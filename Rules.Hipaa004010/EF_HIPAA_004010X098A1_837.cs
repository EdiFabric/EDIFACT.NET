using EdiFabric.Core.Annotations;
using EdiFabric.Core.Annotations.Edi;
using EdiFabric.Core.Annotations.Validation;
using EdiFabric.Core.Model;

namespace EdiFabric.Rules.HIPAA_004010X098A1_837
{
    using System;
    using System.Collections.Generic;


    [Serializable()]
    [Message("X12", "004010X098A1", "837")]
    public class TS837 : EdiMessage
    {
        
        [Pos(1)]
        public ST ST { get; set; }
        [Required]
        [Pos(2)]
        public BHT_BeginningOfHierarchicalTransaction BHT_BeginningOfHierarchicalTransaction { get; set; }
        [Required]
        [Pos(3)]
        public REF_TransmissionTypeIdentification REF_TransmissionTypeIdentification { get; set; }
        [Required]
        [Pos(4)]
        public Loop_1000A Loop_1000A { get; set; }
        [Required]
        [Pos(5)]
        public Loop_1000B Loop_1000B { get; set; }
        [Required]
        [Pos(6)]
        public List<Loop_2000A> Loop_2000A { get; set; }
        [Pos(7)]
        public SE SE { get; set; }
    }
    
    [Serializable()]
    public class X12_AN
    {
    }
    
    [Serializable()]
    [EdiCodes(",0019,")]
    public class X12_ID_1005_BHT_BeginningOfHierarchicalTransaction
    {
    }
    
    [Serializable()]
    [EdiCodes(",00,18,")]
    public class X12_ID_353_BHT_BeginningOfHierarchicalTransaction
    {
    }
    
    [Serializable()]
    [EdiCodes(",87,")]
    public class X12_ID_128_REF_TransmissionTypeIdentification
    {
    }
    
    [Serializable()]
    [Segment("SE")]
    public class SE
    {
        
        [Required]
        [StringLength(1, 10)]
        [DataElement("96", typeof(X12_AN))]
        [Pos(1)]
        public string NumberofIncludedSegments_01 { get; set; }
        [Required]
        [StringLength(4, 9)]
        [DataElement("329", typeof(X12_AN))]
        [Pos(2)]
        public string TransactionSetControlNumber_02 { get; set; }
    }
    
    [Serializable()]
    [Group("HL")]
    public class Loop_2000A
    {
        
        [Required]
        [Pos(1)]
        public HL_BillingPaytoProviderHierarchicalLevel_2000A HL_BillingPaytoProviderHierarchicalLevel_2000A { get; set; }
        [Pos(2)]
        public PRV_BillingPaytoProviderSpecialtyInformation_2000A PRV_BillingPaytoProviderSpecialtyInformation_2000A { get; set; }
        [Pos(3)]
        public CUR_ForeignCurrencyInformation_2000A CUR_ForeignCurrencyInformation_2000A { get; set; }
        [Required]
        [Pos(4)]
        public All_2010A All_2010A { get; set; }
        [Required]
        [Pos(5)]
        public List<Loop_2000B> Loop_2000B { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",BI,PT,")]
    public class X12_ID_1221_PRV_BillingPaytoProviderSpecialtyInformation_2000A
    {
    }
    
    [Serializable()]
    [EdiCodes(",ZZ,")]
    public class X12_ID_128_PRV_BillingPaytoProviderSpecialtyInformation_2000A
    {
    }
    
    [Serializable()]
    [EdiCodes(",85,")]
    public class X12_ID_98_CUR_ForeignCurrencyInformation_2000A
    {
    }
    
    [Serializable()]
    public class X12_ID
    {
    }
    
    [Serializable()]
    [Group("HL")]
    public class Loop_2000B
    {
        
        [Required]
        [Pos(1)]
        public HL_SubscriberHierarchicalLevel_2000B HL_SubscriberHierarchicalLevel_2000B { get; set; }
        [Required]
        [Pos(2)]
        public SBR_SubscriberInformation_2000B SBR_SubscriberInformation_2000B { get; set; }
        [Pos(3)]
        public PAT_PatientInformation_2000B PAT_PatientInformation_2000B { get; set; }
        [Required]
        [Pos(4)]
        public All_2010B All_2010B { get; set; }
        [ListCount(100)]
        [Pos(5)]
        public List<Loop_2300> Loop_2300 { get; set; }
        [Pos(6)]
        public List<Loop_2000C> Loop_2000C { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",P,S,T,")]
    public class X12_ID_1138_SBR_SubscriberInformation_2000B
    {
    }
    
    [Serializable()]
    [EdiCodes(",18,")]
    public class X12_ID_1069_SBR_SubscriberInformation_2000B
    {
    }
    
    [Serializable()]
    [Group("HL")]
    public class Loop_2000C
    {
        
        [Required]
        [Pos(1)]
        public HL_PatientHierarchicalLevel_2000C HL_PatientHierarchicalLevel_2000C { get; set; }
        [Required]
        [Pos(2)]
        public PAT_PatientInformation_2000C PAT_PatientInformation_2000C { get; set; }
        [Required]
        [Pos(3)]
        public Loop_2010CA Loop_2010CA { get; set; }
        [Required]
        [ListCount(100)]
        [Pos(4)]
        public List<Loop_2300> Loop_2300 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",01,04,05,07,09,10,15,17,19,20,21,22,23,24,29,32,33,34,36,39,40,41,43,53,G8,")]
    public class X12_ID_1069_PAT_PatientInformation_2000C
    {
    }
    
    [Serializable()]
    [Group("CLM")]
    public class Loop_2300
    {
        
        [Required]
        [Pos(1)]
        public CLM_ClaimInformation_2300 CLM_ClaimInformation_2300 { get; set; }
        [Pos(2)]
        public All_DTP_2300 All_DTP_2300 { get; set; }
        [ListCount(10)]
        [Pos(3)]
        public List<PWK_ClaimSupplementalInformation_2300> PWK_ClaimSupplementalInformation_2300 { get; set; }
        [Pos(4)]
        public CN1_ContractInformation_2300 CN1_ContractInformation_2300 { get; set; }
        [Pos(5)]
        public All_AMT_2300 All_AMT_2300 { get; set; }
        [Pos(6)]
        public All_REF_2300 All_REF_2300 { get; set; }
        [ListCount(10)]
        [Pos(7)]
        public List<K3_FileInformation_2300> K3_FileInformation_2300 { get; set; }
        [Pos(8)]
        public NTE_ClaimNote_2300 NTE_ClaimNote_2300 { get; set; }
        [Pos(9)]
        public CR1_AmbulanceTransportInformation_2300 CR1_AmbulanceTransportInformation_2300 { get; set; }
        [Pos(10)]
        public CR2_SpinalManipulationServiceInformation_2300 CR2_SpinalManipulationServiceInformation_2300 { get; set; }
        [Pos(11)]
        public All_CRC_2300 All_CRC_2300 { get; set; }
        [Pos(12)]
        public HI_HealthCareDiagnosisCode_2300 HI_HealthCareDiagnosisCode_2300 { get; set; }
        [Pos(13)]
        public HCP_ClaimPricingRepricingInformation_2300 HCP_ClaimPricingRepricingInformation_2300 { get; set; }
        [ListCount(6)]
        [Pos(14)]
        public List<Loop_2305> Loop_2305 { get; set; }
        [Pos(15)]
        public All_2310 All_2310 { get; set; }
        [ListCount(10)]
        [Pos(16)]
        public List<Loop_2320> Loop_2320 { get; set; }
        [Required]
        [ListCount(50)]
        [Pos(17)]
        public List<Loop_2400> Loop_2400 { get; set; }
    }
    
    [Serializable()]
    public class X12_R
    {
    }
    
    [Serializable()]
    [EdiCodes(",77,AS,B2,B3,B4,CT,DA,DG,DS,EB,MT,NN,OB,OZ,PN,PO,PZ,RB,RR,RT,")]
    public class X12_ID_755_PWK_ClaimSupplementalInformation_2300
    {
    }
    
    [Serializable()]
    [EdiCodes(",AA,BM,EL,EM,FX,")]
    public class X12_ID_756_PWK_ClaimSupplementalInformation_2300
    {
    }
    
    [Serializable()]
    [EdiCodes(",02,03,04,05,06,09,")]
    public class X12_ID_1166_CN1_ContractInformation_2300
    {
    }
    
    [Serializable()]
    [EdiCodes(",ADD,CER,DCP,DGN,PMT,TPO,")]
    public class X12_ID_363_NTE_ClaimNote_2300
    {
    }
    
    [Serializable()]
    [EdiCodes(",LB,")]
    public class X12_ID_355_CR1_AmbulanceTransportInformation_2300
    {
    }
    
    [Serializable()]
    public class X12_N0
    {
    }
    
    [Serializable()]
    [EdiCodes(",BK,")]
    public class X12_ID_1270_C022_57917336
    {
    }
    
    [Serializable()]
    [EdiCodes(",BF,")]
    public class X12_ID_1270_C022_1220782286
    {
    }
    
    [Serializable()]
    [EdiCodes(",00,01,02,03,04,05,07,08,09,10,11,12,13,14,")]
    public class X12_ID_1473_HCP_ClaimPricingRepricingInformation_2300
    {
    }
    
    [Serializable()]
    [Group("LX")]
    public class Loop_2400
    {
        
        [Required]
        [Pos(1)]
        public LX_ServiceLine_2400 LX_ServiceLine_2400 { get; set; }
        [Required]
        [Pos(2)]
        public SV1_ProfessionalService_2400 SV1_ProfessionalService_2400 { get; set; }
        [Pos(3)]
        public SV5_DurableMedicalEquipmentService_2400 SV5_DurableMedicalEquipmentService_2400 { get; set; }
        [Pos(4)]
        public PWK_DMERCCMNIndicator_2400 PWK_DMERCCMNIndicator_2400 { get; set; }
        [Pos(5)]
        public CR1_AmbulanceTransportInformation_2400 CR1_AmbulanceTransportInformation_2400 { get; set; }
        [ListCount(5)]
        [Pos(6)]
        public List<CR2_SpinalManipulationServiceInformation_2400> CR2_SpinalManipulationServiceInformation_2400 { get; set; }
        [Pos(7)]
        public CR3_DurableMedicalEquipmentCertification_2400 CR3_DurableMedicalEquipmentCertification_2400 { get; set; }
        [Pos(8)]
        public CR5_HomeOxygenTherapyInformation_2400 CR5_HomeOxygenTherapyInformation_2400 { get; set; }
        [Pos(9)]
        public All_CRC_2400 All_CRC_2400 { get; set; }
        [Required]
        [Pos(10)]
        public All_DTP_2400 All_DTP_2400 { get; set; }
        [ListCount(20)]
        [Pos(11)]
        public List<MEA_TestResult_2400> MEA_TestResult_2400 { get; set; }
        [Pos(12)]
        public CN1_ContractInformation_2400 CN1_ContractInformation_2400 { get; set; }
        [Pos(13)]
        public All_REF_2400 All_REF_2400 { get; set; }
        [Pos(14)]
        public All_AMT_2400 All_AMT_2400 { get; set; }
        [ListCount(10)]
        [Pos(15)]
        public List<K3_FileInformation_2400> K3_FileInformation_2400 { get; set; }
        [Pos(16)]
        public NTE_LineNote_2400 NTE_LineNote_2400 { get; set; }
        [Pos(17)]
        public PS1_PurchasedServiceInformation_2400 PS1_PurchasedServiceInformation_2400 { get; set; }
        [Pos(18)]
        public HSD_HealthCareServicesDelivery_2400 HSD_HealthCareServicesDelivery_2400 { get; set; }
        [Pos(19)]
        public HCP_LinePricingRepricingInformation_2400 HCP_LinePricingRepricingInformation_2400 { get; set; }
        [ListCount(25)]
        [Pos(20)]
        public List<Loop_2410> Loop_2410 { get; set; }
        [Pos(21)]
        public All_2420 All_2420 { get; set; }
        [ListCount(25)]
        [Pos(22)]
        public List<Loop_2430> Loop_2430 { get; set; }
        [ListCount(5)]
        [Pos(23)]
        public List<Loop_2440> Loop_2440 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",HC,IV,ZZ,")]
    public class X12_ID_235_C003_701728622
    {
    }
    
    [Serializable()]
    [EdiCodes(",HC,")]
    public class X12_ID_235_C003_19141319
    {
    }
    
    [Serializable()]
    [EdiCodes(",DA,")]
    public class X12_ID_355_SV5_DurableMedicalEquipmentService_2400
    {
    }
    
    [Serializable()]
    [EdiCodes(",CT,")]
    public class X12_ID_755_PWK_DMERCCMNIndicator_2400
    {
    }
    
    [Serializable()]
    [EdiCodes(",AB,AD,AF,AG,NS,")]
    public class X12_ID_756_PWK_DMERCCMNIndicator_2400
    {
    }
    
    [Serializable()]
    [EdiCodes(",LB,")]
    public class X12_ID_355_CR1_AmbulanceTransportInformation_2400
    {
    }
    
    [Serializable()]
    [EdiCodes(",I,R,S,")]
    public class X12_ID_1322_CR3_DurableMedicalEquipmentCertification_2400
    {
    }
    
    [Serializable()]
    [EdiCodes(",MO,")]
    public class X12_ID_355_CR3_DurableMedicalEquipmentCertification_2400
    {
    }
    
    [Serializable()]
    [EdiCodes(",I,R,S,")]
    public class X12_ID_1322_CR5_HomeOxygenTherapyInformation_2400
    {
    }
    
    [Serializable()]
    [EdiCodes(",OG,TR,")]
    public class X12_ID_737_MEA_TestResult_2400
    {
    }
    
    [Serializable()]
    [EdiCodes(",GRA,HT,R1,R2,R3,R4,ZO,")]
    public class X12_ID_738_MEA_TestResult_2400
    {
    }
    
    [Serializable()]
    [EdiCodes(",01,02,03,04,05,06,09,")]
    public class X12_ID_1166_CN1_ContractInformation_2400
    {
    }
    
    [Serializable()]
    [EdiCodes(",ADD,DCP,PMT,TPO,")]
    public class X12_ID_363_NTE_LineNote_2400
    {
    }
    
    [Serializable()]
    [EdiCodes(",VS,")]
    public class X12_ID_673_HSD_HealthCareServicesDelivery_2400
    {
    }
    
    [Serializable()]
    [EdiCodes(",00,01,02,03,04,05,06,07,08,09,10,11,12,13,14,")]
    public class X12_ID_1473_HCP_LinePricingRepricingInformation_2400
    {
    }
    
    [Serializable()]
    [Group("LQ")]
    public class Loop_2440
    {
        
        [Required]
        [Pos(1)]
        public LQ_FormIdentificationCode_2440 LQ_FormIdentificationCode_2440 { get; set; }
        [Required]
        [ListCount(99)]
        [Pos(2)]
        public List<FRM_SupportingDocumentation_2440> FRM_SupportingDocumentation_2440 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",AS,UT,")]
    public class X12_ID_1270_LQ_FormIdentificationCode_2440
    {
    }
    
    [Serializable()]
    [EdiCodes(",N,W,Y,")]
    public class X12_ID_1073_FRM_SupportingDocumentation_2440
    {
    }
    
    [Serializable()]
    [Segment("FRM")]
    public class FRM_SupportingDocumentation_2440
    {
        
        [Required]
        [StringLength(1, 20)]
        [DataElement("", typeof(X12_AN))]
        [Pos(1)]
        public string QuestionNumberLetter_01 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073_FRM_SupportingDocumentation_2440))]
        [Pos(2)]
        public string QuestionResponse_02 { get; set; }
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string QuestionResponse_03 { get; set; }
        [StringLength(8, 8)]
        [DataElement("", typeof(X12_DT))]
        [Pos(4)]
        public string QuestionResponse_04 { get; set; }
        [DataElement("", typeof(X12_R))]
        [Pos(5)]
        public string QuestionResponse_05 { get; set; }
    }
    
    [Serializable()]
    public class X12_DT
    {
    }
    
    [Serializable()]
    [Segment("LQ", typeof(X12_ID_1270_LQ_FormIdentificationCode_2440))]
    public class LQ_FormIdentificationCode_2440
    {
        
        [Required]
        [DataElement("1270", typeof(X12_ID_1270_LQ_FormIdentificationCode_2440))]
        [Pos(1)]
        public string CodeListQualifierCode_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(2)]
        public string FormIdentifier_02 { get; set; }
    }
    
    [Serializable()]
    [Group("SVD")]
    public class Loop_2430
    {
        
        [Required]
        [Pos(1)]
        public SVD_LineAdjudicationInformation_2430 SVD_LineAdjudicationInformation_2430 { get; set; }
        [ListCount(99)]
        [Pos(2)]
        public List<CAS_LineAdjustment_2430> CAS_LineAdjustment_2430 { get; set; }
        [Required]
        [Pos(3)]
        public DTP_LineAdjudicationDate_2430 DTP_LineAdjudicationDate_2430 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",CO,CR,OA,PI,PR,")]
    public class X12_ID_1033_CAS_LineAdjustment_2430
    {
    }
    
    [Serializable()]
    [EdiCodes(",573,")]
    public class X12_ID_374_DTP_LineAdjudicationDate_2430
    {
    }
    
    [Serializable()]
    [EdiCodes(",D8,")]
    public class X12_ID_1250_DTP_LineAdjudicationDate_2430
    {
    }
    
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_DTP_LineAdjudicationDate_2430), typeof(X12_ID_1250_DTP_LineAdjudicationDate_2430))]
    public class DTP_LineAdjudicationDate_2430
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374_DTP_LineAdjudicationDate_2430))]
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        [Required]
        [DataElement("1250", typeof(X12_ID_1250_DTP_LineAdjudicationDate_2430))]
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [Required]
        [StringLength(1, 35)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string AdjudicationOrPaymentDate_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("CAS", typeof(X12_ID_1033_CAS_LineAdjustment_2430))]
    public class CAS_LineAdjustment_2430
    {
        
        [Required]
        [DataElement("1033", typeof(X12_ID_1033_CAS_LineAdjustment_2430))]
        [Pos(1)]
        public string ClaimAdjustmentGroupCode_01 { get; set; }
        [Required]
        [StringLength(1, 5)]
        [DataElement("", typeof(X12_ID))]
        [Pos(2)]
        public string AdjustmentReasonCode_02 { get; set; }
        [Required]
        [DataElement("", typeof(X12_R))]
        [Pos(3)]
        public string AdjustmentAmount_03 { get; set; }
        [DataElement("", typeof(X12_R))]
        [Pos(4)]
        public string AdjustmentQuantity_04 { get; set; }
        [StringLength(1, 5)]
        [DataElement("", typeof(X12_ID))]
        [Pos(5)]
        public string AdjustmentReasonCode_05 { get; set; }
        [DataElement("", typeof(X12_R))]
        [Pos(6)]
        public string AdjustmentAmount_06 { get; set; }
        [DataElement("", typeof(X12_R))]
        [Pos(7)]
        public string AdjustmentQuantity_07 { get; set; }
        [StringLength(1, 5)]
        [DataElement("", typeof(X12_ID))]
        [Pos(8)]
        public string AdjustmentReasonCode_08 { get; set; }
        [DataElement("", typeof(X12_R))]
        [Pos(9)]
        public string AdjustmentAmount_09 { get; set; }
        [DataElement("", typeof(X12_R))]
        [Pos(10)]
        public string AdjustmentQuantity_10 { get; set; }
        [StringLength(1, 5)]
        [DataElement("", typeof(X12_ID))]
        [Pos(11)]
        public string AdjustmentReasonCode_11 { get; set; }
        [DataElement("", typeof(X12_R))]
        [Pos(12)]
        public string AdjustmentAmount_12 { get; set; }
        [DataElement("", typeof(X12_R))]
        [Pos(13)]
        public string AdjustmentQuantity_13 { get; set; }
        [StringLength(1, 5)]
        [DataElement("", typeof(X12_ID))]
        [Pos(14)]
        public string AdjustmentReasonCode_14 { get; set; }
        [DataElement("", typeof(X12_R))]
        [Pos(15)]
        public string AdjustmentAmount_15 { get; set; }
        [DataElement("", typeof(X12_R))]
        [Pos(16)]
        public string AdjustmentQuantity_16 { get; set; }
        [StringLength(1, 5)]
        [DataElement("", typeof(X12_ID))]
        [Pos(17)]
        public string AdjustmentReasonCode_17 { get; set; }
        [DataElement("", typeof(X12_R))]
        [Pos(18)]
        public string AdjustmentAmount_18 { get; set; }
        [DataElement("", typeof(X12_R))]
        [Pos(19)]
        public string AdjustmentQuantity_19 { get; set; }
    }
    
    [Serializable()]
    [Segment("SVD")]
    public class SVD_LineAdjudicationInformation_2430
    {
        
        [Required]
        [StringLength(2, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(1)]
        public string OtherPayerPrimaryIdentifier_01 { get; set; }
        [Required]
        [DataElement("", typeof(X12_R))]
        [Pos(2)]
        public string ServiceLinePaidAmount_02 { get; set; }
        [Required]
        [Pos(3)]
        public C003_460284360 C003_460284360 { get; set; }
        [StringLength(1, 48)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string SVD_04 { get; set; }
        [Required]
        [DataElement("", typeof(X12_R))]
        [Pos(5)]
        public string PaidServiceUnitCount_05 { get; set; }
        [DataElement("", typeof(X12_N0))]
        [Pos(6)]
        public string BundledOrUnbundledLineNumber_06 { get; set; }
    }
    
    [Serializable()]
    [Composite("C003_460284360")]
    public class C003_460284360
    {
        
        [Required]
        [DataElement("235", typeof(X12_ID_235_C003_460284360))]
        [Pos(1)]
        public string ProductOrServiceIDQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 48)]
        [DataElement("", typeof(X12_AN))]
        [Pos(2)]
        public string ProcedureCode_02 { get; set; }
        [StringLength(2, 2)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string ProcedureModifier_03 { get; set; }
        [StringLength(2, 2)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string ProcedureModifier_04 { get; set; }
        [StringLength(2, 2)]
        [DataElement("", typeof(X12_AN))]
        [Pos(5)]
        public string ProcedureModifier_05 { get; set; }
        [StringLength(2, 2)]
        [DataElement("", typeof(X12_AN))]
        [Pos(6)]
        public string ProcedureModifier_06 { get; set; }
        [StringLength(1, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(7)]
        public string ProcedureCodeDescription_07 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",HC,IV,ZZ,")]
    public class X12_ID_235_C003_460284360
    {
    }
    
    [Serializable()]
    [All()]
    public class All_2420
    {
        
        [Pos(1)]
        public Loop_2420A Loop_2420A { get; set; }
        [Pos(2)]
        public Loop_2420B Loop_2420B { get; set; }
        [Pos(3)]
        public Loop_2420C Loop_2420C { get; set; }
        [Pos(4)]
        public Loop_2420D Loop_2420D { get; set; }
        [Pos(5)]
        public Loop_2420E Loop_2420E { get; set; }
        [ListCount(2)]
        [Pos(6)]
        public List<Loop_2420F> Loop_2420F { get; set; }
        [ListCount(4)]
        [Pos(7)]
        public List<Loop_2420G> Loop_2420G { get; set; }
    }
    
    [Serializable()]
    [Group("NM1")]
    public class Loop_2420G
    {
        
        [Required]
        [Pos(1)]
        public NM1_OtherPayerPriorAuthorizationOrReferralNumber_2420G NM1_OtherPayerPriorAuthorizationOrReferralNumber_2420G { get; set; }
        [Required]
        [ListCount(2)]
        [Pos(2)]
        public List<REF_OtherPayerPriorAuthorizationOrReferralNumber_2420G> REF_OtherPayerPriorAuthorizationOrReferralNumber_2420G { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",PR,")]
    public class X12_ID_98_NM1_OtherPayerPriorAuthorizationOrReferralNumber_2420G
    {
    }
    
    [Serializable()]
    [EdiCodes(",2,")]
    public class X12_ID_1065_NM1_OtherPayerPriorAuthorizationOrReferralNumber_2420G
    {
    }
    
    [Serializable()]
    [EdiCodes(",9F,G1,")]
    public class X12_ID_128_REF_OtherPayerPriorAuthorizationOrReferralNumber_2420G
    {
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_REF_OtherPayerPriorAuthorizationOrReferralNumber_2420G))]
    public class REF_OtherPayerPriorAuthorizationOrReferralNumber_2420G
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_REF_OtherPayerPriorAuthorizationOrReferralNumber_2420G))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(2)]
        public string OtherPayerPriorAuthorizationOrReferralNumber_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string REF_03 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string REF_04 { get; set; }
    }
    
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_NM1_OtherPayerPriorAuthorizationOrReferralNumber_2420G), typeof(X12_ID_1065_NM1_OtherPayerPriorAuthorizationOrReferralNumber_2420G))]
    public class NM1_OtherPayerPriorAuthorizationOrReferralNumber_2420G
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98_NM1_OtherPayerPriorAuthorizationOrReferralNumber_2420G))]
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        [Required]
        [DataElement("1065", typeof(X12_ID_1065_NM1_OtherPayerPriorAuthorizationOrReferralNumber_2420G))]
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        [Required]
        [StringLength(1, 35)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string PayerName_03 { get; set; }
        [StringLength(1, 25)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string NM1_04 { get; set; }
        [StringLength(1, 25)]
        [DataElement("", typeof(X12_AN))]
        [Pos(5)]
        public string NM1_05 { get; set; }
        [StringLength(1, 10)]
        [DataElement("", typeof(X12_AN))]
        [Pos(6)]
        public string NM1_06 { get; set; }
        [StringLength(1, 10)]
        [DataElement("", typeof(X12_AN))]
        [Pos(7)]
        public string NM1_07 { get; set; }
        [Required]
        [DataElement("66", typeof(X12_ID_66_NM1_OtherPayerPriorAuthorizationOrReferralNumber_2420G))]
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        [Required]
        [StringLength(2, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(9)]
        public string OtherPayerIdentificationNumber_09 { get; set; }
        [StringLength(2, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(10)]
        public string NM1_10 { get; set; }
        [StringLength(2, 3)]
        [DataElement("", typeof(X12_ID))]
        [Pos(11)]
        public string NM1_11 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",PI,XV,")]
    public class X12_ID_66_NM1_OtherPayerPriorAuthorizationOrReferralNumber_2420G
    {
    }
    
    [Serializable()]
    [Group("NM1")]
    public class Loop_2420F
    {
        
        [Required]
        [Pos(1)]
        public NM1_ReferringProviderName_2420F NM1_ReferringProviderName_2420F { get; set; }
        [Pos(2)]
        public PRV_ReferringProviderSpecialtyInformation_2420F PRV_ReferringProviderSpecialtyInformation_2420F { get; set; }
        [ListCount(5)]
        [Pos(3)]
        public List<REF_ReferringProviderSecondaryIdentification_2420F> REF_ReferringProviderSecondaryIdentification_2420F { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",DN,P3,")]
    public class X12_ID_98_NM1_ReferringProviderName_2420F
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,")]
    public class X12_ID_1065_NM1_ReferringProviderName_2420F
    {
    }
    
    [Serializable()]
    [EdiCodes(",RF,")]
    public class X12_ID_1221_PRV_ReferringProviderSpecialtyInformation_2420F
    {
    }
    
    [Serializable()]
    [EdiCodes(",ZZ,")]
    public class X12_ID_128_PRV_ReferringProviderSpecialtyInformation_2420F
    {
    }
    
    [Serializable()]
    [EdiCodes(",0B,1B,1C,1D,1G,1H,EI,G2,LU,N5,SY,X5,")]
    public class X12_ID_128_REF_ReferringProviderSecondaryIdentification_2420F
    {
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_REF_ReferringProviderSecondaryIdentification_2420F))]
    public class REF_ReferringProviderSecondaryIdentification_2420F
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_REF_ReferringProviderSecondaryIdentification_2420F))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(2)]
        public string ReferringProviderSecondaryIdentifier_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string REF_03 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string REF_04 { get; set; }
    }
    
    [Serializable()]
    [Segment("PRV", typeof(X12_ID_1221_PRV_ReferringProviderSpecialtyInformation_2420F), typeof(X12_ID_128_PRV_ReferringProviderSpecialtyInformation_2420F))]
    public class PRV_ReferringProviderSpecialtyInformation_2420F
    {
        
        [Required]
        [DataElement("1221", typeof(X12_ID_1221_PRV_ReferringProviderSpecialtyInformation_2420F))]
        [Pos(1)]
        public string ProviderCode_01 { get; set; }
        [Required]
        [DataElement("128", typeof(X12_ID_128_PRV_ReferringProviderSpecialtyInformation_2420F))]
        [Pos(2)]
        public string ReferenceIdentificationQualifier_02 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string ProviderTaxonomyCode_03 { get; set; }
        [StringLength(2, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(4)]
        public string PRV_04 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_AN))]
        [Pos(5)]
        public string PRV_05 { get; set; }
        [StringLength(3, 3)]
        [DataElement("", typeof(X12_ID))]
        [Pos(6)]
        public string PRV_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_NM1_ReferringProviderName_2420F), typeof(X12_ID_1065_NM1_ReferringProviderName_2420F))]
    public class NM1_ReferringProviderName_2420F
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98_NM1_ReferringProviderName_2420F))]
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        [Required]
        [DataElement("1065", typeof(X12_ID_1065_NM1_ReferringProviderName_2420F))]
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        [Required]
        [StringLength(1, 35)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string ReferringProviderLastName_03 { get; set; }
        [Required]
        [StringLength(1, 25)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string ReferringProviderFirstName_04 { get; set; }
        [StringLength(1, 25)]
        [DataElement("", typeof(X12_AN))]
        [Pos(5)]
        public string ReferringProviderMiddleName_05 { get; set; }
        [StringLength(1, 10)]
        [DataElement("", typeof(X12_AN))]
        [Pos(6)]
        public string NM1_06 { get; set; }
        [StringLength(1, 10)]
        [DataElement("", typeof(X12_AN))]
        [Pos(7)]
        public string ReferringProviderNameSuffix_07 { get; set; }
        [DataElement("66", typeof(X12_ID_66_NM1_ReferringProviderName_2420F))]
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        [StringLength(2, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(9)]
        public string ReferringProviderIdentifier_09 { get; set; }
        [StringLength(2, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(10)]
        public string NM1_10 { get; set; }
        [StringLength(2, 3)]
        [DataElement("", typeof(X12_ID))]
        [Pos(11)]
        public string NM1_11 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",24,34,XX,")]
    public class X12_ID_66_NM1_ReferringProviderName_2420F
    {
    }
    
    [Serializable()]
    [Group("NM1")]
    public class Loop_2420E
    {
        
        [Required]
        [Pos(1)]
        public NM1_OrderingProviderName_2420E NM1_OrderingProviderName_2420E { get; set; }
        [Pos(2)]
        public N3_OrderingProviderAddress_2420E N3_OrderingProviderAddress_2420E { get; set; }
        [Pos(3)]
        public N4_OrderingProviderCityStateZIPCode_2420E N4_OrderingProviderCityStateZIPCode_2420E { get; set; }
        [ListCount(5)]
        [Pos(4)]
        public List<REF_OrderingProviderSecondaryIdentification_2420E> REF_OrderingProviderSecondaryIdentification_2420E { get; set; }
        [Pos(5)]
        public PER_OrderingProviderContactInformation_2420E PER_OrderingProviderContactInformation_2420E { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",DK,")]
    public class X12_ID_98_NM1_OrderingProviderName_2420E
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,")]
    public class X12_ID_1065_NM1_OrderingProviderName_2420E
    {
    }
    
    [Serializable()]
    [EdiCodes(",0B,1B,1C,1D,1G,1H,EI,G2,LU,N5,SY,X5,")]
    public class X12_ID_128_REF_OrderingProviderSecondaryIdentification_2420E
    {
    }
    
    [Serializable()]
    [EdiCodes(",IC,")]
    public class X12_ID_366_PER_OrderingProviderContactInformation_2420E
    {
    }
    
    [Serializable()]
    [Segment("PER", typeof(X12_ID_366_PER_OrderingProviderContactInformation_2420E))]
    public class PER_OrderingProviderContactInformation_2420E
    {
        
        [Required]
        [DataElement("366", typeof(X12_ID_366_PER_OrderingProviderContactInformation_2420E))]
        [Pos(1)]
        public string ContactFunctionCode_01 { get; set; }
        [Required]
        [StringLength(1, 60)]
        [DataElement("", typeof(X12_AN))]
        [Pos(2)]
        public string OrderingProviderContactName_02 { get; set; }
        [Required]
        [DataElement("365", typeof(X12_ID_365_PER_OrderingProviderContactInformation_2420E))]
        [Pos(3)]
        public string CommunicationNumberQualifier_03 { get; set; }
        [Required]
        [StringLength(1, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string CommunicationNumber_04 { get; set; }
        [DataElement("365", typeof(X12_ID_365_PER_OrderingProviderContactInformation_2420E))]
        [Pos(5)]
        public string CommunicationNumberQualifier_05 { get; set; }
        [StringLength(1, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(6)]
        public string CommunicationNumber_06 { get; set; }
        [DataElement("365", typeof(X12_ID_365_PER_OrderingProviderContactInformation_2420E))]
        [Pos(7)]
        public string CommunicationNumberQualifier_07 { get; set; }
        [StringLength(1, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(8)]
        public string CommunicationNumber_08 { get; set; }
        [StringLength(1, 20)]
        [DataElement("", typeof(X12_AN))]
        [Pos(9)]
        public string PER_09 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",EM,FX,TE,")]
    public class X12_ID_365_PER_OrderingProviderContactInformation_2420E
    {
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_REF_OrderingProviderSecondaryIdentification_2420E))]
    public class REF_OrderingProviderSecondaryIdentification_2420E
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_REF_OrderingProviderSecondaryIdentification_2420E))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(2)]
        public string OrderingProviderSecondaryIdentifier_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string REF_03 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string REF_04 { get; set; }
    }
    
    [Serializable()]
    [Segment("N4")]
    public class N4_OrderingProviderCityStateZIPCode_2420E
    {
        
        [Required]
        [StringLength(2, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(1)]
        public string OrderingProviderCityName_01 { get; set; }
        [Required]
        [StringLength(2, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(2)]
        public string OrderingProviderStateCode_02 { get; set; }
        [Required]
        [StringLength(3, 15)]
        [DataElement("", typeof(X12_ID))]
        [Pos(3)]
        public string OrderingProviderPostalZoneOrZIPCode_03 { get; set; }
        [StringLength(2, 3)]
        [DataElement("", typeof(X12_ID))]
        [Pos(4)]
        public string CountryCode_04 { get; set; }
        [StringLength(1, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(5)]
        public string N4_05 { get; set; }
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(6)]
        public string N4_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("N3")]
    public class N3_OrderingProviderAddress_2420E
    {
        
        [Required]
        [StringLength(1, 55)]
        [DataElement("", typeof(X12_AN))]
        [Pos(1)]
        public string OrderingProviderAddressLine_01 { get; set; }
        [StringLength(1, 55)]
        [DataElement("", typeof(X12_AN))]
        [Pos(2)]
        public string OrderingProviderAddressLine_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_NM1_OrderingProviderName_2420E), typeof(X12_ID_1065_NM1_OrderingProviderName_2420E))]
    public class NM1_OrderingProviderName_2420E
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98_NM1_OrderingProviderName_2420E))]
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        [Required]
        [DataElement("1065", typeof(X12_ID_1065_NM1_OrderingProviderName_2420E))]
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        [Required]
        [StringLength(1, 35)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string OrderingProviderLastName_03 { get; set; }
        [Required]
        [StringLength(1, 25)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string OrderingProviderFirstName_04 { get; set; }
        [StringLength(1, 25)]
        [DataElement("", typeof(X12_AN))]
        [Pos(5)]
        public string OrderingProviderMiddleName_05 { get; set; }
        [StringLength(1, 10)]
        [DataElement("", typeof(X12_AN))]
        [Pos(6)]
        public string NM1_06 { get; set; }
        [StringLength(1, 10)]
        [DataElement("", typeof(X12_AN))]
        [Pos(7)]
        public string OrderingProviderNameSuffix_07 { get; set; }
        [DataElement("66", typeof(X12_ID_66_NM1_OrderingProviderName_2420E))]
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        [StringLength(2, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(9)]
        public string OrderingProviderIdentifier_09 { get; set; }
        [StringLength(2, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(10)]
        public string NM1_10 { get; set; }
        [StringLength(2, 3)]
        [DataElement("", typeof(X12_ID))]
        [Pos(11)]
        public string NM1_11 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",24,34,XX,")]
    public class X12_ID_66_NM1_OrderingProviderName_2420E
    {
    }
    
    [Serializable()]
    [Group("NM1")]
    public class Loop_2420D
    {
        
        [Required]
        [Pos(1)]
        public NM1_SupervisingProviderName_2420D NM1_SupervisingProviderName_2420D { get; set; }
        [ListCount(5)]
        [Pos(2)]
        public List<REF_SupervisingProviderSecondaryIdentification_2420D> REF_SupervisingProviderSecondaryIdentification_2420D { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",DQ,")]
    public class X12_ID_98_NM1_SupervisingProviderName_2420D
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,")]
    public class X12_ID_1065_NM1_SupervisingProviderName_2420D
    {
    }
    
    [Serializable()]
    [EdiCodes(",0B,1B,1C,1D,1G,1H,EI,G2,LU,N5,SY,X5,")]
    public class X12_ID_128_REF_SupervisingProviderSecondaryIdentification_2420D
    {
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_REF_SupervisingProviderSecondaryIdentification_2420D))]
    public class REF_SupervisingProviderSecondaryIdentification_2420D
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_REF_SupervisingProviderSecondaryIdentification_2420D))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(2)]
        public string SupervisingProviderSecondaryIdentifier_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string REF_03 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string REF_04 { get; set; }
    }
    
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_NM1_SupervisingProviderName_2420D), typeof(X12_ID_1065_NM1_SupervisingProviderName_2420D))]
    public class NM1_SupervisingProviderName_2420D
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98_NM1_SupervisingProviderName_2420D))]
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        [Required]
        [DataElement("1065", typeof(X12_ID_1065_NM1_SupervisingProviderName_2420D))]
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        [Required]
        [StringLength(1, 35)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string SupervisingProviderLastName_03 { get; set; }
        [Required]
        [StringLength(1, 25)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string SupervisingProviderFirstName_04 { get; set; }
        [StringLength(1, 25)]
        [DataElement("", typeof(X12_AN))]
        [Pos(5)]
        public string SupervisingProviderMiddleName_05 { get; set; }
        [StringLength(1, 10)]
        [DataElement("", typeof(X12_AN))]
        [Pos(6)]
        public string NM1_06 { get; set; }
        [StringLength(1, 10)]
        [DataElement("", typeof(X12_AN))]
        [Pos(7)]
        public string SupervisingProviderNameSuffix_07 { get; set; }
        [DataElement("66", typeof(X12_ID_66_NM1_SupervisingProviderName_2420D))]
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        [StringLength(2, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(9)]
        public string SupervisingProviderIdentifier_09 { get; set; }
        [StringLength(2, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(10)]
        public string NM1_10 { get; set; }
        [StringLength(2, 3)]
        [DataElement("", typeof(X12_ID))]
        [Pos(11)]
        public string NM1_11 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",24,34,XX,")]
    public class X12_ID_66_NM1_SupervisingProviderName_2420D
    {
    }
    
    [Serializable()]
    [Group("NM1")]
    public class Loop_2420C
    {
        
        [Required]
        [Pos(1)]
        public NM1_ServiceFacilityLocation_2420C NM1_ServiceFacilityLocation_2420C { get; set; }
        [Required]
        [Pos(2)]
        public N3_ServiceFacilityLocationAddress_2420C N3_ServiceFacilityLocationAddress_2420C { get; set; }
        [Required]
        [Pos(3)]
        public N4_ServiceFacilityLocationCityStateZIP_2420C N4_ServiceFacilityLocationCityStateZIP_2420C { get; set; }
        [ListCount(5)]
        [Pos(4)]
        public List<REF_ServiceFacilityLocationSecondaryIdentification_2420C> REF_ServiceFacilityLocationSecondaryIdentification_2420C { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",77,FA,LI,TL,")]
    public class X12_ID_98_NM1_ServiceFacilityLocation_2420C
    {
    }
    
    [Serializable()]
    [EdiCodes(",2,")]
    public class X12_ID_1065_NM1_ServiceFacilityLocation_2420C
    {
    }
    
    [Serializable()]
    [EdiCodes(",0B,1A,1B,1C,1D,1G,1H,G2,LU,N5,TJ,X4,X5,")]
    public class X12_ID_128_REF_ServiceFacilityLocationSecondaryIdentification_2420C
    {
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_REF_ServiceFacilityLocationSecondaryIdentification_2420C))]
    public class REF_ServiceFacilityLocationSecondaryIdentification_2420C
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_REF_ServiceFacilityLocationSecondaryIdentification_2420C))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(2)]
        public string ServiceFacilityLocationSecondaryIdentifier_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string REF_03 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string REF_04 { get; set; }
    }
    
    [Serializable()]
    [Segment("N4")]
    public class N4_ServiceFacilityLocationCityStateZIP_2420C
    {
        
        [Required]
        [StringLength(2, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(1)]
        public string LaboratoryOrFacilityCityName_01 { get; set; }
        [Required]
        [StringLength(2, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(2)]
        public string LaboratoryOrFacilityStateOrProvinceCode_02 { get; set; }
        [Required]
        [StringLength(3, 15)]
        [DataElement("", typeof(X12_ID))]
        [Pos(3)]
        public string LaboratoryOrFacilityPostalZoneOrZIPCode_03 { get; set; }
        [StringLength(2, 3)]
        [DataElement("", typeof(X12_ID))]
        [Pos(4)]
        public string CountryCode_04 { get; set; }
        [StringLength(1, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(5)]
        public string N4_05 { get; set; }
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(6)]
        public string N4_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("N3")]
    public class N3_ServiceFacilityLocationAddress_2420C
    {
        
        [Required]
        [StringLength(1, 55)]
        [DataElement("", typeof(X12_AN))]
        [Pos(1)]
        public string LaboratoryOrFacilityAddressLine_01 { get; set; }
        [StringLength(1, 55)]
        [DataElement("", typeof(X12_AN))]
        [Pos(2)]
        public string LaboratoryOrFacilityAddressLine_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_NM1_ServiceFacilityLocation_2420C), typeof(X12_ID_1065_NM1_ServiceFacilityLocation_2420C))]
    public class NM1_ServiceFacilityLocation_2420C
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98_NM1_ServiceFacilityLocation_2420C))]
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        [Required]
        [DataElement("1065", typeof(X12_ID_1065_NM1_ServiceFacilityLocation_2420C))]
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        [StringLength(1, 35)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string LaboratoryOrFacilityName_03 { get; set; }
        [StringLength(1, 25)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string NM1_04 { get; set; }
        [StringLength(1, 25)]
        [DataElement("", typeof(X12_AN))]
        [Pos(5)]
        public string NM1_05 { get; set; }
        [StringLength(1, 10)]
        [DataElement("", typeof(X12_AN))]
        [Pos(6)]
        public string NM1_06 { get; set; }
        [StringLength(1, 10)]
        [DataElement("", typeof(X12_AN))]
        [Pos(7)]
        public string NM1_07 { get; set; }
        [DataElement("66", typeof(X12_ID_66_NM1_ServiceFacilityLocation_2420C))]
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        [StringLength(2, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(9)]
        public string LaboratoryOrFacilityPrimaryIdentifier_09 { get; set; }
        [StringLength(2, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(10)]
        public string NM1_10 { get; set; }
        [StringLength(2, 3)]
        [DataElement("", typeof(X12_ID))]
        [Pos(11)]
        public string NM1_11 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",24,34,XX,")]
    public class X12_ID_66_NM1_ServiceFacilityLocation_2420C
    {
    }
    
    [Serializable()]
    [Group("NM1")]
    public class Loop_2420B
    {
        
        [Required]
        [Pos(1)]
        public NM1_PurchasedServiceProviderName_2420B NM1_PurchasedServiceProviderName_2420B { get; set; }
        [ListCount(5)]
        [Pos(2)]
        public List<REF_PurchasedServiceProviderSecondaryIdentification_2420B> REF_PurchasedServiceProviderSecondaryIdentification_2420B { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",QB,")]
    public class X12_ID_98_NM1_PurchasedServiceProviderName_2420B
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,")]
    public class X12_ID_1065_NM1_PurchasedServiceProviderName_2420B
    {
    }
    
    [Serializable()]
    [EdiCodes(",0B,1A,1B,1C,1D,1G,1H,EI,G2,LU,N5,SY,U3,X5,")]
    public class X12_ID_128_REF_PurchasedServiceProviderSecondaryIdentification_2420B
    {
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_REF_PurchasedServiceProviderSecondaryIdentification_2420B))]
    public class REF_PurchasedServiceProviderSecondaryIdentification_2420B
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_REF_PurchasedServiceProviderSecondaryIdentification_2420B))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(2)]
        public string PurchasedServiceProviderSecondaryIdentifier_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string REF_03 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string REF_04 { get; set; }
    }
    
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_NM1_PurchasedServiceProviderName_2420B), typeof(X12_ID_1065_NM1_PurchasedServiceProviderName_2420B))]
    public class NM1_PurchasedServiceProviderName_2420B
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98_NM1_PurchasedServiceProviderName_2420B))]
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        [Required]
        [DataElement("1065", typeof(X12_ID_1065_NM1_PurchasedServiceProviderName_2420B))]
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        [StringLength(1, 35)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string NM1_03 { get; set; }
        [StringLength(1, 25)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string NM1_04 { get; set; }
        [StringLength(1, 25)]
        [DataElement("", typeof(X12_AN))]
        [Pos(5)]
        public string NM1_05 { get; set; }
        [StringLength(1, 10)]
        [DataElement("", typeof(X12_AN))]
        [Pos(6)]
        public string NM1_06 { get; set; }
        [StringLength(1, 10)]
        [DataElement("", typeof(X12_AN))]
        [Pos(7)]
        public string NM1_07 { get; set; }
        [DataElement("66", typeof(X12_ID_66_NM1_PurchasedServiceProviderName_2420B))]
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        [StringLength(2, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(9)]
        public string PurchasedServiceProviderIdentifier_09 { get; set; }
        [StringLength(2, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(10)]
        public string NM1_10 { get; set; }
        [StringLength(2, 3)]
        [DataElement("", typeof(X12_ID))]
        [Pos(11)]
        public string NM1_11 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",24,34,XX,")]
    public class X12_ID_66_NM1_PurchasedServiceProviderName_2420B
    {
    }
    
    [Serializable()]
    [Group("NM1")]
    public class Loop_2420A
    {
        
        [Required]
        [Pos(1)]
        public NM1_RenderingProviderName_2420A NM1_RenderingProviderName_2420A { get; set; }
        [Pos(2)]
        public PRV_RenderingProviderSpecialtyInformation_2420A PRV_RenderingProviderSpecialtyInformation_2420A { get; set; }
        [ListCount(5)]
        [Pos(3)]
        public List<REF_RenderingProviderSecondaryIdentification_2420A> REF_RenderingProviderSecondaryIdentification_2420A { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",82,")]
    public class X12_ID_98_NM1_RenderingProviderName_2420A
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,")]
    public class X12_ID_1065_NM1_RenderingProviderName_2420A
    {
    }
    
    [Serializable()]
    [EdiCodes(",PE,")]
    public class X12_ID_1221_PRV_RenderingProviderSpecialtyInformation_2420A
    {
    }
    
    [Serializable()]
    [EdiCodes(",ZZ,")]
    public class X12_ID_128_PRV_RenderingProviderSpecialtyInformation_2420A
    {
    }
    
    [Serializable()]
    [EdiCodes(",0B,1B,1C,1D,1G,1H,EI,G2,LU,N5,SY,X5,")]
    public class X12_ID_128_REF_RenderingProviderSecondaryIdentification_2420A
    {
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_REF_RenderingProviderSecondaryIdentification_2420A))]
    public class REF_RenderingProviderSecondaryIdentification_2420A
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_REF_RenderingProviderSecondaryIdentification_2420A))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(2)]
        public string RenderingProviderSecondaryIdentifier_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string REF_03 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string REF_04 { get; set; }
    }
    
    [Serializable()]
    [Segment("PRV", typeof(X12_ID_1221_PRV_RenderingProviderSpecialtyInformation_2420A), typeof(X12_ID_128_PRV_RenderingProviderSpecialtyInformation_2420A))]
    public class PRV_RenderingProviderSpecialtyInformation_2420A
    {
        
        [Required]
        [DataElement("1221", typeof(X12_ID_1221_PRV_RenderingProviderSpecialtyInformation_2420A))]
        [Pos(1)]
        public string ProviderCode_01 { get; set; }
        [Required]
        [DataElement("128", typeof(X12_ID_128_PRV_RenderingProviderSpecialtyInformation_2420A))]
        [Pos(2)]
        public string ReferenceIdentificationQualifier_02 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string ProviderTaxonomyCode_03 { get; set; }
        [StringLength(2, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(4)]
        public string PRV_04 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_AN))]
        [Pos(5)]
        public string PRV_05 { get; set; }
        [StringLength(3, 3)]
        [DataElement("", typeof(X12_ID))]
        [Pos(6)]
        public string PRV_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_NM1_RenderingProviderName_2420A), typeof(X12_ID_1065_NM1_RenderingProviderName_2420A))]
    public class NM1_RenderingProviderName_2420A
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98_NM1_RenderingProviderName_2420A))]
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        [Required]
        [DataElement("1065", typeof(X12_ID_1065_NM1_RenderingProviderName_2420A))]
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        [Required]
        [StringLength(1, 35)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string RenderingProviderLastOrOrganizationName_03 { get; set; }
        [StringLength(1, 25)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string RenderingProviderFirstName_04 { get; set; }
        [StringLength(1, 25)]
        [DataElement("", typeof(X12_AN))]
        [Pos(5)]
        public string RenderingProviderMiddleName_05 { get; set; }
        [StringLength(1, 10)]
        [DataElement("", typeof(X12_AN))]
        [Pos(6)]
        public string NM1_06 { get; set; }
        [StringLength(1, 10)]
        [DataElement("", typeof(X12_AN))]
        [Pos(7)]
        public string RenderingProviderNameSuffix_07 { get; set; }
        [Required]
        [DataElement("66", typeof(X12_ID_66_NM1_RenderingProviderName_2420A))]
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        [Required]
        [StringLength(2, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(9)]
        public string RenderingProviderIdentifier_09 { get; set; }
        [StringLength(2, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(10)]
        public string NM1_10 { get; set; }
        [StringLength(2, 3)]
        [DataElement("", typeof(X12_ID))]
        [Pos(11)]
        public string NM1_11 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",24,34,XX,")]
    public class X12_ID_66_NM1_RenderingProviderName_2420A
    {
    }
    
    [Serializable()]
    [Group("LIN")]
    public class Loop_2410
    {
        
        [Required]
        [Pos(1)]
        public LIN_DrugIdentification_2410 LIN_DrugIdentification_2410 { get; set; }
        [Pos(2)]
        public CTP_DrugPricing_2410 CTP_DrugPricing_2410 { get; set; }
        [Pos(3)]
        public REF_PrescriptionNumber_2410 REF_PrescriptionNumber_2410 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",N4,")]
    public class X12_ID_235_LIN_DrugIdentification_2410
    {
    }
    
    [Serializable()]
    [EdiCodes(",XZ,")]
    public class X12_ID_128_REF_PrescriptionNumber_2410
    {
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_REF_PrescriptionNumber_2410))]
    public class REF_PrescriptionNumber_2410
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_REF_PrescriptionNumber_2410))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(2)]
        public string PrescriptionNumber_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string REF_03 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string REF_04 { get; set; }
    }
    
    [Serializable()]
    [Segment("CTP")]
    public class CTP_DrugPricing_2410
    {
        
        [StringLength(2, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(1)]
        public string CTP_01 { get; set; }
        [StringLength(3, 3)]
        [DataElement("", typeof(X12_ID))]
        [Pos(2)]
        public string CTP_02 { get; set; }
        [Required]
        [DataElement("", typeof(X12_R))]
        [Pos(3)]
        public string DrugUnitPrice_03 { get; set; }
        [Required]
        [DataElement("", typeof(X12_R))]
        [Pos(4)]
        public string NationalDrugUnitCount_04 { get; set; }
        [Required]
        [Pos(5)]
        public C001_1149128115 C001_1149128115 { get; set; }
        [StringLength(3, 3)]
        [DataElement("", typeof(X12_ID))]
        [Pos(6)]
        public string CTP_06 { get; set; }
        [DataElement("", typeof(X12_R))]
        [Pos(7)]
        public string CTP_07 { get; set; }
        [DataElement("", typeof(X12_R))]
        [Pos(8)]
        public string CTP_08 { get; set; }
        [StringLength(2, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(9)]
        public string CTP_09 { get; set; }
        [StringLength(1, 10)]
        [DataElement("", typeof(X12_AN))]
        [Pos(10)]
        public string CTP_10 { get; set; }
        [DataElement("", typeof(X12_N0))]
        [Pos(11)]
        public string CTP_11 { get; set; }
    }
    
    [Serializable()]
    [Composite("C001_1149128115")]
    public class C001_1149128115
    {
        
        [Required]
        [DataElement("355", typeof(X12_ID_355_C001_1149128115))]
        [Pos(1)]
        public string UnitOrBasisForMeasurementCode_01 { get; set; }
        [DataElement("", typeof(X12_R))]
        [Pos(2)]
        public string CTP_02 { get; set; }
        [DataElement("", typeof(X12_R))]
        [Pos(3)]
        public string CTP_03 { get; set; }
        [StringLength(2, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(4)]
        public string CTP_04 { get; set; }
        [DataElement("", typeof(X12_R))]
        [Pos(5)]
        public string CTP_05 { get; set; }
        [DataElement("", typeof(X12_R))]
        [Pos(6)]
        public string CTP_06 { get; set; }
        [StringLength(2, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(7)]
        public string CTP_07 { get; set; }
        [DataElement("", typeof(X12_R))]
        [Pos(8)]
        public string CTP_08 { get; set; }
        [DataElement("", typeof(X12_R))]
        [Pos(9)]
        public string CTP_09 { get; set; }
        [StringLength(2, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(10)]
        public string CTP_10 { get; set; }
        [DataElement("", typeof(X12_R))]
        [Pos(11)]
        public string CTP_11 { get; set; }
        [DataElement("", typeof(X12_R))]
        [Pos(12)]
        public string CTP_12 { get; set; }
        [StringLength(2, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(13)]
        public string CTP_13 { get; set; }
        [DataElement("", typeof(X12_R))]
        [Pos(14)]
        public string CTP_14 { get; set; }
        [DataElement("", typeof(X12_R))]
        [Pos(15)]
        public string CTP_15 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",F2,GR,ML,UN,")]
    public class X12_ID_355_C001_1149128115
    {
    }
    
    [Serializable()]
    [Segment("LIN")]
    public class LIN_DrugIdentification_2410
    {
        
        [StringLength(1, 20)]
        [DataElement("", typeof(X12_AN))]
        [Pos(1)]
        public string LIN_01 { get; set; }
        [Required]
        [DataElement("235", typeof(X12_ID_235_LIN_DrugIdentification_2410))]
        [Pos(2)]
        public string ProductOrServiceIDQualifier_02 { get; set; }
        [Required]
        [StringLength(1, 48)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string NationalDrugCode_03 { get; set; }
        [StringLength(2, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(4)]
        public string LIN_04 { get; set; }
        [StringLength(1, 48)]
        [DataElement("", typeof(X12_AN))]
        [Pos(5)]
        public string LIN_05 { get; set; }
        [StringLength(2, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(6)]
        public string LIN_06 { get; set; }
        [StringLength(1, 48)]
        [DataElement("", typeof(X12_AN))]
        [Pos(7)]
        public string LIN_07 { get; set; }
        [StringLength(2, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(8)]
        public string LIN_08 { get; set; }
        [StringLength(1, 48)]
        [DataElement("", typeof(X12_AN))]
        [Pos(9)]
        public string LIN_09 { get; set; }
        [StringLength(2, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(10)]
        public string LIN_10 { get; set; }
        [StringLength(1, 48)]
        [DataElement("", typeof(X12_AN))]
        [Pos(11)]
        public string LIN_11 { get; set; }
        [StringLength(2, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(12)]
        public string LIN_12 { get; set; }
        [StringLength(1, 48)]
        [DataElement("", typeof(X12_AN))]
        [Pos(13)]
        public string LIN_13 { get; set; }
        [StringLength(2, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(14)]
        public string LIN_14 { get; set; }
        [StringLength(1, 48)]
        [DataElement("", typeof(X12_AN))]
        [Pos(15)]
        public string LIN_15 { get; set; }
        [StringLength(2, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(16)]
        public string LIN_16 { get; set; }
        [StringLength(1, 48)]
        [DataElement("", typeof(X12_AN))]
        [Pos(17)]
        public string LIN_17 { get; set; }
        [StringLength(2, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(18)]
        public string LIN_18 { get; set; }
        [StringLength(1, 48)]
        [DataElement("", typeof(X12_AN))]
        [Pos(19)]
        public string LIN_19 { get; set; }
        [StringLength(2, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(20)]
        public string LIN_20 { get; set; }
        [StringLength(1, 48)]
        [DataElement("", typeof(X12_AN))]
        [Pos(21)]
        public string LIN_21 { get; set; }
        [StringLength(2, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(22)]
        public string LIN_22 { get; set; }
        [StringLength(1, 48)]
        [DataElement("", typeof(X12_AN))]
        [Pos(23)]
        public string LIN_23 { get; set; }
        [StringLength(2, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(24)]
        public string LIN_24 { get; set; }
        [StringLength(1, 48)]
        [DataElement("", typeof(X12_AN))]
        [Pos(25)]
        public string LIN_25 { get; set; }
        [StringLength(2, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(26)]
        public string LIN_26 { get; set; }
        [StringLength(1, 48)]
        [DataElement("", typeof(X12_AN))]
        [Pos(27)]
        public string LIN_27 { get; set; }
        [StringLength(2, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(28)]
        public string LIN_28 { get; set; }
        [StringLength(1, 48)]
        [DataElement("", typeof(X12_AN))]
        [Pos(29)]
        public string LIN_29 { get; set; }
        [StringLength(2, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(30)]
        public string LIN_30 { get; set; }
        [StringLength(1, 48)]
        [DataElement("", typeof(X12_AN))]
        [Pos(31)]
        public string LIN_31 { get; set; }
    }
    
    [Serializable()]
    [Segment("HCP", typeof(X12_ID_1473_HCP_LinePricingRepricingInformation_2400))]
    public class HCP_LinePricingRepricingInformation_2400
    {
        
        [Required]
        [DataElement("1473", typeof(X12_ID_1473_HCP_LinePricingRepricingInformation_2400))]
        [Pos(1)]
        public string PricingMethodology_01 { get; set; }
        [Required]
        [DataElement("", typeof(X12_R))]
        [Pos(2)]
        public string RepricedAllowedAmount_02 { get; set; }
        [DataElement("", typeof(X12_R))]
        [Pos(3)]
        public string RepricedSavingAmount_03 { get; set; }
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string RepricingOrganizationIdentifier_04 { get; set; }
        [DataElement("", typeof(X12_R))]
        [Pos(5)]
        public string RepricingPerDiemOrFlatRateAmount_05 { get; set; }
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(6)]
        public string RepricedApprovedAmbulatoryPatientGroupCode_06 { get; set; }
        [DataElement("", typeof(X12_R))]
        [Pos(7)]
        public string RepricedApprovedAmbulatoryPatientGroupAmount_07 { get; set; }
        [StringLength(1, 48)]
        [DataElement("", typeof(X12_AN))]
        [Pos(8)]
        public string HCP_08 { get; set; }
        [DataElement("235", typeof(X12_ID_235_HCP_LinePricingRepricingInformation_2400))]
        [Pos(9)]
        public string ProductOrServiceIDQualifier_09 { get; set; }
        [StringLength(1, 48)]
        [DataElement("", typeof(X12_AN))]
        [Pos(10)]
        public string ProcedureCode_10 { get; set; }
        [DataElement("355", typeof(X12_ID_355_HCP_LinePricingRepricingInformation_2400))]
        [Pos(11)]
        public string UnitOrBasisForMeasurementCode_11 { get; set; }
        [DataElement("", typeof(X12_R))]
        [Pos(12)]
        public string RepricedApprovedServiceUnitCount_12 { get; set; }
        [DataElement("901", typeof(X12_ID_901_HCP_LinePricingRepricingInformation_2400))]
        [Pos(13)]
        public string RejectReasonCode_13 { get; set; }
        [DataElement("1526", typeof(X12_ID_1526_HCP_LinePricingRepricingInformation_2400))]
        [Pos(14)]
        public string PolicyComplianceCode_14 { get; set; }
        [DataElement("1527", typeof(X12_ID_1527_HCP_LinePricingRepricingInformation_2400))]
        [Pos(15)]
        public string ExceptionCode_15 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",HC,IV,ZZ,")]
    public class X12_ID_235_HCP_LinePricingRepricingInformation_2400
    {
    }
    
    [Serializable()]
    [EdiCodes(",DA,UN,")]
    public class X12_ID_355_HCP_LinePricingRepricingInformation_2400
    {
    }
    
    [Serializable()]
    [EdiCodes(",T1,T2,T3,T4,T5,T6,")]
    public class X12_ID_901_HCP_LinePricingRepricingInformation_2400
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,3,4,5,")]
    public class X12_ID_1526_HCP_LinePricingRepricingInformation_2400
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,3,4,5,6,")]
    public class X12_ID_1527_HCP_LinePricingRepricingInformation_2400
    {
    }
    
    [Serializable()]
    [Segment("HSD", typeof(X12_ID_673_HSD_HealthCareServicesDelivery_2400))]
    public class HSD_HealthCareServicesDelivery_2400
    {
        
        [DataElement("673", typeof(X12_ID_673_HSD_HealthCareServicesDelivery_2400))]
        [Pos(1)]
        public string Visits_01 { get; set; }
        [DataElement("", typeof(X12_R))]
        [Pos(2)]
        public string NumberOfVisits_02 { get; set; }
        [DataElement("355", typeof(X12_ID_355_HSD_HealthCareServicesDelivery_2400))]
        [Pos(3)]
        public string FrequencyPeriod_03 { get; set; }
        [DataElement("", typeof(X12_R))]
        [Pos(4)]
        public string FrequencyCount_04 { get; set; }
        [DataElement("615", typeof(X12_ID_615_HSD_HealthCareServicesDelivery_2400))]
        [Pos(5)]
        public string DurationOfVisitsUnits_05 { get; set; }
        [DataElement("", typeof(X12_N0))]
        [Pos(6)]
        public string DurationOfVisitsNumberOfUnits_06 { get; set; }
        [DataElement("678", typeof(X12_ID_678_HSD_HealthCareServicesDelivery_2400))]
        [Pos(7)]
        public string ShipDeliveryOrCalendarPatternCode_07 { get; set; }
        [DataElement("679", typeof(X12_ID_679_HSD_HealthCareServicesDelivery_2400))]
        [Pos(8)]
        public string DeliveryPatternTimeCode_08 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",DA,MO,Q1,WK,")]
    public class X12_ID_355_HSD_HealthCareServicesDelivery_2400
    {
    }
    
    [Serializable()]
    [EdiCodes(",7,34,35,")]
    public class X12_ID_615_HSD_HealthCareServicesDelivery_2400
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,3,4,5,6,7,A,B,C,D,E,F,G,H,J,K,L,N,O,SA,SB,SC,SD,SG,SL,SP,SX,SY,SZ,W,")]
    public class X12_ID_678_HSD_HealthCareServicesDelivery_2400
    {
    }
    
    [Serializable()]
    [EdiCodes(",D,E,F,")]
    public class X12_ID_679_HSD_HealthCareServicesDelivery_2400
    {
    }
    
    [Serializable()]
    [Segment("PS1")]
    public class PS1_PurchasedServiceInformation_2400
    {
        
        [Required]
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(1)]
        public string PurchasedServiceProviderIdentifier_01 { get; set; }
        [Required]
        [DataElement("", typeof(X12_R))]
        [Pos(2)]
        public string PurchasedServiceChargeAmount_02 { get; set; }
        [StringLength(2, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(3)]
        public string PS1_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("NTE", typeof(X12_ID_363_NTE_LineNote_2400))]
    public class NTE_LineNote_2400
    {
        
        [Required]
        [DataElement("363", typeof(X12_ID_363_NTE_LineNote_2400))]
        [Pos(1)]
        public string NoteReferenceCode_01 { get; set; }
        [Required]
        [StringLength(1, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(2)]
        public string LineNoteText_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("K3")]
    public class K3_FileInformation_2400
    {
        
        [Required]
        [StringLength(1, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(1)]
        public string FixedFormatInformation_01 { get; set; }
        [StringLength(1, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(2)]
        public string K3_02 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string K3_03 { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_AMT_2400
    {
        
        [Pos(1)]
        public AMT_SalesTaxAmount_2400 AMT_SalesTaxAmount_2400 { get; set; }
        [Pos(2)]
        public AMT_ApprovedAmount_2400 AMT_ApprovedAmount_2400 { get; set; }
        [Pos(3)]
        public AMT_PostageClaimedAmount_2400 AMT_PostageClaimedAmount_2400 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",T,")]
    public class X12_ID_522_AMT_SalesTaxAmount_2400
    {
    }
    
    [Serializable()]
    [EdiCodes(",AAE,")]
    public class X12_ID_522_AMT_ApprovedAmount_2400
    {
    }
    
    [Serializable()]
    [EdiCodes(",F4,")]
    public class X12_ID_522_AMT_PostageClaimedAmount_2400
    {
    }
    
    [Serializable()]
    [Segment("AMT", typeof(X12_ID_522_AMT_PostageClaimedAmount_2400))]
    public class AMT_PostageClaimedAmount_2400
    {
        
        [Required]
        [DataElement("522", typeof(X12_ID_522_AMT_PostageClaimedAmount_2400))]
        [Pos(1)]
        public string AmountQualifierCode_01 { get; set; }
        [Required]
        [DataElement("", typeof(X12_R))]
        [Pos(2)]
        public string PostageClaimedAmount_02 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_ID))]
        [Pos(3)]
        public string AMT_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("AMT", typeof(X12_ID_522_AMT_ApprovedAmount_2400))]
    public class AMT_ApprovedAmount_2400
    {
        
        [Required]
        [DataElement("522", typeof(X12_ID_522_AMT_ApprovedAmount_2400))]
        [Pos(1)]
        public string AmountQualifierCode_01 { get; set; }
        [Required]
        [DataElement("", typeof(X12_R))]
        [Pos(2)]
        public string ApprovedAmount_02 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_ID))]
        [Pos(3)]
        public string AMT_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("AMT", typeof(X12_ID_522_AMT_SalesTaxAmount_2400))]
    public class AMT_SalesTaxAmount_2400
    {
        
        [Required]
        [DataElement("522", typeof(X12_ID_522_AMT_SalesTaxAmount_2400))]
        [Pos(1)]
        public string AmountQualifierCode_01 { get; set; }
        [Required]
        [DataElement("", typeof(X12_R))]
        [Pos(2)]
        public string SalesTaxAmount_02 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_ID))]
        [Pos(3)]
        public string AMT_03 { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_REF_2400
    {
        
        [Pos(1)]
        public REF_RepricedLineItemReferenceNumber_2400 REF_RepricedLineItemReferenceNumber_2400 { get; set; }
        [Pos(2)]
        public REF_AdjustedRepricedLineItemReferenceNumber_2400 REF_AdjustedRepricedLineItemReferenceNumber_2400 { get; set; }
        [ListCount(2)]
        [Pos(3)]
        public List<REF_PriorAuthorizationOrReferralNumber_2400> REF_PriorAuthorizationOrReferralNumber_2400 { get; set; }
        [Pos(4)]
        public REF_LineItemControlNumber_2400 REF_LineItemControlNumber_2400 { get; set; }
        [Pos(5)]
        public REF_MammographyCertificationNumber_2400 REF_MammographyCertificationNumber_2400 { get; set; }
        [Pos(6)]
        public REF_ClinicalLaboratoryImprovementAmendmentCLIAIdentification_2400 REF_ClinicalLaboratoryImprovementAmendmentCLIAIdentification_2400 { get; set; }
        [Pos(7)]
        public REF_ReferringClinicalLaboratoryImprovementAmendmentCLIAFacilityIdentification_2400 REF_ReferringClinicalLaboratoryImprovementAmendmentCLIAFacilityIdentification_2400 { get; set; }
        [Pos(8)]
        public REF_ImmunizationBatchNumber_2400 REF_ImmunizationBatchNumber_2400 { get; set; }
        [ListCount(4)]
        [Pos(9)]
        public List<REF_AmbulatoryPatientGroupAPG_2400> REF_AmbulatoryPatientGroupAPG_2400 { get; set; }
        [Pos(10)]
        public REF_OxygenFlowRate_2400 REF_OxygenFlowRate_2400 { get; set; }
        [Pos(11)]
        public REF_UniversalProductNumberUPN_2400 REF_UniversalProductNumberUPN_2400 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",9B,")]
    public class X12_ID_128_REF_RepricedLineItemReferenceNumber_2400
    {
    }
    
    [Serializable()]
    [EdiCodes(",9D,")]
    public class X12_ID_128_REF_AdjustedRepricedLineItemReferenceNumber_2400
    {
    }
    
    [Serializable()]
    [EdiCodes(",9F,G1,")]
    public class X12_ID_128_REF_PriorAuthorizationOrReferralNumber_2400
    {
    }
    
    [Serializable()]
    [EdiCodes(",6R,")]
    public class X12_ID_128_REF_LineItemControlNumber_2400
    {
    }
    
    [Serializable()]
    [EdiCodes(",EW,")]
    public class X12_ID_128_REF_MammographyCertificationNumber_2400
    {
    }
    
    [Serializable()]
    [EdiCodes(",X4,")]
    public class X12_ID_128_REF_ClinicalLaboratoryImprovementAmendmentCLIAIdentification_2400
    {
    }
    
    [Serializable()]
    [EdiCodes(",F4,")]
    public class X12_ID_128_REF_ReferringClinicalLaboratoryImprovementAmendmentCLIAFacilityIdentification_2400
    {
    }
    
    [Serializable()]
    [EdiCodes(",BT,")]
    public class X12_ID_128_REF_ImmunizationBatchNumber_2400
    {
    }
    
    [Serializable()]
    [EdiCodes(",1S,")]
    public class X12_ID_128_REF_AmbulatoryPatientGroupAPG_2400
    {
    }
    
    [Serializable()]
    [EdiCodes(",TP,")]
    public class X12_ID_128_REF_OxygenFlowRate_2400
    {
    }
    
    [Serializable()]
    [EdiCodes(",OZ,VP,")]
    public class X12_ID_128_REF_UniversalProductNumberUPN_2400
    {
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_REF_UniversalProductNumberUPN_2400))]
    public class REF_UniversalProductNumberUPN_2400
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_REF_UniversalProductNumberUPN_2400))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(2)]
        public string UniversalProductNumber_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string REF_03 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string REF_04 { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_REF_OxygenFlowRate_2400))]
    public class REF_OxygenFlowRate_2400
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_REF_OxygenFlowRate_2400))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(2)]
        public string OxygenFlowRate_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string REF_03 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string REF_04 { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_REF_AmbulatoryPatientGroupAPG_2400))]
    public class REF_AmbulatoryPatientGroupAPG_2400
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_REF_AmbulatoryPatientGroupAPG_2400))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(2)]
        public string AmbulatoryPatientGroupNumber_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string REF_03 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string REF_04 { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_REF_ImmunizationBatchNumber_2400))]
    public class REF_ImmunizationBatchNumber_2400
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_REF_ImmunizationBatchNumber_2400))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(2)]
        public string ImmunizationBatchNumber_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string REF_03 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string REF_04 { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_REF_ReferringClinicalLaboratoryImprovementAmendmentCLIAFacilityIdentification_2400))]
    public class REF_ReferringClinicalLaboratoryImprovementAmendmentCLIAFacilityIdentification_2400
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_REF_ReferringClinicalLaboratoryImprovementAmendmentCLIAFacilityIdentification_2400))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(2)]
        public string ReferringCLIANumber_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string REF_03 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string REF_04 { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_REF_ClinicalLaboratoryImprovementAmendmentCLIAIdentification_2400))]
    public class REF_ClinicalLaboratoryImprovementAmendmentCLIAIdentification_2400
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_REF_ClinicalLaboratoryImprovementAmendmentCLIAIdentification_2400))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(2)]
        public string ClinicalLaboratoryImprovementAmendmentNumber_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string REF_03 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string REF_04 { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_REF_MammographyCertificationNumber_2400))]
    public class REF_MammographyCertificationNumber_2400
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_REF_MammographyCertificationNumber_2400))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(2)]
        public string MammographyCertificationNumber_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string REF_03 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string REF_04 { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_REF_LineItemControlNumber_2400))]
    public class REF_LineItemControlNumber_2400
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_REF_LineItemControlNumber_2400))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(2)]
        public string LineItemControlNumber_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string REF_03 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string REF_04 { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_REF_PriorAuthorizationOrReferralNumber_2400))]
    public class REF_PriorAuthorizationOrReferralNumber_2400
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_REF_PriorAuthorizationOrReferralNumber_2400))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(2)]
        public string PriorAuthorizationOrReferralNumber_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string REF_03 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string REF_04 { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_REF_AdjustedRepricedLineItemReferenceNumber_2400))]
    public class REF_AdjustedRepricedLineItemReferenceNumber_2400
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_REF_AdjustedRepricedLineItemReferenceNumber_2400))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(2)]
        public string AdjustedRepricedLineItemReferenceNumber_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string REF_03 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string REF_04 { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_REF_RepricedLineItemReferenceNumber_2400))]
    public class REF_RepricedLineItemReferenceNumber_2400
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_REF_RepricedLineItemReferenceNumber_2400))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(2)]
        public string RepricedLineItemReferenceNumber_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string REF_03 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string REF_04 { get; set; }
    }
    
    [Serializable()]
    [Segment("CN1", typeof(X12_ID_1166_CN1_ContractInformation_2400))]
    public class CN1_ContractInformation_2400
    {
        
        [Required]
        [DataElement("1166", typeof(X12_ID_1166_CN1_ContractInformation_2400))]
        [Pos(1)]
        public string ContractTypeCode_01 { get; set; }
        [DataElement("", typeof(X12_R))]
        [Pos(2)]
        public string ContractAmount_02 { get; set; }
        [DataElement("", typeof(X12_R))]
        [Pos(3)]
        public string ContractPercentage_03 { get; set; }
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string ContractCode_04 { get; set; }
        [DataElement("", typeof(X12_R))]
        [Pos(5)]
        public string TermsDiscountPercentage_05 { get; set; }
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(6)]
        public string ContractVersionIdentifier_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("MEA", typeof(X12_ID_737_MEA_TestResult_2400), typeof(X12_ID_738_MEA_TestResult_2400))]
    public class MEA_TestResult_2400
    {
        
        [Required]
        [DataElement("737", typeof(X12_ID_737_MEA_TestResult_2400))]
        [Pos(1)]
        public string MeasurementReferenceIdentificationCode_01 { get; set; }
        [Required]
        [DataElement("738", typeof(X12_ID_738_MEA_TestResult_2400))]
        [Pos(2)]
        public string MeasurementQualifier_02 { get; set; }
        [Required]
        [DataElement("", typeof(X12_R))]
        [Pos(3)]
        public string TestResults_03 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string MEA_04 { get; set; }
        [DataElement("", typeof(X12_R))]
        [Pos(5)]
        public string MEA_05 { get; set; }
        [DataElement("", typeof(X12_R))]
        [Pos(6)]
        public string MEA_06 { get; set; }
        [StringLength(2, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(7)]
        public string MEA_07 { get; set; }
        [StringLength(2, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(8)]
        public string MEA_08 { get; set; }
        [StringLength(2, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(9)]
        public string MEA_09 { get; set; }
        [StringLength(2, 4)]
        [DataElement("", typeof(X12_ID))]
        [Pos(10)]
        public string MEA_10 { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_DTP_2400
    {
        
        [Required]
        [Pos(1)]
        public DTP_DateServiceDate_2400 DTP_DateServiceDate_2400 { get; set; }
        [Pos(2)]
        public DTP_DateCertificationRevisionDate_2400 DTP_DateCertificationRevisionDate_2400 { get; set; }
        [Pos(3)]
        public DTP_DateBeginTherapyDate_2400 DTP_DateBeginTherapyDate_2400 { get; set; }
        [Pos(4)]
        public DTP_DateLastCertificationDate_2400 DTP_DateLastCertificationDate_2400 { get; set; }
        [Pos(5)]
        public DTP_DateDateLastSeen_2400 DTP_DateDateLastSeen_2400 { get; set; }
        [ListCount(2)]
        [Pos(6)]
        public List<DTP_DateTest_2400> DTP_DateTest_2400 { get; set; }
        [ListCount(3)]
        [Pos(7)]
        public List<DTP_DateOxygenSaturationArterialBloodGasTest_2400> DTP_DateOxygenSaturationArterialBloodGasTest_2400 { get; set; }
        [Pos(8)]
        public DTP_DateShipped_2400 DTP_DateShipped_2400 { get; set; }
        [Pos(9)]
        public DTP_DateOnsetOfCurrentSymptomIllness_2400 DTP_DateOnsetOfCurrentSymptomIllness_2400 { get; set; }
        [Pos(10)]
        public DTP_DateLastXray_2400 DTP_DateLastXray_2400 { get; set; }
        [Pos(11)]
        public DTP_DateAcuteManifestation_2400 DTP_DateAcuteManifestation_2400 { get; set; }
        [Pos(12)]
        public DTP_DateInitialTreatment_2400 DTP_DateInitialTreatment_2400 { get; set; }
        [Pos(13)]
        public DTP_DateSimilarIllnessSymptomOnset_2400 DTP_DateSimilarIllnessSymptomOnset_2400 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",472,")]
    public class X12_ID_374_DTP_DateServiceDate_2400
    {
    }
    
    [Serializable()]
    [EdiCodes(",D8,RD8,")]
    public class X12_ID_1250_DTP_DateServiceDate_2400
    {
    }
    
    [Serializable()]
    [EdiCodes(",607,")]
    public class X12_ID_374_DTP_DateCertificationRevisionDate_2400
    {
    }
    
    [Serializable()]
    [EdiCodes(",D8,")]
    public class X12_ID_1250_DTP_DateCertificationRevisionDate_2400
    {
    }
    
    [Serializable()]
    [EdiCodes(",463,")]
    public class X12_ID_374_DTP_DateBeginTherapyDate_2400
    {
    }
    
    [Serializable()]
    [EdiCodes(",D8,")]
    public class X12_ID_1250_DTP_DateBeginTherapyDate_2400
    {
    }
    
    [Serializable()]
    [EdiCodes(",461,")]
    public class X12_ID_374_DTP_DateLastCertificationDate_2400
    {
    }
    
    [Serializable()]
    [EdiCodes(",D8,")]
    public class X12_ID_1250_DTP_DateLastCertificationDate_2400
    {
    }
    
    [Serializable()]
    [EdiCodes(",304,")]
    public class X12_ID_374_DTP_DateDateLastSeen_2400
    {
    }
    
    [Serializable()]
    [EdiCodes(",D8,")]
    public class X12_ID_1250_DTP_DateDateLastSeen_2400
    {
    }
    
    [Serializable()]
    [EdiCodes(",738,739,")]
    public class X12_ID_374_DTP_DateTest_2400
    {
    }
    
    [Serializable()]
    [EdiCodes(",D8,")]
    public class X12_ID_1250_DTP_DateTest_2400
    {
    }
    
    [Serializable()]
    [EdiCodes(",119,480,481,")]
    public class X12_ID_374_DTP_DateOxygenSaturationArterialBloodGasTest_2400
    {
    }
    
    [Serializable()]
    [EdiCodes(",D8,")]
    public class X12_ID_1250_DTP_DateOxygenSaturationArterialBloodGasTest_2400
    {
    }
    
    [Serializable()]
    [EdiCodes(",011,")]
    public class X12_ID_374_DTP_DateShipped_2400
    {
    }
    
    [Serializable()]
    [EdiCodes(",D8,")]
    public class X12_ID_1250_DTP_DateShipped_2400
    {
    }
    
    [Serializable()]
    [EdiCodes(",431,")]
    public class X12_ID_374_DTP_DateOnsetOfCurrentSymptomIllness_2400
    {
    }
    
    [Serializable()]
    [EdiCodes(",D8,")]
    public class X12_ID_1250_DTP_DateOnsetOfCurrentSymptomIllness_2400
    {
    }
    
    [Serializable()]
    [EdiCodes(",455,")]
    public class X12_ID_374_DTP_DateLastXray_2400
    {
    }
    
    [Serializable()]
    [EdiCodes(",D8,")]
    public class X12_ID_1250_DTP_DateLastXray_2400
    {
    }
    
    [Serializable()]
    [EdiCodes(",453,")]
    public class X12_ID_374_DTP_DateAcuteManifestation_2400
    {
    }
    
    [Serializable()]
    [EdiCodes(",D8,")]
    public class X12_ID_1250_DTP_DateAcuteManifestation_2400
    {
    }
    
    [Serializable()]
    [EdiCodes(",454,")]
    public class X12_ID_374_DTP_DateInitialTreatment_2400
    {
    }
    
    [Serializable()]
    [EdiCodes(",D8,")]
    public class X12_ID_1250_DTP_DateInitialTreatment_2400
    {
    }
    
    [Serializable()]
    [EdiCodes(",438,")]
    public class X12_ID_374_DTP_DateSimilarIllnessSymptomOnset_2400
    {
    }
    
    [Serializable()]
    [EdiCodes(",D8,")]
    public class X12_ID_1250_DTP_DateSimilarIllnessSymptomOnset_2400
    {
    }
    
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_DTP_DateSimilarIllnessSymptomOnset_2400), typeof(X12_ID_1250_DTP_DateSimilarIllnessSymptomOnset_2400))]
    public class DTP_DateSimilarIllnessSymptomOnset_2400
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374_DTP_DateSimilarIllnessSymptomOnset_2400))]
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        [Required]
        [DataElement("1250", typeof(X12_ID_1250_DTP_DateSimilarIllnessSymptomOnset_2400))]
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [Required]
        [StringLength(1, 35)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string SimilarIllnessOrSymptomDate_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_DTP_DateInitialTreatment_2400), typeof(X12_ID_1250_DTP_DateInitialTreatment_2400))]
    public class DTP_DateInitialTreatment_2400
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374_DTP_DateInitialTreatment_2400))]
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        [Required]
        [DataElement("1250", typeof(X12_ID_1250_DTP_DateInitialTreatment_2400))]
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [Required]
        [StringLength(1, 35)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string InitialTreatmentDate_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_DTP_DateAcuteManifestation_2400), typeof(X12_ID_1250_DTP_DateAcuteManifestation_2400))]
    public class DTP_DateAcuteManifestation_2400
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374_DTP_DateAcuteManifestation_2400))]
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        [Required]
        [DataElement("1250", typeof(X12_ID_1250_DTP_DateAcuteManifestation_2400))]
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [Required]
        [StringLength(1, 35)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string AcuteManifestationDate_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_DTP_DateLastXray_2400), typeof(X12_ID_1250_DTP_DateLastXray_2400))]
    public class DTP_DateLastXray_2400
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374_DTP_DateLastXray_2400))]
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        [Required]
        [DataElement("1250", typeof(X12_ID_1250_DTP_DateLastXray_2400))]
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [Required]
        [StringLength(1, 35)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string LastXRayDate_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_DTP_DateOnsetOfCurrentSymptomIllness_2400), typeof(X12_ID_1250_DTP_DateOnsetOfCurrentSymptomIllness_2400))]
    public class DTP_DateOnsetOfCurrentSymptomIllness_2400
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374_DTP_DateOnsetOfCurrentSymptomIllness_2400))]
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        [Required]
        [DataElement("1250", typeof(X12_ID_1250_DTP_DateOnsetOfCurrentSymptomIllness_2400))]
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [Required]
        [StringLength(1, 35)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string OnsetDate_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_DTP_DateShipped_2400), typeof(X12_ID_1250_DTP_DateShipped_2400))]
    public class DTP_DateShipped_2400
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374_DTP_DateShipped_2400))]
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        [Required]
        [DataElement("1250", typeof(X12_ID_1250_DTP_DateShipped_2400))]
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [Required]
        [StringLength(1, 35)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string ShippedDate_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_DTP_DateOxygenSaturationArterialBloodGasTest_2400), typeof(X12_ID_1250_DTP_DateOxygenSaturationArterialBloodGasTest_2400))]
    public class DTP_DateOxygenSaturationArterialBloodGasTest_2400
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374_DTP_DateOxygenSaturationArterialBloodGasTest_2400))]
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        [Required]
        [DataElement("1250", typeof(X12_ID_1250_DTP_DateOxygenSaturationArterialBloodGasTest_2400))]
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [Required]
        [StringLength(1, 35)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string OxygenSaturationTestDate_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_DTP_DateTest_2400), typeof(X12_ID_1250_DTP_DateTest_2400))]
    public class DTP_DateTest_2400
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374_DTP_DateTest_2400))]
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        [Required]
        [DataElement("1250", typeof(X12_ID_1250_DTP_DateTest_2400))]
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [Required]
        [StringLength(1, 35)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string TestPerformedDate_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_DTP_DateDateLastSeen_2400), typeof(X12_ID_1250_DTP_DateDateLastSeen_2400))]
    public class DTP_DateDateLastSeen_2400
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374_DTP_DateDateLastSeen_2400))]
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        [Required]
        [DataElement("1250", typeof(X12_ID_1250_DTP_DateDateLastSeen_2400))]
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [Required]
        [StringLength(1, 35)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string LastSeenDate_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_DTP_DateLastCertificationDate_2400), typeof(X12_ID_1250_DTP_DateLastCertificationDate_2400))]
    public class DTP_DateLastCertificationDate_2400
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374_DTP_DateLastCertificationDate_2400))]
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        [Required]
        [DataElement("1250", typeof(X12_ID_1250_DTP_DateLastCertificationDate_2400))]
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [Required]
        [StringLength(1, 35)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string LastCertificationDate_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_DTP_DateBeginTherapyDate_2400), typeof(X12_ID_1250_DTP_DateBeginTherapyDate_2400))]
    public class DTP_DateBeginTherapyDate_2400
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374_DTP_DateBeginTherapyDate_2400))]
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        [Required]
        [DataElement("1250", typeof(X12_ID_1250_DTP_DateBeginTherapyDate_2400))]
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [Required]
        [StringLength(1, 35)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string BeginTherapyDate_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_DTP_DateCertificationRevisionDate_2400), typeof(X12_ID_1250_DTP_DateCertificationRevisionDate_2400))]
    public class DTP_DateCertificationRevisionDate_2400
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374_DTP_DateCertificationRevisionDate_2400))]
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        [Required]
        [DataElement("1250", typeof(X12_ID_1250_DTP_DateCertificationRevisionDate_2400))]
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [Required]
        [StringLength(1, 35)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string CertificationRevisionDate_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_DTP_DateServiceDate_2400), typeof(X12_ID_1250_DTP_DateServiceDate_2400))]
    public class DTP_DateServiceDate_2400
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374_DTP_DateServiceDate_2400))]
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        [Required]
        [DataElement("1250", typeof(X12_ID_1250_DTP_DateServiceDate_2400))]
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [Required]
        [StringLength(1, 35)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string ServiceDate_03 { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_CRC_2400
    {
        
        [ListCount(3)]
        [Pos(1)]
        public List<CRC_AmbulanceCertification_2400> CRC_AmbulanceCertification_2400 { get; set; }
        [Pos(2)]
        public CRC_HospiceEmployeeIndicator_2400 CRC_HospiceEmployeeIndicator_2400 { get; set; }
        [ListCount(2)]
        [Pos(3)]
        public List<CRC_DMERCConditionIndicator_2400> CRC_DMERCConditionIndicator_2400 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",07,")]
    public class X12_ID_1136_CRC_AmbulanceCertification_2400
    {
    }
    
    [Serializable()]
    [EdiCodes(",N,Y,")]
    public class X12_ID_1073_CRC_AmbulanceCertification_2400
    {
    }
    
    [Serializable()]
    [EdiCodes(",70,")]
    public class X12_ID_1136_CRC_HospiceEmployeeIndicator_2400
    {
    }
    
    [Serializable()]
    [EdiCodes(",N,Y,")]
    public class X12_ID_1073_CRC_HospiceEmployeeIndicator_2400
    {
    }
    
    [Serializable()]
    [EdiCodes(",09,11,")]
    public class X12_ID_1136_CRC_DMERCConditionIndicator_2400
    {
    }
    
    [Serializable()]
    [EdiCodes(",N,Y,")]
    public class X12_ID_1073_CRC_DMERCConditionIndicator_2400
    {
    }
    
    [Serializable()]
    [Segment("CRC", typeof(X12_ID_1136_CRC_DMERCConditionIndicator_2400), typeof(X12_ID_1073_CRC_DMERCConditionIndicator_2400))]
    public class CRC_DMERCConditionIndicator_2400
    {
        
        [Required]
        [DataElement("1136", typeof(X12_ID_1136_CRC_DMERCConditionIndicator_2400))]
        [Pos(1)]
        public string CodeCategory_01 { get; set; }
        [Required]
        [DataElement("1073", typeof(X12_ID_1073_CRC_DMERCConditionIndicator_2400))]
        [Pos(2)]
        public string CertificationConditionIndicator_02 { get; set; }
        [Required]
        [DataElement("1321", typeof(X12_ID_1321_CRC_DMERCConditionIndicator_2400))]
        [Pos(3)]
        public string ConditionIndicator_03 { get; set; }
        [DataElement("1321", typeof(X12_ID_1321_CRC_DMERCConditionIndicator_2400))]
        [Pos(4)]
        public string ConditionIndicator_04 { get; set; }
        [DataElement("1321", typeof(X12_ID_1321_CRC_DMERCConditionIndicator_2400))]
        [Pos(5)]
        public string ConditionIndicator_05 { get; set; }
        [DataElement("1321", typeof(X12_ID_1321_CRC_DMERCConditionIndicator_2400))]
        [Pos(6)]
        public string ConditionIndicator_06 { get; set; }
        [DataElement("1321", typeof(X12_ID_1321_CRC_DMERCConditionIndicator_2400))]
        [Pos(7)]
        public string ConditionIndicator_07 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",37,38,AL,P1,ZV,")]
    public class X12_ID_1321_CRC_DMERCConditionIndicator_2400
    {
    }
    
    [Serializable()]
    [Segment("CRC", typeof(X12_ID_1136_CRC_HospiceEmployeeIndicator_2400), typeof(X12_ID_1073_CRC_HospiceEmployeeIndicator_2400))]
    public class CRC_HospiceEmployeeIndicator_2400
    {
        
        [Required]
        [DataElement("1136", typeof(X12_ID_1136_CRC_HospiceEmployeeIndicator_2400))]
        [Pos(1)]
        public string CodeCategory_01 { get; set; }
        [Required]
        [DataElement("1073", typeof(X12_ID_1073_CRC_HospiceEmployeeIndicator_2400))]
        [Pos(2)]
        public string HospiceEmployedProviderIndicator_02 { get; set; }
        [Required]
        [DataElement("1321", typeof(X12_ID_1321_CRC_HospiceEmployeeIndicator_2400))]
        [Pos(3)]
        public string ConditionIndicator_03 { get; set; }
        [StringLength(2, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(4)]
        public string CRC_04 { get; set; }
        [StringLength(2, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(5)]
        public string CRC_05 { get; set; }
        [StringLength(2, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(6)]
        public string CRC_06 { get; set; }
        [StringLength(2, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(7)]
        public string CRC_07 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",65,")]
    public class X12_ID_1321_CRC_HospiceEmployeeIndicator_2400
    {
    }
    
    [Serializable()]
    [Segment("CRC", typeof(X12_ID_1136_CRC_AmbulanceCertification_2400), typeof(X12_ID_1073_CRC_AmbulanceCertification_2400))]
    public class CRC_AmbulanceCertification_2400
    {
        
        [Required]
        [DataElement("1136", typeof(X12_ID_1136_CRC_AmbulanceCertification_2400))]
        [Pos(1)]
        public string CodeCategory_01 { get; set; }
        [Required]
        [DataElement("1073", typeof(X12_ID_1073_CRC_AmbulanceCertification_2400))]
        [Pos(2)]
        public string CertificationConditionIndicator_02 { get; set; }
        [Required]
        [DataElement("1321", typeof(X12_ID_1321_CRC_AmbulanceCertification_2400))]
        [Pos(3)]
        public string ConditionCode_03 { get; set; }
        [DataElement("1321", typeof(X12_ID_1321_CRC_AmbulanceCertification_2400))]
        [Pos(4)]
        public string ConditionCode_04 { get; set; }
        [DataElement("1321", typeof(X12_ID_1321_CRC_AmbulanceCertification_2400))]
        [Pos(5)]
        public string ConditionCode_05 { get; set; }
        [DataElement("1321", typeof(X12_ID_1321_CRC_AmbulanceCertification_2400))]
        [Pos(6)]
        public string ConditionCode_06 { get; set; }
        [DataElement("1321", typeof(X12_ID_1321_CRC_AmbulanceCertification_2400))]
        [Pos(7)]
        public string ConditionCode_07 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,60,")]
    public class X12_ID_1321_CRC_AmbulanceCertification_2400
    {
    }
    
    [Serializable()]
    [Segment("CR5", typeof(X12_ID_1322_CR5_HomeOxygenTherapyInformation_2400))]
    public class CR5_HomeOxygenTherapyInformation_2400
    {
        
        [Required]
        [DataElement("1322", typeof(X12_ID_1322_CR5_HomeOxygenTherapyInformation_2400))]
        [Pos(1)]
        public string CertificationTypeCode_01 { get; set; }
        [Required]
        [DataElement("", typeof(X12_R))]
        [Pos(2)]
        public string TreatmentPeriodCount_02 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_ID))]
        [Pos(3)]
        public string CR5_03 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_ID))]
        [Pos(4)]
        public string CR5_04 { get; set; }
        [StringLength(1, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(5)]
        public string CR5_05 { get; set; }
        [DataElement("", typeof(X12_R))]
        [Pos(6)]
        public string CR5_06 { get; set; }
        [DataElement("", typeof(X12_R))]
        [Pos(7)]
        public string CR5_07 { get; set; }
        [DataElement("", typeof(X12_R))]
        [Pos(8)]
        public string CR5_08 { get; set; }
        [StringLength(1, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(9)]
        public string CR5_09 { get; set; }
        [DataElement("", typeof(X12_R))]
        [Pos(10)]
        public string ArterialBloodGasQuantity_10 { get; set; }
        [DataElement("", typeof(X12_R))]
        [Pos(11)]
        public string OxygenSaturationQuantity_11 { get; set; }
        [Required]
        [DataElement("1349", typeof(X12_ID_1349_CR5_HomeOxygenTherapyInformation_2400))]
        [Pos(12)]
        public string OxygenTestConditionCode_12 { get; set; }
        [DataElement("1350", typeof(X12_ID_1350_CR5_HomeOxygenTherapyInformation_2400))]
        [Pos(13)]
        public string OxygenTestFindingsCode_13 { get; set; }
        [DataElement("1350", typeof(X12_ID_1350_CR5_HomeOxygenTherapyInformation_2400))]
        [Pos(14)]
        public string OxygenTestFindingsCode_14 { get; set; }
        [DataElement("1350", typeof(X12_ID_1350_CR5_HomeOxygenTherapyInformation_2400))]
        [Pos(15)]
        public string OxygenTestFindingsCode_15 { get; set; }
        [DataElement("", typeof(X12_R))]
        [Pos(16)]
        public string CR5_16 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_ID))]
        [Pos(17)]
        public string CR5_17 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_ID))]
        [Pos(18)]
        public string CR5_18 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",E,R,S,")]
    public class X12_ID_1349_CR5_HomeOxygenTherapyInformation_2400
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,")]
    public class X12_ID_1350_CR5_HomeOxygenTherapyInformation_2400
    {
    }
    
    [Serializable()]
    [Segment("CR3", typeof(X12_ID_1322_CR3_DurableMedicalEquipmentCertification_2400), typeof(X12_ID_355_CR3_DurableMedicalEquipmentCertification_2400))]
    public class CR3_DurableMedicalEquipmentCertification_2400
    {
        
        [Required]
        [DataElement("1322", typeof(X12_ID_1322_CR3_DurableMedicalEquipmentCertification_2400))]
        [Pos(1)]
        public string CertificationTypeCode_01 { get; set; }
        [Required]
        [DataElement("355", typeof(X12_ID_355_CR3_DurableMedicalEquipmentCertification_2400))]
        [Pos(2)]
        public string UnitOrBasisForMeasurementCode_02 { get; set; }
        [Required]
        [DataElement("", typeof(X12_R))]
        [Pos(3)]
        public string DurableMedicalEquipmentDuration_03 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_ID))]
        [Pos(4)]
        public string CR3_04 { get; set; }
        [StringLength(1, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(5)]
        public string CR3_05 { get; set; }
    }
    
    [Serializable()]
    [Segment("CR2")]
    public class CR2_SpinalManipulationServiceInformation_2400
    {
        
        [DataElement("", typeof(X12_N0))]
        [Pos(1)]
        public string CR2_01 { get; set; }
        [DataElement("", typeof(X12_R))]
        [Pos(2)]
        public string CR2_02 { get; set; }
        [StringLength(2, 3)]
        [DataElement("", typeof(X12_ID))]
        [Pos(3)]
        public string CR2_03 { get; set; }
        [StringLength(2, 3)]
        [DataElement("", typeof(X12_ID))]
        [Pos(4)]
        public string CR2_04 { get; set; }
        [StringLength(2, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(5)]
        public string CR2_05 { get; set; }
        [DataElement("", typeof(X12_R))]
        [Pos(6)]
        public string CR2_06 { get; set; }
        [DataElement("", typeof(X12_R))]
        [Pos(7)]
        public string CR2_07 { get; set; }
        [Required]
        [DataElement("1342", typeof(X12_ID_1342_CR2_SpinalManipulationServiceInformation_2400))]
        [Pos(8)]
        public string PatientConditionCode_08 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_ID))]
        [Pos(9)]
        public string CR2_09 { get; set; }
        [StringLength(1, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(10)]
        public string PatientConditionDescription_10 { get; set; }
        [StringLength(1, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(11)]
        public string PatientConditionDescription_11 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073_CR2_SpinalManipulationServiceInformation_2400))]
        [Pos(12)]
        public string XrayAvailabilityIndicator_12 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",A,C,D,E,F,G,M,")]
    public class X12_ID_1342_CR2_SpinalManipulationServiceInformation_2400
    {
    }
    
    [Serializable()]
    [EdiCodes(",N,Y,")]
    public class X12_ID_1073_CR2_SpinalManipulationServiceInformation_2400
    {
    }
    
    [Serializable()]
    [Segment("CR1", typeof(X12_ID_355_CR1_AmbulanceTransportInformation_2400))]
    public class CR1_AmbulanceTransportInformation_2400
    {
        
        [DataElement("355", typeof(X12_ID_355_CR1_AmbulanceTransportInformation_2400))]
        [Pos(1)]
        public string UnitOrBasisForMeasurementCode_01 { get; set; }
        [DataElement("", typeof(X12_R))]
        [Pos(2)]
        public string PatientWeight_02 { get; set; }
        [Required]
        [DataElement("1316", typeof(X12_ID_1316_CR1_AmbulanceTransportInformation_2400))]
        [Pos(3)]
        public string AmbulanceTransportCode_03 { get; set; }
        [Required]
        [DataElement("1317", typeof(X12_ID_1317_CR1_AmbulanceTransportInformation_2400))]
        [Pos(4)]
        public string AmbulanceTransportReasonCode_04 { get; set; }
        [Required]
        [DataElement("355", typeof(X12_ID_355_CR1_AmbulanceTransportInformation_2400))]
        [Pos(5)]
        public string UnitOrBasisForMeasurementCode_05 { get; set; }
        [Required]
        [DataElement("", typeof(X12_R))]
        [Pos(6)]
        public string TransportDistance_06 { get; set; }
        [StringLength(1, 55)]
        [DataElement("", typeof(X12_AN))]
        [Pos(7)]
        public string CR1_07 { get; set; }
        [StringLength(1, 55)]
        [DataElement("", typeof(X12_AN))]
        [Pos(8)]
        public string CR1_08 { get; set; }
        [StringLength(1, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(9)]
        public string RoundTripPurposeDescription_09 { get; set; }
        [StringLength(1, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(10)]
        public string StretcherPurposeDescription_10 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",I,R,T,X,")]
    public class X12_ID_1316_CR1_AmbulanceTransportInformation_2400
    {
    }
    
    [Serializable()]
    [EdiCodes(",A,B,C,D,E,")]
    public class X12_ID_1317_CR1_AmbulanceTransportInformation_2400
    {
    }
    
    [Serializable()]
    [Segment("PWK", typeof(X12_ID_755_PWK_DMERCCMNIndicator_2400), typeof(X12_ID_756_PWK_DMERCCMNIndicator_2400))]
    public class PWK_DMERCCMNIndicator_2400
    {
        
        [Required]
        [DataElement("755", typeof(X12_ID_755_PWK_DMERCCMNIndicator_2400))]
        [Pos(1)]
        public string AttachmentReportTypeCode_01 { get; set; }
        [Required]
        [DataElement("756", typeof(X12_ID_756_PWK_DMERCCMNIndicator_2400))]
        [Pos(2)]
        public string AttachmentTransmissionCode_02 { get; set; }
        [DataElement("", typeof(X12_N0))]
        [Pos(3)]
        public string PWK_03 { get; set; }
        [StringLength(2, 3)]
        [DataElement("", typeof(X12_ID))]
        [Pos(4)]
        public string PWK_04 { get; set; }
        [StringLength(1, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(5)]
        public string PWK_05 { get; set; }
        [StringLength(2, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(6)]
        public string PWK_06 { get; set; }
        [StringLength(1, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(7)]
        public string PWK_07 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_AN))]
        [Pos(8)]
        public string PWK_08 { get; set; }
        [StringLength(1, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(9)]
        public string PWK_09 { get; set; }
    }
    
    [Serializable()]
    [Segment("SV5", typeof(X12_ID_235_C003_19141319), typeof(X12_ID_355_SV5_DurableMedicalEquipmentService_2400))]
    public class SV5_DurableMedicalEquipmentService_2400
    {
        
        [Required]
        [Pos(1)]
        public C003_19141319 C003_19141319 { get; set; }
        [Required]
        [DataElement("355", typeof(X12_ID_355_SV5_DurableMedicalEquipmentService_2400))]
        [Pos(2)]
        public string UnitOrBasisForMeasurementCode_02 { get; set; }
        [Required]
        [DataElement("", typeof(X12_R))]
        [Pos(3)]
        public string LengthOfMedicalNecessity_03 { get; set; }
        [DataElement("", typeof(X12_R))]
        [Pos(4)]
        public string DMERentalPrice_04 { get; set; }
        [DataElement("", typeof(X12_R))]
        [Pos(5)]
        public string DMEPurchasePrice_05 { get; set; }
        [DataElement("594", typeof(X12_ID_594_SV5_DurableMedicalEquipmentService_2400))]
        [Pos(6)]
        public string RentalUnitPriceIndicator_06 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_ID))]
        [Pos(7)]
        public string SV5_07 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",1,4,6,")]
    public class X12_ID_594_SV5_DurableMedicalEquipmentService_2400
    {
    }
    
    [Serializable()]
    [Composite("C003_19141319")]
    public class C003_19141319
    {
        
        [Required]
        [DataElement("235", typeof(X12_ID_235_C003_19141319))]
        [Pos(1)]
        public string ProcedureIdentifier_01 { get; set; }
        [Required]
        [StringLength(1, 48)]
        [DataElement("", typeof(X12_AN))]
        [Pos(2)]
        public string ProcedureCode_02 { get; set; }
        [StringLength(2, 2)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string SV5_03 { get; set; }
        [StringLength(2, 2)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string SV5_04 { get; set; }
        [StringLength(2, 2)]
        [DataElement("", typeof(X12_AN))]
        [Pos(5)]
        public string SV5_05 { get; set; }
        [StringLength(2, 2)]
        [DataElement("", typeof(X12_AN))]
        [Pos(6)]
        public string SV5_06 { get; set; }
        [StringLength(1, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(7)]
        public string SV5_07 { get; set; }
    }
    
    [Serializable()]
    [Segment("SV1", typeof(X12_ID_235_C003_701728622))]
    public class SV1_ProfessionalService_2400
    {
        
        [Required]
        [Pos(1)]
        public C003_701728622 C003_701728622 { get; set; }
        [Required]
        [DataElement("", typeof(X12_R))]
        [Pos(2)]
        public string LineItemChargeAmount_02 { get; set; }
        [Required]
        [DataElement("355", typeof(X12_ID_355_SV1_ProfessionalService_2400))]
        [Pos(3)]
        public string UnitOrBasisForMeasurementCode_03 { get; set; }
        [Required]
        [DataElement("", typeof(X12_R))]
        [Pos(4)]
        public string ServiceUnitCount_04 { get; set; }
        [StringLength(1, 2)]
        [DataElement("", typeof(X12_AN))]
        [Pos(5)]
        public string PlaceOfServiceCode_05 { get; set; }
        [StringLength(1, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(6)]
        public string SV1_06 { get; set; }
        [Pos(7)]
        public C004_461136328 C004_461136328 { get; set; }
        [DataElement("", typeof(X12_R))]
        [Pos(8)]
        public string SV1_08 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073_SV1_ProfessionalService_2400))]
        [Pos(9)]
        public string EmergencyIndicator_09 { get; set; }
        [StringLength(1, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(10)]
        public string SV1_10 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073_SV1_ProfessionalService_2400))]
        [Pos(11)]
        public string EPSDTIndicator_11 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073_SV1_ProfessionalService_2400))]
        [Pos(12)]
        public string FamilyPlanningIndicator_12 { get; set; }
        [StringLength(1, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(13)]
        public string SV1_13 { get; set; }
        [StringLength(1, 2)]
        [DataElement("", typeof(X12_AN))]
        [Pos(14)]
        public string SV1_14 { get; set; }
        [DataElement("1327", typeof(X12_ID_1327_SV1_ProfessionalService_2400))]
        [Pos(15)]
        public string CoPayStatusCode_15 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_ID))]
        [Pos(16)]
        public string SV1_16 { get; set; }
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(17)]
        public string SV1_17 { get; set; }
        [StringLength(3, 15)]
        [DataElement("", typeof(X12_ID))]
        [Pos(18)]
        public string SV1_18 { get; set; }
        [DataElement("", typeof(X12_R))]
        [Pos(19)]
        public string SV1_19 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_ID))]
        [Pos(20)]
        public string SV1_20 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_ID))]
        [Pos(21)]
        public string SV1_21 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",F2,MJ,UN,")]
    public class X12_ID_355_SV1_ProfessionalService_2400
    {
    }
    
    [Serializable()]
    [EdiCodes(",Y,")]
    public class X12_ID_1073_SV1_ProfessionalService_2400
    {
    }
    
    [Serializable()]
    [EdiCodes(",0,")]
    public class X12_ID_1327_SV1_ProfessionalService_2400
    {
    }
    
    [Serializable()]
    [Composite("C004_461136328")]
    public class C004_461136328
    {
        
        [Required]
        [DataElement("", typeof(X12_N0))]
        [Pos(1)]
        public string DiagnosisCodePointer_01 { get; set; }
        [DataElement("", typeof(X12_N0))]
        [Pos(2)]
        public string DiagnosisCodePointer_02 { get; set; }
        [DataElement("", typeof(X12_N0))]
        [Pos(3)]
        public string DiagnosisCodePointer_03 { get; set; }
        [DataElement("", typeof(X12_N0))]
        [Pos(4)]
        public string DiagnosisCodePointer_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C003_701728622")]
    public class C003_701728622
    {
        
        [Required]
        [DataElement("235", typeof(X12_ID_235_C003_701728622))]
        [Pos(1)]
        public string ProductOrServiceIDQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 48)]
        [DataElement("", typeof(X12_AN))]
        [Pos(2)]
        public string ProcedureCode_02 { get; set; }
        [StringLength(2, 2)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string ProcedureModifier_03 { get; set; }
        [StringLength(2, 2)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string ProcedureModifier_04 { get; set; }
        [StringLength(2, 2)]
        [DataElement("", typeof(X12_AN))]
        [Pos(5)]
        public string ProcedureModifier_05 { get; set; }
        [StringLength(2, 2)]
        [DataElement("", typeof(X12_AN))]
        [Pos(6)]
        public string ProcedureModifier_06 { get; set; }
        [StringLength(1, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(7)]
        public string SV1_07 { get; set; }
    }
    
    [Serializable()]
    [Segment("LX")]
    public class LX_ServiceLine_2400
    {
        
        [Required]
        [DataElement("", typeof(X12_N0))]
        [Pos(1)]
        public string AssignedNumber_01 { get; set; }
    }
    
    [Serializable()]
    [Group("SBR")]
    public class Loop_2320
    {
        
        [Required]
        [Pos(1)]
        public SBR_OtherSubscriberInformation_2320 SBR_OtherSubscriberInformation_2320 { get; set; }
        [ListCount(5)]
        [Pos(2)]
        public List<CAS_ClaimLevelAdjustments_2320> CAS_ClaimLevelAdjustments_2320 { get; set; }
        [Pos(3)]
        public All_AMT_2320 All_AMT_2320 { get; set; }
        [Pos(4)]
        public DMG_SubscriberDemographicInformation_2320 DMG_SubscriberDemographicInformation_2320 { get; set; }
        [Required]
        [Pos(5)]
        public OI_OtherInsuranceCoverageInformation_2320 OI_OtherInsuranceCoverageInformation_2320 { get; set; }
        [Pos(6)]
        public MOA_MedicareOutpatientAdjudicationInformation_2320 MOA_MedicareOutpatientAdjudicationInformation_2320 { get; set; }
        [Required]
        [Pos(7)]
        public All_2330 All_2330 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",P,S,T,")]
    public class X12_ID_1138_SBR_OtherSubscriberInformation_2320
    {
    }
    
    [Serializable()]
    [EdiCodes(",01,04,05,07,10,15,17,18,19,20,21,22,23,24,29,32,33,36,39,40,41,43,53,G8,")]
    public class X12_ID_1069_SBR_OtherSubscriberInformation_2320
    {
    }
    
    [Serializable()]
    [EdiCodes(",CO,CR,OA,PI,PR,")]
    public class X12_ID_1033_CAS_ClaimLevelAdjustments_2320
    {
    }
    
    [Serializable()]
    [EdiCodes(",D8,")]
    public class X12_ID_1250_DMG_SubscriberDemographicInformation_2320
    {
    }
    
    [Serializable()]
    [All()]
    public class All_2330
    {
        
        [Required]
        [Pos(1)]
        public Loop_2330A Loop_2330A { get; set; }
        [Required]
        [Pos(2)]
        public Loop_2330B Loop_2330B { get; set; }
        [Pos(3)]
        public Loop_2330C Loop_2330C { get; set; }
        [ListCount(2)]
        [Pos(4)]
        public List<Loop_2330D> Loop_2330D { get; set; }
        [Pos(5)]
        public Loop_2330E Loop_2330E { get; set; }
        [Pos(6)]
        public Loop_2330F Loop_2330F { get; set; }
        [Pos(7)]
        public Loop_2330G Loop_2330G { get; set; }
        [Pos(8)]
        public Loop_2330H Loop_2330H { get; set; }
    }
    
    [Serializable()]
    [Group("NM1")]
    public class Loop_2330H
    {
        
        [Required]
        [Pos(1)]
        public NM1_OtherPayerSupervisingProvider_2330H NM1_OtherPayerSupervisingProvider_2330H { get; set; }
        [Required]
        [ListCount(3)]
        [Pos(2)]
        public List<REF_OtherPayerSupervisingProviderIdentification_2330H> REF_OtherPayerSupervisingProviderIdentification_2330H { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",DQ,")]
    public class X12_ID_98_NM1_OtherPayerSupervisingProvider_2330H
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,")]
    public class X12_ID_1065_NM1_OtherPayerSupervisingProvider_2330H
    {
    }
    
    [Serializable()]
    [EdiCodes(",1B,1C,1D,EI,G2,N5,")]
    public class X12_ID_128_REF_OtherPayerSupervisingProviderIdentification_2330H
    {
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_REF_OtherPayerSupervisingProviderIdentification_2330H))]
    public class REF_OtherPayerSupervisingProviderIdentification_2330H
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_REF_OtherPayerSupervisingProviderIdentification_2330H))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(2)]
        public string OtherPayerSupervisingProviderIdentifier_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string REF_03 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string REF_04 { get; set; }
    }
    
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_NM1_OtherPayerSupervisingProvider_2330H), typeof(X12_ID_1065_NM1_OtherPayerSupervisingProvider_2330H))]
    public class NM1_OtherPayerSupervisingProvider_2330H
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98_NM1_OtherPayerSupervisingProvider_2330H))]
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        [Required]
        [DataElement("1065", typeof(X12_ID_1065_NM1_OtherPayerSupervisingProvider_2330H))]
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        [StringLength(1, 35)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string NM1_03 { get; set; }
        [StringLength(1, 25)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string NM1_04 { get; set; }
        [StringLength(1, 25)]
        [DataElement("", typeof(X12_AN))]
        [Pos(5)]
        public string NM1_05 { get; set; }
        [StringLength(1, 10)]
        [DataElement("", typeof(X12_AN))]
        [Pos(6)]
        public string NM1_06 { get; set; }
        [StringLength(1, 10)]
        [DataElement("", typeof(X12_AN))]
        [Pos(7)]
        public string NM1_07 { get; set; }
        [StringLength(1, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(8)]
        public string NM1_08 { get; set; }
        [StringLength(2, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(9)]
        public string NM1_09 { get; set; }
        [StringLength(2, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(10)]
        public string NM1_10 { get; set; }
        [StringLength(2, 3)]
        [DataElement("", typeof(X12_ID))]
        [Pos(11)]
        public string NM1_11 { get; set; }
    }
    
    [Serializable()]
    [Group("NM1")]
    public class Loop_2330G
    {
        
        [Required]
        [Pos(1)]
        public NM1_OtherPayerServiceFacilityLocation_2330G NM1_OtherPayerServiceFacilityLocation_2330G { get; set; }
        [Required]
        [ListCount(3)]
        [Pos(2)]
        public List<REF_OtherPayerServiceFacilityLocationIdentification_2330G> REF_OtherPayerServiceFacilityLocationIdentification_2330G { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",77,FA,LI,TL,")]
    public class X12_ID_98_NM1_OtherPayerServiceFacilityLocation_2330G
    {
    }
    
    [Serializable()]
    [EdiCodes(",2,")]
    public class X12_ID_1065_NM1_OtherPayerServiceFacilityLocation_2330G
    {
    }
    
    [Serializable()]
    [EdiCodes(",1A,1B,1C,1D,G2,LU,N5,")]
    public class X12_ID_128_REF_OtherPayerServiceFacilityLocationIdentification_2330G
    {
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_REF_OtherPayerServiceFacilityLocationIdentification_2330G))]
    public class REF_OtherPayerServiceFacilityLocationIdentification_2330G
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_REF_OtherPayerServiceFacilityLocationIdentification_2330G))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(2)]
        public string OtherPayerServiceFacilityLocationIdentifier_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string REF_03 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string REF_04 { get; set; }
    }
    
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_NM1_OtherPayerServiceFacilityLocation_2330G), typeof(X12_ID_1065_NM1_OtherPayerServiceFacilityLocation_2330G))]
    public class NM1_OtherPayerServiceFacilityLocation_2330G
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98_NM1_OtherPayerServiceFacilityLocation_2330G))]
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        [Required]
        [DataElement("1065", typeof(X12_ID_1065_NM1_OtherPayerServiceFacilityLocation_2330G))]
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        [StringLength(1, 35)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string NM1_03 { get; set; }
        [StringLength(1, 25)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string NM1_04 { get; set; }
        [StringLength(1, 25)]
        [DataElement("", typeof(X12_AN))]
        [Pos(5)]
        public string NM1_05 { get; set; }
        [StringLength(1, 10)]
        [DataElement("", typeof(X12_AN))]
        [Pos(6)]
        public string NM1_06 { get; set; }
        [StringLength(1, 10)]
        [DataElement("", typeof(X12_AN))]
        [Pos(7)]
        public string NM1_07 { get; set; }
        [StringLength(1, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(8)]
        public string NM1_08 { get; set; }
        [StringLength(2, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(9)]
        public string NM1_09 { get; set; }
        [StringLength(2, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(10)]
        public string NM1_10 { get; set; }
        [StringLength(2, 3)]
        [DataElement("", typeof(X12_ID))]
        [Pos(11)]
        public string NM1_11 { get; set; }
    }
    
    [Serializable()]
    [Group("NM1")]
    public class Loop_2330F
    {
        
        [Required]
        [Pos(1)]
        public NM1_OtherPayerPurchasedServiceProvider_2330F NM1_OtherPayerPurchasedServiceProvider_2330F { get; set; }
        [Required]
        [ListCount(3)]
        [Pos(2)]
        public List<REF_OtherPayerPurchasedServiceProviderIdentification_2330F> REF_OtherPayerPurchasedServiceProviderIdentification_2330F { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",QB,")]
    public class X12_ID_98_NM1_OtherPayerPurchasedServiceProvider_2330F
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,")]
    public class X12_ID_1065_NM1_OtherPayerPurchasedServiceProvider_2330F
    {
    }
    
    [Serializable()]
    [EdiCodes(",1A,1B,1C,1D,EI,G2,LU,N5,")]
    public class X12_ID_128_REF_OtherPayerPurchasedServiceProviderIdentification_2330F
    {
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_REF_OtherPayerPurchasedServiceProviderIdentification_2330F))]
    public class REF_OtherPayerPurchasedServiceProviderIdentification_2330F
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_REF_OtherPayerPurchasedServiceProviderIdentification_2330F))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(2)]
        public string OtherPayerPurchasedServiceProviderIdentifier_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string REF_03 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string REF_04 { get; set; }
    }
    
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_NM1_OtherPayerPurchasedServiceProvider_2330F), typeof(X12_ID_1065_NM1_OtherPayerPurchasedServiceProvider_2330F))]
    public class NM1_OtherPayerPurchasedServiceProvider_2330F
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98_NM1_OtherPayerPurchasedServiceProvider_2330F))]
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        [Required]
        [DataElement("1065", typeof(X12_ID_1065_NM1_OtherPayerPurchasedServiceProvider_2330F))]
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        [StringLength(1, 35)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string NM1_03 { get; set; }
        [StringLength(1, 25)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string NM1_04 { get; set; }
        [StringLength(1, 25)]
        [DataElement("", typeof(X12_AN))]
        [Pos(5)]
        public string NM1_05 { get; set; }
        [StringLength(1, 10)]
        [DataElement("", typeof(X12_AN))]
        [Pos(6)]
        public string NM1_06 { get; set; }
        [StringLength(1, 10)]
        [DataElement("", typeof(X12_AN))]
        [Pos(7)]
        public string NM1_07 { get; set; }
        [StringLength(1, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(8)]
        public string NM1_08 { get; set; }
        [StringLength(2, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(9)]
        public string NM1_09 { get; set; }
        [StringLength(2, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(10)]
        public string NM1_10 { get; set; }
        [StringLength(2, 3)]
        [DataElement("", typeof(X12_ID))]
        [Pos(11)]
        public string NM1_11 { get; set; }
    }
    
    [Serializable()]
    [Group("NM1")]
    public class Loop_2330E
    {
        
        [Required]
        [Pos(1)]
        public NM1_OtherPayerRenderingProvider_2330E NM1_OtherPayerRenderingProvider_2330E { get; set; }
        [Required]
        [ListCount(3)]
        [Pos(2)]
        public List<REF_OtherPayerRenderingProviderSecondaryIdentification_2330E> REF_OtherPayerRenderingProviderSecondaryIdentification_2330E { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",82,")]
    public class X12_ID_98_NM1_OtherPayerRenderingProvider_2330E
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,")]
    public class X12_ID_1065_NM1_OtherPayerRenderingProvider_2330E
    {
    }
    
    [Serializable()]
    [EdiCodes(",1B,1C,1D,EI,G2,LU,N5,")]
    public class X12_ID_128_REF_OtherPayerRenderingProviderSecondaryIdentification_2330E
    {
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_REF_OtherPayerRenderingProviderSecondaryIdentification_2330E))]
    public class REF_OtherPayerRenderingProviderSecondaryIdentification_2330E
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_REF_OtherPayerRenderingProviderSecondaryIdentification_2330E))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(2)]
        public string OtherPayerRenderingProviderSecondaryIdentifier_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string REF_03 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string REF_04 { get; set; }
    }
    
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_NM1_OtherPayerRenderingProvider_2330E), typeof(X12_ID_1065_NM1_OtherPayerRenderingProvider_2330E))]
    public class NM1_OtherPayerRenderingProvider_2330E
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98_NM1_OtherPayerRenderingProvider_2330E))]
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        [Required]
        [DataElement("1065", typeof(X12_ID_1065_NM1_OtherPayerRenderingProvider_2330E))]
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        [StringLength(1, 35)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string NM1_03 { get; set; }
        [StringLength(1, 25)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string NM1_04 { get; set; }
        [StringLength(1, 25)]
        [DataElement("", typeof(X12_AN))]
        [Pos(5)]
        public string NM1_05 { get; set; }
        [StringLength(1, 10)]
        [DataElement("", typeof(X12_AN))]
        [Pos(6)]
        public string NM1_06 { get; set; }
        [StringLength(1, 10)]
        [DataElement("", typeof(X12_AN))]
        [Pos(7)]
        public string NM1_07 { get; set; }
        [StringLength(1, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(8)]
        public string NM1_08 { get; set; }
        [StringLength(2, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(9)]
        public string NM1_09 { get; set; }
        [StringLength(2, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(10)]
        public string NM1_10 { get; set; }
        [StringLength(2, 3)]
        [DataElement("", typeof(X12_ID))]
        [Pos(11)]
        public string NM1_11 { get; set; }
    }
    
    [Serializable()]
    [Group("NM1")]
    public class Loop_2330D
    {
        
        [Required]
        [Pos(1)]
        public NM1_OtherPayerReferringProvider_2330D NM1_OtherPayerReferringProvider_2330D { get; set; }
        [Required]
        [ListCount(3)]
        [Pos(2)]
        public List<REF_OtherPayerReferringProviderIdentification_2330D> REF_OtherPayerReferringProviderIdentification_2330D { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",DN,P3,")]
    public class X12_ID_98_NM1_OtherPayerReferringProvider_2330D
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,")]
    public class X12_ID_1065_NM1_OtherPayerReferringProvider_2330D
    {
    }
    
    [Serializable()]
    [EdiCodes(",1B,1C,1D,EI,G2,LU,N5,")]
    public class X12_ID_128_REF_OtherPayerReferringProviderIdentification_2330D
    {
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_REF_OtherPayerReferringProviderIdentification_2330D))]
    public class REF_OtherPayerReferringProviderIdentification_2330D
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_REF_OtherPayerReferringProviderIdentification_2330D))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(2)]
        public string OtherPayerReferringProviderIdentifier_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string REF_03 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string REF_04 { get; set; }
    }
    
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_NM1_OtherPayerReferringProvider_2330D), typeof(X12_ID_1065_NM1_OtherPayerReferringProvider_2330D))]
    public class NM1_OtherPayerReferringProvider_2330D
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98_NM1_OtherPayerReferringProvider_2330D))]
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        [Required]
        [DataElement("1065", typeof(X12_ID_1065_NM1_OtherPayerReferringProvider_2330D))]
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        [StringLength(1, 35)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string NM1_03 { get; set; }
        [StringLength(1, 25)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string NM1_04 { get; set; }
        [StringLength(1, 25)]
        [DataElement("", typeof(X12_AN))]
        [Pos(5)]
        public string NM1_05 { get; set; }
        [StringLength(1, 10)]
        [DataElement("", typeof(X12_AN))]
        [Pos(6)]
        public string NM1_06 { get; set; }
        [StringLength(1, 10)]
        [DataElement("", typeof(X12_AN))]
        [Pos(7)]
        public string NM1_07 { get; set; }
        [StringLength(1, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(8)]
        public string NM1_08 { get; set; }
        [StringLength(2, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(9)]
        public string NM1_09 { get; set; }
        [StringLength(2, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(10)]
        public string NM1_10 { get; set; }
        [StringLength(2, 3)]
        [DataElement("", typeof(X12_ID))]
        [Pos(11)]
        public string NM1_11 { get; set; }
    }
    
    [Serializable()]
    [Group("NM1")]
    public class Loop_2330C
    {
        
        [Required]
        [Pos(1)]
        public NM1_OtherPayerPatientInformation_2330C NM1_OtherPayerPatientInformation_2330C { get; set; }
        [ListCount(3)]
        [Pos(2)]
        public List<REF_OtherPayerPatientIdentification_2330C> REF_OtherPayerPatientIdentification_2330C { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",QC,")]
    public class X12_ID_98_NM1_OtherPayerPatientInformation_2330C
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,")]
    public class X12_ID_1065_NM1_OtherPayerPatientInformation_2330C
    {
    }
    
    [Serializable()]
    [EdiCodes(",1W,23,IG,SY,")]
    public class X12_ID_128_REF_OtherPayerPatientIdentification_2330C
    {
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_REF_OtherPayerPatientIdentification_2330C))]
    public class REF_OtherPayerPatientIdentification_2330C
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_REF_OtherPayerPatientIdentification_2330C))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(2)]
        public string OtherPayerPatientSecondaryIdentifier_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string REF_03 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string REF_04 { get; set; }
    }
    
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_NM1_OtherPayerPatientInformation_2330C), typeof(X12_ID_1065_NM1_OtherPayerPatientInformation_2330C))]
    public class NM1_OtherPayerPatientInformation_2330C
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98_NM1_OtherPayerPatientInformation_2330C))]
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        [Required]
        [DataElement("1065", typeof(X12_ID_1065_NM1_OtherPayerPatientInformation_2330C))]
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        [StringLength(1, 35)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string NM1_03 { get; set; }
        [StringLength(1, 25)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string NM1_04 { get; set; }
        [StringLength(1, 25)]
        [DataElement("", typeof(X12_AN))]
        [Pos(5)]
        public string NM1_05 { get; set; }
        [StringLength(1, 10)]
        [DataElement("", typeof(X12_AN))]
        [Pos(6)]
        public string NM1_06 { get; set; }
        [StringLength(1, 10)]
        [DataElement("", typeof(X12_AN))]
        [Pos(7)]
        public string NM1_07 { get; set; }
        [Required]
        [DataElement("66", typeof(X12_ID_66_NM1_OtherPayerPatientInformation_2330C))]
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        [Required]
        [StringLength(2, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(9)]
        public string OtherPayerPatientPrimaryIdentifier_09 { get; set; }
        [StringLength(2, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(10)]
        public string NM1_10 { get; set; }
        [StringLength(2, 3)]
        [DataElement("", typeof(X12_ID))]
        [Pos(11)]
        public string NM1_11 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",MI,")]
    public class X12_ID_66_NM1_OtherPayerPatientInformation_2330C
    {
    }
    
    [Serializable()]
    [Group("NM1")]
    public class Loop_2330B
    {
        
        [Required]
        [Pos(1)]
        public NM1_OtherPayerName_2330B NM1_OtherPayerName_2330B { get; set; }
        [ListCount(2)]
        [Pos(2)]
        public List<PER_OtherPayerContactInformation_2330B> PER_OtherPayerContactInformation_2330B { get; set; }
        [Pos(3)]
        public DTP_ClaimAdjudicationDate_2330B DTP_ClaimAdjudicationDate_2330B { get; set; }
        [Pos(4)]
        public All_REF_2330B All_REF_2330B { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",PR,")]
    public class X12_ID_98_NM1_OtherPayerName_2330B
    {
    }
    
    [Serializable()]
    [EdiCodes(",2,")]
    public class X12_ID_1065_NM1_OtherPayerName_2330B
    {
    }
    
    [Serializable()]
    [EdiCodes(",IC,")]
    public class X12_ID_366_PER_OtherPayerContactInformation_2330B
    {
    }
    
    [Serializable()]
    [EdiCodes(",573,")]
    public class X12_ID_374_DTP_ClaimAdjudicationDate_2330B
    {
    }
    
    [Serializable()]
    [EdiCodes(",D8,")]
    public class X12_ID_1250_DTP_ClaimAdjudicationDate_2330B
    {
    }
    
    [Serializable()]
    [All()]
    public class All_REF_2330B
    {
        
        [ListCount(2)]
        [Pos(1)]
        public List<REF_OtherPayerSecondaryIdentifier_2330B> REF_OtherPayerSecondaryIdentifier_2330B { get; set; }
        [ListCount(2)]
        [Pos(2)]
        public List<REF_OtherPayerPriorAuthorizationOrReferralNumber_2330B> REF_OtherPayerPriorAuthorizationOrReferralNumber_2330B { get; set; }
        [ListCount(2)]
        [Pos(3)]
        public List<REF_OtherPayerClaimAdjustmentIndicator_2330B> REF_OtherPayerClaimAdjustmentIndicator_2330B { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",2U,F8,FY,NF,TJ,")]
    public class X12_ID_128_REF_OtherPayerSecondaryIdentifier_2330B
    {
    }
    
    [Serializable()]
    [EdiCodes(",9F,G1,")]
    public class X12_ID_128_REF_OtherPayerPriorAuthorizationOrReferralNumber_2330B
    {
    }
    
    [Serializable()]
    [EdiCodes(",T4,")]
    public class X12_ID_128_REF_OtherPayerClaimAdjustmentIndicator_2330B
    {
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_REF_OtherPayerClaimAdjustmentIndicator_2330B))]
    public class REF_OtherPayerClaimAdjustmentIndicator_2330B
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_REF_OtherPayerClaimAdjustmentIndicator_2330B))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(2)]
        public string OtherPayerClaimAdjustmentIndicator_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string REF_03 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string REF_04 { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_REF_OtherPayerPriorAuthorizationOrReferralNumber_2330B))]
    public class REF_OtherPayerPriorAuthorizationOrReferralNumber_2330B
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_REF_OtherPayerPriorAuthorizationOrReferralNumber_2330B))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(2)]
        public string OtherPayerPriorAuthorizationOrReferralNumber_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string REF_03 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string REF_04 { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_REF_OtherPayerSecondaryIdentifier_2330B))]
    public class REF_OtherPayerSecondaryIdentifier_2330B
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_REF_OtherPayerSecondaryIdentifier_2330B))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(2)]
        public string OtherPayerSecondaryIdentifier_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string REF_03 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string REF_04 { get; set; }
    }
    
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_DTP_ClaimAdjudicationDate_2330B), typeof(X12_ID_1250_DTP_ClaimAdjudicationDate_2330B))]
    public class DTP_ClaimAdjudicationDate_2330B
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374_DTP_ClaimAdjudicationDate_2330B))]
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        [Required]
        [DataElement("1250", typeof(X12_ID_1250_DTP_ClaimAdjudicationDate_2330B))]
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [Required]
        [StringLength(1, 35)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string AdjudicationOrPaymentDate_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("PER", typeof(X12_ID_366_PER_OtherPayerContactInformation_2330B))]
    public class PER_OtherPayerContactInformation_2330B
    {
        
        [Required]
        [DataElement("366", typeof(X12_ID_366_PER_OtherPayerContactInformation_2330B))]
        [Pos(1)]
        public string ContactFunctionCode_01 { get; set; }
        [Required]
        [StringLength(1, 60)]
        [DataElement("", typeof(X12_AN))]
        [Pos(2)]
        public string OtherPayerContactName_02 { get; set; }
        [Required]
        [DataElement("365", typeof(X12_ID_365_PER_OtherPayerContactInformation_2330B))]
        [Pos(3)]
        public string CommunicationNumberQualifier_03 { get; set; }
        [Required]
        [StringLength(1, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string CommunicationNumber_04 { get; set; }
        [DataElement("365", typeof(X12_ID_365_PER_OtherPayerContactInformation_2330B))]
        [Pos(5)]
        public string CommunicationNumberQualifier_05 { get; set; }
        [StringLength(1, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(6)]
        public string CommunicationNumber_06 { get; set; }
        [DataElement("365", typeof(X12_ID_365_PER_OtherPayerContactInformation_2330B))]
        [Pos(7)]
        public string CommunicationNumberQualifier_07 { get; set; }
        [StringLength(1, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(8)]
        public string CommunicationNumber_08 { get; set; }
        [StringLength(1, 20)]
        [DataElement("", typeof(X12_AN))]
        [Pos(9)]
        public string PER_09 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",ED,EM,FX,TE,")]
    public class X12_ID_365_PER_OtherPayerContactInformation_2330B
    {
    }
    
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_NM1_OtherPayerName_2330B), typeof(X12_ID_1065_NM1_OtherPayerName_2330B))]
    public class NM1_OtherPayerName_2330B
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98_NM1_OtherPayerName_2330B))]
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        [Required]
        [DataElement("1065", typeof(X12_ID_1065_NM1_OtherPayerName_2330B))]
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        [Required]
        [StringLength(1, 35)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string OtherPayerLastOrOrganizationName_03 { get; set; }
        [StringLength(1, 25)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string NM1_04 { get; set; }
        [StringLength(1, 25)]
        [DataElement("", typeof(X12_AN))]
        [Pos(5)]
        public string NM1_05 { get; set; }
        [StringLength(1, 10)]
        [DataElement("", typeof(X12_AN))]
        [Pos(6)]
        public string NM1_06 { get; set; }
        [StringLength(1, 10)]
        [DataElement("", typeof(X12_AN))]
        [Pos(7)]
        public string NM1_07 { get; set; }
        [Required]
        [DataElement("66", typeof(X12_ID_66_NM1_OtherPayerName_2330B))]
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        [Required]
        [StringLength(2, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(9)]
        public string OtherPayerPrimaryIdentifier_09 { get; set; }
        [StringLength(2, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(10)]
        public string NM1_10 { get; set; }
        [StringLength(2, 3)]
        [DataElement("", typeof(X12_ID))]
        [Pos(11)]
        public string NM1_11 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",PI,XV,")]
    public class X12_ID_66_NM1_OtherPayerName_2330B
    {
    }
    
    [Serializable()]
    [Group("NM1")]
    public class Loop_2330A
    {
        
        [Required]
        [Pos(1)]
        public NM1_OtherSubscriberName_2330A NM1_OtherSubscriberName_2330A { get; set; }
        [Pos(2)]
        public N3_OtherSubscriberAddress_2330A N3_OtherSubscriberAddress_2330A { get; set; }
        [Pos(3)]
        public N4_OtherSubscriberCityStateZIPCode_2330A N4_OtherSubscriberCityStateZIPCode_2330A { get; set; }
        [ListCount(3)]
        [Pos(4)]
        public List<REF_OtherSubscriberSecondaryIdentification_2330A> REF_OtherSubscriberSecondaryIdentification_2330A { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",IL,")]
    public class X12_ID_98_NM1_OtherSubscriberName_2330A
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,")]
    public class X12_ID_1065_NM1_OtherSubscriberName_2330A
    {
    }
    
    [Serializable()]
    [EdiCodes(",1W,23,IG,SY,")]
    public class X12_ID_128_REF_OtherSubscriberSecondaryIdentification_2330A
    {
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_REF_OtherSubscriberSecondaryIdentification_2330A))]
    public class REF_OtherSubscriberSecondaryIdentification_2330A
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_REF_OtherSubscriberSecondaryIdentification_2330A))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(2)]
        public string OtherInsuredAdditionalIdentifier_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string REF_03 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string REF_04 { get; set; }
    }
    
    [Serializable()]
    [Segment("N4")]
    public class N4_OtherSubscriberCityStateZIPCode_2330A
    {
        
        [StringLength(2, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(1)]
        public string OtherInsuredCityName_01 { get; set; }
        [StringLength(2, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(2)]
        public string OtherInsuredStateCode_02 { get; set; }
        [StringLength(3, 15)]
        [DataElement("", typeof(X12_ID))]
        [Pos(3)]
        public string OtherInsuredPostalZoneOrZIPCode_03 { get; set; }
        [StringLength(2, 3)]
        [DataElement("", typeof(X12_ID))]
        [Pos(4)]
        public string CountryCode_04 { get; set; }
        [StringLength(1, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(5)]
        public string N4_05 { get; set; }
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(6)]
        public string N4_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("N3")]
    public class N3_OtherSubscriberAddress_2330A
    {
        
        [Required]
        [StringLength(1, 55)]
        [DataElement("", typeof(X12_AN))]
        [Pos(1)]
        public string OtherInsuredAddressLine_01 { get; set; }
        [StringLength(1, 55)]
        [DataElement("", typeof(X12_AN))]
        [Pos(2)]
        public string OtherInsuredAddressLine_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_NM1_OtherSubscriberName_2330A), typeof(X12_ID_1065_NM1_OtherSubscriberName_2330A))]
    public class NM1_OtherSubscriberName_2330A
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98_NM1_OtherSubscriberName_2330A))]
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        [Required]
        [DataElement("1065", typeof(X12_ID_1065_NM1_OtherSubscriberName_2330A))]
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        [Required]
        [StringLength(1, 35)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string OtherInsuredLastName_03 { get; set; }
        [StringLength(1, 25)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string OtherInsuredFirstName_04 { get; set; }
        [StringLength(1, 25)]
        [DataElement("", typeof(X12_AN))]
        [Pos(5)]
        public string OtherInsuredMiddleName_05 { get; set; }
        [StringLength(1, 10)]
        [DataElement("", typeof(X12_AN))]
        [Pos(6)]
        public string NM1_06 { get; set; }
        [StringLength(1, 10)]
        [DataElement("", typeof(X12_AN))]
        [Pos(7)]
        public string OtherInsuredNameSuffix_07 { get; set; }
        [Required]
        [DataElement("66", typeof(X12_ID_66_NM1_OtherSubscriberName_2330A))]
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        [Required]
        [StringLength(2, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(9)]
        public string OtherInsuredIdentifier_09 { get; set; }
        [StringLength(2, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(10)]
        public string NM1_10 { get; set; }
        [StringLength(2, 3)]
        [DataElement("", typeof(X12_ID))]
        [Pos(11)]
        public string NM1_11 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",MI,ZZ,")]
    public class X12_ID_66_NM1_OtherSubscriberName_2330A
    {
    }
    
    [Serializable()]
    [Segment("MOA")]
    public class MOA_MedicareOutpatientAdjudicationInformation_2320
    {
        
        [DataElement("", typeof(X12_R))]
        [Pos(1)]
        public string ReimbursementRate_01 { get; set; }
        [DataElement("", typeof(X12_R))]
        [Pos(2)]
        public string HCPCSPayableAmount_02 { get; set; }
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string RemarkCode_03 { get; set; }
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string RemarkCode_04 { get; set; }
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(5)]
        public string RemarkCode_05 { get; set; }
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(6)]
        public string RemarkCode_06 { get; set; }
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(7)]
        public string RemarkCode_07 { get; set; }
        [DataElement("", typeof(X12_R))]
        [Pos(8)]
        public string EndStageRenalDiseasePaymentAmount_08 { get; set; }
        [DataElement("", typeof(X12_R))]
        [Pos(9)]
        public string NonPayableProfessionalComponentBilledAmount_09 { get; set; }
    }
    
    [Serializable()]
    [Segment("OI")]
    public class OI_OtherInsuranceCoverageInformation_2320
    {
        
        [StringLength(1, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(1)]
        public string OI_01 { get; set; }
        [StringLength(2, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(2)]
        public string OI_02 { get; set; }
        [Required]
        [DataElement("1073", typeof(X12_ID_1073_OI_OtherInsuranceCoverageInformation_2320))]
        [Pos(3)]
        public string BenefitsAssignmentCertificationIndicator_03 { get; set; }
        [DataElement("1351", typeof(X12_ID_1351_OI_OtherInsuranceCoverageInformation_2320))]
        [Pos(4)]
        public string PatientSignatureSourceCode_04 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_ID))]
        [Pos(5)]
        public string OI_05 { get; set; }
        [Required]
        [DataElement("1363", typeof(X12_ID_1363_OI_OtherInsuranceCoverageInformation_2320))]
        [Pos(6)]
        public string ReleaseOfInformationCode_06 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",N,Y,")]
    public class X12_ID_1073_OI_OtherInsuranceCoverageInformation_2320
    {
    }
    
    [Serializable()]
    [EdiCodes(",B,C,M,P,S,")]
    public class X12_ID_1351_OI_OtherInsuranceCoverageInformation_2320
    {
    }
    
    [Serializable()]
    [EdiCodes(",A,I,M,N,O,Y,")]
    public class X12_ID_1363_OI_OtherInsuranceCoverageInformation_2320
    {
    }
    
    [Serializable()]
    [Segment("DMG", typeof(X12_ID_1250_DMG_SubscriberDemographicInformation_2320))]
    public class DMG_SubscriberDemographicInformation_2320
    {
        
        [Required]
        [DataElement("1250", typeof(X12_ID_1250_DMG_SubscriberDemographicInformation_2320))]
        [Pos(1)]
        public string DateTimePeriodFormatQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 35)]
        [DataElement("", typeof(X12_AN))]
        [Pos(2)]
        public string OtherInsuredBirthDate_02 { get; set; }
        [Required]
        [DataElement("1068", typeof(X12_ID_1068_DMG_SubscriberDemographicInformation_2320))]
        [Pos(3)]
        public string OtherInsuredGenderCode_03 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_ID))]
        [Pos(4)]
        public string DMG_04 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_ID))]
        [Pos(5)]
        public string DMG_05 { get; set; }
        [StringLength(1, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(6)]
        public string DMG_06 { get; set; }
        [StringLength(2, 3)]
        [DataElement("", typeof(X12_ID))]
        [Pos(7)]
        public string DMG_07 { get; set; }
        [StringLength(1, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(8)]
        public string DMG_08 { get; set; }
        [DataElement("", typeof(X12_R))]
        [Pos(9)]
        public string DMG_09 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",F,M,U,")]
    public class X12_ID_1068_DMG_SubscriberDemographicInformation_2320
    {
    }
    
    [Serializable()]
    [All()]
    public class All_AMT_2320
    {
        
        [Pos(1)]
        public AMT_CoordinationOfBenefitsCOBPayerPaidAmount_2320 AMT_CoordinationOfBenefitsCOBPayerPaidAmount_2320 { get; set; }
        [Pos(2)]
        public AMT_CoordinationOfBenefitsCOBApprovedAmount_2320 AMT_CoordinationOfBenefitsCOBApprovedAmount_2320 { get; set; }
        [Pos(3)]
        public AMT_CoordinationOfBenefitsCOBAllowedAmount_2320 AMT_CoordinationOfBenefitsCOBAllowedAmount_2320 { get; set; }
        [Pos(4)]
        public AMT_CoordinationOfBenefitsCOBPatientResponsibilityAmount_2320 AMT_CoordinationOfBenefitsCOBPatientResponsibilityAmount_2320 { get; set; }
        [Pos(5)]
        public AMT_CoordinationOfBenefitsCOBCoveredAmount_2320 AMT_CoordinationOfBenefitsCOBCoveredAmount_2320 { get; set; }
        [Pos(6)]
        public AMT_CoordinationOfBenefitsCOBDiscountAmount_2320 AMT_CoordinationOfBenefitsCOBDiscountAmount_2320 { get; set; }
        [Pos(7)]
        public AMT_CoordinationOfBenefitsCOBPerDayLimitAmount_2320 AMT_CoordinationOfBenefitsCOBPerDayLimitAmount_2320 { get; set; }
        [Pos(8)]
        public AMT_CoordinationOfBenefitsCOBPatientPaidAmount_2320 AMT_CoordinationOfBenefitsCOBPatientPaidAmount_2320 { get; set; }
        [Pos(9)]
        public AMT_CoordinationOfBenefitsCOBTaxAmount_2320 AMT_CoordinationOfBenefitsCOBTaxAmount_2320 { get; set; }
        [Pos(10)]
        public AMT_CoordinationOfBenefitsCOBTotalClaimBeforeTaxesAmount_2320 AMT_CoordinationOfBenefitsCOBTotalClaimBeforeTaxesAmount_2320 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",D,")]
    public class X12_ID_522_AMT_CoordinationOfBenefitsCOBPayerPaidAmount_2320
    {
    }
    
    [Serializable()]
    [EdiCodes(",AAE,")]
    public class X12_ID_522_AMT_CoordinationOfBenefitsCOBApprovedAmount_2320
    {
    }
    
    [Serializable()]
    [EdiCodes(",B6,")]
    public class X12_ID_522_AMT_CoordinationOfBenefitsCOBAllowedAmount_2320
    {
    }
    
    [Serializable()]
    [EdiCodes(",F2,")]
    public class X12_ID_522_AMT_CoordinationOfBenefitsCOBPatientResponsibilityAmount_2320
    {
    }
    
    [Serializable()]
    [EdiCodes(",AU,")]
    public class X12_ID_522_AMT_CoordinationOfBenefitsCOBCoveredAmount_2320
    {
    }
    
    [Serializable()]
    [EdiCodes(",D8,")]
    public class X12_ID_522_AMT_CoordinationOfBenefitsCOBDiscountAmount_2320
    {
    }
    
    [Serializable()]
    [EdiCodes(",DY,")]
    public class X12_ID_522_AMT_CoordinationOfBenefitsCOBPerDayLimitAmount_2320
    {
    }
    
    [Serializable()]
    [EdiCodes(",F5,")]
    public class X12_ID_522_AMT_CoordinationOfBenefitsCOBPatientPaidAmount_2320
    {
    }
    
    [Serializable()]
    [EdiCodes(",T,")]
    public class X12_ID_522_AMT_CoordinationOfBenefitsCOBTaxAmount_2320
    {
    }
    
    [Serializable()]
    [EdiCodes(",T2,")]
    public class X12_ID_522_AMT_CoordinationOfBenefitsCOBTotalClaimBeforeTaxesAmount_2320
    {
    }
    
    [Serializable()]
    [Segment("AMT", typeof(X12_ID_522_AMT_CoordinationOfBenefitsCOBTotalClaimBeforeTaxesAmount_2320))]
    public class AMT_CoordinationOfBenefitsCOBTotalClaimBeforeTaxesAmount_2320
    {
        
        [Required]
        [DataElement("522", typeof(X12_ID_522_AMT_CoordinationOfBenefitsCOBTotalClaimBeforeTaxesAmount_2320))]
        [Pos(1)]
        public string AmountQualifierCode_01 { get; set; }
        [Required]
        [DataElement("", typeof(X12_R))]
        [Pos(2)]
        public string OtherPayerPreTaxClaimTotalAmount_02 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_ID))]
        [Pos(3)]
        public string AMT_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("AMT", typeof(X12_ID_522_AMT_CoordinationOfBenefitsCOBTaxAmount_2320))]
    public class AMT_CoordinationOfBenefitsCOBTaxAmount_2320
    {
        
        [Required]
        [DataElement("522", typeof(X12_ID_522_AMT_CoordinationOfBenefitsCOBTaxAmount_2320))]
        [Pos(1)]
        public string AmountQualifierCode_01 { get; set; }
        [Required]
        [DataElement("", typeof(X12_R))]
        [Pos(2)]
        public string OtherPayerTaxAmount_02 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_ID))]
        [Pos(3)]
        public string AMT_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("AMT", typeof(X12_ID_522_AMT_CoordinationOfBenefitsCOBPatientPaidAmount_2320))]
    public class AMT_CoordinationOfBenefitsCOBPatientPaidAmount_2320
    {
        
        [Required]
        [DataElement("522", typeof(X12_ID_522_AMT_CoordinationOfBenefitsCOBPatientPaidAmount_2320))]
        [Pos(1)]
        public string AmountQualifierCode_01 { get; set; }
        [Required]
        [DataElement("", typeof(X12_R))]
        [Pos(2)]
        public string OtherPayerPatientPaidAmount_02 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_ID))]
        [Pos(3)]
        public string AMT_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("AMT", typeof(X12_ID_522_AMT_CoordinationOfBenefitsCOBPerDayLimitAmount_2320))]
    public class AMT_CoordinationOfBenefitsCOBPerDayLimitAmount_2320
    {
        
        [Required]
        [DataElement("522", typeof(X12_ID_522_AMT_CoordinationOfBenefitsCOBPerDayLimitAmount_2320))]
        [Pos(1)]
        public string AmountQualifierCode_01 { get; set; }
        [Required]
        [DataElement("", typeof(X12_R))]
        [Pos(2)]
        public string OtherPayerPerDayLimitAmount_02 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_ID))]
        [Pos(3)]
        public string AMT_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("AMT", typeof(X12_ID_522_AMT_CoordinationOfBenefitsCOBDiscountAmount_2320))]
    public class AMT_CoordinationOfBenefitsCOBDiscountAmount_2320
    {
        
        [Required]
        [DataElement("522", typeof(X12_ID_522_AMT_CoordinationOfBenefitsCOBDiscountAmount_2320))]
        [Pos(1)]
        public string AmountQualifierCode_01 { get; set; }
        [Required]
        [DataElement("", typeof(X12_R))]
        [Pos(2)]
        public string OtherPayerDiscountAmount_02 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_ID))]
        [Pos(3)]
        public string AMT_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("AMT", typeof(X12_ID_522_AMT_CoordinationOfBenefitsCOBCoveredAmount_2320))]
    public class AMT_CoordinationOfBenefitsCOBCoveredAmount_2320
    {
        
        [Required]
        [DataElement("522", typeof(X12_ID_522_AMT_CoordinationOfBenefitsCOBCoveredAmount_2320))]
        [Pos(1)]
        public string AmountQualifierCode_01 { get; set; }
        [Required]
        [DataElement("", typeof(X12_R))]
        [Pos(2)]
        public string OtherPayerCoveredAmount_02 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_ID))]
        [Pos(3)]
        public string AMT_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("AMT", typeof(X12_ID_522_AMT_CoordinationOfBenefitsCOBPatientResponsibilityAmount_2320))]
    public class AMT_CoordinationOfBenefitsCOBPatientResponsibilityAmount_2320
    {
        
        [Required]
        [DataElement("522", typeof(X12_ID_522_AMT_CoordinationOfBenefitsCOBPatientResponsibilityAmount_2320))]
        [Pos(1)]
        public string AmountQualifierCode_01 { get; set; }
        [Required]
        [DataElement("", typeof(X12_R))]
        [Pos(2)]
        public string OtherPayerPatientResponsibilityAmount_02 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_ID))]
        [Pos(3)]
        public string AMT_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("AMT", typeof(X12_ID_522_AMT_CoordinationOfBenefitsCOBAllowedAmount_2320))]
    public class AMT_CoordinationOfBenefitsCOBAllowedAmount_2320
    {
        
        [Required]
        [DataElement("522", typeof(X12_ID_522_AMT_CoordinationOfBenefitsCOBAllowedAmount_2320))]
        [Pos(1)]
        public string AmountQualifierCode_01 { get; set; }
        [Required]
        [DataElement("", typeof(X12_R))]
        [Pos(2)]
        public string AllowedAmount_02 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_ID))]
        [Pos(3)]
        public string AMT_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("AMT", typeof(X12_ID_522_AMT_CoordinationOfBenefitsCOBApprovedAmount_2320))]
    public class AMT_CoordinationOfBenefitsCOBApprovedAmount_2320
    {
        
        [Required]
        [DataElement("522", typeof(X12_ID_522_AMT_CoordinationOfBenefitsCOBApprovedAmount_2320))]
        [Pos(1)]
        public string AmountQualifierCode_01 { get; set; }
        [Required]
        [DataElement("", typeof(X12_R))]
        [Pos(2)]
        public string ApprovedAmount_02 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_ID))]
        [Pos(3)]
        public string AMT_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("AMT", typeof(X12_ID_522_AMT_CoordinationOfBenefitsCOBPayerPaidAmount_2320))]
    public class AMT_CoordinationOfBenefitsCOBPayerPaidAmount_2320
    {
        
        [Required]
        [DataElement("522", typeof(X12_ID_522_AMT_CoordinationOfBenefitsCOBPayerPaidAmount_2320))]
        [Pos(1)]
        public string AmountQualifierCode_01 { get; set; }
        [Required]
        [DataElement("", typeof(X12_R))]
        [Pos(2)]
        public string PayerPaidAmount_02 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_ID))]
        [Pos(3)]
        public string AMT_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("CAS", typeof(X12_ID_1033_CAS_ClaimLevelAdjustments_2320))]
    public class CAS_ClaimLevelAdjustments_2320
    {
        
        [Required]
        [DataElement("1033", typeof(X12_ID_1033_CAS_ClaimLevelAdjustments_2320))]
        [Pos(1)]
        public string ClaimAdjustmentGroupCode_01 { get; set; }
        [Required]
        [StringLength(1, 5)]
        [DataElement("", typeof(X12_ID))]
        [Pos(2)]
        public string AdjustmentReasonCode_02 { get; set; }
        [Required]
        [DataElement("", typeof(X12_R))]
        [Pos(3)]
        public string AdjustmentAmount_03 { get; set; }
        [DataElement("", typeof(X12_R))]
        [Pos(4)]
        public string AdjustmentQuantity_04 { get; set; }
        [StringLength(1, 5)]
        [DataElement("", typeof(X12_ID))]
        [Pos(5)]
        public string AdjustmentReasonCode_05 { get; set; }
        [DataElement("", typeof(X12_R))]
        [Pos(6)]
        public string AdjustmentAmount_06 { get; set; }
        [DataElement("", typeof(X12_R))]
        [Pos(7)]
        public string AdjustmentQuantity_07 { get; set; }
        [StringLength(1, 5)]
        [DataElement("", typeof(X12_ID))]
        [Pos(8)]
        public string AdjustmentReasonCode_08 { get; set; }
        [DataElement("", typeof(X12_R))]
        [Pos(9)]
        public string AdjustmentAmount_09 { get; set; }
        [DataElement("", typeof(X12_R))]
        [Pos(10)]
        public string AdjustmentQuantity_10 { get; set; }
        [StringLength(1, 5)]
        [DataElement("", typeof(X12_ID))]
        [Pos(11)]
        public string AdjustmentReasonCode_11 { get; set; }
        [DataElement("", typeof(X12_R))]
        [Pos(12)]
        public string AdjustmentAmount_12 { get; set; }
        [DataElement("", typeof(X12_R))]
        [Pos(13)]
        public string AdjustmentQuantity_13 { get; set; }
        [StringLength(1, 5)]
        [DataElement("", typeof(X12_ID))]
        [Pos(14)]
        public string AdjustmentReasonCode_14 { get; set; }
        [DataElement("", typeof(X12_R))]
        [Pos(15)]
        public string AdjustmentAmount_15 { get; set; }
        [DataElement("", typeof(X12_R))]
        [Pos(16)]
        public string AdjustmentQuantity_16 { get; set; }
        [StringLength(1, 5)]
        [DataElement("", typeof(X12_ID))]
        [Pos(17)]
        public string AdjustmentReasonCode_17 { get; set; }
        [DataElement("", typeof(X12_R))]
        [Pos(18)]
        public string AdjustmentAmount_18 { get; set; }
        [DataElement("", typeof(X12_R))]
        [Pos(19)]
        public string AdjustmentQuantity_19 { get; set; }
    }
    
    [Serializable()]
    [Segment("SBR", typeof(X12_ID_1138_SBR_OtherSubscriberInformation_2320), typeof(X12_ID_1069_SBR_OtherSubscriberInformation_2320))]
    public class SBR_OtherSubscriberInformation_2320
    {
        
        [Required]
        [DataElement("1138", typeof(X12_ID_1138_SBR_OtherSubscriberInformation_2320))]
        [Pos(1)]
        public string PayerResponsibilitySequenceNumberCode_01 { get; set; }
        [Required]
        [DataElement("1069", typeof(X12_ID_1069_SBR_OtherSubscriberInformation_2320))]
        [Pos(2)]
        public string IndividualRelationshipCode_02 { get; set; }
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string InsuredGroupOrPolicyNumber_03 { get; set; }
        [StringLength(1, 60)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string OtherInsuredGroupName_04 { get; set; }
        [Required]
        [DataElement("1336", typeof(X12_ID_1336_SBR_OtherSubscriberInformation_2320))]
        [Pos(5)]
        public string InsuranceTypeCode_05 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_ID))]
        [Pos(6)]
        public string SBR_06 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_ID))]
        [Pos(7)]
        public string SBR_07 { get; set; }
        [StringLength(2, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(8)]
        public string SBR_08 { get; set; }
        [DataElement("1032", typeof(X12_ID_1032_SBR_OtherSubscriberInformation_2320))]
        [Pos(9)]
        public string ClaimFilingIndicatorCode_09 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",AP,C1,CP,GP,HM,IP,LD,LT,MB,MC,MI,MP,OT,PP,SP,")]
    public class X12_ID_1336_SBR_OtherSubscriberInformation_2320
    {
    }
    
    [Serializable()]
    [EdiCodes(",09,10,11,12,13,14,15,16,AM,BL,CH,CI,DS,HM,LI,LM,MB,MC,OF,TV,VA,WC,ZZ,")]
    public class X12_ID_1032_SBR_OtherSubscriberInformation_2320
    {
    }
    
    [Serializable()]
    [All()]
    public class All_2310
    {
        
        [ListCount(2)]
        [Pos(1)]
        public List<Loop_2310A> Loop_2310A { get; set; }
        [Pos(2)]
        public Loop_2310B Loop_2310B { get; set; }
        [Pos(3)]
        public Loop_2310C Loop_2310C { get; set; }
        [Pos(4)]
        public Loop_2310D Loop_2310D { get; set; }
        [Pos(5)]
        public Loop_2310E Loop_2310E { get; set; }
    }
    
    [Serializable()]
    [Group("NM1")]
    public class Loop_2310E
    {
        
        [Required]
        [Pos(1)]
        public NM1_SupervisingProviderName_2310E NM1_SupervisingProviderName_2310E { get; set; }
        [ListCount(5)]
        [Pos(2)]
        public List<REF_SupervisingProviderSecondaryIdentification_2310E> REF_SupervisingProviderSecondaryIdentification_2310E { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",DQ,")]
    public class X12_ID_98_NM1_SupervisingProviderName_2310E
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,")]
    public class X12_ID_1065_NM1_SupervisingProviderName_2310E
    {
    }
    
    [Serializable()]
    [EdiCodes(",0B,1B,1C,1D,1G,1H,EI,G2,LU,N5,SY,X5,")]
    public class X12_ID_128_REF_SupervisingProviderSecondaryIdentification_2310E
    {
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_REF_SupervisingProviderSecondaryIdentification_2310E))]
    public class REF_SupervisingProviderSecondaryIdentification_2310E
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_REF_SupervisingProviderSecondaryIdentification_2310E))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(2)]
        public string SupervisingProviderSecondaryIdentifier_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string REF_03 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string REF_04 { get; set; }
    }
    
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_NM1_SupervisingProviderName_2310E), typeof(X12_ID_1065_NM1_SupervisingProviderName_2310E))]
    public class NM1_SupervisingProviderName_2310E
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98_NM1_SupervisingProviderName_2310E))]
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        [Required]
        [DataElement("1065", typeof(X12_ID_1065_NM1_SupervisingProviderName_2310E))]
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        [Required]
        [StringLength(1, 35)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string SupervisingProviderLastName_03 { get; set; }
        [Required]
        [StringLength(1, 25)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string SupervisingProviderFirstName_04 { get; set; }
        [StringLength(1, 25)]
        [DataElement("", typeof(X12_AN))]
        [Pos(5)]
        public string SupervisingProviderMiddleName_05 { get; set; }
        [StringLength(1, 10)]
        [DataElement("", typeof(X12_AN))]
        [Pos(6)]
        public string NM1_06 { get; set; }
        [StringLength(1, 10)]
        [DataElement("", typeof(X12_AN))]
        [Pos(7)]
        public string SupervisingProviderNameSuffix_07 { get; set; }
        [DataElement("66", typeof(X12_ID_66_NM1_SupervisingProviderName_2310E))]
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        [StringLength(2, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(9)]
        public string SupervisingProviderIdentifier_09 { get; set; }
        [StringLength(2, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(10)]
        public string NM1_10 { get; set; }
        [StringLength(2, 3)]
        [DataElement("", typeof(X12_ID))]
        [Pos(11)]
        public string NM1_11 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",24,34,XX,")]
    public class X12_ID_66_NM1_SupervisingProviderName_2310E
    {
    }
    
    [Serializable()]
    [Group("NM1")]
    public class Loop_2310D
    {
        
        [Required]
        [Pos(1)]
        public NM1_ServiceFacilityLocation_2310D NM1_ServiceFacilityLocation_2310D { get; set; }
        [Required]
        [Pos(2)]
        public N3_ServiceFacilityLocationAddress_2310D N3_ServiceFacilityLocationAddress_2310D { get; set; }
        [Required]
        [Pos(3)]
        public N4_ServiceFacilityLocationCityStateZIP_2310D N4_ServiceFacilityLocationCityStateZIP_2310D { get; set; }
        [ListCount(5)]
        [Pos(4)]
        public List<REF_ServiceFacilityLocationSecondaryIdentification_2310D> REF_ServiceFacilityLocationSecondaryIdentification_2310D { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",77,FA,LI,TL,")]
    public class X12_ID_98_NM1_ServiceFacilityLocation_2310D
    {
    }
    
    [Serializable()]
    [EdiCodes(",2,")]
    public class X12_ID_1065_NM1_ServiceFacilityLocation_2310D
    {
    }
    
    [Serializable()]
    [EdiCodes(",0B,1A,1B,1C,1D,1G,1H,G2,LU,N5,TJ,X4,X5,")]
    public class X12_ID_128_REF_ServiceFacilityLocationSecondaryIdentification_2310D
    {
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_REF_ServiceFacilityLocationSecondaryIdentification_2310D))]
    public class REF_ServiceFacilityLocationSecondaryIdentification_2310D
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_REF_ServiceFacilityLocationSecondaryIdentification_2310D))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(2)]
        public string LaboratoryOrFacilitySecondaryIdentifier_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string REF_03 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string REF_04 { get; set; }
    }
    
    [Serializable()]
    [Segment("N4")]
    public class N4_ServiceFacilityLocationCityStateZIP_2310D
    {
        
        [Required]
        [StringLength(2, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(1)]
        public string LaboratoryOrFacilityCityName_01 { get; set; }
        [Required]
        [StringLength(2, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(2)]
        public string LaboratoryOrFacilityStateOrProvinceCode_02 { get; set; }
        [Required]
        [StringLength(3, 15)]
        [DataElement("", typeof(X12_ID))]
        [Pos(3)]
        public string LaboratoryOrFacilityPostalZoneOrZIPCode_03 { get; set; }
        [StringLength(2, 3)]
        [DataElement("", typeof(X12_ID))]
        [Pos(4)]
        public string CountryCode_04 { get; set; }
        [StringLength(1, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(5)]
        public string N4_05 { get; set; }
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(6)]
        public string N4_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("N3")]
    public class N3_ServiceFacilityLocationAddress_2310D
    {
        
        [Required]
        [StringLength(1, 55)]
        [DataElement("", typeof(X12_AN))]
        [Pos(1)]
        public string LaboratoryOrFacilityAddressLine_01 { get; set; }
        [StringLength(1, 55)]
        [DataElement("", typeof(X12_AN))]
        [Pos(2)]
        public string LaboratoryOrFacilityAddressLine_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_NM1_ServiceFacilityLocation_2310D), typeof(X12_ID_1065_NM1_ServiceFacilityLocation_2310D))]
    public class NM1_ServiceFacilityLocation_2310D
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98_NM1_ServiceFacilityLocation_2310D))]
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        [Required]
        [DataElement("1065", typeof(X12_ID_1065_NM1_ServiceFacilityLocation_2310D))]
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        [StringLength(1, 35)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string LaboratoryOrFacilityName_03 { get; set; }
        [StringLength(1, 25)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string NM1_04 { get; set; }
        [StringLength(1, 25)]
        [DataElement("", typeof(X12_AN))]
        [Pos(5)]
        public string NM1_05 { get; set; }
        [StringLength(1, 10)]
        [DataElement("", typeof(X12_AN))]
        [Pos(6)]
        public string NM1_06 { get; set; }
        [StringLength(1, 10)]
        [DataElement("", typeof(X12_AN))]
        [Pos(7)]
        public string NM1_07 { get; set; }
        [DataElement("66", typeof(X12_ID_66_NM1_ServiceFacilityLocation_2310D))]
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        [StringLength(2, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(9)]
        public string LaboratoryOrFacilityPrimaryIdentifier_09 { get; set; }
        [StringLength(2, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(10)]
        public string NM1_10 { get; set; }
        [StringLength(2, 3)]
        [DataElement("", typeof(X12_ID))]
        [Pos(11)]
        public string NM1_11 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",24,34,XX,")]
    public class X12_ID_66_NM1_ServiceFacilityLocation_2310D
    {
    }
    
    [Serializable()]
    [Group("NM1")]
    public class Loop_2310C
    {
        
        [Required]
        [Pos(1)]
        public NM1_PurchasedServiceProviderName_2310C NM1_PurchasedServiceProviderName_2310C { get; set; }
        [ListCount(5)]
        [Pos(2)]
        public List<REF_PurchasedServiceProviderSecondaryIdentification_2310C> REF_PurchasedServiceProviderSecondaryIdentification_2310C { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",QB,")]
    public class X12_ID_98_NM1_PurchasedServiceProviderName_2310C
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,")]
    public class X12_ID_1065_NM1_PurchasedServiceProviderName_2310C
    {
    }
    
    [Serializable()]
    [EdiCodes(",0B,1A,1B,1C,1D,1G,1H,EI,G2,LU,N5,SY,U3,X5,")]
    public class X12_ID_128_REF_PurchasedServiceProviderSecondaryIdentification_2310C
    {
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_REF_PurchasedServiceProviderSecondaryIdentification_2310C))]
    public class REF_PurchasedServiceProviderSecondaryIdentification_2310C
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_REF_PurchasedServiceProviderSecondaryIdentification_2310C))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(2)]
        public string PurchasedServiceProviderSecondaryIdentifier_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string REF_03 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string REF_04 { get; set; }
    }
    
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_NM1_PurchasedServiceProviderName_2310C), typeof(X12_ID_1065_NM1_PurchasedServiceProviderName_2310C))]
    public class NM1_PurchasedServiceProviderName_2310C
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98_NM1_PurchasedServiceProviderName_2310C))]
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        [Required]
        [DataElement("1065", typeof(X12_ID_1065_NM1_PurchasedServiceProviderName_2310C))]
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        [Required]
        [StringLength(1, 35)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string PurchasedServiceProviderLastOrOrganizationName_03 { get; set; }
        [StringLength(1, 25)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string PurchasedServiceProviderFirstName_04 { get; set; }
        [StringLength(1, 25)]
        [DataElement("", typeof(X12_AN))]
        [Pos(5)]
        public string PurchasedServiceProviderMiddleName_05 { get; set; }
        [StringLength(1, 10)]
        [DataElement("", typeof(X12_AN))]
        [Pos(6)]
        public string NM1_06 { get; set; }
        [StringLength(1, 10)]
        [DataElement("", typeof(X12_AN))]
        [Pos(7)]
        public string NM1_07 { get; set; }
        [DataElement("66", typeof(X12_ID_66_NM1_PurchasedServiceProviderName_2310C))]
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        [StringLength(2, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(9)]
        public string PurchasedServiceProviderIdentifier_09 { get; set; }
        [StringLength(2, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(10)]
        public string NM1_10 { get; set; }
        [StringLength(2, 3)]
        [DataElement("", typeof(X12_ID))]
        [Pos(11)]
        public string NM1_11 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",24,34,XX,")]
    public class X12_ID_66_NM1_PurchasedServiceProviderName_2310C
    {
    }
    
    [Serializable()]
    [Group("NM1")]
    public class Loop_2310B
    {
        
        [Required]
        [Pos(1)]
        public NM1_RenderingProviderName_2310B NM1_RenderingProviderName_2310B { get; set; }
        [Pos(2)]
        public PRV_RenderingProviderSpecialtyInformation_2310B PRV_RenderingProviderSpecialtyInformation_2310B { get; set; }
        [ListCount(5)]
        [Pos(3)]
        public List<REF_RenderingProviderSecondaryIdentification_2310B> REF_RenderingProviderSecondaryIdentification_2310B { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",82,")]
    public class X12_ID_98_NM1_RenderingProviderName_2310B
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,")]
    public class X12_ID_1065_NM1_RenderingProviderName_2310B
    {
    }
    
    [Serializable()]
    [EdiCodes(",PE,")]
    public class X12_ID_1221_PRV_RenderingProviderSpecialtyInformation_2310B
    {
    }
    
    [Serializable()]
    [EdiCodes(",ZZ,")]
    public class X12_ID_128_PRV_RenderingProviderSpecialtyInformation_2310B
    {
    }
    
    [Serializable()]
    [EdiCodes(",0B,1B,1C,1D,1G,1H,EI,G2,LU,N5,SY,X5,")]
    public class X12_ID_128_REF_RenderingProviderSecondaryIdentification_2310B
    {
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_REF_RenderingProviderSecondaryIdentification_2310B))]
    public class REF_RenderingProviderSecondaryIdentification_2310B
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_REF_RenderingProviderSecondaryIdentification_2310B))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(2)]
        public string RenderingProviderSecondaryIdentifier_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string REF_03 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string REF_04 { get; set; }
    }
    
    [Serializable()]
    [Segment("PRV", typeof(X12_ID_1221_PRV_RenderingProviderSpecialtyInformation_2310B), typeof(X12_ID_128_PRV_RenderingProviderSpecialtyInformation_2310B))]
    public class PRV_RenderingProviderSpecialtyInformation_2310B
    {
        
        [Required]
        [DataElement("1221", typeof(X12_ID_1221_PRV_RenderingProviderSpecialtyInformation_2310B))]
        [Pos(1)]
        public string ProviderCode_01 { get; set; }
        [Required]
        [DataElement("128", typeof(X12_ID_128_PRV_RenderingProviderSpecialtyInformation_2310B))]
        [Pos(2)]
        public string ReferenceIdentificationQualifier_02 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string ProviderTaxonomyCode_03 { get; set; }
        [StringLength(2, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(4)]
        public string PRV_04 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_AN))]
        [Pos(5)]
        public string PRV_05 { get; set; }
        [StringLength(3, 3)]
        [DataElement("", typeof(X12_ID))]
        [Pos(6)]
        public string PRV_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_NM1_RenderingProviderName_2310B), typeof(X12_ID_1065_NM1_RenderingProviderName_2310B))]
    public class NM1_RenderingProviderName_2310B
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98_NM1_RenderingProviderName_2310B))]
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        [Required]
        [DataElement("1065", typeof(X12_ID_1065_NM1_RenderingProviderName_2310B))]
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        [Required]
        [StringLength(1, 35)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string RenderingProviderLastOrOrganizationName_03 { get; set; }
        [StringLength(1, 25)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string RenderingProviderFirstName_04 { get; set; }
        [StringLength(1, 25)]
        [DataElement("", typeof(X12_AN))]
        [Pos(5)]
        public string RenderingProviderMiddleName_05 { get; set; }
        [StringLength(1, 10)]
        [DataElement("", typeof(X12_AN))]
        [Pos(6)]
        public string NM1_06 { get; set; }
        [StringLength(1, 10)]
        [DataElement("", typeof(X12_AN))]
        [Pos(7)]
        public string RenderingProviderNameSuffix_07 { get; set; }
        [Required]
        [DataElement("66", typeof(X12_ID_66_NM1_RenderingProviderName_2310B))]
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        [Required]
        [StringLength(2, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(9)]
        public string RenderingProviderIdentifier_09 { get; set; }
        [StringLength(2, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(10)]
        public string NM1_10 { get; set; }
        [StringLength(2, 3)]
        [DataElement("", typeof(X12_ID))]
        [Pos(11)]
        public string NM1_11 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",24,34,XX,")]
    public class X12_ID_66_NM1_RenderingProviderName_2310B
    {
    }
    
    [Serializable()]
    [Group("NM1")]
    public class Loop_2310A
    {
        
        [Required]
        [Pos(1)]
        public NM1_ReferringProviderName_2310A NM1_ReferringProviderName_2310A { get; set; }
        [Pos(2)]
        public PRV_ReferringProviderSpecialtyInformation_2310A PRV_ReferringProviderSpecialtyInformation_2310A { get; set; }
        [ListCount(5)]
        [Pos(3)]
        public List<REF_ReferringProviderSecondaryIdentification_2310A> REF_ReferringProviderSecondaryIdentification_2310A { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",DN,P3,")]
    public class X12_ID_98_NM1_ReferringProviderName_2310A
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,")]
    public class X12_ID_1065_NM1_ReferringProviderName_2310A
    {
    }
    
    [Serializable()]
    [EdiCodes(",RF,")]
    public class X12_ID_1221_PRV_ReferringProviderSpecialtyInformation_2310A
    {
    }
    
    [Serializable()]
    [EdiCodes(",ZZ,")]
    public class X12_ID_128_PRV_ReferringProviderSpecialtyInformation_2310A
    {
    }
    
    [Serializable()]
    [EdiCodes(",0B,1B,1C,1D,1G,1H,EI,G2,LU,N5,SY,X5,")]
    public class X12_ID_128_REF_ReferringProviderSecondaryIdentification_2310A
    {
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_REF_ReferringProviderSecondaryIdentification_2310A))]
    public class REF_ReferringProviderSecondaryIdentification_2310A
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_REF_ReferringProviderSecondaryIdentification_2310A))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(2)]
        public string ReferringProviderSecondaryIdentifier_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string REF_03 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string REF_04 { get; set; }
    }
    
    [Serializable()]
    [Segment("PRV", typeof(X12_ID_1221_PRV_ReferringProviderSpecialtyInformation_2310A), typeof(X12_ID_128_PRV_ReferringProviderSpecialtyInformation_2310A))]
    public class PRV_ReferringProviderSpecialtyInformation_2310A
    {
        
        [Required]
        [DataElement("1221", typeof(X12_ID_1221_PRV_ReferringProviderSpecialtyInformation_2310A))]
        [Pos(1)]
        public string ProviderCode_01 { get; set; }
        [Required]
        [DataElement("128", typeof(X12_ID_128_PRV_ReferringProviderSpecialtyInformation_2310A))]
        [Pos(2)]
        public string ReferenceIdentificationQualifier_02 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string ProviderTaxonomyCode_03 { get; set; }
        [StringLength(2, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(4)]
        public string PRV_04 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_AN))]
        [Pos(5)]
        public string PRV_05 { get; set; }
        [StringLength(3, 3)]
        [DataElement("", typeof(X12_ID))]
        [Pos(6)]
        public string PRV_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_NM1_ReferringProviderName_2310A), typeof(X12_ID_1065_NM1_ReferringProviderName_2310A))]
    public class NM1_ReferringProviderName_2310A
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98_NM1_ReferringProviderName_2310A))]
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        [Required]
        [DataElement("1065", typeof(X12_ID_1065_NM1_ReferringProviderName_2310A))]
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        [Required]
        [StringLength(1, 35)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string ReferringProviderLastName_03 { get; set; }
        [StringLength(1, 25)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string ReferringProviderFirstName_04 { get; set; }
        [StringLength(1, 25)]
        [DataElement("", typeof(X12_AN))]
        [Pos(5)]
        public string ReferringProviderMiddleName_05 { get; set; }
        [StringLength(1, 10)]
        [DataElement("", typeof(X12_AN))]
        [Pos(6)]
        public string NM1_06 { get; set; }
        [StringLength(1, 10)]
        [DataElement("", typeof(X12_AN))]
        [Pos(7)]
        public string ReferringProviderNameSuffix_07 { get; set; }
        [DataElement("66", typeof(X12_ID_66_NM1_ReferringProviderName_2310A))]
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        [StringLength(2, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(9)]
        public string ReferringProviderIdentifier_09 { get; set; }
        [StringLength(2, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(10)]
        public string NM1_10 { get; set; }
        [StringLength(2, 3)]
        [DataElement("", typeof(X12_ID))]
        [Pos(11)]
        public string NM1_11 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",24,34,XX,")]
    public class X12_ID_66_NM1_ReferringProviderName_2310A
    {
    }
    
    [Serializable()]
    [Group("CR7")]
    public class Loop_2305
    {
        
        [Required]
        [Pos(1)]
        public CR7_HomeHealthCarePlanInformation_2305 CR7_HomeHealthCarePlanInformation_2305 { get; set; }
        [ListCount(3)]
        [Pos(2)]
        public List<HSD_HealthCareServicesDelivery_2305> HSD_HealthCareServicesDelivery_2305 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",AI,MS,OT,PT,SN,ST,")]
    public class X12_ID_921_CR7_HomeHealthCarePlanInformation_2305
    {
    }
    
    [Serializable()]
    [EdiCodes(",VS,")]
    public class X12_ID_673_HSD_HealthCareServicesDelivery_2305
    {
    }
    
    [Serializable()]
    [Segment("HSD", typeof(X12_ID_673_HSD_HealthCareServicesDelivery_2305))]
    public class HSD_HealthCareServicesDelivery_2305
    {
        
        [DataElement("673", typeof(X12_ID_673_HSD_HealthCareServicesDelivery_2305))]
        [Pos(1)]
        public string Visits_01 { get; set; }
        [DataElement("", typeof(X12_R))]
        [Pos(2)]
        public string NumberOfVisits_02 { get; set; }
        [DataElement("355", typeof(X12_ID_355_HSD_HealthCareServicesDelivery_2305))]
        [Pos(3)]
        public string FrequencyPeriod_03 { get; set; }
        [DataElement("", typeof(X12_R))]
        [Pos(4)]
        public string FrequencyCount_04 { get; set; }
        [DataElement("615", typeof(X12_ID_615_HSD_HealthCareServicesDelivery_2305))]
        [Pos(5)]
        public string DurationOfVisitsUnits_05 { get; set; }
        [DataElement("", typeof(X12_N0))]
        [Pos(6)]
        public string DurationOfVisitsNumberOfUnits_06 { get; set; }
        [DataElement("678", typeof(X12_ID_678_HSD_HealthCareServicesDelivery_2305))]
        [Pos(7)]
        public string ShipDeliveryOrCalendarPatternCode_07 { get; set; }
        [DataElement("679", typeof(X12_ID_679_HSD_HealthCareServicesDelivery_2305))]
        [Pos(8)]
        public string DeliveryPatternTimeCode_08 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",DA,MO,Q1,WK,")]
    public class X12_ID_355_HSD_HealthCareServicesDelivery_2305
    {
    }
    
    [Serializable()]
    [EdiCodes(",7,35,")]
    public class X12_ID_615_HSD_HealthCareServicesDelivery_2305
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,3,4,5,6,7,A,B,C,D,E,F,G,H,J,K,L,N,O,S,W,SA,SB,SC,SD,SG,SL,SP,SX,SY,SZ,")]
    public class X12_ID_678_HSD_HealthCareServicesDelivery_2305
    {
    }
    
    [Serializable()]
    [EdiCodes(",D,E,F,")]
    public class X12_ID_679_HSD_HealthCareServicesDelivery_2305
    {
    }
    
    [Serializable()]
    [Segment("CR7", typeof(X12_ID_921_CR7_HomeHealthCarePlanInformation_2305))]
    public class CR7_HomeHealthCarePlanInformation_2305
    {
        
        [Required]
        [DataElement("921", typeof(X12_ID_921_CR7_HomeHealthCarePlanInformation_2305))]
        [Pos(1)]
        public string DisciplineTypeCode_01 { get; set; }
        [Required]
        [DataElement("", typeof(X12_N0))]
        [Pos(2)]
        public string TotalVisitsRenderedCount_02 { get; set; }
        [Required]
        [DataElement("", typeof(X12_N0))]
        [Pos(3)]
        public string CertificationPeriodProjectedVisitCount_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("HCP", typeof(X12_ID_1473_HCP_ClaimPricingRepricingInformation_2300))]
    public class HCP_ClaimPricingRepricingInformation_2300
    {
        
        [Required]
        [DataElement("1473", typeof(X12_ID_1473_HCP_ClaimPricingRepricingInformation_2300))]
        [Pos(1)]
        public string PricingMethodology_01 { get; set; }
        [Required]
        [DataElement("", typeof(X12_R))]
        [Pos(2)]
        public string RepricedAllowedAmount_02 { get; set; }
        [DataElement("", typeof(X12_R))]
        [Pos(3)]
        public string RepricedSavingAmount_03 { get; set; }
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string RepricingOrganizationIdentifier_04 { get; set; }
        [DataElement("", typeof(X12_R))]
        [Pos(5)]
        public string RepricingPerDiemOrFlatRateAmount_05 { get; set; }
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(6)]
        public string RepricedApprovedAmbulatoryPatientGroupCode_06 { get; set; }
        [DataElement("", typeof(X12_R))]
        [Pos(7)]
        public string RepricedApprovedAmbulatoryPatientGroupAmount_07 { get; set; }
        [StringLength(1, 48)]
        [DataElement("", typeof(X12_AN))]
        [Pos(8)]
        public string HCP_08 { get; set; }
        [StringLength(2, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(9)]
        public string HCP_09 { get; set; }
        [StringLength(1, 48)]
        [DataElement("", typeof(X12_AN))]
        [Pos(10)]
        public string HCP_10 { get; set; }
        [StringLength(2, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(11)]
        public string HCP_11 { get; set; }
        [DataElement("", typeof(X12_R))]
        [Pos(12)]
        public string HCP_12 { get; set; }
        [DataElement("901", typeof(X12_ID_901_HCP_ClaimPricingRepricingInformation_2300))]
        [Pos(13)]
        public string RejectReasonCode_13 { get; set; }
        [DataElement("1526", typeof(X12_ID_1526_HCP_ClaimPricingRepricingInformation_2300))]
        [Pos(14)]
        public string PolicyComplianceCode_14 { get; set; }
        [DataElement("1527", typeof(X12_ID_1527_HCP_ClaimPricingRepricingInformation_2300))]
        [Pos(15)]
        public string ExceptionCode_15 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",T1,T2,T3,T4,T5,T6,")]
    public class X12_ID_901_HCP_ClaimPricingRepricingInformation_2300
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,3,4,5,")]
    public class X12_ID_1526_HCP_ClaimPricingRepricingInformation_2300
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,3,4,5,6,")]
    public class X12_ID_1527_HCP_ClaimPricingRepricingInformation_2300
    {
    }
    
    [Serializable()]
    [Segment("HI", typeof(X12_ID_1270_C022_57917336), typeof(X12_ID_1270_C022_1220782286))]
    public class HI_HealthCareDiagnosisCode_2300
    {
        
        [Required]
        [Pos(1)]
        public C022_57917336 C022_57917336 { get; set; }
        [Pos(2)]
        public C022_1220782286 C022_1220782286 { get; set; }
        [Pos(3)]
        public C022_1577012646 C022_1577012646 { get; set; }
        [Pos(4)]
        public C022_2026368300 C022_2026368300 { get; set; }
        [Pos(5)]
        public C022_1105734046 C022_1105734046 { get; set; }
        [Pos(6)]
        public C022_57524121 C022_57524121 { get; set; }
        [Pos(7)]
        public C022_1220389071 C022_1220389071 { get; set; }
        [Pos(8)]
        public C022_1576619431 C022_1576619431 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_AN))]
        [Pos(9)]
        public string HI_09 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_AN))]
        [Pos(10)]
        public string HI_10 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_AN))]
        [Pos(11)]
        public string HI_11 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_AN))]
        [Pos(12)]
        public string HI_12 { get; set; }
    }
    
    [Serializable()]
    [Composite("C022_1576619431")]
    public class C022_1576619431
    {
        
        [Required]
        [DataElement("1270", typeof(X12_ID_1270_C022_1576619431))]
        [Pos(1)]
        public string DiagnosisTypeCode_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(2)]
        public string DiagnosisCode_02 { get; set; }
        [StringLength(2, 3)]
        [DataElement("", typeof(X12_ID))]
        [Pos(3)]
        public string HI_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string HI_04 { get; set; }
        [DataElement("", typeof(X12_R))]
        [Pos(5)]
        public string HI_05 { get; set; }
        [DataElement("", typeof(X12_R))]
        [Pos(6)]
        public string HI_06 { get; set; }
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(7)]
        public string HI_07 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",BF,")]
    public class X12_ID_1270_C022_1576619431
    {
    }
    
    [Serializable()]
    [Composite("C022_1220389071")]
    public class C022_1220389071
    {
        
        [Required]
        [DataElement("1270", typeof(X12_ID_1270_C022_1220389071))]
        [Pos(1)]
        public string DiagnosisTypeCode_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(2)]
        public string DiagnosisCode_02 { get; set; }
        [StringLength(2, 3)]
        [DataElement("", typeof(X12_ID))]
        [Pos(3)]
        public string HI_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string HI_04 { get; set; }
        [DataElement("", typeof(X12_R))]
        [Pos(5)]
        public string HI_05 { get; set; }
        [DataElement("", typeof(X12_R))]
        [Pos(6)]
        public string HI_06 { get; set; }
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(7)]
        public string HI_07 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",BF,")]
    public class X12_ID_1270_C022_1220389071
    {
    }
    
    [Serializable()]
    [Composite("C022_57524121")]
    public class C022_57524121
    {
        
        [Required]
        [DataElement("1270", typeof(X12_ID_1270_C022_57524121))]
        [Pos(1)]
        public string DiagnosisTypeCode_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(2)]
        public string DiagnosisCode_02 { get; set; }
        [StringLength(2, 3)]
        [DataElement("", typeof(X12_ID))]
        [Pos(3)]
        public string HI_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string HI_04 { get; set; }
        [DataElement("", typeof(X12_R))]
        [Pos(5)]
        public string HI_05 { get; set; }
        [DataElement("", typeof(X12_R))]
        [Pos(6)]
        public string HI_06 { get; set; }
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(7)]
        public string HI_07 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",BF,")]
    public class X12_ID_1270_C022_57524121
    {
    }
    
    [Serializable()]
    [Composite("C022_1105734046")]
    public class C022_1105734046
    {
        
        [Required]
        [DataElement("1270", typeof(X12_ID_1270_C022_1105734046))]
        [Pos(1)]
        public string DiagnosisTypeCode_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(2)]
        public string DiagnosisCode_02 { get; set; }
        [StringLength(2, 3)]
        [DataElement("", typeof(X12_ID))]
        [Pos(3)]
        public string HI_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string HI_04 { get; set; }
        [DataElement("", typeof(X12_R))]
        [Pos(5)]
        public string HI_05 { get; set; }
        [DataElement("", typeof(X12_R))]
        [Pos(6)]
        public string HI_06 { get; set; }
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(7)]
        public string HI_07 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",BF,")]
    public class X12_ID_1270_C022_1105734046
    {
    }
    
    [Serializable()]
    [Composite("C022_2026368300")]
    public class C022_2026368300
    {
        
        [Required]
        [DataElement("1270", typeof(X12_ID_1270_C022_2026368300))]
        [Pos(1)]
        public string DiagnosisTypeCode_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(2)]
        public string DiagnosisCode_02 { get; set; }
        [StringLength(2, 3)]
        [DataElement("", typeof(X12_ID))]
        [Pos(3)]
        public string HI_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string HI_04 { get; set; }
        [DataElement("", typeof(X12_R))]
        [Pos(5)]
        public string HI_05 { get; set; }
        [DataElement("", typeof(X12_R))]
        [Pos(6)]
        public string HI_06 { get; set; }
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(7)]
        public string HI_07 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",BF,")]
    public class X12_ID_1270_C022_2026368300
    {
    }
    
    [Serializable()]
    [Composite("C022_1577012646")]
    public class C022_1577012646
    {
        
        [Required]
        [DataElement("1270", typeof(X12_ID_1270_C022_1577012646))]
        [Pos(1)]
        public string DiagnosisTypeCode_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(2)]
        public string DiagnosisCode_02 { get; set; }
        [StringLength(2, 3)]
        [DataElement("", typeof(X12_ID))]
        [Pos(3)]
        public string HI_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string HI_04 { get; set; }
        [DataElement("", typeof(X12_R))]
        [Pos(5)]
        public string HI_05 { get; set; }
        [DataElement("", typeof(X12_R))]
        [Pos(6)]
        public string HI_06 { get; set; }
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(7)]
        public string HI_07 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",BF,")]
    public class X12_ID_1270_C022_1577012646
    {
    }
    
    [Serializable()]
    [Composite("C022_1220782286")]
    public class C022_1220782286
    {
        
        [Required]
        [DataElement("1270", typeof(X12_ID_1270_C022_1220782286))]
        [Pos(1)]
        public string DiagnosisTypeCode_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(2)]
        public string DiagnosisCode_02 { get; set; }
        [StringLength(2, 3)]
        [DataElement("", typeof(X12_ID))]
        [Pos(3)]
        public string HI_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string HI_04 { get; set; }
        [DataElement("", typeof(X12_R))]
        [Pos(5)]
        public string HI_05 { get; set; }
        [DataElement("", typeof(X12_R))]
        [Pos(6)]
        public string HI_06 { get; set; }
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(7)]
        public string HI_07 { get; set; }
    }
    
    [Serializable()]
    [Composite("C022_57917336")]
    public class C022_57917336
    {
        
        [Required]
        [DataElement("1270", typeof(X12_ID_1270_C022_57917336))]
        [Pos(1)]
        public string DiagnosisTypeCode_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(2)]
        public string DiagnosisCode_02 { get; set; }
        [StringLength(2, 3)]
        [DataElement("", typeof(X12_ID))]
        [Pos(3)]
        public string HI_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string HI_04 { get; set; }
        [DataElement("", typeof(X12_R))]
        [Pos(5)]
        public string HI_05 { get; set; }
        [DataElement("", typeof(X12_R))]
        [Pos(6)]
        public string HI_06 { get; set; }
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(7)]
        public string HI_07 { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_CRC_2300
    {
        
        [ListCount(3)]
        [Pos(1)]
        public List<CRC_AmbulanceCertification_2300> CRC_AmbulanceCertification_2300 { get; set; }
        [ListCount(3)]
        [Pos(2)]
        public List<CRC_PatientConditionInformationVision_2300> CRC_PatientConditionInformationVision_2300 { get; set; }
        [Pos(3)]
        public CRC_HomeboundIndicator_2300 CRC_HomeboundIndicator_2300 { get; set; }
        [Pos(4)]
        public CRC_EPSDTReferral_2300 CRC_EPSDTReferral_2300 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",07,")]
    public class X12_ID_1136_CRC_AmbulanceCertification_2300
    {
    }
    
    [Serializable()]
    [EdiCodes(",N,Y,")]
    public class X12_ID_1073_CRC_AmbulanceCertification_2300
    {
    }
    
    [Serializable()]
    [EdiCodes(",E1,E2,E3,")]
    public class X12_ID_1136_CRC_PatientConditionInformationVision_2300
    {
    }
    
    [Serializable()]
    [EdiCodes(",N,Y,")]
    public class X12_ID_1073_CRC_PatientConditionInformationVision_2300
    {
    }
    
    [Serializable()]
    [EdiCodes(",75,")]
    public class X12_ID_1136_CRC_HomeboundIndicator_2300
    {
    }
    
    [Serializable()]
    [EdiCodes(",Y,")]
    public class X12_ID_1073_CRC_HomeboundIndicator_2300
    {
    }
    
    [Serializable()]
    [EdiCodes(",ZZ,")]
    public class X12_ID_1136_CRC_EPSDTReferral_2300
    {
    }
    
    [Serializable()]
    [EdiCodes(",N,Y,")]
    public class X12_ID_1073_CRC_EPSDTReferral_2300
    {
    }
    
    [Serializable()]
    [Segment("CRC", typeof(X12_ID_1136_CRC_EPSDTReferral_2300), typeof(X12_ID_1073_CRC_EPSDTReferral_2300))]
    public class CRC_EPSDTReferral_2300
    {
        
        [Required]
        [DataElement("1136", typeof(X12_ID_1136_CRC_EPSDTReferral_2300))]
        [Pos(1)]
        public string CodeCategory_01 { get; set; }
        [Required]
        [DataElement("1073", typeof(X12_ID_1073_CRC_EPSDTReferral_2300))]
        [Pos(2)]
        public string CertificationConditionIndicator_02 { get; set; }
        [Required]
        [DataElement("1321", typeof(X12_ID_1321_CRC_EPSDTReferral_2300))]
        [Pos(3)]
        public string ConditionCode_03 { get; set; }
        [DataElement("1321", typeof(X12_ID_1321_CRC_EPSDTReferral_2300))]
        [Pos(4)]
        public string ConditionCode_04 { get; set; }
        [DataElement("1321", typeof(X12_ID_1321_CRC_EPSDTReferral_2300))]
        [Pos(5)]
        public string ConditionCode_05 { get; set; }
        [StringLength(2, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(6)]
        public string CRC_06 { get; set; }
        [StringLength(2, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(7)]
        public string CRC_07 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",AV,NU,S2,ST,")]
    public class X12_ID_1321_CRC_EPSDTReferral_2300
    {
    }
    
    [Serializable()]
    [Segment("CRC", typeof(X12_ID_1136_CRC_HomeboundIndicator_2300), typeof(X12_ID_1073_CRC_HomeboundIndicator_2300))]
    public class CRC_HomeboundIndicator_2300
    {
        
        [Required]
        [DataElement("1136", typeof(X12_ID_1136_CRC_HomeboundIndicator_2300))]
        [Pos(1)]
        public string CodeCategory_01 { get; set; }
        [Required]
        [DataElement("1073", typeof(X12_ID_1073_CRC_HomeboundIndicator_2300))]
        [Pos(2)]
        public string CertificationConditionIndicator_02 { get; set; }
        [Required]
        [DataElement("1321", typeof(X12_ID_1321_CRC_HomeboundIndicator_2300))]
        [Pos(3)]
        public string HomeboundIndicator_03 { get; set; }
        [StringLength(2, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(4)]
        public string CRC_04 { get; set; }
        [StringLength(2, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(5)]
        public string CRC_05 { get; set; }
        [StringLength(2, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(6)]
        public string CRC_06 { get; set; }
        [StringLength(2, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(7)]
        public string CRC_07 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",IH,")]
    public class X12_ID_1321_CRC_HomeboundIndicator_2300
    {
    }
    
    [Serializable()]
    [Segment("CRC", typeof(X12_ID_1136_CRC_PatientConditionInformationVision_2300), typeof(X12_ID_1073_CRC_PatientConditionInformationVision_2300))]
    public class CRC_PatientConditionInformationVision_2300
    {
        
        [Required]
        [DataElement("1136", typeof(X12_ID_1136_CRC_PatientConditionInformationVision_2300))]
        [Pos(1)]
        public string CodeCategory_01 { get; set; }
        [Required]
        [DataElement("1073", typeof(X12_ID_1073_CRC_PatientConditionInformationVision_2300))]
        [Pos(2)]
        public string CertificationConditionIndicator_02 { get; set; }
        [Required]
        [DataElement("1321", typeof(X12_ID_1321_CRC_PatientConditionInformationVision_2300))]
        [Pos(3)]
        public string ConditionCode_03 { get; set; }
        [DataElement("1321", typeof(X12_ID_1321_CRC_PatientConditionInformationVision_2300))]
        [Pos(4)]
        public string ConditionCode_04 { get; set; }
        [DataElement("1321", typeof(X12_ID_1321_CRC_PatientConditionInformationVision_2300))]
        [Pos(5)]
        public string ConditionCode_05 { get; set; }
        [DataElement("1321", typeof(X12_ID_1321_CRC_PatientConditionInformationVision_2300))]
        [Pos(6)]
        public string ConditionCode_06 { get; set; }
        [DataElement("1321", typeof(X12_ID_1321_CRC_PatientConditionInformationVision_2300))]
        [Pos(7)]
        public string ConditionCode_07 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",L1,L2,L3,L4,L5,")]
    public class X12_ID_1321_CRC_PatientConditionInformationVision_2300
    {
    }
    
    [Serializable()]
    [Segment("CRC", typeof(X12_ID_1136_CRC_AmbulanceCertification_2300), typeof(X12_ID_1073_CRC_AmbulanceCertification_2300))]
    public class CRC_AmbulanceCertification_2300
    {
        
        [Required]
        [DataElement("1136", typeof(X12_ID_1136_CRC_AmbulanceCertification_2300))]
        [Pos(1)]
        public string CodeCategory_01 { get; set; }
        [Required]
        [DataElement("1073", typeof(X12_ID_1073_CRC_AmbulanceCertification_2300))]
        [Pos(2)]
        public string CertificationConditionIndicator_02 { get; set; }
        [Required]
        [DataElement("1321", typeof(X12_ID_1321_CRC_AmbulanceCertification_2300))]
        [Pos(3)]
        public string ConditionCode_03 { get; set; }
        [DataElement("1321", typeof(X12_ID_1321_CRC_AmbulanceCertification_2300))]
        [Pos(4)]
        public string ConditionCode_04 { get; set; }
        [DataElement("1321", typeof(X12_ID_1321_CRC_AmbulanceCertification_2300))]
        [Pos(5)]
        public string ConditionCode_05 { get; set; }
        [DataElement("1321", typeof(X12_ID_1321_CRC_AmbulanceCertification_2300))]
        [Pos(6)]
        public string ConditionCode_06 { get; set; }
        [DataElement("1321", typeof(X12_ID_1321_CRC_AmbulanceCertification_2300))]
        [Pos(7)]
        public string ConditionCode_07 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,60,")]
    public class X12_ID_1321_CRC_AmbulanceCertification_2300
    {
    }
    
    [Serializable()]
    [Segment("CR2")]
    public class CR2_SpinalManipulationServiceInformation_2300
    {
        
        [DataElement("", typeof(X12_N0))]
        [Pos(1)]
        public string CR2_01 { get; set; }
        [DataElement("", typeof(X12_R))]
        [Pos(2)]
        public string CR2_02 { get; set; }
        [StringLength(2, 3)]
        [DataElement("", typeof(X12_ID))]
        [Pos(3)]
        public string CR2_03 { get; set; }
        [StringLength(2, 3)]
        [DataElement("", typeof(X12_ID))]
        [Pos(4)]
        public string CR2_04 { get; set; }
        [StringLength(2, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(5)]
        public string CR2_05 { get; set; }
        [DataElement("", typeof(X12_R))]
        [Pos(6)]
        public string CR2_06 { get; set; }
        [DataElement("", typeof(X12_R))]
        [Pos(7)]
        public string CR2_07 { get; set; }
        [Required]
        [DataElement("1342", typeof(X12_ID_1342_CR2_SpinalManipulationServiceInformation_2300))]
        [Pos(8)]
        public string PatientConditionCode_08 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_ID))]
        [Pos(9)]
        public string CR2_09 { get; set; }
        [StringLength(1, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(10)]
        public string PatientConditionDescription_10 { get; set; }
        [StringLength(1, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(11)]
        public string PatientConditionDescription_11 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073_CR2_SpinalManipulationServiceInformation_2300))]
        [Pos(12)]
        public string XrayAvailabilityIndicator_12 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",A,C,D,E,F,G,M,")]
    public class X12_ID_1342_CR2_SpinalManipulationServiceInformation_2300
    {
    }
    
    [Serializable()]
    [EdiCodes(",N,Y,")]
    public class X12_ID_1073_CR2_SpinalManipulationServiceInformation_2300
    {
    }
    
    [Serializable()]
    [Segment("CR1", typeof(X12_ID_355_CR1_AmbulanceTransportInformation_2300))]
    public class CR1_AmbulanceTransportInformation_2300
    {
        
        [DataElement("355", typeof(X12_ID_355_CR1_AmbulanceTransportInformation_2300))]
        [Pos(1)]
        public string UnitOrBasisForMeasurementCode_01 { get; set; }
        [DataElement("", typeof(X12_R))]
        [Pos(2)]
        public string PatientWeight_02 { get; set; }
        [Required]
        [DataElement("1316", typeof(X12_ID_1316_CR1_AmbulanceTransportInformation_2300))]
        [Pos(3)]
        public string AmbulanceTransportCode_03 { get; set; }
        [Required]
        [DataElement("1317", typeof(X12_ID_1317_CR1_AmbulanceTransportInformation_2300))]
        [Pos(4)]
        public string AmbulanceTransportReasonCode_04 { get; set; }
        [Required]
        [DataElement("355", typeof(X12_ID_355_CR1_AmbulanceTransportInformation_2300))]
        [Pos(5)]
        public string UnitOrBasisForMeasurementCode_05 { get; set; }
        [Required]
        [DataElement("", typeof(X12_R))]
        [Pos(6)]
        public string TransportDistance_06 { get; set; }
        [StringLength(1, 55)]
        [DataElement("", typeof(X12_AN))]
        [Pos(7)]
        public string CR1_07 { get; set; }
        [StringLength(1, 55)]
        [DataElement("", typeof(X12_AN))]
        [Pos(8)]
        public string CR1_08 { get; set; }
        [StringLength(1, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(9)]
        public string RoundTripPurposeDescription_09 { get; set; }
        [StringLength(1, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(10)]
        public string StretcherPurposeDescription_10 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",I,R,T,X,")]
    public class X12_ID_1316_CR1_AmbulanceTransportInformation_2300
    {
    }
    
    [Serializable()]
    [EdiCodes(",A,B,C,D,E,")]
    public class X12_ID_1317_CR1_AmbulanceTransportInformation_2300
    {
    }
    
    [Serializable()]
    [Segment("NTE", typeof(X12_ID_363_NTE_ClaimNote_2300))]
    public class NTE_ClaimNote_2300
    {
        
        [Required]
        [DataElement("363", typeof(X12_ID_363_NTE_ClaimNote_2300))]
        [Pos(1)]
        public string NoteReferenceCode_01 { get; set; }
        [Required]
        [StringLength(1, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(2)]
        public string ClaimNoteText_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("K3")]
    public class K3_FileInformation_2300
    {
        
        [Required]
        [StringLength(1, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(1)]
        public string FixedFormatInformation_01 { get; set; }
        [StringLength(1, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(2)]
        public string K3_02 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string K3_03 { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_REF_2300
    {
        
        [Pos(1)]
        public REF_ServiceAuthorizationExceptionCode_2300 REF_ServiceAuthorizationExceptionCode_2300 { get; set; }
        [Pos(2)]
        public REF_MandatoryMedicareSection4081CrossoverIndicator_2300 REF_MandatoryMedicareSection4081CrossoverIndicator_2300 { get; set; }
        [Pos(3)]
        public REF_MammographyCertificationNumber_2300 REF_MammographyCertificationNumber_2300 { get; set; }
        [ListCount(2)]
        [Pos(4)]
        public List<REF_PriorAuthorizationOrReferralNumber_2300> REF_PriorAuthorizationOrReferralNumber_2300 { get; set; }
        [Pos(5)]
        public REF_OriginalReferenceNumberICNDCN_2300 REF_OriginalReferenceNumberICNDCN_2300 { get; set; }
        [ListCount(3)]
        [Pos(6)]
        public List<REF_ClinicalLaboratoryImprovementAmendmentCLIANumber_2300> REF_ClinicalLaboratoryImprovementAmendmentCLIANumber_2300 { get; set; }
        [Pos(7)]
        public REF_RepricedClaimNumber_2300 REF_RepricedClaimNumber_2300 { get; set; }
        [Pos(8)]
        public REF_AdjustedRepricedClaimNumber_2300 REF_AdjustedRepricedClaimNumber_2300 { get; set; }
        [Pos(9)]
        public REF_InvestigationalDeviceExemptionNumber_2300 REF_InvestigationalDeviceExemptionNumber_2300 { get; set; }
        [Pos(10)]
        public REF_ClaimIdentificationNumberForClearingHousesAndOtherTransmissionIntermediaries_2300 REF_ClaimIdentificationNumberForClearingHousesAndOtherTransmissionIntermediaries_2300 { get; set; }
        [ListCount(4)]
        [Pos(11)]
        public List<REF_AmbulatoryPatientGroupAPG_2300> REF_AmbulatoryPatientGroupAPG_2300 { get; set; }
        [Pos(12)]
        public REF_MedicalRecordNumber_2300 REF_MedicalRecordNumber_2300 { get; set; }
        [Pos(13)]
        public REF_DemonstrationProjectIdentifier_2300 REF_DemonstrationProjectIdentifier_2300 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",4N,")]
    public class X12_ID_128_REF_ServiceAuthorizationExceptionCode_2300
    {
    }
    
    [Serializable()]
    [EdiCodes(",F5,")]
    public class X12_ID_128_REF_MandatoryMedicareSection4081CrossoverIndicator_2300
    {
    }
    
    [Serializable()]
    [EdiCodes(",EW,")]
    public class X12_ID_128_REF_MammographyCertificationNumber_2300
    {
    }
    
    [Serializable()]
    [EdiCodes(",9F,G1,")]
    public class X12_ID_128_REF_PriorAuthorizationOrReferralNumber_2300
    {
    }
    
    [Serializable()]
    [EdiCodes(",F8,")]
    public class X12_ID_128_REF_OriginalReferenceNumberICNDCN_2300
    {
    }
    
    [Serializable()]
    [EdiCodes(",X4,")]
    public class X12_ID_128_REF_ClinicalLaboratoryImprovementAmendmentCLIANumber_2300
    {
    }
    
    [Serializable()]
    [EdiCodes(",9A,")]
    public class X12_ID_128_REF_RepricedClaimNumber_2300
    {
    }
    
    [Serializable()]
    [EdiCodes(",9C,")]
    public class X12_ID_128_REF_AdjustedRepricedClaimNumber_2300
    {
    }
    
    [Serializable()]
    [EdiCodes(",LX,")]
    public class X12_ID_128_REF_InvestigationalDeviceExemptionNumber_2300
    {
    }
    
    [Serializable()]
    [EdiCodes(",D9,")]
    public class X12_ID_128_REF_ClaimIdentificationNumberForClearingHousesAndOtherTransmissionIntermediaries_2300
    {
    }
    
    [Serializable()]
    [EdiCodes(",1S,")]
    public class X12_ID_128_REF_AmbulatoryPatientGroupAPG_2300
    {
    }
    
    [Serializable()]
    [EdiCodes(",EA,")]
    public class X12_ID_128_REF_MedicalRecordNumber_2300
    {
    }
    
    [Serializable()]
    [EdiCodes(",P4,")]
    public class X12_ID_128_REF_DemonstrationProjectIdentifier_2300
    {
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_REF_DemonstrationProjectIdentifier_2300))]
    public class REF_DemonstrationProjectIdentifier_2300
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_REF_DemonstrationProjectIdentifier_2300))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(2)]
        public string DemonstrationProjectIdentifier_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string REF_03 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string REF_04 { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_REF_MedicalRecordNumber_2300))]
    public class REF_MedicalRecordNumber_2300
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_REF_MedicalRecordNumber_2300))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(2)]
        public string MedicalRecordNumber_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string REF_03 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string REF_04 { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_REF_AmbulatoryPatientGroupAPG_2300))]
    public class REF_AmbulatoryPatientGroupAPG_2300
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_REF_AmbulatoryPatientGroupAPG_2300))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(2)]
        public string AmbulatoryPatientGroupNumber_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string REF_03 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string REF_04 { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_REF_ClaimIdentificationNumberForClearingHousesAndOtherTransmissionIntermediaries_2300))]
    public class REF_ClaimIdentificationNumberForClearingHousesAndOtherTransmissionIntermediaries_2300
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_REF_ClaimIdentificationNumberForClearingHousesAndOtherTransmissionIntermediaries_2300))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(2)]
        public string ClearinghouseTraceNumber_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string REF_03 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string REF_04 { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_REF_InvestigationalDeviceExemptionNumber_2300))]
    public class REF_InvestigationalDeviceExemptionNumber_2300
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_REF_InvestigationalDeviceExemptionNumber_2300))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(2)]
        public string InvestigationalDeviceExemptionIdentifier_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string REF_03 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string REF_04 { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_REF_AdjustedRepricedClaimNumber_2300))]
    public class REF_AdjustedRepricedClaimNumber_2300
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_REF_AdjustedRepricedClaimNumber_2300))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(2)]
        public string AdjustedRepricedClaimReferenceNumber_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string REF_03 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string REF_04 { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_REF_RepricedClaimNumber_2300))]
    public class REF_RepricedClaimNumber_2300
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_REF_RepricedClaimNumber_2300))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(2)]
        public string RepricedClaimReferenceNumber_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string REF_03 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string REF_04 { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_REF_ClinicalLaboratoryImprovementAmendmentCLIANumber_2300))]
    public class REF_ClinicalLaboratoryImprovementAmendmentCLIANumber_2300
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_REF_ClinicalLaboratoryImprovementAmendmentCLIANumber_2300))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(2)]
        public string ClinicalLaboratoryImprovementAmendmentNumber_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string REF_03 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string REF_04 { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_REF_OriginalReferenceNumberICNDCN_2300))]
    public class REF_OriginalReferenceNumberICNDCN_2300
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_REF_OriginalReferenceNumberICNDCN_2300))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(2)]
        public string ClaimOriginalReferenceNumber_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string REF_03 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string REF_04 { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_REF_PriorAuthorizationOrReferralNumber_2300))]
    public class REF_PriorAuthorizationOrReferralNumber_2300
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_REF_PriorAuthorizationOrReferralNumber_2300))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(2)]
        public string PriorAuthorizationOrReferralNumber_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string REF_03 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string REF_04 { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_REF_MammographyCertificationNumber_2300))]
    public class REF_MammographyCertificationNumber_2300
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_REF_MammographyCertificationNumber_2300))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(2)]
        public string MammographyCertificationNumber_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string REF_03 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string REF_04 { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_REF_MandatoryMedicareSection4081CrossoverIndicator_2300))]
    public class REF_MandatoryMedicareSection4081CrossoverIndicator_2300
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_REF_MandatoryMedicareSection4081CrossoverIndicator_2300))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(2)]
        public string MedicareSection4081Indicator_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string REF_03 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string REF_04 { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_REF_ServiceAuthorizationExceptionCode_2300))]
    public class REF_ServiceAuthorizationExceptionCode_2300
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_REF_ServiceAuthorizationExceptionCode_2300))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(2)]
        public string ServiceAuthorizationExceptionCode_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string REF_03 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string REF_04 { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_AMT_2300
    {
        
        [Pos(1)]
        public AMT_CreditDebitCardMaximumAmount_2300 AMT_CreditDebitCardMaximumAmount_2300 { get; set; }
        [Pos(2)]
        public AMT_PatientAmountPaid_2300 AMT_PatientAmountPaid_2300 { get; set; }
        [Pos(3)]
        public AMT_TotalPurchasedServiceAmount_2300 AMT_TotalPurchasedServiceAmount_2300 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",MA,")]
    public class X12_ID_522_AMT_CreditDebitCardMaximumAmount_2300
    {
    }
    
    [Serializable()]
    [EdiCodes(",F5,")]
    public class X12_ID_522_AMT_PatientAmountPaid_2300
    {
    }
    
    [Serializable()]
    [EdiCodes(",NE,")]
    public class X12_ID_522_AMT_TotalPurchasedServiceAmount_2300
    {
    }
    
    [Serializable()]
    [Segment("AMT", typeof(X12_ID_522_AMT_TotalPurchasedServiceAmount_2300))]
    public class AMT_TotalPurchasedServiceAmount_2300
    {
        
        [Required]
        [DataElement("522", typeof(X12_ID_522_AMT_TotalPurchasedServiceAmount_2300))]
        [Pos(1)]
        public string AmountQualifierCode_01 { get; set; }
        [Required]
        [DataElement("", typeof(X12_R))]
        [Pos(2)]
        public string TotalPurchasedServiceAmount_02 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_ID))]
        [Pos(3)]
        public string AMT_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("AMT", typeof(X12_ID_522_AMT_PatientAmountPaid_2300))]
    public class AMT_PatientAmountPaid_2300
    {
        
        [Required]
        [DataElement("522", typeof(X12_ID_522_AMT_PatientAmountPaid_2300))]
        [Pos(1)]
        public string AmountQualifierCode_01 { get; set; }
        [Required]
        [DataElement("", typeof(X12_R))]
        [Pos(2)]
        public string PatientAmountPaid_02 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_ID))]
        [Pos(3)]
        public string AMT_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("AMT", typeof(X12_ID_522_AMT_CreditDebitCardMaximumAmount_2300))]
    public class AMT_CreditDebitCardMaximumAmount_2300
    {
        
        [Required]
        [DataElement("522", typeof(X12_ID_522_AMT_CreditDebitCardMaximumAmount_2300))]
        [Pos(1)]
        public string AmountQualifierCode_01 { get; set; }
        [Required]
        [DataElement("", typeof(X12_R))]
        [Pos(2)]
        public string CreditOrDebitCardMaximumAmount_02 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_ID))]
        [Pos(3)]
        public string AMT_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("CN1", typeof(X12_ID_1166_CN1_ContractInformation_2300))]
    public class CN1_ContractInformation_2300
    {
        
        [Required]
        [DataElement("1166", typeof(X12_ID_1166_CN1_ContractInformation_2300))]
        [Pos(1)]
        public string ContractTypeCode_01 { get; set; }
        [DataElement("", typeof(X12_R))]
        [Pos(2)]
        public string ContractAmount_02 { get; set; }
        [DataElement("", typeof(X12_R))]
        [Pos(3)]
        public string ContractPercentage_03 { get; set; }
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string ContractCode_04 { get; set; }
        [DataElement("", typeof(X12_R))]
        [Pos(5)]
        public string TermsDiscountPercentage_05 { get; set; }
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(6)]
        public string ContractVersionIdentifier_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("PWK", typeof(X12_ID_755_PWK_ClaimSupplementalInformation_2300), typeof(X12_ID_756_PWK_ClaimSupplementalInformation_2300))]
    public class PWK_ClaimSupplementalInformation_2300
    {
        
        [Required]
        [DataElement("755", typeof(X12_ID_755_PWK_ClaimSupplementalInformation_2300))]
        [Pos(1)]
        public string AttachmentReportTypeCode_01 { get; set; }
        [Required]
        [DataElement("756", typeof(X12_ID_756_PWK_ClaimSupplementalInformation_2300))]
        [Pos(2)]
        public string AttachmentTransmissionCode_02 { get; set; }
        [DataElement("", typeof(X12_N0))]
        [Pos(3)]
        public string PWK_03 { get; set; }
        [StringLength(2, 3)]
        [DataElement("", typeof(X12_ID))]
        [Pos(4)]
        public string PWK_04 { get; set; }
        [DataElement("66", typeof(X12_ID_66_PWK_ClaimSupplementalInformation_2300))]
        [Pos(5)]
        public string IdentificationCodeQualifier_05 { get; set; }
        [StringLength(2, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(6)]
        public string AttachmentControlNumber_06 { get; set; }
        [StringLength(1, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(7)]
        public string PWK_07 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_AN))]
        [Pos(8)]
        public string PWK_08 { get; set; }
        [StringLength(1, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(9)]
        public string PWK_09 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",AC,")]
    public class X12_ID_66_PWK_ClaimSupplementalInformation_2300
    {
    }
    
    [Serializable()]
    [All()]
    public class All_DTP_2300
    {
        
        [Pos(1)]
        public DTP_DateInitialTreatment_2300 DTP_DateInitialTreatment_2300 { get; set; }
        [Pos(2)]
        public DTP_DateDateLastSeen_2300 DTP_DateDateLastSeen_2300 { get; set; }
        [Pos(3)]
        public DTP_DateOnsetOfCurrentIllnessSymptom_2300 DTP_DateOnsetOfCurrentIllnessSymptom_2300 { get; set; }
        [ListCount(5)]
        [Pos(4)]
        public List<DTP_DateAcuteManifestation_2300> DTP_DateAcuteManifestation_2300 { get; set; }
        [ListCount(10)]
        [Pos(5)]
        public List<DTP_DateSimilarIllnessSymptomOnset_2300> DTP_DateSimilarIllnessSymptomOnset_2300 { get; set; }
        [ListCount(10)]
        [Pos(6)]
        public List<DTP_DateAccident_2300> DTP_DateAccident_2300 { get; set; }
        [Pos(7)]
        public DTP_DateLastMenstrualPeriod_2300 DTP_DateLastMenstrualPeriod_2300 { get; set; }
        [Pos(8)]
        public DTP_DateLastXray_2300 DTP_DateLastXray_2300 { get; set; }
        [Pos(9)]
        public DTP_DateHearingAndVisionPrescriptionDate_2300 DTP_DateHearingAndVisionPrescriptionDate_2300 { get; set; }
        [ListCount(5)]
        [Pos(10)]
        public List<DTP_DateDisabilityBegin_2300> DTP_DateDisabilityBegin_2300 { get; set; }
        [ListCount(5)]
        [Pos(11)]
        public List<DTP_DateDisabilityEnd_2300> DTP_DateDisabilityEnd_2300 { get; set; }
        [Pos(12)]
        public DTP_DateLastWorked_2300 DTP_DateLastWorked_2300 { get; set; }
        [Pos(13)]
        public DTP_DateAuthorizedReturnToWork_2300 DTP_DateAuthorizedReturnToWork_2300 { get; set; }
        [Pos(14)]
        public DTP_DateAdmission_2300 DTP_DateAdmission_2300 { get; set; }
        [Pos(15)]
        public DTP_DateDischarge_2300 DTP_DateDischarge_2300 { get; set; }
        [ListCount(2)]
        [Pos(16)]
        public List<DTP_DateAssumedAndRelinquishedCareDates_2300> DTP_DateAssumedAndRelinquishedCareDates_2300 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",454,")]
    public class X12_ID_374_DTP_DateInitialTreatment_2300
    {
    }
    
    [Serializable()]
    [EdiCodes(",D8,")]
    public class X12_ID_1250_DTP_DateInitialTreatment_2300
    {
    }
    
    [Serializable()]
    [EdiCodes(",304,")]
    public class X12_ID_374_DTP_DateDateLastSeen_2300
    {
    }
    
    [Serializable()]
    [EdiCodes(",D8,")]
    public class X12_ID_1250_DTP_DateDateLastSeen_2300
    {
    }
    
    [Serializable()]
    [EdiCodes(",431,")]
    public class X12_ID_374_DTP_DateOnsetOfCurrentIllnessSymptom_2300
    {
    }
    
    [Serializable()]
    [EdiCodes(",D8,")]
    public class X12_ID_1250_DTP_DateOnsetOfCurrentIllnessSymptom_2300
    {
    }
    
    [Serializable()]
    [EdiCodes(",453,")]
    public class X12_ID_374_DTP_DateAcuteManifestation_2300
    {
    }
    
    [Serializable()]
    [EdiCodes(",D8,")]
    public class X12_ID_1250_DTP_DateAcuteManifestation_2300
    {
    }
    
    [Serializable()]
    [EdiCodes(",438,")]
    public class X12_ID_374_DTP_DateSimilarIllnessSymptomOnset_2300
    {
    }
    
    [Serializable()]
    [EdiCodes(",D8,")]
    public class X12_ID_1250_DTP_DateSimilarIllnessSymptomOnset_2300
    {
    }
    
    [Serializable()]
    [EdiCodes(",439,")]
    public class X12_ID_374_DTP_DateAccident_2300
    {
    }
    
    [Serializable()]
    [EdiCodes(",D8,DT,")]
    public class X12_ID_1250_DTP_DateAccident_2300
    {
    }
    
    [Serializable()]
    [EdiCodes(",484,")]
    public class X12_ID_374_DTP_DateLastMenstrualPeriod_2300
    {
    }
    
    [Serializable()]
    [EdiCodes(",D8,")]
    public class X12_ID_1250_DTP_DateLastMenstrualPeriod_2300
    {
    }
    
    [Serializable()]
    [EdiCodes(",455,")]
    public class X12_ID_374_DTP_DateLastXray_2300
    {
    }
    
    [Serializable()]
    [EdiCodes(",D8,")]
    public class X12_ID_1250_DTP_DateLastXray_2300
    {
    }
    
    [Serializable()]
    [EdiCodes(",471,")]
    public class X12_ID_374_DTP_DateHearingAndVisionPrescriptionDate_2300
    {
    }
    
    [Serializable()]
    [EdiCodes(",D8,")]
    public class X12_ID_1250_DTP_DateHearingAndVisionPrescriptionDate_2300
    {
    }
    
    [Serializable()]
    [EdiCodes(",360,")]
    public class X12_ID_374_DTP_DateDisabilityBegin_2300
    {
    }
    
    [Serializable()]
    [EdiCodes(",D8,")]
    public class X12_ID_1250_DTP_DateDisabilityBegin_2300
    {
    }
    
    [Serializable()]
    [EdiCodes(",361,")]
    public class X12_ID_374_DTP_DateDisabilityEnd_2300
    {
    }
    
    [Serializable()]
    [EdiCodes(",D8,")]
    public class X12_ID_1250_DTP_DateDisabilityEnd_2300
    {
    }
    
    [Serializable()]
    [EdiCodes(",297,")]
    public class X12_ID_374_DTP_DateLastWorked_2300
    {
    }
    
    [Serializable()]
    [EdiCodes(",D8,")]
    public class X12_ID_1250_DTP_DateLastWorked_2300
    {
    }
    
    [Serializable()]
    [EdiCodes(",296,")]
    public class X12_ID_374_DTP_DateAuthorizedReturnToWork_2300
    {
    }
    
    [Serializable()]
    [EdiCodes(",D8,")]
    public class X12_ID_1250_DTP_DateAuthorizedReturnToWork_2300
    {
    }
    
    [Serializable()]
    [EdiCodes(",435,")]
    public class X12_ID_374_DTP_DateAdmission_2300
    {
    }
    
    [Serializable()]
    [EdiCodes(",D8,")]
    public class X12_ID_1250_DTP_DateAdmission_2300
    {
    }
    
    [Serializable()]
    [EdiCodes(",096,")]
    public class X12_ID_374_DTP_DateDischarge_2300
    {
    }
    
    [Serializable()]
    [EdiCodes(",D8,")]
    public class X12_ID_1250_DTP_DateDischarge_2300
    {
    }
    
    [Serializable()]
    [EdiCodes(",090,091,")]
    public class X12_ID_374_DTP_DateAssumedAndRelinquishedCareDates_2300
    {
    }
    
    [Serializable()]
    [EdiCodes(",D8,")]
    public class X12_ID_1250_DTP_DateAssumedAndRelinquishedCareDates_2300
    {
    }
    
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_DTP_DateAssumedAndRelinquishedCareDates_2300), typeof(X12_ID_1250_DTP_DateAssumedAndRelinquishedCareDates_2300))]
    public class DTP_DateAssumedAndRelinquishedCareDates_2300
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374_DTP_DateAssumedAndRelinquishedCareDates_2300))]
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        [Required]
        [DataElement("1250", typeof(X12_ID_1250_DTP_DateAssumedAndRelinquishedCareDates_2300))]
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [Required]
        [StringLength(1, 35)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string AssumedOrRelinquishedCareDate_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_DTP_DateDischarge_2300), typeof(X12_ID_1250_DTP_DateDischarge_2300))]
    public class DTP_DateDischarge_2300
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374_DTP_DateDischarge_2300))]
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        [Required]
        [DataElement("1250", typeof(X12_ID_1250_DTP_DateDischarge_2300))]
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [Required]
        [StringLength(1, 35)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string RelatedHospitalizationDischargeDate_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_DTP_DateAdmission_2300), typeof(X12_ID_1250_DTP_DateAdmission_2300))]
    public class DTP_DateAdmission_2300
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374_DTP_DateAdmission_2300))]
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        [Required]
        [DataElement("1250", typeof(X12_ID_1250_DTP_DateAdmission_2300))]
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [Required]
        [StringLength(1, 35)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string RelatedHospitalizationAdmissionDate_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_DTP_DateAuthorizedReturnToWork_2300), typeof(X12_ID_1250_DTP_DateAuthorizedReturnToWork_2300))]
    public class DTP_DateAuthorizedReturnToWork_2300
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374_DTP_DateAuthorizedReturnToWork_2300))]
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        [Required]
        [DataElement("1250", typeof(X12_ID_1250_DTP_DateAuthorizedReturnToWork_2300))]
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [Required]
        [StringLength(1, 35)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string WorkReturnDate_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_DTP_DateLastWorked_2300), typeof(X12_ID_1250_DTP_DateLastWorked_2300))]
    public class DTP_DateLastWorked_2300
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374_DTP_DateLastWorked_2300))]
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        [Required]
        [DataElement("1250", typeof(X12_ID_1250_DTP_DateLastWorked_2300))]
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [Required]
        [StringLength(1, 35)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string LastWorkedDate_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_DTP_DateDisabilityEnd_2300), typeof(X12_ID_1250_DTP_DateDisabilityEnd_2300))]
    public class DTP_DateDisabilityEnd_2300
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374_DTP_DateDisabilityEnd_2300))]
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        [Required]
        [DataElement("1250", typeof(X12_ID_1250_DTP_DateDisabilityEnd_2300))]
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [Required]
        [StringLength(1, 35)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string DisabilityToDate_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_DTP_DateDisabilityBegin_2300), typeof(X12_ID_1250_DTP_DateDisabilityBegin_2300))]
    public class DTP_DateDisabilityBegin_2300
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374_DTP_DateDisabilityBegin_2300))]
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        [Required]
        [DataElement("1250", typeof(X12_ID_1250_DTP_DateDisabilityBegin_2300))]
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [Required]
        [StringLength(1, 35)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string DisabilityFromDate_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_DTP_DateHearingAndVisionPrescriptionDate_2300), typeof(X12_ID_1250_DTP_DateHearingAndVisionPrescriptionDate_2300))]
    public class DTP_DateHearingAndVisionPrescriptionDate_2300
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374_DTP_DateHearingAndVisionPrescriptionDate_2300))]
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        [Required]
        [DataElement("1250", typeof(X12_ID_1250_DTP_DateHearingAndVisionPrescriptionDate_2300))]
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [Required]
        [StringLength(1, 35)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string PrescriptionDate_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_DTP_DateLastXray_2300), typeof(X12_ID_1250_DTP_DateLastXray_2300))]
    public class DTP_DateLastXray_2300
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374_DTP_DateLastXray_2300))]
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        [Required]
        [DataElement("1250", typeof(X12_ID_1250_DTP_DateLastXray_2300))]
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [Required]
        [StringLength(1, 35)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string LastXRayDate_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_DTP_DateLastMenstrualPeriod_2300), typeof(X12_ID_1250_DTP_DateLastMenstrualPeriod_2300))]
    public class DTP_DateLastMenstrualPeriod_2300
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374_DTP_DateLastMenstrualPeriod_2300))]
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        [Required]
        [DataElement("1250", typeof(X12_ID_1250_DTP_DateLastMenstrualPeriod_2300))]
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [Required]
        [StringLength(1, 35)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string LastMenstrualPeriodDate_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_DTP_DateAccident_2300), typeof(X12_ID_1250_DTP_DateAccident_2300))]
    public class DTP_DateAccident_2300
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374_DTP_DateAccident_2300))]
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        [Required]
        [DataElement("1250", typeof(X12_ID_1250_DTP_DateAccident_2300))]
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [Required]
        [StringLength(1, 35)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string AccidentDate_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_DTP_DateSimilarIllnessSymptomOnset_2300), typeof(X12_ID_1250_DTP_DateSimilarIllnessSymptomOnset_2300))]
    public class DTP_DateSimilarIllnessSymptomOnset_2300
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374_DTP_DateSimilarIllnessSymptomOnset_2300))]
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        [Required]
        [DataElement("1250", typeof(X12_ID_1250_DTP_DateSimilarIllnessSymptomOnset_2300))]
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [Required]
        [StringLength(1, 35)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string SimilarIllnessOrSymptomDate_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_DTP_DateAcuteManifestation_2300), typeof(X12_ID_1250_DTP_DateAcuteManifestation_2300))]
    public class DTP_DateAcuteManifestation_2300
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374_DTP_DateAcuteManifestation_2300))]
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        [Required]
        [DataElement("1250", typeof(X12_ID_1250_DTP_DateAcuteManifestation_2300))]
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [Required]
        [StringLength(1, 35)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string AcuteManifestationDate_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_DTP_DateOnsetOfCurrentIllnessSymptom_2300), typeof(X12_ID_1250_DTP_DateOnsetOfCurrentIllnessSymptom_2300))]
    public class DTP_DateOnsetOfCurrentIllnessSymptom_2300
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374_DTP_DateOnsetOfCurrentIllnessSymptom_2300))]
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        [Required]
        [DataElement("1250", typeof(X12_ID_1250_DTP_DateOnsetOfCurrentIllnessSymptom_2300))]
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [Required]
        [StringLength(1, 35)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string OnsetOfCurrentIllnessOrInjuryDate_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_DTP_DateDateLastSeen_2300), typeof(X12_ID_1250_DTP_DateDateLastSeen_2300))]
    public class DTP_DateDateLastSeen_2300
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374_DTP_DateDateLastSeen_2300))]
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        [Required]
        [DataElement("1250", typeof(X12_ID_1250_DTP_DateDateLastSeen_2300))]
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [Required]
        [StringLength(1, 35)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string LastSeenDate_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_DTP_DateInitialTreatment_2300), typeof(X12_ID_1250_DTP_DateInitialTreatment_2300))]
    public class DTP_DateInitialTreatment_2300
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374_DTP_DateInitialTreatment_2300))]
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        [Required]
        [DataElement("1250", typeof(X12_ID_1250_DTP_DateInitialTreatment_2300))]
        [Pos(2)]
        public string DateTimePeriodFormatQualifier_02 { get; set; }
        [Required]
        [StringLength(1, 35)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string InitialTreatmentDate_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("CLM")]
    public class CLM_ClaimInformation_2300
    {
        
        [Required]
        [StringLength(1, 38)]
        [DataElement("", typeof(X12_AN))]
        [Pos(1)]
        public string PatientAccountNumber_01 { get; set; }
        [Required]
        [DataElement("", typeof(X12_R))]
        [Pos(2)]
        public string TotalClaimChargeAmount_02 { get; set; }
        [StringLength(1, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(3)]
        public string CLM_03 { get; set; }
        [StringLength(1, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(4)]
        public string CLM_04 { get; set; }
        [Required]
        [Pos(5)]
        public C023_701794159 C023_701794159 { get; set; }
        [Required]
        [DataElement("1073", typeof(X12_ID_1073_CLM_ClaimInformation_2300))]
        [Pos(6)]
        public string ProviderOrSupplierSignatureIndicator_06 { get; set; }
        [Required]
        [DataElement("1359", typeof(X12_ID_1359_CLM_ClaimInformation_2300))]
        [Pos(7)]
        public string MedicareAssignmentCode_07 { get; set; }
        [Required]
        [DataElement("1073", typeof(X12_ID_1073_CLM_ClaimInformation_2300))]
        [Pos(8)]
        public string BenefitsAssignmentCertificationIndicator_08 { get; set; }
        [Required]
        [DataElement("1363", typeof(X12_ID_1363_CLM_ClaimInformation_2300))]
        [Pos(9)]
        public string ReleaseOfInformationCode_09 { get; set; }
        [DataElement("1351", typeof(X12_ID_1351_CLM_ClaimInformation_2300))]
        [Pos(10)]
        public string PatientSignatureSourceCode_10 { get; set; }
        [Pos(11)]
        public C024_1508297677 C024_1508297677 { get; set; }
        [DataElement("1366", typeof(X12_ID_1366_CLM_ClaimInformation_2300))]
        [Pos(12)]
        public string SpecialProgramIndicator_12 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_ID))]
        [Pos(13)]
        public string CLM_13 { get; set; }
        [StringLength(1, 3)]
        [DataElement("", typeof(X12_ID))]
        [Pos(14)]
        public string CLM_14 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_ID))]
        [Pos(15)]
        public string CLM_15 { get; set; }
        [DataElement("1360", typeof(X12_ID_1360_CLM_ClaimInformation_2300))]
        [Pos(16)]
        public string ParticipationAgreement_16 { get; set; }
        [StringLength(1, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(17)]
        public string CLM_17 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_ID))]
        [Pos(18)]
        public string CLM_18 { get; set; }
        [StringLength(2, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(19)]
        public string CLM_19 { get; set; }
        [DataElement("1514", typeof(X12_ID_1514_CLM_ClaimInformation_2300))]
        [Pos(20)]
        public string DelayReasonCode_20 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",N,Y,")]
    public class X12_ID_1073_CLM_ClaimInformation_2300
    {
    }
    
    [Serializable()]
    [EdiCodes(",A,B,C,P,")]
    public class X12_ID_1359_CLM_ClaimInformation_2300
    {
    }
    
    [Serializable()]
    [EdiCodes(",A,I,M,N,O,Y,")]
    public class X12_ID_1363_CLM_ClaimInformation_2300
    {
    }
    
    [Serializable()]
    [EdiCodes(",B,C,M,P,S,")]
    public class X12_ID_1351_CLM_ClaimInformation_2300
    {
    }
    
    [Serializable()]
    [EdiCodes(",01,02,03,05,07,08,09,")]
    public class X12_ID_1366_CLM_ClaimInformation_2300
    {
    }
    
    [Serializable()]
    [EdiCodes(",P,")]
    public class X12_ID_1360_CLM_ClaimInformation_2300
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,10,11,")]
    public class X12_ID_1514_CLM_ClaimInformation_2300
    {
    }
    
    [Serializable()]
    [Composite("C024_1508297677")]
    public class C024_1508297677
    {
        
        [Required]
        [DataElement("1362", typeof(X12_ID_1362_C024_1508297677))]
        [Pos(1)]
        public string RelatedCausesCode_01 { get; set; }
        [DataElement("1362", typeof(X12_ID_1362_C024_1508297677))]
        [Pos(2)]
        public string RelatedCausesCode_02 { get; set; }
        [DataElement("1362", typeof(X12_ID_1362_C024_1508297677))]
        [Pos(3)]
        public string RelatedCausesCode_03 { get; set; }
        [StringLength(2, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(4)]
        public string AutoAccidentStateOrProvinceCode_04 { get; set; }
        [StringLength(2, 3)]
        [DataElement("", typeof(X12_ID))]
        [Pos(5)]
        public string CountryCode_05 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",AA,AP,EM,OA,")]
    public class X12_ID_1362_C024_1508297677
    {
    }
    
    [Serializable()]
    [Composite("C023_701794159")]
    public class C023_701794159
    {
        
        [Required]
        [StringLength(1, 2)]
        [DataElement("", typeof(X12_AN))]
        [Pos(1)]
        public string FacilityTypeCode_01 { get; set; }
        [StringLength(1, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(2)]
        public string CLM_02 { get; set; }
        [Required]
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_ID))]
        [Pos(3)]
        public string ClaimFrequencyCode_03 { get; set; }
    }
    
    [Serializable()]
    [Group("NM1")]
    public class Loop_2010CA
    {
        
        [Required]
        [Pos(1)]
        public NM1_PatientName_2010CA NM1_PatientName_2010CA { get; set; }
        [Required]
        [Pos(2)]
        public N3_PatientAddress_2010CA N3_PatientAddress_2010CA { get; set; }
        [Required]
        [Pos(3)]
        public N4_PatientCityStateZIPCode_2010CA N4_PatientCityStateZIPCode_2010CA { get; set; }
        [Required]
        [Pos(4)]
        public DMG_PatientDemographicInformation_2010CA DMG_PatientDemographicInformation_2010CA { get; set; }
        [Pos(5)]
        public All_REF_2010CA All_REF_2010CA { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",QC,")]
    public class X12_ID_98_NM1_PatientName_2010CA
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,")]
    public class X12_ID_1065_NM1_PatientName_2010CA
    {
    }
    
    [Serializable()]
    [EdiCodes(",D8,")]
    public class X12_ID_1250_DMG_PatientDemographicInformation_2010CA
    {
    }
    
    [Serializable()]
    [All()]
    public class All_REF_2010CA
    {
        
        [ListCount(5)]
        [Pos(1)]
        public List<REF_PatientSecondaryIdentification_2010CA> REF_PatientSecondaryIdentification_2010CA { get; set; }
        [Pos(2)]
        public REF_PropertyAndCasualtyClaimNumber_2010CA REF_PropertyAndCasualtyClaimNumber_2010CA { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",1W,23,IG,SY,")]
    public class X12_ID_128_REF_PatientSecondaryIdentification_2010CA
    {
    }
    
    [Serializable()]
    [EdiCodes(",Y4,")]
    public class X12_ID_128_REF_PropertyAndCasualtyClaimNumber_2010CA
    {
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_REF_PropertyAndCasualtyClaimNumber_2010CA))]
    public class REF_PropertyAndCasualtyClaimNumber_2010CA
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_REF_PropertyAndCasualtyClaimNumber_2010CA))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(2)]
        public string PropertyCasualtyClaimNumber_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string REF_03 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string REF_04 { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_REF_PatientSecondaryIdentification_2010CA))]
    public class REF_PatientSecondaryIdentification_2010CA
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_REF_PatientSecondaryIdentification_2010CA))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(2)]
        public string PatientSecondaryIdentifier_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string REF_03 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string REF_04 { get; set; }
    }
    
    [Serializable()]
    [Segment("DMG", typeof(X12_ID_1250_DMG_PatientDemographicInformation_2010CA))]
    public class DMG_PatientDemographicInformation_2010CA
    {
        
        [Required]
        [DataElement("1250", typeof(X12_ID_1250_DMG_PatientDemographicInformation_2010CA))]
        [Pos(1)]
        public string DateTimePeriodFormatQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 35)]
        [DataElement("", typeof(X12_AN))]
        [Pos(2)]
        public string PatientBirthDate_02 { get; set; }
        [Required]
        [DataElement("1068", typeof(X12_ID_1068_DMG_PatientDemographicInformation_2010CA))]
        [Pos(3)]
        public string PatientGenderCode_03 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_ID))]
        [Pos(4)]
        public string DMG_04 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_ID))]
        [Pos(5)]
        public string DMG_05 { get; set; }
        [StringLength(1, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(6)]
        public string DMG_06 { get; set; }
        [StringLength(2, 3)]
        [DataElement("", typeof(X12_ID))]
        [Pos(7)]
        public string DMG_07 { get; set; }
        [StringLength(1, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(8)]
        public string DMG_08 { get; set; }
        [DataElement("", typeof(X12_R))]
        [Pos(9)]
        public string DMG_09 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",F,M,U,")]
    public class X12_ID_1068_DMG_PatientDemographicInformation_2010CA
    {
    }
    
    [Serializable()]
    [Segment("N4")]
    public class N4_PatientCityStateZIPCode_2010CA
    {
        
        [Required]
        [StringLength(2, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(1)]
        public string PatientCityName_01 { get; set; }
        [Required]
        [StringLength(2, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(2)]
        public string PatientStateCode_02 { get; set; }
        [Required]
        [StringLength(3, 15)]
        [DataElement("", typeof(X12_ID))]
        [Pos(3)]
        public string PatientPostalZoneOrZIPCode_03 { get; set; }
        [StringLength(2, 3)]
        [DataElement("", typeof(X12_ID))]
        [Pos(4)]
        public string CountryCode_04 { get; set; }
        [StringLength(1, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(5)]
        public string N4_05 { get; set; }
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(6)]
        public string N4_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("N3")]
    public class N3_PatientAddress_2010CA
    {
        
        [Required]
        [StringLength(1, 55)]
        [DataElement("", typeof(X12_AN))]
        [Pos(1)]
        public string PatientAddressLine_01 { get; set; }
        [StringLength(1, 55)]
        [DataElement("", typeof(X12_AN))]
        [Pos(2)]
        public string PatientAddressLine_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_NM1_PatientName_2010CA), typeof(X12_ID_1065_NM1_PatientName_2010CA))]
    public class NM1_PatientName_2010CA
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98_NM1_PatientName_2010CA))]
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        [Required]
        [DataElement("1065", typeof(X12_ID_1065_NM1_PatientName_2010CA))]
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        [Required]
        [StringLength(1, 35)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string PatientLastName_03 { get; set; }
        [Required]
        [StringLength(1, 25)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string PatientFirstName_04 { get; set; }
        [StringLength(1, 25)]
        [DataElement("", typeof(X12_AN))]
        [Pos(5)]
        public string PatientMiddleName_05 { get; set; }
        [StringLength(1, 10)]
        [DataElement("", typeof(X12_AN))]
        [Pos(6)]
        public string NM1_06 { get; set; }
        [StringLength(1, 10)]
        [DataElement("", typeof(X12_AN))]
        [Pos(7)]
        public string PatientNameSuffix_07 { get; set; }
        [DataElement("66", typeof(X12_ID_66_NM1_PatientName_2010CA))]
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        [StringLength(2, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(9)]
        public string PatientPrimaryIdentifier_09 { get; set; }
        [StringLength(2, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(10)]
        public string NM1_10 { get; set; }
        [StringLength(2, 3)]
        [DataElement("", typeof(X12_ID))]
        [Pos(11)]
        public string NM1_11 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",MI,ZZ,")]
    public class X12_ID_66_NM1_PatientName_2010CA
    {
    }
    
    [Serializable()]
    [Segment("PAT", typeof(X12_ID_1069_PAT_PatientInformation_2000C))]
    public class PAT_PatientInformation_2000C
    {
        
        [Required]
        [DataElement("1069", typeof(X12_ID_1069_PAT_PatientInformation_2000C))]
        [Pos(1)]
        public string IndividualRelationshipCode_01 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_ID))]
        [Pos(2)]
        public string PAT_02 { get; set; }
        [StringLength(2, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(3)]
        public string PAT_03 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_ID))]
        [Pos(4)]
        public string PAT_04 { get; set; }
        [DataElement("1250", typeof(X12_ID_1250_PAT_PatientInformation_2000C))]
        [Pos(5)]
        public string DateTimePeriodFormatQualifier_05 { get; set; }
        [StringLength(1, 35)]
        [DataElement("", typeof(X12_AN))]
        [Pos(6)]
        public string PatientDeathDate_06 { get; set; }
        [DataElement("355", typeof(X12_ID_355_PAT_PatientInformation_2000C))]
        [Pos(7)]
        public string UnitOrBasisForMeasurementCode_07 { get; set; }
        [DataElement("", typeof(X12_R))]
        [Pos(8)]
        public string PatientWeight_08 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073_PAT_PatientInformation_2000C))]
        [Pos(9)]
        public string PregnancyIndicator_09 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",D8,")]
    public class X12_ID_1250_PAT_PatientInformation_2000C
    {
    }
    
    [Serializable()]
    [EdiCodes(",01,")]
    public class X12_ID_355_PAT_PatientInformation_2000C
    {
    }
    
    [Serializable()]
    [EdiCodes(",Y,")]
    public class X12_ID_1073_PAT_PatientInformation_2000C
    {
    }
    
    [Serializable()]
    [Segment("HL")]
    public class HL_PatientHierarchicalLevel_2000C
    {
        
        [Required]
        [StringLength(1, 12)]
        [DataElement("", typeof(X12_AN))]
        [Pos(1)]
        public string HierarchicalIDNumber_01 { get; set; }
        [Required]
        [StringLength(1, 12)]
        [DataElement("", typeof(X12_AN))]
        [Pos(2)]
        public string HierarchicalParentIDNumber_02 { get; set; }
        [Required]
        [DataElement("735", typeof(X12_ID_735_HL_PatientHierarchicalLevel_2000C))]
        [Pos(3)]
        public string HierarchicalLevelCode_03 { get; set; }
        [Required]
        [DataElement("736", typeof(X12_ID_736_HL_PatientHierarchicalLevel_2000C))]
        [Pos(4)]
        public string HierarchicalChildCode_04 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",23,")]
    public class X12_ID_735_HL_PatientHierarchicalLevel_2000C
    {
    }
    
    [Serializable()]
    [EdiCodes(",0,")]
    public class X12_ID_736_HL_PatientHierarchicalLevel_2000C
    {
    }
    
    [Serializable()]
    [All()]
    public class All_2010B
    {
        
        [Required]
        [Pos(1)]
        public Loop_2010BA Loop_2010BA { get; set; }
        [Required]
        [Pos(2)]
        public Loop_2010BB Loop_2010BB { get; set; }
        [Pos(3)]
        public Loop_2010BC Loop_2010BC { get; set; }
        [Pos(4)]
        public Loop_2010BD Loop_2010BD { get; set; }
    }
    
    [Serializable()]
    [Group("NM1")]
    public class Loop_2010BD
    {
        
        [Required]
        [Pos(1)]
        public NM1_CreditDebitCardHolderName_2010BD NM1_CreditDebitCardHolderName_2010BD { get; set; }
        [ListCount(2)]
        [Pos(2)]
        public List<REF_CreditDebitCardInformation_2010BD> REF_CreditDebitCardInformation_2010BD { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",AO,")]
    public class X12_ID_98_NM1_CreditDebitCardHolderName_2010BD
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,")]
    public class X12_ID_1065_NM1_CreditDebitCardHolderName_2010BD
    {
    }
    
    [Serializable()]
    [EdiCodes(",AB,BB,")]
    public class X12_ID_128_REF_CreditDebitCardInformation_2010BD
    {
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_REF_CreditDebitCardInformation_2010BD))]
    public class REF_CreditDebitCardInformation_2010BD
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_REF_CreditDebitCardInformation_2010BD))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(2)]
        public string CreditOrDebitCardAuthorizationNumber_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string REF_03 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string REF_04 { get; set; }
    }
    
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_NM1_CreditDebitCardHolderName_2010BD), typeof(X12_ID_1065_NM1_CreditDebitCardHolderName_2010BD))]
    public class NM1_CreditDebitCardHolderName_2010BD
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98_NM1_CreditDebitCardHolderName_2010BD))]
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        [Required]
        [DataElement("1065", typeof(X12_ID_1065_NM1_CreditDebitCardHolderName_2010BD))]
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        [Required]
        [StringLength(1, 35)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string CreditOrDebitCardHolderLastOrOrganizationalName_03 { get; set; }
        [StringLength(1, 25)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string CreditOrDebitCardHolderFirstName_04 { get; set; }
        [StringLength(1, 25)]
        [DataElement("", typeof(X12_AN))]
        [Pos(5)]
        public string CreditOrDebitCardHolderMiddleName_05 { get; set; }
        [StringLength(1, 10)]
        [DataElement("", typeof(X12_AN))]
        [Pos(6)]
        public string NM1_06 { get; set; }
        [StringLength(1, 10)]
        [DataElement("", typeof(X12_AN))]
        [Pos(7)]
        public string CreditOrDebitCardHolderNameSuffix_07 { get; set; }
        [Required]
        [DataElement("66", typeof(X12_ID_66_NM1_CreditDebitCardHolderName_2010BD))]
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        [Required]
        [StringLength(2, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(9)]
        public string CreditOrDebitCardNumber_09 { get; set; }
        [StringLength(2, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(10)]
        public string NM1_10 { get; set; }
        [StringLength(2, 3)]
        [DataElement("", typeof(X12_ID))]
        [Pos(11)]
        public string NM1_11 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",MI,")]
    public class X12_ID_66_NM1_CreditDebitCardHolderName_2010BD
    {
    }
    
    [Serializable()]
    [Group("NM1")]
    public class Loop_2010BC
    {
        
        [Required]
        [Pos(1)]
        public NM1_ResponsiblePartyName_2010BC NM1_ResponsiblePartyName_2010BC { get; set; }
        [Required]
        [Pos(2)]
        public N3_ResponsiblePartyAddress_2010BC N3_ResponsiblePartyAddress_2010BC { get; set; }
        [Required]
        [Pos(3)]
        public N4_ResponsiblePartyCityStateZIPCode_2010BC N4_ResponsiblePartyCityStateZIPCode_2010BC { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",QD,")]
    public class X12_ID_98_NM1_ResponsiblePartyName_2010BC
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,")]
    public class X12_ID_1065_NM1_ResponsiblePartyName_2010BC
    {
    }
    
    [Serializable()]
    [Segment("N4")]
    public class N4_ResponsiblePartyCityStateZIPCode_2010BC
    {
        
        [Required]
        [StringLength(2, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(1)]
        public string ResponsiblePartyCityName_01 { get; set; }
        [Required]
        [StringLength(2, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(2)]
        public string ResponsiblePartyStateCode_02 { get; set; }
        [Required]
        [StringLength(3, 15)]
        [DataElement("", typeof(X12_ID))]
        [Pos(3)]
        public string ResponsiblePartyPostalZoneOrZIPCode_03 { get; set; }
        [StringLength(2, 3)]
        [DataElement("", typeof(X12_ID))]
        [Pos(4)]
        public string CountryCode_04 { get; set; }
        [StringLength(1, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(5)]
        public string N4_05 { get; set; }
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(6)]
        public string N4_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("N3")]
    public class N3_ResponsiblePartyAddress_2010BC
    {
        
        [Required]
        [StringLength(1, 55)]
        [DataElement("", typeof(X12_AN))]
        [Pos(1)]
        public string ResponsiblePartyAddressLine_01 { get; set; }
        [StringLength(1, 55)]
        [DataElement("", typeof(X12_AN))]
        [Pos(2)]
        public string ResponsiblePartyAddressLine_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_NM1_ResponsiblePartyName_2010BC), typeof(X12_ID_1065_NM1_ResponsiblePartyName_2010BC))]
    public class NM1_ResponsiblePartyName_2010BC
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98_NM1_ResponsiblePartyName_2010BC))]
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        [Required]
        [DataElement("1065", typeof(X12_ID_1065_NM1_ResponsiblePartyName_2010BC))]
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        [Required]
        [StringLength(1, 35)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string ResponsiblePartyLastOrOrganizationName_03 { get; set; }
        [StringLength(1, 25)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string ResponsiblePartyFirstName_04 { get; set; }
        [StringLength(1, 25)]
        [DataElement("", typeof(X12_AN))]
        [Pos(5)]
        public string ResponsiblePartyMiddleName_05 { get; set; }
        [StringLength(1, 10)]
        [DataElement("", typeof(X12_AN))]
        [Pos(6)]
        public string NM1_06 { get; set; }
        [StringLength(1, 10)]
        [DataElement("", typeof(X12_AN))]
        [Pos(7)]
        public string ResponsiblePartySuffixName_07 { get; set; }
        [StringLength(1, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(8)]
        public string NM1_08 { get; set; }
        [StringLength(2, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(9)]
        public string NM1_09 { get; set; }
        [StringLength(2, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(10)]
        public string NM1_10 { get; set; }
        [StringLength(2, 3)]
        [DataElement("", typeof(X12_ID))]
        [Pos(11)]
        public string NM1_11 { get; set; }
    }
    
    [Serializable()]
    [Group("NM1")]
    public class Loop_2010BB
    {
        
        [Required]
        [Pos(1)]
        public NM1_PayerName_2010BB NM1_PayerName_2010BB { get; set; }
        [Pos(2)]
        public N3_PayerAddress_2010BB N3_PayerAddress_2010BB { get; set; }
        [Pos(3)]
        public N4_PayerCityStateZIPCode_2010BB N4_PayerCityStateZIPCode_2010BB { get; set; }
        [ListCount(3)]
        [Pos(4)]
        public List<REF_PayerSecondaryIdentification_2010BB> REF_PayerSecondaryIdentification_2010BB { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",PR,")]
    public class X12_ID_98_NM1_PayerName_2010BB
    {
    }
    
    [Serializable()]
    [EdiCodes(",2,")]
    public class X12_ID_1065_NM1_PayerName_2010BB
    {
    }
    
    [Serializable()]
    [EdiCodes(",2U,FY,NF,TJ,")]
    public class X12_ID_128_REF_PayerSecondaryIdentification_2010BB
    {
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_REF_PayerSecondaryIdentification_2010BB))]
    public class REF_PayerSecondaryIdentification_2010BB
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_REF_PayerSecondaryIdentification_2010BB))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(2)]
        public string PayerAdditionalIdentifier_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string REF_03 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string REF_04 { get; set; }
    }
    
    [Serializable()]
    [Segment("N4")]
    public class N4_PayerCityStateZIPCode_2010BB
    {
        
        [Required]
        [StringLength(2, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(1)]
        public string PayerCityName_01 { get; set; }
        [Required]
        [StringLength(2, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(2)]
        public string PayerStateCode_02 { get; set; }
        [Required]
        [StringLength(3, 15)]
        [DataElement("", typeof(X12_ID))]
        [Pos(3)]
        public string PayerPostalZoneOrZIPCode_03 { get; set; }
        [StringLength(2, 3)]
        [DataElement("", typeof(X12_ID))]
        [Pos(4)]
        public string CountryCode_04 { get; set; }
        [StringLength(1, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(5)]
        public string N4_05 { get; set; }
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(6)]
        public string N4_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("N3")]
    public class N3_PayerAddress_2010BB
    {
        
        [Required]
        [StringLength(1, 55)]
        [DataElement("", typeof(X12_AN))]
        [Pos(1)]
        public string PayerAddressLine_01 { get; set; }
        [StringLength(1, 55)]
        [DataElement("", typeof(X12_AN))]
        [Pos(2)]
        public string PayerAddressLine_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_NM1_PayerName_2010BB), typeof(X12_ID_1065_NM1_PayerName_2010BB))]
    public class NM1_PayerName_2010BB
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98_NM1_PayerName_2010BB))]
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        [Required]
        [DataElement("1065", typeof(X12_ID_1065_NM1_PayerName_2010BB))]
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        [Required]
        [StringLength(1, 35)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string PayerName_03 { get; set; }
        [StringLength(1, 25)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string NM1_04 { get; set; }
        [StringLength(1, 25)]
        [DataElement("", typeof(X12_AN))]
        [Pos(5)]
        public string NM1_05 { get; set; }
        [StringLength(1, 10)]
        [DataElement("", typeof(X12_AN))]
        [Pos(6)]
        public string NM1_06 { get; set; }
        [StringLength(1, 10)]
        [DataElement("", typeof(X12_AN))]
        [Pos(7)]
        public string NM1_07 { get; set; }
        [Required]
        [DataElement("66", typeof(X12_ID_66_NM1_PayerName_2010BB))]
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        [Required]
        [StringLength(2, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(9)]
        public string PayerIdentifier_09 { get; set; }
        [StringLength(2, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(10)]
        public string NM1_10 { get; set; }
        [StringLength(2, 3)]
        [DataElement("", typeof(X12_ID))]
        [Pos(11)]
        public string NM1_11 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",PI,XV,")]
    public class X12_ID_66_NM1_PayerName_2010BB
    {
    }
    
    [Serializable()]
    [Group("NM1")]
    public class Loop_2010BA
    {
        
        [Required]
        [Pos(1)]
        public NM1_SubscriberName_2010BA NM1_SubscriberName_2010BA { get; set; }
        [Pos(2)]
        public N3_SubscriberAddress_2010BA N3_SubscriberAddress_2010BA { get; set; }
        [Pos(3)]
        public N4_SubscriberCityStateZIPCode_2010BA N4_SubscriberCityStateZIPCode_2010BA { get; set; }
        [Pos(4)]
        public DMG_SubscriberDemographicInformation_2010BA DMG_SubscriberDemographicInformation_2010BA { get; set; }
        [Pos(5)]
        public All_REF_2010BA All_REF_2010BA { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",IL,")]
    public class X12_ID_98_NM1_SubscriberName_2010BA
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,")]
    public class X12_ID_1065_NM1_SubscriberName_2010BA
    {
    }
    
    [Serializable()]
    [EdiCodes(",D8,")]
    public class X12_ID_1250_DMG_SubscriberDemographicInformation_2010BA
    {
    }
    
    [Serializable()]
    [All()]
    public class All_REF_2010BA
    {
        
        [ListCount(4)]
        [Pos(1)]
        public List<REF_SubscriberSecondaryIdentification_2010BA> REF_SubscriberSecondaryIdentification_2010BA { get; set; }
        [Pos(2)]
        public REF_PropertyAndCasualtyClaimNumber_2010BA REF_PropertyAndCasualtyClaimNumber_2010BA { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",1W,23,IG,SY,")]
    public class X12_ID_128_REF_SubscriberSecondaryIdentification_2010BA
    {
    }
    
    [Serializable()]
    [EdiCodes(",Y4,")]
    public class X12_ID_128_REF_PropertyAndCasualtyClaimNumber_2010BA
    {
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_REF_PropertyAndCasualtyClaimNumber_2010BA))]
    public class REF_PropertyAndCasualtyClaimNumber_2010BA
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_REF_PropertyAndCasualtyClaimNumber_2010BA))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(2)]
        public string PropertyCasualtyClaimNumber_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string REF_03 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string REF_04 { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_REF_SubscriberSecondaryIdentification_2010BA))]
    public class REF_SubscriberSecondaryIdentification_2010BA
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_REF_SubscriberSecondaryIdentification_2010BA))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(2)]
        public string SubscriberSupplementalIdentifier_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string REF_03 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string REF_04 { get; set; }
    }
    
    [Serializable()]
    [Segment("DMG", typeof(X12_ID_1250_DMG_SubscriberDemographicInformation_2010BA))]
    public class DMG_SubscriberDemographicInformation_2010BA
    {
        
        [Required]
        [DataElement("1250", typeof(X12_ID_1250_DMG_SubscriberDemographicInformation_2010BA))]
        [Pos(1)]
        public string DateTimePeriodFormatQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 35)]
        [DataElement("", typeof(X12_AN))]
        [Pos(2)]
        public string SubscriberBirthDate_02 { get; set; }
        [Required]
        [DataElement("1068", typeof(X12_ID_1068_DMG_SubscriberDemographicInformation_2010BA))]
        [Pos(3)]
        public string SubscriberGenderCode_03 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_ID))]
        [Pos(4)]
        public string DMG_04 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_ID))]
        [Pos(5)]
        public string DMG_05 { get; set; }
        [StringLength(1, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(6)]
        public string DMG_06 { get; set; }
        [StringLength(2, 3)]
        [DataElement("", typeof(X12_ID))]
        [Pos(7)]
        public string DMG_07 { get; set; }
        [StringLength(1, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(8)]
        public string DMG_08 { get; set; }
        [DataElement("", typeof(X12_R))]
        [Pos(9)]
        public string DMG_09 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",F,M,U,")]
    public class X12_ID_1068_DMG_SubscriberDemographicInformation_2010BA
    {
    }
    
    [Serializable()]
    [Segment("N4")]
    public class N4_SubscriberCityStateZIPCode_2010BA
    {
        
        [Required]
        [StringLength(2, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(1)]
        public string SubscriberCityName_01 { get; set; }
        [Required]
        [StringLength(2, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(2)]
        public string SubscriberStateCode_02 { get; set; }
        [Required]
        [StringLength(3, 15)]
        [DataElement("", typeof(X12_ID))]
        [Pos(3)]
        public string SubscriberPostalZoneOrZIPCode_03 { get; set; }
        [StringLength(2, 3)]
        [DataElement("", typeof(X12_ID))]
        [Pos(4)]
        public string CountryCode_04 { get; set; }
        [StringLength(1, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(5)]
        public string N4_05 { get; set; }
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(6)]
        public string N4_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("N3")]
    public class N3_SubscriberAddress_2010BA
    {
        
        [Required]
        [StringLength(1, 55)]
        [DataElement("", typeof(X12_AN))]
        [Pos(1)]
        public string SubscriberAddressLine_01 { get; set; }
        [StringLength(1, 55)]
        [DataElement("", typeof(X12_AN))]
        [Pos(2)]
        public string SubscriberAddressLine_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_NM1_SubscriberName_2010BA), typeof(X12_ID_1065_NM1_SubscriberName_2010BA))]
    public class NM1_SubscriberName_2010BA
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98_NM1_SubscriberName_2010BA))]
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        [Required]
        [DataElement("1065", typeof(X12_ID_1065_NM1_SubscriberName_2010BA))]
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        [Required]
        [StringLength(1, 35)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string SubscriberLastName_03 { get; set; }
        [StringLength(1, 25)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string SubscriberFirstName_04 { get; set; }
        [StringLength(1, 25)]
        [DataElement("", typeof(X12_AN))]
        [Pos(5)]
        public string SubscriberMiddleName_05 { get; set; }
        [StringLength(1, 10)]
        [DataElement("", typeof(X12_AN))]
        [Pos(6)]
        public string NM1_06 { get; set; }
        [StringLength(1, 10)]
        [DataElement("", typeof(X12_AN))]
        [Pos(7)]
        public string SubscriberNameSuffix_07 { get; set; }
        [DataElement("66", typeof(X12_ID_66_NM1_SubscriberName_2010BA))]
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        [StringLength(2, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(9)]
        public string SubscriberPrimaryIdentifier_09 { get; set; }
        [StringLength(2, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(10)]
        public string NM1_10 { get; set; }
        [StringLength(2, 3)]
        [DataElement("", typeof(X12_ID))]
        [Pos(11)]
        public string NM1_11 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",MI,ZZ,")]
    public class X12_ID_66_NM1_SubscriberName_2010BA
    {
    }
    
    [Serializable()]
    [Segment("PAT")]
    public class PAT_PatientInformation_2000B
    {
        
        [StringLength(2, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(1)]
        public string PAT_01 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_ID))]
        [Pos(2)]
        public string PAT_02 { get; set; }
        [StringLength(2, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(3)]
        public string PAT_03 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_ID))]
        [Pos(4)]
        public string PAT_04 { get; set; }
        [DataElement("1250", typeof(X12_ID_1250_PAT_PatientInformation_2000B))]
        [Pos(5)]
        public string DateTimePeriodFormatQualifier_05 { get; set; }
        [StringLength(1, 35)]
        [DataElement("", typeof(X12_AN))]
        [Pos(6)]
        public string InsuredIndividualDeathDate_06 { get; set; }
        [DataElement("355", typeof(X12_ID_355_PAT_PatientInformation_2000B))]
        [Pos(7)]
        public string UnitOrBasisForMeasurementCode_07 { get; set; }
        [DataElement("", typeof(X12_R))]
        [Pos(8)]
        public string PatientWeight_08 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073_PAT_PatientInformation_2000B))]
        [Pos(9)]
        public string PregnancyIndicator_09 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",D8,")]
    public class X12_ID_1250_PAT_PatientInformation_2000B
    {
    }
    
    [Serializable()]
    [EdiCodes(",01,")]
    public class X12_ID_355_PAT_PatientInformation_2000B
    {
    }
    
    [Serializable()]
    [EdiCodes(",Y,")]
    public class X12_ID_1073_PAT_PatientInformation_2000B
    {
    }
    
    [Serializable()]
    [Segment("SBR", typeof(X12_ID_1138_SBR_SubscriberInformation_2000B), typeof(X12_ID_1069_SBR_SubscriberInformation_2000B))]
    public class SBR_SubscriberInformation_2000B
    {
        
        [Required]
        [DataElement("1138", typeof(X12_ID_1138_SBR_SubscriberInformation_2000B))]
        [Pos(1)]
        public string PayerResponsibilitySequenceNumberCode_01 { get; set; }
        [DataElement("1069", typeof(X12_ID_1069_SBR_SubscriberInformation_2000B))]
        [Pos(2)]
        public string IndividualRelationshipCode_02 { get; set; }
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string InsuredGroupOrPolicyNumber_03 { get; set; }
        [StringLength(1, 60)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string InsuredGroupName_04 { get; set; }
        [DataElement("1336", typeof(X12_ID_1336_SBR_SubscriberInformation_2000B))]
        [Pos(5)]
        public string InsuranceTypeCode_05 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_ID))]
        [Pos(6)]
        public string SBR_06 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_ID))]
        [Pos(7)]
        public string SBR_07 { get; set; }
        [StringLength(2, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(8)]
        public string SBR_08 { get; set; }
        [DataElement("1032", typeof(X12_ID_1032_SBR_SubscriberInformation_2000B))]
        [Pos(9)]
        public string ClaimFilingIndicatorCode_09 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",12,13,14,15,16,41,42,43,47,")]
    public class X12_ID_1336_SBR_SubscriberInformation_2000B
    {
    }
    
    [Serializable()]
    [EdiCodes(",09,10,11,12,13,14,15,16,AM,BL,CH,CI,DS,HM,LI,LM,MB,MC,OF,TV,VA,WC,ZZ,")]
    public class X12_ID_1032_SBR_SubscriberInformation_2000B
    {
    }
    
    [Serializable()]
    [Segment("HL")]
    public class HL_SubscriberHierarchicalLevel_2000B
    {
        
        [Required]
        [StringLength(1, 12)]
        [DataElement("", typeof(X12_AN))]
        [Pos(1)]
        public string HierarchicalIDNumber_01 { get; set; }
        [Required]
        [StringLength(1, 12)]
        [DataElement("", typeof(X12_AN))]
        [Pos(2)]
        public string HierarchicalParentIDNumber_02 { get; set; }
        [Required]
        [DataElement("735", typeof(X12_ID_735_HL_SubscriberHierarchicalLevel_2000B))]
        [Pos(3)]
        public string HierarchicalLevelCode_03 { get; set; }
        [Required]
        [DataElement("736", typeof(X12_ID_736_HL_SubscriberHierarchicalLevel_2000B))]
        [Pos(4)]
        public string HierarchicalChildCode_04 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",22,")]
    public class X12_ID_735_HL_SubscriberHierarchicalLevel_2000B
    {
    }
    
    [Serializable()]
    [EdiCodes(",0,1,")]
    public class X12_ID_736_HL_SubscriberHierarchicalLevel_2000B
    {
    }
    
    [Serializable()]
    [All()]
    public class All_2010A
    {
        
        [Required]
        [Pos(1)]
        public Loop_2010AA Loop_2010AA { get; set; }
        [Pos(2)]
        public Loop_2010AB Loop_2010AB { get; set; }
    }
    
    [Serializable()]
    [Group("NM1")]
    public class Loop_2010AB
    {
        
        [Required]
        [Pos(1)]
        public NM1_PaytoProviderName_2010AB NM1_PaytoProviderName_2010AB { get; set; }
        [Required]
        [Pos(2)]
        public N3_PaytoProviderAddress_2010AB N3_PaytoProviderAddress_2010AB { get; set; }
        [Required]
        [Pos(3)]
        public N4_PaytoProviderCityStateZIPCode_2010AB N4_PaytoProviderCityStateZIPCode_2010AB { get; set; }
        [ListCount(5)]
        [Pos(4)]
        public List<REF_PaytoProviderSecondaryIdentification_2010AB> REF_PaytoProviderSecondaryIdentification_2010AB { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",87,")]
    public class X12_ID_98_NM1_PaytoProviderName_2010AB
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,")]
    public class X12_ID_1065_NM1_PaytoProviderName_2010AB
    {
    }
    
    [Serializable()]
    [EdiCodes(",0B,1A,1B,1C,1D,1G,1H,1J,B3,BQ,EI,FH,G2,G5,LU,SY,U3,X5,")]
    public class X12_ID_128_REF_PaytoProviderSecondaryIdentification_2010AB
    {
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_REF_PaytoProviderSecondaryIdentification_2010AB))]
    public class REF_PaytoProviderSecondaryIdentification_2010AB
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_REF_PaytoProviderSecondaryIdentification_2010AB))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(2)]
        public string PaytoProviderIdentifier_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string REF_03 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string REF_04 { get; set; }
    }
    
    [Serializable()]
    [Segment("N4")]
    public class N4_PaytoProviderCityStateZIPCode_2010AB
    {
        
        [Required]
        [StringLength(2, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(1)]
        public string PaytoProviderCityName_01 { get; set; }
        [Required]
        [StringLength(2, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(2)]
        public string PaytoProviderStateCode_02 { get; set; }
        [Required]
        [StringLength(3, 15)]
        [DataElement("", typeof(X12_ID))]
        [Pos(3)]
        public string PaytoProviderPostalZoneOrZIPCode_03 { get; set; }
        [StringLength(2, 3)]
        [DataElement("", typeof(X12_ID))]
        [Pos(4)]
        public string CountryCode_04 { get; set; }
        [StringLength(1, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(5)]
        public string N4_05 { get; set; }
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(6)]
        public string N4_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("N3")]
    public class N3_PaytoProviderAddress_2010AB
    {
        
        [Required]
        [StringLength(1, 55)]
        [DataElement("", typeof(X12_AN))]
        [Pos(1)]
        public string PaytoProviderAddressLine_01 { get; set; }
        [StringLength(1, 55)]
        [DataElement("", typeof(X12_AN))]
        [Pos(2)]
        public string PaytoProviderAddressLine_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_NM1_PaytoProviderName_2010AB), typeof(X12_ID_1065_NM1_PaytoProviderName_2010AB))]
    public class NM1_PaytoProviderName_2010AB
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98_NM1_PaytoProviderName_2010AB))]
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        [Required]
        [DataElement("1065", typeof(X12_ID_1065_NM1_PaytoProviderName_2010AB))]
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        [Required]
        [StringLength(1, 35)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string PaytoProviderLastOrOrganizationalName_03 { get; set; }
        [StringLength(1, 25)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string PaytoProviderFirstName_04 { get; set; }
        [StringLength(1, 25)]
        [DataElement("", typeof(X12_AN))]
        [Pos(5)]
        public string PaytoProviderMiddleName_05 { get; set; }
        [StringLength(1, 10)]
        [DataElement("", typeof(X12_AN))]
        [Pos(6)]
        public string NM1_06 { get; set; }
        [StringLength(1, 10)]
        [DataElement("", typeof(X12_AN))]
        [Pos(7)]
        public string PaytoProviderNameSuffix_07 { get; set; }
        [Required]
        [DataElement("66", typeof(X12_ID_66_NM1_PaytoProviderName_2010AB))]
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        [Required]
        [StringLength(2, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(9)]
        public string PaytoProviderIdentifier_09 { get; set; }
        [StringLength(2, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(10)]
        public string NM1_10 { get; set; }
        [StringLength(2, 3)]
        [DataElement("", typeof(X12_ID))]
        [Pos(11)]
        public string NM1_11 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",24,34,XX,")]
    public class X12_ID_66_NM1_PaytoProviderName_2010AB
    {
    }
    
    [Serializable()]
    [Group("NM1")]
    public class Loop_2010AA
    {
        
        [Required]
        [Pos(1)]
        public NM1_BillingProviderName_2010AA NM1_BillingProviderName_2010AA { get; set; }
        [Required]
        [Pos(2)]
        public N3_BillingProviderAddress_2010AA N3_BillingProviderAddress_2010AA { get; set; }
        [Required]
        [Pos(3)]
        public N4_BillingProviderCityStateZIPCode_2010AA N4_BillingProviderCityStateZIPCode_2010AA { get; set; }
        [Pos(4)]
        public All_REF_2010AA All_REF_2010AA { get; set; }
        [ListCount(2)]
        [Pos(5)]
        public List<PER_BillingProviderContactInformation_2010AA> PER_BillingProviderContactInformation_2010AA { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",85,")]
    public class X12_ID_98_NM1_BillingProviderName_2010AA
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,")]
    public class X12_ID_1065_NM1_BillingProviderName_2010AA
    {
    }
    
    [Serializable()]
    [EdiCodes(",IC,")]
    public class X12_ID_366_PER_BillingProviderContactInformation_2010AA
    {
    }
    
    [Serializable()]
    [Segment("PER", typeof(X12_ID_366_PER_BillingProviderContactInformation_2010AA))]
    public class PER_BillingProviderContactInformation_2010AA
    {
        
        [Required]
        [DataElement("366", typeof(X12_ID_366_PER_BillingProviderContactInformation_2010AA))]
        [Pos(1)]
        public string ContactFunctionCode_01 { get; set; }
        [Required]
        [StringLength(1, 60)]
        [DataElement("", typeof(X12_AN))]
        [Pos(2)]
        public string BillingProviderContactName_02 { get; set; }
        [Required]
        [DataElement("365", typeof(X12_ID_365_PER_BillingProviderContactInformation_2010AA))]
        [Pos(3)]
        public string CommunicationNumberQualifier_03 { get; set; }
        [Required]
        [StringLength(1, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string CommunicationNumber_04 { get; set; }
        [DataElement("365", typeof(X12_ID_365_PER_BillingProviderContactInformation_2010AA))]
        [Pos(5)]
        public string CommunicationNumberQualifier_05 { get; set; }
        [StringLength(1, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(6)]
        public string CommunicationNumber_06 { get; set; }
        [DataElement("365", typeof(X12_ID_365_PER_BillingProviderContactInformation_2010AA))]
        [Pos(7)]
        public string CommunicationNumberQualifier_07 { get; set; }
        [StringLength(1, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(8)]
        public string CommunicationNumber_08 { get; set; }
        [StringLength(1, 20)]
        [DataElement("", typeof(X12_AN))]
        [Pos(9)]
        public string PER_09 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",EM,FX,TE,")]
    public class X12_ID_365_PER_BillingProviderContactInformation_2010AA
    {
    }
    
    [Serializable()]
    [All()]
    public class All_REF_2010AA
    {
        
        [ListCount(8)]
        [Pos(1)]
        public List<REF_BillingProviderSecondaryIdentification_2010AA> REF_BillingProviderSecondaryIdentification_2010AA { get; set; }
        [ListCount(8)]
        [Pos(2)]
        public List<REF_CreditDebitCardBillingInformation_2010AA> REF_CreditDebitCardBillingInformation_2010AA { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",0B,1A,1B,1C,1D,1G,1H,1J,B3,BQ,EI,FH,G2,G5,LU,SY,U3,X5,")]
    public class X12_ID_128_REF_BillingProviderSecondaryIdentification_2010AA
    {
    }
    
    [Serializable()]
    [EdiCodes(",06,8U,EM,IJ,RB,ST,TT,")]
    public class X12_ID_128_REF_CreditDebitCardBillingInformation_2010AA
    {
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_REF_CreditDebitCardBillingInformation_2010AA))]
    public class REF_CreditDebitCardBillingInformation_2010AA
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_REF_CreditDebitCardBillingInformation_2010AA))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(2)]
        public string BillingProviderCreditCardIdentifier_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string REF_03 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string REF_04 { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_REF_BillingProviderSecondaryIdentification_2010AA))]
    public class REF_BillingProviderSecondaryIdentification_2010AA
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_REF_BillingProviderSecondaryIdentification_2010AA))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(2)]
        public string BillingProviderAdditionalIdentifier_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string REF_03 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string REF_04 { get; set; }
    }
    
    [Serializable()]
    [Segment("N4")]
    public class N4_BillingProviderCityStateZIPCode_2010AA
    {
        
        [Required]
        [StringLength(2, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(1)]
        public string BillingProviderCityName_01 { get; set; }
        [Required]
        [StringLength(2, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(2)]
        public string BillingProviderStateOrProvinceCode_02 { get; set; }
        [Required]
        [StringLength(3, 15)]
        [DataElement("", typeof(X12_ID))]
        [Pos(3)]
        public string BillingProviderPostalZoneOrZIPCode_03 { get; set; }
        [StringLength(2, 3)]
        [DataElement("", typeof(X12_ID))]
        [Pos(4)]
        public string CountryCode_04 { get; set; }
        [StringLength(1, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(5)]
        public string N4_05 { get; set; }
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(6)]
        public string N4_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("N3")]
    public class N3_BillingProviderAddress_2010AA
    {
        
        [Required]
        [StringLength(1, 55)]
        [DataElement("", typeof(X12_AN))]
        [Pos(1)]
        public string BillingProviderAddressLine_01 { get; set; }
        [StringLength(1, 55)]
        [DataElement("", typeof(X12_AN))]
        [Pos(2)]
        public string BillingProviderAddressLine_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_NM1_BillingProviderName_2010AA), typeof(X12_ID_1065_NM1_BillingProviderName_2010AA))]
    public class NM1_BillingProviderName_2010AA
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98_NM1_BillingProviderName_2010AA))]
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        [Required]
        [DataElement("1065", typeof(X12_ID_1065_NM1_BillingProviderName_2010AA))]
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        [Required]
        [StringLength(1, 35)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string BillingProviderLastOrOrganizationalName_03 { get; set; }
        [StringLength(1, 25)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string BillingProviderFirstName_04 { get; set; }
        [StringLength(1, 25)]
        [DataElement("", typeof(X12_AN))]
        [Pos(5)]
        public string BillingProviderMiddleName_05 { get; set; }
        [StringLength(1, 10)]
        [DataElement("", typeof(X12_AN))]
        [Pos(6)]
        public string NM1_06 { get; set; }
        [StringLength(1, 10)]
        [DataElement("", typeof(X12_AN))]
        [Pos(7)]
        public string BillingProviderNameSuffix_07 { get; set; }
        [Required]
        [DataElement("66", typeof(X12_ID_66_NM1_BillingProviderName_2010AA))]
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        [Required]
        [StringLength(2, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(9)]
        public string BillingProviderIdentifier_09 { get; set; }
        [StringLength(2, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(10)]
        public string NM1_10 { get; set; }
        [StringLength(2, 3)]
        [DataElement("", typeof(X12_ID))]
        [Pos(11)]
        public string NM1_11 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",24,34,XX,")]
    public class X12_ID_66_NM1_BillingProviderName_2010AA
    {
    }
    
    [Serializable()]
    [Segment("CUR", typeof(X12_ID_98_CUR_ForeignCurrencyInformation_2000A))]
    public class CUR_ForeignCurrencyInformation_2000A
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98_CUR_ForeignCurrencyInformation_2000A))]
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        [Required]
        [StringLength(3, 3)]
        [DataElement("", typeof(X12_ID))]
        [Pos(2)]
        public string CurrencyCode_02 { get; set; }
        [DataElement("", typeof(X12_R))]
        [Pos(3)]
        public string CUR_03 { get; set; }
        [StringLength(2, 3)]
        [DataElement("", typeof(X12_ID))]
        [Pos(4)]
        public string CUR_04 { get; set; }
        [StringLength(3, 3)]
        [DataElement("", typeof(X12_ID))]
        [Pos(5)]
        public string CUR_05 { get; set; }
        [StringLength(3, 3)]
        [DataElement("", typeof(X12_ID))]
        [Pos(6)]
        public string CUR_06 { get; set; }
        [StringLength(3, 3)]
        [DataElement("", typeof(X12_ID))]
        [Pos(7)]
        public string CUR_07 { get; set; }
        [StringLength(8, 8)]
        [DataElement("", typeof(X12_DT))]
        [Pos(8)]
        public string CUR_08 { get; set; }
        [StringLength(4, 8)]
        [DataElement("", typeof(X12_TM))]
        [Pos(9)]
        public string CUR_09 { get; set; }
        [StringLength(3, 3)]
        [DataElement("", typeof(X12_ID))]
        [Pos(10)]
        public string CUR_10 { get; set; }
        [StringLength(8, 8)]
        [DataElement("", typeof(X12_DT))]
        [Pos(11)]
        public string CUR_11 { get; set; }
        [StringLength(4, 8)]
        [DataElement("", typeof(X12_TM))]
        [Pos(12)]
        public string CUR_12 { get; set; }
        [StringLength(3, 3)]
        [DataElement("", typeof(X12_ID))]
        [Pos(13)]
        public string CUR_13 { get; set; }
        [StringLength(8, 8)]
        [DataElement("", typeof(X12_DT))]
        [Pos(14)]
        public string CUR_14 { get; set; }
        [StringLength(4, 8)]
        [DataElement("", typeof(X12_TM))]
        [Pos(15)]
        public string CUR_15 { get; set; }
        [StringLength(3, 3)]
        [DataElement("", typeof(X12_ID))]
        [Pos(16)]
        public string CUR_16 { get; set; }
        [StringLength(8, 8)]
        [DataElement("", typeof(X12_DT))]
        [Pos(17)]
        public string CUR_17 { get; set; }
        [StringLength(4, 8)]
        [DataElement("", typeof(X12_TM))]
        [Pos(18)]
        public string CUR_18 { get; set; }
        [StringLength(3, 3)]
        [DataElement("", typeof(X12_ID))]
        [Pos(19)]
        public string CUR_19 { get; set; }
        [StringLength(8, 8)]
        [DataElement("", typeof(X12_DT))]
        [Pos(20)]
        public string CUR_20 { get; set; }
        [StringLength(4, 8)]
        [DataElement("", typeof(X12_TM))]
        [Pos(21)]
        public string CUR_21 { get; set; }
    }
    
    [Serializable()]
    public class X12_TM
    {
    }
    
    [Serializable()]
    [Segment("PRV", typeof(X12_ID_1221_PRV_BillingPaytoProviderSpecialtyInformation_2000A), typeof(X12_ID_128_PRV_BillingPaytoProviderSpecialtyInformation_2000A))]
    public class PRV_BillingPaytoProviderSpecialtyInformation_2000A
    {
        
        [Required]
        [DataElement("1221", typeof(X12_ID_1221_PRV_BillingPaytoProviderSpecialtyInformation_2000A))]
        [Pos(1)]
        public string ProviderCode_01 { get; set; }
        [Required]
        [DataElement("128", typeof(X12_ID_128_PRV_BillingPaytoProviderSpecialtyInformation_2000A))]
        [Pos(2)]
        public string ReferenceIdentificationQualifier_02 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string ProviderTaxonomyCode_03 { get; set; }
        [StringLength(2, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(4)]
        public string PRV_04 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_AN))]
        [Pos(5)]
        public string PRV_05 { get; set; }
        [StringLength(3, 3)]
        [DataElement("", typeof(X12_ID))]
        [Pos(6)]
        public string PRV_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("HL")]
    public class HL_BillingPaytoProviderHierarchicalLevel_2000A
    {
        
        [Required]
        [StringLength(1, 12)]
        [DataElement("", typeof(X12_AN))]
        [Pos(1)]
        public string HierarchicalIDNumber_01 { get; set; }
        [StringLength(1, 12)]
        [DataElement("", typeof(X12_AN))]
        [Pos(2)]
        public string HL_02 { get; set; }
        [Required]
        [DataElement("735", typeof(X12_ID_735_HL_BillingPaytoProviderHierarchicalLevel_2000A))]
        [Pos(3)]
        public string HierarchicalLevelCode_03 { get; set; }
        [Required]
        [DataElement("736", typeof(X12_ID_736_HL_BillingPaytoProviderHierarchicalLevel_2000A))]
        [Pos(4)]
        public string HierarchicalChildCode_04 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",20,")]
    public class X12_ID_735_HL_BillingPaytoProviderHierarchicalLevel_2000A
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,")]
    public class X12_ID_736_HL_BillingPaytoProviderHierarchicalLevel_2000A
    {
    }
    
    [Serializable()]
    [Group("NM1")]
    public class Loop_1000B
    {
        
        [Required]
        [Pos(1)]
        public NM1_ReceiverName_1000B NM1_ReceiverName_1000B { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",40,")]
    public class X12_ID_98_NM1_ReceiverName_1000B
    {
    }
    
    [Serializable()]
    [EdiCodes(",2,")]
    public class X12_ID_1065_NM1_ReceiverName_1000B
    {
    }
    
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_NM1_ReceiverName_1000B), typeof(X12_ID_1065_NM1_ReceiverName_1000B))]
    public class NM1_ReceiverName_1000B
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98_NM1_ReceiverName_1000B))]
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        [Required]
        [DataElement("1065", typeof(X12_ID_1065_NM1_ReceiverName_1000B))]
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        [Required]
        [StringLength(1, 35)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string ReceiverName_03 { get; set; }
        [StringLength(1, 25)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string NM1_04 { get; set; }
        [StringLength(1, 25)]
        [DataElement("", typeof(X12_AN))]
        [Pos(5)]
        public string NM1_05 { get; set; }
        [StringLength(1, 10)]
        [DataElement("", typeof(X12_AN))]
        [Pos(6)]
        public string NM1_06 { get; set; }
        [StringLength(1, 10)]
        [DataElement("", typeof(X12_AN))]
        [Pos(7)]
        public string NM1_07 { get; set; }
        [Required]
        [DataElement("66", typeof(X12_ID_66_NM1_ReceiverName_1000B))]
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        [Required]
        [StringLength(2, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(9)]
        public string ReceiverPrimaryIdentifier_09 { get; set; }
        [StringLength(2, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(10)]
        public string NM1_10 { get; set; }
        [StringLength(2, 3)]
        [DataElement("", typeof(X12_ID))]
        [Pos(11)]
        public string NM1_11 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",46,")]
    public class X12_ID_66_NM1_ReceiverName_1000B
    {
    }
    
    [Serializable()]
    [Group("NM1")]
    public class Loop_1000A
    {
        
        [Required]
        [Pos(1)]
        public NM1_SubmitterName_1000A NM1_SubmitterName_1000A { get; set; }
        [Required]
        [ListCount(2)]
        [Pos(2)]
        public List<PER_SubmitterEDIContactInformation_1000A> PER_SubmitterEDIContactInformation_1000A { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",41,")]
    public class X12_ID_98_NM1_SubmitterName_1000A
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,")]
    public class X12_ID_1065_NM1_SubmitterName_1000A
    {
    }
    
    [Serializable()]
    [EdiCodes(",IC,")]
    public class X12_ID_366_PER_SubmitterEDIContactInformation_1000A
    {
    }
    
    [Serializable()]
    [Segment("PER", typeof(X12_ID_366_PER_SubmitterEDIContactInformation_1000A))]
    public class PER_SubmitterEDIContactInformation_1000A
    {
        
        [Required]
        [DataElement("366", typeof(X12_ID_366_PER_SubmitterEDIContactInformation_1000A))]
        [Pos(1)]
        public string ContactFunctionCode_01 { get; set; }
        [Required]
        [StringLength(1, 60)]
        [DataElement("", typeof(X12_AN))]
        [Pos(2)]
        public string SubmitterContactName_02 { get; set; }
        [Required]
        [DataElement("365", typeof(X12_ID_365_PER_SubmitterEDIContactInformation_1000A))]
        [Pos(3)]
        public string CommunicationNumberQualifier_03 { get; set; }
        [Required]
        [StringLength(1, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string CommunicationNumber_04 { get; set; }
        [DataElement("365", typeof(X12_ID_365_PER_SubmitterEDIContactInformation_1000A))]
        [Pos(5)]
        public string CommunicationNumberQualifier_05 { get; set; }
        [StringLength(1, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(6)]
        public string CommunicationNumber_06 { get; set; }
        [DataElement("365", typeof(X12_ID_365_PER_SubmitterEDIContactInformation_1000A))]
        [Pos(7)]
        public string CommunicationNumberQualifier_07 { get; set; }
        [StringLength(1, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(8)]
        public string CommunicationNumber_08 { get; set; }
        [StringLength(1, 20)]
        [DataElement("", typeof(X12_AN))]
        [Pos(9)]
        public string PER_09 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",ED,EM,FX,TE,")]
    public class X12_ID_365_PER_SubmitterEDIContactInformation_1000A
    {
    }
    
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_NM1_SubmitterName_1000A), typeof(X12_ID_1065_NM1_SubmitterName_1000A))]
    public class NM1_SubmitterName_1000A
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98_NM1_SubmitterName_1000A))]
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        [Required]
        [DataElement("1065", typeof(X12_ID_1065_NM1_SubmitterName_1000A))]
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        [Required]
        [StringLength(1, 35)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string SubmitterLastOrOrganizationName_03 { get; set; }
        [StringLength(1, 25)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string SubmitterFirstName_04 { get; set; }
        [StringLength(1, 25)]
        [DataElement("", typeof(X12_AN))]
        [Pos(5)]
        public string SubmitterMiddleName_05 { get; set; }
        [StringLength(1, 10)]
        [DataElement("", typeof(X12_AN))]
        [Pos(6)]
        public string NM1_06 { get; set; }
        [StringLength(1, 10)]
        [DataElement("", typeof(X12_AN))]
        [Pos(7)]
        public string NM1_07 { get; set; }
        [Required]
        [DataElement("66", typeof(X12_ID_66_NM1_SubmitterName_1000A))]
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        [Required]
        [StringLength(2, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(9)]
        public string SubmitterIdentifier_09 { get; set; }
        [StringLength(2, 2)]
        [DataElement("", typeof(X12_ID))]
        [Pos(10)]
        public string NM1_10 { get; set; }
        [StringLength(2, 3)]
        [DataElement("", typeof(X12_ID))]
        [Pos(11)]
        public string NM1_11 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",46,")]
    public class X12_ID_66_NM1_SubmitterName_1000A
    {
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_REF_TransmissionTypeIdentification))]
    public class REF_TransmissionTypeIdentification
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_REF_TransmissionTypeIdentification))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(2)]
        public string TransmissionTypeCode_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string REF_03 { get; set; }
        [StringLength(1, 1)]
        [DataElement("", typeof(X12_AN))]
        [Pos(4)]
        public string REF_04 { get; set; }
    }
    
    [Serializable()]
    [Segment("BHT", typeof(X12_ID_1005_BHT_BeginningOfHierarchicalTransaction), typeof(X12_ID_353_BHT_BeginningOfHierarchicalTransaction))]
    public class BHT_BeginningOfHierarchicalTransaction
    {
        
        [Required]
        [DataElement("1005", typeof(X12_ID_1005_BHT_BeginningOfHierarchicalTransaction))]
        [Pos(1)]
        public string HierarchicalStructureCode_01 { get; set; }
        [Required]
        [DataElement("353", typeof(X12_ID_353_BHT_BeginningOfHierarchicalTransaction))]
        [Pos(2)]
        public string TransactionSetPurposeCode_02 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("", typeof(X12_AN))]
        [Pos(3)]
        public string OriginatorApplicationTransactionIdentifier_03 { get; set; }
        [Required]
        [StringLength(8, 8)]
        [DataElement("", typeof(X12_DT))]
        [Pos(4)]
        public string TransactionSetCreationDate_04 { get; set; }
        [Required]
        [StringLength(4, 8)]
        [DataElement("", typeof(X12_TM))]
        [Pos(5)]
        public string TransactionSetCreationTime_05 { get; set; }
        [Required]
        [DataElement("640", typeof(X12_ID_640_BHT_BeginningOfHierarchicalTransaction))]
        [Pos(6)]
        public string ClaimOrEncounterIdentifier_06 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",CH,RP,")]
    public class X12_ID_640_BHT_BeginningOfHierarchicalTransaction
    {
    }
    
    [Serializable()]
    [Segment("ST")]
    public class ST
    {
        
        [Required]
        [StringLength(3, 3)]
        [DataElement("143", typeof(X12_AN))]
        [Pos(1)]
        public string TransactionSetIdentifierCode_01 { get; set; }
        [Required]
        [StringLength(4, 9)]
        [DataElement("329", typeof(X12_AN))]
        [Pos(2)]
        public string TransactionSetControlNumber_02 { get; set; }
        [StringLength(1, 9)]
        [DataElement("1705", typeof(X12_AN))]
        [Pos(3)]
        public string ImplementationConventionPreference_03 { get; set; }
    }
}
