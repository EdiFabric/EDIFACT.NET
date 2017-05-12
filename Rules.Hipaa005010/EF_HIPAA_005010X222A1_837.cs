using EdiFabric.Core.Annotations;
using EdiFabric.Core.Annotations.Edi;
using EdiFabric.Core.Annotations.Validation;
using EdiFabric.Core.Model;
using EdiFabric.Core.Model.Edi;

namespace EdiFabric.Rules.HIPAA_005010X222A1_837
{
    using System;
    using System.Collections.Generic;


    [Serializable()]
    [Message("X12", "005010X222A1", "837")]
    public class TS837 : EdiMessage
    {
        
        [Pos(1)]
        public ST ST { get; set; }
        [Required]
        [Pos(2)]
        public BHT_BeginningofHierarchicalTransaction BHT_BeginningofHierarchicalTransaction { get; set; }
        [Required]
        [Pos(3)]
        public All_NM1 All_NM1 { get; set; }
        [Required]
        [Pos(4)]
        public List<Loop_2000A> Loop_2000A { get; set; }
        [Pos(5)]
        public SE SE { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",837,")]
    public class X12_ID_143
    {
    }
    
    [Serializable()]
    public class X12_AN
    {
    }
    
    [Serializable()]
    [EdiCodes(",0019,")]
    public class X12_ID_1005
    {
    }
    
    [Serializable()]
    [EdiCodes(",00,18,")]
    public class X12_ID_353
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
    [Group("HL")]
    public class Loop_2000A
    {
        
        [Required]
        [Pos(1)]
        public HL_BillingProviderHierarchicalLevel HL_BillingProviderHierarchicalLevel { get; set; }
        [Pos(2)]
        public PRV_BillingProviderSpecialtyInformation PRV_BillingProviderSpecialtyInformation { get; set; }
        [Pos(3)]
        public CUR_ForeignCurrencyInformation CUR_ForeignCurrencyInformation { get; set; }
        [Required]
        [Pos(4)]
        public All_NM1_2 All_NM1_2 { get; set; }
        [Required]
        [Pos(5)]
        public List<Loop_2000B> Loop_2000B { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",BI,")]
    public class X12_ID_1221
    {
    }
    
    [Serializable()]
    [EdiCodes(",PXC,")]
    public class X12_ID_128
    {
    }
    
    [Serializable()]
    [EdiCodes(",85,")]
    public class X12_ID_98_4
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
        public HL_SubscriberHierarchicalLevel HL_SubscriberHierarchicalLevel { get; set; }
        [Required]
        [Pos(2)]
        public SBR_SubscriberInformation SBR_SubscriberInformation { get; set; }
        [Pos(3)]
        public PAT_PatientInformation PAT_PatientInformation { get; set; }
        [Required]
        [Pos(4)]
        public All_NM1_3 All_NM1_3 { get; set; }
        [ListCount(100)]
        [Pos(5)]
        public List<Loop_2300> Loop_2300 { get; set; }
        [Pos(6)]
        public List<Loop_2000C> Loop_2000C { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",A,B,C,D,E,F,G,H,P,S,T,U,")]
    public class X12_ID_1138
    {
    }
    
    [Serializable()]
    [EdiCodes(",18,")]
    public class X12_ID_1069
    {
    }
    
    [Serializable()]
    [EdiCodes(@",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,36,37,38,39,40,41,43,45,46,47,48,49,50,51,52,53,55,56,57,58,59,60,61,62,63,64,65,66,67,68,70,71,72,73,74,75,76,78,79,80,81,82,83,84,86,87,88,90,91,92,93,94,95,96,97,98,99,A1,A2,A3,A4,A5,A6,A7,A8,A9,B1,B2,B3,B4,B5,B6,B7,B8,B9,C1,C2,C3,C4,C5,C8,C9,D1,D2,D3,D4,D5,D6,D7,D8,D9,E1,E2,E3,E4,E5,E6,E7,E8,E9,F1,F2,F3,F6,F7,F8,F9,G2,G3,G4,G5,G6,G7,G8,G9,H1,H4,N1,OT,ZZ,")]
    public class X12_ID_1069_2
    {
    }
    
    [Serializable()]
    [EdiCodes(",A,B,C,D,E,F,G,H,L,M,O,P,R,S,T,")]
    public class X12_ID_1384
    {
    }
    
    [Serializable()]
    [Group("HL")]
    public class Loop_2000C
    {
        
        [Required]
        [Pos(1)]
        public HL_PatientHierarchicalLevel HL_PatientHierarchicalLevel { get; set; }
        [Required]
        [Pos(2)]
        public PAT_PatientInformation_2 PAT_PatientInformation_2 { get; set; }
        [Required]
        [Pos(3)]
        public Loop_2010CA Loop_2010CA { get; set; }
        [Required]
        [ListCount(100)]
        [Pos(4)]
        public List<Loop_2300_2> Loop_2300_2 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",01,19,20,21,39,40,53,G8,")]
    public class X12_ID_1069_4
    {
    }
    
    [Serializable()]
    [Group("CLM")]
    public class Loop_2300_2
    {
        
        [Required]
        [Pos(1)]
        public CLM_ClaimInformation_2 CLM_ClaimInformation_2 { get; set; }
        [Pos(2)]
        public All_DTP_3 All_DTP_3 { get; set; }
        [ListCount(10)]
        [Pos(3)]
        public List<PWK_ClaimSupplementalInformation_2> PWK_ClaimSupplementalInformation_2 { get; set; }
        [Pos(4)]
        public CN1_ContractInformation_3 CN1_ContractInformation_3 { get; set; }
        [Pos(5)]
        public AMT_PatientAmountPaid_2 AMT_PatientAmountPaid_2 { get; set; }
        [Pos(6)]
        public All_REF_9 All_REF_9 { get; set; }
        [ListCount(10)]
        [Pos(7)]
        public List<K3_FileInformation_3> K3_FileInformation_3 { get; set; }
        [Pos(8)]
        public NTE_ClaimNote_2 NTE_ClaimNote_2 { get; set; }
        [Pos(9)]
        public CR1_AmbulanceTransportInformation_3 CR1_AmbulanceTransportInformation_3 { get; set; }
        [Pos(10)]
        public CR2_SpinalManipulationServiceInformation_2 CR2_SpinalManipulationServiceInformation_2 { get; set; }
        [Pos(11)]
        public All_CRC_3 All_CRC_3 { get; set; }
        [Required]
        [Pos(12)]
        public All_HI_2 All_HI_2 { get; set; }
        [Pos(13)]
        public HCP_ClaimPricing_RepricingInformation_2 HCP_ClaimPricing_RepricingInformation_2 { get; set; }
        [Pos(14)]
        public All_NM1_7 All_NM1_7 { get; set; }
        [ListCount(10)]
        [Pos(15)]
        public List<Loop_2320_2> Loop_2320_2 { get; set; }
        [Required]
        [ListCount(50)]
        [Pos(16)]
        public List<Loop_2400_2> Loop_2400_2 { get; set; }
    }
    
    [Serializable()]
    public class X12_R
    {
    }
    
    [Serializable()]
    [EdiCodes(",03,04,05,06,07,08,09,10,11,13,15,21,77,A3,A4,AM,AS,B2,B3,B4,BR,BS,BT,CB,CK,CT,D2" +
        ",DA,DB,DG,DJ,DS,EB,HC,HR,I5,IR,LA,M1,MT,NN,OB,OC,OD,OE,OX,OZ,P4,P5,PE,PN,PO,PQ,P" +
        "Y,PZ,RB,RR,RT,RX,SG,V5,XP,")]
    public class X12_ID_755
    {
    }
    
    [Serializable()]
    [EdiCodes(",AA,BM,EL,EM,FT,FX,")]
    public class X12_ID_756
    {
    }
    
    [Serializable()]
    [EdiCodes(",01,02,03,04,05,06,09,")]
    public class X12_ID_1166
    {
    }
    
    [Serializable()]
    [EdiCodes(",F5,")]
    public class X12_ID_522
    {
    }
    
    [Serializable()]
    [EdiCodes(",C,D,E,F,P,S,")]
    public class X12_ID_1333
    {
    }
    
    [Serializable()]
    [EdiCodes(",ADD,CER,DCP,DGN,TPO,")]
    public class X12_ID_363
    {
    }
    
    [Serializable()]
    [EdiCodes(",LB,")]
    public class X12_ID_355_3
    {
    }
    
    [Serializable()]
    [EdiCodes(",00,01,02,03,04,05,07,08,09,10,11,12,13,14,")]
    public class X12_ID_1473
    {
    }
    
    [Serializable()]
    [Group("LX")]
    public class Loop_2400_2
    {
        
        [Required]
        [Pos(1)]
        public LX_ServiceLineNumber_2 LX_ServiceLineNumber_2 { get; set; }
        [Required]
        [Pos(2)]
        public SV1_ProfessionalService_2 SV1_ProfessionalService_2 { get; set; }
        [Pos(3)]
        public SV5_DurableMedicalEquipmentService_2 SV5_DurableMedicalEquipmentService_2 { get; set; }
        [Pos(4)]
        public All_PWK_2 All_PWK_2 { get; set; }
        [Pos(5)]
        public CR1_AmbulanceTransportInformation_4 CR1_AmbulanceTransportInformation_4 { get; set; }
        [Pos(6)]
        public CR3_DurableMedicalEquipmentCertification_2 CR3_DurableMedicalEquipmentCertification_2 { get; set; }
        [Pos(7)]
        public All_CRC_4 All_CRC_4 { get; set; }
        [Required]
        [Pos(8)]
        public All_DTP_4 All_DTP_4 { get; set; }
        [Pos(9)]
        public All_QTY_2 All_QTY_2 { get; set; }
        [ListCount(5)]
        [Pos(10)]
        public List<MEA_TestResult_2> MEA_TestResult_2 { get; set; }
        [Pos(11)]
        public CN1_ContractInformation_4 CN1_ContractInformation_4 { get; set; }
        [Pos(12)]
        public All_REF_11 All_REF_11 { get; set; }
        [Pos(13)]
        public All_AMT_4 All_AMT_4 { get; set; }
        [ListCount(10)]
        [Pos(14)]
        public List<K3_FileInformation_4> K3_FileInformation_4 { get; set; }
        [Pos(15)]
        public All_NTE_2 All_NTE_2 { get; set; }
        [Pos(16)]
        public PS1_PurchasedServiceInformation_2 PS1_PurchasedServiceInformation_2 { get; set; }
        [Pos(17)]
        public HCP_LinePricing_RepricingInformation_2 HCP_LinePricing_RepricingInformation_2 { get; set; }
        [Pos(18)]
        public Loop_2410_2 Loop_2410_2 { get; set; }
        [Pos(19)]
        public All_NM1_9 All_NM1_9 { get; set; }
        [ListCount(15)]
        [Pos(20)]
        public List<Loop_2430_2> Loop_2430_2 { get; set; }
        [Pos(21)]
        public List<Loop_2440_2> Loop_2440_2 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",ER,HC,IV,WK,")]
    public class X12_ID_235_2
    {
    }
    
    [Serializable()]
    [EdiCodes(",HC,")]
    public class X12_ID_235_3
    {
    }
    
    [Serializable()]
    [EdiCodes(",DA,")]
    public class X12_ID_355_6
    {
    }
    
    [Serializable()]
    [EdiCodes(",I,R,S,")]
    public class X12_ID_1322
    {
    }
    
    [Serializable()]
    [EdiCodes(",MO,")]
    public class X12_ID_355_7
    {
    }
    
    [Serializable()]
    [EdiCodes(",OG,TR,")]
    public class X12_ID_737
    {
    }
    
    [Serializable()]
    [EdiCodes(",HT,R1,R2,R3,R4,")]
    public class X12_ID_738
    {
    }
    
    [Serializable()]
    [EdiCodes(",00,01,02,03,04,05,06,07,08,09,10,11,12,13,14,")]
    public class X12_ID_1473_2
    {
    }
    
    [Serializable()]
    [Group("LQ")]
    public class Loop_2440_2
    {
        
        [Required]
        [Pos(1)]
        public LQ_FormIdentificationCode_2 LQ_FormIdentificationCode_2 { get; set; }
        [Required]
        [ListCount(99)]
        [Pos(2)]
        public List<FRM_SupportingDocumentation_2> FRM_SupportingDocumentation_2 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",AS,UT,")]
    public class X12_ID_1270_7
    {
    }
    
    [Serializable()]
    [EdiCodes(",N,W,Y,")]
    public class X12_ID_1073_4
    {
    }
    
    [Serializable()]
    [Segment("FRM")]
    public class FRM_SupportingDocumentation_2
    {
        
        [Required]
        [StringLength(1, 20)]
        [DataElement("350", typeof(X12_AN))]
        [Pos(1)]
        public string QuestionNumberLetter_01 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073_4))]
        [Pos(2)]
        public string QuestionResponse_02 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(3)]
        public string QuestionResponse_03 { get; set; }
        [StringLength(8, 8)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(4)]
        public string QuestionResponse_04 { get; set; }
        [StringLength(1, 6)]
        [DataElement("332", typeof(X12_R))]
        [Pos(5)]
        public string QuestionResponse_05 { get; set; }
    }
    
    [Serializable()]
    public class X12_DT
    {
    }
    
    [Serializable()]
    [Segment("LQ", typeof(X12_ID_1270_7))]
    public class LQ_FormIdentificationCode_2
    {
        
        [Required]
        [DataElement("1270", typeof(X12_ID_1270_7))]
        [Pos(1)]
        public string CodeListQualifierCode_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(2)]
        public string FormIdentifier_02 { get; set; }
    }
    
    [Serializable()]
    [Group("SVD")]
    public class Loop_2430_2
    {
        
        [Required]
        [Pos(1)]
        public SVD_LineAdjudicationInformation_2 SVD_LineAdjudicationInformation_2 { get; set; }
        [ListCount(5)]
        [Pos(2)]
        public List<CAS_LineAdjustment_2> CAS_LineAdjustment_2 { get; set; }
        [Required]
        [Pos(3)]
        public DTP_LineCheckorRemittanceDate_2 DTP_LineCheckorRemittanceDate_2 { get; set; }
        [Pos(4)]
        public AMT_RemainingPatientLiability_4 AMT_RemainingPatientLiability_4 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",CO,CR,OA,PI,PR,")]
    public class X12_ID_1033
    {
    }
    
    [Serializable()]
    [EdiCodes(",573,")]
    public class X12_ID_374_18
    {
    }
    
    [Serializable()]
    [EdiCodes(",D8,")]
    public class X12_ID_1250
    {
    }
    
    [Serializable()]
    [EdiCodes(",EAF,")]
    public class X12_ID_522_4
    {
    }
    
    [Serializable()]
    [Segment("AMT", typeof(X12_ID_522_4))]
    public class AMT_RemainingPatientLiability_4
    {
        
        [Required]
        [DataElement("522", typeof(X12_ID_522_4))]
        [Pos(1)]
        public string AmountQualifierCode_01 { get; set; }
        [Required]
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(2)]
        public string RemainingPatientLiability_02 { get; set; }
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
    [Segment("DTP", typeof(X12_ID_374_18), typeof(X12_ID_1250))]
    public class DTP_LineCheckorRemittanceDate_2
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374_18))]
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
        public string AdjudicationorPaymentDate_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("CAS", typeof(X12_ID_1033))]
    public class CAS_LineAdjustment_2
    {
        
        [Required]
        [DataElement("1033", typeof(X12_ID_1033))]
        [Pos(1)]
        public string ClaimAdjustmentGroupCode_01 { get; set; }
        [Required]
        [StringLength(1, 5)]
        [DataElement("1034", typeof(X12_ID))]
        [Pos(2)]
        public string AdjustmentReasonCode_02 { get; set; }
        [Required]
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(3)]
        public string AdjustmentAmount_03 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(4)]
        public string AdjustmentQuantity_04 { get; set; }
        [StringLength(1, 5)]
        [DataElement("1034", typeof(X12_ID))]
        [Pos(5)]
        public string AdjustmentReasonCode_05 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(6)]
        public string AdjustmentAmount_06 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(7)]
        public string AdjustmentQuantity_07 { get; set; }
        [StringLength(1, 5)]
        [DataElement("1034", typeof(X12_ID))]
        [Pos(8)]
        public string AdjustmentReasonCode_08 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(9)]
        public string AdjustmentAmount_09 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(10)]
        public string AdjustmentQuantity_10 { get; set; }
        [StringLength(1, 5)]
        [DataElement("1034", typeof(X12_ID))]
        [Pos(11)]
        public string AdjustmentReasonCode_11 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(12)]
        public string AdjustmentAmount_12 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(13)]
        public string AdjustmentQuantity_13 { get; set; }
        [StringLength(1, 5)]
        [DataElement("1034", typeof(X12_ID))]
        [Pos(14)]
        public string AdjustmentReasonCode_14 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(15)]
        public string AdjustmentAmount_15 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(16)]
        public string AdjustmentQuantity_16 { get; set; }
        [StringLength(1, 5)]
        [DataElement("1034", typeof(X12_ID))]
        [Pos(17)]
        public string AdjustmentReasonCode_17 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(18)]
        public string AdjustmentAmount_18 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(19)]
        public string AdjustmentQuantity_19 { get; set; }
    }
    
    [Serializable()]
    [Segment("SVD")]
    public class SVD_LineAdjudicationInformation_2
    {
        
        [Required]
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(1)]
        public string OtherPayerPrimaryIdentifier_01 { get; set; }
        [Required]
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(2)]
        public string ServiceLinePaidAmount_02 { get; set; }
        [Required]
        [Pos(3)]
        public C003_CompositeMedicalProcedureIdentifier_6 CompositeMedicalProcedureIdentifier_03 { get; set; }
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(4)]
        public string ProductServiceID_04 { get; set; }
        [Required]
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(5)]
        public string PaidServiceUnitCount_05 { get; set; }
        [StringLength(1, 6)]
        [DataElement("554", typeof(X12_N0))]
        [Pos(6)]
        public string BundledorUnbundledLineNumber_06 { get; set; }
    }
    
    [Serializable()]
    [Composite("C003_CompositeMedicalProcedureIdentifier_6")]
    public class C003_CompositeMedicalProcedureIdentifier_6
    {
        
        [Required]
        [DataElement("235", typeof(X12_ID_235_2))]
        [Pos(1)]
        public string ProductorServiceIDQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(2)]
        public string ProcedureCode_02 { get; set; }
        [StringLength(2, 2)]
        [DataElement("1339", typeof(X12_AN))]
        [Pos(3)]
        public string ProcedureModifier_03 { get; set; }
        [StringLength(2, 2)]
        [DataElement("1339", typeof(X12_AN))]
        [Pos(4)]
        public string ProcedureModifier_04 { get; set; }
        [StringLength(2, 2)]
        [DataElement("1339", typeof(X12_AN))]
        [Pos(5)]
        public string ProcedureModifier_05 { get; set; }
        [StringLength(2, 2)]
        [DataElement("1339", typeof(X12_AN))]
        [Pos(6)]
        public string ProcedureModifier_06 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(7)]
        public string ProcedureCodeDescription_07 { get; set; }
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(8)]
        public string ProductServiceID_08 { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_NM1_9
    {
        
        [Pos(1)]
        public Loop_2420A_2 Loop_2420A_2 { get; set; }
        [Pos(2)]
        public Loop_2420B_2 Loop_2420B_2 { get; set; }
        [Pos(3)]
        public Loop_2420C_2 Loop_2420C_2 { get; set; }
        [Pos(4)]
        public Loop_2420D_2 Loop_2420D_2 { get; set; }
        [Pos(5)]
        public Loop_2420E_2 Loop_2420E_2 { get; set; }
        [ListCount(2)]
        [Pos(6)]
        public List<Loop_2420F_2> Loop_2420F_2 { get; set; }
        [Pos(7)]
        public Loop_2420G_2 Loop_2420G_2 { get; set; }
        [Pos(8)]
        public Loop_2420H_2 Loop_2420H_2 { get; set; }
    }
    
    [Serializable()]
    [Group("NM1")]
    public class Loop_2420H_2
    {
        
        [Required]
        [Pos(1)]
        public NM1_AmbulanceDrop_offLocation_4 NM1_AmbulanceDrop_offLocation_4 { get; set; }
        [Required]
        [Pos(2)]
        public N3_AmbulanceDrop_offLocationAddress_4 N3_AmbulanceDrop_offLocationAddress_4 { get; set; }
        [Required]
        [Pos(3)]
        public N4_AmbulanceDrop_offLocationCity_State_ZipCode_4 N4_AmbulanceDrop_offLocationCity_State_ZipCode_4 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",45,")]
    public class X12_ID_98_14
    {
    }
    
    [Serializable()]
    [EdiCodes(",2,")]
    public class X12_ID_1065_2
    {
    }
    
    [Serializable()]
    [Segment("N4")]
    public class N4_AmbulanceDrop_offLocationCity_State_ZipCode_4
    {
        
        [Required]
        [StringLength(2, 30)]
        [DataElement("19", typeof(X12_AN))]
        [Pos(1)]
        public string AmbulanceDropoffCityName_01 { get; set; }
        [StringLength(2, 2)]
        [DataElement("156", typeof(X12_ID))]
        [Pos(2)]
        public string AmbulanceDropoffStateorProvinceCode_02 { get; set; }
        [StringLength(3, 15)]
        [DataElement("116", typeof(X12_ID))]
        [Pos(3)]
        public string AmbulanceDropoffPostalZoneorZIPCode_03 { get; set; }
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
    [EdiCodes(@",10,11,12,13,14,18,19,20,21,22,27,28,29,30,31,32,33,34,35,36,38,39,40,41,42,43,44,45,46,47,48,49,50,52,53,54,55,57,58,59,60,93,94,A,A1,AA,AC,AP,AR,B,B1,BE,BL,BS,C,C2,CA,CB,CC,CD,CE,CG,CI,CL,CM,CO,CR,CS,CY,D,DC,DE,DL,DO,DP,DR,DT,E,EA,EB,EL,F,FA,FE,FF,FI,FR,FS,FT,FV,G,GL,H,I,IA,IB,IM,IP,IS,IT,J,K,KE,KL,KP,L,LO,M,MI,MO,MS,MZ,NS,O,OA,OF,OL,OP,OR,OV,P,PA,PB,PC,PD,PE,PF,PG,PH,PL,PM,PO,PP,PQ,PR,PS,PT,PU,PV,PZ,Q,RA,RC,RE,RG,RJ,RL,RS,RT,SA,SB,SC,SD,SE,SG,SH,SL,SN,SP,SS,ST,SW,TA,TC,TI,TL,TM,TN,TP,TR,TX,UN,UR,UT,VA,VI,VS,W,WF,WH,WI,X1,ZN,ZZ,")]
    public class X12_ID_309
    {
    }
    
    [Serializable()]
    [Segment("N3")]
    public class N3_AmbulanceDrop_offLocationAddress_4
    {
        
        [Required]
        [StringLength(1, 55)]
        [DataElement("166", typeof(X12_AN))]
        [Pos(1)]
        public string AmbulanceDropoffAddressLine_01 { get; set; }
        [StringLength(1, 55)]
        [DataElement("166", typeof(X12_AN))]
        [Pos(2)]
        public string AmbulanceDropoffAddressLine_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_14), typeof(X12_ID_1065_2))]
    public class NM1_AmbulanceDrop_offLocation_4
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98_14))]
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        [Required]
        [DataElement("1065", typeof(X12_ID_1065_2))]
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(3)]
        public string AmbulanceDropoffLocation_03 { get; set; }
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
    [Group("NM1")]
    public class Loop_2420G_2
    {
        
        [Required]
        [Pos(1)]
        public NM1_AmbulancePick_upLocation_4 NM1_AmbulancePick_upLocation_4 { get; set; }
        [Required]
        [Pos(2)]
        public N3_AmbulancePick_upLocationAddress_4 N3_AmbulancePick_upLocationAddress_4 { get; set; }
        [Required]
        [Pos(3)]
        public N4_AmbulancePick_upLocationCity_State_ZipCode_4 N4_AmbulancePick_upLocationCity_State_ZipCode_4 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",PW,")]
    public class X12_ID_98_13
    {
    }
    
    [Serializable()]
    [Segment("N4")]
    public class N4_AmbulancePick_upLocationCity_State_ZipCode_4
    {
        
        [Required]
        [StringLength(2, 30)]
        [DataElement("19", typeof(X12_AN))]
        [Pos(1)]
        public string AmbulancePickupCityName_01 { get; set; }
        [StringLength(2, 2)]
        [DataElement("156", typeof(X12_ID))]
        [Pos(2)]
        public string AmbulancePickupStateorProvinceCode_02 { get; set; }
        [StringLength(3, 15)]
        [DataElement("116", typeof(X12_ID))]
        [Pos(3)]
        public string AmbulancePickupPostalZoneorZIPCode_03 { get; set; }
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
    [Segment("N3")]
    public class N3_AmbulancePick_upLocationAddress_4
    {
        
        [Required]
        [StringLength(1, 55)]
        [DataElement("166", typeof(X12_AN))]
        [Pos(1)]
        public string AmbulancePickupAddressLine_01 { get; set; }
        [StringLength(1, 55)]
        [DataElement("166", typeof(X12_AN))]
        [Pos(2)]
        public string AmbulancePickupAddressLine_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_13), typeof(X12_ID_1065_2))]
    public class NM1_AmbulancePick_upLocation_4
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
    public class Loop_2420F_2
    {
        
        [Required]
        [Pos(1)]
        public NM1_ReferringProviderName_4 NM1_ReferringProviderName_4 { get; set; }
        [ListCount(20)]
        [Pos(2)]
        public List<REF_ReferringProviderSecondaryIdentification_4> REF_ReferringProviderSecondaryIdentification_4 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",DN,P3,")]
    public class X12_ID_98_9
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,")]
    public class X12_ID_1065_3
    {
    }
    
    [Serializable()]
    [EdiCodes(",0B,1G,G2,")]
    public class X12_ID_128_25
    {
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_25))]
    public class REF_ReferringProviderSecondaryIdentification_4
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_25))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferringProviderSecondaryIdentifier_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        [Pos(4)]
        public C040_ReferenceIdentifier_100 ReferenceIdentifier_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C040_ReferenceIdentifier_100")]
    public class C040_ReferenceIdentifier_100
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_31))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string OtherPayerPrimaryIdentifier_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",2U,")]
    public class X12_ID_128_31
    {
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
    public class X12_ID_128_3
    {
    }
    
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_9), typeof(X12_ID_1065_3))]
    public class NM1_ReferringProviderName_4
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
        public string ReferringProviderLastName_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1036", typeof(X12_AN))]
        [Pos(4)]
        public string ReferringProviderFirstName_04 { get; set; }
        [StringLength(1, 25)]
        [DataElement("1037", typeof(X12_AN))]
        [Pos(5)]
        public string ReferringProviderMiddleNameorInitial_05 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1038", typeof(X12_AN))]
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1039", typeof(X12_AN))]
        [Pos(7)]
        public string ReferringProviderNameSuffix_07 { get; set; }
        [DataElement("66", typeof(X12_ID_66_2))]
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(9)]
        public string ReferringProviderIdentifier_09 { get; set; }
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
    [EdiCodes(",XX,")]
    public class X12_ID_66_2
    {
    }
    
    [Serializable()]
    [Group("NM1")]
    public class Loop_2420E_2
    {
        
        [Required]
        [Pos(1)]
        public NM1_OrderingProviderName_2 NM1_OrderingProviderName_2 { get; set; }
        [Pos(2)]
        public N3_OrderingProviderAddress_2 N3_OrderingProviderAddress_2 { get; set; }
        [Pos(3)]
        public N4_OrderingProviderCity_State_ZIPCode_2 N4_OrderingProviderCity_State_ZIPCode_2 { get; set; }
        [ListCount(20)]
        [Pos(4)]
        public List<REF_OrderingProviderSecondaryIdentification_2> REF_OrderingProviderSecondaryIdentification_2 { get; set; }
        [Pos(5)]
        public PER_OrderingProviderContactInformation_2 PER_OrderingProviderContactInformation_2 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",DK,")]
    public class X12_ID_98_16
    {
    }
    
    [Serializable()]
    [EdiCodes(",IC,")]
    public class X12_ID_366
    {
    }
    
    [Serializable()]
    [Segment("PER", typeof(X12_ID_366))]
    public class PER_OrderingProviderContactInformation_2
    {
        
        [Required]
        [DataElement("366", typeof(X12_ID_366))]
        [Pos(1)]
        public string ContactFunctionCode_01 { get; set; }
        [StringLength(1, 60)]
        [DataElement("93", typeof(X12_AN))]
        [Pos(2)]
        public string OrderingProviderContactName_02 { get; set; }
        [Required]
        [DataElement("365", typeof(X12_ID_365))]
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
    [EdiCodes(",EM,FX,TE,")]
    public class X12_ID_365
    {
    }
    
    [Serializable()]
    [EdiCodes(",EM,EX,FX,TE,")]
    public class X12_ID_365_2
    {
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_25))]
    public class REF_OrderingProviderSecondaryIdentification_2
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_25))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string OrderingProviderSecondaryIdentifier_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        [Pos(4)]
        public C040_ReferenceIdentifier_99 ReferenceIdentifier_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C040_ReferenceIdentifier_99")]
    public class C040_ReferenceIdentifier_99
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_31))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string OtherPayerPrimaryIdentifier_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("N4")]
    public class N4_OrderingProviderCity_State_ZIPCode_2
    {
        
        [Required]
        [StringLength(2, 30)]
        [DataElement("19", typeof(X12_AN))]
        [Pos(1)]
        public string OrderingProviderCityName_01 { get; set; }
        [StringLength(2, 2)]
        [DataElement("156", typeof(X12_ID))]
        [Pos(2)]
        public string OrderingProviderStateorProvinceCode_02 { get; set; }
        [StringLength(3, 15)]
        [DataElement("116", typeof(X12_ID))]
        [Pos(3)]
        public string OrderingProviderPostalZoneorZIPCode_03 { get; set; }
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
    [Segment("N3")]
    public class N3_OrderingProviderAddress_2
    {
        
        [Required]
        [StringLength(1, 55)]
        [DataElement("166", typeof(X12_AN))]
        [Pos(1)]
        public string OrderingProviderAddressLine_01 { get; set; }
        [StringLength(1, 55)]
        [DataElement("166", typeof(X12_AN))]
        [Pos(2)]
        public string OrderingProviderAddressLine_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_16), typeof(X12_ID_1065_3))]
    public class NM1_OrderingProviderName_2
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98_16))]
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
        public string OrderingProviderLastName_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1036", typeof(X12_AN))]
        [Pos(4)]
        public string OrderingProviderFirstName_04 { get; set; }
        [StringLength(1, 25)]
        [DataElement("1037", typeof(X12_AN))]
        [Pos(5)]
        public string OrderingProviderMiddleNameorInitial_05 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1038", typeof(X12_AN))]
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1039", typeof(X12_AN))]
        [Pos(7)]
        public string OrderingProviderNameSuffix_07 { get; set; }
        [DataElement("66", typeof(X12_ID_66_2))]
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(9)]
        public string OrderingProviderIdentifier_09 { get; set; }
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
    public class Loop_2420D_2
    {
        
        [Required]
        [Pos(1)]
        public NM1_SupervisingProviderName_4 NM1_SupervisingProviderName_4 { get; set; }
        [ListCount(20)]
        [Pos(2)]
        public List<REF_SupervisingProviderSecondaryIdentification_4> REF_SupervisingProviderSecondaryIdentification_4 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",DQ,")]
    public class X12_ID_98_12
    {
    }
    
    [Serializable()]
    [EdiCodes(",0B,1G,G2,LU,")]
    public class X12_ID_128_26
    {
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_26))]
    public class REF_SupervisingProviderSecondaryIdentification_4
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_26))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string SupervisingProviderSecondaryIdentifier_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        [Pos(4)]
        public C040_ReferenceIdentifier_98 ReferenceIdentifier_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C040_ReferenceIdentifier_98")]
    public class C040_ReferenceIdentifier_98
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_31))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string OtherPayerPrimaryIdentifier_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_12), typeof(X12_ID_1065_3))]
    public class NM1_SupervisingProviderName_4
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98_12))]
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
        public string SupervisingProviderLastName_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1036", typeof(X12_AN))]
        [Pos(4)]
        public string SupervisingProviderFirstName_04 { get; set; }
        [StringLength(1, 25)]
        [DataElement("1037", typeof(X12_AN))]
        [Pos(5)]
        public string SupervisingProviderMiddleNameorInitial_05 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1038", typeof(X12_AN))]
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1039", typeof(X12_AN))]
        [Pos(7)]
        public string SupervisingProviderNameSuffix_07 { get; set; }
        [DataElement("66", typeof(X12_ID_66_2))]
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(9)]
        public string SupervisingProviderIdentifier_09 { get; set; }
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
    public class Loop_2420C_2
    {
        
        [Required]
        [Pos(1)]
        public NM1_ServiceFacilityLocation_2 NM1_ServiceFacilityLocation_2 { get; set; }
        [Required]
        [Pos(2)]
        public N3_ServiceFacilityLocationAddress_4 N3_ServiceFacilityLocationAddress_4 { get; set; }
        [Required]
        [Pos(3)]
        public N4_ServiceFacilityLocationCity_State_ZIPCode_4 N4_ServiceFacilityLocationCity_State_ZIPCode_4 { get; set; }
        [ListCount(3)]
        [Pos(4)]
        public List<REF_ServiceFacilityLocationSecondaryIdentification_4> REF_ServiceFacilityLocationSecondaryIdentification_4 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",77,")]
    public class X12_ID_98_11
    {
    }
    
    [Serializable()]
    [EdiCodes(",G2,LU,")]
    public class X12_ID_128_10
    {
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_10))]
    public class REF_ServiceFacilityLocationSecondaryIdentification_4
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_10))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ServiceFacilityLocationSecondaryIdentifier_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        [Pos(4)]
        public C040_ReferenceIdentifier_97 ReferenceIdentifier_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C040_ReferenceIdentifier_97")]
    public class C040_ReferenceIdentifier_97
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_31))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string OtherPayerPrimaryIdentifier_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("N4")]
    public class N4_ServiceFacilityLocationCity_State_ZIPCode_4
    {
        
        [Required]
        [StringLength(2, 30)]
        [DataElement("19", typeof(X12_AN))]
        [Pos(1)]
        public string LaboratoryorFacilityCityName_01 { get; set; }
        [StringLength(2, 2)]
        [DataElement("156", typeof(X12_ID))]
        [Pos(2)]
        public string LaboratoryorFacilityStateorProvinceCode_02 { get; set; }
        [StringLength(3, 15)]
        [DataElement("116", typeof(X12_ID))]
        [Pos(3)]
        public string LaboratoryorFacilityPostalZoneorZIPCode_03 { get; set; }
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
    [Segment("N3")]
    public class N3_ServiceFacilityLocationAddress_4
    {
        
        [Required]
        [StringLength(1, 55)]
        [DataElement("166", typeof(X12_AN))]
        [Pos(1)]
        public string LaboratoryorFacilityAddressLine_01 { get; set; }
        [StringLength(1, 55)]
        [DataElement("166", typeof(X12_AN))]
        [Pos(2)]
        public string LaboratoryorFacilityAddressLine_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_11), typeof(X12_ID_1065_2))]
    public class NM1_ServiceFacilityLocation_2
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98_11))]
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        [Required]
        [DataElement("1065", typeof(X12_ID_1065_2))]
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        [Required]
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(3)]
        public string LaboratoryorFacilityName_03 { get; set; }
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
        [DataElement("66", typeof(X12_ID_66_2))]
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(9)]
        public string LaboratoryorFacilityPrimaryIdentifier_09 { get; set; }
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
    public class Loop_2420B_2
    {
        
        [Required]
        [Pos(1)]
        public NM1_PurchasedServiceProviderName_2 NM1_PurchasedServiceProviderName_2 { get; set; }
        [ListCount(20)]
        [Pos(2)]
        public List<REF_PurchasedServiceProviderSecondaryIdentification_2> REF_PurchasedServiceProviderSecondaryIdentification_2 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",QB,")]
    public class X12_ID_98_15
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,")]
    public class X12_ID_1065
    {
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_25))]
    public class REF_PurchasedServiceProviderSecondaryIdentification_2
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_25))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string PurchasedServiceProviderSecondaryIdentifier_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        [Pos(4)]
        public C040_ReferenceIdentifier_96 ReferenceIdentifier_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C040_ReferenceIdentifier_96")]
    public class C040_ReferenceIdentifier_96
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_31))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string OtherPayerPrimaryIdentifier_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_15), typeof(X12_ID_1065))]
    public class NM1_PurchasedServiceProviderName_2
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98_15))]
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
        [DataElement("66", typeof(X12_ID_66_2))]
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(9)]
        public string PurchasedServiceProviderIdentifier_09 { get; set; }
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
    public class Loop_2420A_2
    {
        
        [Required]
        [Pos(1)]
        public NM1_RenderingProviderName_4 NM1_RenderingProviderName_4 { get; set; }
        [Pos(2)]
        public PRV_RenderingProviderSpecialtyInformation_4 PRV_RenderingProviderSpecialtyInformation_4 { get; set; }
        [ListCount(20)]
        [Pos(3)]
        public List<REF_RenderingProviderSecondaryIdentification_4> REF_RenderingProviderSecondaryIdentification_4 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",82,")]
    public class X12_ID_98_10
    {
    }
    
    [Serializable()]
    [EdiCodes(",PE,")]
    public class X12_ID_1221_2
    {
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_26))]
    public class REF_RenderingProviderSecondaryIdentification_4
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_26))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string RenderingProviderSecondaryIdentifier_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        [Pos(4)]
        public C040_ReferenceIdentifier_95 ReferenceIdentifier_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C040_ReferenceIdentifier_95")]
    public class C040_ReferenceIdentifier_95
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_31))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string OtherPayerPrimaryIdentifier_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("PRV", typeof(X12_ID_1221_2), typeof(X12_ID_128))]
    public class PRV_RenderingProviderSpecialtyInformation_4
    {
        
        [Required]
        [DataElement("1221", typeof(X12_ID_1221_2))]
        [Pos(1)]
        public string ProviderCode_01 { get; set; }
        [Required]
        [DataElement("128", typeof(X12_ID_128))]
        [Pos(2)]
        public string ReferenceIdentificationQualifier_02 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(3)]
        public string ProviderTaxonomyCode_03 { get; set; }
        [StringLength(2, 2)]
        [DataElement("156", typeof(X12_ID))]
        [Pos(4)]
        public string StateorProvinceCode_04 { get; set; }
        [Pos(5)]
        public C035_ProviderSpecialtyInformation_5 ProviderSpecialtyInformation_05 { get; set; }
        [DataElement("1223", typeof(X12_ID_1223))]
        [Pos(6)]
        public string ProviderOrganizationCode_06 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",001,002,003,004,005,006,007,008,")]
    public class X12_ID_1223
    {
    }
    
    [Serializable()]
    [Composite("C035_ProviderSpecialtyInformation_5")]
    public class C035_ProviderSpecialtyInformation_5
    {
        
        [Required]
        [DataElement("1222", typeof(X12_ID_1222))]
        [Pos(1)]
        public string ProviderSpecialtyCode_01 { get; set; }
        [DataElement("559", typeof(X12_ID_559))]
        [Pos(2)]
        public string AgencyQualifierCode_02 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(3)]
        public string YesNoConditionorResponseCode_03 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",DEN,DGP,END,IHG,OPY,ORT,OSY,PDT,PED,PHD,PST,")]
    public class X12_ID_1222
    {
    }
    
    [Serializable()]
    [EdiCodes(@",10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,64,65,66,93,94,A1,A2,A3,A4,AA,AB,AC,AD,AE,AF,AG,AH,AJ,AL,AM,AP,AQ,AR,AS,AT,AW,AX,AY,BA,BE,BF,BI,CA,CB,CC,CE,CI,CL,CM,CO,CP,CR,CS,CU,CX,DA,DD,DE,DF,DH,DI,DL,DN,DO,DR,DS,DX,DY,DZ,EI,EP,ES,ET,EU,EX,FA,FC,FD,FG,FH,FI,GC,GI,GS,GU,HC,HF,HI,HS,HU,IA,IB,IC,IM,IN,IS,JA,LA,LB,LI,MA,MB,MC,ME,MI,MP,MS,MV,NA,NB,NC,NE,NF,NG,NI,NP,NR,NS,NT,NU,NW,OI,OP,OS,PA,PC,PI,RN,SA,SE,SL,SP,ST,TA,TB,TC,TD,TI,TM,TP,TR,TX,UA,UC,UI,UL,UN,UT,VI,WH,ZZ,")]
    public class X12_ID_559
    {
    }
    
    [Serializable()]
    [EdiCodes(",N,U,W,Y,")]
    public class X12_ID_1073
    {
    }
    
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_10), typeof(X12_ID_1065))]
    public class NM1_RenderingProviderName_4
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
        public string RenderingProviderLastorOrganizationName_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1036", typeof(X12_AN))]
        [Pos(4)]
        public string RenderingProviderFirstName_04 { get; set; }
        [StringLength(1, 25)]
        [DataElement("1037", typeof(X12_AN))]
        [Pos(5)]
        public string RenderingProviderMiddleName_05 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1038", typeof(X12_AN))]
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1039", typeof(X12_AN))]
        [Pos(7)]
        public string RenderingProviderNameSuffix_07 { get; set; }
        [DataElement("66", typeof(X12_ID_66_2))]
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(9)]
        public string RenderingProviderIdentifier_09 { get; set; }
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
    [Group("LIN")]
    public class Loop_2410_2
    {
        
        [Required]
        [Pos(1)]
        public LIN_DrugIdentification_2 LIN_DrugIdentification_2 { get; set; }
        [Required]
        [Pos(2)]
        public CTP_DrugQuantity_2 CTP_DrugQuantity_2 { get; set; }
        [Pos(3)]
        public REF_PrescriptionorCompoundDrugAssociationNumber_2 REF_PrescriptionorCompoundDrugAssociationNumber_2 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",EN,EO,HI,N4,ON,UK,UP,")]
    public class X12_ID_235_4
    {
    }
    
    [Serializable()]
    [EdiCodes(",AA,AB,AC,AD,AE,AF,AG,AH,AI,AJ,AL,AM,AN,AO,AP,AQ,AR,AS,BG,BR,CB,CN,CO,CR,CX,CY,DE" +
        ",DF,DI,DR,EX,FS,GA,GM,GR,GV,HS,ID,IN,IR,JB,LC,MC,MF,ML,OE,OF,ON,PF,PH,PT,PY,RS,S" +
        "A,SB,SE,ST,TR,WA,WC,WH,WS,")]
    public class X12_ID_687
    {
    }
    
    [Serializable()]
    [EdiCodes(@",ACT,AGC,ALT,AWP,BBP,BCH,BID,C01,C02,C03,C04,C05,C06,C07,C08,C09,C10,C11,C12,C13,C14,C15,C16,C17,C18,C19,C20,C21,C22,C23,C24,C25,C26,C27,C28,C29,C30,CAN,CAT,CDF,CDV,CHG,CON,CUP,CUS,D01,D02,D03,DAP,DIS,DPR,DSC,DSD,DSP,EDM,EDP,EDS,EDW,ELC,EST,EUP,FCH,FCP,FDS,FET,FGP,FOR,FSP,FUL,FUP,GAP,GDP,GOV,GSP,GTP,ICL,IND,INS,INV,LAR,LCP,LPP,LPR,MAP,MAS,MAX,MIN,MNC,MNR,MOD,MPR,MSR,MXR,N01,N02,N03,N04,N05,N06,N07,N08,N09,N10,N11,N12,N13,N14,N15,N16,N17,N18,N19,N20,N21,N22,N23,N24,N25,N26,N27,N28,N29,N30,N31,NET,OAP,OPP,PAP,PAQ,PBQ,PBR,PHS,PIE,PLT,PPA,PPD,PRF,PRO,PRP,PUR,QTE,REG,RES,RPA,RPM,RPP,RSH,RTL,SAC,SDP,SFP,SHD,SLP,SPC,SPE,SSP,STA,SUM,SWP,THP,TOT,TRF,UCP,ULC,WAR,WHL,WSP,ZNP,")]
    public class X12_ID_236
    {
    }
    
    [Serializable()]
    [EdiCodes(",VY,XZ,")]
    public class X12_ID_128_35
    {
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_35))]
    public class REF_PrescriptionorCompoundDrugAssociationNumber_2
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_35))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string PrescriptionNumber_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        [Pos(4)]
        public C040_ReferenceIdentifier_94 ReferenceIdentifier_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C040_ReferenceIdentifier_94")]
    public class C040_ReferenceIdentifier_94
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("CTP", typeof(X12_ID_687), typeof(X12_ID_236))]
    public class CTP_DrugQuantity_2
    {
        
        [DataElement("687", typeof(X12_ID_687))]
        [Pos(1)]
        public string ClassofTradeCode_01 { get; set; }
        [DataElement("236", typeof(X12_ID_236))]
        [Pos(2)]
        public string PriceIdentifierCode_02 { get; set; }
        [StringLength(1, 17)]
        [DataElement("212", typeof(X12_R))]
        [Pos(3)]
        public string UnitPrice_03 { get; set; }
        [Required]
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(4)]
        public string NationalDrugUnitCount_04 { get; set; }
        [Required]
        [Pos(5)]
        public C001_CompositeUnitofMeasure_12 CompositeUnitofMeasure_05 { get; set; }
        [DataElement("648", typeof(X12_ID_648))]
        [Pos(6)]
        public string PriceMultiplierQualifier_06 { get; set; }
        [StringLength(1, 10)]
        [DataElement("649", typeof(X12_R))]
        [Pos(7)]
        public string Multiplier_07 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(8)]
        public string MonetaryAmount_08 { get; set; }
        [DataElement("639", typeof(X12_ID_639))]
        [Pos(9)]
        public string BasisofUnitPriceCode_09 { get; set; }
        [StringLength(1, 10)]
        [DataElement("499", typeof(X12_AN))]
        [Pos(10)]
        public string ConditionValue_10 { get; set; }
        [StringLength(1, 2)]
        [DataElement("289", typeof(X12_N0))]
        [Pos(11)]
        public string MultiplePriceQuantity_11 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",CSD,CSR,DIS,ILP,PSP,SEL,")]
    public class X12_ID_648
    {
    }
    
    [Serializable()]
    [EdiCodes(@",AA,AB,AP,AW,BD,BR,BW,CA,CP,CR,CT,DI,DP,DR,DS,EC,EH,ES,FB,FO,FX,HF,HP,HT,KA,KP,KR,LC,LD,LE,LM,LR,ME,ML,NC,NE,NQ,NS,NT,PA,PB,PD,PE,PF,PG,PK,PL,PM,PN,PO,PP,PQ,PR,PS,PT,PU,PV,PY,QE,QH,QR,QS,QT,RC,RD,RE,RM,RS,RT,SA,SC,SM,SR,ST,SW,TB,TC,TD,TE,TF,TM,TP,TT,UM,VQ,WC,WD,WE,WH,WI,WM,")]
    public class X12_ID_639
    {
    }
    
    [Serializable()]
    [Composite("C001_CompositeUnitofMeasure_12")]
    public class C001_CompositeUnitofMeasure_12
    {
        
        [Required]
        [DataElement("355", typeof(X12_ID_355_8))]
        [Pos(1)]
        public string CodeQualifier_01 { get; set; }
        [StringLength(1, 15)]
        [DataElement("1018", typeof(X12_R))]
        [Pos(2)]
        public string Exponent_02 { get; set; }
        [StringLength(1, 10)]
        [DataElement("649", typeof(X12_R))]
        [Pos(3)]
        public string Multiplier_03 { get; set; }
        [DataElement("355", typeof(X12_ID_355_2))]
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
        [DataElement("355", typeof(X12_ID_355_2))]
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
        [DataElement("355", typeof(X12_ID_355_2))]
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
        [DataElement("355", typeof(X12_ID_355_2))]
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
    [EdiCodes(",F2,GR,ME,ML,UN,")]
    public class X12_ID_355_8
    {
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
    public class X12_ID_355_2
    {
    }
    
    [Serializable()]
    [Segment("LIN")]
    public class LIN_DrugIdentification_2
    {
        
        [StringLength(1, 20)]
        [DataElement("350", typeof(X12_AN))]
        [Pos(1)]
        public string AssignedIdentification_01 { get; set; }
        [Required]
        [DataElement("235", typeof(X12_ID_235_4))]
        [Pos(2)]
        public string ProductorServiceIDQualifier_02 { get; set; }
        [Required]
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(3)]
        public string NationalDrugCodeorUniversalProductNumber_03 { get; set; }
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(4)]
        public string ProductServiceIDQualifier_04 { get; set; }
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(5)]
        public string ProductServiceID_05 { get; set; }
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(6)]
        public string ProductServiceIDQualifier_06 { get; set; }
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(7)]
        public string ProductServiceID_07 { get; set; }
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(8)]
        public string ProductServiceIDQualifier_08 { get; set; }
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(9)]
        public string ProductServiceID_09 { get; set; }
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(10)]
        public string ProductServiceIDQualifier_10 { get; set; }
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(11)]
        public string ProductServiceID_11 { get; set; }
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(12)]
        public string ProductServiceIDQualifier_12 { get; set; }
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(13)]
        public string ProductServiceID_13 { get; set; }
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(14)]
        public string ProductServiceIDQualifier_14 { get; set; }
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(15)]
        public string ProductServiceID_15 { get; set; }
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(16)]
        public string ProductServiceIDQualifier_16 { get; set; }
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(17)]
        public string ProductServiceID_17 { get; set; }
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(18)]
        public string ProductServiceIDQualifier_18 { get; set; }
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(19)]
        public string ProductServiceID_19 { get; set; }
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(20)]
        public string ProductServiceIDQualifier_20 { get; set; }
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(21)]
        public string ProductServiceID_21 { get; set; }
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(22)]
        public string ProductServiceIDQualifier_22 { get; set; }
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(23)]
        public string ProductServiceID_23 { get; set; }
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(24)]
        public string ProductServiceIDQualifier_24 { get; set; }
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(25)]
        public string ProductServiceID_25 { get; set; }
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(26)]
        public string ProductServiceIDQualifier_26 { get; set; }
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(27)]
        public string ProductServiceID_27 { get; set; }
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(28)]
        public string ProductServiceIDQualifier_28 { get; set; }
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(29)]
        public string ProductServiceID_29 { get; set; }
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(30)]
        public string ProductServiceIDQualifier_30 { get; set; }
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(31)]
        public string ProductServiceID_31 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",00,A1,A2,A3,A4,A5,A6,A7,A8,AA,AB,AC,AD,AE,AF,AG,AH,AI,AJ,AK,AL,AM,AN,AP,AQ,AR,AS" +
        ",AT,AU,AV,AW,AX,AY,AZ,B1,B2,B3,B4,B5,B6,B7,B8,B9,BA,BB,BC,BD,BE,BF,BG,BH,BI,BJ,B" +
        "K,BL,BM,BN,BO,BP,BQ,BR,BS,BT,BU,BV,BW,BX,BY,BZ,C1,C2,C3,C4,C5,C6,C7,C8,C9,CA,CB," +
        "CC,CD,CE,CF,CG,CH,CI,CJ,CK,CL,CM,CN,CO,CP,CQ,CR,CS,CT,CU,CV,CW,CX,CY,CZ,D1,D2,D3" +
        ",D4,D5,D6,D7,D8,DA,DD,DE,DF,DG,DH,DI,DL,DM,DN,DO,DP,DQ,DR,DS,DT,DU,DV,DW,DX,DY,D" +
        "Z,E1,E2,E3,E4,E5,E6,EA,EB,EC,ED,EE,EF,EG,EH,EI,EJ,EK,EL,EM,EN,EO,EP,EQ,ER,ES,EU," +
        "EX,EZ,F1,F2,F3,F4,F5,F6,F7,F8,F9,FA,FB,FC,FD,FE,FF,FG,FH,FI,FJ,FK,FL,FM,FN,FP,FQ" +
        ",FR,FS,FT,FU,FV,FW,FX,GA,GC,GD,GE,GI,GK,GM,GN,GQ,GR,GS,GU,HC,HD,HI,HN,HP,IA,IB,I" +
        "C,ID,IE,IF,IG,II,IM,IN,IQ,IR,IS,IT,IV,IW,IZ,JA,JB,JC,JD,JN,JP,JS,KA,KB,KD,KE,KF," +
        "KG,KI,KJ,KK,KL,KM,KN,KP,L1,L2,L3,L4,L5,L6,LA,LB,LC,LD,LG,LM,LN,LP,LR,LS,LT,LU,MA" +
        ",MB,MC,MD,ME,MF,MG,MH,MI,MJ,MK,MM,MN,MO,MP,MQ,MR,MS,MT,MU,MV,MW,MX,N1,N2,N3,N4,N" +
        "5,N6,ND,NE,NG,NH,NM,NR,NU,NW,NZ,O0,O7,O8,O9,OA,OB,OC,OD,OE,OF,OG,OH,OI,OL,ON,OO," +
        "OP,OR,OT,OU,P1,P2,P3,P4,P5,P6,P7,P8,P9,PA,PB,PC,PD,PE,PF,PG,PH,PI,PJ,PK,PL,PM,PN" +
        ",PO,PP,PQ,PR,PS,PT,PU,PV,PW,PX,PY,PZ,R0,R1,R2,R3,R4,R5,R6,R7,R8,R9,RA,RB,RC,RD,R" +
        "E,RF,RG,RH,RI,RJ,RK,RL,RM,RN,RO,RP,RQ,RR,RS,RT,RU,RV,RW,RY,RZ,S1,S2,S3,S4,S5,S6," +
        "S7,S8,SA,SB,SC,SD,SE,SF,SG,SH,SI,SJ,SK,SL,SM,SN,SO,SP,SQ,SR,SS,ST,SU,SV,SW,SX,SY" +
        ",SZ,T2,T3,TA,TB,TC,TD,TE,TF,TG,TH,TI,TJ,TK,TM,TN,TP,TR,TS,TT,TU,TV,TW,TX,TY,TZ,U" +
        "2,U3,U5,U6,UA,UB,UC,UD,UE,UF,UG,UH,UI,UJ,UK,UL,UM,UN,UO,UP,UQ,UR,US,UT,UV,UX,VA," +
        "VB,VC,VE,VI,VM,VN,VO,VP,VS,VT,VU,VV,VX,W1,W2,W5,W6,W7,WA,WB,WC,WD,WE,WF,WG,WJ,WK" +
        ",WL,WR,WS,XA,XC,XP,XQ,XZ,YP,ZB,ZR,ZZ,")]
    public class X12_ID_235
    {
    }
    
    [Serializable()]
    [Segment("HCP", typeof(X12_ID_1473_2))]
    public class HCP_LinePricing_RepricingInformation_2
    {
        
        [Required]
        [DataElement("1473", typeof(X12_ID_1473_2))]
        [Pos(1)]
        public string PricingMethodology_01 { get; set; }
        [Required]
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(2)]
        public string RepricedAllowedAmount_02 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(3)]
        public string RepricedSavingAmount_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string RepricingOrganizationIdentifier_04 { get; set; }
        [StringLength(1, 9)]
        [DataElement("118", typeof(X12_R))]
        [Pos(5)]
        public string RepricingPerDiemorFlatRateAmount_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string RepricedApprovedAmbulatoryPatientGroupCode_06 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(7)]
        public string RepricedApprovedAmbulatoryPatientGroupAmount_07 { get; set; }
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(8)]
        public string ProductServiceID_08 { get; set; }
        [DataElement("235", typeof(X12_ID_235_2))]
        [Pos(9)]
        public string ProductorServiceIDQualifier_09 { get; set; }
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(10)]
        public string RepricedApprovedHCPCSCode_10 { get; set; }
        [DataElement("355", typeof(X12_ID_355_5))]
        [Pos(11)]
        public string UnitorBasisforMeasurementCode_11 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(12)]
        public string RepricedApprovedServiceUnitCount_12 { get; set; }
        [DataElement("901", typeof(X12_ID_901))]
        [Pos(13)]
        public string RejectReasonCode_13 { get; set; }
        [DataElement("1526", typeof(X12_ID_1526))]
        [Pos(14)]
        public string PolicyComplianceCode_14 { get; set; }
        [DataElement("1527", typeof(X12_ID_1527))]
        [Pos(15)]
        public string ExceptionCode_15 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",MJ,UN,")]
    public class X12_ID_355_5
    {
    }
    
    [Serializable()]
    [EdiCodes(",T1,T2,T3,T4,T5,T6,")]
    public class X12_ID_901
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,3,4,5,")]
    public class X12_ID_1526
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,3,4,5,6,")]
    public class X12_ID_1527
    {
    }
    
    [Serializable()]
    [Segment("PS1")]
    public class PS1_PurchasedServiceInformation_2
    {
        
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(1)]
        public string PurchasedServiceProviderIdentifier_01 { get; set; }
        [Required]
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(2)]
        public string PurchasedServiceChargeAmount_02 { get; set; }
        [StringLength(2, 2)]
        [DataElement("156", typeof(X12_ID))]
        [Pos(3)]
        public string StateorProvinceCode_03 { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_NTE_2
    {
        
        [Pos(1)]
        public NTE_LineNote_2 NTE_LineNote_2 { get; set; }
        [Pos(2)]
        public NTE_ThirdPartyOrganizationNotes_2 NTE_ThirdPartyOrganizationNotes_2 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",ADD,DCP,")]
    public class X12_ID_363_2
    {
    }
    
    [Serializable()]
    [EdiCodes(",TPO,")]
    public class X12_ID_363_3
    {
    }
    
    [Serializable()]
    [Segment("NTE", typeof(X12_ID_363_3))]
    public class NTE_ThirdPartyOrganizationNotes_2
    {
        
        [Required]
        [DataElement("363", typeof(X12_ID_363_3))]
        [Pos(1)]
        public string NoteReferenceCode_01 { get; set; }
        [Required]
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(2)]
        public string LineNoteText_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("NTE", typeof(X12_ID_363_2))]
    public class NTE_LineNote_2
    {
        
        [Required]
        [DataElement("363", typeof(X12_ID_363_2))]
        [Pos(1)]
        public string NoteReferenceCode_01 { get; set; }
        [Required]
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(2)]
        public string LineNoteText_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("K3")]
    public class K3_FileInformation_4
    {
        
        [Required]
        [StringLength(1, 80)]
        [DataElement("449", typeof(X12_AN))]
        [Pos(1)]
        public string FixedFormatInformation_01 { get; set; }
        [DataElement("1333", typeof(X12_ID_1333))]
        [Pos(2)]
        public string RecordFormatCode_02 { get; set; }
        [Pos(3)]
        public C001_CompositeUnitofMeasure_11 CompositeUnitofMeasure_03 { get; set; }
    }
    
    [Serializable()]
    [Composite("C001_CompositeUnitofMeasure_11")]
    public class C001_CompositeUnitofMeasure_11
    {
        
        [Required]
        [DataElement("355", typeof(X12_ID_355_2))]
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
        [DataElement("355", typeof(X12_ID_355_2))]
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
        [DataElement("355", typeof(X12_ID_355_2))]
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
        [DataElement("355", typeof(X12_ID_355_2))]
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
        [DataElement("355", typeof(X12_ID_355_2))]
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
    [All()]
    public class All_AMT_4
    {
        
        [Pos(1)]
        public AMT_SalesTaxAmount_2 AMT_SalesTaxAmount_2 { get; set; }
        [Pos(2)]
        public AMT_PostageClaimedAmount_2 AMT_PostageClaimedAmount_2 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",T,")]
    public class X12_ID_522_5
    {
    }
    
    [Serializable()]
    [EdiCodes(",F4,")]
    public class X12_ID_522_6
    {
    }
    
    [Serializable()]
    [Segment("AMT", typeof(X12_ID_522_6))]
    public class AMT_PostageClaimedAmount_2
    {
        
        [Required]
        [DataElement("522", typeof(X12_ID_522_6))]
        [Pos(1)]
        public string AmountQualifierCode_01 { get; set; }
        [Required]
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(2)]
        public string PostageClaimedAmount_02 { get; set; }
        [DataElement("478", typeof(X12_ID_478))]
        [Pos(3)]
        public string CreditDebitFlagCode_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("AMT", typeof(X12_ID_522_5))]
    public class AMT_SalesTaxAmount_2
    {
        
        [Required]
        [DataElement("522", typeof(X12_ID_522_5))]
        [Pos(1)]
        public string AmountQualifierCode_01 { get; set; }
        [Required]
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(2)]
        public string SalesTaxAmount_02 { get; set; }
        [DataElement("478", typeof(X12_ID_478))]
        [Pos(3)]
        public string CreditDebitFlagCode_03 { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_REF_11
    {
        
        [Pos(1)]
        public REF_RepricedLineItemReferenceNumber_2 REF_RepricedLineItemReferenceNumber_2 { get; set; }
        [Pos(2)]
        public REF_AdjustedRepricedLineItemReferenceNumber_2 REF_AdjustedRepricedLineItemReferenceNumber_2 { get; set; }
        [ListCount(5)]
        [Pos(3)]
        public List<REF_PriorAuthorization_4> REF_PriorAuthorization_4 { get; set; }
        [Pos(4)]
        public REF_LineItemControlNumber_2 REF_LineItemControlNumber_2 { get; set; }
        [Pos(5)]
        public REF_MammographyCertificationNumber_4 REF_MammographyCertificationNumber_4 { get; set; }
        [Pos(6)]
        public REF_ClinicalLaboratoryImprovementAmendment_CLIA_Number_4 REF_ClinicalLaboratoryImprovementAmendment_CLIA_Number_4 { get; set; }
        [Pos(7)]
        public REF_ReferringClinicalLaboratoryImprovementAmendment_CLIA_FacilityIdentification_2 REF_ReferringClinicalLaboratoryImprovementAmendment_CLIA_FacilityIdentification_2 { get; set; }
        [Pos(8)]
        public REF_ImmunizationBatchNumber_2 REF_ImmunizationBatchNumber_2 { get; set; }
        [ListCount(5)]
        [Pos(9)]
        public List<REF_ReferralNumber_4> REF_ReferralNumber_4 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",9B,")]
    public class X12_ID_128_29
    {
    }
    
    [Serializable()]
    [EdiCodes(",9D,")]
    public class X12_ID_128_30
    {
    }
    
    [Serializable()]
    [EdiCodes(",G1,")]
    public class X12_ID_128_15
    {
    }
    
    [Serializable()]
    [EdiCodes(",6R,")]
    public class X12_ID_128_32
    {
    }
    
    [Serializable()]
    [EdiCodes(",EW,")]
    public class X12_ID_128_13
    {
    }
    
    [Serializable()]
    [EdiCodes(",X4,")]
    public class X12_ID_128_17
    {
    }
    
    [Serializable()]
    [EdiCodes(",F4,")]
    public class X12_ID_128_33
    {
    }
    
    [Serializable()]
    [EdiCodes(",BT,")]
    public class X12_ID_128_34
    {
    }
    
    [Serializable()]
    [EdiCodes(",9F,")]
    public class X12_ID_128_14
    {
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_14))]
    public class REF_ReferralNumber_4
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_14))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferralNumber_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        [Pos(4)]
        public C040_ReferenceIdentifier_93 ReferenceIdentifier_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C040_ReferenceIdentifier_93")]
    public class C040_ReferenceIdentifier_93
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_31))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string OtherPayerPrimaryIdentifier_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_34))]
    public class REF_ImmunizationBatchNumber_2
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_34))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ImmunizationBatchNumber_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        [Pos(4)]
        public C040_ReferenceIdentifier_92 ReferenceIdentifier_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C040_ReferenceIdentifier_92")]
    public class C040_ReferenceIdentifier_92
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_33))]
    public class REF_ReferringClinicalLaboratoryImprovementAmendment_CLIA_FacilityIdentification_2
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_33))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferringCLIANumber_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        [Pos(4)]
        public C040_ReferenceIdentifier_91 ReferenceIdentifier_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C040_ReferenceIdentifier_91")]
    public class C040_ReferenceIdentifier_91
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_17))]
    public class REF_ClinicalLaboratoryImprovementAmendment_CLIA_Number_4
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_17))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ClinicalLaboratoryImprovementAmendmentNumber_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        [Pos(4)]
        public C040_ReferenceIdentifier_90 ReferenceIdentifier_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C040_ReferenceIdentifier_90")]
    public class C040_ReferenceIdentifier_90
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_13))]
    public class REF_MammographyCertificationNumber_4
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_13))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string MammographyCertificationNumber_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        [Pos(4)]
        public C040_ReferenceIdentifier_89 ReferenceIdentifier_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C040_ReferenceIdentifier_89")]
    public class C040_ReferenceIdentifier_89
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_32))]
    public class REF_LineItemControlNumber_2
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_32))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string LineItemControlNumber_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        [Pos(4)]
        public C040_ReferenceIdentifier_88 ReferenceIdentifier_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C040_ReferenceIdentifier_88")]
    public class C040_ReferenceIdentifier_88
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_15))]
    public class REF_PriorAuthorization_4
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_15))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string PriorAuthorizationorReferralNumber_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        [Pos(4)]
        public C040_ReferenceIdentifier_87 ReferenceIdentifier_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C040_ReferenceIdentifier_87")]
    public class C040_ReferenceIdentifier_87
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_31))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string OtherPayerPrimaryIdentifier_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_30))]
    public class REF_AdjustedRepricedLineItemReferenceNumber_2
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_30))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string AdjustedRepricedLineItemReferenceNumber_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        [Pos(4)]
        public C040_ReferenceIdentifier_86 ReferenceIdentifier_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C040_ReferenceIdentifier_86")]
    public class C040_ReferenceIdentifier_86
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_29))]
    public class REF_RepricedLineItemReferenceNumber_2
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_29))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string RepricedLineItemReferenceNumber_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        [Pos(4)]
        public C040_ReferenceIdentifier_85 ReferenceIdentifier_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C040_ReferenceIdentifier_85")]
    public class C040_ReferenceIdentifier_85
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("CN1", typeof(X12_ID_1166))]
    public class CN1_ContractInformation_4
    {
        
        [Required]
        [DataElement("1166", typeof(X12_ID_1166))]
        [Pos(1)]
        public string ContractTypeCode_01 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(2)]
        public string ContractAmount_02 { get; set; }
        [StringLength(1, 6)]
        [DataElement("332", typeof(X12_R))]
        [Pos(3)]
        public string ContractPercentage_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ContractCode_04 { get; set; }
        [StringLength(1, 6)]
        [DataElement("338", typeof(X12_R))]
        [Pos(5)]
        public string TermsDiscountPercentage_05 { get; set; }
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(6)]
        public string ContractVersionIdentifier_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("MEA", typeof(X12_ID_737), typeof(X12_ID_738))]
    public class MEA_TestResult_2
    {
        
        [Required]
        [DataElement("737", typeof(X12_ID_737))]
        [Pos(1)]
        public string MeasurementReferenceIdentificationCode_01 { get; set; }
        [Required]
        [DataElement("738", typeof(X12_ID_738))]
        [Pos(2)]
        public string MeasurementQualifier_02 { get; set; }
        [Required]
        [StringLength(1, 20)]
        [DataElement("739", typeof(X12_R))]
        [Pos(3)]
        public string TestResults_03 { get; set; }
        [Pos(4)]
        public C001_CompositeUnitofMeasure_10 CompositeUnitofMeasure_04 { get; set; }
        [StringLength(1, 20)]
        [DataElement("740", typeof(X12_R))]
        [Pos(5)]
        public string RangeMinimum_05 { get; set; }
        [StringLength(1, 20)]
        [DataElement("741", typeof(X12_R))]
        [Pos(6)]
        public string RangeMaximum_06 { get; set; }
        [DataElement("935", typeof(X12_ID_935))]
        [Pos(7)]
        public string MeasurementSignificanceCode_07 { get; set; }
        [DataElement("936", typeof(X12_ID_936))]
        [Pos(8)]
        public string MeasurementAttributeCode_08 { get; set; }
        [DataElement("752", typeof(X12_ID_752))]
        [Pos(9)]
        public string SurfaceLayerPositionCode_09 { get; set; }
        [DataElement("1373", typeof(X12_ID_1373))]
        [Pos(10)]
        public string MeasurementMethodorDevice_10 { get; set; }
        [DataElement("1270", typeof(X12_ID_1270))]
        [Pos(11)]
        public string CodeListQualifierCode_11 { get; set; }
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(12)]
        public string IndustryCode_12 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(@",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,34,35,36,37,38,39,40,41,42,43,44,45,46,47,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,81,82,83,84,85,86,87,88,89,90,91,92,93,94,95,96,97,98,99,AA,AB,AC,AD,AE,AF,AG,AH,AI,AJ,AK,AL,AM,AN,AO,AP,AQ,AR,AS,AT,AU,AV,AW,AX,AY,AZ,BA,BB,BC,BD,BE,BF,ZZ,")]
    public class X12_ID_935
    {
    }
    
    [Serializable()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27" +
        ",28,29,30,31,32,33,40,41,42,44,45,46,48,49,50,51,52,53,54,56,BA,FL,NA,ND,NS,PR,Q" +
        "1,Q2,TA,TB,WS,ZZ,")]
    public class X12_ID_936
    {
    }
    
    [Serializable()]
    [EdiCodes(@",1S,2S,A1,A2,A3,A4,A5,A6,A7,A8,A9,AL,AO,AS,B1,BC,BI,BK,BL,BR,BS,BT,CH,CT,DO,DT,DU,EX,FR,FS,GF,IN,IT,KB,LC,LO,LT,M1,MC,MD,NS,NT,OA,OS,OT,R0,R1,R2,R3,R4,R5,R6,R7,R8,R9,RA,RB,RC,RD,RE,RF,RG,RH,RI,RJ,RK,RL,RM,RN,RO,RP,RQ,RR,RS,RT,RU,RV,RW,RX,RY,RZ,S1,S2,S3,S4,S5,S6,S7,S8,S9,SA,SB,SC,SD,SE,SF,SN,SP,SS,ST,SU,TB,TP,TS,UC,UN,UP,UT,WF,")]
    public class X12_ID_752
    {
    }
    
    [Serializable()]
    [EdiCodes(",BM,BO,DM,FT,HN,MA,MM,OM,OU,PT,TM,VA,VB,VC,")]
    public class X12_ID_1373
    {
    }
    
    [Serializable()]
    [EdiCodes(",0,1,10,100,101,102,103,104,105,106,107,108,109,11,12,13,14,15,16,17,18,19,20,21," +
        "22,23,24,25,26,27,28,29,3,30,31,32,33,34,35,36,37,38,39,4,40,41,42,43,44,45,46,4" +
        "7,48,49,5,50,52,53,54,55,56,57,58,59,60,61,62,63,65,66,67,68,69,7,71,72,73,74,75" +
        ",78,79,8,80,81,82,83,84,85,87,88,89,90,91,92,93,94,95,96,97,98,99,A,A1,A2,A3,A4," +
        "A5,A6,A7,A8,A9,AA,AAA,AAD,AAE,AAF,AAG,AAH,AAI,AAJ,AAK,AAL,AAM,AAN,AAO,AAP,AAQ,AA" +
        "R,AAS,AAT,AAU,AAV,AAW,AAX,AAY,AB,ABF,ABJ,ABK,ABN,ABR,ABS,ABU,ABV,AC,ACR,AD,ADD,A" +
        "DJ,AE,AF,AG,AH,AI,AJ,AJT,AK,AL,ALM,ALP,AM,AN,AO,APE,APR,AQ,AR,ARI,AS,ASD,AT,ATD," +
        "ATT,AU,AV,AW,AX,AY,AZ,B,BA,BB,BBQ,BBR,BC,BCC,BCR,BD,BE,BF,BG,BH,BI,BJ,BK,BL,BN,B" +
        "O,BP,BPL,BQ,BR,BRL,BS,BSL,BSP,BT,BTC,BU,BUI,BV,BW,BX,BY,BZ,C,C1,C2,C3,CA,CAH,CB," +
        "CC,CD,CE,CF,CFI,CG,CH,CHG,CI,CIE,CJ,CK,CL,CLP,CM,CML,CN,CNC,CO,COG,CP,CPS,CQ,CR," +
        "CRC,CS,CSD,CSF,CT,CU,CV,CW,CZ,D,D1,D2,D3,D4,D5,DA,DAC,DB,DBS,DC,DD,DE,DF,DG,DGO," +
        "DH,DI,DJ,DK,DL,DLO,DLP,DM,DN,DO,DOF,DP,DPE,DPL,DQ,DR,DRL,DS,DSR,DSS,DT,DU,DW,DX," +
        "DY,DZ,E,EA,EAA,EAB,EAC,EAD,EAE,EAF,EAG,EAH,EAI,EAJ,EAK,EAL,EAM,EAN,EAO,EAP,EAQ,E" +
        "AR,EAS,EAT,EAU,EAV,EAW,EAX,EAY,EAZ,EB,EBA,EBB,EBC,EBD,EBE,EBF,EBG,EBH,EBI,EBJ,EB" +
        "K,EBL,EBM,EBN,EBO,EBP,EBQ,EBR,EBS,EBT,EBU,EBV,EBW,EBX,EBY,EBZ,EC,ECA,ECB,ECC,ECD" +
        ",ECE,ECF,ECG,ECH,ECI,ECJ,ECK,ECL,ECM,ECN,ECO,ECP,ECQ,ECR,ECS,ECT,ECU,ECV,ECW,ECX" +
        ",ECY,ECZ,ED,EDA,EDB,EDC,EDD,EDE,EDF,EDG,EDH,EDI,EDJ,EDK,EDL,EDM,EDN,EDO,EDP,EDQ," +
        "EDR,EDS,EDT,EDU,EDV,EDW,EDX,EDY,EDZ,EE,EEA,EEB,EEC,EED,EEE,EEF,EEG,EEH,EEI,EEJ,E" +
        "EK,EEL,EEM,EEN,EEO,EEP,EEQ,EER,EES,EF,EG,EH,EI,EJ,EK,EL,EM,EMC,EN,EO,EQ,EQR,ER,E" +
        "S,ESC,ESL,ET,ETL,EU,EV,EW,EWC,EWR,EX,EXD,EY,EZ,F,FA,FAP,FB,FC,FC1,FD,FE,FF,FF1,F" +
        "G,FH,FH1,FI,FIR,FJ,FK,FL,FL1,FM,FMO,FMS,FN,FO,FP,FP1,FQ,FR,FRP,FS,FT,FT1,FU,FV,F" +
        "W,FX,FZ,G,G1,GA,GB,GC,GD,GE,GF,GG,GI,GJ,GK,GQ,GR,GS,GT,GU,GV,GW,GX,GY,GZ,H,HA,HB" +
        ",HC,HD,HE,HF,HG,HI,HJ,HK,HL,HM,HO,HRC,HS,HZR,I,IBP,IC,ID,IF,IMC,IMP,IND,IPA,IQ,I" +
        "RR,IRT,IT,J,J0,J1,J2,J3,J4,J5,J6,J7,J8,J9,JA,JB,JC,JCL,JD,JE,JF,JG,JH,JI,JK,JL,J" +
        "M,JN,JO,JOL,JP,K,KA,KB,KC,KD,KE,KF,KG,KH,KI,KJ,KK,KL,KM,KO,KP,KQ,KS,KT,KU,KW,KYL" +
        ",KZ,L,LA,LB,LC,LD,LE,LF,LG,LH,LIN,LJ,LK,LM,LN,LO,LOC,LOI,LP,LQ,LR,LS,LSC,LT,LZ,M" +
        ",MA,MAC,MB,MC,MCC,MCD,ME,MEC,MI,MJ,MK,ML,MN,MOC,MOE,MRI,MS,MT,N,NA,NAC,NAF,NAN,N" +
        "AS,NB,NC,ND,NDC,NE,NF,NH,NI,NIR,NJ,NK,NP,NPC,NR,NS,NT,NUB,O,O1,O2,O3,O4,OC,P,PA," +
        "PB,PC,PCR,PD,PDA,PGS,PHC,PI,PIT,PL,PLC,PLS,POB,PPD,PPP,PPS,PPV,PQA,PR,PRA,PRC,PR" +
        "I,PRR,PRT,PS,PT,PWA,PWI,PWR,PWS,PWT,Q,QA,QB,QC,QDR,QE,QF,QG,QH,QI,QJ,QK,QS,QT,R," +
        "R1,R2,R3,R4,RA,RAS,RC,RCA,RD,RE,REC,RED,REN,RET,RFC,RI,RJC,RQ,RSS,RT,RTC,RUM,RVC" +
        ",RX,S,SA,SAT,SB,SBA,SC,SCI,SD,SE,SEC,SET,SF,SG,SH,SHL,SHM,SHN,SHO,SHP,SHQ,SHR,SH" +
        "S,SHT,SHU,SHV,SHW,SHX,SHY,SHZ,SI,SIA,SIB,SIC,SID,SIE,SIF,SIG,SIH,SII,SIJ,SIK,SIL" +
        ",SIM,SIN,SIO,SIP,SIQ,SIR,SIS,SIT,SIU,SIV,SIW,SIX,SIY,SIZ,SJ,SJA,SJB,SJC,SJD,SJE," +
        "SJF,SJG,SJH,SJI,SJJ,SJK,SJL,SJM,SJN,SJO,SJP,SJQ,SJR,SJS,SJT,SJU,SJV,SJW,SJX,SJY," +
        "SJZ,SKA,SKB,SKC,SKD,SKE,SKF,SKG,SKH,SKI,SKJ,SKK,SKL,SKM,SKN,SKO,SKP,SKQ,SKR,SKS," +
        "SKT,SKU,SKV,SKW,SKX,SKY,SKZ,SL,SLA,SLS,SMB,SMC,SMD,SMI,SMT,SO,SP,SPE,SR,SRL,SRR," +
        "SRT,SS,SSC,ST,STC,STF,SUI,SVC,SWR,T,T00,T01,T02,T03,T04,T05,T06,T07,T08,T09,T10," +
        "T11,T12,T13,T14,T15,T16,T17,T18,T19,T20,T21,T22,T23,T24,T25,T26,T27,T28,T29,T30," +
        "T31,T32,T33,T34,T35,TB,TC,TCD,TCL,TD,TE,TF,TFR,TG,TL,TOL,TP,TQ,TR,TT,TTL,TX,TY,U" +
        ",UER,UJC,UNP,UPC,UPT,UR,US,UT,UTC,UU,V,VAL,VP,W,WDL,WRC,WSD,X,XD,Y,Z,ZZ,")]
    public class X12_ID_1270
    {
    }
    
    [Serializable()]
    [Composite("C001_CompositeUnitofMeasure_10")]
    public class C001_CompositeUnitofMeasure_10
    {
        
        [Required]
        [DataElement("355", typeof(X12_ID_355_2))]
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
        [DataElement("355", typeof(X12_ID_355_2))]
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
        [DataElement("355", typeof(X12_ID_355_2))]
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
        [DataElement("355", typeof(X12_ID_355_2))]
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
        [DataElement("355", typeof(X12_ID_355_2))]
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
    [All()]
    public class All_QTY_2
    {
        
        [Pos(1)]
        public QTY_AmbulancePatientCount_2 QTY_AmbulancePatientCount_2 { get; set; }
        [Pos(2)]
        public QTY_ObstetricAnesthesiaAdditionalUnits_2 QTY_ObstetricAnesthesiaAdditionalUnits_2 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",PT,")]
    public class X12_ID_673
    {
    }
    
    [Serializable()]
    [EdiCodes(",FL,")]
    public class X12_ID_673_2
    {
    }
    
    [Serializable()]
    [Segment("QTY", typeof(X12_ID_673_2))]
    public class QTY_ObstetricAnesthesiaAdditionalUnits_2
    {
        
        [Required]
        [DataElement("673", typeof(X12_ID_673_2))]
        [Pos(1)]
        public string QuantityQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(2)]
        public string ObstetricAdditionalUnits_02 { get; set; }
        [Pos(3)]
        public C001_CompositeUnitofMeasure_9 CompositeUnitofMeasure_03 { get; set; }
        [StringLength(1, 30)]
        [DataElement("61", typeof(X12_AN))]
        [Pos(4)]
        public string FreeformInformation_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C001_CompositeUnitofMeasure_9")]
    public class C001_CompositeUnitofMeasure_9
    {
        
        [Required]
        [DataElement("355", typeof(X12_ID_355_2))]
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
        [DataElement("355", typeof(X12_ID_355_2))]
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
        [DataElement("355", typeof(X12_ID_355_2))]
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
        [DataElement("355", typeof(X12_ID_355_2))]
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
        [DataElement("355", typeof(X12_ID_355_2))]
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
    [Segment("QTY", typeof(X12_ID_673))]
    public class QTY_AmbulancePatientCount_2
    {
        
        [Required]
        [DataElement("673", typeof(X12_ID_673))]
        [Pos(1)]
        public string QuantityQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(2)]
        public string AmbulancePatientCount_02 { get; set; }
        [Pos(3)]
        public C001_CompositeUnitofMeasure_8 CompositeUnitofMeasure_03 { get; set; }
        [StringLength(1, 30)]
        [DataElement("61", typeof(X12_AN))]
        [Pos(4)]
        public string FreeformInformation_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C001_CompositeUnitofMeasure_8")]
    public class C001_CompositeUnitofMeasure_8
    {
        
        [Required]
        [DataElement("355", typeof(X12_ID_355_2))]
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
        [DataElement("355", typeof(X12_ID_355_2))]
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
        [DataElement("355", typeof(X12_ID_355_2))]
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
        [DataElement("355", typeof(X12_ID_355_2))]
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
        [DataElement("355", typeof(X12_ID_355_2))]
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
    [All()]
    public class All_DTP_4
    {
        
        [Required]
        [Pos(1)]
        public DTP_Date_ServiceDate_2 DTP_Date_ServiceDate_2 { get; set; }
        [Pos(2)]
        public DTP_Date_PrescriptionDate_2 DTP_Date_PrescriptionDate_2 { get; set; }
        [Pos(3)]
        public DTP_DATE_CertificationRevision_RecertificationDate_2 DTP_DATE_CertificationRevision_RecertificationDate_2 { get; set; }
        [Pos(4)]
        public DTP_Date_BeginTherapyDate_2 DTP_Date_BeginTherapyDate_2 { get; set; }
        [Pos(5)]
        public DTP_Date_LastCertificationDate_2 DTP_Date_LastCertificationDate_2 { get; set; }
        [Pos(6)]
        public DTP_Date_LastSeenDate_4 DTP_Date_LastSeenDate_4 { get; set; }
        [ListCount(2)]
        [Pos(7)]
        public List<DTP_Date_TestDate_2> DTP_Date_TestDate_2 { get; set; }
        [Pos(8)]
        public DTP_Date_ShippedDate_2 DTP_Date_ShippedDate_2 { get; set; }
        [Pos(9)]
        public DTP_Date_LastX_rayDate_4 DTP_Date_LastX_rayDate_4 { get; set; }
        [Pos(10)]
        public DTP_Date_InitialTreatmentDate_4 DTP_Date_InitialTreatmentDate_4 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",472,")]
    public class X12_ID_374_19
    {
    }
    
    [Serializable()]
    [EdiCodes(",D8,RD8,")]
    public class X12_ID_1250_2
    {
    }
    
    [Serializable()]
    [EdiCodes(",471,")]
    public class X12_ID_374_9
    {
    }
    
    [Serializable()]
    [EdiCodes(",607,")]
    public class X12_ID_374_20
    {
    }
    
    [Serializable()]
    [EdiCodes(",463,")]
    public class X12_ID_374_21
    {
    }
    
    [Serializable()]
    [EdiCodes(",461,")]
    public class X12_ID_374_22
    {
    }
    
    [Serializable()]
    [EdiCodes(",304,")]
    public class X12_ID_374_4
    {
    }
    
    [Serializable()]
    [EdiCodes(",738,739,")]
    public class X12_ID_374_23
    {
    }
    
    [Serializable()]
    [EdiCodes(",011,")]
    public class X12_ID_374_24
    {
    }
    
    [Serializable()]
    [EdiCodes(",455,")]
    public class X12_ID_374_8
    {
    }
    
    [Serializable()]
    [EdiCodes(",454,")]
    public class X12_ID_374_3
    {
    }
    
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_3), typeof(X12_ID_1250))]
    public class DTP_Date_InitialTreatmentDate_4
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
        public string InitialTreatmentDate_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_8), typeof(X12_ID_1250))]
    public class DTP_Date_LastX_rayDate_4
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374_8))]
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
        public string LastXRayDate_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_24), typeof(X12_ID_1250))]
    public class DTP_Date_ShippedDate_2
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374_24))]
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
        public string ShippedDate_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_23), typeof(X12_ID_1250))]
    public class DTP_Date_TestDate_2
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374_23))]
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
        public string TestPerformedDate_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_4), typeof(X12_ID_1250))]
    public class DTP_Date_LastSeenDate_4
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374_4))]
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
        public string TreatmentorTherapyDate_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_22), typeof(X12_ID_1250))]
    public class DTP_Date_LastCertificationDate_2
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374_22))]
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
        public string LastCertificationDate_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_21), typeof(X12_ID_1250))]
    public class DTP_Date_BeginTherapyDate_2
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374_21))]
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
        public string BeginTherapyDate_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_20), typeof(X12_ID_1250))]
    public class DTP_DATE_CertificationRevision_RecertificationDate_2
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374_20))]
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
        public string CertificationRevisionorRecertificationDate_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_9), typeof(X12_ID_1250))]
    public class DTP_Date_PrescriptionDate_2
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374_9))]
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
        public string PrescriptionDate_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_19), typeof(X12_ID_1250_2))]
    public class DTP_Date_ServiceDate_2
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374_19))]
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
        public string ServiceDate_03 { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_CRC_4
    {
        
        [ListCount(3)]
        [Pos(1)]
        public List<CRC_AmbulanceCertification_4> CRC_AmbulanceCertification_4 { get; set; }
        [Pos(2)]
        public CRC_HospiceEmployeeIndicator_2 CRC_HospiceEmployeeIndicator_2 { get; set; }
        [Pos(3)]
        public CRC_ConditionIndicator_DurableMedicalEquipment_2 CRC_ConditionIndicator_DurableMedicalEquipment_2 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",07,")]
    public class X12_ID_1136
    {
    }
    
    [Serializable()]
    [EdiCodes(",N,Y,")]
    public class X12_ID_1073_3
    {
    }
    
    [Serializable()]
    [EdiCodes(",70,")]
    public class X12_ID_1136_5
    {
    }
    
    [Serializable()]
    [EdiCodes(",09,")]
    public class X12_ID_1136_6
    {
    }
    
    [Serializable()]
    [Segment("CRC", typeof(X12_ID_1136_6), typeof(X12_ID_1073_3))]
    public class CRC_ConditionIndicator_DurableMedicalEquipment_2
    {
        
        [Required]
        [DataElement("1136", typeof(X12_ID_1136_6))]
        [Pos(1)]
        public string CodeCategory_01 { get; set; }
        [Required]
        [DataElement("1073", typeof(X12_ID_1073_3))]
        [Pos(2)]
        public string CertificationConditionIndicator_02 { get; set; }
        [Required]
        [DataElement("1321", typeof(X12_ID_1321_7))]
        [Pos(3)]
        public string ConditionIndicator_03 { get; set; }
        [DataElement("1321", typeof(X12_ID_1321_7))]
        [Pos(4)]
        public string ConditionIndicator_04 { get; set; }
        [DataElement("1321", typeof(X12_ID_1321_4))]
        [Pos(5)]
        public string ConditionIndicator_05 { get; set; }
        [DataElement("1321", typeof(X12_ID_1321_4))]
        [Pos(6)]
        public string ConditionIndicator_06 { get; set; }
        [DataElement("1321", typeof(X12_ID_1321_4))]
        [Pos(7)]
        public string ConditionIndicator_07 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",38,ZV,")]
    public class X12_ID_1321_7
    {
    }
    
    [Serializable()]
    [EdiCodes(",00,000,01,02,03,04,05,06,07,08,09,0A,0B,0C,0D,0E,0F,0G,0H,0I,0J,0K,0L,0M,0N,0O,0" +
        "P,0Q,0R,0S,0T,0U,0V,0W,0X,0Y,0Z,10,11,12,13,14,15,16,17,18,19,1A,1B,1C,1D,1E,1F," +
        "1G,1H,1I,1J,1K,1L,1M,1N,1O,1P,1Q,1R,1S,1T,1U,1V,1W,1X,1Y,1Z,20,21,22,23,24,25,26" +
        ",27,28,29,2A,2B,2C,2D,2E,2F,2G,2H,2I,2J,2K,2L,2M,2N,2O,2P,2Q,2R,2S,2T,2U,2V,2W,2" +
        "X,2Y,2Z,30,31,32,33,34,35,36,37,38,39,3A,3B,3C,3D,3E,3F,3G,3H,3I,3J,3K,3L,3M,3N," +
        "3O,3P,3Q,3R,3S,3T,3U,3V,3W,3X,3Y,3Z,40,41,42,43,44,45,46,47,48,49,4A,4B,4C,4D,4E" +
        ",4F,4G,4H,4I,4J,4K,4L,4M,4N,4O,4P,4Q,4R,4S,4T,4U,4V,4W,4X,4Y,4Z,50,51,52,53,54,5" +
        "5,56,57,58,59,5A,5B,5C,5D,5E,5F,5G,5H,5I,5J,5K,5L,5M,5N,5O,5P,5Q,5R,5S,5T,5U,5V," +
        "5W,5X,5Y,5Z,60,61,62,63,64,65,66,67,68,69,6A,6B,6C,6D,6E,6F,6G,6H,6I,6J,6K,6L,6M" +
        ",6N,6O,6P,6Q,6R,6S,6T,6U,6V,6W,6X,6Y,6Z,70,71,72,73,74,75,76,77,78,79,7A,7B,7C,7" +
        "D,7E,7F,7G,7H,7I,7J,7K,7L,7M,7N,7O,7P,7Q,7R,7S,7T,7U,7V,7W,7X,7Y,7Z,80,81,82,83," +
        "84,85,86,87,88,89,8A,8B,8C,8D,8E,8F,8G,8H,8I,8J,8K,8L,8M,8N,8O,8P,8Q,8R,8S,8T,8U" +
        ",8V,8W,8X,8Y,8Z,90,91,92,93,94,95,96,97,98,99,9A,9B,9C,9D,9E,9F,9G,9H,9I,9J,9K,9" +
        "L,9M,9N,9O,9P,9Q,9R,9S,9T,9U,9V,9W,9X,9Y,9Z,A0,A1,A2,A3,A4,A5,A6,A7,A8,A9,AA,AB," +
        "AC,AD,AE,AF,AFM,AG,AH,AI,AJ,AK,AL,AM,AN,AO,AP,AQ,AR,AS,AT,AU,AV,AW,AX,AY,AZ,B0,B" +
        "1,B2,B3,B4,B5,B6,B7,B8,B9,BA,BB,BC,BD,BE,BF,BG,BH,BI,BJ,BK,BL,BM,BN,BO,BP,BPD,BQ" +
        ",BR,BS,BT,BTD,BU,BV,BW,BX,BY,BZ,C0,C1,C2,C3,C4,C5,C6,C7,C8,C9,CA,CB,CC,CD,CE,CF," +
        "CFD,CG,CH,CI,CJ,CK,CL,CM,CN,CNJ,CO,CP,CQ,CR,CS,CT,CU,CV,CW,CX,CY,CZ,D0,D1,D2,D3," +
        "D4,D5,D6,D7,D8,D9,DA,DB,DC,DD,DE,DF,DFR,DG,DH,DI,DJ,DK,DL,DM,DN,DNR,DO,DP,DQ,DR," +
        "DS,DT,DU,DV,DW,DX,DY,DZ,E0,E1,E2,E3,E4,E5,E6,E7,E8,E9,EA,EB,EC,ED,EE,EF,EG,EH,EI" +
        ",EJ,EK,EL,EM,EN,EO,EP,EQ,ER,ES,ET,EU,EV,EW,EX,EY,EZ,F0,F1,F2,F3,F4,F5,F6,F7,F8,F" +
        "9,FA,FB,FC,FD,FE,FF,FG,FH,FI,FJ,FK,FL,FM,FN,FO,FP,FQ,FR,FS,FT,FU,FV,FW,FX,FY,FZ," +
        "G0,G1,G2,G3,G4,G5,G6,G7,G8,G9,GA,GB,GC,GD,GE,GF,GG,GH,GI,GJ,GK,GL,GM,GN,GO,GP,GQ" +
        ",GR,GS,GT,GU,GV,GW,GX,GY,GZ,H0,H1,H2,H3,H4,H5,H6,H7,H8,H9,HA,HB,HC,HD,HE,HF,HG,H" +
        "H,HI,HJ,HK,HL,HM,HN,HO,HP,HQ,HR,HS,HT,HU,HV,HW,HX,HY,HZ,I0,I1,I2,I3,I4,I5,I6,I7," +
        "I8,I9,IA,IB,IC,ID,IE,IF,IG,IH,II,IJ,IK,IL,IM,IN,IO,IP,IQ,IR,IS,IT,IU,IV,IW,IX,IY" +
        ",IZ,J0,J1,J2,J3,J4,J5,J6,J7,J8,J9,JA,JB,JC,JCA,JD,JE,JF,JG,JH,JI,JJ,JK,JL,JM,JN," +
        "JO,JP,JQ,JR,JS,JT,JU,JV,JW,JX,JY,JZ,K0,K1,K2,K3,K4,K5,K6,K7,K8,K9,KA,KB,KC,KD,KE" +
        ",KF,KG,KH,KI,KJ,KK,KL,KM,KN,KO,KP,KQ,KR,KS,KT,KU,KV,KW,KX,KY,KZ,L0,L1,L2,L3,L4,L" +
        "5,L6,L7,L8,L9,LA,LB,LC,LD,LE,LF,LG,LH,LI,LJ,LK,LL,LM,LN,LO,LP,LQ,LR,LS,LSD,LT,LU" +
        ",LV,LW,LX,LY,LZ,M0,M1,M2,M3,M4,M5,M6,M7,M8,M9,MA,MB,MC,MD,ME,MF,MG,MH,MI,MJ,MK,M" +
        "L,MM,MN,MO,MP,MQ,MR,MS,MT,MU,MV,MW,MX,MY,MZ,N0,N1,N2,N3,N4,N5,N6,N7,N8,N9,NA,NB," +
        "NC,ND,NDP,NE,NF,NG,NH,NI,NJ,NK,NL,NM,NN,NO,NP,NQ,NR,NS,NT,NU,NV,NW,NX,NY,NZ,O0,O" +
        "1,O2,O3,O4,O5,O6,O7,O8,O9,OA,OB,OC,OD,ODZ,OE,OF,OG,OH,OI,OJ,OK,OL,OM,ON,OO,OP,OQ" +
        ",OR,OS,OT,OU,OV,OW,OX,OY,OZ,P0,P1,P2,P3,P4,P5,P6,P7,P8,P9,PA,PB,PC,PD,PE,PF,PFB," +
        "PG,PH,PI,PJ,PK,PL,PM,PN,PO,PP,PQ,PR,PRD,PS,PT,PU,PV,PW,PX,PY,PZ,Q0,Q1,Q2,Q3,Q4,Q" +
        "5,Q6,Q7,Q8,Q9,QA,QB,QC,QD,QE,QF,QG,QH,QI,QJ,QK,QL,QM,QN,QO,QP,QQ,QR,QS,QT,QU,QV," +
        "QW,QX,QY,QZ,R0,R1,R2,R3,R4,R5,R6,R7,R8,R9,RA,RB,RC,RCA,RD,RE,RF,RG,RH,RI,RJ,RK,R" +
        "L,RM,RN,RO,RP,RQ,RR,RS,RT,RU,RV,RW,RX,RY,RZ,S0,S1,S2,S3,S4,S5,S6,S7,S8,S9,SA,SB," +
        "SC,SD,SE,SF,SG,SH,SI,SJ,SK,SL,SM,SN,SO,SP,SPP,SPS,SQ,SR,SS,ST,SU,SUB,SV,SW,SX,SY" +
        ",SZ,T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,TA,TB,TC,TD,TE,TF,TG,TH,TI,TJ,TK,TL,TM,TN,TNJ," +
        "TO,TP,TQ,TR,TS,TT,TU,TV,TW,TX,TY,TZ,U0,U1,U2,U3,U4,U5,U6,U7,U8,U9,UA,UB,UC,UD,UE" +
        ",UF,UG,UH,UI,UJ,UK,UL,UM,UN,UO,UP,UQ,UR,US,UT,UU,UV,UW,UX,UY,UZ,V0,V1,V2,V3,V4,V" +
        "5,V6,V7,V8,V9,VA,VB,VC,VD,VE,VF,VG,VH,VI,VJ,VK,VL,VM,VN,VO,VP,VQ,VR,VS,VT,VTL,VU" +
        ",VV,VW,VX,VY,VZ,W0,W1,W2,W3,W4,W5,W6,W7,W8,W9,WA,WB,WC,WD,WE,WF,WG,WH,WI,WJ,WK,W" +
        "L,WM,WN,WO,WP,WQ,WR,WS,WT,WU,WV,WW,WX,WY,WZ,X0,X1,X2,X3,X4,X5,X6,X7,X8,X9,XA,XB," +
        "XC,XD,XE,XF,XG,XH,XI,XJ,XK,XL,XM,XN,XO,XP,XQ,XR,XS,XT,XU,XV,XW,XX,XY,XZ,Y0,Y1,Y2" +
        ",Y3,Y4,Y5,Y6,Y7,Y8,Y9,YA,YB,YC,YD,YE,YF,YG,YH,YI,YJ,YK,YL,YM,YN,YO,YP,YQ,YR,YS,Y" +
        "T,YU,YV,YW,YX,YY,YZ,Z0,Z1,Z2,Z3,Z4,Z5,Z6,Z7,Z8,Z9,ZA,ZB,ZC,ZD,ZE,ZF,ZG,ZH,ZI,ZJ," +
        "ZK,ZL,ZM,ZN,ZO,ZP,ZQ,ZR,ZS,ZT,ZU,ZV,ZW,ZX,ZY,ZZ,")]
    public class X12_ID_1321_4
    {
    }
    
    [Serializable()]
    [Segment("CRC", typeof(X12_ID_1136_5), typeof(X12_ID_1073_3))]
    public class CRC_HospiceEmployeeIndicator_2
    {
        
        [Required]
        [DataElement("1136", typeof(X12_ID_1136_5))]
        [Pos(1)]
        public string CodeCategory_01 { get; set; }
        [Required]
        [DataElement("1073", typeof(X12_ID_1073_3))]
        [Pos(2)]
        public string HospiceEmployedProviderIndicator_02 { get; set; }
        [Required]
        [DataElement("1321", typeof(X12_ID_1321_6))]
        [Pos(3)]
        public string ConditionIndicator_03 { get; set; }
        [DataElement("1321", typeof(X12_ID_1321_4))]
        [Pos(4)]
        public string ConditionIndicator_04 { get; set; }
        [DataElement("1321", typeof(X12_ID_1321_4))]
        [Pos(5)]
        public string ConditionIndicator_05 { get; set; }
        [DataElement("1321", typeof(X12_ID_1321_4))]
        [Pos(6)]
        public string ConditionIndicator_06 { get; set; }
        [DataElement("1321", typeof(X12_ID_1321_4))]
        [Pos(7)]
        public string ConditionIndicator_07 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",65,")]
    public class X12_ID_1321_6
    {
    }
    
    [Serializable()]
    [Segment("CRC", typeof(X12_ID_1136), typeof(X12_ID_1073_3))]
    public class CRC_AmbulanceCertification_4
    {
        
        [Required]
        [DataElement("1136", typeof(X12_ID_1136))]
        [Pos(1)]
        public string CodeCategory_01 { get; set; }
        [Required]
        [DataElement("1073", typeof(X12_ID_1073_3))]
        [Pos(2)]
        public string CertificationConditionIndicator_02 { get; set; }
        [Required]
        [DataElement("1321", typeof(X12_ID_1321))]
        [Pos(3)]
        public string ConditionCode_03 { get; set; }
        [DataElement("1321", typeof(X12_ID_1321))]
        [Pos(4)]
        public string ConditionCode_04 { get; set; }
        [DataElement("1321", typeof(X12_ID_1321))]
        [Pos(5)]
        public string ConditionCode_05 { get; set; }
        [DataElement("1321", typeof(X12_ID_1321))]
        [Pos(6)]
        public string ConditionCode_06 { get; set; }
        [DataElement("1321", typeof(X12_ID_1321))]
        [Pos(7)]
        public string ConditionCode_07 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",01,04,05,06,07,08,09,12,")]
    public class X12_ID_1321
    {
    }
    
    [Serializable()]
    [Segment("CR3", typeof(X12_ID_1322), typeof(X12_ID_355_7))]
    public class CR3_DurableMedicalEquipmentCertification_2
    {
        
        [Required]
        [DataElement("1322", typeof(X12_ID_1322))]
        [Pos(1)]
        public string CertificationTypeCode_01 { get; set; }
        [Required]
        [DataElement("355", typeof(X12_ID_355_7))]
        [Pos(2)]
        public string UnitorBasisforMeasurementCode_02 { get; set; }
        [Required]
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(3)]
        public string DurableMedicalEquipmentDuration_03 { get; set; }
        [DataElement("1335", typeof(X12_ID_1335))]
        [Pos(4)]
        public string InsulinDependentCode_04 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(5)]
        public string Description_05 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",1,2,3,N,")]
    public class X12_ID_1335
    {
    }
    
    [Serializable()]
    [Segment("CR1", typeof(X12_ID_355_3))]
    public class CR1_AmbulanceTransportInformation_4
    {
        
        [DataElement("355", typeof(X12_ID_355_3))]
        [Pos(1)]
        public string UnitorBasisforMeasurementCode_01 { get; set; }
        [StringLength(1, 10)]
        [DataElement("81", typeof(X12_R))]
        [Pos(2)]
        public string PatientWeight_02 { get; set; }
        [DataElement("1316", typeof(X12_ID_1316))]
        [Pos(3)]
        public string AmbulanceTransportCode_03 { get; set; }
        [Required]
        [DataElement("1317", typeof(X12_ID_1317))]
        [Pos(4)]
        public string AmbulanceTransportReasonCode_04 { get; set; }
        [Required]
        [DataElement("355", typeof(X12_ID_355_4))]
        [Pos(5)]
        public string UnitorBasisforMeasurementCode_05 { get; set; }
        [Required]
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        public string TransportDistance_06 { get; set; }
        [StringLength(1, 55)]
        [DataElement("166", typeof(X12_AN))]
        [Pos(7)]
        public string AddressInformation_07 { get; set; }
        [StringLength(1, 55)]
        [DataElement("166", typeof(X12_AN))]
        [Pos(8)]
        public string AddressInformation_08 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(9)]
        public string RoundTripPurposeDescription_09 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(10)]
        public string StretcherPurposeDescription_10 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",I,R,T,X,")]
    public class X12_ID_1316
    {
    }
    
    [Serializable()]
    [EdiCodes(",A,B,C,D,E,")]
    public class X12_ID_1317
    {
    }
    
    [Serializable()]
    [EdiCodes(",DH,")]
    public class X12_ID_355_4
    {
    }
    
    [Serializable()]
    [All()]
    public class All_PWK_2
    {
        
        [ListCount(10)]
        [Pos(1)]
        public List<PWK_LineSupplementalInformation_2> PWK_LineSupplementalInformation_2 { get; set; }
        [Pos(2)]
        public PWK_DurableMedicalEquipmentCertificateofMedicalNecessityIndicator_2 PWK_DurableMedicalEquipmentCertificateofMedicalNecessityIndicator_2 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",03,04,05,06,07,08,09,10,11,13,15,21,A3,A4,AM,AS,B2,B3,B4,BR,BS,BT,CB,CK,CT,D2,DA" +
        ",DB,DG,DJ,DS,EB,HC,HR,I5,IR,LA,M1,MT,NN,OB,OC,OD,OE,OX,OZ,P4,P5,PE,PN,PO,PQ,PY,P" +
        "Z,RB,RR,RT,RX,SG,V5,XP,")]
    public class X12_ID_755_2
    {
    }
    
    [Serializable()]
    [EdiCodes(",CT,")]
    public class X12_ID_755_3
    {
    }
    
    [Serializable()]
    [EdiCodes(",AB,AD,AF,AG,NS,")]
    public class X12_ID_756_2
    {
    }
    
    [Serializable()]
    [Segment("PWK", typeof(X12_ID_755_3), typeof(X12_ID_756_2))]
    public class PWK_DurableMedicalEquipmentCertificateofMedicalNecessityIndicator_2
    {
        
        [Required]
        [DataElement("755", typeof(X12_ID_755_3))]
        [Pos(1)]
        public string AttachmentReportTypeCode_01 { get; set; }
        [Required]
        [DataElement("756", typeof(X12_ID_756_2))]
        [Pos(2)]
        public string AttachmentTransmissionCode_02 { get; set; }
        [StringLength(1, 2)]
        [DataElement("757", typeof(X12_N0))]
        [Pos(3)]
        public string ReportCopiesNeeded_03 { get; set; }
        [DataElement("98", typeof(X12_ID_98_2))]
        [Pos(4)]
        public string EntityIdentifierCode_04 { get; set; }
        [DataElement("66", typeof(X12_ID_66_3))]
        [Pos(5)]
        public string IdentificationCodeQualifier_05 { get; set; }
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(6)]
        public string IdentificationCode_06 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(7)]
        public string Description_07 { get; set; }
        [Pos(8)]
        public C002_ActionsIndicated_6 ActionsIndicated_08 { get; set; }
        [DataElement("1525", typeof(X12_ID_1525))]
        [Pos(9)]
        public string RequestCategoryCode_09 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",AR,BA,HS,IN,PR,RE,SC,")]
    public class X12_ID_1525
    {
    }
    
    [Serializable()]
    [Composite("C002_ActionsIndicated_6")]
    public class C002_ActionsIndicated_6
    {
        
        [Required]
        [DataElement("704", typeof(X12_ID_704))]
        [Pos(1)]
        public string PaperworkReportActionCode_01 { get; set; }
        [DataElement("704", typeof(X12_ID_704))]
        [Pos(2)]
        public string PaperworkReportActionCode_02 { get; set; }
        [DataElement("704", typeof(X12_ID_704))]
        [Pos(3)]
        public string PaperworkReportActionCode_03 { get; set; }
        [DataElement("704", typeof(X12_ID_704))]
        [Pos(4)]
        public string PaperworkReportActionCode_04 { get; set; }
        [DataElement("704", typeof(X12_ID_704))]
        [Pos(5)]
        public string PaperworkReportActionCode_05 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",1,2,3,4,5,6,CH,CO,DM,NT,ON,OR,PV,SG,")]
    public class X12_ID_704
    {
    }
    
    [Serializable()]
    [Segment("PWK", typeof(X12_ID_755_2), typeof(X12_ID_756))]
    public class PWK_LineSupplementalInformation_2
    {
        
        [Required]
        [DataElement("755", typeof(X12_ID_755_2))]
        [Pos(1)]
        public string AttachmentReportTypeCode_01 { get; set; }
        [Required]
        [DataElement("756", typeof(X12_ID_756))]
        [Pos(2)]
        public string AttachmentTransmissionCode_02 { get; set; }
        [StringLength(1, 2)]
        [DataElement("757", typeof(X12_N0))]
        [Pos(3)]
        public string ReportCopiesNeeded_03 { get; set; }
        [DataElement("98", typeof(X12_ID_98_2))]
        [Pos(4)]
        public string EntityIdentifierCode_04 { get; set; }
        [DataElement("66", typeof(X12_ID_66_6))]
        [Pos(5)]
        public string IdentificationCodeQualifier_05 { get; set; }
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(6)]
        public string AttachmentControlNumber_06 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(7)]
        public string Description_07 { get; set; }
        [Pos(8)]
        public C002_ActionsIndicated_5 ActionsIndicated_08 { get; set; }
        [DataElement("1525", typeof(X12_ID_1525))]
        [Pos(9)]
        public string RequestCategoryCode_09 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",AC,")]
    public class X12_ID_66_6
    {
    }
    
    [Serializable()]
    [Composite("C002_ActionsIndicated_5")]
    public class C002_ActionsIndicated_5
    {
        
        [Required]
        [DataElement("704", typeof(X12_ID_704))]
        [Pos(1)]
        public string PaperworkReportActionCode_01 { get; set; }
        [DataElement("704", typeof(X12_ID_704))]
        [Pos(2)]
        public string PaperworkReportActionCode_02 { get; set; }
        [DataElement("704", typeof(X12_ID_704))]
        [Pos(3)]
        public string PaperworkReportActionCode_03 { get; set; }
        [DataElement("704", typeof(X12_ID_704))]
        [Pos(4)]
        public string PaperworkReportActionCode_04 { get; set; }
        [DataElement("704", typeof(X12_ID_704))]
        [Pos(5)]
        public string PaperworkReportActionCode_05 { get; set; }
    }
    
    [Serializable()]
    [Segment("SV5", typeof(X12_ID_235_3), typeof(X12_ID_355_6))]
    public class SV5_DurableMedicalEquipmentService_2
    {
        
        [Required]
        [Pos(1)]
        public C003_CompositeMedicalProcedureIdentifier_5 CompositeMedicalProcedureIdentifier_01 { get; set; }
        [Required]
        [DataElement("355", typeof(X12_ID_355_6))]
        [Pos(2)]
        public string UnitorBasisforMeasurementCode_02 { get; set; }
        [Required]
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(3)]
        public string LengthofMedicalNecessity_03 { get; set; }
        [Required]
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(4)]
        public string DMERentalPrice_04 { get; set; }
        [Required]
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(5)]
        public string DMEPurchasePrice_05 { get; set; }
        [Required]
        [DataElement("594", typeof(X12_ID_594))]
        [Pos(6)]
        public string RentalUnitPriceIndicator_06 { get; set; }
        [DataElement("923", typeof(X12_ID_923))]
        [Pos(7)]
        public string PrognosisCode_07 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",1,4,6,")]
    public class X12_ID_594
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,3,4,5,6,7,8,")]
    public class X12_ID_923
    {
    }
    
    [Serializable()]
    [Composite("C003_CompositeMedicalProcedureIdentifier_5")]
    public class C003_CompositeMedicalProcedureIdentifier_5
    {
        
        [Required]
        [DataElement("235", typeof(X12_ID_235_3))]
        [Pos(1)]
        public string ProcedureIdentifier_01 { get; set; }
        [Required]
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(2)]
        public string ProcedureCode_02 { get; set; }
        [StringLength(2, 2)]
        [DataElement("1339", typeof(X12_AN))]
        [Pos(3)]
        public string ProcedureModifier_03 { get; set; }
        [StringLength(2, 2)]
        [DataElement("1339", typeof(X12_AN))]
        [Pos(4)]
        public string ProcedureModifier_04 { get; set; }
        [StringLength(2, 2)]
        [DataElement("1339", typeof(X12_AN))]
        [Pos(5)]
        public string ProcedureModifier_05 { get; set; }
        [StringLength(2, 2)]
        [DataElement("1339", typeof(X12_AN))]
        [Pos(6)]
        public string ProcedureModifier_06 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(7)]
        public string Description_07 { get; set; }
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(8)]
        public string ProductServiceID_08 { get; set; }
    }
    
    [Serializable()]
    [Segment("SV1", typeof(X12_ID_235_2))]
    public class SV1_ProfessionalService_2
    {
        
        [Required]
        [Pos(1)]
        public C003_CompositeMedicalProcedureIdentifier_4 CompositeMedicalProcedureIdentifier_01 { get; set; }
        [Required]
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(2)]
        public string LineItemChargeAmount_02 { get; set; }
        [Required]
        [DataElement("355", typeof(X12_ID_355_5))]
        [Pos(3)]
        public string UnitorBasisforMeasurementCode_03 { get; set; }
        [Required]
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(4)]
        public string ServiceUnitCount_04 { get; set; }
        [StringLength(1, 2)]
        [DataElement("1331", typeof(X12_AN))]
        [Pos(5)]
        public string PlaceofServiceCode_05 { get; set; }
        [DataElement("1365", typeof(X12_ID_1365))]
        [Pos(6)]
        public string ServiceTypeCode_06 { get; set; }
        [Required]
        [Pos(7)]
        public C004_CompositeDiagnosisCodePointer_2 CompositeDiagnosisCodePointer_07 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(8)]
        public string MonetaryAmount_08 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073_2))]
        [Pos(9)]
        public string EmergencyIndicator_09 { get; set; }
        [DataElement("1340", typeof(X12_ID_1340))]
        [Pos(10)]
        public string MultipleProcedureCode_10 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073_2))]
        [Pos(11)]
        public string EPSDTIndicator_11 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073_2))]
        [Pos(12)]
        public string FamilyPlanningIndicator_12 { get; set; }
        [DataElement("1364", typeof(X12_ID_1364))]
        [Pos(13)]
        public string ReviewCode_13 { get; set; }
        [StringLength(1, 2)]
        [DataElement("1341", typeof(X12_AN))]
        [Pos(14)]
        public string NationalorLocalAssignedReviewValue_14 { get; set; }
        [DataElement("1327", typeof(X12_ID_1327))]
        [Pos(15)]
        public string CoPayStatusCode_15 { get; set; }
        [StringLength(1, 1)]
        [DataElement("1334", typeof(X12_ID))]
        [Pos(16)]
        public string HealthCareProfessionalShortageAreaCode_16 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(17)]
        public string ReferenceIdentification_17 { get; set; }
        [StringLength(3, 15)]
        [DataElement("116", typeof(X12_ID))]
        [Pos(18)]
        public string PostalCode_18 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(19)]
        public string MonetaryAmount_19 { get; set; }
        [DataElement("1337", typeof(X12_ID_1337))]
        [Pos(20)]
        public string LevelofCareCode_20 { get; set; }
        [DataElement("1360", typeof(X12_ID_1360))]
        [Pos(21)]
        public string ProviderAgreementCode_21 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(@",1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,23,24,25,26,27,28,3,30,31,32,33,34,35,36,37,38,39,4,40,41,42,43,44,45,46,47,48,49,5,50,51,52,53,54,55,56,57,58,59,6,60,61,62,63,64,65,66,67,68,69,7,70,71,72,73,74,75,76,77,78,79,8,80,81,82,83,84,85,86,87,88,89,9,90,91,92,93,94,95,96,97,98,99,A0,A1,A2,A3,A4,A5,A6,A7,A8,A9,AA,AB,AC,AD,AE,AF,AG,AH,AI,AJ,AK,AL,AM,AN,AO,AQ,AR,B,B1,B2,B3,BA,BB,BC,BD,BE,BF,BG,BH,BI,BJ,BK,BL,BM,BN,BP,BQ,BR,BS,BT,BU,BV,BW,BX,BY,BZ,C,C1,CA,CB,CC,CD,CE,CF,CG,CH,CI,CJ,CK,CL,CM,CN,CO,CP,CQ,DG,DM,DS,GF,GN,GY,IC,MH,NI,ON,PT,PU,RN,RT,TC,TN,UC,")]
    public class X12_ID_1365
    {
    }
    
    [Serializable()]
    [EdiCodes(",Y,")]
    public class X12_ID_1073_2
    {
    }
    
    [Serializable()]
    [EdiCodes(",N,P,S,")]
    public class X12_ID_1340
    {
    }
    
    [Serializable()]
    [EdiCodes(",A,B,C,D,E,F,L,N,")]
    public class X12_ID_1364
    {
    }
    
    [Serializable()]
    [EdiCodes(",0,")]
    public class X12_ID_1327
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,3,4,5,6,7,8,")]
    public class X12_ID_1337
    {
    }
    
    [Serializable()]
    [EdiCodes(",D,E,H,I,N,P,Y,")]
    public class X12_ID_1360
    {
    }
    
    [Serializable()]
    [Composite("C004_CompositeDiagnosisCodePointer_2")]
    public class C004_CompositeDiagnosisCodePointer_2
    {
        
        [Required]
        [StringLength(1, 2)]
        [DataElement("1328", typeof(X12_N0))]
        [Pos(1)]
        public string DiagnosisCodePointer_01 { get; set; }
        [StringLength(1, 2)]
        [DataElement("1328", typeof(X12_N0))]
        [Pos(2)]
        public string DiagnosisCodePointer_02 { get; set; }
        [StringLength(1, 2)]
        [DataElement("1328", typeof(X12_N0))]
        [Pos(3)]
        public string DiagnosisCodePointer_03 { get; set; }
        [StringLength(1, 2)]
        [DataElement("1328", typeof(X12_N0))]
        [Pos(4)]
        public string DiagnosisCodePointer_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C003_CompositeMedicalProcedureIdentifier_4")]
    public class C003_CompositeMedicalProcedureIdentifier_4
    {
        
        [Required]
        [DataElement("235", typeof(X12_ID_235_2))]
        [Pos(1)]
        public string ProductorServiceIDQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(2)]
        public string ProcedureCode_02 { get; set; }
        [StringLength(2, 2)]
        [DataElement("1339", typeof(X12_AN))]
        [Pos(3)]
        public string ProcedureModifier_03 { get; set; }
        [StringLength(2, 2)]
        [DataElement("1339", typeof(X12_AN))]
        [Pos(4)]
        public string ProcedureModifier_04 { get; set; }
        [StringLength(2, 2)]
        [DataElement("1339", typeof(X12_AN))]
        [Pos(5)]
        public string ProcedureModifier_05 { get; set; }
        [StringLength(2, 2)]
        [DataElement("1339", typeof(X12_AN))]
        [Pos(6)]
        public string ProcedureModifier_06 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(7)]
        public string Description_07 { get; set; }
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(8)]
        public string ProductServiceID_08 { get; set; }
    }
    
    [Serializable()]
    [Segment("LX")]
    public class LX_ServiceLineNumber_2
    {
        
        [Required]
        [StringLength(1, 6)]
        [DataElement("554", typeof(X12_N0))]
        [Pos(1)]
        public string AssignedNumber_01 { get; set; }
    }
    
    [Serializable()]
    [Group("SBR")]
    public class Loop_2320_2
    {
        
        [Required]
        [Pos(1)]
        public SBR_OtherSubscriberInformation_2 SBR_OtherSubscriberInformation_2 { get; set; }
        [ListCount(5)]
        [Pos(2)]
        public List<CAS_ClaimLevelAdjustments_2> CAS_ClaimLevelAdjustments_2 { get; set; }
        [Pos(3)]
        public All_AMT_3 All_AMT_3 { get; set; }
        [Required]
        [Pos(4)]
        public OI_OtherInsuranceCoverageInformation_2 OI_OtherInsuranceCoverageInformation_2 { get; set; }
        [Pos(5)]
        public MOA_OutpatientAdjudicationInformation_2 MOA_OutpatientAdjudicationInformation_2 { get; set; }
        [Required]
        [Pos(6)]
        public All_NM1_8 All_NM1_8 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",01,18,19,20,21,39,40,53,G8,")]
    public class X12_ID_1069_3
    {
    }
    
    [Serializable()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,31,32,33,AM,BL" +
        ",CH,CI,CN,DS,FI,HM,LI,LM,MA,MB,MC,MH,OF,SA,TV,VA,WB,WC,WD,WE,ZZ,")]
    public class X12_ID_1032_2
    {
    }
    
    [Serializable()]
    [EdiCodes(",00,01,02,03,05,07,08,09,15,16,17,18,20,22,27,28,29,PB,")]
    public class X12_ID_1383
    {
    }
    
    [Serializable()]
    [All()]
    public class All_NM1_8
    {
        
        [Required]
        [Pos(1)]
        public Loop_2330A_2 Loop_2330A_2 { get; set; }
        [Required]
        [Pos(2)]
        public Loop_2330B_2 Loop_2330B_2 { get; set; }
        [ListCount(2)]
        [Pos(3)]
        public List<Loop_2330C_2> Loop_2330C_2 { get; set; }
        [Pos(4)]
        public Loop_2330D_2 Loop_2330D_2 { get; set; }
        [Pos(5)]
        public Loop_2330E_2 Loop_2330E_2 { get; set; }
        [Pos(6)]
        public Loop_2330F_2 Loop_2330F_2 { get; set; }
        [Pos(7)]
        public Loop_2330G_2 Loop_2330G_2 { get; set; }
    }
    
    [Serializable()]
    [Group("NM1")]
    public class Loop_2330G_2
    {
        
        [Required]
        [Pos(1)]
        public NM1_OtherPayerBillingProvider_2 NM1_OtherPayerBillingProvider_2 { get; set; }
        [Required]
        [ListCount(2)]
        [Pos(2)]
        public List<REF_OtherPayerBillingProviderSecondaryIdentification_2> REF_OtherPayerBillingProviderSecondaryIdentification_2 { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_10))]
    public class REF_OtherPayerBillingProviderSecondaryIdentification_2
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_10))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string OtherPayerBillingProviderIdentifier_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        [Pos(4)]
        public C040_ReferenceIdentifier_84 ReferenceIdentifier_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C040_ReferenceIdentifier_84")]
    public class C040_ReferenceIdentifier_84
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_4), typeof(X12_ID_1065))]
    public class NM1_OtherPayerBillingProvider_2
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98_4))]
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
    public class Loop_2330F_2
    {
        
        [Required]
        [Pos(1)]
        public NM1_OtherPayerSupervisingProvider_2 NM1_OtherPayerSupervisingProvider_2 { get; set; }
        [Required]
        [ListCount(3)]
        [Pos(2)]
        public List<REF_OtherPayerSupervisingProviderSecondaryIdentification_2> REF_OtherPayerSupervisingProviderSecondaryIdentification_2 { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_26))]
    public class REF_OtherPayerSupervisingProviderSecondaryIdentification_2
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_26))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string OtherPayerSupervisingProviderIdentifier_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        [Pos(4)]
        public C040_ReferenceIdentifier_83 ReferenceIdentifier_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C040_ReferenceIdentifier_83")]
    public class C040_ReferenceIdentifier_83
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_12), typeof(X12_ID_1065_3))]
    public class NM1_OtherPayerSupervisingProvider_2
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98_12))]
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        [Required]
        [DataElement("1065", typeof(X12_ID_1065_3))]
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
    public class Loop_2330E_2
    {
        
        [Required]
        [Pos(1)]
        public NM1_OtherPayerServiceFacilityLocation_2 NM1_OtherPayerServiceFacilityLocation_2 { get; set; }
        [Required]
        [ListCount(3)]
        [Pos(2)]
        public List<REF_OtherPayerServiceFacilityLocationSecondaryIdentification_2> REF_OtherPayerServiceFacilityLocationSecondaryIdentification_2 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",0B,G2,LU,")]
    public class X12_ID_128_27
    {
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_27))]
    public class REF_OtherPayerServiceFacilityLocationSecondaryIdentification_2
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_27))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string OtherPayerServiceFacilityLocationSecondaryIdentifier_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        [Pos(4)]
        public C040_ReferenceIdentifier_82 ReferenceIdentifier_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C040_ReferenceIdentifier_82")]
    public class C040_ReferenceIdentifier_82
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_11), typeof(X12_ID_1065_2))]
    public class NM1_OtherPayerServiceFacilityLocation_2
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98_11))]
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        [Required]
        [DataElement("1065", typeof(X12_ID_1065_2))]
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
    public class Loop_2330D_2
    {
        
        [Required]
        [Pos(1)]
        public NM1_OtherPayerRenderingProvider_2 NM1_OtherPayerRenderingProvider_2 { get; set; }
        [Required]
        [ListCount(3)]
        [Pos(2)]
        public List<REF_OtherPayerRenderingProviderSecondaryIdentification_2> REF_OtherPayerRenderingProviderSecondaryIdentification_2 { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_26))]
    public class REF_OtherPayerRenderingProviderSecondaryIdentification_2
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_26))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string OtherPayerRenderingProviderSecondaryIdentifier_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        [Pos(4)]
        public C040_ReferenceIdentifier_81 ReferenceIdentifier_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C040_ReferenceIdentifier_81")]
    public class C040_ReferenceIdentifier_81
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_10), typeof(X12_ID_1065))]
    public class NM1_OtherPayerRenderingProvider_2
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98_10))]
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
    public class Loop_2330C_2
    {
        
        [Required]
        [Pos(1)]
        public NM1_OtherPayerReferringProvider_2 NM1_OtherPayerReferringProvider_2 { get; set; }
        [Required]
        [ListCount(3)]
        [Pos(2)]
        public List<REF_OtherPayerReferringProviderSecondaryIdentification_2> REF_OtherPayerReferringProviderSecondaryIdentification_2 { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_25))]
    public class REF_OtherPayerReferringProviderSecondaryIdentification_2
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_25))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string OtherPayerReferringProviderIdentifier_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        [Pos(4)]
        public C040_ReferenceIdentifier_80 ReferenceIdentifier_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C040_ReferenceIdentifier_80")]
    public class C040_ReferenceIdentifier_80
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_9), typeof(X12_ID_1065_3))]
    public class NM1_OtherPayerReferringProvider_2
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98_9))]
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        [Required]
        [DataElement("1065", typeof(X12_ID_1065_3))]
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
    public class Loop_2330B_2
    {
        
        [Required]
        [Pos(1)]
        public NM1_OtherPayerName_2 NM1_OtherPayerName_2 { get; set; }
        [Pos(2)]
        public N3_OtherPayerAddress_2 N3_OtherPayerAddress_2 { get; set; }
        [Pos(3)]
        public N4_OtherPayerCity_State_ZIPCode_2 N4_OtherPayerCity_State_ZIPCode_2 { get; set; }
        [Pos(4)]
        public DTP_ClaimCheckorRemittanceDate_2 DTP_ClaimCheckorRemittanceDate_2 { get; set; }
        [Pos(5)]
        public All_REF_10 All_REF_10 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",PR,")]
    public class X12_ID_98_8
    {
    }
    
    [Serializable()]
    [All()]
    public class All_REF_10
    {
        
        [ListCount(2)]
        [Pos(1)]
        public List<REF_OtherPayerSecondaryIdentifier_2> REF_OtherPayerSecondaryIdentifier_2 { get; set; }
        [Pos(2)]
        public REF_OtherPayerPriorAuthorizationNumber_2 REF_OtherPayerPriorAuthorizationNumber_2 { get; set; }
        [Pos(3)]
        public REF_OtherPayerReferralNumber_2 REF_OtherPayerReferralNumber_2 { get; set; }
        [Pos(4)]
        public REF_OtherPayerClaimAdjustmentIndicator_2 REF_OtherPayerClaimAdjustmentIndicator_2 { get; set; }
        [Pos(5)]
        public REF_OtherPayerClaimControlNumber_2 REF_OtherPayerClaimControlNumber_2 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",2U,EI,FY,NF,")]
    public class X12_ID_128_9
    {
    }
    
    [Serializable()]
    [EdiCodes(",T4,")]
    public class X12_ID_128_28
    {
    }
    
    [Serializable()]
    [EdiCodes(",F8,")]
    public class X12_ID_128_16
    {
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_16))]
    public class REF_OtherPayerClaimControlNumber_2
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_16))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string OtherPayersClaimControlNumber_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        [Pos(4)]
        public C040_ReferenceIdentifier_79 ReferenceIdentifier_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C040_ReferenceIdentifier_79")]
    public class C040_ReferenceIdentifier_79
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_28))]
    public class REF_OtherPayerClaimAdjustmentIndicator_2
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_28))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string OtherPayerClaimAdjustmentIndicator_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        [Pos(4)]
        public C040_ReferenceIdentifier_78 ReferenceIdentifier_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C040_ReferenceIdentifier_78")]
    public class C040_ReferenceIdentifier_78
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_14))]
    public class REF_OtherPayerReferralNumber_2
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_14))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string OtherPayerPriorAuthorizationorReferralNumber_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        [Pos(4)]
        public C040_ReferenceIdentifier_77 ReferenceIdentifier_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C040_ReferenceIdentifier_77")]
    public class C040_ReferenceIdentifier_77
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_15))]
    public class REF_OtherPayerPriorAuthorizationNumber_2
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_15))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string OtherPayerPriorAuthorizationNumber_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        [Pos(4)]
        public C040_ReferenceIdentifier_76 ReferenceIdentifier_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C040_ReferenceIdentifier_76")]
    public class C040_ReferenceIdentifier_76
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_9))]
    public class REF_OtherPayerSecondaryIdentifier_2
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_9))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string OtherPayerSecondaryIdentifier_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        [Pos(4)]
        public C040_ReferenceIdentifier_75 ReferenceIdentifier_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C040_ReferenceIdentifier_75")]
    public class C040_ReferenceIdentifier_75
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_18), typeof(X12_ID_1250))]
    public class DTP_ClaimCheckorRemittanceDate_2
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374_18))]
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
        public string AdjudicationorPaymentDate_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("N4")]
    public class N4_OtherPayerCity_State_ZIPCode_2
    {
        
        [Required]
        [StringLength(2, 30)]
        [DataElement("19", typeof(X12_AN))]
        [Pos(1)]
        public string OtherPayerCityName_01 { get; set; }
        [StringLength(2, 2)]
        [DataElement("156", typeof(X12_ID))]
        [Pos(2)]
        public string OtherPayerStateorProvinceCode_02 { get; set; }
        [StringLength(3, 15)]
        [DataElement("116", typeof(X12_ID))]
        [Pos(3)]
        public string OtherPayerPostalZoneorZIPCode_03 { get; set; }
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
    [Segment("N3")]
    public class N3_OtherPayerAddress_2
    {
        
        [Required]
        [StringLength(1, 55)]
        [DataElement("166", typeof(X12_AN))]
        [Pos(1)]
        public string OtherPayerAddressLine_01 { get; set; }
        [StringLength(1, 55)]
        [DataElement("166", typeof(X12_AN))]
        [Pos(2)]
        public string OtherPayerAddressLine_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_8), typeof(X12_ID_1065_2))]
    public class NM1_OtherPayerName_2
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98_8))]
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        [Required]
        [DataElement("1065", typeof(X12_ID_1065_2))]
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        [Required]
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(3)]
        public string OtherPayerOrganizationName_03 { get; set; }
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
        [Required]
        [DataElement("66", typeof(X12_ID_66_4))]
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        [Required]
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(9)]
        public string OtherPayerPrimaryIdentifier_09 { get; set; }
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
    [EdiCodes(",PI,XV,")]
    public class X12_ID_66_4
    {
    }
    
    [Serializable()]
    [Group("NM1")]
    public class Loop_2330A_2
    {
        
        [Required]
        [Pos(1)]
        public NM1_OtherSubscriberName_2 NM1_OtherSubscriberName_2 { get; set; }
        [Pos(2)]
        public N3_OtherSubscriberAddress_2 N3_OtherSubscriberAddress_2 { get; set; }
        [Pos(3)]
        public N4_OtherSubscriberCity_State_ZIPCode_2 N4_OtherSubscriberCity_State_ZIPCode_2 { get; set; }
        [Pos(4)]
        public REF_OtherSubscriberSecondaryIdentification_2 REF_OtherSubscriberSecondaryIdentification_2 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",IL,")]
    public class X12_ID_98_7
    {
    }
    
    [Serializable()]
    [EdiCodes(",SY,")]
    public class X12_ID_128_7
    {
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_7))]
    public class REF_OtherSubscriberSecondaryIdentification_2
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_7))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string OtherInsuredAdditionalIdentifier_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        [Pos(4)]
        public C040_ReferenceIdentifier_74 ReferenceIdentifier_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C040_ReferenceIdentifier_74")]
    public class C040_ReferenceIdentifier_74
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("N4")]
    public class N4_OtherSubscriberCity_State_ZIPCode_2
    {
        
        [Required]
        [StringLength(2, 30)]
        [DataElement("19", typeof(X12_AN))]
        [Pos(1)]
        public string OtherSubscriberCityName_01 { get; set; }
        [StringLength(2, 2)]
        [DataElement("156", typeof(X12_ID))]
        [Pos(2)]
        public string OtherSubscriberStateorProvinceCode_02 { get; set; }
        [StringLength(3, 15)]
        [DataElement("116", typeof(X12_ID))]
        [Pos(3)]
        public string OtherSubscriberPostalZoneorZIPCode_03 { get; set; }
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
    [Segment("N3")]
    public class N3_OtherSubscriberAddress_2
    {
        
        [Required]
        [StringLength(1, 55)]
        [DataElement("166", typeof(X12_AN))]
        [Pos(1)]
        public string OtherInsuredAddressLine_01 { get; set; }
        [StringLength(1, 55)]
        [DataElement("166", typeof(X12_AN))]
        [Pos(2)]
        public string OtherInsuredAddressLine_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_7), typeof(X12_ID_1065))]
    public class NM1_OtherSubscriberName_2
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98_7))]
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
        public string OtherInsuredLastName_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1036", typeof(X12_AN))]
        [Pos(4)]
        public string OtherInsuredFirstName_04 { get; set; }
        [StringLength(1, 25)]
        [DataElement("1037", typeof(X12_AN))]
        [Pos(5)]
        public string OtherInsuredMiddleName_05 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1038", typeof(X12_AN))]
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1039", typeof(X12_AN))]
        [Pos(7)]
        public string OtherInsuredNameSuffix_07 { get; set; }
        [Required]
        [DataElement("66", typeof(X12_ID_66_5))]
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        [Required]
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(9)]
        public string OtherInsuredIdentifier_09 { get; set; }
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
    [EdiCodes(",II,MI,")]
    public class X12_ID_66_5
    {
    }
    
    [Serializable()]
    [Segment("MOA")]
    public class MOA_OutpatientAdjudicationInformation_2
    {
        
        [StringLength(1, 10)]
        [DataElement("954", typeof(X12_R))]
        [Pos(1)]
        public string ReimbursementRate_01 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(2)]
        public string HCPCSPayableAmount_02 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(3)]
        public string ClaimPaymentRemarkCode_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ClaimPaymentRemarkCode_04 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(5)]
        public string ClaimPaymentRemarkCode_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ClaimPaymentRemarkCode_06 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(7)]
        public string ClaimPaymentRemarkCode_07 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(8)]
        public string EndStageRenalDiseasePaymentAmount_08 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(9)]
        public string NonPayableProfessionalComponentBilledAmount_09 { get; set; }
    }
    
    [Serializable()]
    [Segment("OI", typeof(X12_ID_1032_2), typeof(X12_ID_1383))]
    public class OI_OtherInsuranceCoverageInformation_2
    {
        
        [DataElement("1032", typeof(X12_ID_1032_2))]
        [Pos(1)]
        public string ClaimFilingIndicatorCode_01 { get; set; }
        [DataElement("1383", typeof(X12_ID_1383))]
        [Pos(2)]
        public string ClaimSubmissionReasonCode_02 { get; set; }
        [Required]
        [DataElement("1073", typeof(X12_ID_1073_4))]
        [Pos(3)]
        public string BenefitsAssignmentCertificationIndicator_03 { get; set; }
        [DataElement("1351", typeof(X12_ID_1351))]
        [Pos(4)]
        public string PatientSignatureSourceCode_04 { get; set; }
        [DataElement("1360", typeof(X12_ID_1360))]
        [Pos(5)]
        public string ProviderAgreementCode_05 { get; set; }
        [Required]
        [DataElement("1363", typeof(X12_ID_1363))]
        [Pos(6)]
        public string ReleaseofInformationCode_06 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",P,")]
    public class X12_ID_1351
    {
    }
    
    [Serializable()]
    [EdiCodes(",I,Y,")]
    public class X12_ID_1363
    {
    }
    
    [Serializable()]
    [All()]
    public class All_AMT_3
    {
        
        [Pos(1)]
        public AMT_CoordinationofBenefits_COB_PayerPaidAmount_2 AMT_CoordinationofBenefits_COB_PayerPaidAmount_2 { get; set; }
        [Pos(2)]
        public AMT_CoordinationofBenefits_COB_TotalNon_coveredAmount_2 AMT_CoordinationofBenefits_COB_TotalNon_coveredAmount_2 { get; set; }
        [Pos(3)]
        public AMT_RemainingPatientLiability_3 AMT_RemainingPatientLiability_3 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",D,")]
    public class X12_ID_522_2
    {
    }
    
    [Serializable()]
    [EdiCodes(",A8,")]
    public class X12_ID_522_3
    {
    }
    
    [Serializable()]
    [Segment("AMT", typeof(X12_ID_522_4))]
    public class AMT_RemainingPatientLiability_3
    {
        
        [Required]
        [DataElement("522", typeof(X12_ID_522_4))]
        [Pos(1)]
        public string AmountQualifierCode_01 { get; set; }
        [Required]
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(2)]
        public string RemainingPatientLiability_02 { get; set; }
        [DataElement("478", typeof(X12_ID_478))]
        [Pos(3)]
        public string CreditDebitFlagCode_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("AMT", typeof(X12_ID_522_3))]
    public class AMT_CoordinationofBenefits_COB_TotalNon_coveredAmount_2
    {
        
        [Required]
        [DataElement("522", typeof(X12_ID_522_3))]
        [Pos(1)]
        public string AmountQualifierCode_01 { get; set; }
        [Required]
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(2)]
        public string NonCoveredChargeAmount_02 { get; set; }
        [DataElement("478", typeof(X12_ID_478))]
        [Pos(3)]
        public string CreditDebitFlagCode_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("AMT", typeof(X12_ID_522_2))]
    public class AMT_CoordinationofBenefits_COB_PayerPaidAmount_2
    {
        
        [Required]
        [DataElement("522", typeof(X12_ID_522_2))]
        [Pos(1)]
        public string AmountQualifierCode_01 { get; set; }
        [Required]
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(2)]
        public string PayerPaidAmount_02 { get; set; }
        [DataElement("478", typeof(X12_ID_478))]
        [Pos(3)]
        public string CreditDebitFlagCode_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("CAS", typeof(X12_ID_1033))]
    public class CAS_ClaimLevelAdjustments_2
    {
        
        [Required]
        [DataElement("1033", typeof(X12_ID_1033))]
        [Pos(1)]
        public string ClaimAdjustmentGroupCode_01 { get; set; }
        [Required]
        [StringLength(1, 5)]
        [DataElement("1034", typeof(X12_ID))]
        [Pos(2)]
        public string AdjustmentReasonCode_02 { get; set; }
        [Required]
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(3)]
        public string AdjustmentAmount_03 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(4)]
        public string AdjustmentQuantity_04 { get; set; }
        [StringLength(1, 5)]
        [DataElement("1034", typeof(X12_ID))]
        [Pos(5)]
        public string AdjustmentReasonCode_05 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(6)]
        public string AdjustmentAmount_06 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(7)]
        public string AdjustmentQuantity_07 { get; set; }
        [StringLength(1, 5)]
        [DataElement("1034", typeof(X12_ID))]
        [Pos(8)]
        public string AdjustmentReasonCode_08 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(9)]
        public string AdjustmentAmount_09 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(10)]
        public string AdjustmentQuantity_10 { get; set; }
        [StringLength(1, 5)]
        [DataElement("1034", typeof(X12_ID))]
        [Pos(11)]
        public string AdjustmentReasonCode_11 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(12)]
        public string AdjustmentAmount_12 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(13)]
        public string AdjustmentQuantity_13 { get; set; }
        [StringLength(1, 5)]
        [DataElement("1034", typeof(X12_ID))]
        [Pos(14)]
        public string AdjustmentReasonCode_14 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(15)]
        public string AdjustmentAmount_15 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(16)]
        public string AdjustmentQuantity_16 { get; set; }
        [StringLength(1, 5)]
        [DataElement("1034", typeof(X12_ID))]
        [Pos(17)]
        public string AdjustmentReasonCode_17 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(18)]
        public string AdjustmentAmount_18 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(19)]
        public string AdjustmentQuantity_19 { get; set; }
    }
    
    [Serializable()]
    [Segment("SBR", typeof(X12_ID_1138), typeof(X12_ID_1069_3))]
    public class SBR_OtherSubscriberInformation_2
    {
        
        [Required]
        [DataElement("1138", typeof(X12_ID_1138))]
        [Pos(1)]
        public string PayerResponsibilitySequenceNumberCode_01 { get; set; }
        [Required]
        [DataElement("1069", typeof(X12_ID_1069_3))]
        [Pos(2)]
        public string IndividualRelationshipCode_02 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(3)]
        public string InsuredGrouporPolicyNumber_03 { get; set; }
        [StringLength(1, 60)]
        [DataElement("93", typeof(X12_AN))]
        [Pos(4)]
        public string OtherInsuredGroupName_04 { get; set; }
        [DataElement("1336", typeof(X12_ID_1336))]
        [Pos(5)]
        public string InsuranceTypeCode_05 { get; set; }
        [DataElement("1143", typeof(X12_ID_1143))]
        [Pos(6)]
        public string CoordinationofBenefitsCode_06 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(7)]
        public string YesNoConditionorResponseCode_07 { get; set; }
        [DataElement("584", typeof(X12_ID_584))]
        [Pos(8)]
        public string EmploymentStatusCode_08 { get; set; }
        [DataElement("1032", typeof(X12_ID_1032))]
        [Pos(9)]
        public string ClaimFilingIndicatorCode_09 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",12,13,14,15,16,41,42,43,47,")]
    public class X12_ID_1336
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,")]
    public class X12_ID_1143
    {
    }
    
    [Serializable()]
    [EdiCodes(@",00,AA,AB,AC,AD,AE,AF,AG,AH,AI,AJ,AO,AP,AQ,AS,AT,AU,CA,CC,CO,CT,DC,DD,DI,DQ,DR,DS,EO,FA,FB,FC,FO,FT,HD,IA,IR,L1,L2,L3,L4,L5,L6,L7,LA,LE,LF,LM,LO,LS,LU,LW,LX,NE,OS,OT,PA,PC,PE,PM,PN,PR,PT,PV,PW,RA,RB,RC,RD,RE,RI,RM,RP,RR,RT,RU,RW,SA,SB,SE,SL,SU,TE,TF,TM,TN,TP,TR,UK,VO,XD,ZZ,")]
    public class X12_ID_584
    {
    }
    
    [Serializable()]
    [EdiCodes(",11,12,13,14,15,16,17,AM,BL,CH,CI,DS,FI,HM,LM,MA,MB,MC,OF,TV,VA,WC,ZZ,")]
    public class X12_ID_1032
    {
    }
    
    [Serializable()]
    [All()]
    public class All_NM1_7
    {
        
        [ListCount(2)]
        [Pos(1)]
        public List<Loop_2310A_2> Loop_2310A_2 { get; set; }
        [Pos(2)]
        public Loop_2310B_2 Loop_2310B_2 { get; set; }
        [Pos(3)]
        public Loop_2310C_2 Loop_2310C_2 { get; set; }
        [Pos(4)]
        public Loop_2310D_2 Loop_2310D_2 { get; set; }
        [Pos(5)]
        public Loop_2310E_2 Loop_2310E_2 { get; set; }
        [Pos(6)]
        public Loop_2310F_2 Loop_2310F_2 { get; set; }
    }
    
    [Serializable()]
    [Group("NM1")]
    public class Loop_2310F_2
    {
        
        [Required]
        [Pos(1)]
        public NM1_AmbulanceDrop_offLocation_3 NM1_AmbulanceDrop_offLocation_3 { get; set; }
        [Required]
        [Pos(2)]
        public N3_AmbulanceDrop_offLocationAddress_3 N3_AmbulanceDrop_offLocationAddress_3 { get; set; }
        [Required]
        [Pos(3)]
        public N4_AmbulanceDrop_offLocationCity_State_ZipCode_3 N4_AmbulanceDrop_offLocationCity_State_ZipCode_3 { get; set; }
    }
    
    [Serializable()]
    [Segment("N4")]
    public class N4_AmbulanceDrop_offLocationCity_State_ZipCode_3
    {
        
        [Required]
        [StringLength(2, 30)]
        [DataElement("19", typeof(X12_AN))]
        [Pos(1)]
        public string AmbulanceDropoffCityName_01 { get; set; }
        [StringLength(2, 2)]
        [DataElement("156", typeof(X12_ID))]
        [Pos(2)]
        public string AmbulanceDropoffStateorProvinceCode_02 { get; set; }
        [StringLength(3, 15)]
        [DataElement("116", typeof(X12_ID))]
        [Pos(3)]
        public string AmbulanceDropoffPostalZoneorZIPCode_03 { get; set; }
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
    [Segment("N3")]
    public class N3_AmbulanceDrop_offLocationAddress_3
    {
        
        [Required]
        [StringLength(1, 55)]
        [DataElement("166", typeof(X12_AN))]
        [Pos(1)]
        public string AmbulanceDropoffAddressLine_01 { get; set; }
        [StringLength(1, 55)]
        [DataElement("166", typeof(X12_AN))]
        [Pos(2)]
        public string AmbulanceDropoffAddressLine_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_14), typeof(X12_ID_1065_2))]
    public class NM1_AmbulanceDrop_offLocation_3
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98_14))]
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        [Required]
        [DataElement("1065", typeof(X12_ID_1065_2))]
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(3)]
        public string AmbulanceDropoffLocation_03 { get; set; }
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
    public class Loop_2310E_2
    {
        
        [Required]
        [Pos(1)]
        public NM1_AmbulancePick_upLocation_3 NM1_AmbulancePick_upLocation_3 { get; set; }
        [Required]
        [Pos(2)]
        public N3_AmbulancePick_upLocationAddress_3 N3_AmbulancePick_upLocationAddress_3 { get; set; }
        [Required]
        [Pos(3)]
        public N4_AmbulancePick_upLocationCity_State_ZipCode_3 N4_AmbulancePick_upLocationCity_State_ZipCode_3 { get; set; }
    }
    
    [Serializable()]
    [Segment("N4")]
    public class N4_AmbulancePick_upLocationCity_State_ZipCode_3
    {
        
        [Required]
        [StringLength(2, 30)]
        [DataElement("19", typeof(X12_AN))]
        [Pos(1)]
        public string AmbulancePickupCityName_01 { get; set; }
        [StringLength(2, 2)]
        [DataElement("156", typeof(X12_ID))]
        [Pos(2)]
        public string AmbulancePickupStateorProvinceCode_02 { get; set; }
        [StringLength(3, 15)]
        [DataElement("116", typeof(X12_ID))]
        [Pos(3)]
        public string AmbulancePickupPostalZoneorZIPCode_03 { get; set; }
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
    [Segment("N3")]
    public class N3_AmbulancePick_upLocationAddress_3
    {
        
        [Required]
        [StringLength(1, 55)]
        [DataElement("166", typeof(X12_AN))]
        [Pos(1)]
        public string AmbulancePickupAddressLine_01 { get; set; }
        [StringLength(1, 55)]
        [DataElement("166", typeof(X12_AN))]
        [Pos(2)]
        public string AmbulancePickupAddressLine_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_13), typeof(X12_ID_1065_2))]
    public class NM1_AmbulancePick_upLocation_3
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
    public class Loop_2310D_2
    {
        
        [Required]
        [Pos(1)]
        public NM1_SupervisingProviderName_3 NM1_SupervisingProviderName_3 { get; set; }
        [ListCount(4)]
        [Pos(2)]
        public List<REF_SupervisingProviderSecondaryIdentification_3> REF_SupervisingProviderSecondaryIdentification_3 { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_26))]
    public class REF_SupervisingProviderSecondaryIdentification_3
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_26))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string SupervisingProviderSecondaryIdentifier_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        [Pos(4)]
        public C040_ReferenceIdentifier_73 ReferenceIdentifier_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C040_ReferenceIdentifier_73")]
    public class C040_ReferenceIdentifier_73
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_12), typeof(X12_ID_1065_3))]
    public class NM1_SupervisingProviderName_3
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98_12))]
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
        public string SupervisingProviderLastName_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1036", typeof(X12_AN))]
        [Pos(4)]
        public string SupervisingProviderFirstName_04 { get; set; }
        [StringLength(1, 25)]
        [DataElement("1037", typeof(X12_AN))]
        [Pos(5)]
        public string SupervisingProviderMiddleNameorInitial_05 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1038", typeof(X12_AN))]
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1039", typeof(X12_AN))]
        [Pos(7)]
        public string SupervisingProviderNameSuffix_07 { get; set; }
        [DataElement("66", typeof(X12_ID_66_2))]
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(9)]
        public string SupervisingProviderIdentifier_09 { get; set; }
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
    public class Loop_2310C_2
    {
        
        [Required]
        [Pos(1)]
        public NM1_ServiceFacilityLocationName_2 NM1_ServiceFacilityLocationName_2 { get; set; }
        [Required]
        [Pos(2)]
        public N3_ServiceFacilityLocationAddress_3 N3_ServiceFacilityLocationAddress_3 { get; set; }
        [Required]
        [Pos(3)]
        public N4_ServiceFacilityLocationCity_State_ZIPCode_3 N4_ServiceFacilityLocationCity_State_ZIPCode_3 { get; set; }
        [ListCount(3)]
        [Pos(4)]
        public List<REF_ServiceFacilityLocationSecondaryIdentification_3> REF_ServiceFacilityLocationSecondaryIdentification_3 { get; set; }
        [Pos(5)]
        public PER_ServiceFacilityContactInformation_2 PER_ServiceFacilityContactInformation_2 { get; set; }
    }
    
    [Serializable()]
    [Segment("PER", typeof(X12_ID_366))]
    public class PER_ServiceFacilityContactInformation_2
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
        [DataElement("365", typeof(X12_ID_365_3))]
        [Pos(3)]
        public string CommunicationNumberQualifier_03 { get; set; }
        [Required]
        [StringLength(1, 256)]
        [DataElement("364", typeof(X12_AN))]
        [Pos(4)]
        public string CommunicationNumber_04 { get; set; }
        [DataElement("365", typeof(X12_ID_365_4))]
        [Pos(5)]
        public string CommunicationNumberQualifier_05 { get; set; }
        [StringLength(1, 256)]
        [DataElement("364", typeof(X12_AN))]
        [Pos(6)]
        public string CommunicationNumber_06 { get; set; }
        [DataElement("365", typeof(X12_ID_365_5))]
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
    public class X12_ID_365_3
    {
    }
    
    [Serializable()]
    [EdiCodes(",EX,")]
    public class X12_ID_365_4
    {
    }
    
    [Serializable()]
    [EdiCodes(",AA,AB,AC,AD,AE,AP,AS,AU,BN,BT,CA,CP,DN,EA,ED,EM,EX,FT,FU,FX,HF,HP,IT,MN,NP,OF,OT" +
        ",PA,PC,PP,PS,SP,TE,TL,TM,TN,TX,UR,VM,WC,WF,WP,")]
    public class X12_ID_365_5
    {
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_27))]
    public class REF_ServiceFacilityLocationSecondaryIdentification_3
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_27))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string LaboratoryorFacilitySecondaryIdentifier_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        [Pos(4)]
        public C040_ReferenceIdentifier_72 ReferenceIdentifier_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C040_ReferenceIdentifier_72")]
    public class C040_ReferenceIdentifier_72
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("N4")]
    public class N4_ServiceFacilityLocationCity_State_ZIPCode_3
    {
        
        [Required]
        [StringLength(2, 30)]
        [DataElement("19", typeof(X12_AN))]
        [Pos(1)]
        public string LaboratoryorFacilityCityName_01 { get; set; }
        [StringLength(2, 2)]
        [DataElement("156", typeof(X12_ID))]
        [Pos(2)]
        public string LaboratoryorFacilityStateorProvinceCode_02 { get; set; }
        [StringLength(3, 15)]
        [DataElement("116", typeof(X12_ID))]
        [Pos(3)]
        public string LaboratoryorFacilityPostalZoneorZIPCode_03 { get; set; }
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
    [Segment("N3")]
    public class N3_ServiceFacilityLocationAddress_3
    {
        
        [Required]
        [StringLength(1, 55)]
        [DataElement("166", typeof(X12_AN))]
        [Pos(1)]
        public string LaboratoryorFacilityAddressLine_01 { get; set; }
        [StringLength(1, 55)]
        [DataElement("166", typeof(X12_AN))]
        [Pos(2)]
        public string LaboratoryorFacilityAddressLine_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_11), typeof(X12_ID_1065_2))]
    public class NM1_ServiceFacilityLocationName_2
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98_11))]
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        [Required]
        [DataElement("1065", typeof(X12_ID_1065_2))]
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        [Required]
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(3)]
        public string LaboratoryorFacilityName_03 { get; set; }
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
        [DataElement("66", typeof(X12_ID_66_2))]
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(9)]
        public string LaboratoryorFacilityPrimaryIdentifier_09 { get; set; }
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
    public class Loop_2310B_2
    {
        
        [Required]
        [Pos(1)]
        public NM1_RenderingProviderName_3 NM1_RenderingProviderName_3 { get; set; }
        [Pos(2)]
        public PRV_RenderingProviderSpecialtyInformation_3 PRV_RenderingProviderSpecialtyInformation_3 { get; set; }
        [ListCount(4)]
        [Pos(3)]
        public List<REF_RenderingProviderSecondaryIdentification_3> REF_RenderingProviderSecondaryIdentification_3 { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_26))]
    public class REF_RenderingProviderSecondaryIdentification_3
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_26))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string RenderingProviderSecondaryIdentifier_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        [Pos(4)]
        public C040_ReferenceIdentifier_71 ReferenceIdentifier_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C040_ReferenceIdentifier_71")]
    public class C040_ReferenceIdentifier_71
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("PRV", typeof(X12_ID_1221_2), typeof(X12_ID_128))]
    public class PRV_RenderingProviderSpecialtyInformation_3
    {
        
        [Required]
        [DataElement("1221", typeof(X12_ID_1221_2))]
        [Pos(1)]
        public string ProviderCode_01 { get; set; }
        [Required]
        [DataElement("128", typeof(X12_ID_128))]
        [Pos(2)]
        public string ReferenceIdentificationQualifier_02 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(3)]
        public string ProviderTaxonomyCode_03 { get; set; }
        [StringLength(2, 2)]
        [DataElement("156", typeof(X12_ID))]
        [Pos(4)]
        public string StateorProvinceCode_04 { get; set; }
        [Pos(5)]
        public C035_ProviderSpecialtyInformation_4 ProviderSpecialtyInformation_05 { get; set; }
        [DataElement("1223", typeof(X12_ID_1223))]
        [Pos(6)]
        public string ProviderOrganizationCode_06 { get; set; }
    }
    
    [Serializable()]
    [Composite("C035_ProviderSpecialtyInformation_4")]
    public class C035_ProviderSpecialtyInformation_4
    {
        
        [Required]
        [DataElement("1222", typeof(X12_ID_1222))]
        [Pos(1)]
        public string ProviderSpecialtyCode_01 { get; set; }
        [DataElement("559", typeof(X12_ID_559))]
        [Pos(2)]
        public string AgencyQualifierCode_02 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(3)]
        public string YesNoConditionorResponseCode_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_10), typeof(X12_ID_1065))]
    public class NM1_RenderingProviderName_3
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
        public string RenderingProviderLastorOrganizationName_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1036", typeof(X12_AN))]
        [Pos(4)]
        public string RenderingProviderFirstName_04 { get; set; }
        [StringLength(1, 25)]
        [DataElement("1037", typeof(X12_AN))]
        [Pos(5)]
        public string RenderingProviderMiddleNameorInitial_05 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1038", typeof(X12_AN))]
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1039", typeof(X12_AN))]
        [Pos(7)]
        public string RenderingProviderNameSuffix_07 { get; set; }
        [DataElement("66", typeof(X12_ID_66_2))]
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(9)]
        public string RenderingProviderIdentifier_09 { get; set; }
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
    public class Loop_2310A_2
    {
        
        [Required]
        [Pos(1)]
        public NM1_ReferringProviderName_3 NM1_ReferringProviderName_3 { get; set; }
        [ListCount(3)]
        [Pos(2)]
        public List<REF_ReferringProviderSecondaryIdentification_3> REF_ReferringProviderSecondaryIdentification_3 { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_25))]
    public class REF_ReferringProviderSecondaryIdentification_3
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_25))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferringProviderSecondaryIdentifier_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        [Pos(4)]
        public C040_ReferenceIdentifier_70 ReferenceIdentifier_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C040_ReferenceIdentifier_70")]
    public class C040_ReferenceIdentifier_70
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_9), typeof(X12_ID_1065_3))]
    public class NM1_ReferringProviderName_3
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
        public string ReferringProviderLastName_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1036", typeof(X12_AN))]
        [Pos(4)]
        public string ReferringProviderFirstName_04 { get; set; }
        [StringLength(1, 25)]
        [DataElement("1037", typeof(X12_AN))]
        [Pos(5)]
        public string ReferringProviderMiddleNameorInitial_05 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1038", typeof(X12_AN))]
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1039", typeof(X12_AN))]
        [Pos(7)]
        public string ReferringProviderNameSuffix_07 { get; set; }
        [DataElement("66", typeof(X12_ID_66_2))]
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(9)]
        public string ReferringProviderIdentifier_09 { get; set; }
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
    [Segment("HCP", typeof(X12_ID_1473))]
    public class HCP_ClaimPricing_RepricingInformation_2
    {
        
        [Required]
        [DataElement("1473", typeof(X12_ID_1473))]
        [Pos(1)]
        public string PricingMethodology_01 { get; set; }
        [Required]
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(2)]
        public string RepricedAllowedAmount_02 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(3)]
        public string RepricedSavingAmount_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string RepricingOrganizationIdentifier_04 { get; set; }
        [StringLength(1, 9)]
        [DataElement("118", typeof(X12_R))]
        [Pos(5)]
        public string RepricingPerDiemorFlatRateAmount_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string RepricedApprovedAmbulatoryPatientGroupCode_06 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(7)]
        public string RepricedApprovedAmbulatoryPatientGroupAmount_07 { get; set; }
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(8)]
        public string ProductServiceID_08 { get; set; }
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(9)]
        public string ProductServiceIDQualifier_09 { get; set; }
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(10)]
        public string ProductServiceID_10 { get; set; }
        [DataElement("355", typeof(X12_ID_355_2))]
        [Pos(11)]
        public string UnitorBasisforMeasurementCode_11 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(12)]
        public string Quantity_12 { get; set; }
        [DataElement("901", typeof(X12_ID_901))]
        [Pos(13)]
        public string RejectReasonCode_13 { get; set; }
        [DataElement("1526", typeof(X12_ID_1526))]
        [Pos(14)]
        public string PolicyComplianceCode_14 { get; set; }
        [DataElement("1527", typeof(X12_ID_1527))]
        [Pos(15)]
        public string ExceptionCode_15 { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_HI_2
    {
        
        [Required]
        [Pos(1)]
        public HI_HealthCareDiagnosisCode_2 HI_HealthCareDiagnosisCode_2 { get; set; }
        [Pos(2)]
        public HI_AnesthesiaRelatedProcedure_2 HI_AnesthesiaRelatedProcedure_2 { get; set; }
        [ListCount(2)]
        [Pos(3)]
        public List<HI_ConditionInformation_2> HI_ConditionInformation_2 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",ABK,BK,")]
    public class X12_ID_1270_2
    {
    }
    
    [Serializable()]
    [EdiCodes(",ABF,BF,")]
    public class X12_ID_1270_3
    {
    }
    
    [Serializable()]
    [EdiCodes(",BP,")]
    public class X12_ID_1270_4
    {
    }
    
    [Serializable()]
    [EdiCodes(",BO,")]
    public class X12_ID_1270_5
    {
    }
    
    [Serializable()]
    [EdiCodes(",BG,")]
    public class X12_ID_1270_6
    {
    }
    
    [Serializable()]
    [Segment("HI", typeof(X12_ID_1270_6), typeof(X12_ID_1270_6))]
    public class HI_ConditionInformation_2
    {
        
        [Required]
        [Pos(1)]
        public C022_HealthCareCodeInformation_61 HealthCareCodeInformation_01 { get; set; }
        [Pos(2)]
        public C022_HealthCareCodeInformation_62 HealthCareCodeInformation_02 { get; set; }
        [Pos(3)]
        public C022_HealthCareCodeInformation_63 HealthCareCodeInformation_03 { get; set; }
        [Pos(4)]
        public C022_HealthCareCodeInformation_64 HealthCareCodeInformation_04 { get; set; }
        [Pos(5)]
        public C022_HealthCareCodeInformation_65 HealthCareCodeInformation_05 { get; set; }
        [Pos(6)]
        public C022_HealthCareCodeInformation_66 HealthCareCodeInformation_06 { get; set; }
        [Pos(7)]
        public C022_HealthCareCodeInformation_67 HealthCareCodeInformation_07 { get; set; }
        [Pos(8)]
        public C022_HealthCareCodeInformation_68 HealthCareCodeInformation_08 { get; set; }
        [Pos(9)]
        public C022_HealthCareCodeInformation_69 HealthCareCodeInformation_09 { get; set; }
        [Pos(10)]
        public C022_HealthCareCodeInformation_70 HealthCareCodeInformation_10 { get; set; }
        [Pos(11)]
        public C022_HealthCareCodeInformation_71 HealthCareCodeInformation_11 { get; set; }
        [Pos(12)]
        public C022_HealthCareCodeInformation_72 HealthCareCodeInformation_12 { get; set; }
    }
    
    [Serializable()]
    [Composite("C022_HealthCareCodeInformation_72")]
    public class C022_HealthCareCodeInformation_72
    {
        
        [Required]
        [DataElement("1270", typeof(X12_ID_1270_6))]
        [Pos(1)]
        public string CodeListQualifierCode_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(2)]
        public string ConditionCode_02 { get; set; }
        [DataElement("1250", typeof(X12_ID_1250_3))]
        [Pos(3)]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(4)]
        public string DateTimePeriod_04 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(5)]
        public string MonetaryAmount_05 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        public string Quantity_06 { get; set; }
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(7)]
        public string VersionIdentifier_07 { get; set; }
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(8)]
        public string IndustryCode_08 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(9)]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",CC,CD,CM,CQ,CY,D6,D8,DA,DB,DD,DDT,DT,DTD,DTS,EH,KA,MCY,MD,MM,RD,RD2,RD4,RD5,RD6," +
        "RD8,RDM,RDT,RMD,RMY,RTM,RTS,TC,TM,TQ,TR,TS,TT,TU,UN,YM,YMM,YY,")]
    public class X12_ID_1250_3
    {
    }
    
    [Serializable()]
    [Composite("C022_HealthCareCodeInformation_71")]
    public class C022_HealthCareCodeInformation_71
    {
        
        [Required]
        [DataElement("1270", typeof(X12_ID_1270_6))]
        [Pos(1)]
        public string CodeListQualifierCode_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(2)]
        public string ConditionCode_02 { get; set; }
        [DataElement("1250", typeof(X12_ID_1250_3))]
        [Pos(3)]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(4)]
        public string DateTimePeriod_04 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(5)]
        public string MonetaryAmount_05 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        public string Quantity_06 { get; set; }
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(7)]
        public string VersionIdentifier_07 { get; set; }
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(8)]
        public string IndustryCode_08 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(9)]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    [Serializable()]
    [Composite("C022_HealthCareCodeInformation_70")]
    public class C022_HealthCareCodeInformation_70
    {
        
        [Required]
        [DataElement("1270", typeof(X12_ID_1270_6))]
        [Pos(1)]
        public string CodeListQualifierCode_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(2)]
        public string ConditionCode_02 { get; set; }
        [DataElement("1250", typeof(X12_ID_1250_3))]
        [Pos(3)]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(4)]
        public string DateTimePeriod_04 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(5)]
        public string MonetaryAmount_05 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        public string Quantity_06 { get; set; }
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(7)]
        public string VersionIdentifier_07 { get; set; }
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(8)]
        public string IndustryCode_08 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(9)]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    [Serializable()]
    [Composite("C022_HealthCareCodeInformation_69")]
    public class C022_HealthCareCodeInformation_69
    {
        
        [Required]
        [DataElement("1270", typeof(X12_ID_1270_6))]
        [Pos(1)]
        public string CodeListQualifierCode_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(2)]
        public string ConditionCode_02 { get; set; }
        [DataElement("1250", typeof(X12_ID_1250_3))]
        [Pos(3)]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(4)]
        public string DateTimePeriod_04 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(5)]
        public string MonetaryAmount_05 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        public string Quantity_06 { get; set; }
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(7)]
        public string VersionIdentifier_07 { get; set; }
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(8)]
        public string IndustryCode_08 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(9)]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    [Serializable()]
    [Composite("C022_HealthCareCodeInformation_68")]
    public class C022_HealthCareCodeInformation_68
    {
        
        [Required]
        [DataElement("1270", typeof(X12_ID_1270_6))]
        [Pos(1)]
        public string CodeListQualifierCode_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(2)]
        public string ConditionCode_02 { get; set; }
        [DataElement("1250", typeof(X12_ID_1250_3))]
        [Pos(3)]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(4)]
        public string DateTimePeriod_04 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(5)]
        public string MonetaryAmount_05 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        public string Quantity_06 { get; set; }
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(7)]
        public string VersionIdentifier_07 { get; set; }
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(8)]
        public string IndustryCode_08 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(9)]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    [Serializable()]
    [Composite("C022_HealthCareCodeInformation_67")]
    public class C022_HealthCareCodeInformation_67
    {
        
        [Required]
        [DataElement("1270", typeof(X12_ID_1270_6))]
        [Pos(1)]
        public string CodeListQualifierCode_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(2)]
        public string ConditionCode_02 { get; set; }
        [DataElement("1250", typeof(X12_ID_1250_3))]
        [Pos(3)]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(4)]
        public string DateTimePeriod_04 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(5)]
        public string MonetaryAmount_05 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        public string Quantity_06 { get; set; }
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(7)]
        public string VersionIdentifier_07 { get; set; }
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(8)]
        public string IndustryCode_08 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(9)]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    [Serializable()]
    [Composite("C022_HealthCareCodeInformation_66")]
    public class C022_HealthCareCodeInformation_66
    {
        
        [Required]
        [DataElement("1270", typeof(X12_ID_1270_6))]
        [Pos(1)]
        public string CodeListQualifierCode_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(2)]
        public string ConditionCode_02 { get; set; }
        [DataElement("1250", typeof(X12_ID_1250_3))]
        [Pos(3)]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(4)]
        public string DateTimePeriod_04 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(5)]
        public string MonetaryAmount_05 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        public string Quantity_06 { get; set; }
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(7)]
        public string VersionIdentifier_07 { get; set; }
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(8)]
        public string IndustryCode_08 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(9)]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    [Serializable()]
    [Composite("C022_HealthCareCodeInformation_65")]
    public class C022_HealthCareCodeInformation_65
    {
        
        [Required]
        [DataElement("1270", typeof(X12_ID_1270_6))]
        [Pos(1)]
        public string CodeListQualifierCode_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(2)]
        public string ConditionCode_02 { get; set; }
        [DataElement("1250", typeof(X12_ID_1250_3))]
        [Pos(3)]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(4)]
        public string DateTimePeriod_04 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(5)]
        public string MonetaryAmount_05 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        public string Quantity_06 { get; set; }
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(7)]
        public string VersionIdentifier_07 { get; set; }
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(8)]
        public string IndustryCode_08 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(9)]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    [Serializable()]
    [Composite("C022_HealthCareCodeInformation_64")]
    public class C022_HealthCareCodeInformation_64
    {
        
        [Required]
        [DataElement("1270", typeof(X12_ID_1270_6))]
        [Pos(1)]
        public string CodeListQualifierCode_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(2)]
        public string ConditionCode_02 { get; set; }
        [DataElement("1250", typeof(X12_ID_1250_3))]
        [Pos(3)]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(4)]
        public string DateTimePeriod_04 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(5)]
        public string MonetaryAmount_05 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        public string Quantity_06 { get; set; }
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(7)]
        public string VersionIdentifier_07 { get; set; }
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(8)]
        public string IndustryCode_08 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(9)]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    [Serializable()]
    [Composite("C022_HealthCareCodeInformation_63")]
    public class C022_HealthCareCodeInformation_63
    {
        
        [Required]
        [DataElement("1270", typeof(X12_ID_1270_6))]
        [Pos(1)]
        public string CodeListQualifierCode_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(2)]
        public string ConditionCode_02 { get; set; }
        [DataElement("1250", typeof(X12_ID_1250_3))]
        [Pos(3)]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(4)]
        public string DateTimePeriod_04 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(5)]
        public string MonetaryAmount_05 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        public string Quantity_06 { get; set; }
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(7)]
        public string VersionIdentifier_07 { get; set; }
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(8)]
        public string IndustryCode_08 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(9)]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    [Serializable()]
    [Composite("C022_HealthCareCodeInformation_62")]
    public class C022_HealthCareCodeInformation_62
    {
        
        [Required]
        [DataElement("1270", typeof(X12_ID_1270_6))]
        [Pos(1)]
        public string CodeListQualifierCode_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(2)]
        public string ConditionCode_02 { get; set; }
        [DataElement("1250", typeof(X12_ID_1250_3))]
        [Pos(3)]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(4)]
        public string DateTimePeriod_04 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(5)]
        public string MonetaryAmount_05 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        public string Quantity_06 { get; set; }
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(7)]
        public string VersionIdentifier_07 { get; set; }
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(8)]
        public string IndustryCode_08 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(9)]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    [Serializable()]
    [Composite("C022_HealthCareCodeInformation_61")]
    public class C022_HealthCareCodeInformation_61
    {
        
        [Required]
        [DataElement("1270", typeof(X12_ID_1270_6))]
        [Pos(1)]
        public string CodeListQualifierCode_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(2)]
        public string ConditionCode_02 { get; set; }
        [DataElement("1250", typeof(X12_ID_1250_3))]
        [Pos(3)]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(4)]
        public string DateTimePeriod_04 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(5)]
        public string MonetaryAmount_05 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        public string Quantity_06 { get; set; }
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(7)]
        public string VersionIdentifier_07 { get; set; }
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(8)]
        public string IndustryCode_08 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(9)]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    [Serializable()]
    [Segment("HI", typeof(X12_ID_1270_4), typeof(X12_ID_1270_5))]
    public class HI_AnesthesiaRelatedProcedure_2
    {
        
        [Required]
        [Pos(1)]
        public C022_HealthCareCodeInformation_49 HealthCareCodeInformation_01 { get; set; }
        [Pos(2)]
        public C022_HealthCareCodeInformation_50 HealthCareCodeInformation_02 { get; set; }
        [Pos(3)]
        public C022_HealthCareCodeInformation_51 HealthCareCodeInformation_03 { get; set; }
        [Pos(4)]
        public C022_HealthCareCodeInformation_52 HealthCareCodeInformation_04 { get; set; }
        [Pos(5)]
        public C022_HealthCareCodeInformation_53 HealthCareCodeInformation_05 { get; set; }
        [Pos(6)]
        public C022_HealthCareCodeInformation_54 HealthCareCodeInformation_06 { get; set; }
        [Pos(7)]
        public C022_HealthCareCodeInformation_55 HealthCareCodeInformation_07 { get; set; }
        [Pos(8)]
        public C022_HealthCareCodeInformation_56 HealthCareCodeInformation_08 { get; set; }
        [Pos(9)]
        public C022_HealthCareCodeInformation_57 HealthCareCodeInformation_09 { get; set; }
        [Pos(10)]
        public C022_HealthCareCodeInformation_58 HealthCareCodeInformation_10 { get; set; }
        [Pos(11)]
        public C022_HealthCareCodeInformation_59 HealthCareCodeInformation_11 { get; set; }
        [Pos(12)]
        public C022_HealthCareCodeInformation_60 HealthCareCodeInformation_12 { get; set; }
    }
    
    [Serializable()]
    [Composite("C022_HealthCareCodeInformation_60")]
    public class C022_HealthCareCodeInformation_60
    {
        
        [Required]
        [DataElement("1270", typeof(X12_ID_1270))]
        [Pos(1)]
        public string CodeListQualifierCode_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(2)]
        public string IndustryCode_02 { get; set; }
        [DataElement("1250", typeof(X12_ID_1250_3))]
        [Pos(3)]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(4)]
        public string DateTimePeriod_04 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(5)]
        public string MonetaryAmount_05 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        public string Quantity_06 { get; set; }
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(7)]
        public string VersionIdentifier_07 { get; set; }
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(8)]
        public string IndustryCode_08 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(9)]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    [Serializable()]
    [Composite("C022_HealthCareCodeInformation_59")]
    public class C022_HealthCareCodeInformation_59
    {
        
        [Required]
        [DataElement("1270", typeof(X12_ID_1270))]
        [Pos(1)]
        public string CodeListQualifierCode_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(2)]
        public string IndustryCode_02 { get; set; }
        [DataElement("1250", typeof(X12_ID_1250_3))]
        [Pos(3)]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(4)]
        public string DateTimePeriod_04 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(5)]
        public string MonetaryAmount_05 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        public string Quantity_06 { get; set; }
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(7)]
        public string VersionIdentifier_07 { get; set; }
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(8)]
        public string IndustryCode_08 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(9)]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    [Serializable()]
    [Composite("C022_HealthCareCodeInformation_58")]
    public class C022_HealthCareCodeInformation_58
    {
        
        [Required]
        [DataElement("1270", typeof(X12_ID_1270))]
        [Pos(1)]
        public string CodeListQualifierCode_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(2)]
        public string IndustryCode_02 { get; set; }
        [DataElement("1250", typeof(X12_ID_1250_3))]
        [Pos(3)]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(4)]
        public string DateTimePeriod_04 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(5)]
        public string MonetaryAmount_05 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        public string Quantity_06 { get; set; }
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(7)]
        public string VersionIdentifier_07 { get; set; }
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(8)]
        public string IndustryCode_08 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(9)]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    [Serializable()]
    [Composite("C022_HealthCareCodeInformation_57")]
    public class C022_HealthCareCodeInformation_57
    {
        
        [Required]
        [DataElement("1270", typeof(X12_ID_1270))]
        [Pos(1)]
        public string CodeListQualifierCode_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(2)]
        public string IndustryCode_02 { get; set; }
        [DataElement("1250", typeof(X12_ID_1250_3))]
        [Pos(3)]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(4)]
        public string DateTimePeriod_04 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(5)]
        public string MonetaryAmount_05 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        public string Quantity_06 { get; set; }
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(7)]
        public string VersionIdentifier_07 { get; set; }
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(8)]
        public string IndustryCode_08 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(9)]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    [Serializable()]
    [Composite("C022_HealthCareCodeInformation_56")]
    public class C022_HealthCareCodeInformation_56
    {
        
        [Required]
        [DataElement("1270", typeof(X12_ID_1270))]
        [Pos(1)]
        public string CodeListQualifierCode_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(2)]
        public string IndustryCode_02 { get; set; }
        [DataElement("1250", typeof(X12_ID_1250_3))]
        [Pos(3)]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(4)]
        public string DateTimePeriod_04 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(5)]
        public string MonetaryAmount_05 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        public string Quantity_06 { get; set; }
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(7)]
        public string VersionIdentifier_07 { get; set; }
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(8)]
        public string IndustryCode_08 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(9)]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    [Serializable()]
    [Composite("C022_HealthCareCodeInformation_55")]
    public class C022_HealthCareCodeInformation_55
    {
        
        [Required]
        [DataElement("1270", typeof(X12_ID_1270))]
        [Pos(1)]
        public string CodeListQualifierCode_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(2)]
        public string IndustryCode_02 { get; set; }
        [DataElement("1250", typeof(X12_ID_1250_3))]
        [Pos(3)]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(4)]
        public string DateTimePeriod_04 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(5)]
        public string MonetaryAmount_05 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        public string Quantity_06 { get; set; }
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(7)]
        public string VersionIdentifier_07 { get; set; }
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(8)]
        public string IndustryCode_08 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(9)]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    [Serializable()]
    [Composite("C022_HealthCareCodeInformation_54")]
    public class C022_HealthCareCodeInformation_54
    {
        
        [Required]
        [DataElement("1270", typeof(X12_ID_1270))]
        [Pos(1)]
        public string CodeListQualifierCode_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(2)]
        public string IndustryCode_02 { get; set; }
        [DataElement("1250", typeof(X12_ID_1250_3))]
        [Pos(3)]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(4)]
        public string DateTimePeriod_04 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(5)]
        public string MonetaryAmount_05 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        public string Quantity_06 { get; set; }
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(7)]
        public string VersionIdentifier_07 { get; set; }
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(8)]
        public string IndustryCode_08 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(9)]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    [Serializable()]
    [Composite("C022_HealthCareCodeInformation_53")]
    public class C022_HealthCareCodeInformation_53
    {
        
        [Required]
        [DataElement("1270", typeof(X12_ID_1270))]
        [Pos(1)]
        public string CodeListQualifierCode_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(2)]
        public string IndustryCode_02 { get; set; }
        [DataElement("1250", typeof(X12_ID_1250_3))]
        [Pos(3)]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(4)]
        public string DateTimePeriod_04 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(5)]
        public string MonetaryAmount_05 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        public string Quantity_06 { get; set; }
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(7)]
        public string VersionIdentifier_07 { get; set; }
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(8)]
        public string IndustryCode_08 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(9)]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    [Serializable()]
    [Composite("C022_HealthCareCodeInformation_52")]
    public class C022_HealthCareCodeInformation_52
    {
        
        [Required]
        [DataElement("1270", typeof(X12_ID_1270))]
        [Pos(1)]
        public string CodeListQualifierCode_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(2)]
        public string IndustryCode_02 { get; set; }
        [DataElement("1250", typeof(X12_ID_1250_3))]
        [Pos(3)]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(4)]
        public string DateTimePeriod_04 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(5)]
        public string MonetaryAmount_05 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        public string Quantity_06 { get; set; }
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(7)]
        public string VersionIdentifier_07 { get; set; }
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(8)]
        public string IndustryCode_08 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(9)]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    [Serializable()]
    [Composite("C022_HealthCareCodeInformation_51")]
    public class C022_HealthCareCodeInformation_51
    {
        
        [Required]
        [DataElement("1270", typeof(X12_ID_1270))]
        [Pos(1)]
        public string CodeListQualifierCode_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(2)]
        public string IndustryCode_02 { get; set; }
        [DataElement("1250", typeof(X12_ID_1250_3))]
        [Pos(3)]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(4)]
        public string DateTimePeriod_04 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(5)]
        public string MonetaryAmount_05 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        public string Quantity_06 { get; set; }
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(7)]
        public string VersionIdentifier_07 { get; set; }
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(8)]
        public string IndustryCode_08 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(9)]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    [Serializable()]
    [Composite("C022_HealthCareCodeInformation_50")]
    public class C022_HealthCareCodeInformation_50
    {
        
        [Required]
        [DataElement("1270", typeof(X12_ID_1270_5))]
        [Pos(1)]
        public string CodeListQualifierCode_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(2)]
        public string IndustryCode_02 { get; set; }
        [DataElement("1250", typeof(X12_ID_1250_3))]
        [Pos(3)]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(4)]
        public string DateTimePeriod_04 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(5)]
        public string MonetaryAmount_05 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        public string Quantity_06 { get; set; }
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(7)]
        public string VersionIdentifier_07 { get; set; }
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(8)]
        public string IndustryCode_08 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(9)]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    [Serializable()]
    [Composite("C022_HealthCareCodeInformation_49")]
    public class C022_HealthCareCodeInformation_49
    {
        
        [Required]
        [DataElement("1270", typeof(X12_ID_1270_4))]
        [Pos(1)]
        public string CodeListQualifierCode_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(2)]
        public string AnesthesiaRelatedSurgicalProcedure_02 { get; set; }
        [DataElement("1250", typeof(X12_ID_1250_3))]
        [Pos(3)]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(4)]
        public string DateTimePeriod_04 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(5)]
        public string MonetaryAmount_05 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        public string Quantity_06 { get; set; }
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(7)]
        public string VersionIdentifier_07 { get; set; }
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(8)]
        public string IndustryCode_08 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(9)]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    [Serializable()]
    [Segment("HI", typeof(X12_ID_1270_2), typeof(X12_ID_1270_3))]
    public class HI_HealthCareDiagnosisCode_2
    {
        
        [Required]
        [Pos(1)]
        public C022_HealthCareCodeInformation_37 HealthCareCodeInformation_01 { get; set; }
        [Pos(2)]
        public C022_HealthCareCodeInformation_38 HealthCareCodeInformation_02 { get; set; }
        [Pos(3)]
        public C022_HealthCareCodeInformation_39 HealthCareCodeInformation_03 { get; set; }
        [Pos(4)]
        public C022_HealthCareCodeInformation_40 HealthCareCodeInformation_04 { get; set; }
        [Pos(5)]
        public C022_HealthCareCodeInformation_41 HealthCareCodeInformation_05 { get; set; }
        [Pos(6)]
        public C022_HealthCareCodeInformation_42 HealthCareCodeInformation_06 { get; set; }
        [Pos(7)]
        public C022_HealthCareCodeInformation_43 HealthCareCodeInformation_07 { get; set; }
        [Pos(8)]
        public C022_HealthCareCodeInformation_44 HealthCareCodeInformation_08 { get; set; }
        [Pos(9)]
        public C022_HealthCareCodeInformation_45 HealthCareCodeInformation_09 { get; set; }
        [Pos(10)]
        public C022_HealthCareCodeInformation_46 HealthCareCodeInformation_10 { get; set; }
        [Pos(11)]
        public C022_HealthCareCodeInformation_47 HealthCareCodeInformation_11 { get; set; }
        [Pos(12)]
        public C022_HealthCareCodeInformation_48 HealthCareCodeInformation_12 { get; set; }
    }
    
    [Serializable()]
    [Composite("C022_HealthCareCodeInformation_48")]
    public class C022_HealthCareCodeInformation_48
    {
        
        [Required]
        [DataElement("1270", typeof(X12_ID_1270_3))]
        [Pos(1)]
        public string DiagnosisTypeCode_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(2)]
        public string DiagnosisCode_02 { get; set; }
        [DataElement("1250", typeof(X12_ID_1250_3))]
        [Pos(3)]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(4)]
        public string DateTimePeriod_04 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(5)]
        public string MonetaryAmount_05 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        public string Quantity_06 { get; set; }
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(7)]
        public string VersionIdentifier_07 { get; set; }
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(8)]
        public string IndustryCode_08 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(9)]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    [Serializable()]
    [Composite("C022_HealthCareCodeInformation_47")]
    public class C022_HealthCareCodeInformation_47
    {
        
        [Required]
        [DataElement("1270", typeof(X12_ID_1270_3))]
        [Pos(1)]
        public string DiagnosisTypeCode_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(2)]
        public string DiagnosisCode_02 { get; set; }
        [DataElement("1250", typeof(X12_ID_1250_3))]
        [Pos(3)]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(4)]
        public string DateTimePeriod_04 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(5)]
        public string MonetaryAmount_05 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        public string Quantity_06 { get; set; }
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(7)]
        public string VersionIdentifier_07 { get; set; }
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(8)]
        public string IndustryCode_08 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(9)]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    [Serializable()]
    [Composite("C022_HealthCareCodeInformation_46")]
    public class C022_HealthCareCodeInformation_46
    {
        
        [Required]
        [DataElement("1270", typeof(X12_ID_1270_3))]
        [Pos(1)]
        public string DiagnosisTypeCode_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(2)]
        public string DiagnosisCode_02 { get; set; }
        [DataElement("1250", typeof(X12_ID_1250_3))]
        [Pos(3)]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(4)]
        public string DateTimePeriod_04 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(5)]
        public string MonetaryAmount_05 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        public string Quantity_06 { get; set; }
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(7)]
        public string VersionIdentifier_07 { get; set; }
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(8)]
        public string IndustryCode_08 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(9)]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    [Serializable()]
    [Composite("C022_HealthCareCodeInformation_45")]
    public class C022_HealthCareCodeInformation_45
    {
        
        [Required]
        [DataElement("1270", typeof(X12_ID_1270_3))]
        [Pos(1)]
        public string DiagnosisTypeCode_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(2)]
        public string DiagnosisCode_02 { get; set; }
        [DataElement("1250", typeof(X12_ID_1250_3))]
        [Pos(3)]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(4)]
        public string DateTimePeriod_04 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(5)]
        public string MonetaryAmount_05 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        public string Quantity_06 { get; set; }
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(7)]
        public string VersionIdentifier_07 { get; set; }
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(8)]
        public string IndustryCode_08 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(9)]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    [Serializable()]
    [Composite("C022_HealthCareCodeInformation_44")]
    public class C022_HealthCareCodeInformation_44
    {
        
        [Required]
        [DataElement("1270", typeof(X12_ID_1270_3))]
        [Pos(1)]
        public string DiagnosisTypeCode_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(2)]
        public string DiagnosisCode_02 { get; set; }
        [DataElement("1250", typeof(X12_ID_1250_3))]
        [Pos(3)]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(4)]
        public string DateTimePeriod_04 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(5)]
        public string MonetaryAmount_05 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        public string Quantity_06 { get; set; }
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(7)]
        public string VersionIdentifier_07 { get; set; }
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(8)]
        public string IndustryCode_08 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(9)]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    [Serializable()]
    [Composite("C022_HealthCareCodeInformation_43")]
    public class C022_HealthCareCodeInformation_43
    {
        
        [Required]
        [DataElement("1270", typeof(X12_ID_1270_3))]
        [Pos(1)]
        public string DiagnosisTypeCode_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(2)]
        public string DiagnosisCode_02 { get; set; }
        [DataElement("1250", typeof(X12_ID_1250_3))]
        [Pos(3)]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(4)]
        public string DateTimePeriod_04 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(5)]
        public string MonetaryAmount_05 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        public string Quantity_06 { get; set; }
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(7)]
        public string VersionIdentifier_07 { get; set; }
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(8)]
        public string IndustryCode_08 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(9)]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    [Serializable()]
    [Composite("C022_HealthCareCodeInformation_42")]
    public class C022_HealthCareCodeInformation_42
    {
        
        [Required]
        [DataElement("1270", typeof(X12_ID_1270_3))]
        [Pos(1)]
        public string DiagnosisTypeCode_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(2)]
        public string DiagnosisCode_02 { get; set; }
        [DataElement("1250", typeof(X12_ID_1250_3))]
        [Pos(3)]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(4)]
        public string DateTimePeriod_04 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(5)]
        public string MonetaryAmount_05 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        public string Quantity_06 { get; set; }
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(7)]
        public string VersionIdentifier_07 { get; set; }
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(8)]
        public string IndustryCode_08 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(9)]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    [Serializable()]
    [Composite("C022_HealthCareCodeInformation_41")]
    public class C022_HealthCareCodeInformation_41
    {
        
        [Required]
        [DataElement("1270", typeof(X12_ID_1270_3))]
        [Pos(1)]
        public string DiagnosisTypeCode_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(2)]
        public string DiagnosisCode_02 { get; set; }
        [DataElement("1250", typeof(X12_ID_1250_3))]
        [Pos(3)]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(4)]
        public string DateTimePeriod_04 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(5)]
        public string MonetaryAmount_05 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        public string Quantity_06 { get; set; }
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(7)]
        public string VersionIdentifier_07 { get; set; }
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(8)]
        public string IndustryCode_08 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(9)]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    [Serializable()]
    [Composite("C022_HealthCareCodeInformation_40")]
    public class C022_HealthCareCodeInformation_40
    {
        
        [Required]
        [DataElement("1270", typeof(X12_ID_1270_3))]
        [Pos(1)]
        public string DiagnosisTypeCode_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(2)]
        public string DiagnosisCode_02 { get; set; }
        [DataElement("1250", typeof(X12_ID_1250_3))]
        [Pos(3)]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(4)]
        public string DateTimePeriod_04 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(5)]
        public string MonetaryAmount_05 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        public string Quantity_06 { get; set; }
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(7)]
        public string VersionIdentifier_07 { get; set; }
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(8)]
        public string IndustryCode_08 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(9)]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    [Serializable()]
    [Composite("C022_HealthCareCodeInformation_39")]
    public class C022_HealthCareCodeInformation_39
    {
        
        [Required]
        [DataElement("1270", typeof(X12_ID_1270_3))]
        [Pos(1)]
        public string DiagnosisTypeCode_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(2)]
        public string DiagnosisCode_02 { get; set; }
        [DataElement("1250", typeof(X12_ID_1250_3))]
        [Pos(3)]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(4)]
        public string DateTimePeriod_04 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(5)]
        public string MonetaryAmount_05 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        public string Quantity_06 { get; set; }
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(7)]
        public string VersionIdentifier_07 { get; set; }
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(8)]
        public string IndustryCode_08 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(9)]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    [Serializable()]
    [Composite("C022_HealthCareCodeInformation_38")]
    public class C022_HealthCareCodeInformation_38
    {
        
        [Required]
        [DataElement("1270", typeof(X12_ID_1270_3))]
        [Pos(1)]
        public string DiagnosisTypeCode_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(2)]
        public string DiagnosisCode_02 { get; set; }
        [DataElement("1250", typeof(X12_ID_1250_3))]
        [Pos(3)]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(4)]
        public string DateTimePeriod_04 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(5)]
        public string MonetaryAmount_05 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        public string Quantity_06 { get; set; }
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(7)]
        public string VersionIdentifier_07 { get; set; }
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(8)]
        public string IndustryCode_08 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(9)]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    [Serializable()]
    [Composite("C022_HealthCareCodeInformation_37")]
    public class C022_HealthCareCodeInformation_37
    {
        
        [Required]
        [DataElement("1270", typeof(X12_ID_1270_2))]
        [Pos(1)]
        public string DiagnosisTypeCode_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(2)]
        public string DiagnosisCode_02 { get; set; }
        [DataElement("1250", typeof(X12_ID_1250_3))]
        [Pos(3)]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(4)]
        public string DateTimePeriod_04 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(5)]
        public string MonetaryAmount_05 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        public string Quantity_06 { get; set; }
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(7)]
        public string VersionIdentifier_07 { get; set; }
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(8)]
        public string IndustryCode_08 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(9)]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_CRC_3
    {
        
        [ListCount(3)]
        [Pos(1)]
        public List<CRC_AmbulanceCertification_3> CRC_AmbulanceCertification_3 { get; set; }
        [ListCount(3)]
        [Pos(2)]
        public List<CRC_PatientConditionInformation_Vision_2> CRC_PatientConditionInformation_Vision_2 { get; set; }
        [Pos(3)]
        public CRC_HomeboundIndicator_2 CRC_HomeboundIndicator_2 { get; set; }
        [Pos(4)]
        public CRC_EPSDTReferral_2 CRC_EPSDTReferral_2 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",E1,E2,E3,")]
    public class X12_ID_1136_2
    {
    }
    
    [Serializable()]
    [EdiCodes(",75,")]
    public class X12_ID_1136_3
    {
    }
    
    [Serializable()]
    [EdiCodes(",ZZ,")]
    public class X12_ID_1136_4
    {
    }
    
    [Serializable()]
    [Segment("CRC", typeof(X12_ID_1136_4), typeof(X12_ID_1073_3))]
    public class CRC_EPSDTReferral_2
    {
        
        [Required]
        [DataElement("1136", typeof(X12_ID_1136_4))]
        [Pos(1)]
        public string CodeQualifier_01 { get; set; }
        [Required]
        [DataElement("1073", typeof(X12_ID_1073_3))]
        [Pos(2)]
        public string CertificationConditionCodeAppliesIndicator_02 { get; set; }
        [Required]
        [DataElement("1321", typeof(X12_ID_1321_5))]
        [Pos(3)]
        public string ConditionIndicator_03 { get; set; }
        [DataElement("1321", typeof(X12_ID_1321_5))]
        [Pos(4)]
        public string ConditionIndicator_04 { get; set; }
        [DataElement("1321", typeof(X12_ID_1321_5))]
        [Pos(5)]
        public string ConditionIndicator_05 { get; set; }
        [DataElement("1321", typeof(X12_ID_1321_4))]
        [Pos(6)]
        public string ConditionIndicator_06 { get; set; }
        [DataElement("1321", typeof(X12_ID_1321_4))]
        [Pos(7)]
        public string ConditionIndicator_07 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",AV,NU,S2,ST,")]
    public class X12_ID_1321_5
    {
    }
    
    [Serializable()]
    [Segment("CRC", typeof(X12_ID_1136_3), typeof(X12_ID_1073_2))]
    public class CRC_HomeboundIndicator_2
    {
        
        [Required]
        [DataElement("1136", typeof(X12_ID_1136_3))]
        [Pos(1)]
        public string CodeCategory_01 { get; set; }
        [Required]
        [DataElement("1073", typeof(X12_ID_1073_2))]
        [Pos(2)]
        public string CertificationConditionIndicator_02 { get; set; }
        [Required]
        [DataElement("1321", typeof(X12_ID_1321_3))]
        [Pos(3)]
        public string HomeboundIndicator_03 { get; set; }
        [DataElement("1321", typeof(X12_ID_1321_4))]
        [Pos(4)]
        public string ConditionIndicator_04 { get; set; }
        [DataElement("1321", typeof(X12_ID_1321_4))]
        [Pos(5)]
        public string ConditionIndicator_05 { get; set; }
        [DataElement("1321", typeof(X12_ID_1321_4))]
        [Pos(6)]
        public string ConditionIndicator_06 { get; set; }
        [DataElement("1321", typeof(X12_ID_1321_4))]
        [Pos(7)]
        public string ConditionIndicator_07 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",IH,")]
    public class X12_ID_1321_3
    {
    }
    
    [Serializable()]
    [Segment("CRC", typeof(X12_ID_1136_2), typeof(X12_ID_1073_3))]
    public class CRC_PatientConditionInformation_Vision_2
    {
        
        [Required]
        [DataElement("1136", typeof(X12_ID_1136_2))]
        [Pos(1)]
        public string CodeCategory_01 { get; set; }
        [Required]
        [DataElement("1073", typeof(X12_ID_1073_3))]
        [Pos(2)]
        public string CertificationConditionIndicator_02 { get; set; }
        [Required]
        [DataElement("1321", typeof(X12_ID_1321_2))]
        [Pos(3)]
        public string ConditionCode_03 { get; set; }
        [DataElement("1321", typeof(X12_ID_1321_2))]
        [Pos(4)]
        public string ConditionCode_04 { get; set; }
        [DataElement("1321", typeof(X12_ID_1321_2))]
        [Pos(5)]
        public string ConditionCode_05 { get; set; }
        [DataElement("1321", typeof(X12_ID_1321_2))]
        [Pos(6)]
        public string ConditionCode_06 { get; set; }
        [DataElement("1321", typeof(X12_ID_1321_2))]
        [Pos(7)]
        public string ConditionCode_07 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",L1,L2,L3,L4,L5,")]
    public class X12_ID_1321_2
    {
    }
    
    [Serializable()]
    [Segment("CRC", typeof(X12_ID_1136), typeof(X12_ID_1073_3))]
    public class CRC_AmbulanceCertification_3
    {
        
        [Required]
        [DataElement("1136", typeof(X12_ID_1136))]
        [Pos(1)]
        public string CodeCategory_01 { get; set; }
        [Required]
        [DataElement("1073", typeof(X12_ID_1073_3))]
        [Pos(2)]
        public string CertificationConditionIndicator_02 { get; set; }
        [Required]
        [DataElement("1321", typeof(X12_ID_1321))]
        [Pos(3)]
        public string ConditionCode_03 { get; set; }
        [DataElement("1321", typeof(X12_ID_1321))]
        [Pos(4)]
        public string ConditionCode_04 { get; set; }
        [DataElement("1321", typeof(X12_ID_1321))]
        [Pos(5)]
        public string ConditionCode_05 { get; set; }
        [DataElement("1321", typeof(X12_ID_1321))]
        [Pos(6)]
        public string ConditionCode_06 { get; set; }
        [DataElement("1321", typeof(X12_ID_1321))]
        [Pos(7)]
        public string ConditionCode_07 { get; set; }
    }
    
    [Serializable()]
    [Segment("CR2")]
    public class CR2_SpinalManipulationServiceInformation_2
    {
        
        [StringLength(1, 9)]
        [DataElement("609", typeof(X12_N0))]
        [Pos(1)]
        public string Count_01 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(2)]
        public string Quantity_02 { get; set; }
        [DataElement("1367", typeof(X12_ID_1367))]
        [Pos(3)]
        public string SubluxationLevelCode_03 { get; set; }
        [DataElement("1367", typeof(X12_ID_1367))]
        [Pos(4)]
        public string SubluxationLevelCode_04 { get; set; }
        [DataElement("355", typeof(X12_ID_355_2))]
        [Pos(5)]
        public string UnitorBasisforMeasurementCode_05 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        public string Quantity_06 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(7)]
        public string Quantity_07 { get; set; }
        [Required]
        [DataElement("1342", typeof(X12_ID_1342))]
        [Pos(8)]
        public string PatientConditionCode_08 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(9)]
        public string YesNoConditionorResponseCode_09 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(10)]
        public string PatientConditionDescription_10 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(11)]
        public string PatientConditionDescription_11 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(12)]
        public string YesNoConditionorResponseCode_12 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",C1,C2,C3,C4,C5,C6,C7,CO,IL,L1,L2,L3,L4,L5,OC,SA,T1,T10,T11,T12,T2,T3,T4,T5,T6,T7" +
        ",T8,T9,")]
    public class X12_ID_1367
    {
    }
    
    [Serializable()]
    [EdiCodes(",A,C,D,E,F,G,M,")]
    public class X12_ID_1342
    {
    }
    
    [Serializable()]
    [Segment("CR1", typeof(X12_ID_355_3))]
    public class CR1_AmbulanceTransportInformation_3
    {
        
        [DataElement("355", typeof(X12_ID_355_3))]
        [Pos(1)]
        public string UnitorBasisforMeasurementCode_01 { get; set; }
        [StringLength(1, 10)]
        [DataElement("81", typeof(X12_R))]
        [Pos(2)]
        public string PatientWeight_02 { get; set; }
        [DataElement("1316", typeof(X12_ID_1316))]
        [Pos(3)]
        public string AmbulanceTransportCode_03 { get; set; }
        [Required]
        [DataElement("1317", typeof(X12_ID_1317))]
        [Pos(4)]
        public string AmbulanceTransportReasonCode_04 { get; set; }
        [Required]
        [DataElement("355", typeof(X12_ID_355_4))]
        [Pos(5)]
        public string UnitorBasisforMeasurementCode_05 { get; set; }
        [Required]
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        public string TransportDistance_06 { get; set; }
        [StringLength(1, 55)]
        [DataElement("166", typeof(X12_AN))]
        [Pos(7)]
        public string AddressInformation_07 { get; set; }
        [StringLength(1, 55)]
        [DataElement("166", typeof(X12_AN))]
        [Pos(8)]
        public string AddressInformation_08 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(9)]
        public string RoundTripPurposeDescription_09 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(10)]
        public string StretcherPurposeDescription_10 { get; set; }
    }
    
    [Serializable()]
    [Segment("NTE", typeof(X12_ID_363))]
    public class NTE_ClaimNote_2
    {
        
        [Required]
        [DataElement("363", typeof(X12_ID_363))]
        [Pos(1)]
        public string NoteReferenceCode_01 { get; set; }
        [Required]
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(2)]
        public string ClaimNoteText_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("K3")]
    public class K3_FileInformation_3
    {
        
        [Required]
        [StringLength(1, 80)]
        [DataElement("449", typeof(X12_AN))]
        [Pos(1)]
        public string FixedFormatInformation_01 { get; set; }
        [DataElement("1333", typeof(X12_ID_1333))]
        [Pos(2)]
        public string RecordFormatCode_02 { get; set; }
        [Pos(3)]
        public C001_CompositeUnitofMeasure_7 CompositeUnitofMeasure_03 { get; set; }
    }
    
    [Serializable()]
    [Composite("C001_CompositeUnitofMeasure_7")]
    public class C001_CompositeUnitofMeasure_7
    {
        
        [Required]
        [DataElement("355", typeof(X12_ID_355_2))]
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
        [DataElement("355", typeof(X12_ID_355_2))]
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
        [DataElement("355", typeof(X12_ID_355_2))]
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
        [DataElement("355", typeof(X12_ID_355_2))]
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
        [DataElement("355", typeof(X12_ID_355_2))]
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
    [All()]
    public class All_REF_9
    {
        
        [Pos(1)]
        public REF_ServiceAuthorizationExceptionCode_2 REF_ServiceAuthorizationExceptionCode_2 { get; set; }
        [Pos(2)]
        public REF_MandatoryMedicare_Section4081_CrossoverIndicator_2 REF_MandatoryMedicare_Section4081_CrossoverIndicator_2 { get; set; }
        [Pos(3)]
        public REF_MammographyCertificationNumber_3 REF_MammographyCertificationNumber_3 { get; set; }
        [Pos(4)]
        public REF_ReferralNumber_3 REF_ReferralNumber_3 { get; set; }
        [Pos(5)]
        public REF_PriorAuthorization_3 REF_PriorAuthorization_3 { get; set; }
        [Pos(6)]
        public REF_PayerClaimControlNumber_2 REF_PayerClaimControlNumber_2 { get; set; }
        [Pos(7)]
        public REF_ClinicalLaboratoryImprovementAmendment_CLIA_Number_3 REF_ClinicalLaboratoryImprovementAmendment_CLIA_Number_3 { get; set; }
        [Pos(8)]
        public REF_RepricedClaimNumber_2 REF_RepricedClaimNumber_2 { get; set; }
        [Pos(9)]
        public REF_AdjustedRepricedClaimNumber_2 REF_AdjustedRepricedClaimNumber_2 { get; set; }
        [Pos(10)]
        public REF_InvestigationalDeviceExemptionNumber_2 REF_InvestigationalDeviceExemptionNumber_2 { get; set; }
        [Pos(11)]
        public REF_ClaimIdentifierForTransmissionIntermediaries_2 REF_ClaimIdentifierForTransmissionIntermediaries_2 { get; set; }
        [Pos(12)]
        public REF_MedicalRecordNumber_2 REF_MedicalRecordNumber_2 { get; set; }
        [Pos(13)]
        public REF_DemonstrationProjectIdentifier_2 REF_DemonstrationProjectIdentifier_2 { get; set; }
        [Pos(14)]
        public REF_CarePlanOversight_2 REF_CarePlanOversight_2 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",4N,")]
    public class X12_ID_128_11
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,3,4,5,6,7,")]
    public class X12_ID_127_1
    {
    }
    
    [Serializable()]
    [EdiCodes(",F5,")]
    public class X12_ID_128_12
    {
    }
    
    [Serializable()]
    [EdiCodes(",N,Y,")]
    public class X12_ID_127_2
    {
    }
    
    [Serializable()]
    [EdiCodes(",9A,")]
    public class X12_ID_128_18
    {
    }
    
    [Serializable()]
    [EdiCodes(",9C,")]
    public class X12_ID_128_19
    {
    }
    
    [Serializable()]
    [EdiCodes(",LX,")]
    public class X12_ID_128_20
    {
    }
    
    [Serializable()]
    [EdiCodes(",D9,")]
    public class X12_ID_128_21
    {
    }
    
    [Serializable()]
    [EdiCodes(",EA,")]
    public class X12_ID_128_22
    {
    }
    
    [Serializable()]
    [EdiCodes(",P4,")]
    public class X12_ID_128_23
    {
    }
    
    [Serializable()]
    [EdiCodes(",1J,")]
    public class X12_ID_128_24
    {
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_24))]
    public class REF_CarePlanOversight_2
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_24))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string CarePlanOversightNumber_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        [Pos(4)]
        public C040_ReferenceIdentifier_69 ReferenceIdentifier_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C040_ReferenceIdentifier_69")]
    public class C040_ReferenceIdentifier_69
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_23))]
    public class REF_DemonstrationProjectIdentifier_2
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_23))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string DemonstrationProjectIdentifier_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        [Pos(4)]
        public C040_ReferenceIdentifier_68 ReferenceIdentifier_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C040_ReferenceIdentifier_68")]
    public class C040_ReferenceIdentifier_68
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_22))]
    public class REF_MedicalRecordNumber_2
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_22))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string MedicalRecordNumber_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        [Pos(4)]
        public C040_ReferenceIdentifier_67 ReferenceIdentifier_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C040_ReferenceIdentifier_67")]
    public class C040_ReferenceIdentifier_67
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_21))]
    public class REF_ClaimIdentifierForTransmissionIntermediaries_2
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_21))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ValueAddedNetworkTraceNumber_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        [Pos(4)]
        public C040_ReferenceIdentifier_66 ReferenceIdentifier_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C040_ReferenceIdentifier_66")]
    public class C040_ReferenceIdentifier_66
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_20))]
    public class REF_InvestigationalDeviceExemptionNumber_2
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_20))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string InvestigationalDeviceExemptionIdentifier_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        [Pos(4)]
        public C040_ReferenceIdentifier_65 ReferenceIdentifier_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C040_ReferenceIdentifier_65")]
    public class C040_ReferenceIdentifier_65
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_19))]
    public class REF_AdjustedRepricedClaimNumber_2
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_19))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string AdjustedRepricedClaimReferenceNumber_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        [Pos(4)]
        public C040_ReferenceIdentifier_64 ReferenceIdentifier_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C040_ReferenceIdentifier_64")]
    public class C040_ReferenceIdentifier_64
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_18))]
    public class REF_RepricedClaimNumber_2
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_18))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string RepricedClaimReferenceNumber_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        [Pos(4)]
        public C040_ReferenceIdentifier_63 ReferenceIdentifier_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C040_ReferenceIdentifier_63")]
    public class C040_ReferenceIdentifier_63
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_17))]
    public class REF_ClinicalLaboratoryImprovementAmendment_CLIA_Number_3
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_17))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ClinicalLaboratoryImprovementAmendmentNumber_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        [Pos(4)]
        public C040_ReferenceIdentifier_62 ReferenceIdentifier_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C040_ReferenceIdentifier_62")]
    public class C040_ReferenceIdentifier_62
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_16))]
    public class REF_PayerClaimControlNumber_2
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_16))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string PayerClaimControlNumber_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        [Pos(4)]
        public C040_ReferenceIdentifier_61 ReferenceIdentifier_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C040_ReferenceIdentifier_61")]
    public class C040_ReferenceIdentifier_61
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_15))]
    public class REF_PriorAuthorization_3
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_15))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string PriorAuthorizationNumber_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        [Pos(4)]
        public C040_ReferenceIdentifier_60 ReferenceIdentifier_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C040_ReferenceIdentifier_60")]
    public class C040_ReferenceIdentifier_60
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_14))]
    public class REF_ReferralNumber_3
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_14))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferralNumber_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        [Pos(4)]
        public C040_ReferenceIdentifier_59 ReferenceIdentifier_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C040_ReferenceIdentifier_59")]
    public class C040_ReferenceIdentifier_59
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_13))]
    public class REF_MammographyCertificationNumber_3
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_13))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string MammographyCertificationNumber_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        [Pos(4)]
        public C040_ReferenceIdentifier_58 ReferenceIdentifier_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C040_ReferenceIdentifier_58")]
    public class C040_ReferenceIdentifier_58
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_12), typeof(X12_ID_127_2))]
    public class REF_MandatoryMedicare_Section4081_CrossoverIndicator_2
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_12))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [DataElement("127", typeof(X12_ID_127_2))]
        [Pos(2)]
        public string MedicareSection4081Indicator_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        [Pos(4)]
        public C040_ReferenceIdentifier_57 ReferenceIdentifier_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C040_ReferenceIdentifier_57")]
    public class C040_ReferenceIdentifier_57
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_11), typeof(X12_ID_127_1))]
    public class REF_ServiceAuthorizationExceptionCode_2
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_11))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [DataElement("127", typeof(X12_ID_127_1))]
        [Pos(2)]
        public string ServiceAuthorizationExceptionCode_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        [Pos(4)]
        public C040_ReferenceIdentifier_56 ReferenceIdentifier_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C040_ReferenceIdentifier_56")]
    public class C040_ReferenceIdentifier_56
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("AMT", typeof(X12_ID_522))]
    public class AMT_PatientAmountPaid_2
    {
        
        [Required]
        [DataElement("522", typeof(X12_ID_522))]
        [Pos(1)]
        public string AmountQualifierCode_01 { get; set; }
        [Required]
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(2)]
        public string PatientAmountPaid_02 { get; set; }
        [DataElement("478", typeof(X12_ID_478))]
        [Pos(3)]
        public string CreditDebitFlagCode_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("CN1", typeof(X12_ID_1166))]
    public class CN1_ContractInformation_3
    {
        
        [Required]
        [DataElement("1166", typeof(X12_ID_1166))]
        [Pos(1)]
        public string ContractTypeCode_01 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(2)]
        public string ContractAmount_02 { get; set; }
        [StringLength(1, 6)]
        [DataElement("332", typeof(X12_R))]
        [Pos(3)]
        public string ContractPercentage_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ContractCode_04 { get; set; }
        [StringLength(1, 6)]
        [DataElement("338", typeof(X12_R))]
        [Pos(5)]
        public string TermsDiscountPercentage_05 { get; set; }
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(6)]
        public string ContractVersionIdentifier_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("PWK", typeof(X12_ID_755), typeof(X12_ID_756))]
    public class PWK_ClaimSupplementalInformation_2
    {
        
        [Required]
        [DataElement("755", typeof(X12_ID_755))]
        [Pos(1)]
        public string AttachmentReportTypeCode_01 { get; set; }
        [Required]
        [DataElement("756", typeof(X12_ID_756))]
        [Pos(2)]
        public string AttachmentTransmissionCode_02 { get; set; }
        [StringLength(1, 2)]
        [DataElement("757", typeof(X12_N0))]
        [Pos(3)]
        public string ReportCopiesNeeded_03 { get; set; }
        [DataElement("98", typeof(X12_ID_98_2))]
        [Pos(4)]
        public string EntityIdentifierCode_04 { get; set; }
        [DataElement("66", typeof(X12_ID_66_6))]
        [Pos(5)]
        public string IdentificationCodeQualifier_05 { get; set; }
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(6)]
        public string AttachmentControlNumber_06 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(7)]
        public string Description_07 { get; set; }
        [Pos(8)]
        public C002_ActionsIndicated_4 ActionsIndicated_08 { get; set; }
        [DataElement("1525", typeof(X12_ID_1525))]
        [Pos(9)]
        public string RequestCategoryCode_09 { get; set; }
    }
    
    [Serializable()]
    [Composite("C002_ActionsIndicated_4")]
    public class C002_ActionsIndicated_4
    {
        
        [Required]
        [DataElement("704", typeof(X12_ID_704))]
        [Pos(1)]
        public string PaperworkReportActionCode_01 { get; set; }
        [DataElement("704", typeof(X12_ID_704))]
        [Pos(2)]
        public string PaperworkReportActionCode_02 { get; set; }
        [DataElement("704", typeof(X12_ID_704))]
        [Pos(3)]
        public string PaperworkReportActionCode_03 { get; set; }
        [DataElement("704", typeof(X12_ID_704))]
        [Pos(4)]
        public string PaperworkReportActionCode_04 { get; set; }
        [DataElement("704", typeof(X12_ID_704))]
        [Pos(5)]
        public string PaperworkReportActionCode_05 { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_DTP_3
    {
        
        [Pos(1)]
        public DTP_Date_OnsetofCurrentIllnessorSymptom_2 DTP_Date_OnsetofCurrentIllnessorSymptom_2 { get; set; }
        [Pos(2)]
        public DTP_Date_InitialTreatmentDate_3 DTP_Date_InitialTreatmentDate_3 { get; set; }
        [Pos(3)]
        public DTP_Date_LastSeenDate_3 DTP_Date_LastSeenDate_3 { get; set; }
        [Pos(4)]
        public DTP_Date_AcuteManifestation_2 DTP_Date_AcuteManifestation_2 { get; set; }
        [Pos(5)]
        public DTP_Date_Accident_2 DTP_Date_Accident_2 { get; set; }
        [Pos(6)]
        public DTP_Date_LastMenstrualPeriod_2 DTP_Date_LastMenstrualPeriod_2 { get; set; }
        [Pos(7)]
        public DTP_Date_LastX_rayDate_3 DTP_Date_LastX_rayDate_3 { get; set; }
        [Pos(8)]
        public DTP_Date_HearingandVisionPrescriptionDate_2 DTP_Date_HearingandVisionPrescriptionDate_2 { get; set; }
        [Pos(9)]
        public DTP_Date_DisabilityDates_2 DTP_Date_DisabilityDates_2 { get; set; }
        [Pos(10)]
        public DTP_Date_LastWorked_2 DTP_Date_LastWorked_2 { get; set; }
        [Pos(11)]
        public DTP_Date_AuthorizedReturntoWork_2 DTP_Date_AuthorizedReturntoWork_2 { get; set; }
        [Pos(12)]
        public DTP_Date_Admission_2 DTP_Date_Admission_2 { get; set; }
        [Pos(13)]
        public DTP_Date_Discharge_2 DTP_Date_Discharge_2 { get; set; }
        [ListCount(2)]
        [Pos(14)]
        public List<DTP_Date_AssumedandRelinquishedCareDates_2> DTP_Date_AssumedandRelinquishedCareDates_2 { get; set; }
        [Pos(15)]
        public DTP_PropertyandCasualtyDateofFirstContact_2 DTP_PropertyandCasualtyDateofFirstContact_2 { get; set; }
        [Pos(16)]
        public DTP_Date_RepricerReceivedDate_2 DTP_Date_RepricerReceivedDate_2 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",431,")]
    public class X12_ID_374_2
    {
    }
    
    [Serializable()]
    [EdiCodes(",453,")]
    public class X12_ID_374_5
    {
    }
    
    [Serializable()]
    [EdiCodes(",439,")]
    public class X12_ID_374_6
    {
    }
    
    [Serializable()]
    [EdiCodes(",484,")]
    public class X12_ID_374_7
    {
    }
    
    [Serializable()]
    [EdiCodes(",314,360,361,")]
    public class X12_ID_374_10
    {
    }
    
    [Serializable()]
    [EdiCodes(",297,")]
    public class X12_ID_374_11
    {
    }
    
    [Serializable()]
    [EdiCodes(",296,")]
    public class X12_ID_374_12
    {
    }
    
    [Serializable()]
    [EdiCodes(",435,")]
    public class X12_ID_374_13
    {
    }
    
    [Serializable()]
    [EdiCodes(",096,")]
    public class X12_ID_374_14
    {
    }
    
    [Serializable()]
    [EdiCodes(",090,091,")]
    public class X12_ID_374_15
    {
    }
    
    [Serializable()]
    [EdiCodes(",444,")]
    public class X12_ID_374_16
    {
    }
    
    [Serializable()]
    [EdiCodes(",050,")]
    public class X12_ID_374_17
    {
    }
    
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_17), typeof(X12_ID_1250))]
    public class DTP_Date_RepricerReceivedDate_2
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374_17))]
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
        public string RepricerReceivedDate_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_16), typeof(X12_ID_1250))]
    public class DTP_PropertyandCasualtyDateofFirstContact_2
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374_16))]
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
    [Segment("DTP", typeof(X12_ID_374_15), typeof(X12_ID_1250))]
    public class DTP_Date_AssumedandRelinquishedCareDates_2
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374_15))]
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
        public string AssumedorRelinquishedCareDate_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_14), typeof(X12_ID_1250))]
    public class DTP_Date_Discharge_2
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374_14))]
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
        public string RelatedHospitalizationDischargeDate_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_13), typeof(X12_ID_1250))]
    public class DTP_Date_Admission_2
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374_13))]
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
        public string RelatedHospitalizationAdmissionDate_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_12), typeof(X12_ID_1250))]
    public class DTP_Date_AuthorizedReturntoWork_2
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374_12))]
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
        public string WorkReturnDate_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_11), typeof(X12_ID_1250))]
    public class DTP_Date_LastWorked_2
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374_11))]
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
        public string LastWorkedDate_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_10), typeof(X12_ID_1250_2))]
    public class DTP_Date_DisabilityDates_2
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374_10))]
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
        public string DisabilityFromDate_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_9), typeof(X12_ID_1250))]
    public class DTP_Date_HearingandVisionPrescriptionDate_2
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374_9))]
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
        public string PrescriptionDate_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_8), typeof(X12_ID_1250))]
    public class DTP_Date_LastX_rayDate_3
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374_8))]
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
        public string LastXRayDate_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_7), typeof(X12_ID_1250))]
    public class DTP_Date_LastMenstrualPeriod_2
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374_7))]
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
        public string LastMenstrualPeriodDate_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_6), typeof(X12_ID_1250))]
    public class DTP_Date_Accident_2
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374_6))]
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
        public string AccidentDate_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_5), typeof(X12_ID_1250))]
    public class DTP_Date_AcuteManifestation_2
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
        public string AcuteManifestationDate_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_4), typeof(X12_ID_1250))]
    public class DTP_Date_LastSeenDate_3
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374_4))]
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
        public string LastSeenDate_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_3), typeof(X12_ID_1250))]
    public class DTP_Date_InitialTreatmentDate_3
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
        public string InitialTreatmentDate_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_2), typeof(X12_ID_1250))]
    public class DTP_Date_OnsetofCurrentIllnessorSymptom_2
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
        public string OnsetofCurrentIllnessorInjuryDate_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("CLM")]
    public class CLM_ClaimInformation_2
    {
        
        [Required]
        [StringLength(1, 38)]
        [DataElement("1028", typeof(X12_AN))]
        [Pos(1)]
        public string PatientControlNumber_01 { get; set; }
        [Required]
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(2)]
        public string TotalClaimChargeAmount_02 { get; set; }
        [DataElement("1032", typeof(X12_ID_1032_2))]
        [Pos(3)]
        public string ClaimFilingIndicatorCode_03 { get; set; }
        [DataElement("1343", typeof(X12_ID_1343))]
        [Pos(4)]
        public string NonInstitutionalClaimTypeCode_04 { get; set; }
        [Required]
        [Pos(5)]
        public C023_HealthCareServiceLocationInformation_2 HealthCareServiceLocationInformation_05 { get; set; }
        [Required]
        [DataElement("1073", typeof(X12_ID_1073_3))]
        [Pos(6)]
        public string ProviderorSupplierSignatureIndicator_06 { get; set; }
        [Required]
        [DataElement("1359", typeof(X12_ID_1359))]
        [Pos(7)]
        public string AssignmentorPlanParticipationCode_07 { get; set; }
        [Required]
        [DataElement("1073", typeof(X12_ID_1073_4))]
        [Pos(8)]
        public string BenefitsAssignmentCertificationIndicator_08 { get; set; }
        [Required]
        [DataElement("1363", typeof(X12_ID_1363))]
        [Pos(9)]
        public string ReleaseofInformationCode_09 { get; set; }
        [DataElement("1351", typeof(X12_ID_1351))]
        [Pos(10)]
        public string PatientSignatureSourceCode_10 { get; set; }
        [Pos(11)]
        public C024_RelatedCausesInformation_2 RelatedCausesInformation_11 { get; set; }
        [DataElement("1366", typeof(X12_ID_1366))]
        [Pos(12)]
        public string SpecialProgramIndicator_12 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(13)]
        public string YesNoConditionorResponseCode_13 { get; set; }
        [DataElement("1338", typeof(X12_ID_1338))]
        [Pos(14)]
        public string LevelofServiceCode_14 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(15)]
        public string YesNoConditionorResponseCode_15 { get; set; }
        [DataElement("1360", typeof(X12_ID_1360))]
        [Pos(16)]
        public string ProviderAgreementCode_16 { get; set; }
        [DataElement("1029", typeof(X12_ID_1029))]
        [Pos(17)]
        public string ClaimStatusCode_17 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(18)]
        public string YesNoConditionorResponseCode_18 { get; set; }
        [DataElement("1383", typeof(X12_ID_1383))]
        [Pos(19)]
        public string ClaimSubmissionReasonCode_19 { get; set; }
        [DataElement("1514", typeof(X12_ID_1514))]
        [Pos(20)]
        public string DelayReasonCode_20 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",A,AA,AM,AN,CF,CH,CS,DA,DD,DM,DN,ER,HH,HS,IF,IL,L,LT,MD,MF,MH,MI,MO,MS,NM,NP,NS,O" +
        ",OC,OP,OT,OX,P,PA,PD,PE,PF,PS,PT,RX,S,SC,SN,ST,T,TX,V,")]
    public class X12_ID_1343
    {
    }
    
    [Serializable()]
    [EdiCodes(",A,B,C,")]
    public class X12_ID_1359
    {
    }
    
    [Serializable()]
    [EdiCodes(",02,03,05,09,")]
    public class X12_ID_1366
    {
    }
    
    [Serializable()]
    [EdiCodes(",00,01,02,03,04,05,06,09,10,11,E,F1,F2,I,L,NBC,R,U,")]
    public class X12_ID_1338
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,23,24,25,26,27,28,29,3,30,4,5,6,7,8,9" +
        ",AD,AP,CC,CL,CP,I,RA,RB,RC,RD,RO,")]
    public class X12_ID_1029
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,10,11,15,2,3,4,5,6,7,8,9,")]
    public class X12_ID_1514
    {
    }
    
    [Serializable()]
    [Composite("C024_RelatedCausesInformation_2")]
    public class C024_RelatedCausesInformation_2
    {
        
        [Required]
        [DataElement("1362", typeof(X12_ID_1362))]
        [Pos(1)]
        public string RelatedCausesCode_01 { get; set; }
        [DataElement("1362", typeof(X12_ID_1362))]
        [Pos(2)]
        public string RelatedCausesCode_02 { get; set; }
        [DataElement("1362", typeof(X12_ID_1362_2))]
        [Pos(3)]
        public string RelatedCausesCode_03 { get; set; }
        [StringLength(2, 2)]
        [DataElement("156", typeof(X12_ID))]
        [Pos(4)]
        public string AutoAccidentStateorProvinceCode_04 { get; set; }
        [StringLength(2, 3)]
        [DataElement("26", typeof(X12_ID))]
        [Pos(5)]
        public string CountryCode_05 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",AA,EM,OA,")]
    public class X12_ID_1362
    {
    }
    
    [Serializable()]
    [EdiCodes(",AA,AB,AP,EM,OA,ZZ,")]
    public class X12_ID_1362_2
    {
    }
    
    [Serializable()]
    [Composite("C023_HealthCareServiceLocationInformation_2")]
    public class C023_HealthCareServiceLocationInformation_2
    {
        
        [Required]
        [StringLength(1, 2)]
        [DataElement("1331", typeof(X12_AN))]
        [Pos(1)]
        public string PlaceofServiceCode_01 { get; set; }
        [Required]
        [DataElement("1332", typeof(X12_ID_1332))]
        [Pos(2)]
        public string FacilityCodeQualifier_02 { get; set; }
        [Required]
        [StringLength(1, 1)]
        [DataElement("1325", typeof(X12_ID))]
        [Pos(3)]
        public string ClaimFrequencyCode_03 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",B,")]
    public class X12_ID_1332
    {
    }
    
    [Serializable()]
    [Group("NM1")]
    public class Loop_2010CA
    {
        
        [Required]
        [Pos(1)]
        public NM1_PatientName NM1_PatientName { get; set; }
        [Required]
        [Pos(2)]
        public N3_PatientAddress N3_PatientAddress { get; set; }
        [Required]
        [Pos(3)]
        public N4_PatientCity_State_ZIPCode N4_PatientCity_State_ZIPCode { get; set; }
        [Required]
        [Pos(4)]
        public DMG_PatientDemographicInformation DMG_PatientDemographicInformation { get; set; }
        [Pos(5)]
        public All_REF_8 All_REF_8 { get; set; }
        [Pos(6)]
        public PER_PropertyandCasualtyPatientContactInformation PER_PropertyandCasualtyPatientContactInformation { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",QC,")]
    public class X12_ID_98_17
    {
    }
    
    [Serializable()]
    [Segment("PER", typeof(X12_ID_366))]
    public class PER_PropertyandCasualtyPatientContactInformation
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
        [DataElement("365", typeof(X12_ID_365_3))]
        [Pos(3)]
        public string CommunicationNumberQualifier_03 { get; set; }
        [Required]
        [StringLength(1, 256)]
        [DataElement("364", typeof(X12_AN))]
        [Pos(4)]
        public string CommunicationNumber_04 { get; set; }
        [DataElement("365", typeof(X12_ID_365_4))]
        [Pos(5)]
        public string CommunicationNumberQualifier_05 { get; set; }
        [StringLength(1, 256)]
        [DataElement("364", typeof(X12_AN))]
        [Pos(6)]
        public string CommunicationNumber_06 { get; set; }
        [DataElement("365", typeof(X12_ID_365_5))]
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
    [All()]
    public class All_REF_8
    {
        
        [Pos(1)]
        public REF_PropertyandCasualtyClaimNumber_2 REF_PropertyandCasualtyClaimNumber_2 { get; set; }
        [Pos(2)]
        public REF_PropertyandCasualtyPatientIdentifier REF_PropertyandCasualtyPatientIdentifier { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",Y4,")]
    public class X12_ID_128_8
    {
    }
    
    [Serializable()]
    [EdiCodes(",1W,SY,")]
    public class X12_ID_128_36
    {
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_36))]
    public class REF_PropertyandCasualtyPatientIdentifier
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_36))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string PropertyandCasualtyPatientIdentifier_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        [Pos(4)]
        public C040_ReferenceIdentifier_55 ReferenceIdentifier_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C040_ReferenceIdentifier_55")]
    public class C040_ReferenceIdentifier_55
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        [Required]
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [Required]
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_8))]
    public class REF_PropertyandCasualtyClaimNumber_2
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_8))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string PropertyCasualtyClaimNumber_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        [Pos(4)]
        public C040_ReferenceIdentifier_54 ReferenceIdentifier_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C040_ReferenceIdentifier_54")]
    public class C040_ReferenceIdentifier_54
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("DMG", typeof(X12_ID_1250))]
    public class DMG_PatientDemographicInformation
    {
        
        [Required]
        [DataElement("1250", typeof(X12_ID_1250))]
        [Pos(1)]
        public string DateTimePeriodFormatQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(2)]
        public string PatientBirthDate_02 { get; set; }
        [Required]
        [DataElement("1068", typeof(X12_ID_1068))]
        [Pos(3)]
        public string PatientGenderCode_03 { get; set; }
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
        [DataElement("1270", typeof(X12_ID_1270))]
        [Pos(10)]
        public string CodeListQualifierCode_10 { get; set; }
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(11)]
        public string IndustryCode_11 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",F,M,U,")]
    public class X12_ID_1068
    {
    }
    
    [Serializable()]
    [EdiCodes(",A,B,C,D,I,K,M,R,S,U,W,X,")]
    public class X12_ID_1067
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,A,B,C,D,E,F,G,H,I,")]
    public class X12_ID_1066
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,A,B,C,D,E,F,G,H,I,J,K,")]
    public class X12_ID_659
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
        public string IndustryCode_03 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",7,8,A,B,C,D,E,F,G,H,I,J,N,O,P,Q,R,S,T,U,V,W,Z,")]
    public class X12_ID_1109
    {
    }
    
    [Serializable()]
    [Segment("N4")]
    public class N4_PatientCity_State_ZIPCode
    {
        
        [Required]
        [StringLength(2, 30)]
        [DataElement("19", typeof(X12_AN))]
        [Pos(1)]
        public string PatientCityName_01 { get; set; }
        [StringLength(2, 2)]
        [DataElement("156", typeof(X12_ID))]
        [Pos(2)]
        public string PatientStateCode_02 { get; set; }
        [StringLength(3, 15)]
        [DataElement("116", typeof(X12_ID))]
        [Pos(3)]
        public string PatientPostalZoneorZIPCode_03 { get; set; }
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
    [Segment("N3")]
    public class N3_PatientAddress
    {
        
        [Required]
        [StringLength(1, 55)]
        [DataElement("166", typeof(X12_AN))]
        [Pos(1)]
        public string PatientAddressLine_01 { get; set; }
        [StringLength(1, 55)]
        [DataElement("166", typeof(X12_AN))]
        [Pos(2)]
        public string PatientAddressLine_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_17), typeof(X12_ID_1065_3))]
    public class NM1_PatientName
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98_17))]
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
        public string PatientLastName_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1036", typeof(X12_AN))]
        [Pos(4)]
        public string PatientFirstName_04 { get; set; }
        [StringLength(1, 25)]
        [DataElement("1037", typeof(X12_AN))]
        [Pos(5)]
        public string PatientMiddleNameorInitial_05 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1038", typeof(X12_AN))]
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1039", typeof(X12_AN))]
        [Pos(7)]
        public string PatientNameSuffix_07 { get; set; }
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
    [Segment("PAT", typeof(X12_ID_1069_4), typeof(X12_ID_1384))]
    public class PAT_PatientInformation_2
    {
        
        [Required]
        [DataElement("1069", typeof(X12_ID_1069_4))]
        [Pos(1)]
        public string IndividualRelationshipCode_01 { get; set; }
        [DataElement("1384", typeof(X12_ID_1384))]
        [Pos(2)]
        public string PatientLocationCode_02 { get; set; }
        [DataElement("584", typeof(X12_ID_584))]
        [Pos(3)]
        public string EmploymentStatusCode_03 { get; set; }
        [DataElement("1220", typeof(X12_ID_1220))]
        [Pos(4)]
        public string StudentStatusCode_04 { get; set; }
        [DataElement("1250", typeof(X12_ID_1250))]
        [Pos(5)]
        public string DateTimePeriodFormatQualifier_05 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(6)]
        public string PatientDeathDate_06 { get; set; }
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(7)]
        public string UnitorBasisforMeasurementCode_07 { get; set; }
        [StringLength(1, 10)]
        [DataElement("81", typeof(X12_R))]
        [Pos(8)]
        public string PatientWeight_08 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073_2))]
        [Pos(9)]
        public string PregnancyIndicator_09 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",F,N,P,")]
    public class X12_ID_1220
    {
    }
    
    [Serializable()]
    [EdiCodes(",01,")]
    public class X12_ID_355
    {
    }
    
    [Serializable()]
    [Segment("HL")]
    public class HL_PatientHierarchicalLevel
    {
        
        [Required]
        [StringLength(1, 12)]
        [DataElement("628", typeof(X12_AN))]
        [Pos(1)]
        public string HierarchicalIDNumber_01 { get; set; }
        [Required]
        [StringLength(1, 12)]
        [DataElement("734", typeof(X12_AN))]
        [Pos(2)]
        public string HierarchicalParentIDNumber_02 { get; set; }
        [Required]
        [DataElement("735", typeof(X12_ID_735_3))]
        [Pos(3)]
        public string HierarchicalLevelCode_03 { get; set; }
        [Required]
        [DataElement("736", typeof(X12_ID_736_3))]
        [Pos(4)]
        public string HierarchicalChildCode_04 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",23,")]
    public class X12_ID_735_3
    {
    }
    
    [Serializable()]
    [EdiCodes(",0,")]
    public class X12_ID_736_3
    {
    }
    
    [Serializable()]
    [Group("CLM")]
    public class Loop_2300
    {
        
        [Required]
        [Pos(1)]
        public CLM_ClaimInformation CLM_ClaimInformation { get; set; }
        [Pos(2)]
        public All_DTP All_DTP { get; set; }
        [ListCount(10)]
        [Pos(3)]
        public List<PWK_ClaimSupplementalInformation> PWK_ClaimSupplementalInformation { get; set; }
        [Pos(4)]
        public CN1_ContractInformation CN1_ContractInformation { get; set; }
        [Pos(5)]
        public AMT_PatientAmountPaid AMT_PatientAmountPaid { get; set; }
        [Pos(6)]
        public All_REF_5 All_REF_5 { get; set; }
        [ListCount(10)]
        [Pos(7)]
        public List<K3_FileInformation> K3_FileInformation { get; set; }
        [Pos(8)]
        public NTE_ClaimNote NTE_ClaimNote { get; set; }
        [Pos(9)]
        public CR1_AmbulanceTransportInformation CR1_AmbulanceTransportInformation { get; set; }
        [Pos(10)]
        public CR2_SpinalManipulationServiceInformation CR2_SpinalManipulationServiceInformation { get; set; }
        [Pos(11)]
        public All_CRC All_CRC { get; set; }
        [Required]
        [Pos(12)]
        public All_HI All_HI { get; set; }
        [Pos(13)]
        public HCP_ClaimPricing_RepricingInformation HCP_ClaimPricing_RepricingInformation { get; set; }
        [Pos(14)]
        public All_NM1_4 All_NM1_4 { get; set; }
        [ListCount(10)]
        [Pos(15)]
        public List<Loop_2320> Loop_2320 { get; set; }
        [Required]
        [ListCount(50)]
        [Pos(16)]
        public List<Loop_2400> Loop_2400 { get; set; }
    }
    
    [Serializable()]
    [Group("LX")]
    public class Loop_2400
    {
        
        [Required]
        [Pos(1)]
        public LX_ServiceLineNumber LX_ServiceLineNumber { get; set; }
        [Required]
        [Pos(2)]
        public SV1_ProfessionalService SV1_ProfessionalService { get; set; }
        [Pos(3)]
        public SV5_DurableMedicalEquipmentService SV5_DurableMedicalEquipmentService { get; set; }
        [Pos(4)]
        public All_PWK All_PWK { get; set; }
        [Pos(5)]
        public CR1_AmbulanceTransportInformation_2 CR1_AmbulanceTransportInformation_2 { get; set; }
        [Pos(6)]
        public CR3_DurableMedicalEquipmentCertification CR3_DurableMedicalEquipmentCertification { get; set; }
        [Pos(7)]
        public All_CRC_2 All_CRC_2 { get; set; }
        [Required]
        [Pos(8)]
        public All_DTP_2 All_DTP_2 { get; set; }
        [Pos(9)]
        public All_QTY All_QTY { get; set; }
        [ListCount(5)]
        [Pos(10)]
        public List<MEA_TestResult> MEA_TestResult { get; set; }
        [Pos(11)]
        public CN1_ContractInformation_2 CN1_ContractInformation_2 { get; set; }
        [Pos(12)]
        public All_REF_7 All_REF_7 { get; set; }
        [Pos(13)]
        public All_AMT_2 All_AMT_2 { get; set; }
        [ListCount(10)]
        [Pos(14)]
        public List<K3_FileInformation_2> K3_FileInformation_2 { get; set; }
        [Pos(15)]
        public All_NTE All_NTE { get; set; }
        [Pos(16)]
        public PS1_PurchasedServiceInformation PS1_PurchasedServiceInformation { get; set; }
        [Pos(17)]
        public HCP_LinePricing_RepricingInformation HCP_LinePricing_RepricingInformation { get; set; }
        [Pos(18)]
        public Loop_2410 Loop_2410 { get; set; }
        [Pos(19)]
        public All_NM1_6 All_NM1_6 { get; set; }
        [ListCount(15)]
        [Pos(20)]
        public List<Loop_2430> Loop_2430 { get; set; }
        [Pos(21)]
        public List<Loop_2440> Loop_2440 { get; set; }
    }
    
    [Serializable()]
    [Group("LQ")]
    public class Loop_2440
    {
        
        [Required]
        [Pos(1)]
        public LQ_FormIdentificationCode LQ_FormIdentificationCode { get; set; }
        [Required]
        [ListCount(99)]
        [Pos(2)]
        public List<FRM_SupportingDocumentation> FRM_SupportingDocumentation { get; set; }
    }
    
    [Serializable()]
    [Segment("FRM")]
    public class FRM_SupportingDocumentation
    {
        
        [Required]
        [StringLength(1, 20)]
        [DataElement("350", typeof(X12_AN))]
        [Pos(1)]
        public string QuestionNumberLetter_01 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073_4))]
        [Pos(2)]
        public string QuestionResponse_02 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(3)]
        public string QuestionResponse_03 { get; set; }
        [StringLength(8, 8)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(4)]
        public string QuestionResponse_04 { get; set; }
        [StringLength(1, 6)]
        [DataElement("332", typeof(X12_R))]
        [Pos(5)]
        public string QuestionResponse_05 { get; set; }
    }
    
    [Serializable()]
    [Segment("LQ", typeof(X12_ID_1270_7))]
    public class LQ_FormIdentificationCode
    {
        
        [Required]
        [DataElement("1270", typeof(X12_ID_1270_7))]
        [Pos(1)]
        public string CodeListQualifierCode_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(2)]
        public string FormIdentifier_02 { get; set; }
    }
    
    [Serializable()]
    [Group("SVD")]
    public class Loop_2430
    {
        
        [Required]
        [Pos(1)]
        public SVD_LineAdjudicationInformation SVD_LineAdjudicationInformation { get; set; }
        [ListCount(5)]
        [Pos(2)]
        public List<CAS_LineAdjustment> CAS_LineAdjustment { get; set; }
        [Required]
        [Pos(3)]
        public DTP_LineCheckorRemittanceDate DTP_LineCheckorRemittanceDate { get; set; }
        [Pos(4)]
        public AMT_RemainingPatientLiability_2 AMT_RemainingPatientLiability_2 { get; set; }
    }
    
    [Serializable()]
    [Segment("AMT", typeof(X12_ID_522_4))]
    public class AMT_RemainingPatientLiability_2
    {
        
        [Required]
        [DataElement("522", typeof(X12_ID_522_4))]
        [Pos(1)]
        public string AmountQualifierCode_01 { get; set; }
        [Required]
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(2)]
        public string RemainingPatientLiability_02 { get; set; }
        [DataElement("478", typeof(X12_ID_478))]
        [Pos(3)]
        public string CreditDebitFlagCode_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_18), typeof(X12_ID_1250))]
    public class DTP_LineCheckorRemittanceDate
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374_18))]
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
        public string AdjudicationorPaymentDate_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("CAS", typeof(X12_ID_1033))]
    public class CAS_LineAdjustment
    {
        
        [Required]
        [DataElement("1033", typeof(X12_ID_1033))]
        [Pos(1)]
        public string ClaimAdjustmentGroupCode_01 { get; set; }
        [Required]
        [StringLength(1, 5)]
        [DataElement("1034", typeof(X12_ID))]
        [Pos(2)]
        public string AdjustmentReasonCode_02 { get; set; }
        [Required]
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(3)]
        public string AdjustmentAmount_03 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(4)]
        public string AdjustmentQuantity_04 { get; set; }
        [StringLength(1, 5)]
        [DataElement("1034", typeof(X12_ID))]
        [Pos(5)]
        public string AdjustmentReasonCode_05 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(6)]
        public string AdjustmentAmount_06 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(7)]
        public string AdjustmentQuantity_07 { get; set; }
        [StringLength(1, 5)]
        [DataElement("1034", typeof(X12_ID))]
        [Pos(8)]
        public string AdjustmentReasonCode_08 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(9)]
        public string AdjustmentAmount_09 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(10)]
        public string AdjustmentQuantity_10 { get; set; }
        [StringLength(1, 5)]
        [DataElement("1034", typeof(X12_ID))]
        [Pos(11)]
        public string AdjustmentReasonCode_11 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(12)]
        public string AdjustmentAmount_12 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(13)]
        public string AdjustmentQuantity_13 { get; set; }
        [StringLength(1, 5)]
        [DataElement("1034", typeof(X12_ID))]
        [Pos(14)]
        public string AdjustmentReasonCode_14 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(15)]
        public string AdjustmentAmount_15 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(16)]
        public string AdjustmentQuantity_16 { get; set; }
        [StringLength(1, 5)]
        [DataElement("1034", typeof(X12_ID))]
        [Pos(17)]
        public string AdjustmentReasonCode_17 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(18)]
        public string AdjustmentAmount_18 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(19)]
        public string AdjustmentQuantity_19 { get; set; }
    }
    
    [Serializable()]
    [Segment("SVD")]
    public class SVD_LineAdjudicationInformation
    {
        
        [Required]
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(1)]
        public string OtherPayerPrimaryIdentifier_01 { get; set; }
        [Required]
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(2)]
        public string ServiceLinePaidAmount_02 { get; set; }
        [Required]
        [Pos(3)]
        public C003_CompositeMedicalProcedureIdentifier_3 CompositeMedicalProcedureIdentifier_03 { get; set; }
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(4)]
        public string ProductServiceID_04 { get; set; }
        [Required]
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(5)]
        public string PaidServiceUnitCount_05 { get; set; }
        [StringLength(1, 6)]
        [DataElement("554", typeof(X12_N0))]
        [Pos(6)]
        public string BundledorUnbundledLineNumber_06 { get; set; }
    }
    
    [Serializable()]
    [Composite("C003_CompositeMedicalProcedureIdentifier_3")]
    public class C003_CompositeMedicalProcedureIdentifier_3
    {
        
        [Required]
        [DataElement("235", typeof(X12_ID_235_2))]
        [Pos(1)]
        public string ProductorServiceIDQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(2)]
        public string ProcedureCode_02 { get; set; }
        [StringLength(2, 2)]
        [DataElement("1339", typeof(X12_AN))]
        [Pos(3)]
        public string ProcedureModifier_03 { get; set; }
        [StringLength(2, 2)]
        [DataElement("1339", typeof(X12_AN))]
        [Pos(4)]
        public string ProcedureModifier_04 { get; set; }
        [StringLength(2, 2)]
        [DataElement("1339", typeof(X12_AN))]
        [Pos(5)]
        public string ProcedureModifier_05 { get; set; }
        [StringLength(2, 2)]
        [DataElement("1339", typeof(X12_AN))]
        [Pos(6)]
        public string ProcedureModifier_06 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(7)]
        public string ProcedureCodeDescription_07 { get; set; }
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(8)]
        public string ProductServiceID_08 { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_NM1_6
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
        [Pos(7)]
        public Loop_2420G Loop_2420G { get; set; }
        [Pos(8)]
        public Loop_2420H Loop_2420H { get; set; }
    }
    
    [Serializable()]
    [Group("NM1")]
    public class Loop_2420H
    {
        
        [Required]
        [Pos(1)]
        public NM1_AmbulanceDrop_offLocation_2 NM1_AmbulanceDrop_offLocation_2 { get; set; }
        [Required]
        [Pos(2)]
        public N3_AmbulanceDrop_offLocationAddress_2 N3_AmbulanceDrop_offLocationAddress_2 { get; set; }
        [Required]
        [Pos(3)]
        public N4_AmbulanceDrop_offLocationCity_State_ZipCode_2 N4_AmbulanceDrop_offLocationCity_State_ZipCode_2 { get; set; }
    }
    
    [Serializable()]
    [Segment("N4")]
    public class N4_AmbulanceDrop_offLocationCity_State_ZipCode_2
    {
        
        [Required]
        [StringLength(2, 30)]
        [DataElement("19", typeof(X12_AN))]
        [Pos(1)]
        public string AmbulanceDropoffCityName_01 { get; set; }
        [StringLength(2, 2)]
        [DataElement("156", typeof(X12_ID))]
        [Pos(2)]
        public string AmbulanceDropoffStateorProvinceCode_02 { get; set; }
        [StringLength(3, 15)]
        [DataElement("116", typeof(X12_ID))]
        [Pos(3)]
        public string AmbulanceDropoffPostalZoneorZIPCode_03 { get; set; }
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
    [Segment("N3")]
    public class N3_AmbulanceDrop_offLocationAddress_2
    {
        
        [Required]
        [StringLength(1, 55)]
        [DataElement("166", typeof(X12_AN))]
        [Pos(1)]
        public string AmbulanceDropoffAddressLine_01 { get; set; }
        [StringLength(1, 55)]
        [DataElement("166", typeof(X12_AN))]
        [Pos(2)]
        public string AmbulanceDropoffAddressLine_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_14), typeof(X12_ID_1065_2))]
    public class NM1_AmbulanceDrop_offLocation_2
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98_14))]
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        [Required]
        [DataElement("1065", typeof(X12_ID_1065_2))]
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(3)]
        public string AmbulanceDropoffLocation_03 { get; set; }
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
    public class Loop_2420G
    {
        
        [Required]
        [Pos(1)]
        public NM1_AmbulancePick_upLocation_2 NM1_AmbulancePick_upLocation_2 { get; set; }
        [Required]
        [Pos(2)]
        public N3_AmbulancePick_upLocationAddress_2 N3_AmbulancePick_upLocationAddress_2 { get; set; }
        [Required]
        [Pos(3)]
        public N4_AmbulancePick_upLocationCity_State_ZipCode_2 N4_AmbulancePick_upLocationCity_State_ZipCode_2 { get; set; }
    }
    
    [Serializable()]
    [Segment("N4")]
    public class N4_AmbulancePick_upLocationCity_State_ZipCode_2
    {
        
        [Required]
        [StringLength(2, 30)]
        [DataElement("19", typeof(X12_AN))]
        [Pos(1)]
        public string AmbulancePickupCityName_01 { get; set; }
        [StringLength(2, 2)]
        [DataElement("156", typeof(X12_ID))]
        [Pos(2)]
        public string AmbulancePickupStateorProvinceCode_02 { get; set; }
        [StringLength(3, 15)]
        [DataElement("116", typeof(X12_ID))]
        [Pos(3)]
        public string AmbulancePickupPostalZoneorZIPCode_03 { get; set; }
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
    [Segment("N3")]
    public class N3_AmbulancePick_upLocationAddress_2
    {
        
        [Required]
        [StringLength(1, 55)]
        [DataElement("166", typeof(X12_AN))]
        [Pos(1)]
        public string AmbulancePickupAddressLine_01 { get; set; }
        [StringLength(1, 55)]
        [DataElement("166", typeof(X12_AN))]
        [Pos(2)]
        public string AmbulancePickupAddressLine_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_13), typeof(X12_ID_1065_2))]
    public class NM1_AmbulancePick_upLocation_2
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
    public class Loop_2420F
    {
        
        [Required]
        [Pos(1)]
        public NM1_ReferringProviderName_2 NM1_ReferringProviderName_2 { get; set; }
        [ListCount(20)]
        [Pos(2)]
        public List<REF_ReferringProviderSecondaryIdentification_2> REF_ReferringProviderSecondaryIdentification_2 { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_25))]
    public class REF_ReferringProviderSecondaryIdentification_2
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_25))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferringProviderSecondaryIdentifier_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        [Pos(4)]
        public C040_ReferenceIdentifier_53 ReferenceIdentifier_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C040_ReferenceIdentifier_53")]
    public class C040_ReferenceIdentifier_53
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_31))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string OtherPayerPrimaryIdentifier_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_9), typeof(X12_ID_1065_3))]
    public class NM1_ReferringProviderName_2
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
        public string ReferringProviderLastName_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1036", typeof(X12_AN))]
        [Pos(4)]
        public string ReferringProviderFirstName_04 { get; set; }
        [StringLength(1, 25)]
        [DataElement("1037", typeof(X12_AN))]
        [Pos(5)]
        public string ReferringProviderMiddleNameorInitial_05 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1038", typeof(X12_AN))]
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1039", typeof(X12_AN))]
        [Pos(7)]
        public string ReferringProviderNameSuffix_07 { get; set; }
        [DataElement("66", typeof(X12_ID_66_2))]
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(9)]
        public string ReferringProviderIdentifier_09 { get; set; }
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
    public class Loop_2420E
    {
        
        [Required]
        [Pos(1)]
        public NM1_OrderingProviderName NM1_OrderingProviderName { get; set; }
        [Pos(2)]
        public N3_OrderingProviderAddress N3_OrderingProviderAddress { get; set; }
        [Pos(3)]
        public N4_OrderingProviderCity_State_ZIPCode N4_OrderingProviderCity_State_ZIPCode { get; set; }
        [ListCount(20)]
        [Pos(4)]
        public List<REF_OrderingProviderSecondaryIdentification> REF_OrderingProviderSecondaryIdentification { get; set; }
        [Pos(5)]
        public PER_OrderingProviderContactInformation PER_OrderingProviderContactInformation { get; set; }
    }
    
    [Serializable()]
    [Segment("PER", typeof(X12_ID_366))]
    public class PER_OrderingProviderContactInformation
    {
        
        [Required]
        [DataElement("366", typeof(X12_ID_366))]
        [Pos(1)]
        public string ContactFunctionCode_01 { get; set; }
        [StringLength(1, 60)]
        [DataElement("93", typeof(X12_AN))]
        [Pos(2)]
        public string OrderingProviderContactName_02 { get; set; }
        [Required]
        [DataElement("365", typeof(X12_ID_365))]
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
    [Segment("REF", typeof(X12_ID_128_25))]
    public class REF_OrderingProviderSecondaryIdentification
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_25))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string OrderingProviderSecondaryIdentifier_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        [Pos(4)]
        public C040_ReferenceIdentifier_52 ReferenceIdentifier_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C040_ReferenceIdentifier_52")]
    public class C040_ReferenceIdentifier_52
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_31))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string OtherPayerPrimaryIdentifier_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("N4")]
    public class N4_OrderingProviderCity_State_ZIPCode
    {
        
        [Required]
        [StringLength(2, 30)]
        [DataElement("19", typeof(X12_AN))]
        [Pos(1)]
        public string OrderingProviderCityName_01 { get; set; }
        [StringLength(2, 2)]
        [DataElement("156", typeof(X12_ID))]
        [Pos(2)]
        public string OrderingProviderStateorProvinceCode_02 { get; set; }
        [StringLength(3, 15)]
        [DataElement("116", typeof(X12_ID))]
        [Pos(3)]
        public string OrderingProviderPostalZoneorZIPCode_03 { get; set; }
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
    [Segment("N3")]
    public class N3_OrderingProviderAddress
    {
        
        [Required]
        [StringLength(1, 55)]
        [DataElement("166", typeof(X12_AN))]
        [Pos(1)]
        public string OrderingProviderAddressLine_01 { get; set; }
        [StringLength(1, 55)]
        [DataElement("166", typeof(X12_AN))]
        [Pos(2)]
        public string OrderingProviderAddressLine_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_16), typeof(X12_ID_1065_3))]
    public class NM1_OrderingProviderName
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98_16))]
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
        public string OrderingProviderLastName_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1036", typeof(X12_AN))]
        [Pos(4)]
        public string OrderingProviderFirstName_04 { get; set; }
        [StringLength(1, 25)]
        [DataElement("1037", typeof(X12_AN))]
        [Pos(5)]
        public string OrderingProviderMiddleNameorInitial_05 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1038", typeof(X12_AN))]
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1039", typeof(X12_AN))]
        [Pos(7)]
        public string OrderingProviderNameSuffix_07 { get; set; }
        [DataElement("66", typeof(X12_ID_66_2))]
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(9)]
        public string OrderingProviderIdentifier_09 { get; set; }
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
    public class Loop_2420D
    {
        
        [Required]
        [Pos(1)]
        public NM1_SupervisingProviderName_2 NM1_SupervisingProviderName_2 { get; set; }
        [ListCount(20)]
        [Pos(2)]
        public List<REF_SupervisingProviderSecondaryIdentification_2> REF_SupervisingProviderSecondaryIdentification_2 { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_26))]
    public class REF_SupervisingProviderSecondaryIdentification_2
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_26))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string SupervisingProviderSecondaryIdentifier_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        [Pos(4)]
        public C040_ReferenceIdentifier_51 ReferenceIdentifier_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C040_ReferenceIdentifier_51")]
    public class C040_ReferenceIdentifier_51
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_31))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string OtherPayerPrimaryIdentifier_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_12), typeof(X12_ID_1065_3))]
    public class NM1_SupervisingProviderName_2
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98_12))]
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
        public string SupervisingProviderLastName_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1036", typeof(X12_AN))]
        [Pos(4)]
        public string SupervisingProviderFirstName_04 { get; set; }
        [StringLength(1, 25)]
        [DataElement("1037", typeof(X12_AN))]
        [Pos(5)]
        public string SupervisingProviderMiddleNameorInitial_05 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1038", typeof(X12_AN))]
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1039", typeof(X12_AN))]
        [Pos(7)]
        public string SupervisingProviderNameSuffix_07 { get; set; }
        [DataElement("66", typeof(X12_ID_66_2))]
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(9)]
        public string SupervisingProviderIdentifier_09 { get; set; }
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
    public class Loop_2420C
    {
        
        [Required]
        [Pos(1)]
        public NM1_ServiceFacilityLocation NM1_ServiceFacilityLocation { get; set; }
        [Required]
        [Pos(2)]
        public N3_ServiceFacilityLocationAddress_2 N3_ServiceFacilityLocationAddress_2 { get; set; }
        [Required]
        [Pos(3)]
        public N4_ServiceFacilityLocationCity_State_ZIPCode_2 N4_ServiceFacilityLocationCity_State_ZIPCode_2 { get; set; }
        [ListCount(3)]
        [Pos(4)]
        public List<REF_ServiceFacilityLocationSecondaryIdentification_2> REF_ServiceFacilityLocationSecondaryIdentification_2 { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_10))]
    public class REF_ServiceFacilityLocationSecondaryIdentification_2
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_10))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ServiceFacilityLocationSecondaryIdentifier_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        [Pos(4)]
        public C040_ReferenceIdentifier_50 ReferenceIdentifier_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C040_ReferenceIdentifier_50")]
    public class C040_ReferenceIdentifier_50
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_31))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string OtherPayerPrimaryIdentifier_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("N4")]
    public class N4_ServiceFacilityLocationCity_State_ZIPCode_2
    {
        
        [Required]
        [StringLength(2, 30)]
        [DataElement("19", typeof(X12_AN))]
        [Pos(1)]
        public string LaboratoryorFacilityCityName_01 { get; set; }
        [StringLength(2, 2)]
        [DataElement("156", typeof(X12_ID))]
        [Pos(2)]
        public string LaboratoryorFacilityStateorProvinceCode_02 { get; set; }
        [StringLength(3, 15)]
        [DataElement("116", typeof(X12_ID))]
        [Pos(3)]
        public string LaboratoryorFacilityPostalZoneorZIPCode_03 { get; set; }
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
    [Segment("N3")]
    public class N3_ServiceFacilityLocationAddress_2
    {
        
        [Required]
        [StringLength(1, 55)]
        [DataElement("166", typeof(X12_AN))]
        [Pos(1)]
        public string LaboratoryorFacilityAddressLine_01 { get; set; }
        [StringLength(1, 55)]
        [DataElement("166", typeof(X12_AN))]
        [Pos(2)]
        public string LaboratoryorFacilityAddressLine_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_11), typeof(X12_ID_1065_2))]
    public class NM1_ServiceFacilityLocation
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98_11))]
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        [Required]
        [DataElement("1065", typeof(X12_ID_1065_2))]
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        [Required]
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(3)]
        public string LaboratoryorFacilityName_03 { get; set; }
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
        [DataElement("66", typeof(X12_ID_66_2))]
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(9)]
        public string LaboratoryorFacilityPrimaryIdentifier_09 { get; set; }
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
    public class Loop_2420B
    {
        
        [Required]
        [Pos(1)]
        public NM1_PurchasedServiceProviderName NM1_PurchasedServiceProviderName { get; set; }
        [ListCount(20)]
        [Pos(2)]
        public List<REF_PurchasedServiceProviderSecondaryIdentification> REF_PurchasedServiceProviderSecondaryIdentification { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_25))]
    public class REF_PurchasedServiceProviderSecondaryIdentification
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_25))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string PurchasedServiceProviderSecondaryIdentifier_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        [Pos(4)]
        public C040_ReferenceIdentifier_49 ReferenceIdentifier_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C040_ReferenceIdentifier_49")]
    public class C040_ReferenceIdentifier_49
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_31))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string OtherPayerPrimaryIdentifier_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_15), typeof(X12_ID_1065))]
    public class NM1_PurchasedServiceProviderName
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98_15))]
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
        [DataElement("66", typeof(X12_ID_66_2))]
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(9)]
        public string PurchasedServiceProviderIdentifier_09 { get; set; }
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
    public class Loop_2420A
    {
        
        [Required]
        [Pos(1)]
        public NM1_RenderingProviderName_2 NM1_RenderingProviderName_2 { get; set; }
        [Pos(2)]
        public PRV_RenderingProviderSpecialtyInformation_2 PRV_RenderingProviderSpecialtyInformation_2 { get; set; }
        [ListCount(20)]
        [Pos(3)]
        public List<REF_RenderingProviderSecondaryIdentification_2> REF_RenderingProviderSecondaryIdentification_2 { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_26))]
    public class REF_RenderingProviderSecondaryIdentification_2
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_26))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string RenderingProviderSecondaryIdentifier_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        [Pos(4)]
        public C040_ReferenceIdentifier_48 ReferenceIdentifier_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C040_ReferenceIdentifier_48")]
    public class C040_ReferenceIdentifier_48
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_31))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string OtherPayerPrimaryIdentifier_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("PRV", typeof(X12_ID_1221_2), typeof(X12_ID_128))]
    public class PRV_RenderingProviderSpecialtyInformation_2
    {
        
        [Required]
        [DataElement("1221", typeof(X12_ID_1221_2))]
        [Pos(1)]
        public string ProviderCode_01 { get; set; }
        [Required]
        [DataElement("128", typeof(X12_ID_128))]
        [Pos(2)]
        public string ReferenceIdentificationQualifier_02 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(3)]
        public string ProviderTaxonomyCode_03 { get; set; }
        [StringLength(2, 2)]
        [DataElement("156", typeof(X12_ID))]
        [Pos(4)]
        public string StateorProvinceCode_04 { get; set; }
        [Pos(5)]
        public C035_ProviderSpecialtyInformation_3 ProviderSpecialtyInformation_05 { get; set; }
        [DataElement("1223", typeof(X12_ID_1223))]
        [Pos(6)]
        public string ProviderOrganizationCode_06 { get; set; }
    }
    
    [Serializable()]
    [Composite("C035_ProviderSpecialtyInformation_3")]
    public class C035_ProviderSpecialtyInformation_3
    {
        
        [Required]
        [DataElement("1222", typeof(X12_ID_1222))]
        [Pos(1)]
        public string ProviderSpecialtyCode_01 { get; set; }
        [DataElement("559", typeof(X12_ID_559))]
        [Pos(2)]
        public string AgencyQualifierCode_02 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(3)]
        public string YesNoConditionorResponseCode_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_10), typeof(X12_ID_1065))]
    public class NM1_RenderingProviderName_2
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
        public string RenderingProviderLastorOrganizationName_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1036", typeof(X12_AN))]
        [Pos(4)]
        public string RenderingProviderFirstName_04 { get; set; }
        [StringLength(1, 25)]
        [DataElement("1037", typeof(X12_AN))]
        [Pos(5)]
        public string RenderingProviderMiddleName_05 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1038", typeof(X12_AN))]
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1039", typeof(X12_AN))]
        [Pos(7)]
        public string RenderingProviderNameSuffix_07 { get; set; }
        [DataElement("66", typeof(X12_ID_66_2))]
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(9)]
        public string RenderingProviderIdentifier_09 { get; set; }
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
    [Group("LIN")]
    public class Loop_2410
    {
        
        [Required]
        [Pos(1)]
        public LIN_DrugIdentification LIN_DrugIdentification { get; set; }
        [Required]
        [Pos(2)]
        public CTP_DrugQuantity CTP_DrugQuantity { get; set; }
        [Pos(3)]
        public REF_PrescriptionorCompoundDrugAssociationNumber REF_PrescriptionorCompoundDrugAssociationNumber { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_35))]
    public class REF_PrescriptionorCompoundDrugAssociationNumber
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_35))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string PrescriptionNumber_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        [Pos(4)]
        public C040_ReferenceIdentifier_47 ReferenceIdentifier_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C040_ReferenceIdentifier_47")]
    public class C040_ReferenceIdentifier_47
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("CTP", typeof(X12_ID_687), typeof(X12_ID_236))]
    public class CTP_DrugQuantity
    {
        
        [DataElement("687", typeof(X12_ID_687))]
        [Pos(1)]
        public string ClassofTradeCode_01 { get; set; }
        [DataElement("236", typeof(X12_ID_236))]
        [Pos(2)]
        public string PriceIdentifierCode_02 { get; set; }
        [StringLength(1, 17)]
        [DataElement("212", typeof(X12_R))]
        [Pos(3)]
        public string UnitPrice_03 { get; set; }
        [Required]
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(4)]
        public string NationalDrugUnitCount_04 { get; set; }
        [Required]
        [Pos(5)]
        public C001_CompositeUnitofMeasure_6 CompositeUnitofMeasure_05 { get; set; }
        [DataElement("648", typeof(X12_ID_648))]
        [Pos(6)]
        public string PriceMultiplierQualifier_06 { get; set; }
        [StringLength(1, 10)]
        [DataElement("649", typeof(X12_R))]
        [Pos(7)]
        public string Multiplier_07 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(8)]
        public string MonetaryAmount_08 { get; set; }
        [DataElement("639", typeof(X12_ID_639))]
        [Pos(9)]
        public string BasisofUnitPriceCode_09 { get; set; }
        [StringLength(1, 10)]
        [DataElement("499", typeof(X12_AN))]
        [Pos(10)]
        public string ConditionValue_10 { get; set; }
        [StringLength(1, 2)]
        [DataElement("289", typeof(X12_N0))]
        [Pos(11)]
        public string MultiplePriceQuantity_11 { get; set; }
    }
    
    [Serializable()]
    [Composite("C001_CompositeUnitofMeasure_6")]
    public class C001_CompositeUnitofMeasure_6
    {
        
        [Required]
        [DataElement("355", typeof(X12_ID_355_8))]
        [Pos(1)]
        public string CodeQualifier_01 { get; set; }
        [StringLength(1, 15)]
        [DataElement("1018", typeof(X12_R))]
        [Pos(2)]
        public string Exponent_02 { get; set; }
        [StringLength(1, 10)]
        [DataElement("649", typeof(X12_R))]
        [Pos(3)]
        public string Multiplier_03 { get; set; }
        [DataElement("355", typeof(X12_ID_355_2))]
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
        [DataElement("355", typeof(X12_ID_355_2))]
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
        [DataElement("355", typeof(X12_ID_355_2))]
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
        [DataElement("355", typeof(X12_ID_355_2))]
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
    [Segment("LIN")]
    public class LIN_DrugIdentification
    {
        
        [StringLength(1, 20)]
        [DataElement("350", typeof(X12_AN))]
        [Pos(1)]
        public string AssignedIdentification_01 { get; set; }
        [Required]
        [DataElement("235", typeof(X12_ID_235_4))]
        [Pos(2)]
        public string ProductorServiceIDQualifier_02 { get; set; }
        [Required]
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(3)]
        public string NationalDrugCodeorUniversalProductNumber_03 { get; set; }
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(4)]
        public string ProductServiceIDQualifier_04 { get; set; }
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(5)]
        public string ProductServiceID_05 { get; set; }
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(6)]
        public string ProductServiceIDQualifier_06 { get; set; }
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(7)]
        public string ProductServiceID_07 { get; set; }
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(8)]
        public string ProductServiceIDQualifier_08 { get; set; }
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(9)]
        public string ProductServiceID_09 { get; set; }
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(10)]
        public string ProductServiceIDQualifier_10 { get; set; }
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(11)]
        public string ProductServiceID_11 { get; set; }
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(12)]
        public string ProductServiceIDQualifier_12 { get; set; }
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(13)]
        public string ProductServiceID_13 { get; set; }
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(14)]
        public string ProductServiceIDQualifier_14 { get; set; }
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(15)]
        public string ProductServiceID_15 { get; set; }
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(16)]
        public string ProductServiceIDQualifier_16 { get; set; }
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(17)]
        public string ProductServiceID_17 { get; set; }
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(18)]
        public string ProductServiceIDQualifier_18 { get; set; }
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(19)]
        public string ProductServiceID_19 { get; set; }
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(20)]
        public string ProductServiceIDQualifier_20 { get; set; }
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(21)]
        public string ProductServiceID_21 { get; set; }
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(22)]
        public string ProductServiceIDQualifier_22 { get; set; }
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(23)]
        public string ProductServiceID_23 { get; set; }
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(24)]
        public string ProductServiceIDQualifier_24 { get; set; }
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(25)]
        public string ProductServiceID_25 { get; set; }
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(26)]
        public string ProductServiceIDQualifier_26 { get; set; }
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(27)]
        public string ProductServiceID_27 { get; set; }
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(28)]
        public string ProductServiceIDQualifier_28 { get; set; }
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(29)]
        public string ProductServiceID_29 { get; set; }
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(30)]
        public string ProductServiceIDQualifier_30 { get; set; }
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(31)]
        public string ProductServiceID_31 { get; set; }
    }
    
    [Serializable()]
    [Segment("HCP", typeof(X12_ID_1473_2))]
    public class HCP_LinePricing_RepricingInformation
    {
        
        [Required]
        [DataElement("1473", typeof(X12_ID_1473_2))]
        [Pos(1)]
        public string PricingMethodology_01 { get; set; }
        [Required]
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(2)]
        public string RepricedAllowedAmount_02 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(3)]
        public string RepricedSavingAmount_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string RepricingOrganizationIdentifier_04 { get; set; }
        [StringLength(1, 9)]
        [DataElement("118", typeof(X12_R))]
        [Pos(5)]
        public string RepricingPerDiemorFlatRateAmount_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string RepricedApprovedAmbulatoryPatientGroupCode_06 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(7)]
        public string RepricedApprovedAmbulatoryPatientGroupAmount_07 { get; set; }
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(8)]
        public string ProductServiceID_08 { get; set; }
        [DataElement("235", typeof(X12_ID_235_2))]
        [Pos(9)]
        public string ProductorServiceIDQualifier_09 { get; set; }
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(10)]
        public string RepricedApprovedHCPCSCode_10 { get; set; }
        [DataElement("355", typeof(X12_ID_355_5))]
        [Pos(11)]
        public string UnitorBasisforMeasurementCode_11 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(12)]
        public string RepricedApprovedServiceUnitCount_12 { get; set; }
        [DataElement("901", typeof(X12_ID_901))]
        [Pos(13)]
        public string RejectReasonCode_13 { get; set; }
        [DataElement("1526", typeof(X12_ID_1526))]
        [Pos(14)]
        public string PolicyComplianceCode_14 { get; set; }
        [DataElement("1527", typeof(X12_ID_1527))]
        [Pos(15)]
        public string ExceptionCode_15 { get; set; }
    }
    
    [Serializable()]
    [Segment("PS1")]
    public class PS1_PurchasedServiceInformation
    {
        
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(1)]
        public string PurchasedServiceProviderIdentifier_01 { get; set; }
        [Required]
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(2)]
        public string PurchasedServiceChargeAmount_02 { get; set; }
        [StringLength(2, 2)]
        [DataElement("156", typeof(X12_ID))]
        [Pos(3)]
        public string StateorProvinceCode_03 { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_NTE
    {
        
        [Pos(1)]
        public NTE_LineNote NTE_LineNote { get; set; }
        [Pos(2)]
        public NTE_ThirdPartyOrganizationNotes NTE_ThirdPartyOrganizationNotes { get; set; }
    }
    
    [Serializable()]
    [Segment("NTE", typeof(X12_ID_363_3))]
    public class NTE_ThirdPartyOrganizationNotes
    {
        
        [Required]
        [DataElement("363", typeof(X12_ID_363_3))]
        [Pos(1)]
        public string NoteReferenceCode_01 { get; set; }
        [Required]
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(2)]
        public string LineNoteText_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("NTE", typeof(X12_ID_363_2))]
    public class NTE_LineNote
    {
        
        [Required]
        [DataElement("363", typeof(X12_ID_363_2))]
        [Pos(1)]
        public string NoteReferenceCode_01 { get; set; }
        [Required]
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(2)]
        public string LineNoteText_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("K3")]
    public class K3_FileInformation_2
    {
        
        [Required]
        [StringLength(1, 80)]
        [DataElement("449", typeof(X12_AN))]
        [Pos(1)]
        public string FixedFormatInformation_01 { get; set; }
        [DataElement("1333", typeof(X12_ID_1333))]
        [Pos(2)]
        public string RecordFormatCode_02 { get; set; }
        [Pos(3)]
        public C001_CompositeUnitofMeasure_5 CompositeUnitofMeasure_03 { get; set; }
    }
    
    [Serializable()]
    [Composite("C001_CompositeUnitofMeasure_5")]
    public class C001_CompositeUnitofMeasure_5
    {
        
        [Required]
        [DataElement("355", typeof(X12_ID_355_2))]
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
        [DataElement("355", typeof(X12_ID_355_2))]
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
        [DataElement("355", typeof(X12_ID_355_2))]
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
        [DataElement("355", typeof(X12_ID_355_2))]
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
        [DataElement("355", typeof(X12_ID_355_2))]
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
    [All()]
    public class All_AMT_2
    {
        
        [Pos(1)]
        public AMT_SalesTaxAmount AMT_SalesTaxAmount { get; set; }
        [Pos(2)]
        public AMT_PostageClaimedAmount AMT_PostageClaimedAmount { get; set; }
    }
    
    [Serializable()]
    [Segment("AMT", typeof(X12_ID_522_6))]
    public class AMT_PostageClaimedAmount
    {
        
        [Required]
        [DataElement("522", typeof(X12_ID_522_6))]
        [Pos(1)]
        public string AmountQualifierCode_01 { get; set; }
        [Required]
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(2)]
        public string PostageClaimedAmount_02 { get; set; }
        [DataElement("478", typeof(X12_ID_478))]
        [Pos(3)]
        public string CreditDebitFlagCode_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("AMT", typeof(X12_ID_522_5))]
    public class AMT_SalesTaxAmount
    {
        
        [Required]
        [DataElement("522", typeof(X12_ID_522_5))]
        [Pos(1)]
        public string AmountQualifierCode_01 { get; set; }
        [Required]
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(2)]
        public string SalesTaxAmount_02 { get; set; }
        [DataElement("478", typeof(X12_ID_478))]
        [Pos(3)]
        public string CreditDebitFlagCode_03 { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_REF_7
    {
        
        [Pos(1)]
        public REF_RepricedLineItemReferenceNumber REF_RepricedLineItemReferenceNumber { get; set; }
        [Pos(2)]
        public REF_AdjustedRepricedLineItemReferenceNumber REF_AdjustedRepricedLineItemReferenceNumber { get; set; }
        [ListCount(5)]
        [Pos(3)]
        public List<REF_PriorAuthorization_2> REF_PriorAuthorization_2 { get; set; }
        [Pos(4)]
        public REF_LineItemControlNumber REF_LineItemControlNumber { get; set; }
        [Pos(5)]
        public REF_MammographyCertificationNumber_2 REF_MammographyCertificationNumber_2 { get; set; }
        [Pos(6)]
        public REF_ClinicalLaboratoryImprovementAmendment_CLIA_Number_2 REF_ClinicalLaboratoryImprovementAmendment_CLIA_Number_2 { get; set; }
        [Pos(7)]
        public REF_ReferringClinicalLaboratoryImprovementAmendment_CLIA_FacilityIdentification REF_ReferringClinicalLaboratoryImprovementAmendment_CLIA_FacilityIdentification { get; set; }
        [Pos(8)]
        public REF_ImmunizationBatchNumber REF_ImmunizationBatchNumber { get; set; }
        [ListCount(5)]
        [Pos(9)]
        public List<REF_ReferralNumber_2> REF_ReferralNumber_2 { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_14))]
    public class REF_ReferralNumber_2
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_14))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferralNumber_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        [Pos(4)]
        public C040_ReferenceIdentifier_46 ReferenceIdentifier_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C040_ReferenceIdentifier_46")]
    public class C040_ReferenceIdentifier_46
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_31))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string OtherPayerPrimaryIdentifier_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_34))]
    public class REF_ImmunizationBatchNumber
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_34))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ImmunizationBatchNumber_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        [Pos(4)]
        public C040_ReferenceIdentifier_45 ReferenceIdentifier_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C040_ReferenceIdentifier_45")]
    public class C040_ReferenceIdentifier_45
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_33))]
    public class REF_ReferringClinicalLaboratoryImprovementAmendment_CLIA_FacilityIdentification
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_33))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferringCLIANumber_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        [Pos(4)]
        public C040_ReferenceIdentifier_44 ReferenceIdentifier_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C040_ReferenceIdentifier_44")]
    public class C040_ReferenceIdentifier_44
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_17))]
    public class REF_ClinicalLaboratoryImprovementAmendment_CLIA_Number_2
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_17))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ClinicalLaboratoryImprovementAmendmentNumber_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        [Pos(4)]
        public C040_ReferenceIdentifier_43 ReferenceIdentifier_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C040_ReferenceIdentifier_43")]
    public class C040_ReferenceIdentifier_43
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_13))]
    public class REF_MammographyCertificationNumber_2
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_13))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string MammographyCertificationNumber_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        [Pos(4)]
        public C040_ReferenceIdentifier_42 ReferenceIdentifier_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C040_ReferenceIdentifier_42")]
    public class C040_ReferenceIdentifier_42
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_32))]
    public class REF_LineItemControlNumber
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_32))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string LineItemControlNumber_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        [Pos(4)]
        public C040_ReferenceIdentifier_41 ReferenceIdentifier_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C040_ReferenceIdentifier_41")]
    public class C040_ReferenceIdentifier_41
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_15))]
    public class REF_PriorAuthorization_2
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_15))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string PriorAuthorizationorReferralNumber_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        [Pos(4)]
        public C040_ReferenceIdentifier_40 ReferenceIdentifier_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C040_ReferenceIdentifier_40")]
    public class C040_ReferenceIdentifier_40
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_31))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string OtherPayerPrimaryIdentifier_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_30))]
    public class REF_AdjustedRepricedLineItemReferenceNumber
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_30))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string AdjustedRepricedLineItemReferenceNumber_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        [Pos(4)]
        public C040_ReferenceIdentifier_39 ReferenceIdentifier_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C040_ReferenceIdentifier_39")]
    public class C040_ReferenceIdentifier_39
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_29))]
    public class REF_RepricedLineItemReferenceNumber
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_29))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string RepricedLineItemReferenceNumber_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        [Pos(4)]
        public C040_ReferenceIdentifier_38 ReferenceIdentifier_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C040_ReferenceIdentifier_38")]
    public class C040_ReferenceIdentifier_38
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("CN1", typeof(X12_ID_1166))]
    public class CN1_ContractInformation_2
    {
        
        [Required]
        [DataElement("1166", typeof(X12_ID_1166))]
        [Pos(1)]
        public string ContractTypeCode_01 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(2)]
        public string ContractAmount_02 { get; set; }
        [StringLength(1, 6)]
        [DataElement("332", typeof(X12_R))]
        [Pos(3)]
        public string ContractPercentage_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ContractCode_04 { get; set; }
        [StringLength(1, 6)]
        [DataElement("338", typeof(X12_R))]
        [Pos(5)]
        public string TermsDiscountPercentage_05 { get; set; }
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(6)]
        public string ContractVersionIdentifier_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("MEA", typeof(X12_ID_737), typeof(X12_ID_738))]
    public class MEA_TestResult
    {
        
        [Required]
        [DataElement("737", typeof(X12_ID_737))]
        [Pos(1)]
        public string MeasurementReferenceIdentificationCode_01 { get; set; }
        [Required]
        [DataElement("738", typeof(X12_ID_738))]
        [Pos(2)]
        public string MeasurementQualifier_02 { get; set; }
        [Required]
        [StringLength(1, 20)]
        [DataElement("739", typeof(X12_R))]
        [Pos(3)]
        public string TestResults_03 { get; set; }
        [Pos(4)]
        public C001_CompositeUnitofMeasure_4 CompositeUnitofMeasure_04 { get; set; }
        [StringLength(1, 20)]
        [DataElement("740", typeof(X12_R))]
        [Pos(5)]
        public string RangeMinimum_05 { get; set; }
        [StringLength(1, 20)]
        [DataElement("741", typeof(X12_R))]
        [Pos(6)]
        public string RangeMaximum_06 { get; set; }
        [DataElement("935", typeof(X12_ID_935))]
        [Pos(7)]
        public string MeasurementSignificanceCode_07 { get; set; }
        [DataElement("936", typeof(X12_ID_936))]
        [Pos(8)]
        public string MeasurementAttributeCode_08 { get; set; }
        [DataElement("752", typeof(X12_ID_752))]
        [Pos(9)]
        public string SurfaceLayerPositionCode_09 { get; set; }
        [DataElement("1373", typeof(X12_ID_1373))]
        [Pos(10)]
        public string MeasurementMethodorDevice_10 { get; set; }
        [DataElement("1270", typeof(X12_ID_1270))]
        [Pos(11)]
        public string CodeListQualifierCode_11 { get; set; }
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(12)]
        public string IndustryCode_12 { get; set; }
    }
    
    [Serializable()]
    [Composite("C001_CompositeUnitofMeasure_4")]
    public class C001_CompositeUnitofMeasure_4
    {
        
        [Required]
        [DataElement("355", typeof(X12_ID_355_2))]
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
        [DataElement("355", typeof(X12_ID_355_2))]
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
        [DataElement("355", typeof(X12_ID_355_2))]
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
        [DataElement("355", typeof(X12_ID_355_2))]
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
        [DataElement("355", typeof(X12_ID_355_2))]
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
    [All()]
    public class All_QTY
    {
        
        [Pos(1)]
        public QTY_AmbulancePatientCount QTY_AmbulancePatientCount { get; set; }
        [Pos(2)]
        public QTY_ObstetricAnesthesiaAdditionalUnits QTY_ObstetricAnesthesiaAdditionalUnits { get; set; }
    }
    
    [Serializable()]
    [Segment("QTY", typeof(X12_ID_673_2))]
    public class QTY_ObstetricAnesthesiaAdditionalUnits
    {
        
        [Required]
        [DataElement("673", typeof(X12_ID_673_2))]
        [Pos(1)]
        public string QuantityQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(2)]
        public string ObstetricAdditionalUnits_02 { get; set; }
        [Pos(3)]
        public C001_CompositeUnitofMeasure_3 CompositeUnitofMeasure_03 { get; set; }
        [StringLength(1, 30)]
        [DataElement("61", typeof(X12_AN))]
        [Pos(4)]
        public string FreeformInformation_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C001_CompositeUnitofMeasure_3")]
    public class C001_CompositeUnitofMeasure_3
    {
        
        [Required]
        [DataElement("355", typeof(X12_ID_355_2))]
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
        [DataElement("355", typeof(X12_ID_355_2))]
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
        [DataElement("355", typeof(X12_ID_355_2))]
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
        [DataElement("355", typeof(X12_ID_355_2))]
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
        [DataElement("355", typeof(X12_ID_355_2))]
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
    [Segment("QTY", typeof(X12_ID_673))]
    public class QTY_AmbulancePatientCount
    {
        
        [Required]
        [DataElement("673", typeof(X12_ID_673))]
        [Pos(1)]
        public string QuantityQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(2)]
        public string AmbulancePatientCount_02 { get; set; }
        [Pos(3)]
        public C001_CompositeUnitofMeasure_2 CompositeUnitofMeasure_03 { get; set; }
        [StringLength(1, 30)]
        [DataElement("61", typeof(X12_AN))]
        [Pos(4)]
        public string FreeformInformation_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C001_CompositeUnitofMeasure_2")]
    public class C001_CompositeUnitofMeasure_2
    {
        
        [Required]
        [DataElement("355", typeof(X12_ID_355_2))]
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
        [DataElement("355", typeof(X12_ID_355_2))]
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
        [DataElement("355", typeof(X12_ID_355_2))]
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
        [DataElement("355", typeof(X12_ID_355_2))]
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
        [DataElement("355", typeof(X12_ID_355_2))]
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
    [All()]
    public class All_DTP_2
    {
        
        [Required]
        [Pos(1)]
        public DTP_Date_ServiceDate DTP_Date_ServiceDate { get; set; }
        [Pos(2)]
        public DTP_Date_PrescriptionDate DTP_Date_PrescriptionDate { get; set; }
        [Pos(3)]
        public DTP_DATE_CertificationRevision_RecertificationDate DTP_DATE_CertificationRevision_RecertificationDate { get; set; }
        [Pos(4)]
        public DTP_Date_BeginTherapyDate DTP_Date_BeginTherapyDate { get; set; }
        [Pos(5)]
        public DTP_Date_LastCertificationDate DTP_Date_LastCertificationDate { get; set; }
        [Pos(6)]
        public DTP_Date_LastSeenDate_2 DTP_Date_LastSeenDate_2 { get; set; }
        [ListCount(2)]
        [Pos(7)]
        public List<DTP_Date_TestDate> DTP_Date_TestDate { get; set; }
        [Pos(8)]
        public DTP_Date_ShippedDate DTP_Date_ShippedDate { get; set; }
        [Pos(9)]
        public DTP_Date_LastX_rayDate_2 DTP_Date_LastX_rayDate_2 { get; set; }
        [Pos(10)]
        public DTP_Date_InitialTreatmentDate_2 DTP_Date_InitialTreatmentDate_2 { get; set; }
    }
    
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_3), typeof(X12_ID_1250))]
    public class DTP_Date_InitialTreatmentDate_2
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
        public string InitialTreatmentDate_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_8), typeof(X12_ID_1250))]
    public class DTP_Date_LastX_rayDate_2
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374_8))]
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
        public string LastXRayDate_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_24), typeof(X12_ID_1250))]
    public class DTP_Date_ShippedDate
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374_24))]
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
        public string ShippedDate_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_23), typeof(X12_ID_1250))]
    public class DTP_Date_TestDate
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374_23))]
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
        public string TestPerformedDate_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_4), typeof(X12_ID_1250))]
    public class DTP_Date_LastSeenDate_2
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374_4))]
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
        public string TreatmentorTherapyDate_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_22), typeof(X12_ID_1250))]
    public class DTP_Date_LastCertificationDate
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374_22))]
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
        public string LastCertificationDate_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_21), typeof(X12_ID_1250))]
    public class DTP_Date_BeginTherapyDate
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374_21))]
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
        public string BeginTherapyDate_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_20), typeof(X12_ID_1250))]
    public class DTP_DATE_CertificationRevision_RecertificationDate
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374_20))]
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
        public string CertificationRevisionorRecertificationDate_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_9), typeof(X12_ID_1250))]
    public class DTP_Date_PrescriptionDate
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374_9))]
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
        public string PrescriptionDate_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_19), typeof(X12_ID_1250_2))]
    public class DTP_Date_ServiceDate
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374_19))]
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
        public string ServiceDate_03 { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_CRC_2
    {
        
        [ListCount(3)]
        [Pos(1)]
        public List<CRC_AmbulanceCertification_2> CRC_AmbulanceCertification_2 { get; set; }
        [Pos(2)]
        public CRC_HospiceEmployeeIndicator CRC_HospiceEmployeeIndicator { get; set; }
        [Pos(3)]
        public CRC_ConditionIndicator_DurableMedicalEquipment CRC_ConditionIndicator_DurableMedicalEquipment { get; set; }
    }
    
    [Serializable()]
    [Segment("CRC", typeof(X12_ID_1136_6), typeof(X12_ID_1073_3))]
    public class CRC_ConditionIndicator_DurableMedicalEquipment
    {
        
        [Required]
        [DataElement("1136", typeof(X12_ID_1136_6))]
        [Pos(1)]
        public string CodeCategory_01 { get; set; }
        [Required]
        [DataElement("1073", typeof(X12_ID_1073_3))]
        [Pos(2)]
        public string CertificationConditionIndicator_02 { get; set; }
        [Required]
        [DataElement("1321", typeof(X12_ID_1321_7))]
        [Pos(3)]
        public string ConditionIndicator_03 { get; set; }
        [DataElement("1321", typeof(X12_ID_1321_7))]
        [Pos(4)]
        public string ConditionIndicator_04 { get; set; }
        [DataElement("1321", typeof(X12_ID_1321_4))]
        [Pos(5)]
        public string ConditionIndicator_05 { get; set; }
        [DataElement("1321", typeof(X12_ID_1321_4))]
        [Pos(6)]
        public string ConditionIndicator_06 { get; set; }
        [DataElement("1321", typeof(X12_ID_1321_4))]
        [Pos(7)]
        public string ConditionIndicator_07 { get; set; }
    }
    
    [Serializable()]
    [Segment("CRC", typeof(X12_ID_1136_5), typeof(X12_ID_1073_3))]
    public class CRC_HospiceEmployeeIndicator
    {
        
        [Required]
        [DataElement("1136", typeof(X12_ID_1136_5))]
        [Pos(1)]
        public string CodeCategory_01 { get; set; }
        [Required]
        [DataElement("1073", typeof(X12_ID_1073_3))]
        [Pos(2)]
        public string HospiceEmployedProviderIndicator_02 { get; set; }
        [Required]
        [DataElement("1321", typeof(X12_ID_1321_6))]
        [Pos(3)]
        public string ConditionIndicator_03 { get; set; }
        [DataElement("1321", typeof(X12_ID_1321_4))]
        [Pos(4)]
        public string ConditionIndicator_04 { get; set; }
        [DataElement("1321", typeof(X12_ID_1321_4))]
        [Pos(5)]
        public string ConditionIndicator_05 { get; set; }
        [DataElement("1321", typeof(X12_ID_1321_4))]
        [Pos(6)]
        public string ConditionIndicator_06 { get; set; }
        [DataElement("1321", typeof(X12_ID_1321_4))]
        [Pos(7)]
        public string ConditionIndicator_07 { get; set; }
    }
    
    [Serializable()]
    [Segment("CRC", typeof(X12_ID_1136), typeof(X12_ID_1073_3))]
    public class CRC_AmbulanceCertification_2
    {
        
        [Required]
        [DataElement("1136", typeof(X12_ID_1136))]
        [Pos(1)]
        public string CodeCategory_01 { get; set; }
        [Required]
        [DataElement("1073", typeof(X12_ID_1073_3))]
        [Pos(2)]
        public string CertificationConditionIndicator_02 { get; set; }
        [Required]
        [DataElement("1321", typeof(X12_ID_1321))]
        [Pos(3)]
        public string ConditionCode_03 { get; set; }
        [DataElement("1321", typeof(X12_ID_1321))]
        [Pos(4)]
        public string ConditionCode_04 { get; set; }
        [DataElement("1321", typeof(X12_ID_1321))]
        [Pos(5)]
        public string ConditionCode_05 { get; set; }
        [DataElement("1321", typeof(X12_ID_1321))]
        [Pos(6)]
        public string ConditionCode_06 { get; set; }
        [DataElement("1321", typeof(X12_ID_1321))]
        [Pos(7)]
        public string ConditionCode_07 { get; set; }
    }
    
    [Serializable()]
    [Segment("CR3", typeof(X12_ID_1322), typeof(X12_ID_355_7))]
    public class CR3_DurableMedicalEquipmentCertification
    {
        
        [Required]
        [DataElement("1322", typeof(X12_ID_1322))]
        [Pos(1)]
        public string CertificationTypeCode_01 { get; set; }
        [Required]
        [DataElement("355", typeof(X12_ID_355_7))]
        [Pos(2)]
        public string UnitorBasisforMeasurementCode_02 { get; set; }
        [Required]
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(3)]
        public string DurableMedicalEquipmentDuration_03 { get; set; }
        [DataElement("1335", typeof(X12_ID_1335))]
        [Pos(4)]
        public string InsulinDependentCode_04 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(5)]
        public string Description_05 { get; set; }
    }
    
    [Serializable()]
    [Segment("CR1", typeof(X12_ID_355_3))]
    public class CR1_AmbulanceTransportInformation_2
    {
        
        [DataElement("355", typeof(X12_ID_355_3))]
        [Pos(1)]
        public string UnitorBasisforMeasurementCode_01 { get; set; }
        [StringLength(1, 10)]
        [DataElement("81", typeof(X12_R))]
        [Pos(2)]
        public string PatientWeight_02 { get; set; }
        [DataElement("1316", typeof(X12_ID_1316))]
        [Pos(3)]
        public string AmbulanceTransportCode_03 { get; set; }
        [Required]
        [DataElement("1317", typeof(X12_ID_1317))]
        [Pos(4)]
        public string AmbulanceTransportReasonCode_04 { get; set; }
        [Required]
        [DataElement("355", typeof(X12_ID_355_4))]
        [Pos(5)]
        public string UnitorBasisforMeasurementCode_05 { get; set; }
        [Required]
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        public string TransportDistance_06 { get; set; }
        [StringLength(1, 55)]
        [DataElement("166", typeof(X12_AN))]
        [Pos(7)]
        public string AddressInformation_07 { get; set; }
        [StringLength(1, 55)]
        [DataElement("166", typeof(X12_AN))]
        [Pos(8)]
        public string AddressInformation_08 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(9)]
        public string RoundTripPurposeDescription_09 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(10)]
        public string StretcherPurposeDescription_10 { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_PWK
    {
        
        [ListCount(10)]
        [Pos(1)]
        public List<PWK_LineSupplementalInformation> PWK_LineSupplementalInformation { get; set; }
        [Pos(2)]
        public PWK_DurableMedicalEquipmentCertificateofMedicalNecessityIndicator PWK_DurableMedicalEquipmentCertificateofMedicalNecessityIndicator { get; set; }
    }
    
    [Serializable()]
    [Segment("PWK", typeof(X12_ID_755_3), typeof(X12_ID_756_2))]
    public class PWK_DurableMedicalEquipmentCertificateofMedicalNecessityIndicator
    {
        
        [Required]
        [DataElement("755", typeof(X12_ID_755_3))]
        [Pos(1)]
        public string AttachmentReportTypeCode_01 { get; set; }
        [Required]
        [DataElement("756", typeof(X12_ID_756_2))]
        [Pos(2)]
        public string AttachmentTransmissionCode_02 { get; set; }
        [StringLength(1, 2)]
        [DataElement("757", typeof(X12_N0))]
        [Pos(3)]
        public string ReportCopiesNeeded_03 { get; set; }
        [DataElement("98", typeof(X12_ID_98_2))]
        [Pos(4)]
        public string EntityIdentifierCode_04 { get; set; }
        [DataElement("66", typeof(X12_ID_66_3))]
        [Pos(5)]
        public string IdentificationCodeQualifier_05 { get; set; }
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(6)]
        public string IdentificationCode_06 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(7)]
        public string Description_07 { get; set; }
        [Pos(8)]
        public C002_ActionsIndicated_3 ActionsIndicated_08 { get; set; }
        [DataElement("1525", typeof(X12_ID_1525))]
        [Pos(9)]
        public string RequestCategoryCode_09 { get; set; }
    }
    
    [Serializable()]
    [Composite("C002_ActionsIndicated_3")]
    public class C002_ActionsIndicated_3
    {
        
        [Required]
        [DataElement("704", typeof(X12_ID_704))]
        [Pos(1)]
        public string PaperworkReportActionCode_01 { get; set; }
        [DataElement("704", typeof(X12_ID_704))]
        [Pos(2)]
        public string PaperworkReportActionCode_02 { get; set; }
        [DataElement("704", typeof(X12_ID_704))]
        [Pos(3)]
        public string PaperworkReportActionCode_03 { get; set; }
        [DataElement("704", typeof(X12_ID_704))]
        [Pos(4)]
        public string PaperworkReportActionCode_04 { get; set; }
        [DataElement("704", typeof(X12_ID_704))]
        [Pos(5)]
        public string PaperworkReportActionCode_05 { get; set; }
    }
    
    [Serializable()]
    [Segment("PWK", typeof(X12_ID_755_2), typeof(X12_ID_756))]
    public class PWK_LineSupplementalInformation
    {
        
        [Required]
        [DataElement("755", typeof(X12_ID_755_2))]
        [Pos(1)]
        public string AttachmentReportTypeCode_01 { get; set; }
        [Required]
        [DataElement("756", typeof(X12_ID_756))]
        [Pos(2)]
        public string AttachmentTransmissionCode_02 { get; set; }
        [StringLength(1, 2)]
        [DataElement("757", typeof(X12_N0))]
        [Pos(3)]
        public string ReportCopiesNeeded_03 { get; set; }
        [DataElement("98", typeof(X12_ID_98_2))]
        [Pos(4)]
        public string EntityIdentifierCode_04 { get; set; }
        [DataElement("66", typeof(X12_ID_66_6))]
        [Pos(5)]
        public string IdentificationCodeQualifier_05 { get; set; }
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(6)]
        public string AttachmentControlNumber_06 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(7)]
        public string Description_07 { get; set; }
        [Pos(8)]
        public C002_ActionsIndicated_2 ActionsIndicated_08 { get; set; }
        [DataElement("1525", typeof(X12_ID_1525))]
        [Pos(9)]
        public string RequestCategoryCode_09 { get; set; }
    }
    
    [Serializable()]
    [Composite("C002_ActionsIndicated_2")]
    public class C002_ActionsIndicated_2
    {
        
        [Required]
        [DataElement("704", typeof(X12_ID_704))]
        [Pos(1)]
        public string PaperworkReportActionCode_01 { get; set; }
        [DataElement("704", typeof(X12_ID_704))]
        [Pos(2)]
        public string PaperworkReportActionCode_02 { get; set; }
        [DataElement("704", typeof(X12_ID_704))]
        [Pos(3)]
        public string PaperworkReportActionCode_03 { get; set; }
        [DataElement("704", typeof(X12_ID_704))]
        [Pos(4)]
        public string PaperworkReportActionCode_04 { get; set; }
        [DataElement("704", typeof(X12_ID_704))]
        [Pos(5)]
        public string PaperworkReportActionCode_05 { get; set; }
    }
    
    [Serializable()]
    [Segment("SV5", typeof(X12_ID_235_3), typeof(X12_ID_355_6))]
    public class SV5_DurableMedicalEquipmentService
    {
        
        [Required]
        [Pos(1)]
        public C003_CompositeMedicalProcedureIdentifier_2 CompositeMedicalProcedureIdentifier_01 { get; set; }
        [Required]
        [DataElement("355", typeof(X12_ID_355_6))]
        [Pos(2)]
        public string UnitorBasisforMeasurementCode_02 { get; set; }
        [Required]
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(3)]
        public string LengthofMedicalNecessity_03 { get; set; }
        [Required]
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(4)]
        public string DMERentalPrice_04 { get; set; }
        [Required]
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(5)]
        public string DMEPurchasePrice_05 { get; set; }
        [Required]
        [DataElement("594", typeof(X12_ID_594))]
        [Pos(6)]
        public string RentalUnitPriceIndicator_06 { get; set; }
        [DataElement("923", typeof(X12_ID_923))]
        [Pos(7)]
        public string PrognosisCode_07 { get; set; }
    }
    
    [Serializable()]
    [Composite("C003_CompositeMedicalProcedureIdentifier_2")]
    public class C003_CompositeMedicalProcedureIdentifier_2
    {
        
        [Required]
        [DataElement("235", typeof(X12_ID_235_3))]
        [Pos(1)]
        public string ProcedureIdentifier_01 { get; set; }
        [Required]
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(2)]
        public string ProcedureCode_02 { get; set; }
        [StringLength(2, 2)]
        [DataElement("1339", typeof(X12_AN))]
        [Pos(3)]
        public string ProcedureModifier_03 { get; set; }
        [StringLength(2, 2)]
        [DataElement("1339", typeof(X12_AN))]
        [Pos(4)]
        public string ProcedureModifier_04 { get; set; }
        [StringLength(2, 2)]
        [DataElement("1339", typeof(X12_AN))]
        [Pos(5)]
        public string ProcedureModifier_05 { get; set; }
        [StringLength(2, 2)]
        [DataElement("1339", typeof(X12_AN))]
        [Pos(6)]
        public string ProcedureModifier_06 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(7)]
        public string Description_07 { get; set; }
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(8)]
        public string ProductServiceID_08 { get; set; }
    }
    
    [Serializable()]
    [Segment("SV1", typeof(X12_ID_235_2))]
    public class SV1_ProfessionalService
    {
        
        [Required]
        [Pos(1)]
        public C003_CompositeMedicalProcedureIdentifier CompositeMedicalProcedureIdentifier_01 { get; set; }
        [Required]
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(2)]
        public string LineItemChargeAmount_02 { get; set; }
        [Required]
        [DataElement("355", typeof(X12_ID_355_5))]
        [Pos(3)]
        public string UnitorBasisforMeasurementCode_03 { get; set; }
        [Required]
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(4)]
        public string ServiceUnitCount_04 { get; set; }
        [StringLength(1, 2)]
        [DataElement("1331", typeof(X12_AN))]
        [Pos(5)]
        public string PlaceofServiceCode_05 { get; set; }
        [DataElement("1365", typeof(X12_ID_1365))]
        [Pos(6)]
        public string ServiceTypeCode_06 { get; set; }
        [Required]
        [Pos(7)]
        public C004_CompositeDiagnosisCodePointer CompositeDiagnosisCodePointer_07 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(8)]
        public string MonetaryAmount_08 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073_2))]
        [Pos(9)]
        public string EmergencyIndicator_09 { get; set; }
        [DataElement("1340", typeof(X12_ID_1340))]
        [Pos(10)]
        public string MultipleProcedureCode_10 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073_2))]
        [Pos(11)]
        public string EPSDTIndicator_11 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073_2))]
        [Pos(12)]
        public string FamilyPlanningIndicator_12 { get; set; }
        [DataElement("1364", typeof(X12_ID_1364))]
        [Pos(13)]
        public string ReviewCode_13 { get; set; }
        [StringLength(1, 2)]
        [DataElement("1341", typeof(X12_AN))]
        [Pos(14)]
        public string NationalorLocalAssignedReviewValue_14 { get; set; }
        [DataElement("1327", typeof(X12_ID_1327))]
        [Pos(15)]
        public string CoPayStatusCode_15 { get; set; }
        [StringLength(1, 1)]
        [DataElement("1334", typeof(X12_ID))]
        [Pos(16)]
        public string HealthCareProfessionalShortageAreaCode_16 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(17)]
        public string ReferenceIdentification_17 { get; set; }
        [StringLength(3, 15)]
        [DataElement("116", typeof(X12_ID))]
        [Pos(18)]
        public string PostalCode_18 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(19)]
        public string MonetaryAmount_19 { get; set; }
        [DataElement("1337", typeof(X12_ID_1337))]
        [Pos(20)]
        public string LevelofCareCode_20 { get; set; }
        [DataElement("1360", typeof(X12_ID_1360))]
        [Pos(21)]
        public string ProviderAgreementCode_21 { get; set; }
    }
    
    [Serializable()]
    [Composite("C004_CompositeDiagnosisCodePointer")]
    public class C004_CompositeDiagnosisCodePointer
    {
        
        [Required]
        [StringLength(1, 2)]
        [DataElement("1328", typeof(X12_N0))]
        [Pos(1)]
        public string DiagnosisCodePointer_01 { get; set; }
        [StringLength(1, 2)]
        [DataElement("1328", typeof(X12_N0))]
        [Pos(2)]
        public string DiagnosisCodePointer_02 { get; set; }
        [StringLength(1, 2)]
        [DataElement("1328", typeof(X12_N0))]
        [Pos(3)]
        public string DiagnosisCodePointer_03 { get; set; }
        [StringLength(1, 2)]
        [DataElement("1328", typeof(X12_N0))]
        [Pos(4)]
        public string DiagnosisCodePointer_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C003_CompositeMedicalProcedureIdentifier")]
    public class C003_CompositeMedicalProcedureIdentifier
    {
        
        [Required]
        [DataElement("235", typeof(X12_ID_235_2))]
        [Pos(1)]
        public string ProductorServiceIDQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(2)]
        public string ProcedureCode_02 { get; set; }
        [StringLength(2, 2)]
        [DataElement("1339", typeof(X12_AN))]
        [Pos(3)]
        public string ProcedureModifier_03 { get; set; }
        [StringLength(2, 2)]
        [DataElement("1339", typeof(X12_AN))]
        [Pos(4)]
        public string ProcedureModifier_04 { get; set; }
        [StringLength(2, 2)]
        [DataElement("1339", typeof(X12_AN))]
        [Pos(5)]
        public string ProcedureModifier_05 { get; set; }
        [StringLength(2, 2)]
        [DataElement("1339", typeof(X12_AN))]
        [Pos(6)]
        public string ProcedureModifier_06 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(7)]
        public string Description_07 { get; set; }
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(8)]
        public string ProductServiceID_08 { get; set; }
    }
    
    [Serializable()]
    [Segment("LX")]
    public class LX_ServiceLineNumber
    {
        
        [Required]
        [StringLength(1, 6)]
        [DataElement("554", typeof(X12_N0))]
        [Pos(1)]
        public string AssignedNumber_01 { get; set; }
    }
    
    [Serializable()]
    [Group("SBR")]
    public class Loop_2320
    {
        
        [Required]
        [Pos(1)]
        public SBR_OtherSubscriberInformation SBR_OtherSubscriberInformation { get; set; }
        [ListCount(5)]
        [Pos(2)]
        public List<CAS_ClaimLevelAdjustments> CAS_ClaimLevelAdjustments { get; set; }
        [Pos(3)]
        public All_AMT All_AMT { get; set; }
        [Required]
        [Pos(4)]
        public OI_OtherInsuranceCoverageInformation OI_OtherInsuranceCoverageInformation { get; set; }
        [Pos(5)]
        public MOA_OutpatientAdjudicationInformation MOA_OutpatientAdjudicationInformation { get; set; }
        [Required]
        [Pos(6)]
        public All_NM1_5 All_NM1_5 { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_NM1_5
    {
        
        [Required]
        [Pos(1)]
        public Loop_2330A Loop_2330A { get; set; }
        [Required]
        [Pos(2)]
        public Loop_2330B Loop_2330B { get; set; }
        [ListCount(2)]
        [Pos(3)]
        public List<Loop_2330C> Loop_2330C { get; set; }
        [Pos(4)]
        public Loop_2330D Loop_2330D { get; set; }
        [Pos(5)]
        public Loop_2330E Loop_2330E { get; set; }
        [Pos(6)]
        public Loop_2330F Loop_2330F { get; set; }
        [Pos(7)]
        public Loop_2330G Loop_2330G { get; set; }
    }
    
    [Serializable()]
    [Group("NM1")]
    public class Loop_2330G
    {
        
        [Required]
        [Pos(1)]
        public NM1_OtherPayerBillingProvider NM1_OtherPayerBillingProvider { get; set; }
        [Required]
        [ListCount(2)]
        [Pos(2)]
        public List<REF_OtherPayerBillingProviderSecondaryIdentification> REF_OtherPayerBillingProviderSecondaryIdentification { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_10))]
    public class REF_OtherPayerBillingProviderSecondaryIdentification
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_10))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string OtherPayerBillingProviderIdentifier_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        [Pos(4)]
        public C040_ReferenceIdentifier_37 ReferenceIdentifier_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C040_ReferenceIdentifier_37")]
    public class C040_ReferenceIdentifier_37
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_4), typeof(X12_ID_1065))]
    public class NM1_OtherPayerBillingProvider
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98_4))]
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
    public class Loop_2330F
    {
        
        [Required]
        [Pos(1)]
        public NM1_OtherPayerSupervisingProvider NM1_OtherPayerSupervisingProvider { get; set; }
        [Required]
        [ListCount(3)]
        [Pos(2)]
        public List<REF_OtherPayerSupervisingProviderSecondaryIdentification> REF_OtherPayerSupervisingProviderSecondaryIdentification { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_26))]
    public class REF_OtherPayerSupervisingProviderSecondaryIdentification
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_26))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string OtherPayerSupervisingProviderIdentifier_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        [Pos(4)]
        public C040_ReferenceIdentifier_36 ReferenceIdentifier_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C040_ReferenceIdentifier_36")]
    public class C040_ReferenceIdentifier_36
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_12), typeof(X12_ID_1065_3))]
    public class NM1_OtherPayerSupervisingProvider
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98_12))]
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        [Required]
        [DataElement("1065", typeof(X12_ID_1065_3))]
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
    public class Loop_2330E
    {
        
        [Required]
        [Pos(1)]
        public NM1_OtherPayerServiceFacilityLocation NM1_OtherPayerServiceFacilityLocation { get; set; }
        [Required]
        [ListCount(3)]
        [Pos(2)]
        public List<REF_OtherPayerServiceFacilityLocationSecondaryIdentification> REF_OtherPayerServiceFacilityLocationSecondaryIdentification { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_27))]
    public class REF_OtherPayerServiceFacilityLocationSecondaryIdentification
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_27))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string OtherPayerServiceFacilityLocationSecondaryIdentifier_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        [Pos(4)]
        public C040_ReferenceIdentifier_35 ReferenceIdentifier_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C040_ReferenceIdentifier_35")]
    public class C040_ReferenceIdentifier_35
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_11), typeof(X12_ID_1065_2))]
    public class NM1_OtherPayerServiceFacilityLocation
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98_11))]
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        [Required]
        [DataElement("1065", typeof(X12_ID_1065_2))]
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
    public class Loop_2330D
    {
        
        [Required]
        [Pos(1)]
        public NM1_OtherPayerRenderingProvider NM1_OtherPayerRenderingProvider { get; set; }
        [Required]
        [ListCount(3)]
        [Pos(2)]
        public List<REF_OtherPayerRenderingProviderSecondaryIdentification> REF_OtherPayerRenderingProviderSecondaryIdentification { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_26))]
    public class REF_OtherPayerRenderingProviderSecondaryIdentification
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_26))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string OtherPayerRenderingProviderSecondaryIdentifier_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        [Pos(4)]
        public C040_ReferenceIdentifier_34 ReferenceIdentifier_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C040_ReferenceIdentifier_34")]
    public class C040_ReferenceIdentifier_34
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_10), typeof(X12_ID_1065))]
    public class NM1_OtherPayerRenderingProvider
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98_10))]
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
    public class Loop_2330C
    {
        
        [Required]
        [Pos(1)]
        public NM1_OtherPayerReferringProvider NM1_OtherPayerReferringProvider { get; set; }
        [Required]
        [ListCount(3)]
        [Pos(2)]
        public List<REF_OtherPayerReferringProviderSecondaryIdentification> REF_OtherPayerReferringProviderSecondaryIdentification { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_25))]
    public class REF_OtherPayerReferringProviderSecondaryIdentification
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_25))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string OtherPayerReferringProviderIdentifier_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        [Pos(4)]
        public C040_ReferenceIdentifier_33 ReferenceIdentifier_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C040_ReferenceIdentifier_33")]
    public class C040_ReferenceIdentifier_33
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_9), typeof(X12_ID_1065_3))]
    public class NM1_OtherPayerReferringProvider
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98_9))]
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        [Required]
        [DataElement("1065", typeof(X12_ID_1065_3))]
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
    public class Loop_2330B
    {
        
        [Required]
        [Pos(1)]
        public NM1_OtherPayerName NM1_OtherPayerName { get; set; }
        [Pos(2)]
        public N3_OtherPayerAddress N3_OtherPayerAddress { get; set; }
        [Pos(3)]
        public N4_OtherPayerCity_State_ZIPCode N4_OtherPayerCity_State_ZIPCode { get; set; }
        [Pos(4)]
        public DTP_ClaimCheckorRemittanceDate DTP_ClaimCheckorRemittanceDate { get; set; }
        [Pos(5)]
        public All_REF_6 All_REF_6 { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_REF_6
    {
        
        [ListCount(2)]
        [Pos(1)]
        public List<REF_OtherPayerSecondaryIdentifier> REF_OtherPayerSecondaryIdentifier { get; set; }
        [Pos(2)]
        public REF_OtherPayerPriorAuthorizationNumber REF_OtherPayerPriorAuthorizationNumber { get; set; }
        [Pos(3)]
        public REF_OtherPayerReferralNumber REF_OtherPayerReferralNumber { get; set; }
        [Pos(4)]
        public REF_OtherPayerClaimAdjustmentIndicator REF_OtherPayerClaimAdjustmentIndicator { get; set; }
        [Pos(5)]
        public REF_OtherPayerClaimControlNumber REF_OtherPayerClaimControlNumber { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_16))]
    public class REF_OtherPayerClaimControlNumber
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_16))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string OtherPayersClaimControlNumber_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        [Pos(4)]
        public C040_ReferenceIdentifier_32 ReferenceIdentifier_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C040_ReferenceIdentifier_32")]
    public class C040_ReferenceIdentifier_32
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_28))]
    public class REF_OtherPayerClaimAdjustmentIndicator
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_28))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string OtherPayerClaimAdjustmentIndicator_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        [Pos(4)]
        public C040_ReferenceIdentifier_31 ReferenceIdentifier_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C040_ReferenceIdentifier_31")]
    public class C040_ReferenceIdentifier_31
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_14))]
    public class REF_OtherPayerReferralNumber
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_14))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string OtherPayerPriorAuthorizationorReferralNumber_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        [Pos(4)]
        public C040_ReferenceIdentifier_30 ReferenceIdentifier_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C040_ReferenceIdentifier_30")]
    public class C040_ReferenceIdentifier_30
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_15))]
    public class REF_OtherPayerPriorAuthorizationNumber
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_15))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string OtherPayerPriorAuthorizationNumber_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        [Pos(4)]
        public C040_ReferenceIdentifier_29 ReferenceIdentifier_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C040_ReferenceIdentifier_29")]
    public class C040_ReferenceIdentifier_29
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_9))]
    public class REF_OtherPayerSecondaryIdentifier
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_9))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string OtherPayerSecondaryIdentifier_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        [Pos(4)]
        public C040_ReferenceIdentifier_28 ReferenceIdentifier_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C040_ReferenceIdentifier_28")]
    public class C040_ReferenceIdentifier_28
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_18), typeof(X12_ID_1250))]
    public class DTP_ClaimCheckorRemittanceDate
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374_18))]
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
        public string AdjudicationorPaymentDate_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("N4")]
    public class N4_OtherPayerCity_State_ZIPCode
    {
        
        [Required]
        [StringLength(2, 30)]
        [DataElement("19", typeof(X12_AN))]
        [Pos(1)]
        public string OtherPayerCityName_01 { get; set; }
        [StringLength(2, 2)]
        [DataElement("156", typeof(X12_ID))]
        [Pos(2)]
        public string OtherPayerStateorProvinceCode_02 { get; set; }
        [StringLength(3, 15)]
        [DataElement("116", typeof(X12_ID))]
        [Pos(3)]
        public string OtherPayerPostalZoneorZIPCode_03 { get; set; }
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
    [Segment("N3")]
    public class N3_OtherPayerAddress
    {
        
        [Required]
        [StringLength(1, 55)]
        [DataElement("166", typeof(X12_AN))]
        [Pos(1)]
        public string OtherPayerAddressLine_01 { get; set; }
        [StringLength(1, 55)]
        [DataElement("166", typeof(X12_AN))]
        [Pos(2)]
        public string OtherPayerAddressLine_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_8), typeof(X12_ID_1065_2))]
    public class NM1_OtherPayerName
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98_8))]
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        [Required]
        [DataElement("1065", typeof(X12_ID_1065_2))]
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        [Required]
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(3)]
        public string OtherPayerOrganizationName_03 { get; set; }
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
        [Required]
        [DataElement("66", typeof(X12_ID_66_4))]
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        [Required]
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(9)]
        public string OtherPayerPrimaryIdentifier_09 { get; set; }
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
    public class Loop_2330A
    {
        
        [Required]
        [Pos(1)]
        public NM1_OtherSubscriberName NM1_OtherSubscriberName { get; set; }
        [Pos(2)]
        public N3_OtherSubscriberAddress N3_OtherSubscriberAddress { get; set; }
        [Pos(3)]
        public N4_OtherSubscriberCity_State_ZIPCode N4_OtherSubscriberCity_State_ZIPCode { get; set; }
        [Pos(4)]
        public REF_OtherSubscriberSecondaryIdentification REF_OtherSubscriberSecondaryIdentification { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_7))]
    public class REF_OtherSubscriberSecondaryIdentification
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_7))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string OtherInsuredAdditionalIdentifier_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        [Pos(4)]
        public C040_ReferenceIdentifier_27 ReferenceIdentifier_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C040_ReferenceIdentifier_27")]
    public class C040_ReferenceIdentifier_27
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("N4")]
    public class N4_OtherSubscriberCity_State_ZIPCode
    {
        
        [Required]
        [StringLength(2, 30)]
        [DataElement("19", typeof(X12_AN))]
        [Pos(1)]
        public string OtherSubscriberCityName_01 { get; set; }
        [StringLength(2, 2)]
        [DataElement("156", typeof(X12_ID))]
        [Pos(2)]
        public string OtherSubscriberStateorProvinceCode_02 { get; set; }
        [StringLength(3, 15)]
        [DataElement("116", typeof(X12_ID))]
        [Pos(3)]
        public string OtherSubscriberPostalZoneorZIPCode_03 { get; set; }
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
    [Segment("N3")]
    public class N3_OtherSubscriberAddress
    {
        
        [Required]
        [StringLength(1, 55)]
        [DataElement("166", typeof(X12_AN))]
        [Pos(1)]
        public string OtherInsuredAddressLine_01 { get; set; }
        [StringLength(1, 55)]
        [DataElement("166", typeof(X12_AN))]
        [Pos(2)]
        public string OtherInsuredAddressLine_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_7), typeof(X12_ID_1065))]
    public class NM1_OtherSubscriberName
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98_7))]
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
        public string OtherInsuredLastName_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1036", typeof(X12_AN))]
        [Pos(4)]
        public string OtherInsuredFirstName_04 { get; set; }
        [StringLength(1, 25)]
        [DataElement("1037", typeof(X12_AN))]
        [Pos(5)]
        public string OtherInsuredMiddleName_05 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1038", typeof(X12_AN))]
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1039", typeof(X12_AN))]
        [Pos(7)]
        public string OtherInsuredNameSuffix_07 { get; set; }
        [Required]
        [DataElement("66", typeof(X12_ID_66_5))]
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        [Required]
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(9)]
        public string OtherInsuredIdentifier_09 { get; set; }
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
    [Segment("MOA")]
    public class MOA_OutpatientAdjudicationInformation
    {
        
        [StringLength(1, 10)]
        [DataElement("954", typeof(X12_R))]
        [Pos(1)]
        public string ReimbursementRate_01 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(2)]
        public string HCPCSPayableAmount_02 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(3)]
        public string ClaimPaymentRemarkCode_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ClaimPaymentRemarkCode_04 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(5)]
        public string ClaimPaymentRemarkCode_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ClaimPaymentRemarkCode_06 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(7)]
        public string ClaimPaymentRemarkCode_07 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(8)]
        public string EndStageRenalDiseasePaymentAmount_08 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(9)]
        public string NonPayableProfessionalComponentBilledAmount_09 { get; set; }
    }
    
    [Serializable()]
    [Segment("OI", typeof(X12_ID_1032_2), typeof(X12_ID_1383))]
    public class OI_OtherInsuranceCoverageInformation
    {
        
        [DataElement("1032", typeof(X12_ID_1032_2))]
        [Pos(1)]
        public string ClaimFilingIndicatorCode_01 { get; set; }
        [DataElement("1383", typeof(X12_ID_1383))]
        [Pos(2)]
        public string ClaimSubmissionReasonCode_02 { get; set; }
        [Required]
        [DataElement("1073", typeof(X12_ID_1073_4))]
        [Pos(3)]
        public string BenefitsAssignmentCertificationIndicator_03 { get; set; }
        [DataElement("1351", typeof(X12_ID_1351))]
        [Pos(4)]
        public string PatientSignatureSourceCode_04 { get; set; }
        [DataElement("1360", typeof(X12_ID_1360))]
        [Pos(5)]
        public string ProviderAgreementCode_05 { get; set; }
        [Required]
        [DataElement("1363", typeof(X12_ID_1363))]
        [Pos(6)]
        public string ReleaseofInformationCode_06 { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_AMT
    {
        
        [Pos(1)]
        public AMT_CoordinationofBenefits_COB_PayerPaidAmount AMT_CoordinationofBenefits_COB_PayerPaidAmount { get; set; }
        [Pos(2)]
        public AMT_CoordinationofBenefits_COB_TotalNon_coveredAmount AMT_CoordinationofBenefits_COB_TotalNon_coveredAmount { get; set; }
        [Pos(3)]
        public AMT_RemainingPatientLiability AMT_RemainingPatientLiability { get; set; }
    }
    
    [Serializable()]
    [Segment("AMT", typeof(X12_ID_522_4))]
    public class AMT_RemainingPatientLiability
    {
        
        [Required]
        [DataElement("522", typeof(X12_ID_522_4))]
        [Pos(1)]
        public string AmountQualifierCode_01 { get; set; }
        [Required]
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(2)]
        public string RemainingPatientLiability_02 { get; set; }
        [DataElement("478", typeof(X12_ID_478))]
        [Pos(3)]
        public string CreditDebitFlagCode_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("AMT", typeof(X12_ID_522_3))]
    public class AMT_CoordinationofBenefits_COB_TotalNon_coveredAmount
    {
        
        [Required]
        [DataElement("522", typeof(X12_ID_522_3))]
        [Pos(1)]
        public string AmountQualifierCode_01 { get; set; }
        [Required]
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(2)]
        public string NonCoveredChargeAmount_02 { get; set; }
        [DataElement("478", typeof(X12_ID_478))]
        [Pos(3)]
        public string CreditDebitFlagCode_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("AMT", typeof(X12_ID_522_2))]
    public class AMT_CoordinationofBenefits_COB_PayerPaidAmount
    {
        
        [Required]
        [DataElement("522", typeof(X12_ID_522_2))]
        [Pos(1)]
        public string AmountQualifierCode_01 { get; set; }
        [Required]
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(2)]
        public string PayerPaidAmount_02 { get; set; }
        [DataElement("478", typeof(X12_ID_478))]
        [Pos(3)]
        public string CreditDebitFlagCode_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("CAS", typeof(X12_ID_1033))]
    public class CAS_ClaimLevelAdjustments
    {
        
        [Required]
        [DataElement("1033", typeof(X12_ID_1033))]
        [Pos(1)]
        public string ClaimAdjustmentGroupCode_01 { get; set; }
        [Required]
        [StringLength(1, 5)]
        [DataElement("1034", typeof(X12_ID))]
        [Pos(2)]
        public string AdjustmentReasonCode_02 { get; set; }
        [Required]
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(3)]
        public string AdjustmentAmount_03 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(4)]
        public string AdjustmentQuantity_04 { get; set; }
        [StringLength(1, 5)]
        [DataElement("1034", typeof(X12_ID))]
        [Pos(5)]
        public string AdjustmentReasonCode_05 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(6)]
        public string AdjustmentAmount_06 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(7)]
        public string AdjustmentQuantity_07 { get; set; }
        [StringLength(1, 5)]
        [DataElement("1034", typeof(X12_ID))]
        [Pos(8)]
        public string AdjustmentReasonCode_08 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(9)]
        public string AdjustmentAmount_09 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(10)]
        public string AdjustmentQuantity_10 { get; set; }
        [StringLength(1, 5)]
        [DataElement("1034", typeof(X12_ID))]
        [Pos(11)]
        public string AdjustmentReasonCode_11 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(12)]
        public string AdjustmentAmount_12 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(13)]
        public string AdjustmentQuantity_13 { get; set; }
        [StringLength(1, 5)]
        [DataElement("1034", typeof(X12_ID))]
        [Pos(14)]
        public string AdjustmentReasonCode_14 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(15)]
        public string AdjustmentAmount_15 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(16)]
        public string AdjustmentQuantity_16 { get; set; }
        [StringLength(1, 5)]
        [DataElement("1034", typeof(X12_ID))]
        [Pos(17)]
        public string AdjustmentReasonCode_17 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(18)]
        public string AdjustmentAmount_18 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(19)]
        public string AdjustmentQuantity_19 { get; set; }
    }
    
    [Serializable()]
    [Segment("SBR", typeof(X12_ID_1138), typeof(X12_ID_1069_3))]
    public class SBR_OtherSubscriberInformation
    {
        
        [Required]
        [DataElement("1138", typeof(X12_ID_1138))]
        [Pos(1)]
        public string PayerResponsibilitySequenceNumberCode_01 { get; set; }
        [Required]
        [DataElement("1069", typeof(X12_ID_1069_3))]
        [Pos(2)]
        public string IndividualRelationshipCode_02 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(3)]
        public string InsuredGrouporPolicyNumber_03 { get; set; }
        [StringLength(1, 60)]
        [DataElement("93", typeof(X12_AN))]
        [Pos(4)]
        public string OtherInsuredGroupName_04 { get; set; }
        [DataElement("1336", typeof(X12_ID_1336))]
        [Pos(5)]
        public string InsuranceTypeCode_05 { get; set; }
        [DataElement("1143", typeof(X12_ID_1143))]
        [Pos(6)]
        public string CoordinationofBenefitsCode_06 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(7)]
        public string YesNoConditionorResponseCode_07 { get; set; }
        [DataElement("584", typeof(X12_ID_584))]
        [Pos(8)]
        public string EmploymentStatusCode_08 { get; set; }
        [DataElement("1032", typeof(X12_ID_1032))]
        [Pos(9)]
        public string ClaimFilingIndicatorCode_09 { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_NM1_4
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
        [Pos(6)]
        public Loop_2310F Loop_2310F { get; set; }
    }
    
    [Serializable()]
    [Group("NM1")]
    public class Loop_2310F
    {
        
        [Required]
        [Pos(1)]
        public NM1_AmbulanceDrop_offLocation NM1_AmbulanceDrop_offLocation { get; set; }
        [Required]
        [Pos(2)]
        public N3_AmbulanceDrop_offLocationAddress N3_AmbulanceDrop_offLocationAddress { get; set; }
        [Required]
        [Pos(3)]
        public N4_AmbulanceDrop_offLocationCity_State_ZipCode N4_AmbulanceDrop_offLocationCity_State_ZipCode { get; set; }
    }
    
    [Serializable()]
    [Segment("N4")]
    public class N4_AmbulanceDrop_offLocationCity_State_ZipCode
    {
        
        [Required]
        [StringLength(2, 30)]
        [DataElement("19", typeof(X12_AN))]
        [Pos(1)]
        public string AmbulanceDropoffCityName_01 { get; set; }
        [StringLength(2, 2)]
        [DataElement("156", typeof(X12_ID))]
        [Pos(2)]
        public string AmbulanceDropoffStateorProvinceCode_02 { get; set; }
        [StringLength(3, 15)]
        [DataElement("116", typeof(X12_ID))]
        [Pos(3)]
        public string AmbulanceDropoffPostalZoneorZIPCode_03 { get; set; }
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
    [Segment("N3")]
    public class N3_AmbulanceDrop_offLocationAddress
    {
        
        [Required]
        [StringLength(1, 55)]
        [DataElement("166", typeof(X12_AN))]
        [Pos(1)]
        public string AmbulanceDropoffAddressLine_01 { get; set; }
        [StringLength(1, 55)]
        [DataElement("166", typeof(X12_AN))]
        [Pos(2)]
        public string AmbulanceDropoffAddressLine_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_14), typeof(X12_ID_1065_2))]
    public class NM1_AmbulanceDrop_offLocation
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98_14))]
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        [Required]
        [DataElement("1065", typeof(X12_ID_1065_2))]
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(3)]
        public string AmbulanceDropoffLocation_03 { get; set; }
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
    public class Loop_2310E
    {
        
        [Required]
        [Pos(1)]
        public NM1_AmbulancePick_upLocation NM1_AmbulancePick_upLocation { get; set; }
        [Required]
        [Pos(2)]
        public N3_AmbulancePick_upLocationAddress N3_AmbulancePick_upLocationAddress { get; set; }
        [Required]
        [Pos(3)]
        public N4_AmbulancePick_upLocationCity_State_ZipCode N4_AmbulancePick_upLocationCity_State_ZipCode { get; set; }
    }
    
    [Serializable()]
    [Segment("N4")]
    public class N4_AmbulancePick_upLocationCity_State_ZipCode
    {
        
        [Required]
        [StringLength(2, 30)]
        [DataElement("19", typeof(X12_AN))]
        [Pos(1)]
        public string AmbulancePickupCityName_01 { get; set; }
        [StringLength(2, 2)]
        [DataElement("156", typeof(X12_ID))]
        [Pos(2)]
        public string AmbulancePickupStateorProvinceCode_02 { get; set; }
        [StringLength(3, 15)]
        [DataElement("116", typeof(X12_ID))]
        [Pos(3)]
        public string AmbulancePickupPostalZoneorZIPCode_03 { get; set; }
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
    [Segment("N3")]
    public class N3_AmbulancePick_upLocationAddress
    {
        
        [Required]
        [StringLength(1, 55)]
        [DataElement("166", typeof(X12_AN))]
        [Pos(1)]
        public string AmbulancePickupAddressLine_01 { get; set; }
        [StringLength(1, 55)]
        [DataElement("166", typeof(X12_AN))]
        [Pos(2)]
        public string AmbulancePickupAddressLine_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_13), typeof(X12_ID_1065_2))]
    public class NM1_AmbulancePick_upLocation
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
    public class Loop_2310D
    {
        
        [Required]
        [Pos(1)]
        public NM1_SupervisingProviderName NM1_SupervisingProviderName { get; set; }
        [ListCount(4)]
        [Pos(2)]
        public List<REF_SupervisingProviderSecondaryIdentification> REF_SupervisingProviderSecondaryIdentification { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_26))]
    public class REF_SupervisingProviderSecondaryIdentification
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_26))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string SupervisingProviderSecondaryIdentifier_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        [Pos(4)]
        public C040_ReferenceIdentifier_26 ReferenceIdentifier_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C040_ReferenceIdentifier_26")]
    public class C040_ReferenceIdentifier_26
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_12), typeof(X12_ID_1065_3))]
    public class NM1_SupervisingProviderName
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98_12))]
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
        public string SupervisingProviderLastName_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1036", typeof(X12_AN))]
        [Pos(4)]
        public string SupervisingProviderFirstName_04 { get; set; }
        [StringLength(1, 25)]
        [DataElement("1037", typeof(X12_AN))]
        [Pos(5)]
        public string SupervisingProviderMiddleNameorInitial_05 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1038", typeof(X12_AN))]
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1039", typeof(X12_AN))]
        [Pos(7)]
        public string SupervisingProviderNameSuffix_07 { get; set; }
        [DataElement("66", typeof(X12_ID_66_2))]
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(9)]
        public string SupervisingProviderIdentifier_09 { get; set; }
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
    public class Loop_2310C
    {
        
        [Required]
        [Pos(1)]
        public NM1_ServiceFacilityLocationName NM1_ServiceFacilityLocationName { get; set; }
        [Required]
        [Pos(2)]
        public N3_ServiceFacilityLocationAddress N3_ServiceFacilityLocationAddress { get; set; }
        [Required]
        [Pos(3)]
        public N4_ServiceFacilityLocationCity_State_ZIPCode N4_ServiceFacilityLocationCity_State_ZIPCode { get; set; }
        [ListCount(3)]
        [Pos(4)]
        public List<REF_ServiceFacilityLocationSecondaryIdentification> REF_ServiceFacilityLocationSecondaryIdentification { get; set; }
        [Pos(5)]
        public PER_ServiceFacilityContactInformation PER_ServiceFacilityContactInformation { get; set; }
    }
    
    [Serializable()]
    [Segment("PER", typeof(X12_ID_366))]
    public class PER_ServiceFacilityContactInformation
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
        [DataElement("365", typeof(X12_ID_365_3))]
        [Pos(3)]
        public string CommunicationNumberQualifier_03 { get; set; }
        [Required]
        [StringLength(1, 256)]
        [DataElement("364", typeof(X12_AN))]
        [Pos(4)]
        public string CommunicationNumber_04 { get; set; }
        [DataElement("365", typeof(X12_ID_365_4))]
        [Pos(5)]
        public string CommunicationNumberQualifier_05 { get; set; }
        [StringLength(1, 256)]
        [DataElement("364", typeof(X12_AN))]
        [Pos(6)]
        public string CommunicationNumber_06 { get; set; }
        [DataElement("365", typeof(X12_ID_365_5))]
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
    [Segment("REF", typeof(X12_ID_128_27))]
    public class REF_ServiceFacilityLocationSecondaryIdentification
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_27))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string LaboratoryorFacilitySecondaryIdentifier_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        [Pos(4)]
        public C040_ReferenceIdentifier_25 ReferenceIdentifier_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C040_ReferenceIdentifier_25")]
    public class C040_ReferenceIdentifier_25
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("N4")]
    public class N4_ServiceFacilityLocationCity_State_ZIPCode
    {
        
        [Required]
        [StringLength(2, 30)]
        [DataElement("19", typeof(X12_AN))]
        [Pos(1)]
        public string LaboratoryorFacilityCityName_01 { get; set; }
        [StringLength(2, 2)]
        [DataElement("156", typeof(X12_ID))]
        [Pos(2)]
        public string LaboratoryorFacilityStateorProvinceCode_02 { get; set; }
        [StringLength(3, 15)]
        [DataElement("116", typeof(X12_ID))]
        [Pos(3)]
        public string LaboratoryorFacilityPostalZoneorZIPCode_03 { get; set; }
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
    [Segment("N3")]
    public class N3_ServiceFacilityLocationAddress
    {
        
        [Required]
        [StringLength(1, 55)]
        [DataElement("166", typeof(X12_AN))]
        [Pos(1)]
        public string LaboratoryorFacilityAddressLine_01 { get; set; }
        [StringLength(1, 55)]
        [DataElement("166", typeof(X12_AN))]
        [Pos(2)]
        public string LaboratoryorFacilityAddressLine_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_11), typeof(X12_ID_1065_2))]
    public class NM1_ServiceFacilityLocationName
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98_11))]
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        [Required]
        [DataElement("1065", typeof(X12_ID_1065_2))]
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        [Required]
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(3)]
        public string LaboratoryorFacilityName_03 { get; set; }
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
        [DataElement("66", typeof(X12_ID_66_2))]
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(9)]
        public string LaboratoryorFacilityPrimaryIdentifier_09 { get; set; }
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
    public class Loop_2310B
    {
        
        [Required]
        [Pos(1)]
        public NM1_RenderingProviderName NM1_RenderingProviderName { get; set; }
        [Pos(2)]
        public PRV_RenderingProviderSpecialtyInformation PRV_RenderingProviderSpecialtyInformation { get; set; }
        [ListCount(4)]
        [Pos(3)]
        public List<REF_RenderingProviderSecondaryIdentification> REF_RenderingProviderSecondaryIdentification { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_26))]
    public class REF_RenderingProviderSecondaryIdentification
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_26))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string RenderingProviderSecondaryIdentifier_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        [Pos(4)]
        public C040_ReferenceIdentifier_24 ReferenceIdentifier_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C040_ReferenceIdentifier_24")]
    public class C040_ReferenceIdentifier_24
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("PRV", typeof(X12_ID_1221_2), typeof(X12_ID_128))]
    public class PRV_RenderingProviderSpecialtyInformation
    {
        
        [Required]
        [DataElement("1221", typeof(X12_ID_1221_2))]
        [Pos(1)]
        public string ProviderCode_01 { get; set; }
        [Required]
        [DataElement("128", typeof(X12_ID_128))]
        [Pos(2)]
        public string ReferenceIdentificationQualifier_02 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(3)]
        public string ProviderTaxonomyCode_03 { get; set; }
        [StringLength(2, 2)]
        [DataElement("156", typeof(X12_ID))]
        [Pos(4)]
        public string StateorProvinceCode_04 { get; set; }
        [Pos(5)]
        public C035_ProviderSpecialtyInformation_2 ProviderSpecialtyInformation_05 { get; set; }
        [DataElement("1223", typeof(X12_ID_1223))]
        [Pos(6)]
        public string ProviderOrganizationCode_06 { get; set; }
    }
    
    [Serializable()]
    [Composite("C035_ProviderSpecialtyInformation_2")]
    public class C035_ProviderSpecialtyInformation_2
    {
        
        [Required]
        [DataElement("1222", typeof(X12_ID_1222))]
        [Pos(1)]
        public string ProviderSpecialtyCode_01 { get; set; }
        [DataElement("559", typeof(X12_ID_559))]
        [Pos(2)]
        public string AgencyQualifierCode_02 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(3)]
        public string YesNoConditionorResponseCode_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_10), typeof(X12_ID_1065))]
    public class NM1_RenderingProviderName
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
        public string RenderingProviderLastorOrganizationName_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1036", typeof(X12_AN))]
        [Pos(4)]
        public string RenderingProviderFirstName_04 { get; set; }
        [StringLength(1, 25)]
        [DataElement("1037", typeof(X12_AN))]
        [Pos(5)]
        public string RenderingProviderMiddleNameorInitial_05 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1038", typeof(X12_AN))]
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1039", typeof(X12_AN))]
        [Pos(7)]
        public string RenderingProviderNameSuffix_07 { get; set; }
        [DataElement("66", typeof(X12_ID_66_2))]
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(9)]
        public string RenderingProviderIdentifier_09 { get; set; }
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
    public class Loop_2310A
    {
        
        [Required]
        [Pos(1)]
        public NM1_ReferringProviderName NM1_ReferringProviderName { get; set; }
        [ListCount(3)]
        [Pos(2)]
        public List<REF_ReferringProviderSecondaryIdentification> REF_ReferringProviderSecondaryIdentification { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_25))]
    public class REF_ReferringProviderSecondaryIdentification
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_25))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferringProviderSecondaryIdentifier_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        [Pos(4)]
        public C040_ReferenceIdentifier_23 ReferenceIdentifier_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C040_ReferenceIdentifier_23")]
    public class C040_ReferenceIdentifier_23
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_9), typeof(X12_ID_1065_3))]
    public class NM1_ReferringProviderName
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
        public string ReferringProviderLastName_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1036", typeof(X12_AN))]
        [Pos(4)]
        public string ReferringProviderFirstName_04 { get; set; }
        [StringLength(1, 25)]
        [DataElement("1037", typeof(X12_AN))]
        [Pos(5)]
        public string ReferringProviderMiddleNameorInitial_05 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1038", typeof(X12_AN))]
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1039", typeof(X12_AN))]
        [Pos(7)]
        public string ReferringProviderNameSuffix_07 { get; set; }
        [DataElement("66", typeof(X12_ID_66_2))]
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(9)]
        public string ReferringProviderIdentifier_09 { get; set; }
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
    [Segment("HCP", typeof(X12_ID_1473))]
    public class HCP_ClaimPricing_RepricingInformation
    {
        
        [Required]
        [DataElement("1473", typeof(X12_ID_1473))]
        [Pos(1)]
        public string PricingMethodology_01 { get; set; }
        [Required]
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(2)]
        public string RepricedAllowedAmount_02 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(3)]
        public string RepricedSavingAmount_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string RepricingOrganizationIdentifier_04 { get; set; }
        [StringLength(1, 9)]
        [DataElement("118", typeof(X12_R))]
        [Pos(5)]
        public string RepricingPerDiemorFlatRateAmount_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string RepricedApprovedAmbulatoryPatientGroupCode_06 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(7)]
        public string RepricedApprovedAmbulatoryPatientGroupAmount_07 { get; set; }
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(8)]
        public string ProductServiceID_08 { get; set; }
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(9)]
        public string ProductServiceIDQualifier_09 { get; set; }
        [StringLength(1, 48)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(10)]
        public string ProductServiceID_10 { get; set; }
        [DataElement("355", typeof(X12_ID_355_2))]
        [Pos(11)]
        public string UnitorBasisforMeasurementCode_11 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(12)]
        public string Quantity_12 { get; set; }
        [DataElement("901", typeof(X12_ID_901))]
        [Pos(13)]
        public string RejectReasonCode_13 { get; set; }
        [DataElement("1526", typeof(X12_ID_1526))]
        [Pos(14)]
        public string PolicyComplianceCode_14 { get; set; }
        [DataElement("1527", typeof(X12_ID_1527))]
        [Pos(15)]
        public string ExceptionCode_15 { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_HI
    {
        
        [Required]
        [Pos(1)]
        public HI_HealthCareDiagnosisCode HI_HealthCareDiagnosisCode { get; set; }
        [Pos(2)]
        public HI_AnesthesiaRelatedProcedure HI_AnesthesiaRelatedProcedure { get; set; }
        [ListCount(2)]
        [Pos(3)]
        public List<HI_ConditionInformation> HI_ConditionInformation { get; set; }
    }
    
    [Serializable()]
    [Segment("HI", typeof(X12_ID_1270_6), typeof(X12_ID_1270_6))]
    public class HI_ConditionInformation
    {
        
        [Required]
        [Pos(1)]
        public C022_HealthCareCodeInformation_25 HealthCareCodeInformation_01 { get; set; }
        [Pos(2)]
        public C022_HealthCareCodeInformation_26 HealthCareCodeInformation_02 { get; set; }
        [Pos(3)]
        public C022_HealthCareCodeInformation_27 HealthCareCodeInformation_03 { get; set; }
        [Pos(4)]
        public C022_HealthCareCodeInformation_28 HealthCareCodeInformation_04 { get; set; }
        [Pos(5)]
        public C022_HealthCareCodeInformation_29 HealthCareCodeInformation_05 { get; set; }
        [Pos(6)]
        public C022_HealthCareCodeInformation_30 HealthCareCodeInformation_06 { get; set; }
        [Pos(7)]
        public C022_HealthCareCodeInformation_31 HealthCareCodeInformation_07 { get; set; }
        [Pos(8)]
        public C022_HealthCareCodeInformation_32 HealthCareCodeInformation_08 { get; set; }
        [Pos(9)]
        public C022_HealthCareCodeInformation_33 HealthCareCodeInformation_09 { get; set; }
        [Pos(10)]
        public C022_HealthCareCodeInformation_34 HealthCareCodeInformation_10 { get; set; }
        [Pos(11)]
        public C022_HealthCareCodeInformation_35 HealthCareCodeInformation_11 { get; set; }
        [Pos(12)]
        public C022_HealthCareCodeInformation_36 HealthCareCodeInformation_12 { get; set; }
    }
    
    [Serializable()]
    [Composite("C022_HealthCareCodeInformation_36")]
    public class C022_HealthCareCodeInformation_36
    {
        
        [Required]
        [DataElement("1270", typeof(X12_ID_1270_6))]
        [Pos(1)]
        public string CodeListQualifierCode_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(2)]
        public string ConditionCode_02 { get; set; }
        [DataElement("1250", typeof(X12_ID_1250_3))]
        [Pos(3)]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(4)]
        public string DateTimePeriod_04 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(5)]
        public string MonetaryAmount_05 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        public string Quantity_06 { get; set; }
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(7)]
        public string VersionIdentifier_07 { get; set; }
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(8)]
        public string IndustryCode_08 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(9)]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    [Serializable()]
    [Composite("C022_HealthCareCodeInformation_35")]
    public class C022_HealthCareCodeInformation_35
    {
        
        [Required]
        [DataElement("1270", typeof(X12_ID_1270_6))]
        [Pos(1)]
        public string CodeListQualifierCode_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(2)]
        public string ConditionCode_02 { get; set; }
        [DataElement("1250", typeof(X12_ID_1250_3))]
        [Pos(3)]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(4)]
        public string DateTimePeriod_04 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(5)]
        public string MonetaryAmount_05 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        public string Quantity_06 { get; set; }
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(7)]
        public string VersionIdentifier_07 { get; set; }
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(8)]
        public string IndustryCode_08 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(9)]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    [Serializable()]
    [Composite("C022_HealthCareCodeInformation_34")]
    public class C022_HealthCareCodeInformation_34
    {
        
        [Required]
        [DataElement("1270", typeof(X12_ID_1270_6))]
        [Pos(1)]
        public string CodeListQualifierCode_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(2)]
        public string ConditionCode_02 { get; set; }
        [DataElement("1250", typeof(X12_ID_1250_3))]
        [Pos(3)]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(4)]
        public string DateTimePeriod_04 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(5)]
        public string MonetaryAmount_05 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        public string Quantity_06 { get; set; }
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(7)]
        public string VersionIdentifier_07 { get; set; }
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(8)]
        public string IndustryCode_08 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(9)]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    [Serializable()]
    [Composite("C022_HealthCareCodeInformation_33")]
    public class C022_HealthCareCodeInformation_33
    {
        
        [Required]
        [DataElement("1270", typeof(X12_ID_1270_6))]
        [Pos(1)]
        public string CodeListQualifierCode_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(2)]
        public string ConditionCode_02 { get; set; }
        [DataElement("1250", typeof(X12_ID_1250_3))]
        [Pos(3)]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(4)]
        public string DateTimePeriod_04 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(5)]
        public string MonetaryAmount_05 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        public string Quantity_06 { get; set; }
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(7)]
        public string VersionIdentifier_07 { get; set; }
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(8)]
        public string IndustryCode_08 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(9)]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    [Serializable()]
    [Composite("C022_HealthCareCodeInformation_32")]
    public class C022_HealthCareCodeInformation_32
    {
        
        [Required]
        [DataElement("1270", typeof(X12_ID_1270_6))]
        [Pos(1)]
        public string CodeListQualifierCode_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(2)]
        public string ConditionCode_02 { get; set; }
        [DataElement("1250", typeof(X12_ID_1250_3))]
        [Pos(3)]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(4)]
        public string DateTimePeriod_04 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(5)]
        public string MonetaryAmount_05 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        public string Quantity_06 { get; set; }
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(7)]
        public string VersionIdentifier_07 { get; set; }
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(8)]
        public string IndustryCode_08 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(9)]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    [Serializable()]
    [Composite("C022_HealthCareCodeInformation_31")]
    public class C022_HealthCareCodeInformation_31
    {
        
        [Required]
        [DataElement("1270", typeof(X12_ID_1270_6))]
        [Pos(1)]
        public string CodeListQualifierCode_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(2)]
        public string ConditionCode_02 { get; set; }
        [DataElement("1250", typeof(X12_ID_1250_3))]
        [Pos(3)]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(4)]
        public string DateTimePeriod_04 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(5)]
        public string MonetaryAmount_05 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        public string Quantity_06 { get; set; }
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(7)]
        public string VersionIdentifier_07 { get; set; }
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(8)]
        public string IndustryCode_08 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(9)]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    [Serializable()]
    [Composite("C022_HealthCareCodeInformation_30")]
    public class C022_HealthCareCodeInformation_30
    {
        
        [Required]
        [DataElement("1270", typeof(X12_ID_1270_6))]
        [Pos(1)]
        public string CodeListQualifierCode_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(2)]
        public string ConditionCode_02 { get; set; }
        [DataElement("1250", typeof(X12_ID_1250_3))]
        [Pos(3)]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(4)]
        public string DateTimePeriod_04 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(5)]
        public string MonetaryAmount_05 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        public string Quantity_06 { get; set; }
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(7)]
        public string VersionIdentifier_07 { get; set; }
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(8)]
        public string IndustryCode_08 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(9)]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    [Serializable()]
    [Composite("C022_HealthCareCodeInformation_29")]
    public class C022_HealthCareCodeInformation_29
    {
        
        [Required]
        [DataElement("1270", typeof(X12_ID_1270_6))]
        [Pos(1)]
        public string CodeListQualifierCode_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(2)]
        public string ConditionCode_02 { get; set; }
        [DataElement("1250", typeof(X12_ID_1250_3))]
        [Pos(3)]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(4)]
        public string DateTimePeriod_04 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(5)]
        public string MonetaryAmount_05 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        public string Quantity_06 { get; set; }
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(7)]
        public string VersionIdentifier_07 { get; set; }
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(8)]
        public string IndustryCode_08 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(9)]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    [Serializable()]
    [Composite("C022_HealthCareCodeInformation_28")]
    public class C022_HealthCareCodeInformation_28
    {
        
        [Required]
        [DataElement("1270", typeof(X12_ID_1270_6))]
        [Pos(1)]
        public string CodeListQualifierCode_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(2)]
        public string ConditionCode_02 { get; set; }
        [DataElement("1250", typeof(X12_ID_1250_3))]
        [Pos(3)]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(4)]
        public string DateTimePeriod_04 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(5)]
        public string MonetaryAmount_05 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        public string Quantity_06 { get; set; }
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(7)]
        public string VersionIdentifier_07 { get; set; }
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(8)]
        public string IndustryCode_08 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(9)]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    [Serializable()]
    [Composite("C022_HealthCareCodeInformation_27")]
    public class C022_HealthCareCodeInformation_27
    {
        
        [Required]
        [DataElement("1270", typeof(X12_ID_1270_6))]
        [Pos(1)]
        public string CodeListQualifierCode_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(2)]
        public string ConditionCode_02 { get; set; }
        [DataElement("1250", typeof(X12_ID_1250_3))]
        [Pos(3)]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(4)]
        public string DateTimePeriod_04 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(5)]
        public string MonetaryAmount_05 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        public string Quantity_06 { get; set; }
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(7)]
        public string VersionIdentifier_07 { get; set; }
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(8)]
        public string IndustryCode_08 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(9)]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    [Serializable()]
    [Composite("C022_HealthCareCodeInformation_26")]
    public class C022_HealthCareCodeInformation_26
    {
        
        [Required]
        [DataElement("1270", typeof(X12_ID_1270_6))]
        [Pos(1)]
        public string CodeListQualifierCode_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(2)]
        public string ConditionCode_02 { get; set; }
        [DataElement("1250", typeof(X12_ID_1250_3))]
        [Pos(3)]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(4)]
        public string DateTimePeriod_04 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(5)]
        public string MonetaryAmount_05 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        public string Quantity_06 { get; set; }
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(7)]
        public string VersionIdentifier_07 { get; set; }
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(8)]
        public string IndustryCode_08 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(9)]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    [Serializable()]
    [Composite("C022_HealthCareCodeInformation_25")]
    public class C022_HealthCareCodeInformation_25
    {
        
        [Required]
        [DataElement("1270", typeof(X12_ID_1270_6))]
        [Pos(1)]
        public string CodeListQualifierCode_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(2)]
        public string ConditionCode_02 { get; set; }
        [DataElement("1250", typeof(X12_ID_1250_3))]
        [Pos(3)]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(4)]
        public string DateTimePeriod_04 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(5)]
        public string MonetaryAmount_05 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        public string Quantity_06 { get; set; }
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(7)]
        public string VersionIdentifier_07 { get; set; }
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(8)]
        public string IndustryCode_08 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(9)]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    [Serializable()]
    [Segment("HI", typeof(X12_ID_1270_4), typeof(X12_ID_1270_5))]
    public class HI_AnesthesiaRelatedProcedure
    {
        
        [Required]
        [Pos(1)]
        public C022_HealthCareCodeInformation_13 HealthCareCodeInformation_01 { get; set; }
        [Pos(2)]
        public C022_HealthCareCodeInformation_14 HealthCareCodeInformation_02 { get; set; }
        [Pos(3)]
        public C022_HealthCareCodeInformation_15 HealthCareCodeInformation_03 { get; set; }
        [Pos(4)]
        public C022_HealthCareCodeInformation_16 HealthCareCodeInformation_04 { get; set; }
        [Pos(5)]
        public C022_HealthCareCodeInformation_17 HealthCareCodeInformation_05 { get; set; }
        [Pos(6)]
        public C022_HealthCareCodeInformation_18 HealthCareCodeInformation_06 { get; set; }
        [Pos(7)]
        public C022_HealthCareCodeInformation_19 HealthCareCodeInformation_07 { get; set; }
        [Pos(8)]
        public C022_HealthCareCodeInformation_20 HealthCareCodeInformation_08 { get; set; }
        [Pos(9)]
        public C022_HealthCareCodeInformation_21 HealthCareCodeInformation_09 { get; set; }
        [Pos(10)]
        public C022_HealthCareCodeInformation_22 HealthCareCodeInformation_10 { get; set; }
        [Pos(11)]
        public C022_HealthCareCodeInformation_23 HealthCareCodeInformation_11 { get; set; }
        [Pos(12)]
        public C022_HealthCareCodeInformation_24 HealthCareCodeInformation_12 { get; set; }
    }
    
    [Serializable()]
    [Composite("C022_HealthCareCodeInformation_24")]
    public class C022_HealthCareCodeInformation_24
    {
        
        [Required]
        [DataElement("1270", typeof(X12_ID_1270))]
        [Pos(1)]
        public string CodeListQualifierCode_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(2)]
        public string IndustryCode_02 { get; set; }
        [DataElement("1250", typeof(X12_ID_1250_3))]
        [Pos(3)]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(4)]
        public string DateTimePeriod_04 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(5)]
        public string MonetaryAmount_05 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        public string Quantity_06 { get; set; }
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(7)]
        public string VersionIdentifier_07 { get; set; }
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(8)]
        public string IndustryCode_08 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(9)]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    [Serializable()]
    [Composite("C022_HealthCareCodeInformation_23")]
    public class C022_HealthCareCodeInformation_23
    {
        
        [Required]
        [DataElement("1270", typeof(X12_ID_1270))]
        [Pos(1)]
        public string CodeListQualifierCode_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(2)]
        public string IndustryCode_02 { get; set; }
        [DataElement("1250", typeof(X12_ID_1250_3))]
        [Pos(3)]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(4)]
        public string DateTimePeriod_04 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(5)]
        public string MonetaryAmount_05 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        public string Quantity_06 { get; set; }
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(7)]
        public string VersionIdentifier_07 { get; set; }
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(8)]
        public string IndustryCode_08 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(9)]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    [Serializable()]
    [Composite("C022_HealthCareCodeInformation_22")]
    public class C022_HealthCareCodeInformation_22
    {
        
        [Required]
        [DataElement("1270", typeof(X12_ID_1270))]
        [Pos(1)]
        public string CodeListQualifierCode_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(2)]
        public string IndustryCode_02 { get; set; }
        [DataElement("1250", typeof(X12_ID_1250_3))]
        [Pos(3)]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(4)]
        public string DateTimePeriod_04 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(5)]
        public string MonetaryAmount_05 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        public string Quantity_06 { get; set; }
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(7)]
        public string VersionIdentifier_07 { get; set; }
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(8)]
        public string IndustryCode_08 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(9)]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    [Serializable()]
    [Composite("C022_HealthCareCodeInformation_21")]
    public class C022_HealthCareCodeInformation_21
    {
        
        [Required]
        [DataElement("1270", typeof(X12_ID_1270))]
        [Pos(1)]
        public string CodeListQualifierCode_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(2)]
        public string IndustryCode_02 { get; set; }
        [DataElement("1250", typeof(X12_ID_1250_3))]
        [Pos(3)]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(4)]
        public string DateTimePeriod_04 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(5)]
        public string MonetaryAmount_05 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        public string Quantity_06 { get; set; }
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(7)]
        public string VersionIdentifier_07 { get; set; }
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(8)]
        public string IndustryCode_08 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(9)]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    [Serializable()]
    [Composite("C022_HealthCareCodeInformation_20")]
    public class C022_HealthCareCodeInformation_20
    {
        
        [Required]
        [DataElement("1270", typeof(X12_ID_1270))]
        [Pos(1)]
        public string CodeListQualifierCode_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(2)]
        public string IndustryCode_02 { get; set; }
        [DataElement("1250", typeof(X12_ID_1250_3))]
        [Pos(3)]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(4)]
        public string DateTimePeriod_04 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(5)]
        public string MonetaryAmount_05 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        public string Quantity_06 { get; set; }
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(7)]
        public string VersionIdentifier_07 { get; set; }
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(8)]
        public string IndustryCode_08 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(9)]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    [Serializable()]
    [Composite("C022_HealthCareCodeInformation_19")]
    public class C022_HealthCareCodeInformation_19
    {
        
        [Required]
        [DataElement("1270", typeof(X12_ID_1270))]
        [Pos(1)]
        public string CodeListQualifierCode_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(2)]
        public string IndustryCode_02 { get; set; }
        [DataElement("1250", typeof(X12_ID_1250_3))]
        [Pos(3)]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(4)]
        public string DateTimePeriod_04 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(5)]
        public string MonetaryAmount_05 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        public string Quantity_06 { get; set; }
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(7)]
        public string VersionIdentifier_07 { get; set; }
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(8)]
        public string IndustryCode_08 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(9)]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    [Serializable()]
    [Composite("C022_HealthCareCodeInformation_18")]
    public class C022_HealthCareCodeInformation_18
    {
        
        [Required]
        [DataElement("1270", typeof(X12_ID_1270))]
        [Pos(1)]
        public string CodeListQualifierCode_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(2)]
        public string IndustryCode_02 { get; set; }
        [DataElement("1250", typeof(X12_ID_1250_3))]
        [Pos(3)]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(4)]
        public string DateTimePeriod_04 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(5)]
        public string MonetaryAmount_05 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        public string Quantity_06 { get; set; }
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(7)]
        public string VersionIdentifier_07 { get; set; }
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(8)]
        public string IndustryCode_08 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(9)]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    [Serializable()]
    [Composite("C022_HealthCareCodeInformation_17")]
    public class C022_HealthCareCodeInformation_17
    {
        
        [Required]
        [DataElement("1270", typeof(X12_ID_1270))]
        [Pos(1)]
        public string CodeListQualifierCode_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(2)]
        public string IndustryCode_02 { get; set; }
        [DataElement("1250", typeof(X12_ID_1250_3))]
        [Pos(3)]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(4)]
        public string DateTimePeriod_04 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(5)]
        public string MonetaryAmount_05 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        public string Quantity_06 { get; set; }
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(7)]
        public string VersionIdentifier_07 { get; set; }
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(8)]
        public string IndustryCode_08 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(9)]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    [Serializable()]
    [Composite("C022_HealthCareCodeInformation_16")]
    public class C022_HealthCareCodeInformation_16
    {
        
        [Required]
        [DataElement("1270", typeof(X12_ID_1270))]
        [Pos(1)]
        public string CodeListQualifierCode_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(2)]
        public string IndustryCode_02 { get; set; }
        [DataElement("1250", typeof(X12_ID_1250_3))]
        [Pos(3)]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(4)]
        public string DateTimePeriod_04 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(5)]
        public string MonetaryAmount_05 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        public string Quantity_06 { get; set; }
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(7)]
        public string VersionIdentifier_07 { get; set; }
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(8)]
        public string IndustryCode_08 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(9)]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    [Serializable()]
    [Composite("C022_HealthCareCodeInformation_15")]
    public class C022_HealthCareCodeInformation_15
    {
        
        [Required]
        [DataElement("1270", typeof(X12_ID_1270))]
        [Pos(1)]
        public string CodeListQualifierCode_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(2)]
        public string IndustryCode_02 { get; set; }
        [DataElement("1250", typeof(X12_ID_1250_3))]
        [Pos(3)]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(4)]
        public string DateTimePeriod_04 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(5)]
        public string MonetaryAmount_05 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        public string Quantity_06 { get; set; }
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(7)]
        public string VersionIdentifier_07 { get; set; }
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(8)]
        public string IndustryCode_08 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(9)]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    [Serializable()]
    [Composite("C022_HealthCareCodeInformation_14")]
    public class C022_HealthCareCodeInformation_14
    {
        
        [Required]
        [DataElement("1270", typeof(X12_ID_1270_5))]
        [Pos(1)]
        public string CodeListQualifierCode_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(2)]
        public string IndustryCode_02 { get; set; }
        [DataElement("1250", typeof(X12_ID_1250_3))]
        [Pos(3)]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(4)]
        public string DateTimePeriod_04 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(5)]
        public string MonetaryAmount_05 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        public string Quantity_06 { get; set; }
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(7)]
        public string VersionIdentifier_07 { get; set; }
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(8)]
        public string IndustryCode_08 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(9)]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    [Serializable()]
    [Composite("C022_HealthCareCodeInformation_13")]
    public class C022_HealthCareCodeInformation_13
    {
        
        [Required]
        [DataElement("1270", typeof(X12_ID_1270_4))]
        [Pos(1)]
        public string CodeListQualifierCode_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(2)]
        public string AnesthesiaRelatedSurgicalProcedure_02 { get; set; }
        [DataElement("1250", typeof(X12_ID_1250_3))]
        [Pos(3)]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(4)]
        public string DateTimePeriod_04 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(5)]
        public string MonetaryAmount_05 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        public string Quantity_06 { get; set; }
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(7)]
        public string VersionIdentifier_07 { get; set; }
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(8)]
        public string IndustryCode_08 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(9)]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    [Serializable()]
    [Segment("HI", typeof(X12_ID_1270_2), typeof(X12_ID_1270_3))]
    public class HI_HealthCareDiagnosisCode
    {
        
        [Required]
        [Pos(1)]
        public C022_HealthCareCodeInformation HealthCareCodeInformation_01 { get; set; }
        [Pos(2)]
        public C022_HealthCareCodeInformation_2 HealthCareCodeInformation_02 { get; set; }
        [Pos(3)]
        public C022_HealthCareCodeInformation_3 HealthCareCodeInformation_03 { get; set; }
        [Pos(4)]
        public C022_HealthCareCodeInformation_4 HealthCareCodeInformation_04 { get; set; }
        [Pos(5)]
        public C022_HealthCareCodeInformation_5 HealthCareCodeInformation_05 { get; set; }
        [Pos(6)]
        public C022_HealthCareCodeInformation_6 HealthCareCodeInformation_06 { get; set; }
        [Pos(7)]
        public C022_HealthCareCodeInformation_7 HealthCareCodeInformation_07 { get; set; }
        [Pos(8)]
        public C022_HealthCareCodeInformation_8 HealthCareCodeInformation_08 { get; set; }
        [Pos(9)]
        public C022_HealthCareCodeInformation_9 HealthCareCodeInformation_09 { get; set; }
        [Pos(10)]
        public C022_HealthCareCodeInformation_10 HealthCareCodeInformation_10 { get; set; }
        [Pos(11)]
        public C022_HealthCareCodeInformation_11 HealthCareCodeInformation_11 { get; set; }
        [Pos(12)]
        public C022_HealthCareCodeInformation_12 HealthCareCodeInformation_12 { get; set; }
    }
    
    [Serializable()]
    [Composite("C022_HealthCareCodeInformation_12")]
    public class C022_HealthCareCodeInformation_12
    {
        
        [Required]
        [DataElement("1270", typeof(X12_ID_1270_3))]
        [Pos(1)]
        public string DiagnosisTypeCode_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(2)]
        public string DiagnosisCode_02 { get; set; }
        [DataElement("1250", typeof(X12_ID_1250_3))]
        [Pos(3)]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(4)]
        public string DateTimePeriod_04 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(5)]
        public string MonetaryAmount_05 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        public string Quantity_06 { get; set; }
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(7)]
        public string VersionIdentifier_07 { get; set; }
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(8)]
        public string IndustryCode_08 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(9)]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    [Serializable()]
    [Composite("C022_HealthCareCodeInformation_11")]
    public class C022_HealthCareCodeInformation_11
    {
        
        [Required]
        [DataElement("1270", typeof(X12_ID_1270_3))]
        [Pos(1)]
        public string DiagnosisTypeCode_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(2)]
        public string DiagnosisCode_02 { get; set; }
        [DataElement("1250", typeof(X12_ID_1250_3))]
        [Pos(3)]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(4)]
        public string DateTimePeriod_04 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(5)]
        public string MonetaryAmount_05 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        public string Quantity_06 { get; set; }
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(7)]
        public string VersionIdentifier_07 { get; set; }
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(8)]
        public string IndustryCode_08 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(9)]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    [Serializable()]
    [Composite("C022_HealthCareCodeInformation_10")]
    public class C022_HealthCareCodeInformation_10
    {
        
        [Required]
        [DataElement("1270", typeof(X12_ID_1270_3))]
        [Pos(1)]
        public string DiagnosisTypeCode_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(2)]
        public string DiagnosisCode_02 { get; set; }
        [DataElement("1250", typeof(X12_ID_1250_3))]
        [Pos(3)]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(4)]
        public string DateTimePeriod_04 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(5)]
        public string MonetaryAmount_05 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        public string Quantity_06 { get; set; }
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(7)]
        public string VersionIdentifier_07 { get; set; }
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(8)]
        public string IndustryCode_08 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(9)]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    [Serializable()]
    [Composite("C022_HealthCareCodeInformation_9")]
    public class C022_HealthCareCodeInformation_9
    {
        
        [Required]
        [DataElement("1270", typeof(X12_ID_1270_3))]
        [Pos(1)]
        public string DiagnosisTypeCode_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(2)]
        public string DiagnosisCode_02 { get; set; }
        [DataElement("1250", typeof(X12_ID_1250_3))]
        [Pos(3)]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(4)]
        public string DateTimePeriod_04 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(5)]
        public string MonetaryAmount_05 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        public string Quantity_06 { get; set; }
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(7)]
        public string VersionIdentifier_07 { get; set; }
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(8)]
        public string IndustryCode_08 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(9)]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    [Serializable()]
    [Composite("C022_HealthCareCodeInformation_8")]
    public class C022_HealthCareCodeInformation_8
    {
        
        [Required]
        [DataElement("1270", typeof(X12_ID_1270_3))]
        [Pos(1)]
        public string DiagnosisTypeCode_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(2)]
        public string DiagnosisCode_02 { get; set; }
        [DataElement("1250", typeof(X12_ID_1250_3))]
        [Pos(3)]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(4)]
        public string DateTimePeriod_04 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(5)]
        public string MonetaryAmount_05 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        public string Quantity_06 { get; set; }
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(7)]
        public string VersionIdentifier_07 { get; set; }
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(8)]
        public string IndustryCode_08 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(9)]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    [Serializable()]
    [Composite("C022_HealthCareCodeInformation_7")]
    public class C022_HealthCareCodeInformation_7
    {
        
        [Required]
        [DataElement("1270", typeof(X12_ID_1270_3))]
        [Pos(1)]
        public string DiagnosisTypeCode_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(2)]
        public string DiagnosisCode_02 { get; set; }
        [DataElement("1250", typeof(X12_ID_1250_3))]
        [Pos(3)]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(4)]
        public string DateTimePeriod_04 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(5)]
        public string MonetaryAmount_05 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        public string Quantity_06 { get; set; }
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(7)]
        public string VersionIdentifier_07 { get; set; }
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(8)]
        public string IndustryCode_08 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(9)]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    [Serializable()]
    [Composite("C022_HealthCareCodeInformation_6")]
    public class C022_HealthCareCodeInformation_6
    {
        
        [Required]
        [DataElement("1270", typeof(X12_ID_1270_3))]
        [Pos(1)]
        public string DiagnosisTypeCode_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(2)]
        public string DiagnosisCode_02 { get; set; }
        [DataElement("1250", typeof(X12_ID_1250_3))]
        [Pos(3)]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(4)]
        public string DateTimePeriod_04 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(5)]
        public string MonetaryAmount_05 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        public string Quantity_06 { get; set; }
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(7)]
        public string VersionIdentifier_07 { get; set; }
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(8)]
        public string IndustryCode_08 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(9)]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    [Serializable()]
    [Composite("C022_HealthCareCodeInformation_5")]
    public class C022_HealthCareCodeInformation_5
    {
        
        [Required]
        [DataElement("1270", typeof(X12_ID_1270_3))]
        [Pos(1)]
        public string DiagnosisTypeCode_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(2)]
        public string DiagnosisCode_02 { get; set; }
        [DataElement("1250", typeof(X12_ID_1250_3))]
        [Pos(3)]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(4)]
        public string DateTimePeriod_04 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(5)]
        public string MonetaryAmount_05 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        public string Quantity_06 { get; set; }
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(7)]
        public string VersionIdentifier_07 { get; set; }
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(8)]
        public string IndustryCode_08 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(9)]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    [Serializable()]
    [Composite("C022_HealthCareCodeInformation_4")]
    public class C022_HealthCareCodeInformation_4
    {
        
        [Required]
        [DataElement("1270", typeof(X12_ID_1270_3))]
        [Pos(1)]
        public string DiagnosisTypeCode_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(2)]
        public string DiagnosisCode_02 { get; set; }
        [DataElement("1250", typeof(X12_ID_1250_3))]
        [Pos(3)]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(4)]
        public string DateTimePeriod_04 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(5)]
        public string MonetaryAmount_05 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        public string Quantity_06 { get; set; }
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(7)]
        public string VersionIdentifier_07 { get; set; }
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(8)]
        public string IndustryCode_08 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(9)]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    [Serializable()]
    [Composite("C022_HealthCareCodeInformation_3")]
    public class C022_HealthCareCodeInformation_3
    {
        
        [Required]
        [DataElement("1270", typeof(X12_ID_1270_3))]
        [Pos(1)]
        public string DiagnosisTypeCode_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(2)]
        public string DiagnosisCode_02 { get; set; }
        [DataElement("1250", typeof(X12_ID_1250_3))]
        [Pos(3)]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(4)]
        public string DateTimePeriod_04 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(5)]
        public string MonetaryAmount_05 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        public string Quantity_06 { get; set; }
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(7)]
        public string VersionIdentifier_07 { get; set; }
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(8)]
        public string IndustryCode_08 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(9)]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    [Serializable()]
    [Composite("C022_HealthCareCodeInformation_2")]
    public class C022_HealthCareCodeInformation_2
    {
        
        [Required]
        [DataElement("1270", typeof(X12_ID_1270_3))]
        [Pos(1)]
        public string DiagnosisTypeCode_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(2)]
        public string DiagnosisCode_02 { get; set; }
        [DataElement("1250", typeof(X12_ID_1250_3))]
        [Pos(3)]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(4)]
        public string DateTimePeriod_04 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(5)]
        public string MonetaryAmount_05 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        public string Quantity_06 { get; set; }
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(7)]
        public string VersionIdentifier_07 { get; set; }
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(8)]
        public string IndustryCode_08 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(9)]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    [Serializable()]
    [Composite("C022_HealthCareCodeInformation")]
    public class C022_HealthCareCodeInformation
    {
        
        [Required]
        [DataElement("1270", typeof(X12_ID_1270_2))]
        [Pos(1)]
        public string DiagnosisTypeCode_01 { get; set; }
        [Required]
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(2)]
        public string DiagnosisCode_02 { get; set; }
        [DataElement("1250", typeof(X12_ID_1250_3))]
        [Pos(3)]
        public string DateTimePeriodFormatQualifier_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(4)]
        public string DateTimePeriod_04 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(5)]
        public string MonetaryAmount_05 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        public string Quantity_06 { get; set; }
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(7)]
        public string VersionIdentifier_07 { get; set; }
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(8)]
        public string IndustryCode_08 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(9)]
        public string YesNoConditionorResponseCode_09 { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_CRC
    {
        
        [ListCount(3)]
        [Pos(1)]
        public List<CRC_AmbulanceCertification> CRC_AmbulanceCertification { get; set; }
        [ListCount(3)]
        [Pos(2)]
        public List<CRC_PatientConditionInformation_Vision> CRC_PatientConditionInformation_Vision { get; set; }
        [Pos(3)]
        public CRC_HomeboundIndicator CRC_HomeboundIndicator { get; set; }
        [Pos(4)]
        public CRC_EPSDTReferral CRC_EPSDTReferral { get; set; }
    }
    
    [Serializable()]
    [Segment("CRC", typeof(X12_ID_1136_4), typeof(X12_ID_1073_3))]
    public class CRC_EPSDTReferral
    {
        
        [Required]
        [DataElement("1136", typeof(X12_ID_1136_4))]
        [Pos(1)]
        public string CodeQualifier_01 { get; set; }
        [Required]
        [DataElement("1073", typeof(X12_ID_1073_3))]
        [Pos(2)]
        public string CertificationConditionCodeAppliesIndicator_02 { get; set; }
        [Required]
        [DataElement("1321", typeof(X12_ID_1321_5))]
        [Pos(3)]
        public string ConditionIndicator_03 { get; set; }
        [DataElement("1321", typeof(X12_ID_1321_5))]
        [Pos(4)]
        public string ConditionIndicator_04 { get; set; }
        [DataElement("1321", typeof(X12_ID_1321_5))]
        [Pos(5)]
        public string ConditionIndicator_05 { get; set; }
        [DataElement("1321", typeof(X12_ID_1321_4))]
        [Pos(6)]
        public string ConditionIndicator_06 { get; set; }
        [DataElement("1321", typeof(X12_ID_1321_4))]
        [Pos(7)]
        public string ConditionIndicator_07 { get; set; }
    }
    
    [Serializable()]
    [Segment("CRC", typeof(X12_ID_1136_3), typeof(X12_ID_1073_2))]
    public class CRC_HomeboundIndicator
    {
        
        [Required]
        [DataElement("1136", typeof(X12_ID_1136_3))]
        [Pos(1)]
        public string CodeCategory_01 { get; set; }
        [Required]
        [DataElement("1073", typeof(X12_ID_1073_2))]
        [Pos(2)]
        public string CertificationConditionIndicator_02 { get; set; }
        [Required]
        [DataElement("1321", typeof(X12_ID_1321_3))]
        [Pos(3)]
        public string HomeboundIndicator_03 { get; set; }
        [DataElement("1321", typeof(X12_ID_1321_4))]
        [Pos(4)]
        public string ConditionIndicator_04 { get; set; }
        [DataElement("1321", typeof(X12_ID_1321_4))]
        [Pos(5)]
        public string ConditionIndicator_05 { get; set; }
        [DataElement("1321", typeof(X12_ID_1321_4))]
        [Pos(6)]
        public string ConditionIndicator_06 { get; set; }
        [DataElement("1321", typeof(X12_ID_1321_4))]
        [Pos(7)]
        public string ConditionIndicator_07 { get; set; }
    }
    
    [Serializable()]
    [Segment("CRC", typeof(X12_ID_1136_2), typeof(X12_ID_1073_3))]
    public class CRC_PatientConditionInformation_Vision
    {
        
        [Required]
        [DataElement("1136", typeof(X12_ID_1136_2))]
        [Pos(1)]
        public string CodeCategory_01 { get; set; }
        [Required]
        [DataElement("1073", typeof(X12_ID_1073_3))]
        [Pos(2)]
        public string CertificationConditionIndicator_02 { get; set; }
        [Required]
        [DataElement("1321", typeof(X12_ID_1321_2))]
        [Pos(3)]
        public string ConditionCode_03 { get; set; }
        [DataElement("1321", typeof(X12_ID_1321_2))]
        [Pos(4)]
        public string ConditionCode_04 { get; set; }
        [DataElement("1321", typeof(X12_ID_1321_2))]
        [Pos(5)]
        public string ConditionCode_05 { get; set; }
        [DataElement("1321", typeof(X12_ID_1321_2))]
        [Pos(6)]
        public string ConditionCode_06 { get; set; }
        [DataElement("1321", typeof(X12_ID_1321_2))]
        [Pos(7)]
        public string ConditionCode_07 { get; set; }
    }
    
    [Serializable()]
    [Segment("CRC", typeof(X12_ID_1136), typeof(X12_ID_1073_3))]
    public class CRC_AmbulanceCertification
    {
        
        [Required]
        [DataElement("1136", typeof(X12_ID_1136))]
        [Pos(1)]
        public string CodeCategory_01 { get; set; }
        [Required]
        [DataElement("1073", typeof(X12_ID_1073_3))]
        [Pos(2)]
        public string CertificationConditionIndicator_02 { get; set; }
        [Required]
        [DataElement("1321", typeof(X12_ID_1321))]
        [Pos(3)]
        public string ConditionCode_03 { get; set; }
        [DataElement("1321", typeof(X12_ID_1321))]
        [Pos(4)]
        public string ConditionCode_04 { get; set; }
        [DataElement("1321", typeof(X12_ID_1321))]
        [Pos(5)]
        public string ConditionCode_05 { get; set; }
        [DataElement("1321", typeof(X12_ID_1321))]
        [Pos(6)]
        public string ConditionCode_06 { get; set; }
        [DataElement("1321", typeof(X12_ID_1321))]
        [Pos(7)]
        public string ConditionCode_07 { get; set; }
    }
    
    [Serializable()]
    [Segment("CR2")]
    public class CR2_SpinalManipulationServiceInformation
    {
        
        [StringLength(1, 9)]
        [DataElement("609", typeof(X12_N0))]
        [Pos(1)]
        public string Count_01 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(2)]
        public string Quantity_02 { get; set; }
        [DataElement("1367", typeof(X12_ID_1367))]
        [Pos(3)]
        public string SubluxationLevelCode_03 { get; set; }
        [DataElement("1367", typeof(X12_ID_1367))]
        [Pos(4)]
        public string SubluxationLevelCode_04 { get; set; }
        [DataElement("355", typeof(X12_ID_355_2))]
        [Pos(5)]
        public string UnitorBasisforMeasurementCode_05 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        public string Quantity_06 { get; set; }
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(7)]
        public string Quantity_07 { get; set; }
        [Required]
        [DataElement("1342", typeof(X12_ID_1342))]
        [Pos(8)]
        public string PatientConditionCode_08 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(9)]
        public string YesNoConditionorResponseCode_09 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(10)]
        public string PatientConditionDescription_10 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(11)]
        public string PatientConditionDescription_11 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(12)]
        public string YesNoConditionorResponseCode_12 { get; set; }
    }
    
    [Serializable()]
    [Segment("CR1", typeof(X12_ID_355_3))]
    public class CR1_AmbulanceTransportInformation
    {
        
        [DataElement("355", typeof(X12_ID_355_3))]
        [Pos(1)]
        public string UnitorBasisforMeasurementCode_01 { get; set; }
        [StringLength(1, 10)]
        [DataElement("81", typeof(X12_R))]
        [Pos(2)]
        public string PatientWeight_02 { get; set; }
        [DataElement("1316", typeof(X12_ID_1316))]
        [Pos(3)]
        public string AmbulanceTransportCode_03 { get; set; }
        [Required]
        [DataElement("1317", typeof(X12_ID_1317))]
        [Pos(4)]
        public string AmbulanceTransportReasonCode_04 { get; set; }
        [Required]
        [DataElement("355", typeof(X12_ID_355_4))]
        [Pos(5)]
        public string UnitorBasisforMeasurementCode_05 { get; set; }
        [Required]
        [StringLength(1, 15)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        public string TransportDistance_06 { get; set; }
        [StringLength(1, 55)]
        [DataElement("166", typeof(X12_AN))]
        [Pos(7)]
        public string AddressInformation_07 { get; set; }
        [StringLength(1, 55)]
        [DataElement("166", typeof(X12_AN))]
        [Pos(8)]
        public string AddressInformation_08 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(9)]
        public string RoundTripPurposeDescription_09 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(10)]
        public string StretcherPurposeDescription_10 { get; set; }
    }
    
    [Serializable()]
    [Segment("NTE", typeof(X12_ID_363))]
    public class NTE_ClaimNote
    {
        
        [Required]
        [DataElement("363", typeof(X12_ID_363))]
        [Pos(1)]
        public string NoteReferenceCode_01 { get; set; }
        [Required]
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(2)]
        public string ClaimNoteText_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("K3")]
    public class K3_FileInformation
    {
        
        [Required]
        [StringLength(1, 80)]
        [DataElement("449", typeof(X12_AN))]
        [Pos(1)]
        public string FixedFormatInformation_01 { get; set; }
        [DataElement("1333", typeof(X12_ID_1333))]
        [Pos(2)]
        public string RecordFormatCode_02 { get; set; }
        [Pos(3)]
        public C001_CompositeUnitofMeasure CompositeUnitofMeasure_03 { get; set; }
    }
    
    [Serializable()]
    [Composite("C001_CompositeUnitofMeasure")]
    public class C001_CompositeUnitofMeasure
    {
        
        [Required]
        [DataElement("355", typeof(X12_ID_355_2))]
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
        [DataElement("355", typeof(X12_ID_355_2))]
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
        [DataElement("355", typeof(X12_ID_355_2))]
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
        [DataElement("355", typeof(X12_ID_355_2))]
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
        [DataElement("355", typeof(X12_ID_355_2))]
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
    [All()]
    public class All_REF_5
    {
        
        [Pos(1)]
        public REF_ServiceAuthorizationExceptionCode REF_ServiceAuthorizationExceptionCode { get; set; }
        [Pos(2)]
        public REF_MandatoryMedicare_Section4081_CrossoverIndicator REF_MandatoryMedicare_Section4081_CrossoverIndicator { get; set; }
        [Pos(3)]
        public REF_MammographyCertificationNumber REF_MammographyCertificationNumber { get; set; }
        [Pos(4)]
        public REF_ReferralNumber REF_ReferralNumber { get; set; }
        [Pos(5)]
        public REF_PriorAuthorization REF_PriorAuthorization { get; set; }
        [Pos(6)]
        public REF_PayerClaimControlNumber REF_PayerClaimControlNumber { get; set; }
        [Pos(7)]
        public REF_ClinicalLaboratoryImprovementAmendment_CLIA_Number REF_ClinicalLaboratoryImprovementAmendment_CLIA_Number { get; set; }
        [Pos(8)]
        public REF_RepricedClaimNumber REF_RepricedClaimNumber { get; set; }
        [Pos(9)]
        public REF_AdjustedRepricedClaimNumber REF_AdjustedRepricedClaimNumber { get; set; }
        [Pos(10)]
        public REF_InvestigationalDeviceExemptionNumber REF_InvestigationalDeviceExemptionNumber { get; set; }
        [Pos(11)]
        public REF_ClaimIdentifierForTransmissionIntermediaries REF_ClaimIdentifierForTransmissionIntermediaries { get; set; }
        [Pos(12)]
        public REF_MedicalRecordNumber REF_MedicalRecordNumber { get; set; }
        [Pos(13)]
        public REF_DemonstrationProjectIdentifier REF_DemonstrationProjectIdentifier { get; set; }
        [Pos(14)]
        public REF_CarePlanOversight REF_CarePlanOversight { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_24))]
    public class REF_CarePlanOversight
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_24))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string CarePlanOversightNumber_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        [Pos(4)]
        public C040_ReferenceIdentifier_22 ReferenceIdentifier_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C040_ReferenceIdentifier_22")]
    public class C040_ReferenceIdentifier_22
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_23))]
    public class REF_DemonstrationProjectIdentifier
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_23))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string DemonstrationProjectIdentifier_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        [Pos(4)]
        public C040_ReferenceIdentifier_21 ReferenceIdentifier_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C040_ReferenceIdentifier_21")]
    public class C040_ReferenceIdentifier_21
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_22))]
    public class REF_MedicalRecordNumber
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_22))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string MedicalRecordNumber_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        [Pos(4)]
        public C040_ReferenceIdentifier_20 ReferenceIdentifier_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C040_ReferenceIdentifier_20")]
    public class C040_ReferenceIdentifier_20
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_21))]
    public class REF_ClaimIdentifierForTransmissionIntermediaries
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_21))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ValueAddedNetworkTraceNumber_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        [Pos(4)]
        public C040_ReferenceIdentifier_19 ReferenceIdentifier_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C040_ReferenceIdentifier_19")]
    public class C040_ReferenceIdentifier_19
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_20))]
    public class REF_InvestigationalDeviceExemptionNumber
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_20))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string InvestigationalDeviceExemptionIdentifier_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        [Pos(4)]
        public C040_ReferenceIdentifier_18 ReferenceIdentifier_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C040_ReferenceIdentifier_18")]
    public class C040_ReferenceIdentifier_18
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_19))]
    public class REF_AdjustedRepricedClaimNumber
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_19))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string AdjustedRepricedClaimReferenceNumber_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        [Pos(4)]
        public C040_ReferenceIdentifier_17 ReferenceIdentifier_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C040_ReferenceIdentifier_17")]
    public class C040_ReferenceIdentifier_17
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_18))]
    public class REF_RepricedClaimNumber
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_18))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string RepricedClaimReferenceNumber_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        [Pos(4)]
        public C040_ReferenceIdentifier_16 ReferenceIdentifier_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C040_ReferenceIdentifier_16")]
    public class C040_ReferenceIdentifier_16
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_17))]
    public class REF_ClinicalLaboratoryImprovementAmendment_CLIA_Number
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_17))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ClinicalLaboratoryImprovementAmendmentNumber_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        [Pos(4)]
        public C040_ReferenceIdentifier_15 ReferenceIdentifier_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C040_ReferenceIdentifier_15")]
    public class C040_ReferenceIdentifier_15
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_16))]
    public class REF_PayerClaimControlNumber
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_16))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string PayerClaimControlNumber_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        [Pos(4)]
        public C040_ReferenceIdentifier_14 ReferenceIdentifier_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C040_ReferenceIdentifier_14")]
    public class C040_ReferenceIdentifier_14
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_15))]
    public class REF_PriorAuthorization
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_15))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string PriorAuthorizationNumber_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        [Pos(4)]
        public C040_ReferenceIdentifier_13 ReferenceIdentifier_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C040_ReferenceIdentifier_13")]
    public class C040_ReferenceIdentifier_13
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_14))]
    public class REF_ReferralNumber
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_14))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferralNumber_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        [Pos(4)]
        public C040_ReferenceIdentifier_12 ReferenceIdentifier_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C040_ReferenceIdentifier_12")]
    public class C040_ReferenceIdentifier_12
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_13))]
    public class REF_MammographyCertificationNumber
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_13))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string MammographyCertificationNumber_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        [Pos(4)]
        public C040_ReferenceIdentifier_11 ReferenceIdentifier_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C040_ReferenceIdentifier_11")]
    public class C040_ReferenceIdentifier_11
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_12), typeof(X12_ID_127_2))]
    public class REF_MandatoryMedicare_Section4081_CrossoverIndicator
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_12))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [DataElement("127", typeof(X12_ID_127_2))]
        [Pos(2)]
        public string MedicareSection4081Indicator_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        [Pos(4)]
        public C040_ReferenceIdentifier_10 ReferenceIdentifier_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C040_ReferenceIdentifier_10")]
    public class C040_ReferenceIdentifier_10
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_11), typeof(X12_ID_127_1))]
    public class REF_ServiceAuthorizationExceptionCode
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_11))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [DataElement("127", typeof(X12_ID_127_1))]
        [Pos(2)]
        public string ServiceAuthorizationExceptionCode_02 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        [Pos(4)]
        public C040_ReferenceIdentifier_9 ReferenceIdentifier_04 { get; set; }
    }
    
    [Serializable()]
    [Composite("C040_ReferenceIdentifier_9")]
    public class C040_ReferenceIdentifier_9
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("AMT", typeof(X12_ID_522))]
    public class AMT_PatientAmountPaid
    {
        
        [Required]
        [DataElement("522", typeof(X12_ID_522))]
        [Pos(1)]
        public string AmountQualifierCode_01 { get; set; }
        [Required]
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(2)]
        public string PatientAmountPaid_02 { get; set; }
        [DataElement("478", typeof(X12_ID_478))]
        [Pos(3)]
        public string CreditDebitFlagCode_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("CN1", typeof(X12_ID_1166))]
    public class CN1_ContractInformation
    {
        
        [Required]
        [DataElement("1166", typeof(X12_ID_1166))]
        [Pos(1)]
        public string ContractTypeCode_01 { get; set; }
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(2)]
        public string ContractAmount_02 { get; set; }
        [StringLength(1, 6)]
        [DataElement("332", typeof(X12_R))]
        [Pos(3)]
        public string ContractPercentage_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ContractCode_04 { get; set; }
        [StringLength(1, 6)]
        [DataElement("338", typeof(X12_R))]
        [Pos(5)]
        public string TermsDiscountPercentage_05 { get; set; }
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(6)]
        public string ContractVersionIdentifier_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("PWK", typeof(X12_ID_755), typeof(X12_ID_756))]
    public class PWK_ClaimSupplementalInformation
    {
        
        [Required]
        [DataElement("755", typeof(X12_ID_755))]
        [Pos(1)]
        public string AttachmentReportTypeCode_01 { get; set; }
        [Required]
        [DataElement("756", typeof(X12_ID_756))]
        [Pos(2)]
        public string AttachmentTransmissionCode_02 { get; set; }
        [StringLength(1, 2)]
        [DataElement("757", typeof(X12_N0))]
        [Pos(3)]
        public string ReportCopiesNeeded_03 { get; set; }
        [DataElement("98", typeof(X12_ID_98_2))]
        [Pos(4)]
        public string EntityIdentifierCode_04 { get; set; }
        [DataElement("66", typeof(X12_ID_66_6))]
        [Pos(5)]
        public string IdentificationCodeQualifier_05 { get; set; }
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(6)]
        public string AttachmentControlNumber_06 { get; set; }
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(7)]
        public string Description_07 { get; set; }
        [Pos(8)]
        public C002_ActionsIndicated ActionsIndicated_08 { get; set; }
        [DataElement("1525", typeof(X12_ID_1525))]
        [Pos(9)]
        public string RequestCategoryCode_09 { get; set; }
    }
    
    [Serializable()]
    [Composite("C002_ActionsIndicated")]
    public class C002_ActionsIndicated
    {
        
        [Required]
        [DataElement("704", typeof(X12_ID_704))]
        [Pos(1)]
        public string PaperworkReportActionCode_01 { get; set; }
        [DataElement("704", typeof(X12_ID_704))]
        [Pos(2)]
        public string PaperworkReportActionCode_02 { get; set; }
        [DataElement("704", typeof(X12_ID_704))]
        [Pos(3)]
        public string PaperworkReportActionCode_03 { get; set; }
        [DataElement("704", typeof(X12_ID_704))]
        [Pos(4)]
        public string PaperworkReportActionCode_04 { get; set; }
        [DataElement("704", typeof(X12_ID_704))]
        [Pos(5)]
        public string PaperworkReportActionCode_05 { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_DTP
    {
        
        [Pos(1)]
        public DTP_Date_OnsetofCurrentIllnessorSymptom DTP_Date_OnsetofCurrentIllnessorSymptom { get; set; }
        [Pos(2)]
        public DTP_Date_InitialTreatmentDate DTP_Date_InitialTreatmentDate { get; set; }
        [Pos(3)]
        public DTP_Date_LastSeenDate DTP_Date_LastSeenDate { get; set; }
        [Pos(4)]
        public DTP_Date_AcuteManifestation DTP_Date_AcuteManifestation { get; set; }
        [Pos(5)]
        public DTP_Date_Accident DTP_Date_Accident { get; set; }
        [Pos(6)]
        public DTP_Date_LastMenstrualPeriod DTP_Date_LastMenstrualPeriod { get; set; }
        [Pos(7)]
        public DTP_Date_LastX_rayDate DTP_Date_LastX_rayDate { get; set; }
        [Pos(8)]
        public DTP_Date_HearingandVisionPrescriptionDate DTP_Date_HearingandVisionPrescriptionDate { get; set; }
        [Pos(9)]
        public DTP_Date_DisabilityDates DTP_Date_DisabilityDates { get; set; }
        [Pos(10)]
        public DTP_Date_LastWorked DTP_Date_LastWorked { get; set; }
        [Pos(11)]
        public DTP_Date_AuthorizedReturntoWork DTP_Date_AuthorizedReturntoWork { get; set; }
        [Pos(12)]
        public DTP_Date_Admission DTP_Date_Admission { get; set; }
        [Pos(13)]
        public DTP_Date_Discharge DTP_Date_Discharge { get; set; }
        [ListCount(2)]
        [Pos(14)]
        public List<DTP_Date_AssumedandRelinquishedCareDates> DTP_Date_AssumedandRelinquishedCareDates { get; set; }
        [Pos(15)]
        public DTP_PropertyandCasualtyDateofFirstContact DTP_PropertyandCasualtyDateofFirstContact { get; set; }
        [Pos(16)]
        public DTP_Date_RepricerReceivedDate DTP_Date_RepricerReceivedDate { get; set; }
    }
    
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_17), typeof(X12_ID_1250))]
    public class DTP_Date_RepricerReceivedDate
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374_17))]
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
        public string RepricerReceivedDate_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_16), typeof(X12_ID_1250))]
    public class DTP_PropertyandCasualtyDateofFirstContact
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374_16))]
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
    [Segment("DTP", typeof(X12_ID_374_15), typeof(X12_ID_1250))]
    public class DTP_Date_AssumedandRelinquishedCareDates
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374_15))]
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
        public string AssumedorRelinquishedCareDate_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_14), typeof(X12_ID_1250))]
    public class DTP_Date_Discharge
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374_14))]
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
        public string RelatedHospitalizationDischargeDate_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_13), typeof(X12_ID_1250))]
    public class DTP_Date_Admission
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374_13))]
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
        public string RelatedHospitalizationAdmissionDate_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_12), typeof(X12_ID_1250))]
    public class DTP_Date_AuthorizedReturntoWork
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374_12))]
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
        public string WorkReturnDate_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_11), typeof(X12_ID_1250))]
    public class DTP_Date_LastWorked
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374_11))]
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
        public string LastWorkedDate_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_10), typeof(X12_ID_1250_2))]
    public class DTP_Date_DisabilityDates
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374_10))]
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
        public string DisabilityFromDate_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_9), typeof(X12_ID_1250))]
    public class DTP_Date_HearingandVisionPrescriptionDate
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374_9))]
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
        public string PrescriptionDate_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_8), typeof(X12_ID_1250))]
    public class DTP_Date_LastX_rayDate
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374_8))]
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
        public string LastXRayDate_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_7), typeof(X12_ID_1250))]
    public class DTP_Date_LastMenstrualPeriod
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374_7))]
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
        public string LastMenstrualPeriodDate_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_6), typeof(X12_ID_1250))]
    public class DTP_Date_Accident
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374_6))]
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
        public string AccidentDate_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_5), typeof(X12_ID_1250))]
    public class DTP_Date_AcuteManifestation
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
        public string AcuteManifestationDate_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_4), typeof(X12_ID_1250))]
    public class DTP_Date_LastSeenDate
    {
        
        [Required]
        [DataElement("374", typeof(X12_ID_374_4))]
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
        public string LastSeenDate_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_3), typeof(X12_ID_1250))]
    public class DTP_Date_InitialTreatmentDate
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
        public string InitialTreatmentDate_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("DTP", typeof(X12_ID_374_2), typeof(X12_ID_1250))]
    public class DTP_Date_OnsetofCurrentIllnessorSymptom
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
        public string OnsetofCurrentIllnessorInjuryDate_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("CLM")]
    public class CLM_ClaimInformation
    {
        
        [Required]
        [StringLength(1, 38)]
        [DataElement("1028", typeof(X12_AN))]
        [Pos(1)]
        public string PatientControlNumber_01 { get; set; }
        [Required]
        [StringLength(1, 18)]
        [DataElement("782", typeof(X12_R))]
        [Pos(2)]
        public string TotalClaimChargeAmount_02 { get; set; }
        [DataElement("1032", typeof(X12_ID_1032_2))]
        [Pos(3)]
        public string ClaimFilingIndicatorCode_03 { get; set; }
        [DataElement("1343", typeof(X12_ID_1343))]
        [Pos(4)]
        public string NonInstitutionalClaimTypeCode_04 { get; set; }
        [Required]
        [Pos(5)]
        public C023_HealthCareServiceLocationInformation HealthCareServiceLocationInformation_05 { get; set; }
        [Required]
        [DataElement("1073", typeof(X12_ID_1073_3))]
        [Pos(6)]
        public string ProviderorSupplierSignatureIndicator_06 { get; set; }
        [Required]
        [DataElement("1359", typeof(X12_ID_1359))]
        [Pos(7)]
        public string AssignmentorPlanParticipationCode_07 { get; set; }
        [Required]
        [DataElement("1073", typeof(X12_ID_1073_4))]
        [Pos(8)]
        public string BenefitsAssignmentCertificationIndicator_08 { get; set; }
        [Required]
        [DataElement("1363", typeof(X12_ID_1363))]
        [Pos(9)]
        public string ReleaseofInformationCode_09 { get; set; }
        [DataElement("1351", typeof(X12_ID_1351))]
        [Pos(10)]
        public string PatientSignatureSourceCode_10 { get; set; }
        [Pos(11)]
        public C024_RelatedCausesInformation RelatedCausesInformation_11 { get; set; }
        [DataElement("1366", typeof(X12_ID_1366))]
        [Pos(12)]
        public string SpecialProgramIndicator_12 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(13)]
        public string YesNoConditionorResponseCode_13 { get; set; }
        [DataElement("1338", typeof(X12_ID_1338))]
        [Pos(14)]
        public string LevelofServiceCode_14 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(15)]
        public string YesNoConditionorResponseCode_15 { get; set; }
        [DataElement("1360", typeof(X12_ID_1360))]
        [Pos(16)]
        public string ProviderAgreementCode_16 { get; set; }
        [DataElement("1029", typeof(X12_ID_1029))]
        [Pos(17)]
        public string ClaimStatusCode_17 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(18)]
        public string YesNoConditionorResponseCode_18 { get; set; }
        [DataElement("1383", typeof(X12_ID_1383))]
        [Pos(19)]
        public string ClaimSubmissionReasonCode_19 { get; set; }
        [DataElement("1514", typeof(X12_ID_1514))]
        [Pos(20)]
        public string DelayReasonCode_20 { get; set; }
    }
    
    [Serializable()]
    [Composite("C024_RelatedCausesInformation")]
    public class C024_RelatedCausesInformation
    {
        
        [Required]
        [DataElement("1362", typeof(X12_ID_1362))]
        [Pos(1)]
        public string RelatedCausesCode_01 { get; set; }
        [DataElement("1362", typeof(X12_ID_1362))]
        [Pos(2)]
        public string RelatedCausesCode_02 { get; set; }
        [DataElement("1362", typeof(X12_ID_1362_2))]
        [Pos(3)]
        public string RelatedCausesCode_03 { get; set; }
        [StringLength(2, 2)]
        [DataElement("156", typeof(X12_ID))]
        [Pos(4)]
        public string AutoAccidentStateorProvinceCode_04 { get; set; }
        [StringLength(2, 3)]
        [DataElement("26", typeof(X12_ID))]
        [Pos(5)]
        public string CountryCode_05 { get; set; }
    }
    
    [Serializable()]
    [Composite("C023_HealthCareServiceLocationInformation")]
    public class C023_HealthCareServiceLocationInformation
    {
        
        [Required]
        [StringLength(1, 2)]
        [DataElement("1331", typeof(X12_AN))]
        [Pos(1)]
        public string PlaceofServiceCode_01 { get; set; }
        [Required]
        [DataElement("1332", typeof(X12_ID_1332))]
        [Pos(2)]
        public string FacilityCodeQualifier_02 { get; set; }
        [Required]
        [StringLength(1, 1)]
        [DataElement("1325", typeof(X12_ID))]
        [Pos(3)]
        public string ClaimFrequencyCode_03 { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_NM1_3
    {
        
        [Required]
        [Pos(1)]
        public Loop_2010BA Loop_2010BA { get; set; }
        [Required]
        [Pos(2)]
        public Loop_2010BB Loop_2010BB { get; set; }
    }
    
    [Serializable()]
    [Group("NM1")]
    public class Loop_2010BB
    {
        
        [Required]
        [Pos(1)]
        public NM1_PayerName NM1_PayerName { get; set; }
        [Pos(2)]
        public N3_PayerAddress N3_PayerAddress { get; set; }
        [Pos(3)]
        public N4_PayerCity_State_ZIPCode N4_PayerCity_State_ZIPCode { get; set; }
        [Pos(4)]
        public All_REF_4 All_REF_4 { get; set; }
    }
    
    [Serializable()]
    [All()]
    public class All_REF_4
    {
        
        [ListCount(3)]
        [Pos(1)]
        public List<REF_PayerSecondaryIdentification> REF_PayerSecondaryIdentification { get; set; }
        [ListCount(2)]
        [Pos(2)]
        public List<REF_BillingProviderSecondaryIdentification> REF_BillingProviderSecondaryIdentification { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_10))]
    public class REF_BillingProviderSecondaryIdentification
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_10))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string BillingProviderSecondaryIdentifier_02 { get; set; }
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
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_9))]
    public class REF_PayerSecondaryIdentification
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_9))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string PayerSecondaryIdentifier_02 { get; set; }
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
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("N4")]
    public class N4_PayerCity_State_ZIPCode
    {
        
        [Required]
        [StringLength(2, 30)]
        [DataElement("19", typeof(X12_AN))]
        [Pos(1)]
        public string PayerCityName_01 { get; set; }
        [StringLength(2, 2)]
        [DataElement("156", typeof(X12_ID))]
        [Pos(2)]
        public string PayerStateorProvinceCode_02 { get; set; }
        [StringLength(3, 15)]
        [DataElement("116", typeof(X12_ID))]
        [Pos(3)]
        public string PayerPostalZoneorZIPCode_03 { get; set; }
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
    [Segment("N3")]
    public class N3_PayerAddress
    {
        
        [Required]
        [StringLength(1, 55)]
        [DataElement("166", typeof(X12_AN))]
        [Pos(1)]
        public string PayerAddressLine_01 { get; set; }
        [StringLength(1, 55)]
        [DataElement("166", typeof(X12_AN))]
        [Pos(2)]
        public string PayerAddressLine_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_8), typeof(X12_ID_1065_2))]
    public class NM1_PayerName
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98_8))]
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        [Required]
        [DataElement("1065", typeof(X12_ID_1065_2))]
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        [Required]
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(3)]
        public string PayerName_03 { get; set; }
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
        [Required]
        [DataElement("66", typeof(X12_ID_66_4))]
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        [Required]
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(9)]
        public string PayerIdentifier_09 { get; set; }
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
    public class Loop_2010BA
    {
        
        [Required]
        [Pos(1)]
        public NM1_SubscriberName NM1_SubscriberName { get; set; }
        [Pos(2)]
        public N3_SubscriberAddress N3_SubscriberAddress { get; set; }
        [Pos(3)]
        public N4_SubscriberCity_State_ZIPCode N4_SubscriberCity_State_ZIPCode { get; set; }
        [Pos(4)]
        public DMG_SubscriberDemographicInformation DMG_SubscriberDemographicInformation { get; set; }
        [Pos(5)]
        public All_REF_3 All_REF_3 { get; set; }
        [Pos(6)]
        public PER_PropertyandCasualtySubscriberContactInformation PER_PropertyandCasualtySubscriberContactInformation { get; set; }
    }
    
    [Serializable()]
    [Segment("PER", typeof(X12_ID_366))]
    public class PER_PropertyandCasualtySubscriberContactInformation
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
        [DataElement("365", typeof(X12_ID_365_3))]
        [Pos(3)]
        public string CommunicationNumberQualifier_03 { get; set; }
        [Required]
        [StringLength(1, 256)]
        [DataElement("364", typeof(X12_AN))]
        [Pos(4)]
        public string CommunicationNumber_04 { get; set; }
        [DataElement("365", typeof(X12_ID_365_4))]
        [Pos(5)]
        public string CommunicationNumberQualifier_05 { get; set; }
        [StringLength(1, 256)]
        [DataElement("364", typeof(X12_AN))]
        [Pos(6)]
        public string CommunicationNumber_06 { get; set; }
        [DataElement("365", typeof(X12_ID_365_5))]
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
    [All()]
    public class All_REF_3
    {
        
        [Pos(1)]
        public REF_SubscriberSecondaryIdentification REF_SubscriberSecondaryIdentification { get; set; }
        [Pos(2)]
        public REF_PropertyandCasualtyClaimNumber REF_PropertyandCasualtyClaimNumber { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_8))]
    public class REF_PropertyandCasualtyClaimNumber
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_8))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string PropertyCasualtyClaimNumber_02 { get; set; }
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
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_7))]
    public class REF_SubscriberSecondaryIdentification
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_7))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string SubscriberSupplementalIdentifier_02 { get; set; }
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
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("DMG", typeof(X12_ID_1250))]
    public class DMG_SubscriberDemographicInformation
    {
        
        [Required]
        [DataElement("1250", typeof(X12_ID_1250))]
        [Pos(1)]
        public string DateTimePeriodFormatQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(2)]
        public string SubscriberBirthDate_02 { get; set; }
        [Required]
        [DataElement("1068", typeof(X12_ID_1068))]
        [Pos(3)]
        public string SubscriberGenderCode_03 { get; set; }
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
        [DataElement("1270", typeof(X12_ID_1270))]
        [Pos(10)]
        public string CodeListQualifierCode_10 { get; set; }
        [StringLength(1, 30)]
        [DataElement("1271", typeof(X12_AN))]
        [Pos(11)]
        public string IndustryCode_11 { get; set; }
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
        public string IndustryCode_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("N4")]
    public class N4_SubscriberCity_State_ZIPCode
    {
        
        [Required]
        [StringLength(2, 30)]
        [DataElement("19", typeof(X12_AN))]
        [Pos(1)]
        public string SubscriberCityName_01 { get; set; }
        [StringLength(2, 2)]
        [DataElement("156", typeof(X12_ID))]
        [Pos(2)]
        public string SubscriberStateCode_02 { get; set; }
        [StringLength(3, 15)]
        [DataElement("116", typeof(X12_ID))]
        [Pos(3)]
        public string SubscriberPostalZoneorZIPCode_03 { get; set; }
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
    [Segment("N3")]
    public class N3_SubscriberAddress
    {
        
        [Required]
        [StringLength(1, 55)]
        [DataElement("166", typeof(X12_AN))]
        [Pos(1)]
        public string SubscriberAddressLine_01 { get; set; }
        [StringLength(1, 55)]
        [DataElement("166", typeof(X12_AN))]
        [Pos(2)]
        public string SubscriberAddressLine_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_7), typeof(X12_ID_1065))]
    public class NM1_SubscriberName
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98_7))]
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
        public string SubscriberLastName_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1036", typeof(X12_AN))]
        [Pos(4)]
        public string SubscriberFirstName_04 { get; set; }
        [StringLength(1, 25)]
        [DataElement("1037", typeof(X12_AN))]
        [Pos(5)]
        public string SubscriberMiddleNameorInitial_05 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1038", typeof(X12_AN))]
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1039", typeof(X12_AN))]
        [Pos(7)]
        public string SubscriberNameSuffix_07 { get; set; }
        [DataElement("66", typeof(X12_ID_66_5))]
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(9)]
        public string SubscriberPrimaryIdentifier_09 { get; set; }
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
    [Segment("PAT", typeof(X12_ID_1069_2), typeof(X12_ID_1384))]
    public class PAT_PatientInformation
    {
        
        [DataElement("1069", typeof(X12_ID_1069_2))]
        [Pos(1)]
        public string IndividualRelationshipCode_01 { get; set; }
        [DataElement("1384", typeof(X12_ID_1384))]
        [Pos(2)]
        public string PatientLocationCode_02 { get; set; }
        [DataElement("584", typeof(X12_ID_584))]
        [Pos(3)]
        public string EmploymentStatusCode_03 { get; set; }
        [DataElement("1220", typeof(X12_ID_1220))]
        [Pos(4)]
        public string StudentStatusCode_04 { get; set; }
        [DataElement("1250", typeof(X12_ID_1250))]
        [Pos(5)]
        public string DateTimePeriodFormatQualifier_05 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1251", typeof(X12_AN))]
        [Pos(6)]
        public string PatientDeathDate_06 { get; set; }
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(7)]
        public string UnitorBasisforMeasurementCode_07 { get; set; }
        [StringLength(1, 10)]
        [DataElement("81", typeof(X12_R))]
        [Pos(8)]
        public string PatientWeight_08 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073_2))]
        [Pos(9)]
        public string PregnancyIndicator_09 { get; set; }
    }
    
    [Serializable()]
    [Segment("SBR", typeof(X12_ID_1138), typeof(X12_ID_1069))]
    public class SBR_SubscriberInformation
    {
        
        [Required]
        [DataElement("1138", typeof(X12_ID_1138))]
        [Pos(1)]
        public string PayerResponsibilitySequenceNumberCode_01 { get; set; }
        [DataElement("1069", typeof(X12_ID_1069))]
        [Pos(2)]
        public string IndividualRelationshipCode_02 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(3)]
        public string SubscriberGrouporPolicyNumber_03 { get; set; }
        [StringLength(1, 60)]
        [DataElement("93", typeof(X12_AN))]
        [Pos(4)]
        public string SubscriberGroupName_04 { get; set; }
        [DataElement("1336", typeof(X12_ID_1336))]
        [Pos(5)]
        public string InsuranceTypeCode_05 { get; set; }
        [DataElement("1143", typeof(X12_ID_1143))]
        [Pos(6)]
        public string CoordinationofBenefitsCode_06 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(7)]
        public string YesNoConditionorResponseCode_07 { get; set; }
        [DataElement("584", typeof(X12_ID_584))]
        [Pos(8)]
        public string EmploymentStatusCode_08 { get; set; }
        [DataElement("1032", typeof(X12_ID_1032))]
        [Pos(9)]
        public string ClaimFilingIndicatorCode_09 { get; set; }
    }
    
    [Serializable()]
    [Segment("HL")]
    public class HL_SubscriberHierarchicalLevel
    {
        
        [Required]
        [StringLength(1, 12)]
        [DataElement("628", typeof(X12_AN))]
        [Pos(1)]
        public string HierarchicalIDNumber_01 { get; set; }
        [Required]
        [StringLength(1, 12)]
        [DataElement("734", typeof(X12_AN))]
        [Pos(2)]
        public string HierarchicalParentIDNumber_02 { get; set; }
        [Required]
        [DataElement("735", typeof(X12_ID_735_2))]
        [Pos(3)]
        public string HierarchicalLevelCode_03 { get; set; }
        [Required]
        [DataElement("736", typeof(X12_ID_736_2))]
        [Pos(4)]
        public string HierarchicalChildCode_04 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",22,")]
    public class X12_ID_735_2
    {
    }
    
    [Serializable()]
    [EdiCodes(",0,1,")]
    public class X12_ID_736_2
    {
    }
    
    [Serializable()]
    [All()]
    public class All_NM1_2
    {
        
        [Required]
        [Pos(1)]
        public Loop_2010AA Loop_2010AA { get; set; }
        [Pos(2)]
        public Loop_2010AB Loop_2010AB { get; set; }
        [Pos(3)]
        public Loop_2010AC Loop_2010AC { get; set; }
    }
    
    [Serializable()]
    [Group("NM1")]
    public class Loop_2010AC
    {
        
        [Required]
        [Pos(1)]
        public NM1_Pay_ToPlanName NM1_Pay_ToPlanName { get; set; }
        [Required]
        [Pos(2)]
        public N3_Pay_ToPlanAddress N3_Pay_ToPlanAddress { get; set; }
        [Required]
        [Pos(3)]
        public N4_Pay_ToPlanCity_State_ZIPCode N4_Pay_ToPlanCity_State_ZIPCode { get; set; }
        [Required]
        [Pos(4)]
        public All_REF_2 All_REF_2 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",PE,")]
    public class X12_ID_98_6
    {
    }
    
    [Serializable()]
    [All()]
    public class All_REF_2
    {
        
        [Pos(1)]
        public REF_Pay_ToPlanSecondaryIdentification REF_Pay_ToPlanSecondaryIdentification { get; set; }
        [Required]
        [Pos(2)]
        public REF_Pay_ToPlanTaxIdentificationNumber REF_Pay_ToPlanTaxIdentificationNumber { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",2U,FY,NF,")]
    public class X12_ID_128_5
    {
    }
    
    [Serializable()]
    [EdiCodes(",EI,")]
    public class X12_ID_128_6
    {
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_6))]
    public class REF_Pay_ToPlanTaxIdentificationNumber
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_6))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string PayToPlanTaxIdentificationNumber_02 { get; set; }
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
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_5))]
    public class REF_Pay_ToPlanSecondaryIdentification
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_5))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string PaytoPlanSecondaryIdentifier_02 { get; set; }
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
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("N4")]
    public class N4_Pay_ToPlanCity_State_ZIPCode
    {
        
        [Required]
        [StringLength(2, 30)]
        [DataElement("19", typeof(X12_AN))]
        [Pos(1)]
        public string PaytoPlanCityName_01 { get; set; }
        [StringLength(2, 2)]
        [DataElement("156", typeof(X12_ID))]
        [Pos(2)]
        public string PaytoPlanStateorProvinceCode_02 { get; set; }
        [StringLength(3, 15)]
        [DataElement("116", typeof(X12_ID))]
        [Pos(3)]
        public string PaytoPlanPostalZoneorZIPCode_03 { get; set; }
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
    [Segment("N3")]
    public class N3_Pay_ToPlanAddress
    {
        
        [Required]
        [StringLength(1, 55)]
        [DataElement("166", typeof(X12_AN))]
        [Pos(1)]
        public string PaytoPlanAddressLine_01 { get; set; }
        [StringLength(1, 55)]
        [DataElement("166", typeof(X12_AN))]
        [Pos(2)]
        public string PaytoPlanAddressLine_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_6), typeof(X12_ID_1065_2))]
    public class NM1_Pay_ToPlanName
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98_6))]
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        [Required]
        [DataElement("1065", typeof(X12_ID_1065_2))]
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        [Required]
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(3)]
        public string PaytoPlanOrganizationalName_03 { get; set; }
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
        [Required]
        [DataElement("66", typeof(X12_ID_66_4))]
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        [Required]
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(9)]
        public string PaytoPlanPrimaryIdentifier_09 { get; set; }
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
    public class Loop_2010AB
    {
        
        [Required]
        [Pos(1)]
        public NM1_Pay_toAddressName NM1_Pay_toAddressName { get; set; }
        [Required]
        [Pos(2)]
        public N3_Pay_ToAddress_ADDRESS N3_Pay_ToAddress_ADDRESS { get; set; }
        [Required]
        [Pos(3)]
        public N4_Pay_toAddressCity_State_ZIPCode N4_Pay_toAddressCity_State_ZIPCode { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",87,")]
    public class X12_ID_98_5
    {
    }
    
    [Serializable()]
    [Segment("N4")]
    public class N4_Pay_toAddressCity_State_ZIPCode
    {
        
        [Required]
        [StringLength(2, 30)]
        [DataElement("19", typeof(X12_AN))]
        [Pos(1)]
        public string PaytoAddressCityName_01 { get; set; }
        [StringLength(2, 2)]
        [DataElement("156", typeof(X12_ID))]
        [Pos(2)]
        public string PaytoAddressStateCode_02 { get; set; }
        [StringLength(3, 15)]
        [DataElement("116", typeof(X12_ID))]
        [Pos(3)]
        public string PaytoAddressPostalZoneorZIPCode_03 { get; set; }
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
    [Segment("N3")]
    public class N3_Pay_ToAddress_ADDRESS
    {
        
        [Required]
        [StringLength(1, 55)]
        [DataElement("166", typeof(X12_AN))]
        [Pos(1)]
        public string PaytoAddressLine_01 { get; set; }
        [StringLength(1, 55)]
        [DataElement("166", typeof(X12_AN))]
        [Pos(2)]
        public string PaytoAddressLine_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_5), typeof(X12_ID_1065))]
    public class NM1_Pay_toAddressName
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98_5))]
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        [Required]
        [DataElement("1065", typeof(X12_ID_1065))]
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(3)]
        public string PaytoLastorOrganizationalName_03 { get; set; }
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
    public class Loop_2010AA
    {
        
        [Required]
        [Pos(1)]
        public NM1_BillingProviderName NM1_BillingProviderName { get; set; }
        [Required]
        [Pos(2)]
        public N3_BillingProviderAddress N3_BillingProviderAddress { get; set; }
        [Required]
        [Pos(3)]
        public N4_BillingProviderCity_State_ZIPCode N4_BillingProviderCity_State_ZIPCode { get; set; }
        [Required]
        [Pos(4)]
        public All_REF All_REF { get; set; }
        [ListCount(2)]
        [Pos(5)]
        public List<PER_BillingProviderContactInformation> PER_BillingProviderContactInformation { get; set; }
    }
    
    [Serializable()]
    [Segment("PER", typeof(X12_ID_366))]
    public class PER_BillingProviderContactInformation
    {
        
        [Required]
        [DataElement("366", typeof(X12_ID_366))]
        [Pos(1)]
        public string ContactFunctionCode_01 { get; set; }
        [StringLength(1, 60)]
        [DataElement("93", typeof(X12_AN))]
        [Pos(2)]
        public string BillingProviderContactName_02 { get; set; }
        [Required]
        [DataElement("365", typeof(X12_ID_365))]
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
    [All()]
    public class All_REF
    {
        
        [Required]
        [Pos(1)]
        public REF_BillingProviderTaxIdentification REF_BillingProviderTaxIdentification { get; set; }
        [ListCount(2)]
        [Pos(2)]
        public List<REF_BillingProviderUPIN_LicenseInformation> REF_BillingProviderUPIN_LicenseInformation { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",EI,SY,")]
    public class X12_ID_128_2
    {
    }
    
    [Serializable()]
    [EdiCodes(",0B,1G,")]
    public class X12_ID_128_4
    {
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_4))]
    public class REF_BillingProviderUPIN_LicenseInformation
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_4))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string BillingProviderLicenseandorUPINInformation_02 { get; set; }
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
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("REF", typeof(X12_ID_128_2))]
    public class REF_BillingProviderTaxIdentification
    {
        
        [Required]
        [DataElement("128", typeof(X12_ID_128_2))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string BillingProviderTaxIdentificationNumber_02 { get; set; }
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
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        [DataElement("128", typeof(X12_ID_128_3))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
    
    [Serializable()]
    [Segment("N4")]
    public class N4_BillingProviderCity_State_ZIPCode
    {
        
        [Required]
        [StringLength(2, 30)]
        [DataElement("19", typeof(X12_AN))]
        [Pos(1)]
        public string BillingProviderCityName_01 { get; set; }
        [StringLength(2, 2)]
        [DataElement("156", typeof(X12_ID))]
        [Pos(2)]
        public string BillingProviderStateorProvinceCode_02 { get; set; }
        [StringLength(3, 15)]
        [DataElement("116", typeof(X12_ID))]
        [Pos(3)]
        public string BillingProviderPostalZoneorZIPCode_03 { get; set; }
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
    [Segment("N3")]
    public class N3_BillingProviderAddress
    {
        
        [Required]
        [StringLength(1, 55)]
        [DataElement("166", typeof(X12_AN))]
        [Pos(1)]
        public string BillingProviderAddressLine_01 { get; set; }
        [StringLength(1, 55)]
        [DataElement("166", typeof(X12_AN))]
        [Pos(2)]
        public string BillingProviderAddressLine_02 { get; set; }
    }
    
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_4), typeof(X12_ID_1065))]
    public class NM1_BillingProviderName
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98_4))]
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
        public string BillingProviderLastorOrganizationalName_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1036", typeof(X12_AN))]
        [Pos(4)]
        public string BillingProviderFirstName_04 { get; set; }
        [StringLength(1, 25)]
        [DataElement("1037", typeof(X12_AN))]
        [Pos(5)]
        public string BillingProviderMiddleNameorInitial_05 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1038", typeof(X12_AN))]
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1039", typeof(X12_AN))]
        [Pos(7)]
        public string BillingProviderNameSuffix_07 { get; set; }
        [DataElement("66", typeof(X12_ID_66_2))]
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(9)]
        public string BillingProviderIdentifier_09 { get; set; }
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
    [Segment("CUR", typeof(X12_ID_98_4))]
    public class CUR_ForeignCurrencyInformation
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98_4))]
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        [Required]
        [StringLength(3, 3)]
        [DataElement("100", typeof(X12_ID))]
        [Pos(2)]
        public string CurrencyCode_02 { get; set; }
        [StringLength(4, 10)]
        [DataElement("280", typeof(X12_R))]
        [Pos(3)]
        public string ExchangeRate_03 { get; set; }
        [DataElement("98", typeof(X12_ID_98_2))]
        [Pos(4)]
        public string EntityIdentifierCode_04 { get; set; }
        [StringLength(3, 3)]
        [DataElement("100", typeof(X12_ID))]
        [Pos(5)]
        public string CurrencyCode_05 { get; set; }
        [DataElement("669", typeof(X12_ID_669))]
        [Pos(6)]
        public string CurrencyMarketExchangeCode_06 { get; set; }
        [DataElement("374", typeof(X12_ID_374))]
        [Pos(7)]
        public string DateTimeQualifier_07 { get; set; }
        [StringLength(8, 8)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(8)]
        public string Date_08 { get; set; }
        [StringLength(4, 8)]
        [DataElement("337", typeof(X12_TM))]
        [Pos(9)]
        public string Time_09 { get; set; }
        [DataElement("374", typeof(X12_ID_374))]
        [Pos(10)]
        public string DateTimeQualifier_10 { get; set; }
        [StringLength(8, 8)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(11)]
        public string Date_11 { get; set; }
        [StringLength(4, 8)]
        [DataElement("337", typeof(X12_TM))]
        [Pos(12)]
        public string Time_12 { get; set; }
        [DataElement("374", typeof(X12_ID_374))]
        [Pos(13)]
        public string DateTimeQualifier_13 { get; set; }
        [StringLength(8, 8)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(14)]
        public string Date_14 { get; set; }
        [StringLength(4, 8)]
        [DataElement("337", typeof(X12_TM))]
        [Pos(15)]
        public string Time_15 { get; set; }
        [DataElement("374", typeof(X12_ID_374))]
        [Pos(16)]
        public string DateTimeQualifier_16 { get; set; }
        [StringLength(8, 8)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(17)]
        public string Date_17 { get; set; }
        [StringLength(4, 8)]
        [DataElement("337", typeof(X12_TM))]
        [Pos(18)]
        public string Time_18 { get; set; }
        [DataElement("374", typeof(X12_ID_374))]
        [Pos(19)]
        public string DateTimeQualifier_19 { get; set; }
        [StringLength(8, 8)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(20)]
        public string Date_20 { get; set; }
        [StringLength(4, 8)]
        [DataElement("337", typeof(X12_TM))]
        [Pos(21)]
        public string Time_21 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",IMF,LNF,LNS,NYC,PHI,ZUR,")]
    public class X12_ID_669
    {
    }
    
    [Serializable()]
    [EdiCodes(",001,002,003,004,005,006,007,008,009,010,011,012,013,014,015,016,017,018,019,020," +
        "021,022,023,024,025,026,027,028,029,030,031,032,033,034,035,036,037,038,039,040," +
        "041,042,043,044,045,046,047,048,049,050,051,052,053,054,055,056,057,058,059,060," +
        "061,062,063,064,065,066,067,068,069,070,071,072,073,074,075,076,077,078,079,080," +
        "081,082,083,084,085,086,087,088,089,090,091,092,093,094,095,096,097,098,099,100," +
        "101,102,103,104,105,106,107,108,109,110,111,112,113,114,115,116,118,119,120,121," +
        "122,124,125,126,127,128,129,130,131,132,133,134,135,136,137,138,139,140,141,142," +
        "143,144,145,146,147,148,149,150,151,152,153,154,155,156,157,158,159,160,161,162," +
        "163,164,165,166,167,168,169,170,171,172,173,174,175,176,177,178,179,180,181,182," +
        "183,184,185,186,187,188,189,190,191,192,193,194,195,196,197,198,199,200,201,202," +
        "203,204,205,206,207,208,209,210,211,212,213,214,215,216,217,218,219,220,221,222," +
        "223,224,225,226,227,228,229,230,231,232,233,234,235,236,237,238,239,240,241,242," +
        "243,244,245,246,247,248,249,250,251,252,253,254,255,256,257,258,259,260,261,262," +
        "263,264,265,266,267,268,269,270,271,272,273,274,275,276,277,278,279,280,281,282," +
        "283,284,285,286,287,288,289,290,291,292,293,294,295,296,297,298,299,300,301,302," +
        "303,304,305,306,307,308,309,310,311,312,313,314,315,316,317,318,319,320,321,322," +
        "323,324,325,326,327,328,329,330,331,332,333,334,335,336,337,338,339,340,341,342," +
        "343,344,345,346,347,348,349,350,351,352,353,354,355,356,357,358,359,360,361,362," +
        "363,364,365,366,367,368,369,370,371,372,373,374,375,376,377,378,379,380,381,382," +
        "383,384,385,386,387,388,389,390,391,392,393,394,395,396,397,398,399,400,401,402," +
        "403,404,405,406,408,409,410,411,412,413,414,415,416,417,418,419,420,421,422,423," +
        "424,425,426,427,428,429,430,431,432,433,434,435,436,437,438,439,440,441,442,443," +
        "444,445,446,447,448,449,450,451,452,453,454,455,456,457,458,459,460,461,462,463," +
        "464,465,466,467,468,469,470,471,472,473,474,475,476,477,478,479,480,481,482,483," +
        "484,485,486,487,488,489,490,491,492,493,494,495,496,497,498,499,500,501,502,503," +
        "504,505,506,507,508,509,510,511,512,513,514,515,516,517,518,519,520,521,522,523," +
        "524,525,526,527,528,529,530,531,532,533,534,535,536,537,538,539,540,541,542,543," +
        "544,545,546,547,548,549,550,551,552,553,554,555,556,557,558,559,560,561,562,563," +
        "564,565,566,567,568,569,570,571,572,573,574,575,576,577,578,579,580,581,582,583," +
        "584,585,586,587,589,590,591,592,593,594,595,596,597,598,599,600,601,602,603,604," +
        "606,607,608,609,610,611,612,613,614,615,616,617,618,619,620,621,622,623,624,625," +
        "626,627,629,630,631,632,633,634,635,636,637,638,640,641,642,643,644,646,647,648," +
        "649,650,651,652,653,655,656,657,658,659,660,661,662,663,664,665,666,667,668,669," +
        "670,671,672,673,674,675,681,682,683,684,685,686,687,688,689,690,691,692,693,694," +
        "695,696,697,699,700,701,702,703,704,705,706,707,708,709,710,711,712,713,714,715," +
        "716,717,718,719,720,721,722,723,724,725,726,727,728,729,730,731,732,733,734,736," +
        "737,738,739,740,741,742,743,744,745,746,747,748,749,750,751,752,753,754,755,756," +
        "757,758,759,760,761,762,764,765,766,769,770,771,772,773,774,775,776,777,778,779," +
        "780,781,782,783,784,785,786,787,788,789,790,791,792,793,794,795,796,797,798,799," +
        "800,801,802,803,804,805,806,807,808,809,810,811,812,813,814,815,816,817,818,819," +
        "820,821,822,823,824,825,826,827,828,830,831,832,840,841,842,843,844,845,846,847," +
        "848,849,850,851,853,854,855,856,857,858,859,860,861,862,863,864,865,866,867,868," +
        "869,870,871,872,873,874,875,876,877,878,879,880,881,882,883,884,885,900,901,903," +
        "904,905,906,907,908,909,910,911,912,913,914,915,916,917,918,919,920,921,922,923," +
        "924,925,926,927,928,930,931,932,933,934,935,936,937,938,939,940,941,942,943,944," +
        "945,946,947,948,949,950,951,952,953,954,955,956,957,960,961,962,963,964,965,966," +
        "967,968,969,970,971,972,973,974,975,976,977,978,979,980,981,982,983,984,985,986," +
        "987,988,989,990,992,993,994,995,996,997,998,999,AA1,AA2,AA3,AA4,AA5,AA6,AA7,AA8," +
        "AA9,AAA,AAB,AAC,AAD,AAE,AAF,AAG,AAH,AAI,AAJ,AAK,AAL,AAM,AAN,AAO,AAP,AAQ,AAR,AAS," +
        "AAT,AAU,AAV,AAW,AAX,AAY,AAZ,AB1,AB2,AB3,AB4,AB5,AB6,AB7,AB8,AB9,ABA,ABB,ABC,ABD," +
        "ABE,ABF,ABG,ABH,ABI,ABK,ABL,ABM,ABN,ABO,ABP,ABQ,ABR,ABS,ABT,ABU,ABV,ABW,ABX,ABY," +
        "ACA,ACB,ACC,ACD,ACE,ACF,ACG,ACH,ACI,ACJ,ACK,ACL,ACM,ACN,ACO,ACP,ACQ,ACR,ACS,ACT," +
        "ACU,ACV,ACW,ACX,ACZ,ADA,ADB,ADC,ADD,ADE,ADF,ADG,ADH,ADI,ADJ,ADK,ADL,ADM,ADN,ADR," +
        "ADS,ADT,ADU,ADV,ADW,ADX,ADY,AEA,AEB,AEC,AED,AEE,AEF,AEG,AEH,AEI,AEK,AEL,AEM,AEN," +
        "AEO,AEP,AEQ,AER,AES,AET,AEU,AEV,AEW,AEX,AEY,ARD,AWH,BAA,BAB,BAC,BAD,BAE,BAF,BAG," +
        "BAH,BAI,BAJ,BAK,BAL,BAM,BAN,BAO,BAP,BAQ,BAR,BIP,CAD,CCR,CDD,CDT,CEA,CEB,CEC,CED," +
        "CEE,CEF,CEH,CEJ,CEK,CEL,CEM,CEN,CEO,CLO,CLU,COM,CON,CRV,CUR,DAF,DDO,DEE,DEL,DET," +
        "DFF,DFS,DIL,DIP,DIS,DLC,DOA,DOD,DOI,DOR,DSP,DTC,DTQ,E01,E02,E03,E04,E05,E06,E07," +
        "ECD,ECF,ECS,ECT,EDA,EDB,EDC,EDD,EDE,EDF,EDG,EDH,EDI,EDJ,EDK,EDL,EDM,EDN,EDO,EDP," +
        "EKD,EPP,ESC,ESF,ESS,EST,ETP,EXO,EXP,FFI,FFO,FIA,FPE,FPS,GRD,ICF,IDG,IFH,III,IMP," +
        "INC,INT,IPS,IVA,KEV,KEW,LAM,LAS,LCC,LEA,LEL,LIQ,LLP,LOG,LPC,LSC,LTP,MRR,MSD,NAM," +
        "NFD,NOD,NRG,NSD,ORG,PBC,PCP,PCS,PDE,PDR,PDV,PLS,PPC,PPD,PPP,PRD,PRR,PSA,PSC,PSF," +
        "PTD,PTO,RAP,RES,RFD,RFF,RFO,RNT,RRM,RRT,RSD,RSS,RTO,SCV,SDD,SFH,STN,SVA,TSR,TSS," +
        "TST,VAT,VLU,W01,W02,W03,W05,W06,W07,W08,W09,W10,W11,W12,W13,WAA,WAY,YXX,YXY,ZZZ," +
        "")]
    public class X12_ID_374
    {
    }
    
    [Serializable()]
    public class X12_TM
    {
    }
    
    [Serializable()]
    [Segment("PRV", typeof(X12_ID_1221), typeof(X12_ID_128))]
    public class PRV_BillingProviderSpecialtyInformation
    {
        
        [Required]
        [DataElement("1221", typeof(X12_ID_1221))]
        [Pos(1)]
        public string ProviderCode_01 { get; set; }
        [Required]
        [DataElement("128", typeof(X12_ID_128))]
        [Pos(2)]
        public string ReferenceIdentificationQualifier_02 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(3)]
        public string ProviderTaxonomyCode_03 { get; set; }
        [StringLength(2, 2)]
        [DataElement("156", typeof(X12_ID))]
        [Pos(4)]
        public string StateorProvinceCode_04 { get; set; }
        [Pos(5)]
        public C035_ProviderSpecialtyInformation ProviderSpecialtyInformation_05 { get; set; }
        [DataElement("1223", typeof(X12_ID_1223))]
        [Pos(6)]
        public string ProviderOrganizationCode_06 { get; set; }
    }
    
    [Serializable()]
    [Composite("C035_ProviderSpecialtyInformation")]
    public class C035_ProviderSpecialtyInformation
    {
        
        [Required]
        [DataElement("1222", typeof(X12_ID_1222))]
        [Pos(1)]
        public string ProviderSpecialtyCode_01 { get; set; }
        [DataElement("559", typeof(X12_ID_559))]
        [Pos(2)]
        public string AgencyQualifierCode_02 { get; set; }
        [DataElement("1073", typeof(X12_ID_1073))]
        [Pos(3)]
        public string YesNoConditionorResponseCode_03 { get; set; }
    }
    
    [Serializable()]
    [Segment("HL")]
    public class HL_BillingProviderHierarchicalLevel
    {
        
        [Required]
        [StringLength(1, 12)]
        [DataElement("628", typeof(X12_AN))]
        [Pos(1)]
        public string HierarchicalIDNumber_01 { get; set; }
        [StringLength(1, 12)]
        [DataElement("734", typeof(X12_AN))]
        [Pos(2)]
        public string HierarchicalParentIDNumber_02 { get; set; }
        [Required]
        [DataElement("735", typeof(X12_ID_735))]
        [Pos(3)]
        public string HierarchicalLevelCode_03 { get; set; }
        [Required]
        [DataElement("736", typeof(X12_ID_736))]
        [Pos(4)]
        public string HierarchicalChildCode_04 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",20,")]
    public class X12_ID_735
    {
    }
    
    [Serializable()]
    [EdiCodes(",1,")]
    public class X12_ID_736
    {
    }
    
    [Serializable()]
    [All()]
    public class All_NM1
    {
        
        [Required]
        [Pos(1)]
        public Loop_1000A Loop_1000A { get; set; }
        [Required]
        [Pos(2)]
        public Loop_1000B Loop_1000B { get; set; }
    }
    
    [Serializable()]
    [Group("NM1")]
    public class Loop_1000B
    {
        
        [Required]
        [Pos(1)]
        public NM1_ReceiverName NM1_ReceiverName { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",40,")]
    public class X12_ID_98_3
    {
    }
    
    [Serializable()]
    [Segment("NM1", typeof(X12_ID_98_3), typeof(X12_ID_1065_2))]
    public class NM1_ReceiverName
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98_3))]
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        [Required]
        [DataElement("1065", typeof(X12_ID_1065_2))]
        [Pos(2)]
        public string EntityTypeQualifier_02 { get; set; }
        [Required]
        [StringLength(1, 60)]
        [DataElement("1035", typeof(X12_AN))]
        [Pos(3)]
        public string ReceiverName_03 { get; set; }
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
        [Required]
        [DataElement("66", typeof(X12_ID_66))]
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        [Required]
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(9)]
        public string ReceiverPrimaryIdentifier_09 { get; set; }
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
    [EdiCodes(",46,")]
    public class X12_ID_66
    {
    }
    
    [Serializable()]
    [Group("NM1")]
    public class Loop_1000A
    {
        
        [Required]
        [Pos(1)]
        public NM1_SubmitterName NM1_SubmitterName { get; set; }
        [Required]
        [ListCount(2)]
        [Pos(2)]
        public List<PER_SubmitterEDIContactInformation> PER_SubmitterEDIContactInformation { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",41,")]
    public class X12_ID_98
    {
    }
    
    [Serializable()]
    [Segment("PER", typeof(X12_ID_366))]
    public class PER_SubmitterEDIContactInformation
    {
        
        [Required]
        [DataElement("366", typeof(X12_ID_366))]
        [Pos(1)]
        public string ContactFunctionCode_01 { get; set; }
        [StringLength(1, 60)]
        [DataElement("93", typeof(X12_AN))]
        [Pos(2)]
        public string SubmitterContactName_02 { get; set; }
        [Required]
        [DataElement("365", typeof(X12_ID_365))]
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
    [Segment("NM1", typeof(X12_ID_98), typeof(X12_ID_1065))]
    public class NM1_SubmitterName
    {
        
        [Required]
        [DataElement("98", typeof(X12_ID_98))]
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
        public string SubmitterLastorOrganizationName_03 { get; set; }
        [StringLength(1, 35)]
        [DataElement("1036", typeof(X12_AN))]
        [Pos(4)]
        public string SubmitterFirstName_04 { get; set; }
        [StringLength(1, 25)]
        [DataElement("1037", typeof(X12_AN))]
        [Pos(5)]
        public string SubmitterMiddleNameorInitial_05 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1038", typeof(X12_AN))]
        [Pos(6)]
        public string NamePrefix_06 { get; set; }
        [StringLength(1, 10)]
        [DataElement("1039", typeof(X12_AN))]
        [Pos(7)]
        public string NameSuffix_07 { get; set; }
        [Required]
        [DataElement("66", typeof(X12_ID_66))]
        [Pos(8)]
        public string IdentificationCodeQualifier_08 { get; set; }
        [Required]
        [StringLength(2, 80)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(9)]
        public string SubmitterIdentifier_09 { get; set; }
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
    [Segment("BHT", typeof(X12_ID_1005), typeof(X12_ID_353))]
    public class BHT_BeginningofHierarchicalTransaction
    {
        
        [Required]
        [DataElement("1005", typeof(X12_ID_1005))]
        [Pos(1)]
        public string HierarchicalStructureCode_01 { get; set; }
        [Required]
        [DataElement("353", typeof(X12_ID_353))]
        [Pos(2)]
        public string TransactionSetPurposeCode_02 { get; set; }
        [Required]
        [StringLength(1, 50)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(3)]
        public string OriginatorApplicationTransactionIdentifier_03 { get; set; }
        [Required]
        [StringLength(8, 8)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(4)]
        public string TransactionSetCreationDate_04 { get; set; }
        [Required]
        [StringLength(4, 8)]
        [DataElement("337", typeof(X12_TM))]
        [Pos(5)]
        public string TransactionSetCreationTime_05 { get; set; }
        [Required]
        [DataElement("640", typeof(X12_ID_640))]
        [Pos(6)]
        public string ClaimorEncounterIdentifier_06 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",31,CH,RP,")]
    public class X12_ID_640
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
        public string ImplementationGuideVersionName_03 { get; set; }
    }
    
    [Serializable()]
    [EdiCodes(",005010X222A1,")]
    public class X12_ID_1705
    {
    }
}
