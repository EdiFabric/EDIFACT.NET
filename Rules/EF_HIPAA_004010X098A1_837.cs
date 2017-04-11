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
        public HL_BillingPaytoProviderHierarchicalLevel HL_BillingPaytoProviderHierarchicalLevel { get; set; }
        [S("PRV", 2)]
        public PRV_BillingPaytoProviderSpecialtyInformation PRV_BillingPaytoProviderSpecialtyInformation { get; set; }
        [S("CUR", 3)]
        public CUR_ForeignCurrencyInformation CUR_ForeignCurrencyInformation { get; set; }
        [A(4)]
        public All_2010A All_2010A { get; set; }
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
        public All_2010B All_2010B { get; set; }
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
        public PAT_PatientInformation PAT_PatientInformation { get; set; }
        [G(3)]
        public Loop_2010CA Loop_2010CA { get; set; }
        [G(4)]
        public List<Loop_2300> Loop_2300 { get; set; }
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
        [A(5)]
        public All_AMT All_AMT { get; set; }
        [A(6)]
        public All_REF All_REF { get; set; }
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
        [S("HI", 12)]
        public HI_HealthCareDiagnosisCode HI_HealthCareDiagnosisCode { get; set; }
        [S("HCP", 13)]
        public HCP_ClaimPricingRepricingInformation HCP_ClaimPricingRepricingInformation { get; set; }
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
        public LX_ServiceLine LX_ServiceLine { get; set; }
        [S("SV1", 2)]
        public SV1_ProfessionalService SV1_ProfessionalService { get; set; }
        [S("SV5", 3)]
        public SV5_DurableMedicalEquipmentService SV5_DurableMedicalEquipmentService { get; set; }
        [S("PWK", 4)]
        public PWK_DMERCCMNIndicator PWK_DMERCCMNIndicator { get; set; }
        [S("CR1", 5)]
        public CR1_AmbulanceTransportInformation CR1_AmbulanceTransportInformation { get; set; }
        [S("CR2", 6)]
        public List<CR2_SpinalManipulationServiceInformation> CR2_SpinalManipulationServiceInformation { get; set; }
        [S("CR3", 7)]
        public CR3_DurableMedicalEquipmentCertification CR3_DurableMedicalEquipmentCertification { get; set; }
        [S("CR5", 8)]
        public CR5_HomeOxygenTherapyInformation CR5_HomeOxygenTherapyInformation { get; set; }
        [A(9)]
        public All_CRC All_CRC { get; set; }
        [A(10)]
        public All_DTP All_DTP { get; set; }
        [S("MEA", 11)]
        public List<MEA_TestResult> MEA_TestResult { get; set; }
        [S("CN1", 12)]
        public CN1_ContractInformation CN1_ContractInformation { get; set; }
        [A(13)]
        public All_REF All_REF { get; set; }
        [A(14)]
        public All_AMT All_AMT { get; set; }
        [S("K3", 15)]
        public List<K3_FileInformation> K3_FileInformation { get; set; }
        [S("NTE", 16)]
        public NTE_LineNote NTE_LineNote { get; set; }
        [S("PS1", 17)]
        public PS1_PurchasedServiceInformation PS1_PurchasedServiceInformation { get; set; }
        [S("HSD", 18)]
        public HSD_HealthCareServicesDelivery HSD_HealthCareServicesDelivery { get; set; }
        [S("HCP", 19)]
        public HCP_LinePricingRepricingInformation HCP_LinePricingRepricingInformation { get; set; }
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
        public LQ_FormIdentificationCode LQ_FormIdentificationCode { get; set; }
        [S("FRM", 2)]
        public List<FRM_SupportingDocumentation> FRM_SupportingDocumentation { get; set; }
    }
    
    public class FRM_SupportingDocumentation
    {
        
        [D(1, typeof(X12_AN))]
        public string QuestionNumberLetter_01 { get; set; }
        [D(2, typeof(X12_ID_1073_FRM_SupportingDocumentation), "1073")]
        public string QuestionResponse_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string QuestionResponse_03 { get; set; }
        [D(4, typeof(X12_DT))]
        public string QuestionResponse_04 { get; set; }
        [D(5, typeof(X12_R))]
        public string QuestionResponse_05 { get; set; }
    }
    
    public class X12_ID_1073_FRM_SupportingDocumentation
    {
        
        public List<string> Codes = new List<string> {"N","W","Y"};
    }
    
    public class X12_DT
    {
    }
    
    public class X12_R
    {
    }
    
    public class LQ_FormIdentificationCode
    {
        
        [D(1, typeof(X12_ID_1270_LQ_FormIdentificationCode), "1270")]
        public string CodeListQualifierCode_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string FormIdentifier_02 { get; set; }
    }
    
    public class X12_ID_1270_LQ_FormIdentificationCode
    {
        
        public List<string> Codes = new List<string> {"AS","UT"};
    }
    
    public class Loop_2430
    {
        
        [S("SVD", 1)]
        public SVD_LineAdjudicationInformation SVD_LineAdjudicationInformation { get; set; }
        [S("CAS", 2)]
        public List<CAS_LineAdjustment> CAS_LineAdjustment { get; set; }
        [S("DTP", 3)]
        public DTP_LineAdjudicationDate DTP_LineAdjudicationDate { get; set; }
    }
    
    public class DTP_LineAdjudicationDate
    {
        
        [D(1, typeof(X12_ID_374_DTP_LineAdjudicationDate), "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_1250_DTP_LineAdjudicationDate), "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string AdjudicationOrPaymentDate_03 { get; set; }
    }
    
    public class X12_ID_374_DTP_LineAdjudicationDate
    {
        
        public List<string> Codes = new List<string> {"573"};
    }
    
    public class X12_ID_1250_DTP_LineAdjudicationDate
    {
        
        public List<string> Codes = new List<string> {"D8"};
    }
    
    public class CAS_LineAdjustment
    {
        
        [D(1, typeof(X12_ID_1033_CAS_LineAdjustment), "1033")]
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
    
    public class X12_ID_1033_CAS_LineAdjustment
    {
        
        public List<string> Codes = new List<string> {"CO","CR","OA","PI","PR"};
    }
    
    public class X12_ID
    {
    }
    
    public class SVD_LineAdjudicationInformation
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
        public NM1_OtherPayerPriorAuthorizationOrReferralNumber NM1_OtherPayerPriorAuthorizationOrReferralNumber { get; set; }
        [S("REF", 2)]
        public List<REF_OtherPayerPriorAuthorizationOrReferralNumber> REF_OtherPayerPriorAuthorizationOrReferralNumber { get; set; }
    }
    
    public class REF_OtherPayerPriorAuthorizationOrReferralNumber
    {
        
        [D(1, typeof(X12_ID_128_REF_OtherPayerPriorAuthorizationOrReferralNumber), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string OtherPayerPriorAuthorizationOrReferralNumber_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string REF_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string REF_04 { get; set; }
    }
    
    public class X12_ID_128_REF_OtherPayerPriorAuthorizationOrReferralNumber
    {
        
        public List<string> Codes = new List<string> {"9F","G1"};
    }
    
    public class NM1_OtherPayerPriorAuthorizationOrReferralNumber
    {
        
        [D(1, typeof(X12_ID_98_NM1_OtherPayerPriorAuthorizationOrReferralNumber), "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, typeof(X12_ID_1065_NM1_OtherPayerPriorAuthorizationOrReferralNumber), "1065")]
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
        [D(8, typeof(X12_ID_66_NM1_OtherPayerPriorAuthorizationOrReferralNumber), "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, typeof(X12_AN))]
        public string OtherPayerIdentificationNumber_09 { get; set; }
        [D(10, typeof(X12_ID))]
        public string NM1_10 { get; set; }
        [D(11, typeof(X12_ID))]
        public string NM1_11 { get; set; }
    }
    
    public class X12_ID_98_NM1_OtherPayerPriorAuthorizationOrReferralNumber
    {
        
        public List<string> Codes = new List<string> {"PR"};
    }
    
    public class X12_ID_1065_NM1_OtherPayerPriorAuthorizationOrReferralNumber
    {
        
        public List<string> Codes = new List<string> {"2"};
    }
    
    public class X12_ID_66_NM1_OtherPayerPriorAuthorizationOrReferralNumber
    {
        
        public List<string> Codes = new List<string> {"PI","XV"};
    }
    
    public class Loop_2420F
    {
        
        [S("NM1", 1)]
        public NM1_ReferringProviderName NM1_ReferringProviderName { get; set; }
        [S("PRV", 2)]
        public PRV_ReferringProviderSpecialtyInformation PRV_ReferringProviderSpecialtyInformation { get; set; }
        [S("REF", 3)]
        public List<REF_ReferringProviderSecondaryIdentification> REF_ReferringProviderSecondaryIdentification { get; set; }
    }
    
    public class REF_ReferringProviderSecondaryIdentification
    {
        
        [D(1, typeof(X12_ID_128_REF_ReferringProviderSecondaryIdentification), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string ReferringProviderSecondaryIdentifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string REF_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string REF_04 { get; set; }
    }
    
    public class X12_ID_128_REF_ReferringProviderSecondaryIdentification
    {
        
        public List<string> Codes = new List<string> {"0B","1B","1C","1D","1G","1H","EI","G2","LU","N5","SY","X5"};
    }
    
    public class PRV_ReferringProviderSpecialtyInformation
    {
        
        [D(1, typeof(X12_ID_1221_PRV_ReferringProviderSpecialtyInformation), "1221")]
        public string ProviderCode_01 { get; set; }
        [D(2, typeof(X12_ID_128_PRV_ReferringProviderSpecialtyInformation), "128")]
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
    
    public class X12_ID_1221_PRV_ReferringProviderSpecialtyInformation
    {
        
        public List<string> Codes = new List<string> {"RF"};
    }
    
    public class X12_ID_128_PRV_ReferringProviderSpecialtyInformation
    {
        
        public List<string> Codes = new List<string> {"ZZ"};
    }
    
    public class NM1_ReferringProviderName
    {
        
        [D(1, typeof(X12_ID_98_NM1_ReferringProviderName), "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, typeof(X12_ID_1065_NM1_ReferringProviderName), "1065")]
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
        [D(8, typeof(X12_ID_66_NM1_ReferringProviderName), "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, typeof(X12_AN))]
        public string ReferringProviderIdentifier_09 { get; set; }
        [D(10, typeof(X12_ID))]
        public string NM1_10 { get; set; }
        [D(11, typeof(X12_ID))]
        public string NM1_11 { get; set; }
    }
    
    public class X12_ID_98_NM1_ReferringProviderName
    {
        
        public List<string> Codes = new List<string> {"DN","P3"};
    }
    
    public class X12_ID_1065_NM1_ReferringProviderName
    {
        
        public List<string> Codes = new List<string> {"1"};
    }
    
    public class X12_ID_66_NM1_ReferringProviderName
    {
        
        public List<string> Codes = new List<string> {"24","34","XX"};
    }
    
    public class Loop_2420E
    {
        
        [S("NM1", 1)]
        public NM1_OrderingProviderName NM1_OrderingProviderName { get; set; }
        [S("N3", 2)]
        public N3_OrderingProviderAddress N3_OrderingProviderAddress { get; set; }
        [S("N4", 3)]
        public N4_OrderingProviderCityStateZIPCode N4_OrderingProviderCityStateZIPCode { get; set; }
        [S("REF", 4)]
        public List<REF_OrderingProviderSecondaryIdentification> REF_OrderingProviderSecondaryIdentification { get; set; }
        [S("PER", 5)]
        public PER_OrderingProviderContactInformation PER_OrderingProviderContactInformation { get; set; }
    }
    
    public class PER_OrderingProviderContactInformation
    {
        
        [D(1, typeof(X12_ID_366_PER_OrderingProviderContactInformation), "366")]
        public string ContactFunctionCode_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string OrderingProviderContactName_02 { get; set; }
        [D(3, typeof(X12_ID_365_PER_OrderingProviderContactInformation), "365")]
        public string CommunicationNumberQualifier_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string CommunicationNumber_04 { get; set; }
        [D(5, typeof(X12_ID_365_PER_OrderingProviderContactInformation), "365")]
        public string CommunicationNumberQualifier_05 { get; set; }
        [D(6, typeof(X12_AN))]
        public string CommunicationNumber_06 { get; set; }
        [D(7, typeof(X12_ID_365_PER_OrderingProviderContactInformation), "365")]
        public string CommunicationNumberQualifier_07 { get; set; }
        [D(8, typeof(X12_AN))]
        public string CommunicationNumber_08 { get; set; }
        [D(9, typeof(X12_AN))]
        public string PER_09 { get; set; }
    }
    
    public class X12_ID_366_PER_OrderingProviderContactInformation
    {
        
        public List<string> Codes = new List<string> {"IC"};
    }
    
    public class X12_ID_365_PER_OrderingProviderContactInformation
    {
        
        public List<string> Codes = new List<string> {"EM","FX","TE"};
    }
    
    public class REF_OrderingProviderSecondaryIdentification
    {
        
        [D(1, typeof(X12_ID_128_REF_OrderingProviderSecondaryIdentification), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string OrderingProviderSecondaryIdentifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string REF_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string REF_04 { get; set; }
    }
    
    public class X12_ID_128_REF_OrderingProviderSecondaryIdentification
    {
        
        public List<string> Codes = new List<string> {"0B","1B","1C","1D","1G","1H","EI","G2","LU","N5","SY","X5"};
    }
    
    public class N4_OrderingProviderCityStateZIPCode
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
    
    public class N3_OrderingProviderAddress
    {
        
        [D(1, typeof(X12_AN))]
        public string OrderingProviderAddressLine_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string OrderingProviderAddressLine_02 { get; set; }
    }
    
    public class NM1_OrderingProviderName
    {
        
        [D(1, typeof(X12_ID_98_NM1_OrderingProviderName), "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, typeof(X12_ID_1065_NM1_OrderingProviderName), "1065")]
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
        [D(8, typeof(X12_ID_66_NM1_OrderingProviderName), "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, typeof(X12_AN))]
        public string OrderingProviderIdentifier_09 { get; set; }
        [D(10, typeof(X12_ID))]
        public string NM1_10 { get; set; }
        [D(11, typeof(X12_ID))]
        public string NM1_11 { get; set; }
    }
    
    public class X12_ID_98_NM1_OrderingProviderName
    {
        
        public List<string> Codes = new List<string> {"DK"};
    }
    
    public class X12_ID_1065_NM1_OrderingProviderName
    {
        
        public List<string> Codes = new List<string> {"1"};
    }
    
    public class X12_ID_66_NM1_OrderingProviderName
    {
        
        public List<string> Codes = new List<string> {"24","34","XX"};
    }
    
    public class Loop_2420D
    {
        
        [S("NM1", 1)]
        public NM1_SupervisingProviderName NM1_SupervisingProviderName { get; set; }
        [S("REF", 2)]
        public List<REF_SupervisingProviderSecondaryIdentification> REF_SupervisingProviderSecondaryIdentification { get; set; }
    }
    
    public class REF_SupervisingProviderSecondaryIdentification
    {
        
        [D(1, typeof(X12_ID_128_REF_SupervisingProviderSecondaryIdentification), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string SupervisingProviderSecondaryIdentifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string REF_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string REF_04 { get; set; }
    }
    
    public class X12_ID_128_REF_SupervisingProviderSecondaryIdentification
    {
        
        public List<string> Codes = new List<string> {"0B","1B","1C","1D","1G","1H","EI","G2","LU","N5","SY","X5"};
    }
    
    public class NM1_SupervisingProviderName
    {
        
        [D(1, typeof(X12_ID_98_NM1_SupervisingProviderName), "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, typeof(X12_ID_1065_NM1_SupervisingProviderName), "1065")]
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
        [D(8, typeof(X12_ID_66_NM1_SupervisingProviderName), "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, typeof(X12_AN))]
        public string SupervisingProviderIdentifier_09 { get; set; }
        [D(10, typeof(X12_ID))]
        public string NM1_10 { get; set; }
        [D(11, typeof(X12_ID))]
        public string NM1_11 { get; set; }
    }
    
    public class X12_ID_98_NM1_SupervisingProviderName
    {
        
        public List<string> Codes = new List<string> {"DQ"};
    }
    
    public class X12_ID_1065_NM1_SupervisingProviderName
    {
        
        public List<string> Codes = new List<string> {"1"};
    }
    
    public class X12_ID_66_NM1_SupervisingProviderName
    {
        
        public List<string> Codes = new List<string> {"24","34","XX"};
    }
    
    public class Loop_2420C
    {
        
        [S("NM1", 1)]
        public NM1_ServiceFacilityLocation NM1_ServiceFacilityLocation { get; set; }
        [S("N3", 2)]
        public N3_ServiceFacilityLocationAddress N3_ServiceFacilityLocationAddress { get; set; }
        [S("N4", 3)]
        public N4_ServiceFacilityLocationCityStateZIP N4_ServiceFacilityLocationCityStateZIP { get; set; }
        [S("REF", 4)]
        public List<REF_ServiceFacilityLocationSecondaryIdentification> REF_ServiceFacilityLocationSecondaryIdentification { get; set; }
    }
    
    public class REF_ServiceFacilityLocationSecondaryIdentification
    {
        
        [D(1, typeof(X12_ID_128_REF_ServiceFacilityLocationSecondaryIdentification), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string ServiceFacilityLocationSecondaryIdentifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string REF_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string REF_04 { get; set; }
    }
    
    public class X12_ID_128_REF_ServiceFacilityLocationSecondaryIdentification
    {
        
        public List<string> Codes = new List<string> {"0B","1A","1B","1C","1D","1G","1H","G2","LU","N5","TJ","X4","X5"};
    }
    
    public class N4_ServiceFacilityLocationCityStateZIP
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
    
    public class N3_ServiceFacilityLocationAddress
    {
        
        [D(1, typeof(X12_AN))]
        public string LaboratoryOrFacilityAddressLine_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string LaboratoryOrFacilityAddressLine_02 { get; set; }
    }
    
    public class NM1_ServiceFacilityLocation
    {
        
        [D(1, typeof(X12_ID_98_NM1_ServiceFacilityLocation), "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, typeof(X12_ID_1065_NM1_ServiceFacilityLocation), "1065")]
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
        [D(8, typeof(X12_ID_66_NM1_ServiceFacilityLocation), "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, typeof(X12_AN))]
        public string LaboratoryOrFacilityPrimaryIdentifier_09 { get; set; }
        [D(10, typeof(X12_ID))]
        public string NM1_10 { get; set; }
        [D(11, typeof(X12_ID))]
        public string NM1_11 { get; set; }
    }
    
    public class X12_ID_98_NM1_ServiceFacilityLocation
    {
        
        public List<string> Codes = new List<string> {"77","FA","LI","TL"};
    }
    
    public class X12_ID_1065_NM1_ServiceFacilityLocation
    {
        
        public List<string> Codes = new List<string> {"2"};
    }
    
    public class X12_ID_66_NM1_ServiceFacilityLocation
    {
        
        public List<string> Codes = new List<string> {"24","34","XX"};
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
        
        [D(1, typeof(X12_ID_128_REF_PurchasedServiceProviderSecondaryIdentification), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string PurchasedServiceProviderSecondaryIdentifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string REF_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string REF_04 { get; set; }
    }
    
    public class X12_ID_128_REF_PurchasedServiceProviderSecondaryIdentification
    {
        
        public List<string> Codes = new List<string> {"0B","1A","1B","1C","1D","1G","1H","EI","G2","LU","N5","SY","U3","X5"};
    }
    
    public class NM1_PurchasedServiceProviderName
    {
        
        [D(1, typeof(X12_ID_98_NM1_PurchasedServiceProviderName), "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, typeof(X12_ID_1065_NM1_PurchasedServiceProviderName), "1065")]
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
        [D(8, typeof(X12_ID_66_NM1_PurchasedServiceProviderName), "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, typeof(X12_AN))]
        public string PurchasedServiceProviderIdentifier_09 { get; set; }
        [D(10, typeof(X12_ID))]
        public string NM1_10 { get; set; }
        [D(11, typeof(X12_ID))]
        public string NM1_11 { get; set; }
    }
    
    public class X12_ID_98_NM1_PurchasedServiceProviderName
    {
        
        public List<string> Codes = new List<string> {"QB"};
    }
    
    public class X12_ID_1065_NM1_PurchasedServiceProviderName
    {
        
        public List<string> Codes = new List<string> {"1","2"};
    }
    
    public class X12_ID_66_NM1_PurchasedServiceProviderName
    {
        
        public List<string> Codes = new List<string> {"24","34","XX"};
    }
    
    public class Loop_2420A
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
        
        [D(1, typeof(X12_ID_128_REF_RenderingProviderSecondaryIdentification), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string RenderingProviderSecondaryIdentifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string REF_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string REF_04 { get; set; }
    }
    
    public class X12_ID_128_REF_RenderingProviderSecondaryIdentification
    {
        
        public List<string> Codes = new List<string> {"0B","1B","1C","1D","1G","1H","EI","G2","LU","N5","SY","X5"};
    }
    
    public class PRV_RenderingProviderSpecialtyInformation
    {
        
        [D(1, typeof(X12_ID_1221_PRV_RenderingProviderSpecialtyInformation), "1221")]
        public string ProviderCode_01 { get; set; }
        [D(2, typeof(X12_ID_128_PRV_RenderingProviderSpecialtyInformation), "128")]
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
    
    public class X12_ID_1221_PRV_RenderingProviderSpecialtyInformation
    {
        
        public List<string> Codes = new List<string> {"PE"};
    }
    
    public class X12_ID_128_PRV_RenderingProviderSpecialtyInformation
    {
        
        public List<string> Codes = new List<string> {"ZZ"};
    }
    
    public class NM1_RenderingProviderName
    {
        
        [D(1, typeof(X12_ID_98_NM1_RenderingProviderName), "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, typeof(X12_ID_1065_NM1_RenderingProviderName), "1065")]
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
        [D(8, typeof(X12_ID_66_NM1_RenderingProviderName), "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, typeof(X12_AN))]
        public string RenderingProviderIdentifier_09 { get; set; }
        [D(10, typeof(X12_ID))]
        public string NM1_10 { get; set; }
        [D(11, typeof(X12_ID))]
        public string NM1_11 { get; set; }
    }
    
    public class X12_ID_98_NM1_RenderingProviderName
    {
        
        public List<string> Codes = new List<string> {"82"};
    }
    
    public class X12_ID_1065_NM1_RenderingProviderName
    {
        
        public List<string> Codes = new List<string> {"1","2"};
    }
    
    public class X12_ID_66_NM1_RenderingProviderName
    {
        
        public List<string> Codes = new List<string> {"24","34","XX"};
    }
    
    public class Loop_2410
    {
        
        [S("LIN", 1)]
        public LIN_DrugIdentification LIN_DrugIdentification { get; set; }
        [S("CTP", 2)]
        public CTP_DrugPricing CTP_DrugPricing { get; set; }
        [S("REF", 3)]
        public REF_PrescriptionNumber REF_PrescriptionNumber { get; set; }
    }
    
    public class REF_PrescriptionNumber
    {
        
        [D(1, typeof(X12_ID_128_REF_PrescriptionNumber), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string PrescriptionNumber_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string REF_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string REF_04 { get; set; }
    }
    
    public class X12_ID_128_REF_PrescriptionNumber
    {
        
        public List<string> Codes = new List<string> {"XZ"};
    }
    
    public class CTP_DrugPricing
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
    
    public class LIN_DrugIdentification
    {
        
        [D(1, typeof(X12_AN))]
        public string LIN_01 { get; set; }
        [D(2, typeof(X12_ID_235_LIN_DrugIdentification), "235")]
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
    
    public class X12_ID_235_LIN_DrugIdentification
    {
        
        public List<string> Codes = new List<string> {"N4"};
    }
    
    public class HCP_LinePricingRepricingInformation
    {
        
        [D(1, typeof(X12_ID_1473_HCP_LinePricingRepricingInformation), "1473")]
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
        [D(9, typeof(X12_ID_235_HCP_LinePricingRepricingInformation), "235")]
        public string ProductOrServiceIDQualifier_09 { get; set; }
        [D(10, typeof(X12_AN))]
        public string ProcedureCode_10 { get; set; }
        [D(11, typeof(X12_ID_355_HCP_LinePricingRepricingInformation), "355")]
        public string UnitOrBasisForMeasurementCode_11 { get; set; }
        [D(12, typeof(X12_R))]
        public string RepricedApprovedServiceUnitCount_12 { get; set; }
        [D(13, typeof(X12_ID_901_HCP_LinePricingRepricingInformation), "901")]
        public string RejectReasonCode_13 { get; set; }
        [D(14, typeof(X12_ID_1526_HCP_LinePricingRepricingInformation), "1526")]
        public string PolicyComplianceCode_14 { get; set; }
        [D(15, typeof(X12_ID_1527_HCP_LinePricingRepricingInformation), "1527")]
        public string ExceptionCode_15 { get; set; }
    }
    
    public class X12_ID_1473_HCP_LinePricingRepricingInformation
    {
        
        public List<string> Codes = new List<string> {"00","01","02","03","04","05","06","07","08","09","10","11","12","13","14"};
    }
    
    public class X12_ID_235_HCP_LinePricingRepricingInformation
    {
        
        public List<string> Codes = new List<string> {"HC","IV","ZZ"};
    }
    
    public class X12_ID_355_HCP_LinePricingRepricingInformation
    {
        
        public List<string> Codes = new List<string> {"DA","UN"};
    }
    
    public class X12_ID_901_HCP_LinePricingRepricingInformation
    {
        
        public List<string> Codes = new List<string> {"T1","T2","T3","T4","T5","T6"};
    }
    
    public class X12_ID_1526_HCP_LinePricingRepricingInformation
    {
        
        public List<string> Codes = new List<string> {"1","2","3","4","5"};
    }
    
    public class X12_ID_1527_HCP_LinePricingRepricingInformation
    {
        
        public List<string> Codes = new List<string> {"1","2","3","4","5","6"};
    }
    
    public class HSD_HealthCareServicesDelivery
    {
        
        [D(1, typeof(X12_ID_673_HSD_HealthCareServicesDelivery), "673")]
        public string Visits_01 { get; set; }
        [D(2, typeof(X12_R))]
        public string NumberOfVisits_02 { get; set; }
        [D(3, typeof(X12_ID_355_HSD_HealthCareServicesDelivery), "355")]
        public string FrequencyPeriod_03 { get; set; }
        [D(4, typeof(X12_R))]
        public string FrequencyCount_04 { get; set; }
        [D(5, typeof(X12_ID_615_HSD_HealthCareServicesDelivery), "615")]
        public string DurationOfVisitsUnits_05 { get; set; }
        [D(6, typeof(X12_N0))]
        public string DurationOfVisitsNumberOfUnits_06 { get; set; }
        [D(7, typeof(X12_ID_678_HSD_HealthCareServicesDelivery), "678")]
        public string ShipDeliveryOrCalendarPatternCode_07 { get; set; }
        [D(8, typeof(X12_ID_679_HSD_HealthCareServicesDelivery), "679")]
        public string DeliveryPatternTimeCode_08 { get; set; }
    }
    
    public class X12_ID_673_HSD_HealthCareServicesDelivery
    {
        
        public List<string> Codes = new List<string> {"VS"};
    }
    
    public class X12_ID_355_HSD_HealthCareServicesDelivery
    {
        
        public List<string> Codes = new List<string> {"DA","MO","Q1","WK"};
    }
    
    public class X12_ID_615_HSD_HealthCareServicesDelivery
    {
        
        public List<string> Codes = new List<string> {"7","34","35"};
    }
    
    public class X12_ID_678_HSD_HealthCareServicesDelivery
    {
        
        public List<string> Codes = new List<string> {"1","2","3","4","5","6","7","A","B","C","D","E","F","G","H","J","K","L","N","O","SA","SB","SC","SD","SG","SL","SP","SX","SY","SZ","W"};
    }
    
    public class X12_ID_679_HSD_HealthCareServicesDelivery
    {
        
        public List<string> Codes = new List<string> {"D","E","F"};
    }
    
    public class PS1_PurchasedServiceInformation
    {
        
        [D(1, typeof(X12_AN))]
        public string PurchasedServiceProviderIdentifier_01 { get; set; }
        [D(2, typeof(X12_R))]
        public string PurchasedServiceChargeAmount_02 { get; set; }
        [D(3, typeof(X12_ID))]
        public string PS1_03 { get; set; }
    }
    
    public class NTE_LineNote
    {
        
        [D(1, typeof(X12_ID_363_NTE_LineNote), "363")]
        public string NoteReferenceCode_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string LineNoteText_02 { get; set; }
    }
    
    public class X12_ID_363_NTE_LineNote
    {
        
        public List<string> Codes = new List<string> {"ADD","DCP","PMT","TPO"};
    }
    
    public class K3_FileInformation
    {
        
        [D(1, typeof(X12_AN))]
        public string FixedFormatInformation_01 { get; set; }
        [D(2, typeof(X12_ID))]
        public string K3_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string K3_03 { get; set; }
    }
    
    public class All_AMT
    {
        
        [S("AMT", 1)]
        public AMT_SalesTaxAmount AMT_SalesTaxAmount { get; set; }
        [S("AMT", 2)]
        public AMT_ApprovedAmount AMT_ApprovedAmount { get; set; }
        [S("AMT", 3)]
        public AMT_PostageClaimedAmount AMT_PostageClaimedAmount { get; set; }
    }
    
    public class AMT_PostageClaimedAmount
    {
        
        [D(1, typeof(X12_ID_522_AMT_PostageClaimedAmount), "522")]
        public string AmountQualifierCode_01 { get; set; }
        [D(2, typeof(X12_R))]
        public string PostageClaimedAmount_02 { get; set; }
        [D(3, typeof(X12_ID))]
        public string AMT_03 { get; set; }
    }
    
    public class X12_ID_522_AMT_PostageClaimedAmount
    {
        
        public List<string> Codes = new List<string> {"F4"};
    }
    
    public class AMT_ApprovedAmount
    {
        
        [D(1, typeof(X12_ID_522_AMT_ApprovedAmount), "522")]
        public string AmountQualifierCode_01 { get; set; }
        [D(2, typeof(X12_R))]
        public string ApprovedAmount_02 { get; set; }
        [D(3, typeof(X12_ID))]
        public string AMT_03 { get; set; }
    }
    
    public class X12_ID_522_AMT_ApprovedAmount
    {
        
        public List<string> Codes = new List<string> {"AAE"};
    }
    
    public class AMT_SalesTaxAmount
    {
        
        [D(1, typeof(X12_ID_522_AMT_SalesTaxAmount), "522")]
        public string AmountQualifierCode_01 { get; set; }
        [D(2, typeof(X12_R))]
        public string SalesTaxAmount_02 { get; set; }
        [D(3, typeof(X12_ID))]
        public string AMT_03 { get; set; }
    }
    
    public class X12_ID_522_AMT_SalesTaxAmount
    {
        
        public List<string> Codes = new List<string> {"T"};
    }
    
    public class All_REF
    {
        
        [S("REF", 1)]
        public REF_RepricedLineItemReferenceNumber REF_RepricedLineItemReferenceNumber { get; set; }
        [S("REF", 2)]
        public REF_AdjustedRepricedLineItemReferenceNumber REF_AdjustedRepricedLineItemReferenceNumber { get; set; }
        [S("REF", 3)]
        public List<REF_PriorAuthorizationOrReferralNumber> REF_PriorAuthorizationOrReferralNumber { get; set; }
        [S("REF", 4)]
        public REF_LineItemControlNumber REF_LineItemControlNumber { get; set; }
        [S("REF", 5)]
        public REF_MammographyCertificationNumber REF_MammographyCertificationNumber { get; set; }
        [S("REF", 6)]
        public REF_ClinicalLaboratoryImprovementAmendmentCLIAIdentification REF_ClinicalLaboratoryImprovementAmendmentCLIAIdentification { get; set; }
        [S("REF", 7)]
        public REF_ReferringClinicalLaboratoryImprovementAmendmentCLIAFacilityIdentification REF_ReferringClinicalLaboratoryImprovementAmendmentCLIAFacilityIdentification { get; set; }
        [S("REF", 8)]
        public REF_ImmunizationBatchNumber REF_ImmunizationBatchNumber { get; set; }
        [S("REF", 9)]
        public List<REF_AmbulatoryPatientGroupAPG> REF_AmbulatoryPatientGroupAPG { get; set; }
        [S("REF", 10)]
        public REF_OxygenFlowRate REF_OxygenFlowRate { get; set; }
        [S("REF", 11)]
        public REF_UniversalProductNumberUPN REF_UniversalProductNumberUPN { get; set; }
    }
    
    public class REF_UniversalProductNumberUPN
    {
        
        [D(1, typeof(X12_ID_128_REF_UniversalProductNumberUPN), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string UniversalProductNumber_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string REF_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string REF_04 { get; set; }
    }
    
    public class X12_ID_128_REF_UniversalProductNumberUPN
    {
        
        public List<string> Codes = new List<string> {"OZ","VP"};
    }
    
    public class REF_OxygenFlowRate
    {
        
        [D(1, typeof(X12_ID_128_REF_OxygenFlowRate), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string OxygenFlowRate_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string REF_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string REF_04 { get; set; }
    }
    
    public class X12_ID_128_REF_OxygenFlowRate
    {
        
        public List<string> Codes = new List<string> {"TP"};
    }
    
    public class REF_AmbulatoryPatientGroupAPG
    {
        
        [D(1, typeof(X12_ID_128_REF_AmbulatoryPatientGroupAPG), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string AmbulatoryPatientGroupNumber_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string REF_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string REF_04 { get; set; }
    }
    
    public class X12_ID_128_REF_AmbulatoryPatientGroupAPG
    {
        
        public List<string> Codes = new List<string> {"1S"};
    }
    
    public class REF_ImmunizationBatchNumber
    {
        
        [D(1, typeof(X12_ID_128_REF_ImmunizationBatchNumber), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string ImmunizationBatchNumber_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string REF_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string REF_04 { get; set; }
    }
    
    public class X12_ID_128_REF_ImmunizationBatchNumber
    {
        
        public List<string> Codes = new List<string> {"BT"};
    }
    
    public class REF_ReferringClinicalLaboratoryImprovementAmendmentCLIAFacilityIdentification
    {
        
        [D(1, typeof(X12_ID_128_REF_ReferringClinicalLaboratoryImprovementAmendmentCLIAFacilityIdentification), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string ReferringCLIANumber_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string REF_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string REF_04 { get; set; }
    }
    
    public class X12_ID_128_REF_ReferringClinicalLaboratoryImprovementAmendmentCLIAFacilityIdentification
    {
        
        public List<string> Codes = new List<string> {"F4"};
    }
    
    public class REF_ClinicalLaboratoryImprovementAmendmentCLIAIdentification
    {
        
        [D(1, typeof(X12_ID_128_REF_ClinicalLaboratoryImprovementAmendmentCLIAIdentification), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string ClinicalLaboratoryImprovementAmendmentNumber_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string REF_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string REF_04 { get; set; }
    }
    
    public class X12_ID_128_REF_ClinicalLaboratoryImprovementAmendmentCLIAIdentification
    {
        
        public List<string> Codes = new List<string> {"X4"};
    }
    
    public class REF_MammographyCertificationNumber
    {
        
        [D(1, typeof(X12_ID_128_REF_MammographyCertificationNumber), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string MammographyCertificationNumber_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string REF_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string REF_04 { get; set; }
    }
    
    public class X12_ID_128_REF_MammographyCertificationNumber
    {
        
        public List<string> Codes = new List<string> {"EW"};
    }
    
    public class REF_LineItemControlNumber
    {
        
        [D(1, typeof(X12_ID_128_REF_LineItemControlNumber), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string LineItemControlNumber_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string REF_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string REF_04 { get; set; }
    }
    
    public class X12_ID_128_REF_LineItemControlNumber
    {
        
        public List<string> Codes = new List<string> {"6R"};
    }
    
    public class REF_PriorAuthorizationOrReferralNumber
    {
        
        [D(1, typeof(X12_ID_128_REF_PriorAuthorizationOrReferralNumber), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string PriorAuthorizationOrReferralNumber_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string REF_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string REF_04 { get; set; }
    }
    
    public class X12_ID_128_REF_PriorAuthorizationOrReferralNumber
    {
        
        public List<string> Codes = new List<string> {"9F","G1"};
    }
    
    public class REF_AdjustedRepricedLineItemReferenceNumber
    {
        
        [D(1, typeof(X12_ID_128_REF_AdjustedRepricedLineItemReferenceNumber), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string AdjustedRepricedLineItemReferenceNumber_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string REF_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string REF_04 { get; set; }
    }
    
    public class X12_ID_128_REF_AdjustedRepricedLineItemReferenceNumber
    {
        
        public List<string> Codes = new List<string> {"9D"};
    }
    
    public class REF_RepricedLineItemReferenceNumber
    {
        
        [D(1, typeof(X12_ID_128_REF_RepricedLineItemReferenceNumber), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string RepricedLineItemReferenceNumber_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string REF_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string REF_04 { get; set; }
    }
    
    public class X12_ID_128_REF_RepricedLineItemReferenceNumber
    {
        
        public List<string> Codes = new List<string> {"9B"};
    }
    
    public class CN1_ContractInformation
    {
        
        [D(1, typeof(X12_ID_1166_CN1_ContractInformation), "1166")]
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
    
    public class X12_ID_1166_CN1_ContractInformation
    {
        
        public List<string> Codes = new List<string> {"01","02","03","04","05","06","09"};
    }
    
    public class MEA_TestResult
    {
        
        [D(1, typeof(X12_ID_737_MEA_TestResult), "737")]
        public string MeasurementReferenceIdentificationCode_01 { get; set; }
        [D(2, typeof(X12_ID_738_MEA_TestResult), "738")]
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
    
    public class X12_ID_737_MEA_TestResult
    {
        
        public List<string> Codes = new List<string> {"OG","TR"};
    }
    
    public class X12_ID_738_MEA_TestResult
    {
        
        public List<string> Codes = new List<string> {"GRA","HT","R1","R2","R3","R4","ZO"};
    }
    
    public class All_DTP
    {
        
        [S("DTP", 1)]
        public DTP_DateServiceDate DTP_DateServiceDate { get; set; }
        [S("DTP", 2)]
        public DTP_DateCertificationRevisionDate DTP_DateCertificationRevisionDate { get; set; }
        [S("DTP", 3)]
        public DTP_DateBeginTherapyDate DTP_DateBeginTherapyDate { get; set; }
        [S("DTP", 4)]
        public DTP_DateLastCertificationDate DTP_DateLastCertificationDate { get; set; }
        [S("DTP", 5)]
        public DTP_DateDateLastSeen DTP_DateDateLastSeen { get; set; }
        [S("DTP", 6)]
        public List<DTP_DateTest> DTP_DateTest { get; set; }
        [S("DTP", 7)]
        public List<DTP_DateOxygenSaturationArterialBloodGasTest> DTP_DateOxygenSaturationArterialBloodGasTest { get; set; }
        [S("DTP", 8)]
        public DTP_DateShipped DTP_DateShipped { get; set; }
        [S("DTP", 9)]
        public DTP_DateOnsetOfCurrentSymptomIllness DTP_DateOnsetOfCurrentSymptomIllness { get; set; }
        [S("DTP", 10)]
        public DTP_DateLastXray DTP_DateLastXray { get; set; }
        [S("DTP", 11)]
        public DTP_DateAcuteManifestation DTP_DateAcuteManifestation { get; set; }
        [S("DTP", 12)]
        public DTP_DateInitialTreatment DTP_DateInitialTreatment { get; set; }
        [S("DTP", 13)]
        public DTP_DateSimilarIllnessSymptomOnset DTP_DateSimilarIllnessSymptomOnset { get; set; }
    }
    
    public class DTP_DateSimilarIllnessSymptomOnset
    {
        
        [D(1, typeof(X12_ID_374_DTP_DateSimilarIllnessSymptomOnset), "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_1250_DTP_DateSimilarIllnessSymptomOnset), "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string SimilarIllnessOrSymptomDate_03 { get; set; }
    }
    
    public class X12_ID_374_DTP_DateSimilarIllnessSymptomOnset
    {
        
        public List<string> Codes = new List<string> {"438"};
    }
    
    public class X12_ID_1250_DTP_DateSimilarIllnessSymptomOnset
    {
        
        public List<string> Codes = new List<string> {"D8"};
    }
    
    public class DTP_DateInitialTreatment
    {
        
        [D(1, typeof(X12_ID_374_DTP_DateInitialTreatment), "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_1250_DTP_DateInitialTreatment), "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string InitialTreatmentDate_03 { get; set; }
    }
    
    public class X12_ID_374_DTP_DateInitialTreatment
    {
        
        public List<string> Codes = new List<string> {"454"};
    }
    
    public class X12_ID_1250_DTP_DateInitialTreatment
    {
        
        public List<string> Codes = new List<string> {"D8"};
    }
    
    public class DTP_DateAcuteManifestation
    {
        
        [D(1, typeof(X12_ID_374_DTP_DateAcuteManifestation), "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_1250_DTP_DateAcuteManifestation), "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string AcuteManifestationDate_03 { get; set; }
    }
    
    public class X12_ID_374_DTP_DateAcuteManifestation
    {
        
        public List<string> Codes = new List<string> {"453"};
    }
    
    public class X12_ID_1250_DTP_DateAcuteManifestation
    {
        
        public List<string> Codes = new List<string> {"D8"};
    }
    
    public class DTP_DateLastXray
    {
        
        [D(1, typeof(X12_ID_374_DTP_DateLastXray), "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_1250_DTP_DateLastXray), "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string LastXRayDate_03 { get; set; }
    }
    
    public class X12_ID_374_DTP_DateLastXray
    {
        
        public List<string> Codes = new List<string> {"455"};
    }
    
    public class X12_ID_1250_DTP_DateLastXray
    {
        
        public List<string> Codes = new List<string> {"D8"};
    }
    
    public class DTP_DateOnsetOfCurrentSymptomIllness
    {
        
        [D(1, typeof(X12_ID_374_DTP_DateOnsetOfCurrentSymptomIllness), "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_1250_DTP_DateOnsetOfCurrentSymptomIllness), "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string OnsetDate_03 { get; set; }
    }
    
    public class X12_ID_374_DTP_DateOnsetOfCurrentSymptomIllness
    {
        
        public List<string> Codes = new List<string> {"431"};
    }
    
    public class X12_ID_1250_DTP_DateOnsetOfCurrentSymptomIllness
    {
        
        public List<string> Codes = new List<string> {"D8"};
    }
    
    public class DTP_DateShipped
    {
        
        [D(1, typeof(X12_ID_374_DTP_DateShipped), "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_1250_DTP_DateShipped), "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string ShippedDate_03 { get; set; }
    }
    
    public class X12_ID_374_DTP_DateShipped
    {
        
        public List<string> Codes = new List<string> {"011"};
    }
    
    public class X12_ID_1250_DTP_DateShipped
    {
        
        public List<string> Codes = new List<string> {"D8"};
    }
    
    public class DTP_DateOxygenSaturationArterialBloodGasTest
    {
        
        [D(1, typeof(X12_ID_374_DTP_DateOxygenSaturationArterialBloodGasTest), "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_1250_DTP_DateOxygenSaturationArterialBloodGasTest), "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string OxygenSaturationTestDate_03 { get; set; }
    }
    
    public class X12_ID_374_DTP_DateOxygenSaturationArterialBloodGasTest
    {
        
        public List<string> Codes = new List<string> {"119","480","481"};
    }
    
    public class X12_ID_1250_DTP_DateOxygenSaturationArterialBloodGasTest
    {
        
        public List<string> Codes = new List<string> {"D8"};
    }
    
    public class DTP_DateTest
    {
        
        [D(1, typeof(X12_ID_374_DTP_DateTest), "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_1250_DTP_DateTest), "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string TestPerformedDate_03 { get; set; }
    }
    
    public class X12_ID_374_DTP_DateTest
    {
        
        public List<string> Codes = new List<string> {"738","739"};
    }
    
    public class X12_ID_1250_DTP_DateTest
    {
        
        public List<string> Codes = new List<string> {"D8"};
    }
    
    public class DTP_DateDateLastSeen
    {
        
        [D(1, typeof(X12_ID_374_DTP_DateDateLastSeen), "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_1250_DTP_DateDateLastSeen), "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string LastSeenDate_03 { get; set; }
    }
    
    public class X12_ID_374_DTP_DateDateLastSeen
    {
        
        public List<string> Codes = new List<string> {"304"};
    }
    
    public class X12_ID_1250_DTP_DateDateLastSeen
    {
        
        public List<string> Codes = new List<string> {"D8"};
    }
    
    public class DTP_DateLastCertificationDate
    {
        
        [D(1, typeof(X12_ID_374_DTP_DateLastCertificationDate), "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_1250_DTP_DateLastCertificationDate), "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string LastCertificationDate_03 { get; set; }
    }
    
    public class X12_ID_374_DTP_DateLastCertificationDate
    {
        
        public List<string> Codes = new List<string> {"461"};
    }
    
    public class X12_ID_1250_DTP_DateLastCertificationDate
    {
        
        public List<string> Codes = new List<string> {"D8"};
    }
    
    public class DTP_DateBeginTherapyDate
    {
        
        [D(1, typeof(X12_ID_374_DTP_DateBeginTherapyDate), "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_1250_DTP_DateBeginTherapyDate), "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string BeginTherapyDate_03 { get; set; }
    }
    
    public class X12_ID_374_DTP_DateBeginTherapyDate
    {
        
        public List<string> Codes = new List<string> {"463"};
    }
    
    public class X12_ID_1250_DTP_DateBeginTherapyDate
    {
        
        public List<string> Codes = new List<string> {"D8"};
    }
    
    public class DTP_DateCertificationRevisionDate
    {
        
        [D(1, typeof(X12_ID_374_DTP_DateCertificationRevisionDate), "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_1250_DTP_DateCertificationRevisionDate), "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string CertificationRevisionDate_03 { get; set; }
    }
    
    public class X12_ID_374_DTP_DateCertificationRevisionDate
    {
        
        public List<string> Codes = new List<string> {"607"};
    }
    
    public class X12_ID_1250_DTP_DateCertificationRevisionDate
    {
        
        public List<string> Codes = new List<string> {"D8"};
    }
    
    public class DTP_DateServiceDate
    {
        
        [D(1, typeof(X12_ID_374_DTP_DateServiceDate), "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_1250_DTP_DateServiceDate), "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string ServiceDate_03 { get; set; }
    }
    
    public class X12_ID_374_DTP_DateServiceDate
    {
        
        public List<string> Codes = new List<string> {"472"};
    }
    
    public class X12_ID_1250_DTP_DateServiceDate
    {
        
        public List<string> Codes = new List<string> {"D8","RD8"};
    }
    
    public class All_CRC
    {
        
        [S("CRC", 1)]
        public List<CRC_AmbulanceCertification> CRC_AmbulanceCertification { get; set; }
        [S("CRC", 2)]
        public CRC_HospiceEmployeeIndicator CRC_HospiceEmployeeIndicator { get; set; }
        [S("CRC", 3)]
        public List<CRC_DMERCConditionIndicator> CRC_DMERCConditionIndicator { get; set; }
    }
    
    public class CRC_DMERCConditionIndicator
    {
        
        [D(1, typeof(X12_ID_1136_CRC_DMERCConditionIndicator), "1136")]
        public string CodeCategory_01 { get; set; }
        [D(2, typeof(X12_ID_1073_CRC_DMERCConditionIndicator), "1073")]
        public string CertificationConditionIndicator_02 { get; set; }
        [D(3, typeof(X12_ID_1321_CRC_DMERCConditionIndicator), "1321")]
        public string ConditionIndicator_03 { get; set; }
        [D(4, typeof(X12_ID_1321_CRC_DMERCConditionIndicator), "1321")]
        public string ConditionIndicator_04 { get; set; }
        [D(5, typeof(X12_ID_1321_CRC_DMERCConditionIndicator), "1321")]
        public string ConditionIndicator_05 { get; set; }
        [D(6, typeof(X12_ID_1321_CRC_DMERCConditionIndicator), "1321")]
        public string ConditionIndicator_06 { get; set; }
        [D(7, typeof(X12_ID_1321_CRC_DMERCConditionIndicator), "1321")]
        public string ConditionIndicator_07 { get; set; }
    }
    
    public class X12_ID_1136_CRC_DMERCConditionIndicator
    {
        
        public List<string> Codes = new List<string> {"09","11"};
    }
    
    public class X12_ID_1073_CRC_DMERCConditionIndicator
    {
        
        public List<string> Codes = new List<string> {"N","Y"};
    }
    
    public class X12_ID_1321_CRC_DMERCConditionIndicator
    {
        
        public List<string> Codes = new List<string> {"37","38","AL","P1","ZV"};
    }
    
    public class CRC_HospiceEmployeeIndicator
    {
        
        [D(1, typeof(X12_ID_1136_CRC_HospiceEmployeeIndicator), "1136")]
        public string CodeCategory_01 { get; set; }
        [D(2, typeof(X12_ID_1073_CRC_HospiceEmployeeIndicator), "1073")]
        public string HospiceEmployedProviderIndicator_02 { get; set; }
        [D(3, typeof(X12_ID_1321_CRC_HospiceEmployeeIndicator), "1321")]
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
    
    public class X12_ID_1136_CRC_HospiceEmployeeIndicator
    {
        
        public List<string> Codes = new List<string> {"70"};
    }
    
    public class X12_ID_1073_CRC_HospiceEmployeeIndicator
    {
        
        public List<string> Codes = new List<string> {"N","Y"};
    }
    
    public class X12_ID_1321_CRC_HospiceEmployeeIndicator
    {
        
        public List<string> Codes = new List<string> {"65"};
    }
    
    public class CRC_AmbulanceCertification
    {
        
        [D(1, typeof(X12_ID_1136_CRC_AmbulanceCertification), "1136")]
        public string CodeCategory_01 { get; set; }
        [D(2, typeof(X12_ID_1073_CRC_AmbulanceCertification), "1073")]
        public string CertificationConditionIndicator_02 { get; set; }
        [D(3, typeof(X12_ID_1321_CRC_AmbulanceCertification), "1321")]
        public string ConditionCode_03 { get; set; }
        [D(4, typeof(X12_ID_1321_CRC_AmbulanceCertification), "1321")]
        public string ConditionCode_04 { get; set; }
        [D(5, typeof(X12_ID_1321_CRC_AmbulanceCertification), "1321")]
        public string ConditionCode_05 { get; set; }
        [D(6, typeof(X12_ID_1321_CRC_AmbulanceCertification), "1321")]
        public string ConditionCode_06 { get; set; }
        [D(7, typeof(X12_ID_1321_CRC_AmbulanceCertification), "1321")]
        public string ConditionCode_07 { get; set; }
    }
    
    public class X12_ID_1136_CRC_AmbulanceCertification
    {
        
        public List<string> Codes = new List<string> {"07"};
    }
    
    public class X12_ID_1073_CRC_AmbulanceCertification
    {
        
        public List<string> Codes = new List<string> {"N","Y"};
    }
    
    public class X12_ID_1321_CRC_AmbulanceCertification
    {
        
        public List<string> Codes = new List<string> {"01","02","03","04","05","06","07","08","09","60"};
    }
    
    public class CR5_HomeOxygenTherapyInformation
    {
        
        [D(1, typeof(X12_ID_1322_CR5_HomeOxygenTherapyInformation), "1322")]
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
        [D(12, typeof(X12_ID_1349_CR5_HomeOxygenTherapyInformation), "1349")]
        public string OxygenTestConditionCode_12 { get; set; }
        [D(13, typeof(X12_ID_1350_CR5_HomeOxygenTherapyInformation), "1350")]
        public string OxygenTestFindingsCode_13 { get; set; }
        [D(14, typeof(X12_ID_1350_CR5_HomeOxygenTherapyInformation), "1350")]
        public string OxygenTestFindingsCode_14 { get; set; }
        [D(15, typeof(X12_ID_1350_CR5_HomeOxygenTherapyInformation), "1350")]
        public string OxygenTestFindingsCode_15 { get; set; }
        [D(16, typeof(X12_R))]
        public string CR5_16 { get; set; }
        [D(17, typeof(X12_ID))]
        public string CR5_17 { get; set; }
        [D(18, typeof(X12_ID))]
        public string CR5_18 { get; set; }
    }
    
    public class X12_ID_1322_CR5_HomeOxygenTherapyInformation
    {
        
        public List<string> Codes = new List<string> {"I","R","S"};
    }
    
    public class X12_ID_1349_CR5_HomeOxygenTherapyInformation
    {
        
        public List<string> Codes = new List<string> {"E","R","S"};
    }
    
    public class X12_ID_1350_CR5_HomeOxygenTherapyInformation
    {
        
        public List<string> Codes = new List<string> {"1"};
    }
    
    public class CR3_DurableMedicalEquipmentCertification
    {
        
        [D(1, typeof(X12_ID_1322_CR3_DurableMedicalEquipmentCertification), "1322")]
        public string CertificationTypeCode_01 { get; set; }
        [D(2, typeof(X12_ID_355_CR3_DurableMedicalEquipmentCertification), "355")]
        public string UnitOrBasisForMeasurementCode_02 { get; set; }
        [D(3, typeof(X12_R))]
        public string DurableMedicalEquipmentDuration_03 { get; set; }
        [D(4, typeof(X12_ID))]
        public string CR3_04 { get; set; }
        [D(5, typeof(X12_AN))]
        public string CR3_05 { get; set; }
    }
    
    public class X12_ID_1322_CR3_DurableMedicalEquipmentCertification
    {
        
        public List<string> Codes = new List<string> {"I","R","S"};
    }
    
    public class X12_ID_355_CR3_DurableMedicalEquipmentCertification
    {
        
        public List<string> Codes = new List<string> {"MO"};
    }
    
    public class CR2_SpinalManipulationServiceInformation
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
        [D(8, typeof(X12_ID_1342_CR2_SpinalManipulationServiceInformation), "1342")]
        public string PatientConditionCode_08 { get; set; }
        [D(9, typeof(X12_ID))]
        public string CR2_09 { get; set; }
        [D(10, typeof(X12_AN))]
        public string PatientConditionDescription_10 { get; set; }
        [D(11, typeof(X12_AN))]
        public string PatientConditionDescription_11 { get; set; }
        [D(12, typeof(X12_ID_1073_CR2_SpinalManipulationServiceInformation), "1073")]
        public string XrayAvailabilityIndicator_12 { get; set; }
    }
    
    public class X12_ID_1342_CR2_SpinalManipulationServiceInformation
    {
        
        public List<string> Codes = new List<string> {"A","C","D","E","F","G","M"};
    }
    
    public class X12_ID_1073_CR2_SpinalManipulationServiceInformation
    {
        
        public List<string> Codes = new List<string> {"N","Y"};
    }
    
    public class CR1_AmbulanceTransportInformation
    {
        
        [D(1, typeof(X12_ID_355_CR1_AmbulanceTransportInformation), "355")]
        public string UnitOrBasisForMeasurementCode_01 { get; set; }
        [D(2, typeof(X12_R))]
        public string PatientWeight_02 { get; set; }
        [D(3, typeof(X12_ID_1316_CR1_AmbulanceTransportInformation), "1316")]
        public string AmbulanceTransportCode_03 { get; set; }
        [D(4, typeof(X12_ID_1317_CR1_AmbulanceTransportInformation), "1317")]
        public string AmbulanceTransportReasonCode_04 { get; set; }
        [D(5, typeof(X12_ID_355_CR1_AmbulanceTransportInformation), "355")]
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
    
    public class X12_ID_355_CR1_AmbulanceTransportInformation
    {
        
        public List<string> Codes = new List<string> {"LB"};
    }
    
    public class X12_ID_1316_CR1_AmbulanceTransportInformation
    {
        
        public List<string> Codes = new List<string> {"I","R","T","X"};
    }
    
    public class X12_ID_1317_CR1_AmbulanceTransportInformation
    {
        
        public List<string> Codes = new List<string> {"A","B","C","D","E"};
    }
    
    public class PWK_DMERCCMNIndicator
    {
        
        [D(1, typeof(X12_ID_755_PWK_DMERCCMNIndicator), "755")]
        public string AttachmentReportTypeCode_01 { get; set; }
        [D(2, typeof(X12_ID_756_PWK_DMERCCMNIndicator), "756")]
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
    
    public class X12_ID_755_PWK_DMERCCMNIndicator
    {
        
        public List<string> Codes = new List<string> {"CT"};
    }
    
    public class X12_ID_756_PWK_DMERCCMNIndicator
    {
        
        public List<string> Codes = new List<string> {"AB","AD","AF","AG","NS"};
    }
    
    public class SV5_DurableMedicalEquipmentService
    {
        
        [C(1)]
        public C003_19141319 C003_19141319 { get; set; }
        [D(2, typeof(X12_ID_355_SV5_DurableMedicalEquipmentService), "355")]
        public string UnitOrBasisForMeasurementCode_02 { get; set; }
        [D(3, typeof(X12_R))]
        public string LengthOfMedicalNecessity_03 { get; set; }
        [D(4, typeof(X12_R))]
        public string DMERentalPrice_04 { get; set; }
        [D(5, typeof(X12_R))]
        public string DMEPurchasePrice_05 { get; set; }
        [D(6, typeof(X12_ID_594_SV5_DurableMedicalEquipmentService), "594")]
        public string RentalUnitPriceIndicator_06 { get; set; }
        [D(7, typeof(X12_ID))]
        public string SV5_07 { get; set; }
    }
    
    public class X12_ID_355_SV5_DurableMedicalEquipmentService
    {
        
        public List<string> Codes = new List<string> {"DA"};
    }
    
    public class X12_ID_594_SV5_DurableMedicalEquipmentService
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
    
    public class SV1_ProfessionalService
    {
        
        [C(1)]
        public C003_701728622 C003_701728622 { get; set; }
        [D(2, typeof(X12_R))]
        public string LineItemChargeAmount_02 { get; set; }
        [D(3, typeof(X12_ID_355_SV1_ProfessionalService), "355")]
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
        [D(9, typeof(X12_ID_1073_SV1_ProfessionalService), "1073")]
        public string EmergencyIndicator_09 { get; set; }
        [D(10, typeof(X12_ID))]
        public string SV1_10 { get; set; }
        [D(11, typeof(X12_ID_1073_SV1_ProfessionalService), "1073")]
        public string EPSDTIndicator_11 { get; set; }
        [D(12, typeof(X12_ID_1073_SV1_ProfessionalService), "1073")]
        public string FamilyPlanningIndicator_12 { get; set; }
        [D(13, typeof(X12_ID))]
        public string SV1_13 { get; set; }
        [D(14, typeof(X12_AN))]
        public string SV1_14 { get; set; }
        [D(15, typeof(X12_ID_1327_SV1_ProfessionalService), "1327")]
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
    
    public class X12_ID_355_SV1_ProfessionalService
    {
        
        public List<string> Codes = new List<string> {"F2","MJ","UN"};
    }
    
    public class X12_ID_1073_SV1_ProfessionalService
    {
        
        public List<string> Codes = new List<string> {"Y"};
    }
    
    public class X12_ID_1327_SV1_ProfessionalService
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
    
    public class LX_ServiceLine
    {
        
        [D(1, typeof(X12_N0))]
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
        [S("DMG", 4)]
        public DMG_SubscriberDemographicInformation DMG_SubscriberDemographicInformation { get; set; }
        [S("OI", 5)]
        public OI_OtherInsuranceCoverageInformation OI_OtherInsuranceCoverageInformation { get; set; }
        [S("MOA", 6)]
        public MOA_MedicareOutpatientAdjudicationInformation MOA_MedicareOutpatientAdjudicationInformation { get; set; }
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
        public NM1_OtherPayerSupervisingProvider NM1_OtherPayerSupervisingProvider { get; set; }
        [S("REF", 2)]
        public List<REF_OtherPayerSupervisingProviderIdentification> REF_OtherPayerSupervisingProviderIdentification { get; set; }
    }
    
    public class REF_OtherPayerSupervisingProviderIdentification
    {
        
        [D(1, typeof(X12_ID_128_REF_OtherPayerSupervisingProviderIdentification), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string OtherPayerSupervisingProviderIdentifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string REF_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string REF_04 { get; set; }
    }
    
    public class X12_ID_128_REF_OtherPayerSupervisingProviderIdentification
    {
        
        public List<string> Codes = new List<string> {"1B","1C","1D","EI","G2","N5"};
    }
    
    public class NM1_OtherPayerSupervisingProvider
    {
        
        [D(1, typeof(X12_ID_98_NM1_OtherPayerSupervisingProvider), "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, typeof(X12_ID_1065_NM1_OtherPayerSupervisingProvider), "1065")]
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
    
    public class X12_ID_98_NM1_OtherPayerSupervisingProvider
    {
        
        public List<string> Codes = new List<string> {"DQ"};
    }
    
    public class X12_ID_1065_NM1_OtherPayerSupervisingProvider
    {
        
        public List<string> Codes = new List<string> {"1"};
    }
    
    public class Loop_2330G
    {
        
        [S("NM1", 1)]
        public NM1_OtherPayerServiceFacilityLocation NM1_OtherPayerServiceFacilityLocation { get; set; }
        [S("REF", 2)]
        public List<REF_OtherPayerServiceFacilityLocationIdentification> REF_OtherPayerServiceFacilityLocationIdentification { get; set; }
    }
    
    public class REF_OtherPayerServiceFacilityLocationIdentification
    {
        
        [D(1, typeof(X12_ID_128_REF_OtherPayerServiceFacilityLocationIdentification), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string OtherPayerServiceFacilityLocationIdentifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string REF_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string REF_04 { get; set; }
    }
    
    public class X12_ID_128_REF_OtherPayerServiceFacilityLocationIdentification
    {
        
        public List<string> Codes = new List<string> {"1A","1B","1C","1D","G2","LU","N5"};
    }
    
    public class NM1_OtherPayerServiceFacilityLocation
    {
        
        [D(1, typeof(X12_ID_98_NM1_OtherPayerServiceFacilityLocation), "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, typeof(X12_ID_1065_NM1_OtherPayerServiceFacilityLocation), "1065")]
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
    
    public class X12_ID_98_NM1_OtherPayerServiceFacilityLocation
    {
        
        public List<string> Codes = new List<string> {"77","FA","LI","TL"};
    }
    
    public class X12_ID_1065_NM1_OtherPayerServiceFacilityLocation
    {
        
        public List<string> Codes = new List<string> {"2"};
    }
    
    public class Loop_2330F
    {
        
        [S("NM1", 1)]
        public NM1_OtherPayerPurchasedServiceProvider NM1_OtherPayerPurchasedServiceProvider { get; set; }
        [S("REF", 2)]
        public List<REF_OtherPayerPurchasedServiceProviderIdentification> REF_OtherPayerPurchasedServiceProviderIdentification { get; set; }
    }
    
    public class REF_OtherPayerPurchasedServiceProviderIdentification
    {
        
        [D(1, typeof(X12_ID_128_REF_OtherPayerPurchasedServiceProviderIdentification), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string OtherPayerPurchasedServiceProviderIdentifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string REF_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string REF_04 { get; set; }
    }
    
    public class X12_ID_128_REF_OtherPayerPurchasedServiceProviderIdentification
    {
        
        public List<string> Codes = new List<string> {"1A","1B","1C","1D","EI","G2","LU","N5"};
    }
    
    public class NM1_OtherPayerPurchasedServiceProvider
    {
        
        [D(1, typeof(X12_ID_98_NM1_OtherPayerPurchasedServiceProvider), "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, typeof(X12_ID_1065_NM1_OtherPayerPurchasedServiceProvider), "1065")]
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
    
    public class X12_ID_98_NM1_OtherPayerPurchasedServiceProvider
    {
        
        public List<string> Codes = new List<string> {"QB"};
    }
    
    public class X12_ID_1065_NM1_OtherPayerPurchasedServiceProvider
    {
        
        public List<string> Codes = new List<string> {"1","2"};
    }
    
    public class Loop_2330E
    {
        
        [S("NM1", 1)]
        public NM1_OtherPayerRenderingProvider NM1_OtherPayerRenderingProvider { get; set; }
        [S("REF", 2)]
        public List<REF_OtherPayerRenderingProviderSecondaryIdentification> REF_OtherPayerRenderingProviderSecondaryIdentification { get; set; }
    }
    
    public class REF_OtherPayerRenderingProviderSecondaryIdentification
    {
        
        [D(1, typeof(X12_ID_128_REF_OtherPayerRenderingProviderSecondaryIdentification), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string OtherPayerRenderingProviderSecondaryIdentifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string REF_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string REF_04 { get; set; }
    }
    
    public class X12_ID_128_REF_OtherPayerRenderingProviderSecondaryIdentification
    {
        
        public List<string> Codes = new List<string> {"1B","1C","1D","EI","G2","LU","N5"};
    }
    
    public class NM1_OtherPayerRenderingProvider
    {
        
        [D(1, typeof(X12_ID_98_NM1_OtherPayerRenderingProvider), "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, typeof(X12_ID_1065_NM1_OtherPayerRenderingProvider), "1065")]
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
    
    public class X12_ID_98_NM1_OtherPayerRenderingProvider
    {
        
        public List<string> Codes = new List<string> {"82"};
    }
    
    public class X12_ID_1065_NM1_OtherPayerRenderingProvider
    {
        
        public List<string> Codes = new List<string> {"1","2"};
    }
    
    public class Loop_2330D
    {
        
        [S("NM1", 1)]
        public NM1_OtherPayerReferringProvider NM1_OtherPayerReferringProvider { get; set; }
        [S("REF", 2)]
        public List<REF_OtherPayerReferringProviderIdentification> REF_OtherPayerReferringProviderIdentification { get; set; }
    }
    
    public class REF_OtherPayerReferringProviderIdentification
    {
        
        [D(1, typeof(X12_ID_128_REF_OtherPayerReferringProviderIdentification), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string OtherPayerReferringProviderIdentifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string REF_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string REF_04 { get; set; }
    }
    
    public class X12_ID_128_REF_OtherPayerReferringProviderIdentification
    {
        
        public List<string> Codes = new List<string> {"1B","1C","1D","EI","G2","LU","N5"};
    }
    
    public class NM1_OtherPayerReferringProvider
    {
        
        [D(1, typeof(X12_ID_98_NM1_OtherPayerReferringProvider), "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, typeof(X12_ID_1065_NM1_OtherPayerReferringProvider), "1065")]
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
    
    public class X12_ID_98_NM1_OtherPayerReferringProvider
    {
        
        public List<string> Codes = new List<string> {"DN","P3"};
    }
    
    public class X12_ID_1065_NM1_OtherPayerReferringProvider
    {
        
        public List<string> Codes = new List<string> {"1","2"};
    }
    
    public class Loop_2330C
    {
        
        [S("NM1", 1)]
        public NM1_OtherPayerPatientInformation NM1_OtherPayerPatientInformation { get; set; }
        [S("REF", 2)]
        public List<REF_OtherPayerPatientIdentification> REF_OtherPayerPatientIdentification { get; set; }
    }
    
    public class REF_OtherPayerPatientIdentification
    {
        
        [D(1, typeof(X12_ID_128_REF_OtherPayerPatientIdentification), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string OtherPayerPatientSecondaryIdentifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string REF_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string REF_04 { get; set; }
    }
    
    public class X12_ID_128_REF_OtherPayerPatientIdentification
    {
        
        public List<string> Codes = new List<string> {"1W","23","IG","SY"};
    }
    
    public class NM1_OtherPayerPatientInformation
    {
        
        [D(1, typeof(X12_ID_98_NM1_OtherPayerPatientInformation), "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, typeof(X12_ID_1065_NM1_OtherPayerPatientInformation), "1065")]
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
        [D(8, typeof(X12_ID_66_NM1_OtherPayerPatientInformation), "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, typeof(X12_AN))]
        public string OtherPayerPatientPrimaryIdentifier_09 { get; set; }
        [D(10, typeof(X12_ID))]
        public string NM1_10 { get; set; }
        [D(11, typeof(X12_ID))]
        public string NM1_11 { get; set; }
    }
    
    public class X12_ID_98_NM1_OtherPayerPatientInformation
    {
        
        public List<string> Codes = new List<string> {"QC"};
    }
    
    public class X12_ID_1065_NM1_OtherPayerPatientInformation
    {
        
        public List<string> Codes = new List<string> {"1"};
    }
    
    public class X12_ID_66_NM1_OtherPayerPatientInformation
    {
        
        public List<string> Codes = new List<string> {"MI"};
    }
    
    public class Loop_2330B
    {
        
        [S("NM1", 1)]
        public NM1_OtherPayerName NM1_OtherPayerName { get; set; }
        [S("PER", 2)]
        public List<PER_OtherPayerContactInformation> PER_OtherPayerContactInformation { get; set; }
        [S("DTP", 3)]
        public DTP_ClaimAdjudicationDate DTP_ClaimAdjudicationDate { get; set; }
        [A(4)]
        public All_REF All_REF { get; set; }
    }
    
    public class DTP_ClaimAdjudicationDate
    {
        
        [D(1, typeof(X12_ID_374_DTP_ClaimAdjudicationDate), "374")]
        public string DateTimeQualifier_01 { get; set; }
        [D(2, typeof(X12_ID_1250_DTP_ClaimAdjudicationDate), "1250")]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string AdjudicationOrPaymentDate_03 { get; set; }
    }
    
    public class X12_ID_374_DTP_ClaimAdjudicationDate
    {
        
        public List<string> Codes = new List<string> {"573"};
    }
    
    public class X12_ID_1250_DTP_ClaimAdjudicationDate
    {
        
        public List<string> Codes = new List<string> {"D8"};
    }
    
    public class PER_OtherPayerContactInformation
    {
        
        [D(1, typeof(X12_ID_366_PER_OtherPayerContactInformation), "366")]
        public string ContactFunctionCode_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string OtherPayerContactName_02 { get; set; }
        [D(3, typeof(X12_ID_365_PER_OtherPayerContactInformation), "365")]
        public string CommunicationNumberQualifier_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string CommunicationNumber_04 { get; set; }
        [D(5, typeof(X12_ID_365_PER_OtherPayerContactInformation), "365")]
        public string CommunicationNumberQualifier_05 { get; set; }
        [D(6, typeof(X12_AN))]
        public string CommunicationNumber_06 { get; set; }
        [D(7, typeof(X12_ID_365_PER_OtherPayerContactInformation), "365")]
        public string CommunicationNumberQualifier_07 { get; set; }
        [D(8, typeof(X12_AN))]
        public string CommunicationNumber_08 { get; set; }
        [D(9, typeof(X12_AN))]
        public string PER_09 { get; set; }
    }
    
    public class X12_ID_366_PER_OtherPayerContactInformation
    {
        
        public List<string> Codes = new List<string> {"IC"};
    }
    
    public class X12_ID_365_PER_OtherPayerContactInformation
    {
        
        public List<string> Codes = new List<string> {"ED","EM","FX","TE"};
    }
    
    public class NM1_OtherPayerName
    {
        
        [D(1, typeof(X12_ID_98_NM1_OtherPayerName), "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, typeof(X12_ID_1065_NM1_OtherPayerName), "1065")]
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
        [D(8, typeof(X12_ID_66_NM1_OtherPayerName), "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, typeof(X12_AN))]
        public string OtherPayerPrimaryIdentifier_09 { get; set; }
        [D(10, typeof(X12_ID))]
        public string NM1_10 { get; set; }
        [D(11, typeof(X12_ID))]
        public string NM1_11 { get; set; }
    }
    
    public class X12_ID_98_NM1_OtherPayerName
    {
        
        public List<string> Codes = new List<string> {"PR"};
    }
    
    public class X12_ID_1065_NM1_OtherPayerName
    {
        
        public List<string> Codes = new List<string> {"2"};
    }
    
    public class X12_ID_66_NM1_OtherPayerName
    {
        
        public List<string> Codes = new List<string> {"PI","XV"};
    }
    
    public class Loop_2330A
    {
        
        [S("NM1", 1)]
        public NM1_OtherSubscriberName NM1_OtherSubscriberName { get; set; }
        [S("N3", 2)]
        public N3_OtherSubscriberAddress N3_OtherSubscriberAddress { get; set; }
        [S("N4", 3)]
        public N4_OtherSubscriberCityStateZIPCode N4_OtherSubscriberCityStateZIPCode { get; set; }
        [S("REF", 4)]
        public List<REF_OtherSubscriberSecondaryIdentification> REF_OtherSubscriberSecondaryIdentification { get; set; }
    }
    
    public class REF_OtherSubscriberSecondaryIdentification
    {
        
        [D(1, typeof(X12_ID_128_REF_OtherSubscriberSecondaryIdentification), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string OtherInsuredAdditionalIdentifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string REF_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string REF_04 { get; set; }
    }
    
    public class X12_ID_128_REF_OtherSubscriberSecondaryIdentification
    {
        
        public List<string> Codes = new List<string> {"1W","23","IG","SY"};
    }
    
    public class N4_OtherSubscriberCityStateZIPCode
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
    
    public class N3_OtherSubscriberAddress
    {
        
        [D(1, typeof(X12_AN))]
        public string OtherInsuredAddressLine_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string OtherInsuredAddressLine_02 { get; set; }
    }
    
    public class NM1_OtherSubscriberName
    {
        
        [D(1, typeof(X12_ID_98_NM1_OtherSubscriberName), "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, typeof(X12_ID_1065_NM1_OtherSubscriberName), "1065")]
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
        [D(8, typeof(X12_ID_66_NM1_OtherSubscriberName), "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, typeof(X12_AN))]
        public string OtherInsuredIdentifier_09 { get; set; }
        [D(10, typeof(X12_ID))]
        public string NM1_10 { get; set; }
        [D(11, typeof(X12_ID))]
        public string NM1_11 { get; set; }
    }
    
    public class X12_ID_98_NM1_OtherSubscriberName
    {
        
        public List<string> Codes = new List<string> {"IL"};
    }
    
    public class X12_ID_1065_NM1_OtherSubscriberName
    {
        
        public List<string> Codes = new List<string> {"1","2"};
    }
    
    public class X12_ID_66_NM1_OtherSubscriberName
    {
        
        public List<string> Codes = new List<string> {"MI","ZZ"};
    }
    
    public class MOA_MedicareOutpatientAdjudicationInformation
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
    
    public class OI_OtherInsuranceCoverageInformation
    {
        
        [D(1, typeof(X12_ID))]
        public string OI_01 { get; set; }
        [D(2, typeof(X12_ID))]
        public string OI_02 { get; set; }
        [D(3, typeof(X12_ID_1073_OI_OtherInsuranceCoverageInformation), "1073")]
        public string BenefitsAssignmentCertificationIndicator_03 { get; set; }
        [D(4, typeof(X12_ID_1351_OI_OtherInsuranceCoverageInformation), "1351")]
        public string PatientSignatureSourceCode_04 { get; set; }
        [D(5, typeof(X12_ID))]
        public string OI_05 { get; set; }
        [D(6, typeof(X12_ID_1363_OI_OtherInsuranceCoverageInformation), "1363")]
        public string ReleaseOfInformationCode_06 { get; set; }
    }
    
    public class X12_ID_1073_OI_OtherInsuranceCoverageInformation
    {
        
        public List<string> Codes = new List<string> {"N","Y"};
    }
    
    public class X12_ID_1351_OI_OtherInsuranceCoverageInformation
    {
        
        public List<string> Codes = new List<string> {"B","C","M","P","S"};
    }
    
    public class X12_ID_1363_OI_OtherInsuranceCoverageInformation
    {
        
        public List<string> Codes = new List<string> {"A","I","M","N","O","Y"};
    }
    
    public class DMG_SubscriberDemographicInformation
    {
        
        [D(1, typeof(X12_ID_1250_DMG_SubscriberDemographicInformation), "1250")]
        public string DateTimePeriodFormatQualifier_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string OtherInsuredBirthDate_02 { get; set; }
        [D(3, typeof(X12_ID_1068_DMG_SubscriberDemographicInformation), "1068")]
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
    
    public class X12_ID_1250_DMG_SubscriberDemographicInformation
    {
        
        public List<string> Codes = new List<string> {"D8"};
    }
    
    public class X12_ID_1068_DMG_SubscriberDemographicInformation
    {
        
        public List<string> Codes = new List<string> {"F","M","U"};
    }
    
    public class CAS_ClaimLevelAdjustments
    {
        
        [D(1, typeof(X12_ID_1033_CAS_ClaimLevelAdjustments), "1033")]
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
    
    public class X12_ID_1033_CAS_ClaimLevelAdjustments
    {
        
        public List<string> Codes = new List<string> {"CO","CR","OA","PI","PR"};
    }
    
    public class SBR_OtherSubscriberInformation
    {
        
        [D(1, typeof(X12_ID_1138_SBR_OtherSubscriberInformation), "1138")]
        public string PayerResponsibilitySequenceNumberCode_01 { get; set; }
        [D(2, typeof(X12_ID_1069_SBR_OtherSubscriberInformation), "1069")]
        public string IndividualRelationshipCode_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string InsuredGroupOrPolicyNumber_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string OtherInsuredGroupName_04 { get; set; }
        [D(5, typeof(X12_ID_1336_SBR_OtherSubscriberInformation), "1336")]
        public string InsuranceTypeCode_05 { get; set; }
        [D(6, typeof(X12_ID))]
        public string SBR_06 { get; set; }
        [D(7, typeof(X12_ID))]
        public string SBR_07 { get; set; }
        [D(8, typeof(X12_ID))]
        public string SBR_08 { get; set; }
        [D(9, typeof(X12_ID_1032_SBR_OtherSubscriberInformation), "1032")]
        public string ClaimFilingIndicatorCode_09 { get; set; }
    }
    
    public class X12_ID_1138_SBR_OtherSubscriberInformation
    {
        
        public List<string> Codes = new List<string> {"P","S","T"};
    }
    
    public class X12_ID_1069_SBR_OtherSubscriberInformation
    {
        
        public List<string> Codes = new List<string> {"01","04","05","07","10","15","17","18","19","20","21","22","23","24","29","32","33","36","39","40","41","43","53","G8"};
    }
    
    public class X12_ID_1336_SBR_OtherSubscriberInformation
    {
        
        public List<string> Codes = new List<string> {"AP","C1","CP","GP","HM","IP","LD","LT","MB","MC","MI","MP","OT","PP","SP"};
    }
    
    public class X12_ID_1032_SBR_OtherSubscriberInformation
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
        public NM1_SupervisingProviderName NM1_SupervisingProviderName { get; set; }
        [S("REF", 2)]
        public List<REF_SupervisingProviderSecondaryIdentification> REF_SupervisingProviderSecondaryIdentification { get; set; }
    }
    
    public class Loop_2310D
    {
        
        [S("NM1", 1)]
        public NM1_ServiceFacilityLocation NM1_ServiceFacilityLocation { get; set; }
        [S("N3", 2)]
        public N3_ServiceFacilityLocationAddress N3_ServiceFacilityLocationAddress { get; set; }
        [S("N4", 3)]
        public N4_ServiceFacilityLocationCityStateZIP N4_ServiceFacilityLocationCityStateZIP { get; set; }
        [S("REF", 4)]
        public List<REF_ServiceFacilityLocationSecondaryIdentification> REF_ServiceFacilityLocationSecondaryIdentification { get; set; }
    }
    
    public class Loop_2310C
    {
        
        [S("NM1", 1)]
        public NM1_PurchasedServiceProviderName NM1_PurchasedServiceProviderName { get; set; }
        [S("REF", 2)]
        public List<REF_PurchasedServiceProviderSecondaryIdentification> REF_PurchasedServiceProviderSecondaryIdentification { get; set; }
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
    
    public class Loop_2310A
    {
        
        [S("NM1", 1)]
        public NM1_ReferringProviderName NM1_ReferringProviderName { get; set; }
        [S("PRV", 2)]
        public PRV_ReferringProviderSpecialtyInformation PRV_ReferringProviderSpecialtyInformation { get; set; }
        [S("REF", 3)]
        public List<REF_ReferringProviderSecondaryIdentification> REF_ReferringProviderSecondaryIdentification { get; set; }
    }
    
    public class Loop_2305
    {
        
        [S("CR7", 1)]
        public CR7_HomeHealthCarePlanInformation CR7_HomeHealthCarePlanInformation { get; set; }
        [S("HSD", 2)]
        public List<HSD_HealthCareServicesDelivery> HSD_HealthCareServicesDelivery { get; set; }
    }
    
    public class CR7_HomeHealthCarePlanInformation
    {
        
        [D(1, typeof(X12_ID_921_CR7_HomeHealthCarePlanInformation), "921")]
        public string DisciplineTypeCode_01 { get; set; }
        [D(2, typeof(X12_N0))]
        public string TotalVisitsRenderedCount_02 { get; set; }
        [D(3, typeof(X12_N0))]
        public string CertificationPeriodProjectedVisitCount_03 { get; set; }
    }
    
    public class X12_ID_921_CR7_HomeHealthCarePlanInformation
    {
        
        public List<string> Codes = new List<string> {"AI","MS","OT","PT","SN","ST"};
    }
    
    public class HCP_ClaimPricingRepricingInformation
    {
        
        [D(1, typeof(X12_ID_1473_HCP_ClaimPricingRepricingInformation), "1473")]
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
        [D(13, typeof(X12_ID_901_HCP_ClaimPricingRepricingInformation), "901")]
        public string RejectReasonCode_13 { get; set; }
        [D(14, typeof(X12_ID_1526_HCP_ClaimPricingRepricingInformation), "1526")]
        public string PolicyComplianceCode_14 { get; set; }
        [D(15, typeof(X12_ID_1527_HCP_ClaimPricingRepricingInformation), "1527")]
        public string ExceptionCode_15 { get; set; }
    }
    
    public class X12_ID_1473_HCP_ClaimPricingRepricingInformation
    {
        
        public List<string> Codes = new List<string> {"00","01","02","03","04","05","07","08","09","10","11","12","13","14"};
    }
    
    public class X12_ID_901_HCP_ClaimPricingRepricingInformation
    {
        
        public List<string> Codes = new List<string> {"T1","T2","T3","T4","T5","T6"};
    }
    
    public class X12_ID_1526_HCP_ClaimPricingRepricingInformation
    {
        
        public List<string> Codes = new List<string> {"1","2","3","4","5"};
    }
    
    public class X12_ID_1527_HCP_ClaimPricingRepricingInformation
    {
        
        public List<string> Codes = new List<string> {"1","2","3","4","5","6"};
    }
    
    public class HI_HealthCareDiagnosisCode
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
    
    public class NTE_ClaimNote
    {
        
        [D(1, typeof(X12_ID_363_NTE_ClaimNote), "363")]
        public string NoteReferenceCode_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string ClaimNoteText_02 { get; set; }
    }
    
    public class X12_ID_363_NTE_ClaimNote
    {
        
        public List<string> Codes = new List<string> {"ADD","CER","DCP","DGN","PMT","TPO"};
    }
    
    public class PWK_ClaimSupplementalInformation
    {
        
        [D(1, typeof(X12_ID_755_PWK_ClaimSupplementalInformation), "755")]
        public string AttachmentReportTypeCode_01 { get; set; }
        [D(2, typeof(X12_ID_756_PWK_ClaimSupplementalInformation), "756")]
        public string AttachmentTransmissionCode_02 { get; set; }
        [D(3, typeof(X12_N0))]
        public string PWK_03 { get; set; }
        [D(4, typeof(X12_ID))]
        public string PWK_04 { get; set; }
        [D(5, typeof(X12_ID_66_PWK_ClaimSupplementalInformation), "66")]
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
    
    public class X12_ID_755_PWK_ClaimSupplementalInformation
    {
        
        public List<string> Codes = new List<string> {"77","AS","B2","B3","B4","CT","DA","DG","DS","EB","MT","NN","OB","OZ","PN","PO","PZ","RB","RR","RT"};
    }
    
    public class X12_ID_756_PWK_ClaimSupplementalInformation
    {
        
        public List<string> Codes = new List<string> {"AA","BM","EL","EM","FX"};
    }
    
    public class X12_ID_66_PWK_ClaimSupplementalInformation
    {
        
        public List<string> Codes = new List<string> {"AC"};
    }
    
    public class CLM_ClaimInformation
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
        [D(6, typeof(X12_ID_1073_CLM_ClaimInformation), "1073")]
        public string ProviderOrSupplierSignatureIndicator_06 { get; set; }
        [D(7, typeof(X12_ID_1359_CLM_ClaimInformation), "1359")]
        public string MedicareAssignmentCode_07 { get; set; }
        [D(8, typeof(X12_ID_1073_CLM_ClaimInformation), "1073")]
        public string BenefitsAssignmentCertificationIndicator_08 { get; set; }
        [D(9, typeof(X12_ID_1363_CLM_ClaimInformation), "1363")]
        public string ReleaseOfInformationCode_09 { get; set; }
        [D(10, typeof(X12_ID_1351_CLM_ClaimInformation), "1351")]
        public string PatientSignatureSourceCode_10 { get; set; }
        [C(11)]
        public C024_1508297677 C024_1508297677 { get; set; }
        [D(12, typeof(X12_ID_1366_CLM_ClaimInformation), "1366")]
        public string SpecialProgramIndicator_12 { get; set; }
        [D(13, typeof(X12_ID))]
        public string CLM_13 { get; set; }
        [D(14, typeof(X12_ID))]
        public string CLM_14 { get; set; }
        [D(15, typeof(X12_ID))]
        public string CLM_15 { get; set; }
        [D(16, typeof(X12_ID_1360_CLM_ClaimInformation), "1360")]
        public string ParticipationAgreement_16 { get; set; }
        [D(17, typeof(X12_ID))]
        public string CLM_17 { get; set; }
        [D(18, typeof(X12_ID))]
        public string CLM_18 { get; set; }
        [D(19, typeof(X12_ID))]
        public string CLM_19 { get; set; }
        [D(20, typeof(X12_ID_1514_CLM_ClaimInformation), "1514")]
        public string DelayReasonCode_20 { get; set; }
    }
    
    public class X12_ID_1073_CLM_ClaimInformation
    {
        
        public List<string> Codes = new List<string> {"N","Y"};
    }
    
    public class X12_ID_1359_CLM_ClaimInformation
    {
        
        public List<string> Codes = new List<string> {"A","B","C","P"};
    }
    
    public class X12_ID_1363_CLM_ClaimInformation
    {
        
        public List<string> Codes = new List<string> {"A","I","M","N","O","Y"};
    }
    
    public class X12_ID_1351_CLM_ClaimInformation
    {
        
        public List<string> Codes = new List<string> {"B","C","M","P","S"};
    }
    
    public class X12_ID_1366_CLM_ClaimInformation
    {
        
        public List<string> Codes = new List<string> {"01","02","03","05","07","08","09"};
    }
    
    public class X12_ID_1360_CLM_ClaimInformation
    {
        
        public List<string> Codes = new List<string> {"P"};
    }
    
    public class X12_ID_1514_CLM_ClaimInformation
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
        public NM1_PatientName NM1_PatientName { get; set; }
        [S("N3", 2)]
        public N3_PatientAddress N3_PatientAddress { get; set; }
        [S("N4", 3)]
        public N4_PatientCityStateZIPCode N4_PatientCityStateZIPCode { get; set; }
        [S("DMG", 4)]
        public DMG_PatientDemographicInformation DMG_PatientDemographicInformation { get; set; }
        [A(5)]
        public All_REF All_REF { get; set; }
    }
    
    public class DMG_PatientDemographicInformation
    {
        
        [D(1, typeof(X12_ID_1250_DMG_PatientDemographicInformation), "1250")]
        public string DateTimePeriodFormatQualifier_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string PatientBirthDate_02 { get; set; }
        [D(3, typeof(X12_ID_1068_DMG_PatientDemographicInformation), "1068")]
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
    
    public class X12_ID_1250_DMG_PatientDemographicInformation
    {
        
        public List<string> Codes = new List<string> {"D8"};
    }
    
    public class X12_ID_1068_DMG_PatientDemographicInformation
    {
        
        public List<string> Codes = new List<string> {"F","M","U"};
    }
    
    public class N4_PatientCityStateZIPCode
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
    
    public class N3_PatientAddress
    {
        
        [D(1, typeof(X12_AN))]
        public string PatientAddressLine_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string PatientAddressLine_02 { get; set; }
    }
    
    public class NM1_PatientName
    {
        
        [D(1, typeof(X12_ID_98_NM1_PatientName), "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, typeof(X12_ID_1065_NM1_PatientName), "1065")]
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
        [D(8, typeof(X12_ID_66_NM1_PatientName), "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, typeof(X12_AN))]
        public string PatientPrimaryIdentifier_09 { get; set; }
        [D(10, typeof(X12_ID))]
        public string NM1_10 { get; set; }
        [D(11, typeof(X12_ID))]
        public string NM1_11 { get; set; }
    }
    
    public class X12_ID_98_NM1_PatientName
    {
        
        public List<string> Codes = new List<string> {"QC"};
    }
    
    public class X12_ID_1065_NM1_PatientName
    {
        
        public List<string> Codes = new List<string> {"1"};
    }
    
    public class X12_ID_66_NM1_PatientName
    {
        
        public List<string> Codes = new List<string> {"MI","ZZ"};
    }
    
    public class PAT_PatientInformation
    {
        
        [D(1, typeof(X12_ID_1069_PAT_PatientInformation), "1069")]
        public string IndividualRelationshipCode_01 { get; set; }
        [D(2, typeof(X12_ID))]
        public string PAT_02 { get; set; }
        [D(3, typeof(X12_ID))]
        public string PAT_03 { get; set; }
        [D(4, typeof(X12_ID))]
        public string PAT_04 { get; set; }
        [D(5, typeof(X12_ID_1250_PAT_PatientInformation), "1250")]
        public string DateTimePeriodFormatQualifier_05 { get; set; }
        [D(6, typeof(X12_AN))]
        public string PatientDeathDate_06 { get; set; }
        [D(7, typeof(X12_ID_355_PAT_PatientInformation), "355")]
        public string UnitOrBasisForMeasurementCode_07 { get; set; }
        [D(8, typeof(X12_R))]
        public string PatientWeight_08 { get; set; }
        [D(9, typeof(X12_ID_1073_PAT_PatientInformation), "1073")]
        public string PregnancyIndicator_09 { get; set; }
    }
    
    public class X12_ID_1069_PAT_PatientInformation
    {
        
        public List<string> Codes = new List<string> {"01","04","05","07","09","10","15","17","19","20","21","22","23","24","29","32","33","34","36","39","40","41","43","53","G8"};
    }
    
    public class X12_ID_1250_PAT_PatientInformation
    {
        
        public List<string> Codes = new List<string> {"D8"};
    }
    
    public class X12_ID_355_PAT_PatientInformation
    {
        
        public List<string> Codes = new List<string> {"01"};
    }
    
    public class X12_ID_1073_PAT_PatientInformation
    {
        
        public List<string> Codes = new List<string> {"Y"};
    }
    
    public class HL_PatientHierarchicalLevel
    {
        
        [D(1, typeof(X12_AN))]
        public string HierarchicalIDNumber_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string HierarchicalParentIDNumber_02 { get; set; }
        [D(3, typeof(X12_ID_735_HL_PatientHierarchicalLevel), "735")]
        public string HierarchicalLevelCode_03 { get; set; }
        [D(4, typeof(X12_ID_736_HL_PatientHierarchicalLevel), "736")]
        public string HierarchicalChildCode_04 { get; set; }
    }
    
    public class X12_ID_735_HL_PatientHierarchicalLevel
    {
        
        public List<string> Codes = new List<string> {"23"};
    }
    
    public class X12_ID_736_HL_PatientHierarchicalLevel
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
        public NM1_CreditDebitCardHolderName NM1_CreditDebitCardHolderName { get; set; }
        [S("REF", 2)]
        public List<REF_CreditDebitCardInformation> REF_CreditDebitCardInformation { get; set; }
    }
    
    public class REF_CreditDebitCardInformation
    {
        
        [D(1, typeof(X12_ID_128_REF_CreditDebitCardInformation), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string CreditOrDebitCardAuthorizationNumber_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string REF_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string REF_04 { get; set; }
    }
    
    public class X12_ID_128_REF_CreditDebitCardInformation
    {
        
        public List<string> Codes = new List<string> {"AB","BB"};
    }
    
    public class NM1_CreditDebitCardHolderName
    {
        
        [D(1, typeof(X12_ID_98_NM1_CreditDebitCardHolderName), "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, typeof(X12_ID_1065_NM1_CreditDebitCardHolderName), "1065")]
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
        [D(8, typeof(X12_ID_66_NM1_CreditDebitCardHolderName), "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, typeof(X12_AN))]
        public string CreditOrDebitCardNumber_09 { get; set; }
        [D(10, typeof(X12_ID))]
        public string NM1_10 { get; set; }
        [D(11, typeof(X12_ID))]
        public string NM1_11 { get; set; }
    }
    
    public class X12_ID_98_NM1_CreditDebitCardHolderName
    {
        
        public List<string> Codes = new List<string> {"AO"};
    }
    
    public class X12_ID_1065_NM1_CreditDebitCardHolderName
    {
        
        public List<string> Codes = new List<string> {"1","2"};
    }
    
    public class X12_ID_66_NM1_CreditDebitCardHolderName
    {
        
        public List<string> Codes = new List<string> {"MI"};
    }
    
    public class Loop_2010BC
    {
        
        [S("NM1", 1)]
        public NM1_ResponsiblePartyName NM1_ResponsiblePartyName { get; set; }
        [S("N3", 2)]
        public N3_ResponsiblePartyAddress N3_ResponsiblePartyAddress { get; set; }
        [S("N4", 3)]
        public N4_ResponsiblePartyCityStateZIPCode N4_ResponsiblePartyCityStateZIPCode { get; set; }
    }
    
    public class N4_ResponsiblePartyCityStateZIPCode
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
    
    public class N3_ResponsiblePartyAddress
    {
        
        [D(1, typeof(X12_AN))]
        public string ResponsiblePartyAddressLine_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string ResponsiblePartyAddressLine_02 { get; set; }
    }
    
    public class NM1_ResponsiblePartyName
    {
        
        [D(1, typeof(X12_ID_98_NM1_ResponsiblePartyName), "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, typeof(X12_ID_1065_NM1_ResponsiblePartyName), "1065")]
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
    
    public class X12_ID_98_NM1_ResponsiblePartyName
    {
        
        public List<string> Codes = new List<string> {"QD"};
    }
    
    public class X12_ID_1065_NM1_ResponsiblePartyName
    {
        
        public List<string> Codes = new List<string> {"1","2"};
    }
    
    public class Loop_2010BB
    {
        
        [S("NM1", 1)]
        public NM1_PayerName NM1_PayerName { get; set; }
        [S("N3", 2)]
        public N3_PayerAddress N3_PayerAddress { get; set; }
        [S("N4", 3)]
        public N4_PayerCityStateZIPCode N4_PayerCityStateZIPCode { get; set; }
        [S("REF", 4)]
        public List<REF_PayerSecondaryIdentification> REF_PayerSecondaryIdentification { get; set; }
    }
    
    public class REF_PayerSecondaryIdentification
    {
        
        [D(1, typeof(X12_ID_128_REF_PayerSecondaryIdentification), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string PayerAdditionalIdentifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string REF_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string REF_04 { get; set; }
    }
    
    public class X12_ID_128_REF_PayerSecondaryIdentification
    {
        
        public List<string> Codes = new List<string> {"2U","FY","NF","TJ"};
    }
    
    public class N4_PayerCityStateZIPCode
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
    
    public class N3_PayerAddress
    {
        
        [D(1, typeof(X12_AN))]
        public string PayerAddressLine_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string PayerAddressLine_02 { get; set; }
    }
    
    public class NM1_PayerName
    {
        
        [D(1, typeof(X12_ID_98_NM1_PayerName), "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, typeof(X12_ID_1065_NM1_PayerName), "1065")]
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
        [D(8, typeof(X12_ID_66_NM1_PayerName), "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, typeof(X12_AN))]
        public string PayerIdentifier_09 { get; set; }
        [D(10, typeof(X12_ID))]
        public string NM1_10 { get; set; }
        [D(11, typeof(X12_ID))]
        public string NM1_11 { get; set; }
    }
    
    public class X12_ID_98_NM1_PayerName
    {
        
        public List<string> Codes = new List<string> {"PR"};
    }
    
    public class X12_ID_1065_NM1_PayerName
    {
        
        public List<string> Codes = new List<string> {"2"};
    }
    
    public class X12_ID_66_NM1_PayerName
    {
        
        public List<string> Codes = new List<string> {"PI","XV"};
    }
    
    public class Loop_2010BA
    {
        
        [S("NM1", 1)]
        public NM1_SubscriberName NM1_SubscriberName { get; set; }
        [S("N3", 2)]
        public N3_SubscriberAddress N3_SubscriberAddress { get; set; }
        [S("N4", 3)]
        public N4_SubscriberCityStateZIPCode N4_SubscriberCityStateZIPCode { get; set; }
        [S("DMG", 4)]
        public DMG_SubscriberDemographicInformation DMG_SubscriberDemographicInformation { get; set; }
        [A(5)]
        public All_REF All_REF { get; set; }
    }
    
    public class N4_SubscriberCityStateZIPCode
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
    
    public class N3_SubscriberAddress
    {
        
        [D(1, typeof(X12_AN))]
        public string SubscriberAddressLine_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string SubscriberAddressLine_02 { get; set; }
    }
    
    public class NM1_SubscriberName
    {
        
        [D(1, typeof(X12_ID_98_NM1_SubscriberName), "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, typeof(X12_ID_1065_NM1_SubscriberName), "1065")]
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
        [D(8, typeof(X12_ID_66_NM1_SubscriberName), "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, typeof(X12_AN))]
        public string SubscriberPrimaryIdentifier_09 { get; set; }
        [D(10, typeof(X12_ID))]
        public string NM1_10 { get; set; }
        [D(11, typeof(X12_ID))]
        public string NM1_11 { get; set; }
    }
    
    public class X12_ID_98_NM1_SubscriberName
    {
        
        public List<string> Codes = new List<string> {"IL"};
    }
    
    public class X12_ID_1065_NM1_SubscriberName
    {
        
        public List<string> Codes = new List<string> {"1","2"};
    }
    
    public class X12_ID_66_NM1_SubscriberName
    {
        
        public List<string> Codes = new List<string> {"MI","ZZ"};
    }
    
    public class SBR_SubscriberInformation
    {
        
        [D(1, typeof(X12_ID_1138_SBR_SubscriberInformation), "1138")]
        public string PayerResponsibilitySequenceNumberCode_01 { get; set; }
        [D(2, typeof(X12_ID_1069_SBR_SubscriberInformation), "1069")]
        public string IndividualRelationshipCode_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string InsuredGroupOrPolicyNumber_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string InsuredGroupName_04 { get; set; }
        [D(5, typeof(X12_ID_1336_SBR_SubscriberInformation), "1336")]
        public string InsuranceTypeCode_05 { get; set; }
        [D(6, typeof(X12_ID))]
        public string SBR_06 { get; set; }
        [D(7, typeof(X12_ID))]
        public string SBR_07 { get; set; }
        [D(8, typeof(X12_ID))]
        public string SBR_08 { get; set; }
        [D(9, typeof(X12_ID_1032_SBR_SubscriberInformation), "1032")]
        public string ClaimFilingIndicatorCode_09 { get; set; }
    }
    
    public class X12_ID_1138_SBR_SubscriberInformation
    {
        
        public List<string> Codes = new List<string> {"P","S","T"};
    }
    
    public class X12_ID_1069_SBR_SubscriberInformation
    {
        
        public List<string> Codes = new List<string> {"18"};
    }
    
    public class X12_ID_1336_SBR_SubscriberInformation
    {
        
        public List<string> Codes = new List<string> {"12","13","14","15","16","41","42","43","47"};
    }
    
    public class X12_ID_1032_SBR_SubscriberInformation
    {
        
        public List<string> Codes = new List<string> {"09","10","11","12","13","14","15","16","AM","BL","CH","CI","DS","HM","LI","LM","MB","MC","OF","TV","VA","WC","ZZ"};
    }
    
    public class HL_SubscriberHierarchicalLevel
    {
        
        [D(1, typeof(X12_AN))]
        public string HierarchicalIDNumber_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string HierarchicalParentIDNumber_02 { get; set; }
        [D(3, typeof(X12_ID_735_HL_SubscriberHierarchicalLevel), "735")]
        public string HierarchicalLevelCode_03 { get; set; }
        [D(4, typeof(X12_ID_736_HL_SubscriberHierarchicalLevel), "736")]
        public string HierarchicalChildCode_04 { get; set; }
    }
    
    public class X12_ID_735_HL_SubscriberHierarchicalLevel
    {
        
        public List<string> Codes = new List<string> {"22"};
    }
    
    public class X12_ID_736_HL_SubscriberHierarchicalLevel
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
        public NM1_PaytoProviderName NM1_PaytoProviderName { get; set; }
        [S("N3", 2)]
        public N3_PaytoProviderAddress N3_PaytoProviderAddress { get; set; }
        [S("N4", 3)]
        public N4_PaytoProviderCityStateZIPCode N4_PaytoProviderCityStateZIPCode { get; set; }
        [S("REF", 4)]
        public List<REF_PaytoProviderSecondaryIdentification> REF_PaytoProviderSecondaryIdentification { get; set; }
    }
    
    public class REF_PaytoProviderSecondaryIdentification
    {
        
        [D(1, typeof(X12_ID_128_REF_PaytoProviderSecondaryIdentification), "128")]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string PaytoProviderIdentifier_02 { get; set; }
        [D(3, typeof(X12_AN))]
        public string REF_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string REF_04 { get; set; }
    }
    
    public class X12_ID_128_REF_PaytoProviderSecondaryIdentification
    {
        
        public List<string> Codes = new List<string> {"0B","1A","1B","1C","1D","1G","1H","1J","B3","BQ","EI","FH","G2","G5","LU","SY","U3","X5"};
    }
    
    public class N4_PaytoProviderCityStateZIPCode
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
    
    public class N3_PaytoProviderAddress
    {
        
        [D(1, typeof(X12_AN))]
        public string PaytoProviderAddressLine_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string PaytoProviderAddressLine_02 { get; set; }
    }
    
    public class NM1_PaytoProviderName
    {
        
        [D(1, typeof(X12_ID_98_NM1_PaytoProviderName), "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, typeof(X12_ID_1065_NM1_PaytoProviderName), "1065")]
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
        [D(8, typeof(X12_ID_66_NM1_PaytoProviderName), "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, typeof(X12_AN))]
        public string PaytoProviderIdentifier_09 { get; set; }
        [D(10, typeof(X12_ID))]
        public string NM1_10 { get; set; }
        [D(11, typeof(X12_ID))]
        public string NM1_11 { get; set; }
    }
    
    public class X12_ID_98_NM1_PaytoProviderName
    {
        
        public List<string> Codes = new List<string> {"87"};
    }
    
    public class X12_ID_1065_NM1_PaytoProviderName
    {
        
        public List<string> Codes = new List<string> {"1","2"};
    }
    
    public class X12_ID_66_NM1_PaytoProviderName
    {
        
        public List<string> Codes = new List<string> {"24","34","XX"};
    }
    
    public class Loop_2010AA
    {
        
        [S("NM1", 1)]
        public NM1_BillingProviderName NM1_BillingProviderName { get; set; }
        [S("N3", 2)]
        public N3_BillingProviderAddress N3_BillingProviderAddress { get; set; }
        [S("N4", 3)]
        public N4_BillingProviderCityStateZIPCode N4_BillingProviderCityStateZIPCode { get; set; }
        [A(4)]
        public All_REF All_REF { get; set; }
        [S("PER", 5)]
        public List<PER_BillingProviderContactInformation> PER_BillingProviderContactInformation { get; set; }
    }
    
    public class PER_BillingProviderContactInformation
    {
        
        [D(1, typeof(X12_ID_366_PER_BillingProviderContactInformation), "366")]
        public string ContactFunctionCode_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string BillingProviderContactName_02 { get; set; }
        [D(3, typeof(X12_ID_365_PER_BillingProviderContactInformation), "365")]
        public string CommunicationNumberQualifier_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string CommunicationNumber_04 { get; set; }
        [D(5, typeof(X12_ID_365_PER_BillingProviderContactInformation), "365")]
        public string CommunicationNumberQualifier_05 { get; set; }
        [D(6, typeof(X12_AN))]
        public string CommunicationNumber_06 { get; set; }
        [D(7, typeof(X12_ID_365_PER_BillingProviderContactInformation), "365")]
        public string CommunicationNumberQualifier_07 { get; set; }
        [D(8, typeof(X12_AN))]
        public string CommunicationNumber_08 { get; set; }
        [D(9, typeof(X12_AN))]
        public string PER_09 { get; set; }
    }
    
    public class X12_ID_366_PER_BillingProviderContactInformation
    {
        
        public List<string> Codes = new List<string> {"IC"};
    }
    
    public class X12_ID_365_PER_BillingProviderContactInformation
    {
        
        public List<string> Codes = new List<string> {"EM","FX","TE"};
    }
    
    public class N4_BillingProviderCityStateZIPCode
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
    
    public class N3_BillingProviderAddress
    {
        
        [D(1, typeof(X12_AN))]
        public string BillingProviderAddressLine_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string BillingProviderAddressLine_02 { get; set; }
    }
    
    public class NM1_BillingProviderName
    {
        
        [D(1, typeof(X12_ID_98_NM1_BillingProviderName), "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, typeof(X12_ID_1065_NM1_BillingProviderName), "1065")]
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
        [D(8, typeof(X12_ID_66_NM1_BillingProviderName), "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, typeof(X12_AN))]
        public string BillingProviderIdentifier_09 { get; set; }
        [D(10, typeof(X12_ID))]
        public string NM1_10 { get; set; }
        [D(11, typeof(X12_ID))]
        public string NM1_11 { get; set; }
    }
    
    public class X12_ID_98_NM1_BillingProviderName
    {
        
        public List<string> Codes = new List<string> {"85"};
    }
    
    public class X12_ID_1065_NM1_BillingProviderName
    {
        
        public List<string> Codes = new List<string> {"1","2"};
    }
    
    public class X12_ID_66_NM1_BillingProviderName
    {
        
        public List<string> Codes = new List<string> {"24","34","XX"};
    }
    
    public class CUR_ForeignCurrencyInformation
    {
        
        [D(1, typeof(X12_ID_98_CUR_ForeignCurrencyInformation), "98")]
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
    
    public class X12_ID_98_CUR_ForeignCurrencyInformation
    {
        
        public List<string> Codes = new List<string> {"85"};
    }
    
    public class X12_TM
    {
    }
    
    public class PRV_BillingPaytoProviderSpecialtyInformation
    {
        
        [D(1, typeof(X12_ID_1221_PRV_BillingPaytoProviderSpecialtyInformation), "1221")]
        public string ProviderCode_01 { get; set; }
        [D(2, typeof(X12_ID_128_PRV_BillingPaytoProviderSpecialtyInformation), "128")]
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
    
    public class X12_ID_1221_PRV_BillingPaytoProviderSpecialtyInformation
    {
        
        public List<string> Codes = new List<string> {"BI","PT"};
    }
    
    public class X12_ID_128_PRV_BillingPaytoProviderSpecialtyInformation
    {
        
        public List<string> Codes = new List<string> {"ZZ"};
    }
    
    public class HL_BillingPaytoProviderHierarchicalLevel
    {
        
        [D(1, typeof(X12_AN))]
        public string HierarchicalIDNumber_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string HL_02 { get; set; }
        [D(3, typeof(X12_ID_735_HL_BillingPaytoProviderHierarchicalLevel), "735")]
        public string HierarchicalLevelCode_03 { get; set; }
        [D(4, typeof(X12_ID_736_HL_BillingPaytoProviderHierarchicalLevel), "736")]
        public string HierarchicalChildCode_04 { get; set; }
    }
    
    public class X12_ID_735_HL_BillingPaytoProviderHierarchicalLevel
    {
        
        public List<string> Codes = new List<string> {"20"};
    }
    
    public class X12_ID_736_HL_BillingPaytoProviderHierarchicalLevel
    {
        
        public List<string> Codes = new List<string> {"1"};
    }
    
    public class Loop_1000B
    {
        
        [S("NM1", 1)]
        public NM1_ReceiverName NM1_ReceiverName { get; set; }
    }
    
    public class NM1_ReceiverName
    {
        
        [D(1, typeof(X12_ID_98_NM1_ReceiverName), "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, typeof(X12_ID_1065_NM1_ReceiverName), "1065")]
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
        [D(8, typeof(X12_ID_66_NM1_ReceiverName), "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, typeof(X12_AN))]
        public string ReceiverPrimaryIdentifier_09 { get; set; }
        [D(10, typeof(X12_ID))]
        public string NM1_10 { get; set; }
        [D(11, typeof(X12_ID))]
        public string NM1_11 { get; set; }
    }
    
    public class X12_ID_98_NM1_ReceiverName
    {
        
        public List<string> Codes = new List<string> {"40"};
    }
    
    public class X12_ID_1065_NM1_ReceiverName
    {
        
        public List<string> Codes = new List<string> {"2"};
    }
    
    public class X12_ID_66_NM1_ReceiverName
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
        
        [D(1, typeof(X12_ID_366_PER_SubmitterEDIContactInformation), "366")]
        public string ContactFunctionCode_01 { get; set; }
        [D(2, typeof(X12_AN))]
        public string SubmitterContactName_02 { get; set; }
        [D(3, typeof(X12_ID_365_PER_SubmitterEDIContactInformation), "365")]
        public string CommunicationNumberQualifier_03 { get; set; }
        [D(4, typeof(X12_AN))]
        public string CommunicationNumber_04 { get; set; }
        [D(5, typeof(X12_ID_365_PER_SubmitterEDIContactInformation), "365")]
        public string CommunicationNumberQualifier_05 { get; set; }
        [D(6, typeof(X12_AN))]
        public string CommunicationNumber_06 { get; set; }
        [D(7, typeof(X12_ID_365_PER_SubmitterEDIContactInformation), "365")]
        public string CommunicationNumberQualifier_07 { get; set; }
        [D(8, typeof(X12_AN))]
        public string CommunicationNumber_08 { get; set; }
        [D(9, typeof(X12_AN))]
        public string PER_09 { get; set; }
    }
    
    public class X12_ID_366_PER_SubmitterEDIContactInformation
    {
        
        public List<string> Codes = new List<string> {"IC"};
    }
    
    public class X12_ID_365_PER_SubmitterEDIContactInformation
    {
        
        public List<string> Codes = new List<string> {"ED","EM","FX","TE"};
    }
    
    public class NM1_SubmitterName
    {
        
        [D(1, typeof(X12_ID_98_NM1_SubmitterName), "98")]
        public string EntityIdentifierCode_01 { get; set; }
        [D(2, typeof(X12_ID_1065_NM1_SubmitterName), "1065")]
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
        [D(8, typeof(X12_ID_66_NM1_SubmitterName), "66")]
        public string IdentificationCodeQualifier_08 { get; set; }
        [D(9, typeof(X12_AN))]
        public string SubmitterIdentifier_09 { get; set; }
        [D(10, typeof(X12_ID))]
        public string NM1_10 { get; set; }
        [D(11, typeof(X12_ID))]
        public string NM1_11 { get; set; }
    }
    
    public class X12_ID_98_NM1_SubmitterName
    {
        
        public List<string> Codes = new List<string> {"41"};
    }
    
    public class X12_ID_1065_NM1_SubmitterName
    {
        
        public List<string> Codes = new List<string> {"1","2"};
    }
    
    public class X12_ID_66_NM1_SubmitterName
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
