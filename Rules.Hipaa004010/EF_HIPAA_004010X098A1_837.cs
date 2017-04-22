namespace EdiFabric.Rules.HIPAA_004010X098A1_837
{
    using System;
    using System.Xml;
    using System.Xml.Serialization;
    using System.Collections.Generic;
    using EdiFabric.Attributes;
    
    
    [M("X12", "004010X098A1", "837")]
    public class TS837
    {
        
        /// <summary>
        /// Transaction Set Header
        /// </summary>
        [S("ST", 1)]
        public ST ST { get; set; }
        [S("BHT", 2, typeof(X12_ID_1005_TS837), typeof(X12_ID_353_TS837))]
        public BHT_BeginningOfHierarchicalTransaction BHT_BeginningOfHierarchicalTransaction { get; set; }
        [S("REF", 3, typeof(X12_ID_128_TS837))]
        public REF_TransmissionTypeIdentification REF_TransmissionTypeIdentification { get; set; }
        [G(4)]
        public Loop_1000A Loop_1000A { get; set; }
        [G(5)]
        public Loop_1000B Loop_1000B { get; set; }
        [G(6)]
        public List<Loop_2000A> Loop_2000A { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [S("SE", 7)]
        public SE SE { get; set; }
    }
    
    public class X12_AN
    {
    }
    
    [E(",0019,")]
    public class X12_ID_1005_TS837
    {
    }
    
    [E(",00,18,")]
    public class X12_ID_353_TS837
    {
    }
    
    [E(",87,")]
    public class X12_ID_128_TS837
    {
    }
    
    public class SE
    {
        
        [D(1, "96")]
        public string NumberofIncludedSegments_01 { get; set; }
        [D(2, "329")]
        public string TransactionSetControlNumber_02 { get; set; }
    }
    
    public class Loop_2000A
    {
        
        [S("HL", 1)]
        public HL_BillingPaytoProviderHierarchicalLevel_2000A HL_BillingPaytoProviderHierarchicalLevel_2000A { get; set; }
        [S("PRV", 2, typeof(X12_ID_1221_Loop_2000A), typeof(X12_ID_128_Loop_2000A))]
        public PRV_BillingPaytoProviderSpecialtyInformation_2000A PRV_BillingPaytoProviderSpecialtyInformation_2000A { get; set; }
        [S("CUR", 3, typeof(X12_ID_98_Loop_2000A))]
        public CUR_ForeignCurrencyInformation_2000A CUR_ForeignCurrencyInformation_2000A { get; set; }
        [A(4)]
        public All_2010A All_2010A { get; set; }
        [G(5)]
        public List<Loop_2000B> Loop_2000B { get; set; }
    }
    
    [E(",BI,PT,")]
    public class X12_ID_1221_Loop_2000A
    {
    }
    
    [E(",ZZ,")]
    public class X12_ID_128_Loop_2000A
    {
    }
    
    [E(",85,")]
    public class X12_ID_98_Loop_2000A
    {
    }
    
    public class X12_ID
    {
    }
    
    public class Loop_2000B
    {
        
        [S("HL", 1)]
        public HL_SubscriberHierarchicalLevel_2000B HL_SubscriberHierarchicalLevel_2000B { get; set; }
        [S("SBR", 2, typeof(X12_ID_1138_Loop_2000B), typeof(X12_ID_1069_Loop_2000B))]
        public SBR_SubscriberInformation_2000B SBR_SubscriberInformation_2000B { get; set; }
        [S("PAT", 3)]
        public PAT_PatientInformation_2000B PAT_PatientInformation_2000B { get; set; }
        [A(4)]
        public All_2010B All_2010B { get; set; }
        [G(5)]
        public List<Loop_2300> Loop_2300 { get; set; }
        [G(6)]
        public List<Loop_2000C> Loop_2000C { get; set; }
    }
    
    [E(",P,S,T,")]
    public class X12_ID_1138_Loop_2000B
    {
    }
    
    [E(",18,")]
    public class X12_ID_1069_Loop_2000B
    {
    }
    
    public class Loop_2000C
    {
        
        [S("HL", 1)]
        public HL_PatientHierarchicalLevel_2000C HL_PatientHierarchicalLevel_2000C { get; set; }
        [S("PAT", 2, typeof(X12_ID_1069_Loop_2000C))]
        public PAT_PatientInformation_2000C PAT_PatientInformation_2000C { get; set; }
        [G(3)]
        public Loop_2010CA Loop_2010CA { get; set; }
        [G(4)]
        public List<Loop_2300> Loop_2300 { get; set; }
    }
    
    [E(",01,04,05,07,09,10,15,17,19,20,21,22,23,24,29,32,33,34,36,39,40,41,43,53,G8,")]
    public class X12_ID_1069_Loop_2000C
    {
    }
    
    public class Loop_2300
    {
        
        [S("CLM", 1)]
        public CLM_ClaimInformation_2300 CLM_ClaimInformation_2300 { get; set; }
        [A(2)]
        public All_DTP_2300 All_DTP_2300 { get; set; }
        [S("PWK", 3, typeof(X12_ID_755_Loop_2300), typeof(X12_ID_756_Loop_2300))]
        public List<PWK_ClaimSupplementalInformation_2300> PWK_ClaimSupplementalInformation_2300 { get; set; }
        [S("CN1", 4, typeof(X12_ID_1166_Loop_2300))]
        public CN1_ContractInformation_2300 CN1_ContractInformation_2300 { get; set; }
        [A(5)]
        public All_AMT_2300 All_AMT_2300 { get; set; }
        [A(6)]
        public All_REF_2300 All_REF_2300 { get; set; }
        [S("K3", 7)]
        public List<K3_FileInformation_2300> K3_FileInformation_2300 { get; set; }
        [S("NTE", 8, typeof(X12_ID_363_Loop_2300))]
        public NTE_ClaimNote_2300 NTE_ClaimNote_2300 { get; set; }
        [S("CR1", 9, typeof(X12_ID_355_Loop_2300))]
        public CR1_AmbulanceTransportInformation_2300 CR1_AmbulanceTransportInformation_2300 { get; set; }
        [S("CR2", 10)]
        public CR2_SpinalManipulationServiceInformation_2300 CR2_SpinalManipulationServiceInformation_2300 { get; set; }
        [A(11)]
        public All_CRC_2300 All_CRC_2300 { get; set; }
        [S("HI", 12, typeof(X12_ID_1270_Loop_2300), typeof(X12_ID_1270_Loop_2300))]
        public HI_HealthCareDiagnosisCode_2300 HI_HealthCareDiagnosisCode_2300 { get; set; }
        [S("HCP", 13, typeof(X12_ID_1473_Loop_2300))]
        public HCP_ClaimPricingRepricingInformation_2300 HCP_ClaimPricingRepricingInformation_2300 { get; set; }
        [G(14)]
        public List<Loop_2305> Loop_2305 { get; set; }
        [A(15)]
        public All_2310 All_2310 { get; set; }
        [G(16)]
        public List<Loop_2320> Loop_2320 { get; set; }
        [G(17)]
        public List<Loop_2400> Loop_2400 { get; set; }
    }
    
    public class X12_R
    {
    }
    
    [E(",77,AS,B2,B3,B4,CT,DA,DG,DS,EB,MT,NN,OB,OZ,PN,PO,PZ,RB,RR,RT,")]
    public class X12_ID_755_Loop_2300
    {
    }
    
    [E(",AA,BM,EL,EM,FX,")]
    public class X12_ID_756_Loop_2300
    {
    }
    
    [E(",02,03,04,05,06,09,")]
    public class X12_ID_1166_Loop_2300
    {
    }
    
    [E(",ADD,CER,DCP,DGN,PMT,TPO,")]
    public class X12_ID_363_Loop_2300
    {
    }
    
    [E(",LB,")]
    public class X12_ID_355_Loop_2300
    {
    }
    
    public class X12_N0
    {
    }
    
    [E(",BK,")]
    public class X12_ID_1270_Loop_2300
    {
    }
    
    [E(",00,01,02,03,04,05,07,08,09,10,11,12,13,14,")]
    public class X12_ID_1473_Loop_2300
    {
    }
    
    public class Loop_2400
    {
        
        [S("LX", 1)]
        public LX_ServiceLine_2400 LX_ServiceLine_2400 { get; set; }
        [S("SV1", 2, typeof(X12_ID_235_Loop_2400))]
        public SV1_ProfessionalService_2400 SV1_ProfessionalService_2400 { get; set; }
        [S("SV5", 3, typeof(X12_ID_235_Loop_2400), typeof(X12_ID_355_Loop_2400))]
        public SV5_DurableMedicalEquipmentService_2400 SV5_DurableMedicalEquipmentService_2400 { get; set; }
        [S("PWK", 4, typeof(X12_ID_755_Loop_2400), typeof(X12_ID_756_Loop_2400))]
        public PWK_DMERCCMNIndicator_2400 PWK_DMERCCMNIndicator_2400 { get; set; }
        [S("CR1", 5, typeof(X12_ID_355_Loop_2400))]
        public CR1_AmbulanceTransportInformation_2400 CR1_AmbulanceTransportInformation_2400 { get; set; }
        [S("CR2", 6)]
        public List<CR2_SpinalManipulationServiceInformation_2400> CR2_SpinalManipulationServiceInformation_2400 { get; set; }
        [S("CR3", 7, typeof(X12_ID_1322_Loop_2400), typeof(X12_ID_355_Loop_2400))]
        public CR3_DurableMedicalEquipmentCertification_2400 CR3_DurableMedicalEquipmentCertification_2400 { get; set; }
        [S("CR5", 8, typeof(X12_ID_1322_Loop_2400))]
        public CR5_HomeOxygenTherapyInformation_2400 CR5_HomeOxygenTherapyInformation_2400 { get; set; }
        [A(9)]
        public All_CRC_2400 All_CRC_2400 { get; set; }
        [A(10)]
        public All_DTP_2400 All_DTP_2400 { get; set; }
        [S("MEA", 11, typeof(X12_ID_737_Loop_2400), typeof(X12_ID_738_Loop_2400))]
        public List<MEA_TestResult_2400> MEA_TestResult_2400 { get; set; }
        [S("CN1", 12, typeof(X12_ID_1166_Loop_2400))]
        public CN1_ContractInformation_2400 CN1_ContractInformation_2400 { get; set; }
        [A(13)]
        public All_REF_2400 All_REF_2400 { get; set; }
        [A(14)]
        public All_AMT_2400 All_AMT_2400 { get; set; }
        [S("K3", 15)]
        public List<K3_FileInformation_2400> K3_FileInformation_2400 { get; set; }
        [S("NTE", 16, typeof(X12_ID_363_Loop_2400))]
        public NTE_LineNote_2400 NTE_LineNote_2400 { get; set; }
        [S("PS1", 17)]
        public PS1_PurchasedServiceInformation_2400 PS1_PurchasedServiceInformation_2400 { get; set; }
        [S("HSD", 18, typeof(X12_ID_673_Loop_2400))]
        public HSD_HealthCareServicesDelivery_2400 HSD_HealthCareServicesDelivery_2400 { get; set; }
        [S("HCP", 19, typeof(X12_ID_1473_Loop_2400))]
        public HCP_LinePricingRepricingInformation_2400 HCP_LinePricingRepricingInformation_2400 { get; set; }
        [G(20)]
        public List<Loop_2410> Loop_2410 { get; set; }
        [A(21)]
        public All_2420 All_2420 { get; set; }
        [G(22)]
        public List<Loop_2430> Loop_2430 { get; set; }
        [G(23)]
        public List<Loop_2440> Loop_2440 { get; set; }
    }
    
    [E(",HC,IV,ZZ,")]
    public class X12_ID_235_Loop_2400
    {
    }
    
    [E(",DA,")]
    public class X12_ID_355_Loop_2400
    {
    }
    
    [E(",CT,")]
    public class X12_ID_755_Loop_2400
    {
    }
    
    [E(",AB,AD,AF,AG,NS,")]
    public class X12_ID_756_Loop_2400
    {
    }
    
    [E(",I,R,S,")]
    public class X12_ID_1322_Loop_2400
    {
    }
    
    [E(",OG,TR,")]
    public class X12_ID_737_Loop_2400
    {
    }
    
    [E(",GRA,HT,R1,R2,R3,R4,ZO,")]
    public class X12_ID_738_Loop_2400
    {
    }
    
    [E(",01,02,03,04,05,06,09,")]
    public class X12_ID_1166_Loop_2400
    {
    }
    
    [E(",ADD,DCP,PMT,TPO,")]
    public class X12_ID_363_Loop_2400
    {
    }
    
    [E(",VS,")]
    public class X12_ID_673_Loop_2400
    {
    }
    
    [E(",00,01,02,03,04,05,06,07,08,09,10,11,12,13,14,")]
    public class X12_ID_1473_Loop_2400
    {
    }
    
    public class Loop_2440
    {
        
        [S("LQ", 1, typeof(X12_ID_1270_Loop_2440))]
        public LQ_FormIdentificationCode_2440 LQ_FormIdentificationCode_2440 { get; set; }
        [S("FRM", 2)]
        public List<FRM_SupportingDocumentation_2440> FRM_SupportingDocumentation_2440 { get; set; }
    }
    
    [E(",AS,UT,")]
    public class X12_ID_1270_Loop_2440
    {
    }
    
    [E(",N,W,Y,")]
    public class X12_ID_1073_Loop_2440
    {
    }
    
    public class FRM_SupportingDocumentation_2440
    {
        
        [D(1)]
        public string QuestionNumberLetter_01 { get; set; }
        [D(2, "1073")]
        public string QuestionResponse_02 { get; set; }
        [D(3)]
        public string QuestionResponse_03 { get; set; }
        [D(4)]
        public string QuestionResponse_04 { get; set; }
        [D(5)]
        public string QuestionResponse_05 { get; set; }
    }
    
    public class LQ_FormIdentificationCode_2440
    {
        
        [D(1, "1270")]
        public string CodeListQualifierCode_01 { get; set; }
        [D(2)]
        public string FormIdentifier_02 { get; set; }
    }
    
    public class Loop_2430
    {
        
        [S("SVD", 1)]
        public SVD_LineAdjudicationInformation_2430 SVD_LineAdjudicationInformation_2430 { get; set; }
        [S("CAS", 2, typeof(X12_ID_1033_Loop_2430))]
        public List<CAS_LineAdjustment_2430> CAS_LineAdjustment_2430 { get; set; }
        [S("DTP", 3, typeof(X12_ID_374_Loop_2430), typeof(X12_ID_1250_Loop_2430))]
        public DTP_LineAdjudicationDate_2430 DTP_LineAdjudicationDate_2430 { get; set; }
    }
    
    [E(",CO,CR,OA,PI,PR,")]
    public class X12_ID_1033_Loop_2430
    {
    }
    
    [E(",573,")]
    public class X12_ID_374_Loop_2430
    {
    }
    
    [E(",D8,")]
    public class X12_ID_1250_Loop_2430
    {
    }
    
    public class DTP_LineAdjudicationDate_2430
    {
        
        [D(1, "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3)]
        public string AdjudicationOrPaymentDate_03 { get; set; }
    }
    
    public class CAS_LineAdjustment_2430
    {
        
        [D(1, "1033")]
        public string ClaimAdjustmentGroupCode_01 { get; set; }
        [D(2)]
        public string AdjustmentReasonCode_02 { get; set; }
        [D(3)]
        public string AdjustmentAmount_03 { get; set; }
        [D(4)]
        public string AdjustmentQuantity_04 { get; set; }
        [D(5)]
        public string AdjustmentReasonCode_05 { get; set; }
        [D(6)]
        public string AdjustmentAmount_06 { get; set; }
        [D(7)]
        public string AdjustmentQuantity_07 { get; set; }
        [D(8)]
        public string AdjustmentReasonCode_08 { get; set; }
        [D(9)]
        public string AdjustmentAmount_09 { get; set; }
        [D(10)]
        public string AdjustmentQuantity_10 { get; set; }
        [D(11)]
        public string AdjustmentReasonCode_11 { get; set; }
        [D(12)]
        public string AdjustmentAmount_12 { get; set; }
        [D(13)]
        public string AdjustmentQuantity_13 { get; set; }
        [D(14)]
        public string AdjustmentReasonCode_14 { get; set; }
        [D(15)]
        public string AdjustmentAmount_15 { get; set; }
        [D(16)]
        public string AdjustmentQuantity_16 { get; set; }
        [D(17)]
        public string AdjustmentReasonCode_17 { get; set; }
        [D(18)]
        public string AdjustmentAmount_18 { get; set; }
        [D(19)]
        public string AdjustmentQuantity_19 { get; set; }
    }
    
    public class SVD_LineAdjudicationInformation_2430
    {
        
        [D(1)]
        public string OtherPayerPrimaryIdentifier_01 { get; set; }
        [D(2)]
        public string ServiceLinePaidAmount_02 { get; set; }
        [C(3)]
        public C003_460284360 C003_460284360 { get; set; }
        [D(4)]
        public string SVD_04 { get; set; }
        [D(5)]
        public string PaidServiceUnitCount_05 { get; set; }
        [D(6)]
        public string BundledOrUnbundledLineNumber_06 { get; set; }
    }
    
    public class C003_460284360
    {
        
        [D(1, "235")]
        public string ProductOrServiceIDQualifier_01 { get; set; }
        [D(2)]
        public string ProcedureCode_02 { get; set; }
        [D(3)]
        public string ProcedureModifier_03 { get; set; }
        [D(4)]
        public string ProcedureModifier_04 { get; set; }
        [D(5)]
        public string ProcedureModifier_05 { get; set; }
        [D(6)]
        public string ProcedureModifier_06 { get; set; }
        [D(7)]
        public string ProcedureCodeDescription_07 { get; set; }
    }
    
    public class All_2420
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
        public List<Loop_2420G> Loop_2420G { get; set; }
    }
    
    public class Loop_2420G
    {
        
        [S("NM1", 1, typeof(X12_ID_98_Loop_2420G), typeof(X12_ID_1065_Loop_2420G))]
        public NM1_OtherPayerPriorAuthorizationOrReferralNumber_2420G NM1_OtherPayerPriorAuthorizationOrReferralNumber_2420G { get; set; }
        [S("REF", 2, typeof(X12_ID_128_Loop_2420G))]
        public List<REF_OtherPayerPriorAuthorizationOrReferralNumber_2420G> REF_OtherPayerPriorAuthorizationOrReferralNumber_2420G { get; set; }
    }
    
    [E(",PR,")]
    public class X12_ID_98_Loop_2420G
    {
    }
    
    [E(",2,")]
    public class X12_ID_1065_Loop_2420G
    {
    }
    
    [E(",9F,G1,")]
    public class X12_ID_128_Loop_2420G
    {
    }
    
    public class REF_OtherPayerPriorAuthorizationOrReferralNumber_2420G
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2)]
        public string OtherPayerPriorAuthorizationOrReferralNumber_02 { get; set; }
        [D(3)]
        public string REF_03 { get; set; }
        [D(4)]
        public string REF_04 { get; set; }
    }
    
    public class NM1_OtherPayerPriorAuthorizationOrReferralNumber_2420G
    {
        
        [D(1, "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3)]
        public string PayerName_03 { get; set; }
        [D(4)]
        public string NM1_04 { get; set; }
        [D(5)]
        public string NM1_05 { get; set; }
        [D(6)]
        public string NM1_06 { get; set; }
        [D(7)]
        public string NM1_07 { get; set; }
        [D(8, "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9)]
        public string OtherPayerIdentificationNumber_09 { get; set; }
        [D(10)]
        public string NM1_10 { get; set; }
        [D(11)]
        public string NM1_11 { get; set; }
    }
    
    public class Loop_2420F
    {
        
        [S("NM1", 1, typeof(X12_ID_98_Loop_2420F), typeof(X12_ID_1065_Loop_2420F))]
        public NM1_ReferringProviderName_2420F NM1_ReferringProviderName_2420F { get; set; }
        [S("PRV", 2, typeof(X12_ID_1221_Loop_2420F), typeof(X12_ID_128_Loop_2420F))]
        public PRV_ReferringProviderSpecialtyInformation_2420F PRV_ReferringProviderSpecialtyInformation_2420F { get; set; }
        [S("REF", 3, typeof(X12_ID_128_Loop_2420F))]
        public List<REF_ReferringProviderSecondaryIdentification_2420F> REF_ReferringProviderSecondaryIdentification_2420F { get; set; }
    }
    
    [E(",DN,P3,")]
    public class X12_ID_98_Loop_2420F
    {
    }
    
    [E(",1,")]
    public class X12_ID_1065_Loop_2420F
    {
    }
    
    [E(",RF,")]
    public class X12_ID_1221_Loop_2420F
    {
    }
    
    [E(",ZZ,")]
    public class X12_ID_128_Loop_2420F
    {
    }
    
    public class REF_ReferringProviderSecondaryIdentification_2420F
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2)]
        public string ReferringProviderSecondaryIdentifier_02 { get; set; }
        [D(3)]
        public string REF_03 { get; set; }
        [D(4)]
        public string REF_04 { get; set; }
    }
    
    public class PRV_ReferringProviderSpecialtyInformation_2420F
    {
        
        [D(1, "1221")]
        public string ProviderCode_01 { get; set; }
        [D(2, "128")]
        public string ReferenceIdentificationQualifier_02 { get; set; }
        [D(3)]
        public string ProviderTaxonomyCode_03 { get; set; }
        [D(4)]
        public string PRV_04 { get; set; }
        [D(5)]
        public string PRV_05 { get; set; }
        [D(6)]
        public string PRV_06 { get; set; }
    }
    
    public class NM1_ReferringProviderName_2420F
    {
        
        [D(1, "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3)]
        public string ReferringProviderLastName_03 { get; set; }
        [D(4)]
        public string ReferringProviderFirstName_04 { get; set; }
        [D(5)]
        public string ReferringProviderMiddleName_05 { get; set; }
        [D(6)]
        public string NM1_06 { get; set; }
        [D(7)]
        public string ReferringProviderNameSuffix_07 { get; set; }
        [D(8, "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9)]
        public string ReferringProviderIdentifier_09 { get; set; }
        [D(10)]
        public string NM1_10 { get; set; }
        [D(11)]
        public string NM1_11 { get; set; }
    }
    
    public class Loop_2420E
    {
        
        [S("NM1", 1, typeof(X12_ID_98_Loop_2420E), typeof(X12_ID_1065_Loop_2420E))]
        public NM1_OrderingProviderName_2420E NM1_OrderingProviderName_2420E { get; set; }
        [S("N3", 2)]
        public N3_OrderingProviderAddress_2420E N3_OrderingProviderAddress_2420E { get; set; }
        [S("N4", 3)]
        public N4_OrderingProviderCityStateZIPCode_2420E N4_OrderingProviderCityStateZIPCode_2420E { get; set; }
        [S("REF", 4, typeof(X12_ID_128_Loop_2420E))]
        public List<REF_OrderingProviderSecondaryIdentification_2420E> REF_OrderingProviderSecondaryIdentification_2420E { get; set; }
        [S("PER", 5, typeof(X12_ID_366_Loop_2420E))]
        public PER_OrderingProviderContactInformation_2420E PER_OrderingProviderContactInformation_2420E { get; set; }
    }
    
    [E(",DK,")]
    public class X12_ID_98_Loop_2420E
    {
    }
    
    [E(",1,")]
    public class X12_ID_1065_Loop_2420E
    {
    }
    
    [E(",0B,1B,1C,1D,1G,1H,EI,G2,LU,N5,SY,X5,")]
    public class X12_ID_128_Loop_2420E
    {
    }
    
    [E(",IC,")]
    public class X12_ID_366_Loop_2420E
    {
    }
    
    public class PER_OrderingProviderContactInformation_2420E
    {
        
        [D(1, "366")]
        public string ContactFunctionCode_01 { get; set; }
        [D(2)]
        public string OrderingProviderContactName_02 { get; set; }
        [D(3, "365")]
        public string CommunicationNumberQualifier_03 { get; set; }
        [D(4)]
        public string CommunicationNumber_04 { get; set; }
        [D(5, "365")]
        public string CommunicationNumberQualifier_05 { get; set; }
        [D(6)]
        public string CommunicationNumber_06 { get; set; }
        [D(7, "365")]
        public string CommunicationNumberQualifier_07 { get; set; }
        [D(8)]
        public string CommunicationNumber_08 { get; set; }
        [D(9)]
        public string PER_09 { get; set; }
    }
    
    public class REF_OrderingProviderSecondaryIdentification_2420E
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2)]
        public string OrderingProviderSecondaryIdentifier_02 { get; set; }
        [D(3)]
        public string REF_03 { get; set; }
        [D(4)]
        public string REF_04 { get; set; }
    }
    
    public class N4_OrderingProviderCityStateZIPCode_2420E
    {
        
        [D(1)]
        public string OrderingProviderCityName_01 { get; set; }
        [D(2)]
        public string OrderingProviderStateCode_02 { get; set; }
        [D(3)]
        public string OrderingProviderPostalZoneOrZIPCode_03 { get; set; }
        [D(4)]
        public string CountryCode_04 { get; set; }
        [D(5)]
        public string N4_05 { get; set; }
        [D(6)]
        public string N4_06 { get; set; }
    }
    
    public class N3_OrderingProviderAddress_2420E
    {
        
        [D(1)]
        public string OrderingProviderAddressLine_01 { get; set; }
        [D(2)]
        public string OrderingProviderAddressLine_02 { get; set; }
    }
    
    public class NM1_OrderingProviderName_2420E
    {
        
        [D(1, "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3)]
        public string OrderingProviderLastName_03 { get; set; }
        [D(4)]
        public string OrderingProviderFirstName_04 { get; set; }
        [D(5)]
        public string OrderingProviderMiddleName_05 { get; set; }
        [D(6)]
        public string NM1_06 { get; set; }
        [D(7)]
        public string OrderingProviderNameSuffix_07 { get; set; }
        [D(8, "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9)]
        public string OrderingProviderIdentifier_09 { get; set; }
        [D(10)]
        public string NM1_10 { get; set; }
        [D(11)]
        public string NM1_11 { get; set; }
    }
    
    public class Loop_2420D
    {
        
        [S("NM1", 1, typeof(X12_ID_98_Loop_2420D), typeof(X12_ID_1065_Loop_2420D))]
        public NM1_SupervisingProviderName_2420D NM1_SupervisingProviderName_2420D { get; set; }
        [S("REF", 2, typeof(X12_ID_128_Loop_2420D))]
        public List<REF_SupervisingProviderSecondaryIdentification_2420D> REF_SupervisingProviderSecondaryIdentification_2420D { get; set; }
    }
    
    [E(",DQ,")]
    public class X12_ID_98_Loop_2420D
    {
    }
    
    [E(",1,")]
    public class X12_ID_1065_Loop_2420D
    {
    }
    
    [E(",0B,1B,1C,1D,1G,1H,EI,G2,LU,N5,SY,X5,")]
    public class X12_ID_128_Loop_2420D
    {
    }
    
    public class REF_SupervisingProviderSecondaryIdentification_2420D
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2)]
        public string SupervisingProviderSecondaryIdentifier_02 { get; set; }
        [D(3)]
        public string REF_03 { get; set; }
        [D(4)]
        public string REF_04 { get; set; }
    }
    
    public class NM1_SupervisingProviderName_2420D
    {
        
        [D(1, "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3)]
        public string SupervisingProviderLastName_03 { get; set; }
        [D(4)]
        public string SupervisingProviderFirstName_04 { get; set; }
        [D(5)]
        public string SupervisingProviderMiddleName_05 { get; set; }
        [D(6)]
        public string NM1_06 { get; set; }
        [D(7)]
        public string SupervisingProviderNameSuffix_07 { get; set; }
        [D(8, "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9)]
        public string SupervisingProviderIdentifier_09 { get; set; }
        [D(10)]
        public string NM1_10 { get; set; }
        [D(11)]
        public string NM1_11 { get; set; }
    }
    
    public class Loop_2420C
    {
        
        [S("NM1", 1, typeof(X12_ID_98_Loop_2420C), typeof(X12_ID_1065_Loop_2420C))]
        public NM1_ServiceFacilityLocation_2420C NM1_ServiceFacilityLocation_2420C { get; set; }
        [S("N3", 2)]
        public N3_ServiceFacilityLocationAddress_2420C N3_ServiceFacilityLocationAddress_2420C { get; set; }
        [S("N4", 3)]
        public N4_ServiceFacilityLocationCityStateZIP_2420C N4_ServiceFacilityLocationCityStateZIP_2420C { get; set; }
        [S("REF", 4, typeof(X12_ID_128_Loop_2420C))]
        public List<REF_ServiceFacilityLocationSecondaryIdentification_2420C> REF_ServiceFacilityLocationSecondaryIdentification_2420C { get; set; }
    }
    
    [E(",77,FA,LI,TL,")]
    public class X12_ID_98_Loop_2420C
    {
    }
    
    [E(",2,")]
    public class X12_ID_1065_Loop_2420C
    {
    }
    
    [E(",0B,1A,1B,1C,1D,1G,1H,G2,LU,N5,TJ,X4,X5,")]
    public class X12_ID_128_Loop_2420C
    {
    }
    
    public class REF_ServiceFacilityLocationSecondaryIdentification_2420C
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2)]
        public string ServiceFacilityLocationSecondaryIdentifier_02 { get; set; }
        [D(3)]
        public string REF_03 { get; set; }
        [D(4)]
        public string REF_04 { get; set; }
    }
    
    public class N4_ServiceFacilityLocationCityStateZIP_2420C
    {
        
        [D(1)]
        public string LaboratoryOrFacilityCityName_01 { get; set; }
        [D(2)]
        public string LaboratoryOrFacilityStateOrProvinceCode_02 { get; set; }
        [D(3)]
        public string LaboratoryOrFacilityPostalZoneOrZIPCode_03 { get; set; }
        [D(4)]
        public string CountryCode_04 { get; set; }
        [D(5)]
        public string N4_05 { get; set; }
        [D(6)]
        public string N4_06 { get; set; }
    }
    
    public class N3_ServiceFacilityLocationAddress_2420C
    {
        
        [D(1)]
        public string LaboratoryOrFacilityAddressLine_01 { get; set; }
        [D(2)]
        public string LaboratoryOrFacilityAddressLine_02 { get; set; }
    }
    
    public class NM1_ServiceFacilityLocation_2420C
    {
        
        [D(1, "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3)]
        public string LaboratoryOrFacilityName_03 { get; set; }
        [D(4)]
        public string NM1_04 { get; set; }
        [D(5)]
        public string NM1_05 { get; set; }
        [D(6)]
        public string NM1_06 { get; set; }
        [D(7)]
        public string NM1_07 { get; set; }
        [D(8, "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9)]
        public string LaboratoryOrFacilityPrimaryIdentifier_09 { get; set; }
        [D(10)]
        public string NM1_10 { get; set; }
        [D(11)]
        public string NM1_11 { get; set; }
    }
    
    public class Loop_2420B
    {
        
        [S("NM1", 1, typeof(X12_ID_98_Loop_2420B), typeof(X12_ID_1065_Loop_2420B))]
        public NM1_PurchasedServiceProviderName_2420B NM1_PurchasedServiceProviderName_2420B { get; set; }
        [S("REF", 2, typeof(X12_ID_128_Loop_2420B))]
        public List<REF_PurchasedServiceProviderSecondaryIdentification_2420B> REF_PurchasedServiceProviderSecondaryIdentification_2420B { get; set; }
    }
    
    [E(",QB,")]
    public class X12_ID_98_Loop_2420B
    {
    }
    
    [E(",1,2,")]
    public class X12_ID_1065_Loop_2420B
    {
    }
    
    [E(",0B,1A,1B,1C,1D,1G,1H,EI,G2,LU,N5,SY,U3,X5,")]
    public class X12_ID_128_Loop_2420B
    {
    }
    
    public class REF_PurchasedServiceProviderSecondaryIdentification_2420B
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2)]
        public string PurchasedServiceProviderSecondaryIdentifier_02 { get; set; }
        [D(3)]
        public string REF_03 { get; set; }
        [D(4)]
        public string REF_04 { get; set; }
    }
    
    public class NM1_PurchasedServiceProviderName_2420B
    {
        
        [D(1, "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3)]
        public string NM1_03 { get; set; }
        [D(4)]
        public string NM1_04 { get; set; }
        [D(5)]
        public string NM1_05 { get; set; }
        [D(6)]
        public string NM1_06 { get; set; }
        [D(7)]
        public string NM1_07 { get; set; }
        [D(8, "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9)]
        public string PurchasedServiceProviderIdentifier_09 { get; set; }
        [D(10)]
        public string NM1_10 { get; set; }
        [D(11)]
        public string NM1_11 { get; set; }
    }
    
    public class Loop_2420A
    {
        
        [S("NM1", 1, typeof(X12_ID_98_Loop_2420A), typeof(X12_ID_1065_Loop_2420A))]
        public NM1_RenderingProviderName_2420A NM1_RenderingProviderName_2420A { get; set; }
        [S("PRV", 2, typeof(X12_ID_1221_Loop_2420A), typeof(X12_ID_128_Loop_2420A))]
        public PRV_RenderingProviderSpecialtyInformation_2420A PRV_RenderingProviderSpecialtyInformation_2420A { get; set; }
        [S("REF", 3, typeof(X12_ID_128_Loop_2420A))]
        public List<REF_RenderingProviderSecondaryIdentification_2420A> REF_RenderingProviderSecondaryIdentification_2420A { get; set; }
    }
    
    [E(",82,")]
    public class X12_ID_98_Loop_2420A
    {
    }
    
    [E(",1,2,")]
    public class X12_ID_1065_Loop_2420A
    {
    }
    
    [E(",PE,")]
    public class X12_ID_1221_Loop_2420A
    {
    }
    
    [E(",ZZ,")]
    public class X12_ID_128_Loop_2420A
    {
    }
    
    public class REF_RenderingProviderSecondaryIdentification_2420A
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2)]
        public string RenderingProviderSecondaryIdentifier_02 { get; set; }
        [D(3)]
        public string REF_03 { get; set; }
        [D(4)]
        public string REF_04 { get; set; }
    }
    
    public class PRV_RenderingProviderSpecialtyInformation_2420A
    {
        
        [D(1, "1221")]
        public string ProviderCode_01 { get; set; }
        [D(2, "128")]
        public string ReferenceIdentificationQualifier_02 { get; set; }
        [D(3)]
        public string ProviderTaxonomyCode_03 { get; set; }
        [D(4)]
        public string PRV_04 { get; set; }
        [D(5)]
        public string PRV_05 { get; set; }
        [D(6)]
        public string PRV_06 { get; set; }
    }
    
    public class NM1_RenderingProviderName_2420A
    {
        
        [D(1, "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3)]
        public string RenderingProviderLastOrOrganizationName_03 { get; set; }
        [D(4)]
        public string RenderingProviderFirstName_04 { get; set; }
        [D(5)]
        public string RenderingProviderMiddleName_05 { get; set; }
        [D(6)]
        public string NM1_06 { get; set; }
        [D(7)]
        public string RenderingProviderNameSuffix_07 { get; set; }
        [D(8, "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9)]
        public string RenderingProviderIdentifier_09 { get; set; }
        [D(10)]
        public string NM1_10 { get; set; }
        [D(11)]
        public string NM1_11 { get; set; }
    }
    
    public class Loop_2410
    {
        
        [S("LIN", 1)]
        public LIN_DrugIdentification_2410 LIN_DrugIdentification_2410 { get; set; }
        [S("CTP", 2)]
        public CTP_DrugPricing_2410 CTP_DrugPricing_2410 { get; set; }
        [S("REF", 3, typeof(X12_ID_128_Loop_2410))]
        public REF_PrescriptionNumber_2410 REF_PrescriptionNumber_2410 { get; set; }
    }
    
    [E(",N4,")]
    public class X12_ID_235_Loop_2410
    {
    }
    
    [E(",XZ,")]
    public class X12_ID_128_Loop_2410
    {
    }
    
    public class REF_PrescriptionNumber_2410
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2)]
        public string PrescriptionNumber_02 { get; set; }
        [D(3)]
        public string REF_03 { get; set; }
        [D(4)]
        public string REF_04 { get; set; }
    }
    
    public class CTP_DrugPricing_2410
    {
        
        [D(1)]
        public string CTP_01 { get; set; }
        [D(2)]
        public string CTP_02 { get; set; }
        [D(3)]
        public string DrugUnitPrice_03 { get; set; }
        [D(4)]
        public string NationalDrugUnitCount_04 { get; set; }
        [C(5)]
        public C001_1149128115 C001_1149128115 { get; set; }
        [D(6)]
        public string CTP_06 { get; set; }
        [D(7)]
        public string CTP_07 { get; set; }
        [D(8)]
        public string CTP_08 { get; set; }
        [D(9)]
        public string CTP_09 { get; set; }
        [D(10)]
        public string CTP_10 { get; set; }
        [D(11)]
        public string CTP_11 { get; set; }
    }
    
    public class C001_1149128115
    {
        
        [D(1, "355")]
        public string UnitOrBasisForMeasurementCode_01 { get; set; }
        [D(2)]
        public string CTP_02 { get; set; }
        [D(3)]
        public string CTP_03 { get; set; }
        [D(4)]
        public string CTP_04 { get; set; }
        [D(5)]
        public string CTP_05 { get; set; }
        [D(6)]
        public string CTP_06 { get; set; }
        [D(7)]
        public string CTP_07 { get; set; }
        [D(8)]
        public string CTP_08 { get; set; }
        [D(9)]
        public string CTP_09 { get; set; }
        [D(10)]
        public string CTP_10 { get; set; }
        [D(11)]
        public string CTP_11 { get; set; }
        [D(12)]
        public string CTP_12 { get; set; }
        [D(13)]
        public string CTP_13 { get; set; }
        [D(14)]
        public string CTP_14 { get; set; }
        [D(15)]
        public string CTP_15 { get; set; }
    }
    
    public class LIN_DrugIdentification_2410
    {
        
        [D(1)]
        public string LIN_01 { get; set; }
        [D(2, "235")]
        public string ProductOrServiceIDQualifier_02 { get; set; }
        [D(3)]
        public string NationalDrugCode_03 { get; set; }
        [D(4)]
        public string LIN_04 { get; set; }
        [D(5)]
        public string LIN_05 { get; set; }
        [D(6)]
        public string LIN_06 { get; set; }
        [D(7)]
        public string LIN_07 { get; set; }
        [D(8)]
        public string LIN_08 { get; set; }
        [D(9)]
        public string LIN_09 { get; set; }
        [D(10)]
        public string LIN_10 { get; set; }
        [D(11)]
        public string LIN_11 { get; set; }
        [D(12)]
        public string LIN_12 { get; set; }
        [D(13)]
        public string LIN_13 { get; set; }
        [D(14)]
        public string LIN_14 { get; set; }
        [D(15)]
        public string LIN_15 { get; set; }
        [D(16)]
        public string LIN_16 { get; set; }
        [D(17)]
        public string LIN_17 { get; set; }
        [D(18)]
        public string LIN_18 { get; set; }
        [D(19)]
        public string LIN_19 { get; set; }
        [D(20)]
        public string LIN_20 { get; set; }
        [D(21)]
        public string LIN_21 { get; set; }
        [D(22)]
        public string LIN_22 { get; set; }
        [D(23)]
        public string LIN_23 { get; set; }
        [D(24)]
        public string LIN_24 { get; set; }
        [D(25)]
        public string LIN_25 { get; set; }
        [D(26)]
        public string LIN_26 { get; set; }
        [D(27)]
        public string LIN_27 { get; set; }
        [D(28)]
        public string LIN_28 { get; set; }
        [D(29)]
        public string LIN_29 { get; set; }
        [D(30)]
        public string LIN_30 { get; set; }
        [D(31)]
        public string LIN_31 { get; set; }
    }
    
    public class HCP_LinePricingRepricingInformation_2400
    {
        
        [D(1, "1473")]
        public string PricingMethodology_01 { get; set; }
        [D(2)]
        public string RepricedAllowedAmount_02 { get; set; }
        [D(3)]
        public string RepricedSavingAmount_03 { get; set; }
        [D(4)]
        public string RepricingOrganizationIdentifier_04 { get; set; }
        [D(5)]
        public string RepricingPerDiemOrFlatRateAmount_05 { get; set; }
        [D(6)]
        public string RepricedApprovedAmbulatoryPatientGroupCode_06 { get; set; }
        [D(7)]
        public string RepricedApprovedAmbulatoryPatientGroupAmount_07 { get; set; }
        [D(8)]
        public string HCP_08 { get; set; }
        [D(9, "235")]
        public string ProductOrServiceIDQualifier_09 { get; set; }
        [D(10)]
        public string ProcedureCode_10 { get; set; }
        [D(11, "355")]
        public string UnitOrBasisForMeasurementCode_11 { get; set; }
        [D(12)]
        public string RepricedApprovedServiceUnitCount_12 { get; set; }
        [D(13, "901")]
        public string RejectReasonCode_13 { get; set; }
        [D(14, "1526")]
        public string PolicyComplianceCode_14 { get; set; }
        [D(15, "1527")]
        public string ExceptionCode_15 { get; set; }
    }
    
    public class HSD_HealthCareServicesDelivery_2400
    {
        
        [D(1, "673")]
        public string Visits_01 { get; set; }
        [D(2)]
        public string NumberOfVisits_02 { get; set; }
        [D(3, "355")]
        public string FrequencyPeriod_03 { get; set; }
        [D(4)]
        public string FrequencyCount_04 { get; set; }
        [D(5, "615")]
        public string DurationOfVisitsUnits_05 { get; set; }
        [D(6)]
        public string DurationOfVisitsNumberOfUnits_06 { get; set; }
        [D(7, "678")]
        public string ShipDeliveryOrCalendarPatternCode_07 { get; set; }
        [D(8, "679")]
        public string DeliveryPatternTimeCode_08 { get; set; }
    }
    
    public class PS1_PurchasedServiceInformation_2400
    {
        
        [D(1)]
        public string PurchasedServiceProviderIdentifier_01 { get; set; }
        [D(2)]
        public string PurchasedServiceChargeAmount_02 { get; set; }
        [D(3)]
        public string PS1_03 { get; set; }
    }
    
    public class NTE_LineNote_2400
    {
        
        [D(1, "363")]
        public string NoteReferenceCode_01 { get; set; }
        [D(2)]
        public string LineNoteText_02 { get; set; }
    }
    
    public class K3_FileInformation_2400
    {
        
        [D(1)]
        public string FixedFormatInformation_01 { get; set; }
        [D(2)]
        public string K3_02 { get; set; }
        [D(3)]
        public string K3_03 { get; set; }
    }
    
    public class All_AMT_2400
    {
        
        [S("AMT", 1, typeof(X12_ID_522_All_AMT_2400))]
        public AMT_SalesTaxAmount_2400 AMT_SalesTaxAmount_2400 { get; set; }
        [S("AMT", 2, typeof(X12_ID_522_All_AMT_2400))]
        public AMT_ApprovedAmount_2400 AMT_ApprovedAmount_2400 { get; set; }
        [S("AMT", 3, typeof(X12_ID_522_All_AMT_2400))]
        public AMT_PostageClaimedAmount_2400 AMT_PostageClaimedAmount_2400 { get; set; }
    }
    
    [E(",T,")]
    public class X12_ID_522_All_AMT_2400
    {
    }
    
    public class AMT_PostageClaimedAmount_2400
    {
        
        [D(1, "522")]
        public string AmountQualifierCode_01 { get; set; }
        [D(2)]
        public string PostageClaimedAmount_02 { get; set; }
        [D(3)]
        public string AMT_03 { get; set; }
    }
    
    public class AMT_ApprovedAmount_2400
    {
        
        [D(1, "522")]
        public string AmountQualifierCode_01 { get; set; }
        [D(2)]
        public string ApprovedAmount_02 { get; set; }
        [D(3)]
        public string AMT_03 { get; set; }
    }
    
    public class AMT_SalesTaxAmount_2400
    {
        
        [D(1, "522")]
        public string AmountQualifierCode_01 { get; set; }
        [D(2)]
        public string SalesTaxAmount_02 { get; set; }
        [D(3)]
        public string AMT_03 { get; set; }
    }
    
    public class All_REF_2400
    {
        
        [S("REF", 1, typeof(X12_ID_128_All_REF_2400))]
        public REF_RepricedLineItemReferenceNumber_2400 REF_RepricedLineItemReferenceNumber_2400 { get; set; }
        [S("REF", 2, typeof(X12_ID_128_All_REF_2400))]
        public REF_AdjustedRepricedLineItemReferenceNumber_2400 REF_AdjustedRepricedLineItemReferenceNumber_2400 { get; set; }
        [S("REF", 3, typeof(X12_ID_128_All_REF_2400))]
        public List<REF_PriorAuthorizationOrReferralNumber_2400> REF_PriorAuthorizationOrReferralNumber_2400 { get; set; }
        [S("REF", 4, typeof(X12_ID_128_All_REF_2400))]
        public REF_LineItemControlNumber_2400 REF_LineItemControlNumber_2400 { get; set; }
        [S("REF", 5, typeof(X12_ID_128_All_REF_2400))]
        public REF_MammographyCertificationNumber_2400 REF_MammographyCertificationNumber_2400 { get; set; }
        [S("REF", 6, typeof(X12_ID_128_All_REF_2400))]
        public REF_ClinicalLaboratoryImprovementAmendmentCLIAIdentification_2400 REF_ClinicalLaboratoryImprovementAmendmentCLIAIdentification_2400 { get; set; }
        [S("REF", 7, typeof(X12_ID_128_All_REF_2400))]
        public REF_ReferringClinicalLaboratoryImprovementAmendmentCLIAFacilityIdentification_2400 REF_ReferringClinicalLaboratoryImprovementAmendmentCLIAFacilityIdentification_2400 { get; set; }
        [S("REF", 8, typeof(X12_ID_128_All_REF_2400))]
        public REF_ImmunizationBatchNumber_2400 REF_ImmunizationBatchNumber_2400 { get; set; }
        [S("REF", 9, typeof(X12_ID_128_All_REF_2400))]
        public List<REF_AmbulatoryPatientGroupAPG_2400> REF_AmbulatoryPatientGroupAPG_2400 { get; set; }
        [S("REF", 10, typeof(X12_ID_128_All_REF_2400))]
        public REF_OxygenFlowRate_2400 REF_OxygenFlowRate_2400 { get; set; }
        [S("REF", 11, typeof(X12_ID_128_All_REF_2400))]
        public REF_UniversalProductNumberUPN_2400 REF_UniversalProductNumberUPN_2400 { get; set; }
    }
    
    [E(",9B,")]
    public class X12_ID_128_All_REF_2400
    {
    }
    
    public class REF_UniversalProductNumberUPN_2400
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2)]
        public string UniversalProductNumber_02 { get; set; }
        [D(3)]
        public string REF_03 { get; set; }
        [D(4)]
        public string REF_04 { get; set; }
    }
    
    public class REF_OxygenFlowRate_2400
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2)]
        public string OxygenFlowRate_02 { get; set; }
        [D(3)]
        public string REF_03 { get; set; }
        [D(4)]
        public string REF_04 { get; set; }
    }
    
    public class REF_AmbulatoryPatientGroupAPG_2400
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2)]
        public string AmbulatoryPatientGroupNumber_02 { get; set; }
        [D(3)]
        public string REF_03 { get; set; }
        [D(4)]
        public string REF_04 { get; set; }
    }
    
    public class REF_ImmunizationBatchNumber_2400
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2)]
        public string ImmunizationBatchNumber_02 { get; set; }
        [D(3)]
        public string REF_03 { get; set; }
        [D(4)]
        public string REF_04 { get; set; }
    }
    
    public class REF_ReferringClinicalLaboratoryImprovementAmendmentCLIAFacilityIdentification_2400
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2)]
        public string ReferringCLIANumber_02 { get; set; }
        [D(3)]
        public string REF_03 { get; set; }
        [D(4)]
        public string REF_04 { get; set; }
    }
    
    public class REF_ClinicalLaboratoryImprovementAmendmentCLIAIdentification_2400
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2)]
        public string ClinicalLaboratoryImprovementAmendmentNumber_02 { get; set; }
        [D(3)]
        public string REF_03 { get; set; }
        [D(4)]
        public string REF_04 { get; set; }
    }
    
    public class REF_MammographyCertificationNumber_2400
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2)]
        public string MammographyCertificationNumber_02 { get; set; }
        [D(3)]
        public string REF_03 { get; set; }
        [D(4)]
        public string REF_04 { get; set; }
    }
    
    public class REF_LineItemControlNumber_2400
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2)]
        public string LineItemControlNumber_02 { get; set; }
        [D(3)]
        public string REF_03 { get; set; }
        [D(4)]
        public string REF_04 { get; set; }
    }
    
    public class REF_PriorAuthorizationOrReferralNumber_2400
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2)]
        public string PriorAuthorizationOrReferralNumber_02 { get; set; }
        [D(3)]
        public string REF_03 { get; set; }
        [D(4)]
        public string REF_04 { get; set; }
    }
    
    public class REF_AdjustedRepricedLineItemReferenceNumber_2400
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2)]
        public string AdjustedRepricedLineItemReferenceNumber_02 { get; set; }
        [D(3)]
        public string REF_03 { get; set; }
        [D(4)]
        public string REF_04 { get; set; }
    }
    
    public class REF_RepricedLineItemReferenceNumber_2400
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2)]
        public string RepricedLineItemReferenceNumber_02 { get; set; }
        [D(3)]
        public string REF_03 { get; set; }
        [D(4)]
        public string REF_04 { get; set; }
    }
    
    public class CN1_ContractInformation_2400
    {
        
        [D(1, "1166")]
        public string ContractTypeCode_01 { get; set; }
        [D(2)]
        public string ContractAmount_02 { get; set; }
        [D(3)]
        public string ContractPercentage_03 { get; set; }
        [D(4)]
        public string ContractCode_04 { get; set; }
        [D(5)]
        public string TermsDiscountPercentage_05 { get; set; }
        [D(6)]
        public string ContractVersionIdentifier_06 { get; set; }
    }
    
    public class MEA_TestResult_2400
    {
        
        [D(1, "737")]
        public string MeasurementReferenceIdentificationCode_01 { get; set; }
        [D(2, "738")]
        public string MeasurementQualifier_02 { get; set; }
        [D(3)]
        public string TestResults_03 { get; set; }
        [D(4)]
        public string MEA_04 { get; set; }
        [D(5)]
        public string MEA_05 { get; set; }
        [D(6)]
        public string MEA_06 { get; set; }
        [D(7)]
        public string MEA_07 { get; set; }
        [D(8)]
        public string MEA_08 { get; set; }
        [D(9)]
        public string MEA_09 { get; set; }
        [D(10)]
        public string MEA_10 { get; set; }
    }
    
    public class All_DTP_2400
    {
        
        [S("DTP", 1, typeof(X12_ID_374_All_DTP_2400), typeof(X12_ID_1250_All_DTP_2400))]
        public DTP_DateServiceDate_2400 DTP_DateServiceDate_2400 { get; set; }
        [S("DTP", 2, typeof(X12_ID_374_All_DTP_2400), typeof(X12_ID_1250_All_DTP_2400))]
        public DTP_DateCertificationRevisionDate_2400 DTP_DateCertificationRevisionDate_2400 { get; set; }
        [S("DTP", 3, typeof(X12_ID_374_All_DTP_2400), typeof(X12_ID_1250_All_DTP_2400))]
        public DTP_DateBeginTherapyDate_2400 DTP_DateBeginTherapyDate_2400 { get; set; }
        [S("DTP", 4, typeof(X12_ID_374_All_DTP_2400), typeof(X12_ID_1250_All_DTP_2400))]
        public DTP_DateLastCertificationDate_2400 DTP_DateLastCertificationDate_2400 { get; set; }
        [S("DTP", 5, typeof(X12_ID_374_All_DTP_2400), typeof(X12_ID_1250_All_DTP_2400))]
        public DTP_DateDateLastSeen_2400 DTP_DateDateLastSeen_2400 { get; set; }
        [S("DTP", 6, typeof(X12_ID_374_All_DTP_2400), typeof(X12_ID_1250_All_DTP_2400))]
        public List<DTP_DateTest_2400> DTP_DateTest_2400 { get; set; }
        [S("DTP", 7, typeof(X12_ID_374_All_DTP_2400), typeof(X12_ID_1250_All_DTP_2400))]
        public List<DTP_DateOxygenSaturationArterialBloodGasTest_2400> DTP_DateOxygenSaturationArterialBloodGasTest_2400 { get; set; }
        [S("DTP", 8, typeof(X12_ID_374_All_DTP_2400), typeof(X12_ID_1250_All_DTP_2400))]
        public DTP_DateShipped_2400 DTP_DateShipped_2400 { get; set; }
        [S("DTP", 9, typeof(X12_ID_374_All_DTP_2400), typeof(X12_ID_1250_All_DTP_2400))]
        public DTP_DateOnsetOfCurrentSymptomIllness_2400 DTP_DateOnsetOfCurrentSymptomIllness_2400 { get; set; }
        [S("DTP", 10, typeof(X12_ID_374_All_DTP_2400), typeof(X12_ID_1250_All_DTP_2400))]
        public DTP_DateLastXray_2400 DTP_DateLastXray_2400 { get; set; }
        [S("DTP", 11, typeof(X12_ID_374_All_DTP_2400), typeof(X12_ID_1250_All_DTP_2400))]
        public DTP_DateAcuteManifestation_2400 DTP_DateAcuteManifestation_2400 { get; set; }
        [S("DTP", 12, typeof(X12_ID_374_All_DTP_2400), typeof(X12_ID_1250_All_DTP_2400))]
        public DTP_DateInitialTreatment_2400 DTP_DateInitialTreatment_2400 { get; set; }
        [S("DTP", 13, typeof(X12_ID_374_All_DTP_2400), typeof(X12_ID_1250_All_DTP_2400))]
        public DTP_DateSimilarIllnessSymptomOnset_2400 DTP_DateSimilarIllnessSymptomOnset_2400 { get; set; }
    }
    
    [E(",472,")]
    public class X12_ID_374_All_DTP_2400
    {
    }
    
    [E(",D8,RD8,")]
    public class X12_ID_1250_All_DTP_2400
    {
    }
    
    public class DTP_DateSimilarIllnessSymptomOnset_2400
    {
        
        [D(1, "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3)]
        public string SimilarIllnessOrSymptomDate_03 { get; set; }
    }
    
    public class DTP_DateInitialTreatment_2400
    {
        
        [D(1, "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3)]
        public string InitialTreatmentDate_03 { get; set; }
    }
    
    public class DTP_DateAcuteManifestation_2400
    {
        
        [D(1, "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3)]
        public string AcuteManifestationDate_03 { get; set; }
    }
    
    public class DTP_DateLastXray_2400
    {
        
        [D(1, "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3)]
        public string LastXRayDate_03 { get; set; }
    }
    
    public class DTP_DateOnsetOfCurrentSymptomIllness_2400
    {
        
        [D(1, "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3)]
        public string OnsetDate_03 { get; set; }
    }
    
    public class DTP_DateShipped_2400
    {
        
        [D(1, "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3)]
        public string ShippedDate_03 { get; set; }
    }
    
    public class DTP_DateOxygenSaturationArterialBloodGasTest_2400
    {
        
        [D(1, "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3)]
        public string OxygenSaturationTestDate_03 { get; set; }
    }
    
    public class DTP_DateTest_2400
    {
        
        [D(1, "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3)]
        public string TestPerformedDate_03 { get; set; }
    }
    
    public class DTP_DateDateLastSeen_2400
    {
        
        [D(1, "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3)]
        public string LastSeenDate_03 { get; set; }
    }
    
    public class DTP_DateLastCertificationDate_2400
    {
        
        [D(1, "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3)]
        public string LastCertificationDate_03 { get; set; }
    }
    
    public class DTP_DateBeginTherapyDate_2400
    {
        
        [D(1, "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3)]
        public string BeginTherapyDate_03 { get; set; }
    }
    
    public class DTP_DateCertificationRevisionDate_2400
    {
        
        [D(1, "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3)]
        public string CertificationRevisionDate_03 { get; set; }
    }
    
    public class DTP_DateServiceDate_2400
    {
        
        [D(1, "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3)]
        public string ServiceDate_03 { get; set; }
    }
    
    public class All_CRC_2400
    {
        
        [S("CRC", 1, typeof(X12_ID_1136_All_CRC_2400), typeof(X12_ID_1073_All_CRC_2400))]
        public List<CRC_AmbulanceCertification_2400> CRC_AmbulanceCertification_2400 { get; set; }
        [S("CRC", 2, typeof(X12_ID_1136_All_CRC_2400), typeof(X12_ID_1073_All_CRC_2400))]
        public CRC_HospiceEmployeeIndicator_2400 CRC_HospiceEmployeeIndicator_2400 { get; set; }
        [S("CRC", 3, typeof(X12_ID_1136_All_CRC_2400), typeof(X12_ID_1073_All_CRC_2400))]
        public List<CRC_DMERCConditionIndicator_2400> CRC_DMERCConditionIndicator_2400 { get; set; }
    }
    
    [E(",07,")]
    public class X12_ID_1136_All_CRC_2400
    {
    }
    
    [E(",N,Y,")]
    public class X12_ID_1073_All_CRC_2400
    {
    }
    
    public class CRC_DMERCConditionIndicator_2400
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
    
    public class CRC_HospiceEmployeeIndicator_2400
    {
        
        [D(1, "1136")]
        public string CodeCategory_01 { get; set; }
        [D(2, "1073")]
        public string HospiceEmployedProviderIndicator_02 { get; set; }
        [D(3, "1321")]
        public string ConditionIndicator_03 { get; set; }
        [D(4)]
        public string CRC_04 { get; set; }
        [D(5)]
        public string CRC_05 { get; set; }
        [D(6)]
        public string CRC_06 { get; set; }
        [D(7)]
        public string CRC_07 { get; set; }
    }
    
    public class CRC_AmbulanceCertification_2400
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
    
    public class CR5_HomeOxygenTherapyInformation_2400
    {
        
        [D(1, "1322")]
        public string CertificationTypeCode_01 { get; set; }
        [D(2)]
        public string TreatmentPeriodCount_02 { get; set; }
        [D(3)]
        public string CR5_03 { get; set; }
        [D(4)]
        public string CR5_04 { get; set; }
        [D(5)]
        public string CR5_05 { get; set; }
        [D(6)]
        public string CR5_06 { get; set; }
        [D(7)]
        public string CR5_07 { get; set; }
        [D(8)]
        public string CR5_08 { get; set; }
        [D(9)]
        public string CR5_09 { get; set; }
        [D(10)]
        public string ArterialBloodGasQuantity_10 { get; set; }
        [D(11)]
        public string OxygenSaturationQuantity_11 { get; set; }
        [D(12, "1349")]
        public string OxygenTestConditionCode_12 { get; set; }
        [D(13, "1350")]
        public string OxygenTestFindingsCode_13 { get; set; }
        [D(14, "1350")]
        public string OxygenTestFindingsCode_14 { get; set; }
        [D(15, "1350")]
        public string OxygenTestFindingsCode_15 { get; set; }
        [D(16)]
        public string CR5_16 { get; set; }
        [D(17)]
        public string CR5_17 { get; set; }
        [D(18)]
        public string CR5_18 { get; set; }
    }
    
    public class CR3_DurableMedicalEquipmentCertification_2400
    {
        
        [D(1, "1322")]
        public string CertificationTypeCode_01 { get; set; }
        [D(2, "355")]
        public string UnitOrBasisForMeasurementCode_02 { get; set; }
        [D(3)]
        public string DurableMedicalEquipmentDuration_03 { get; set; }
        [D(4)]
        public string CR3_04 { get; set; }
        [D(5)]
        public string CR3_05 { get; set; }
    }
    
    public class CR2_SpinalManipulationServiceInformation_2400
    {
        
        [D(1)]
        public string CR2_01 { get; set; }
        [D(2)]
        public string CR2_02 { get; set; }
        [D(3)]
        public string CR2_03 { get; set; }
        [D(4)]
        public string CR2_04 { get; set; }
        [D(5)]
        public string CR2_05 { get; set; }
        [D(6)]
        public string CR2_06 { get; set; }
        [D(7)]
        public string CR2_07 { get; set; }
        [D(8, "1342")]
        public string PatientConditionCode_08 { get; set; }
        [D(9)]
        public string CR2_09 { get; set; }
        [D(10)]
        public string PatientConditionDescription_10 { get; set; }
        [D(11)]
        public string PatientConditionDescription_11 { get; set; }
        [D(12, "1073")]
        public string XrayAvailabilityIndicator_12 { get; set; }
    }
    
    public class CR1_AmbulanceTransportInformation_2400
    {
        
        [D(1, "355")]
        public string UnitOrBasisForMeasurementCode_01 { get; set; }
        [D(2)]
        public string PatientWeight_02 { get; set; }
        [D(3, "1316")]
        public string AmbulanceTransportCode_03 { get; set; }
        [D(4, "1317")]
        public string AmbulanceTransportReasonCode_04 { get; set; }
        [D(5, "355")]
        public string UnitOrBasisForMeasurementCode_05 { get; set; }
        [D(6)]
        public string TransportDistance_06 { get; set; }
        [D(7)]
        public string CR1_07 { get; set; }
        [D(8)]
        public string CR1_08 { get; set; }
        [D(9)]
        public string RoundTripPurposeDescription_09 { get; set; }
        [D(10)]
        public string StretcherPurposeDescription_10 { get; set; }
    }
    
    public class PWK_DMERCCMNIndicator_2400
    {
        
        [D(1, "755")]
        public string AttachmentReportTypeCode_01 { get; set; }
        [D(2, "756")]
        public string AttachmentTransmissionCode_02 { get; set; }
        [D(3)]
        public string PWK_03 { get; set; }
        [D(4)]
        public string PWK_04 { get; set; }
        [D(5)]
        public string PWK_05 { get; set; }
        [D(6)]
        public string PWK_06 { get; set; }
        [D(7)]
        public string PWK_07 { get; set; }
        [D(8)]
        public string PWK_08 { get; set; }
        [D(9)]
        public string PWK_09 { get; set; }
    }
    
    public class SV5_DurableMedicalEquipmentService_2400
    {
        
        [C(1)]
        public C003_19141319 C003_19141319 { get; set; }
        [D(2, "355")]
        public string UnitOrBasisForMeasurementCode_02 { get; set; }
        [D(3)]
        public string LengthOfMedicalNecessity_03 { get; set; }
        [D(4)]
        public string DMERentalPrice_04 { get; set; }
        [D(5)]
        public string DMEPurchasePrice_05 { get; set; }
        [D(6, "594")]
        public string RentalUnitPriceIndicator_06 { get; set; }
        [D(7)]
        public string SV5_07 { get; set; }
    }
    
    public class C003_19141319
    {
        
        [D(1, "235")]
        public string ProcedureIdentifier_01 { get; set; }
        [D(2)]
        public string ProcedureCode_02 { get; set; }
        [D(3)]
        public string SV5_03 { get; set; }
        [D(4)]
        public string SV5_04 { get; set; }
        [D(5)]
        public string SV5_05 { get; set; }
        [D(6)]
        public string SV5_06 { get; set; }
        [D(7)]
        public string SV5_07 { get; set; }
    }
    
    public class SV1_ProfessionalService_2400
    {
        
        [C(1)]
        public C003_701728622 C003_701728622 { get; set; }
        [D(2)]
        public string LineItemChargeAmount_02 { get; set; }
        [D(3, "355")]
        public string UnitOrBasisForMeasurementCode_03 { get; set; }
        [D(4)]
        public string ServiceUnitCount_04 { get; set; }
        [D(5)]
        public string PlaceOfServiceCode_05 { get; set; }
        [D(6)]
        public string SV1_06 { get; set; }
        [C(7)]
        public C004_461136328 C004_461136328 { get; set; }
        [D(8)]
        public string SV1_08 { get; set; }
        [D(9, "1073")]
        public string EmergencyIndicator_09 { get; set; }
        [D(10)]
        public string SV1_10 { get; set; }
        [D(11, "1073")]
        public string EPSDTIndicator_11 { get; set; }
        [D(12, "1073")]
        public string FamilyPlanningIndicator_12 { get; set; }
        [D(13)]
        public string SV1_13 { get; set; }
        [D(14)]
        public string SV1_14 { get; set; }
        [D(15, "1327")]
        public string CoPayStatusCode_15 { get; set; }
        [D(16)]
        public string SV1_16 { get; set; }
        [D(17)]
        public string SV1_17 { get; set; }
        [D(18)]
        public string SV1_18 { get; set; }
        [D(19)]
        public string SV1_19 { get; set; }
        [D(20)]
        public string SV1_20 { get; set; }
        [D(21)]
        public string SV1_21 { get; set; }
    }
    
    public class C004_461136328
    {
        
        [D(1)]
        public string DiagnosisCodePointer_01 { get; set; }
        [D(2)]
        public string DiagnosisCodePointer_02 { get; set; }
        [D(3)]
        public string DiagnosisCodePointer_03 { get; set; }
        [D(4)]
        public string DiagnosisCodePointer_04 { get; set; }
    }
    
    public class C003_701728622
    {
        
        [D(1, "235")]
        public string ProductOrServiceIDQualifier_01 { get; set; }
        [D(2)]
        public string ProcedureCode_02 { get; set; }
        [D(3)]
        public string ProcedureModifier_03 { get; set; }
        [D(4)]
        public string ProcedureModifier_04 { get; set; }
        [D(5)]
        public string ProcedureModifier_05 { get; set; }
        [D(6)]
        public string ProcedureModifier_06 { get; set; }
        [D(7)]
        public string SV1_07 { get; set; }
    }
    
    public class LX_ServiceLine_2400
    {
        
        [D(1)]
        public string AssignedNumber_01 { get; set; }
    }
    
    public class Loop_2320
    {
        
        [S("SBR", 1, typeof(X12_ID_1138_Loop_2320), typeof(X12_ID_1069_Loop_2320))]
        public SBR_OtherSubscriberInformation_2320 SBR_OtherSubscriberInformation_2320 { get; set; }
        [S("CAS", 2, typeof(X12_ID_1033_Loop_2320))]
        public List<CAS_ClaimLevelAdjustments_2320> CAS_ClaimLevelAdjustments_2320 { get; set; }
        [A(3)]
        public All_AMT_2320 All_AMT_2320 { get; set; }
        [S("DMG", 4, typeof(X12_ID_1250_Loop_2320))]
        public DMG_SubscriberDemographicInformation_2320 DMG_SubscriberDemographicInformation_2320 { get; set; }
        [S("OI", 5)]
        public OI_OtherInsuranceCoverageInformation_2320 OI_OtherInsuranceCoverageInformation_2320 { get; set; }
        [S("MOA", 6)]
        public MOA_MedicareOutpatientAdjudicationInformation_2320 MOA_MedicareOutpatientAdjudicationInformation_2320 { get; set; }
        [A(7)]
        public All_2330 All_2330 { get; set; }
    }
    
    [E(",P,S,T,")]
    public class X12_ID_1138_Loop_2320
    {
    }
    
    [E(",01,04,05,07,10,15,17,18,19,20,21,22,23,24,29,32,33,36,39,40,41,43,53,G8,")]
    public class X12_ID_1069_Loop_2320
    {
    }
    
    [E(",CO,CR,OA,PI,PR,")]
    public class X12_ID_1033_Loop_2320
    {
    }
    
    [E(",D8,")]
    public class X12_ID_1250_Loop_2320
    {
    }
    
    public class All_2330
    {
        
        [G(1)]
        public Loop_2330A Loop_2330A { get; set; }
        [G(2)]
        public Loop_2330B Loop_2330B { get; set; }
        [G(3)]
        public Loop_2330C Loop_2330C { get; set; }
        [G(4)]
        public List<Loop_2330D> Loop_2330D { get; set; }
        [G(5)]
        public Loop_2330E Loop_2330E { get; set; }
        [G(6)]
        public Loop_2330F Loop_2330F { get; set; }
        [G(7)]
        public Loop_2330G Loop_2330G { get; set; }
        [G(8)]
        public Loop_2330H Loop_2330H { get; set; }
    }
    
    public class Loop_2330H
    {
        
        [S("NM1", 1, typeof(X12_ID_98_Loop_2330H), typeof(X12_ID_1065_Loop_2330H))]
        public NM1_OtherPayerSupervisingProvider_2330H NM1_OtherPayerSupervisingProvider_2330H { get; set; }
        [S("REF", 2, typeof(X12_ID_128_Loop_2330H))]
        public List<REF_OtherPayerSupervisingProviderIdentification_2330H> REF_OtherPayerSupervisingProviderIdentification_2330H { get; set; }
    }
    
    [E(",DQ,")]
    public class X12_ID_98_Loop_2330H
    {
    }
    
    [E(",1,")]
    public class X12_ID_1065_Loop_2330H
    {
    }
    
    [E(",1B,1C,1D,EI,G2,N5,")]
    public class X12_ID_128_Loop_2330H
    {
    }
    
    public class REF_OtherPayerSupervisingProviderIdentification_2330H
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2)]
        public string OtherPayerSupervisingProviderIdentifier_02 { get; set; }
        [D(3)]
        public string REF_03 { get; set; }
        [D(4)]
        public string REF_04 { get; set; }
    }
    
    public class NM1_OtherPayerSupervisingProvider_2330H
    {
        
        [D(1, "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3)]
        public string NM1_03 { get; set; }
        [D(4)]
        public string NM1_04 { get; set; }
        [D(5)]
        public string NM1_05 { get; set; }
        [D(6)]
        public string NM1_06 { get; set; }
        [D(7)]
        public string NM1_07 { get; set; }
        [D(8)]
        public string NM1_08 { get; set; }
        [D(9)]
        public string NM1_09 { get; set; }
        [D(10)]
        public string NM1_10 { get; set; }
        [D(11)]
        public string NM1_11 { get; set; }
    }
    
    public class Loop_2330G
    {
        
        [S("NM1", 1, typeof(X12_ID_98_Loop_2330G), typeof(X12_ID_1065_Loop_2330G))]
        public NM1_OtherPayerServiceFacilityLocation_2330G NM1_OtherPayerServiceFacilityLocation_2330G { get; set; }
        [S("REF", 2, typeof(X12_ID_128_Loop_2330G))]
        public List<REF_OtherPayerServiceFacilityLocationIdentification_2330G> REF_OtherPayerServiceFacilityLocationIdentification_2330G { get; set; }
    }
    
    [E(",77,FA,LI,TL,")]
    public class X12_ID_98_Loop_2330G
    {
    }
    
    [E(",2,")]
    public class X12_ID_1065_Loop_2330G
    {
    }
    
    [E(",1A,1B,1C,1D,G2,LU,N5,")]
    public class X12_ID_128_Loop_2330G
    {
    }
    
    public class REF_OtherPayerServiceFacilityLocationIdentification_2330G
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2)]
        public string OtherPayerServiceFacilityLocationIdentifier_02 { get; set; }
        [D(3)]
        public string REF_03 { get; set; }
        [D(4)]
        public string REF_04 { get; set; }
    }
    
    public class NM1_OtherPayerServiceFacilityLocation_2330G
    {
        
        [D(1, "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3)]
        public string NM1_03 { get; set; }
        [D(4)]
        public string NM1_04 { get; set; }
        [D(5)]
        public string NM1_05 { get; set; }
        [D(6)]
        public string NM1_06 { get; set; }
        [D(7)]
        public string NM1_07 { get; set; }
        [D(8)]
        public string NM1_08 { get; set; }
        [D(9)]
        public string NM1_09 { get; set; }
        [D(10)]
        public string NM1_10 { get; set; }
        [D(11)]
        public string NM1_11 { get; set; }
    }
    
    public class Loop_2330F
    {
        
        [S("NM1", 1, typeof(X12_ID_98_Loop_2330F), typeof(X12_ID_1065_Loop_2330F))]
        public NM1_OtherPayerPurchasedServiceProvider_2330F NM1_OtherPayerPurchasedServiceProvider_2330F { get; set; }
        [S("REF", 2, typeof(X12_ID_128_Loop_2330F))]
        public List<REF_OtherPayerPurchasedServiceProviderIdentification_2330F> REF_OtherPayerPurchasedServiceProviderIdentification_2330F { get; set; }
    }
    
    [E(",QB,")]
    public class X12_ID_98_Loop_2330F
    {
    }
    
    [E(",1,2,")]
    public class X12_ID_1065_Loop_2330F
    {
    }
    
    [E(",1A,1B,1C,1D,EI,G2,LU,N5,")]
    public class X12_ID_128_Loop_2330F
    {
    }
    
    public class REF_OtherPayerPurchasedServiceProviderIdentification_2330F
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2)]
        public string OtherPayerPurchasedServiceProviderIdentifier_02 { get; set; }
        [D(3)]
        public string REF_03 { get; set; }
        [D(4)]
        public string REF_04 { get; set; }
    }
    
    public class NM1_OtherPayerPurchasedServiceProvider_2330F
    {
        
        [D(1, "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3)]
        public string NM1_03 { get; set; }
        [D(4)]
        public string NM1_04 { get; set; }
        [D(5)]
        public string NM1_05 { get; set; }
        [D(6)]
        public string NM1_06 { get; set; }
        [D(7)]
        public string NM1_07 { get; set; }
        [D(8)]
        public string NM1_08 { get; set; }
        [D(9)]
        public string NM1_09 { get; set; }
        [D(10)]
        public string NM1_10 { get; set; }
        [D(11)]
        public string NM1_11 { get; set; }
    }
    
    public class Loop_2330E
    {
        
        [S("NM1", 1, typeof(X12_ID_98_Loop_2330E), typeof(X12_ID_1065_Loop_2330E))]
        public NM1_OtherPayerRenderingProvider_2330E NM1_OtherPayerRenderingProvider_2330E { get; set; }
        [S("REF", 2, typeof(X12_ID_128_Loop_2330E))]
        public List<REF_OtherPayerRenderingProviderSecondaryIdentification_2330E> REF_OtherPayerRenderingProviderSecondaryIdentification_2330E { get; set; }
    }
    
    [E(",82,")]
    public class X12_ID_98_Loop_2330E
    {
    }
    
    [E(",1,2,")]
    public class X12_ID_1065_Loop_2330E
    {
    }
    
    [E(",1B,1C,1D,EI,G2,LU,N5,")]
    public class X12_ID_128_Loop_2330E
    {
    }
    
    public class REF_OtherPayerRenderingProviderSecondaryIdentification_2330E
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2)]
        public string OtherPayerRenderingProviderSecondaryIdentifier_02 { get; set; }
        [D(3)]
        public string REF_03 { get; set; }
        [D(4)]
        public string REF_04 { get; set; }
    }
    
    public class NM1_OtherPayerRenderingProvider_2330E
    {
        
        [D(1, "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3)]
        public string NM1_03 { get; set; }
        [D(4)]
        public string NM1_04 { get; set; }
        [D(5)]
        public string NM1_05 { get; set; }
        [D(6)]
        public string NM1_06 { get; set; }
        [D(7)]
        public string NM1_07 { get; set; }
        [D(8)]
        public string NM1_08 { get; set; }
        [D(9)]
        public string NM1_09 { get; set; }
        [D(10)]
        public string NM1_10 { get; set; }
        [D(11)]
        public string NM1_11 { get; set; }
    }
    
    public class Loop_2330D
    {
        
        [S("NM1", 1, typeof(X12_ID_98_Loop_2330D), typeof(X12_ID_1065_Loop_2330D))]
        public NM1_OtherPayerReferringProvider_2330D NM1_OtherPayerReferringProvider_2330D { get; set; }
        [S("REF", 2, typeof(X12_ID_128_Loop_2330D))]
        public List<REF_OtherPayerReferringProviderIdentification_2330D> REF_OtherPayerReferringProviderIdentification_2330D { get; set; }
    }
    
    [E(",DN,P3,")]
    public class X12_ID_98_Loop_2330D
    {
    }
    
    [E(",1,2,")]
    public class X12_ID_1065_Loop_2330D
    {
    }
    
    [E(",1B,1C,1D,EI,G2,LU,N5,")]
    public class X12_ID_128_Loop_2330D
    {
    }
    
    public class REF_OtherPayerReferringProviderIdentification_2330D
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2)]
        public string OtherPayerReferringProviderIdentifier_02 { get; set; }
        [D(3)]
        public string REF_03 { get; set; }
        [D(4)]
        public string REF_04 { get; set; }
    }
    
    public class NM1_OtherPayerReferringProvider_2330D
    {
        
        [D(1, "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3)]
        public string NM1_03 { get; set; }
        [D(4)]
        public string NM1_04 { get; set; }
        [D(5)]
        public string NM1_05 { get; set; }
        [D(6)]
        public string NM1_06 { get; set; }
        [D(7)]
        public string NM1_07 { get; set; }
        [D(8)]
        public string NM1_08 { get; set; }
        [D(9)]
        public string NM1_09 { get; set; }
        [D(10)]
        public string NM1_10 { get; set; }
        [D(11)]
        public string NM1_11 { get; set; }
    }
    
    public class Loop_2330C
    {
        
        [S("NM1", 1, typeof(X12_ID_98_Loop_2330C), typeof(X12_ID_1065_Loop_2330C))]
        public NM1_OtherPayerPatientInformation_2330C NM1_OtherPayerPatientInformation_2330C { get; set; }
        [S("REF", 2, typeof(X12_ID_128_Loop_2330C))]
        public List<REF_OtherPayerPatientIdentification_2330C> REF_OtherPayerPatientIdentification_2330C { get; set; }
    }
    
    [E(",QC,")]
    public class X12_ID_98_Loop_2330C
    {
    }
    
    [E(",1,")]
    public class X12_ID_1065_Loop_2330C
    {
    }
    
    [E(",1W,23,IG,SY,")]
    public class X12_ID_128_Loop_2330C
    {
    }
    
    public class REF_OtherPayerPatientIdentification_2330C
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2)]
        public string OtherPayerPatientSecondaryIdentifier_02 { get; set; }
        [D(3)]
        public string REF_03 { get; set; }
        [D(4)]
        public string REF_04 { get; set; }
    }
    
    public class NM1_OtherPayerPatientInformation_2330C
    {
        
        [D(1, "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3)]
        public string NM1_03 { get; set; }
        [D(4)]
        public string NM1_04 { get; set; }
        [D(5)]
        public string NM1_05 { get; set; }
        [D(6)]
        public string NM1_06 { get; set; }
        [D(7)]
        public string NM1_07 { get; set; }
        [D(8, "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9)]
        public string OtherPayerPatientPrimaryIdentifier_09 { get; set; }
        [D(10)]
        public string NM1_10 { get; set; }
        [D(11)]
        public string NM1_11 { get; set; }
    }
    
    public class Loop_2330B
    {
        
        [S("NM1", 1, typeof(X12_ID_98_Loop_2330B), typeof(X12_ID_1065_Loop_2330B))]
        public NM1_OtherPayerName_2330B NM1_OtherPayerName_2330B { get; set; }
        [S("PER", 2, typeof(X12_ID_366_Loop_2330B))]
        public List<PER_OtherPayerContactInformation_2330B> PER_OtherPayerContactInformation_2330B { get; set; }
        [S("DTP", 3, typeof(X12_ID_374_Loop_2330B), typeof(X12_ID_1250_Loop_2330B))]
        public DTP_ClaimAdjudicationDate_2330B DTP_ClaimAdjudicationDate_2330B { get; set; }
        [A(4)]
        public All_REF_2330B All_REF_2330B { get; set; }
    }
    
    [E(",PR,")]
    public class X12_ID_98_Loop_2330B
    {
    }
    
    [E(",2,")]
    public class X12_ID_1065_Loop_2330B
    {
    }
    
    [E(",IC,")]
    public class X12_ID_366_Loop_2330B
    {
    }
    
    [E(",573,")]
    public class X12_ID_374_Loop_2330B
    {
    }
    
    [E(",D8,")]
    public class X12_ID_1250_Loop_2330B
    {
    }
    
    public class All_REF_2330B
    {
        
        [S("REF", 1, typeof(X12_ID_128_All_REF_2330B))]
        public List<REF_OtherPayerSecondaryIdentifier_2330B> REF_OtherPayerSecondaryIdentifier_2330B { get; set; }
        [S("REF", 2, typeof(X12_ID_128_All_REF_2330B))]
        public List<REF_OtherPayerPriorAuthorizationOrReferralNumber_2330B> REF_OtherPayerPriorAuthorizationOrReferralNumber_2330B { get; set; }
        [S("REF", 3, typeof(X12_ID_128_All_REF_2330B))]
        public List<REF_OtherPayerClaimAdjustmentIndicator_2330B> REF_OtherPayerClaimAdjustmentIndicator_2330B { get; set; }
    }
    
    [E(",2U,F8,FY,NF,TJ,")]
    public class X12_ID_128_All_REF_2330B
    {
    }
    
    public class REF_OtherPayerClaimAdjustmentIndicator_2330B
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2)]
        public string OtherPayerClaimAdjustmentIndicator_02 { get; set; }
        [D(3)]
        public string REF_03 { get; set; }
        [D(4)]
        public string REF_04 { get; set; }
    }
    
    public class REF_OtherPayerPriorAuthorizationOrReferralNumber_2330B
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2)]
        public string OtherPayerPriorAuthorizationOrReferralNumber_02 { get; set; }
        [D(3)]
        public string REF_03 { get; set; }
        [D(4)]
        public string REF_04 { get; set; }
    }
    
    public class REF_OtherPayerSecondaryIdentifier_2330B
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2)]
        public string OtherPayerSecondaryIdentifier_02 { get; set; }
        [D(3)]
        public string REF_03 { get; set; }
        [D(4)]
        public string REF_04 { get; set; }
    }
    
    public class DTP_ClaimAdjudicationDate_2330B
    {
        
        [D(1, "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3)]
        public string AdjudicationOrPaymentDate_03 { get; set; }
    }
    
    public class PER_OtherPayerContactInformation_2330B
    {
        
        [D(1, "366")]
        public string ContactFunctionCode_01 { get; set; }
        [D(2)]
        public string OtherPayerContactName_02 { get; set; }
        [D(3, "365")]
        public string CommunicationNumberQualifier_03 { get; set; }
        [D(4)]
        public string CommunicationNumber_04 { get; set; }
        [D(5, "365")]
        public string CommunicationNumberQualifier_05 { get; set; }
        [D(6)]
        public string CommunicationNumber_06 { get; set; }
        [D(7, "365")]
        public string CommunicationNumberQualifier_07 { get; set; }
        [D(8)]
        public string CommunicationNumber_08 { get; set; }
        [D(9)]
        public string PER_09 { get; set; }
    }
    
    public class NM1_OtherPayerName_2330B
    {
        
        [D(1, "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3)]
        public string OtherPayerLastOrOrganizationName_03 { get; set; }
        [D(4)]
        public string NM1_04 { get; set; }
        [D(5)]
        public string NM1_05 { get; set; }
        [D(6)]
        public string NM1_06 { get; set; }
        [D(7)]
        public string NM1_07 { get; set; }
        [D(8, "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9)]
        public string OtherPayerPrimaryIdentifier_09 { get; set; }
        [D(10)]
        public string NM1_10 { get; set; }
        [D(11)]
        public string NM1_11 { get; set; }
    }
    
    public class Loop_2330A
    {
        
        [S("NM1", 1, typeof(X12_ID_98_Loop_2330A), typeof(X12_ID_1065_Loop_2330A))]
        public NM1_OtherSubscriberName_2330A NM1_OtherSubscriberName_2330A { get; set; }
        [S("N3", 2)]
        public N3_OtherSubscriberAddress_2330A N3_OtherSubscriberAddress_2330A { get; set; }
        [S("N4", 3)]
        public N4_OtherSubscriberCityStateZIPCode_2330A N4_OtherSubscriberCityStateZIPCode_2330A { get; set; }
        [S("REF", 4, typeof(X12_ID_128_Loop_2330A))]
        public List<REF_OtherSubscriberSecondaryIdentification_2330A> REF_OtherSubscriberSecondaryIdentification_2330A { get; set; }
    }
    
    [E(",IL,")]
    public class X12_ID_98_Loop_2330A
    {
    }
    
    [E(",1,2,")]
    public class X12_ID_1065_Loop_2330A
    {
    }
    
    [E(",1W,23,IG,SY,")]
    public class X12_ID_128_Loop_2330A
    {
    }
    
    public class REF_OtherSubscriberSecondaryIdentification_2330A
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2)]
        public string OtherInsuredAdditionalIdentifier_02 { get; set; }
        [D(3)]
        public string REF_03 { get; set; }
        [D(4)]
        public string REF_04 { get; set; }
    }
    
    public class N4_OtherSubscriberCityStateZIPCode_2330A
    {
        
        [D(1)]
        public string OtherInsuredCityName_01 { get; set; }
        [D(2)]
        public string OtherInsuredStateCode_02 { get; set; }
        [D(3)]
        public string OtherInsuredPostalZoneOrZIPCode_03 { get; set; }
        [D(4)]
        public string CountryCode_04 { get; set; }
        [D(5)]
        public string N4_05 { get; set; }
        [D(6)]
        public string N4_06 { get; set; }
    }
    
    public class N3_OtherSubscriberAddress_2330A
    {
        
        [D(1)]
        public string OtherInsuredAddressLine_01 { get; set; }
        [D(2)]
        public string OtherInsuredAddressLine_02 { get; set; }
    }
    
    public class NM1_OtherSubscriberName_2330A
    {
        
        [D(1, "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3)]
        public string OtherInsuredLastName_03 { get; set; }
        [D(4)]
        public string OtherInsuredFirstName_04 { get; set; }
        [D(5)]
        public string OtherInsuredMiddleName_05 { get; set; }
        [D(6)]
        public string NM1_06 { get; set; }
        [D(7)]
        public string OtherInsuredNameSuffix_07 { get; set; }
        [D(8, "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9)]
        public string OtherInsuredIdentifier_09 { get; set; }
        [D(10)]
        public string NM1_10 { get; set; }
        [D(11)]
        public string NM1_11 { get; set; }
    }
    
    public class MOA_MedicareOutpatientAdjudicationInformation_2320
    {
        
        [D(1)]
        public string ReimbursementRate_01 { get; set; }
        [D(2)]
        public string HCPCSPayableAmount_02 { get; set; }
        [D(3)]
        public string RemarkCode_03 { get; set; }
        [D(4)]
        public string RemarkCode_04 { get; set; }
        [D(5)]
        public string RemarkCode_05 { get; set; }
        [D(6)]
        public string RemarkCode_06 { get; set; }
        [D(7)]
        public string RemarkCode_07 { get; set; }
        [D(8)]
        public string EndStageRenalDiseasePaymentAmount_08 { get; set; }
        [D(9)]
        public string NonPayableProfessionalComponentBilledAmount_09 { get; set; }
    }
    
    public class OI_OtherInsuranceCoverageInformation_2320
    {
        
        [D(1)]
        public string OI_01 { get; set; }
        [D(2)]
        public string OI_02 { get; set; }
        [D(3, "1073")]
        public string BenefitsAssignmentCertificationIndicator_03 { get; set; }
        [D(4, "1351")]
        public string PatientSignatureSourceCode_04 { get; set; }
        [D(5)]
        public string OI_05 { get; set; }
        [D(6, "1363")]
        public string ReleaseOfInformationCode_06 { get; set; }
    }
    
    public class DMG_SubscriberDemographicInformation_2320
    {
        
        [D(1, "1250")]
        public string DateTimePeriodFormatQualifier_01 { get; set; }
        [D(2)]
        public string OtherInsuredBirthDate_02 { get; set; }
        [D(3, "1068")]
        public string OtherInsuredGenderCode_03 { get; set; }
        [D(4)]
        public string DMG_04 { get; set; }
        [D(5)]
        public string DMG_05 { get; set; }
        [D(6)]
        public string DMG_06 { get; set; }
        [D(7)]
        public string DMG_07 { get; set; }
        [D(8)]
        public string DMG_08 { get; set; }
        [D(9)]
        public string DMG_09 { get; set; }
    }
    
    public class All_AMT_2320
    {
        
        [S("AMT", 1, typeof(X12_ID_522_All_AMT_2320))]
        public AMT_CoordinationOfBenefitsCOBPayerPaidAmount_2320 AMT_CoordinationOfBenefitsCOBPayerPaidAmount_2320 { get; set; }
        [S("AMT", 2, typeof(X12_ID_522_All_AMT_2320))]
        public AMT_CoordinationOfBenefitsCOBApprovedAmount_2320 AMT_CoordinationOfBenefitsCOBApprovedAmount_2320 { get; set; }
        [S("AMT", 3, typeof(X12_ID_522_All_AMT_2320))]
        public AMT_CoordinationOfBenefitsCOBAllowedAmount_2320 AMT_CoordinationOfBenefitsCOBAllowedAmount_2320 { get; set; }
        [S("AMT", 4, typeof(X12_ID_522_All_AMT_2320))]
        public AMT_CoordinationOfBenefitsCOBPatientResponsibilityAmount_2320 AMT_CoordinationOfBenefitsCOBPatientResponsibilityAmount_2320 { get; set; }
        [S("AMT", 5, typeof(X12_ID_522_All_AMT_2320))]
        public AMT_CoordinationOfBenefitsCOBCoveredAmount_2320 AMT_CoordinationOfBenefitsCOBCoveredAmount_2320 { get; set; }
        [S("AMT", 6, typeof(X12_ID_522_All_AMT_2320))]
        public AMT_CoordinationOfBenefitsCOBDiscountAmount_2320 AMT_CoordinationOfBenefitsCOBDiscountAmount_2320 { get; set; }
        [S("AMT", 7, typeof(X12_ID_522_All_AMT_2320))]
        public AMT_CoordinationOfBenefitsCOBPerDayLimitAmount_2320 AMT_CoordinationOfBenefitsCOBPerDayLimitAmount_2320 { get; set; }
        [S("AMT", 8, typeof(X12_ID_522_All_AMT_2320))]
        public AMT_CoordinationOfBenefitsCOBPatientPaidAmount_2320 AMT_CoordinationOfBenefitsCOBPatientPaidAmount_2320 { get; set; }
        [S("AMT", 9, typeof(X12_ID_522_All_AMT_2320))]
        public AMT_CoordinationOfBenefitsCOBTaxAmount_2320 AMT_CoordinationOfBenefitsCOBTaxAmount_2320 { get; set; }
        [S("AMT", 10, typeof(X12_ID_522_All_AMT_2320))]
        public AMT_CoordinationOfBenefitsCOBTotalClaimBeforeTaxesAmount_2320 AMT_CoordinationOfBenefitsCOBTotalClaimBeforeTaxesAmount_2320 { get; set; }
    }
    
    [E(",D,")]
    public class X12_ID_522_All_AMT_2320
    {
    }
    
    public class AMT_CoordinationOfBenefitsCOBTotalClaimBeforeTaxesAmount_2320
    {
        
        [D(1, "522")]
        public string AmountQualifierCode_01 { get; set; }
        [D(2)]
        public string OtherPayerPreTaxClaimTotalAmount_02 { get; set; }
        [D(3)]
        public string AMT_03 { get; set; }
    }
    
    public class AMT_CoordinationOfBenefitsCOBTaxAmount_2320
    {
        
        [D(1, "522")]
        public string AmountQualifierCode_01 { get; set; }
        [D(2)]
        public string OtherPayerTaxAmount_02 { get; set; }
        [D(3)]
        public string AMT_03 { get; set; }
    }
    
    public class AMT_CoordinationOfBenefitsCOBPatientPaidAmount_2320
    {
        
        [D(1, "522")]
        public string AmountQualifierCode_01 { get; set; }
        [D(2)]
        public string OtherPayerPatientPaidAmount_02 { get; set; }
        [D(3)]
        public string AMT_03 { get; set; }
    }
    
    public class AMT_CoordinationOfBenefitsCOBPerDayLimitAmount_2320
    {
        
        [D(1, "522")]
        public string AmountQualifierCode_01 { get; set; }
        [D(2)]
        public string OtherPayerPerDayLimitAmount_02 { get; set; }
        [D(3)]
        public string AMT_03 { get; set; }
    }
    
    public class AMT_CoordinationOfBenefitsCOBDiscountAmount_2320
    {
        
        [D(1, "522")]
        public string AmountQualifierCode_01 { get; set; }
        [D(2)]
        public string OtherPayerDiscountAmount_02 { get; set; }
        [D(3)]
        public string AMT_03 { get; set; }
    }
    
    public class AMT_CoordinationOfBenefitsCOBCoveredAmount_2320
    {
        
        [D(1, "522")]
        public string AmountQualifierCode_01 { get; set; }
        [D(2)]
        public string OtherPayerCoveredAmount_02 { get; set; }
        [D(3)]
        public string AMT_03 { get; set; }
    }
    
    public class AMT_CoordinationOfBenefitsCOBPatientResponsibilityAmount_2320
    {
        
        [D(1, "522")]
        public string AmountQualifierCode_01 { get; set; }
        [D(2)]
        public string OtherPayerPatientResponsibilityAmount_02 { get; set; }
        [D(3)]
        public string AMT_03 { get; set; }
    }
    
    public class AMT_CoordinationOfBenefitsCOBAllowedAmount_2320
    {
        
        [D(1, "522")]
        public string AmountQualifierCode_01 { get; set; }
        [D(2)]
        public string AllowedAmount_02 { get; set; }
        [D(3)]
        public string AMT_03 { get; set; }
    }
    
    public class AMT_CoordinationOfBenefitsCOBApprovedAmount_2320
    {
        
        [D(1, "522")]
        public string AmountQualifierCode_01 { get; set; }
        [D(2)]
        public string ApprovedAmount_02 { get; set; }
        [D(3)]
        public string AMT_03 { get; set; }
    }
    
    public class AMT_CoordinationOfBenefitsCOBPayerPaidAmount_2320
    {
        
        [D(1, "522")]
        public string AmountQualifierCode_01 { get; set; }
        [D(2)]
        public string PayerPaidAmount_02 { get; set; }
        [D(3)]
        public string AMT_03 { get; set; }
    }
    
    public class CAS_ClaimLevelAdjustments_2320
    {
        
        [D(1, "1033")]
        public string ClaimAdjustmentGroupCode_01 { get; set; }
        [D(2)]
        public string AdjustmentReasonCode_02 { get; set; }
        [D(3)]
        public string AdjustmentAmount_03 { get; set; }
        [D(4)]
        public string AdjustmentQuantity_04 { get; set; }
        [D(5)]
        public string AdjustmentReasonCode_05 { get; set; }
        [D(6)]
        public string AdjustmentAmount_06 { get; set; }
        [D(7)]
        public string AdjustmentQuantity_07 { get; set; }
        [D(8)]
        public string AdjustmentReasonCode_08 { get; set; }
        [D(9)]
        public string AdjustmentAmount_09 { get; set; }
        [D(10)]
        public string AdjustmentQuantity_10 { get; set; }
        [D(11)]
        public string AdjustmentReasonCode_11 { get; set; }
        [D(12)]
        public string AdjustmentAmount_12 { get; set; }
        [D(13)]
        public string AdjustmentQuantity_13 { get; set; }
        [D(14)]
        public string AdjustmentReasonCode_14 { get; set; }
        [D(15)]
        public string AdjustmentAmount_15 { get; set; }
        [D(16)]
        public string AdjustmentQuantity_16 { get; set; }
        [D(17)]
        public string AdjustmentReasonCode_17 { get; set; }
        [D(18)]
        public string AdjustmentAmount_18 { get; set; }
        [D(19)]
        public string AdjustmentQuantity_19 { get; set; }
    }
    
    public class SBR_OtherSubscriberInformation_2320
    {
        
        [D(1, "1138")]
        public string PayerResponsibilitySequenceNumberCode_01 { get; set; }
        [D(2, "1069")]
        public string IndividualRelationshipCode_02 { get; set; }
        [D(3)]
        public string InsuredGroupOrPolicyNumber_03 { get; set; }
        [D(4)]
        public string OtherInsuredGroupName_04 { get; set; }
        [D(5, "1336")]
        public string InsuranceTypeCode_05 { get; set; }
        [D(6)]
        public string SBR_06 { get; set; }
        [D(7)]
        public string SBR_07 { get; set; }
        [D(8)]
        public string SBR_08 { get; set; }
        [D(9, "1032")]
        public string ClaimFilingIndicatorCode_09 { get; set; }
    }
    
    public class All_2310
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
    }
    
    public class Loop_2310E
    {
        
        [S("NM1", 1, typeof(X12_ID_98_Loop_2310E), typeof(X12_ID_1065_Loop_2310E))]
        public NM1_SupervisingProviderName_2310E NM1_SupervisingProviderName_2310E { get; set; }
        [S("REF", 2, typeof(X12_ID_128_Loop_2310E))]
        public List<REF_SupervisingProviderSecondaryIdentification_2310E> REF_SupervisingProviderSecondaryIdentification_2310E { get; set; }
    }
    
    [E(",DQ,")]
    public class X12_ID_98_Loop_2310E
    {
    }
    
    [E(",1,")]
    public class X12_ID_1065_Loop_2310E
    {
    }
    
    [E(",0B,1B,1C,1D,1G,1H,EI,G2,LU,N5,SY,X5,")]
    public class X12_ID_128_Loop_2310E
    {
    }
    
    public class REF_SupervisingProviderSecondaryIdentification_2310E
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2)]
        public string SupervisingProviderSecondaryIdentifier_02 { get; set; }
        [D(3)]
        public string REF_03 { get; set; }
        [D(4)]
        public string REF_04 { get; set; }
    }
    
    public class NM1_SupervisingProviderName_2310E
    {
        
        [D(1, "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3)]
        public string SupervisingProviderLastName_03 { get; set; }
        [D(4)]
        public string SupervisingProviderFirstName_04 { get; set; }
        [D(5)]
        public string SupervisingProviderMiddleName_05 { get; set; }
        [D(6)]
        public string NM1_06 { get; set; }
        [D(7)]
        public string SupervisingProviderNameSuffix_07 { get; set; }
        [D(8, "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9)]
        public string SupervisingProviderIdentifier_09 { get; set; }
        [D(10)]
        public string NM1_10 { get; set; }
        [D(11)]
        public string NM1_11 { get; set; }
    }
    
    public class Loop_2310D
    {
        
        [S("NM1", 1, typeof(X12_ID_98_Loop_2310D), typeof(X12_ID_1065_Loop_2310D))]
        public NM1_ServiceFacilityLocation_2310D NM1_ServiceFacilityLocation_2310D { get; set; }
        [S("N3", 2)]
        public N3_ServiceFacilityLocationAddress_2310D N3_ServiceFacilityLocationAddress_2310D { get; set; }
        [S("N4", 3)]
        public N4_ServiceFacilityLocationCityStateZIP_2310D N4_ServiceFacilityLocationCityStateZIP_2310D { get; set; }
        [S("REF", 4, typeof(X12_ID_128_Loop_2310D))]
        public List<REF_ServiceFacilityLocationSecondaryIdentification_2310D> REF_ServiceFacilityLocationSecondaryIdentification_2310D { get; set; }
    }
    
    [E(",77,FA,LI,TL,")]
    public class X12_ID_98_Loop_2310D
    {
    }
    
    [E(",2,")]
    public class X12_ID_1065_Loop_2310D
    {
    }
    
    [E(",0B,1A,1B,1C,1D,1G,1H,G2,LU,N5,TJ,X4,X5,")]
    public class X12_ID_128_Loop_2310D
    {
    }
    
    public class REF_ServiceFacilityLocationSecondaryIdentification_2310D
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2)]
        public string LaboratoryOrFacilitySecondaryIdentifier_02 { get; set; }
        [D(3)]
        public string REF_03 { get; set; }
        [D(4)]
        public string REF_04 { get; set; }
    }
    
    public class N4_ServiceFacilityLocationCityStateZIP_2310D
    {
        
        [D(1)]
        public string LaboratoryOrFacilityCityName_01 { get; set; }
        [D(2)]
        public string LaboratoryOrFacilityStateOrProvinceCode_02 { get; set; }
        [D(3)]
        public string LaboratoryOrFacilityPostalZoneOrZIPCode_03 { get; set; }
        [D(4)]
        public string CountryCode_04 { get; set; }
        [D(5)]
        public string N4_05 { get; set; }
        [D(6)]
        public string N4_06 { get; set; }
    }
    
    public class N3_ServiceFacilityLocationAddress_2310D
    {
        
        [D(1)]
        public string LaboratoryOrFacilityAddressLine_01 { get; set; }
        [D(2)]
        public string LaboratoryOrFacilityAddressLine_02 { get; set; }
    }
    
    public class NM1_ServiceFacilityLocation_2310D
    {
        
        [D(1, "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3)]
        public string LaboratoryOrFacilityName_03 { get; set; }
        [D(4)]
        public string NM1_04 { get; set; }
        [D(5)]
        public string NM1_05 { get; set; }
        [D(6)]
        public string NM1_06 { get; set; }
        [D(7)]
        public string NM1_07 { get; set; }
        [D(8, "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9)]
        public string LaboratoryOrFacilityPrimaryIdentifier_09 { get; set; }
        [D(10)]
        public string NM1_10 { get; set; }
        [D(11)]
        public string NM1_11 { get; set; }
    }
    
    public class Loop_2310C
    {
        
        [S("NM1", 1, typeof(X12_ID_98_Loop_2310C), typeof(X12_ID_1065_Loop_2310C))]
        public NM1_PurchasedServiceProviderName_2310C NM1_PurchasedServiceProviderName_2310C { get; set; }
        [S("REF", 2, typeof(X12_ID_128_Loop_2310C))]
        public List<REF_PurchasedServiceProviderSecondaryIdentification_2310C> REF_PurchasedServiceProviderSecondaryIdentification_2310C { get; set; }
    }
    
    [E(",QB,")]
    public class X12_ID_98_Loop_2310C
    {
    }
    
    [E(",1,2,")]
    public class X12_ID_1065_Loop_2310C
    {
    }
    
    [E(",0B,1A,1B,1C,1D,1G,1H,EI,G2,LU,N5,SY,U3,X5,")]
    public class X12_ID_128_Loop_2310C
    {
    }
    
    public class REF_PurchasedServiceProviderSecondaryIdentification_2310C
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2)]
        public string PurchasedServiceProviderSecondaryIdentifier_02 { get; set; }
        [D(3)]
        public string REF_03 { get; set; }
        [D(4)]
        public string REF_04 { get; set; }
    }
    
    public class NM1_PurchasedServiceProviderName_2310C
    {
        
        [D(1, "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3)]
        public string PurchasedServiceProviderLastOrOrganizationName_03 { get; set; }
        [D(4)]
        public string PurchasedServiceProviderFirstName_04 { get; set; }
        [D(5)]
        public string PurchasedServiceProviderMiddleName_05 { get; set; }
        [D(6)]
        public string NM1_06 { get; set; }
        [D(7)]
        public string NM1_07 { get; set; }
        [D(8, "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9)]
        public string PurchasedServiceProviderIdentifier_09 { get; set; }
        [D(10)]
        public string NM1_10 { get; set; }
        [D(11)]
        public string NM1_11 { get; set; }
    }
    
    public class Loop_2310B
    {
        
        [S("NM1", 1, typeof(X12_ID_98_Loop_2310B), typeof(X12_ID_1065_Loop_2310B))]
        public NM1_RenderingProviderName_2310B NM1_RenderingProviderName_2310B { get; set; }
        [S("PRV", 2, typeof(X12_ID_1221_Loop_2310B), typeof(X12_ID_128_Loop_2310B))]
        public PRV_RenderingProviderSpecialtyInformation_2310B PRV_RenderingProviderSpecialtyInformation_2310B { get; set; }
        [S("REF", 3, typeof(X12_ID_128_Loop_2310B))]
        public List<REF_RenderingProviderSecondaryIdentification_2310B> REF_RenderingProviderSecondaryIdentification_2310B { get; set; }
    }
    
    [E(",82,")]
    public class X12_ID_98_Loop_2310B
    {
    }
    
    [E(",1,2,")]
    public class X12_ID_1065_Loop_2310B
    {
    }
    
    [E(",PE,")]
    public class X12_ID_1221_Loop_2310B
    {
    }
    
    [E(",ZZ,")]
    public class X12_ID_128_Loop_2310B
    {
    }
    
    public class REF_RenderingProviderSecondaryIdentification_2310B
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2)]
        public string RenderingProviderSecondaryIdentifier_02 { get; set; }
        [D(3)]
        public string REF_03 { get; set; }
        [D(4)]
        public string REF_04 { get; set; }
    }
    
    public class PRV_RenderingProviderSpecialtyInformation_2310B
    {
        
        [D(1, "1221")]
        public string ProviderCode_01 { get; set; }
        [D(2, "128")]
        public string ReferenceIdentificationQualifier_02 { get; set; }
        [D(3)]
        public string ProviderTaxonomyCode_03 { get; set; }
        [D(4)]
        public string PRV_04 { get; set; }
        [D(5)]
        public string PRV_05 { get; set; }
        [D(6)]
        public string PRV_06 { get; set; }
    }
    
    public class NM1_RenderingProviderName_2310B
    {
        
        [D(1, "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3)]
        public string RenderingProviderLastOrOrganizationName_03 { get; set; }
        [D(4)]
        public string RenderingProviderFirstName_04 { get; set; }
        [D(5)]
        public string RenderingProviderMiddleName_05 { get; set; }
        [D(6)]
        public string NM1_06 { get; set; }
        [D(7)]
        public string RenderingProviderNameSuffix_07 { get; set; }
        [D(8, "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9)]
        public string RenderingProviderIdentifier_09 { get; set; }
        [D(10)]
        public string NM1_10 { get; set; }
        [D(11)]
        public string NM1_11 { get; set; }
    }
    
    public class Loop_2310A
    {
        
        [S("NM1", 1, typeof(X12_ID_98_Loop_2310A), typeof(X12_ID_1065_Loop_2310A))]
        public NM1_ReferringProviderName_2310A NM1_ReferringProviderName_2310A { get; set; }
        [S("PRV", 2, typeof(X12_ID_1221_Loop_2310A), typeof(X12_ID_128_Loop_2310A))]
        public PRV_ReferringProviderSpecialtyInformation_2310A PRV_ReferringProviderSpecialtyInformation_2310A { get; set; }
        [S("REF", 3, typeof(X12_ID_128_Loop_2310A))]
        public List<REF_ReferringProviderSecondaryIdentification_2310A> REF_ReferringProviderSecondaryIdentification_2310A { get; set; }
    }
    
    [E(",DN,P3,")]
    public class X12_ID_98_Loop_2310A
    {
    }
    
    [E(",1,2,")]
    public class X12_ID_1065_Loop_2310A
    {
    }
    
    [E(",RF,")]
    public class X12_ID_1221_Loop_2310A
    {
    }
    
    [E(",ZZ,")]
    public class X12_ID_128_Loop_2310A
    {
    }
    
    public class REF_ReferringProviderSecondaryIdentification_2310A
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2)]
        public string ReferringProviderSecondaryIdentifier_02 { get; set; }
        [D(3)]
        public string REF_03 { get; set; }
        [D(4)]
        public string REF_04 { get; set; }
    }
    
    public class PRV_ReferringProviderSpecialtyInformation_2310A
    {
        
        [D(1, "1221")]
        public string ProviderCode_01 { get; set; }
        [D(2, "128")]
        public string ReferenceIdentificationQualifier_02 { get; set; }
        [D(3)]
        public string ProviderTaxonomyCode_03 { get; set; }
        [D(4)]
        public string PRV_04 { get; set; }
        [D(5)]
        public string PRV_05 { get; set; }
        [D(6)]
        public string PRV_06 { get; set; }
    }
    
    public class NM1_ReferringProviderName_2310A
    {
        
        [D(1, "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3)]
        public string ReferringProviderLastName_03 { get; set; }
        [D(4)]
        public string ReferringProviderFirstName_04 { get; set; }
        [D(5)]
        public string ReferringProviderMiddleName_05 { get; set; }
        [D(6)]
        public string NM1_06 { get; set; }
        [D(7)]
        public string ReferringProviderNameSuffix_07 { get; set; }
        [D(8, "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9)]
        public string ReferringProviderIdentifier_09 { get; set; }
        [D(10)]
        public string NM1_10 { get; set; }
        [D(11)]
        public string NM1_11 { get; set; }
    }
    
    public class Loop_2305
    {
        
        [S("CR7", 1, typeof(X12_ID_921_Loop_2305))]
        public CR7_HomeHealthCarePlanInformation_2305 CR7_HomeHealthCarePlanInformation_2305 { get; set; }
        [S("HSD", 2, typeof(X12_ID_673_Loop_2305))]
        public List<HSD_HealthCareServicesDelivery_2305> HSD_HealthCareServicesDelivery_2305 { get; set; }
    }
    
    [E(",AI,MS,OT,PT,SN,ST,")]
    public class X12_ID_921_Loop_2305
    {
    }
    
    [E(",VS,")]
    public class X12_ID_673_Loop_2305
    {
    }
    
    public class HSD_HealthCareServicesDelivery_2305
    {
        
        [D(1, "673")]
        public string Visits_01 { get; set; }
        [D(2)]
        public string NumberOfVisits_02 { get; set; }
        [D(3, "355")]
        public string FrequencyPeriod_03 { get; set; }
        [D(4)]
        public string FrequencyCount_04 { get; set; }
        [D(5, "615")]
        public string DurationOfVisitsUnits_05 { get; set; }
        [D(6)]
        public string DurationOfVisitsNumberOfUnits_06 { get; set; }
        [D(7, "678")]
        public string ShipDeliveryOrCalendarPatternCode_07 { get; set; }
        [D(8, "679")]
        public string DeliveryPatternTimeCode_08 { get; set; }
    }
    
    public class CR7_HomeHealthCarePlanInformation_2305
    {
        
        [D(1, "921")]
        public string DisciplineTypeCode_01 { get; set; }
        [D(2)]
        public string TotalVisitsRenderedCount_02 { get; set; }
        [D(3)]
        public string CertificationPeriodProjectedVisitCount_03 { get; set; }
    }
    
    public class HCP_ClaimPricingRepricingInformation_2300
    {
        
        [D(1, "1473")]
        public string PricingMethodology_01 { get; set; }
        [D(2)]
        public string RepricedAllowedAmount_02 { get; set; }
        [D(3)]
        public string RepricedSavingAmount_03 { get; set; }
        [D(4)]
        public string RepricingOrganizationIdentifier_04 { get; set; }
        [D(5)]
        public string RepricingPerDiemOrFlatRateAmount_05 { get; set; }
        [D(6)]
        public string RepricedApprovedAmbulatoryPatientGroupCode_06 { get; set; }
        [D(7)]
        public string RepricedApprovedAmbulatoryPatientGroupAmount_07 { get; set; }
        [D(8)]
        public string HCP_08 { get; set; }
        [D(9)]
        public string HCP_09 { get; set; }
        [D(10)]
        public string HCP_10 { get; set; }
        [D(11)]
        public string HCP_11 { get; set; }
        [D(12)]
        public string HCP_12 { get; set; }
        [D(13, "901")]
        public string RejectReasonCode_13 { get; set; }
        [D(14, "1526")]
        public string PolicyComplianceCode_14 { get; set; }
        [D(15, "1527")]
        public string ExceptionCode_15 { get; set; }
    }
    
    public class HI_HealthCareDiagnosisCode_2300
    {
        
        [C(1)]
        public C022_57917336 C022_57917336 { get; set; }
        [C(2)]
        public C022_1220782286 C022_1220782286 { get; set; }
        [C(3)]
        public C022_1577012646 C022_1577012646 { get; set; }
        [C(4)]
        public C022_2026368300 C022_2026368300 { get; set; }
        [C(5)]
        public C022_1105734046 C022_1105734046 { get; set; }
        [C(6)]
        public C022_57524121 C022_57524121 { get; set; }
        [C(7)]
        public C022_1220389071 C022_1220389071 { get; set; }
        [C(8)]
        public C022_1576619431 C022_1576619431 { get; set; }
        [D(9)]
        public string HI_09 { get; set; }
        [D(10)]
        public string HI_10 { get; set; }
        [D(11)]
        public string HI_11 { get; set; }
        [D(12)]
        public string HI_12 { get; set; }
    }
    
    public class C022_1576619431
    {
        
        [D(1, "1270")]
        public string DiagnosisTypeCode_01 { get; set; }
        [D(2)]
        public string DiagnosisCode_02 { get; set; }
        [D(3)]
        public string HI_03 { get; set; }
        [D(4)]
        public string HI_04 { get; set; }
        [D(5)]
        public string HI_05 { get; set; }
        [D(6)]
        public string HI_06 { get; set; }
        [D(7)]
        public string HI_07 { get; set; }
    }
    
    public class C022_1220389071
    {
        
        [D(1, "1270")]
        public string DiagnosisTypeCode_01 { get; set; }
        [D(2)]
        public string DiagnosisCode_02 { get; set; }
        [D(3)]
        public string HI_03 { get; set; }
        [D(4)]
        public string HI_04 { get; set; }
        [D(5)]
        public string HI_05 { get; set; }
        [D(6)]
        public string HI_06 { get; set; }
        [D(7)]
        public string HI_07 { get; set; }
    }
    
    public class C022_57524121
    {
        
        [D(1, "1270")]
        public string DiagnosisTypeCode_01 { get; set; }
        [D(2)]
        public string DiagnosisCode_02 { get; set; }
        [D(3)]
        public string HI_03 { get; set; }
        [D(4)]
        public string HI_04 { get; set; }
        [D(5)]
        public string HI_05 { get; set; }
        [D(6)]
        public string HI_06 { get; set; }
        [D(7)]
        public string HI_07 { get; set; }
    }
    
    public class C022_1105734046
    {
        
        [D(1, "1270")]
        public string DiagnosisTypeCode_01 { get; set; }
        [D(2)]
        public string DiagnosisCode_02 { get; set; }
        [D(3)]
        public string HI_03 { get; set; }
        [D(4)]
        public string HI_04 { get; set; }
        [D(5)]
        public string HI_05 { get; set; }
        [D(6)]
        public string HI_06 { get; set; }
        [D(7)]
        public string HI_07 { get; set; }
    }
    
    public class C022_2026368300
    {
        
        [D(1, "1270")]
        public string DiagnosisTypeCode_01 { get; set; }
        [D(2)]
        public string DiagnosisCode_02 { get; set; }
        [D(3)]
        public string HI_03 { get; set; }
        [D(4)]
        public string HI_04 { get; set; }
        [D(5)]
        public string HI_05 { get; set; }
        [D(6)]
        public string HI_06 { get; set; }
        [D(7)]
        public string HI_07 { get; set; }
    }
    
    public class C022_1577012646
    {
        
        [D(1, "1270")]
        public string DiagnosisTypeCode_01 { get; set; }
        [D(2)]
        public string DiagnosisCode_02 { get; set; }
        [D(3)]
        public string HI_03 { get; set; }
        [D(4)]
        public string HI_04 { get; set; }
        [D(5)]
        public string HI_05 { get; set; }
        [D(6)]
        public string HI_06 { get; set; }
        [D(7)]
        public string HI_07 { get; set; }
    }
    
    public class C022_1220782286
    {
        
        [D(1, "1270")]
        public string DiagnosisTypeCode_01 { get; set; }
        [D(2)]
        public string DiagnosisCode_02 { get; set; }
        [D(3)]
        public string HI_03 { get; set; }
        [D(4)]
        public string HI_04 { get; set; }
        [D(5)]
        public string HI_05 { get; set; }
        [D(6)]
        public string HI_06 { get; set; }
        [D(7)]
        public string HI_07 { get; set; }
    }
    
    public class C022_57917336
    {
        
        [D(1, "1270")]
        public string DiagnosisTypeCode_01 { get; set; }
        [D(2)]
        public string DiagnosisCode_02 { get; set; }
        [D(3)]
        public string HI_03 { get; set; }
        [D(4)]
        public string HI_04 { get; set; }
        [D(5)]
        public string HI_05 { get; set; }
        [D(6)]
        public string HI_06 { get; set; }
        [D(7)]
        public string HI_07 { get; set; }
    }
    
    public class All_CRC_2300
    {
        
        [S("CRC", 1, typeof(X12_ID_1136_All_CRC_2300), typeof(X12_ID_1073_All_CRC_2300))]
        public List<CRC_AmbulanceCertification_2300> CRC_AmbulanceCertification_2300 { get; set; }
        [S("CRC", 2, typeof(X12_ID_1136_All_CRC_2300), typeof(X12_ID_1073_All_CRC_2300))]
        public List<CRC_PatientConditionInformationVision_2300> CRC_PatientConditionInformationVision_2300 { get; set; }
        [S("CRC", 3, typeof(X12_ID_1136_All_CRC_2300), typeof(X12_ID_1073_All_CRC_2300))]
        public CRC_HomeboundIndicator_2300 CRC_HomeboundIndicator_2300 { get; set; }
        [S("CRC", 4, typeof(X12_ID_1136_All_CRC_2300), typeof(X12_ID_1073_All_CRC_2300))]
        public CRC_EPSDTReferral_2300 CRC_EPSDTReferral_2300 { get; set; }
    }
    
    [E(",07,")]
    public class X12_ID_1136_All_CRC_2300
    {
    }
    
    [E(",N,Y,")]
    public class X12_ID_1073_All_CRC_2300
    {
    }
    
    public class CRC_EPSDTReferral_2300
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
        [D(6)]
        public string CRC_06 { get; set; }
        [D(7)]
        public string CRC_07 { get; set; }
    }
    
    public class CRC_HomeboundIndicator_2300
    {
        
        [D(1, "1136")]
        public string CodeCategory_01 { get; set; }
        [D(2, "1073")]
        public string CertificationConditionIndicator_02 { get; set; }
        [D(3, "1321")]
        public string HomeboundIndicator_03 { get; set; }
        [D(4)]
        public string CRC_04 { get; set; }
        [D(5)]
        public string CRC_05 { get; set; }
        [D(6)]
        public string CRC_06 { get; set; }
        [D(7)]
        public string CRC_07 { get; set; }
    }
    
    public class CRC_PatientConditionInformationVision_2300
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
    
    public class CRC_AmbulanceCertification_2300
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
    
    public class CR2_SpinalManipulationServiceInformation_2300
    {
        
        [D(1)]
        public string CR2_01 { get; set; }
        [D(2)]
        public string CR2_02 { get; set; }
        [D(3)]
        public string CR2_03 { get; set; }
        [D(4)]
        public string CR2_04 { get; set; }
        [D(5)]
        public string CR2_05 { get; set; }
        [D(6)]
        public string CR2_06 { get; set; }
        [D(7)]
        public string CR2_07 { get; set; }
        [D(8, "1342")]
        public string PatientConditionCode_08 { get; set; }
        [D(9)]
        public string CR2_09 { get; set; }
        [D(10)]
        public string PatientConditionDescription_10 { get; set; }
        [D(11)]
        public string PatientConditionDescription_11 { get; set; }
        [D(12, "1073")]
        public string XrayAvailabilityIndicator_12 { get; set; }
    }
    
    public class CR1_AmbulanceTransportInformation_2300
    {
        
        [D(1, "355")]
        public string UnitOrBasisForMeasurementCode_01 { get; set; }
        [D(2)]
        public string PatientWeight_02 { get; set; }
        [D(3, "1316")]
        public string AmbulanceTransportCode_03 { get; set; }
        [D(4, "1317")]
        public string AmbulanceTransportReasonCode_04 { get; set; }
        [D(5, "355")]
        public string UnitOrBasisForMeasurementCode_05 { get; set; }
        [D(6)]
        public string TransportDistance_06 { get; set; }
        [D(7)]
        public string CR1_07 { get; set; }
        [D(8)]
        public string CR1_08 { get; set; }
        [D(9)]
        public string RoundTripPurposeDescription_09 { get; set; }
        [D(10)]
        public string StretcherPurposeDescription_10 { get; set; }
    }
    
    public class NTE_ClaimNote_2300
    {
        
        [D(1, "363")]
        public string NoteReferenceCode_01 { get; set; }
        [D(2)]
        public string ClaimNoteText_02 { get; set; }
    }
    
    public class K3_FileInformation_2300
    {
        
        [D(1)]
        public string FixedFormatInformation_01 { get; set; }
        [D(2)]
        public string K3_02 { get; set; }
        [D(3)]
        public string K3_03 { get; set; }
    }
    
    public class All_REF_2300
    {
        
        [S("REF", 1, typeof(X12_ID_128_All_REF_2300))]
        public REF_ServiceAuthorizationExceptionCode_2300 REF_ServiceAuthorizationExceptionCode_2300 { get; set; }
        [S("REF", 2, typeof(X12_ID_128_All_REF_2300))]
        public REF_MandatoryMedicareSection4081CrossoverIndicator_2300 REF_MandatoryMedicareSection4081CrossoverIndicator_2300 { get; set; }
        [S("REF", 3, typeof(X12_ID_128_All_REF_2300))]
        public REF_MammographyCertificationNumber_2300 REF_MammographyCertificationNumber_2300 { get; set; }
        [S("REF", 4, typeof(X12_ID_128_All_REF_2300))]
        public List<REF_PriorAuthorizationOrReferralNumber_2300> REF_PriorAuthorizationOrReferralNumber_2300 { get; set; }
        [S("REF", 5, typeof(X12_ID_128_All_REF_2300))]
        public REF_OriginalReferenceNumberICNDCN_2300 REF_OriginalReferenceNumberICNDCN_2300 { get; set; }
        [S("REF", 6, typeof(X12_ID_128_All_REF_2300))]
        public List<REF_ClinicalLaboratoryImprovementAmendmentCLIANumber_2300> REF_ClinicalLaboratoryImprovementAmendmentCLIANumber_2300 { get; set; }
        [S("REF", 7, typeof(X12_ID_128_All_REF_2300))]
        public REF_RepricedClaimNumber_2300 REF_RepricedClaimNumber_2300 { get; set; }
        [S("REF", 8, typeof(X12_ID_128_All_REF_2300))]
        public REF_AdjustedRepricedClaimNumber_2300 REF_AdjustedRepricedClaimNumber_2300 { get; set; }
        [S("REF", 9, typeof(X12_ID_128_All_REF_2300))]
        public REF_InvestigationalDeviceExemptionNumber_2300 REF_InvestigationalDeviceExemptionNumber_2300 { get; set; }
        [S("REF", 10, typeof(X12_ID_128_All_REF_2300))]
        public REF_ClaimIdentificationNumberForClearingHousesAndOtherTransmissionIntermediaries_2300 REF_ClaimIdentificationNumberForClearingHousesAndOtherTransmissionIntermediaries_2300 { get; set; }
        [S("REF", 11, typeof(X12_ID_128_All_REF_2300))]
        public List<REF_AmbulatoryPatientGroupAPG_2300> REF_AmbulatoryPatientGroupAPG_2300 { get; set; }
        [S("REF", 12, typeof(X12_ID_128_All_REF_2300))]
        public REF_MedicalRecordNumber_2300 REF_MedicalRecordNumber_2300 { get; set; }
        [S("REF", 13, typeof(X12_ID_128_All_REF_2300))]
        public REF_DemonstrationProjectIdentifier_2300 REF_DemonstrationProjectIdentifier_2300 { get; set; }
    }
    
    [E(",4N,")]
    public class X12_ID_128_All_REF_2300
    {
    }
    
    public class REF_DemonstrationProjectIdentifier_2300
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2)]
        public string DemonstrationProjectIdentifier_02 { get; set; }
        [D(3)]
        public string REF_03 { get; set; }
        [D(4)]
        public string REF_04 { get; set; }
    }
    
    public class REF_MedicalRecordNumber_2300
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2)]
        public string MedicalRecordNumber_02 { get; set; }
        [D(3)]
        public string REF_03 { get; set; }
        [D(4)]
        public string REF_04 { get; set; }
    }
    
    public class REF_AmbulatoryPatientGroupAPG_2300
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2)]
        public string AmbulatoryPatientGroupNumber_02 { get; set; }
        [D(3)]
        public string REF_03 { get; set; }
        [D(4)]
        public string REF_04 { get; set; }
    }
    
    public class REF_ClaimIdentificationNumberForClearingHousesAndOtherTransmissionIntermediaries_2300
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2)]
        public string ClearinghouseTraceNumber_02 { get; set; }
        [D(3)]
        public string REF_03 { get; set; }
        [D(4)]
        public string REF_04 { get; set; }
    }
    
    public class REF_InvestigationalDeviceExemptionNumber_2300
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2)]
        public string InvestigationalDeviceExemptionIdentifier_02 { get; set; }
        [D(3)]
        public string REF_03 { get; set; }
        [D(4)]
        public string REF_04 { get; set; }
    }
    
    public class REF_AdjustedRepricedClaimNumber_2300
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2)]
        public string AdjustedRepricedClaimReferenceNumber_02 { get; set; }
        [D(3)]
        public string REF_03 { get; set; }
        [D(4)]
        public string REF_04 { get; set; }
    }
    
    public class REF_RepricedClaimNumber_2300
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2)]
        public string RepricedClaimReferenceNumber_02 { get; set; }
        [D(3)]
        public string REF_03 { get; set; }
        [D(4)]
        public string REF_04 { get; set; }
    }
    
    public class REF_ClinicalLaboratoryImprovementAmendmentCLIANumber_2300
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2)]
        public string ClinicalLaboratoryImprovementAmendmentNumber_02 { get; set; }
        [D(3)]
        public string REF_03 { get; set; }
        [D(4)]
        public string REF_04 { get; set; }
    }
    
    public class REF_OriginalReferenceNumberICNDCN_2300
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2)]
        public string ClaimOriginalReferenceNumber_02 { get; set; }
        [D(3)]
        public string REF_03 { get; set; }
        [D(4)]
        public string REF_04 { get; set; }
    }
    
    public class REF_PriorAuthorizationOrReferralNumber_2300
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2)]
        public string PriorAuthorizationOrReferralNumber_02 { get; set; }
        [D(3)]
        public string REF_03 { get; set; }
        [D(4)]
        public string REF_04 { get; set; }
    }
    
    public class REF_MammographyCertificationNumber_2300
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2)]
        public string MammographyCertificationNumber_02 { get; set; }
        [D(3)]
        public string REF_03 { get; set; }
        [D(4)]
        public string REF_04 { get; set; }
    }
    
    public class REF_MandatoryMedicareSection4081CrossoverIndicator_2300
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2)]
        public string MedicareSection4081Indicator_02 { get; set; }
        [D(3)]
        public string REF_03 { get; set; }
        [D(4)]
        public string REF_04 { get; set; }
    }
    
    public class REF_ServiceAuthorizationExceptionCode_2300
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2)]
        public string ServiceAuthorizationExceptionCode_02 { get; set; }
        [D(3)]
        public string REF_03 { get; set; }
        [D(4)]
        public string REF_04 { get; set; }
    }
    
    public class All_AMT_2300
    {
        
        [S("AMT", 1, typeof(X12_ID_522_All_AMT_2300))]
        public AMT_CreditDebitCardMaximumAmount_2300 AMT_CreditDebitCardMaximumAmount_2300 { get; set; }
        [S("AMT", 2, typeof(X12_ID_522_All_AMT_2300))]
        public AMT_PatientAmountPaid_2300 AMT_PatientAmountPaid_2300 { get; set; }
        [S("AMT", 3, typeof(X12_ID_522_All_AMT_2300))]
        public AMT_TotalPurchasedServiceAmount_2300 AMT_TotalPurchasedServiceAmount_2300 { get; set; }
    }
    
    [E(",MA,")]
    public class X12_ID_522_All_AMT_2300
    {
    }
    
    public class AMT_TotalPurchasedServiceAmount_2300
    {
        
        [D(1, "522")]
        public string AmountQualifierCode_01 { get; set; }
        [D(2)]
        public string TotalPurchasedServiceAmount_02 { get; set; }
        [D(3)]
        public string AMT_03 { get; set; }
    }
    
    public class AMT_PatientAmountPaid_2300
    {
        
        [D(1, "522")]
        public string AmountQualifierCode_01 { get; set; }
        [D(2)]
        public string PatientAmountPaid_02 { get; set; }
        [D(3)]
        public string AMT_03 { get; set; }
    }
    
    public class AMT_CreditDebitCardMaximumAmount_2300
    {
        
        [D(1, "522")]
        public string AmountQualifierCode_01 { get; set; }
        [D(2)]
        public string CreditOrDebitCardMaximumAmount_02 { get; set; }
        [D(3)]
        public string AMT_03 { get; set; }
    }
    
    public class CN1_ContractInformation_2300
    {
        
        [D(1, "1166")]
        public string ContractTypeCode_01 { get; set; }
        [D(2)]
        public string ContractAmount_02 { get; set; }
        [D(3)]
        public string ContractPercentage_03 { get; set; }
        [D(4)]
        public string ContractCode_04 { get; set; }
        [D(5)]
        public string TermsDiscountPercentage_05 { get; set; }
        [D(6)]
        public string ContractVersionIdentifier_06 { get; set; }
    }
    
    public class PWK_ClaimSupplementalInformation_2300
    {
        
        [D(1, "755")]
        public string AttachmentReportTypeCode_01 { get; set; }
        [D(2, "756")]
        public string AttachmentTransmissionCode_02 { get; set; }
        [D(3)]
        public string PWK_03 { get; set; }
        [D(4)]
        public string PWK_04 { get; set; }
        [D(5, "66")]
        public string IdentificationCodeQualifier_05 { get; set; }
        [D(6)]
        public string AttachmentControlNumber_06 { get; set; }
        [D(7)]
        public string PWK_07 { get; set; }
        [D(8)]
        public string PWK_08 { get; set; }
        [D(9)]
        public string PWK_09 { get; set; }
    }
    
    public class All_DTP_2300
    {
        
        [S("DTP", 1, typeof(X12_ID_374_All_DTP_2300), typeof(X12_ID_1250_All_DTP_2300))]
        public DTP_DateInitialTreatment_2300 DTP_DateInitialTreatment_2300 { get; set; }
        [S("DTP", 2, typeof(X12_ID_374_All_DTP_2300), typeof(X12_ID_1250_All_DTP_2300))]
        public DTP_DateDateLastSeen_2300 DTP_DateDateLastSeen_2300 { get; set; }
        [S("DTP", 3, typeof(X12_ID_374_All_DTP_2300), typeof(X12_ID_1250_All_DTP_2300))]
        public DTP_DateOnsetOfCurrentIllnessSymptom_2300 DTP_DateOnsetOfCurrentIllnessSymptom_2300 { get; set; }
        [S("DTP", 4, typeof(X12_ID_374_All_DTP_2300), typeof(X12_ID_1250_All_DTP_2300))]
        public List<DTP_DateAcuteManifestation_2300> DTP_DateAcuteManifestation_2300 { get; set; }
        [S("DTP", 5, typeof(X12_ID_374_All_DTP_2300), typeof(X12_ID_1250_All_DTP_2300))]
        public List<DTP_DateSimilarIllnessSymptomOnset_2300> DTP_DateSimilarIllnessSymptomOnset_2300 { get; set; }
        [S("DTP", 6, typeof(X12_ID_374_All_DTP_2300), typeof(X12_ID_1250_All_DTP_2300))]
        public List<DTP_DateAccident_2300> DTP_DateAccident_2300 { get; set; }
        [S("DTP", 7, typeof(X12_ID_374_All_DTP_2300), typeof(X12_ID_1250_All_DTP_2300))]
        public DTP_DateLastMenstrualPeriod_2300 DTP_DateLastMenstrualPeriod_2300 { get; set; }
        [S("DTP", 8, typeof(X12_ID_374_All_DTP_2300), typeof(X12_ID_1250_All_DTP_2300))]
        public DTP_DateLastXray_2300 DTP_DateLastXray_2300 { get; set; }
        [S("DTP", 9, typeof(X12_ID_374_All_DTP_2300), typeof(X12_ID_1250_All_DTP_2300))]
        public DTP_DateHearingAndVisionPrescriptionDate_2300 DTP_DateHearingAndVisionPrescriptionDate_2300 { get; set; }
        [S("DTP", 10, typeof(X12_ID_374_All_DTP_2300), typeof(X12_ID_1250_All_DTP_2300))]
        public List<DTP_DateDisabilityBegin_2300> DTP_DateDisabilityBegin_2300 { get; set; }
        [S("DTP", 11, typeof(X12_ID_374_All_DTP_2300), typeof(X12_ID_1250_All_DTP_2300))]
        public List<DTP_DateDisabilityEnd_2300> DTP_DateDisabilityEnd_2300 { get; set; }
        [S("DTP", 12, typeof(X12_ID_374_All_DTP_2300), typeof(X12_ID_1250_All_DTP_2300))]
        public DTP_DateLastWorked_2300 DTP_DateLastWorked_2300 { get; set; }
        [S("DTP", 13, typeof(X12_ID_374_All_DTP_2300), typeof(X12_ID_1250_All_DTP_2300))]
        public DTP_DateAuthorizedReturnToWork_2300 DTP_DateAuthorizedReturnToWork_2300 { get; set; }
        [S("DTP", 14, typeof(X12_ID_374_All_DTP_2300), typeof(X12_ID_1250_All_DTP_2300))]
        public DTP_DateAdmission_2300 DTP_DateAdmission_2300 { get; set; }
        [S("DTP", 15, typeof(X12_ID_374_All_DTP_2300), typeof(X12_ID_1250_All_DTP_2300))]
        public DTP_DateDischarge_2300 DTP_DateDischarge_2300 { get; set; }
        [S("DTP", 16, typeof(X12_ID_374_All_DTP_2300), typeof(X12_ID_1250_All_DTP_2300))]
        public List<DTP_DateAssumedAndRelinquishedCareDates_2300> DTP_DateAssumedAndRelinquishedCareDates_2300 { get; set; }
    }
    
    [E(",454,")]
    public class X12_ID_374_All_DTP_2300
    {
    }
    
    [E(",D8,")]
    public class X12_ID_1250_All_DTP_2300
    {
    }
    
    public class DTP_DateAssumedAndRelinquishedCareDates_2300
    {
        
        [D(1, "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3)]
        public string AssumedOrRelinquishedCareDate_03 { get; set; }
    }
    
    public class DTP_DateDischarge_2300
    {
        
        [D(1, "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3)]
        public string RelatedHospitalizationDischargeDate_03 { get; set; }
    }
    
    public class DTP_DateAdmission_2300
    {
        
        [D(1, "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3)]
        public string RelatedHospitalizationAdmissionDate_03 { get; set; }
    }
    
    public class DTP_DateAuthorizedReturnToWork_2300
    {
        
        [D(1, "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3)]
        public string WorkReturnDate_03 { get; set; }
    }
    
    public class DTP_DateLastWorked_2300
    {
        
        [D(1, "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3)]
        public string LastWorkedDate_03 { get; set; }
    }
    
    public class DTP_DateDisabilityEnd_2300
    {
        
        [D(1, "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3)]
        public string DisabilityToDate_03 { get; set; }
    }
    
    public class DTP_DateDisabilityBegin_2300
    {
        
        [D(1, "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3)]
        public string DisabilityFromDate_03 { get; set; }
    }
    
    public class DTP_DateHearingAndVisionPrescriptionDate_2300
    {
        
        [D(1, "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3)]
        public string PrescriptionDate_03 { get; set; }
    }
    
    public class DTP_DateLastXray_2300
    {
        
        [D(1, "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3)]
        public string LastXRayDate_03 { get; set; }
    }
    
    public class DTP_DateLastMenstrualPeriod_2300
    {
        
        [D(1, "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3)]
        public string LastMenstrualPeriodDate_03 { get; set; }
    }
    
    public class DTP_DateAccident_2300
    {
        
        [D(1, "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3)]
        public string AccidentDate_03 { get; set; }
    }
    
    public class DTP_DateSimilarIllnessSymptomOnset_2300
    {
        
        [D(1, "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3)]
        public string SimilarIllnessOrSymptomDate_03 { get; set; }
    }
    
    public class DTP_DateAcuteManifestation_2300
    {
        
        [D(1, "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3)]
        public string AcuteManifestationDate_03 { get; set; }
    }
    
    public class DTP_DateOnsetOfCurrentIllnessSymptom_2300
    {
        
        [D(1, "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3)]
        public string OnsetOfCurrentIllnessOrInjuryDate_03 { get; set; }
    }
    
    public class DTP_DateDateLastSeen_2300
    {
        
        [D(1, "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3)]
        public string LastSeenDate_03 { get; set; }
    }
    
    public class DTP_DateInitialTreatment_2300
    {
        
        [D(1, "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3)]
        public string InitialTreatmentDate_03 { get; set; }
    }
    
    public class CLM_ClaimInformation_2300
    {
        
        [D(1)]
        public string PatientAccountNumber_01 { get; set; }
        [D(2)]
        public string TotalClaimChargeAmount_02 { get; set; }
        [D(3)]
        public string CLM_03 { get; set; }
        [D(4)]
        public string CLM_04 { get; set; }
        [C(5)]
        public C023_701794159 C023_701794159 { get; set; }
        [D(6, "1073")]
        public string ProviderOrSupplierSignatureIndicator_06 { get; set; }
        [D(7, "1359")]
        public string MedicareAssignmentCode_07 { get; set; }
        [D(8, "1073")]
        public string BenefitsAssignmentCertificationIndicator_08 { get; set; }
        [D(9, "1363")]
        public string ReleaseOfInformationCode_09 { get; set; }
        [D(10, "1351")]
        public string PatientSignatureSourceCode_10 { get; set; }
        [C(11)]
        public C024_1508297677 C024_1508297677 { get; set; }
        [D(12, "1366")]
        public string SpecialProgramIndicator_12 { get; set; }
        [D(13)]
        public string CLM_13 { get; set; }
        [D(14)]
        public string CLM_14 { get; set; }
        [D(15)]
        public string CLM_15 { get; set; }
        [D(16, "1360")]
        public string ParticipationAgreement_16 { get; set; }
        [D(17)]
        public string CLM_17 { get; set; }
        [D(18)]
        public string CLM_18 { get; set; }
        [D(19)]
        public string CLM_19 { get; set; }
        [D(20, "1514")]
        public string DelayReasonCode_20 { get; set; }
    }
    
    public class C024_1508297677
    {
        
        [D(1, "1362")]
        public string RelatedCausesCode_01 { get; set; }
        [D(2, "1362")]
        public string RelatedCausesCode_02 { get; set; }
        [D(3, "1362")]
        public string RelatedCausesCode_03 { get; set; }
        [D(4)]
        public string AutoAccidentStateOrProvinceCode_04 { get; set; }
        [D(5)]
        public string CountryCode_05 { get; set; }
    }
    
    public class C023_701794159
    {
        
        [D(1)]
        public string FacilityTypeCode_01 { get; set; }
        [D(2)]
        public string CLM_02 { get; set; }
        [D(3)]
        public string ClaimFrequencyCode_03 { get; set; }
    }
    
    public class Loop_2010CA
    {
        
        [S("NM1", 1, typeof(X12_ID_98_Loop_2010CA), typeof(X12_ID_1065_Loop_2010CA))]
        public NM1_PatientName_2010CA NM1_PatientName_2010CA { get; set; }
        [S("N3", 2)]
        public N3_PatientAddress_2010CA N3_PatientAddress_2010CA { get; set; }
        [S("N4", 3)]
        public N4_PatientCityStateZIPCode_2010CA N4_PatientCityStateZIPCode_2010CA { get; set; }
        [S("DMG", 4, typeof(X12_ID_1250_Loop_2010CA))]
        public DMG_PatientDemographicInformation_2010CA DMG_PatientDemographicInformation_2010CA { get; set; }
        [A(5)]
        public All_REF_2010CA All_REF_2010CA { get; set; }
    }
    
    [E(",QC,")]
    public class X12_ID_98_Loop_2010CA
    {
    }
    
    [E(",1,")]
    public class X12_ID_1065_Loop_2010CA
    {
    }
    
    [E(",D8,")]
    public class X12_ID_1250_Loop_2010CA
    {
    }
    
    public class All_REF_2010CA
    {
        
        [S("REF", 1, typeof(X12_ID_128_All_REF_2010CA))]
        public List<REF_PatientSecondaryIdentification_2010CA> REF_PatientSecondaryIdentification_2010CA { get; set; }
        [S("REF", 2, typeof(X12_ID_128_All_REF_2010CA))]
        public REF_PropertyAndCasualtyClaimNumber_2010CA REF_PropertyAndCasualtyClaimNumber_2010CA { get; set; }
    }
    
    [E(",1W,23,IG,SY,")]
    public class X12_ID_128_All_REF_2010CA
    {
    }
    
    public class REF_PropertyAndCasualtyClaimNumber_2010CA
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2)]
        public string PropertyCasualtyClaimNumber_02 { get; set; }
        [D(3)]
        public string REF_03 { get; set; }
        [D(4)]
        public string REF_04 { get; set; }
    }
    
    public class REF_PatientSecondaryIdentification_2010CA
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2)]
        public string PatientSecondaryIdentifier_02 { get; set; }
        [D(3)]
        public string REF_03 { get; set; }
        [D(4)]
        public string REF_04 { get; set; }
    }
    
    public class DMG_PatientDemographicInformation_2010CA
    {
        
        [D(1, "1250")]
        public string DateTimePeriodFormatQualifier_01 { get; set; }
        [D(2)]
        public string PatientBirthDate_02 { get; set; }
        [D(3, "1068")]
        public string PatientGenderCode_03 { get; set; }
        [D(4)]
        public string DMG_04 { get; set; }
        [D(5)]
        public string DMG_05 { get; set; }
        [D(6)]
        public string DMG_06 { get; set; }
        [D(7)]
        public string DMG_07 { get; set; }
        [D(8)]
        public string DMG_08 { get; set; }
        [D(9)]
        public string DMG_09 { get; set; }
    }
    
    public class N4_PatientCityStateZIPCode_2010CA
    {
        
        [D(1)]
        public string PatientCityName_01 { get; set; }
        [D(2)]
        public string PatientStateCode_02 { get; set; }
        [D(3)]
        public string PatientPostalZoneOrZIPCode_03 { get; set; }
        [D(4)]
        public string CountryCode_04 { get; set; }
        [D(5)]
        public string N4_05 { get; set; }
        [D(6)]
        public string N4_06 { get; set; }
    }
    
    public class N3_PatientAddress_2010CA
    {
        
        [D(1)]
        public string PatientAddressLine_01 { get; set; }
        [D(2)]
        public string PatientAddressLine_02 { get; set; }
    }
    
    public class NM1_PatientName_2010CA
    {
        
        [D(1, "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3)]
        public string PatientLastName_03 { get; set; }
        [D(4)]
        public string PatientFirstName_04 { get; set; }
        [D(5)]
        public string PatientMiddleName_05 { get; set; }
        [D(6)]
        public string NM1_06 { get; set; }
        [D(7)]
        public string PatientNameSuffix_07 { get; set; }
        [D(8, "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9)]
        public string PatientPrimaryIdentifier_09 { get; set; }
        [D(10)]
        public string NM1_10 { get; set; }
        [D(11)]
        public string NM1_11 { get; set; }
    }
    
    public class PAT_PatientInformation_2000C
    {
        
        [D(1, "1069")]
        public string IndividualRelationshipCode_01 { get; set; }
        [D(2)]
        public string PAT_02 { get; set; }
        [D(3)]
        public string PAT_03 { get; set; }
        [D(4)]
        public string PAT_04 { get; set; }
        [D(5, "1250")]
        public string DateTimePeriodFormatQualifier_05 { get; set; }
        [D(6)]
        public string PatientDeathDate_06 { get; set; }
        [D(7, "355")]
        public string UnitOrBasisForMeasurementCode_07 { get; set; }
        [D(8)]
        public string PatientWeight_08 { get; set; }
        [D(9, "1073")]
        public string PregnancyIndicator_09 { get; set; }
    }
    
    public class HL_PatientHierarchicalLevel_2000C
    {
        
        [D(1)]
        public string HierarchicalIDNumber_01 { get; set; }
        [D(2)]
        public string HierarchicalParentIDNumber_02 { get; set; }
        [D(3, "735")]
        public string HierarchicalLevelCode_03 { get; set; }
        [D(4, "736")]
        public string HierarchicalChildCode_04 { get; set; }
    }
    
    public class All_2010B
    {
        
        [G(1)]
        public Loop_2010BA Loop_2010BA { get; set; }
        [G(2)]
        public Loop_2010BB Loop_2010BB { get; set; }
        [G(3)]
        public Loop_2010BC Loop_2010BC { get; set; }
        [G(4)]
        public Loop_2010BD Loop_2010BD { get; set; }
    }
    
    public class Loop_2010BD
    {
        
        [S("NM1", 1, typeof(X12_ID_98_Loop_2010BD), typeof(X12_ID_1065_Loop_2010BD))]
        public NM1_CreditDebitCardHolderName_2010BD NM1_CreditDebitCardHolderName_2010BD { get; set; }
        [S("REF", 2, typeof(X12_ID_128_Loop_2010BD))]
        public List<REF_CreditDebitCardInformation_2010BD> REF_CreditDebitCardInformation_2010BD { get; set; }
    }
    
    [E(",AO,")]
    public class X12_ID_98_Loop_2010BD
    {
    }
    
    [E(",1,2,")]
    public class X12_ID_1065_Loop_2010BD
    {
    }
    
    [E(",AB,BB,")]
    public class X12_ID_128_Loop_2010BD
    {
    }
    
    public class REF_CreditDebitCardInformation_2010BD
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2)]
        public string CreditOrDebitCardAuthorizationNumber_02 { get; set; }
        [D(3)]
        public string REF_03 { get; set; }
        [D(4)]
        public string REF_04 { get; set; }
    }
    
    public class NM1_CreditDebitCardHolderName_2010BD
    {
        
        [D(1, "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3)]
        public string CreditOrDebitCardHolderLastOrOrganizationalName_03 { get; set; }
        [D(4)]
        public string CreditOrDebitCardHolderFirstName_04 { get; set; }
        [D(5)]
        public string CreditOrDebitCardHolderMiddleName_05 { get; set; }
        [D(6)]
        public string NM1_06 { get; set; }
        [D(7)]
        public string CreditOrDebitCardHolderNameSuffix_07 { get; set; }
        [D(8, "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9)]
        public string CreditOrDebitCardNumber_09 { get; set; }
        [D(10)]
        public string NM1_10 { get; set; }
        [D(11)]
        public string NM1_11 { get; set; }
    }
    
    public class Loop_2010BC
    {
        
        [S("NM1", 1, typeof(X12_ID_98_Loop_2010BC), typeof(X12_ID_1065_Loop_2010BC))]
        public NM1_ResponsiblePartyName_2010BC NM1_ResponsiblePartyName_2010BC { get; set; }
        [S("N3", 2)]
        public N3_ResponsiblePartyAddress_2010BC N3_ResponsiblePartyAddress_2010BC { get; set; }
        [S("N4", 3)]
        public N4_ResponsiblePartyCityStateZIPCode_2010BC N4_ResponsiblePartyCityStateZIPCode_2010BC { get; set; }
    }
    
    [E(",QD,")]
    public class X12_ID_98_Loop_2010BC
    {
    }
    
    [E(",1,2,")]
    public class X12_ID_1065_Loop_2010BC
    {
    }
    
    public class N4_ResponsiblePartyCityStateZIPCode_2010BC
    {
        
        [D(1)]
        public string ResponsiblePartyCityName_01 { get; set; }
        [D(2)]
        public string ResponsiblePartyStateCode_02 { get; set; }
        [D(3)]
        public string ResponsiblePartyPostalZoneOrZIPCode_03 { get; set; }
        [D(4)]
        public string CountryCode_04 { get; set; }
        [D(5)]
        public string N4_05 { get; set; }
        [D(6)]
        public string N4_06 { get; set; }
    }
    
    public class N3_ResponsiblePartyAddress_2010BC
    {
        
        [D(1)]
        public string ResponsiblePartyAddressLine_01 { get; set; }
        [D(2)]
        public string ResponsiblePartyAddressLine_02 { get; set; }
    }
    
    public class NM1_ResponsiblePartyName_2010BC
    {
        
        [D(1, "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3)]
        public string ResponsiblePartyLastOrOrganizationName_03 { get; set; }
        [D(4)]
        public string ResponsiblePartyFirstName_04 { get; set; }
        [D(5)]
        public string ResponsiblePartyMiddleName_05 { get; set; }
        [D(6)]
        public string NM1_06 { get; set; }
        [D(7)]
        public string ResponsiblePartySuffixName_07 { get; set; }
        [D(8)]
        public string NM1_08 { get; set; }
        [D(9)]
        public string NM1_09 { get; set; }
        [D(10)]
        public string NM1_10 { get; set; }
        [D(11)]
        public string NM1_11 { get; set; }
    }
    
    public class Loop_2010BB
    {
        
        [S("NM1", 1, typeof(X12_ID_98_Loop_2010BB), typeof(X12_ID_1065_Loop_2010BB))]
        public NM1_PayerName_2010BB NM1_PayerName_2010BB { get; set; }
        [S("N3", 2)]
        public N3_PayerAddress_2010BB N3_PayerAddress_2010BB { get; set; }
        [S("N4", 3)]
        public N4_PayerCityStateZIPCode_2010BB N4_PayerCityStateZIPCode_2010BB { get; set; }
        [S("REF", 4, typeof(X12_ID_128_Loop_2010BB))]
        public List<REF_PayerSecondaryIdentification_2010BB> REF_PayerSecondaryIdentification_2010BB { get; set; }
    }
    
    [E(",PR,")]
    public class X12_ID_98_Loop_2010BB
    {
    }
    
    [E(",2,")]
    public class X12_ID_1065_Loop_2010BB
    {
    }
    
    [E(",2U,FY,NF,TJ,")]
    public class X12_ID_128_Loop_2010BB
    {
    }
    
    public class REF_PayerSecondaryIdentification_2010BB
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2)]
        public string PayerAdditionalIdentifier_02 { get; set; }
        [D(3)]
        public string REF_03 { get; set; }
        [D(4)]
        public string REF_04 { get; set; }
    }
    
    public class N4_PayerCityStateZIPCode_2010BB
    {
        
        [D(1)]
        public string PayerCityName_01 { get; set; }
        [D(2)]
        public string PayerStateCode_02 { get; set; }
        [D(3)]
        public string PayerPostalZoneOrZIPCode_03 { get; set; }
        [D(4)]
        public string CountryCode_04 { get; set; }
        [D(5)]
        public string N4_05 { get; set; }
        [D(6)]
        public string N4_06 { get; set; }
    }
    
    public class N3_PayerAddress_2010BB
    {
        
        [D(1)]
        public string PayerAddressLine_01 { get; set; }
        [D(2)]
        public string PayerAddressLine_02 { get; set; }
    }
    
    public class NM1_PayerName_2010BB
    {
        
        [D(1, "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3)]
        public string PayerName_03 { get; set; }
        [D(4)]
        public string NM1_04 { get; set; }
        [D(5)]
        public string NM1_05 { get; set; }
        [D(6)]
        public string NM1_06 { get; set; }
        [D(7)]
        public string NM1_07 { get; set; }
        [D(8, "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9)]
        public string PayerIdentifier_09 { get; set; }
        [D(10)]
        public string NM1_10 { get; set; }
        [D(11)]
        public string NM1_11 { get; set; }
    }
    
    public class Loop_2010BA
    {
        
        [S("NM1", 1, typeof(X12_ID_98_Loop_2010BA), typeof(X12_ID_1065_Loop_2010BA))]
        public NM1_SubscriberName_2010BA NM1_SubscriberName_2010BA { get; set; }
        [S("N3", 2)]
        public N3_SubscriberAddress_2010BA N3_SubscriberAddress_2010BA { get; set; }
        [S("N4", 3)]
        public N4_SubscriberCityStateZIPCode_2010BA N4_SubscriberCityStateZIPCode_2010BA { get; set; }
        [S("DMG", 4, typeof(X12_ID_1250_Loop_2010BA))]
        public DMG_SubscriberDemographicInformation_2010BA DMG_SubscriberDemographicInformation_2010BA { get; set; }
        [A(5)]
        public All_REF_2010BA All_REF_2010BA { get; set; }
    }
    
    [E(",IL,")]
    public class X12_ID_98_Loop_2010BA
    {
    }
    
    [E(",1,2,")]
    public class X12_ID_1065_Loop_2010BA
    {
    }
    
    [E(",D8,")]
    public class X12_ID_1250_Loop_2010BA
    {
    }
    
    public class All_REF_2010BA
    {
        
        [S("REF", 1, typeof(X12_ID_128_All_REF_2010BA))]
        public List<REF_SubscriberSecondaryIdentification_2010BA> REF_SubscriberSecondaryIdentification_2010BA { get; set; }
        [S("REF", 2, typeof(X12_ID_128_All_REF_2010BA))]
        public REF_PropertyAndCasualtyClaimNumber_2010BA REF_PropertyAndCasualtyClaimNumber_2010BA { get; set; }
    }
    
    [E(",1W,23,IG,SY,")]
    public class X12_ID_128_All_REF_2010BA
    {
    }
    
    public class REF_PropertyAndCasualtyClaimNumber_2010BA
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2)]
        public string PropertyCasualtyClaimNumber_02 { get; set; }
        [D(3)]
        public string REF_03 { get; set; }
        [D(4)]
        public string REF_04 { get; set; }
    }
    
    public class REF_SubscriberSecondaryIdentification_2010BA
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2)]
        public string SubscriberSupplementalIdentifier_02 { get; set; }
        [D(3)]
        public string REF_03 { get; set; }
        [D(4)]
        public string REF_04 { get; set; }
    }
    
    public class DMG_SubscriberDemographicInformation_2010BA
    {
        
        [D(1, "1250")]
        public string DateTimePeriodFormatQualifier_01 { get; set; }
        [D(2)]
        public string SubscriberBirthDate_02 { get; set; }
        [D(3, "1068")]
        public string SubscriberGenderCode_03 { get; set; }
        [D(4)]
        public string DMG_04 { get; set; }
        [D(5)]
        public string DMG_05 { get; set; }
        [D(6)]
        public string DMG_06 { get; set; }
        [D(7)]
        public string DMG_07 { get; set; }
        [D(8)]
        public string DMG_08 { get; set; }
        [D(9)]
        public string DMG_09 { get; set; }
    }
    
    public class N4_SubscriberCityStateZIPCode_2010BA
    {
        
        [D(1)]
        public string SubscriberCityName_01 { get; set; }
        [D(2)]
        public string SubscriberStateCode_02 { get; set; }
        [D(3)]
        public string SubscriberPostalZoneOrZIPCode_03 { get; set; }
        [D(4)]
        public string CountryCode_04 { get; set; }
        [D(5)]
        public string N4_05 { get; set; }
        [D(6)]
        public string N4_06 { get; set; }
    }
    
    public class N3_SubscriberAddress_2010BA
    {
        
        [D(1)]
        public string SubscriberAddressLine_01 { get; set; }
        [D(2)]
        public string SubscriberAddressLine_02 { get; set; }
    }
    
    public class NM1_SubscriberName_2010BA
    {
        
        [D(1, "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3)]
        public string SubscriberLastName_03 { get; set; }
        [D(4)]
        public string SubscriberFirstName_04 { get; set; }
        [D(5)]
        public string SubscriberMiddleName_05 { get; set; }
        [D(6)]
        public string NM1_06 { get; set; }
        [D(7)]
        public string SubscriberNameSuffix_07 { get; set; }
        [D(8, "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9)]
        public string SubscriberPrimaryIdentifier_09 { get; set; }
        [D(10)]
        public string NM1_10 { get; set; }
        [D(11)]
        public string NM1_11 { get; set; }
    }
    
    public class PAT_PatientInformation_2000B
    {
        
        [D(1)]
        public string PAT_01 { get; set; }
        [D(2)]
        public string PAT_02 { get; set; }
        [D(3)]
        public string PAT_03 { get; set; }
        [D(4)]
        public string PAT_04 { get; set; }
        [D(5, "1250")]
        public string DateTimePeriodFormatQualifier_05 { get; set; }
        [D(6)]
        public string InsuredIndividualDeathDate_06 { get; set; }
        [D(7, "355")]
        public string UnitOrBasisForMeasurementCode_07 { get; set; }
        [D(8)]
        public string PatientWeight_08 { get; set; }
        [D(9, "1073")]
        public string PregnancyIndicator_09 { get; set; }
    }
    
    public class SBR_SubscriberInformation_2000B
    {
        
        [D(1, "1138")]
        public string PayerResponsibilitySequenceNumberCode_01 { get; set; }
        [D(2, "1069")]
        public string IndividualRelationshipCode_02 { get; set; }
        [D(3)]
        public string InsuredGroupOrPolicyNumber_03 { get; set; }
        [D(4)]
        public string InsuredGroupName_04 { get; set; }
        [D(5, "1336")]
        public string InsuranceTypeCode_05 { get; set; }
        [D(6)]
        public string SBR_06 { get; set; }
        [D(7)]
        public string SBR_07 { get; set; }
        [D(8)]
        public string SBR_08 { get; set; }
        [D(9, "1032")]
        public string ClaimFilingIndicatorCode_09 { get; set; }
    }
    
    public class HL_SubscriberHierarchicalLevel_2000B
    {
        
        [D(1)]
        public string HierarchicalIDNumber_01 { get; set; }
        [D(2)]
        public string HierarchicalParentIDNumber_02 { get; set; }
        [D(3, "735")]
        public string HierarchicalLevelCode_03 { get; set; }
        [D(4, "736")]
        public string HierarchicalChildCode_04 { get; set; }
    }
    
    public class All_2010A
    {
        
        [G(1)]
        public Loop_2010AA Loop_2010AA { get; set; }
        [G(2)]
        public Loop_2010AB Loop_2010AB { get; set; }
    }
    
    public class Loop_2010AB
    {
        
        [S("NM1", 1, typeof(X12_ID_98_Loop_2010AB), typeof(X12_ID_1065_Loop_2010AB))]
        public NM1_PaytoProviderName_2010AB NM1_PaytoProviderName_2010AB { get; set; }
        [S("N3", 2)]
        public N3_PaytoProviderAddress_2010AB N3_PaytoProviderAddress_2010AB { get; set; }
        [S("N4", 3)]
        public N4_PaytoProviderCityStateZIPCode_2010AB N4_PaytoProviderCityStateZIPCode_2010AB { get; set; }
        [S("REF", 4, typeof(X12_ID_128_Loop_2010AB))]
        public List<REF_PaytoProviderSecondaryIdentification_2010AB> REF_PaytoProviderSecondaryIdentification_2010AB { get; set; }
    }
    
    [E(",87,")]
    public class X12_ID_98_Loop_2010AB
    {
    }
    
    [E(",1,2,")]
    public class X12_ID_1065_Loop_2010AB
    {
    }
    
    [E(",0B,1A,1B,1C,1D,1G,1H,1J,B3,BQ,EI,FH,G2,G5,LU,SY,U3,X5,")]
    public class X12_ID_128_Loop_2010AB
    {
    }
    
    public class REF_PaytoProviderSecondaryIdentification_2010AB
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2)]
        public string PaytoProviderIdentifier_02 { get; set; }
        [D(3)]
        public string REF_03 { get; set; }
        [D(4)]
        public string REF_04 { get; set; }
    }
    
    public class N4_PaytoProviderCityStateZIPCode_2010AB
    {
        
        [D(1)]
        public string PaytoProviderCityName_01 { get; set; }
        [D(2)]
        public string PaytoProviderStateCode_02 { get; set; }
        [D(3)]
        public string PaytoProviderPostalZoneOrZIPCode_03 { get; set; }
        [D(4)]
        public string CountryCode_04 { get; set; }
        [D(5)]
        public string N4_05 { get; set; }
        [D(6)]
        public string N4_06 { get; set; }
    }
    
    public class N3_PaytoProviderAddress_2010AB
    {
        
        [D(1)]
        public string PaytoProviderAddressLine_01 { get; set; }
        [D(2)]
        public string PaytoProviderAddressLine_02 { get; set; }
    }
    
    public class NM1_PaytoProviderName_2010AB
    {
        
        [D(1, "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3)]
        public string PaytoProviderLastOrOrganizationalName_03 { get; set; }
        [D(4)]
        public string PaytoProviderFirstName_04 { get; set; }
        [D(5)]
        public string PaytoProviderMiddleName_05 { get; set; }
        [D(6)]
        public string NM1_06 { get; set; }
        [D(7)]
        public string PaytoProviderNameSuffix_07 { get; set; }
        [D(8, "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9)]
        public string PaytoProviderIdentifier_09 { get; set; }
        [D(10)]
        public string NM1_10 { get; set; }
        [D(11)]
        public string NM1_11 { get; set; }
    }
    
    public class Loop_2010AA
    {
        
        [S("NM1", 1, typeof(X12_ID_98_Loop_2010AA), typeof(X12_ID_1065_Loop_2010AA))]
        public NM1_BillingProviderName_2010AA NM1_BillingProviderName_2010AA { get; set; }
        [S("N3", 2)]
        public N3_BillingProviderAddress_2010AA N3_BillingProviderAddress_2010AA { get; set; }
        [S("N4", 3)]
        public N4_BillingProviderCityStateZIPCode_2010AA N4_BillingProviderCityStateZIPCode_2010AA { get; set; }
        [A(4)]
        public All_REF_2010AA All_REF_2010AA { get; set; }
        [S("PER", 5, typeof(X12_ID_366_Loop_2010AA))]
        public List<PER_BillingProviderContactInformation_2010AA> PER_BillingProviderContactInformation_2010AA { get; set; }
    }
    
    [E(",85,")]
    public class X12_ID_98_Loop_2010AA
    {
    }
    
    [E(",1,2,")]
    public class X12_ID_1065_Loop_2010AA
    {
    }
    
    [E(",IC,")]
    public class X12_ID_366_Loop_2010AA
    {
    }
    
    public class PER_BillingProviderContactInformation_2010AA
    {
        
        [D(1, "366")]
        public string ContactFunctionCode_01 { get; set; }
        [D(2)]
        public string BillingProviderContactName_02 { get; set; }
        [D(3, "365")]
        public string CommunicationNumberQualifier_03 { get; set; }
        [D(4)]
        public string CommunicationNumber_04 { get; set; }
        [D(5, "365")]
        public string CommunicationNumberQualifier_05 { get; set; }
        [D(6)]
        public string CommunicationNumber_06 { get; set; }
        [D(7, "365")]
        public string CommunicationNumberQualifier_07 { get; set; }
        [D(8)]
        public string CommunicationNumber_08 { get; set; }
        [D(9)]
        public string PER_09 { get; set; }
    }
    
    public class All_REF_2010AA
    {
        
        [S("REF", 1, typeof(X12_ID_128_All_REF_2010AA))]
        public List<REF_BillingProviderSecondaryIdentification_2010AA> REF_BillingProviderSecondaryIdentification_2010AA { get; set; }
        [S("REF", 2, typeof(X12_ID_128_All_REF_2010AA))]
        public List<REF_CreditDebitCardBillingInformation_2010AA> REF_CreditDebitCardBillingInformation_2010AA { get; set; }
    }
    
    [E(",0B,1A,1B,1C,1D,1G,1H,1J,B3,BQ,EI,FH,G2,G5,LU,SY,U3,X5,")]
    public class X12_ID_128_All_REF_2010AA
    {
    }
    
    public class REF_CreditDebitCardBillingInformation_2010AA
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2)]
        public string BillingProviderCreditCardIdentifier_02 { get; set; }
        [D(3)]
        public string REF_03 { get; set; }
        [D(4)]
        public string REF_04 { get; set; }
    }
    
    public class REF_BillingProviderSecondaryIdentification_2010AA
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2)]
        public string BillingProviderAdditionalIdentifier_02 { get; set; }
        [D(3)]
        public string REF_03 { get; set; }
        [D(4)]
        public string REF_04 { get; set; }
    }
    
    public class N4_BillingProviderCityStateZIPCode_2010AA
    {
        
        [D(1)]
        public string BillingProviderCityName_01 { get; set; }
        [D(2)]
        public string BillingProviderStateOrProvinceCode_02 { get; set; }
        [D(3)]
        public string BillingProviderPostalZoneOrZIPCode_03 { get; set; }
        [D(4)]
        public string CountryCode_04 { get; set; }
        [D(5)]
        public string N4_05 { get; set; }
        [D(6)]
        public string N4_06 { get; set; }
    }
    
    public class N3_BillingProviderAddress_2010AA
    {
        
        [D(1)]
        public string BillingProviderAddressLine_01 { get; set; }
        [D(2)]
        public string BillingProviderAddressLine_02 { get; set; }
    }
    
    public class NM1_BillingProviderName_2010AA
    {
        
        [D(1, "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3)]
        public string BillingProviderLastOrOrganizationalName_03 { get; set; }
        [D(4)]
        public string BillingProviderFirstName_04 { get; set; }
        [D(5)]
        public string BillingProviderMiddleName_05 { get; set; }
        [D(6)]
        public string NM1_06 { get; set; }
        [D(7)]
        public string BillingProviderNameSuffix_07 { get; set; }
        [D(8, "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9)]
        public string BillingProviderIdentifier_09 { get; set; }
        [D(10)]
        public string NM1_10 { get; set; }
        [D(11)]
        public string NM1_11 { get; set; }
    }
    
    public class CUR_ForeignCurrencyInformation_2000A
    {
        
        [D(1, "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2)]
        public string CurrencyCode_02 { get; set; }
        [D(3)]
        public string CUR_03 { get; set; }
        [D(4)]
        public string CUR_04 { get; set; }
        [D(5)]
        public string CUR_05 { get; set; }
        [D(6)]
        public string CUR_06 { get; set; }
        [D(7)]
        public string CUR_07 { get; set; }
        [D(8)]
        public string CUR_08 { get; set; }
        [D(9)]
        public string CUR_09 { get; set; }
        [D(10)]
        public string CUR_10 { get; set; }
        [D(11)]
        public string CUR_11 { get; set; }
        [D(12)]
        public string CUR_12 { get; set; }
        [D(13)]
        public string CUR_13 { get; set; }
        [D(14)]
        public string CUR_14 { get; set; }
        [D(15)]
        public string CUR_15 { get; set; }
        [D(16)]
        public string CUR_16 { get; set; }
        [D(17)]
        public string CUR_17 { get; set; }
        [D(18)]
        public string CUR_18 { get; set; }
        [D(19)]
        public string CUR_19 { get; set; }
        [D(20)]
        public string CUR_20 { get; set; }
        [D(21)]
        public string CUR_21 { get; set; }
    }
    
    public class PRV_BillingPaytoProviderSpecialtyInformation_2000A
    {
        
        [D(1, "1221")]
        public string ProviderCode_01 { get; set; }
        [D(2, "128")]
        public string ReferenceIdentificationQualifier_02 { get; set; }
        [D(3)]
        public string ProviderTaxonomyCode_03 { get; set; }
        [D(4)]
        public string PRV_04 { get; set; }
        [D(5)]
        public string PRV_05 { get; set; }
        [D(6)]
        public string PRV_06 { get; set; }
    }
    
    public class HL_BillingPaytoProviderHierarchicalLevel_2000A
    {
        
        [D(1)]
        public string HierarchicalIDNumber_01 { get; set; }
        [D(2)]
        public string HL_02 { get; set; }
        [D(3, "735")]
        public string HierarchicalLevelCode_03 { get; set; }
        [D(4, "736")]
        public string HierarchicalChildCode_04 { get; set; }
    }
    
    public class Loop_1000B
    {
        
        [S("NM1", 1, typeof(X12_ID_98_Loop_1000B), typeof(X12_ID_1065_Loop_1000B))]
        public NM1_ReceiverName_1000B NM1_ReceiverName_1000B { get; set; }
    }
    
    [E(",40,")]
    public class X12_ID_98_Loop_1000B
    {
    }
    
    [E(",2,")]
    public class X12_ID_1065_Loop_1000B
    {
    }
    
    public class NM1_ReceiverName_1000B
    {
        
        [D(1, "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3)]
        public string ReceiverName_03 { get; set; }
        [D(4)]
        public string NM1_04 { get; set; }
        [D(5)]
        public string NM1_05 { get; set; }
        [D(6)]
        public string NM1_06 { get; set; }
        [D(7)]
        public string NM1_07 { get; set; }
        [D(8, "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9)]
        public string ReceiverPrimaryIdentifier_09 { get; set; }
        [D(10)]
        public string NM1_10 { get; set; }
        [D(11)]
        public string NM1_11 { get; set; }
    }
    
    public class Loop_1000A
    {
        
        [S("NM1", 1, typeof(X12_ID_98_Loop_1000A), typeof(X12_ID_1065_Loop_1000A))]
        public NM1_SubmitterName_1000A NM1_SubmitterName_1000A { get; set; }
        [S("PER", 2, typeof(X12_ID_366_Loop_1000A))]
        public List<PER_SubmitterEDIContactInformation_1000A> PER_SubmitterEDIContactInformation_1000A { get; set; }
    }
    
    [E(",41,")]
    public class X12_ID_98_Loop_1000A
    {
    }
    
    [E(",1,2,")]
    public class X12_ID_1065_Loop_1000A
    {
    }
    
    [E(",IC,")]
    public class X12_ID_366_Loop_1000A
    {
    }
    
    public class PER_SubmitterEDIContactInformation_1000A
    {
        
        [D(1, "366")]
        public string ContactFunctionCode_01 { get; set; }
        [D(2)]
        public string SubmitterContactName_02 { get; set; }
        [D(3, "365")]
        public string CommunicationNumberQualifier_03 { get; set; }
        [D(4)]
        public string CommunicationNumber_04 { get; set; }
        [D(5, "365")]
        public string CommunicationNumberQualifier_05 { get; set; }
        [D(6)]
        public string CommunicationNumber_06 { get; set; }
        [D(7, "365")]
        public string CommunicationNumberQualifier_07 { get; set; }
        [D(8)]
        public string CommunicationNumber_08 { get; set; }
        [D(9)]
        public string PER_09 { get; set; }
    }
    
    public class NM1_SubmitterName_1000A
    {
        
        [D(1, "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3)]
        public string SubmitterLastOrOrganizationName_03 { get; set; }
        [D(4)]
        public string SubmitterFirstName_04 { get; set; }
        [D(5)]
        public string SubmitterMiddleName_05 { get; set; }
        [D(6)]
        public string NM1_06 { get; set; }
        [D(7)]
        public string NM1_07 { get; set; }
        [D(8, "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9)]
        public string SubmitterIdentifier_09 { get; set; }
        [D(10)]
        public string NM1_10 { get; set; }
        [D(11)]
        public string NM1_11 { get; set; }
    }
    
    public class REF_TransmissionTypeIdentification
    {
        
        [D(1, "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2)]
        public string TransmissionTypeCode_02 { get; set; }
        [D(3)]
        public string REF_03 { get; set; }
        [D(4)]
        public string REF_04 { get; set; }
    }
    
    public class BHT_BeginningOfHierarchicalTransaction
    {
        
        [D(1, "1005")]
        public string HierarchicalStructureCode_01 { get; set; }
        [D(2, "353")]
        public string TransactionSetPurposeCode_02 { get; set; }
        [D(3)]
        public string OriginatorApplicationTransactionIdentifier_03 { get; set; }
        [D(4)]
        public string TransactionSetCreationDate_04 { get; set; }
        [D(5)]
        public string TransactionSetCreationTime_05 { get; set; }
        [D(6, "640")]
        public string ClaimOrEncounterIdentifier_06 { get; set; }
    }
    
    public class ST
    {
        
        [D(1, "143")]
        public string TransactionSetIdentifierCode_01 { get; set; }
        [D(2, "329")]
        public string TransactionSetControlNumber_02 { get; set; }
        [D(3, "1705")]
        public string ImplementationConventionPreference_03 { get; set; }
    }
}
