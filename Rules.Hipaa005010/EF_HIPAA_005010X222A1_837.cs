namespace EdiFabric.Rules.HIPAA_005010X222A1_837
{
    using System;
    using System.Xml;
    using System.Xml.Serialization;
    using System.Collections.Generic;
    using EdiFabric.Attributes;
    
    
    [M("X12", "005010X222A1", "837")]
    public class TS837 : IEdiMessage
    {
        
        /// <summary>
        /// Transaction Set Header
        /// </summary>
        [S("ST", 1, typeof(X12_ID_143))]
        public ST ST { get; set; }
        [S("BHT", 2, typeof(X12_ID_1005), typeof(X12_ID_353))]
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
    
    [E(",837,")]
    public class X12_ID_143
    {
    }
    
    public class X12_AN
    {
    }
    
    [E(",0019,")]
    public class X12_ID_1005
    {
    }
    
    [E(",00,18,")]
    public class X12_ID_353
    {
    }
    
    public class X12_N0
    {
    }
    
    public class SE
    {
        
        [D(1, "96")]
        public string TransactionSegmentCount_01 { get; set; }
        [D(2, "329")]
        public string TransactionSetControlNumber_02 { get; set; }
    }
    
    public class Loop_2000A
    {
        
        [S("HL", 1)]
        public HL_BillingProviderHierarchicalLevel HL_BillingProviderHierarchicalLevel { get; set; }
        [S("PRV", 2, typeof(X12_ID_1221), typeof(X12_ID_128))]
        public PRV_BillingProviderSpecialtyInformation PRV_BillingProviderSpecialtyInformation { get; set; }
        [S("CUR", 3, typeof(X12_ID_98_4))]
        public CUR_ForeignCurrencyInformation CUR_ForeignCurrencyInformation { get; set; }
        [A(4)]
        public All_NM1_2 All_NM1_2 { get; set; }
        [G(5)]
        public List<Loop_2000B> Loop_2000B { get; set; }
    }
    
    [E(",BI,")]
    public class X12_ID_1221
    {
    }
    
    [E(",PXC,")]
    public class X12_ID_128
    {
    }
    
    [E(",85,")]
    public class X12_ID_98_4
    {
    }
    
    public class X12_ID
    {
    }
    
    public class Loop_2000B
    {
        
        [S("HL", 1)]
        public HL_SubscriberHierarchicalLevel HL_SubscriberHierarchicalLevel { get; set; }
        [S("SBR", 2, typeof(X12_ID_1138), typeof(X12_ID_1069))]
        public SBR_SubscriberInformation SBR_SubscriberInformation { get; set; }
        [S("PAT", 3, typeof(X12_ID_1069_2), typeof(X12_ID_1384))]
        public PAT_PatientInformation PAT_PatientInformation { get; set; }
        [A(4)]
        public All_NM1_3 All_NM1_3 { get; set; }
        [G(5)]
        public List<Loop_2300> Loop_2300 { get; set; }
        [G(6)]
        public List<Loop_2000C> Loop_2000C { get; set; }
    }
    
    [E(",A,B,C,D,E,F,G,H,P,S,T,U,")]
    public class X12_ID_1138
    {
    }
    
    [E(",18,")]
    public class X12_ID_1069
    {
    }
    
    [E(@",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,36,37,38,39,40,41,43,45,46,47,48,49,50,51,52,53,55,56,57,58,59,60,61,62,63,64,65,66,67,68,70,71,72,73,74,75,76,78,79,80,81,82,83,84,86,87,88,90,91,92,93,94,95,96,97,98,99,A1,A2,A3,A4,A5,A6,A7,A8,A9,B1,B2,B3,B4,B5,B6,B7,B8,B9,C1,C2,C3,C4,C5,C8,C9,D1,D2,D3,D4,D5,D6,D7,D8,D9,E1,E2,E3,E4,E5,E6,E7,E8,E9,F1,F2,F3,F6,F7,F8,F9,G2,G3,G4,G5,G6,G7,G8,G9,H1,H4,N1,OT,ZZ,")]
    public class X12_ID_1069_2
    {
    }
    
    [E(",A,B,C,D,E,F,G,H,L,M,O,P,R,S,T,")]
    public class X12_ID_1384
    {
    }
    
    public class Loop_2000C
    {
        
        [S("HL", 1)]
        public HL_PatientHierarchicalLevel HL_PatientHierarchicalLevel { get; set; }
        [S("PAT", 2, typeof(X12_ID_1069_4), typeof(X12_ID_1384))]
        public PAT_PatientInformation_2 PAT_PatientInformation_2 { get; set; }
        [G(3)]
        public Loop_2010CA Loop_2010CA { get; set; }
        [G(4)]
        public List<Loop_2300_2> Loop_2300_2 { get; set; }
    }
    
    [E(",01,19,20,21,39,40,53,G8,")]
    public class X12_ID_1069_4
    {
    }
    
    public class Loop_2300_2
    {
        
        [S("CLM", 1)]
        public CLM_ClaimInformation_2 CLM_ClaimInformation_2 { get; set; }
        [A(2)]
        public All_DTP_3 All_DTP_3 { get; set; }
        [S("PWK", 3, typeof(X12_ID_755), typeof(X12_ID_756))]
        public List<PWK_ClaimSupplementalInformation_2> PWK_ClaimSupplementalInformation_2 { get; set; }
        [S("CN1", 4, typeof(X12_ID_1166))]
        public CN1_ContractInformation_3 CN1_ContractInformation_3 { get; set; }
        [S("AMT", 5, typeof(X12_ID_522))]
        public AMT_PatientAmountPaid_2 AMT_PatientAmountPaid_2 { get; set; }
        [A(6)]
        public All_REF_9 All_REF_9 { get; set; }
        [S("K3", 7)]
        public List<K3_FileInformation_3> K3_FileInformation_3 { get; set; }
        [S("NTE", 8, typeof(X12_ID_363))]
        public NTE_ClaimNote_2 NTE_ClaimNote_2 { get; set; }
        [S("CR1", 9, typeof(X12_ID_355_3))]
        public CR1_AmbulanceTransportInformation_3 CR1_AmbulanceTransportInformation_3 { get; set; }
        [S("CR2", 10)]
        public CR2_SpinalManipulationServiceInformation_2 CR2_SpinalManipulationServiceInformation_2 { get; set; }
        [A(11)]
        public All_CRC_3 All_CRC_3 { get; set; }
        [A(12)]
        public All_HI_2 All_HI_2 { get; set; }
        [S("HCP", 13, typeof(X12_ID_1473))]
        public HCP_ClaimPricing_RepricingInformation_2 HCP_ClaimPricing_RepricingInformation_2 { get; set; }
        [A(14)]
        public All_NM1_7 All_NM1_7 { get; set; }
        [G(15)]
        public List<Loop_2320_2> Loop_2320_2 { get; set; }
        [G(16)]
        public List<Loop_2400_2> Loop_2400_2 { get; set; }
    }
    
    public class X12_R
    {
    }
    
    [E(",03,04,05,06,07,08,09,10,11,13,15,21,77,A3,A4,AM,AS,B2,B3,B4,BR,BS,BT,CB,CK,CT,D2" +
        ",DA,DB,DG,DJ,DS,EB,HC,HR,I5,IR,LA,M1,MT,NN,OB,OC,OD,OE,OX,OZ,P4,P5,PE,PN,PO,PQ,P" +
        "Y,PZ,RB,RR,RT,RX,SG,V5,XP,")]
    public class X12_ID_755
    {
    }
    
    [E(",AA,BM,EL,EM,FT,FX,")]
    public class X12_ID_756
    {
    }
    
    [E(",01,02,03,04,05,06,09,")]
    public class X12_ID_1166
    {
    }
    
    [E(",F5,")]
    public class X12_ID_522
    {
    }
    
    [E(",C,D,E,F,P,S,")]
    public class X12_ID_1333
    {
    }
    
    [E(",ADD,CER,DCP,DGN,TPO,")]
    public class X12_ID_363
    {
    }
    
    [E(",LB,")]
    public class X12_ID_355_3
    {
    }
    
    [E(",00,01,02,03,04,05,07,08,09,10,11,12,13,14,")]
    public class X12_ID_1473
    {
    }
    
    public class Loop_2400_2
    {
        
        [S("LX", 1)]
        public LX_ServiceLineNumber_2 LX_ServiceLineNumber_2 { get; set; }
        [S("SV1", 2, typeof(X12_ID_235_2))]
        public SV1_ProfessionalService_2 SV1_ProfessionalService_2 { get; set; }
        [S("SV5", 3, typeof(X12_ID_235_3), typeof(X12_ID_355_6))]
        public SV5_DurableMedicalEquipmentService_2 SV5_DurableMedicalEquipmentService_2 { get; set; }
        [A(4)]
        public All_PWK_2 All_PWK_2 { get; set; }
        [S("CR1", 5, typeof(X12_ID_355_3))]
        public CR1_AmbulanceTransportInformation_4 CR1_AmbulanceTransportInformation_4 { get; set; }
        [S("CR3", 6, typeof(X12_ID_1322), typeof(X12_ID_355_7))]
        public CR3_DurableMedicalEquipmentCertification_2 CR3_DurableMedicalEquipmentCertification_2 { get; set; }
        [A(7)]
        public All_CRC_4 All_CRC_4 { get; set; }
        [A(8)]
        public All_DTP_4 All_DTP_4 { get; set; }
        [A(9)]
        public All_QTY_2 All_QTY_2 { get; set; }
        [S("MEA", 10, typeof(X12_ID_737), typeof(X12_ID_738))]
        public List<MEA_TestResult_2> MEA_TestResult_2 { get; set; }
        [S("CN1", 11, typeof(X12_ID_1166))]
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
        [S("HCP", 17, typeof(X12_ID_1473_2))]
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
    
    [E(",ER,HC,IV,WK,")]
    public class X12_ID_235_2
    {
    }
    
    [E(",HC,")]
    public class X12_ID_235_3
    {
    }
    
    [E(",DA,")]
    public class X12_ID_355_6
    {
    }
    
    [E(",I,R,S,")]
    public class X12_ID_1322
    {
    }
    
    [E(",MO,")]
    public class X12_ID_355_7
    {
    }
    
    [E(",OG,TR,")]
    public class X12_ID_737
    {
    }
    
    [E(",HT,R1,R2,R3,R4,")]
    public class X12_ID_738
    {
    }
    
    [E(",00,01,02,03,04,05,06,07,08,09,10,11,12,13,14,")]
    public class X12_ID_1473_2
    {
    }
    
    public class Loop_2440_2
    {
        
        [S("LQ", 1, typeof(X12_ID_1270_7))]
        public LQ_FormIdentificationCode_2 LQ_FormIdentificationCode_2 { get; set; }
        [S("FRM", 2)]
        public List<FRM_SupportingDocumentation_2> FRM_SupportingDocumentation_2 { get; set; }
    }
    
    [E(",AS,UT,")]
    public class X12_ID_1270_7
    {
    }
    
    [E(",N,W,Y,")]
    public class X12_ID_1073_4
    {
    }
    
    public class FRM_SupportingDocumentation_2
    {
        
        [D(1, "350")]
        public string QuestionNumberLetter_01 { get; set; }
        [D(2, "1073")]
        public string QuestionResponse_02 { get; set; }
        [D(3, "127")]
        public string QuestionResponse_03 { get; set; }
        [D(4, "373")]
        public string QuestionResponse_04 { get; set; }
        [D(5, "332")]
        public string QuestionResponse_05 { get; set; }
    }
    
    public class LQ_FormIdentificationCode_2
    {
        
        [D(1, "1270")]
        public string CodeListQualifierCode_01 { get; set; }
        [D(2, "1271")]
        public string FormIdentifier_02 { get; set; }
    }
    
    public class Loop_2430_2
    {
        
        [S("SVD", 1)]
        public SVD_LineAdjudicationInformation_2 SVD_LineAdjudicationInformation_2 { get; set; }
        [S("CAS", 2, typeof(X12_ID_1033))]
        public List<CAS_LineAdjustment_2> CAS_LineAdjustment_2 { get; set; }
        [S("DTP", 3, typeof(X12_ID_374_18), typeof(X12_ID_1250))]
        public DTP_LineCheckorRemittanceDate_2 DTP_LineCheckorRemittanceDate_2 { get; set; }
        [S("AMT", 4, typeof(X12_ID_522_4))]
        public AMT_RemainingPatientLiability_4 AMT_RemainingPatientLiability_4 { get; set; }
    }
    
    [E(",CO,CR,OA,PI,PR,")]
    public class X12_ID_1033
    {
    }
    
    [E(",573,")]
    public class X12_ID_374_18
    {
    }
    
    [E(",D8,")]
    public class X12_ID_1250
    {
    }
    
    [E(",EAF,")]
    public class X12_ID_522_4
    {
    }
    
    public class AMT_RemainingPatientLiability_4
    {
        
        [D(1, "522")]
        public string AmountQualifierCode_01 { get; set; }
        [D(2, "782")]
        public string RemainingPatientLiability_02 { get; set; }
        [D(3, "478")]
        public string CreditDebitFlagCode_03 { get; set; }
    }
    
    public class DTP_LineCheckorRemittanceDate_2
    {
        
        [D(1, "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, "1251")]
        public string AdjudicationorPaymentDate_03 { get; set; }
    }
    
    public class CAS_LineAdjustment_2
    {
        
        [D(1, "1033")]
        public string ClaimAdjustmentGroupCode_01 { get; set; }
        [D(2, "1034")]
        public string AdjustmentReasonCode_02 { get; set; }
        [D(3, "782")]
        public string AdjustmentAmount_03 { get; set; }
        [D(4, "380")]
        public string AdjustmentQuantity_04 { get; set; }
        [D(5, "1034")]
        public string AdjustmentReasonCode_05 { get; set; }
        [D(6, "782")]
        public string AdjustmentAmount_06 { get; set; }
        [D(7, "380")]
        public string AdjustmentQuantity_07 { get; set; }
        [D(8, "1034")]
        public string AdjustmentReasonCode_08 { get; set; }
        [D(9, "782")]
        public string AdjustmentAmount_09 { get; set; }
        [D(10, "380")]
        public string AdjustmentQuantity_10 { get; set; }
        [D(11, "1034")]
        public string AdjustmentReasonCode_11 { get; set; }
        [D(12, "782")]
        public string AdjustmentAmount_12 { get; set; }
        [D(13, "380")]
        public string AdjustmentQuantity_13 { get; set; }
        [D(14, "1034")]
        public string AdjustmentReasonCode_14 { get; set; }
        [D(15, "782")]
        public string AdjustmentAmount_15 { get; set; }
        [D(16, "380")]
        public string AdjustmentQuantity_16 { get; set; }
        [D(17, "1034")]
        public string AdjustmentReasonCode_17 { get; set; }
        [D(18, "782")]
        public string AdjustmentAmount_18 { get; set; }
        [D(19, "380")]
        public string AdjustmentQuantity_19 { get; set; }
    }
    
    public class SVD_LineAdjudicationInformation_2
    {
        
        [D(1, "67")]
        public string OtherPayerPrimaryIdentifier_01 { get; set; }
        [D(2, "782")]
        public string ServiceLinePaidAmount_02 { get; set; }
        [C(3)]
        public C003_CompositeMedicalProcedureIdentifier_6 CompositeMedicalProcedureIdentifier_03 { get; set; }
        [D(4, "234")]
        public string ProductServiceID_04 { get; set; }
        [D(5, "380")]
        public string PaidServiceUnitCount_05 { get; set; }
        [D(6, "554")]
        public string BundledorUnbundledLineNumber_06 { get; set; }
    }
    
    public class C003_CompositeMedicalProcedureIdentifier_6
    {
        
        [D(1, "235")]
        public string ProductorServiceIDQualifier_01 { get; set; }
        [D(2, "234")]
        public string ProcedureCode_02 { get; set; }
        [D(3, "1339")]
        public string ProcedureModifier_03 { get; set; }
        [D(4, "1339")]
        public string ProcedureModifier_04 { get; set; }
        [D(5, "1339")]
        public string ProcedureModifier_05 { get; set; }
        [D(6, "1339")]
        public string ProcedureModifier_06 { get; set; }
        [D(7, "352")]
        public string ProcedureCodeDescription_07 { get; set; }
        [D(8, "234")]
        public string ProductServiceID_08 { get; set; }
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
        
        [S("NM1", 1, typeof(X12_ID_98_14), typeof(X12_ID_1065_2))]
        public NM1_AmbulanceDrop_offLocation_4 NM1_AmbulanceDrop_offLocation_4 { get; set; }
        [S("N3", 2)]
        public N3_AmbulanceDrop_offLocationAddress_4 N3_AmbulanceDrop_offLocationAddress_4 { get; set; }
        [S("N4", 3)]
        public N4_AmbulanceDrop_offLocationCity_State_ZipCode_4 N4_AmbulanceDrop_offLocationCity_State_ZipCode_4 { get; set; }
    }
    
    [E(",45,")]
    public class X12_ID_98_14
    {
    }
    
    [E(",2,")]
    public class X12_ID_1065_2
    {
    }
    
    public class N4_AmbulanceDrop_offLocationCity_State_ZipCode_4
    {
        
        [D(1, "19")]
        public string AmbulanceDropoffCityName_01 { get; set; }
        [D(2, "156")]
        public string AmbulanceDropoffStateorProvinceCode_02 { get; set; }
        [D(3, "116")]
        public string AmbulanceDropoffPostalZoneorZIPCode_03 { get; set; }
        [D(4, "26")]
        public string CountryCode_04 { get; set; }
        [D(5, "309")]
        public string LocationQualifier_05 { get; set; }
        [D(6, "310")]
        public string LocationIdentifier_06 { get; set; }
        [D(7, "1715")]
        public string CountrySubdivisionCode_07 { get; set; }
    }
    
    public class N3_AmbulanceDrop_offLocationAddress_4
    {
        
        [D(1, "166")]
        public string AmbulanceDropoffAddressLine_01 { get; set; }
        [D(2, "166")]
        public string AmbulanceDropoffAddressLine_02 { get; set; }
    }
    
    public class NM1_AmbulanceDrop_offLocation_4
    {
        
        [D(1, "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, "1035")]
        public string AmbulanceDropoffLocation_03 { get; set; }
        [D(4, "1036")]
        public string NameFirst_04 { get; set; }
        [D(5, "1037")]
        public string NameMiddle_05 { get; set; }
        [D(6, "1038")]
        public string NamePrefix_06 { get; set; }
        [D(7, "1039")]
        public string NameSuffix_07 { get; set; }
        [D(8, "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, "67")]
        public string IdentificationCode_09 { get; set; }
        [D(10, "706")]
        public string EntityRelationshipCode_10 { get; set; }
        [D(11, "98")]
        public string EntityIdentifierCode_11 { get; set; }
        [D(12, "1035")]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    public class Loop_2420G_2
    {
        
        [S("NM1", 1, typeof(X12_ID_98_13), typeof(X12_ID_1065_2))]
        public NM1_AmbulancePick_upLocation_4 NM1_AmbulancePick_upLocation_4 { get; set; }
        [S("N3", 2)]
        public N3_AmbulancePick_upLocationAddress_4 N3_AmbulancePick_upLocationAddress_4 { get; set; }
        [S("N4", 3)]
        public N4_AmbulancePick_upLocationCity_State_ZipCode_4 N4_AmbulancePick_upLocationCity_State_ZipCode_4 { get; set; }
    }
    
    [E(",PW,")]
    public class X12_ID_98_13
    {
    }
    
    public class N4_AmbulancePick_upLocationCity_State_ZipCode_4
    {
        
        [D(1, "19")]
        public string AmbulancePickupCityName_01 { get; set; }
        [D(2, "156")]
        public string AmbulancePickupStateorProvinceCode_02 { get; set; }
        [D(3, "116")]
        public string AmbulancePickupPostalZoneorZIPCode_03 { get; set; }
        [D(4, "26")]
        public string CountryCode_04 { get; set; }
        [D(5, "309")]
        public string LocationQualifier_05 { get; set; }
        [D(6, "310")]
        public string LocationIdentifier_06 { get; set; }
        [D(7, "1715")]
        public string CountrySubdivisionCode_07 { get; set; }
    }
    
    public class N3_AmbulancePick_upLocationAddress_4
    {
        
        [D(1, "166")]
        public string AmbulancePickupAddressLine_01 { get; set; }
        [D(2, "166")]
        public string AmbulancePickupAddressLine_02 { get; set; }
    }
    
    public class NM1_AmbulancePick_upLocation_4
    {
        
        [D(1, "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, "1035")]
        public string NameLastorOrganizationName_03 { get; set; }
        [D(4, "1036")]
        public string NameFirst_04 { get; set; }
        [D(5, "1037")]
        public string NameMiddle_05 { get; set; }
        [D(6, "1038")]
        public string NamePrefix_06 { get; set; }
        [D(7, "1039")]
        public string NameSuffix_07 { get; set; }
        [D(8, "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, "67")]
        public string IdentificationCode_09 { get; set; }
        [D(10, "706")]
        public string EntityRelationshipCode_10 { get; set; }
        [D(11, "98")]
        public string EntityIdentifierCode_11 { get; set; }
        [D(12, "1035")]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    public class Loop_2420F_2
    {
        
        [S("NM1", 1, typeof(X12_ID_98_9), typeof(X12_ID_1065_3))]
        public NM1_ReferringProviderName_4 NM1_ReferringProviderName_4 { get; set; }
        [S("REF", 2, typeof(X12_ID_128_25))]
        public List<REF_ReferringProviderSecondaryIdentification_4> REF_ReferringProviderSecondaryIdentification_4 { get; set; }
    }
    
    [E(",DN,P3,")]
    public class X12_ID_98_9
    {
    }
    
    [E(",1,")]
    public class X12_ID_1065_3
    {
    }
    
    [E(",0B,1G,G2,")]
    public class X12_ID_128_25
    {
    }
    
    public class REF_ReferringProviderSecondaryIdentification_4
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string ReferringProviderSecondaryIdentifier_02 { get; set; }
        [D(3, "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_100 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_100
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string OtherPayerPrimaryIdentifier_02 { get; set; }
        [D(3, "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class NM1_ReferringProviderName_4
    {
        
        [D(1, "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, "1035")]
        public string ReferringProviderLastName_03 { get; set; }
        [D(4, "1036")]
        public string ReferringProviderFirstName_04 { get; set; }
        [D(5, "1037")]
        public string ReferringProviderMiddleNameorInitial_05 { get; set; }
        [D(6, "1038")]
        public string NamePrefix_06 { get; set; }
        [D(7, "1039")]
        public string ReferringProviderNameSuffix_07 { get; set; }
        [D(8, "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, "67")]
        public string ReferringProviderIdentifier_09 { get; set; }
        [D(10, "706")]
        public string EntityRelationshipCode_10 { get; set; }
        [D(11, "98")]
        public string EntityIdentifierCode_11 { get; set; }
        [D(12, "1035")]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    public class Loop_2420E_2
    {
        
        [S("NM1", 1, typeof(X12_ID_98_16), typeof(X12_ID_1065_3))]
        public NM1_OrderingProviderName_2 NM1_OrderingProviderName_2 { get; set; }
        [S("N3", 2)]
        public N3_OrderingProviderAddress_2 N3_OrderingProviderAddress_2 { get; set; }
        [S("N4", 3)]
        public N4_OrderingProviderCity_State_ZIPCode_2 N4_OrderingProviderCity_State_ZIPCode_2 { get; set; }
        [S("REF", 4, typeof(X12_ID_128_25))]
        public List<REF_OrderingProviderSecondaryIdentification_2> REF_OrderingProviderSecondaryIdentification_2 { get; set; }
        [S("PER", 5, typeof(X12_ID_366))]
        public PER_OrderingProviderContactInformation_2 PER_OrderingProviderContactInformation_2 { get; set; }
    }
    
    [E(",DK,")]
    public class X12_ID_98_16
    {
    }
    
    [E(",IC,")]
    public class X12_ID_366
    {
    }
    
    public class PER_OrderingProviderContactInformation_2
    {
        
        [D(1, "366")]
        public string ContactFunctionCode_01 { get; set; }
        [D(2, "93")]
        public string OrderingProviderContactName_02 { get; set; }
        [D(3, "365")]
        public string CommunicationNumberQualifier_03 { get; set; }
        [D(4, "364")]
        public string CommunicationNumber_04 { get; set; }
        [D(5, "365")]
        public string CommunicationNumberQualifier_05 { get; set; }
        [D(6, "364")]
        public string CommunicationNumber_06 { get; set; }
        [D(7, "365")]
        public string CommunicationNumberQualifier_07 { get; set; }
        [D(8, "364")]
        public string CommunicationNumber_08 { get; set; }
        [D(9, "443")]
        public string ContactInquiryReference_09 { get; set; }
    }
    
    public class REF_OrderingProviderSecondaryIdentification_2
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string OrderingProviderSecondaryIdentifier_02 { get; set; }
        [D(3, "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_99 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_99
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string OtherPayerPrimaryIdentifier_02 { get; set; }
        [D(3, "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class N4_OrderingProviderCity_State_ZIPCode_2
    {
        
        [D(1, "19")]
        public string OrderingProviderCityName_01 { get; set; }
        [D(2, "156")]
        public string OrderingProviderStateorProvinceCode_02 { get; set; }
        [D(3, "116")]
        public string OrderingProviderPostalZoneorZIPCode_03 { get; set; }
        [D(4, "26")]
        public string CountryCode_04 { get; set; }
        [D(5, "309")]
        public string LocationQualifier_05 { get; set; }
        [D(6, "310")]
        public string LocationIdentifier_06 { get; set; }
        [D(7, "1715")]
        public string CountrySubdivisionCode_07 { get; set; }
    }
    
    public class N3_OrderingProviderAddress_2
    {
        
        [D(1, "166")]
        public string OrderingProviderAddressLine_01 { get; set; }
        [D(2, "166")]
        public string OrderingProviderAddressLine_02 { get; set; }
    }
    
    public class NM1_OrderingProviderName_2
    {
        
        [D(1, "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, "1035")]
        public string OrderingProviderLastName_03 { get; set; }
        [D(4, "1036")]
        public string OrderingProviderFirstName_04 { get; set; }
        [D(5, "1037")]
        public string OrderingProviderMiddleNameorInitial_05 { get; set; }
        [D(6, "1038")]
        public string NamePrefix_06 { get; set; }
        [D(7, "1039")]
        public string OrderingProviderNameSuffix_07 { get; set; }
        [D(8, "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, "67")]
        public string OrderingProviderIdentifier_09 { get; set; }
        [D(10, "706")]
        public string EntityRelationshipCode_10 { get; set; }
        [D(11, "98")]
        public string EntityIdentifierCode_11 { get; set; }
        [D(12, "1035")]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    public class Loop_2420D_2
    {
        
        [S("NM1", 1, typeof(X12_ID_98_12), typeof(X12_ID_1065_3))]
        public NM1_SupervisingProviderName_4 NM1_SupervisingProviderName_4 { get; set; }
        [S("REF", 2, typeof(X12_ID_128_26))]
        public List<REF_SupervisingProviderSecondaryIdentification_4> REF_SupervisingProviderSecondaryIdentification_4 { get; set; }
    }
    
    [E(",DQ,")]
    public class X12_ID_98_12
    {
    }
    
    [E(",0B,1G,G2,LU,")]
    public class X12_ID_128_26
    {
    }
    
    public class REF_SupervisingProviderSecondaryIdentification_4
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string SupervisingProviderSecondaryIdentifier_02 { get; set; }
        [D(3, "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_98 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_98
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string OtherPayerPrimaryIdentifier_02 { get; set; }
        [D(3, "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class NM1_SupervisingProviderName_4
    {
        
        [D(1, "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, "1035")]
        public string SupervisingProviderLastName_03 { get; set; }
        [D(4, "1036")]
        public string SupervisingProviderFirstName_04 { get; set; }
        [D(5, "1037")]
        public string SupervisingProviderMiddleNameorInitial_05 { get; set; }
        [D(6, "1038")]
        public string NamePrefix_06 { get; set; }
        [D(7, "1039")]
        public string SupervisingProviderNameSuffix_07 { get; set; }
        [D(8, "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, "67")]
        public string SupervisingProviderIdentifier_09 { get; set; }
        [D(10, "706")]
        public string EntityRelationshipCode_10 { get; set; }
        [D(11, "98")]
        public string EntityIdentifierCode_11 { get; set; }
        [D(12, "1035")]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    public class Loop_2420C_2
    {
        
        [S("NM1", 1, typeof(X12_ID_98_11), typeof(X12_ID_1065_2))]
        public NM1_ServiceFacilityLocation_2 NM1_ServiceFacilityLocation_2 { get; set; }
        [S("N3", 2)]
        public N3_ServiceFacilityLocationAddress_4 N3_ServiceFacilityLocationAddress_4 { get; set; }
        [S("N4", 3)]
        public N4_ServiceFacilityLocationCity_State_ZIPCode_4 N4_ServiceFacilityLocationCity_State_ZIPCode_4 { get; set; }
        [S("REF", 4, typeof(X12_ID_128_10))]
        public List<REF_ServiceFacilityLocationSecondaryIdentification_4> REF_ServiceFacilityLocationSecondaryIdentification_4 { get; set; }
    }
    
    [E(",77,")]
    public class X12_ID_98_11
    {
    }
    
    [E(",G2,LU,")]
    public class X12_ID_128_10
    {
    }
    
    public class REF_ServiceFacilityLocationSecondaryIdentification_4
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string ServiceFacilityLocationSecondaryIdentifier_02 { get; set; }
        [D(3, "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_97 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_97
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string OtherPayerPrimaryIdentifier_02 { get; set; }
        [D(3, "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class N4_ServiceFacilityLocationCity_State_ZIPCode_4
    {
        
        [D(1, "19")]
        public string LaboratoryorFacilityCityName_01 { get; set; }
        [D(2, "156")]
        public string LaboratoryorFacilityStateorProvinceCode_02 { get; set; }
        [D(3, "116")]
        public string LaboratoryorFacilityPostalZoneorZIPCode_03 { get; set; }
        [D(4, "26")]
        public string CountryCode_04 { get; set; }
        [D(5, "309")]
        public string LocationQualifier_05 { get; set; }
        [D(6, "310")]
        public string LocationIdentifier_06 { get; set; }
        [D(7, "1715")]
        public string CountrySubdivisionCode_07 { get; set; }
    }
    
    public class N3_ServiceFacilityLocationAddress_4
    {
        
        [D(1, "166")]
        public string LaboratoryorFacilityAddressLine_01 { get; set; }
        [D(2, "166")]
        public string LaboratoryorFacilityAddressLine_02 { get; set; }
    }
    
    public class NM1_ServiceFacilityLocation_2
    {
        
        [D(1, "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, "1035")]
        public string LaboratoryorFacilityName_03 { get; set; }
        [D(4, "1036")]
        public string NameFirst_04 { get; set; }
        [D(5, "1037")]
        public string NameMiddle_05 { get; set; }
        [D(6, "1038")]
        public string NamePrefix_06 { get; set; }
        [D(7, "1039")]
        public string NameSuffix_07 { get; set; }
        [D(8, "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, "67")]
        public string LaboratoryorFacilityPrimaryIdentifier_09 { get; set; }
        [D(10, "706")]
        public string EntityRelationshipCode_10 { get; set; }
        [D(11, "98")]
        public string EntityIdentifierCode_11 { get; set; }
        [D(12, "1035")]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    public class Loop_2420B_2
    {
        
        [S("NM1", 1, typeof(X12_ID_98_15), typeof(X12_ID_1065))]
        public NM1_PurchasedServiceProviderName_2 NM1_PurchasedServiceProviderName_2 { get; set; }
        [S("REF", 2, typeof(X12_ID_128_25))]
        public List<REF_PurchasedServiceProviderSecondaryIdentification_2> REF_PurchasedServiceProviderSecondaryIdentification_2 { get; set; }
    }
    
    [E(",QB,")]
    public class X12_ID_98_15
    {
    }
    
    [E(",1,2,")]
    public class X12_ID_1065
    {
    }
    
    public class REF_PurchasedServiceProviderSecondaryIdentification_2
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string PurchasedServiceProviderSecondaryIdentifier_02 { get; set; }
        [D(3, "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_96 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_96
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string OtherPayerPrimaryIdentifier_02 { get; set; }
        [D(3, "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class NM1_PurchasedServiceProviderName_2
    {
        
        [D(1, "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, "1035")]
        public string NameLastorOrganizationName_03 { get; set; }
        [D(4, "1036")]
        public string NameFirst_04 { get; set; }
        [D(5, "1037")]
        public string NameMiddle_05 { get; set; }
        [D(6, "1038")]
        public string NamePrefix_06 { get; set; }
        [D(7, "1039")]
        public string NameSuffix_07 { get; set; }
        [D(8, "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, "67")]
        public string PurchasedServiceProviderIdentifier_09 { get; set; }
        [D(10, "706")]
        public string EntityRelationshipCode_10 { get; set; }
        [D(11, "98")]
        public string EntityIdentifierCode_11 { get; set; }
        [D(12, "1035")]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    public class Loop_2420A_2
    {
        
        [S("NM1", 1, typeof(X12_ID_98_10), typeof(X12_ID_1065))]
        public NM1_RenderingProviderName_4 NM1_RenderingProviderName_4 { get; set; }
        [S("PRV", 2, typeof(X12_ID_1221_2), typeof(X12_ID_128))]
        public PRV_RenderingProviderSpecialtyInformation_4 PRV_RenderingProviderSpecialtyInformation_4 { get; set; }
        [S("REF", 3, typeof(X12_ID_128_26))]
        public List<REF_RenderingProviderSecondaryIdentification_4> REF_RenderingProviderSecondaryIdentification_4 { get; set; }
    }
    
    [E(",82,")]
    public class X12_ID_98_10
    {
    }
    
    [E(",PE,")]
    public class X12_ID_1221_2
    {
    }
    
    public class REF_RenderingProviderSecondaryIdentification_4
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string RenderingProviderSecondaryIdentifier_02 { get; set; }
        [D(3, "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_95 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_95
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string OtherPayerPrimaryIdentifier_02 { get; set; }
        [D(3, "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class PRV_RenderingProviderSpecialtyInformation_4
    {
        
        [D(1, "1221")]
        public string ProviderCode_01 { get; set; }
        [D(2, "128")]
        public string ReferenceIdentificationQualifier_02 { get; set; }
        [D(3, "127")]
        public string ProviderTaxonomyCode_03 { get; set; }
        [D(4, "156")]
        public string StateorProvinceCode_04 { get; set; }
        [C(5)]
        public C035_ProviderSpecialtyInformation_5 ProviderSpecialtyInformation_05 { get; set; }
        [D(6, "1223")]
        public string ProviderOrganizationCode_06 { get; set; }
    }
    
    public class C035_ProviderSpecialtyInformation_5
    {
        
        [D(1, "1222")]
        public string ProviderSpecialtyCode_01 { get; set; }
        [D(2, "559")]
        public string AgencyQualifierCode_02 { get; set; }
        [D(3, "1073")]
        public string YesNoConditionorResponseCode_03 { get; set; }
    }
    
    public class NM1_RenderingProviderName_4
    {
        
        [D(1, "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, "1035")]
        public string RenderingProviderLastorOrganizationName_03 { get; set; }
        [D(4, "1036")]
        public string RenderingProviderFirstName_04 { get; set; }
        [D(5, "1037")]
        public string RenderingProviderMiddleName_05 { get; set; }
        [D(6, "1038")]
        public string NamePrefix_06 { get; set; }
        [D(7, "1039")]
        public string RenderingProviderNameSuffix_07 { get; set; }
        [D(8, "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, "67")]
        public string RenderingProviderIdentifier_09 { get; set; }
        [D(10, "706")]
        public string EntityRelationshipCode_10 { get; set; }
        [D(11, "98")]
        public string EntityIdentifierCode_11 { get; set; }
        [D(12, "1035")]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    public class Loop_2410_2
    {
        
        [S("LIN", 1)]
        public LIN_DrugIdentification_2 LIN_DrugIdentification_2 { get; set; }
        [S("CTP", 2, typeof(X12_ID_687), typeof(X12_ID_236))]
        public CTP_DrugQuantity_2 CTP_DrugQuantity_2 { get; set; }
        [S("REF", 3, typeof(X12_ID_128_35))]
        public REF_PrescriptionorCompoundDrugAssociationNumber_2 REF_PrescriptionorCompoundDrugAssociationNumber_2 { get; set; }
    }
    
    [E(",EN,EO,HI,N4,ON,UK,UP,")]
    public class X12_ID_235_4
    {
    }
    
    [E(",AA,AB,AC,AD,AE,AF,AG,AH,AI,AJ,AL,AM,AN,AO,AP,AQ,AR,AS,BG,BR,CB,CN,CO,CR,CX,CY,DE" +
        ",DF,DI,DR,EX,FS,GA,GM,GR,GV,HS,ID,IN,IR,JB,LC,MC,MF,ML,OE,OF,ON,PF,PH,PT,PY,RS,S" +
        "A,SB,SE,ST,TR,WA,WC,WH,WS,")]
    public class X12_ID_687
    {
    }
    
    [E(@",ACT,AGC,ALT,AWP,BBP,BCH,BID,C01,C02,C03,C04,C05,C06,C07,C08,C09,C10,C11,C12,C13,C14,C15,C16,C17,C18,C19,C20,C21,C22,C23,C24,C25,C26,C27,C28,C29,C30,CAN,CAT,CDF,CDV,CHG,CON,CUP,CUS,D01,D02,D03,DAP,DIS,DPR,DSC,DSD,DSP,EDM,EDP,EDS,EDW,ELC,EST,EUP,FCH,FCP,FDS,FET,FGP,FOR,FSP,FUL,FUP,GAP,GDP,GOV,GSP,GTP,ICL,IND,INS,INV,LAR,LCP,LPP,LPR,MAP,MAS,MAX,MIN,MNC,MNR,MOD,MPR,MSR,MXR,N01,N02,N03,N04,N05,N06,N07,N08,N09,N10,N11,N12,N13,N14,N15,N16,N17,N18,N19,N20,N21,N22,N23,N24,N25,N26,N27,N28,N29,N30,N31,NET,OAP,OPP,PAP,PAQ,PBQ,PBR,PHS,PIE,PLT,PPA,PPD,PRF,PRO,PRP,PUR,QTE,REG,RES,RPA,RPM,RPP,RSH,RTL,SAC,SDP,SFP,SHD,SLP,SPC,SPE,SSP,STA,SUM,SWP,THP,TOT,TRF,UCP,ULC,WAR,WHL,WSP,ZNP,")]
    public class X12_ID_236
    {
    }
    
    [E(",VY,XZ,")]
    public class X12_ID_128_35
    {
    }
    
    public class REF_PrescriptionorCompoundDrugAssociationNumber_2
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string PrescriptionNumber_02 { get; set; }
        [D(3, "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_94 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_94
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class CTP_DrugQuantity_2
    {
        
        [D(1, "687")]
        public string ClassofTradeCode_01 { get; set; }
        [D(2, "236")]
        public string PriceIdentifierCode_02 { get; set; }
        [D(3, "212")]
        public string UnitPrice_03 { get; set; }
        [D(4, "380")]
        public string NationalDrugUnitCount_04 { get; set; }
        [C(5)]
        public C001_CompositeUnitofMeasure_12 CompositeUnitofMeasure_05 { get; set; }
        [D(6, "648")]
        public string PriceMultiplierQualifier_06 { get; set; }
        [D(7, "649")]
        public string Multiplier_07 { get; set; }
        [D(8, "782")]
        public string MonetaryAmount_08 { get; set; }
        [D(9, "639")]
        public string BasisofUnitPriceCode_09 { get; set; }
        [D(10, "499")]
        public string ConditionValue_10 { get; set; }
        [D(11, "289")]
        public string MultiplePriceQuantity_11 { get; set; }
    }
    
    public class C001_CompositeUnitofMeasure_12
    {
        
        [D(1, "355")]
        public string CodeQualifier_01 { get; set; }
        [D(2, "1018")]
        public string Exponent_02 { get; set; }
        [D(3, "649")]
        public string Multiplier_03 { get; set; }
        [D(4, "355")]
        public string UnitorBasisforMeasurementCode_04 { get; set; }
        [D(5, "1018")]
        public string Exponent_05 { get; set; }
        [D(6, "649")]
        public string Multiplier_06 { get; set; }
        [D(7, "355")]
        public string UnitorBasisforMeasurementCode_07 { get; set; }
        [D(8, "1018")]
        public string Exponent_08 { get; set; }
        [D(9, "649")]
        public string Multiplier_09 { get; set; }
        [D(10, "355")]
        public string UnitorBasisforMeasurementCode_10 { get; set; }
        [D(11, "1018")]
        public string Exponent_11 { get; set; }
        [D(12, "649")]
        public string Multiplier_12 { get; set; }
        [D(13, "355")]
        public string UnitorBasisforMeasurementCode_13 { get; set; }
        [D(14, "1018")]
        public string Exponent_14 { get; set; }
        [D(15, "649")]
        public string Multiplier_15 { get; set; }
    }
    
    public class LIN_DrugIdentification_2
    {
        
        [D(1, "350")]
        public string AssignedIdentification_01 { get; set; }
        [D(2, "235")]
        public string ProductorServiceIDQualifier_02 { get; set; }
        [D(3, "234")]
        public string NationalDrugCodeorUniversalProductNumber_03 { get; set; }
        [D(4, "235")]
        public string ProductServiceIDQualifier_04 { get; set; }
        [D(5, "234")]
        public string ProductServiceID_05 { get; set; }
        [D(6, "235")]
        public string ProductServiceIDQualifier_06 { get; set; }
        [D(7, "234")]
        public string ProductServiceID_07 { get; set; }
        [D(8, "235")]
        public string ProductServiceIDQualifier_08 { get; set; }
        [D(9, "234")]
        public string ProductServiceID_09 { get; set; }
        [D(10, "235")]
        public string ProductServiceIDQualifier_10 { get; set; }
        [D(11, "234")]
        public string ProductServiceID_11 { get; set; }
        [D(12, "235")]
        public string ProductServiceIDQualifier_12 { get; set; }
        [D(13, "234")]
        public string ProductServiceID_13 { get; set; }
        [D(14, "235")]
        public string ProductServiceIDQualifier_14 { get; set; }
        [D(15, "234")]
        public string ProductServiceID_15 { get; set; }
        [D(16, "235")]
        public string ProductServiceIDQualifier_16 { get; set; }
        [D(17, "234")]
        public string ProductServiceID_17 { get; set; }
        [D(18, "235")]
        public string ProductServiceIDQualifier_18 { get; set; }
        [D(19, "234")]
        public string ProductServiceID_19 { get; set; }
        [D(20, "235")]
        public string ProductServiceIDQualifier_20 { get; set; }
        [D(21, "234")]
        public string ProductServiceID_21 { get; set; }
        [D(22, "235")]
        public string ProductServiceIDQualifier_22 { get; set; }
        [D(23, "234")]
        public string ProductServiceID_23 { get; set; }
        [D(24, "235")]
        public string ProductServiceIDQualifier_24 { get; set; }
        [D(25, "234")]
        public string ProductServiceID_25 { get; set; }
        [D(26, "235")]
        public string ProductServiceIDQualifier_26 { get; set; }
        [D(27, "234")]
        public string ProductServiceID_27 { get; set; }
        [D(28, "235")]
        public string ProductServiceIDQualifier_28 { get; set; }
        [D(29, "234")]
        public string ProductServiceID_29 { get; set; }
        [D(30, "235")]
        public string ProductServiceIDQualifier_30 { get; set; }
        [D(31, "234")]
        public string ProductServiceID_31 { get; set; }
    }
    
    public class HCP_LinePricing_RepricingInformation_2
    {
        
        [D(1, "1473")]
        public string PricingMethodology_01 { get; set; }
        [D(2, "782")]
        public string RepricedAllowedAmount_02 { get; set; }
        [D(3, "782")]
        public string RepricedSavingAmount_03 { get; set; }
        [D(4, "127")]
        public string RepricingOrganizationIdentifier_04 { get; set; }
        [D(5, "118")]
        public string RepricingPerDiemorFlatRateAmount_05 { get; set; }
        [D(6, "127")]
        public string RepricedApprovedAmbulatoryPatientGroupCode_06 { get; set; }
        [D(7, "782")]
        public string RepricedApprovedAmbulatoryPatientGroupAmount_07 { get; set; }
        [D(8, "234")]
        public string ProductServiceID_08 { get; set; }
        [D(9, "235")]
        public string ProductorServiceIDQualifier_09 { get; set; }
        [D(10, "234")]
        public string RepricedApprovedHCPCSCode_10 { get; set; }
        [D(11, "355")]
        public string UnitorBasisforMeasurementCode_11 { get; set; }
        [D(12, "380")]
        public string RepricedApprovedServiceUnitCount_12 { get; set; }
        [D(13, "901")]
        public string RejectReasonCode_13 { get; set; }
        [D(14, "1526")]
        public string PolicyComplianceCode_14 { get; set; }
        [D(15, "1527")]
        public string ExceptionCode_15 { get; set; }
    }
    
    public class PS1_PurchasedServiceInformation_2
    {
        
        [D(1, "127")]
        public string PurchasedServiceProviderIdentifier_01 { get; set; }
        [D(2, "782")]
        public string PurchasedServiceChargeAmount_02 { get; set; }
        [D(3, "156")]
        public string StateorProvinceCode_03 { get; set; }
    }
    
    public class All_NTE_2
    {
        
        [S("NTE", 1, typeof(X12_ID_363_2))]
        public NTE_LineNote_2 NTE_LineNote_2 { get; set; }
        [S("NTE", 2, typeof(X12_ID_363_3))]
        public NTE_ThirdPartyOrganizationNotes_2 NTE_ThirdPartyOrganizationNotes_2 { get; set; }
    }
    
    [E(",ADD,DCP,")]
    public class X12_ID_363_2
    {
    }
    
    [E(",TPO,")]
    public class X12_ID_363_3
    {
    }
    
    public class NTE_ThirdPartyOrganizationNotes_2
    {
        
        [D(1, "363")]
        public string NoteReferenceCode_01 { get; set; }
        [D(2, "352")]
        public string LineNoteText_02 { get; set; }
    }
    
    public class NTE_LineNote_2
    {
        
        [D(1, "363")]
        public string NoteReferenceCode_01 { get; set; }
        [D(2, "352")]
        public string LineNoteText_02 { get; set; }
    }
    
    public class K3_FileInformation_4
    {
        
        [D(1, "449")]
        public string FixedFormatInformation_01 { get; set; }
        [D(2, "1333")]
        public string RecordFormatCode_02 { get; set; }
        [C(3)]
        public C001_CompositeUnitofMeasure_11 CompositeUnitofMeasure_03 { get; set; }
    }
    
    public class C001_CompositeUnitofMeasure_11
    {
        
        [D(1, "355")]
        public string UnitorBasisforMeasurementCode_01 { get; set; }
        [D(2, "1018")]
        public string Exponent_02 { get; set; }
        [D(3, "649")]
        public string Multiplier_03 { get; set; }
        [D(4, "355")]
        public string UnitorBasisforMeasurementCode_04 { get; set; }
        [D(5, "1018")]
        public string Exponent_05 { get; set; }
        [D(6, "649")]
        public string Multiplier_06 { get; set; }
        [D(7, "355")]
        public string UnitorBasisforMeasurementCode_07 { get; set; }
        [D(8, "1018")]
        public string Exponent_08 { get; set; }
        [D(9, "649")]
        public string Multiplier_09 { get; set; }
        [D(10, "355")]
        public string UnitorBasisforMeasurementCode_10 { get; set; }
        [D(11, "1018")]
        public string Exponent_11 { get; set; }
        [D(12, "649")]
        public string Multiplier_12 { get; set; }
        [D(13, "355")]
        public string UnitorBasisforMeasurementCode_13 { get; set; }
        [D(14, "1018")]
        public string Exponent_14 { get; set; }
        [D(15, "649")]
        public string Multiplier_15 { get; set; }
    }
    
    public class All_AMT_4
    {
        
        [S("AMT", 1, typeof(X12_ID_522_5))]
        public AMT_SalesTaxAmount_2 AMT_SalesTaxAmount_2 { get; set; }
        [S("AMT", 2, typeof(X12_ID_522_6))]
        public AMT_PostageClaimedAmount_2 AMT_PostageClaimedAmount_2 { get; set; }
    }
    
    [E(",T,")]
    public class X12_ID_522_5
    {
    }
    
    [E(",F4,")]
    public class X12_ID_522_6
    {
    }
    
    public class AMT_PostageClaimedAmount_2
    {
        
        [D(1, "522")]
        public string AmountQualifierCode_01 { get; set; }
        [D(2, "782")]
        public string PostageClaimedAmount_02 { get; set; }
        [D(3, "478")]
        public string CreditDebitFlagCode_03 { get; set; }
    }
    
    public class AMT_SalesTaxAmount_2
    {
        
        [D(1, "522")]
        public string AmountQualifierCode_01 { get; set; }
        [D(2, "782")]
        public string SalesTaxAmount_02 { get; set; }
        [D(3, "478")]
        public string CreditDebitFlagCode_03 { get; set; }
    }
    
    public class All_REF_11
    {
        
        [S("REF", 1, typeof(X12_ID_128_29))]
        public REF_RepricedLineItemReferenceNumber_2 REF_RepricedLineItemReferenceNumber_2 { get; set; }
        [S("REF", 2, typeof(X12_ID_128_30))]
        public REF_AdjustedRepricedLineItemReferenceNumber_2 REF_AdjustedRepricedLineItemReferenceNumber_2 { get; set; }
        [S("REF", 3, typeof(X12_ID_128_15))]
        public List<REF_PriorAuthorization_4> REF_PriorAuthorization_4 { get; set; }
        [S("REF", 4, typeof(X12_ID_128_32))]
        public REF_LineItemControlNumber_2 REF_LineItemControlNumber_2 { get; set; }
        [S("REF", 5, typeof(X12_ID_128_13))]
        public REF_MammographyCertificationNumber_4 REF_MammographyCertificationNumber_4 { get; set; }
        [S("REF", 6, typeof(X12_ID_128_17))]
        public REF_ClinicalLaboratoryImprovementAmendment_CLIA_Number_4 REF_ClinicalLaboratoryImprovementAmendment_CLIA_Number_4 { get; set; }
        [S("REF", 7, typeof(X12_ID_128_33))]
        public REF_ReferringClinicalLaboratoryImprovementAmendment_CLIA_FacilityIdentification_2 REF_ReferringClinicalLaboratoryImprovementAmendment_CLIA_FacilityIdentification_2 { get; set; }
        [S("REF", 8, typeof(X12_ID_128_34))]
        public REF_ImmunizationBatchNumber_2 REF_ImmunizationBatchNumber_2 { get; set; }
        [S("REF", 9, typeof(X12_ID_128_14))]
        public List<REF_ReferralNumber_4> REF_ReferralNumber_4 { get; set; }
    }
    
    [E(",9B,")]
    public class X12_ID_128_29
    {
    }
    
    [E(",9D,")]
    public class X12_ID_128_30
    {
    }
    
    [E(",G1,")]
    public class X12_ID_128_15
    {
    }
    
    [E(",6R,")]
    public class X12_ID_128_32
    {
    }
    
    [E(",EW,")]
    public class X12_ID_128_13
    {
    }
    
    [E(",X4,")]
    public class X12_ID_128_17
    {
    }
    
    [E(",F4,")]
    public class X12_ID_128_33
    {
    }
    
    [E(",BT,")]
    public class X12_ID_128_34
    {
    }
    
    [E(",9F,")]
    public class X12_ID_128_14
    {
    }
    
    public class REF_ReferralNumber_4
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string ReferralNumber_02 { get; set; }
        [D(3, "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_93 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_93
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string OtherPayerPrimaryIdentifier_02 { get; set; }
        [D(3, "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_ImmunizationBatchNumber_2
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string ImmunizationBatchNumber_02 { get; set; }
        [D(3, "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_92 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_92
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_ReferringClinicalLaboratoryImprovementAmendment_CLIA_FacilityIdentification_2
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string ReferringCLIANumber_02 { get; set; }
        [D(3, "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_91 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_91
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_ClinicalLaboratoryImprovementAmendment_CLIA_Number_4
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string ClinicalLaboratoryImprovementAmendmentNumber_02 { get; set; }
        [D(3, "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_90 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_90
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_MammographyCertificationNumber_4
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string MammographyCertificationNumber_02 { get; set; }
        [D(3, "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_89 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_89
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_LineItemControlNumber_2
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string LineItemControlNumber_02 { get; set; }
        [D(3, "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_88 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_88
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_PriorAuthorization_4
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string PriorAuthorizationorReferralNumber_02 { get; set; }
        [D(3, "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_87 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_87
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string OtherPayerPrimaryIdentifier_02 { get; set; }
        [D(3, "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_AdjustedRepricedLineItemReferenceNumber_2
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string AdjustedRepricedLineItemReferenceNumber_02 { get; set; }
        [D(3, "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_86 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_86
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_RepricedLineItemReferenceNumber_2
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string RepricedLineItemReferenceNumber_02 { get; set; }
        [D(3, "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_85 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_85
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class CN1_ContractInformation_4
    {
        
        [D(1, "1166")]
        public string ContractTypeCode_01 { get; set; }
        [D(2, "782")]
        public string ContractAmount_02 { get; set; }
        [D(3, "332")]
        public string ContractPercentage_03 { get; set; }
        [D(4, "127")]
        public string ContractCode_04 { get; set; }
        [D(5, "338")]
        public string TermsDiscountPercentage_05 { get; set; }
        [D(6, "799")]
        public string ContractVersionIdentifier_06 { get; set; }
    }
    
    public class MEA_TestResult_2
    {
        
        [D(1, "737")]
        public string MeasurementReferenceIdentificationCode_01 { get; set; }
        [D(2, "738")]
        public string MeasurementQualifier_02 { get; set; }
        [D(3, "739")]
        public string TestResults_03 { get; set; }
        [C(4)]
        public C001_CompositeUnitofMeasure_10 CompositeUnitofMeasure_04 { get; set; }
        [D(5, "740")]
        public string RangeMinimum_05 { get; set; }
        [D(6, "741")]
        public string RangeMaximum_06 { get; set; }
        [D(7, "935")]
        public string MeasurementSignificanceCode_07 { get; set; }
        [D(8, "936")]
        public string MeasurementAttributeCode_08 { get; set; }
        [D(9, "752")]
        public string SurfaceLayerPositionCode_09 { get; set; }
        [D(10, "1373")]
        public string MeasurementMethodorDevice_10 { get; set; }
        [D(11, "1270")]
        public string CodeListQualifierCode_11 { get; set; }
        [D(12, "1271")]
        public string IndustryCode_12 { get; set; }
    }
    
    public class C001_CompositeUnitofMeasure_10
    {
        
        [D(1, "355")]
        public string UnitorBasisforMeasurementCode_01 { get; set; }
        [D(2, "1018")]
        public string Exponent_02 { get; set; }
        [D(3, "649")]
        public string Multiplier_03 { get; set; }
        [D(4, "355")]
        public string UnitorBasisforMeasurementCode_04 { get; set; }
        [D(5, "1018")]
        public string Exponent_05 { get; set; }
        [D(6, "649")]
        public string Multiplier_06 { get; set; }
        [D(7, "355")]
        public string UnitorBasisforMeasurementCode_07 { get; set; }
        [D(8, "1018")]
        public string Exponent_08 { get; set; }
        [D(9, "649")]
        public string Multiplier_09 { get; set; }
        [D(10, "355")]
        public string UnitorBasisforMeasurementCode_10 { get; set; }
        [D(11, "1018")]
        public string Exponent_11 { get; set; }
        [D(12, "649")]
        public string Multiplier_12 { get; set; }
        [D(13, "355")]
        public string UnitorBasisforMeasurementCode_13 { get; set; }
        [D(14, "1018")]
        public string Exponent_14 { get; set; }
        [D(15, "649")]
        public string Multiplier_15 { get; set; }
    }
    
    public class All_QTY_2
    {
        
        [S("QTY", 1, typeof(X12_ID_673))]
        public QTY_AmbulancePatientCount_2 QTY_AmbulancePatientCount_2 { get; set; }
        [S("QTY", 2, typeof(X12_ID_673_2))]
        public QTY_ObstetricAnesthesiaAdditionalUnits_2 QTY_ObstetricAnesthesiaAdditionalUnits_2 { get; set; }
    }
    
    [E(",PT,")]
    public class X12_ID_673
    {
    }
    
    [E(",FL,")]
    public class X12_ID_673_2
    {
    }
    
    public class QTY_ObstetricAnesthesiaAdditionalUnits_2
    {
        
        [D(1, "673")]
        public string QuantityQualifier_01 { get; set; }
        [D(2, "380")]
        public string ObstetricAdditionalUnits_02 { get; set; }
        [C(3)]
        public C001_CompositeUnitofMeasure_9 CompositeUnitofMeasure_03 { get; set; }
        [D(4, "61")]
        public string FreeformInformation_04 { get; set; }
    }
    
    public class C001_CompositeUnitofMeasure_9
    {
        
        [D(1, "355")]
        public string UnitorBasisforMeasurementCode_01 { get; set; }
        [D(2, "1018")]
        public string Exponent_02 { get; set; }
        [D(3, "649")]
        public string Multiplier_03 { get; set; }
        [D(4, "355")]
        public string UnitorBasisforMeasurementCode_04 { get; set; }
        [D(5, "1018")]
        public string Exponent_05 { get; set; }
        [D(6, "649")]
        public string Multiplier_06 { get; set; }
        [D(7, "355")]
        public string UnitorBasisforMeasurementCode_07 { get; set; }
        [D(8, "1018")]
        public string Exponent_08 { get; set; }
        [D(9, "649")]
        public string Multiplier_09 { get; set; }
        [D(10, "355")]
        public string UnitorBasisforMeasurementCode_10 { get; set; }
        [D(11, "1018")]
        public string Exponent_11 { get; set; }
        [D(12, "649")]
        public string Multiplier_12 { get; set; }
        [D(13, "355")]
        public string UnitorBasisforMeasurementCode_13 { get; set; }
        [D(14, "1018")]
        public string Exponent_14 { get; set; }
        [D(15, "649")]
        public string Multiplier_15 { get; set; }
    }
    
    public class QTY_AmbulancePatientCount_2
    {
        
        [D(1, "673")]
        public string QuantityQualifier_01 { get; set; }
        [D(2, "380")]
        public string AmbulancePatientCount_02 { get; set; }
        [C(3)]
        public C001_CompositeUnitofMeasure_8 CompositeUnitofMeasure_03 { get; set; }
        [D(4, "61")]
        public string FreeformInformation_04 { get; set; }
    }
    
    public class C001_CompositeUnitofMeasure_8
    {
        
        [D(1, "355")]
        public string UnitorBasisforMeasurementCode_01 { get; set; }
        [D(2, "1018")]
        public string Exponent_02 { get; set; }
        [D(3, "649")]
        public string Multiplier_03 { get; set; }
        [D(4, "355")]
        public string UnitorBasisforMeasurementCode_04 { get; set; }
        [D(5, "1018")]
        public string Exponent_05 { get; set; }
        [D(6, "649")]
        public string Multiplier_06 { get; set; }
        [D(7, "355")]
        public string UnitorBasisforMeasurementCode_07 { get; set; }
        [D(8, "1018")]
        public string Exponent_08 { get; set; }
        [D(9, "649")]
        public string Multiplier_09 { get; set; }
        [D(10, "355")]
        public string UnitorBasisforMeasurementCode_10 { get; set; }
        [D(11, "1018")]
        public string Exponent_11 { get; set; }
        [D(12, "649")]
        public string Multiplier_12 { get; set; }
        [D(13, "355")]
        public string UnitorBasisforMeasurementCode_13 { get; set; }
        [D(14, "1018")]
        public string Exponent_14 { get; set; }
        [D(15, "649")]
        public string Multiplier_15 { get; set; }
    }
    
    public class All_DTP_4
    {
        
        [S("DTP", 1, typeof(X12_ID_374_19), typeof(X12_ID_1250_2))]
        public DTP_Date_ServiceDate_2 DTP_Date_ServiceDate_2 { get; set; }
        [S("DTP", 2, typeof(X12_ID_374_9), typeof(X12_ID_1250))]
        public DTP_Date_PrescriptionDate_2 DTP_Date_PrescriptionDate_2 { get; set; }
        [S("DTP", 3, typeof(X12_ID_374_20), typeof(X12_ID_1250))]
        public DTP_DATE_CertificationRevision_RecertificationDate_2 DTP_DATE_CertificationRevision_RecertificationDate_2 { get; set; }
        [S("DTP", 4, typeof(X12_ID_374_21), typeof(X12_ID_1250))]
        public DTP_Date_BeginTherapyDate_2 DTP_Date_BeginTherapyDate_2 { get; set; }
        [S("DTP", 5, typeof(X12_ID_374_22), typeof(X12_ID_1250))]
        public DTP_Date_LastCertificationDate_2 DTP_Date_LastCertificationDate_2 { get; set; }
        [S("DTP", 6, typeof(X12_ID_374_4), typeof(X12_ID_1250))]
        public DTP_Date_LastSeenDate_4 DTP_Date_LastSeenDate_4 { get; set; }
        [S("DTP", 7, typeof(X12_ID_374_23), typeof(X12_ID_1250))]
        public List<DTP_Date_TestDate_2> DTP_Date_TestDate_2 { get; set; }
        [S("DTP", 8, typeof(X12_ID_374_24), typeof(X12_ID_1250))]
        public DTP_Date_ShippedDate_2 DTP_Date_ShippedDate_2 { get; set; }
        [S("DTP", 9, typeof(X12_ID_374_8), typeof(X12_ID_1250))]
        public DTP_Date_LastX_rayDate_4 DTP_Date_LastX_rayDate_4 { get; set; }
        [S("DTP", 10, typeof(X12_ID_374_3), typeof(X12_ID_1250))]
        public DTP_Date_InitialTreatmentDate_4 DTP_Date_InitialTreatmentDate_4 { get; set; }
    }
    
    [E(",472,")]
    public class X12_ID_374_19
    {
    }
    
    [E(",D8,RD8,")]
    public class X12_ID_1250_2
    {
    }
    
    [E(",471,")]
    public class X12_ID_374_9
    {
    }
    
    [E(",607,")]
    public class X12_ID_374_20
    {
    }
    
    [E(",463,")]
    public class X12_ID_374_21
    {
    }
    
    [E(",461,")]
    public class X12_ID_374_22
    {
    }
    
    [E(",304,")]
    public class X12_ID_374_4
    {
    }
    
    [E(",738,739,")]
    public class X12_ID_374_23
    {
    }
    
    [E(",011,")]
    public class X12_ID_374_24
    {
    }
    
    [E(",455,")]
    public class X12_ID_374_8
    {
    }
    
    [E(",454,")]
    public class X12_ID_374_3
    {
    }
    
    public class DTP_Date_InitialTreatmentDate_4
    {
        
        [D(1, "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, "1251")]
        public string InitialTreatmentDate_03 { get; set; }
    }
    
    public class DTP_Date_LastX_rayDate_4
    {
        
        [D(1, "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, "1251")]
        public string LastXRayDate_03 { get; set; }
    }
    
    public class DTP_Date_ShippedDate_2
    {
        
        [D(1, "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, "1251")]
        public string ShippedDate_03 { get; set; }
    }
    
    public class DTP_Date_TestDate_2
    {
        
        [D(1, "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, "1251")]
        public string TestPerformedDate_03 { get; set; }
    }
    
    public class DTP_Date_LastSeenDate_4
    {
        
        [D(1, "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, "1251")]
        public string TreatmentorTherapyDate_03 { get; set; }
    }
    
    public class DTP_Date_LastCertificationDate_2
    {
        
        [D(1, "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, "1251")]
        public string LastCertificationDate_03 { get; set; }
    }
    
    public class DTP_Date_BeginTherapyDate_2
    {
        
        [D(1, "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, "1251")]
        public string BeginTherapyDate_03 { get; set; }
    }
    
    public class DTP_DATE_CertificationRevision_RecertificationDate_2
    {
        
        [D(1, "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, "1251")]
        public string CertificationRevisionorRecertificationDate_03 { get; set; }
    }
    
    public class DTP_Date_PrescriptionDate_2
    {
        
        [D(1, "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, "1251")]
        public string PrescriptionDate_03 { get; set; }
    }
    
    public class DTP_Date_ServiceDate_2
    {
        
        [D(1, "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, "1251")]
        public string ServiceDate_03 { get; set; }
    }
    
    public class All_CRC_4
    {
        
        [S("CRC", 1, typeof(X12_ID_1136), typeof(X12_ID_1073_3))]
        public List<CRC_AmbulanceCertification_4> CRC_AmbulanceCertification_4 { get; set; }
        [S("CRC", 2, typeof(X12_ID_1136_5), typeof(X12_ID_1073_3))]
        public CRC_HospiceEmployeeIndicator_2 CRC_HospiceEmployeeIndicator_2 { get; set; }
        [S("CRC", 3, typeof(X12_ID_1136_6), typeof(X12_ID_1073_3))]
        public CRC_ConditionIndicator_DurableMedicalEquipment_2 CRC_ConditionIndicator_DurableMedicalEquipment_2 { get; set; }
    }
    
    [E(",07,")]
    public class X12_ID_1136
    {
    }
    
    [E(",N,Y,")]
    public class X12_ID_1073_3
    {
    }
    
    [E(",70,")]
    public class X12_ID_1136_5
    {
    }
    
    [E(",09,")]
    public class X12_ID_1136_6
    {
    }
    
    public class CRC_ConditionIndicator_DurableMedicalEquipment_2
    {
        
        [D(1, "1136")]
        public string CodeCategory_01 { get; set; }
        [D(2, "1073")]
        public string CertificationConditionIndicator_02 { get; set; }
        [D(3, "1321")]
        public string ConditionIndicator_03 { get; set; }
        [D(4, "1321")]
        public string ConditionIndicator_04 { get; set; }
        [D(5, "1321")]
        public string ConditionIndicator_05 { get; set; }
        [D(6, "1321")]
        public string ConditionIndicator_06 { get; set; }
        [D(7, "1321")]
        public string ConditionIndicator_07 { get; set; }
    }
    
    public class CRC_HospiceEmployeeIndicator_2
    {
        
        [D(1, "1136")]
        public string CodeCategory_01 { get; set; }
        [D(2, "1073")]
        public string HospiceEmployedProviderIndicator_02 { get; set; }
        [D(3, "1321")]
        public string ConditionIndicator_03 { get; set; }
        [D(4, "1321")]
        public string ConditionIndicator_04 { get; set; }
        [D(5, "1321")]
        public string ConditionIndicator_05 { get; set; }
        [D(6, "1321")]
        public string ConditionIndicator_06 { get; set; }
        [D(7, "1321")]
        public string ConditionIndicator_07 { get; set; }
    }
    
    public class CRC_AmbulanceCertification_4
    {
        
        [D(1, "1136")]
        public string CodeCategory_01 { get; set; }
        [D(2, "1073")]
        public string CertificationConditionIndicator_02 { get; set; }
        [D(3, "1321")]
        public string ConditionCode_03 { get; set; }
        [D(4, "1321")]
        public string ConditionCode_04 { get; set; }
        [D(5, "1321")]
        public string ConditionCode_05 { get; set; }
        [D(6, "1321")]
        public string ConditionCode_06 { get; set; }
        [D(7, "1321")]
        public string ConditionCode_07 { get; set; }
    }
    
    public class CR3_DurableMedicalEquipmentCertification_2
    {
        
        [D(1, "1322")]
        public string CertificationTypeCode_01 { get; set; }
        [D(2, "355")]
        public string UnitorBasisforMeasurementCode_02 { get; set; }
        [D(3, "380")]
        public string DurableMedicalEquipmentDuration_03 { get; set; }
        [D(4, "1335")]
        public string InsulinDependentCode_04 { get; set; }
        [D(5, "352")]
        public string Description_05 { get; set; }
    }
    
    public class CR1_AmbulanceTransportInformation_4
    {
        
        [D(1, "355")]
        public string UnitorBasisforMeasurementCode_01 { get; set; }
        [D(2, "81")]
        public string PatientWeight_02 { get; set; }
        [D(3, "1316")]
        public string AmbulanceTransportCode_03 { get; set; }
        [D(4, "1317")]
        public string AmbulanceTransportReasonCode_04 { get; set; }
        [D(5, "355")]
        public string UnitorBasisforMeasurementCode_05 { get; set; }
        [D(6, "380")]
        public string TransportDistance_06 { get; set; }
        [D(7, "166")]
        public string AddressInformation_07 { get; set; }
        [D(8, "166")]
        public string AddressInformation_08 { get; set; }
        [D(9, "352")]
        public string RoundTripPurposeDescription_09 { get; set; }
        [D(10, "352")]
        public string StretcherPurposeDescription_10 { get; set; }
    }
    
    public class All_PWK_2
    {
        
        [S("PWK", 1, typeof(X12_ID_755_2), typeof(X12_ID_756))]
        public List<PWK_LineSupplementalInformation_2> PWK_LineSupplementalInformation_2 { get; set; }
        [S("PWK", 2, typeof(X12_ID_755_3), typeof(X12_ID_756_2))]
        public PWK_DurableMedicalEquipmentCertificateofMedicalNecessityIndicator_2 PWK_DurableMedicalEquipmentCertificateofMedicalNecessityIndicator_2 { get; set; }
    }
    
    [E(",03,04,05,06,07,08,09,10,11,13,15,21,A3,A4,AM,AS,B2,B3,B4,BR,BS,BT,CB,CK,CT,D2,DA" +
        ",DB,DG,DJ,DS,EB,HC,HR,I5,IR,LA,M1,MT,NN,OB,OC,OD,OE,OX,OZ,P4,P5,PE,PN,PO,PQ,PY,P" +
        "Z,RB,RR,RT,RX,SG,V5,XP,")]
    public class X12_ID_755_2
    {
    }
    
    [E(",CT,")]
    public class X12_ID_755_3
    {
    }
    
    [E(",AB,AD,AF,AG,NS,")]
    public class X12_ID_756_2
    {
    }
    
    public class PWK_DurableMedicalEquipmentCertificateofMedicalNecessityIndicator_2
    {
        
        [D(1, "755")]
        public string AttachmentReportTypeCode_01 { get; set; }
        [D(2, "756")]
        public string AttachmentTransmissionCode_02 { get; set; }
        [D(3, "757")]
        public string ReportCopiesNeeded_03 { get; set; }
        [D(4, "98")]
        public string EntityIdentifierCode_04 { get; set; }
        [D(5, "66")]
        public string IdentificationCodeQualifier_05 { get; set; }
        [D(6, "67")]
        public string IdentificationCode_06 { get; set; }
        [D(7, "352")]
        public string Description_07 { get; set; }
        [C(8)]
        public C002_ActionsIndicated_6 ActionsIndicated_08 { get; set; }
        [D(9, "1525")]
        public string RequestCategoryCode_09 { get; set; }
    }
    
    public class C002_ActionsIndicated_6
    {
        
        [D(1, "704")]
        public string PaperworkReportActionCode_01 { get; set; }
        [D(2, "704")]
        public string PaperworkReportActionCode_02 { get; set; }
        [D(3, "704")]
        public string PaperworkReportActionCode_03 { get; set; }
        [D(4, "704")]
        public string PaperworkReportActionCode_04 { get; set; }
        [D(5, "704")]
        public string PaperworkReportActionCode_05 { get; set; }
    }
    
    public class PWK_LineSupplementalInformation_2
    {
        
        [D(1, "755")]
        public string AttachmentReportTypeCode_01 { get; set; }
        [D(2, "756")]
        public string AttachmentTransmissionCode_02 { get; set; }
        [D(3, "757")]
        public string ReportCopiesNeeded_03 { get; set; }
        [D(4, "98")]
        public string EntityIdentifierCode_04 { get; set; }
        [D(5, "66")]
        public string IdentificationCodeQualifier_05 { get; set; }
        [D(6, "67")]
        public string AttachmentControlNumber_06 { get; set; }
        [D(7, "352")]
        public string Description_07 { get; set; }
        [C(8)]
        public C002_ActionsIndicated_5 ActionsIndicated_08 { get; set; }
        [D(9, "1525")]
        public string RequestCategoryCode_09 { get; set; }
    }
    
    public class C002_ActionsIndicated_5
    {
        
        [D(1, "704")]
        public string PaperworkReportActionCode_01 { get; set; }
        [D(2, "704")]
        public string PaperworkReportActionCode_02 { get; set; }
        [D(3, "704")]
        public string PaperworkReportActionCode_03 { get; set; }
        [D(4, "704")]
        public string PaperworkReportActionCode_04 { get; set; }
        [D(5, "704")]
        public string PaperworkReportActionCode_05 { get; set; }
    }
    
    public class SV5_DurableMedicalEquipmentService_2
    {
        
        [C(1)]
        public C003_CompositeMedicalProcedureIdentifier_5 CompositeMedicalProcedureIdentifier_01 { get; set; }
        [D(2, "355")]
        public string UnitorBasisforMeasurementCode_02 { get; set; }
        [D(3, "380")]
        public string LengthofMedicalNecessity_03 { get; set; }
        [D(4, "782")]
        public string DMERentalPrice_04 { get; set; }
        [D(5, "782")]
        public string DMEPurchasePrice_05 { get; set; }
        [D(6, "594")]
        public string RentalUnitPriceIndicator_06 { get; set; }
        [D(7, "923")]
        public string PrognosisCode_07 { get; set; }
    }
    
    public class C003_CompositeMedicalProcedureIdentifier_5
    {
        
        [D(1, "235")]
        public string ProcedureIdentifier_01 { get; set; }
        [D(2, "234")]
        public string ProcedureCode_02 { get; set; }
        [D(3, "1339")]
        public string ProcedureModifier_03 { get; set; }
        [D(4, "1339")]
        public string ProcedureModifier_04 { get; set; }
        [D(5, "1339")]
        public string ProcedureModifier_05 { get; set; }
        [D(6, "1339")]
        public string ProcedureModifier_06 { get; set; }
        [D(7, "352")]
        public string Description_07 { get; set; }
        [D(8, "234")]
        public string ProductServiceID_08 { get; set; }
    }
    
    public class SV1_ProfessionalService_2
    {
        
        [C(1)]
        public C003_CompositeMedicalProcedureIdentifier_4 CompositeMedicalProcedureIdentifier_01 { get; set; }
        [D(2, "782")]
        public string LineItemChargeAmount_02 { get; set; }
        [D(3, "355")]
        public string UnitorBasisforMeasurementCode_03 { get; set; }
        [D(4, "380")]
        public string ServiceUnitCount_04 { get; set; }
        [D(5, "1331")]
        public string PlaceofServiceCode_05 { get; set; }
        [D(6, "1365")]
        public string ServiceTypeCode_06 { get; set; }
        [C(7)]
        public C004_CompositeDiagnosisCodePointer_2 CompositeDiagnosisCodePointer_07 { get; set; }
        [D(8, "782")]
        public string MonetaryAmount_08 { get; set; }
        [D(9, "1073")]
        public string EmergencyIndicator_09 { get; set; }
        [D(10, "1340")]
        public string MultipleProcedureCode_10 { get; set; }
        [D(11, "1073")]
        public string EPSDTIndicator_11 { get; set; }
        [D(12, "1073")]
        public string FamilyPlanningIndicator_12 { get; set; }
        [D(13, "1364")]
        public string ReviewCode_13 { get; set; }
        [D(14, "1341")]
        public string NationalorLocalAssignedReviewValue_14 { get; set; }
        [D(15, "1327")]
        public string CoPayStatusCode_15 { get; set; }
        [D(16, "1334")]
        public string HealthCareProfessionalShortageAreaCode_16 { get; set; }
        [D(17, "127")]
        public string ReferenceIdentification_17 { get; set; }
        [D(18, "116")]
        public string PostalCode_18 { get; set; }
        [D(19, "782")]
        public string MonetaryAmount_19 { get; set; }
        [D(20, "1337")]
        public string LevelofCareCode_20 { get; set; }
        [D(21, "1360")]
        public string ProviderAgreementCode_21 { get; set; }
    }
    
    public class C004_CompositeDiagnosisCodePointer_2
    {
        
        [D(1, "1328")]
        public string DiagnosisCodePointer_01 { get; set; }
        [D(2, "1328")]
        public string DiagnosisCodePointer_02 { get; set; }
        [D(3, "1328")]
        public string DiagnosisCodePointer_03 { get; set; }
        [D(4, "1328")]
        public string DiagnosisCodePointer_04 { get; set; }
    }
    
    public class C003_CompositeMedicalProcedureIdentifier_4
    {
        
        [D(1, "235")]
        public string ProductorServiceIDQualifier_01 { get; set; }
        [D(2, "234")]
        public string ProcedureCode_02 { get; set; }
        [D(3, "1339")]
        public string ProcedureModifier_03 { get; set; }
        [D(4, "1339")]
        public string ProcedureModifier_04 { get; set; }
        [D(5, "1339")]
        public string ProcedureModifier_05 { get; set; }
        [D(6, "1339")]
        public string ProcedureModifier_06 { get; set; }
        [D(7, "352")]
        public string Description_07 { get; set; }
        [D(8, "234")]
        public string ProductServiceID_08 { get; set; }
    }
    
    public class LX_ServiceLineNumber_2
    {
        
        [D(1, "554")]
        public string AssignedNumber_01 { get; set; }
    }
    
    public class Loop_2320_2
    {
        
        [S("SBR", 1, typeof(X12_ID_1138), typeof(X12_ID_1069_3))]
        public SBR_OtherSubscriberInformation_2 SBR_OtherSubscriberInformation_2 { get; set; }
        [S("CAS", 2, typeof(X12_ID_1033))]
        public List<CAS_ClaimLevelAdjustments_2> CAS_ClaimLevelAdjustments_2 { get; set; }
        [A(3)]
        public All_AMT_3 All_AMT_3 { get; set; }
        [S("OI", 4, typeof(X12_ID_1032_2), typeof(X12_ID_1383))]
        public OI_OtherInsuranceCoverageInformation_2 OI_OtherInsuranceCoverageInformation_2 { get; set; }
        [S("MOA", 5)]
        public MOA_OutpatientAdjudicationInformation_2 MOA_OutpatientAdjudicationInformation_2 { get; set; }
        [A(6)]
        public All_NM1_8 All_NM1_8 { get; set; }
    }
    
    [E(",01,18,19,20,21,39,40,53,G8,")]
    public class X12_ID_1069_3
    {
    }
    
    [E(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,31,32,33,AM,BL" +
        ",CH,CI,CN,DS,FI,HM,LI,LM,MA,MB,MC,MH,OF,SA,TV,VA,WB,WC,WD,WE,ZZ,")]
    public class X12_ID_1032_2
    {
    }
    
    [E(",00,01,02,03,05,07,08,09,15,16,17,18,20,22,27,28,29,PB,")]
    public class X12_ID_1383
    {
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
        
        [S("NM1", 1, typeof(X12_ID_98_4), typeof(X12_ID_1065))]
        public NM1_OtherPayerBillingProvider_2 NM1_OtherPayerBillingProvider_2 { get; set; }
        [S("REF", 2, typeof(X12_ID_128_10))]
        public List<REF_OtherPayerBillingProviderSecondaryIdentification_2> REF_OtherPayerBillingProviderSecondaryIdentification_2 { get; set; }
    }
    
    public class REF_OtherPayerBillingProviderSecondaryIdentification_2
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string OtherPayerBillingProviderIdentifier_02 { get; set; }
        [D(3, "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_84 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_84
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class NM1_OtherPayerBillingProvider_2
    {
        
        [D(1, "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, "1035")]
        public string NameLastorOrganizationName_03 { get; set; }
        [D(4, "1036")]
        public string NameFirst_04 { get; set; }
        [D(5, "1037")]
        public string NameMiddle_05 { get; set; }
        [D(6, "1038")]
        public string NamePrefix_06 { get; set; }
        [D(7, "1039")]
        public string NameSuffix_07 { get; set; }
        [D(8, "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, "67")]
        public string IdentificationCode_09 { get; set; }
        [D(10, "706")]
        public string EntityRelationshipCode_10 { get; set; }
        [D(11, "98")]
        public string EntityIdentifierCode_11 { get; set; }
        [D(12, "1035")]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    public class Loop_2330F_2
    {
        
        [S("NM1", 1, typeof(X12_ID_98_12), typeof(X12_ID_1065_3))]
        public NM1_OtherPayerSupervisingProvider_2 NM1_OtherPayerSupervisingProvider_2 { get; set; }
        [S("REF", 2, typeof(X12_ID_128_26))]
        public List<REF_OtherPayerSupervisingProviderSecondaryIdentification_2> REF_OtherPayerSupervisingProviderSecondaryIdentification_2 { get; set; }
    }
    
    public class REF_OtherPayerSupervisingProviderSecondaryIdentification_2
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string OtherPayerSupervisingProviderIdentifier_02 { get; set; }
        [D(3, "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_83 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_83
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class NM1_OtherPayerSupervisingProvider_2
    {
        
        [D(1, "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, "1035")]
        public string NameLastorOrganizationName_03 { get; set; }
        [D(4, "1036")]
        public string NameFirst_04 { get; set; }
        [D(5, "1037")]
        public string NameMiddle_05 { get; set; }
        [D(6, "1038")]
        public string NamePrefix_06 { get; set; }
        [D(7, "1039")]
        public string NameSuffix_07 { get; set; }
        [D(8, "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, "67")]
        public string IdentificationCode_09 { get; set; }
        [D(10, "706")]
        public string EntityRelationshipCode_10 { get; set; }
        [D(11, "98")]
        public string EntityIdentifierCode_11 { get; set; }
        [D(12, "1035")]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    public class Loop_2330E_2
    {
        
        [S("NM1", 1, typeof(X12_ID_98_11), typeof(X12_ID_1065_2))]
        public NM1_OtherPayerServiceFacilityLocation_2 NM1_OtherPayerServiceFacilityLocation_2 { get; set; }
        [S("REF", 2, typeof(X12_ID_128_27))]
        public List<REF_OtherPayerServiceFacilityLocationSecondaryIdentification_2> REF_OtherPayerServiceFacilityLocationSecondaryIdentification_2 { get; set; }
    }
    
    [E(",0B,G2,LU,")]
    public class X12_ID_128_27
    {
    }
    
    public class REF_OtherPayerServiceFacilityLocationSecondaryIdentification_2
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string OtherPayerServiceFacilityLocationSecondaryIdentifier_02 { get; set; }
        [D(3, "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_82 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_82
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class NM1_OtherPayerServiceFacilityLocation_2
    {
        
        [D(1, "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, "1035")]
        public string NameLastorOrganizationName_03 { get; set; }
        [D(4, "1036")]
        public string NameFirst_04 { get; set; }
        [D(5, "1037")]
        public string NameMiddle_05 { get; set; }
        [D(6, "1038")]
        public string NamePrefix_06 { get; set; }
        [D(7, "1039")]
        public string NameSuffix_07 { get; set; }
        [D(8, "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, "67")]
        public string IdentificationCode_09 { get; set; }
        [D(10, "706")]
        public string EntityRelationshipCode_10 { get; set; }
        [D(11, "98")]
        public string EntityIdentifierCode_11 { get; set; }
        [D(12, "1035")]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    public class Loop_2330D_2
    {
        
        [S("NM1", 1, typeof(X12_ID_98_10), typeof(X12_ID_1065))]
        public NM1_OtherPayerRenderingProvider_2 NM1_OtherPayerRenderingProvider_2 { get; set; }
        [S("REF", 2, typeof(X12_ID_128_26))]
        public List<REF_OtherPayerRenderingProviderSecondaryIdentification_2> REF_OtherPayerRenderingProviderSecondaryIdentification_2 { get; set; }
    }
    
    public class REF_OtherPayerRenderingProviderSecondaryIdentification_2
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string OtherPayerRenderingProviderSecondaryIdentifier_02 { get; set; }
        [D(3, "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_81 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_81
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class NM1_OtherPayerRenderingProvider_2
    {
        
        [D(1, "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, "1035")]
        public string NameLastorOrganizationName_03 { get; set; }
        [D(4, "1036")]
        public string NameFirst_04 { get; set; }
        [D(5, "1037")]
        public string NameMiddle_05 { get; set; }
        [D(6, "1038")]
        public string NamePrefix_06 { get; set; }
        [D(7, "1039")]
        public string NameSuffix_07 { get; set; }
        [D(8, "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, "67")]
        public string IdentificationCode_09 { get; set; }
        [D(10, "706")]
        public string EntityRelationshipCode_10 { get; set; }
        [D(11, "98")]
        public string EntityIdentifierCode_11 { get; set; }
        [D(12, "1035")]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    public class Loop_2330C_2
    {
        
        [S("NM1", 1, typeof(X12_ID_98_9), typeof(X12_ID_1065_3))]
        public NM1_OtherPayerReferringProvider_2 NM1_OtherPayerReferringProvider_2 { get; set; }
        [S("REF", 2, typeof(X12_ID_128_25))]
        public List<REF_OtherPayerReferringProviderSecondaryIdentification_2> REF_OtherPayerReferringProviderSecondaryIdentification_2 { get; set; }
    }
    
    public class REF_OtherPayerReferringProviderSecondaryIdentification_2
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string OtherPayerReferringProviderIdentifier_02 { get; set; }
        [D(3, "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_80 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_80
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class NM1_OtherPayerReferringProvider_2
    {
        
        [D(1, "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, "1035")]
        public string NameLastorOrganizationName_03 { get; set; }
        [D(4, "1036")]
        public string NameFirst_04 { get; set; }
        [D(5, "1037")]
        public string NameMiddle_05 { get; set; }
        [D(6, "1038")]
        public string NamePrefix_06 { get; set; }
        [D(7, "1039")]
        public string NameSuffix_07 { get; set; }
        [D(8, "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, "67")]
        public string IdentificationCode_09 { get; set; }
        [D(10, "706")]
        public string EntityRelationshipCode_10 { get; set; }
        [D(11, "98")]
        public string EntityIdentifierCode_11 { get; set; }
        [D(12, "1035")]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    public class Loop_2330B_2
    {
        
        [S("NM1", 1, typeof(X12_ID_98_8), typeof(X12_ID_1065_2))]
        public NM1_OtherPayerName_2 NM1_OtherPayerName_2 { get; set; }
        [S("N3", 2)]
        public N3_OtherPayerAddress_2 N3_OtherPayerAddress_2 { get; set; }
        [S("N4", 3)]
        public N4_OtherPayerCity_State_ZIPCode_2 N4_OtherPayerCity_State_ZIPCode_2 { get; set; }
        [S("DTP", 4, typeof(X12_ID_374_18), typeof(X12_ID_1250))]
        public DTP_ClaimCheckorRemittanceDate_2 DTP_ClaimCheckorRemittanceDate_2 { get; set; }
        [A(5)]
        public All_REF_10 All_REF_10 { get; set; }
    }
    
    [E(",PR,")]
    public class X12_ID_98_8
    {
    }
    
    public class All_REF_10
    {
        
        [S("REF", 1, typeof(X12_ID_128_9))]
        public List<REF_OtherPayerSecondaryIdentifier_2> REF_OtherPayerSecondaryIdentifier_2 { get; set; }
        [S("REF", 2, typeof(X12_ID_128_15))]
        public REF_OtherPayerPriorAuthorizationNumber_2 REF_OtherPayerPriorAuthorizationNumber_2 { get; set; }
        [S("REF", 3, typeof(X12_ID_128_14))]
        public REF_OtherPayerReferralNumber_2 REF_OtherPayerReferralNumber_2 { get; set; }
        [S("REF", 4, typeof(X12_ID_128_28))]
        public REF_OtherPayerClaimAdjustmentIndicator_2 REF_OtherPayerClaimAdjustmentIndicator_2 { get; set; }
        [S("REF", 5, typeof(X12_ID_128_16))]
        public REF_OtherPayerClaimControlNumber_2 REF_OtherPayerClaimControlNumber_2 { get; set; }
    }
    
    [E(",2U,EI,FY,NF,")]
    public class X12_ID_128_9
    {
    }
    
    [E(",T4,")]
    public class X12_ID_128_28
    {
    }
    
    [E(",F8,")]
    public class X12_ID_128_16
    {
    }
    
    public class REF_OtherPayerClaimControlNumber_2
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string OtherPayersClaimControlNumber_02 { get; set; }
        [D(3, "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_79 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_79
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_OtherPayerClaimAdjustmentIndicator_2
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string OtherPayerClaimAdjustmentIndicator_02 { get; set; }
        [D(3, "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_78 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_78
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_OtherPayerReferralNumber_2
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string OtherPayerPriorAuthorizationorReferralNumber_02 { get; set; }
        [D(3, "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_77 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_77
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_OtherPayerPriorAuthorizationNumber_2
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string OtherPayerPriorAuthorizationNumber_02 { get; set; }
        [D(3, "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_76 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_76
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_OtherPayerSecondaryIdentifier_2
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string OtherPayerSecondaryIdentifier_02 { get; set; }
        [D(3, "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_75 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_75
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class DTP_ClaimCheckorRemittanceDate_2
    {
        
        [D(1, "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, "1251")]
        public string AdjudicationorPaymentDate_03 { get; set; }
    }
    
    public class N4_OtherPayerCity_State_ZIPCode_2
    {
        
        [D(1, "19")]
        public string OtherPayerCityName_01 { get; set; }
        [D(2, "156")]
        public string OtherPayerStateorProvinceCode_02 { get; set; }
        [D(3, "116")]
        public string OtherPayerPostalZoneorZIPCode_03 { get; set; }
        [D(4, "26")]
        public string CountryCode_04 { get; set; }
        [D(5, "309")]
        public string LocationQualifier_05 { get; set; }
        [D(6, "310")]
        public string LocationIdentifier_06 { get; set; }
        [D(7, "1715")]
        public string CountrySubdivisionCode_07 { get; set; }
    }
    
    public class N3_OtherPayerAddress_2
    {
        
        [D(1, "166")]
        public string OtherPayerAddressLine_01 { get; set; }
        [D(2, "166")]
        public string OtherPayerAddressLine_02 { get; set; }
    }
    
    public class NM1_OtherPayerName_2
    {
        
        [D(1, "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, "1035")]
        public string OtherPayerOrganizationName_03 { get; set; }
        [D(4, "1036")]
        public string NameFirst_04 { get; set; }
        [D(5, "1037")]
        public string NameMiddle_05 { get; set; }
        [D(6, "1038")]
        public string NamePrefix_06 { get; set; }
        [D(7, "1039")]
        public string NameSuffix_07 { get; set; }
        [D(8, "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, "67")]
        public string OtherPayerPrimaryIdentifier_09 { get; set; }
        [D(10, "706")]
        public string EntityRelationshipCode_10 { get; set; }
        [D(11, "98")]
        public string EntityIdentifierCode_11 { get; set; }
        [D(12, "1035")]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    public class Loop_2330A_2
    {
        
        [S("NM1", 1, typeof(X12_ID_98_7), typeof(X12_ID_1065))]
        public NM1_OtherSubscriberName_2 NM1_OtherSubscriberName_2 { get; set; }
        [S("N3", 2)]
        public N3_OtherSubscriberAddress_2 N3_OtherSubscriberAddress_2 { get; set; }
        [S("N4", 3)]
        public N4_OtherSubscriberCity_State_ZIPCode_2 N4_OtherSubscriberCity_State_ZIPCode_2 { get; set; }
        [S("REF", 4, typeof(X12_ID_128_7))]
        public REF_OtherSubscriberSecondaryIdentification_2 REF_OtherSubscriberSecondaryIdentification_2 { get; set; }
    }
    
    [E(",IL,")]
    public class X12_ID_98_7
    {
    }
    
    [E(",SY,")]
    public class X12_ID_128_7
    {
    }
    
    public class REF_OtherSubscriberSecondaryIdentification_2
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string OtherInsuredAdditionalIdentifier_02 { get; set; }
        [D(3, "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_74 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_74
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class N4_OtherSubscriberCity_State_ZIPCode_2
    {
        
        [D(1, "19")]
        public string OtherSubscriberCityName_01 { get; set; }
        [D(2, "156")]
        public string OtherSubscriberStateorProvinceCode_02 { get; set; }
        [D(3, "116")]
        public string OtherSubscriberPostalZoneorZIPCode_03 { get; set; }
        [D(4, "26")]
        public string CountryCode_04 { get; set; }
        [D(5, "309")]
        public string LocationQualifier_05 { get; set; }
        [D(6, "310")]
        public string LocationIdentifier_06 { get; set; }
        [D(7, "1715")]
        public string CountrySubdivisionCode_07 { get; set; }
    }
    
    public class N3_OtherSubscriberAddress_2
    {
        
        [D(1, "166")]
        public string OtherInsuredAddressLine_01 { get; set; }
        [D(2, "166")]
        public string OtherInsuredAddressLine_02 { get; set; }
    }
    
    public class NM1_OtherSubscriberName_2
    {
        
        [D(1, "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, "1035")]
        public string OtherInsuredLastName_03 { get; set; }
        [D(4, "1036")]
        public string OtherInsuredFirstName_04 { get; set; }
        [D(5, "1037")]
        public string OtherInsuredMiddleName_05 { get; set; }
        [D(6, "1038")]
        public string NamePrefix_06 { get; set; }
        [D(7, "1039")]
        public string OtherInsuredNameSuffix_07 { get; set; }
        [D(8, "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, "67")]
        public string OtherInsuredIdentifier_09 { get; set; }
        [D(10, "706")]
        public string EntityRelationshipCode_10 { get; set; }
        [D(11, "98")]
        public string EntityIdentifierCode_11 { get; set; }
        [D(12, "1035")]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    public class MOA_OutpatientAdjudicationInformation_2
    {
        
        [D(1, "954")]
        public string ReimbursementRate_01 { get; set; }
        [D(2, "782")]
        public string HCPCSPayableAmount_02 { get; set; }
        [D(3, "127")]
        public string ClaimPaymentRemarkCode_03 { get; set; }
        [D(4, "127")]
        public string ClaimPaymentRemarkCode_04 { get; set; }
        [D(5, "127")]
        public string ClaimPaymentRemarkCode_05 { get; set; }
        [D(6, "127")]
        public string ClaimPaymentRemarkCode_06 { get; set; }
        [D(7, "127")]
        public string ClaimPaymentRemarkCode_07 { get; set; }
        [D(8, "782")]
        public string EndStageRenalDiseasePaymentAmount_08 { get; set; }
        [D(9, "782")]
        public string NonPayableProfessionalComponentBilledAmount_09 { get; set; }
    }
    
    public class OI_OtherInsuranceCoverageInformation_2
    {
        
        [D(1, "1032")]
        public string ClaimFilingIndicatorCode_01 { get; set; }
        [D(2, "1383")]
        public string ClaimSubmissionReasonCode_02 { get; set; }
        [D(3, "1073")]
        public string BenefitsAssignmentCertificationIndicator_03 { get; set; }
        [D(4, "1351")]
        public string PatientSignatureSourceCode_04 { get; set; }
        [D(5, "1360")]
        public string ProviderAgreementCode_05 { get; set; }
        [D(6, "1363")]
        public string ReleaseofInformationCode_06 { get; set; }
    }
    
    public class All_AMT_3
    {
        
        [S("AMT", 1, typeof(X12_ID_522_2))]
        public AMT_CoordinationofBenefits_COB_PayerPaidAmount_2 AMT_CoordinationofBenefits_COB_PayerPaidAmount_2 { get; set; }
        [S("AMT", 2, typeof(X12_ID_522_3))]
        public AMT_CoordinationofBenefits_COB_TotalNon_coveredAmount_2 AMT_CoordinationofBenefits_COB_TotalNon_coveredAmount_2 { get; set; }
        [S("AMT", 3, typeof(X12_ID_522_4))]
        public AMT_RemainingPatientLiability_3 AMT_RemainingPatientLiability_3 { get; set; }
    }
    
    [E(",D,")]
    public class X12_ID_522_2
    {
    }
    
    [E(",A8,")]
    public class X12_ID_522_3
    {
    }
    
    public class AMT_RemainingPatientLiability_3
    {
        
        [D(1, "522")]
        public string AmountQualifierCode_01 { get; set; }
        [D(2, "782")]
        public string RemainingPatientLiability_02 { get; set; }
        [D(3, "478")]
        public string CreditDebitFlagCode_03 { get; set; }
    }
    
    public class AMT_CoordinationofBenefits_COB_TotalNon_coveredAmount_2
    {
        
        [D(1, "522")]
        public string AmountQualifierCode_01 { get; set; }
        [D(2, "782")]
        public string NonCoveredChargeAmount_02 { get; set; }
        [D(3, "478")]
        public string CreditDebitFlagCode_03 { get; set; }
    }
    
    public class AMT_CoordinationofBenefits_COB_PayerPaidAmount_2
    {
        
        [D(1, "522")]
        public string AmountQualifierCode_01 { get; set; }
        [D(2, "782")]
        public string PayerPaidAmount_02 { get; set; }
        [D(3, "478")]
        public string CreditDebitFlagCode_03 { get; set; }
    }
    
    public class CAS_ClaimLevelAdjustments_2
    {
        
        [D(1, "1033")]
        public string ClaimAdjustmentGroupCode_01 { get; set; }
        [D(2, "1034")]
        public string AdjustmentReasonCode_02 { get; set; }
        [D(3, "782")]
        public string AdjustmentAmount_03 { get; set; }
        [D(4, "380")]
        public string AdjustmentQuantity_04 { get; set; }
        [D(5, "1034")]
        public string AdjustmentReasonCode_05 { get; set; }
        [D(6, "782")]
        public string AdjustmentAmount_06 { get; set; }
        [D(7, "380")]
        public string AdjustmentQuantity_07 { get; set; }
        [D(8, "1034")]
        public string AdjustmentReasonCode_08 { get; set; }
        [D(9, "782")]
        public string AdjustmentAmount_09 { get; set; }
        [D(10, "380")]
        public string AdjustmentQuantity_10 { get; set; }
        [D(11, "1034")]
        public string AdjustmentReasonCode_11 { get; set; }
        [D(12, "782")]
        public string AdjustmentAmount_12 { get; set; }
        [D(13, "380")]
        public string AdjustmentQuantity_13 { get; set; }
        [D(14, "1034")]
        public string AdjustmentReasonCode_14 { get; set; }
        [D(15, "782")]
        public string AdjustmentAmount_15 { get; set; }
        [D(16, "380")]
        public string AdjustmentQuantity_16 { get; set; }
        [D(17, "1034")]
        public string AdjustmentReasonCode_17 { get; set; }
        [D(18, "782")]
        public string AdjustmentAmount_18 { get; set; }
        [D(19, "380")]
        public string AdjustmentQuantity_19 { get; set; }
    }
    
    public class SBR_OtherSubscriberInformation_2
    {
        
        [D(1, "1138")]
        public string PayerResponsibilitySequenceNumberCode_01 { get; set; }
        [D(2, "1069")]
        public string IndividualRelationshipCode_02 { get; set; }
        [D(3, "127")]
        public string InsuredGrouporPolicyNumber_03 { get; set; }
        [D(4, "93")]
        public string OtherInsuredGroupName_04 { get; set; }
        [D(5, "1336")]
        public string InsuranceTypeCode_05 { get; set; }
        [D(6, "1143")]
        public string CoordinationofBenefitsCode_06 { get; set; }
        [D(7, "1073")]
        public string YesNoConditionorResponseCode_07 { get; set; }
        [D(8, "584")]
        public string EmploymentStatusCode_08 { get; set; }
        [D(9, "1032")]
        public string ClaimFilingIndicatorCode_09 { get; set; }
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
        
        [S("NM1", 1, typeof(X12_ID_98_14), typeof(X12_ID_1065_2))]
        public NM1_AmbulanceDrop_offLocation_3 NM1_AmbulanceDrop_offLocation_3 { get; set; }
        [S("N3", 2)]
        public N3_AmbulanceDrop_offLocationAddress_3 N3_AmbulanceDrop_offLocationAddress_3 { get; set; }
        [S("N4", 3)]
        public N4_AmbulanceDrop_offLocationCity_State_ZipCode_3 N4_AmbulanceDrop_offLocationCity_State_ZipCode_3 { get; set; }
    }
    
    public class N4_AmbulanceDrop_offLocationCity_State_ZipCode_3
    {
        
        [D(1, "19")]
        public string AmbulanceDropoffCityName_01 { get; set; }
        [D(2, "156")]
        public string AmbulanceDropoffStateorProvinceCode_02 { get; set; }
        [D(3, "116")]
        public string AmbulanceDropoffPostalZoneorZIPCode_03 { get; set; }
        [D(4, "26")]
        public string CountryCode_04 { get; set; }
        [D(5, "309")]
        public string LocationQualifier_05 { get; set; }
        [D(6, "310")]
        public string LocationIdentifier_06 { get; set; }
        [D(7, "1715")]
        public string CountrySubdivisionCode_07 { get; set; }
    }
    
    public class N3_AmbulanceDrop_offLocationAddress_3
    {
        
        [D(1, "166")]
        public string AmbulanceDropoffAddressLine_01 { get; set; }
        [D(2, "166")]
        public string AmbulanceDropoffAddressLine_02 { get; set; }
    }
    
    public class NM1_AmbulanceDrop_offLocation_3
    {
        
        [D(1, "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, "1035")]
        public string AmbulanceDropoffLocation_03 { get; set; }
        [D(4, "1036")]
        public string NameFirst_04 { get; set; }
        [D(5, "1037")]
        public string NameMiddle_05 { get; set; }
        [D(6, "1038")]
        public string NamePrefix_06 { get; set; }
        [D(7, "1039")]
        public string NameSuffix_07 { get; set; }
        [D(8, "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, "67")]
        public string IdentificationCode_09 { get; set; }
        [D(10, "706")]
        public string EntityRelationshipCode_10 { get; set; }
        [D(11, "98")]
        public string EntityIdentifierCode_11 { get; set; }
        [D(12, "1035")]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    public class Loop_2310E_2
    {
        
        [S("NM1", 1, typeof(X12_ID_98_13), typeof(X12_ID_1065_2))]
        public NM1_AmbulancePick_upLocation_3 NM1_AmbulancePick_upLocation_3 { get; set; }
        [S("N3", 2)]
        public N3_AmbulancePick_upLocationAddress_3 N3_AmbulancePick_upLocationAddress_3 { get; set; }
        [S("N4", 3)]
        public N4_AmbulancePick_upLocationCity_State_ZipCode_3 N4_AmbulancePick_upLocationCity_State_ZipCode_3 { get; set; }
    }
    
    public class N4_AmbulancePick_upLocationCity_State_ZipCode_3
    {
        
        [D(1, "19")]
        public string AmbulancePickupCityName_01 { get; set; }
        [D(2, "156")]
        public string AmbulancePickupStateorProvinceCode_02 { get; set; }
        [D(3, "116")]
        public string AmbulancePickupPostalZoneorZIPCode_03 { get; set; }
        [D(4, "26")]
        public string CountryCode_04 { get; set; }
        [D(5, "309")]
        public string LocationQualifier_05 { get; set; }
        [D(6, "310")]
        public string LocationIdentifier_06 { get; set; }
        [D(7, "1715")]
        public string CountrySubdivisionCode_07 { get; set; }
    }
    
    public class N3_AmbulancePick_upLocationAddress_3
    {
        
        [D(1, "166")]
        public string AmbulancePickupAddressLine_01 { get; set; }
        [D(2, "166")]
        public string AmbulancePickupAddressLine_02 { get; set; }
    }
    
    public class NM1_AmbulancePick_upLocation_3
    {
        
        [D(1, "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, "1035")]
        public string NameLastorOrganizationName_03 { get; set; }
        [D(4, "1036")]
        public string NameFirst_04 { get; set; }
        [D(5, "1037")]
        public string NameMiddle_05 { get; set; }
        [D(6, "1038")]
        public string NamePrefix_06 { get; set; }
        [D(7, "1039")]
        public string NameSuffix_07 { get; set; }
        [D(8, "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, "67")]
        public string IdentificationCode_09 { get; set; }
        [D(10, "706")]
        public string EntityRelationshipCode_10 { get; set; }
        [D(11, "98")]
        public string EntityIdentifierCode_11 { get; set; }
        [D(12, "1035")]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    public class Loop_2310D_2
    {
        
        [S("NM1", 1, typeof(X12_ID_98_12), typeof(X12_ID_1065_3))]
        public NM1_SupervisingProviderName_3 NM1_SupervisingProviderName_3 { get; set; }
        [S("REF", 2, typeof(X12_ID_128_26))]
        public List<REF_SupervisingProviderSecondaryIdentification_3> REF_SupervisingProviderSecondaryIdentification_3 { get; set; }
    }
    
    public class REF_SupervisingProviderSecondaryIdentification_3
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string SupervisingProviderSecondaryIdentifier_02 { get; set; }
        [D(3, "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_73 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_73
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class NM1_SupervisingProviderName_3
    {
        
        [D(1, "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, "1035")]
        public string SupervisingProviderLastName_03 { get; set; }
        [D(4, "1036")]
        public string SupervisingProviderFirstName_04 { get; set; }
        [D(5, "1037")]
        public string SupervisingProviderMiddleNameorInitial_05 { get; set; }
        [D(6, "1038")]
        public string NamePrefix_06 { get; set; }
        [D(7, "1039")]
        public string SupervisingProviderNameSuffix_07 { get; set; }
        [D(8, "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, "67")]
        public string SupervisingProviderIdentifier_09 { get; set; }
        [D(10, "706")]
        public string EntityRelationshipCode_10 { get; set; }
        [D(11, "98")]
        public string EntityIdentifierCode_11 { get; set; }
        [D(12, "1035")]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    public class Loop_2310C_2
    {
        
        [S("NM1", 1, typeof(X12_ID_98_11), typeof(X12_ID_1065_2))]
        public NM1_ServiceFacilityLocationName_2 NM1_ServiceFacilityLocationName_2 { get; set; }
        [S("N3", 2)]
        public N3_ServiceFacilityLocationAddress_3 N3_ServiceFacilityLocationAddress_3 { get; set; }
        [S("N4", 3)]
        public N4_ServiceFacilityLocationCity_State_ZIPCode_3 N4_ServiceFacilityLocationCity_State_ZIPCode_3 { get; set; }
        [S("REF", 4, typeof(X12_ID_128_27))]
        public List<REF_ServiceFacilityLocationSecondaryIdentification_3> REF_ServiceFacilityLocationSecondaryIdentification_3 { get; set; }
        [S("PER", 5, typeof(X12_ID_366))]
        public PER_ServiceFacilityContactInformation_2 PER_ServiceFacilityContactInformation_2 { get; set; }
    }
    
    public class PER_ServiceFacilityContactInformation_2
    {
        
        [D(1, "366")]
        public string ContactFunctionCode_01 { get; set; }
        [D(2, "93")]
        public string Name_02 { get; set; }
        [D(3, "365")]
        public string CommunicationNumberQualifier_03 { get; set; }
        [D(4, "364")]
        public string CommunicationNumber_04 { get; set; }
        [D(5, "365")]
        public string CommunicationNumberQualifier_05 { get; set; }
        [D(6, "364")]
        public string CommunicationNumber_06 { get; set; }
        [D(7, "365")]
        public string CommunicationNumberQualifier_07 { get; set; }
        [D(8, "364")]
        public string CommunicationNumber_08 { get; set; }
        [D(9, "443")]
        public string ContactInquiryReference_09 { get; set; }
    }
    
    public class REF_ServiceFacilityLocationSecondaryIdentification_3
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string LaboratoryorFacilitySecondaryIdentifier_02 { get; set; }
        [D(3, "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_72 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_72
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class N4_ServiceFacilityLocationCity_State_ZIPCode_3
    {
        
        [D(1, "19")]
        public string LaboratoryorFacilityCityName_01 { get; set; }
        [D(2, "156")]
        public string LaboratoryorFacilityStateorProvinceCode_02 { get; set; }
        [D(3, "116")]
        public string LaboratoryorFacilityPostalZoneorZIPCode_03 { get; set; }
        [D(4, "26")]
        public string CountryCode_04 { get; set; }
        [D(5, "309")]
        public string LocationQualifier_05 { get; set; }
        [D(6, "310")]
        public string LocationIdentifier_06 { get; set; }
        [D(7, "1715")]
        public string CountrySubdivisionCode_07 { get; set; }
    }
    
    public class N3_ServiceFacilityLocationAddress_3
    {
        
        [D(1, "166")]
        public string LaboratoryorFacilityAddressLine_01 { get; set; }
        [D(2, "166")]
        public string LaboratoryorFacilityAddressLine_02 { get; set; }
    }
    
    public class NM1_ServiceFacilityLocationName_2
    {
        
        [D(1, "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, "1035")]
        public string LaboratoryorFacilityName_03 { get; set; }
        [D(4, "1036")]
        public string NameFirst_04 { get; set; }
        [D(5, "1037")]
        public string NameMiddle_05 { get; set; }
        [D(6, "1038")]
        public string NamePrefix_06 { get; set; }
        [D(7, "1039")]
        public string NameSuffix_07 { get; set; }
        [D(8, "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, "67")]
        public string LaboratoryorFacilityPrimaryIdentifier_09 { get; set; }
        [D(10, "706")]
        public string EntityRelationshipCode_10 { get; set; }
        [D(11, "98")]
        public string EntityIdentifierCode_11 { get; set; }
        [D(12, "1035")]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    public class Loop_2310B_2
    {
        
        [S("NM1", 1, typeof(X12_ID_98_10), typeof(X12_ID_1065))]
        public NM1_RenderingProviderName_3 NM1_RenderingProviderName_3 { get; set; }
        [S("PRV", 2, typeof(X12_ID_1221_2), typeof(X12_ID_128))]
        public PRV_RenderingProviderSpecialtyInformation_3 PRV_RenderingProviderSpecialtyInformation_3 { get; set; }
        [S("REF", 3, typeof(X12_ID_128_26))]
        public List<REF_RenderingProviderSecondaryIdentification_3> REF_RenderingProviderSecondaryIdentification_3 { get; set; }
    }
    
    public class REF_RenderingProviderSecondaryIdentification_3
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string RenderingProviderSecondaryIdentifier_02 { get; set; }
        [D(3, "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_71 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_71
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class PRV_RenderingProviderSpecialtyInformation_3
    {
        
        [D(1, "1221")]
        public string ProviderCode_01 { get; set; }
        [D(2, "128")]
        public string ReferenceIdentificationQualifier_02 { get; set; }
        [D(3, "127")]
        public string ProviderTaxonomyCode_03 { get; set; }
        [D(4, "156")]
        public string StateorProvinceCode_04 { get; set; }
        [C(5)]
        public C035_ProviderSpecialtyInformation_4 ProviderSpecialtyInformation_05 { get; set; }
        [D(6, "1223")]
        public string ProviderOrganizationCode_06 { get; set; }
    }
    
    public class C035_ProviderSpecialtyInformation_4
    {
        
        [D(1, "1222")]
        public string ProviderSpecialtyCode_01 { get; set; }
        [D(2, "559")]
        public string AgencyQualifierCode_02 { get; set; }
        [D(3, "1073")]
        public string YesNoConditionorResponseCode_03 { get; set; }
    }
    
    public class NM1_RenderingProviderName_3
    {
        
        [D(1, "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, "1035")]
        public string RenderingProviderLastorOrganizationName_03 { get; set; }
        [D(4, "1036")]
        public string RenderingProviderFirstName_04 { get; set; }
        [D(5, "1037")]
        public string RenderingProviderMiddleNameorInitial_05 { get; set; }
        [D(6, "1038")]
        public string NamePrefix_06 { get; set; }
        [D(7, "1039")]
        public string RenderingProviderNameSuffix_07 { get; set; }
        [D(8, "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, "67")]
        public string RenderingProviderIdentifier_09 { get; set; }
        [D(10, "706")]
        public string EntityRelationshipCode_10 { get; set; }
        [D(11, "98")]
        public string EntityIdentifierCode_11 { get; set; }
        [D(12, "1035")]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    public class Loop_2310A_2
    {
        
        [S("NM1", 1, typeof(X12_ID_98_9), typeof(X12_ID_1065_3))]
        public NM1_ReferringProviderName_3 NM1_ReferringProviderName_3 { get; set; }
        [S("REF", 2, typeof(X12_ID_128_25))]
        public List<REF_ReferringProviderSecondaryIdentification_3> REF_ReferringProviderSecondaryIdentification_3 { get; set; }
    }
    
    public class REF_ReferringProviderSecondaryIdentification_3
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string ReferringProviderSecondaryIdentifier_02 { get; set; }
        [D(3, "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_70 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_70
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class NM1_ReferringProviderName_3
    {
        
        [D(1, "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, "1035")]
        public string ReferringProviderLastName_03 { get; set; }
        [D(4, "1036")]
        public string ReferringProviderFirstName_04 { get; set; }
        [D(5, "1037")]
        public string ReferringProviderMiddleNameorInitial_05 { get; set; }
        [D(6, "1038")]
        public string NamePrefix_06 { get; set; }
        [D(7, "1039")]
        public string ReferringProviderNameSuffix_07 { get; set; }
        [D(8, "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, "67")]
        public string ReferringProviderIdentifier_09 { get; set; }
        [D(10, "706")]
        public string EntityRelationshipCode_10 { get; set; }
        [D(11, "98")]
        public string EntityIdentifierCode_11 { get; set; }
        [D(12, "1035")]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    public class HCP_ClaimPricing_RepricingInformation_2
    {
        
        [D(1, "1473")]
        public string PricingMethodology_01 { get; set; }
        [D(2, "782")]
        public string RepricedAllowedAmount_02 { get; set; }
        [D(3, "782")]
        public string RepricedSavingAmount_03 { get; set; }
        [D(4, "127")]
        public string RepricingOrganizationIdentifier_04 { get; set; }
        [D(5, "118")]
        public string RepricingPerDiemorFlatRateAmount_05 { get; set; }
        [D(6, "127")]
        public string RepricedApprovedAmbulatoryPatientGroupCode_06 { get; set; }
        [D(7, "782")]
        public string RepricedApprovedAmbulatoryPatientGroupAmount_07 { get; set; }
        [D(8, "234")]
        public string ProductServiceID_08 { get; set; }
        [D(9, "235")]
        public string ProductServiceIDQualifier_09 { get; set; }
        [D(10, "234")]
        public string ProductServiceID_10 { get; set; }
        [D(11, "355")]
        public string UnitorBasisforMeasurementCode_11 { get; set; }
        [D(12, "380")]
        public string Quantity_12 { get; set; }
        [D(13, "901")]
        public string RejectReasonCode_13 { get; set; }
        [D(14, "1526")]
        public string PolicyComplianceCode_14 { get; set; }
        [D(15, "1527")]
        public string ExceptionCode_15 { get; set; }
    }
    
    public class All_HI_2
    {
        
        [S("HI", 1, typeof(X12_ID_1270_2), typeof(X12_ID_1270_3))]
        public HI_HealthCareDiagnosisCode_2 HI_HealthCareDiagnosisCode_2 { get; set; }
        [S("HI", 2, typeof(X12_ID_1270_4), typeof(X12_ID_1270_5))]
        public HI_AnesthesiaRelatedProcedure_2 HI_AnesthesiaRelatedProcedure_2 { get; set; }
        [S("HI", 3, typeof(X12_ID_1270_6), typeof(X12_ID_1270_6))]
        public List<HI_ConditionInformation_2> HI_ConditionInformation_2 { get; set; }
    }
    
    [E(",ABK,BK,")]
    public class X12_ID_1270_2
    {
    }
    
    [E(",ABF,BF,")]
    public class X12_ID_1270_3
    {
    }
    
    [E(",BP,")]
    public class X12_ID_1270_4
    {
    }
    
    [E(",BO,")]
    public class X12_ID_1270_5
    {
    }
    
    [E(",BG,")]
    public class X12_ID_1270_6
    {
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
        
        [D(1, "1270")]
        public string CodeListQualifierCode_01 { get; set; }
        [D(2, "1271")]
        public string ConditionCode_02 { get; set; }
        [D(3, "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, "380")]
        public string Quantity_06 { get; set; }
        [D(7, "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_71
    {
        
        [D(1, "1270")]
        public string CodeListQualifierCode_01 { get; set; }
        [D(2, "1271")]
        public string ConditionCode_02 { get; set; }
        [D(3, "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, "380")]
        public string Quantity_06 { get; set; }
        [D(7, "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_70
    {
        
        [D(1, "1270")]
        public string CodeListQualifierCode_01 { get; set; }
        [D(2, "1271")]
        public string ConditionCode_02 { get; set; }
        [D(3, "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, "380")]
        public string Quantity_06 { get; set; }
        [D(7, "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_69
    {
        
        [D(1, "1270")]
        public string CodeListQualifierCode_01 { get; set; }
        [D(2, "1271")]
        public string ConditionCode_02 { get; set; }
        [D(3, "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, "380")]
        public string Quantity_06 { get; set; }
        [D(7, "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_68
    {
        
        [D(1, "1270")]
        public string CodeListQualifierCode_01 { get; set; }
        [D(2, "1271")]
        public string ConditionCode_02 { get; set; }
        [D(3, "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, "380")]
        public string Quantity_06 { get; set; }
        [D(7, "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_67
    {
        
        [D(1, "1270")]
        public string CodeListQualifierCode_01 { get; set; }
        [D(2, "1271")]
        public string ConditionCode_02 { get; set; }
        [D(3, "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, "380")]
        public string Quantity_06 { get; set; }
        [D(7, "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_66
    {
        
        [D(1, "1270")]
        public string CodeListQualifierCode_01 { get; set; }
        [D(2, "1271")]
        public string ConditionCode_02 { get; set; }
        [D(3, "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, "380")]
        public string Quantity_06 { get; set; }
        [D(7, "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_65
    {
        
        [D(1, "1270")]
        public string CodeListQualifierCode_01 { get; set; }
        [D(2, "1271")]
        public string ConditionCode_02 { get; set; }
        [D(3, "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, "380")]
        public string Quantity_06 { get; set; }
        [D(7, "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_64
    {
        
        [D(1, "1270")]
        public string CodeListQualifierCode_01 { get; set; }
        [D(2, "1271")]
        public string ConditionCode_02 { get; set; }
        [D(3, "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, "380")]
        public string Quantity_06 { get; set; }
        [D(7, "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_63
    {
        
        [D(1, "1270")]
        public string CodeListQualifierCode_01 { get; set; }
        [D(2, "1271")]
        public string ConditionCode_02 { get; set; }
        [D(3, "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, "380")]
        public string Quantity_06 { get; set; }
        [D(7, "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_62
    {
        
        [D(1, "1270")]
        public string CodeListQualifierCode_01 { get; set; }
        [D(2, "1271")]
        public string ConditionCode_02 { get; set; }
        [D(3, "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, "380")]
        public string Quantity_06 { get; set; }
        [D(7, "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_61
    {
        
        [D(1, "1270")]
        public string CodeListQualifierCode_01 { get; set; }
        [D(2, "1271")]
        public string ConditionCode_02 { get; set; }
        [D(3, "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, "380")]
        public string Quantity_06 { get; set; }
        [D(7, "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, "1073")]
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
        
        [D(1, "1270")]
        public string CodeListQualifierCode_01 { get; set; }
        [D(2, "1271")]
        public string IndustryCode_02 { get; set; }
        [D(3, "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, "380")]
        public string Quantity_06 { get; set; }
        [D(7, "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_59
    {
        
        [D(1, "1270")]
        public string CodeListQualifierCode_01 { get; set; }
        [D(2, "1271")]
        public string IndustryCode_02 { get; set; }
        [D(3, "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, "380")]
        public string Quantity_06 { get; set; }
        [D(7, "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_58
    {
        
        [D(1, "1270")]
        public string CodeListQualifierCode_01 { get; set; }
        [D(2, "1271")]
        public string IndustryCode_02 { get; set; }
        [D(3, "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, "380")]
        public string Quantity_06 { get; set; }
        [D(7, "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_57
    {
        
        [D(1, "1270")]
        public string CodeListQualifierCode_01 { get; set; }
        [D(2, "1271")]
        public string IndustryCode_02 { get; set; }
        [D(3, "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, "380")]
        public string Quantity_06 { get; set; }
        [D(7, "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_56
    {
        
        [D(1, "1270")]
        public string CodeListQualifierCode_01 { get; set; }
        [D(2, "1271")]
        public string IndustryCode_02 { get; set; }
        [D(3, "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, "380")]
        public string Quantity_06 { get; set; }
        [D(7, "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_55
    {
        
        [D(1, "1270")]
        public string CodeListQualifierCode_01 { get; set; }
        [D(2, "1271")]
        public string IndustryCode_02 { get; set; }
        [D(3, "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, "380")]
        public string Quantity_06 { get; set; }
        [D(7, "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_54
    {
        
        [D(1, "1270")]
        public string CodeListQualifierCode_01 { get; set; }
        [D(2, "1271")]
        public string IndustryCode_02 { get; set; }
        [D(3, "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, "380")]
        public string Quantity_06 { get; set; }
        [D(7, "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_53
    {
        
        [D(1, "1270")]
        public string CodeListQualifierCode_01 { get; set; }
        [D(2, "1271")]
        public string IndustryCode_02 { get; set; }
        [D(3, "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, "380")]
        public string Quantity_06 { get; set; }
        [D(7, "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_52
    {
        
        [D(1, "1270")]
        public string CodeListQualifierCode_01 { get; set; }
        [D(2, "1271")]
        public string IndustryCode_02 { get; set; }
        [D(3, "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, "380")]
        public string Quantity_06 { get; set; }
        [D(7, "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_51
    {
        
        [D(1, "1270")]
        public string CodeListQualifierCode_01 { get; set; }
        [D(2, "1271")]
        public string IndustryCode_02 { get; set; }
        [D(3, "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, "380")]
        public string Quantity_06 { get; set; }
        [D(7, "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_50
    {
        
        [D(1, "1270")]
        public string CodeListQualifierCode_01 { get; set; }
        [D(2, "1271")]
        public string IndustryCode_02 { get; set; }
        [D(3, "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, "380")]
        public string Quantity_06 { get; set; }
        [D(7, "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_49
    {
        
        [D(1, "1270")]
        public string CodeListQualifierCode_01 { get; set; }
        [D(2, "1271")]
        public string AnesthesiaRelatedSurgicalProcedure_02 { get; set; }
        [D(3, "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, "380")]
        public string Quantity_06 { get; set; }
        [D(7, "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
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
        
        [D(1, "1270")]
        public string DiagnosisTypeCode_01 { get; set; }
        [D(2, "1271")]
        public string DiagnosisCode_02 { get; set; }
        [D(3, "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, "380")]
        public string Quantity_06 { get; set; }
        [D(7, "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_47
    {
        
        [D(1, "1270")]
        public string DiagnosisTypeCode_01 { get; set; }
        [D(2, "1271")]
        public string DiagnosisCode_02 { get; set; }
        [D(3, "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, "380")]
        public string Quantity_06 { get; set; }
        [D(7, "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_46
    {
        
        [D(1, "1270")]
        public string DiagnosisTypeCode_01 { get; set; }
        [D(2, "1271")]
        public string DiagnosisCode_02 { get; set; }
        [D(3, "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, "380")]
        public string Quantity_06 { get; set; }
        [D(7, "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_45
    {
        
        [D(1, "1270")]
        public string DiagnosisTypeCode_01 { get; set; }
        [D(2, "1271")]
        public string DiagnosisCode_02 { get; set; }
        [D(3, "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, "380")]
        public string Quantity_06 { get; set; }
        [D(7, "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_44
    {
        
        [D(1, "1270")]
        public string DiagnosisTypeCode_01 { get; set; }
        [D(2, "1271")]
        public string DiagnosisCode_02 { get; set; }
        [D(3, "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, "380")]
        public string Quantity_06 { get; set; }
        [D(7, "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_43
    {
        
        [D(1, "1270")]
        public string DiagnosisTypeCode_01 { get; set; }
        [D(2, "1271")]
        public string DiagnosisCode_02 { get; set; }
        [D(3, "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, "380")]
        public string Quantity_06 { get; set; }
        [D(7, "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_42
    {
        
        [D(1, "1270")]
        public string DiagnosisTypeCode_01 { get; set; }
        [D(2, "1271")]
        public string DiagnosisCode_02 { get; set; }
        [D(3, "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, "380")]
        public string Quantity_06 { get; set; }
        [D(7, "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_41
    {
        
        [D(1, "1270")]
        public string DiagnosisTypeCode_01 { get; set; }
        [D(2, "1271")]
        public string DiagnosisCode_02 { get; set; }
        [D(3, "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, "380")]
        public string Quantity_06 { get; set; }
        [D(7, "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_40
    {
        
        [D(1, "1270")]
        public string DiagnosisTypeCode_01 { get; set; }
        [D(2, "1271")]
        public string DiagnosisCode_02 { get; set; }
        [D(3, "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, "380")]
        public string Quantity_06 { get; set; }
        [D(7, "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_39
    {
        
        [D(1, "1270")]
        public string DiagnosisTypeCode_01 { get; set; }
        [D(2, "1271")]
        public string DiagnosisCode_02 { get; set; }
        [D(3, "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, "380")]
        public string Quantity_06 { get; set; }
        [D(7, "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_38
    {
        
        [D(1, "1270")]
        public string DiagnosisTypeCode_01 { get; set; }
        [D(2, "1271")]
        public string DiagnosisCode_02 { get; set; }
        [D(3, "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, "380")]
        public string Quantity_06 { get; set; }
        [D(7, "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_37
    {
        
        [D(1, "1270")]
        public string DiagnosisTypeCode_01 { get; set; }
        [D(2, "1271")]
        public string DiagnosisCode_02 { get; set; }
        [D(3, "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, "380")]
        public string Quantity_06 { get; set; }
        [D(7, "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class All_CRC_3
    {
        
        [S("CRC", 1, typeof(X12_ID_1136), typeof(X12_ID_1073_3))]
        public List<CRC_AmbulanceCertification_3> CRC_AmbulanceCertification_3 { get; set; }
        [S("CRC", 2, typeof(X12_ID_1136_2), typeof(X12_ID_1073_3))]
        public List<CRC_PatientConditionInformation_Vision_2> CRC_PatientConditionInformation_Vision_2 { get; set; }
        [S("CRC", 3, typeof(X12_ID_1136_3), typeof(X12_ID_1073_2))]
        public CRC_HomeboundIndicator_2 CRC_HomeboundIndicator_2 { get; set; }
        [S("CRC", 4, typeof(X12_ID_1136_4), typeof(X12_ID_1073_3))]
        public CRC_EPSDTReferral_2 CRC_EPSDTReferral_2 { get; set; }
    }
    
    [E(",E1,E2,E3,")]
    public class X12_ID_1136_2
    {
    }
    
    [E(",75,")]
    public class X12_ID_1136_3
    {
    }
    
    [E(",Y,")]
    public class X12_ID_1073_2
    {
    }
    
    [E(",ZZ,")]
    public class X12_ID_1136_4
    {
    }
    
    public class CRC_EPSDTReferral_2
    {
        
        [D(1, "1136")]
        public string CodeQualifier_01 { get; set; }
        [D(2, "1073")]
        public string CertificationConditionCodeAppliesIndicator_02 { get; set; }
        [D(3, "1321")]
        public string ConditionIndicator_03 { get; set; }
        [D(4, "1321")]
        public string ConditionIndicator_04 { get; set; }
        [D(5, "1321")]
        public string ConditionIndicator_05 { get; set; }
        [D(6, "1321")]
        public string ConditionIndicator_06 { get; set; }
        [D(7, "1321")]
        public string ConditionIndicator_07 { get; set; }
    }
    
    public class CRC_HomeboundIndicator_2
    {
        
        [D(1, "1136")]
        public string CodeCategory_01 { get; set; }
        [D(2, "1073")]
        public string CertificationConditionIndicator_02 { get; set; }
        [D(3, "1321")]
        public string HomeboundIndicator_03 { get; set; }
        [D(4, "1321")]
        public string ConditionIndicator_04 { get; set; }
        [D(5, "1321")]
        public string ConditionIndicator_05 { get; set; }
        [D(6, "1321")]
        public string ConditionIndicator_06 { get; set; }
        [D(7, "1321")]
        public string ConditionIndicator_07 { get; set; }
    }
    
    public class CRC_PatientConditionInformation_Vision_2
    {
        
        [D(1, "1136")]
        public string CodeCategory_01 { get; set; }
        [D(2, "1073")]
        public string CertificationConditionIndicator_02 { get; set; }
        [D(3, "1321")]
        public string ConditionCode_03 { get; set; }
        [D(4, "1321")]
        public string ConditionCode_04 { get; set; }
        [D(5, "1321")]
        public string ConditionCode_05 { get; set; }
        [D(6, "1321")]
        public string ConditionCode_06 { get; set; }
        [D(7, "1321")]
        public string ConditionCode_07 { get; set; }
    }
    
    public class CRC_AmbulanceCertification_3
    {
        
        [D(1, "1136")]
        public string CodeCategory_01 { get; set; }
        [D(2, "1073")]
        public string CertificationConditionIndicator_02 { get; set; }
        [D(3, "1321")]
        public string ConditionCode_03 { get; set; }
        [D(4, "1321")]
        public string ConditionCode_04 { get; set; }
        [D(5, "1321")]
        public string ConditionCode_05 { get; set; }
        [D(6, "1321")]
        public string ConditionCode_06 { get; set; }
        [D(7, "1321")]
        public string ConditionCode_07 { get; set; }
    }
    
    public class CR2_SpinalManipulationServiceInformation_2
    {
        
        [D(1, "609")]
        public string Count_01 { get; set; }
        [D(2, "380")]
        public string Quantity_02 { get; set; }
        [D(3, "1367")]
        public string SubluxationLevelCode_03 { get; set; }
        [D(4, "1367")]
        public string SubluxationLevelCode_04 { get; set; }
        [D(5, "355")]
        public string UnitorBasisforMeasurementCode_05 { get; set; }
        [D(6, "380")]
        public string Quantity_06 { get; set; }
        [D(7, "380")]
        public string Quantity_07 { get; set; }
        [D(8, "1342")]
        public string PatientConditionCode_08 { get; set; }
        [D(9, "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
        [D(10, "352")]
        public string PatientConditionDescription_10 { get; set; }
        [D(11, "352")]
        public string PatientConditionDescription_11 { get; set; }
        [D(12, "1073")]
        public string YesNoConditionorResponseCode_12 { get; set; }
    }
    
    public class CR1_AmbulanceTransportInformation_3
    {
        
        [D(1, "355")]
        public string UnitorBasisforMeasurementCode_01 { get; set; }
        [D(2, "81")]
        public string PatientWeight_02 { get; set; }
        [D(3, "1316")]
        public string AmbulanceTransportCode_03 { get; set; }
        [D(4, "1317")]
        public string AmbulanceTransportReasonCode_04 { get; set; }
        [D(5, "355")]
        public string UnitorBasisforMeasurementCode_05 { get; set; }
        [D(6, "380")]
        public string TransportDistance_06 { get; set; }
        [D(7, "166")]
        public string AddressInformation_07 { get; set; }
        [D(8, "166")]
        public string AddressInformation_08 { get; set; }
        [D(9, "352")]
        public string RoundTripPurposeDescription_09 { get; set; }
        [D(10, "352")]
        public string StretcherPurposeDescription_10 { get; set; }
    }
    
    public class NTE_ClaimNote_2
    {
        
        [D(1, "363")]
        public string NoteReferenceCode_01 { get; set; }
        [D(2, "352")]
        public string ClaimNoteText_02 { get; set; }
    }
    
    public class K3_FileInformation_3
    {
        
        [D(1, "449")]
        public string FixedFormatInformation_01 { get; set; }
        [D(2, "1333")]
        public string RecordFormatCode_02 { get; set; }
        [C(3)]
        public C001_CompositeUnitofMeasure_7 CompositeUnitofMeasure_03 { get; set; }
    }
    
    public class C001_CompositeUnitofMeasure_7
    {
        
        [D(1, "355")]
        public string UnitorBasisforMeasurementCode_01 { get; set; }
        [D(2, "1018")]
        public string Exponent_02 { get; set; }
        [D(3, "649")]
        public string Multiplier_03 { get; set; }
        [D(4, "355")]
        public string UnitorBasisforMeasurementCode_04 { get; set; }
        [D(5, "1018")]
        public string Exponent_05 { get; set; }
        [D(6, "649")]
        public string Multiplier_06 { get; set; }
        [D(7, "355")]
        public string UnitorBasisforMeasurementCode_07 { get; set; }
        [D(8, "1018")]
        public string Exponent_08 { get; set; }
        [D(9, "649")]
        public string Multiplier_09 { get; set; }
        [D(10, "355")]
        public string UnitorBasisforMeasurementCode_10 { get; set; }
        [D(11, "1018")]
        public string Exponent_11 { get; set; }
        [D(12, "649")]
        public string Multiplier_12 { get; set; }
        [D(13, "355")]
        public string UnitorBasisforMeasurementCode_13 { get; set; }
        [D(14, "1018")]
        public string Exponent_14 { get; set; }
        [D(15, "649")]
        public string Multiplier_15 { get; set; }
    }
    
    public class All_REF_9
    {
        
        [S("REF", 1, typeof(X12_ID_128_11), typeof(X12_ID_127_1))]
        public REF_ServiceAuthorizationExceptionCode_2 REF_ServiceAuthorizationExceptionCode_2 { get; set; }
        [S("REF", 2, typeof(X12_ID_128_12), typeof(X12_ID_127_2))]
        public REF_MandatoryMedicare_Section4081_CrossoverIndicator_2 REF_MandatoryMedicare_Section4081_CrossoverIndicator_2 { get; set; }
        [S("REF", 3, typeof(X12_ID_128_13))]
        public REF_MammographyCertificationNumber_3 REF_MammographyCertificationNumber_3 { get; set; }
        [S("REF", 4, typeof(X12_ID_128_14))]
        public REF_ReferralNumber_3 REF_ReferralNumber_3 { get; set; }
        [S("REF", 5, typeof(X12_ID_128_15))]
        public REF_PriorAuthorization_3 REF_PriorAuthorization_3 { get; set; }
        [S("REF", 6, typeof(X12_ID_128_16))]
        public REF_PayerClaimControlNumber_2 REF_PayerClaimControlNumber_2 { get; set; }
        [S("REF", 7, typeof(X12_ID_128_17))]
        public REF_ClinicalLaboratoryImprovementAmendment_CLIA_Number_3 REF_ClinicalLaboratoryImprovementAmendment_CLIA_Number_3 { get; set; }
        [S("REF", 8, typeof(X12_ID_128_18))]
        public REF_RepricedClaimNumber_2 REF_RepricedClaimNumber_2 { get; set; }
        [S("REF", 9, typeof(X12_ID_128_19))]
        public REF_AdjustedRepricedClaimNumber_2 REF_AdjustedRepricedClaimNumber_2 { get; set; }
        [S("REF", 10, typeof(X12_ID_128_20))]
        public REF_InvestigationalDeviceExemptionNumber_2 REF_InvestigationalDeviceExemptionNumber_2 { get; set; }
        [S("REF", 11, typeof(X12_ID_128_21))]
        public REF_ClaimIdentifierForTransmissionIntermediaries_2 REF_ClaimIdentifierForTransmissionIntermediaries_2 { get; set; }
        [S("REF", 12, typeof(X12_ID_128_22))]
        public REF_MedicalRecordNumber_2 REF_MedicalRecordNumber_2 { get; set; }
        [S("REF", 13, typeof(X12_ID_128_23))]
        public REF_DemonstrationProjectIdentifier_2 REF_DemonstrationProjectIdentifier_2 { get; set; }
        [S("REF", 14, typeof(X12_ID_128_24))]
        public REF_CarePlanOversight_2 REF_CarePlanOversight_2 { get; set; }
    }
    
    [E(",4N,")]
    public class X12_ID_128_11
    {
    }
    
    [E(",1,2,3,4,5,6,7,")]
    public class X12_ID_127_1
    {
    }
    
    [E(",F5,")]
    public class X12_ID_128_12
    {
    }
    
    [E(",N,Y,")]
    public class X12_ID_127_2
    {
    }
    
    [E(",9A,")]
    public class X12_ID_128_18
    {
    }
    
    [E(",9C,")]
    public class X12_ID_128_19
    {
    }
    
    [E(",LX,")]
    public class X12_ID_128_20
    {
    }
    
    [E(",D9,")]
    public class X12_ID_128_21
    {
    }
    
    [E(",EA,")]
    public class X12_ID_128_22
    {
    }
    
    [E(",P4,")]
    public class X12_ID_128_23
    {
    }
    
    [E(",1J,")]
    public class X12_ID_128_24
    {
    }
    
    public class REF_CarePlanOversight_2
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string CarePlanOversightNumber_02 { get; set; }
        [D(3, "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_69 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_69
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_DemonstrationProjectIdentifier_2
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string DemonstrationProjectIdentifier_02 { get; set; }
        [D(3, "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_68 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_68
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_MedicalRecordNumber_2
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string MedicalRecordNumber_02 { get; set; }
        [D(3, "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_67 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_67
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_ClaimIdentifierForTransmissionIntermediaries_2
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string ValueAddedNetworkTraceNumber_02 { get; set; }
        [D(3, "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_66 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_66
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_InvestigationalDeviceExemptionNumber_2
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string InvestigationalDeviceExemptionIdentifier_02 { get; set; }
        [D(3, "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_65 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_65
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_AdjustedRepricedClaimNumber_2
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string AdjustedRepricedClaimReferenceNumber_02 { get; set; }
        [D(3, "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_64 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_64
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_RepricedClaimNumber_2
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string RepricedClaimReferenceNumber_02 { get; set; }
        [D(3, "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_63 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_63
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_ClinicalLaboratoryImprovementAmendment_CLIA_Number_3
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string ClinicalLaboratoryImprovementAmendmentNumber_02 { get; set; }
        [D(3, "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_62 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_62
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_PayerClaimControlNumber_2
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string PayerClaimControlNumber_02 { get; set; }
        [D(3, "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_61 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_61
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_PriorAuthorization_3
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string PriorAuthorizationNumber_02 { get; set; }
        [D(3, "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_60 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_60
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_ReferralNumber_3
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string ReferralNumber_02 { get; set; }
        [D(3, "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_59 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_59
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_MammographyCertificationNumber_3
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string MammographyCertificationNumber_02 { get; set; }
        [D(3, "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_58 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_58
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_MandatoryMedicare_Section4081_CrossoverIndicator_2
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string MedicareSection4081Indicator_02 { get; set; }
        [D(3, "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_57 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_57
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_ServiceAuthorizationExceptionCode_2
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string ServiceAuthorizationExceptionCode_02 { get; set; }
        [D(3, "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_56 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_56
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class AMT_PatientAmountPaid_2
    {
        
        [D(1, "522")]
        public string AmountQualifierCode_01 { get; set; }
        [D(2, "782")]
        public string PatientAmountPaid_02 { get; set; }
        [D(3, "478")]
        public string CreditDebitFlagCode_03 { get; set; }
    }
    
    public class CN1_ContractInformation_3
    {
        
        [D(1, "1166")]
        public string ContractTypeCode_01 { get; set; }
        [D(2, "782")]
        public string ContractAmount_02 { get; set; }
        [D(3, "332")]
        public string ContractPercentage_03 { get; set; }
        [D(4, "127")]
        public string ContractCode_04 { get; set; }
        [D(5, "338")]
        public string TermsDiscountPercentage_05 { get; set; }
        [D(6, "799")]
        public string ContractVersionIdentifier_06 { get; set; }
    }
    
    public class PWK_ClaimSupplementalInformation_2
    {
        
        [D(1, "755")]
        public string AttachmentReportTypeCode_01 { get; set; }
        [D(2, "756")]
        public string AttachmentTransmissionCode_02 { get; set; }
        [D(3, "757")]
        public string ReportCopiesNeeded_03 { get; set; }
        [D(4, "98")]
        public string EntityIdentifierCode_04 { get; set; }
        [D(5, "66")]
        public string IdentificationCodeQualifier_05 { get; set; }
        [D(6, "67")]
        public string AttachmentControlNumber_06 { get; set; }
        [D(7, "352")]
        public string Description_07 { get; set; }
        [C(8)]
        public C002_ActionsIndicated_4 ActionsIndicated_08 { get; set; }
        [D(9, "1525")]
        public string RequestCategoryCode_09 { get; set; }
    }
    
    public class C002_ActionsIndicated_4
    {
        
        [D(1, "704")]
        public string PaperworkReportActionCode_01 { get; set; }
        [D(2, "704")]
        public string PaperworkReportActionCode_02 { get; set; }
        [D(3, "704")]
        public string PaperworkReportActionCode_03 { get; set; }
        [D(4, "704")]
        public string PaperworkReportActionCode_04 { get; set; }
        [D(5, "704")]
        public string PaperworkReportActionCode_05 { get; set; }
    }
    
    public class All_DTP_3
    {
        
        [S("DTP", 1, typeof(X12_ID_374_2), typeof(X12_ID_1250))]
        public DTP_Date_OnsetofCurrentIllnessorSymptom_2 DTP_Date_OnsetofCurrentIllnessorSymptom_2 { get; set; }
        [S("DTP", 2, typeof(X12_ID_374_3), typeof(X12_ID_1250))]
        public DTP_Date_InitialTreatmentDate_3 DTP_Date_InitialTreatmentDate_3 { get; set; }
        [S("DTP", 3, typeof(X12_ID_374_4), typeof(X12_ID_1250))]
        public DTP_Date_LastSeenDate_3 DTP_Date_LastSeenDate_3 { get; set; }
        [S("DTP", 4, typeof(X12_ID_374_5), typeof(X12_ID_1250))]
        public DTP_Date_AcuteManifestation_2 DTP_Date_AcuteManifestation_2 { get; set; }
        [S("DTP", 5, typeof(X12_ID_374_6), typeof(X12_ID_1250))]
        public DTP_Date_Accident_2 DTP_Date_Accident_2 { get; set; }
        [S("DTP", 6, typeof(X12_ID_374_7), typeof(X12_ID_1250))]
        public DTP_Date_LastMenstrualPeriod_2 DTP_Date_LastMenstrualPeriod_2 { get; set; }
        [S("DTP", 7, typeof(X12_ID_374_8), typeof(X12_ID_1250))]
        public DTP_Date_LastX_rayDate_3 DTP_Date_LastX_rayDate_3 { get; set; }
        [S("DTP", 8, typeof(X12_ID_374_9), typeof(X12_ID_1250))]
        public DTP_Date_HearingandVisionPrescriptionDate_2 DTP_Date_HearingandVisionPrescriptionDate_2 { get; set; }
        [S("DTP", 9, typeof(X12_ID_374_10), typeof(X12_ID_1250_2))]
        public DTP_Date_DisabilityDates_2 DTP_Date_DisabilityDates_2 { get; set; }
        [S("DTP", 10, typeof(X12_ID_374_11), typeof(X12_ID_1250))]
        public DTP_Date_LastWorked_2 DTP_Date_LastWorked_2 { get; set; }
        [S("DTP", 11, typeof(X12_ID_374_12), typeof(X12_ID_1250))]
        public DTP_Date_AuthorizedReturntoWork_2 DTP_Date_AuthorizedReturntoWork_2 { get; set; }
        [S("DTP", 12, typeof(X12_ID_374_13), typeof(X12_ID_1250))]
        public DTP_Date_Admission_2 DTP_Date_Admission_2 { get; set; }
        [S("DTP", 13, typeof(X12_ID_374_14), typeof(X12_ID_1250))]
        public DTP_Date_Discharge_2 DTP_Date_Discharge_2 { get; set; }
        [S("DTP", 14, typeof(X12_ID_374_15), typeof(X12_ID_1250))]
        public List<DTP_Date_AssumedandRelinquishedCareDates_2> DTP_Date_AssumedandRelinquishedCareDates_2 { get; set; }
        [S("DTP", 15, typeof(X12_ID_374_16), typeof(X12_ID_1250))]
        public DTP_PropertyandCasualtyDateofFirstContact_2 DTP_PropertyandCasualtyDateofFirstContact_2 { get; set; }
        [S("DTP", 16, typeof(X12_ID_374_17), typeof(X12_ID_1250))]
        public DTP_Date_RepricerReceivedDate_2 DTP_Date_RepricerReceivedDate_2 { get; set; }
    }
    
    [E(",431,")]
    public class X12_ID_374_2
    {
    }
    
    [E(",453,")]
    public class X12_ID_374_5
    {
    }
    
    [E(",439,")]
    public class X12_ID_374_6
    {
    }
    
    [E(",484,")]
    public class X12_ID_374_7
    {
    }
    
    [E(",314,360,361,")]
    public class X12_ID_374_10
    {
    }
    
    [E(",297,")]
    public class X12_ID_374_11
    {
    }
    
    [E(",296,")]
    public class X12_ID_374_12
    {
    }
    
    [E(",435,")]
    public class X12_ID_374_13
    {
    }
    
    [E(",096,")]
    public class X12_ID_374_14
    {
    }
    
    [E(",090,091,")]
    public class X12_ID_374_15
    {
    }
    
    [E(",444,")]
    public class X12_ID_374_16
    {
    }
    
    [E(",050,")]
    public class X12_ID_374_17
    {
    }
    
    public class DTP_Date_RepricerReceivedDate_2
    {
        
        [D(1, "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, "1251")]
        public string RepricerReceivedDate_03 { get; set; }
    }
    
    public class DTP_PropertyandCasualtyDateofFirstContact_2
    {
        
        [D(1, "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, "1251")]
        public string DateTimePeriod_03 { get; set; }
    }
    
    public class DTP_Date_AssumedandRelinquishedCareDates_2
    {
        
        [D(1, "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, "1251")]
        public string AssumedorRelinquishedCareDate_03 { get; set; }
    }
    
    public class DTP_Date_Discharge_2
    {
        
        [D(1, "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, "1251")]
        public string RelatedHospitalizationDischargeDate_03 { get; set; }
    }
    
    public class DTP_Date_Admission_2
    {
        
        [D(1, "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, "1251")]
        public string RelatedHospitalizationAdmissionDate_03 { get; set; }
    }
    
    public class DTP_Date_AuthorizedReturntoWork_2
    {
        
        [D(1, "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, "1251")]
        public string WorkReturnDate_03 { get; set; }
    }
    
    public class DTP_Date_LastWorked_2
    {
        
        [D(1, "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, "1251")]
        public string LastWorkedDate_03 { get; set; }
    }
    
    public class DTP_Date_DisabilityDates_2
    {
        
        [D(1, "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, "1251")]
        public string DisabilityFromDate_03 { get; set; }
    }
    
    public class DTP_Date_HearingandVisionPrescriptionDate_2
    {
        
        [D(1, "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, "1251")]
        public string PrescriptionDate_03 { get; set; }
    }
    
    public class DTP_Date_LastX_rayDate_3
    {
        
        [D(1, "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, "1251")]
        public string LastXRayDate_03 { get; set; }
    }
    
    public class DTP_Date_LastMenstrualPeriod_2
    {
        
        [D(1, "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, "1251")]
        public string LastMenstrualPeriodDate_03 { get; set; }
    }
    
    public class DTP_Date_Accident_2
    {
        
        [D(1, "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, "1251")]
        public string AccidentDate_03 { get; set; }
    }
    
    public class DTP_Date_AcuteManifestation_2
    {
        
        [D(1, "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, "1251")]
        public string AcuteManifestationDate_03 { get; set; }
    }
    
    public class DTP_Date_LastSeenDate_3
    {
        
        [D(1, "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, "1251")]
        public string LastSeenDate_03 { get; set; }
    }
    
    public class DTP_Date_InitialTreatmentDate_3
    {
        
        [D(1, "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, "1251")]
        public string InitialTreatmentDate_03 { get; set; }
    }
    
    public class DTP_Date_OnsetofCurrentIllnessorSymptom_2
    {
        
        [D(1, "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, "1251")]
        public string OnsetofCurrentIllnessorInjuryDate_03 { get; set; }
    }
    
    public class CLM_ClaimInformation_2
    {
        
        [D(1, "1028")]
        public string PatientControlNumber_01 { get; set; }
        [D(2, "782")]
        public string TotalClaimChargeAmount_02 { get; set; }
        [D(3, "1032")]
        public string ClaimFilingIndicatorCode_03 { get; set; }
        [D(4, "1343")]
        public string NonInstitutionalClaimTypeCode_04 { get; set; }
        [C(5)]
        public C023_HealthCareServiceLocationInformation_2 HealthCareServiceLocationInformation_05 { get; set; }
        [D(6, "1073")]
        public string ProviderorSupplierSignatureIndicator_06 { get; set; }
        [D(7, "1359")]
        public string AssignmentorPlanParticipationCode_07 { get; set; }
        [D(8, "1073")]
        public string BenefitsAssignmentCertificationIndicator_08 { get; set; }
        [D(9, "1363")]
        public string ReleaseofInformationCode_09 { get; set; }
        [D(10, "1351")]
        public string PatientSignatureSourceCode_10 { get; set; }
        [C(11)]
        public C024_RelatedCausesInformation_2 RelatedCausesInformation_11 { get; set; }
        [D(12, "1366")]
        public string SpecialProgramIndicator_12 { get; set; }
        [D(13, "1073")]
        public string YesNoConditionorResponseCode_13 { get; set; }
        [D(14, "1338")]
        public string LevelofServiceCode_14 { get; set; }
        [D(15, "1073")]
        public string YesNoConditionorResponseCode_15 { get; set; }
        [D(16, "1360")]
        public string ProviderAgreementCode_16 { get; set; }
        [D(17, "1029")]
        public string ClaimStatusCode_17 { get; set; }
        [D(18, "1073")]
        public string YesNoConditionorResponseCode_18 { get; set; }
        [D(19, "1383")]
        public string ClaimSubmissionReasonCode_19 { get; set; }
        [D(20, "1514")]
        public string DelayReasonCode_20 { get; set; }
    }
    
    public class C024_RelatedCausesInformation_2
    {
        
        [D(1, "1362")]
        public string RelatedCausesCode_01 { get; set; }
        [D(2, "1362")]
        public string RelatedCausesCode_02 { get; set; }
        [D(3, "1362")]
        public string RelatedCausesCode_03 { get; set; }
        [D(4, "156")]
        public string AutoAccidentStateorProvinceCode_04 { get; set; }
        [D(5, "26")]
        public string CountryCode_05 { get; set; }
    }
    
    public class C023_HealthCareServiceLocationInformation_2
    {
        
        [D(1, "1331")]
        public string PlaceofServiceCode_01 { get; set; }
        [D(2, "1332")]
        public string FacilityCodeQualifier_02 { get; set; }
        [D(3, "1325")]
        public string ClaimFrequencyCode_03 { get; set; }
    }
    
    public class Loop_2010CA
    {
        
        [S("NM1", 1, typeof(X12_ID_98_17), typeof(X12_ID_1065_3))]
        public NM1_PatientName NM1_PatientName { get; set; }
        [S("N3", 2)]
        public N3_PatientAddress N3_PatientAddress { get; set; }
        [S("N4", 3)]
        public N4_PatientCity_State_ZIPCode N4_PatientCity_State_ZIPCode { get; set; }
        [S("DMG", 4, typeof(X12_ID_1250))]
        public DMG_PatientDemographicInformation DMG_PatientDemographicInformation { get; set; }
        [A(5)]
        public All_REF_8 All_REF_8 { get; set; }
        [S("PER", 6, typeof(X12_ID_366))]
        public PER_PropertyandCasualtyPatientContactInformation PER_PropertyandCasualtyPatientContactInformation { get; set; }
    }
    
    [E(",QC,")]
    public class X12_ID_98_17
    {
    }
    
    public class PER_PropertyandCasualtyPatientContactInformation
    {
        
        [D(1, "366")]
        public string ContactFunctionCode_01 { get; set; }
        [D(2, "93")]
        public string Name_02 { get; set; }
        [D(3, "365")]
        public string CommunicationNumberQualifier_03 { get; set; }
        [D(4, "364")]
        public string CommunicationNumber_04 { get; set; }
        [D(5, "365")]
        public string CommunicationNumberQualifier_05 { get; set; }
        [D(6, "364")]
        public string CommunicationNumber_06 { get; set; }
        [D(7, "365")]
        public string CommunicationNumberQualifier_07 { get; set; }
        [D(8, "364")]
        public string CommunicationNumber_08 { get; set; }
        [D(9, "443")]
        public string ContactInquiryReference_09 { get; set; }
    }
    
    public class All_REF_8
    {
        
        [S("REF", 1, typeof(X12_ID_128_8))]
        public REF_PropertyandCasualtyClaimNumber_2 REF_PropertyandCasualtyClaimNumber_2 { get; set; }
        [S("REF", 2, typeof(X12_ID_128_36))]
        public REF_PropertyandCasualtyPatientIdentifier REF_PropertyandCasualtyPatientIdentifier { get; set; }
    }
    
    [E(",Y4,")]
    public class X12_ID_128_8
    {
    }
    
    [E(",1W,SY,")]
    public class X12_ID_128_36
    {
    }
    
    public class REF_PropertyandCasualtyPatientIdentifier
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string PropertyandCasualtyPatientIdentifier_02 { get; set; }
        [D(3, "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_55 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_55
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_PropertyandCasualtyClaimNumber_2
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string PropertyCasualtyClaimNumber_02 { get; set; }
        [D(3, "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_54 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_54
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class DMG_PatientDemographicInformation
    {
        
        [D(1, "1250")]
        public string DateTimePeriodFormatQualifier_01 { get; set; }
        [D(2, "1251")]
        public string PatientBirthDate_02 { get; set; }
        [D(3, "1068")]
        public string PatientGenderCode_03 { get; set; }
        [D(4, "1067")]
        public string MaritalStatusCode_04 { get; set; }
        [C(5)]
        public List<C056_CompositeRaceorEthnicityInformation_2> CompositeRaceorEthnicityInformation_05 { get; set; }
        [D(6, "1066")]
        public string CitizenshipStatusCode_06 { get; set; }
        [D(7, "26")]
        public string CountryCode_07 { get; set; }
        [D(8, "659")]
        public string BasisofVerificationCode_08 { get; set; }
        [D(9, "380")]
        public string Quantity_09 { get; set; }
        [D(10, "1270")]
        public string CodeListQualifierCode_10 { get; set; }
        [D(11, "1271")]
        public string IndustryCode_11 { get; set; }
    }
    
    public class C056_CompositeRaceorEthnicityInformation_2
    {
        
        [D(1, "1109")]
        public string RaceorEthnicityCode_01 { get; set; }
        [D(2, "1270")]
        public string CodeListQualifierCode_02 { get; set; }
        [D(3, "1271")]
        public string IndustryCode_03 { get; set; }
    }
    
    public class N4_PatientCity_State_ZIPCode
    {
        
        [D(1, "19")]
        public string PatientCityName_01 { get; set; }
        [D(2, "156")]
        public string PatientStateCode_02 { get; set; }
        [D(3, "116")]
        public string PatientPostalZoneorZIPCode_03 { get; set; }
        [D(4, "26")]
        public string CountryCode_04 { get; set; }
        [D(5, "309")]
        public string LocationQualifier_05 { get; set; }
        [D(6, "310")]
        public string LocationIdentifier_06 { get; set; }
        [D(7, "1715")]
        public string CountrySubdivisionCode_07 { get; set; }
    }
    
    public class N3_PatientAddress
    {
        
        [D(1, "166")]
        public string PatientAddressLine_01 { get; set; }
        [D(2, "166")]
        public string PatientAddressLine_02 { get; set; }
    }
    
    public class NM1_PatientName
    {
        
        [D(1, "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, "1035")]
        public string PatientLastName_03 { get; set; }
        [D(4, "1036")]
        public string PatientFirstName_04 { get; set; }
        [D(5, "1037")]
        public string PatientMiddleNameorInitial_05 { get; set; }
        [D(6, "1038")]
        public string NamePrefix_06 { get; set; }
        [D(7, "1039")]
        public string PatientNameSuffix_07 { get; set; }
        [D(8, "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, "67")]
        public string IdentificationCode_09 { get; set; }
        [D(10, "706")]
        public string EntityRelationshipCode_10 { get; set; }
        [D(11, "98")]
        public string EntityIdentifierCode_11 { get; set; }
        [D(12, "1035")]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    public class PAT_PatientInformation_2
    {
        
        [D(1, "1069")]
        public string IndividualRelationshipCode_01 { get; set; }
        [D(2, "1384")]
        public string PatientLocationCode_02 { get; set; }
        [D(3, "584")]
        public string EmploymentStatusCode_03 { get; set; }
        [D(4, "1220")]
        public string StudentStatusCode_04 { get; set; }
        [D(5, "1250")]
        public string DateTimePeriodFormatQualifier_05 { get; set; }
        [D(6, "1251")]
        public string PatientDeathDate_06 { get; set; }
        [D(7, "355")]
        public string UnitorBasisforMeasurementCode_07 { get; set; }
        [D(8, "81")]
        public string PatientWeight_08 { get; set; }
        [D(9, "1073")]
        public string PregnancyIndicator_09 { get; set; }
    }
    
    public class HL_PatientHierarchicalLevel
    {
        
        [D(1, "628")]
        public string HierarchicalIDNumber_01 { get; set; }
        [D(2, "734")]
        public string HierarchicalParentIDNumber_02 { get; set; }
        [D(3, "735")]
        public string HierarchicalLevelCode_03 { get; set; }
        [D(4, "736")]
        public string HierarchicalChildCode_04 { get; set; }
    }
    
    public class Loop_2300
    {
        
        [S("CLM", 1)]
        public CLM_ClaimInformation CLM_ClaimInformation { get; set; }
        [A(2)]
        public All_DTP All_DTP { get; set; }
        [S("PWK", 3, typeof(X12_ID_755), typeof(X12_ID_756))]
        public List<PWK_ClaimSupplementalInformation> PWK_ClaimSupplementalInformation { get; set; }
        [S("CN1", 4, typeof(X12_ID_1166))]
        public CN1_ContractInformation CN1_ContractInformation { get; set; }
        [S("AMT", 5, typeof(X12_ID_522))]
        public AMT_PatientAmountPaid AMT_PatientAmountPaid { get; set; }
        [A(6)]
        public All_REF_5 All_REF_5 { get; set; }
        [S("K3", 7)]
        public List<K3_FileInformation> K3_FileInformation { get; set; }
        [S("NTE", 8, typeof(X12_ID_363))]
        public NTE_ClaimNote NTE_ClaimNote { get; set; }
        [S("CR1", 9, typeof(X12_ID_355_3))]
        public CR1_AmbulanceTransportInformation CR1_AmbulanceTransportInformation { get; set; }
        [S("CR2", 10)]
        public CR2_SpinalManipulationServiceInformation CR2_SpinalManipulationServiceInformation { get; set; }
        [A(11)]
        public All_CRC All_CRC { get; set; }
        [A(12)]
        public All_HI All_HI { get; set; }
        [S("HCP", 13, typeof(X12_ID_1473))]
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
        [S("SV1", 2, typeof(X12_ID_235_2))]
        public SV1_ProfessionalService SV1_ProfessionalService { get; set; }
        [S("SV5", 3, typeof(X12_ID_235_3), typeof(X12_ID_355_6))]
        public SV5_DurableMedicalEquipmentService SV5_DurableMedicalEquipmentService { get; set; }
        [A(4)]
        public All_PWK All_PWK { get; set; }
        [S("CR1", 5, typeof(X12_ID_355_3))]
        public CR1_AmbulanceTransportInformation_2 CR1_AmbulanceTransportInformation_2 { get; set; }
        [S("CR3", 6, typeof(X12_ID_1322), typeof(X12_ID_355_7))]
        public CR3_DurableMedicalEquipmentCertification CR3_DurableMedicalEquipmentCertification { get; set; }
        [A(7)]
        public All_CRC_2 All_CRC_2 { get; set; }
        [A(8)]
        public All_DTP_2 All_DTP_2 { get; set; }
        [A(9)]
        public All_QTY All_QTY { get; set; }
        [S("MEA", 10, typeof(X12_ID_737), typeof(X12_ID_738))]
        public List<MEA_TestResult> MEA_TestResult { get; set; }
        [S("CN1", 11, typeof(X12_ID_1166))]
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
        [S("HCP", 17, typeof(X12_ID_1473_2))]
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
        
        [S("LQ", 1, typeof(X12_ID_1270_7))]
        public LQ_FormIdentificationCode LQ_FormIdentificationCode { get; set; }
        [S("FRM", 2)]
        public List<FRM_SupportingDocumentation> FRM_SupportingDocumentation { get; set; }
    }
    
    public class FRM_SupportingDocumentation
    {
        
        [D(1, "350")]
        public string QuestionNumberLetter_01 { get; set; }
        [D(2, "1073")]
        public string QuestionResponse_02 { get; set; }
        [D(3, "127")]
        public string QuestionResponse_03 { get; set; }
        [D(4, "373")]
        public string QuestionResponse_04 { get; set; }
        [D(5, "332")]
        public string QuestionResponse_05 { get; set; }
    }
    
    public class LQ_FormIdentificationCode
    {
        
        [D(1, "1270")]
        public string CodeListQualifierCode_01 { get; set; }
        [D(2, "1271")]
        public string FormIdentifier_02 { get; set; }
    }
    
    public class Loop_2430
    {
        
        [S("SVD", 1)]
        public SVD_LineAdjudicationInformation SVD_LineAdjudicationInformation { get; set; }
        [S("CAS", 2, typeof(X12_ID_1033))]
        public List<CAS_LineAdjustment> CAS_LineAdjustment { get; set; }
        [S("DTP", 3, typeof(X12_ID_374_18), typeof(X12_ID_1250))]
        public DTP_LineCheckorRemittanceDate DTP_LineCheckorRemittanceDate { get; set; }
        [S("AMT", 4, typeof(X12_ID_522_4))]
        public AMT_RemainingPatientLiability_2 AMT_RemainingPatientLiability_2 { get; set; }
    }
    
    public class AMT_RemainingPatientLiability_2
    {
        
        [D(1, "522")]
        public string AmountQualifierCode_01 { get; set; }
        [D(2, "782")]
        public string RemainingPatientLiability_02 { get; set; }
        [D(3, "478")]
        public string CreditDebitFlagCode_03 { get; set; }
    }
    
    public class DTP_LineCheckorRemittanceDate
    {
        
        [D(1, "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, "1251")]
        public string AdjudicationorPaymentDate_03 { get; set; }
    }
    
    public class CAS_LineAdjustment
    {
        
        [D(1, "1033")]
        public string ClaimAdjustmentGroupCode_01 { get; set; }
        [D(2, "1034")]
        public string AdjustmentReasonCode_02 { get; set; }
        [D(3, "782")]
        public string AdjustmentAmount_03 { get; set; }
        [D(4, "380")]
        public string AdjustmentQuantity_04 { get; set; }
        [D(5, "1034")]
        public string AdjustmentReasonCode_05 { get; set; }
        [D(6, "782")]
        public string AdjustmentAmount_06 { get; set; }
        [D(7, "380")]
        public string AdjustmentQuantity_07 { get; set; }
        [D(8, "1034")]
        public string AdjustmentReasonCode_08 { get; set; }
        [D(9, "782")]
        public string AdjustmentAmount_09 { get; set; }
        [D(10, "380")]
        public string AdjustmentQuantity_10 { get; set; }
        [D(11, "1034")]
        public string AdjustmentReasonCode_11 { get; set; }
        [D(12, "782")]
        public string AdjustmentAmount_12 { get; set; }
        [D(13, "380")]
        public string AdjustmentQuantity_13 { get; set; }
        [D(14, "1034")]
        public string AdjustmentReasonCode_14 { get; set; }
        [D(15, "782")]
        public string AdjustmentAmount_15 { get; set; }
        [D(16, "380")]
        public string AdjustmentQuantity_16 { get; set; }
        [D(17, "1034")]
        public string AdjustmentReasonCode_17 { get; set; }
        [D(18, "782")]
        public string AdjustmentAmount_18 { get; set; }
        [D(19, "380")]
        public string AdjustmentQuantity_19 { get; set; }
    }
    
    public class SVD_LineAdjudicationInformation
    {
        
        [D(1, "67")]
        public string OtherPayerPrimaryIdentifier_01 { get; set; }
        [D(2, "782")]
        public string ServiceLinePaidAmount_02 { get; set; }
        [C(3)]
        public C003_CompositeMedicalProcedureIdentifier_3 CompositeMedicalProcedureIdentifier_03 { get; set; }
        [D(4, "234")]
        public string ProductServiceID_04 { get; set; }
        [D(5, "380")]
        public string PaidServiceUnitCount_05 { get; set; }
        [D(6, "554")]
        public string BundledorUnbundledLineNumber_06 { get; set; }
    }
    
    public class C003_CompositeMedicalProcedureIdentifier_3
    {
        
        [D(1, "235")]
        public string ProductorServiceIDQualifier_01 { get; set; }
        [D(2, "234")]
        public string ProcedureCode_02 { get; set; }
        [D(3, "1339")]
        public string ProcedureModifier_03 { get; set; }
        [D(4, "1339")]
        public string ProcedureModifier_04 { get; set; }
        [D(5, "1339")]
        public string ProcedureModifier_05 { get; set; }
        [D(6, "1339")]
        public string ProcedureModifier_06 { get; set; }
        [D(7, "352")]
        public string ProcedureCodeDescription_07 { get; set; }
        [D(8, "234")]
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
        
        [S("NM1", 1, typeof(X12_ID_98_14), typeof(X12_ID_1065_2))]
        public NM1_AmbulanceDrop_offLocation_2 NM1_AmbulanceDrop_offLocation_2 { get; set; }
        [S("N3", 2)]
        public N3_AmbulanceDrop_offLocationAddress_2 N3_AmbulanceDrop_offLocationAddress_2 { get; set; }
        [S("N4", 3)]
        public N4_AmbulanceDrop_offLocationCity_State_ZipCode_2 N4_AmbulanceDrop_offLocationCity_State_ZipCode_2 { get; set; }
    }
    
    public class N4_AmbulanceDrop_offLocationCity_State_ZipCode_2
    {
        
        [D(1, "19")]
        public string AmbulanceDropoffCityName_01 { get; set; }
        [D(2, "156")]
        public string AmbulanceDropoffStateorProvinceCode_02 { get; set; }
        [D(3, "116")]
        public string AmbulanceDropoffPostalZoneorZIPCode_03 { get; set; }
        [D(4, "26")]
        public string CountryCode_04 { get; set; }
        [D(5, "309")]
        public string LocationQualifier_05 { get; set; }
        [D(6, "310")]
        public string LocationIdentifier_06 { get; set; }
        [D(7, "1715")]
        public string CountrySubdivisionCode_07 { get; set; }
    }
    
    public class N3_AmbulanceDrop_offLocationAddress_2
    {
        
        [D(1, "166")]
        public string AmbulanceDropoffAddressLine_01 { get; set; }
        [D(2, "166")]
        public string AmbulanceDropoffAddressLine_02 { get; set; }
    }
    
    public class NM1_AmbulanceDrop_offLocation_2
    {
        
        [D(1, "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, "1035")]
        public string AmbulanceDropoffLocation_03 { get; set; }
        [D(4, "1036")]
        public string NameFirst_04 { get; set; }
        [D(5, "1037")]
        public string NameMiddle_05 { get; set; }
        [D(6, "1038")]
        public string NamePrefix_06 { get; set; }
        [D(7, "1039")]
        public string NameSuffix_07 { get; set; }
        [D(8, "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, "67")]
        public string IdentificationCode_09 { get; set; }
        [D(10, "706")]
        public string EntityRelationshipCode_10 { get; set; }
        [D(11, "98")]
        public string EntityIdentifierCode_11 { get; set; }
        [D(12, "1035")]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    public class Loop_2420G
    {
        
        [S("NM1", 1, typeof(X12_ID_98_13), typeof(X12_ID_1065_2))]
        public NM1_AmbulancePick_upLocation_2 NM1_AmbulancePick_upLocation_2 { get; set; }
        [S("N3", 2)]
        public N3_AmbulancePick_upLocationAddress_2 N3_AmbulancePick_upLocationAddress_2 { get; set; }
        [S("N4", 3)]
        public N4_AmbulancePick_upLocationCity_State_ZipCode_2 N4_AmbulancePick_upLocationCity_State_ZipCode_2 { get; set; }
    }
    
    public class N4_AmbulancePick_upLocationCity_State_ZipCode_2
    {
        
        [D(1, "19")]
        public string AmbulancePickupCityName_01 { get; set; }
        [D(2, "156")]
        public string AmbulancePickupStateorProvinceCode_02 { get; set; }
        [D(3, "116")]
        public string AmbulancePickupPostalZoneorZIPCode_03 { get; set; }
        [D(4, "26")]
        public string CountryCode_04 { get; set; }
        [D(5, "309")]
        public string LocationQualifier_05 { get; set; }
        [D(6, "310")]
        public string LocationIdentifier_06 { get; set; }
        [D(7, "1715")]
        public string CountrySubdivisionCode_07 { get; set; }
    }
    
    public class N3_AmbulancePick_upLocationAddress_2
    {
        
        [D(1, "166")]
        public string AmbulancePickupAddressLine_01 { get; set; }
        [D(2, "166")]
        public string AmbulancePickupAddressLine_02 { get; set; }
    }
    
    public class NM1_AmbulancePick_upLocation_2
    {
        
        [D(1, "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, "1035")]
        public string NameLastorOrganizationName_03 { get; set; }
        [D(4, "1036")]
        public string NameFirst_04 { get; set; }
        [D(5, "1037")]
        public string NameMiddle_05 { get; set; }
        [D(6, "1038")]
        public string NamePrefix_06 { get; set; }
        [D(7, "1039")]
        public string NameSuffix_07 { get; set; }
        [D(8, "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, "67")]
        public string IdentificationCode_09 { get; set; }
        [D(10, "706")]
        public string EntityRelationshipCode_10 { get; set; }
        [D(11, "98")]
        public string EntityIdentifierCode_11 { get; set; }
        [D(12, "1035")]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    public class Loop_2420F
    {
        
        [S("NM1", 1, typeof(X12_ID_98_9), typeof(X12_ID_1065_3))]
        public NM1_ReferringProviderName_2 NM1_ReferringProviderName_2 { get; set; }
        [S("REF", 2, typeof(X12_ID_128_25))]
        public List<REF_ReferringProviderSecondaryIdentification_2> REF_ReferringProviderSecondaryIdentification_2 { get; set; }
    }
    
    public class REF_ReferringProviderSecondaryIdentification_2
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string ReferringProviderSecondaryIdentifier_02 { get; set; }
        [D(3, "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_53 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_53
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string OtherPayerPrimaryIdentifier_02 { get; set; }
        [D(3, "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class NM1_ReferringProviderName_2
    {
        
        [D(1, "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, "1035")]
        public string ReferringProviderLastName_03 { get; set; }
        [D(4, "1036")]
        public string ReferringProviderFirstName_04 { get; set; }
        [D(5, "1037")]
        public string ReferringProviderMiddleNameorInitial_05 { get; set; }
        [D(6, "1038")]
        public string NamePrefix_06 { get; set; }
        [D(7, "1039")]
        public string ReferringProviderNameSuffix_07 { get; set; }
        [D(8, "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, "67")]
        public string ReferringProviderIdentifier_09 { get; set; }
        [D(10, "706")]
        public string EntityRelationshipCode_10 { get; set; }
        [D(11, "98")]
        public string EntityIdentifierCode_11 { get; set; }
        [D(12, "1035")]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    public class Loop_2420E
    {
        
        [S("NM1", 1, typeof(X12_ID_98_16), typeof(X12_ID_1065_3))]
        public NM1_OrderingProviderName NM1_OrderingProviderName { get; set; }
        [S("N3", 2)]
        public N3_OrderingProviderAddress N3_OrderingProviderAddress { get; set; }
        [S("N4", 3)]
        public N4_OrderingProviderCity_State_ZIPCode N4_OrderingProviderCity_State_ZIPCode { get; set; }
        [S("REF", 4, typeof(X12_ID_128_25))]
        public List<REF_OrderingProviderSecondaryIdentification> REF_OrderingProviderSecondaryIdentification { get; set; }
        [S("PER", 5, typeof(X12_ID_366))]
        public PER_OrderingProviderContactInformation PER_OrderingProviderContactInformation { get; set; }
    }
    
    public class PER_OrderingProviderContactInformation
    {
        
        [D(1, "366")]
        public string ContactFunctionCode_01 { get; set; }
        [D(2, "93")]
        public string OrderingProviderContactName_02 { get; set; }
        [D(3, "365")]
        public string CommunicationNumberQualifier_03 { get; set; }
        [D(4, "364")]
        public string CommunicationNumber_04 { get; set; }
        [D(5, "365")]
        public string CommunicationNumberQualifier_05 { get; set; }
        [D(6, "364")]
        public string CommunicationNumber_06 { get; set; }
        [D(7, "365")]
        public string CommunicationNumberQualifier_07 { get; set; }
        [D(8, "364")]
        public string CommunicationNumber_08 { get; set; }
        [D(9, "443")]
        public string ContactInquiryReference_09 { get; set; }
    }
    
    public class REF_OrderingProviderSecondaryIdentification
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string OrderingProviderSecondaryIdentifier_02 { get; set; }
        [D(3, "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_52 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_52
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string OtherPayerPrimaryIdentifier_02 { get; set; }
        [D(3, "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class N4_OrderingProviderCity_State_ZIPCode
    {
        
        [D(1, "19")]
        public string OrderingProviderCityName_01 { get; set; }
        [D(2, "156")]
        public string OrderingProviderStateorProvinceCode_02 { get; set; }
        [D(3, "116")]
        public string OrderingProviderPostalZoneorZIPCode_03 { get; set; }
        [D(4, "26")]
        public string CountryCode_04 { get; set; }
        [D(5, "309")]
        public string LocationQualifier_05 { get; set; }
        [D(6, "310")]
        public string LocationIdentifier_06 { get; set; }
        [D(7, "1715")]
        public string CountrySubdivisionCode_07 { get; set; }
    }
    
    public class N3_OrderingProviderAddress
    {
        
        [D(1, "166")]
        public string OrderingProviderAddressLine_01 { get; set; }
        [D(2, "166")]
        public string OrderingProviderAddressLine_02 { get; set; }
    }
    
    public class NM1_OrderingProviderName
    {
        
        [D(1, "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, "1035")]
        public string OrderingProviderLastName_03 { get; set; }
        [D(4, "1036")]
        public string OrderingProviderFirstName_04 { get; set; }
        [D(5, "1037")]
        public string OrderingProviderMiddleNameorInitial_05 { get; set; }
        [D(6, "1038")]
        public string NamePrefix_06 { get; set; }
        [D(7, "1039")]
        public string OrderingProviderNameSuffix_07 { get; set; }
        [D(8, "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, "67")]
        public string OrderingProviderIdentifier_09 { get; set; }
        [D(10, "706")]
        public string EntityRelationshipCode_10 { get; set; }
        [D(11, "98")]
        public string EntityIdentifierCode_11 { get; set; }
        [D(12, "1035")]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    public class Loop_2420D
    {
        
        [S("NM1", 1, typeof(X12_ID_98_12), typeof(X12_ID_1065_3))]
        public NM1_SupervisingProviderName_2 NM1_SupervisingProviderName_2 { get; set; }
        [S("REF", 2, typeof(X12_ID_128_26))]
        public List<REF_SupervisingProviderSecondaryIdentification_2> REF_SupervisingProviderSecondaryIdentification_2 { get; set; }
    }
    
    public class REF_SupervisingProviderSecondaryIdentification_2
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string SupervisingProviderSecondaryIdentifier_02 { get; set; }
        [D(3, "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_51 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_51
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string OtherPayerPrimaryIdentifier_02 { get; set; }
        [D(3, "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class NM1_SupervisingProviderName_2
    {
        
        [D(1, "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, "1035")]
        public string SupervisingProviderLastName_03 { get; set; }
        [D(4, "1036")]
        public string SupervisingProviderFirstName_04 { get; set; }
        [D(5, "1037")]
        public string SupervisingProviderMiddleNameorInitial_05 { get; set; }
        [D(6, "1038")]
        public string NamePrefix_06 { get; set; }
        [D(7, "1039")]
        public string SupervisingProviderNameSuffix_07 { get; set; }
        [D(8, "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, "67")]
        public string SupervisingProviderIdentifier_09 { get; set; }
        [D(10, "706")]
        public string EntityRelationshipCode_10 { get; set; }
        [D(11, "98")]
        public string EntityIdentifierCode_11 { get; set; }
        [D(12, "1035")]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    public class Loop_2420C
    {
        
        [S("NM1", 1, typeof(X12_ID_98_11), typeof(X12_ID_1065_2))]
        public NM1_ServiceFacilityLocation NM1_ServiceFacilityLocation { get; set; }
        [S("N3", 2)]
        public N3_ServiceFacilityLocationAddress_2 N3_ServiceFacilityLocationAddress_2 { get; set; }
        [S("N4", 3)]
        public N4_ServiceFacilityLocationCity_State_ZIPCode_2 N4_ServiceFacilityLocationCity_State_ZIPCode_2 { get; set; }
        [S("REF", 4, typeof(X12_ID_128_10))]
        public List<REF_ServiceFacilityLocationSecondaryIdentification_2> REF_ServiceFacilityLocationSecondaryIdentification_2 { get; set; }
    }
    
    public class REF_ServiceFacilityLocationSecondaryIdentification_2
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string ServiceFacilityLocationSecondaryIdentifier_02 { get; set; }
        [D(3, "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_50 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_50
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string OtherPayerPrimaryIdentifier_02 { get; set; }
        [D(3, "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class N4_ServiceFacilityLocationCity_State_ZIPCode_2
    {
        
        [D(1, "19")]
        public string LaboratoryorFacilityCityName_01 { get; set; }
        [D(2, "156")]
        public string LaboratoryorFacilityStateorProvinceCode_02 { get; set; }
        [D(3, "116")]
        public string LaboratoryorFacilityPostalZoneorZIPCode_03 { get; set; }
        [D(4, "26")]
        public string CountryCode_04 { get; set; }
        [D(5, "309")]
        public string LocationQualifier_05 { get; set; }
        [D(6, "310")]
        public string LocationIdentifier_06 { get; set; }
        [D(7, "1715")]
        public string CountrySubdivisionCode_07 { get; set; }
    }
    
    public class N3_ServiceFacilityLocationAddress_2
    {
        
        [D(1, "166")]
        public string LaboratoryorFacilityAddressLine_01 { get; set; }
        [D(2, "166")]
        public string LaboratoryorFacilityAddressLine_02 { get; set; }
    }
    
    public class NM1_ServiceFacilityLocation
    {
        
        [D(1, "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, "1035")]
        public string LaboratoryorFacilityName_03 { get; set; }
        [D(4, "1036")]
        public string NameFirst_04 { get; set; }
        [D(5, "1037")]
        public string NameMiddle_05 { get; set; }
        [D(6, "1038")]
        public string NamePrefix_06 { get; set; }
        [D(7, "1039")]
        public string NameSuffix_07 { get; set; }
        [D(8, "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, "67")]
        public string LaboratoryorFacilityPrimaryIdentifier_09 { get; set; }
        [D(10, "706")]
        public string EntityRelationshipCode_10 { get; set; }
        [D(11, "98")]
        public string EntityIdentifierCode_11 { get; set; }
        [D(12, "1035")]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    public class Loop_2420B
    {
        
        [S("NM1", 1, typeof(X12_ID_98_15), typeof(X12_ID_1065))]
        public NM1_PurchasedServiceProviderName NM1_PurchasedServiceProviderName { get; set; }
        [S("REF", 2, typeof(X12_ID_128_25))]
        public List<REF_PurchasedServiceProviderSecondaryIdentification> REF_PurchasedServiceProviderSecondaryIdentification { get; set; }
    }
    
    public class REF_PurchasedServiceProviderSecondaryIdentification
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string PurchasedServiceProviderSecondaryIdentifier_02 { get; set; }
        [D(3, "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_49 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_49
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string OtherPayerPrimaryIdentifier_02 { get; set; }
        [D(3, "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class NM1_PurchasedServiceProviderName
    {
        
        [D(1, "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, "1035")]
        public string NameLastorOrganizationName_03 { get; set; }
        [D(4, "1036")]
        public string NameFirst_04 { get; set; }
        [D(5, "1037")]
        public string NameMiddle_05 { get; set; }
        [D(6, "1038")]
        public string NamePrefix_06 { get; set; }
        [D(7, "1039")]
        public string NameSuffix_07 { get; set; }
        [D(8, "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, "67")]
        public string PurchasedServiceProviderIdentifier_09 { get; set; }
        [D(10, "706")]
        public string EntityRelationshipCode_10 { get; set; }
        [D(11, "98")]
        public string EntityIdentifierCode_11 { get; set; }
        [D(12, "1035")]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    public class Loop_2420A
    {
        
        [S("NM1", 1, typeof(X12_ID_98_10), typeof(X12_ID_1065))]
        public NM1_RenderingProviderName_2 NM1_RenderingProviderName_2 { get; set; }
        [S("PRV", 2, typeof(X12_ID_1221_2), typeof(X12_ID_128))]
        public PRV_RenderingProviderSpecialtyInformation_2 PRV_RenderingProviderSpecialtyInformation_2 { get; set; }
        [S("REF", 3, typeof(X12_ID_128_26))]
        public List<REF_RenderingProviderSecondaryIdentification_2> REF_RenderingProviderSecondaryIdentification_2 { get; set; }
    }
    
    public class REF_RenderingProviderSecondaryIdentification_2
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string RenderingProviderSecondaryIdentifier_02 { get; set; }
        [D(3, "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_48 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_48
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string OtherPayerPrimaryIdentifier_02 { get; set; }
        [D(3, "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class PRV_RenderingProviderSpecialtyInformation_2
    {
        
        [D(1, "1221")]
        public string ProviderCode_01 { get; set; }
        [D(2, "128")]
        public string ReferenceIdentificationQualifier_02 { get; set; }
        [D(3, "127")]
        public string ProviderTaxonomyCode_03 { get; set; }
        [D(4, "156")]
        public string StateorProvinceCode_04 { get; set; }
        [C(5)]
        public C035_ProviderSpecialtyInformation_3 ProviderSpecialtyInformation_05 { get; set; }
        [D(6, "1223")]
        public string ProviderOrganizationCode_06 { get; set; }
    }
    
    public class C035_ProviderSpecialtyInformation_3
    {
        
        [D(1, "1222")]
        public string ProviderSpecialtyCode_01 { get; set; }
        [D(2, "559")]
        public string AgencyQualifierCode_02 { get; set; }
        [D(3, "1073")]
        public string YesNoConditionorResponseCode_03 { get; set; }
    }
    
    public class NM1_RenderingProviderName_2
    {
        
        [D(1, "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, "1035")]
        public string RenderingProviderLastorOrganizationName_03 { get; set; }
        [D(4, "1036")]
        public string RenderingProviderFirstName_04 { get; set; }
        [D(5, "1037")]
        public string RenderingProviderMiddleName_05 { get; set; }
        [D(6, "1038")]
        public string NamePrefix_06 { get; set; }
        [D(7, "1039")]
        public string RenderingProviderNameSuffix_07 { get; set; }
        [D(8, "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, "67")]
        public string RenderingProviderIdentifier_09 { get; set; }
        [D(10, "706")]
        public string EntityRelationshipCode_10 { get; set; }
        [D(11, "98")]
        public string EntityIdentifierCode_11 { get; set; }
        [D(12, "1035")]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    public class Loop_2410
    {
        
        [S("LIN", 1)]
        public LIN_DrugIdentification LIN_DrugIdentification { get; set; }
        [S("CTP", 2, typeof(X12_ID_687), typeof(X12_ID_236))]
        public CTP_DrugQuantity CTP_DrugQuantity { get; set; }
        [S("REF", 3, typeof(X12_ID_128_35))]
        public REF_PrescriptionorCompoundDrugAssociationNumber REF_PrescriptionorCompoundDrugAssociationNumber { get; set; }
    }
    
    public class REF_PrescriptionorCompoundDrugAssociationNumber
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string PrescriptionNumber_02 { get; set; }
        [D(3, "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_47 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_47
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class CTP_DrugQuantity
    {
        
        [D(1, "687")]
        public string ClassofTradeCode_01 { get; set; }
        [D(2, "236")]
        public string PriceIdentifierCode_02 { get; set; }
        [D(3, "212")]
        public string UnitPrice_03 { get; set; }
        [D(4, "380")]
        public string NationalDrugUnitCount_04 { get; set; }
        [C(5)]
        public C001_CompositeUnitofMeasure_6 CompositeUnitofMeasure_05 { get; set; }
        [D(6, "648")]
        public string PriceMultiplierQualifier_06 { get; set; }
        [D(7, "649")]
        public string Multiplier_07 { get; set; }
        [D(8, "782")]
        public string MonetaryAmount_08 { get; set; }
        [D(9, "639")]
        public string BasisofUnitPriceCode_09 { get; set; }
        [D(10, "499")]
        public string ConditionValue_10 { get; set; }
        [D(11, "289")]
        public string MultiplePriceQuantity_11 { get; set; }
    }
    
    public class C001_CompositeUnitofMeasure_6
    {
        
        [D(1, "355")]
        public string CodeQualifier_01 { get; set; }
        [D(2, "1018")]
        public string Exponent_02 { get; set; }
        [D(3, "649")]
        public string Multiplier_03 { get; set; }
        [D(4, "355")]
        public string UnitorBasisforMeasurementCode_04 { get; set; }
        [D(5, "1018")]
        public string Exponent_05 { get; set; }
        [D(6, "649")]
        public string Multiplier_06 { get; set; }
        [D(7, "355")]
        public string UnitorBasisforMeasurementCode_07 { get; set; }
        [D(8, "1018")]
        public string Exponent_08 { get; set; }
        [D(9, "649")]
        public string Multiplier_09 { get; set; }
        [D(10, "355")]
        public string UnitorBasisforMeasurementCode_10 { get; set; }
        [D(11, "1018")]
        public string Exponent_11 { get; set; }
        [D(12, "649")]
        public string Multiplier_12 { get; set; }
        [D(13, "355")]
        public string UnitorBasisforMeasurementCode_13 { get; set; }
        [D(14, "1018")]
        public string Exponent_14 { get; set; }
        [D(15, "649")]
        public string Multiplier_15 { get; set; }
    }
    
    public class LIN_DrugIdentification
    {
        
        [D(1, "350")]
        public string AssignedIdentification_01 { get; set; }
        [D(2, "235")]
        public string ProductorServiceIDQualifier_02 { get; set; }
        [D(3, "234")]
        public string NationalDrugCodeorUniversalProductNumber_03 { get; set; }
        [D(4, "235")]
        public string ProductServiceIDQualifier_04 { get; set; }
        [D(5, "234")]
        public string ProductServiceID_05 { get; set; }
        [D(6, "235")]
        public string ProductServiceIDQualifier_06 { get; set; }
        [D(7, "234")]
        public string ProductServiceID_07 { get; set; }
        [D(8, "235")]
        public string ProductServiceIDQualifier_08 { get; set; }
        [D(9, "234")]
        public string ProductServiceID_09 { get; set; }
        [D(10, "235")]
        public string ProductServiceIDQualifier_10 { get; set; }
        [D(11, "234")]
        public string ProductServiceID_11 { get; set; }
        [D(12, "235")]
        public string ProductServiceIDQualifier_12 { get; set; }
        [D(13, "234")]
        public string ProductServiceID_13 { get; set; }
        [D(14, "235")]
        public string ProductServiceIDQualifier_14 { get; set; }
        [D(15, "234")]
        public string ProductServiceID_15 { get; set; }
        [D(16, "235")]
        public string ProductServiceIDQualifier_16 { get; set; }
        [D(17, "234")]
        public string ProductServiceID_17 { get; set; }
        [D(18, "235")]
        public string ProductServiceIDQualifier_18 { get; set; }
        [D(19, "234")]
        public string ProductServiceID_19 { get; set; }
        [D(20, "235")]
        public string ProductServiceIDQualifier_20 { get; set; }
        [D(21, "234")]
        public string ProductServiceID_21 { get; set; }
        [D(22, "235")]
        public string ProductServiceIDQualifier_22 { get; set; }
        [D(23, "234")]
        public string ProductServiceID_23 { get; set; }
        [D(24, "235")]
        public string ProductServiceIDQualifier_24 { get; set; }
        [D(25, "234")]
        public string ProductServiceID_25 { get; set; }
        [D(26, "235")]
        public string ProductServiceIDQualifier_26 { get; set; }
        [D(27, "234")]
        public string ProductServiceID_27 { get; set; }
        [D(28, "235")]
        public string ProductServiceIDQualifier_28 { get; set; }
        [D(29, "234")]
        public string ProductServiceID_29 { get; set; }
        [D(30, "235")]
        public string ProductServiceIDQualifier_30 { get; set; }
        [D(31, "234")]
        public string ProductServiceID_31 { get; set; }
    }
    
    public class HCP_LinePricing_RepricingInformation
    {
        
        [D(1, "1473")]
        public string PricingMethodology_01 { get; set; }
        [D(2, "782")]
        public string RepricedAllowedAmount_02 { get; set; }
        [D(3, "782")]
        public string RepricedSavingAmount_03 { get; set; }
        [D(4, "127")]
        public string RepricingOrganizationIdentifier_04 { get; set; }
        [D(5, "118")]
        public string RepricingPerDiemorFlatRateAmount_05 { get; set; }
        [D(6, "127")]
        public string RepricedApprovedAmbulatoryPatientGroupCode_06 { get; set; }
        [D(7, "782")]
        public string RepricedApprovedAmbulatoryPatientGroupAmount_07 { get; set; }
        [D(8, "234")]
        public string ProductServiceID_08 { get; set; }
        [D(9, "235")]
        public string ProductorServiceIDQualifier_09 { get; set; }
        [D(10, "234")]
        public string RepricedApprovedHCPCSCode_10 { get; set; }
        [D(11, "355")]
        public string UnitorBasisforMeasurementCode_11 { get; set; }
        [D(12, "380")]
        public string RepricedApprovedServiceUnitCount_12 { get; set; }
        [D(13, "901")]
        public string RejectReasonCode_13 { get; set; }
        [D(14, "1526")]
        public string PolicyComplianceCode_14 { get; set; }
        [D(15, "1527")]
        public string ExceptionCode_15 { get; set; }
    }
    
    public class PS1_PurchasedServiceInformation
    {
        
        [D(1, "127")]
        public string PurchasedServiceProviderIdentifier_01 { get; set; }
        [D(2, "782")]
        public string PurchasedServiceChargeAmount_02 { get; set; }
        [D(3, "156")]
        public string StateorProvinceCode_03 { get; set; }
    }
    
    public class All_NTE
    {
        
        [S("NTE", 1, typeof(X12_ID_363_2))]
        public NTE_LineNote NTE_LineNote { get; set; }
        [S("NTE", 2, typeof(X12_ID_363_3))]
        public NTE_ThirdPartyOrganizationNotes NTE_ThirdPartyOrganizationNotes { get; set; }
    }
    
    public class NTE_ThirdPartyOrganizationNotes
    {
        
        [D(1, "363")]
        public string NoteReferenceCode_01 { get; set; }
        [D(2, "352")]
        public string LineNoteText_02 { get; set; }
    }
    
    public class NTE_LineNote
    {
        
        [D(1, "363")]
        public string NoteReferenceCode_01 { get; set; }
        [D(2, "352")]
        public string LineNoteText_02 { get; set; }
    }
    
    public class K3_FileInformation_2
    {
        
        [D(1, "449")]
        public string FixedFormatInformation_01 { get; set; }
        [D(2, "1333")]
        public string RecordFormatCode_02 { get; set; }
        [C(3)]
        public C001_CompositeUnitofMeasure_5 CompositeUnitofMeasure_03 { get; set; }
    }
    
    public class C001_CompositeUnitofMeasure_5
    {
        
        [D(1, "355")]
        public string UnitorBasisforMeasurementCode_01 { get; set; }
        [D(2, "1018")]
        public string Exponent_02 { get; set; }
        [D(3, "649")]
        public string Multiplier_03 { get; set; }
        [D(4, "355")]
        public string UnitorBasisforMeasurementCode_04 { get; set; }
        [D(5, "1018")]
        public string Exponent_05 { get; set; }
        [D(6, "649")]
        public string Multiplier_06 { get; set; }
        [D(7, "355")]
        public string UnitorBasisforMeasurementCode_07 { get; set; }
        [D(8, "1018")]
        public string Exponent_08 { get; set; }
        [D(9, "649")]
        public string Multiplier_09 { get; set; }
        [D(10, "355")]
        public string UnitorBasisforMeasurementCode_10 { get; set; }
        [D(11, "1018")]
        public string Exponent_11 { get; set; }
        [D(12, "649")]
        public string Multiplier_12 { get; set; }
        [D(13, "355")]
        public string UnitorBasisforMeasurementCode_13 { get; set; }
        [D(14, "1018")]
        public string Exponent_14 { get; set; }
        [D(15, "649")]
        public string Multiplier_15 { get; set; }
    }
    
    public class All_AMT_2
    {
        
        [S("AMT", 1, typeof(X12_ID_522_5))]
        public AMT_SalesTaxAmount AMT_SalesTaxAmount { get; set; }
        [S("AMT", 2, typeof(X12_ID_522_6))]
        public AMT_PostageClaimedAmount AMT_PostageClaimedAmount { get; set; }
    }
    
    public class AMT_PostageClaimedAmount
    {
        
        [D(1, "522")]
        public string AmountQualifierCode_01 { get; set; }
        [D(2, "782")]
        public string PostageClaimedAmount_02 { get; set; }
        [D(3, "478")]
        public string CreditDebitFlagCode_03 { get; set; }
    }
    
    public class AMT_SalesTaxAmount
    {
        
        [D(1, "522")]
        public string AmountQualifierCode_01 { get; set; }
        [D(2, "782")]
        public string SalesTaxAmount_02 { get; set; }
        [D(3, "478")]
        public string CreditDebitFlagCode_03 { get; set; }
    }
    
    public class All_REF_7
    {
        
        [S("REF", 1, typeof(X12_ID_128_29))]
        public REF_RepricedLineItemReferenceNumber REF_RepricedLineItemReferenceNumber { get; set; }
        [S("REF", 2, typeof(X12_ID_128_30))]
        public REF_AdjustedRepricedLineItemReferenceNumber REF_AdjustedRepricedLineItemReferenceNumber { get; set; }
        [S("REF", 3, typeof(X12_ID_128_15))]
        public List<REF_PriorAuthorization_2> REF_PriorAuthorization_2 { get; set; }
        [S("REF", 4, typeof(X12_ID_128_32))]
        public REF_LineItemControlNumber REF_LineItemControlNumber { get; set; }
        [S("REF", 5, typeof(X12_ID_128_13))]
        public REF_MammographyCertificationNumber_2 REF_MammographyCertificationNumber_2 { get; set; }
        [S("REF", 6, typeof(X12_ID_128_17))]
        public REF_ClinicalLaboratoryImprovementAmendment_CLIA_Number_2 REF_ClinicalLaboratoryImprovementAmendment_CLIA_Number_2 { get; set; }
        [S("REF", 7, typeof(X12_ID_128_33))]
        public REF_ReferringClinicalLaboratoryImprovementAmendment_CLIA_FacilityIdentification REF_ReferringClinicalLaboratoryImprovementAmendment_CLIA_FacilityIdentification { get; set; }
        [S("REF", 8, typeof(X12_ID_128_34))]
        public REF_ImmunizationBatchNumber REF_ImmunizationBatchNumber { get; set; }
        [S("REF", 9, typeof(X12_ID_128_14))]
        public List<REF_ReferralNumber_2> REF_ReferralNumber_2 { get; set; }
    }
    
    public class REF_ReferralNumber_2
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string ReferralNumber_02 { get; set; }
        [D(3, "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_46 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_46
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string OtherPayerPrimaryIdentifier_02 { get; set; }
        [D(3, "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_ImmunizationBatchNumber
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string ImmunizationBatchNumber_02 { get; set; }
        [D(3, "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_45 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_45
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_ReferringClinicalLaboratoryImprovementAmendment_CLIA_FacilityIdentification
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string ReferringCLIANumber_02 { get; set; }
        [D(3, "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_44 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_44
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_ClinicalLaboratoryImprovementAmendment_CLIA_Number_2
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string ClinicalLaboratoryImprovementAmendmentNumber_02 { get; set; }
        [D(3, "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_43 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_43
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_MammographyCertificationNumber_2
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string MammographyCertificationNumber_02 { get; set; }
        [D(3, "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_42 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_42
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_LineItemControlNumber
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string LineItemControlNumber_02 { get; set; }
        [D(3, "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_41 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_41
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_PriorAuthorization_2
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string PriorAuthorizationorReferralNumber_02 { get; set; }
        [D(3, "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_40 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_40
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string OtherPayerPrimaryIdentifier_02 { get; set; }
        [D(3, "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_AdjustedRepricedLineItemReferenceNumber
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string AdjustedRepricedLineItemReferenceNumber_02 { get; set; }
        [D(3, "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_39 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_39
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_RepricedLineItemReferenceNumber
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string RepricedLineItemReferenceNumber_02 { get; set; }
        [D(3, "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_38 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_38
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class CN1_ContractInformation_2
    {
        
        [D(1, "1166")]
        public string ContractTypeCode_01 { get; set; }
        [D(2, "782")]
        public string ContractAmount_02 { get; set; }
        [D(3, "332")]
        public string ContractPercentage_03 { get; set; }
        [D(4, "127")]
        public string ContractCode_04 { get; set; }
        [D(5, "338")]
        public string TermsDiscountPercentage_05 { get; set; }
        [D(6, "799")]
        public string ContractVersionIdentifier_06 { get; set; }
    }
    
    public class MEA_TestResult
    {
        
        [D(1, "737")]
        public string MeasurementReferenceIdentificationCode_01 { get; set; }
        [D(2, "738")]
        public string MeasurementQualifier_02 { get; set; }
        [D(3, "739")]
        public string TestResults_03 { get; set; }
        [C(4)]
        public C001_CompositeUnitofMeasure_4 CompositeUnitofMeasure_04 { get; set; }
        [D(5, "740")]
        public string RangeMinimum_05 { get; set; }
        [D(6, "741")]
        public string RangeMaximum_06 { get; set; }
        [D(7, "935")]
        public string MeasurementSignificanceCode_07 { get; set; }
        [D(8, "936")]
        public string MeasurementAttributeCode_08 { get; set; }
        [D(9, "752")]
        public string SurfaceLayerPositionCode_09 { get; set; }
        [D(10, "1373")]
        public string MeasurementMethodorDevice_10 { get; set; }
        [D(11, "1270")]
        public string CodeListQualifierCode_11 { get; set; }
        [D(12, "1271")]
        public string IndustryCode_12 { get; set; }
    }
    
    public class C001_CompositeUnitofMeasure_4
    {
        
        [D(1, "355")]
        public string UnitorBasisforMeasurementCode_01 { get; set; }
        [D(2, "1018")]
        public string Exponent_02 { get; set; }
        [D(3, "649")]
        public string Multiplier_03 { get; set; }
        [D(4, "355")]
        public string UnitorBasisforMeasurementCode_04 { get; set; }
        [D(5, "1018")]
        public string Exponent_05 { get; set; }
        [D(6, "649")]
        public string Multiplier_06 { get; set; }
        [D(7, "355")]
        public string UnitorBasisforMeasurementCode_07 { get; set; }
        [D(8, "1018")]
        public string Exponent_08 { get; set; }
        [D(9, "649")]
        public string Multiplier_09 { get; set; }
        [D(10, "355")]
        public string UnitorBasisforMeasurementCode_10 { get; set; }
        [D(11, "1018")]
        public string Exponent_11 { get; set; }
        [D(12, "649")]
        public string Multiplier_12 { get; set; }
        [D(13, "355")]
        public string UnitorBasisforMeasurementCode_13 { get; set; }
        [D(14, "1018")]
        public string Exponent_14 { get; set; }
        [D(15, "649")]
        public string Multiplier_15 { get; set; }
    }
    
    public class All_QTY
    {
        
        [S("QTY", 1, typeof(X12_ID_673))]
        public QTY_AmbulancePatientCount QTY_AmbulancePatientCount { get; set; }
        [S("QTY", 2, typeof(X12_ID_673_2))]
        public QTY_ObstetricAnesthesiaAdditionalUnits QTY_ObstetricAnesthesiaAdditionalUnits { get; set; }
    }
    
    public class QTY_ObstetricAnesthesiaAdditionalUnits
    {
        
        [D(1, "673")]
        public string QuantityQualifier_01 { get; set; }
        [D(2, "380")]
        public string ObstetricAdditionalUnits_02 { get; set; }
        [C(3)]
        public C001_CompositeUnitofMeasure_3 CompositeUnitofMeasure_03 { get; set; }
        [D(4, "61")]
        public string FreeformInformation_04 { get; set; }
    }
    
    public class C001_CompositeUnitofMeasure_3
    {
        
        [D(1, "355")]
        public string UnitorBasisforMeasurementCode_01 { get; set; }
        [D(2, "1018")]
        public string Exponent_02 { get; set; }
        [D(3, "649")]
        public string Multiplier_03 { get; set; }
        [D(4, "355")]
        public string UnitorBasisforMeasurementCode_04 { get; set; }
        [D(5, "1018")]
        public string Exponent_05 { get; set; }
        [D(6, "649")]
        public string Multiplier_06 { get; set; }
        [D(7, "355")]
        public string UnitorBasisforMeasurementCode_07 { get; set; }
        [D(8, "1018")]
        public string Exponent_08 { get; set; }
        [D(9, "649")]
        public string Multiplier_09 { get; set; }
        [D(10, "355")]
        public string UnitorBasisforMeasurementCode_10 { get; set; }
        [D(11, "1018")]
        public string Exponent_11 { get; set; }
        [D(12, "649")]
        public string Multiplier_12 { get; set; }
        [D(13, "355")]
        public string UnitorBasisforMeasurementCode_13 { get; set; }
        [D(14, "1018")]
        public string Exponent_14 { get; set; }
        [D(15, "649")]
        public string Multiplier_15 { get; set; }
    }
    
    public class QTY_AmbulancePatientCount
    {
        
        [D(1, "673")]
        public string QuantityQualifier_01 { get; set; }
        [D(2, "380")]
        public string AmbulancePatientCount_02 { get; set; }
        [C(3)]
        public C001_CompositeUnitofMeasure_2 CompositeUnitofMeasure_03 { get; set; }
        [D(4, "61")]
        public string FreeformInformation_04 { get; set; }
    }
    
    public class C001_CompositeUnitofMeasure_2
    {
        
        [D(1, "355")]
        public string UnitorBasisforMeasurementCode_01 { get; set; }
        [D(2, "1018")]
        public string Exponent_02 { get; set; }
        [D(3, "649")]
        public string Multiplier_03 { get; set; }
        [D(4, "355")]
        public string UnitorBasisforMeasurementCode_04 { get; set; }
        [D(5, "1018")]
        public string Exponent_05 { get; set; }
        [D(6, "649")]
        public string Multiplier_06 { get; set; }
        [D(7, "355")]
        public string UnitorBasisforMeasurementCode_07 { get; set; }
        [D(8, "1018")]
        public string Exponent_08 { get; set; }
        [D(9, "649")]
        public string Multiplier_09 { get; set; }
        [D(10, "355")]
        public string UnitorBasisforMeasurementCode_10 { get; set; }
        [D(11, "1018")]
        public string Exponent_11 { get; set; }
        [D(12, "649")]
        public string Multiplier_12 { get; set; }
        [D(13, "355")]
        public string UnitorBasisforMeasurementCode_13 { get; set; }
        [D(14, "1018")]
        public string Exponent_14 { get; set; }
        [D(15, "649")]
        public string Multiplier_15 { get; set; }
    }
    
    public class All_DTP_2
    {
        
        [S("DTP", 1, typeof(X12_ID_374_19), typeof(X12_ID_1250_2))]
        public DTP_Date_ServiceDate DTP_Date_ServiceDate { get; set; }
        [S("DTP", 2, typeof(X12_ID_374_9), typeof(X12_ID_1250))]
        public DTP_Date_PrescriptionDate DTP_Date_PrescriptionDate { get; set; }
        [S("DTP", 3, typeof(X12_ID_374_20), typeof(X12_ID_1250))]
        public DTP_DATE_CertificationRevision_RecertificationDate DTP_DATE_CertificationRevision_RecertificationDate { get; set; }
        [S("DTP", 4, typeof(X12_ID_374_21), typeof(X12_ID_1250))]
        public DTP_Date_BeginTherapyDate DTP_Date_BeginTherapyDate { get; set; }
        [S("DTP", 5, typeof(X12_ID_374_22), typeof(X12_ID_1250))]
        public DTP_Date_LastCertificationDate DTP_Date_LastCertificationDate { get; set; }
        [S("DTP", 6, typeof(X12_ID_374_4), typeof(X12_ID_1250))]
        public DTP_Date_LastSeenDate_2 DTP_Date_LastSeenDate_2 { get; set; }
        [S("DTP", 7, typeof(X12_ID_374_23), typeof(X12_ID_1250))]
        public List<DTP_Date_TestDate> DTP_Date_TestDate { get; set; }
        [S("DTP", 8, typeof(X12_ID_374_24), typeof(X12_ID_1250))]
        public DTP_Date_ShippedDate DTP_Date_ShippedDate { get; set; }
        [S("DTP", 9, typeof(X12_ID_374_8), typeof(X12_ID_1250))]
        public DTP_Date_LastX_rayDate_2 DTP_Date_LastX_rayDate_2 { get; set; }
        [S("DTP", 10, typeof(X12_ID_374_3), typeof(X12_ID_1250))]
        public DTP_Date_InitialTreatmentDate_2 DTP_Date_InitialTreatmentDate_2 { get; set; }
    }
    
    public class DTP_Date_InitialTreatmentDate_2
    {
        
        [D(1, "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, "1251")]
        public string InitialTreatmentDate_03 { get; set; }
    }
    
    public class DTP_Date_LastX_rayDate_2
    {
        
        [D(1, "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, "1251")]
        public string LastXRayDate_03 { get; set; }
    }
    
    public class DTP_Date_ShippedDate
    {
        
        [D(1, "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, "1251")]
        public string ShippedDate_03 { get; set; }
    }
    
    public class DTP_Date_TestDate
    {
        
        [D(1, "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, "1251")]
        public string TestPerformedDate_03 { get; set; }
    }
    
    public class DTP_Date_LastSeenDate_2
    {
        
        [D(1, "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, "1251")]
        public string TreatmentorTherapyDate_03 { get; set; }
    }
    
    public class DTP_Date_LastCertificationDate
    {
        
        [D(1, "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, "1251")]
        public string LastCertificationDate_03 { get; set; }
    }
    
    public class DTP_Date_BeginTherapyDate
    {
        
        [D(1, "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, "1251")]
        public string BeginTherapyDate_03 { get; set; }
    }
    
    public class DTP_DATE_CertificationRevision_RecertificationDate
    {
        
        [D(1, "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, "1251")]
        public string CertificationRevisionorRecertificationDate_03 { get; set; }
    }
    
    public class DTP_Date_PrescriptionDate
    {
        
        [D(1, "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, "1251")]
        public string PrescriptionDate_03 { get; set; }
    }
    
    public class DTP_Date_ServiceDate
    {
        
        [D(1, "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, "1251")]
        public string ServiceDate_03 { get; set; }
    }
    
    public class All_CRC_2
    {
        
        [S("CRC", 1, typeof(X12_ID_1136), typeof(X12_ID_1073_3))]
        public List<CRC_AmbulanceCertification_2> CRC_AmbulanceCertification_2 { get; set; }
        [S("CRC", 2, typeof(X12_ID_1136_5), typeof(X12_ID_1073_3))]
        public CRC_HospiceEmployeeIndicator CRC_HospiceEmployeeIndicator { get; set; }
        [S("CRC", 3, typeof(X12_ID_1136_6), typeof(X12_ID_1073_3))]
        public CRC_ConditionIndicator_DurableMedicalEquipment CRC_ConditionIndicator_DurableMedicalEquipment { get; set; }
    }
    
    public class CRC_ConditionIndicator_DurableMedicalEquipment
    {
        
        [D(1, "1136")]
        public string CodeCategory_01 { get; set; }
        [D(2, "1073")]
        public string CertificationConditionIndicator_02 { get; set; }
        [D(3, "1321")]
        public string ConditionIndicator_03 { get; set; }
        [D(4, "1321")]
        public string ConditionIndicator_04 { get; set; }
        [D(5, "1321")]
        public string ConditionIndicator_05 { get; set; }
        [D(6, "1321")]
        public string ConditionIndicator_06 { get; set; }
        [D(7, "1321")]
        public string ConditionIndicator_07 { get; set; }
    }
    
    public class CRC_HospiceEmployeeIndicator
    {
        
        [D(1, "1136")]
        public string CodeCategory_01 { get; set; }
        [D(2, "1073")]
        public string HospiceEmployedProviderIndicator_02 { get; set; }
        [D(3, "1321")]
        public string ConditionIndicator_03 { get; set; }
        [D(4, "1321")]
        public string ConditionIndicator_04 { get; set; }
        [D(5, "1321")]
        public string ConditionIndicator_05 { get; set; }
        [D(6, "1321")]
        public string ConditionIndicator_06 { get; set; }
        [D(7, "1321")]
        public string ConditionIndicator_07 { get; set; }
    }
    
    public class CRC_AmbulanceCertification_2
    {
        
        [D(1, "1136")]
        public string CodeCategory_01 { get; set; }
        [D(2, "1073")]
        public string CertificationConditionIndicator_02 { get; set; }
        [D(3, "1321")]
        public string ConditionCode_03 { get; set; }
        [D(4, "1321")]
        public string ConditionCode_04 { get; set; }
        [D(5, "1321")]
        public string ConditionCode_05 { get; set; }
        [D(6, "1321")]
        public string ConditionCode_06 { get; set; }
        [D(7, "1321")]
        public string ConditionCode_07 { get; set; }
    }
    
    public class CR3_DurableMedicalEquipmentCertification
    {
        
        [D(1, "1322")]
        public string CertificationTypeCode_01 { get; set; }
        [D(2, "355")]
        public string UnitorBasisforMeasurementCode_02 { get; set; }
        [D(3, "380")]
        public string DurableMedicalEquipmentDuration_03 { get; set; }
        [D(4, "1335")]
        public string InsulinDependentCode_04 { get; set; }
        [D(5, "352")]
        public string Description_05 { get; set; }
    }
    
    public class CR1_AmbulanceTransportInformation_2
    {
        
        [D(1, "355")]
        public string UnitorBasisforMeasurementCode_01 { get; set; }
        [D(2, "81")]
        public string PatientWeight_02 { get; set; }
        [D(3, "1316")]
        public string AmbulanceTransportCode_03 { get; set; }
        [D(4, "1317")]
        public string AmbulanceTransportReasonCode_04 { get; set; }
        [D(5, "355")]
        public string UnitorBasisforMeasurementCode_05 { get; set; }
        [D(6, "380")]
        public string TransportDistance_06 { get; set; }
        [D(7, "166")]
        public string AddressInformation_07 { get; set; }
        [D(8, "166")]
        public string AddressInformation_08 { get; set; }
        [D(9, "352")]
        public string RoundTripPurposeDescription_09 { get; set; }
        [D(10, "352")]
        public string StretcherPurposeDescription_10 { get; set; }
    }
    
    public class All_PWK
    {
        
        [S("PWK", 1, typeof(X12_ID_755_2), typeof(X12_ID_756))]
        public List<PWK_LineSupplementalInformation> PWK_LineSupplementalInformation { get; set; }
        [S("PWK", 2, typeof(X12_ID_755_3), typeof(X12_ID_756_2))]
        public PWK_DurableMedicalEquipmentCertificateofMedicalNecessityIndicator PWK_DurableMedicalEquipmentCertificateofMedicalNecessityIndicator { get; set; }
    }
    
    public class PWK_DurableMedicalEquipmentCertificateofMedicalNecessityIndicator
    {
        
        [D(1, "755")]
        public string AttachmentReportTypeCode_01 { get; set; }
        [D(2, "756")]
        public string AttachmentTransmissionCode_02 { get; set; }
        [D(3, "757")]
        public string ReportCopiesNeeded_03 { get; set; }
        [D(4, "98")]
        public string EntityIdentifierCode_04 { get; set; }
        [D(5, "66")]
        public string IdentificationCodeQualifier_05 { get; set; }
        [D(6, "67")]
        public string IdentificationCode_06 { get; set; }
        [D(7, "352")]
        public string Description_07 { get; set; }
        [C(8)]
        public C002_ActionsIndicated_3 ActionsIndicated_08 { get; set; }
        [D(9, "1525")]
        public string RequestCategoryCode_09 { get; set; }
    }
    
    public class C002_ActionsIndicated_3
    {
        
        [D(1, "704")]
        public string PaperworkReportActionCode_01 { get; set; }
        [D(2, "704")]
        public string PaperworkReportActionCode_02 { get; set; }
        [D(3, "704")]
        public string PaperworkReportActionCode_03 { get; set; }
        [D(4, "704")]
        public string PaperworkReportActionCode_04 { get; set; }
        [D(5, "704")]
        public string PaperworkReportActionCode_05 { get; set; }
    }
    
    public class PWK_LineSupplementalInformation
    {
        
        [D(1, "755")]
        public string AttachmentReportTypeCode_01 { get; set; }
        [D(2, "756")]
        public string AttachmentTransmissionCode_02 { get; set; }
        [D(3, "757")]
        public string ReportCopiesNeeded_03 { get; set; }
        [D(4, "98")]
        public string EntityIdentifierCode_04 { get; set; }
        [D(5, "66")]
        public string IdentificationCodeQualifier_05 { get; set; }
        [D(6, "67")]
        public string AttachmentControlNumber_06 { get; set; }
        [D(7, "352")]
        public string Description_07 { get; set; }
        [C(8)]
        public C002_ActionsIndicated_2 ActionsIndicated_08 { get; set; }
        [D(9, "1525")]
        public string RequestCategoryCode_09 { get; set; }
    }
    
    public class C002_ActionsIndicated_2
    {
        
        [D(1, "704")]
        public string PaperworkReportActionCode_01 { get; set; }
        [D(2, "704")]
        public string PaperworkReportActionCode_02 { get; set; }
        [D(3, "704")]
        public string PaperworkReportActionCode_03 { get; set; }
        [D(4, "704")]
        public string PaperworkReportActionCode_04 { get; set; }
        [D(5, "704")]
        public string PaperworkReportActionCode_05 { get; set; }
    }
    
    public class SV5_DurableMedicalEquipmentService
    {
        
        [C(1)]
        public C003_CompositeMedicalProcedureIdentifier_2 CompositeMedicalProcedureIdentifier_01 { get; set; }
        [D(2, "355")]
        public string UnitorBasisforMeasurementCode_02 { get; set; }
        [D(3, "380")]
        public string LengthofMedicalNecessity_03 { get; set; }
        [D(4, "782")]
        public string DMERentalPrice_04 { get; set; }
        [D(5, "782")]
        public string DMEPurchasePrice_05 { get; set; }
        [D(6, "594")]
        public string RentalUnitPriceIndicator_06 { get; set; }
        [D(7, "923")]
        public string PrognosisCode_07 { get; set; }
    }
    
    public class C003_CompositeMedicalProcedureIdentifier_2
    {
        
        [D(1, "235")]
        public string ProcedureIdentifier_01 { get; set; }
        [D(2, "234")]
        public string ProcedureCode_02 { get; set; }
        [D(3, "1339")]
        public string ProcedureModifier_03 { get; set; }
        [D(4, "1339")]
        public string ProcedureModifier_04 { get; set; }
        [D(5, "1339")]
        public string ProcedureModifier_05 { get; set; }
        [D(6, "1339")]
        public string ProcedureModifier_06 { get; set; }
        [D(7, "352")]
        public string Description_07 { get; set; }
        [D(8, "234")]
        public string ProductServiceID_08 { get; set; }
    }
    
    public class SV1_ProfessionalService
    {
        
        [C(1)]
        public C003_CompositeMedicalProcedureIdentifier CompositeMedicalProcedureIdentifier_01 { get; set; }
        [D(2, "782")]
        public string LineItemChargeAmount_02 { get; set; }
        [D(3, "355")]
        public string UnitorBasisforMeasurementCode_03 { get; set; }
        [D(4, "380")]
        public string ServiceUnitCount_04 { get; set; }
        [D(5, "1331")]
        public string PlaceofServiceCode_05 { get; set; }
        [D(6, "1365")]
        public string ServiceTypeCode_06 { get; set; }
        [C(7)]
        public C004_CompositeDiagnosisCodePointer CompositeDiagnosisCodePointer_07 { get; set; }
        [D(8, "782")]
        public string MonetaryAmount_08 { get; set; }
        [D(9, "1073")]
        public string EmergencyIndicator_09 { get; set; }
        [D(10, "1340")]
        public string MultipleProcedureCode_10 { get; set; }
        [D(11, "1073")]
        public string EPSDTIndicator_11 { get; set; }
        [D(12, "1073")]
        public string FamilyPlanningIndicator_12 { get; set; }
        [D(13, "1364")]
        public string ReviewCode_13 { get; set; }
        [D(14, "1341")]
        public string NationalorLocalAssignedReviewValue_14 { get; set; }
        [D(15, "1327")]
        public string CoPayStatusCode_15 { get; set; }
        [D(16, "1334")]
        public string HealthCareProfessionalShortageAreaCode_16 { get; set; }
        [D(17, "127")]
        public string ReferenceIdentification_17 { get; set; }
        [D(18, "116")]
        public string PostalCode_18 { get; set; }
        [D(19, "782")]
        public string MonetaryAmount_19 { get; set; }
        [D(20, "1337")]
        public string LevelofCareCode_20 { get; set; }
        [D(21, "1360")]
        public string ProviderAgreementCode_21 { get; set; }
    }
    
    public class C004_CompositeDiagnosisCodePointer
    {
        
        [D(1, "1328")]
        public string DiagnosisCodePointer_01 { get; set; }
        [D(2, "1328")]
        public string DiagnosisCodePointer_02 { get; set; }
        [D(3, "1328")]
        public string DiagnosisCodePointer_03 { get; set; }
        [D(4, "1328")]
        public string DiagnosisCodePointer_04 { get; set; }
    }
    
    public class C003_CompositeMedicalProcedureIdentifier
    {
        
        [D(1, "235")]
        public string ProductorServiceIDQualifier_01 { get; set; }
        [D(2, "234")]
        public string ProcedureCode_02 { get; set; }
        [D(3, "1339")]
        public string ProcedureModifier_03 { get; set; }
        [D(4, "1339")]
        public string ProcedureModifier_04 { get; set; }
        [D(5, "1339")]
        public string ProcedureModifier_05 { get; set; }
        [D(6, "1339")]
        public string ProcedureModifier_06 { get; set; }
        [D(7, "352")]
        public string Description_07 { get; set; }
        [D(8, "234")]
        public string ProductServiceID_08 { get; set; }
    }
    
    public class LX_ServiceLineNumber
    {
        
        [D(1, "554")]
        public string AssignedNumber_01 { get; set; }
    }
    
    public class Loop_2320
    {
        
        [S("SBR", 1, typeof(X12_ID_1138), typeof(X12_ID_1069_3))]
        public SBR_OtherSubscriberInformation SBR_OtherSubscriberInformation { get; set; }
        [S("CAS", 2, typeof(X12_ID_1033))]
        public List<CAS_ClaimLevelAdjustments> CAS_ClaimLevelAdjustments { get; set; }
        [A(3)]
        public All_AMT All_AMT { get; set; }
        [S("OI", 4, typeof(X12_ID_1032_2), typeof(X12_ID_1383))]
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
        
        [S("NM1", 1, typeof(X12_ID_98_4), typeof(X12_ID_1065))]
        public NM1_OtherPayerBillingProvider NM1_OtherPayerBillingProvider { get; set; }
        [S("REF", 2, typeof(X12_ID_128_10))]
        public List<REF_OtherPayerBillingProviderSecondaryIdentification> REF_OtherPayerBillingProviderSecondaryIdentification { get; set; }
    }
    
    public class REF_OtherPayerBillingProviderSecondaryIdentification
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string OtherPayerBillingProviderIdentifier_02 { get; set; }
        [D(3, "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_37 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_37
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class NM1_OtherPayerBillingProvider
    {
        
        [D(1, "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, "1035")]
        public string NameLastorOrganizationName_03 { get; set; }
        [D(4, "1036")]
        public string NameFirst_04 { get; set; }
        [D(5, "1037")]
        public string NameMiddle_05 { get; set; }
        [D(6, "1038")]
        public string NamePrefix_06 { get; set; }
        [D(7, "1039")]
        public string NameSuffix_07 { get; set; }
        [D(8, "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, "67")]
        public string IdentificationCode_09 { get; set; }
        [D(10, "706")]
        public string EntityRelationshipCode_10 { get; set; }
        [D(11, "98")]
        public string EntityIdentifierCode_11 { get; set; }
        [D(12, "1035")]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    public class Loop_2330F
    {
        
        [S("NM1", 1, typeof(X12_ID_98_12), typeof(X12_ID_1065_3))]
        public NM1_OtherPayerSupervisingProvider NM1_OtherPayerSupervisingProvider { get; set; }
        [S("REF", 2, typeof(X12_ID_128_26))]
        public List<REF_OtherPayerSupervisingProviderSecondaryIdentification> REF_OtherPayerSupervisingProviderSecondaryIdentification { get; set; }
    }
    
    public class REF_OtherPayerSupervisingProviderSecondaryIdentification
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string OtherPayerSupervisingProviderIdentifier_02 { get; set; }
        [D(3, "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_36 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_36
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class NM1_OtherPayerSupervisingProvider
    {
        
        [D(1, "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, "1035")]
        public string NameLastorOrganizationName_03 { get; set; }
        [D(4, "1036")]
        public string NameFirst_04 { get; set; }
        [D(5, "1037")]
        public string NameMiddle_05 { get; set; }
        [D(6, "1038")]
        public string NamePrefix_06 { get; set; }
        [D(7, "1039")]
        public string NameSuffix_07 { get; set; }
        [D(8, "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, "67")]
        public string IdentificationCode_09 { get; set; }
        [D(10, "706")]
        public string EntityRelationshipCode_10 { get; set; }
        [D(11, "98")]
        public string EntityIdentifierCode_11 { get; set; }
        [D(12, "1035")]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    public class Loop_2330E
    {
        
        [S("NM1", 1, typeof(X12_ID_98_11), typeof(X12_ID_1065_2))]
        public NM1_OtherPayerServiceFacilityLocation NM1_OtherPayerServiceFacilityLocation { get; set; }
        [S("REF", 2, typeof(X12_ID_128_27))]
        public List<REF_OtherPayerServiceFacilityLocationSecondaryIdentification> REF_OtherPayerServiceFacilityLocationSecondaryIdentification { get; set; }
    }
    
    public class REF_OtherPayerServiceFacilityLocationSecondaryIdentification
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string OtherPayerServiceFacilityLocationSecondaryIdentifier_02 { get; set; }
        [D(3, "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_35 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_35
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class NM1_OtherPayerServiceFacilityLocation
    {
        
        [D(1, "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, "1035")]
        public string NameLastorOrganizationName_03 { get; set; }
        [D(4, "1036")]
        public string NameFirst_04 { get; set; }
        [D(5, "1037")]
        public string NameMiddle_05 { get; set; }
        [D(6, "1038")]
        public string NamePrefix_06 { get; set; }
        [D(7, "1039")]
        public string NameSuffix_07 { get; set; }
        [D(8, "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, "67")]
        public string IdentificationCode_09 { get; set; }
        [D(10, "706")]
        public string EntityRelationshipCode_10 { get; set; }
        [D(11, "98")]
        public string EntityIdentifierCode_11 { get; set; }
        [D(12, "1035")]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    public class Loop_2330D
    {
        
        [S("NM1", 1, typeof(X12_ID_98_10), typeof(X12_ID_1065))]
        public NM1_OtherPayerRenderingProvider NM1_OtherPayerRenderingProvider { get; set; }
        [S("REF", 2, typeof(X12_ID_128_26))]
        public List<REF_OtherPayerRenderingProviderSecondaryIdentification> REF_OtherPayerRenderingProviderSecondaryIdentification { get; set; }
    }
    
    public class REF_OtherPayerRenderingProviderSecondaryIdentification
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string OtherPayerRenderingProviderSecondaryIdentifier_02 { get; set; }
        [D(3, "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_34 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_34
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class NM1_OtherPayerRenderingProvider
    {
        
        [D(1, "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, "1035")]
        public string NameLastorOrganizationName_03 { get; set; }
        [D(4, "1036")]
        public string NameFirst_04 { get; set; }
        [D(5, "1037")]
        public string NameMiddle_05 { get; set; }
        [D(6, "1038")]
        public string NamePrefix_06 { get; set; }
        [D(7, "1039")]
        public string NameSuffix_07 { get; set; }
        [D(8, "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, "67")]
        public string IdentificationCode_09 { get; set; }
        [D(10, "706")]
        public string EntityRelationshipCode_10 { get; set; }
        [D(11, "98")]
        public string EntityIdentifierCode_11 { get; set; }
        [D(12, "1035")]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    public class Loop_2330C
    {
        
        [S("NM1", 1, typeof(X12_ID_98_9), typeof(X12_ID_1065_3))]
        public NM1_OtherPayerReferringProvider NM1_OtherPayerReferringProvider { get; set; }
        [S("REF", 2, typeof(X12_ID_128_25))]
        public List<REF_OtherPayerReferringProviderSecondaryIdentification> REF_OtherPayerReferringProviderSecondaryIdentification { get; set; }
    }
    
    public class REF_OtherPayerReferringProviderSecondaryIdentification
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string OtherPayerReferringProviderIdentifier_02 { get; set; }
        [D(3, "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_33 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_33
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class NM1_OtherPayerReferringProvider
    {
        
        [D(1, "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, "1035")]
        public string NameLastorOrganizationName_03 { get; set; }
        [D(4, "1036")]
        public string NameFirst_04 { get; set; }
        [D(5, "1037")]
        public string NameMiddle_05 { get; set; }
        [D(6, "1038")]
        public string NamePrefix_06 { get; set; }
        [D(7, "1039")]
        public string NameSuffix_07 { get; set; }
        [D(8, "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, "67")]
        public string IdentificationCode_09 { get; set; }
        [D(10, "706")]
        public string EntityRelationshipCode_10 { get; set; }
        [D(11, "98")]
        public string EntityIdentifierCode_11 { get; set; }
        [D(12, "1035")]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    public class Loop_2330B
    {
        
        [S("NM1", 1, typeof(X12_ID_98_8), typeof(X12_ID_1065_2))]
        public NM1_OtherPayerName NM1_OtherPayerName { get; set; }
        [S("N3", 2)]
        public N3_OtherPayerAddress N3_OtherPayerAddress { get; set; }
        [S("N4", 3)]
        public N4_OtherPayerCity_State_ZIPCode N4_OtherPayerCity_State_ZIPCode { get; set; }
        [S("DTP", 4, typeof(X12_ID_374_18), typeof(X12_ID_1250))]
        public DTP_ClaimCheckorRemittanceDate DTP_ClaimCheckorRemittanceDate { get; set; }
        [A(5)]
        public All_REF_6 All_REF_6 { get; set; }
    }
    
    public class All_REF_6
    {
        
        [S("REF", 1, typeof(X12_ID_128_9))]
        public List<REF_OtherPayerSecondaryIdentifier> REF_OtherPayerSecondaryIdentifier { get; set; }
        [S("REF", 2, typeof(X12_ID_128_15))]
        public REF_OtherPayerPriorAuthorizationNumber REF_OtherPayerPriorAuthorizationNumber { get; set; }
        [S("REF", 3, typeof(X12_ID_128_14))]
        public REF_OtherPayerReferralNumber REF_OtherPayerReferralNumber { get; set; }
        [S("REF", 4, typeof(X12_ID_128_28))]
        public REF_OtherPayerClaimAdjustmentIndicator REF_OtherPayerClaimAdjustmentIndicator { get; set; }
        [S("REF", 5, typeof(X12_ID_128_16))]
        public REF_OtherPayerClaimControlNumber REF_OtherPayerClaimControlNumber { get; set; }
    }
    
    public class REF_OtherPayerClaimControlNumber
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string OtherPayersClaimControlNumber_02 { get; set; }
        [D(3, "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_32 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_32
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_OtherPayerClaimAdjustmentIndicator
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string OtherPayerClaimAdjustmentIndicator_02 { get; set; }
        [D(3, "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_31 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_31
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_OtherPayerReferralNumber
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string OtherPayerPriorAuthorizationorReferralNumber_02 { get; set; }
        [D(3, "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_30 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_30
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_OtherPayerPriorAuthorizationNumber
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string OtherPayerPriorAuthorizationNumber_02 { get; set; }
        [D(3, "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_29 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_29
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_OtherPayerSecondaryIdentifier
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string OtherPayerSecondaryIdentifier_02 { get; set; }
        [D(3, "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_28 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_28
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class DTP_ClaimCheckorRemittanceDate
    {
        
        [D(1, "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, "1251")]
        public string AdjudicationorPaymentDate_03 { get; set; }
    }
    
    public class N4_OtherPayerCity_State_ZIPCode
    {
        
        [D(1, "19")]
        public string OtherPayerCityName_01 { get; set; }
        [D(2, "156")]
        public string OtherPayerStateorProvinceCode_02 { get; set; }
        [D(3, "116")]
        public string OtherPayerPostalZoneorZIPCode_03 { get; set; }
        [D(4, "26")]
        public string CountryCode_04 { get; set; }
        [D(5, "309")]
        public string LocationQualifier_05 { get; set; }
        [D(6, "310")]
        public string LocationIdentifier_06 { get; set; }
        [D(7, "1715")]
        public string CountrySubdivisionCode_07 { get; set; }
    }
    
    public class N3_OtherPayerAddress
    {
        
        [D(1, "166")]
        public string OtherPayerAddressLine_01 { get; set; }
        [D(2, "166")]
        public string OtherPayerAddressLine_02 { get; set; }
    }
    
    public class NM1_OtherPayerName
    {
        
        [D(1, "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, "1035")]
        public string OtherPayerOrganizationName_03 { get; set; }
        [D(4, "1036")]
        public string NameFirst_04 { get; set; }
        [D(5, "1037")]
        public string NameMiddle_05 { get; set; }
        [D(6, "1038")]
        public string NamePrefix_06 { get; set; }
        [D(7, "1039")]
        public string NameSuffix_07 { get; set; }
        [D(8, "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, "67")]
        public string OtherPayerPrimaryIdentifier_09 { get; set; }
        [D(10, "706")]
        public string EntityRelationshipCode_10 { get; set; }
        [D(11, "98")]
        public string EntityIdentifierCode_11 { get; set; }
        [D(12, "1035")]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    public class Loop_2330A
    {
        
        [S("NM1", 1, typeof(X12_ID_98_7), typeof(X12_ID_1065))]
        public NM1_OtherSubscriberName NM1_OtherSubscriberName { get; set; }
        [S("N3", 2)]
        public N3_OtherSubscriberAddress N3_OtherSubscriberAddress { get; set; }
        [S("N4", 3)]
        public N4_OtherSubscriberCity_State_ZIPCode N4_OtherSubscriberCity_State_ZIPCode { get; set; }
        [S("REF", 4, typeof(X12_ID_128_7))]
        public REF_OtherSubscriberSecondaryIdentification REF_OtherSubscriberSecondaryIdentification { get; set; }
    }
    
    public class REF_OtherSubscriberSecondaryIdentification
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string OtherInsuredAdditionalIdentifier_02 { get; set; }
        [D(3, "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_27 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_27
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class N4_OtherSubscriberCity_State_ZIPCode
    {
        
        [D(1, "19")]
        public string OtherSubscriberCityName_01 { get; set; }
        [D(2, "156")]
        public string OtherSubscriberStateorProvinceCode_02 { get; set; }
        [D(3, "116")]
        public string OtherSubscriberPostalZoneorZIPCode_03 { get; set; }
        [D(4, "26")]
        public string CountryCode_04 { get; set; }
        [D(5, "309")]
        public string LocationQualifier_05 { get; set; }
        [D(6, "310")]
        public string LocationIdentifier_06 { get; set; }
        [D(7, "1715")]
        public string CountrySubdivisionCode_07 { get; set; }
    }
    
    public class N3_OtherSubscriberAddress
    {
        
        [D(1, "166")]
        public string OtherInsuredAddressLine_01 { get; set; }
        [D(2, "166")]
        public string OtherInsuredAddressLine_02 { get; set; }
    }
    
    public class NM1_OtherSubscriberName
    {
        
        [D(1, "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, "1035")]
        public string OtherInsuredLastName_03 { get; set; }
        [D(4, "1036")]
        public string OtherInsuredFirstName_04 { get; set; }
        [D(5, "1037")]
        public string OtherInsuredMiddleName_05 { get; set; }
        [D(6, "1038")]
        public string NamePrefix_06 { get; set; }
        [D(7, "1039")]
        public string OtherInsuredNameSuffix_07 { get; set; }
        [D(8, "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, "67")]
        public string OtherInsuredIdentifier_09 { get; set; }
        [D(10, "706")]
        public string EntityRelationshipCode_10 { get; set; }
        [D(11, "98")]
        public string EntityIdentifierCode_11 { get; set; }
        [D(12, "1035")]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    public class MOA_OutpatientAdjudicationInformation
    {
        
        [D(1, "954")]
        public string ReimbursementRate_01 { get; set; }
        [D(2, "782")]
        public string HCPCSPayableAmount_02 { get; set; }
        [D(3, "127")]
        public string ClaimPaymentRemarkCode_03 { get; set; }
        [D(4, "127")]
        public string ClaimPaymentRemarkCode_04 { get; set; }
        [D(5, "127")]
        public string ClaimPaymentRemarkCode_05 { get; set; }
        [D(6, "127")]
        public string ClaimPaymentRemarkCode_06 { get; set; }
        [D(7, "127")]
        public string ClaimPaymentRemarkCode_07 { get; set; }
        [D(8, "782")]
        public string EndStageRenalDiseasePaymentAmount_08 { get; set; }
        [D(9, "782")]
        public string NonPayableProfessionalComponentBilledAmount_09 { get; set; }
    }
    
    public class OI_OtherInsuranceCoverageInformation
    {
        
        [D(1, "1032")]
        public string ClaimFilingIndicatorCode_01 { get; set; }
        [D(2, "1383")]
        public string ClaimSubmissionReasonCode_02 { get; set; }
        [D(3, "1073")]
        public string BenefitsAssignmentCertificationIndicator_03 { get; set; }
        [D(4, "1351")]
        public string PatientSignatureSourceCode_04 { get; set; }
        [D(5, "1360")]
        public string ProviderAgreementCode_05 { get; set; }
        [D(6, "1363")]
        public string ReleaseofInformationCode_06 { get; set; }
    }
    
    public class All_AMT
    {
        
        [S("AMT", 1, typeof(X12_ID_522_2))]
        public AMT_CoordinationofBenefits_COB_PayerPaidAmount AMT_CoordinationofBenefits_COB_PayerPaidAmount { get; set; }
        [S("AMT", 2, typeof(X12_ID_522_3))]
        public AMT_CoordinationofBenefits_COB_TotalNon_coveredAmount AMT_CoordinationofBenefits_COB_TotalNon_coveredAmount { get; set; }
        [S("AMT", 3, typeof(X12_ID_522_4))]
        public AMT_RemainingPatientLiability AMT_RemainingPatientLiability { get; set; }
    }
    
    public class AMT_RemainingPatientLiability
    {
        
        [D(1, "522")]
        public string AmountQualifierCode_01 { get; set; }
        [D(2, "782")]
        public string RemainingPatientLiability_02 { get; set; }
        [D(3, "478")]
        public string CreditDebitFlagCode_03 { get; set; }
    }
    
    public class AMT_CoordinationofBenefits_COB_TotalNon_coveredAmount
    {
        
        [D(1, "522")]
        public string AmountQualifierCode_01 { get; set; }
        [D(2, "782")]
        public string NonCoveredChargeAmount_02 { get; set; }
        [D(3, "478")]
        public string CreditDebitFlagCode_03 { get; set; }
    }
    
    public class AMT_CoordinationofBenefits_COB_PayerPaidAmount
    {
        
        [D(1, "522")]
        public string AmountQualifierCode_01 { get; set; }
        [D(2, "782")]
        public string PayerPaidAmount_02 { get; set; }
        [D(3, "478")]
        public string CreditDebitFlagCode_03 { get; set; }
    }
    
    public class CAS_ClaimLevelAdjustments
    {
        
        [D(1, "1033")]
        public string ClaimAdjustmentGroupCode_01 { get; set; }
        [D(2, "1034")]
        public string AdjustmentReasonCode_02 { get; set; }
        [D(3, "782")]
        public string AdjustmentAmount_03 { get; set; }
        [D(4, "380")]
        public string AdjustmentQuantity_04 { get; set; }
        [D(5, "1034")]
        public string AdjustmentReasonCode_05 { get; set; }
        [D(6, "782")]
        public string AdjustmentAmount_06 { get; set; }
        [D(7, "380")]
        public string AdjustmentQuantity_07 { get; set; }
        [D(8, "1034")]
        public string AdjustmentReasonCode_08 { get; set; }
        [D(9, "782")]
        public string AdjustmentAmount_09 { get; set; }
        [D(10, "380")]
        public string AdjustmentQuantity_10 { get; set; }
        [D(11, "1034")]
        public string AdjustmentReasonCode_11 { get; set; }
        [D(12, "782")]
        public string AdjustmentAmount_12 { get; set; }
        [D(13, "380")]
        public string AdjustmentQuantity_13 { get; set; }
        [D(14, "1034")]
        public string AdjustmentReasonCode_14 { get; set; }
        [D(15, "782")]
        public string AdjustmentAmount_15 { get; set; }
        [D(16, "380")]
        public string AdjustmentQuantity_16 { get; set; }
        [D(17, "1034")]
        public string AdjustmentReasonCode_17 { get; set; }
        [D(18, "782")]
        public string AdjustmentAmount_18 { get; set; }
        [D(19, "380")]
        public string AdjustmentQuantity_19 { get; set; }
    }
    
    public class SBR_OtherSubscriberInformation
    {
        
        [D(1, "1138")]
        public string PayerResponsibilitySequenceNumberCode_01 { get; set; }
        [D(2, "1069")]
        public string IndividualRelationshipCode_02 { get; set; }
        [D(3, "127")]
        public string InsuredGrouporPolicyNumber_03 { get; set; }
        [D(4, "93")]
        public string OtherInsuredGroupName_04 { get; set; }
        [D(5, "1336")]
        public string InsuranceTypeCode_05 { get; set; }
        [D(6, "1143")]
        public string CoordinationofBenefitsCode_06 { get; set; }
        [D(7, "1073")]
        public string YesNoConditionorResponseCode_07 { get; set; }
        [D(8, "584")]
        public string EmploymentStatusCode_08 { get; set; }
        [D(9, "1032")]
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
        
        [S("NM1", 1, typeof(X12_ID_98_14), typeof(X12_ID_1065_2))]
        public NM1_AmbulanceDrop_offLocation NM1_AmbulanceDrop_offLocation { get; set; }
        [S("N3", 2)]
        public N3_AmbulanceDrop_offLocationAddress N3_AmbulanceDrop_offLocationAddress { get; set; }
        [S("N4", 3)]
        public N4_AmbulanceDrop_offLocationCity_State_ZipCode N4_AmbulanceDrop_offLocationCity_State_ZipCode { get; set; }
    }
    
    public class N4_AmbulanceDrop_offLocationCity_State_ZipCode
    {
        
        [D(1, "19")]
        public string AmbulanceDropoffCityName_01 { get; set; }
        [D(2, "156")]
        public string AmbulanceDropoffStateorProvinceCode_02 { get; set; }
        [D(3, "116")]
        public string AmbulanceDropoffPostalZoneorZIPCode_03 { get; set; }
        [D(4, "26")]
        public string CountryCode_04 { get; set; }
        [D(5, "309")]
        public string LocationQualifier_05 { get; set; }
        [D(6, "310")]
        public string LocationIdentifier_06 { get; set; }
        [D(7, "1715")]
        public string CountrySubdivisionCode_07 { get; set; }
    }
    
    public class N3_AmbulanceDrop_offLocationAddress
    {
        
        [D(1, "166")]
        public string AmbulanceDropoffAddressLine_01 { get; set; }
        [D(2, "166")]
        public string AmbulanceDropoffAddressLine_02 { get; set; }
    }
    
    public class NM1_AmbulanceDrop_offLocation
    {
        
        [D(1, "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, "1035")]
        public string AmbulanceDropoffLocation_03 { get; set; }
        [D(4, "1036")]
        public string NameFirst_04 { get; set; }
        [D(5, "1037")]
        public string NameMiddle_05 { get; set; }
        [D(6, "1038")]
        public string NamePrefix_06 { get; set; }
        [D(7, "1039")]
        public string NameSuffix_07 { get; set; }
        [D(8, "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, "67")]
        public string IdentificationCode_09 { get; set; }
        [D(10, "706")]
        public string EntityRelationshipCode_10 { get; set; }
        [D(11, "98")]
        public string EntityIdentifierCode_11 { get; set; }
        [D(12, "1035")]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    public class Loop_2310E
    {
        
        [S("NM1", 1, typeof(X12_ID_98_13), typeof(X12_ID_1065_2))]
        public NM1_AmbulancePick_upLocation NM1_AmbulancePick_upLocation { get; set; }
        [S("N3", 2)]
        public N3_AmbulancePick_upLocationAddress N3_AmbulancePick_upLocationAddress { get; set; }
        [S("N4", 3)]
        public N4_AmbulancePick_upLocationCity_State_ZipCode N4_AmbulancePick_upLocationCity_State_ZipCode { get; set; }
    }
    
    public class N4_AmbulancePick_upLocationCity_State_ZipCode
    {
        
        [D(1, "19")]
        public string AmbulancePickupCityName_01 { get; set; }
        [D(2, "156")]
        public string AmbulancePickupStateorProvinceCode_02 { get; set; }
        [D(3, "116")]
        public string AmbulancePickupPostalZoneorZIPCode_03 { get; set; }
        [D(4, "26")]
        public string CountryCode_04 { get; set; }
        [D(5, "309")]
        public string LocationQualifier_05 { get; set; }
        [D(6, "310")]
        public string LocationIdentifier_06 { get; set; }
        [D(7, "1715")]
        public string CountrySubdivisionCode_07 { get; set; }
    }
    
    public class N3_AmbulancePick_upLocationAddress
    {
        
        [D(1, "166")]
        public string AmbulancePickupAddressLine_01 { get; set; }
        [D(2, "166")]
        public string AmbulancePickupAddressLine_02 { get; set; }
    }
    
    public class NM1_AmbulancePick_upLocation
    {
        
        [D(1, "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, "1035")]
        public string NameLastorOrganizationName_03 { get; set; }
        [D(4, "1036")]
        public string NameFirst_04 { get; set; }
        [D(5, "1037")]
        public string NameMiddle_05 { get; set; }
        [D(6, "1038")]
        public string NamePrefix_06 { get; set; }
        [D(7, "1039")]
        public string NameSuffix_07 { get; set; }
        [D(8, "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, "67")]
        public string IdentificationCode_09 { get; set; }
        [D(10, "706")]
        public string EntityRelationshipCode_10 { get; set; }
        [D(11, "98")]
        public string EntityIdentifierCode_11 { get; set; }
        [D(12, "1035")]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    public class Loop_2310D
    {
        
        [S("NM1", 1, typeof(X12_ID_98_12), typeof(X12_ID_1065_3))]
        public NM1_SupervisingProviderName NM1_SupervisingProviderName { get; set; }
        [S("REF", 2, typeof(X12_ID_128_26))]
        public List<REF_SupervisingProviderSecondaryIdentification> REF_SupervisingProviderSecondaryIdentification { get; set; }
    }
    
    public class REF_SupervisingProviderSecondaryIdentification
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string SupervisingProviderSecondaryIdentifier_02 { get; set; }
        [D(3, "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_26 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_26
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class NM1_SupervisingProviderName
    {
        
        [D(1, "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, "1035")]
        public string SupervisingProviderLastName_03 { get; set; }
        [D(4, "1036")]
        public string SupervisingProviderFirstName_04 { get; set; }
        [D(5, "1037")]
        public string SupervisingProviderMiddleNameorInitial_05 { get; set; }
        [D(6, "1038")]
        public string NamePrefix_06 { get; set; }
        [D(7, "1039")]
        public string SupervisingProviderNameSuffix_07 { get; set; }
        [D(8, "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, "67")]
        public string SupervisingProviderIdentifier_09 { get; set; }
        [D(10, "706")]
        public string EntityRelationshipCode_10 { get; set; }
        [D(11, "98")]
        public string EntityIdentifierCode_11 { get; set; }
        [D(12, "1035")]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    public class Loop_2310C
    {
        
        [S("NM1", 1, typeof(X12_ID_98_11), typeof(X12_ID_1065_2))]
        public NM1_ServiceFacilityLocationName NM1_ServiceFacilityLocationName { get; set; }
        [S("N3", 2)]
        public N3_ServiceFacilityLocationAddress N3_ServiceFacilityLocationAddress { get; set; }
        [S("N4", 3)]
        public N4_ServiceFacilityLocationCity_State_ZIPCode N4_ServiceFacilityLocationCity_State_ZIPCode { get; set; }
        [S("REF", 4, typeof(X12_ID_128_27))]
        public List<REF_ServiceFacilityLocationSecondaryIdentification> REF_ServiceFacilityLocationSecondaryIdentification { get; set; }
        [S("PER", 5, typeof(X12_ID_366))]
        public PER_ServiceFacilityContactInformation PER_ServiceFacilityContactInformation { get; set; }
    }
    
    public class PER_ServiceFacilityContactInformation
    {
        
        [D(1, "366")]
        public string ContactFunctionCode_01 { get; set; }
        [D(2, "93")]
        public string Name_02 { get; set; }
        [D(3, "365")]
        public string CommunicationNumberQualifier_03 { get; set; }
        [D(4, "364")]
        public string CommunicationNumber_04 { get; set; }
        [D(5, "365")]
        public string CommunicationNumberQualifier_05 { get; set; }
        [D(6, "364")]
        public string CommunicationNumber_06 { get; set; }
        [D(7, "365")]
        public string CommunicationNumberQualifier_07 { get; set; }
        [D(8, "364")]
        public string CommunicationNumber_08 { get; set; }
        [D(9, "443")]
        public string ContactInquiryReference_09 { get; set; }
    }
    
    public class REF_ServiceFacilityLocationSecondaryIdentification
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string LaboratoryorFacilitySecondaryIdentifier_02 { get; set; }
        [D(3, "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_25 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_25
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class N4_ServiceFacilityLocationCity_State_ZIPCode
    {
        
        [D(1, "19")]
        public string LaboratoryorFacilityCityName_01 { get; set; }
        [D(2, "156")]
        public string LaboratoryorFacilityStateorProvinceCode_02 { get; set; }
        [D(3, "116")]
        public string LaboratoryorFacilityPostalZoneorZIPCode_03 { get; set; }
        [D(4, "26")]
        public string CountryCode_04 { get; set; }
        [D(5, "309")]
        public string LocationQualifier_05 { get; set; }
        [D(6, "310")]
        public string LocationIdentifier_06 { get; set; }
        [D(7, "1715")]
        public string CountrySubdivisionCode_07 { get; set; }
    }
    
    public class N3_ServiceFacilityLocationAddress
    {
        
        [D(1, "166")]
        public string LaboratoryorFacilityAddressLine_01 { get; set; }
        [D(2, "166")]
        public string LaboratoryorFacilityAddressLine_02 { get; set; }
    }
    
    public class NM1_ServiceFacilityLocationName
    {
        
        [D(1, "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, "1035")]
        public string LaboratoryorFacilityName_03 { get; set; }
        [D(4, "1036")]
        public string NameFirst_04 { get; set; }
        [D(5, "1037")]
        public string NameMiddle_05 { get; set; }
        [D(6, "1038")]
        public string NamePrefix_06 { get; set; }
        [D(7, "1039")]
        public string NameSuffix_07 { get; set; }
        [D(8, "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, "67")]
        public string LaboratoryorFacilityPrimaryIdentifier_09 { get; set; }
        [D(10, "706")]
        public string EntityRelationshipCode_10 { get; set; }
        [D(11, "98")]
        public string EntityIdentifierCode_11 { get; set; }
        [D(12, "1035")]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    public class Loop_2310B
    {
        
        [S("NM1", 1, typeof(X12_ID_98_10), typeof(X12_ID_1065))]
        public NM1_RenderingProviderName NM1_RenderingProviderName { get; set; }
        [S("PRV", 2, typeof(X12_ID_1221_2), typeof(X12_ID_128))]
        public PRV_RenderingProviderSpecialtyInformation PRV_RenderingProviderSpecialtyInformation { get; set; }
        [S("REF", 3, typeof(X12_ID_128_26))]
        public List<REF_RenderingProviderSecondaryIdentification> REF_RenderingProviderSecondaryIdentification { get; set; }
    }
    
    public class REF_RenderingProviderSecondaryIdentification
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string RenderingProviderSecondaryIdentifier_02 { get; set; }
        [D(3, "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_24 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_24
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class PRV_RenderingProviderSpecialtyInformation
    {
        
        [D(1, "1221")]
        public string ProviderCode_01 { get; set; }
        [D(2, "128")]
        public string ReferenceIdentificationQualifier_02 { get; set; }
        [D(3, "127")]
        public string ProviderTaxonomyCode_03 { get; set; }
        [D(4, "156")]
        public string StateorProvinceCode_04 { get; set; }
        [C(5)]
        public C035_ProviderSpecialtyInformation_2 ProviderSpecialtyInformation_05 { get; set; }
        [D(6, "1223")]
        public string ProviderOrganizationCode_06 { get; set; }
    }
    
    public class C035_ProviderSpecialtyInformation_2
    {
        
        [D(1, "1222")]
        public string ProviderSpecialtyCode_01 { get; set; }
        [D(2, "559")]
        public string AgencyQualifierCode_02 { get; set; }
        [D(3, "1073")]
        public string YesNoConditionorResponseCode_03 { get; set; }
    }
    
    public class NM1_RenderingProviderName
    {
        
        [D(1, "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, "1035")]
        public string RenderingProviderLastorOrganizationName_03 { get; set; }
        [D(4, "1036")]
        public string RenderingProviderFirstName_04 { get; set; }
        [D(5, "1037")]
        public string RenderingProviderMiddleNameorInitial_05 { get; set; }
        [D(6, "1038")]
        public string NamePrefix_06 { get; set; }
        [D(7, "1039")]
        public string RenderingProviderNameSuffix_07 { get; set; }
        [D(8, "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, "67")]
        public string RenderingProviderIdentifier_09 { get; set; }
        [D(10, "706")]
        public string EntityRelationshipCode_10 { get; set; }
        [D(11, "98")]
        public string EntityIdentifierCode_11 { get; set; }
        [D(12, "1035")]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    public class Loop_2310A
    {
        
        [S("NM1", 1, typeof(X12_ID_98_9), typeof(X12_ID_1065_3))]
        public NM1_ReferringProviderName NM1_ReferringProviderName { get; set; }
        [S("REF", 2, typeof(X12_ID_128_25))]
        public List<REF_ReferringProviderSecondaryIdentification> REF_ReferringProviderSecondaryIdentification { get; set; }
    }
    
    public class REF_ReferringProviderSecondaryIdentification
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string ReferringProviderSecondaryIdentifier_02 { get; set; }
        [D(3, "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_23 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_23
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class NM1_ReferringProviderName
    {
        
        [D(1, "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, "1035")]
        public string ReferringProviderLastName_03 { get; set; }
        [D(4, "1036")]
        public string ReferringProviderFirstName_04 { get; set; }
        [D(5, "1037")]
        public string ReferringProviderMiddleNameorInitial_05 { get; set; }
        [D(6, "1038")]
        public string NamePrefix_06 { get; set; }
        [D(7, "1039")]
        public string ReferringProviderNameSuffix_07 { get; set; }
        [D(8, "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, "67")]
        public string ReferringProviderIdentifier_09 { get; set; }
        [D(10, "706")]
        public string EntityRelationshipCode_10 { get; set; }
        [D(11, "98")]
        public string EntityIdentifierCode_11 { get; set; }
        [D(12, "1035")]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    public class HCP_ClaimPricing_RepricingInformation
    {
        
        [D(1, "1473")]
        public string PricingMethodology_01 { get; set; }
        [D(2, "782")]
        public string RepricedAllowedAmount_02 { get; set; }
        [D(3, "782")]
        public string RepricedSavingAmount_03 { get; set; }
        [D(4, "127")]
        public string RepricingOrganizationIdentifier_04 { get; set; }
        [D(5, "118")]
        public string RepricingPerDiemorFlatRateAmount_05 { get; set; }
        [D(6, "127")]
        public string RepricedApprovedAmbulatoryPatientGroupCode_06 { get; set; }
        [D(7, "782")]
        public string RepricedApprovedAmbulatoryPatientGroupAmount_07 { get; set; }
        [D(8, "234")]
        public string ProductServiceID_08 { get; set; }
        [D(9, "235")]
        public string ProductServiceIDQualifier_09 { get; set; }
        [D(10, "234")]
        public string ProductServiceID_10 { get; set; }
        [D(11, "355")]
        public string UnitorBasisforMeasurementCode_11 { get; set; }
        [D(12, "380")]
        public string Quantity_12 { get; set; }
        [D(13, "901")]
        public string RejectReasonCode_13 { get; set; }
        [D(14, "1526")]
        public string PolicyComplianceCode_14 { get; set; }
        [D(15, "1527")]
        public string ExceptionCode_15 { get; set; }
    }
    
    public class All_HI
    {
        
        [S("HI", 1, typeof(X12_ID_1270_2), typeof(X12_ID_1270_3))]
        public HI_HealthCareDiagnosisCode HI_HealthCareDiagnosisCode { get; set; }
        [S("HI", 2, typeof(X12_ID_1270_4), typeof(X12_ID_1270_5))]
        public HI_AnesthesiaRelatedProcedure HI_AnesthesiaRelatedProcedure { get; set; }
        [S("HI", 3, typeof(X12_ID_1270_6), typeof(X12_ID_1270_6))]
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
        
        [D(1, "1270")]
        public string CodeListQualifierCode_01 { get; set; }
        [D(2, "1271")]
        public string ConditionCode_02 { get; set; }
        [D(3, "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, "380")]
        public string Quantity_06 { get; set; }
        [D(7, "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_35
    {
        
        [D(1, "1270")]
        public string CodeListQualifierCode_01 { get; set; }
        [D(2, "1271")]
        public string ConditionCode_02 { get; set; }
        [D(3, "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, "380")]
        public string Quantity_06 { get; set; }
        [D(7, "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_34
    {
        
        [D(1, "1270")]
        public string CodeListQualifierCode_01 { get; set; }
        [D(2, "1271")]
        public string ConditionCode_02 { get; set; }
        [D(3, "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, "380")]
        public string Quantity_06 { get; set; }
        [D(7, "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_33
    {
        
        [D(1, "1270")]
        public string CodeListQualifierCode_01 { get; set; }
        [D(2, "1271")]
        public string ConditionCode_02 { get; set; }
        [D(3, "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, "380")]
        public string Quantity_06 { get; set; }
        [D(7, "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_32
    {
        
        [D(1, "1270")]
        public string CodeListQualifierCode_01 { get; set; }
        [D(2, "1271")]
        public string ConditionCode_02 { get; set; }
        [D(3, "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, "380")]
        public string Quantity_06 { get; set; }
        [D(7, "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_31
    {
        
        [D(1, "1270")]
        public string CodeListQualifierCode_01 { get; set; }
        [D(2, "1271")]
        public string ConditionCode_02 { get; set; }
        [D(3, "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, "380")]
        public string Quantity_06 { get; set; }
        [D(7, "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_30
    {
        
        [D(1, "1270")]
        public string CodeListQualifierCode_01 { get; set; }
        [D(2, "1271")]
        public string ConditionCode_02 { get; set; }
        [D(3, "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, "380")]
        public string Quantity_06 { get; set; }
        [D(7, "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_29
    {
        
        [D(1, "1270")]
        public string CodeListQualifierCode_01 { get; set; }
        [D(2, "1271")]
        public string ConditionCode_02 { get; set; }
        [D(3, "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, "380")]
        public string Quantity_06 { get; set; }
        [D(7, "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_28
    {
        
        [D(1, "1270")]
        public string CodeListQualifierCode_01 { get; set; }
        [D(2, "1271")]
        public string ConditionCode_02 { get; set; }
        [D(3, "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, "380")]
        public string Quantity_06 { get; set; }
        [D(7, "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_27
    {
        
        [D(1, "1270")]
        public string CodeListQualifierCode_01 { get; set; }
        [D(2, "1271")]
        public string ConditionCode_02 { get; set; }
        [D(3, "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, "380")]
        public string Quantity_06 { get; set; }
        [D(7, "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_26
    {
        
        [D(1, "1270")]
        public string CodeListQualifierCode_01 { get; set; }
        [D(2, "1271")]
        public string ConditionCode_02 { get; set; }
        [D(3, "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, "380")]
        public string Quantity_06 { get; set; }
        [D(7, "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_25
    {
        
        [D(1, "1270")]
        public string CodeListQualifierCode_01 { get; set; }
        [D(2, "1271")]
        public string ConditionCode_02 { get; set; }
        [D(3, "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, "380")]
        public string Quantity_06 { get; set; }
        [D(7, "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, "1073")]
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
        
        [D(1, "1270")]
        public string CodeListQualifierCode_01 { get; set; }
        [D(2, "1271")]
        public string IndustryCode_02 { get; set; }
        [D(3, "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, "380")]
        public string Quantity_06 { get; set; }
        [D(7, "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_23
    {
        
        [D(1, "1270")]
        public string CodeListQualifierCode_01 { get; set; }
        [D(2, "1271")]
        public string IndustryCode_02 { get; set; }
        [D(3, "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, "380")]
        public string Quantity_06 { get; set; }
        [D(7, "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_22
    {
        
        [D(1, "1270")]
        public string CodeListQualifierCode_01 { get; set; }
        [D(2, "1271")]
        public string IndustryCode_02 { get; set; }
        [D(3, "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, "380")]
        public string Quantity_06 { get; set; }
        [D(7, "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_21
    {
        
        [D(1, "1270")]
        public string CodeListQualifierCode_01 { get; set; }
        [D(2, "1271")]
        public string IndustryCode_02 { get; set; }
        [D(3, "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, "380")]
        public string Quantity_06 { get; set; }
        [D(7, "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_20
    {
        
        [D(1, "1270")]
        public string CodeListQualifierCode_01 { get; set; }
        [D(2, "1271")]
        public string IndustryCode_02 { get; set; }
        [D(3, "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, "380")]
        public string Quantity_06 { get; set; }
        [D(7, "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_19
    {
        
        [D(1, "1270")]
        public string CodeListQualifierCode_01 { get; set; }
        [D(2, "1271")]
        public string IndustryCode_02 { get; set; }
        [D(3, "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, "380")]
        public string Quantity_06 { get; set; }
        [D(7, "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_18
    {
        
        [D(1, "1270")]
        public string CodeListQualifierCode_01 { get; set; }
        [D(2, "1271")]
        public string IndustryCode_02 { get; set; }
        [D(3, "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, "380")]
        public string Quantity_06 { get; set; }
        [D(7, "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_17
    {
        
        [D(1, "1270")]
        public string CodeListQualifierCode_01 { get; set; }
        [D(2, "1271")]
        public string IndustryCode_02 { get; set; }
        [D(3, "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, "380")]
        public string Quantity_06 { get; set; }
        [D(7, "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_16
    {
        
        [D(1, "1270")]
        public string CodeListQualifierCode_01 { get; set; }
        [D(2, "1271")]
        public string IndustryCode_02 { get; set; }
        [D(3, "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, "380")]
        public string Quantity_06 { get; set; }
        [D(7, "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_15
    {
        
        [D(1, "1270")]
        public string CodeListQualifierCode_01 { get; set; }
        [D(2, "1271")]
        public string IndustryCode_02 { get; set; }
        [D(3, "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, "380")]
        public string Quantity_06 { get; set; }
        [D(7, "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_14
    {
        
        [D(1, "1270")]
        public string CodeListQualifierCode_01 { get; set; }
        [D(2, "1271")]
        public string IndustryCode_02 { get; set; }
        [D(3, "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, "380")]
        public string Quantity_06 { get; set; }
        [D(7, "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_13
    {
        
        [D(1, "1270")]
        public string CodeListQualifierCode_01 { get; set; }
        [D(2, "1271")]
        public string AnesthesiaRelatedSurgicalProcedure_02 { get; set; }
        [D(3, "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, "380")]
        public string Quantity_06 { get; set; }
        [D(7, "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, "1073")]
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
        
        [D(1, "1270")]
        public string DiagnosisTypeCode_01 { get; set; }
        [D(2, "1271")]
        public string DiagnosisCode_02 { get; set; }
        [D(3, "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, "380")]
        public string Quantity_06 { get; set; }
        [D(7, "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_11
    {
        
        [D(1, "1270")]
        public string DiagnosisTypeCode_01 { get; set; }
        [D(2, "1271")]
        public string DiagnosisCode_02 { get; set; }
        [D(3, "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, "380")]
        public string Quantity_06 { get; set; }
        [D(7, "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_10
    {
        
        [D(1, "1270")]
        public string DiagnosisTypeCode_01 { get; set; }
        [D(2, "1271")]
        public string DiagnosisCode_02 { get; set; }
        [D(3, "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, "380")]
        public string Quantity_06 { get; set; }
        [D(7, "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_9
    {
        
        [D(1, "1270")]
        public string DiagnosisTypeCode_01 { get; set; }
        [D(2, "1271")]
        public string DiagnosisCode_02 { get; set; }
        [D(3, "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, "380")]
        public string Quantity_06 { get; set; }
        [D(7, "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_8
    {
        
        [D(1, "1270")]
        public string DiagnosisTypeCode_01 { get; set; }
        [D(2, "1271")]
        public string DiagnosisCode_02 { get; set; }
        [D(3, "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, "380")]
        public string Quantity_06 { get; set; }
        [D(7, "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_7
    {
        
        [D(1, "1270")]
        public string DiagnosisTypeCode_01 { get; set; }
        [D(2, "1271")]
        public string DiagnosisCode_02 { get; set; }
        [D(3, "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, "380")]
        public string Quantity_06 { get; set; }
        [D(7, "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_6
    {
        
        [D(1, "1270")]
        public string DiagnosisTypeCode_01 { get; set; }
        [D(2, "1271")]
        public string DiagnosisCode_02 { get; set; }
        [D(3, "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, "380")]
        public string Quantity_06 { get; set; }
        [D(7, "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_5
    {
        
        [D(1, "1270")]
        public string DiagnosisTypeCode_01 { get; set; }
        [D(2, "1271")]
        public string DiagnosisCode_02 { get; set; }
        [D(3, "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, "380")]
        public string Quantity_06 { get; set; }
        [D(7, "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_4
    {
        
        [D(1, "1270")]
        public string DiagnosisTypeCode_01 { get; set; }
        [D(2, "1271")]
        public string DiagnosisCode_02 { get; set; }
        [D(3, "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, "380")]
        public string Quantity_06 { get; set; }
        [D(7, "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_3
    {
        
        [D(1, "1270")]
        public string DiagnosisTypeCode_01 { get; set; }
        [D(2, "1271")]
        public string DiagnosisCode_02 { get; set; }
        [D(3, "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, "380")]
        public string Quantity_06 { get; set; }
        [D(7, "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation_2
    {
        
        [D(1, "1270")]
        public string DiagnosisTypeCode_01 { get; set; }
        [D(2, "1271")]
        public string DiagnosisCode_02 { get; set; }
        [D(3, "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, "380")]
        public string Quantity_06 { get; set; }
        [D(7, "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class C022_HealthCareCodeInformation
    {
        
        [D(1, "1270")]
        public string DiagnosisTypeCode_01 { get; set; }
        [D(2, "1271")]
        public string DiagnosisCode_02 { get; set; }
        [D(3, "1250")]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [D(4, "1251")]
        public string DateTimePeriod_04 { get; set; }
        [D(5, "782")]
        public string MonetaryAmount_05 { get; set; }
        [D(6, "380")]
        public string Quantity_06 { get; set; }
        [D(7, "799")]
        public string VersionIdentifier_07 { get; set; }
        [D(8, "1271")]
        public string IndustryCode_08 { get; set; }
        [D(9, "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    public class All_CRC
    {
        
        [S("CRC", 1, typeof(X12_ID_1136), typeof(X12_ID_1073_3))]
        public List<CRC_AmbulanceCertification> CRC_AmbulanceCertification { get; set; }
        [S("CRC", 2, typeof(X12_ID_1136_2), typeof(X12_ID_1073_3))]
        public List<CRC_PatientConditionInformation_Vision> CRC_PatientConditionInformation_Vision { get; set; }
        [S("CRC", 3, typeof(X12_ID_1136_3), typeof(X12_ID_1073_2))]
        public CRC_HomeboundIndicator CRC_HomeboundIndicator { get; set; }
        [S("CRC", 4, typeof(X12_ID_1136_4), typeof(X12_ID_1073_3))]
        public CRC_EPSDTReferral CRC_EPSDTReferral { get; set; }
    }
    
    public class CRC_EPSDTReferral
    {
        
        [D(1, "1136")]
        public string CodeQualifier_01 { get; set; }
        [D(2, "1073")]
        public string CertificationConditionCodeAppliesIndicator_02 { get; set; }
        [D(3, "1321")]
        public string ConditionIndicator_03 { get; set; }
        [D(4, "1321")]
        public string ConditionIndicator_04 { get; set; }
        [D(5, "1321")]
        public string ConditionIndicator_05 { get; set; }
        [D(6, "1321")]
        public string ConditionIndicator_06 { get; set; }
        [D(7, "1321")]
        public string ConditionIndicator_07 { get; set; }
    }
    
    public class CRC_HomeboundIndicator
    {
        
        [D(1, "1136")]
        public string CodeCategory_01 { get; set; }
        [D(2, "1073")]
        public string CertificationConditionIndicator_02 { get; set; }
        [D(3, "1321")]
        public string HomeboundIndicator_03 { get; set; }
        [D(4, "1321")]
        public string ConditionIndicator_04 { get; set; }
        [D(5, "1321")]
        public string ConditionIndicator_05 { get; set; }
        [D(6, "1321")]
        public string ConditionIndicator_06 { get; set; }
        [D(7, "1321")]
        public string ConditionIndicator_07 { get; set; }
    }
    
    public class CRC_PatientConditionInformation_Vision
    {
        
        [D(1, "1136")]
        public string CodeCategory_01 { get; set; }
        [D(2, "1073")]
        public string CertificationConditionIndicator_02 { get; set; }
        [D(3, "1321")]
        public string ConditionCode_03 { get; set; }
        [D(4, "1321")]
        public string ConditionCode_04 { get; set; }
        [D(5, "1321")]
        public string ConditionCode_05 { get; set; }
        [D(6, "1321")]
        public string ConditionCode_06 { get; set; }
        [D(7, "1321")]
        public string ConditionCode_07 { get; set; }
    }
    
    public class CRC_AmbulanceCertification
    {
        
        [D(1, "1136")]
        public string CodeCategory_01 { get; set; }
        [D(2, "1073")]
        public string CertificationConditionIndicator_02 { get; set; }
        [D(3, "1321")]
        public string ConditionCode_03 { get; set; }
        [D(4, "1321")]
        public string ConditionCode_04 { get; set; }
        [D(5, "1321")]
        public string ConditionCode_05 { get; set; }
        [D(6, "1321")]
        public string ConditionCode_06 { get; set; }
        [D(7, "1321")]
        public string ConditionCode_07 { get; set; }
    }
    
    public class CR2_SpinalManipulationServiceInformation
    {
        
        [D(1, "609")]
        public string Count_01 { get; set; }
        [D(2, "380")]
        public string Quantity_02 { get; set; }
        [D(3, "1367")]
        public string SubluxationLevelCode_03 { get; set; }
        [D(4, "1367")]
        public string SubluxationLevelCode_04 { get; set; }
        [D(5, "355")]
        public string UnitorBasisforMeasurementCode_05 { get; set; }
        [D(6, "380")]
        public string Quantity_06 { get; set; }
        [D(7, "380")]
        public string Quantity_07 { get; set; }
        [D(8, "1342")]
        public string PatientConditionCode_08 { get; set; }
        [D(9, "1073")]
        public string YesNoConditionorResponseCode_09 { get; set; }
        [D(10, "352")]
        public string PatientConditionDescription_10 { get; set; }
        [D(11, "352")]
        public string PatientConditionDescription_11 { get; set; }
        [D(12, "1073")]
        public string YesNoConditionorResponseCode_12 { get; set; }
    }
    
    public class CR1_AmbulanceTransportInformation
    {
        
        [D(1, "355")]
        public string UnitorBasisforMeasurementCode_01 { get; set; }
        [D(2, "81")]
        public string PatientWeight_02 { get; set; }
        [D(3, "1316")]
        public string AmbulanceTransportCode_03 { get; set; }
        [D(4, "1317")]
        public string AmbulanceTransportReasonCode_04 { get; set; }
        [D(5, "355")]
        public string UnitorBasisforMeasurementCode_05 { get; set; }
        [D(6, "380")]
        public string TransportDistance_06 { get; set; }
        [D(7, "166")]
        public string AddressInformation_07 { get; set; }
        [D(8, "166")]
        public string AddressInformation_08 { get; set; }
        [D(9, "352")]
        public string RoundTripPurposeDescription_09 { get; set; }
        [D(10, "352")]
        public string StretcherPurposeDescription_10 { get; set; }
    }
    
    public class NTE_ClaimNote
    {
        
        [D(1, "363")]
        public string NoteReferenceCode_01 { get; set; }
        [D(2, "352")]
        public string ClaimNoteText_02 { get; set; }
    }
    
    public class K3_FileInformation
    {
        
        [D(1, "449")]
        public string FixedFormatInformation_01 { get; set; }
        [D(2, "1333")]
        public string RecordFormatCode_02 { get; set; }
        [C(3)]
        public C001_CompositeUnitofMeasure CompositeUnitofMeasure_03 { get; set; }
    }
    
    public class C001_CompositeUnitofMeasure
    {
        
        [D(1, "355")]
        public string UnitorBasisforMeasurementCode_01 { get; set; }
        [D(2, "1018")]
        public string Exponent_02 { get; set; }
        [D(3, "649")]
        public string Multiplier_03 { get; set; }
        [D(4, "355")]
        public string UnitorBasisforMeasurementCode_04 { get; set; }
        [D(5, "1018")]
        public string Exponent_05 { get; set; }
        [D(6, "649")]
        public string Multiplier_06 { get; set; }
        [D(7, "355")]
        public string UnitorBasisforMeasurementCode_07 { get; set; }
        [D(8, "1018")]
        public string Exponent_08 { get; set; }
        [D(9, "649")]
        public string Multiplier_09 { get; set; }
        [D(10, "355")]
        public string UnitorBasisforMeasurementCode_10 { get; set; }
        [D(11, "1018")]
        public string Exponent_11 { get; set; }
        [D(12, "649")]
        public string Multiplier_12 { get; set; }
        [D(13, "355")]
        public string UnitorBasisforMeasurementCode_13 { get; set; }
        [D(14, "1018")]
        public string Exponent_14 { get; set; }
        [D(15, "649")]
        public string Multiplier_15 { get; set; }
    }
    
    public class All_REF_5
    {
        
        [S("REF", 1, typeof(X12_ID_128_11), typeof(X12_ID_127_1))]
        public REF_ServiceAuthorizationExceptionCode REF_ServiceAuthorizationExceptionCode { get; set; }
        [S("REF", 2, typeof(X12_ID_128_12), typeof(X12_ID_127_2))]
        public REF_MandatoryMedicare_Section4081_CrossoverIndicator REF_MandatoryMedicare_Section4081_CrossoverIndicator { get; set; }
        [S("REF", 3, typeof(X12_ID_128_13))]
        public REF_MammographyCertificationNumber REF_MammographyCertificationNumber { get; set; }
        [S("REF", 4, typeof(X12_ID_128_14))]
        public REF_ReferralNumber REF_ReferralNumber { get; set; }
        [S("REF", 5, typeof(X12_ID_128_15))]
        public REF_PriorAuthorization REF_PriorAuthorization { get; set; }
        [S("REF", 6, typeof(X12_ID_128_16))]
        public REF_PayerClaimControlNumber REF_PayerClaimControlNumber { get; set; }
        [S("REF", 7, typeof(X12_ID_128_17))]
        public REF_ClinicalLaboratoryImprovementAmendment_CLIA_Number REF_ClinicalLaboratoryImprovementAmendment_CLIA_Number { get; set; }
        [S("REF", 8, typeof(X12_ID_128_18))]
        public REF_RepricedClaimNumber REF_RepricedClaimNumber { get; set; }
        [S("REF", 9, typeof(X12_ID_128_19))]
        public REF_AdjustedRepricedClaimNumber REF_AdjustedRepricedClaimNumber { get; set; }
        [S("REF", 10, typeof(X12_ID_128_20))]
        public REF_InvestigationalDeviceExemptionNumber REF_InvestigationalDeviceExemptionNumber { get; set; }
        [S("REF", 11, typeof(X12_ID_128_21))]
        public REF_ClaimIdentifierForTransmissionIntermediaries REF_ClaimIdentifierForTransmissionIntermediaries { get; set; }
        [S("REF", 12, typeof(X12_ID_128_22))]
        public REF_MedicalRecordNumber REF_MedicalRecordNumber { get; set; }
        [S("REF", 13, typeof(X12_ID_128_23))]
        public REF_DemonstrationProjectIdentifier REF_DemonstrationProjectIdentifier { get; set; }
        [S("REF", 14, typeof(X12_ID_128_24))]
        public REF_CarePlanOversight REF_CarePlanOversight { get; set; }
    }
    
    public class REF_CarePlanOversight
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string CarePlanOversightNumber_02 { get; set; }
        [D(3, "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_22 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_22
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_DemonstrationProjectIdentifier
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string DemonstrationProjectIdentifier_02 { get; set; }
        [D(3, "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_21 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_21
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_MedicalRecordNumber
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string MedicalRecordNumber_02 { get; set; }
        [D(3, "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_20 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_20
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_ClaimIdentifierForTransmissionIntermediaries
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string ValueAddedNetworkTraceNumber_02 { get; set; }
        [D(3, "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_19 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_19
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_InvestigationalDeviceExemptionNumber
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string InvestigationalDeviceExemptionIdentifier_02 { get; set; }
        [D(3, "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_18 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_18
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_AdjustedRepricedClaimNumber
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string AdjustedRepricedClaimReferenceNumber_02 { get; set; }
        [D(3, "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_17 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_17
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_RepricedClaimNumber
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string RepricedClaimReferenceNumber_02 { get; set; }
        [D(3, "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_16 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_16
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_ClinicalLaboratoryImprovementAmendment_CLIA_Number
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string ClinicalLaboratoryImprovementAmendmentNumber_02 { get; set; }
        [D(3, "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_15 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_15
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_PayerClaimControlNumber
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string PayerClaimControlNumber_02 { get; set; }
        [D(3, "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_14 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_14
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_PriorAuthorization
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string PriorAuthorizationNumber_02 { get; set; }
        [D(3, "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_13 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_13
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_ReferralNumber
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string ReferralNumber_02 { get; set; }
        [D(3, "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_12 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_12
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_MammographyCertificationNumber
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string MammographyCertificationNumber_02 { get; set; }
        [D(3, "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_11 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_11
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_MandatoryMedicare_Section4081_CrossoverIndicator
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string MedicareSection4081Indicator_02 { get; set; }
        [D(3, "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_10 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_10
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_ServiceAuthorizationExceptionCode
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string ServiceAuthorizationExceptionCode_02 { get; set; }
        [D(3, "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_9 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_9
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class AMT_PatientAmountPaid
    {
        
        [D(1, "522")]
        public string AmountQualifierCode_01 { get; set; }
        [D(2, "782")]
        public string PatientAmountPaid_02 { get; set; }
        [D(3, "478")]
        public string CreditDebitFlagCode_03 { get; set; }
    }
    
    public class CN1_ContractInformation
    {
        
        [D(1, "1166")]
        public string ContractTypeCode_01 { get; set; }
        [D(2, "782")]
        public string ContractAmount_02 { get; set; }
        [D(3, "332")]
        public string ContractPercentage_03 { get; set; }
        [D(4, "127")]
        public string ContractCode_04 { get; set; }
        [D(5, "338")]
        public string TermsDiscountPercentage_05 { get; set; }
        [D(6, "799")]
        public string ContractVersionIdentifier_06 { get; set; }
    }
    
    public class PWK_ClaimSupplementalInformation
    {
        
        [D(1, "755")]
        public string AttachmentReportTypeCode_01 { get; set; }
        [D(2, "756")]
        public string AttachmentTransmissionCode_02 { get; set; }
        [D(3, "757")]
        public string ReportCopiesNeeded_03 { get; set; }
        [D(4, "98")]
        public string EntityIdentifierCode_04 { get; set; }
        [D(5, "66")]
        public string IdentificationCodeQualifier_05 { get; set; }
        [D(6, "67")]
        public string AttachmentControlNumber_06 { get; set; }
        [D(7, "352")]
        public string Description_07 { get; set; }
        [C(8)]
        public C002_ActionsIndicated ActionsIndicated_08 { get; set; }
        [D(9, "1525")]
        public string RequestCategoryCode_09 { get; set; }
    }
    
    public class C002_ActionsIndicated
    {
        
        [D(1, "704")]
        public string PaperworkReportActionCode_01 { get; set; }
        [D(2, "704")]
        public string PaperworkReportActionCode_02 { get; set; }
        [D(3, "704")]
        public string PaperworkReportActionCode_03 { get; set; }
        [D(4, "704")]
        public string PaperworkReportActionCode_04 { get; set; }
        [D(5, "704")]
        public string PaperworkReportActionCode_05 { get; set; }
    }
    
    public class All_DTP
    {
        
        [S("DTP", 1, typeof(X12_ID_374_2), typeof(X12_ID_1250))]
        public DTP_Date_OnsetofCurrentIllnessorSymptom DTP_Date_OnsetofCurrentIllnessorSymptom { get; set; }
        [S("DTP", 2, typeof(X12_ID_374_3), typeof(X12_ID_1250))]
        public DTP_Date_InitialTreatmentDate DTP_Date_InitialTreatmentDate { get; set; }
        [S("DTP", 3, typeof(X12_ID_374_4), typeof(X12_ID_1250))]
        public DTP_Date_LastSeenDate DTP_Date_LastSeenDate { get; set; }
        [S("DTP", 4, typeof(X12_ID_374_5), typeof(X12_ID_1250))]
        public DTP_Date_AcuteManifestation DTP_Date_AcuteManifestation { get; set; }
        [S("DTP", 5, typeof(X12_ID_374_6), typeof(X12_ID_1250))]
        public DTP_Date_Accident DTP_Date_Accident { get; set; }
        [S("DTP", 6, typeof(X12_ID_374_7), typeof(X12_ID_1250))]
        public DTP_Date_LastMenstrualPeriod DTP_Date_LastMenstrualPeriod { get; set; }
        [S("DTP", 7, typeof(X12_ID_374_8), typeof(X12_ID_1250))]
        public DTP_Date_LastX_rayDate DTP_Date_LastX_rayDate { get; set; }
        [S("DTP", 8, typeof(X12_ID_374_9), typeof(X12_ID_1250))]
        public DTP_Date_HearingandVisionPrescriptionDate DTP_Date_HearingandVisionPrescriptionDate { get; set; }
        [S("DTP", 9, typeof(X12_ID_374_10), typeof(X12_ID_1250_2))]
        public DTP_Date_DisabilityDates DTP_Date_DisabilityDates { get; set; }
        [S("DTP", 10, typeof(X12_ID_374_11), typeof(X12_ID_1250))]
        public DTP_Date_LastWorked DTP_Date_LastWorked { get; set; }
        [S("DTP", 11, typeof(X12_ID_374_12), typeof(X12_ID_1250))]
        public DTP_Date_AuthorizedReturntoWork DTP_Date_AuthorizedReturntoWork { get; set; }
        [S("DTP", 12, typeof(X12_ID_374_13), typeof(X12_ID_1250))]
        public DTP_Date_Admission DTP_Date_Admission { get; set; }
        [S("DTP", 13, typeof(X12_ID_374_14), typeof(X12_ID_1250))]
        public DTP_Date_Discharge DTP_Date_Discharge { get; set; }
        [S("DTP", 14, typeof(X12_ID_374_15), typeof(X12_ID_1250))]
        public List<DTP_Date_AssumedandRelinquishedCareDates> DTP_Date_AssumedandRelinquishedCareDates { get; set; }
        [S("DTP", 15, typeof(X12_ID_374_16), typeof(X12_ID_1250))]
        public DTP_PropertyandCasualtyDateofFirstContact DTP_PropertyandCasualtyDateofFirstContact { get; set; }
        [S("DTP", 16, typeof(X12_ID_374_17), typeof(X12_ID_1250))]
        public DTP_Date_RepricerReceivedDate DTP_Date_RepricerReceivedDate { get; set; }
    }
    
    public class DTP_Date_RepricerReceivedDate
    {
        
        [D(1, "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, "1251")]
        public string RepricerReceivedDate_03 { get; set; }
    }
    
    public class DTP_PropertyandCasualtyDateofFirstContact
    {
        
        [D(1, "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, "1251")]
        public string DateTimePeriod_03 { get; set; }
    }
    
    public class DTP_Date_AssumedandRelinquishedCareDates
    {
        
        [D(1, "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, "1251")]
        public string AssumedorRelinquishedCareDate_03 { get; set; }
    }
    
    public class DTP_Date_Discharge
    {
        
        [D(1, "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, "1251")]
        public string RelatedHospitalizationDischargeDate_03 { get; set; }
    }
    
    public class DTP_Date_Admission
    {
        
        [D(1, "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, "1251")]
        public string RelatedHospitalizationAdmissionDate_03 { get; set; }
    }
    
    public class DTP_Date_AuthorizedReturntoWork
    {
        
        [D(1, "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, "1251")]
        public string WorkReturnDate_03 { get; set; }
    }
    
    public class DTP_Date_LastWorked
    {
        
        [D(1, "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, "1251")]
        public string LastWorkedDate_03 { get; set; }
    }
    
    public class DTP_Date_DisabilityDates
    {
        
        [D(1, "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, "1251")]
        public string DisabilityFromDate_03 { get; set; }
    }
    
    public class DTP_Date_HearingandVisionPrescriptionDate
    {
        
        [D(1, "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, "1251")]
        public string PrescriptionDate_03 { get; set; }
    }
    
    public class DTP_Date_LastX_rayDate
    {
        
        [D(1, "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, "1251")]
        public string LastXRayDate_03 { get; set; }
    }
    
    public class DTP_Date_LastMenstrualPeriod
    {
        
        [D(1, "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, "1251")]
        public string LastMenstrualPeriodDate_03 { get; set; }
    }
    
    public class DTP_Date_Accident
    {
        
        [D(1, "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, "1251")]
        public string AccidentDate_03 { get; set; }
    }
    
    public class DTP_Date_AcuteManifestation
    {
        
        [D(1, "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, "1251")]
        public string AcuteManifestationDate_03 { get; set; }
    }
    
    public class DTP_Date_LastSeenDate
    {
        
        [D(1, "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, "1251")]
        public string LastSeenDate_03 { get; set; }
    }
    
    public class DTP_Date_InitialTreatmentDate
    {
        
        [D(1, "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, "1251")]
        public string InitialTreatmentDate_03 { get; set; }
    }
    
    public class DTP_Date_OnsetofCurrentIllnessorSymptom
    {
        
        [D(1, "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, "1251")]
        public string OnsetofCurrentIllnessorInjuryDate_03 { get; set; }
    }
    
    public class CLM_ClaimInformation
    {
        
        [D(1, "1028")]
        public string PatientControlNumber_01 { get; set; }
        [D(2, "782")]
        public string TotalClaimChargeAmount_02 { get; set; }
        [D(3, "1032")]
        public string ClaimFilingIndicatorCode_03 { get; set; }
        [D(4, "1343")]
        public string NonInstitutionalClaimTypeCode_04 { get; set; }
        [C(5)]
        public C023_HealthCareServiceLocationInformation HealthCareServiceLocationInformation_05 { get; set; }
        [D(6, "1073")]
        public string ProviderorSupplierSignatureIndicator_06 { get; set; }
        [D(7, "1359")]
        public string AssignmentorPlanParticipationCode_07 { get; set; }
        [D(8, "1073")]
        public string BenefitsAssignmentCertificationIndicator_08 { get; set; }
        [D(9, "1363")]
        public string ReleaseofInformationCode_09 { get; set; }
        [D(10, "1351")]
        public string PatientSignatureSourceCode_10 { get; set; }
        [C(11)]
        public C024_RelatedCausesInformation RelatedCausesInformation_11 { get; set; }
        [D(12, "1366")]
        public string SpecialProgramIndicator_12 { get; set; }
        [D(13, "1073")]
        public string YesNoConditionorResponseCode_13 { get; set; }
        [D(14, "1338")]
        public string LevelofServiceCode_14 { get; set; }
        [D(15, "1073")]
        public string YesNoConditionorResponseCode_15 { get; set; }
        [D(16, "1360")]
        public string ProviderAgreementCode_16 { get; set; }
        [D(17, "1029")]
        public string ClaimStatusCode_17 { get; set; }
        [D(18, "1073")]
        public string YesNoConditionorResponseCode_18 { get; set; }
        [D(19, "1383")]
        public string ClaimSubmissionReasonCode_19 { get; set; }
        [D(20, "1514")]
        public string DelayReasonCode_20 { get; set; }
    }
    
    public class C024_RelatedCausesInformation
    {
        
        [D(1, "1362")]
        public string RelatedCausesCode_01 { get; set; }
        [D(2, "1362")]
        public string RelatedCausesCode_02 { get; set; }
        [D(3, "1362")]
        public string RelatedCausesCode_03 { get; set; }
        [D(4, "156")]
        public string AutoAccidentStateorProvinceCode_04 { get; set; }
        [D(5, "26")]
        public string CountryCode_05 { get; set; }
    }
    
    public class C023_HealthCareServiceLocationInformation
    {
        
        [D(1, "1331")]
        public string PlaceofServiceCode_01 { get; set; }
        [D(2, "1332")]
        public string FacilityCodeQualifier_02 { get; set; }
        [D(3, "1325")]
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
        
        [S("NM1", 1, typeof(X12_ID_98_8), typeof(X12_ID_1065_2))]
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
        
        [S("REF", 1, typeof(X12_ID_128_9))]
        public List<REF_PayerSecondaryIdentification> REF_PayerSecondaryIdentification { get; set; }
        [S("REF", 2, typeof(X12_ID_128_10))]
        public List<REF_BillingProviderSecondaryIdentification> REF_BillingProviderSecondaryIdentification { get; set; }
    }
    
    public class REF_BillingProviderSecondaryIdentification
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string BillingProviderSecondaryIdentifier_02 { get; set; }
        [D(3, "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_8 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_8
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_PayerSecondaryIdentification
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string PayerSecondaryIdentifier_02 { get; set; }
        [D(3, "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_7 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_7
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class N4_PayerCity_State_ZIPCode
    {
        
        [D(1, "19")]
        public string PayerCityName_01 { get; set; }
        [D(2, "156")]
        public string PayerStateorProvinceCode_02 { get; set; }
        [D(3, "116")]
        public string PayerPostalZoneorZIPCode_03 { get; set; }
        [D(4, "26")]
        public string CountryCode_04 { get; set; }
        [D(5, "309")]
        public string LocationQualifier_05 { get; set; }
        [D(6, "310")]
        public string LocationIdentifier_06 { get; set; }
        [D(7, "1715")]
        public string CountrySubdivisionCode_07 { get; set; }
    }
    
    public class N3_PayerAddress
    {
        
        [D(1, "166")]
        public string PayerAddressLine_01 { get; set; }
        [D(2, "166")]
        public string PayerAddressLine_02 { get; set; }
    }
    
    public class NM1_PayerName
    {
        
        [D(1, "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, "1035")]
        public string PayerName_03 { get; set; }
        [D(4, "1036")]
        public string NameFirst_04 { get; set; }
        [D(5, "1037")]
        public string NameMiddle_05 { get; set; }
        [D(6, "1038")]
        public string NamePrefix_06 { get; set; }
        [D(7, "1039")]
        public string NameSuffix_07 { get; set; }
        [D(8, "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, "67")]
        public string PayerIdentifier_09 { get; set; }
        [D(10, "706")]
        public string EntityRelationshipCode_10 { get; set; }
        [D(11, "98")]
        public string EntityIdentifierCode_11 { get; set; }
        [D(12, "1035")]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    public class Loop_2010BA
    {
        
        [S("NM1", 1, typeof(X12_ID_98_7), typeof(X12_ID_1065))]
        public NM1_SubscriberName NM1_SubscriberName { get; set; }
        [S("N3", 2)]
        public N3_SubscriberAddress N3_SubscriberAddress { get; set; }
        [S("N4", 3)]
        public N4_SubscriberCity_State_ZIPCode N4_SubscriberCity_State_ZIPCode { get; set; }
        [S("DMG", 4, typeof(X12_ID_1250))]
        public DMG_SubscriberDemographicInformation DMG_SubscriberDemographicInformation { get; set; }
        [A(5)]
        public All_REF_3 All_REF_3 { get; set; }
        [S("PER", 6, typeof(X12_ID_366))]
        public PER_PropertyandCasualtySubscriberContactInformation PER_PropertyandCasualtySubscriberContactInformation { get; set; }
    }
    
    public class PER_PropertyandCasualtySubscriberContactInformation
    {
        
        [D(1, "366")]
        public string ContactFunctionCode_01 { get; set; }
        [D(2, "93")]
        public string Name_02 { get; set; }
        [D(3, "365")]
        public string CommunicationNumberQualifier_03 { get; set; }
        [D(4, "364")]
        public string CommunicationNumber_04 { get; set; }
        [D(5, "365")]
        public string CommunicationNumberQualifier_05 { get; set; }
        [D(6, "364")]
        public string CommunicationNumber_06 { get; set; }
        [D(7, "365")]
        public string CommunicationNumberQualifier_07 { get; set; }
        [D(8, "364")]
        public string CommunicationNumber_08 { get; set; }
        [D(9, "443")]
        public string ContactInquiryReference_09 { get; set; }
    }
    
    public class All_REF_3
    {
        
        [S("REF", 1, typeof(X12_ID_128_7))]
        public REF_SubscriberSecondaryIdentification REF_SubscriberSecondaryIdentification { get; set; }
        [S("REF", 2, typeof(X12_ID_128_8))]
        public REF_PropertyandCasualtyClaimNumber REF_PropertyandCasualtyClaimNumber { get; set; }
    }
    
    public class REF_PropertyandCasualtyClaimNumber
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string PropertyCasualtyClaimNumber_02 { get; set; }
        [D(3, "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_6 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_6
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_SubscriberSecondaryIdentification
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string SubscriberSupplementalIdentifier_02 { get; set; }
        [D(3, "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_5 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_5
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class DMG_SubscriberDemographicInformation
    {
        
        [D(1, "1250")]
        public string DateTimePeriodFormatQualifier_01 { get; set; }
        [D(2, "1251")]
        public string SubscriberBirthDate_02 { get; set; }
        [D(3, "1068")]
        public string SubscriberGenderCode_03 { get; set; }
        [D(4, "1067")]
        public string MaritalStatusCode_04 { get; set; }
        [C(5)]
        public List<C056_CompositeRaceorEthnicityInformation> CompositeRaceorEthnicityInformation_05 { get; set; }
        [D(6, "1066")]
        public string CitizenshipStatusCode_06 { get; set; }
        [D(7, "26")]
        public string CountryCode_07 { get; set; }
        [D(8, "659")]
        public string BasisofVerificationCode_08 { get; set; }
        [D(9, "380")]
        public string Quantity_09 { get; set; }
        [D(10, "1270")]
        public string CodeListQualifierCode_10 { get; set; }
        [D(11, "1271")]
        public string IndustryCode_11 { get; set; }
    }
    
    public class C056_CompositeRaceorEthnicityInformation
    {
        
        [D(1, "1109")]
        public string RaceorEthnicityCode_01 { get; set; }
        [D(2, "1270")]
        public string CodeListQualifierCode_02 { get; set; }
        [D(3, "1271")]
        public string IndustryCode_03 { get; set; }
    }
    
    public class N4_SubscriberCity_State_ZIPCode
    {
        
        [D(1, "19")]
        public string SubscriberCityName_01 { get; set; }
        [D(2, "156")]
        public string SubscriberStateCode_02 { get; set; }
        [D(3, "116")]
        public string SubscriberPostalZoneorZIPCode_03 { get; set; }
        [D(4, "26")]
        public string CountryCode_04 { get; set; }
        [D(5, "309")]
        public string LocationQualifier_05 { get; set; }
        [D(6, "310")]
        public string LocationIdentifier_06 { get; set; }
        [D(7, "1715")]
        public string CountrySubdivisionCode_07 { get; set; }
    }
    
    public class N3_SubscriberAddress
    {
        
        [D(1, "166")]
        public string SubscriberAddressLine_01 { get; set; }
        [D(2, "166")]
        public string SubscriberAddressLine_02 { get; set; }
    }
    
    public class NM1_SubscriberName
    {
        
        [D(1, "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, "1035")]
        public string SubscriberLastName_03 { get; set; }
        [D(4, "1036")]
        public string SubscriberFirstName_04 { get; set; }
        [D(5, "1037")]
        public string SubscriberMiddleNameorInitial_05 { get; set; }
        [D(6, "1038")]
        public string NamePrefix_06 { get; set; }
        [D(7, "1039")]
        public string SubscriberNameSuffix_07 { get; set; }
        [D(8, "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, "67")]
        public string SubscriberPrimaryIdentifier_09 { get; set; }
        [D(10, "706")]
        public string EntityRelationshipCode_10 { get; set; }
        [D(11, "98")]
        public string EntityIdentifierCode_11 { get; set; }
        [D(12, "1035")]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    public class PAT_PatientInformation
    {
        
        [D(1, "1069")]
        public string IndividualRelationshipCode_01 { get; set; }
        [D(2, "1384")]
        public string PatientLocationCode_02 { get; set; }
        [D(3, "584")]
        public string EmploymentStatusCode_03 { get; set; }
        [D(4, "1220")]
        public string StudentStatusCode_04 { get; set; }
        [D(5, "1250")]
        public string DateTimePeriodFormatQualifier_05 { get; set; }
        [D(6, "1251")]
        public string PatientDeathDate_06 { get; set; }
        [D(7, "355")]
        public string UnitorBasisforMeasurementCode_07 { get; set; }
        [D(8, "81")]
        public string PatientWeight_08 { get; set; }
        [D(9, "1073")]
        public string PregnancyIndicator_09 { get; set; }
    }
    
    public class SBR_SubscriberInformation
    {
        
        [D(1, "1138")]
        public string PayerResponsibilitySequenceNumberCode_01 { get; set; }
        [D(2, "1069")]
        public string IndividualRelationshipCode_02 { get; set; }
        [D(3, "127")]
        public string SubscriberGrouporPolicyNumber_03 { get; set; }
        [D(4, "93")]
        public string SubscriberGroupName_04 { get; set; }
        [D(5, "1336")]
        public string InsuranceTypeCode_05 { get; set; }
        [D(6, "1143")]
        public string CoordinationofBenefitsCode_06 { get; set; }
        [D(7, "1073")]
        public string YesNoConditionorResponseCode_07 { get; set; }
        [D(8, "584")]
        public string EmploymentStatusCode_08 { get; set; }
        [D(9, "1032")]
        public string ClaimFilingIndicatorCode_09 { get; set; }
    }
    
    public class HL_SubscriberHierarchicalLevel
    {
        
        [D(1, "628")]
        public string HierarchicalIDNumber_01 { get; set; }
        [D(2, "734")]
        public string HierarchicalParentIDNumber_02 { get; set; }
        [D(3, "735")]
        public string HierarchicalLevelCode_03 { get; set; }
        [D(4, "736")]
        public string HierarchicalChildCode_04 { get; set; }
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
        
        [S("NM1", 1, typeof(X12_ID_98_6), typeof(X12_ID_1065_2))]
        public NM1_Pay_ToPlanName NM1_Pay_ToPlanName { get; set; }
        [S("N3", 2)]
        public N3_Pay_ToPlanAddress N3_Pay_ToPlanAddress { get; set; }
        [S("N4", 3)]
        public N4_Pay_ToPlanCity_State_ZIPCode N4_Pay_ToPlanCity_State_ZIPCode { get; set; }
        [A(4)]
        public All_REF_2 All_REF_2 { get; set; }
    }
    
    [E(",PE,")]
    public class X12_ID_98_6
    {
    }
    
    public class All_REF_2
    {
        
        [S("REF", 1, typeof(X12_ID_128_5))]
        public REF_Pay_ToPlanSecondaryIdentification REF_Pay_ToPlanSecondaryIdentification { get; set; }
        [S("REF", 2, typeof(X12_ID_128_6))]
        public REF_Pay_ToPlanTaxIdentificationNumber REF_Pay_ToPlanTaxIdentificationNumber { get; set; }
    }
    
    [E(",2U,FY,NF,")]
    public class X12_ID_128_5
    {
    }
    
    [E(",EI,")]
    public class X12_ID_128_6
    {
    }
    
    public class REF_Pay_ToPlanTaxIdentificationNumber
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string PayToPlanTaxIdentificationNumber_02 { get; set; }
        [D(3, "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_4 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_4
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_Pay_ToPlanSecondaryIdentification
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string PaytoPlanSecondaryIdentifier_02 { get; set; }
        [D(3, "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_3 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_3
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class N4_Pay_ToPlanCity_State_ZIPCode
    {
        
        [D(1, "19")]
        public string PaytoPlanCityName_01 { get; set; }
        [D(2, "156")]
        public string PaytoPlanStateorProvinceCode_02 { get; set; }
        [D(3, "116")]
        public string PaytoPlanPostalZoneorZIPCode_03 { get; set; }
        [D(4, "26")]
        public string CountryCode_04 { get; set; }
        [D(5, "309")]
        public string LocationQualifier_05 { get; set; }
        [D(6, "310")]
        public string LocationIdentifier_06 { get; set; }
        [D(7, "1715")]
        public string CountrySubdivisionCode_07 { get; set; }
    }
    
    public class N3_Pay_ToPlanAddress
    {
        
        [D(1, "166")]
        public string PaytoPlanAddressLine_01 { get; set; }
        [D(2, "166")]
        public string PaytoPlanAddressLine_02 { get; set; }
    }
    
    public class NM1_Pay_ToPlanName
    {
        
        [D(1, "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, "1035")]
        public string PaytoPlanOrganizationalName_03 { get; set; }
        [D(4, "1036")]
        public string NameFirst_04 { get; set; }
        [D(5, "1037")]
        public string NameMiddle_05 { get; set; }
        [D(6, "1038")]
        public string NamePrefix_06 { get; set; }
        [D(7, "1039")]
        public string NameSuffix_07 { get; set; }
        [D(8, "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, "67")]
        public string PaytoPlanPrimaryIdentifier_09 { get; set; }
        [D(10, "706")]
        public string EntityRelationshipCode_10 { get; set; }
        [D(11, "98")]
        public string EntityIdentifierCode_11 { get; set; }
        [D(12, "1035")]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    public class Loop_2010AB
    {
        
        [S("NM1", 1, typeof(X12_ID_98_5), typeof(X12_ID_1065))]
        public NM1_Pay_toAddressName NM1_Pay_toAddressName { get; set; }
        [S("N3", 2)]
        public N3_Pay_ToAddress_ADDRESS N3_Pay_ToAddress_ADDRESS { get; set; }
        [S("N4", 3)]
        public N4_Pay_toAddressCity_State_ZIPCode N4_Pay_toAddressCity_State_ZIPCode { get; set; }
    }
    
    [E(",87,")]
    public class X12_ID_98_5
    {
    }
    
    public class N4_Pay_toAddressCity_State_ZIPCode
    {
        
        [D(1, "19")]
        public string PaytoAddressCityName_01 { get; set; }
        [D(2, "156")]
        public string PaytoAddressStateCode_02 { get; set; }
        [D(3, "116")]
        public string PaytoAddressPostalZoneorZIPCode_03 { get; set; }
        [D(4, "26")]
        public string CountryCode_04 { get; set; }
        [D(5, "309")]
        public string LocationQualifier_05 { get; set; }
        [D(6, "310")]
        public string LocationIdentifier_06 { get; set; }
        [D(7, "1715")]
        public string CountrySubdivisionCode_07 { get; set; }
    }
    
    public class N3_Pay_ToAddress_ADDRESS
    {
        
        [D(1, "166")]
        public string PaytoAddressLine_01 { get; set; }
        [D(2, "166")]
        public string PaytoAddressLine_02 { get; set; }
    }
    
    public class NM1_Pay_toAddressName
    {
        
        [D(1, "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, "1035")]
        public string PaytoLastorOrganizationalName_03 { get; set; }
        [D(4, "1036")]
        public string NameFirst_04 { get; set; }
        [D(5, "1037")]
        public string NameMiddle_05 { get; set; }
        [D(6, "1038")]
        public string NamePrefix_06 { get; set; }
        [D(7, "1039")]
        public string NameSuffix_07 { get; set; }
        [D(8, "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, "67")]
        public string IdentificationCode_09 { get; set; }
        [D(10, "706")]
        public string EntityRelationshipCode_10 { get; set; }
        [D(11, "98")]
        public string EntityIdentifierCode_11 { get; set; }
        [D(12, "1035")]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    public class Loop_2010AA
    {
        
        [S("NM1", 1, typeof(X12_ID_98_4), typeof(X12_ID_1065))]
        public NM1_BillingProviderName NM1_BillingProviderName { get; set; }
        [S("N3", 2)]
        public N3_BillingProviderAddress N3_BillingProviderAddress { get; set; }
        [S("N4", 3)]
        public N4_BillingProviderCity_State_ZIPCode N4_BillingProviderCity_State_ZIPCode { get; set; }
        [A(4)]
        public All_REF All_REF { get; set; }
        [S("PER", 5, typeof(X12_ID_366))]
        public List<PER_BillingProviderContactInformation> PER_BillingProviderContactInformation { get; set; }
    }
    
    public class PER_BillingProviderContactInformation
    {
        
        [D(1, "366")]
        public string ContactFunctionCode_01 { get; set; }
        [D(2, "93")]
        public string BillingProviderContactName_02 { get; set; }
        [D(3, "365")]
        public string CommunicationNumberQualifier_03 { get; set; }
        [D(4, "364")]
        public string CommunicationNumber_04 { get; set; }
        [D(5, "365")]
        public string CommunicationNumberQualifier_05 { get; set; }
        [D(6, "364")]
        public string CommunicationNumber_06 { get; set; }
        [D(7, "365")]
        public string CommunicationNumberQualifier_07 { get; set; }
        [D(8, "364")]
        public string CommunicationNumber_08 { get; set; }
        [D(9, "443")]
        public string ContactInquiryReference_09 { get; set; }
    }
    
    public class All_REF
    {
        
        [S("REF", 1, typeof(X12_ID_128_2))]
        public REF_BillingProviderTaxIdentification REF_BillingProviderTaxIdentification { get; set; }
        [S("REF", 2, typeof(X12_ID_128_4))]
        public List<REF_BillingProviderUPIN_LicenseInformation> REF_BillingProviderUPIN_LicenseInformation { get; set; }
    }
    
    [E(",EI,SY,")]
    public class X12_ID_128_2
    {
    }
    
    [E(",0B,1G,")]
    public class X12_ID_128_4
    {
    }
    
    public class REF_BillingProviderUPIN_LicenseInformation
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string BillingProviderLicenseandorUPINInformation_02 { get; set; }
        [D(3, "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier_2 ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier_2
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class REF_BillingProviderTaxIdentification
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string BillingProviderTaxIdentificationNumber_02 { get; set; }
        [D(3, "352")]
        public string Description_03 { get; set; }
        [C(4)]
        public C040_ReferenceIdentifier ReferenceIdentifier_04 { get; set; }
    }
    
    public class C040_ReferenceIdentifier
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, "127")]
        public string ReferenceIdentification_02 { get; set; }
        [D(3, "128")]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [D(4, "127")]
        public string ReferenceIdentification_04 { get; set; }
        [D(5, "128")]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [D(6, "127")]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    public class N4_BillingProviderCity_State_ZIPCode
    {
        
        [D(1, "19")]
        public string BillingProviderCityName_01 { get; set; }
        [D(2, "156")]
        public string BillingProviderStateorProvinceCode_02 { get; set; }
        [D(3, "116")]
        public string BillingProviderPostalZoneorZIPCode_03 { get; set; }
        [D(4, "26")]
        public string CountryCode_04 { get; set; }
        [D(5, "309")]
        public string LocationQualifier_05 { get; set; }
        [D(6, "310")]
        public string LocationIdentifier_06 { get; set; }
        [D(7, "1715")]
        public string CountrySubdivisionCode_07 { get; set; }
    }
    
    public class N3_BillingProviderAddress
    {
        
        [D(1, "166")]
        public string BillingProviderAddressLine_01 { get; set; }
        [D(2, "166")]
        public string BillingProviderAddressLine_02 { get; set; }
    }
    
    public class NM1_BillingProviderName
    {
        
        [D(1, "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, "1035")]
        public string BillingProviderLastorOrganizationalName_03 { get; set; }
        [D(4, "1036")]
        public string BillingProviderFirstName_04 { get; set; }
        [D(5, "1037")]
        public string BillingProviderMiddleNameorInitial_05 { get; set; }
        [D(6, "1038")]
        public string NamePrefix_06 { get; set; }
        [D(7, "1039")]
        public string BillingProviderNameSuffix_07 { get; set; }
        [D(8, "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, "67")]
        public string BillingProviderIdentifier_09 { get; set; }
        [D(10, "706")]
        public string EntityRelationshipCode_10 { get; set; }
        [D(11, "98")]
        public string EntityIdentifierCode_11 { get; set; }
        [D(12, "1035")]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    public class CUR_ForeignCurrencyInformation
    {
        
        [D(1, "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, "100")]
        public string CurrencyCode_02 { get; set; }
        [D(3, "280")]
        public string ExchangeRate_03 { get; set; }
        [D(4, "98")]
        public string EntityIdentifierCode_04 { get; set; }
        [D(5, "100")]
        public string CurrencyCode_05 { get; set; }
        [D(6, "669")]
        public string CurrencyMarketExchangeCode_06 { get; set; }
        [D(7, "374")]
        public string DateTimeQualifier_07 { get; set; }
        [D(8, "373")]
        public string Date_08 { get; set; }
        [D(9, "337")]
        public string Time_09 { get; set; }
        [D(10, "374")]
        public string DateTimeQualifier_10 { get; set; }
        [D(11, "373")]
        public string Date_11 { get; set; }
        [D(12, "337")]
        public string Time_12 { get; set; }
        [D(13, "374")]
        public string DateTimeQualifier_13 { get; set; }
        [D(14, "373")]
        public string Date_14 { get; set; }
        [D(15, "337")]
        public string Time_15 { get; set; }
        [D(16, "374")]
        public string DateTimeQualifier_16 { get; set; }
        [D(17, "373")]
        public string Date_17 { get; set; }
        [D(18, "337")]
        public string Time_18 { get; set; }
        [D(19, "374")]
        public string DateTimeQualifier_19 { get; set; }
        [D(20, "373")]
        public string Date_20 { get; set; }
        [D(21, "337")]
        public string Time_21 { get; set; }
    }
    
    public class PRV_BillingProviderSpecialtyInformation
    {
        
        [D(1, "1221")]
        public string ProviderCode_01 { get; set; }
        [D(2, "128")]
        public string ReferenceIdentificationQualifier_02 { get; set; }
        [D(3, "127")]
        public string ProviderTaxonomyCode_03 { get; set; }
        [D(4, "156")]
        public string StateorProvinceCode_04 { get; set; }
        [C(5)]
        public C035_ProviderSpecialtyInformation ProviderSpecialtyInformation_05 { get; set; }
        [D(6, "1223")]
        public string ProviderOrganizationCode_06 { get; set; }
    }
    
    public class C035_ProviderSpecialtyInformation
    {
        
        [D(1, "1222")]
        public string ProviderSpecialtyCode_01 { get; set; }
        [D(2, "559")]
        public string AgencyQualifierCode_02 { get; set; }
        [D(3, "1073")]
        public string YesNoConditionorResponseCode_03 { get; set; }
    }
    
    public class HL_BillingProviderHierarchicalLevel
    {
        
        [D(1, "628")]
        public string HierarchicalIDNumber_01 { get; set; }
        [D(2, "734")]
        public string HierarchicalParentIDNumber_02 { get; set; }
        [D(3, "735")]
        public string HierarchicalLevelCode_03 { get; set; }
        [D(4, "736")]
        public string HierarchicalChildCode_04 { get; set; }
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
        
        [S("NM1", 1, typeof(X12_ID_98_3), typeof(X12_ID_1065_2))]
        public NM1_ReceiverName NM1_ReceiverName { get; set; }
    }
    
    [E(",40,")]
    public class X12_ID_98_3
    {
    }
    
    public class NM1_ReceiverName
    {
        
        [D(1, "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, "1035")]
        public string ReceiverName_03 { get; set; }
        [D(4, "1036")]
        public string NameFirst_04 { get; set; }
        [D(5, "1037")]
        public string NameMiddle_05 { get; set; }
        [D(6, "1038")]
        public string NamePrefix_06 { get; set; }
        [D(7, "1039")]
        public string NameSuffix_07 { get; set; }
        [D(8, "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, "67")]
        public string ReceiverPrimaryIdentifier_09 { get; set; }
        [D(10, "706")]
        public string EntityRelationshipCode_10 { get; set; }
        [D(11, "98")]
        public string EntityIdentifierCode_11 { get; set; }
        [D(12, "1035")]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    public class Loop_1000A
    {
        
        [S("NM1", 1, typeof(X12_ID_98), typeof(X12_ID_1065))]
        public NM1_SubmitterName NM1_SubmitterName { get; set; }
        [S("PER", 2, typeof(X12_ID_366))]
        public List<PER_SubmitterEDIContactInformation> PER_SubmitterEDIContactInformation { get; set; }
    }
    
    [E(",41,")]
    public class X12_ID_98
    {
    }
    
    public class PER_SubmitterEDIContactInformation
    {
        
        [D(1, "366")]
        public string ContactFunctionCode_01 { get; set; }
        [D(2, "93")]
        public string SubmitterContactName_02 { get; set; }
        [D(3, "365")]
        public string CommunicationNumberQualifier_03 { get; set; }
        [D(4, "364")]
        public string CommunicationNumber_04 { get; set; }
        [D(5, "365")]
        public string CommunicationNumberQualifier_05 { get; set; }
        [D(6, "364")]
        public string CommunicationNumber_06 { get; set; }
        [D(7, "365")]
        public string CommunicationNumberQualifier_07 { get; set; }
        [D(8, "364")]
        public string CommunicationNumber_08 { get; set; }
        [D(9, "443")]
        public string ContactInquiryReference_09 { get; set; }
    }
    
    public class NM1_SubmitterName
    {
        
        [D(1, "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, "1035")]
        public string SubmitterLastorOrganizationName_03 { get; set; }
        [D(4, "1036")]
        public string SubmitterFirstName_04 { get; set; }
        [D(5, "1037")]
        public string SubmitterMiddleNameorInitial_05 { get; set; }
        [D(6, "1038")]
        public string NamePrefix_06 { get; set; }
        [D(7, "1039")]
        public string NameSuffix_07 { get; set; }
        [D(8, "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, "67")]
        public string SubmitterIdentifier_09 { get; set; }
        [D(10, "706")]
        public string EntityRelationshipCode_10 { get; set; }
        [D(11, "98")]
        public string EntityIdentifierCode_11 { get; set; }
        [D(12, "1035")]
        public string NameLastorOrganizationName_12 { get; set; }
    }
    
    public class BHT_BeginningofHierarchicalTransaction
    {
        
        [D(1, "1005")]
        public string HierarchicalStructureCode_01 { get; set; }
        [D(2, "353")]
        public string TransactionSetPurposeCode_02 { get; set; }
        [D(3, "127")]
        public string OriginatorApplicationTransactionIdentifier_03 { get; set; }
        [D(4, "373")]
        public string TransactionSetCreationDate_04 { get; set; }
        [D(5, "337")]
        public string TransactionSetCreationTime_05 { get; set; }
        [D(6, "640")]
        public string ClaimorEncounterIdentifier_06 { get; set; }
    }
    
    public class ST
    {
        
        [D(1, "143")]
        public string TransactionSetIdentifierCode_01 { get; set; }
        [D(2, "329")]
        public string TransactionSetControlNumber_02 { get; set; }
        [D(3, "1705")]
        public string ImplementationGuideVersionName_03 { get; set; }
    }
}
