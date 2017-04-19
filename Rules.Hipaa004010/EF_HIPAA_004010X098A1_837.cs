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
        [S("BHT", 2)]
        public BHT_BeginningOfHierarchicalTransaction BHT_BeginningOfHierarchicalTransaction { get; set; }
        [S("REF", 3)]
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
    
    public class SE
    {
        
        [D(1, typeof(X12_AN), "96")]
        public string NumberofIncludedSegments_01 { get; set; }
        [D(2, typeof(X12_AN), "329")]
        public string TransactionSetControlNumber_02 { get; set; }
    }
    
    public class X12_AN
    {
    }
    
    public class Loop_2000A
    {
        
        [S("HL", 1)]
        public HL_BillingPaytoProviderHierarchicalLevel_2000A HL_BillingPaytoProviderHierarchicalLevel_2000A { get; set; }
        [S("PRV", 2)]
        public PRV_BillingPaytoProviderSpecialtyInformation_2000A PRV_BillingPaytoProviderSpecialtyInformation_2000A { get; set; }
        [S("CUR", 3)]
        public CUR_ForeignCurrencyInformation_2000A CUR_ForeignCurrencyInformation_2000A { get; set; }
        [A(4)]
        public All_2010A All_2010A { get; set; }
        [G(5)]
        public List<Loop_2000B> Loop_2000B { get; set; }
    }
    
    public class Loop_2000B
    {
        
        [S("HL", 1)]
        public HL_SubscriberHierarchicalLevel_2000B HL_SubscriberHierarchicalLevel_2000B { get; set; }
        [S("SBR", 2)]
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
    
    public class Loop_2000C
    {
        
        [S("HL", 1)]
        public HL_PatientHierarchicalLevel_2000C HL_PatientHierarchicalLevel_2000C { get; set; }
        [S("PAT", 2)]
        public PAT_PatientInformation_2000C PAT_PatientInformation_2000C { get; set; }
        [G(3)]
        public Loop_2010CA Loop_2010CA { get; set; }
        [G(4)]
        public List<Loop_2300> Loop_2300 { get; set; }
    }
    
    public class Loop_2300
    {
        
        [S("CLM", 1)]
        public CLM_ClaimInformation_2300 CLM_ClaimInformation_2300 { get; set; }
        [A(2)]
        public All_DTP_2300 All_DTP_2300 { get; set; }
        [S("PWK", 3)]
        public List<PWK_ClaimSupplementalInformation_2300> PWK_ClaimSupplementalInformation_2300 { get; set; }
        [S("CN1", 4)]
        public CN1_ContractInformation_2300 CN1_ContractInformation_2300 { get; set; }
        [A(5)]
        public All_AMT_2300 All_AMT_2300 { get; set; }
        [A(6)]
        public All_REF_2300 All_REF_2300 { get; set; }
        [S("K3", 7)]
        public List<K3_FileInformation_2300> K3_FileInformation_2300 { get; set; }
        [S("NTE", 8)]
        public NTE_ClaimNote_2300 NTE_ClaimNote_2300 { get; set; }
        [S("CR1", 9)]
        public CR1_AmbulanceTransportInformation_2300 CR1_AmbulanceTransportInformation_2300 { get; set; }
        [S("CR2", 10)]
        public CR2_SpinalManipulationServiceInformation_2300 CR2_SpinalManipulationServiceInformation_2300 { get; set; }
        [A(11)]
        public All_CRC_2300 All_CRC_2300 { get; set; }
        [S("HI", 12)]
        public HI_HealthCareDiagnosisCode_2300 HI_HealthCareDiagnosisCode_2300 { get; set; }
        [S("HCP", 13)]
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
    
    public class Loop_2400
    {
        
        [S("LX", 1)]
        public LX_ServiceLine_2400 LX_ServiceLine_2400 { get; set; }
        [S("SV1", 2)]
        public SV1_ProfessionalService_2400 SV1_ProfessionalService_2400 { get; set; }
        [S("SV5", 3)]
        public SV5_DurableMedicalEquipmentService_2400 SV5_DurableMedicalEquipmentService_2400 { get; set; }
        [S("PWK", 4)]
        public PWK_DMERCCMNIndicator_2400 PWK_DMERCCMNIndicator_2400 { get; set; }
        [S("CR1", 5)]
        public CR1_AmbulanceTransportInformation_2400 CR1_AmbulanceTransportInformation_2400 { get; set; }
        [S("CR2", 6)]
        public List<CR2_SpinalManipulationServiceInformation_2400> CR2_SpinalManipulationServiceInformation_2400 { get; set; }
        [S("CR3", 7)]
        public CR3_DurableMedicalEquipmentCertification_2400 CR3_DurableMedicalEquipmentCertification_2400 { get; set; }
        [S("CR5", 8)]
        public CR5_HomeOxygenTherapyInformation_2400 CR5_HomeOxygenTherapyInformation_2400 { get; set; }
        [A(9)]
        public All_CRC_2400 All_CRC_2400 { get; set; }
        [A(10)]
        public All_DTP_2400 All_DTP_2400 { get; set; }
        [S("MEA", 11)]
        public List<MEA_TestResult_2400> MEA_TestResult_2400 { get; set; }
        [S("CN1", 12)]
        public CN1_ContractInformation_2400 CN1_ContractInformation_2400 { get; set; }
        [A(13)]
        public All_REF_2400 All_REF_2400 { get; set; }
        [A(14)]
        public All_AMT_2400 All_AMT_2400 { get; set; }
        [S("K3", 15)]
        public List<K3_FileInformation_2400> K3_FileInformation_2400 { get; set; }
        [S("NTE", 16)]
        public NTE_LineNote_2400 NTE_LineNote_2400 { get; set; }
        [S("PS1", 17)]
        public PS1_PurchasedServiceInformation_2400 PS1_PurchasedServiceInformation_2400 { get; set; }
        [S("HSD", 18)]
        public HSD_HealthCareServicesDelivery_2400 HSD_HealthCareServicesDelivery_2400 { get; set; }
        [S("HCP", 19)]
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
    
    public class Loop_2440
    {
        
        [S("LQ", 1)]
        public LQ_FormIdentificationCode_2440 LQ_FormIdentificationCode_2440 { get; set; }
        [S("FRM", 2)]
        public List<FRM_SupportingDocumentation_2440> FRM_SupportingDocumentation_2440 { get; set; }
    }
    
    public class FRM_SupportingDocumentation_2440
    {
        
        [D(1, typeof(X12_AN))]
        public string QuestionNumberLetter_01 { get; set; }
        [D(2, typeof(X12_ID_1073_FRM_SupportingDocumentation_2440), "1073")]
        public string QuestionResponse_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string QuestionResponse_03 { get; set; }
        [D(4, typeof(X12_DT))]
        public string QuestionResponse_04 { get; set; }
        [D(5, typeof(X12_R))]
        public string QuestionResponse_05 { get; set; }
    }
    
    public class X12_ID_1073_FRM_SupportingDocumentation_2440
    {
        
        public List<string> Codes = new List<string> {"N","W","Y"};
    }
    
    public class X12_DT
    {
    }
    
    public class X12_R
    {
    }
    
    public class LQ_FormIdentificationCode_2440
    {
        
        [D(1, typeof(X12_ID_1270_LQ_FormIdentificationCode_2440), "1270")]
        public string CodeListQualifierCode_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string FormIdentifier_02 { get; set; }
    }
    
    public class X12_ID_1270_LQ_FormIdentificationCode_2440
    {
        
        public List<string> Codes = new List<string> {"AS","UT"};
    }
    
    public class Loop_2430
    {
        
        [S("SVD", 1)]
        public SVD_LineAdjudicationInformation_2430 SVD_LineAdjudicationInformation_2430 { get; set; }
        [S("CAS", 2)]
        public List<CAS_LineAdjustment_2430> CAS_LineAdjustment_2430 { get; set; }
        [S("DTP", 3)]
        public DTP_LineAdjudicationDate_2430 DTP_LineAdjudicationDate_2430 { get; set; }
    }
    
    public class DTP_LineAdjudicationDate_2430
    {
        
        [D(1, typeof(X12_ID_374_DTP_LineAdjudicationDate_2430), "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_1250_DTP_LineAdjudicationDate_2430), "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string AdjudicationOrPaymentDate_03 { get; set; }
    }
    
    public class X12_ID_374_DTP_LineAdjudicationDate_2430
    {
        
        public List<string> Codes = new List<string> {"573"};
    }
    
    public class X12_ID_1250_DTP_LineAdjudicationDate_2430
    {
        
        public List<string> Codes = new List<string> {"D8"};
    }
    
    public class CAS_LineAdjustment_2430
    {
        
        [D(1, typeof(X12_ID_1033_CAS_LineAdjustment_2430), "1033")]
        public string ClaimAdjustmentGroupCode_01 { get; set; }
        [D(2, typeof(X12_ID))]
        public string AdjustmentReasonCode_02 { get; set; }
        [D(3, typeof(X12_R))]
        public string AdjustmentAmount_03 { get; set; }
        [D(4, typeof(X12_R))]
        public string AdjustmentQuantity_04 { get; set; }
        [D(5, typeof(X12_ID))]
        public string AdjustmentReasonCode_05 { get; set; }
        [D(6, typeof(X12_R))]
        public string AdjustmentAmount_06 { get; set; }
        [D(7, typeof(X12_R))]
        public string AdjustmentQuantity_07 { get; set; }
        [D(8, typeof(X12_ID))]
        public string AdjustmentReasonCode_08 { get; set; }
        [D(9, typeof(X12_R))]
        public string AdjustmentAmount_09 { get; set; }
        [D(10, typeof(X12_R))]
        public string AdjustmentQuantity_10 { get; set; }
        [D(11, typeof(X12_ID))]
        public string AdjustmentReasonCode_11 { get; set; }
        [D(12, typeof(X12_R))]
        public string AdjustmentAmount_12 { get; set; }
        [D(13, typeof(X12_R))]
        public string AdjustmentQuantity_13 { get; set; }
        [D(14, typeof(X12_ID))]
        public string AdjustmentReasonCode_14 { get; set; }
        [D(15, typeof(X12_R))]
        public string AdjustmentAmount_15 { get; set; }
        [D(16, typeof(X12_R))]
        public string AdjustmentQuantity_16 { get; set; }
        [D(17, typeof(X12_ID))]
        public string AdjustmentReasonCode_17 { get; set; }
        [D(18, typeof(X12_R))]
        public string AdjustmentAmount_18 { get; set; }
        [D(19, typeof(X12_R))]
        public string AdjustmentQuantity_19 { get; set; }
    }
    
    public class X12_ID_1033_CAS_LineAdjustment_2430
    {
        
        public List<string> Codes = new List<string> {"CO","CR","OA","PI","PR"};
    }
    
    public class X12_ID
    {
    }
    
    public class SVD_LineAdjudicationInformation_2430
    {
        
        [D(1, typeof(X12_AN))]
        public string OtherPayerPrimaryIdentifier_01 { get; set; }
        [D(2, typeof(X12_R))]
        public string ServiceLinePaidAmount_02 { get; set; }
        [C(3)]
        public C003_460284360 C003_460284360 { get; set; }
        [D(4, typeof(X12_AN))]
        public string SVD_04 { get; set; }
        [D(5, typeof(X12_R))]
        public string PaidServiceUnitCount_05 { get; set; }
        [D(6, typeof(X12_N0))]
        public string BundledOrUnbundledLineNumber_06 { get; set; }
    }
    
    public class X12_N0
    {
    }
    
    public class C003_460284360
    {
        
        [D(1, typeof(X12_ID_235_C003_460284360), "235")]
        public string ProductOrServiceIDQualifier_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string ProcedureCode_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string ProcedureModifier_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string ProcedureModifier_04 { get; set; }
        [D(5, typeof(X12_AN))]
        public string ProcedureModifier_05 { get; set; }
        [D(6, typeof(X12_AN))]
        public string ProcedureModifier_06 { get; set; }
        [D(7, typeof(X12_AN))]
        public string ProcedureCodeDescription_07 { get; set; }
    }
    
    public class X12_ID_235_C003_460284360
    {
        
        public List<string> Codes = new List<string> {"HC","IV","ZZ"};
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
        
        [S("NM1", 1)]
        public NM1_OtherPayerPriorAuthorizationOrReferralNumber_2420G NM1_OtherPayerPriorAuthorizationOrReferralNumber_2420G { get; set; }
        [S("REF", 2)]
        public List<REF_OtherPayerPriorAuthorizationOrReferralNumber_2420G> REF_OtherPayerPriorAuthorizationOrReferralNumber_2420G { get; set; }
    }
    
    public class REF_OtherPayerPriorAuthorizationOrReferralNumber_2420G
    {
        
        [D(1, typeof(X12_ID_128_REF_OtherPayerPriorAuthorizationOrReferralNumber_2420G), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string OtherPayerPriorAuthorizationOrReferralNumber_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string REF_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string REF_04 { get; set; }
    }
    
    public class X12_ID_128_REF_OtherPayerPriorAuthorizationOrReferralNumber_2420G
    {
        
        public List<string> Codes = new List<string> {"9F","G1"};
    }
    
    public class NM1_OtherPayerPriorAuthorizationOrReferralNumber_2420G
    {
        
        [D(1, typeof(X12_ID_98_NM1_OtherPayerPriorAuthorizationOrReferralNumber_2420G), "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, typeof(X12_ID_1065_NM1_OtherPayerPriorAuthorizationOrReferralNumber_2420G), "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string PayerName_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string NM1_04 { get; set; }
        [D(5, typeof(X12_AN))]
        public string NM1_05 { get; set; }
        [D(6, typeof(X12_AN))]
        public string NM1_06 { get; set; }
        [D(7, typeof(X12_AN))]
        public string NM1_07 { get; set; }
        [D(8, typeof(X12_ID_66_NM1_OtherPayerPriorAuthorizationOrReferralNumber_2420G), "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, typeof(X12_AN))]
        public string OtherPayerIdentificationNumber_09 { get; set; }
        [D(10, typeof(X12_ID))]
        public string NM1_10 { get; set; }
        [D(11, typeof(X12_ID))]
        public string NM1_11 { get; set; }
    }
    
    public class X12_ID_98_NM1_OtherPayerPriorAuthorizationOrReferralNumber_2420G
    {
        
        public List<string> Codes = new List<string> {"PR"};
    }
    
    public class X12_ID_1065_NM1_OtherPayerPriorAuthorizationOrReferralNumber_2420G
    {
        
        public List<string> Codes = new List<string> {"2"};
    }
    
    public class X12_ID_66_NM1_OtherPayerPriorAuthorizationOrReferralNumber_2420G
    {
        
        public List<string> Codes = new List<string> {"PI","XV"};
    }
    
    public class Loop_2420F
    {
        
        [S("NM1", 1)]
        public NM1_ReferringProviderName_2420F NM1_ReferringProviderName_2420F { get; set; }
        [S("PRV", 2)]
        public PRV_ReferringProviderSpecialtyInformation_2420F PRV_ReferringProviderSpecialtyInformation_2420F { get; set; }
        [S("REF", 3)]
        public List<REF_ReferringProviderSecondaryIdentification_2420F> REF_ReferringProviderSecondaryIdentification_2420F { get; set; }
    }
    
    public class REF_ReferringProviderSecondaryIdentification_2420F
    {
        
        [D(1, typeof(X12_ID_128_REF_ReferringProviderSecondaryIdentification_2420F), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string ReferringProviderSecondaryIdentifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string REF_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string REF_04 { get; set; }
    }
    
    public class X12_ID_128_REF_ReferringProviderSecondaryIdentification_2420F
    {
        
        public List<string> Codes = new List<string> {"0B","1B","1C","1D","1G","1H","EI","G2","LU","N5","SY","X5"};
    }
    
    public class PRV_ReferringProviderSpecialtyInformation_2420F
    {
        
        [D(1, typeof(X12_ID_1221_PRV_ReferringProviderSpecialtyInformation_2420F), "1221")]
        public string ProviderCode_01 { get; set; }
        [D(2, typeof(X12_ID_128_PRV_ReferringProviderSpecialtyInformation_2420F), "128")]
        public string ReferenceIdentificationQualifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string ProviderTaxonomyCode_03 { get; set; }
        [D(4, typeof(X12_ID))]
        public string PRV_04 { get; set; }
        [D(5, typeof(X12_AN))]
        public string PRV_05 { get; set; }
        [D(6, typeof(X12_ID))]
        public string PRV_06 { get; set; }
    }
    
    public class X12_ID_1221_PRV_ReferringProviderSpecialtyInformation_2420F
    {
        
        public List<string> Codes = new List<string> {"RF"};
    }
    
    public class X12_ID_128_PRV_ReferringProviderSpecialtyInformation_2420F
    {
        
        public List<string> Codes = new List<string> {"ZZ"};
    }
    
    public class NM1_ReferringProviderName_2420F
    {
        
        [D(1, typeof(X12_ID_98_NM1_ReferringProviderName_2420F), "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, typeof(X12_ID_1065_NM1_ReferringProviderName_2420F), "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string ReferringProviderLastName_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string ReferringProviderFirstName_04 { get; set; }
        [D(5, typeof(X12_AN))]
        public string ReferringProviderMiddleName_05 { get; set; }
        [D(6, typeof(X12_AN))]
        public string NM1_06 { get; set; }
        [D(7, typeof(X12_AN))]
        public string ReferringProviderNameSuffix_07 { get; set; }
        [D(8, typeof(X12_ID_66_NM1_ReferringProviderName_2420F), "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, typeof(X12_AN))]
        public string ReferringProviderIdentifier_09 { get; set; }
        [D(10, typeof(X12_ID))]
        public string NM1_10 { get; set; }
        [D(11, typeof(X12_ID))]
        public string NM1_11 { get; set; }
    }
    
    public class X12_ID_98_NM1_ReferringProviderName_2420F
    {
        
        public List<string> Codes = new List<string> {"DN","P3"};
    }
    
    public class X12_ID_1065_NM1_ReferringProviderName_2420F
    {
        
        public List<string> Codes = new List<string> {"1"};
    }
    
    public class X12_ID_66_NM1_ReferringProviderName_2420F
    {
        
        public List<string> Codes = new List<string> {"24","34","XX"};
    }
    
    public class Loop_2420E
    {
        
        [S("NM1", 1)]
        public NM1_OrderingProviderName_2420E NM1_OrderingProviderName_2420E { get; set; }
        [S("N3", 2)]
        public N3_OrderingProviderAddress_2420E N3_OrderingProviderAddress_2420E { get; set; }
        [S("N4", 3)]
        public N4_OrderingProviderCityStateZIPCode_2420E N4_OrderingProviderCityStateZIPCode_2420E { get; set; }
        [S("REF", 4)]
        public List<REF_OrderingProviderSecondaryIdentification_2420E> REF_OrderingProviderSecondaryIdentification_2420E { get; set; }
        [S("PER", 5)]
        public PER_OrderingProviderContactInformation_2420E PER_OrderingProviderContactInformation_2420E { get; set; }
    }
    
    public class PER_OrderingProviderContactInformation_2420E
    {
        
        [D(1, typeof(X12_ID_366_PER_OrderingProviderContactInformation_2420E), "366")]
        public string ContactFunctionCode_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string OrderingProviderContactName_02 { get; set; }
        [D(3, typeof(X12_ID_365_PER_OrderingProviderContactInformation_2420E), "365")]
        public string CommunicationNumberQualifier_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string CommunicationNumber_04 { get; set; }
        [D(5, typeof(X12_ID_365_PER_OrderingProviderContactInformation_2420E), "365")]
        public string CommunicationNumberQualifier_05 { get; set; }
        [D(6, typeof(X12_AN))]
        public string CommunicationNumber_06 { get; set; }
        [D(7, typeof(X12_ID_365_PER_OrderingProviderContactInformation_2420E), "365")]
        public string CommunicationNumberQualifier_07 { get; set; }
        [D(8, typeof(X12_AN))]
        public string CommunicationNumber_08 { get; set; }
        [D(9, typeof(X12_AN))]
        public string PER_09 { get; set; }
    }
    
    public class X12_ID_366_PER_OrderingProviderContactInformation_2420E
    {
        
        public List<string> Codes = new List<string> {"IC"};
    }
    
    public class X12_ID_365_PER_OrderingProviderContactInformation_2420E
    {
        
        public List<string> Codes = new List<string> {"EM","FX","TE"};
    }
    
    public class REF_OrderingProviderSecondaryIdentification_2420E
    {
        
        [D(1, typeof(X12_ID_128_REF_OrderingProviderSecondaryIdentification_2420E), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string OrderingProviderSecondaryIdentifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string REF_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string REF_04 { get; set; }
    }
    
    public class X12_ID_128_REF_OrderingProviderSecondaryIdentification_2420E
    {
        
        public List<string> Codes = new List<string> {"0B","1B","1C","1D","1G","1H","EI","G2","LU","N5","SY","X5"};
    }
    
    public class N4_OrderingProviderCityStateZIPCode_2420E
    {
        
        [D(1, typeof(X12_AN))]
        public string OrderingProviderCityName_01 { get; set; }
        [D(2, typeof(X12_ID))]
        public string OrderingProviderStateCode_02 { get; set; }
        [D(3, typeof(X12_ID))]
        public string OrderingProviderPostalZoneOrZIPCode_03 { get; set; }
        [D(4, typeof(X12_ID))]
        public string CountryCode_04 { get; set; }
        [D(5, typeof(X12_ID))]
        public string N4_05 { get; set; }
        [D(6, typeof(X12_AN))]
        public string N4_06 { get; set; }
    }
    
    public class N3_OrderingProviderAddress_2420E
    {
        
        [D(1, typeof(X12_AN))]
        public string OrderingProviderAddressLine_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string OrderingProviderAddressLine_02 { get; set; }
    }
    
    public class NM1_OrderingProviderName_2420E
    {
        
        [D(1, typeof(X12_ID_98_NM1_OrderingProviderName_2420E), "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, typeof(X12_ID_1065_NM1_OrderingProviderName_2420E), "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string OrderingProviderLastName_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string OrderingProviderFirstName_04 { get; set; }
        [D(5, typeof(X12_AN))]
        public string OrderingProviderMiddleName_05 { get; set; }
        [D(6, typeof(X12_AN))]
        public string NM1_06 { get; set; }
        [D(7, typeof(X12_AN))]
        public string OrderingProviderNameSuffix_07 { get; set; }
        [D(8, typeof(X12_ID_66_NM1_OrderingProviderName_2420E), "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, typeof(X12_AN))]
        public string OrderingProviderIdentifier_09 { get; set; }
        [D(10, typeof(X12_ID))]
        public string NM1_10 { get; set; }
        [D(11, typeof(X12_ID))]
        public string NM1_11 { get; set; }
    }
    
    public class X12_ID_98_NM1_OrderingProviderName_2420E
    {
        
        public List<string> Codes = new List<string> {"DK"};
    }
    
    public class X12_ID_1065_NM1_OrderingProviderName_2420E
    {
        
        public List<string> Codes = new List<string> {"1"};
    }
    
    public class X12_ID_66_NM1_OrderingProviderName_2420E
    {
        
        public List<string> Codes = new List<string> {"24","34","XX"};
    }
    
    public class Loop_2420D
    {
        
        [S("NM1", 1)]
        public NM1_SupervisingProviderName_2420D NM1_SupervisingProviderName_2420D { get; set; }
        [S("REF", 2)]
        public List<REF_SupervisingProviderSecondaryIdentification_2420D> REF_SupervisingProviderSecondaryIdentification_2420D { get; set; }
    }
    
    public class REF_SupervisingProviderSecondaryIdentification_2420D
    {
        
        [D(1, typeof(X12_ID_128_REF_SupervisingProviderSecondaryIdentification_2420D), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string SupervisingProviderSecondaryIdentifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string REF_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string REF_04 { get; set; }
    }
    
    public class X12_ID_128_REF_SupervisingProviderSecondaryIdentification_2420D
    {
        
        public List<string> Codes = new List<string> {"0B","1B","1C","1D","1G","1H","EI","G2","LU","N5","SY","X5"};
    }
    
    public class NM1_SupervisingProviderName_2420D
    {
        
        [D(1, typeof(X12_ID_98_NM1_SupervisingProviderName_2420D), "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, typeof(X12_ID_1065_NM1_SupervisingProviderName_2420D), "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string SupervisingProviderLastName_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string SupervisingProviderFirstName_04 { get; set; }
        [D(5, typeof(X12_AN))]
        public string SupervisingProviderMiddleName_05 { get; set; }
        [D(6, typeof(X12_AN))]
        public string NM1_06 { get; set; }
        [D(7, typeof(X12_AN))]
        public string SupervisingProviderNameSuffix_07 { get; set; }
        [D(8, typeof(X12_ID_66_NM1_SupervisingProviderName_2420D), "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, typeof(X12_AN))]
        public string SupervisingProviderIdentifier_09 { get; set; }
        [D(10, typeof(X12_ID))]
        public string NM1_10 { get; set; }
        [D(11, typeof(X12_ID))]
        public string NM1_11 { get; set; }
    }
    
    public class X12_ID_98_NM1_SupervisingProviderName_2420D
    {
        
        public List<string> Codes = new List<string> {"DQ"};
    }
    
    public class X12_ID_1065_NM1_SupervisingProviderName_2420D
    {
        
        public List<string> Codes = new List<string> {"1"};
    }
    
    public class X12_ID_66_NM1_SupervisingProviderName_2420D
    {
        
        public List<string> Codes = new List<string> {"24","34","XX"};
    }
    
    public class Loop_2420C
    {
        
        [S("NM1", 1)]
        public NM1_ServiceFacilityLocation_2420C NM1_ServiceFacilityLocation_2420C { get; set; }
        [S("N3", 2)]
        public N3_ServiceFacilityLocationAddress_2420C N3_ServiceFacilityLocationAddress_2420C { get; set; }
        [S("N4", 3)]
        public N4_ServiceFacilityLocationCityStateZIP_2420C N4_ServiceFacilityLocationCityStateZIP_2420C { get; set; }
        [S("REF", 4)]
        public List<REF_ServiceFacilityLocationSecondaryIdentification_2420C> REF_ServiceFacilityLocationSecondaryIdentification_2420C { get; set; }
    }
    
    public class REF_ServiceFacilityLocationSecondaryIdentification_2420C
    {
        
        [D(1, typeof(X12_ID_128_REF_ServiceFacilityLocationSecondaryIdentification_2420C), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string ServiceFacilityLocationSecondaryIdentifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string REF_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string REF_04 { get; set; }
    }
    
    public class X12_ID_128_REF_ServiceFacilityLocationSecondaryIdentification_2420C
    {
        
        public List<string> Codes = new List<string> {"0B","1A","1B","1C","1D","1G","1H","G2","LU","N5","TJ","X4","X5"};
    }
    
    public class N4_ServiceFacilityLocationCityStateZIP_2420C
    {
        
        [D(1, typeof(X12_AN))]
        public string LaboratoryOrFacilityCityName_01 { get; set; }
        [D(2, typeof(X12_ID))]
        public string LaboratoryOrFacilityStateOrProvinceCode_02 { get; set; }
        [D(3, typeof(X12_ID))]
        public string LaboratoryOrFacilityPostalZoneOrZIPCode_03 { get; set; }
        [D(4, typeof(X12_ID))]
        public string CountryCode_04 { get; set; }
        [D(5, typeof(X12_ID))]
        public string N4_05 { get; set; }
        [D(6, typeof(X12_AN))]
        public string N4_06 { get; set; }
    }
    
    public class N3_ServiceFacilityLocationAddress_2420C
    {
        
        [D(1, typeof(X12_AN))]
        public string LaboratoryOrFacilityAddressLine_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string LaboratoryOrFacilityAddressLine_02 { get; set; }
    }
    
    public class NM1_ServiceFacilityLocation_2420C
    {
        
        [D(1, typeof(X12_ID_98_NM1_ServiceFacilityLocation_2420C), "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, typeof(X12_ID_1065_NM1_ServiceFacilityLocation_2420C), "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string LaboratoryOrFacilityName_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string NM1_04 { get; set; }
        [D(5, typeof(X12_AN))]
        public string NM1_05 { get; set; }
        [D(6, typeof(X12_AN))]
        public string NM1_06 { get; set; }
        [D(7, typeof(X12_AN))]
        public string NM1_07 { get; set; }
        [D(8, typeof(X12_ID_66_NM1_ServiceFacilityLocation_2420C), "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, typeof(X12_AN))]
        public string LaboratoryOrFacilityPrimaryIdentifier_09 { get; set; }
        [D(10, typeof(X12_ID))]
        public string NM1_10 { get; set; }
        [D(11, typeof(X12_ID))]
        public string NM1_11 { get; set; }
    }
    
    public class X12_ID_98_NM1_ServiceFacilityLocation_2420C
    {
        
        public List<string> Codes = new List<string> {"77","FA","LI","TL"};
    }
    
    public class X12_ID_1065_NM1_ServiceFacilityLocation_2420C
    {
        
        public List<string> Codes = new List<string> {"2"};
    }
    
    public class X12_ID_66_NM1_ServiceFacilityLocation_2420C
    {
        
        public List<string> Codes = new List<string> {"24","34","XX"};
    }
    
    public class Loop_2420B
    {
        
        [S("NM1", 1)]
        public NM1_PurchasedServiceProviderName_2420B NM1_PurchasedServiceProviderName_2420B { get; set; }
        [S("REF", 2)]
        public List<REF_PurchasedServiceProviderSecondaryIdentification_2420B> REF_PurchasedServiceProviderSecondaryIdentification_2420B { get; set; }
    }
    
    public class REF_PurchasedServiceProviderSecondaryIdentification_2420B
    {
        
        [D(1, typeof(X12_ID_128_REF_PurchasedServiceProviderSecondaryIdentification_2420B), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string PurchasedServiceProviderSecondaryIdentifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string REF_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string REF_04 { get; set; }
    }
    
    public class X12_ID_128_REF_PurchasedServiceProviderSecondaryIdentification_2420B
    {
        
        public List<string> Codes = new List<string> {"0B","1A","1B","1C","1D","1G","1H","EI","G2","LU","N5","SY","U3","X5"};
    }
    
    public class NM1_PurchasedServiceProviderName_2420B
    {
        
        [D(1, typeof(X12_ID_98_NM1_PurchasedServiceProviderName_2420B), "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, typeof(X12_ID_1065_NM1_PurchasedServiceProviderName_2420B), "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string NM1_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string NM1_04 { get; set; }
        [D(5, typeof(X12_AN))]
        public string NM1_05 { get; set; }
        [D(6, typeof(X12_AN))]
        public string NM1_06 { get; set; }
        [D(7, typeof(X12_AN))]
        public string NM1_07 { get; set; }
        [D(8, typeof(X12_ID_66_NM1_PurchasedServiceProviderName_2420B), "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, typeof(X12_AN))]
        public string PurchasedServiceProviderIdentifier_09 { get; set; }
        [D(10, typeof(X12_ID))]
        public string NM1_10 { get; set; }
        [D(11, typeof(X12_ID))]
        public string NM1_11 { get; set; }
    }
    
    public class X12_ID_98_NM1_PurchasedServiceProviderName_2420B
    {
        
        public List<string> Codes = new List<string> {"QB"};
    }
    
    public class X12_ID_1065_NM1_PurchasedServiceProviderName_2420B
    {
        
        public List<string> Codes = new List<string> {"1","2"};
    }
    
    public class X12_ID_66_NM1_PurchasedServiceProviderName_2420B
    {
        
        public List<string> Codes = new List<string> {"24","34","XX"};
    }
    
    public class Loop_2420A
    {
        
        [S("NM1", 1)]
        public NM1_RenderingProviderName_2420A NM1_RenderingProviderName_2420A { get; set; }
        [S("PRV", 2)]
        public PRV_RenderingProviderSpecialtyInformation_2420A PRV_RenderingProviderSpecialtyInformation_2420A { get; set; }
        [S("REF", 3)]
        public List<REF_RenderingProviderSecondaryIdentification_2420A> REF_RenderingProviderSecondaryIdentification_2420A { get; set; }
    }
    
    public class REF_RenderingProviderSecondaryIdentification_2420A
    {
        
        [D(1, typeof(X12_ID_128_REF_RenderingProviderSecondaryIdentification_2420A), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string RenderingProviderSecondaryIdentifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string REF_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string REF_04 { get; set; }
    }
    
    public class X12_ID_128_REF_RenderingProviderSecondaryIdentification_2420A
    {
        
        public List<string> Codes = new List<string> {"0B","1B","1C","1D","1G","1H","EI","G2","LU","N5","SY","X5"};
    }
    
    public class PRV_RenderingProviderSpecialtyInformation_2420A
    {
        
        [D(1, typeof(X12_ID_1221_PRV_RenderingProviderSpecialtyInformation_2420A), "1221")]
        public string ProviderCode_01 { get; set; }
        [D(2, typeof(X12_ID_128_PRV_RenderingProviderSpecialtyInformation_2420A), "128")]
        public string ReferenceIdentificationQualifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string ProviderTaxonomyCode_03 { get; set; }
        [D(4, typeof(X12_ID))]
        public string PRV_04 { get; set; }
        [D(5, typeof(X12_AN))]
        public string PRV_05 { get; set; }
        [D(6, typeof(X12_ID))]
        public string PRV_06 { get; set; }
    }
    
    public class X12_ID_1221_PRV_RenderingProviderSpecialtyInformation_2420A
    {
        
        public List<string> Codes = new List<string> {"PE"};
    }
    
    public class X12_ID_128_PRV_RenderingProviderSpecialtyInformation_2420A
    {
        
        public List<string> Codes = new List<string> {"ZZ"};
    }
    
    public class NM1_RenderingProviderName_2420A
    {
        
        [D(1, typeof(X12_ID_98_NM1_RenderingProviderName_2420A), "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, typeof(X12_ID_1065_NM1_RenderingProviderName_2420A), "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string RenderingProviderLastOrOrganizationName_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string RenderingProviderFirstName_04 { get; set; }
        [D(5, typeof(X12_AN))]
        public string RenderingProviderMiddleName_05 { get; set; }
        [D(6, typeof(X12_AN))]
        public string NM1_06 { get; set; }
        [D(7, typeof(X12_AN))]
        public string RenderingProviderNameSuffix_07 { get; set; }
        [D(8, typeof(X12_ID_66_NM1_RenderingProviderName_2420A), "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, typeof(X12_AN))]
        public string RenderingProviderIdentifier_09 { get; set; }
        [D(10, typeof(X12_ID))]
        public string NM1_10 { get; set; }
        [D(11, typeof(X12_ID))]
        public string NM1_11 { get; set; }
    }
    
    public class X12_ID_98_NM1_RenderingProviderName_2420A
    {
        
        public List<string> Codes = new List<string> {"82"};
    }
    
    public class X12_ID_1065_NM1_RenderingProviderName_2420A
    {
        
        public List<string> Codes = new List<string> {"1","2"};
    }
    
    public class X12_ID_66_NM1_RenderingProviderName_2420A
    {
        
        public List<string> Codes = new List<string> {"24","34","XX"};
    }
    
    public class Loop_2410
    {
        
        [S("LIN", 1)]
        public LIN_DrugIdentification_2410 LIN_DrugIdentification_2410 { get; set; }
        [S("CTP", 2)]
        public CTP_DrugPricing_2410 CTP_DrugPricing_2410 { get; set; }
        [S("REF", 3)]
        public REF_PrescriptionNumber_2410 REF_PrescriptionNumber_2410 { get; set; }
    }
    
    public class REF_PrescriptionNumber_2410
    {
        
        [D(1, typeof(X12_ID_128_REF_PrescriptionNumber_2410), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string PrescriptionNumber_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string REF_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string REF_04 { get; set; }
    }
    
    public class X12_ID_128_REF_PrescriptionNumber_2410
    {
        
        public List<string> Codes = new List<string> {"XZ"};
    }
    
    public class CTP_DrugPricing_2410
    {
        
        [D(1, typeof(X12_ID))]
        public string CTP_01 { get; set; }
        [D(2, typeof(X12_ID))]
        public string CTP_02 { get; set; }
        [D(3, typeof(X12_R))]
        public string DrugUnitPrice_03 { get; set; }
        [D(4, typeof(X12_R))]
        public string NationalDrugUnitCount_04 { get; set; }
        [C(5)]
        public C001_1149128115 C001_1149128115 { get; set; }
        [D(6, typeof(X12_ID))]
        public string CTP_06 { get; set; }
        [D(7, typeof(X12_R))]
        public string CTP_07 { get; set; }
        [D(8, typeof(X12_R))]
        public string CTP_08 { get; set; }
        [D(9, typeof(X12_ID))]
        public string CTP_09 { get; set; }
        [D(10, typeof(X12_AN))]
        public string CTP_10 { get; set; }
        [D(11, typeof(X12_N0))]
        public string CTP_11 { get; set; }
    }
    
    public class C001_1149128115
    {
        
        [D(1, typeof(X12_ID_355_C001_1149128115), "355")]
        public string UnitOrBasisForMeasurementCode_01 { get; set; }
        [D(2, typeof(X12_R))]
        public string CTP_02 { get; set; }
        [D(3, typeof(X12_R))]
        public string CTP_03 { get; set; }
        [D(4, typeof(X12_ID))]
        public string CTP_04 { get; set; }
        [D(5, typeof(X12_R))]
        public string CTP_05 { get; set; }
        [D(6, typeof(X12_R))]
        public string CTP_06 { get; set; }
        [D(7, typeof(X12_ID))]
        public string CTP_07 { get; set; }
        [D(8, typeof(X12_R))]
        public string CTP_08 { get; set; }
        [D(9, typeof(X12_R))]
        public string CTP_09 { get; set; }
        [D(10, typeof(X12_ID))]
        public string CTP_10 { get; set; }
        [D(11, typeof(X12_R))]
        public string CTP_11 { get; set; }
        [D(12, typeof(X12_R))]
        public string CTP_12 { get; set; }
        [D(13, typeof(X12_ID))]
        public string CTP_13 { get; set; }
        [D(14, typeof(X12_R))]
        public string CTP_14 { get; set; }
        [D(15, typeof(X12_R))]
        public string CTP_15 { get; set; }
    }
    
    public class X12_ID_355_C001_1149128115
    {
        
        public List<string> Codes = new List<string> {"F2","GR","ML","UN"};
    }
    
    public class LIN_DrugIdentification_2410
    {
        
        [D(1, typeof(X12_AN))]
        public string LIN_01 { get; set; }
        [D(2, typeof(X12_ID_235_LIN_DrugIdentification_2410), "235")]
        public string ProductOrServiceIDQualifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string NationalDrugCode_03 { get; set; }
        [D(4, typeof(X12_ID))]
        public string LIN_04 { get; set; }
        [D(5, typeof(X12_AN))]
        public string LIN_05 { get; set; }
        [D(6, typeof(X12_ID))]
        public string LIN_06 { get; set; }
        [D(7, typeof(X12_AN))]
        public string LIN_07 { get; set; }
        [D(8, typeof(X12_ID))]
        public string LIN_08 { get; set; }
        [D(9, typeof(X12_AN))]
        public string LIN_09 { get; set; }
        [D(10, typeof(X12_ID))]
        public string LIN_10 { get; set; }
        [D(11, typeof(X12_AN))]
        public string LIN_11 { get; set; }
        [D(12, typeof(X12_ID))]
        public string LIN_12 { get; set; }
        [D(13, typeof(X12_AN))]
        public string LIN_13 { get; set; }
        [D(14, typeof(X12_ID))]
        public string LIN_14 { get; set; }
        [D(15, typeof(X12_AN))]
        public string LIN_15 { get; set; }
        [D(16, typeof(X12_ID))]
        public string LIN_16 { get; set; }
        [D(17, typeof(X12_AN))]
        public string LIN_17 { get; set; }
        [D(18, typeof(X12_ID))]
        public string LIN_18 { get; set; }
        [D(19, typeof(X12_AN))]
        public string LIN_19 { get; set; }
        [D(20, typeof(X12_ID))]
        public string LIN_20 { get; set; }
        [D(21, typeof(X12_AN))]
        public string LIN_21 { get; set; }
        [D(22, typeof(X12_ID))]
        public string LIN_22 { get; set; }
        [D(23, typeof(X12_AN))]
        public string LIN_23 { get; set; }
        [D(24, typeof(X12_ID))]
        public string LIN_24 { get; set; }
        [D(25, typeof(X12_AN))]
        public string LIN_25 { get; set; }
        [D(26, typeof(X12_ID))]
        public string LIN_26 { get; set; }
        [D(27, typeof(X12_AN))]
        public string LIN_27 { get; set; }
        [D(28, typeof(X12_ID))]
        public string LIN_28 { get; set; }
        [D(29, typeof(X12_AN))]
        public string LIN_29 { get; set; }
        [D(30, typeof(X12_ID))]
        public string LIN_30 { get; set; }
        [D(31, typeof(X12_AN))]
        public string LIN_31 { get; set; }
    }
    
    public class X12_ID_235_LIN_DrugIdentification_2410
    {
        
        public List<string> Codes = new List<string> {"N4"};
    }
    
    public class HCP_LinePricingRepricingInformation_2400
    {
        
        [D(1, typeof(X12_ID_1473_HCP_LinePricingRepricingInformation_2400), "1473")]
        public string PricingMethodology_01 { get; set; }
        [D(2, typeof(X12_R))]
        public string RepricedAllowedAmount_02 { get; set; }
        [D(3, typeof(X12_R))]
        public string RepricedSavingAmount_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string RepricingOrganizationIdentifier_04 { get; set; }
        [D(5, typeof(X12_R))]
        public string RepricingPerDiemOrFlatRateAmount_05 { get; set; }
        [D(6, typeof(X12_AN))]
        public string RepricedApprovedAmbulatoryPatientGroupCode_06 { get; set; }
        [D(7, typeof(X12_R))]
        public string RepricedApprovedAmbulatoryPatientGroupAmount_07 { get; set; }
        [D(8, typeof(X12_AN))]
        public string HCP_08 { get; set; }
        [D(9, typeof(X12_ID_235_HCP_LinePricingRepricingInformation_2400), "235")]
        public string ProductOrServiceIDQualifier_09 { get; set; }
        [D(10, typeof(X12_AN))]
        public string ProcedureCode_10 { get; set; }
        [D(11, typeof(X12_ID_355_HCP_LinePricingRepricingInformation_2400), "355")]
        public string UnitOrBasisForMeasurementCode_11 { get; set; }
        [D(12, typeof(X12_R))]
        public string RepricedApprovedServiceUnitCount_12 { get; set; }
        [D(13, typeof(X12_ID_901_HCP_LinePricingRepricingInformation_2400), "901")]
        public string RejectReasonCode_13 { get; set; }
        [D(14, typeof(X12_ID_1526_HCP_LinePricingRepricingInformation_2400), "1526")]
        public string PolicyComplianceCode_14 { get; set; }
        [D(15, typeof(X12_ID_1527_HCP_LinePricingRepricingInformation_2400), "1527")]
        public string ExceptionCode_15 { get; set; }
    }
    
    public class X12_ID_1473_HCP_LinePricingRepricingInformation_2400
    {
        
        public List<string> Codes = new List<string> {"00","01","02","03","04","05","06","07","08","09","10","11","12","13","14"};
    }
    
    public class X12_ID_235_HCP_LinePricingRepricingInformation_2400
    {
        
        public List<string> Codes = new List<string> {"HC","IV","ZZ"};
    }
    
    public class X12_ID_355_HCP_LinePricingRepricingInformation_2400
    {
        
        public List<string> Codes = new List<string> {"DA","UN"};
    }
    
    public class X12_ID_901_HCP_LinePricingRepricingInformation_2400
    {
        
        public List<string> Codes = new List<string> {"T1","T2","T3","T4","T5","T6"};
    }
    
    public class X12_ID_1526_HCP_LinePricingRepricingInformation_2400
    {
        
        public List<string> Codes = new List<string> {"1","2","3","4","5"};
    }
    
    public class X12_ID_1527_HCP_LinePricingRepricingInformation_2400
    {
        
        public List<string> Codes = new List<string> {"1","2","3","4","5","6"};
    }
    
    public class HSD_HealthCareServicesDelivery_2400
    {
        
        [D(1, typeof(X12_ID_673_HSD_HealthCareServicesDelivery_2400), "673")]
        public string Visits_01 { get; set; }
        [D(2, typeof(X12_R))]
        public string NumberOfVisits_02 { get; set; }
        [D(3, typeof(X12_ID_355_HSD_HealthCareServicesDelivery_2400), "355")]
        public string FrequencyPeriod_03 { get; set; }
        [D(4, typeof(X12_R))]
        public string FrequencyCount_04 { get; set; }
        [D(5, typeof(X12_ID_615_HSD_HealthCareServicesDelivery_2400), "615")]
        public string DurationOfVisitsUnits_05 { get; set; }
        [D(6, typeof(X12_N0))]
        public string DurationOfVisitsNumberOfUnits_06 { get; set; }
        [D(7, typeof(X12_ID_678_HSD_HealthCareServicesDelivery_2400), "678")]
        public string ShipDeliveryOrCalendarPatternCode_07 { get; set; }
        [D(8, typeof(X12_ID_679_HSD_HealthCareServicesDelivery_2400), "679")]
        public string DeliveryPatternTimeCode_08 { get; set; }
    }
    
    public class X12_ID_673_HSD_HealthCareServicesDelivery_2400
    {
        
        public List<string> Codes = new List<string> {"VS"};
    }
    
    public class X12_ID_355_HSD_HealthCareServicesDelivery_2400
    {
        
        public List<string> Codes = new List<string> {"DA","MO","Q1","WK"};
    }
    
    public class X12_ID_615_HSD_HealthCareServicesDelivery_2400
    {
        
        public List<string> Codes = new List<string> {"7","34","35"};
    }
    
    public class X12_ID_678_HSD_HealthCareServicesDelivery_2400
    {
        
        public List<string> Codes = new List<string> {"1","2","3","4","5","6","7","A","B","C","D","E","F","G","H","J","K","L","N","O","SA","SB","SC","SD","SG","SL","SP","SX","SY","SZ","W"};
    }
    
    public class X12_ID_679_HSD_HealthCareServicesDelivery_2400
    {
        
        public List<string> Codes = new List<string> {"D","E","F"};
    }
    
    public class PS1_PurchasedServiceInformation_2400
    {
        
        [D(1, typeof(X12_AN))]
        public string PurchasedServiceProviderIdentifier_01 { get; set; }
        [D(2, typeof(X12_R))]
        public string PurchasedServiceChargeAmount_02 { get; set; }
        [D(3, typeof(X12_ID))]
        public string PS1_03 { get; set; }
    }
    
    public class NTE_LineNote_2400
    {
        
        [D(1, typeof(X12_ID_363_NTE_LineNote_2400), "363")]
        public string NoteReferenceCode_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string LineNoteText_02 { get; set; }
    }
    
    public class X12_ID_363_NTE_LineNote_2400
    {
        
        public List<string> Codes = new List<string> {"ADD","DCP","PMT","TPO"};
    }
    
    public class K3_FileInformation_2400
    {
        
        [D(1, typeof(X12_AN))]
        public string FixedFormatInformation_01 { get; set; }
        [D(2, typeof(X12_ID))]
        public string K3_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string K3_03 { get; set; }
    }
    
    public class All_AMT_2400
    {
        
        [S("AMT", 1)]
        public AMT_SalesTaxAmount_2400 AMT_SalesTaxAmount_2400 { get; set; }
        [S("AMT", 2)]
        public AMT_ApprovedAmount_2400 AMT_ApprovedAmount_2400 { get; set; }
        [S("AMT", 3)]
        public AMT_PostageClaimedAmount_2400 AMT_PostageClaimedAmount_2400 { get; set; }
    }
    
    public class AMT_PostageClaimedAmount_2400
    {
        
        [D(1, typeof(X12_ID_522_AMT_PostageClaimedAmount_2400), "522")]
        public string AmountQualifierCode_01 { get; set; }
        [D(2, typeof(X12_R))]
        public string PostageClaimedAmount_02 { get; set; }
        [D(3, typeof(X12_ID))]
        public string AMT_03 { get; set; }
    }
    
    public class X12_ID_522_AMT_PostageClaimedAmount_2400
    {
        
        public List<string> Codes = new List<string> {"F4"};
    }
    
    public class AMT_ApprovedAmount_2400
    {
        
        [D(1, typeof(X12_ID_522_AMT_ApprovedAmount_2400), "522")]
        public string AmountQualifierCode_01 { get; set; }
        [D(2, typeof(X12_R))]
        public string ApprovedAmount_02 { get; set; }
        [D(3, typeof(X12_ID))]
        public string AMT_03 { get; set; }
    }
    
    public class X12_ID_522_AMT_ApprovedAmount_2400
    {
        
        public List<string> Codes = new List<string> {"AAE"};
    }
    
    public class AMT_SalesTaxAmount_2400
    {
        
        [D(1, typeof(X12_ID_522_AMT_SalesTaxAmount_2400), "522")]
        public string AmountQualifierCode_01 { get; set; }
        [D(2, typeof(X12_R))]
        public string SalesTaxAmount_02 { get; set; }
        [D(3, typeof(X12_ID))]
        public string AMT_03 { get; set; }
    }
    
    public class X12_ID_522_AMT_SalesTaxAmount_2400
    {
        
        public List<string> Codes = new List<string> {"T"};
    }
    
    public class All_REF_2400
    {
        
        [S("REF", 1)]
        public REF_RepricedLineItemReferenceNumber_2400 REF_RepricedLineItemReferenceNumber_2400 { get; set; }
        [S("REF", 2)]
        public REF_AdjustedRepricedLineItemReferenceNumber_2400 REF_AdjustedRepricedLineItemReferenceNumber_2400 { get; set; }
        [S("REF", 3)]
        public List<REF_PriorAuthorizationOrReferralNumber_2400> REF_PriorAuthorizationOrReferralNumber_2400 { get; set; }
        [S("REF", 4)]
        public REF_LineItemControlNumber_2400 REF_LineItemControlNumber_2400 { get; set; }
        [S("REF", 5)]
        public REF_MammographyCertificationNumber_2400 REF_MammographyCertificationNumber_2400 { get; set; }
        [S("REF", 6)]
        public REF_ClinicalLaboratoryImprovementAmendmentCLIAIdentification_2400 REF_ClinicalLaboratoryImprovementAmendmentCLIAIdentification_2400 { get; set; }
        [S("REF", 7)]
        public REF_ReferringClinicalLaboratoryImprovementAmendmentCLIAFacilityIdentification_2400 REF_ReferringClinicalLaboratoryImprovementAmendmentCLIAFacilityIdentification_2400 { get; set; }
        [S("REF", 8)]
        public REF_ImmunizationBatchNumber_2400 REF_ImmunizationBatchNumber_2400 { get; set; }
        [S("REF", 9)]
        public List<REF_AmbulatoryPatientGroupAPG_2400> REF_AmbulatoryPatientGroupAPG_2400 { get; set; }
        [S("REF", 10)]
        public REF_OxygenFlowRate_2400 REF_OxygenFlowRate_2400 { get; set; }
        [S("REF", 11)]
        public REF_UniversalProductNumberUPN_2400 REF_UniversalProductNumberUPN_2400 { get; set; }
    }
    
    public class REF_UniversalProductNumberUPN_2400
    {
        
        [D(1, typeof(X12_ID_128_REF_UniversalProductNumberUPN_2400), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string UniversalProductNumber_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string REF_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string REF_04 { get; set; }
    }
    
    public class X12_ID_128_REF_UniversalProductNumberUPN_2400
    {
        
        public List<string> Codes = new List<string> {"OZ","VP"};
    }
    
    public class REF_OxygenFlowRate_2400
    {
        
        [D(1, typeof(X12_ID_128_REF_OxygenFlowRate_2400), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string OxygenFlowRate_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string REF_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string REF_04 { get; set; }
    }
    
    public class X12_ID_128_REF_OxygenFlowRate_2400
    {
        
        public List<string> Codes = new List<string> {"TP"};
    }
    
    public class REF_AmbulatoryPatientGroupAPG_2400
    {
        
        [D(1, typeof(X12_ID_128_REF_AmbulatoryPatientGroupAPG_2400), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string AmbulatoryPatientGroupNumber_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string REF_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string REF_04 { get; set; }
    }
    
    public class X12_ID_128_REF_AmbulatoryPatientGroupAPG_2400
    {
        
        public List<string> Codes = new List<string> {"1S"};
    }
    
    public class REF_ImmunizationBatchNumber_2400
    {
        
        [D(1, typeof(X12_ID_128_REF_ImmunizationBatchNumber_2400), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string ImmunizationBatchNumber_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string REF_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string REF_04 { get; set; }
    }
    
    public class X12_ID_128_REF_ImmunizationBatchNumber_2400
    {
        
        public List<string> Codes = new List<string> {"BT"};
    }
    
    public class REF_ReferringClinicalLaboratoryImprovementAmendmentCLIAFacilityIdentification_2400
    {
        
        [D(1, typeof(X12_ID_128_REF_ReferringClinicalLaboratoryImprovementAmendmentCLIAFacilityIdentification_2400), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string ReferringCLIANumber_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string REF_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string REF_04 { get; set; }
    }
    
    public class X12_ID_128_REF_ReferringClinicalLaboratoryImprovementAmendmentCLIAFacilityIdentification_2400
    {
        
        public List<string> Codes = new List<string> {"F4"};
    }
    
    public class REF_ClinicalLaboratoryImprovementAmendmentCLIAIdentification_2400
    {
        
        [D(1, typeof(X12_ID_128_REF_ClinicalLaboratoryImprovementAmendmentCLIAIdentification_2400), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string ClinicalLaboratoryImprovementAmendmentNumber_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string REF_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string REF_04 { get; set; }
    }
    
    public class X12_ID_128_REF_ClinicalLaboratoryImprovementAmendmentCLIAIdentification_2400
    {
        
        public List<string> Codes = new List<string> {"X4"};
    }
    
    public class REF_MammographyCertificationNumber_2400
    {
        
        [D(1, typeof(X12_ID_128_REF_MammographyCertificationNumber_2400), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string MammographyCertificationNumber_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string REF_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string REF_04 { get; set; }
    }
    
    public class X12_ID_128_REF_MammographyCertificationNumber_2400
    {
        
        public List<string> Codes = new List<string> {"EW"};
    }
    
    public class REF_LineItemControlNumber_2400
    {
        
        [D(1, typeof(X12_ID_128_REF_LineItemControlNumber_2400), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string LineItemControlNumber_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string REF_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string REF_04 { get; set; }
    }
    
    public class X12_ID_128_REF_LineItemControlNumber_2400
    {
        
        public List<string> Codes = new List<string> {"6R"};
    }
    
    public class REF_PriorAuthorizationOrReferralNumber_2400
    {
        
        [D(1, typeof(X12_ID_128_REF_PriorAuthorizationOrReferralNumber_2400), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string PriorAuthorizationOrReferralNumber_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string REF_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string REF_04 { get; set; }
    }
    
    public class X12_ID_128_REF_PriorAuthorizationOrReferralNumber_2400
    {
        
        public List<string> Codes = new List<string> {"9F","G1"};
    }
    
    public class REF_AdjustedRepricedLineItemReferenceNumber_2400
    {
        
        [D(1, typeof(X12_ID_128_REF_AdjustedRepricedLineItemReferenceNumber_2400), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string AdjustedRepricedLineItemReferenceNumber_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string REF_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string REF_04 { get; set; }
    }
    
    public class X12_ID_128_REF_AdjustedRepricedLineItemReferenceNumber_2400
    {
        
        public List<string> Codes = new List<string> {"9D"};
    }
    
    public class REF_RepricedLineItemReferenceNumber_2400
    {
        
        [D(1, typeof(X12_ID_128_REF_RepricedLineItemReferenceNumber_2400), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string RepricedLineItemReferenceNumber_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string REF_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string REF_04 { get; set; }
    }
    
    public class X12_ID_128_REF_RepricedLineItemReferenceNumber_2400
    {
        
        public List<string> Codes = new List<string> {"9B"};
    }
    
    public class CN1_ContractInformation_2400
    {
        
        [D(1, typeof(X12_ID_1166_CN1_ContractInformation_2400), "1166")]
        public string ContractTypeCode_01 { get; set; }
        [D(2, typeof(X12_R))]
        public string ContractAmount_02 { get; set; }
        [D(3, typeof(X12_R))]
        public string ContractPercentage_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string ContractCode_04 { get; set; }
        [D(5, typeof(X12_R))]
        public string TermsDiscountPercentage_05 { get; set; }
        [D(6, typeof(X12_AN))]
        public string ContractVersionIdentifier_06 { get; set; }
    }
    
    public class X12_ID_1166_CN1_ContractInformation_2400
    {
        
        public List<string> Codes = new List<string> {"01","02","03","04","05","06","09"};
    }
    
    public class MEA_TestResult_2400
    {
        
        [D(1, typeof(X12_ID_737_MEA_TestResult_2400), "737")]
        public string MeasurementReferenceIdentificationCode_01 { get; set; }
        [D(2, typeof(X12_ID_738_MEA_TestResult_2400), "738")]
        public string MeasurementQualifier_02 { get; set; }
        [D(3, typeof(X12_R))]
        public string TestResults_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string MEA_04 { get; set; }
        [D(5, typeof(X12_R))]
        public string MEA_05 { get; set; }
        [D(6, typeof(X12_R))]
        public string MEA_06 { get; set; }
        [D(7, typeof(X12_ID))]
        public string MEA_07 { get; set; }
        [D(8, typeof(X12_ID))]
        public string MEA_08 { get; set; }
        [D(9, typeof(X12_ID))]
        public string MEA_09 { get; set; }
        [D(10, typeof(X12_ID))]
        public string MEA_10 { get; set; }
    }
    
    public class X12_ID_737_MEA_TestResult_2400
    {
        
        public List<string> Codes = new List<string> {"OG","TR"};
    }
    
    public class X12_ID_738_MEA_TestResult_2400
    {
        
        public List<string> Codes = new List<string> {"GRA","HT","R1","R2","R3","R4","ZO"};
    }
    
    public class All_DTP_2400
    {
        
        [S("DTP", 1)]
        public DTP_DateServiceDate_2400 DTP_DateServiceDate_2400 { get; set; }
        [S("DTP", 2)]
        public DTP_DateCertificationRevisionDate_2400 DTP_DateCertificationRevisionDate_2400 { get; set; }
        [S("DTP", 3)]
        public DTP_DateBeginTherapyDate_2400 DTP_DateBeginTherapyDate_2400 { get; set; }
        [S("DTP", 4)]
        public DTP_DateLastCertificationDate_2400 DTP_DateLastCertificationDate_2400 { get; set; }
        [S("DTP", 5)]
        public DTP_DateDateLastSeen_2400 DTP_DateDateLastSeen_2400 { get; set; }
        [S("DTP", 6)]
        public List<DTP_DateTest_2400> DTP_DateTest_2400 { get; set; }
        [S("DTP", 7)]
        public List<DTP_DateOxygenSaturationArterialBloodGasTest_2400> DTP_DateOxygenSaturationArterialBloodGasTest_2400 { get; set; }
        [S("DTP", 8)]
        public DTP_DateShipped_2400 DTP_DateShipped_2400 { get; set; }
        [S("DTP", 9)]
        public DTP_DateOnsetOfCurrentSymptomIllness_2400 DTP_DateOnsetOfCurrentSymptomIllness_2400 { get; set; }
        [S("DTP", 10)]
        public DTP_DateLastXray_2400 DTP_DateLastXray_2400 { get; set; }
        [S("DTP", 11)]
        public DTP_DateAcuteManifestation_2400 DTP_DateAcuteManifestation_2400 { get; set; }
        [S("DTP", 12)]
        public DTP_DateInitialTreatment_2400 DTP_DateInitialTreatment_2400 { get; set; }
        [S("DTP", 13)]
        public DTP_DateSimilarIllnessSymptomOnset_2400 DTP_DateSimilarIllnessSymptomOnset_2400 { get; set; }
    }
    
    public class DTP_DateSimilarIllnessSymptomOnset_2400
    {
        
        [D(1, typeof(X12_ID_374_DTP_DateSimilarIllnessSymptomOnset_2400), "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_1250_DTP_DateSimilarIllnessSymptomOnset_2400), "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string SimilarIllnessOrSymptomDate_03 { get; set; }
    }
    
    public class X12_ID_374_DTP_DateSimilarIllnessSymptomOnset_2400
    {
        
        public List<string> Codes = new List<string> {"438"};
    }
    
    public class X12_ID_1250_DTP_DateSimilarIllnessSymptomOnset_2400
    {
        
        public List<string> Codes = new List<string> {"D8"};
    }
    
    public class DTP_DateInitialTreatment_2400
    {
        
        [D(1, typeof(X12_ID_374_DTP_DateInitialTreatment_2400), "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_1250_DTP_DateInitialTreatment_2400), "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string InitialTreatmentDate_03 { get; set; }
    }
    
    public class X12_ID_374_DTP_DateInitialTreatment_2400
    {
        
        public List<string> Codes = new List<string> {"454"};
    }
    
    public class X12_ID_1250_DTP_DateInitialTreatment_2400
    {
        
        public List<string> Codes = new List<string> {"D8"};
    }
    
    public class DTP_DateAcuteManifestation_2400
    {
        
        [D(1, typeof(X12_ID_374_DTP_DateAcuteManifestation_2400), "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_1250_DTP_DateAcuteManifestation_2400), "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string AcuteManifestationDate_03 { get; set; }
    }
    
    public class X12_ID_374_DTP_DateAcuteManifestation_2400
    {
        
        public List<string> Codes = new List<string> {"453"};
    }
    
    public class X12_ID_1250_DTP_DateAcuteManifestation_2400
    {
        
        public List<string> Codes = new List<string> {"D8"};
    }
    
    public class DTP_DateLastXray_2400
    {
        
        [D(1, typeof(X12_ID_374_DTP_DateLastXray_2400), "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_1250_DTP_DateLastXray_2400), "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string LastXRayDate_03 { get; set; }
    }
    
    public class X12_ID_374_DTP_DateLastXray_2400
    {
        
        public List<string> Codes = new List<string> {"455"};
    }
    
    public class X12_ID_1250_DTP_DateLastXray_2400
    {
        
        public List<string> Codes = new List<string> {"D8"};
    }
    
    public class DTP_DateOnsetOfCurrentSymptomIllness_2400
    {
        
        [D(1, typeof(X12_ID_374_DTP_DateOnsetOfCurrentSymptomIllness_2400), "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_1250_DTP_DateOnsetOfCurrentSymptomIllness_2400), "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string OnsetDate_03 { get; set; }
    }
    
    public class X12_ID_374_DTP_DateOnsetOfCurrentSymptomIllness_2400
    {
        
        public List<string> Codes = new List<string> {"431"};
    }
    
    public class X12_ID_1250_DTP_DateOnsetOfCurrentSymptomIllness_2400
    {
        
        public List<string> Codes = new List<string> {"D8"};
    }
    
    public class DTP_DateShipped_2400
    {
        
        [D(1, typeof(X12_ID_374_DTP_DateShipped_2400), "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_1250_DTP_DateShipped_2400), "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string ShippedDate_03 { get; set; }
    }
    
    public class X12_ID_374_DTP_DateShipped_2400
    {
        
        public List<string> Codes = new List<string> {"011"};
    }
    
    public class X12_ID_1250_DTP_DateShipped_2400
    {
        
        public List<string> Codes = new List<string> {"D8"};
    }
    
    public class DTP_DateOxygenSaturationArterialBloodGasTest_2400
    {
        
        [D(1, typeof(X12_ID_374_DTP_DateOxygenSaturationArterialBloodGasTest_2400), "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_1250_DTP_DateOxygenSaturationArterialBloodGasTest_2400), "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string OxygenSaturationTestDate_03 { get; set; }
    }
    
    public class X12_ID_374_DTP_DateOxygenSaturationArterialBloodGasTest_2400
    {
        
        public List<string> Codes = new List<string> {"119","480","481"};
    }
    
    public class X12_ID_1250_DTP_DateOxygenSaturationArterialBloodGasTest_2400
    {
        
        public List<string> Codes = new List<string> {"D8"};
    }
    
    public class DTP_DateTest_2400
    {
        
        [D(1, typeof(X12_ID_374_DTP_DateTest_2400), "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_1250_DTP_DateTest_2400), "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string TestPerformedDate_03 { get; set; }
    }
    
    public class X12_ID_374_DTP_DateTest_2400
    {
        
        public List<string> Codes = new List<string> {"738","739"};
    }
    
    public class X12_ID_1250_DTP_DateTest_2400
    {
        
        public List<string> Codes = new List<string> {"D8"};
    }
    
    public class DTP_DateDateLastSeen_2400
    {
        
        [D(1, typeof(X12_ID_374_DTP_DateDateLastSeen_2400), "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_1250_DTP_DateDateLastSeen_2400), "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string LastSeenDate_03 { get; set; }
    }
    
    public class X12_ID_374_DTP_DateDateLastSeen_2400
    {
        
        public List<string> Codes = new List<string> {"304"};
    }
    
    public class X12_ID_1250_DTP_DateDateLastSeen_2400
    {
        
        public List<string> Codes = new List<string> {"D8"};
    }
    
    public class DTP_DateLastCertificationDate_2400
    {
        
        [D(1, typeof(X12_ID_374_DTP_DateLastCertificationDate_2400), "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_1250_DTP_DateLastCertificationDate_2400), "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string LastCertificationDate_03 { get; set; }
    }
    
    public class X12_ID_374_DTP_DateLastCertificationDate_2400
    {
        
        public List<string> Codes = new List<string> {"461"};
    }
    
    public class X12_ID_1250_DTP_DateLastCertificationDate_2400
    {
        
        public List<string> Codes = new List<string> {"D8"};
    }
    
    public class DTP_DateBeginTherapyDate_2400
    {
        
        [D(1, typeof(X12_ID_374_DTP_DateBeginTherapyDate_2400), "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_1250_DTP_DateBeginTherapyDate_2400), "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string BeginTherapyDate_03 { get; set; }
    }
    
    public class X12_ID_374_DTP_DateBeginTherapyDate_2400
    {
        
        public List<string> Codes = new List<string> {"463"};
    }
    
    public class X12_ID_1250_DTP_DateBeginTherapyDate_2400
    {
        
        public List<string> Codes = new List<string> {"D8"};
    }
    
    public class DTP_DateCertificationRevisionDate_2400
    {
        
        [D(1, typeof(X12_ID_374_DTP_DateCertificationRevisionDate_2400), "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_1250_DTP_DateCertificationRevisionDate_2400), "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string CertificationRevisionDate_03 { get; set; }
    }
    
    public class X12_ID_374_DTP_DateCertificationRevisionDate_2400
    {
        
        public List<string> Codes = new List<string> {"607"};
    }
    
    public class X12_ID_1250_DTP_DateCertificationRevisionDate_2400
    {
        
        public List<string> Codes = new List<string> {"D8"};
    }
    
    public class DTP_DateServiceDate_2400
    {
        
        [D(1, typeof(X12_ID_374_DTP_DateServiceDate_2400), "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_1250_DTP_DateServiceDate_2400), "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string ServiceDate_03 { get; set; }
    }
    
    public class X12_ID_374_DTP_DateServiceDate_2400
    {
        
        public List<string> Codes = new List<string> {"472"};
    }
    
    public class X12_ID_1250_DTP_DateServiceDate_2400
    {
        
        public List<string> Codes = new List<string> {"D8","RD8"};
    }
    
    public class All_CRC_2400
    {
        
        [S("CRC", 1)]
        public List<CRC_AmbulanceCertification_2400> CRC_AmbulanceCertification_2400 { get; set; }
        [S("CRC", 2)]
        public CRC_HospiceEmployeeIndicator_2400 CRC_HospiceEmployeeIndicator_2400 { get; set; }
        [S("CRC", 3)]
        public List<CRC_DMERCConditionIndicator_2400> CRC_DMERCConditionIndicator_2400 { get; set; }
    }
    
    public class CRC_DMERCConditionIndicator_2400
    {
        
        [D(1, typeof(X12_ID_1136_CRC_DMERCConditionIndicator_2400), "1136")]
        public string CodeCategory_01 { get; set; }
        [D(2, typeof(X12_ID_1073_CRC_DMERCConditionIndicator_2400), "1073")]
        public string CertificationConditionIndicator_02 { get; set; }
        [D(3, typeof(X12_ID_1321_CRC_DMERCConditionIndicator_2400), "1321")]
        public string ConditionIndicator_03 { get; set; }
        [D(4, typeof(X12_ID_1321_CRC_DMERCConditionIndicator_2400), "1321")]
        public string ConditionIndicator_04 { get; set; }
        [D(5, typeof(X12_ID_1321_CRC_DMERCConditionIndicator_2400), "1321")]
        public string ConditionIndicator_05 { get; set; }
        [D(6, typeof(X12_ID_1321_CRC_DMERCConditionIndicator_2400), "1321")]
        public string ConditionIndicator_06 { get; set; }
        [D(7, typeof(X12_ID_1321_CRC_DMERCConditionIndicator_2400), "1321")]
        public string ConditionIndicator_07 { get; set; }
    }
    
    public class X12_ID_1136_CRC_DMERCConditionIndicator_2400
    {
        
        public List<string> Codes = new List<string> {"09","11"};
    }
    
    public class X12_ID_1073_CRC_DMERCConditionIndicator_2400
    {
        
        public List<string> Codes = new List<string> {"N","Y"};
    }
    
    public class X12_ID_1321_CRC_DMERCConditionIndicator_2400
    {
        
        public List<string> Codes = new List<string> {"37","38","AL","P1","ZV"};
    }
    
    public class CRC_HospiceEmployeeIndicator_2400
    {
        
        [D(1, typeof(X12_ID_1136_CRC_HospiceEmployeeIndicator_2400), "1136")]
        public string CodeCategory_01 { get; set; }
        [D(2, typeof(X12_ID_1073_CRC_HospiceEmployeeIndicator_2400), "1073")]
        public string HospiceEmployedProviderIndicator_02 { get; set; }
        [D(3, typeof(X12_ID_1321_CRC_HospiceEmployeeIndicator_2400), "1321")]
        public string ConditionIndicator_03 { get; set; }
        [D(4, typeof(X12_ID))]
        public string CRC_04 { get; set; }
        [D(5, typeof(X12_ID))]
        public string CRC_05 { get; set; }
        [D(6, typeof(X12_ID))]
        public string CRC_06 { get; set; }
        [D(7, typeof(X12_ID))]
        public string CRC_07 { get; set; }
    }
    
    public class X12_ID_1136_CRC_HospiceEmployeeIndicator_2400
    {
        
        public List<string> Codes = new List<string> {"70"};
    }
    
    public class X12_ID_1073_CRC_HospiceEmployeeIndicator_2400
    {
        
        public List<string> Codes = new List<string> {"N","Y"};
    }
    
    public class X12_ID_1321_CRC_HospiceEmployeeIndicator_2400
    {
        
        public List<string> Codes = new List<string> {"65"};
    }
    
    public class CRC_AmbulanceCertification_2400
    {
        
        [D(1, typeof(X12_ID_1136_CRC_AmbulanceCertification_2400), "1136")]
        public string CodeCategory_01 { get; set; }
        [D(2, typeof(X12_ID_1073_CRC_AmbulanceCertification_2400), "1073")]
        public string CertificationConditionIndicator_02 { get; set; }
        [D(3, typeof(X12_ID_1321_CRC_AmbulanceCertification_2400), "1321")]
        public string ConditionCode_03 { get; set; }
        [D(4, typeof(X12_ID_1321_CRC_AmbulanceCertification_2400), "1321")]
        public string ConditionCode_04 { get; set; }
        [D(5, typeof(X12_ID_1321_CRC_AmbulanceCertification_2400), "1321")]
        public string ConditionCode_05 { get; set; }
        [D(6, typeof(X12_ID_1321_CRC_AmbulanceCertification_2400), "1321")]
        public string ConditionCode_06 { get; set; }
        [D(7, typeof(X12_ID_1321_CRC_AmbulanceCertification_2400), "1321")]
        public string ConditionCode_07 { get; set; }
    }
    
    public class X12_ID_1136_CRC_AmbulanceCertification_2400
    {
        
        public List<string> Codes = new List<string> {"07"};
    }
    
    public class X12_ID_1073_CRC_AmbulanceCertification_2400
    {
        
        public List<string> Codes = new List<string> {"N","Y"};
    }
    
    public class X12_ID_1321_CRC_AmbulanceCertification_2400
    {
        
        public List<string> Codes = new List<string> {"01","02","03","04","05","06","07","08","09","60"};
    }
    
    public class CR5_HomeOxygenTherapyInformation_2400
    {
        
        [D(1, typeof(X12_ID_1322_CR5_HomeOxygenTherapyInformation_2400), "1322")]
        public string CertificationTypeCode_01 { get; set; }
        [D(2, typeof(X12_R))]
        public string TreatmentPeriodCount_02 { get; set; }
        [D(3, typeof(X12_ID))]
        public string CR5_03 { get; set; }
        [D(4, typeof(X12_ID))]
        public string CR5_04 { get; set; }
        [D(5, typeof(X12_AN))]
        public string CR5_05 { get; set; }
        [D(6, typeof(X12_R))]
        public string CR5_06 { get; set; }
        [D(7, typeof(X12_R))]
        public string CR5_07 { get; set; }
        [D(8, typeof(X12_R))]
        public string CR5_08 { get; set; }
        [D(9, typeof(X12_AN))]
        public string CR5_09 { get; set; }
        [D(10, typeof(X12_R))]
        public string ArterialBloodGasQuantity_10 { get; set; }
        [D(11, typeof(X12_R))]
        public string OxygenSaturationQuantity_11 { get; set; }
        [D(12, typeof(X12_ID_1349_CR5_HomeOxygenTherapyInformation_2400), "1349")]
        public string OxygenTestConditionCode_12 { get; set; }
        [D(13, typeof(X12_ID_1350_CR5_HomeOxygenTherapyInformation_2400), "1350")]
        public string OxygenTestFindingsCode_13 { get; set; }
        [D(14, typeof(X12_ID_1350_CR5_HomeOxygenTherapyInformation_2400), "1350")]
        public string OxygenTestFindingsCode_14 { get; set; }
        [D(15, typeof(X12_ID_1350_CR5_HomeOxygenTherapyInformation_2400), "1350")]
        public string OxygenTestFindingsCode_15 { get; set; }
        [D(16, typeof(X12_R))]
        public string CR5_16 { get; set; }
        [D(17, typeof(X12_ID))]
        public string CR5_17 { get; set; }
        [D(18, typeof(X12_ID))]
        public string CR5_18 { get; set; }
    }
    
    public class X12_ID_1322_CR5_HomeOxygenTherapyInformation_2400
    {
        
        public List<string> Codes = new List<string> {"I","R","S"};
    }
    
    public class X12_ID_1349_CR5_HomeOxygenTherapyInformation_2400
    {
        
        public List<string> Codes = new List<string> {"E","R","S"};
    }
    
    public class X12_ID_1350_CR5_HomeOxygenTherapyInformation_2400
    {
        
        public List<string> Codes = new List<string> {"1"};
    }
    
    public class CR3_DurableMedicalEquipmentCertification_2400
    {
        
        [D(1, typeof(X12_ID_1322_CR3_DurableMedicalEquipmentCertification_2400), "1322")]
        public string CertificationTypeCode_01 { get; set; }
        [D(2, typeof(X12_ID_355_CR3_DurableMedicalEquipmentCertification_2400), "355")]
        public string UnitOrBasisForMeasurementCode_02 { get; set; }
        [D(3, typeof(X12_R))]
        public string DurableMedicalEquipmentDuration_03 { get; set; }
        [D(4, typeof(X12_ID))]
        public string CR3_04 { get; set; }
        [D(5, typeof(X12_AN))]
        public string CR3_05 { get; set; }
    }
    
    public class X12_ID_1322_CR3_DurableMedicalEquipmentCertification_2400
    {
        
        public List<string> Codes = new List<string> {"I","R","S"};
    }
    
    public class X12_ID_355_CR3_DurableMedicalEquipmentCertification_2400
    {
        
        public List<string> Codes = new List<string> {"MO"};
    }
    
    public class CR2_SpinalManipulationServiceInformation_2400
    {
        
        [D(1, typeof(X12_N0))]
        public string CR2_01 { get; set; }
        [D(2, typeof(X12_R))]
        public string CR2_02 { get; set; }
        [D(3, typeof(X12_ID))]
        public string CR2_03 { get; set; }
        [D(4, typeof(X12_ID))]
        public string CR2_04 { get; set; }
        [D(5, typeof(X12_ID))]
        public string CR2_05 { get; set; }
        [D(6, typeof(X12_R))]
        public string CR2_06 { get; set; }
        [D(7, typeof(X12_R))]
        public string CR2_07 { get; set; }
        [D(8, typeof(X12_ID_1342_CR2_SpinalManipulationServiceInformation_2400), "1342")]
        public string PatientConditionCode_08 { get; set; }
        [D(9, typeof(X12_ID))]
        public string CR2_09 { get; set; }
        [D(10, typeof(X12_AN))]
        public string PatientConditionDescription_10 { get; set; }
        [D(11, typeof(X12_AN))]
        public string PatientConditionDescription_11 { get; set; }
        [D(12, typeof(X12_ID_1073_CR2_SpinalManipulationServiceInformation_2400), "1073")]
        public string XrayAvailabilityIndicator_12 { get; set; }
    }
    
    public class X12_ID_1342_CR2_SpinalManipulationServiceInformation_2400
    {
        
        public List<string> Codes = new List<string> {"A","C","D","E","F","G","M"};
    }
    
    public class X12_ID_1073_CR2_SpinalManipulationServiceInformation_2400
    {
        
        public List<string> Codes = new List<string> {"N","Y"};
    }
    
    public class CR1_AmbulanceTransportInformation_2400
    {
        
        [D(1, typeof(X12_ID_355_CR1_AmbulanceTransportInformation_2400), "355")]
        public string UnitOrBasisForMeasurementCode_01 { get; set; }
        [D(2, typeof(X12_R))]
        public string PatientWeight_02 { get; set; }
        [D(3, typeof(X12_ID_1316_CR1_AmbulanceTransportInformation_2400), "1316")]
        public string AmbulanceTransportCode_03 { get; set; }
        [D(4, typeof(X12_ID_1317_CR1_AmbulanceTransportInformation_2400), "1317")]
        public string AmbulanceTransportReasonCode_04 { get; set; }
        [D(5, typeof(X12_ID_355_CR1_AmbulanceTransportInformation_2400), "355")]
        public string UnitOrBasisForMeasurementCode_05 { get; set; }
        [D(6, typeof(X12_R))]
        public string TransportDistance_06 { get; set; }
        [D(7, typeof(X12_AN))]
        public string CR1_07 { get; set; }
        [D(8, typeof(X12_AN))]
        public string CR1_08 { get; set; }
        [D(9, typeof(X12_AN))]
        public string RoundTripPurposeDescription_09 { get; set; }
        [D(10, typeof(X12_AN))]
        public string StretcherPurposeDescription_10 { get; set; }
    }
    
    public class X12_ID_355_CR1_AmbulanceTransportInformation_2400
    {
        
        public List<string> Codes = new List<string> {"LB"};
    }
    
    public class X12_ID_1316_CR1_AmbulanceTransportInformation_2400
    {
        
        public List<string> Codes = new List<string> {"I","R","T","X"};
    }
    
    public class X12_ID_1317_CR1_AmbulanceTransportInformation_2400
    {
        
        public List<string> Codes = new List<string> {"A","B","C","D","E"};
    }
    
    public class PWK_DMERCCMNIndicator_2400
    {
        
        [D(1, typeof(X12_ID_755_PWK_DMERCCMNIndicator_2400), "755")]
        public string AttachmentReportTypeCode_01 { get; set; }
        [D(2, typeof(X12_ID_756_PWK_DMERCCMNIndicator_2400), "756")]
        public string AttachmentTransmissionCode_02 { get; set; }
        [D(3, typeof(X12_N0))]
        public string PWK_03 { get; set; }
        [D(4, typeof(X12_ID))]
        public string PWK_04 { get; set; }
        [D(5, typeof(X12_ID))]
        public string PWK_05 { get; set; }
        [D(6, typeof(X12_AN))]
        public string PWK_06 { get; set; }
        [D(7, typeof(X12_AN))]
        public string PWK_07 { get; set; }
        [D(8, typeof(X12_AN))]
        public string PWK_08 { get; set; }
        [D(9, typeof(X12_ID))]
        public string PWK_09 { get; set; }
    }
    
    public class X12_ID_755_PWK_DMERCCMNIndicator_2400
    {
        
        public List<string> Codes = new List<string> {"CT"};
    }
    
    public class X12_ID_756_PWK_DMERCCMNIndicator_2400
    {
        
        public List<string> Codes = new List<string> {"AB","AD","AF","AG","NS"};
    }
    
    public class SV5_DurableMedicalEquipmentService_2400
    {
        
        [C(1)]
        public C003_19141319 C003_19141319 { get; set; }
        [D(2, typeof(X12_ID_355_SV5_DurableMedicalEquipmentService_2400), "355")]
        public string UnitOrBasisForMeasurementCode_02 { get; set; }
        [D(3, typeof(X12_R))]
        public string LengthOfMedicalNecessity_03 { get; set; }
        [D(4, typeof(X12_R))]
        public string DMERentalPrice_04 { get; set; }
        [D(5, typeof(X12_R))]
        public string DMEPurchasePrice_05 { get; set; }
        [D(6, typeof(X12_ID_594_SV5_DurableMedicalEquipmentService_2400), "594")]
        public string RentalUnitPriceIndicator_06 { get; set; }
        [D(7, typeof(X12_ID))]
        public string SV5_07 { get; set; }
    }
    
    public class X12_ID_355_SV5_DurableMedicalEquipmentService_2400
    {
        
        public List<string> Codes = new List<string> {"DA"};
    }
    
    public class X12_ID_594_SV5_DurableMedicalEquipmentService_2400
    {
        
        public List<string> Codes = new List<string> {"1","4","6"};
    }
    
    public class C003_19141319
    {
        
        [D(1, typeof(X12_ID_235_C003_19141319), "235")]
        public string ProcedureIdentifier_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string ProcedureCode_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string SV5_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string SV5_04 { get; set; }
        [D(5, typeof(X12_AN))]
        public string SV5_05 { get; set; }
        [D(6, typeof(X12_AN))]
        public string SV5_06 { get; set; }
        [D(7, typeof(X12_AN))]
        public string SV5_07 { get; set; }
    }
    
    public class X12_ID_235_C003_19141319
    {
        
        public List<string> Codes = new List<string> {"HC"};
    }
    
    public class SV1_ProfessionalService_2400
    {
        
        [C(1)]
        public C003_701728622 C003_701728622 { get; set; }
        [D(2, typeof(X12_R))]
        public string LineItemChargeAmount_02 { get; set; }
        [D(3, typeof(X12_ID_355_SV1_ProfessionalService_2400), "355")]
        public string UnitOrBasisForMeasurementCode_03 { get; set; }
        [D(4, typeof(X12_R))]
        public string ServiceUnitCount_04 { get; set; }
        [D(5, typeof(X12_AN))]
        public string PlaceOfServiceCode_05 { get; set; }
        [D(6, typeof(X12_ID))]
        public string SV1_06 { get; set; }
        [C(7)]
        public C004_461136328 C004_461136328 { get; set; }
        [D(8, typeof(X12_R))]
        public string SV1_08 { get; set; }
        [D(9, typeof(X12_ID_1073_SV1_ProfessionalService_2400), "1073")]
        public string EmergencyIndicator_09 { get; set; }
        [D(10, typeof(X12_ID))]
        public string SV1_10 { get; set; }
        [D(11, typeof(X12_ID_1073_SV1_ProfessionalService_2400), "1073")]
        public string EPSDTIndicator_11 { get; set; }
        [D(12, typeof(X12_ID_1073_SV1_ProfessionalService_2400), "1073")]
        public string FamilyPlanningIndicator_12 { get; set; }
        [D(13, typeof(X12_ID))]
        public string SV1_13 { get; set; }
        [D(14, typeof(X12_AN))]
        public string SV1_14 { get; set; }
        [D(15, typeof(X12_ID_1327_SV1_ProfessionalService_2400), "1327")]
        public string CoPayStatusCode_15 { get; set; }
        [D(16, typeof(X12_ID))]
        public string SV1_16 { get; set; }
        [D(17, typeof(X12_AN))]
        public string SV1_17 { get; set; }
        [D(18, typeof(X12_ID))]
        public string SV1_18 { get; set; }
        [D(19, typeof(X12_R))]
        public string SV1_19 { get; set; }
        [D(20, typeof(X12_ID))]
        public string SV1_20 { get; set; }
        [D(21, typeof(X12_ID))]
        public string SV1_21 { get; set; }
    }
    
    public class X12_ID_355_SV1_ProfessionalService_2400
    {
        
        public List<string> Codes = new List<string> {"F2","MJ","UN"};
    }
    
    public class X12_ID_1073_SV1_ProfessionalService_2400
    {
        
        public List<string> Codes = new List<string> {"Y"};
    }
    
    public class X12_ID_1327_SV1_ProfessionalService_2400
    {
        
        public List<string> Codes = new List<string> {"0"};
    }
    
    public class C004_461136328
    {
        
        [D(1, typeof(X12_N0))]
        public string DiagnosisCodePointer_01 { get; set; }
        [D(2, typeof(X12_N0))]
        public string DiagnosisCodePointer_02 { get; set; }
        [D(3, typeof(X12_N0))]
        public string DiagnosisCodePointer_03 { get; set; }
        [D(4, typeof(X12_N0))]
        public string DiagnosisCodePointer_04 { get; set; }
    }
    
    public class C003_701728622
    {
        
        [D(1, typeof(X12_ID_235_C003_701728622), "235")]
        public string ProductOrServiceIDQualifier_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string ProcedureCode_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string ProcedureModifier_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string ProcedureModifier_04 { get; set; }
        [D(5, typeof(X12_AN))]
        public string ProcedureModifier_05 { get; set; }
        [D(6, typeof(X12_AN))]
        public string ProcedureModifier_06 { get; set; }
        [D(7, typeof(X12_AN))]
        public string SV1_07 { get; set; }
    }
    
    public class X12_ID_235_C003_701728622
    {
        
        public List<string> Codes = new List<string> {"HC","IV","ZZ"};
    }
    
    public class LX_ServiceLine_2400
    {
        
        [D(1, typeof(X12_N0))]
        public string AssignedNumber_01 { get; set; }
    }
    
    public class Loop_2320
    {
        
        [S("SBR", 1)]
        public SBR_OtherSubscriberInformation_2320 SBR_OtherSubscriberInformation_2320 { get; set; }
        [S("CAS", 2)]
        public List<CAS_ClaimLevelAdjustments_2320> CAS_ClaimLevelAdjustments_2320 { get; set; }
        [A(3)]
        public All_AMT_2320 All_AMT_2320 { get; set; }
        [S("DMG", 4)]
        public DMG_SubscriberDemographicInformation_2320 DMG_SubscriberDemographicInformation_2320 { get; set; }
        [S("OI", 5)]
        public OI_OtherInsuranceCoverageInformation_2320 OI_OtherInsuranceCoverageInformation_2320 { get; set; }
        [S("MOA", 6)]
        public MOA_MedicareOutpatientAdjudicationInformation_2320 MOA_MedicareOutpatientAdjudicationInformation_2320 { get; set; }
        [A(7)]
        public All_2330 All_2330 { get; set; }
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
        
        [S("NM1", 1)]
        public NM1_OtherPayerSupervisingProvider_2330H NM1_OtherPayerSupervisingProvider_2330H { get; set; }
        [S("REF", 2)]
        public List<REF_OtherPayerSupervisingProviderIdentification_2330H> REF_OtherPayerSupervisingProviderIdentification_2330H { get; set; }
    }
    
    public class REF_OtherPayerSupervisingProviderIdentification_2330H
    {
        
        [D(1, typeof(X12_ID_128_REF_OtherPayerSupervisingProviderIdentification_2330H), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string OtherPayerSupervisingProviderIdentifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string REF_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string REF_04 { get; set; }
    }
    
    public class X12_ID_128_REF_OtherPayerSupervisingProviderIdentification_2330H
    {
        
        public List<string> Codes = new List<string> {"1B","1C","1D","EI","G2","N5"};
    }
    
    public class NM1_OtherPayerSupervisingProvider_2330H
    {
        
        [D(1, typeof(X12_ID_98_NM1_OtherPayerSupervisingProvider_2330H), "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, typeof(X12_ID_1065_NM1_OtherPayerSupervisingProvider_2330H), "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string NM1_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string NM1_04 { get; set; }
        [D(5, typeof(X12_AN))]
        public string NM1_05 { get; set; }
        [D(6, typeof(X12_AN))]
        public string NM1_06 { get; set; }
        [D(7, typeof(X12_AN))]
        public string NM1_07 { get; set; }
        [D(8, typeof(X12_ID))]
        public string NM1_08 { get; set; }
        [D(9, typeof(X12_AN))]
        public string NM1_09 { get; set; }
        [D(10, typeof(X12_ID))]
        public string NM1_10 { get; set; }
        [D(11, typeof(X12_ID))]
        public string NM1_11 { get; set; }
    }
    
    public class X12_ID_98_NM1_OtherPayerSupervisingProvider_2330H
    {
        
        public List<string> Codes = new List<string> {"DQ"};
    }
    
    public class X12_ID_1065_NM1_OtherPayerSupervisingProvider_2330H
    {
        
        public List<string> Codes = new List<string> {"1"};
    }
    
    public class Loop_2330G
    {
        
        [S("NM1", 1)]
        public NM1_OtherPayerServiceFacilityLocation_2330G NM1_OtherPayerServiceFacilityLocation_2330G { get; set; }
        [S("REF", 2)]
        public List<REF_OtherPayerServiceFacilityLocationIdentification_2330G> REF_OtherPayerServiceFacilityLocationIdentification_2330G { get; set; }
    }
    
    public class REF_OtherPayerServiceFacilityLocationIdentification_2330G
    {
        
        [D(1, typeof(X12_ID_128_REF_OtherPayerServiceFacilityLocationIdentification_2330G), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string OtherPayerServiceFacilityLocationIdentifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string REF_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string REF_04 { get; set; }
    }
    
    public class X12_ID_128_REF_OtherPayerServiceFacilityLocationIdentification_2330G
    {
        
        public List<string> Codes = new List<string> {"1A","1B","1C","1D","G2","LU","N5"};
    }
    
    public class NM1_OtherPayerServiceFacilityLocation_2330G
    {
        
        [D(1, typeof(X12_ID_98_NM1_OtherPayerServiceFacilityLocation_2330G), "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, typeof(X12_ID_1065_NM1_OtherPayerServiceFacilityLocation_2330G), "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string NM1_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string NM1_04 { get; set; }
        [D(5, typeof(X12_AN))]
        public string NM1_05 { get; set; }
        [D(6, typeof(X12_AN))]
        public string NM1_06 { get; set; }
        [D(7, typeof(X12_AN))]
        public string NM1_07 { get; set; }
        [D(8, typeof(X12_ID))]
        public string NM1_08 { get; set; }
        [D(9, typeof(X12_AN))]
        public string NM1_09 { get; set; }
        [D(10, typeof(X12_ID))]
        public string NM1_10 { get; set; }
        [D(11, typeof(X12_ID))]
        public string NM1_11 { get; set; }
    }
    
    public class X12_ID_98_NM1_OtherPayerServiceFacilityLocation_2330G
    {
        
        public List<string> Codes = new List<string> {"77","FA","LI","TL"};
    }
    
    public class X12_ID_1065_NM1_OtherPayerServiceFacilityLocation_2330G
    {
        
        public List<string> Codes = new List<string> {"2"};
    }
    
    public class Loop_2330F
    {
        
        [S("NM1", 1)]
        public NM1_OtherPayerPurchasedServiceProvider_2330F NM1_OtherPayerPurchasedServiceProvider_2330F { get; set; }
        [S("REF", 2)]
        public List<REF_OtherPayerPurchasedServiceProviderIdentification_2330F> REF_OtherPayerPurchasedServiceProviderIdentification_2330F { get; set; }
    }
    
    public class REF_OtherPayerPurchasedServiceProviderIdentification_2330F
    {
        
        [D(1, typeof(X12_ID_128_REF_OtherPayerPurchasedServiceProviderIdentification_2330F), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string OtherPayerPurchasedServiceProviderIdentifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string REF_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string REF_04 { get; set; }
    }
    
    public class X12_ID_128_REF_OtherPayerPurchasedServiceProviderIdentification_2330F
    {
        
        public List<string> Codes = new List<string> {"1A","1B","1C","1D","EI","G2","LU","N5"};
    }
    
    public class NM1_OtherPayerPurchasedServiceProvider_2330F
    {
        
        [D(1, typeof(X12_ID_98_NM1_OtherPayerPurchasedServiceProvider_2330F), "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, typeof(X12_ID_1065_NM1_OtherPayerPurchasedServiceProvider_2330F), "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string NM1_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string NM1_04 { get; set; }
        [D(5, typeof(X12_AN))]
        public string NM1_05 { get; set; }
        [D(6, typeof(X12_AN))]
        public string NM1_06 { get; set; }
        [D(7, typeof(X12_AN))]
        public string NM1_07 { get; set; }
        [D(8, typeof(X12_ID))]
        public string NM1_08 { get; set; }
        [D(9, typeof(X12_AN))]
        public string NM1_09 { get; set; }
        [D(10, typeof(X12_ID))]
        public string NM1_10 { get; set; }
        [D(11, typeof(X12_ID))]
        public string NM1_11 { get; set; }
    }
    
    public class X12_ID_98_NM1_OtherPayerPurchasedServiceProvider_2330F
    {
        
        public List<string> Codes = new List<string> {"QB"};
    }
    
    public class X12_ID_1065_NM1_OtherPayerPurchasedServiceProvider_2330F
    {
        
        public List<string> Codes = new List<string> {"1","2"};
    }
    
    public class Loop_2330E
    {
        
        [S("NM1", 1)]
        public NM1_OtherPayerRenderingProvider_2330E NM1_OtherPayerRenderingProvider_2330E { get; set; }
        [S("REF", 2)]
        public List<REF_OtherPayerRenderingProviderSecondaryIdentification_2330E> REF_OtherPayerRenderingProviderSecondaryIdentification_2330E { get; set; }
    }
    
    public class REF_OtherPayerRenderingProviderSecondaryIdentification_2330E
    {
        
        [D(1, typeof(X12_ID_128_REF_OtherPayerRenderingProviderSecondaryIdentification_2330E), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string OtherPayerRenderingProviderSecondaryIdentifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string REF_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string REF_04 { get; set; }
    }
    
    public class X12_ID_128_REF_OtherPayerRenderingProviderSecondaryIdentification_2330E
    {
        
        public List<string> Codes = new List<string> {"1B","1C","1D","EI","G2","LU","N5"};
    }
    
    public class NM1_OtherPayerRenderingProvider_2330E
    {
        
        [D(1, typeof(X12_ID_98_NM1_OtherPayerRenderingProvider_2330E), "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, typeof(X12_ID_1065_NM1_OtherPayerRenderingProvider_2330E), "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string NM1_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string NM1_04 { get; set; }
        [D(5, typeof(X12_AN))]
        public string NM1_05 { get; set; }
        [D(6, typeof(X12_AN))]
        public string NM1_06 { get; set; }
        [D(7, typeof(X12_AN))]
        public string NM1_07 { get; set; }
        [D(8, typeof(X12_ID))]
        public string NM1_08 { get; set; }
        [D(9, typeof(X12_AN))]
        public string NM1_09 { get; set; }
        [D(10, typeof(X12_ID))]
        public string NM1_10 { get; set; }
        [D(11, typeof(X12_ID))]
        public string NM1_11 { get; set; }
    }
    
    public class X12_ID_98_NM1_OtherPayerRenderingProvider_2330E
    {
        
        public List<string> Codes = new List<string> {"82"};
    }
    
    public class X12_ID_1065_NM1_OtherPayerRenderingProvider_2330E
    {
        
        public List<string> Codes = new List<string> {"1","2"};
    }
    
    public class Loop_2330D
    {
        
        [S("NM1", 1)]
        public NM1_OtherPayerReferringProvider_2330D NM1_OtherPayerReferringProvider_2330D { get; set; }
        [S("REF", 2)]
        public List<REF_OtherPayerReferringProviderIdentification_2330D> REF_OtherPayerReferringProviderIdentification_2330D { get; set; }
    }
    
    public class REF_OtherPayerReferringProviderIdentification_2330D
    {
        
        [D(1, typeof(X12_ID_128_REF_OtherPayerReferringProviderIdentification_2330D), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string OtherPayerReferringProviderIdentifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string REF_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string REF_04 { get; set; }
    }
    
    public class X12_ID_128_REF_OtherPayerReferringProviderIdentification_2330D
    {
        
        public List<string> Codes = new List<string> {"1B","1C","1D","EI","G2","LU","N5"};
    }
    
    public class NM1_OtherPayerReferringProvider_2330D
    {
        
        [D(1, typeof(X12_ID_98_NM1_OtherPayerReferringProvider_2330D), "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, typeof(X12_ID_1065_NM1_OtherPayerReferringProvider_2330D), "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string NM1_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string NM1_04 { get; set; }
        [D(5, typeof(X12_AN))]
        public string NM1_05 { get; set; }
        [D(6, typeof(X12_AN))]
        public string NM1_06 { get; set; }
        [D(7, typeof(X12_AN))]
        public string NM1_07 { get; set; }
        [D(8, typeof(X12_ID))]
        public string NM1_08 { get; set; }
        [D(9, typeof(X12_AN))]
        public string NM1_09 { get; set; }
        [D(10, typeof(X12_ID))]
        public string NM1_10 { get; set; }
        [D(11, typeof(X12_ID))]
        public string NM1_11 { get; set; }
    }
    
    public class X12_ID_98_NM1_OtherPayerReferringProvider_2330D
    {
        
        public List<string> Codes = new List<string> {"DN","P3"};
    }
    
    public class X12_ID_1065_NM1_OtherPayerReferringProvider_2330D
    {
        
        public List<string> Codes = new List<string> {"1","2"};
    }
    
    public class Loop_2330C
    {
        
        [S("NM1", 1)]
        public NM1_OtherPayerPatientInformation_2330C NM1_OtherPayerPatientInformation_2330C { get; set; }
        [S("REF", 2)]
        public List<REF_OtherPayerPatientIdentification_2330C> REF_OtherPayerPatientIdentification_2330C { get; set; }
    }
    
    public class REF_OtherPayerPatientIdentification_2330C
    {
        
        [D(1, typeof(X12_ID_128_REF_OtherPayerPatientIdentification_2330C), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string OtherPayerPatientSecondaryIdentifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string REF_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string REF_04 { get; set; }
    }
    
    public class X12_ID_128_REF_OtherPayerPatientIdentification_2330C
    {
        
        public List<string> Codes = new List<string> {"1W","23","IG","SY"};
    }
    
    public class NM1_OtherPayerPatientInformation_2330C
    {
        
        [D(1, typeof(X12_ID_98_NM1_OtherPayerPatientInformation_2330C), "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, typeof(X12_ID_1065_NM1_OtherPayerPatientInformation_2330C), "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string NM1_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string NM1_04 { get; set; }
        [D(5, typeof(X12_AN))]
        public string NM1_05 { get; set; }
        [D(6, typeof(X12_AN))]
        public string NM1_06 { get; set; }
        [D(7, typeof(X12_AN))]
        public string NM1_07 { get; set; }
        [D(8, typeof(X12_ID_66_NM1_OtherPayerPatientInformation_2330C), "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, typeof(X12_AN))]
        public string OtherPayerPatientPrimaryIdentifier_09 { get; set; }
        [D(10, typeof(X12_ID))]
        public string NM1_10 { get; set; }
        [D(11, typeof(X12_ID))]
        public string NM1_11 { get; set; }
    }
    
    public class X12_ID_98_NM1_OtherPayerPatientInformation_2330C
    {
        
        public List<string> Codes = new List<string> {"QC"};
    }
    
    public class X12_ID_1065_NM1_OtherPayerPatientInformation_2330C
    {
        
        public List<string> Codes = new List<string> {"1"};
    }
    
    public class X12_ID_66_NM1_OtherPayerPatientInformation_2330C
    {
        
        public List<string> Codes = new List<string> {"MI"};
    }
    
    public class Loop_2330B
    {
        
        [S("NM1", 1)]
        public NM1_OtherPayerName_2330B NM1_OtherPayerName_2330B { get; set; }
        [S("PER", 2)]
        public List<PER_OtherPayerContactInformation_2330B> PER_OtherPayerContactInformation_2330B { get; set; }
        [S("DTP", 3)]
        public DTP_ClaimAdjudicationDate_2330B DTP_ClaimAdjudicationDate_2330B { get; set; }
        [A(4)]
        public All_REF_2330B All_REF_2330B { get; set; }
    }
    
    public class All_REF_2330B
    {
        
        [S("REF", 1)]
        public List<REF_OtherPayerSecondaryIdentifier_2330B> REF_OtherPayerSecondaryIdentifier_2330B { get; set; }
        [S("REF", 2)]
        public List<REF_OtherPayerPriorAuthorizationOrReferralNumber_2330B> REF_OtherPayerPriorAuthorizationOrReferralNumber_2330B { get; set; }
        [S("REF", 3)]
        public List<REF_OtherPayerClaimAdjustmentIndicator_2330B> REF_OtherPayerClaimAdjustmentIndicator_2330B { get; set; }
    }
    
    public class REF_OtherPayerClaimAdjustmentIndicator_2330B
    {
        
        [D(1, typeof(X12_ID_128_REF_OtherPayerClaimAdjustmentIndicator_2330B), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string OtherPayerClaimAdjustmentIndicator_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string REF_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string REF_04 { get; set; }
    }
    
    public class X12_ID_128_REF_OtherPayerClaimAdjustmentIndicator_2330B
    {
        
        public List<string> Codes = new List<string> {"T4"};
    }
    
    public class REF_OtherPayerPriorAuthorizationOrReferralNumber_2330B
    {
        
        [D(1, typeof(X12_ID_128_REF_OtherPayerPriorAuthorizationOrReferralNumber_2330B), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string OtherPayerPriorAuthorizationOrReferralNumber_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string REF_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string REF_04 { get; set; }
    }
    
    public class X12_ID_128_REF_OtherPayerPriorAuthorizationOrReferralNumber_2330B
    {
        
        public List<string> Codes = new List<string> {"9F","G1"};
    }
    
    public class REF_OtherPayerSecondaryIdentifier_2330B
    {
        
        [D(1, typeof(X12_ID_128_REF_OtherPayerSecondaryIdentifier_2330B), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string OtherPayerSecondaryIdentifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string REF_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string REF_04 { get; set; }
    }
    
    public class X12_ID_128_REF_OtherPayerSecondaryIdentifier_2330B
    {
        
        public List<string> Codes = new List<string> {"2U","F8","FY","NF","TJ"};
    }
    
    public class DTP_ClaimAdjudicationDate_2330B
    {
        
        [D(1, typeof(X12_ID_374_DTP_ClaimAdjudicationDate_2330B), "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_1250_DTP_ClaimAdjudicationDate_2330B), "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string AdjudicationOrPaymentDate_03 { get; set; }
    }
    
    public class X12_ID_374_DTP_ClaimAdjudicationDate_2330B
    {
        
        public List<string> Codes = new List<string> {"573"};
    }
    
    public class X12_ID_1250_DTP_ClaimAdjudicationDate_2330B
    {
        
        public List<string> Codes = new List<string> {"D8"};
    }
    
    public class PER_OtherPayerContactInformation_2330B
    {
        
        [D(1, typeof(X12_ID_366_PER_OtherPayerContactInformation_2330B), "366")]
        public string ContactFunctionCode_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string OtherPayerContactName_02 { get; set; }
        [D(3, typeof(X12_ID_365_PER_OtherPayerContactInformation_2330B), "365")]
        public string CommunicationNumberQualifier_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string CommunicationNumber_04 { get; set; }
        [D(5, typeof(X12_ID_365_PER_OtherPayerContactInformation_2330B), "365")]
        public string CommunicationNumberQualifier_05 { get; set; }
        [D(6, typeof(X12_AN))]
        public string CommunicationNumber_06 { get; set; }
        [D(7, typeof(X12_ID_365_PER_OtherPayerContactInformation_2330B), "365")]
        public string CommunicationNumberQualifier_07 { get; set; }
        [D(8, typeof(X12_AN))]
        public string CommunicationNumber_08 { get; set; }
        [D(9, typeof(X12_AN))]
        public string PER_09 { get; set; }
    }
    
    public class X12_ID_366_PER_OtherPayerContactInformation_2330B
    {
        
        public List<string> Codes = new List<string> {"IC"};
    }
    
    public class X12_ID_365_PER_OtherPayerContactInformation_2330B
    {
        
        public List<string> Codes = new List<string> {"ED","EM","FX","TE"};
    }
    
    public class NM1_OtherPayerName_2330B
    {
        
        [D(1, typeof(X12_ID_98_NM1_OtherPayerName_2330B), "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, typeof(X12_ID_1065_NM1_OtherPayerName_2330B), "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string OtherPayerLastOrOrganizationName_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string NM1_04 { get; set; }
        [D(5, typeof(X12_AN))]
        public string NM1_05 { get; set; }
        [D(6, typeof(X12_AN))]
        public string NM1_06 { get; set; }
        [D(7, typeof(X12_AN))]
        public string NM1_07 { get; set; }
        [D(8, typeof(X12_ID_66_NM1_OtherPayerName_2330B), "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, typeof(X12_AN))]
        public string OtherPayerPrimaryIdentifier_09 { get; set; }
        [D(10, typeof(X12_ID))]
        public string NM1_10 { get; set; }
        [D(11, typeof(X12_ID))]
        public string NM1_11 { get; set; }
    }
    
    public class X12_ID_98_NM1_OtherPayerName_2330B
    {
        
        public List<string> Codes = new List<string> {"PR"};
    }
    
    public class X12_ID_1065_NM1_OtherPayerName_2330B
    {
        
        public List<string> Codes = new List<string> {"2"};
    }
    
    public class X12_ID_66_NM1_OtherPayerName_2330B
    {
        
        public List<string> Codes = new List<string> {"PI","XV"};
    }
    
    public class Loop_2330A
    {
        
        [S("NM1", 1)]
        public NM1_OtherSubscriberName_2330A NM1_OtherSubscriberName_2330A { get; set; }
        [S("N3", 2)]
        public N3_OtherSubscriberAddress_2330A N3_OtherSubscriberAddress_2330A { get; set; }
        [S("N4", 3)]
        public N4_OtherSubscriberCityStateZIPCode_2330A N4_OtherSubscriberCityStateZIPCode_2330A { get; set; }
        [S("REF", 4)]
        public List<REF_OtherSubscriberSecondaryIdentification_2330A> REF_OtherSubscriberSecondaryIdentification_2330A { get; set; }
    }
    
    public class REF_OtherSubscriberSecondaryIdentification_2330A
    {
        
        [D(1, typeof(X12_ID_128_REF_OtherSubscriberSecondaryIdentification_2330A), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string OtherInsuredAdditionalIdentifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string REF_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string REF_04 { get; set; }
    }
    
    public class X12_ID_128_REF_OtherSubscriberSecondaryIdentification_2330A
    {
        
        public List<string> Codes = new List<string> {"1W","23","IG","SY"};
    }
    
    public class N4_OtherSubscriberCityStateZIPCode_2330A
    {
        
        [D(1, typeof(X12_AN))]
        public string OtherInsuredCityName_01 { get; set; }
        [D(2, typeof(X12_ID))]
        public string OtherInsuredStateCode_02 { get; set; }
        [D(3, typeof(X12_ID))]
        public string OtherInsuredPostalZoneOrZIPCode_03 { get; set; }
        [D(4, typeof(X12_ID))]
        public string CountryCode_04 { get; set; }
        [D(5, typeof(X12_ID))]
        public string N4_05 { get; set; }
        [D(6, typeof(X12_AN))]
        public string N4_06 { get; set; }
    }
    
    public class N3_OtherSubscriberAddress_2330A
    {
        
        [D(1, typeof(X12_AN))]
        public string OtherInsuredAddressLine_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string OtherInsuredAddressLine_02 { get; set; }
    }
    
    public class NM1_OtherSubscriberName_2330A
    {
        
        [D(1, typeof(X12_ID_98_NM1_OtherSubscriberName_2330A), "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, typeof(X12_ID_1065_NM1_OtherSubscriberName_2330A), "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string OtherInsuredLastName_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string OtherInsuredFirstName_04 { get; set; }
        [D(5, typeof(X12_AN))]
        public string OtherInsuredMiddleName_05 { get; set; }
        [D(6, typeof(X12_AN))]
        public string NM1_06 { get; set; }
        [D(7, typeof(X12_AN))]
        public string OtherInsuredNameSuffix_07 { get; set; }
        [D(8, typeof(X12_ID_66_NM1_OtherSubscriberName_2330A), "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, typeof(X12_AN))]
        public string OtherInsuredIdentifier_09 { get; set; }
        [D(10, typeof(X12_ID))]
        public string NM1_10 { get; set; }
        [D(11, typeof(X12_ID))]
        public string NM1_11 { get; set; }
    }
    
    public class X12_ID_98_NM1_OtherSubscriberName_2330A
    {
        
        public List<string> Codes = new List<string> {"IL"};
    }
    
    public class X12_ID_1065_NM1_OtherSubscriberName_2330A
    {
        
        public List<string> Codes = new List<string> {"1","2"};
    }
    
    public class X12_ID_66_NM1_OtherSubscriberName_2330A
    {
        
        public List<string> Codes = new List<string> {"MI","ZZ"};
    }
    
    public class MOA_MedicareOutpatientAdjudicationInformation_2320
    {
        
        [D(1, typeof(X12_R))]
        public string ReimbursementRate_01 { get; set; }
        [D(2, typeof(X12_R))]
        public string HCPCSPayableAmount_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string RemarkCode_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string RemarkCode_04 { get; set; }
        [D(5, typeof(X12_AN))]
        public string RemarkCode_05 { get; set; }
        [D(6, typeof(X12_AN))]
        public string RemarkCode_06 { get; set; }
        [D(7, typeof(X12_AN))]
        public string RemarkCode_07 { get; set; }
        [D(8, typeof(X12_R))]
        public string EndStageRenalDiseasePaymentAmount_08 { get; set; }
        [D(9, typeof(X12_R))]
        public string NonPayableProfessionalComponentBilledAmount_09 { get; set; }
    }
    
    public class OI_OtherInsuranceCoverageInformation_2320
    {
        
        [D(1, typeof(X12_ID))]
        public string OI_01 { get; set; }
        [D(2, typeof(X12_ID))]
        public string OI_02 { get; set; }
        [D(3, typeof(X12_ID_1073_OI_OtherInsuranceCoverageInformation_2320), "1073")]
        public string BenefitsAssignmentCertificationIndicator_03 { get; set; }
        [D(4, typeof(X12_ID_1351_OI_OtherInsuranceCoverageInformation_2320), "1351")]
        public string PatientSignatureSourceCode_04 { get; set; }
        [D(5, typeof(X12_ID))]
        public string OI_05 { get; set; }
        [D(6, typeof(X12_ID_1363_OI_OtherInsuranceCoverageInformation_2320), "1363")]
        public string ReleaseOfInformationCode_06 { get; set; }
    }
    
    public class X12_ID_1073_OI_OtherInsuranceCoverageInformation_2320
    {
        
        public List<string> Codes = new List<string> {"N","Y"};
    }
    
    public class X12_ID_1351_OI_OtherInsuranceCoverageInformation_2320
    {
        
        public List<string> Codes = new List<string> {"B","C","M","P","S"};
    }
    
    public class X12_ID_1363_OI_OtherInsuranceCoverageInformation_2320
    {
        
        public List<string> Codes = new List<string> {"A","I","M","N","O","Y"};
    }
    
    public class DMG_SubscriberDemographicInformation_2320
    {
        
        [D(1, typeof(X12_ID_1250_DMG_SubscriberDemographicInformation_2320), "1250")]
        public string DateTimePeriodFormatQualifier_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string OtherInsuredBirthDate_02 { get; set; }
        [D(3, typeof(X12_ID_1068_DMG_SubscriberDemographicInformation_2320), "1068")]
        public string OtherInsuredGenderCode_03 { get; set; }
        [D(4, typeof(X12_ID))]
        public string DMG_04 { get; set; }
        [D(5, typeof(X12_ID))]
        public string DMG_05 { get; set; }
        [D(6, typeof(X12_ID))]
        public string DMG_06 { get; set; }
        [D(7, typeof(X12_ID))]
        public string DMG_07 { get; set; }
        [D(8, typeof(X12_ID))]
        public string DMG_08 { get; set; }
        [D(9, typeof(X12_R))]
        public string DMG_09 { get; set; }
    }
    
    public class X12_ID_1250_DMG_SubscriberDemographicInformation_2320
    {
        
        public List<string> Codes = new List<string> {"D8"};
    }
    
    public class X12_ID_1068_DMG_SubscriberDemographicInformation_2320
    {
        
        public List<string> Codes = new List<string> {"F","M","U"};
    }
    
    public class All_AMT_2320
    {
        
        [S("AMT", 1)]
        public AMT_CoordinationOfBenefitsCOBPayerPaidAmount_2320 AMT_CoordinationOfBenefitsCOBPayerPaidAmount_2320 { get; set; }
        [S("AMT", 2)]
        public AMT_CoordinationOfBenefitsCOBApprovedAmount_2320 AMT_CoordinationOfBenefitsCOBApprovedAmount_2320 { get; set; }
        [S("AMT", 3)]
        public AMT_CoordinationOfBenefitsCOBAllowedAmount_2320 AMT_CoordinationOfBenefitsCOBAllowedAmount_2320 { get; set; }
        [S("AMT", 4)]
        public AMT_CoordinationOfBenefitsCOBPatientResponsibilityAmount_2320 AMT_CoordinationOfBenefitsCOBPatientResponsibilityAmount_2320 { get; set; }
        [S("AMT", 5)]
        public AMT_CoordinationOfBenefitsCOBCoveredAmount_2320 AMT_CoordinationOfBenefitsCOBCoveredAmount_2320 { get; set; }
        [S("AMT", 6)]
        public AMT_CoordinationOfBenefitsCOBDiscountAmount_2320 AMT_CoordinationOfBenefitsCOBDiscountAmount_2320 { get; set; }
        [S("AMT", 7)]
        public AMT_CoordinationOfBenefitsCOBPerDayLimitAmount_2320 AMT_CoordinationOfBenefitsCOBPerDayLimitAmount_2320 { get; set; }
        [S("AMT", 8)]
        public AMT_CoordinationOfBenefitsCOBPatientPaidAmount_2320 AMT_CoordinationOfBenefitsCOBPatientPaidAmount_2320 { get; set; }
        [S("AMT", 9)]
        public AMT_CoordinationOfBenefitsCOBTaxAmount_2320 AMT_CoordinationOfBenefitsCOBTaxAmount_2320 { get; set; }
        [S("AMT", 10)]
        public AMT_CoordinationOfBenefitsCOBTotalClaimBeforeTaxesAmount_2320 AMT_CoordinationOfBenefitsCOBTotalClaimBeforeTaxesAmount_2320 { get; set; }
    }
    
    public class AMT_CoordinationOfBenefitsCOBTotalClaimBeforeTaxesAmount_2320
    {
        
        [D(1, typeof(X12_ID_522_AMT_CoordinationOfBenefitsCOBTotalClaimBeforeTaxesAmount_2320), "522")]
        public string AmountQualifierCode_01 { get; set; }
        [D(2, typeof(X12_R))]
        public string OtherPayerPreTaxClaimTotalAmount_02 { get; set; }
        [D(3, typeof(X12_ID))]
        public string AMT_03 { get; set; }
    }
    
    public class X12_ID_522_AMT_CoordinationOfBenefitsCOBTotalClaimBeforeTaxesAmount_2320
    {
        
        public List<string> Codes = new List<string> {"T2"};
    }
    
    public class AMT_CoordinationOfBenefitsCOBTaxAmount_2320
    {
        
        [D(1, typeof(X12_ID_522_AMT_CoordinationOfBenefitsCOBTaxAmount_2320), "522")]
        public string AmountQualifierCode_01 { get; set; }
        [D(2, typeof(X12_R))]
        public string OtherPayerTaxAmount_02 { get; set; }
        [D(3, typeof(X12_ID))]
        public string AMT_03 { get; set; }
    }
    
    public class X12_ID_522_AMT_CoordinationOfBenefitsCOBTaxAmount_2320
    {
        
        public List<string> Codes = new List<string> {"T"};
    }
    
    public class AMT_CoordinationOfBenefitsCOBPatientPaidAmount_2320
    {
        
        [D(1, typeof(X12_ID_522_AMT_CoordinationOfBenefitsCOBPatientPaidAmount_2320), "522")]
        public string AmountQualifierCode_01 { get; set; }
        [D(2, typeof(X12_R))]
        public string OtherPayerPatientPaidAmount_02 { get; set; }
        [D(3, typeof(X12_ID))]
        public string AMT_03 { get; set; }
    }
    
    public class X12_ID_522_AMT_CoordinationOfBenefitsCOBPatientPaidAmount_2320
    {
        
        public List<string> Codes = new List<string> {"F5"};
    }
    
    public class AMT_CoordinationOfBenefitsCOBPerDayLimitAmount_2320
    {
        
        [D(1, typeof(X12_ID_522_AMT_CoordinationOfBenefitsCOBPerDayLimitAmount_2320), "522")]
        public string AmountQualifierCode_01 { get; set; }
        [D(2, typeof(X12_R))]
        public string OtherPayerPerDayLimitAmount_02 { get; set; }
        [D(3, typeof(X12_ID))]
        public string AMT_03 { get; set; }
    }
    
    public class X12_ID_522_AMT_CoordinationOfBenefitsCOBPerDayLimitAmount_2320
    {
        
        public List<string> Codes = new List<string> {"DY"};
    }
    
    public class AMT_CoordinationOfBenefitsCOBDiscountAmount_2320
    {
        
        [D(1, typeof(X12_ID_522_AMT_CoordinationOfBenefitsCOBDiscountAmount_2320), "522")]
        public string AmountQualifierCode_01 { get; set; }
        [D(2, typeof(X12_R))]
        public string OtherPayerDiscountAmount_02 { get; set; }
        [D(3, typeof(X12_ID))]
        public string AMT_03 { get; set; }
    }
    
    public class X12_ID_522_AMT_CoordinationOfBenefitsCOBDiscountAmount_2320
    {
        
        public List<string> Codes = new List<string> {"D8"};
    }
    
    public class AMT_CoordinationOfBenefitsCOBCoveredAmount_2320
    {
        
        [D(1, typeof(X12_ID_522_AMT_CoordinationOfBenefitsCOBCoveredAmount_2320), "522")]
        public string AmountQualifierCode_01 { get; set; }
        [D(2, typeof(X12_R))]
        public string OtherPayerCoveredAmount_02 { get; set; }
        [D(3, typeof(X12_ID))]
        public string AMT_03 { get; set; }
    }
    
    public class X12_ID_522_AMT_CoordinationOfBenefitsCOBCoveredAmount_2320
    {
        
        public List<string> Codes = new List<string> {"AU"};
    }
    
    public class AMT_CoordinationOfBenefitsCOBPatientResponsibilityAmount_2320
    {
        
        [D(1, typeof(X12_ID_522_AMT_CoordinationOfBenefitsCOBPatientResponsibilityAmount_2320), "522")]
        public string AmountQualifierCode_01 { get; set; }
        [D(2, typeof(X12_R))]
        public string OtherPayerPatientResponsibilityAmount_02 { get; set; }
        [D(3, typeof(X12_ID))]
        public string AMT_03 { get; set; }
    }
    
    public class X12_ID_522_AMT_CoordinationOfBenefitsCOBPatientResponsibilityAmount_2320
    {
        
        public List<string> Codes = new List<string> {"F2"};
    }
    
    public class AMT_CoordinationOfBenefitsCOBAllowedAmount_2320
    {
        
        [D(1, typeof(X12_ID_522_AMT_CoordinationOfBenefitsCOBAllowedAmount_2320), "522")]
        public string AmountQualifierCode_01 { get; set; }
        [D(2, typeof(X12_R))]
        public string AllowedAmount_02 { get; set; }
        [D(3, typeof(X12_ID))]
        public string AMT_03 { get; set; }
    }
    
    public class X12_ID_522_AMT_CoordinationOfBenefitsCOBAllowedAmount_2320
    {
        
        public List<string> Codes = new List<string> {"B6"};
    }
    
    public class AMT_CoordinationOfBenefitsCOBApprovedAmount_2320
    {
        
        [D(1, typeof(X12_ID_522_AMT_CoordinationOfBenefitsCOBApprovedAmount_2320), "522")]
        public string AmountQualifierCode_01 { get; set; }
        [D(2, typeof(X12_R))]
        public string ApprovedAmount_02 { get; set; }
        [D(3, typeof(X12_ID))]
        public string AMT_03 { get; set; }
    }
    
    public class X12_ID_522_AMT_CoordinationOfBenefitsCOBApprovedAmount_2320
    {
        
        public List<string> Codes = new List<string> {"AAE"};
    }
    
    public class AMT_CoordinationOfBenefitsCOBPayerPaidAmount_2320
    {
        
        [D(1, typeof(X12_ID_522_AMT_CoordinationOfBenefitsCOBPayerPaidAmount_2320), "522")]
        public string AmountQualifierCode_01 { get; set; }
        [D(2, typeof(X12_R))]
        public string PayerPaidAmount_02 { get; set; }
        [D(3, typeof(X12_ID))]
        public string AMT_03 { get; set; }
    }
    
    public class X12_ID_522_AMT_CoordinationOfBenefitsCOBPayerPaidAmount_2320
    {
        
        public List<string> Codes = new List<string> {"D"};
    }
    
    public class CAS_ClaimLevelAdjustments_2320
    {
        
        [D(1, typeof(X12_ID_1033_CAS_ClaimLevelAdjustments_2320), "1033")]
        public string ClaimAdjustmentGroupCode_01 { get; set; }
        [D(2, typeof(X12_ID))]
        public string AdjustmentReasonCode_02 { get; set; }
        [D(3, typeof(X12_R))]
        public string AdjustmentAmount_03 { get; set; }
        [D(4, typeof(X12_R))]
        public string AdjustmentQuantity_04 { get; set; }
        [D(5, typeof(X12_ID))]
        public string AdjustmentReasonCode_05 { get; set; }
        [D(6, typeof(X12_R))]
        public string AdjustmentAmount_06 { get; set; }
        [D(7, typeof(X12_R))]
        public string AdjustmentQuantity_07 { get; set; }
        [D(8, typeof(X12_ID))]
        public string AdjustmentReasonCode_08 { get; set; }
        [D(9, typeof(X12_R))]
        public string AdjustmentAmount_09 { get; set; }
        [D(10, typeof(X12_R))]
        public string AdjustmentQuantity_10 { get; set; }
        [D(11, typeof(X12_ID))]
        public string AdjustmentReasonCode_11 { get; set; }
        [D(12, typeof(X12_R))]
        public string AdjustmentAmount_12 { get; set; }
        [D(13, typeof(X12_R))]
        public string AdjustmentQuantity_13 { get; set; }
        [D(14, typeof(X12_ID))]
        public string AdjustmentReasonCode_14 { get; set; }
        [D(15, typeof(X12_R))]
        public string AdjustmentAmount_15 { get; set; }
        [D(16, typeof(X12_R))]
        public string AdjustmentQuantity_16 { get; set; }
        [D(17, typeof(X12_ID))]
        public string AdjustmentReasonCode_17 { get; set; }
        [D(18, typeof(X12_R))]
        public string AdjustmentAmount_18 { get; set; }
        [D(19, typeof(X12_R))]
        public string AdjustmentQuantity_19 { get; set; }
    }
    
    public class X12_ID_1033_CAS_ClaimLevelAdjustments_2320
    {
        
        public List<string> Codes = new List<string> {"CO","CR","OA","PI","PR"};
    }
    
    public class SBR_OtherSubscriberInformation_2320
    {
        
        [D(1, typeof(X12_ID_1138_SBR_OtherSubscriberInformation_2320), "1138")]
        public string PayerResponsibilitySequenceNumberCode_01 { get; set; }
        [D(2, typeof(X12_ID_1069_SBR_OtherSubscriberInformation_2320), "1069")]
        public string IndividualRelationshipCode_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string InsuredGroupOrPolicyNumber_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string OtherInsuredGroupName_04 { get; set; }
        [D(5, typeof(X12_ID_1336_SBR_OtherSubscriberInformation_2320), "1336")]
        public string InsuranceTypeCode_05 { get; set; }
        [D(6, typeof(X12_ID))]
        public string SBR_06 { get; set; }
        [D(7, typeof(X12_ID))]
        public string SBR_07 { get; set; }
        [D(8, typeof(X12_ID))]
        public string SBR_08 { get; set; }
        [D(9, typeof(X12_ID_1032_SBR_OtherSubscriberInformation_2320), "1032")]
        public string ClaimFilingIndicatorCode_09 { get; set; }
    }
    
    public class X12_ID_1138_SBR_OtherSubscriberInformation_2320
    {
        
        public List<string> Codes = new List<string> {"P","S","T"};
    }
    
    public class X12_ID_1069_SBR_OtherSubscriberInformation_2320
    {
        
        public List<string> Codes = new List<string> {"01","04","05","07","10","15","17","18","19","20","21","22","23","24","29","32","33","36","39","40","41","43","53","G8"};
    }
    
    public class X12_ID_1336_SBR_OtherSubscriberInformation_2320
    {
        
        public List<string> Codes = new List<string> {"AP","C1","CP","GP","HM","IP","LD","LT","MB","MC","MI","MP","OT","PP","SP"};
    }
    
    public class X12_ID_1032_SBR_OtherSubscriberInformation_2320
    {
        
        public List<string> Codes = new List<string> {"09","10","11","12","13","14","15","16","AM","BL","CH","CI","DS","HM","LI","LM","MB","MC","OF","TV","VA","WC","ZZ"};
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
        
        [S("NM1", 1)]
        public NM1_SupervisingProviderName_2310E NM1_SupervisingProviderName_2310E { get; set; }
        [S("REF", 2)]
        public List<REF_SupervisingProviderSecondaryIdentification_2310E> REF_SupervisingProviderSecondaryIdentification_2310E { get; set; }
    }
    
    public class REF_SupervisingProviderSecondaryIdentification_2310E
    {
        
        [D(1, typeof(X12_ID_128_REF_SupervisingProviderSecondaryIdentification_2310E), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string SupervisingProviderSecondaryIdentifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string REF_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string REF_04 { get; set; }
    }
    
    public class X12_ID_128_REF_SupervisingProviderSecondaryIdentification_2310E
    {
        
        public List<string> Codes = new List<string> {"0B","1B","1C","1D","1G","1H","EI","G2","LU","N5","SY","X5"};
    }
    
    public class NM1_SupervisingProviderName_2310E
    {
        
        [D(1, typeof(X12_ID_98_NM1_SupervisingProviderName_2310E), "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, typeof(X12_ID_1065_NM1_SupervisingProviderName_2310E), "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string SupervisingProviderLastName_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string SupervisingProviderFirstName_04 { get; set; }
        [D(5, typeof(X12_AN))]
        public string SupervisingProviderMiddleName_05 { get; set; }
        [D(6, typeof(X12_AN))]
        public string NM1_06 { get; set; }
        [D(7, typeof(X12_AN))]
        public string SupervisingProviderNameSuffix_07 { get; set; }
        [D(8, typeof(X12_ID_66_NM1_SupervisingProviderName_2310E), "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, typeof(X12_AN))]
        public string SupervisingProviderIdentifier_09 { get; set; }
        [D(10, typeof(X12_ID))]
        public string NM1_10 { get; set; }
        [D(11, typeof(X12_ID))]
        public string NM1_11 { get; set; }
    }
    
    public class X12_ID_98_NM1_SupervisingProviderName_2310E
    {
        
        public List<string> Codes = new List<string> {"DQ"};
    }
    
    public class X12_ID_1065_NM1_SupervisingProviderName_2310E
    {
        
        public List<string> Codes = new List<string> {"1"};
    }
    
    public class X12_ID_66_NM1_SupervisingProviderName_2310E
    {
        
        public List<string> Codes = new List<string> {"24","34","XX"};
    }
    
    public class Loop_2310D
    {
        
        [S("NM1", 1)]
        public NM1_ServiceFacilityLocation_2310D NM1_ServiceFacilityLocation_2310D { get; set; }
        [S("N3", 2)]
        public N3_ServiceFacilityLocationAddress_2310D N3_ServiceFacilityLocationAddress_2310D { get; set; }
        [S("N4", 3)]
        public N4_ServiceFacilityLocationCityStateZIP_2310D N4_ServiceFacilityLocationCityStateZIP_2310D { get; set; }
        [S("REF", 4)]
        public List<REF_ServiceFacilityLocationSecondaryIdentification_2310D> REF_ServiceFacilityLocationSecondaryIdentification_2310D { get; set; }
    }
    
    public class REF_ServiceFacilityLocationSecondaryIdentification_2310D
    {
        
        [D(1, typeof(X12_ID_128_REF_ServiceFacilityLocationSecondaryIdentification_2310D), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string LaboratoryOrFacilitySecondaryIdentifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string REF_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string REF_04 { get; set; }
    }
    
    public class X12_ID_128_REF_ServiceFacilityLocationSecondaryIdentification_2310D
    {
        
        public List<string> Codes = new List<string> {"0B","1A","1B","1C","1D","1G","1H","G2","LU","N5","TJ","X4","X5"};
    }
    
    public class N4_ServiceFacilityLocationCityStateZIP_2310D
    {
        
        [D(1, typeof(X12_AN))]
        public string LaboratoryOrFacilityCityName_01 { get; set; }
        [D(2, typeof(X12_ID))]
        public string LaboratoryOrFacilityStateOrProvinceCode_02 { get; set; }
        [D(3, typeof(X12_ID))]
        public string LaboratoryOrFacilityPostalZoneOrZIPCode_03 { get; set; }
        [D(4, typeof(X12_ID))]
        public string CountryCode_04 { get; set; }
        [D(5, typeof(X12_ID))]
        public string N4_05 { get; set; }
        [D(6, typeof(X12_AN))]
        public string N4_06 { get; set; }
    }
    
    public class N3_ServiceFacilityLocationAddress_2310D
    {
        
        [D(1, typeof(X12_AN))]
        public string LaboratoryOrFacilityAddressLine_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string LaboratoryOrFacilityAddressLine_02 { get; set; }
    }
    
    public class NM1_ServiceFacilityLocation_2310D
    {
        
        [D(1, typeof(X12_ID_98_NM1_ServiceFacilityLocation_2310D), "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, typeof(X12_ID_1065_NM1_ServiceFacilityLocation_2310D), "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string LaboratoryOrFacilityName_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string NM1_04 { get; set; }
        [D(5, typeof(X12_AN))]
        public string NM1_05 { get; set; }
        [D(6, typeof(X12_AN))]
        public string NM1_06 { get; set; }
        [D(7, typeof(X12_AN))]
        public string NM1_07 { get; set; }
        [D(8, typeof(X12_ID_66_NM1_ServiceFacilityLocation_2310D), "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, typeof(X12_AN))]
        public string LaboratoryOrFacilityPrimaryIdentifier_09 { get; set; }
        [D(10, typeof(X12_ID))]
        public string NM1_10 { get; set; }
        [D(11, typeof(X12_ID))]
        public string NM1_11 { get; set; }
    }
    
    public class X12_ID_98_NM1_ServiceFacilityLocation_2310D
    {
        
        public List<string> Codes = new List<string> {"77","FA","LI","TL"};
    }
    
    public class X12_ID_1065_NM1_ServiceFacilityLocation_2310D
    {
        
        public List<string> Codes = new List<string> {"2"};
    }
    
    public class X12_ID_66_NM1_ServiceFacilityLocation_2310D
    {
        
        public List<string> Codes = new List<string> {"24","34","XX"};
    }
    
    public class Loop_2310C
    {
        
        [S("NM1", 1)]
        public NM1_PurchasedServiceProviderName_2310C NM1_PurchasedServiceProviderName_2310C { get; set; }
        [S("REF", 2)]
        public List<REF_PurchasedServiceProviderSecondaryIdentification_2310C> REF_PurchasedServiceProviderSecondaryIdentification_2310C { get; set; }
    }
    
    public class REF_PurchasedServiceProviderSecondaryIdentification_2310C
    {
        
        [D(1, typeof(X12_ID_128_REF_PurchasedServiceProviderSecondaryIdentification_2310C), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string PurchasedServiceProviderSecondaryIdentifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string REF_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string REF_04 { get; set; }
    }
    
    public class X12_ID_128_REF_PurchasedServiceProviderSecondaryIdentification_2310C
    {
        
        public List<string> Codes = new List<string> {"0B","1A","1B","1C","1D","1G","1H","EI","G2","LU","N5","SY","U3","X5"};
    }
    
    public class NM1_PurchasedServiceProviderName_2310C
    {
        
        [D(1, typeof(X12_ID_98_NM1_PurchasedServiceProviderName_2310C), "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, typeof(X12_ID_1065_NM1_PurchasedServiceProviderName_2310C), "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string PurchasedServiceProviderLastOrOrganizationName_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string PurchasedServiceProviderFirstName_04 { get; set; }
        [D(5, typeof(X12_AN))]
        public string PurchasedServiceProviderMiddleName_05 { get; set; }
        [D(6, typeof(X12_AN))]
        public string NM1_06 { get; set; }
        [D(7, typeof(X12_AN))]
        public string NM1_07 { get; set; }
        [D(8, typeof(X12_ID_66_NM1_PurchasedServiceProviderName_2310C), "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, typeof(X12_AN))]
        public string PurchasedServiceProviderIdentifier_09 { get; set; }
        [D(10, typeof(X12_ID))]
        public string NM1_10 { get; set; }
        [D(11, typeof(X12_ID))]
        public string NM1_11 { get; set; }
    }
    
    public class X12_ID_98_NM1_PurchasedServiceProviderName_2310C
    {
        
        public List<string> Codes = new List<string> {"QB"};
    }
    
    public class X12_ID_1065_NM1_PurchasedServiceProviderName_2310C
    {
        
        public List<string> Codes = new List<string> {"1","2"};
    }
    
    public class X12_ID_66_NM1_PurchasedServiceProviderName_2310C
    {
        
        public List<string> Codes = new List<string> {"24","34","XX"};
    }
    
    public class Loop_2310B
    {
        
        [S("NM1", 1)]
        public NM1_RenderingProviderName_2310B NM1_RenderingProviderName_2310B { get; set; }
        [S("PRV", 2)]
        public PRV_RenderingProviderSpecialtyInformation_2310B PRV_RenderingProviderSpecialtyInformation_2310B { get; set; }
        [S("REF", 3)]
        public List<REF_RenderingProviderSecondaryIdentification_2310B> REF_RenderingProviderSecondaryIdentification_2310B { get; set; }
    }
    
    public class REF_RenderingProviderSecondaryIdentification_2310B
    {
        
        [D(1, typeof(X12_ID_128_REF_RenderingProviderSecondaryIdentification_2310B), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string RenderingProviderSecondaryIdentifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string REF_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string REF_04 { get; set; }
    }
    
    public class X12_ID_128_REF_RenderingProviderSecondaryIdentification_2310B
    {
        
        public List<string> Codes = new List<string> {"0B","1B","1C","1D","1G","1H","EI","G2","LU","N5","SY","X5"};
    }
    
    public class PRV_RenderingProviderSpecialtyInformation_2310B
    {
        
        [D(1, typeof(X12_ID_1221_PRV_RenderingProviderSpecialtyInformation_2310B), "1221")]
        public string ProviderCode_01 { get; set; }
        [D(2, typeof(X12_ID_128_PRV_RenderingProviderSpecialtyInformation_2310B), "128")]
        public string ReferenceIdentificationQualifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string ProviderTaxonomyCode_03 { get; set; }
        [D(4, typeof(X12_ID))]
        public string PRV_04 { get; set; }
        [D(5, typeof(X12_AN))]
        public string PRV_05 { get; set; }
        [D(6, typeof(X12_ID))]
        public string PRV_06 { get; set; }
    }
    
    public class X12_ID_1221_PRV_RenderingProviderSpecialtyInformation_2310B
    {
        
        public List<string> Codes = new List<string> {"PE"};
    }
    
    public class X12_ID_128_PRV_RenderingProviderSpecialtyInformation_2310B
    {
        
        public List<string> Codes = new List<string> {"ZZ"};
    }
    
    public class NM1_RenderingProviderName_2310B
    {
        
        [D(1, typeof(X12_ID_98_NM1_RenderingProviderName_2310B), "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, typeof(X12_ID_1065_NM1_RenderingProviderName_2310B), "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string RenderingProviderLastOrOrganizationName_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string RenderingProviderFirstName_04 { get; set; }
        [D(5, typeof(X12_AN))]
        public string RenderingProviderMiddleName_05 { get; set; }
        [D(6, typeof(X12_AN))]
        public string NM1_06 { get; set; }
        [D(7, typeof(X12_AN))]
        public string RenderingProviderNameSuffix_07 { get; set; }
        [D(8, typeof(X12_ID_66_NM1_RenderingProviderName_2310B), "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, typeof(X12_AN))]
        public string RenderingProviderIdentifier_09 { get; set; }
        [D(10, typeof(X12_ID))]
        public string NM1_10 { get; set; }
        [D(11, typeof(X12_ID))]
        public string NM1_11 { get; set; }
    }
    
    public class X12_ID_98_NM1_RenderingProviderName_2310B
    {
        
        public List<string> Codes = new List<string> {"82"};
    }
    
    public class X12_ID_1065_NM1_RenderingProviderName_2310B
    {
        
        public List<string> Codes = new List<string> {"1","2"};
    }
    
    public class X12_ID_66_NM1_RenderingProviderName_2310B
    {
        
        public List<string> Codes = new List<string> {"24","34","XX"};
    }
    
    public class Loop_2310A
    {
        
        [S("NM1", 1)]
        public NM1_ReferringProviderName_2310A NM1_ReferringProviderName_2310A { get; set; }
        [S("PRV", 2)]
        public PRV_ReferringProviderSpecialtyInformation_2310A PRV_ReferringProviderSpecialtyInformation_2310A { get; set; }
        [S("REF", 3)]
        public List<REF_ReferringProviderSecondaryIdentification_2310A> REF_ReferringProviderSecondaryIdentification_2310A { get; set; }
    }
    
    public class REF_ReferringProviderSecondaryIdentification_2310A
    {
        
        [D(1, typeof(X12_ID_128_REF_ReferringProviderSecondaryIdentification_2310A), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string ReferringProviderSecondaryIdentifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string REF_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string REF_04 { get; set; }
    }
    
    public class X12_ID_128_REF_ReferringProviderSecondaryIdentification_2310A
    {
        
        public List<string> Codes = new List<string> {"0B","1B","1C","1D","1G","1H","EI","G2","LU","N5","SY","X5"};
    }
    
    public class PRV_ReferringProviderSpecialtyInformation_2310A
    {
        
        [D(1, typeof(X12_ID_1221_PRV_ReferringProviderSpecialtyInformation_2310A), "1221")]
        public string ProviderCode_01 { get; set; }
        [D(2, typeof(X12_ID_128_PRV_ReferringProviderSpecialtyInformation_2310A), "128")]
        public string ReferenceIdentificationQualifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string ProviderTaxonomyCode_03 { get; set; }
        [D(4, typeof(X12_ID))]
        public string PRV_04 { get; set; }
        [D(5, typeof(X12_AN))]
        public string PRV_05 { get; set; }
        [D(6, typeof(X12_ID))]
        public string PRV_06 { get; set; }
    }
    
    public class X12_ID_1221_PRV_ReferringProviderSpecialtyInformation_2310A
    {
        
        public List<string> Codes = new List<string> {"RF"};
    }
    
    public class X12_ID_128_PRV_ReferringProviderSpecialtyInformation_2310A
    {
        
        public List<string> Codes = new List<string> {"ZZ"};
    }
    
    public class NM1_ReferringProviderName_2310A
    {
        
        [D(1, typeof(X12_ID_98_NM1_ReferringProviderName_2310A), "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, typeof(X12_ID_1065_NM1_ReferringProviderName_2310A), "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string ReferringProviderLastName_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string ReferringProviderFirstName_04 { get; set; }
        [D(5, typeof(X12_AN))]
        public string ReferringProviderMiddleName_05 { get; set; }
        [D(6, typeof(X12_AN))]
        public string NM1_06 { get; set; }
        [D(7, typeof(X12_AN))]
        public string ReferringProviderNameSuffix_07 { get; set; }
        [D(8, typeof(X12_ID_66_NM1_ReferringProviderName_2310A), "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, typeof(X12_AN))]
        public string ReferringProviderIdentifier_09 { get; set; }
        [D(10, typeof(X12_ID))]
        public string NM1_10 { get; set; }
        [D(11, typeof(X12_ID))]
        public string NM1_11 { get; set; }
    }
    
    public class X12_ID_98_NM1_ReferringProviderName_2310A
    {
        
        public List<string> Codes = new List<string> {"DN","P3"};
    }
    
    public class X12_ID_1065_NM1_ReferringProviderName_2310A
    {
        
        public List<string> Codes = new List<string> {"1","2"};
    }
    
    public class X12_ID_66_NM1_ReferringProviderName_2310A
    {
        
        public List<string> Codes = new List<string> {"24","34","XX"};
    }
    
    public class Loop_2305
    {
        
        [S("CR7", 1)]
        public CR7_HomeHealthCarePlanInformation_2305 CR7_HomeHealthCarePlanInformation_2305 { get; set; }
        [S("HSD", 2)]
        public List<HSD_HealthCareServicesDelivery_2305> HSD_HealthCareServicesDelivery_2305 { get; set; }
    }
    
    public class HSD_HealthCareServicesDelivery_2305
    {
        
        [D(1, typeof(X12_ID_673_HSD_HealthCareServicesDelivery_2305), "673")]
        public string Visits_01 { get; set; }
        [D(2, typeof(X12_R))]
        public string NumberOfVisits_02 { get; set; }
        [D(3, typeof(X12_ID_355_HSD_HealthCareServicesDelivery_2305), "355")]
        public string FrequencyPeriod_03 { get; set; }
        [D(4, typeof(X12_R))]
        public string FrequencyCount_04 { get; set; }
        [D(5, typeof(X12_ID_615_HSD_HealthCareServicesDelivery_2305), "615")]
        public string DurationOfVisitsUnits_05 { get; set; }
        [D(6, typeof(X12_N0))]
        public string DurationOfVisitsNumberOfUnits_06 { get; set; }
        [D(7, typeof(X12_ID_678_HSD_HealthCareServicesDelivery_2305), "678")]
        public string ShipDeliveryOrCalendarPatternCode_07 { get; set; }
        [D(8, typeof(X12_ID_679_HSD_HealthCareServicesDelivery_2305), "679")]
        public string DeliveryPatternTimeCode_08 { get; set; }
    }
    
    public class X12_ID_673_HSD_HealthCareServicesDelivery_2305
    {
        
        public List<string> Codes = new List<string> {"VS"};
    }
    
    public class X12_ID_355_HSD_HealthCareServicesDelivery_2305
    {
        
        public List<string> Codes = new List<string> {"DA","MO","Q1","WK"};
    }
    
    public class X12_ID_615_HSD_HealthCareServicesDelivery_2305
    {
        
        public List<string> Codes = new List<string> {"7","35"};
    }
    
    public class X12_ID_678_HSD_HealthCareServicesDelivery_2305
    {
        
        public List<string> Codes = new List<string> {"1","2","3","4","5","6","7","A","B","C","D","E","F","G","H","J","K","L","N","O","S","W","SA","SB","SC","SD","SG","SL","SP","SX","SY","SZ"};
    }
    
    public class X12_ID_679_HSD_HealthCareServicesDelivery_2305
    {
        
        public List<string> Codes = new List<string> {"D","E","F"};
    }
    
    public class CR7_HomeHealthCarePlanInformation_2305
    {
        
        [D(1, typeof(X12_ID_921_CR7_HomeHealthCarePlanInformation_2305), "921")]
        public string DisciplineTypeCode_01 { get; set; }
        [D(2, typeof(X12_N0))]
        public string TotalVisitsRenderedCount_02 { get; set; }
        [D(3, typeof(X12_N0))]
        public string CertificationPeriodProjectedVisitCount_03 { get; set; }
    }
    
    public class X12_ID_921_CR7_HomeHealthCarePlanInformation_2305
    {
        
        public List<string> Codes = new List<string> {"AI","MS","OT","PT","SN","ST"};
    }
    
    public class HCP_ClaimPricingRepricingInformation_2300
    {
        
        [D(1, typeof(X12_ID_1473_HCP_ClaimPricingRepricingInformation_2300), "1473")]
        public string PricingMethodology_01 { get; set; }
        [D(2, typeof(X12_R))]
        public string RepricedAllowedAmount_02 { get; set; }
        [D(3, typeof(X12_R))]
        public string RepricedSavingAmount_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string RepricingOrganizationIdentifier_04 { get; set; }
        [D(5, typeof(X12_R))]
        public string RepricingPerDiemOrFlatRateAmount_05 { get; set; }
        [D(6, typeof(X12_AN))]
        public string RepricedApprovedAmbulatoryPatientGroupCode_06 { get; set; }
        [D(7, typeof(X12_R))]
        public string RepricedApprovedAmbulatoryPatientGroupAmount_07 { get; set; }
        [D(8, typeof(X12_AN))]
        public string HCP_08 { get; set; }
        [D(9, typeof(X12_ID))]
        public string HCP_09 { get; set; }
        [D(10, typeof(X12_AN))]
        public string HCP_10 { get; set; }
        [D(11, typeof(X12_ID))]
        public string HCP_11 { get; set; }
        [D(12, typeof(X12_R))]
        public string HCP_12 { get; set; }
        [D(13, typeof(X12_ID_901_HCP_ClaimPricingRepricingInformation_2300), "901")]
        public string RejectReasonCode_13 { get; set; }
        [D(14, typeof(X12_ID_1526_HCP_ClaimPricingRepricingInformation_2300), "1526")]
        public string PolicyComplianceCode_14 { get; set; }
        [D(15, typeof(X12_ID_1527_HCP_ClaimPricingRepricingInformation_2300), "1527")]
        public string ExceptionCode_15 { get; set; }
    }
    
    public class X12_ID_1473_HCP_ClaimPricingRepricingInformation_2300
    {
        
        public List<string> Codes = new List<string> {"00","01","02","03","04","05","07","08","09","10","11","12","13","14"};
    }
    
    public class X12_ID_901_HCP_ClaimPricingRepricingInformation_2300
    {
        
        public List<string> Codes = new List<string> {"T1","T2","T3","T4","T5","T6"};
    }
    
    public class X12_ID_1526_HCP_ClaimPricingRepricingInformation_2300
    {
        
        public List<string> Codes = new List<string> {"1","2","3","4","5"};
    }
    
    public class X12_ID_1527_HCP_ClaimPricingRepricingInformation_2300
    {
        
        public List<string> Codes = new List<string> {"1","2","3","4","5","6"};
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
        [D(9, typeof(X12_AN))]
        public string HI_09 { get; set; }
        [D(10, typeof(X12_AN))]
        public string HI_10 { get; set; }
        [D(11, typeof(X12_AN))]
        public string HI_11 { get; set; }
        [D(12, typeof(X12_AN))]
        public string HI_12 { get; set; }
    }
    
    public class C022_1576619431
    {
        
        [D(1, typeof(X12_ID_1270_C022_1576619431), "1270")]
        public string DiagnosisTypeCode_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string DiagnosisCode_02 { get; set; }
        [D(3, typeof(X12_ID))]
        public string HI_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string HI_04 { get; set; }
        [D(5, typeof(X12_R))]
        public string HI_05 { get; set; }
        [D(6, typeof(X12_R))]
        public string HI_06 { get; set; }
        [D(7, typeof(X12_AN))]
        public string HI_07 { get; set; }
    }
    
    public class X12_ID_1270_C022_1576619431
    {
        
        public List<string> Codes = new List<string> {"BF"};
    }
    
    public class C022_1220389071
    {
        
        [D(1, typeof(X12_ID_1270_C022_1220389071), "1270")]
        public string DiagnosisTypeCode_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string DiagnosisCode_02 { get; set; }
        [D(3, typeof(X12_ID))]
        public string HI_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string HI_04 { get; set; }
        [D(5, typeof(X12_R))]
        public string HI_05 { get; set; }
        [D(6, typeof(X12_R))]
        public string HI_06 { get; set; }
        [D(7, typeof(X12_AN))]
        public string HI_07 { get; set; }
    }
    
    public class X12_ID_1270_C022_1220389071
    {
        
        public List<string> Codes = new List<string> {"BF"};
    }
    
    public class C022_57524121
    {
        
        [D(1, typeof(X12_ID_1270_C022_57524121), "1270")]
        public string DiagnosisTypeCode_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string DiagnosisCode_02 { get; set; }
        [D(3, typeof(X12_ID))]
        public string HI_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string HI_04 { get; set; }
        [D(5, typeof(X12_R))]
        public string HI_05 { get; set; }
        [D(6, typeof(X12_R))]
        public string HI_06 { get; set; }
        [D(7, typeof(X12_AN))]
        public string HI_07 { get; set; }
    }
    
    public class X12_ID_1270_C022_57524121
    {
        
        public List<string> Codes = new List<string> {"BF"};
    }
    
    public class C022_1105734046
    {
        
        [D(1, typeof(X12_ID_1270_C022_1105734046), "1270")]
        public string DiagnosisTypeCode_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string DiagnosisCode_02 { get; set; }
        [D(3, typeof(X12_ID))]
        public string HI_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string HI_04 { get; set; }
        [D(5, typeof(X12_R))]
        public string HI_05 { get; set; }
        [D(6, typeof(X12_R))]
        public string HI_06 { get; set; }
        [D(7, typeof(X12_AN))]
        public string HI_07 { get; set; }
    }
    
    public class X12_ID_1270_C022_1105734046
    {
        
        public List<string> Codes = new List<string> {"BF"};
    }
    
    public class C022_2026368300
    {
        
        [D(1, typeof(X12_ID_1270_C022_2026368300), "1270")]
        public string DiagnosisTypeCode_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string DiagnosisCode_02 { get; set; }
        [D(3, typeof(X12_ID))]
        public string HI_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string HI_04 { get; set; }
        [D(5, typeof(X12_R))]
        public string HI_05 { get; set; }
        [D(6, typeof(X12_R))]
        public string HI_06 { get; set; }
        [D(7, typeof(X12_AN))]
        public string HI_07 { get; set; }
    }
    
    public class X12_ID_1270_C022_2026368300
    {
        
        public List<string> Codes = new List<string> {"BF"};
    }
    
    public class C022_1577012646
    {
        
        [D(1, typeof(X12_ID_1270_C022_1577012646), "1270")]
        public string DiagnosisTypeCode_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string DiagnosisCode_02 { get; set; }
        [D(3, typeof(X12_ID))]
        public string HI_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string HI_04 { get; set; }
        [D(5, typeof(X12_R))]
        public string HI_05 { get; set; }
        [D(6, typeof(X12_R))]
        public string HI_06 { get; set; }
        [D(7, typeof(X12_AN))]
        public string HI_07 { get; set; }
    }
    
    public class X12_ID_1270_C022_1577012646
    {
        
        public List<string> Codes = new List<string> {"BF"};
    }
    
    public class C022_1220782286
    {
        
        [D(1, typeof(X12_ID_1270_C022_1220782286), "1270")]
        public string DiagnosisTypeCode_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string DiagnosisCode_02 { get; set; }
        [D(3, typeof(X12_ID))]
        public string HI_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string HI_04 { get; set; }
        [D(5, typeof(X12_R))]
        public string HI_05 { get; set; }
        [D(6, typeof(X12_R))]
        public string HI_06 { get; set; }
        [D(7, typeof(X12_AN))]
        public string HI_07 { get; set; }
    }
    
    public class X12_ID_1270_C022_1220782286
    {
        
        public List<string> Codes = new List<string> {"BF"};
    }
    
    public class C022_57917336
    {
        
        [D(1, typeof(X12_ID_1270_C022_57917336), "1270")]
        public string DiagnosisTypeCode_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string DiagnosisCode_02 { get; set; }
        [D(3, typeof(X12_ID))]
        public string HI_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string HI_04 { get; set; }
        [D(5, typeof(X12_R))]
        public string HI_05 { get; set; }
        [D(6, typeof(X12_R))]
        public string HI_06 { get; set; }
        [D(7, typeof(X12_AN))]
        public string HI_07 { get; set; }
    }
    
    public class X12_ID_1270_C022_57917336
    {
        
        public List<string> Codes = new List<string> {"BK"};
    }
    
    public class All_CRC_2300
    {
        
        [S("CRC", 1)]
        public List<CRC_AmbulanceCertification_2300> CRC_AmbulanceCertification_2300 { get; set; }
        [S("CRC", 2)]
        public List<CRC_PatientConditionInformationVision_2300> CRC_PatientConditionInformationVision_2300 { get; set; }
        [S("CRC", 3)]
        public CRC_HomeboundIndicator_2300 CRC_HomeboundIndicator_2300 { get; set; }
        [S("CRC", 4)]
        public CRC_EPSDTReferral_2300 CRC_EPSDTReferral_2300 { get; set; }
    }
    
    public class CRC_EPSDTReferral_2300
    {
        
        [D(1, typeof(X12_ID_1136_CRC_EPSDTReferral_2300), "1136")]
        public string CodeCategory_01 { get; set; }
        [D(2, typeof(X12_ID_1073_CRC_EPSDTReferral_2300), "1073")]
        public string CertificationConditionIndicator_02 { get; set; }
        [D(3, typeof(X12_ID_1321_CRC_EPSDTReferral_2300), "1321")]
        public string ConditionCode_03 { get; set; }
        [D(4, typeof(X12_ID_1321_CRC_EPSDTReferral_2300), "1321")]
        public string ConditionCode_04 { get; set; }
        [D(5, typeof(X12_ID_1321_CRC_EPSDTReferral_2300), "1321")]
        public string ConditionCode_05 { get; set; }
        [D(6, typeof(X12_ID))]
        public string CRC_06 { get; set; }
        [D(7, typeof(X12_ID))]
        public string CRC_07 { get; set; }
    }
    
    public class X12_ID_1136_CRC_EPSDTReferral_2300
    {
        
        public List<string> Codes = new List<string> {"ZZ"};
    }
    
    public class X12_ID_1073_CRC_EPSDTReferral_2300
    {
        
        public List<string> Codes = new List<string> {"N","Y"};
    }
    
    public class X12_ID_1321_CRC_EPSDTReferral_2300
    {
        
        public List<string> Codes = new List<string> {"AV","NU","S2","ST"};
    }
    
    public class CRC_HomeboundIndicator_2300
    {
        
        [D(1, typeof(X12_ID_1136_CRC_HomeboundIndicator_2300), "1136")]
        public string CodeCategory_01 { get; set; }
        [D(2, typeof(X12_ID_1073_CRC_HomeboundIndicator_2300), "1073")]
        public string CertificationConditionIndicator_02 { get; set; }
        [D(3, typeof(X12_ID_1321_CRC_HomeboundIndicator_2300), "1321")]
        public string HomeboundIndicator_03 { get; set; }
        [D(4, typeof(X12_ID))]
        public string CRC_04 { get; set; }
        [D(5, typeof(X12_ID))]
        public string CRC_05 { get; set; }
        [D(6, typeof(X12_ID))]
        public string CRC_06 { get; set; }
        [D(7, typeof(X12_ID))]
        public string CRC_07 { get; set; }
    }
    
    public class X12_ID_1136_CRC_HomeboundIndicator_2300
    {
        
        public List<string> Codes = new List<string> {"75"};
    }
    
    public class X12_ID_1073_CRC_HomeboundIndicator_2300
    {
        
        public List<string> Codes = new List<string> {"Y"};
    }
    
    public class X12_ID_1321_CRC_HomeboundIndicator_2300
    {
        
        public List<string> Codes = new List<string> {"IH"};
    }
    
    public class CRC_PatientConditionInformationVision_2300
    {
        
        [D(1, typeof(X12_ID_1136_CRC_PatientConditionInformationVision_2300), "1136")]
        public string CodeCategory_01 { get; set; }
        [D(2, typeof(X12_ID_1073_CRC_PatientConditionInformationVision_2300), "1073")]
        public string CertificationConditionIndicator_02 { get; set; }
        [D(3, typeof(X12_ID_1321_CRC_PatientConditionInformationVision_2300), "1321")]
        public string ConditionCode_03 { get; set; }
        [D(4, typeof(X12_ID_1321_CRC_PatientConditionInformationVision_2300), "1321")]
        public string ConditionCode_04 { get; set; }
        [D(5, typeof(X12_ID_1321_CRC_PatientConditionInformationVision_2300), "1321")]
        public string ConditionCode_05 { get; set; }
        [D(6, typeof(X12_ID_1321_CRC_PatientConditionInformationVision_2300), "1321")]
        public string ConditionCode_06 { get; set; }
        [D(7, typeof(X12_ID_1321_CRC_PatientConditionInformationVision_2300), "1321")]
        public string ConditionCode_07 { get; set; }
    }
    
    public class X12_ID_1136_CRC_PatientConditionInformationVision_2300
    {
        
        public List<string> Codes = new List<string> {"E1","E2","E3"};
    }
    
    public class X12_ID_1073_CRC_PatientConditionInformationVision_2300
    {
        
        public List<string> Codes = new List<string> {"N","Y"};
    }
    
    public class X12_ID_1321_CRC_PatientConditionInformationVision_2300
    {
        
        public List<string> Codes = new List<string> {"L1","L2","L3","L4","L5"};
    }
    
    public class CRC_AmbulanceCertification_2300
    {
        
        [D(1, typeof(X12_ID_1136_CRC_AmbulanceCertification_2300), "1136")]
        public string CodeCategory_01 { get; set; }
        [D(2, typeof(X12_ID_1073_CRC_AmbulanceCertification_2300), "1073")]
        public string CertificationConditionIndicator_02 { get; set; }
        [D(3, typeof(X12_ID_1321_CRC_AmbulanceCertification_2300), "1321")]
        public string ConditionCode_03 { get; set; }
        [D(4, typeof(X12_ID_1321_CRC_AmbulanceCertification_2300), "1321")]
        public string ConditionCode_04 { get; set; }
        [D(5, typeof(X12_ID_1321_CRC_AmbulanceCertification_2300), "1321")]
        public string ConditionCode_05 { get; set; }
        [D(6, typeof(X12_ID_1321_CRC_AmbulanceCertification_2300), "1321")]
        public string ConditionCode_06 { get; set; }
        [D(7, typeof(X12_ID_1321_CRC_AmbulanceCertification_2300), "1321")]
        public string ConditionCode_07 { get; set; }
    }
    
    public class X12_ID_1136_CRC_AmbulanceCertification_2300
    {
        
        public List<string> Codes = new List<string> {"07"};
    }
    
    public class X12_ID_1073_CRC_AmbulanceCertification_2300
    {
        
        public List<string> Codes = new List<string> {"N","Y"};
    }
    
    public class X12_ID_1321_CRC_AmbulanceCertification_2300
    {
        
        public List<string> Codes = new List<string> {"01","02","03","04","05","06","07","08","09","60"};
    }
    
    public class CR2_SpinalManipulationServiceInformation_2300
    {
        
        [D(1, typeof(X12_N0))]
        public string CR2_01 { get; set; }
        [D(2, typeof(X12_R))]
        public string CR2_02 { get; set; }
        [D(3, typeof(X12_ID))]
        public string CR2_03 { get; set; }
        [D(4, typeof(X12_ID))]
        public string CR2_04 { get; set; }
        [D(5, typeof(X12_ID))]
        public string CR2_05 { get; set; }
        [D(6, typeof(X12_R))]
        public string CR2_06 { get; set; }
        [D(7, typeof(X12_R))]
        public string CR2_07 { get; set; }
        [D(8, typeof(X12_ID_1342_CR2_SpinalManipulationServiceInformation_2300), "1342")]
        public string PatientConditionCode_08 { get; set; }
        [D(9, typeof(X12_ID))]
        public string CR2_09 { get; set; }
        [D(10, typeof(X12_AN))]
        public string PatientConditionDescription_10 { get; set; }
        [D(11, typeof(X12_AN))]
        public string PatientConditionDescription_11 { get; set; }
        [D(12, typeof(X12_ID_1073_CR2_SpinalManipulationServiceInformation_2300), "1073")]
        public string XrayAvailabilityIndicator_12 { get; set; }
    }
    
    public class X12_ID_1342_CR2_SpinalManipulationServiceInformation_2300
    {
        
        public List<string> Codes = new List<string> {"A","C","D","E","F","G","M"};
    }
    
    public class X12_ID_1073_CR2_SpinalManipulationServiceInformation_2300
    {
        
        public List<string> Codes = new List<string> {"N","Y"};
    }
    
    public class CR1_AmbulanceTransportInformation_2300
    {
        
        [D(1, typeof(X12_ID_355_CR1_AmbulanceTransportInformation_2300), "355")]
        public string UnitOrBasisForMeasurementCode_01 { get; set; }
        [D(2, typeof(X12_R))]
        public string PatientWeight_02 { get; set; }
        [D(3, typeof(X12_ID_1316_CR1_AmbulanceTransportInformation_2300), "1316")]
        public string AmbulanceTransportCode_03 { get; set; }
        [D(4, typeof(X12_ID_1317_CR1_AmbulanceTransportInformation_2300), "1317")]
        public string AmbulanceTransportReasonCode_04 { get; set; }
        [D(5, typeof(X12_ID_355_CR1_AmbulanceTransportInformation_2300), "355")]
        public string UnitOrBasisForMeasurementCode_05 { get; set; }
        [D(6, typeof(X12_R))]
        public string TransportDistance_06 { get; set; }
        [D(7, typeof(X12_AN))]
        public string CR1_07 { get; set; }
        [D(8, typeof(X12_AN))]
        public string CR1_08 { get; set; }
        [D(9, typeof(X12_AN))]
        public string RoundTripPurposeDescription_09 { get; set; }
        [D(10, typeof(X12_AN))]
        public string StretcherPurposeDescription_10 { get; set; }
    }
    
    public class X12_ID_355_CR1_AmbulanceTransportInformation_2300
    {
        
        public List<string> Codes = new List<string> {"LB"};
    }
    
    public class X12_ID_1316_CR1_AmbulanceTransportInformation_2300
    {
        
        public List<string> Codes = new List<string> {"I","R","T","X"};
    }
    
    public class X12_ID_1317_CR1_AmbulanceTransportInformation_2300
    {
        
        public List<string> Codes = new List<string> {"A","B","C","D","E"};
    }
    
    public class NTE_ClaimNote_2300
    {
        
        [D(1, typeof(X12_ID_363_NTE_ClaimNote_2300), "363")]
        public string NoteReferenceCode_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string ClaimNoteText_02 { get; set; }
    }
    
    public class X12_ID_363_NTE_ClaimNote_2300
    {
        
        public List<string> Codes = new List<string> {"ADD","CER","DCP","DGN","PMT","TPO"};
    }
    
    public class K3_FileInformation_2300
    {
        
        [D(1, typeof(X12_AN))]
        public string FixedFormatInformation_01 { get; set; }
        [D(2, typeof(X12_ID))]
        public string K3_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string K3_03 { get; set; }
    }
    
    public class All_REF_2300
    {
        
        [S("REF", 1)]
        public REF_ServiceAuthorizationExceptionCode_2300 REF_ServiceAuthorizationExceptionCode_2300 { get; set; }
        [S("REF", 2)]
        public REF_MandatoryMedicareSection4081CrossoverIndicator_2300 REF_MandatoryMedicareSection4081CrossoverIndicator_2300 { get; set; }
        [S("REF", 3)]
        public REF_MammographyCertificationNumber_2300 REF_MammographyCertificationNumber_2300 { get; set; }
        [S("REF", 4)]
        public List<REF_PriorAuthorizationOrReferralNumber_2300> REF_PriorAuthorizationOrReferralNumber_2300 { get; set; }
        [S("REF", 5)]
        public REF_OriginalReferenceNumberICNDCN_2300 REF_OriginalReferenceNumberICNDCN_2300 { get; set; }
        [S("REF", 6)]
        public List<REF_ClinicalLaboratoryImprovementAmendmentCLIANumber_2300> REF_ClinicalLaboratoryImprovementAmendmentCLIANumber_2300 { get; set; }
        [S("REF", 7)]
        public REF_RepricedClaimNumber_2300 REF_RepricedClaimNumber_2300 { get; set; }
        [S("REF", 8)]
        public REF_AdjustedRepricedClaimNumber_2300 REF_AdjustedRepricedClaimNumber_2300 { get; set; }
        [S("REF", 9)]
        public REF_InvestigationalDeviceExemptionNumber_2300 REF_InvestigationalDeviceExemptionNumber_2300 { get; set; }
        [S("REF", 10)]
        public REF_ClaimIdentificationNumberForClearingHousesAndOtherTransmissionIntermediaries_2300 REF_ClaimIdentificationNumberForClearingHousesAndOtherTransmissionIntermediaries_2300 { get; set; }
        [S("REF", 11)]
        public List<REF_AmbulatoryPatientGroupAPG_2300> REF_AmbulatoryPatientGroupAPG_2300 { get; set; }
        [S("REF", 12)]
        public REF_MedicalRecordNumber_2300 REF_MedicalRecordNumber_2300 { get; set; }
        [S("REF", 13)]
        public REF_DemonstrationProjectIdentifier_2300 REF_DemonstrationProjectIdentifier_2300 { get; set; }
    }
    
    public class REF_DemonstrationProjectIdentifier_2300
    {
        
        [D(1, typeof(X12_ID_128_REF_DemonstrationProjectIdentifier_2300), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string DemonstrationProjectIdentifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string REF_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string REF_04 { get; set; }
    }
    
    public class X12_ID_128_REF_DemonstrationProjectIdentifier_2300
    {
        
        public List<string> Codes = new List<string> {"P4"};
    }
    
    public class REF_MedicalRecordNumber_2300
    {
        
        [D(1, typeof(X12_ID_128_REF_MedicalRecordNumber_2300), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string MedicalRecordNumber_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string REF_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string REF_04 { get; set; }
    }
    
    public class X12_ID_128_REF_MedicalRecordNumber_2300
    {
        
        public List<string> Codes = new List<string> {"EA"};
    }
    
    public class REF_AmbulatoryPatientGroupAPG_2300
    {
        
        [D(1, typeof(X12_ID_128_REF_AmbulatoryPatientGroupAPG_2300), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string AmbulatoryPatientGroupNumber_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string REF_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string REF_04 { get; set; }
    }
    
    public class X12_ID_128_REF_AmbulatoryPatientGroupAPG_2300
    {
        
        public List<string> Codes = new List<string> {"1S"};
    }
    
    public class REF_ClaimIdentificationNumberForClearingHousesAndOtherTransmissionIntermediaries_2300
    {
        
        [D(1, typeof(X12_ID_128_REF_ClaimIdentificationNumberForClearingHousesAndOtherTransmissionIntermediaries_2300), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string ClearinghouseTraceNumber_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string REF_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string REF_04 { get; set; }
    }
    
    public class X12_ID_128_REF_ClaimIdentificationNumberForClearingHousesAndOtherTransmissionIntermediaries_2300
    {
        
        public List<string> Codes = new List<string> {"D9"};
    }
    
    public class REF_InvestigationalDeviceExemptionNumber_2300
    {
        
        [D(1, typeof(X12_ID_128_REF_InvestigationalDeviceExemptionNumber_2300), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string InvestigationalDeviceExemptionIdentifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string REF_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string REF_04 { get; set; }
    }
    
    public class X12_ID_128_REF_InvestigationalDeviceExemptionNumber_2300
    {
        
        public List<string> Codes = new List<string> {"LX"};
    }
    
    public class REF_AdjustedRepricedClaimNumber_2300
    {
        
        [D(1, typeof(X12_ID_128_REF_AdjustedRepricedClaimNumber_2300), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string AdjustedRepricedClaimReferenceNumber_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string REF_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string REF_04 { get; set; }
    }
    
    public class X12_ID_128_REF_AdjustedRepricedClaimNumber_2300
    {
        
        public List<string> Codes = new List<string> {"9C"};
    }
    
    public class REF_RepricedClaimNumber_2300
    {
        
        [D(1, typeof(X12_ID_128_REF_RepricedClaimNumber_2300), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string RepricedClaimReferenceNumber_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string REF_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string REF_04 { get; set; }
    }
    
    public class X12_ID_128_REF_RepricedClaimNumber_2300
    {
        
        public List<string> Codes = new List<string> {"9A"};
    }
    
    public class REF_ClinicalLaboratoryImprovementAmendmentCLIANumber_2300
    {
        
        [D(1, typeof(X12_ID_128_REF_ClinicalLaboratoryImprovementAmendmentCLIANumber_2300), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string ClinicalLaboratoryImprovementAmendmentNumber_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string REF_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string REF_04 { get; set; }
    }
    
    public class X12_ID_128_REF_ClinicalLaboratoryImprovementAmendmentCLIANumber_2300
    {
        
        public List<string> Codes = new List<string> {"X4"};
    }
    
    public class REF_OriginalReferenceNumberICNDCN_2300
    {
        
        [D(1, typeof(X12_ID_128_REF_OriginalReferenceNumberICNDCN_2300), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string ClaimOriginalReferenceNumber_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string REF_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string REF_04 { get; set; }
    }
    
    public class X12_ID_128_REF_OriginalReferenceNumberICNDCN_2300
    {
        
        public List<string> Codes = new List<string> {"F8"};
    }
    
    public class REF_PriorAuthorizationOrReferralNumber_2300
    {
        
        [D(1, typeof(X12_ID_128_REF_PriorAuthorizationOrReferralNumber_2300), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string PriorAuthorizationOrReferralNumber_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string REF_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string REF_04 { get; set; }
    }
    
    public class X12_ID_128_REF_PriorAuthorizationOrReferralNumber_2300
    {
        
        public List<string> Codes = new List<string> {"9F","G1"};
    }
    
    public class REF_MammographyCertificationNumber_2300
    {
        
        [D(1, typeof(X12_ID_128_REF_MammographyCertificationNumber_2300), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string MammographyCertificationNumber_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string REF_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string REF_04 { get; set; }
    }
    
    public class X12_ID_128_REF_MammographyCertificationNumber_2300
    {
        
        public List<string> Codes = new List<string> {"EW"};
    }
    
    public class REF_MandatoryMedicareSection4081CrossoverIndicator_2300
    {
        
        [D(1, typeof(X12_ID_128_REF_MandatoryMedicareSection4081CrossoverIndicator_2300), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string MedicareSection4081Indicator_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string REF_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string REF_04 { get; set; }
    }
    
    public class X12_ID_128_REF_MandatoryMedicareSection4081CrossoverIndicator_2300
    {
        
        public List<string> Codes = new List<string> {"F5"};
    }
    
    public class REF_ServiceAuthorizationExceptionCode_2300
    {
        
        [D(1, typeof(X12_ID_128_REF_ServiceAuthorizationExceptionCode_2300), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string ServiceAuthorizationExceptionCode_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string REF_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string REF_04 { get; set; }
    }
    
    public class X12_ID_128_REF_ServiceAuthorizationExceptionCode_2300
    {
        
        public List<string> Codes = new List<string> {"4N"};
    }
    
    public class All_AMT_2300
    {
        
        [S("AMT", 1)]
        public AMT_CreditDebitCardMaximumAmount_2300 AMT_CreditDebitCardMaximumAmount_2300 { get; set; }
        [S("AMT", 2)]
        public AMT_PatientAmountPaid_2300 AMT_PatientAmountPaid_2300 { get; set; }
        [S("AMT", 3)]
        public AMT_TotalPurchasedServiceAmount_2300 AMT_TotalPurchasedServiceAmount_2300 { get; set; }
    }
    
    public class AMT_TotalPurchasedServiceAmount_2300
    {
        
        [D(1, typeof(X12_ID_522_AMT_TotalPurchasedServiceAmount_2300), "522")]
        public string AmountQualifierCode_01 { get; set; }
        [D(2, typeof(X12_R))]
        public string TotalPurchasedServiceAmount_02 { get; set; }
        [D(3, typeof(X12_ID))]
        public string AMT_03 { get; set; }
    }
    
    public class X12_ID_522_AMT_TotalPurchasedServiceAmount_2300
    {
        
        public List<string> Codes = new List<string> {"NE"};
    }
    
    public class AMT_PatientAmountPaid_2300
    {
        
        [D(1, typeof(X12_ID_522_AMT_PatientAmountPaid_2300), "522")]
        public string AmountQualifierCode_01 { get; set; }
        [D(2, typeof(X12_R))]
        public string PatientAmountPaid_02 { get; set; }
        [D(3, typeof(X12_ID))]
        public string AMT_03 { get; set; }
    }
    
    public class X12_ID_522_AMT_PatientAmountPaid_2300
    {
        
        public List<string> Codes = new List<string> {"F5"};
    }
    
    public class AMT_CreditDebitCardMaximumAmount_2300
    {
        
        [D(1, typeof(X12_ID_522_AMT_CreditDebitCardMaximumAmount_2300), "522")]
        public string AmountQualifierCode_01 { get; set; }
        [D(2, typeof(X12_R))]
        public string CreditOrDebitCardMaximumAmount_02 { get; set; }
        [D(3, typeof(X12_ID))]
        public string AMT_03 { get; set; }
    }
    
    public class X12_ID_522_AMT_CreditDebitCardMaximumAmount_2300
    {
        
        public List<string> Codes = new List<string> {"MA"};
    }
    
    public class CN1_ContractInformation_2300
    {
        
        [D(1, typeof(X12_ID_1166_CN1_ContractInformation_2300), "1166")]
        public string ContractTypeCode_01 { get; set; }
        [D(2, typeof(X12_R))]
        public string ContractAmount_02 { get; set; }
        [D(3, typeof(X12_R))]
        public string ContractPercentage_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string ContractCode_04 { get; set; }
        [D(5, typeof(X12_R))]
        public string TermsDiscountPercentage_05 { get; set; }
        [D(6, typeof(X12_AN))]
        public string ContractVersionIdentifier_06 { get; set; }
    }
    
    public class X12_ID_1166_CN1_ContractInformation_2300
    {
        
        public List<string> Codes = new List<string> {"02","03","04","05","06","09"};
    }
    
    public class PWK_ClaimSupplementalInformation_2300
    {
        
        [D(1, typeof(X12_ID_755_PWK_ClaimSupplementalInformation_2300), "755")]
        public string AttachmentReportTypeCode_01 { get; set; }
        [D(2, typeof(X12_ID_756_PWK_ClaimSupplementalInformation_2300), "756")]
        public string AttachmentTransmissionCode_02 { get; set; }
        [D(3, typeof(X12_N0))]
        public string PWK_03 { get; set; }
        [D(4, typeof(X12_ID))]
        public string PWK_04 { get; set; }
        [D(5, typeof(X12_ID_66_PWK_ClaimSupplementalInformation_2300), "66")]
        public string IdentificationCodeQualifier_05 { get; set; }
        [D(6, typeof(X12_AN))]
        public string AttachmentControlNumber_06 { get; set; }
        [D(7, typeof(X12_AN))]
        public string PWK_07 { get; set; }
        [D(8, typeof(X12_AN))]
        public string PWK_08 { get; set; }
        [D(9, typeof(X12_ID))]
        public string PWK_09 { get; set; }
    }
    
    public class X12_ID_755_PWK_ClaimSupplementalInformation_2300
    {
        
        public List<string> Codes = new List<string> {"77","AS","B2","B3","B4","CT","DA","DG","DS","EB","MT","NN","OB","OZ","PN","PO","PZ","RB","RR","RT"};
    }
    
    public class X12_ID_756_PWK_ClaimSupplementalInformation_2300
    {
        
        public List<string> Codes = new List<string> {"AA","BM","EL","EM","FX"};
    }
    
    public class X12_ID_66_PWK_ClaimSupplementalInformation_2300
    {
        
        public List<string> Codes = new List<string> {"AC"};
    }
    
    public class All_DTP_2300
    {
        
        [S("DTP", 1)]
        public DTP_DateInitialTreatment_2300 DTP_DateInitialTreatment_2300 { get; set; }
        [S("DTP", 2)]
        public DTP_DateDateLastSeen_2300 DTP_DateDateLastSeen_2300 { get; set; }
        [S("DTP", 3)]
        public DTP_DateOnsetOfCurrentIllnessSymptom_2300 DTP_DateOnsetOfCurrentIllnessSymptom_2300 { get; set; }
        [S("DTP", 4)]
        public List<DTP_DateAcuteManifestation_2300> DTP_DateAcuteManifestation_2300 { get; set; }
        [S("DTP", 5)]
        public List<DTP_DateSimilarIllnessSymptomOnset_2300> DTP_DateSimilarIllnessSymptomOnset_2300 { get; set; }
        [S("DTP", 6)]
        public List<DTP_DateAccident_2300> DTP_DateAccident_2300 { get; set; }
        [S("DTP", 7)]
        public DTP_DateLastMenstrualPeriod_2300 DTP_DateLastMenstrualPeriod_2300 { get; set; }
        [S("DTP", 8)]
        public DTP_DateLastXray_2300 DTP_DateLastXray_2300 { get; set; }
        [S("DTP", 9)]
        public DTP_DateHearingAndVisionPrescriptionDate_2300 DTP_DateHearingAndVisionPrescriptionDate_2300 { get; set; }
        [S("DTP", 10)]
        public List<DTP_DateDisabilityBegin_2300> DTP_DateDisabilityBegin_2300 { get; set; }
        [S("DTP", 11)]
        public List<DTP_DateDisabilityEnd_2300> DTP_DateDisabilityEnd_2300 { get; set; }
        [S("DTP", 12)]
        public DTP_DateLastWorked_2300 DTP_DateLastWorked_2300 { get; set; }
        [S("DTP", 13)]
        public DTP_DateAuthorizedReturnToWork_2300 DTP_DateAuthorizedReturnToWork_2300 { get; set; }
        [S("DTP", 14)]
        public DTP_DateAdmission_2300 DTP_DateAdmission_2300 { get; set; }
        [S("DTP", 15)]
        public DTP_DateDischarge_2300 DTP_DateDischarge_2300 { get; set; }
        [S("DTP", 16)]
        public List<DTP_DateAssumedAndRelinquishedCareDates_2300> DTP_DateAssumedAndRelinquishedCareDates_2300 { get; set; }
    }
    
    public class DTP_DateAssumedAndRelinquishedCareDates_2300
    {
        
        [D(1, typeof(X12_ID_374_DTP_DateAssumedAndRelinquishedCareDates_2300), "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_1250_DTP_DateAssumedAndRelinquishedCareDates_2300), "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string AssumedOrRelinquishedCareDate_03 { get; set; }
    }
    
    public class X12_ID_374_DTP_DateAssumedAndRelinquishedCareDates_2300
    {
        
        public List<string> Codes = new List<string> {"090","091"};
    }
    
    public class X12_ID_1250_DTP_DateAssumedAndRelinquishedCareDates_2300
    {
        
        public List<string> Codes = new List<string> {"D8"};
    }
    
    public class DTP_DateDischarge_2300
    {
        
        [D(1, typeof(X12_ID_374_DTP_DateDischarge_2300), "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_1250_DTP_DateDischarge_2300), "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string RelatedHospitalizationDischargeDate_03 { get; set; }
    }
    
    public class X12_ID_374_DTP_DateDischarge_2300
    {
        
        public List<string> Codes = new List<string> {"096"};
    }
    
    public class X12_ID_1250_DTP_DateDischarge_2300
    {
        
        public List<string> Codes = new List<string> {"D8"};
    }
    
    public class DTP_DateAdmission_2300
    {
        
        [D(1, typeof(X12_ID_374_DTP_DateAdmission_2300), "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_1250_DTP_DateAdmission_2300), "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string RelatedHospitalizationAdmissionDate_03 { get; set; }
    }
    
    public class X12_ID_374_DTP_DateAdmission_2300
    {
        
        public List<string> Codes = new List<string> {"435"};
    }
    
    public class X12_ID_1250_DTP_DateAdmission_2300
    {
        
        public List<string> Codes = new List<string> {"D8"};
    }
    
    public class DTP_DateAuthorizedReturnToWork_2300
    {
        
        [D(1, typeof(X12_ID_374_DTP_DateAuthorizedReturnToWork_2300), "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_1250_DTP_DateAuthorizedReturnToWork_2300), "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string WorkReturnDate_03 { get; set; }
    }
    
    public class X12_ID_374_DTP_DateAuthorizedReturnToWork_2300
    {
        
        public List<string> Codes = new List<string> {"296"};
    }
    
    public class X12_ID_1250_DTP_DateAuthorizedReturnToWork_2300
    {
        
        public List<string> Codes = new List<string> {"D8"};
    }
    
    public class DTP_DateLastWorked_2300
    {
        
        [D(1, typeof(X12_ID_374_DTP_DateLastWorked_2300), "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_1250_DTP_DateLastWorked_2300), "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string LastWorkedDate_03 { get; set; }
    }
    
    public class X12_ID_374_DTP_DateLastWorked_2300
    {
        
        public List<string> Codes = new List<string> {"297"};
    }
    
    public class X12_ID_1250_DTP_DateLastWorked_2300
    {
        
        public List<string> Codes = new List<string> {"D8"};
    }
    
    public class DTP_DateDisabilityEnd_2300
    {
        
        [D(1, typeof(X12_ID_374_DTP_DateDisabilityEnd_2300), "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_1250_DTP_DateDisabilityEnd_2300), "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string DisabilityToDate_03 { get; set; }
    }
    
    public class X12_ID_374_DTP_DateDisabilityEnd_2300
    {
        
        public List<string> Codes = new List<string> {"361"};
    }
    
    public class X12_ID_1250_DTP_DateDisabilityEnd_2300
    {
        
        public List<string> Codes = new List<string> {"D8"};
    }
    
    public class DTP_DateDisabilityBegin_2300
    {
        
        [D(1, typeof(X12_ID_374_DTP_DateDisabilityBegin_2300), "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_1250_DTP_DateDisabilityBegin_2300), "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string DisabilityFromDate_03 { get; set; }
    }
    
    public class X12_ID_374_DTP_DateDisabilityBegin_2300
    {
        
        public List<string> Codes = new List<string> {"360"};
    }
    
    public class X12_ID_1250_DTP_DateDisabilityBegin_2300
    {
        
        public List<string> Codes = new List<string> {"D8"};
    }
    
    public class DTP_DateHearingAndVisionPrescriptionDate_2300
    {
        
        [D(1, typeof(X12_ID_374_DTP_DateHearingAndVisionPrescriptionDate_2300), "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_1250_DTP_DateHearingAndVisionPrescriptionDate_2300), "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string PrescriptionDate_03 { get; set; }
    }
    
    public class X12_ID_374_DTP_DateHearingAndVisionPrescriptionDate_2300
    {
        
        public List<string> Codes = new List<string> {"471"};
    }
    
    public class X12_ID_1250_DTP_DateHearingAndVisionPrescriptionDate_2300
    {
        
        public List<string> Codes = new List<string> {"D8"};
    }
    
    public class DTP_DateLastXray_2300
    {
        
        [D(1, typeof(X12_ID_374_DTP_DateLastXray_2300), "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_1250_DTP_DateLastXray_2300), "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string LastXRayDate_03 { get; set; }
    }
    
    public class X12_ID_374_DTP_DateLastXray_2300
    {
        
        public List<string> Codes = new List<string> {"455"};
    }
    
    public class X12_ID_1250_DTP_DateLastXray_2300
    {
        
        public List<string> Codes = new List<string> {"D8"};
    }
    
    public class DTP_DateLastMenstrualPeriod_2300
    {
        
        [D(1, typeof(X12_ID_374_DTP_DateLastMenstrualPeriod_2300), "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_1250_DTP_DateLastMenstrualPeriod_2300), "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string LastMenstrualPeriodDate_03 { get; set; }
    }
    
    public class X12_ID_374_DTP_DateLastMenstrualPeriod_2300
    {
        
        public List<string> Codes = new List<string> {"484"};
    }
    
    public class X12_ID_1250_DTP_DateLastMenstrualPeriod_2300
    {
        
        public List<string> Codes = new List<string> {"D8"};
    }
    
    public class DTP_DateAccident_2300
    {
        
        [D(1, typeof(X12_ID_374_DTP_DateAccident_2300), "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_1250_DTP_DateAccident_2300), "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string AccidentDate_03 { get; set; }
    }
    
    public class X12_ID_374_DTP_DateAccident_2300
    {
        
        public List<string> Codes = new List<string> {"439"};
    }
    
    public class X12_ID_1250_DTP_DateAccident_2300
    {
        
        public List<string> Codes = new List<string> {"D8","DT"};
    }
    
    public class DTP_DateSimilarIllnessSymptomOnset_2300
    {
        
        [D(1, typeof(X12_ID_374_DTP_DateSimilarIllnessSymptomOnset_2300), "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_1250_DTP_DateSimilarIllnessSymptomOnset_2300), "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string SimilarIllnessOrSymptomDate_03 { get; set; }
    }
    
    public class X12_ID_374_DTP_DateSimilarIllnessSymptomOnset_2300
    {
        
        public List<string> Codes = new List<string> {"438"};
    }
    
    public class X12_ID_1250_DTP_DateSimilarIllnessSymptomOnset_2300
    {
        
        public List<string> Codes = new List<string> {"D8"};
    }
    
    public class DTP_DateAcuteManifestation_2300
    {
        
        [D(1, typeof(X12_ID_374_DTP_DateAcuteManifestation_2300), "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_1250_DTP_DateAcuteManifestation_2300), "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string AcuteManifestationDate_03 { get; set; }
    }
    
    public class X12_ID_374_DTP_DateAcuteManifestation_2300
    {
        
        public List<string> Codes = new List<string> {"453"};
    }
    
    public class X12_ID_1250_DTP_DateAcuteManifestation_2300
    {
        
        public List<string> Codes = new List<string> {"D8"};
    }
    
    public class DTP_DateOnsetOfCurrentIllnessSymptom_2300
    {
        
        [D(1, typeof(X12_ID_374_DTP_DateOnsetOfCurrentIllnessSymptom_2300), "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_1250_DTP_DateOnsetOfCurrentIllnessSymptom_2300), "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string OnsetOfCurrentIllnessOrInjuryDate_03 { get; set; }
    }
    
    public class X12_ID_374_DTP_DateOnsetOfCurrentIllnessSymptom_2300
    {
        
        public List<string> Codes = new List<string> {"431"};
    }
    
    public class X12_ID_1250_DTP_DateOnsetOfCurrentIllnessSymptom_2300
    {
        
        public List<string> Codes = new List<string> {"D8"};
    }
    
    public class DTP_DateDateLastSeen_2300
    {
        
        [D(1, typeof(X12_ID_374_DTP_DateDateLastSeen_2300), "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_1250_DTP_DateDateLastSeen_2300), "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string LastSeenDate_03 { get; set; }
    }
    
    public class X12_ID_374_DTP_DateDateLastSeen_2300
    {
        
        public List<string> Codes = new List<string> {"304"};
    }
    
    public class X12_ID_1250_DTP_DateDateLastSeen_2300
    {
        
        public List<string> Codes = new List<string> {"D8"};
    }
    
    public class DTP_DateInitialTreatment_2300
    {
        
        [D(1, typeof(X12_ID_374_DTP_DateInitialTreatment_2300), "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_1250_DTP_DateInitialTreatment_2300), "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string InitialTreatmentDate_03 { get; set; }
    }
    
    public class X12_ID_374_DTP_DateInitialTreatment_2300
    {
        
        public List<string> Codes = new List<string> {"454"};
    }
    
    public class X12_ID_1250_DTP_DateInitialTreatment_2300
    {
        
        public List<string> Codes = new List<string> {"D8"};
    }
    
    public class CLM_ClaimInformation_2300
    {
        
        [D(1, typeof(X12_AN))]
        public string PatientAccountNumber_01 { get; set; }
        [D(2, typeof(X12_R))]
        public string TotalClaimChargeAmount_02 { get; set; }
        [D(3, typeof(X12_ID))]
        public string CLM_03 { get; set; }
        [D(4, typeof(X12_ID))]
        public string CLM_04 { get; set; }
        [C(5)]
        public C023_701794159 C023_701794159 { get; set; }
        [D(6, typeof(X12_ID_1073_CLM_ClaimInformation_2300), "1073")]
        public string ProviderOrSupplierSignatureIndicator_06 { get; set; }
        [D(7, typeof(X12_ID_1359_CLM_ClaimInformation_2300), "1359")]
        public string MedicareAssignmentCode_07 { get; set; }
        [D(8, typeof(X12_ID_1073_CLM_ClaimInformation_2300), "1073")]
        public string BenefitsAssignmentCertificationIndicator_08 { get; set; }
        [D(9, typeof(X12_ID_1363_CLM_ClaimInformation_2300), "1363")]
        public string ReleaseOfInformationCode_09 { get; set; }
        [D(10, typeof(X12_ID_1351_CLM_ClaimInformation_2300), "1351")]
        public string PatientSignatureSourceCode_10 { get; set; }
        [C(11)]
        public C024_1508297677 C024_1508297677 { get; set; }
        [D(12, typeof(X12_ID_1366_CLM_ClaimInformation_2300), "1366")]
        public string SpecialProgramIndicator_12 { get; set; }
        [D(13, typeof(X12_ID))]
        public string CLM_13 { get; set; }
        [D(14, typeof(X12_ID))]
        public string CLM_14 { get; set; }
        [D(15, typeof(X12_ID))]
        public string CLM_15 { get; set; }
        [D(16, typeof(X12_ID_1360_CLM_ClaimInformation_2300), "1360")]
        public string ParticipationAgreement_16 { get; set; }
        [D(17, typeof(X12_ID))]
        public string CLM_17 { get; set; }
        [D(18, typeof(X12_ID))]
        public string CLM_18 { get; set; }
        [D(19, typeof(X12_ID))]
        public string CLM_19 { get; set; }
        [D(20, typeof(X12_ID_1514_CLM_ClaimInformation_2300), "1514")]
        public string DelayReasonCode_20 { get; set; }
    }
    
    public class X12_ID_1073_CLM_ClaimInformation_2300
    {
        
        public List<string> Codes = new List<string> {"N","Y"};
    }
    
    public class X12_ID_1359_CLM_ClaimInformation_2300
    {
        
        public List<string> Codes = new List<string> {"A","B","C","P"};
    }
    
    public class X12_ID_1363_CLM_ClaimInformation_2300
    {
        
        public List<string> Codes = new List<string> {"A","I","M","N","O","Y"};
    }
    
    public class X12_ID_1351_CLM_ClaimInformation_2300
    {
        
        public List<string> Codes = new List<string> {"B","C","M","P","S"};
    }
    
    public class X12_ID_1366_CLM_ClaimInformation_2300
    {
        
        public List<string> Codes = new List<string> {"01","02","03","05","07","08","09"};
    }
    
    public class X12_ID_1360_CLM_ClaimInformation_2300
    {
        
        public List<string> Codes = new List<string> {"P"};
    }
    
    public class X12_ID_1514_CLM_ClaimInformation_2300
    {
        
        public List<string> Codes = new List<string> {"1","2","3","4","5","6","7","8","9","10","11"};
    }
    
    public class C024_1508297677
    {
        
        [D(1, typeof(X12_ID_1362_C024_1508297677), "1362")]
        public string RelatedCausesCode_01 { get; set; }
        [D(2, typeof(X12_ID_1362_C024_1508297677), "1362")]
        public string RelatedCausesCode_02 { get; set; }
        [D(3, typeof(X12_ID_1362_C024_1508297677), "1362")]
        public string RelatedCausesCode_03 { get; set; }
        [D(4, typeof(X12_ID))]
        public string AutoAccidentStateOrProvinceCode_04 { get; set; }
        [D(5, typeof(X12_ID))]
        public string CountryCode_05 { get; set; }
    }
    
    public class X12_ID_1362_C024_1508297677
    {
        
        public List<string> Codes = new List<string> {"AA","AP","EM","OA"};
    }
    
    public class C023_701794159
    {
        
        [D(1, typeof(X12_AN))]
        public string FacilityTypeCode_01 { get; set; }
        [D(2, typeof(X12_ID))]
        public string CLM_02 { get; set; }
        [D(3, typeof(X12_ID))]
        public string ClaimFrequencyCode_03 { get; set; }
    }
    
    public class Loop_2010CA
    {
        
        [S("NM1", 1)]
        public NM1_PatientName_2010CA NM1_PatientName_2010CA { get; set; }
        [S("N3", 2)]
        public N3_PatientAddress_2010CA N3_PatientAddress_2010CA { get; set; }
        [S("N4", 3)]
        public N4_PatientCityStateZIPCode_2010CA N4_PatientCityStateZIPCode_2010CA { get; set; }
        [S("DMG", 4)]
        public DMG_PatientDemographicInformation_2010CA DMG_PatientDemographicInformation_2010CA { get; set; }
        [A(5)]
        public All_REF_2010CA All_REF_2010CA { get; set; }
    }
    
    public class All_REF_2010CA
    {
        
        [S("REF", 1)]
        public List<REF_PatientSecondaryIdentification_2010CA> REF_PatientSecondaryIdentification_2010CA { get; set; }
        [S("REF", 2)]
        public REF_PropertyAndCasualtyClaimNumber_2010CA REF_PropertyAndCasualtyClaimNumber_2010CA { get; set; }
    }
    
    public class REF_PropertyAndCasualtyClaimNumber_2010CA
    {
        
        [D(1, typeof(X12_ID_128_REF_PropertyAndCasualtyClaimNumber_2010CA), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string PropertyCasualtyClaimNumber_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string REF_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string REF_04 { get; set; }
    }
    
    public class X12_ID_128_REF_PropertyAndCasualtyClaimNumber_2010CA
    {
        
        public List<string> Codes = new List<string> {"Y4"};
    }
    
    public class REF_PatientSecondaryIdentification_2010CA
    {
        
        [D(1, typeof(X12_ID_128_REF_PatientSecondaryIdentification_2010CA), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string PatientSecondaryIdentifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string REF_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string REF_04 { get; set; }
    }
    
    public class X12_ID_128_REF_PatientSecondaryIdentification_2010CA
    {
        
        public List<string> Codes = new List<string> {"1W","23","IG","SY"};
    }
    
    public class DMG_PatientDemographicInformation_2010CA
    {
        
        [D(1, typeof(X12_ID_1250_DMG_PatientDemographicInformation_2010CA), "1250")]
        public string DateTimePeriodFormatQualifier_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string PatientBirthDate_02 { get; set; }
        [D(3, typeof(X12_ID_1068_DMG_PatientDemographicInformation_2010CA), "1068")]
        public string PatientGenderCode_03 { get; set; }
        [D(4, typeof(X12_ID))]
        public string DMG_04 { get; set; }
        [D(5, typeof(X12_ID))]
        public string DMG_05 { get; set; }
        [D(6, typeof(X12_ID))]
        public string DMG_06 { get; set; }
        [D(7, typeof(X12_ID))]
        public string DMG_07 { get; set; }
        [D(8, typeof(X12_ID))]
        public string DMG_08 { get; set; }
        [D(9, typeof(X12_R))]
        public string DMG_09 { get; set; }
    }
    
    public class X12_ID_1250_DMG_PatientDemographicInformation_2010CA
    {
        
        public List<string> Codes = new List<string> {"D8"};
    }
    
    public class X12_ID_1068_DMG_PatientDemographicInformation_2010CA
    {
        
        public List<string> Codes = new List<string> {"F","M","U"};
    }
    
    public class N4_PatientCityStateZIPCode_2010CA
    {
        
        [D(1, typeof(X12_AN))]
        public string PatientCityName_01 { get; set; }
        [D(2, typeof(X12_ID))]
        public string PatientStateCode_02 { get; set; }
        [D(3, typeof(X12_ID))]
        public string PatientPostalZoneOrZIPCode_03 { get; set; }
        [D(4, typeof(X12_ID))]
        public string CountryCode_04 { get; set; }
        [D(5, typeof(X12_ID))]
        public string N4_05 { get; set; }
        [D(6, typeof(X12_AN))]
        public string N4_06 { get; set; }
    }
    
    public class N3_PatientAddress_2010CA
    {
        
        [D(1, typeof(X12_AN))]
        public string PatientAddressLine_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string PatientAddressLine_02 { get; set; }
    }
    
    public class NM1_PatientName_2010CA
    {
        
        [D(1, typeof(X12_ID_98_NM1_PatientName_2010CA), "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, typeof(X12_ID_1065_NM1_PatientName_2010CA), "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string PatientLastName_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string PatientFirstName_04 { get; set; }
        [D(5, typeof(X12_AN))]
        public string PatientMiddleName_05 { get; set; }
        [D(6, typeof(X12_AN))]
        public string NM1_06 { get; set; }
        [D(7, typeof(X12_AN))]
        public string PatientNameSuffix_07 { get; set; }
        [D(8, typeof(X12_ID_66_NM1_PatientName_2010CA), "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, typeof(X12_AN))]
        public string PatientPrimaryIdentifier_09 { get; set; }
        [D(10, typeof(X12_ID))]
        public string NM1_10 { get; set; }
        [D(11, typeof(X12_ID))]
        public string NM1_11 { get; set; }
    }
    
    public class X12_ID_98_NM1_PatientName_2010CA
    {
        
        public List<string> Codes = new List<string> {"QC"};
    }
    
    public class X12_ID_1065_NM1_PatientName_2010CA
    {
        
        public List<string> Codes = new List<string> {"1"};
    }
    
    public class X12_ID_66_NM1_PatientName_2010CA
    {
        
        public List<string> Codes = new List<string> {"MI","ZZ"};
    }
    
    public class PAT_PatientInformation_2000C
    {
        
        [D(1, typeof(X12_ID_1069_PAT_PatientInformation_2000C), "1069")]
        public string IndividualRelationshipCode_01 { get; set; }
        [D(2, typeof(X12_ID))]
        public string PAT_02 { get; set; }
        [D(3, typeof(X12_ID))]
        public string PAT_03 { get; set; }
        [D(4, typeof(X12_ID))]
        public string PAT_04 { get; set; }
        [D(5, typeof(X12_ID_1250_PAT_PatientInformation_2000C), "1250")]
        public string DateTimePeriodFormatQualifier_05 { get; set; }
        [D(6, typeof(X12_AN))]
        public string PatientDeathDate_06 { get; set; }
        [D(7, typeof(X12_ID_355_PAT_PatientInformation_2000C), "355")]
        public string UnitOrBasisForMeasurementCode_07 { get; set; }
        [D(8, typeof(X12_R))]
        public string PatientWeight_08 { get; set; }
        [D(9, typeof(X12_ID_1073_PAT_PatientInformation_2000C), "1073")]
        public string PregnancyIndicator_09 { get; set; }
    }
    
    public class X12_ID_1069_PAT_PatientInformation_2000C
    {
        
        public List<string> Codes = new List<string> {"01","04","05","07","09","10","15","17","19","20","21","22","23","24","29","32","33","34","36","39","40","41","43","53","G8"};
    }
    
    public class X12_ID_1250_PAT_PatientInformation_2000C
    {
        
        public List<string> Codes = new List<string> {"D8"};
    }
    
    public class X12_ID_355_PAT_PatientInformation_2000C
    {
        
        public List<string> Codes = new List<string> {"01"};
    }
    
    public class X12_ID_1073_PAT_PatientInformation_2000C
    {
        
        public List<string> Codes = new List<string> {"Y"};
    }
    
    public class HL_PatientHierarchicalLevel_2000C
    {
        
        [D(1, typeof(X12_AN))]
        public string HierarchicalIDNumber_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string HierarchicalParentIDNumber_02 { get; set; }
        [D(3, typeof(X12_ID_735_HL_PatientHierarchicalLevel_2000C), "735")]
        public string HierarchicalLevelCode_03 { get; set; }
        [D(4, typeof(X12_ID_736_HL_PatientHierarchicalLevel_2000C), "736")]
        public string HierarchicalChildCode_04 { get; set; }
    }
    
    public class X12_ID_735_HL_PatientHierarchicalLevel_2000C
    {
        
        public List<string> Codes = new List<string> {"23"};
    }
    
    public class X12_ID_736_HL_PatientHierarchicalLevel_2000C
    {
        
        public List<string> Codes = new List<string> {"0"};
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
        
        [S("NM1", 1)]
        public NM1_CreditDebitCardHolderName_2010BD NM1_CreditDebitCardHolderName_2010BD { get; set; }
        [S("REF", 2)]
        public List<REF_CreditDebitCardInformation_2010BD> REF_CreditDebitCardInformation_2010BD { get; set; }
    }
    
    public class REF_CreditDebitCardInformation_2010BD
    {
        
        [D(1, typeof(X12_ID_128_REF_CreditDebitCardInformation_2010BD), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string CreditOrDebitCardAuthorizationNumber_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string REF_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string REF_04 { get; set; }
    }
    
    public class X12_ID_128_REF_CreditDebitCardInformation_2010BD
    {
        
        public List<string> Codes = new List<string> {"AB","BB"};
    }
    
    public class NM1_CreditDebitCardHolderName_2010BD
    {
        
        [D(1, typeof(X12_ID_98_NM1_CreditDebitCardHolderName_2010BD), "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, typeof(X12_ID_1065_NM1_CreditDebitCardHolderName_2010BD), "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string CreditOrDebitCardHolderLastOrOrganizationalName_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string CreditOrDebitCardHolderFirstName_04 { get; set; }
        [D(5, typeof(X12_AN))]
        public string CreditOrDebitCardHolderMiddleName_05 { get; set; }
        [D(6, typeof(X12_AN))]
        public string NM1_06 { get; set; }
        [D(7, typeof(X12_AN))]
        public string CreditOrDebitCardHolderNameSuffix_07 { get; set; }
        [D(8, typeof(X12_ID_66_NM1_CreditDebitCardHolderName_2010BD), "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, typeof(X12_AN))]
        public string CreditOrDebitCardNumber_09 { get; set; }
        [D(10, typeof(X12_ID))]
        public string NM1_10 { get; set; }
        [D(11, typeof(X12_ID))]
        public string NM1_11 { get; set; }
    }
    
    public class X12_ID_98_NM1_CreditDebitCardHolderName_2010BD
    {
        
        public List<string> Codes = new List<string> {"AO"};
    }
    
    public class X12_ID_1065_NM1_CreditDebitCardHolderName_2010BD
    {
        
        public List<string> Codes = new List<string> {"1","2"};
    }
    
    public class X12_ID_66_NM1_CreditDebitCardHolderName_2010BD
    {
        
        public List<string> Codes = new List<string> {"MI"};
    }
    
    public class Loop_2010BC
    {
        
        [S("NM1", 1)]
        public NM1_ResponsiblePartyName_2010BC NM1_ResponsiblePartyName_2010BC { get; set; }
        [S("N3", 2)]
        public N3_ResponsiblePartyAddress_2010BC N3_ResponsiblePartyAddress_2010BC { get; set; }
        [S("N4", 3)]
        public N4_ResponsiblePartyCityStateZIPCode_2010BC N4_ResponsiblePartyCityStateZIPCode_2010BC { get; set; }
    }
    
    public class N4_ResponsiblePartyCityStateZIPCode_2010BC
    {
        
        [D(1, typeof(X12_AN))]
        public string ResponsiblePartyCityName_01 { get; set; }
        [D(2, typeof(X12_ID))]
        public string ResponsiblePartyStateCode_02 { get; set; }
        [D(3, typeof(X12_ID))]
        public string ResponsiblePartyPostalZoneOrZIPCode_03 { get; set; }
        [D(4, typeof(X12_ID))]
        public string CountryCode_04 { get; set; }
        [D(5, typeof(X12_ID))]
        public string N4_05 { get; set; }
        [D(6, typeof(X12_AN))]
        public string N4_06 { get; set; }
    }
    
    public class N3_ResponsiblePartyAddress_2010BC
    {
        
        [D(1, typeof(X12_AN))]
        public string ResponsiblePartyAddressLine_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string ResponsiblePartyAddressLine_02 { get; set; }
    }
    
    public class NM1_ResponsiblePartyName_2010BC
    {
        
        [D(1, typeof(X12_ID_98_NM1_ResponsiblePartyName_2010BC), "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, typeof(X12_ID_1065_NM1_ResponsiblePartyName_2010BC), "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string ResponsiblePartyLastOrOrganizationName_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string ResponsiblePartyFirstName_04 { get; set; }
        [D(5, typeof(X12_AN))]
        public string ResponsiblePartyMiddleName_05 { get; set; }
        [D(6, typeof(X12_AN))]
        public string NM1_06 { get; set; }
        [D(7, typeof(X12_AN))]
        public string ResponsiblePartySuffixName_07 { get; set; }
        [D(8, typeof(X12_ID))]
        public string NM1_08 { get; set; }
        [D(9, typeof(X12_AN))]
        public string NM1_09 { get; set; }
        [D(10, typeof(X12_ID))]
        public string NM1_10 { get; set; }
        [D(11, typeof(X12_ID))]
        public string NM1_11 { get; set; }
    }
    
    public class X12_ID_98_NM1_ResponsiblePartyName_2010BC
    {
        
        public List<string> Codes = new List<string> {"QD"};
    }
    
    public class X12_ID_1065_NM1_ResponsiblePartyName_2010BC
    {
        
        public List<string> Codes = new List<string> {"1","2"};
    }
    
    public class Loop_2010BB
    {
        
        [S("NM1", 1)]
        public NM1_PayerName_2010BB NM1_PayerName_2010BB { get; set; }
        [S("N3", 2)]
        public N3_PayerAddress_2010BB N3_PayerAddress_2010BB { get; set; }
        [S("N4", 3)]
        public N4_PayerCityStateZIPCode_2010BB N4_PayerCityStateZIPCode_2010BB { get; set; }
        [S("REF", 4)]
        public List<REF_PayerSecondaryIdentification_2010BB> REF_PayerSecondaryIdentification_2010BB { get; set; }
    }
    
    public class REF_PayerSecondaryIdentification_2010BB
    {
        
        [D(1, typeof(X12_ID_128_REF_PayerSecondaryIdentification_2010BB), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string PayerAdditionalIdentifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string REF_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string REF_04 { get; set; }
    }
    
    public class X12_ID_128_REF_PayerSecondaryIdentification_2010BB
    {
        
        public List<string> Codes = new List<string> {"2U","FY","NF","TJ"};
    }
    
    public class N4_PayerCityStateZIPCode_2010BB
    {
        
        [D(1, typeof(X12_AN))]
        public string PayerCityName_01 { get; set; }
        [D(2, typeof(X12_ID))]
        public string PayerStateCode_02 { get; set; }
        [D(3, typeof(X12_ID))]
        public string PayerPostalZoneOrZIPCode_03 { get; set; }
        [D(4, typeof(X12_ID))]
        public string CountryCode_04 { get; set; }
        [D(5, typeof(X12_ID))]
        public string N4_05 { get; set; }
        [D(6, typeof(X12_AN))]
        public string N4_06 { get; set; }
    }
    
    public class N3_PayerAddress_2010BB
    {
        
        [D(1, typeof(X12_AN))]
        public string PayerAddressLine_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string PayerAddressLine_02 { get; set; }
    }
    
    public class NM1_PayerName_2010BB
    {
        
        [D(1, typeof(X12_ID_98_NM1_PayerName_2010BB), "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, typeof(X12_ID_1065_NM1_PayerName_2010BB), "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string PayerName_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string NM1_04 { get; set; }
        [D(5, typeof(X12_AN))]
        public string NM1_05 { get; set; }
        [D(6, typeof(X12_AN))]
        public string NM1_06 { get; set; }
        [D(7, typeof(X12_AN))]
        public string NM1_07 { get; set; }
        [D(8, typeof(X12_ID_66_NM1_PayerName_2010BB), "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, typeof(X12_AN))]
        public string PayerIdentifier_09 { get; set; }
        [D(10, typeof(X12_ID))]
        public string NM1_10 { get; set; }
        [D(11, typeof(X12_ID))]
        public string NM1_11 { get; set; }
    }
    
    public class X12_ID_98_NM1_PayerName_2010BB
    {
        
        public List<string> Codes = new List<string> {"PR"};
    }
    
    public class X12_ID_1065_NM1_PayerName_2010BB
    {
        
        public List<string> Codes = new List<string> {"2"};
    }
    
    public class X12_ID_66_NM1_PayerName_2010BB
    {
        
        public List<string> Codes = new List<string> {"PI","XV"};
    }
    
    public class Loop_2010BA
    {
        
        [S("NM1", 1)]
        public NM1_SubscriberName_2010BA NM1_SubscriberName_2010BA { get; set; }
        [S("N3", 2)]
        public N3_SubscriberAddress_2010BA N3_SubscriberAddress_2010BA { get; set; }
        [S("N4", 3)]
        public N4_SubscriberCityStateZIPCode_2010BA N4_SubscriberCityStateZIPCode_2010BA { get; set; }
        [S("DMG", 4)]
        public DMG_SubscriberDemographicInformation_2010BA DMG_SubscriberDemographicInformation_2010BA { get; set; }
        [A(5)]
        public All_REF_2010BA All_REF_2010BA { get; set; }
    }
    
    public class All_REF_2010BA
    {
        
        [S("REF", 1)]
        public List<REF_SubscriberSecondaryIdentification_2010BA> REF_SubscriberSecondaryIdentification_2010BA { get; set; }
        [S("REF", 2)]
        public REF_PropertyAndCasualtyClaimNumber_2010BA REF_PropertyAndCasualtyClaimNumber_2010BA { get; set; }
    }
    
    public class REF_PropertyAndCasualtyClaimNumber_2010BA
    {
        
        [D(1, typeof(X12_ID_128_REF_PropertyAndCasualtyClaimNumber_2010BA), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string PropertyCasualtyClaimNumber_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string REF_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string REF_04 { get; set; }
    }
    
    public class X12_ID_128_REF_PropertyAndCasualtyClaimNumber_2010BA
    {
        
        public List<string> Codes = new List<string> {"Y4"};
    }
    
    public class REF_SubscriberSecondaryIdentification_2010BA
    {
        
        [D(1, typeof(X12_ID_128_REF_SubscriberSecondaryIdentification_2010BA), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string SubscriberSupplementalIdentifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string REF_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string REF_04 { get; set; }
    }
    
    public class X12_ID_128_REF_SubscriberSecondaryIdentification_2010BA
    {
        
        public List<string> Codes = new List<string> {"1W","23","IG","SY"};
    }
    
    public class DMG_SubscriberDemographicInformation_2010BA
    {
        
        [D(1, typeof(X12_ID_1250_DMG_SubscriberDemographicInformation_2010BA), "1250")]
        public string DateTimePeriodFormatQualifier_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string SubscriberBirthDate_02 { get; set; }
        [D(3, typeof(X12_ID_1068_DMG_SubscriberDemographicInformation_2010BA), "1068")]
        public string SubscriberGenderCode_03 { get; set; }
        [D(4, typeof(X12_ID))]
        public string DMG_04 { get; set; }
        [D(5, typeof(X12_ID))]
        public string DMG_05 { get; set; }
        [D(6, typeof(X12_ID))]
        public string DMG_06 { get; set; }
        [D(7, typeof(X12_ID))]
        public string DMG_07 { get; set; }
        [D(8, typeof(X12_ID))]
        public string DMG_08 { get; set; }
        [D(9, typeof(X12_R))]
        public string DMG_09 { get; set; }
    }
    
    public class X12_ID_1250_DMG_SubscriberDemographicInformation_2010BA
    {
        
        public List<string> Codes = new List<string> {"D8"};
    }
    
    public class X12_ID_1068_DMG_SubscriberDemographicInformation_2010BA
    {
        
        public List<string> Codes = new List<string> {"F","M","U"};
    }
    
    public class N4_SubscriberCityStateZIPCode_2010BA
    {
        
        [D(1, typeof(X12_AN))]
        public string SubscriberCityName_01 { get; set; }
        [D(2, typeof(X12_ID))]
        public string SubscriberStateCode_02 { get; set; }
        [D(3, typeof(X12_ID))]
        public string SubscriberPostalZoneOrZIPCode_03 { get; set; }
        [D(4, typeof(X12_ID))]
        public string CountryCode_04 { get; set; }
        [D(5, typeof(X12_ID))]
        public string N4_05 { get; set; }
        [D(6, typeof(X12_AN))]
        public string N4_06 { get; set; }
    }
    
    public class N3_SubscriberAddress_2010BA
    {
        
        [D(1, typeof(X12_AN))]
        public string SubscriberAddressLine_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string SubscriberAddressLine_02 { get; set; }
    }
    
    public class NM1_SubscriberName_2010BA
    {
        
        [D(1, typeof(X12_ID_98_NM1_SubscriberName_2010BA), "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, typeof(X12_ID_1065_NM1_SubscriberName_2010BA), "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string SubscriberLastName_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string SubscriberFirstName_04 { get; set; }
        [D(5, typeof(X12_AN))]
        public string SubscriberMiddleName_05 { get; set; }
        [D(6, typeof(X12_AN))]
        public string NM1_06 { get; set; }
        [D(7, typeof(X12_AN))]
        public string SubscriberNameSuffix_07 { get; set; }
        [D(8, typeof(X12_ID_66_NM1_SubscriberName_2010BA), "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, typeof(X12_AN))]
        public string SubscriberPrimaryIdentifier_09 { get; set; }
        [D(10, typeof(X12_ID))]
        public string NM1_10 { get; set; }
        [D(11, typeof(X12_ID))]
        public string NM1_11 { get; set; }
    }
    
    public class X12_ID_98_NM1_SubscriberName_2010BA
    {
        
        public List<string> Codes = new List<string> {"IL"};
    }
    
    public class X12_ID_1065_NM1_SubscriberName_2010BA
    {
        
        public List<string> Codes = new List<string> {"1","2"};
    }
    
    public class X12_ID_66_NM1_SubscriberName_2010BA
    {
        
        public List<string> Codes = new List<string> {"MI","ZZ"};
    }
    
    public class PAT_PatientInformation_2000B
    {
        
        [D(1, typeof(X12_ID))]
        public string PAT_01 { get; set; }
        [D(2, typeof(X12_ID))]
        public string PAT_02 { get; set; }
        [D(3, typeof(X12_ID))]
        public string PAT_03 { get; set; }
        [D(4, typeof(X12_ID))]
        public string PAT_04 { get; set; }
        [D(5, typeof(X12_ID_1250_PAT_PatientInformation_2000B), "1250")]
        public string DateTimePeriodFormatQualifier_05 { get; set; }
        [D(6, typeof(X12_AN))]
        public string InsuredIndividualDeathDate_06 { get; set; }
        [D(7, typeof(X12_ID_355_PAT_PatientInformation_2000B), "355")]
        public string UnitOrBasisForMeasurementCode_07 { get; set; }
        [D(8, typeof(X12_R))]
        public string PatientWeight_08 { get; set; }
        [D(9, typeof(X12_ID_1073_PAT_PatientInformation_2000B), "1073")]
        public string PregnancyIndicator_09 { get; set; }
    }
    
    public class X12_ID_1250_PAT_PatientInformation_2000B
    {
        
        public List<string> Codes = new List<string> {"D8"};
    }
    
    public class X12_ID_355_PAT_PatientInformation_2000B
    {
        
        public List<string> Codes = new List<string> {"01"};
    }
    
    public class X12_ID_1073_PAT_PatientInformation_2000B
    {
        
        public List<string> Codes = new List<string> {"Y"};
    }
    
    public class SBR_SubscriberInformation_2000B
    {
        
        [D(1, typeof(X12_ID_1138_SBR_SubscriberInformation_2000B), "1138")]
        public string PayerResponsibilitySequenceNumberCode_01 { get; set; }
        [D(2, typeof(X12_ID_1069_SBR_SubscriberInformation_2000B), "1069")]
        public string IndividualRelationshipCode_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string InsuredGroupOrPolicyNumber_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string InsuredGroupName_04 { get; set; }
        [D(5, typeof(X12_ID_1336_SBR_SubscriberInformation_2000B), "1336")]
        public string InsuranceTypeCode_05 { get; set; }
        [D(6, typeof(X12_ID))]
        public string SBR_06 { get; set; }
        [D(7, typeof(X12_ID))]
        public string SBR_07 { get; set; }
        [D(8, typeof(X12_ID))]
        public string SBR_08 { get; set; }
        [D(9, typeof(X12_ID_1032_SBR_SubscriberInformation_2000B), "1032")]
        public string ClaimFilingIndicatorCode_09 { get; set; }
    }
    
    public class X12_ID_1138_SBR_SubscriberInformation_2000B
    {
        
        public List<string> Codes = new List<string> {"P","S","T"};
    }
    
    public class X12_ID_1069_SBR_SubscriberInformation_2000B
    {
        
        public List<string> Codes = new List<string> {"18"};
    }
    
    public class X12_ID_1336_SBR_SubscriberInformation_2000B
    {
        
        public List<string> Codes = new List<string> {"12","13","14","15","16","41","42","43","47"};
    }
    
    public class X12_ID_1032_SBR_SubscriberInformation_2000B
    {
        
        public List<string> Codes = new List<string> {"09","10","11","12","13","14","15","16","AM","BL","CH","CI","DS","HM","LI","LM","MB","MC","OF","TV","VA","WC","ZZ"};
    }
    
    public class HL_SubscriberHierarchicalLevel_2000B
    {
        
        [D(1, typeof(X12_AN))]
        public string HierarchicalIDNumber_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string HierarchicalParentIDNumber_02 { get; set; }
        [D(3, typeof(X12_ID_735_HL_SubscriberHierarchicalLevel_2000B), "735")]
        public string HierarchicalLevelCode_03 { get; set; }
        [D(4, typeof(X12_ID_736_HL_SubscriberHierarchicalLevel_2000B), "736")]
        public string HierarchicalChildCode_04 { get; set; }
    }
    
    public class X12_ID_735_HL_SubscriberHierarchicalLevel_2000B
    {
        
        public List<string> Codes = new List<string> {"22"};
    }
    
    public class X12_ID_736_HL_SubscriberHierarchicalLevel_2000B
    {
        
        public List<string> Codes = new List<string> {"0","1"};
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
        
        [S("NM1", 1)]
        public NM1_PaytoProviderName_2010AB NM1_PaytoProviderName_2010AB { get; set; }
        [S("N3", 2)]
        public N3_PaytoProviderAddress_2010AB N3_PaytoProviderAddress_2010AB { get; set; }
        [S("N4", 3)]
        public N4_PaytoProviderCityStateZIPCode_2010AB N4_PaytoProviderCityStateZIPCode_2010AB { get; set; }
        [S("REF", 4)]
        public List<REF_PaytoProviderSecondaryIdentification_2010AB> REF_PaytoProviderSecondaryIdentification_2010AB { get; set; }
    }
    
    public class REF_PaytoProviderSecondaryIdentification_2010AB
    {
        
        [D(1, typeof(X12_ID_128_REF_PaytoProviderSecondaryIdentification_2010AB), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string PaytoProviderIdentifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string REF_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string REF_04 { get; set; }
    }
    
    public class X12_ID_128_REF_PaytoProviderSecondaryIdentification_2010AB
    {
        
        public List<string> Codes = new List<string> {"0B","1A","1B","1C","1D","1G","1H","1J","B3","BQ","EI","FH","G2","G5","LU","SY","U3","X5"};
    }
    
    public class N4_PaytoProviderCityStateZIPCode_2010AB
    {
        
        [D(1, typeof(X12_AN))]
        public string PaytoProviderCityName_01 { get; set; }
        [D(2, typeof(X12_ID))]
        public string PaytoProviderStateCode_02 { get; set; }
        [D(3, typeof(X12_ID))]
        public string PaytoProviderPostalZoneOrZIPCode_03 { get; set; }
        [D(4, typeof(X12_ID))]
        public string CountryCode_04 { get; set; }
        [D(5, typeof(X12_ID))]
        public string N4_05 { get; set; }
        [D(6, typeof(X12_AN))]
        public string N4_06 { get; set; }
    }
    
    public class N3_PaytoProviderAddress_2010AB
    {
        
        [D(1, typeof(X12_AN))]
        public string PaytoProviderAddressLine_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string PaytoProviderAddressLine_02 { get; set; }
    }
    
    public class NM1_PaytoProviderName_2010AB
    {
        
        [D(1, typeof(X12_ID_98_NM1_PaytoProviderName_2010AB), "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, typeof(X12_ID_1065_NM1_PaytoProviderName_2010AB), "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string PaytoProviderLastOrOrganizationalName_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string PaytoProviderFirstName_04 { get; set; }
        [D(5, typeof(X12_AN))]
        public string PaytoProviderMiddleName_05 { get; set; }
        [D(6, typeof(X12_AN))]
        public string NM1_06 { get; set; }
        [D(7, typeof(X12_AN))]
        public string PaytoProviderNameSuffix_07 { get; set; }
        [D(8, typeof(X12_ID_66_NM1_PaytoProviderName_2010AB), "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, typeof(X12_AN))]
        public string PaytoProviderIdentifier_09 { get; set; }
        [D(10, typeof(X12_ID))]
        public string NM1_10 { get; set; }
        [D(11, typeof(X12_ID))]
        public string NM1_11 { get; set; }
    }
    
    public class X12_ID_98_NM1_PaytoProviderName_2010AB
    {
        
        public List<string> Codes = new List<string> {"87"};
    }
    
    public class X12_ID_1065_NM1_PaytoProviderName_2010AB
    {
        
        public List<string> Codes = new List<string> {"1","2"};
    }
    
    public class X12_ID_66_NM1_PaytoProviderName_2010AB
    {
        
        public List<string> Codes = new List<string> {"24","34","XX"};
    }
    
    public class Loop_2010AA
    {
        
        [S("NM1", 1)]
        public NM1_BillingProviderName_2010AA NM1_BillingProviderName_2010AA { get; set; }
        [S("N3", 2)]
        public N3_BillingProviderAddress_2010AA N3_BillingProviderAddress_2010AA { get; set; }
        [S("N4", 3)]
        public N4_BillingProviderCityStateZIPCode_2010AA N4_BillingProviderCityStateZIPCode_2010AA { get; set; }
        [A(4)]
        public All_REF_2010AA All_REF_2010AA { get; set; }
        [S("PER", 5)]
        public List<PER_BillingProviderContactInformation_2010AA> PER_BillingProviderContactInformation_2010AA { get; set; }
    }
    
    public class PER_BillingProviderContactInformation_2010AA
    {
        
        [D(1, typeof(X12_ID_366_PER_BillingProviderContactInformation_2010AA), "366")]
        public string ContactFunctionCode_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string BillingProviderContactName_02 { get; set; }
        [D(3, typeof(X12_ID_365_PER_BillingProviderContactInformation_2010AA), "365")]
        public string CommunicationNumberQualifier_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string CommunicationNumber_04 { get; set; }
        [D(5, typeof(X12_ID_365_PER_BillingProviderContactInformation_2010AA), "365")]
        public string CommunicationNumberQualifier_05 { get; set; }
        [D(6, typeof(X12_AN))]
        public string CommunicationNumber_06 { get; set; }
        [D(7, typeof(X12_ID_365_PER_BillingProviderContactInformation_2010AA), "365")]
        public string CommunicationNumberQualifier_07 { get; set; }
        [D(8, typeof(X12_AN))]
        public string CommunicationNumber_08 { get; set; }
        [D(9, typeof(X12_AN))]
        public string PER_09 { get; set; }
    }
    
    public class X12_ID_366_PER_BillingProviderContactInformation_2010AA
    {
        
        public List<string> Codes = new List<string> {"IC"};
    }
    
    public class X12_ID_365_PER_BillingProviderContactInformation_2010AA
    {
        
        public List<string> Codes = new List<string> {"EM","FX","TE"};
    }
    
    public class All_REF_2010AA
    {
        
        [S("REF", 1)]
        public List<REF_BillingProviderSecondaryIdentification_2010AA> REF_BillingProviderSecondaryIdentification_2010AA { get; set; }
        [S("REF", 2)]
        public List<REF_CreditDebitCardBillingInformation_2010AA> REF_CreditDebitCardBillingInformation_2010AA { get; set; }
    }
    
    public class REF_CreditDebitCardBillingInformation_2010AA
    {
        
        [D(1, typeof(X12_ID_128_REF_CreditDebitCardBillingInformation_2010AA), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string BillingProviderCreditCardIdentifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string REF_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string REF_04 { get; set; }
    }
    
    public class X12_ID_128_REF_CreditDebitCardBillingInformation_2010AA
    {
        
        public List<string> Codes = new List<string> {"06","8U","EM","IJ","RB","ST","TT"};
    }
    
    public class REF_BillingProviderSecondaryIdentification_2010AA
    {
        
        [D(1, typeof(X12_ID_128_REF_BillingProviderSecondaryIdentification_2010AA), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string BillingProviderAdditionalIdentifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string REF_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string REF_04 { get; set; }
    }
    
    public class X12_ID_128_REF_BillingProviderSecondaryIdentification_2010AA
    {
        
        public List<string> Codes = new List<string> {"0B","1A","1B","1C","1D","1G","1H","1J","B3","BQ","EI","FH","G2","G5","LU","SY","U3","X5"};
    }
    
    public class N4_BillingProviderCityStateZIPCode_2010AA
    {
        
        [D(1, typeof(X12_AN))]
        public string BillingProviderCityName_01 { get; set; }
        [D(2, typeof(X12_ID))]
        public string BillingProviderStateOrProvinceCode_02 { get; set; }
        [D(3, typeof(X12_ID))]
        public string BillingProviderPostalZoneOrZIPCode_03 { get; set; }
        [D(4, typeof(X12_ID))]
        public string CountryCode_04 { get; set; }
        [D(5, typeof(X12_ID))]
        public string N4_05 { get; set; }
        [D(6, typeof(X12_AN))]
        public string N4_06 { get; set; }
    }
    
    public class N3_BillingProviderAddress_2010AA
    {
        
        [D(1, typeof(X12_AN))]
        public string BillingProviderAddressLine_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string BillingProviderAddressLine_02 { get; set; }
    }
    
    public class NM1_BillingProviderName_2010AA
    {
        
        [D(1, typeof(X12_ID_98_NM1_BillingProviderName_2010AA), "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, typeof(X12_ID_1065_NM1_BillingProviderName_2010AA), "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string BillingProviderLastOrOrganizationalName_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string BillingProviderFirstName_04 { get; set; }
        [D(5, typeof(X12_AN))]
        public string BillingProviderMiddleName_05 { get; set; }
        [D(6, typeof(X12_AN))]
        public string NM1_06 { get; set; }
        [D(7, typeof(X12_AN))]
        public string BillingProviderNameSuffix_07 { get; set; }
        [D(8, typeof(X12_ID_66_NM1_BillingProviderName_2010AA), "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, typeof(X12_AN))]
        public string BillingProviderIdentifier_09 { get; set; }
        [D(10, typeof(X12_ID))]
        public string NM1_10 { get; set; }
        [D(11, typeof(X12_ID))]
        public string NM1_11 { get; set; }
    }
    
    public class X12_ID_98_NM1_BillingProviderName_2010AA
    {
        
        public List<string> Codes = new List<string> {"85"};
    }
    
    public class X12_ID_1065_NM1_BillingProviderName_2010AA
    {
        
        public List<string> Codes = new List<string> {"1","2"};
    }
    
    public class X12_ID_66_NM1_BillingProviderName_2010AA
    {
        
        public List<string> Codes = new List<string> {"24","34","XX"};
    }
    
    public class CUR_ForeignCurrencyInformation_2000A
    {
        
        [D(1, typeof(X12_ID_98_CUR_ForeignCurrencyInformation_2000A), "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, typeof(X12_ID))]
        public string CurrencyCode_02 { get; set; }
        [D(3, typeof(X12_R))]
        public string CUR_03 { get; set; }
        [D(4, typeof(X12_ID))]
        public string CUR_04 { get; set; }
        [D(5, typeof(X12_ID))]
        public string CUR_05 { get; set; }
        [D(6, typeof(X12_ID))]
        public string CUR_06 { get; set; }
        [D(7, typeof(X12_ID))]
        public string CUR_07 { get; set; }
        [D(8, typeof(X12_DT))]
        public string CUR_08 { get; set; }
        [D(9, typeof(X12_TM))]
        public string CUR_09 { get; set; }
        [D(10, typeof(X12_ID))]
        public string CUR_10 { get; set; }
        [D(11, typeof(X12_DT))]
        public string CUR_11 { get; set; }
        [D(12, typeof(X12_TM))]
        public string CUR_12 { get; set; }
        [D(13, typeof(X12_ID))]
        public string CUR_13 { get; set; }
        [D(14, typeof(X12_DT))]
        public string CUR_14 { get; set; }
        [D(15, typeof(X12_TM))]
        public string CUR_15 { get; set; }
        [D(16, typeof(X12_ID))]
        public string CUR_16 { get; set; }
        [D(17, typeof(X12_DT))]
        public string CUR_17 { get; set; }
        [D(18, typeof(X12_TM))]
        public string CUR_18 { get; set; }
        [D(19, typeof(X12_ID))]
        public string CUR_19 { get; set; }
        [D(20, typeof(X12_DT))]
        public string CUR_20 { get; set; }
        [D(21, typeof(X12_TM))]
        public string CUR_21 { get; set; }
    }
    
    public class X12_ID_98_CUR_ForeignCurrencyInformation_2000A
    {
        
        public List<string> Codes = new List<string> {"85"};
    }
    
    public class X12_TM
    {
    }
    
    public class PRV_BillingPaytoProviderSpecialtyInformation_2000A
    {
        
        [D(1, typeof(X12_ID_1221_PRV_BillingPaytoProviderSpecialtyInformation_2000A), "1221")]
        public string ProviderCode_01 { get; set; }
        [D(2, typeof(X12_ID_128_PRV_BillingPaytoProviderSpecialtyInformation_2000A), "128")]
        public string ReferenceIdentificationQualifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string ProviderTaxonomyCode_03 { get; set; }
        [D(4, typeof(X12_ID))]
        public string PRV_04 { get; set; }
        [D(5, typeof(X12_AN))]
        public string PRV_05 { get; set; }
        [D(6, typeof(X12_ID))]
        public string PRV_06 { get; set; }
    }
    
    public class X12_ID_1221_PRV_BillingPaytoProviderSpecialtyInformation_2000A
    {
        
        public List<string> Codes = new List<string> {"BI","PT"};
    }
    
    public class X12_ID_128_PRV_BillingPaytoProviderSpecialtyInformation_2000A
    {
        
        public List<string> Codes = new List<string> {"ZZ"};
    }
    
    public class HL_BillingPaytoProviderHierarchicalLevel_2000A
    {
        
        [D(1, typeof(X12_AN))]
        public string HierarchicalIDNumber_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string HL_02 { get; set; }
        [D(3, typeof(X12_ID_735_HL_BillingPaytoProviderHierarchicalLevel_2000A), "735")]
        public string HierarchicalLevelCode_03 { get; set; }
        [D(4, typeof(X12_ID_736_HL_BillingPaytoProviderHierarchicalLevel_2000A), "736")]
        public string HierarchicalChildCode_04 { get; set; }
    }
    
    public class X12_ID_735_HL_BillingPaytoProviderHierarchicalLevel_2000A
    {
        
        public List<string> Codes = new List<string> {"20"};
    }
    
    public class X12_ID_736_HL_BillingPaytoProviderHierarchicalLevel_2000A
    {
        
        public List<string> Codes = new List<string> {"1"};
    }
    
    public class Loop_1000B
    {
        
        [S("NM1", 1)]
        public NM1_ReceiverName_1000B NM1_ReceiverName_1000B { get; set; }
    }
    
    public class NM1_ReceiverName_1000B
    {
        
        [D(1, typeof(X12_ID_98_NM1_ReceiverName_1000B), "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, typeof(X12_ID_1065_NM1_ReceiverName_1000B), "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string ReceiverName_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string NM1_04 { get; set; }
        [D(5, typeof(X12_AN))]
        public string NM1_05 { get; set; }
        [D(6, typeof(X12_AN))]
        public string NM1_06 { get; set; }
        [D(7, typeof(X12_AN))]
        public string NM1_07 { get; set; }
        [D(8, typeof(X12_ID_66_NM1_ReceiverName_1000B), "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, typeof(X12_AN))]
        public string ReceiverPrimaryIdentifier_09 { get; set; }
        [D(10, typeof(X12_ID))]
        public string NM1_10 { get; set; }
        [D(11, typeof(X12_ID))]
        public string NM1_11 { get; set; }
    }
    
    public class X12_ID_98_NM1_ReceiverName_1000B
    {
        
        public List<string> Codes = new List<string> {"40"};
    }
    
    public class X12_ID_1065_NM1_ReceiverName_1000B
    {
        
        public List<string> Codes = new List<string> {"2"};
    }
    
    public class X12_ID_66_NM1_ReceiverName_1000B
    {
        
        public List<string> Codes = new List<string> {"46"};
    }
    
    public class Loop_1000A
    {
        
        [S("NM1", 1)]
        public NM1_SubmitterName_1000A NM1_SubmitterName_1000A { get; set; }
        [S("PER", 2)]
        public List<PER_SubmitterEDIContactInformation_1000A> PER_SubmitterEDIContactInformation_1000A { get; set; }
    }
    
    public class PER_SubmitterEDIContactInformation_1000A
    {
        
        [D(1, typeof(X12_ID_366_PER_SubmitterEDIContactInformation_1000A), "366")]
        public string ContactFunctionCode_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string SubmitterContactName_02 { get; set; }
        [D(3, typeof(X12_ID_365_PER_SubmitterEDIContactInformation_1000A), "365")]
        public string CommunicationNumberQualifier_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string CommunicationNumber_04 { get; set; }
        [D(5, typeof(X12_ID_365_PER_SubmitterEDIContactInformation_1000A), "365")]
        public string CommunicationNumberQualifier_05 { get; set; }
        [D(6, typeof(X12_AN))]
        public string CommunicationNumber_06 { get; set; }
        [D(7, typeof(X12_ID_365_PER_SubmitterEDIContactInformation_1000A), "365")]
        public string CommunicationNumberQualifier_07 { get; set; }
        [D(8, typeof(X12_AN))]
        public string CommunicationNumber_08 { get; set; }
        [D(9, typeof(X12_AN))]
        public string PER_09 { get; set; }
    }
    
    public class X12_ID_366_PER_SubmitterEDIContactInformation_1000A
    {
        
        public List<string> Codes = new List<string> {"IC"};
    }
    
    public class X12_ID_365_PER_SubmitterEDIContactInformation_1000A
    {
        
        public List<string> Codes = new List<string> {"ED","EM","FX","TE"};
    }
    
    public class NM1_SubmitterName_1000A
    {
        
        [D(1, typeof(X12_ID_98_NM1_SubmitterName_1000A), "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, typeof(X12_ID_1065_NM1_SubmitterName_1000A), "1065")]
        public string EntityTypeQualifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string SubmitterLastOrOrganizationName_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string SubmitterFirstName_04 { get; set; }
        [D(5, typeof(X12_AN))]
        public string SubmitterMiddleName_05 { get; set; }
        [D(6, typeof(X12_AN))]
        public string NM1_06 { get; set; }
        [D(7, typeof(X12_AN))]
        public string NM1_07 { get; set; }
        [D(8, typeof(X12_ID_66_NM1_SubmitterName_1000A), "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, typeof(X12_AN))]
        public string SubmitterIdentifier_09 { get; set; }
        [D(10, typeof(X12_ID))]
        public string NM1_10 { get; set; }
        [D(11, typeof(X12_ID))]
        public string NM1_11 { get; set; }
    }
    
    public class X12_ID_98_NM1_SubmitterName_1000A
    {
        
        public List<string> Codes = new List<string> {"41"};
    }
    
    public class X12_ID_1065_NM1_SubmitterName_1000A
    {
        
        public List<string> Codes = new List<string> {"1","2"};
    }
    
    public class X12_ID_66_NM1_SubmitterName_1000A
    {
        
        public List<string> Codes = new List<string> {"46"};
    }
    
    public class REF_TransmissionTypeIdentification
    {
        
        [D(1, typeof(X12_ID_128_REF_TransmissionTypeIdentification), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string TransmissionTypeCode_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string REF_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string REF_04 { get; set; }
    }
    
    public class X12_ID_128_REF_TransmissionTypeIdentification
    {
        
        public List<string> Codes = new List<string> {"87"};
    }
    
    public class BHT_BeginningOfHierarchicalTransaction
    {
        
        [D(1, typeof(X12_ID_1005_BHT_BeginningOfHierarchicalTransaction), "1005")]
        public string HierarchicalStructureCode_01 { get; set; }
        [D(2, typeof(X12_ID_353_BHT_BeginningOfHierarchicalTransaction), "353")]
        public string TransactionSetPurposeCode_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string OriginatorApplicationTransactionIdentifier_03 { get; set; }
        [D(4, typeof(X12_DT))]
        public string TransactionSetCreationDate_04 { get; set; }
        [D(5, typeof(X12_TM))]
        public string TransactionSetCreationTime_05 { get; set; }
        [D(6, typeof(X12_ID_640_BHT_BeginningOfHierarchicalTransaction), "640")]
        public string ClaimOrEncounterIdentifier_06 { get; set; }
    }
    
    public class X12_ID_1005_BHT_BeginningOfHierarchicalTransaction
    {
        
        public List<string> Codes = new List<string> {"0019"};
    }
    
    public class X12_ID_353_BHT_BeginningOfHierarchicalTransaction
    {
        
        public List<string> Codes = new List<string> {"00","18"};
    }
    
    public class X12_ID_640_BHT_BeginningOfHierarchicalTransaction
    {
        
        public List<string> Codes = new List<string> {"CH","RP"};
    }
    
    public class ST
    {
        
        [D(1, typeof(X12_AN), "143")]
        public string TransactionSetIdentifierCode_01 { get; set; }
        [D(2, typeof(X12_AN), "329")]
        public string TransactionSetControlNumber_02 { get; set; }
        [D(3, typeof(X12_AN), "1705")]
        public string ImplementationConventionPreference_03 { get; set; }
    }
}
