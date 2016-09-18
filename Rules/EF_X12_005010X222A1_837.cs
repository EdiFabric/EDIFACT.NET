namespace EdiFabric.Rules.X12005010X222A1837 {
    using System;
    using System.Xml.Serialization;
    using System.Collections.Generic;
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class M_837 {
    [XmlElement(Order=0)]
    public S_ST S_ST {get; set;}
    [XmlElement(Order=1)]
    public S_BHT_BeginningofHierarchicalTransaction S_BHT_BeginningofHierarchicalTransaction {get; set;}
    [XmlElement(Order=2)]
    public A_NM1 A_NM1 {get; set;}
    [XmlElement("G_TS837_2000A",Order=3)]
    public List<G_TS837_2000A> G_TS837_2000A {get; set;}
    [XmlElement(Order=4)]
    public S_SE S_SE {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_ST {
    [XmlElement(Order=0)]
    public X12_ID_143 D_ST01_TransactionSetIdentifierCode {get; set;}
    [XmlElement(Order=1)]
    public string D_ST02_TransactionSetControlNumber {get; set;}
    [XmlElement(Order=2)]
    public string D_ST03_ImplementationGuideVersionName {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_143 {
        [XmlEnum("837")]
        Item837,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_BHT_BeginningofHierarchicalTransaction {
    [XmlElement(Order=0)]
    public X12_ID_1005 D_BHT01_HierarchicalStructureCode {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_353 D_BHT02_TransactionSetPurposeCode {get; set;}
    [XmlElement(Order=2)]
    public string D_BHT03_OriginatorApplicationTransactionIdentifier {get; set;}
    [XmlElement(Order=3)]
    public string D_BHT04_TransactionSetCreationDate {get; set;}
    [XmlElement(Order=4)]
    public string D_BHT05_TransactionSetCreationTime {get; set;}
    [XmlElement(Order=5)]
    public string D_BHT06_ClaimorEncounterIdentifier {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_1005 {
        [XmlEnum("0019")]
        Item0019,
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_353 {
        [XmlEnum("00")]
        Item00,
        [XmlEnum("18")]
        Item18,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class A_NM1 {
    [XmlElementAttribute(Order=0)]
    public G_TS837_1000A G_TS837_1000A {get; set;}
    [XmlElementAttribute(Order=1)]
    public G_TS837_1000B G_TS837_1000B {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_TS837_1000A {
    [XmlElement(Order=0)]
    public S_NM1_SubmitterName S_NM1_SubmitterName {get; set;}
    [XmlElement("S_PER_SubmitterEDIContactInformation",Order=1)]
    public List<S_PER_SubmitterEDIContactInformation> S_PER_SubmitterEDIContactInformation {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_NM1_SubmitterName {
    [XmlElement(Order=0)]
    public X12_ID_98 D_NM101_EntityIdentifierCode {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1065 D_NM102_EntityTypeQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_NM103_SubmitterLastorOrganizationName {get; set;}
    [XmlElement(Order=3)]
    public string D_NM104_SubmitterFirstName {get; set;}
    [XmlElement(Order=4)]
    public string D_NM105_SubmitterMiddleNameorInitial {get; set;}
    [XmlElement(Order=5)]
    public string D_NM106_NamePrefix {get; set;}
    [XmlElement(Order=6)]
    public string D_NM107_NameSuffix {get; set;}
    [XmlElement(Order=7)]
    public string D_NM108_IdentificationCodeQualifier {get; set;}
    [XmlElement(Order=8)]
    public string D_NM109_SubmitterIdentifier {get; set;}
    [XmlElement(Order=9)]
    public string D_NM110_EntityRelationshipCode {get; set;}
    [XmlElement(Order=10)]
    public string D_NM111_EntityIdentifierCode {get; set;}
    [XmlElement(Order=11)]
    public string D_NM112_NameLastorOrganizationName {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_98 {
        [XmlEnum("41")]
        Item41,
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_1065 {
        [XmlEnum("1")]
        Item1,
        [XmlEnum("2")]
        Item2,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_PER_SubmitterEDIContactInformation {
    [XmlElement(Order=0)]
    public X12_ID_366 D_PER01_ContactFunctionCode {get; set;}
    [XmlElement(Order=1)]
    public string D_PER02_SubmitterContactName {get; set;}
    [XmlElement(Order=2)]
    public string D_PER03_CommunicationNumberQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_PER04_CommunicationNumber {get; set;}
    [XmlElement(Order=4)]
    public string D_PER05_CommunicationNumberQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_PER06_CommunicationNumber {get; set;}
    [XmlElement(Order=6)]
    public string D_PER07_CommunicationNumberQualifier {get; set;}
    [XmlElement(Order=7)]
    public string D_PER08_CommunicationNumber {get; set;}
    [XmlElement(Order=8)]
    public string D_PER09_ContactInquiryReference {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_366 {
        IC,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_TS837_1000B {
    [XmlElement(Order=0)]
    public S_NM1_ReceiverName S_NM1_ReceiverName {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_NM1_ReceiverName {
    [XmlElement(Order=0)]
    public X12_ID_98_3 D_NM101_EntityIdentifierCode {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1065_2 D_NM102_EntityTypeQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_NM103_ReceiverName {get; set;}
    [XmlElement(Order=3)]
    public string D_NM104_NameFirst {get; set;}
    [XmlElement(Order=4)]
    public string D_NM105_NameMiddle {get; set;}
    [XmlElement(Order=5)]
    public string D_NM106_NamePrefix {get; set;}
    [XmlElement(Order=6)]
    public string D_NM107_NameSuffix {get; set;}
    [XmlElement(Order=7)]
    public string D_NM108_IdentificationCodeQualifier {get; set;}
    [XmlElement(Order=8)]
    public string D_NM109_ReceiverPrimaryIdentifier {get; set;}
    [XmlElement(Order=9)]
    public string D_NM110_EntityRelationshipCode {get; set;}
    [XmlElement(Order=10)]
    public string D_NM111_EntityIdentifierCode {get; set;}
    [XmlElement(Order=11)]
    public string D_NM112_NameLastorOrganizationName {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_98_3 {
        [XmlEnum("40")]
        Item40,
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_1065_2 {
        [XmlEnum("2")]
        Item2,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_TS837_2000A {
    [XmlElement(Order=0)]
    public S_HL_BillingProviderHierarchicalLevel S_HL_BillingProviderHierarchicalLevel {get; set;}
    [XmlElement(Order=1)]
    public S_PRV_BillingProviderSpecialtyInformation S_PRV_BillingProviderSpecialtyInformation {get; set;}
    [XmlElement(Order=2)]
    public S_CUR_ForeignCurrencyInformation S_CUR_ForeignCurrencyInformation {get; set;}
    [XmlElement(Order=3)]
    public A_NM1_2 A_NM1_2 {get; set;}
    [XmlElement("G_TS837_2000B",Order=4)]
    public List<G_TS837_2000B> G_TS837_2000B {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_HL_BillingProviderHierarchicalLevel {
    [XmlElement(Order=0)]
    public string D_HL01_HierarchicalIDNumber {get; set;}
    [XmlElement(Order=1)]
    public string D_HL02_HierarchicalParentIDNumber {get; set;}
    [XmlElement(Order=2)]
    public string D_HL03_HierarchicalLevelCode {get; set;}
    [XmlElement(Order=3)]
    public string D_HL04_HierarchicalChildCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_PRV_BillingProviderSpecialtyInformation {
    [XmlElement(Order=0)]
    public X12_ID_1221 D_PRV01_ProviderCode {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_128 D_PRV02_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_PRV03_ProviderTaxonomyCode {get; set;}
    [XmlElement(Order=3)]
    public string D_PRV04_StateorProvinceCode {get; set;}
    [XmlElement(Order=4)]
    public C_C035_ProviderSpecialtyInformation C_C035_ProviderSpecialtyInformation {get; set;}
    [XmlElement(Order=5)]
    public string D_PRV06_ProviderOrganizationCode {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_1221 {
        BI,
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_128 {
        PXC,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C035_ProviderSpecialtyInformation {
    [XmlElement(Order=0)]
    public string D_C03501_ProviderSpecialtyCode {get; set;}
    [XmlElement(Order=1)]
    public string D_C03502_AgencyQualifierCode {get; set;}
    [XmlElement(Order=2)]
    public string D_C03503_Yes_NoConditionorResponseCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_CUR_ForeignCurrencyInformation {
    [XmlElement(Order=0)]
    public X12_ID_98_4 D_CUR01_EntityIdentifierCode {get; set;}
    [XmlElement(Order=1)]
    public string D_CUR02_CurrencyCode {get; set;}
    [XmlElement(Order=2)]
    public string D_CUR03_ExchangeRate {get; set;}
    [XmlElement(Order=3)]
    public string D_CUR04_EntityIdentifierCode {get; set;}
    [XmlElement(Order=4)]
    public string D_CUR05_CurrencyCode {get; set;}
    [XmlElement(Order=5)]
    public string D_CUR06_CurrencyMarket_ExchangeCode {get; set;}
    [XmlElement(Order=6)]
    public string D_CUR07_Date_TimeQualifier {get; set;}
    [XmlElement(Order=7)]
    public string D_CUR08_Date {get; set;}
    [XmlElement(Order=8)]
    public string D_CUR09_Time {get; set;}
    [XmlElement(Order=9)]
    public string D_CUR10_Date_TimeQualifier {get; set;}
    [XmlElement(Order=10)]
    public string D_CUR11_Date {get; set;}
    [XmlElement(Order=11)]
    public string D_CUR12_Time {get; set;}
    [XmlElement(Order=12)]
    public string D_CUR13_Date_TimeQualifier {get; set;}
    [XmlElement(Order=13)]
    public string D_CUR14_Date {get; set;}
    [XmlElement(Order=14)]
    public string D_CUR15_Time {get; set;}
    [XmlElement(Order=15)]
    public string D_CUR16_Date_TimeQualifier {get; set;}
    [XmlElement(Order=16)]
    public string D_CUR17_Date {get; set;}
    [XmlElement(Order=17)]
    public string D_CUR18_Time {get; set;}
    [XmlElement(Order=18)]
    public string D_CUR19_Date_TimeQualifier {get; set;}
    [XmlElement(Order=19)]
    public string D_CUR20_Date {get; set;}
    [XmlElement(Order=20)]
    public string D_CUR21_Time {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_98_4 {
        [XmlEnum("85")]
        Item85,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class A_NM1_2 {
    [XmlElementAttribute(Order=0)]
    public G_TS837_2010AA G_TS837_2010AA {get; set;}
    [XmlElementAttribute(Order=1)]
    public G_TS837_2010AB G_TS837_2010AB {get; set;}
    [XmlElementAttribute(Order=2)]
    public G_TS837_2010AC G_TS837_2010AC {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_TS837_2010AA {
    [XmlElement(Order=0)]
    public S_NM1_BillingProviderName S_NM1_BillingProviderName {get; set;}
    [XmlElement(Order=1)]
    public S_N3_BillingProviderAddress S_N3_BillingProviderAddress {get; set;}
    [XmlElement(Order=2)]
    public S_N4_BillingProviderCity_State_ZIPCode S_N4_BillingProviderCity_State_ZIPCode {get; set;}
    [XmlElement(Order=3)]
    public A_REF A_REF {get; set;}
    [XmlElement("S_PER_BillingProviderContactInformation",Order=4)]
    public List<S_PER_BillingProviderContactInformation> S_PER_BillingProviderContactInformation {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_NM1_BillingProviderName {
    [XmlElement(Order=0)]
    public X12_ID_98_4 D_NM101_EntityIdentifierCode {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1065 D_NM102_EntityTypeQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_NM103_BillingProviderLastorOrganizationalName {get; set;}
    [XmlElement(Order=3)]
    public string D_NM104_BillingProviderFirstName {get; set;}
    [XmlElement(Order=4)]
    public string D_NM105_BillingProviderMiddleNameorInitial {get; set;}
    [XmlElement(Order=5)]
    public string D_NM106_NamePrefix {get; set;}
    [XmlElement(Order=6)]
    public string D_NM107_BillingProviderNameSuffix {get; set;}
    [XmlElement(Order=7)]
    public string D_NM108_IdentificationCodeQualifier {get; set;}
    [XmlElement(Order=8)]
    public string D_NM109_BillingProviderIdentifier {get; set;}
    [XmlElement(Order=9)]
    public string D_NM110_EntityRelationshipCode {get; set;}
    [XmlElement(Order=10)]
    public string D_NM111_EntityIdentifierCode {get; set;}
    [XmlElement(Order=11)]
    public string D_NM112_NameLastorOrganizationName {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_N3_BillingProviderAddress {
    [XmlElement(Order=0)]
    public string D_N301_BillingProviderAddressLine {get; set;}
    [XmlElement(Order=1)]
    public string D_N302_BillingProviderAddressLine {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_N4_BillingProviderCity_State_ZIPCode {
    [XmlElement(Order=0)]
    public string D_N401_BillingProviderCityName {get; set;}
    [XmlElement(Order=1)]
    public string D_N402_BillingProviderStateorProvinceCode {get; set;}
    [XmlElement(Order=2)]
    public string D_N403_BillingProviderPostalZoneorZIPCode {get; set;}
    [XmlElement(Order=3)]
    public string D_N404_CountryCode {get; set;}
    [XmlElement(Order=4)]
    public string D_N405_LocationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_N406_LocationIdentifier {get; set;}
    [XmlElement(Order=6)]
    public string D_N407_CountrySubdivisionCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class A_REF {
    [XmlElementAttribute(Order=0)]
    public S_REF_BillingProviderTaxIdentification S_REF_BillingProviderTaxIdentification {get; set;}
    [XmlElement(Order=1)]
    public U_REF_BillingProviderUPIN_LicenseInformation U_REF_BillingProviderUPIN_LicenseInformation {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_BillingProviderTaxIdentification {
    [XmlElement(Order=0)]
    public X12_ID_128_2 D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_BillingProviderTaxIdentificationNumber {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03_Description {get; set;}
    [XmlElement(Order=3)]
    public C_C040_ReferenceIdentifier C_C040_ReferenceIdentifier {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_128_2 {
        EI,
        SY,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C040_ReferenceIdentifier {
    [XmlElement(Order=0)]
    public string D_C04001_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C04002_ReferenceIdentification {get; set;}
    [XmlElement(Order=2)]
    public string D_C04003_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C04004_ReferenceIdentification {get; set;}
    [XmlElement(Order=4)]
    public string D_C04005_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_C04006_ReferenceIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_BillingProviderUPIN_LicenseInformation {
    [XmlElement(Order=0)]
    public X12_ID_128_4 D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_BillingProviderLicenseand_orUPINInformation {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03_Description {get; set;}
    [XmlElement(Order=3)]
    public C_C040_ReferenceIdentifier_2 C_C040_ReferenceIdentifier_2 {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_128_4 {
        [XmlEnum("0B")]
        Item0B,
        [XmlEnum("1G")]
        Item1G,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C040_ReferenceIdentifier_2 {
    [XmlElement(Order=0)]
    public string D_C04001_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C04002_ReferenceIdentification {get; set;}
    [XmlElement(Order=2)]
    public string D_C04003_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C04004_ReferenceIdentification {get; set;}
    [XmlElement(Order=4)]
    public string D_C04005_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_C04006_ReferenceIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_PER_BillingProviderContactInformation {
    [XmlElement(Order=0)]
    public X12_ID_366 D_PER01_ContactFunctionCode {get; set;}
    [XmlElement(Order=1)]
    public string D_PER02_BillingProviderContactName {get; set;}
    [XmlElement(Order=2)]
    public string D_PER03_CommunicationNumberQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_PER04_CommunicationNumber {get; set;}
    [XmlElement(Order=4)]
    public string D_PER05_CommunicationNumberQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_PER06_CommunicationNumber {get; set;}
    [XmlElement(Order=6)]
    public string D_PER07_CommunicationNumberQualifier {get; set;}
    [XmlElement(Order=7)]
    public string D_PER08_CommunicationNumber {get; set;}
    [XmlElement(Order=8)]
    public string D_PER09_ContactInquiryReference {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_TS837_2010AB {
    [XmlElement(Order=0)]
    public S_NM1_Pay_toAddressName S_NM1_Pay_toAddressName {get; set;}
    [XmlElement(Order=1)]
    public S_N3_Pay_ToAddress_ADDRESS S_N3_Pay_ToAddress_ADDRESS {get; set;}
    [XmlElement(Order=2)]
    public S_N4_Pay_toAddressCity_State_ZIPCode S_N4_Pay_toAddressCity_State_ZIPCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_NM1_Pay_toAddressName {
    [XmlElement(Order=0)]
    public X12_ID_98_5 D_NM101_EntityIdentifierCode {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1065 D_NM102_EntityTypeQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_NM103_Pay_toLastorOrganizationalName {get; set;}
    [XmlElement(Order=3)]
    public string D_NM104_NameFirst {get; set;}
    [XmlElement(Order=4)]
    public string D_NM105_NameMiddle {get; set;}
    [XmlElement(Order=5)]
    public string D_NM106_NamePrefix {get; set;}
    [XmlElement(Order=6)]
    public string D_NM107_NameSuffix {get; set;}
    [XmlElement(Order=7)]
    public string D_NM108_IdentificationCodeQualifier {get; set;}
    [XmlElement(Order=8)]
    public string D_NM109_IdentificationCode {get; set;}
    [XmlElement(Order=9)]
    public string D_NM110_EntityRelationshipCode {get; set;}
    [XmlElement(Order=10)]
    public string D_NM111_EntityIdentifierCode {get; set;}
    [XmlElement(Order=11)]
    public string D_NM112_NameLastorOrganizationName {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_98_5 {
        [XmlEnum("87")]
        Item87,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_N3_Pay_ToAddress_ADDRESS {
    [XmlElement(Order=0)]
    public string D_N301_Pay_toAddressLine {get; set;}
    [XmlElement(Order=1)]
    public string D_N302_Pay_toAddressLine {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_N4_Pay_toAddressCity_State_ZIPCode {
    [XmlElement(Order=0)]
    public string D_N401_Pay_toAddressCityName {get; set;}
    [XmlElement(Order=1)]
    public string D_N402_Pay_toAddressStateCode {get; set;}
    [XmlElement(Order=2)]
    public string D_N403_Pay_toAddressPostalZoneorZIPCode {get; set;}
    [XmlElement(Order=3)]
    public string D_N404_CountryCode {get; set;}
    [XmlElement(Order=4)]
    public string D_N405_LocationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_N406_LocationIdentifier {get; set;}
    [XmlElement(Order=6)]
    public string D_N407_CountrySubdivisionCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_TS837_2010AC {
    [XmlElement(Order=0)]
    public S_NM1_Pay_ToPlanName S_NM1_Pay_ToPlanName {get; set;}
    [XmlElement(Order=1)]
    public S_N3_Pay_ToPlanAddress S_N3_Pay_ToPlanAddress {get; set;}
    [XmlElement(Order=2)]
    public S_N4_Pay_ToPlanCity_State_ZIPCode S_N4_Pay_ToPlanCity_State_ZIPCode {get; set;}
    [XmlElement(Order=3)]
    public A_REF_2 A_REF_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_NM1_Pay_ToPlanName {
    [XmlElement(Order=0)]
    public X12_ID_98_6 D_NM101_EntityIdentifierCode {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1065_2 D_NM102_EntityTypeQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_NM103_Pay_toPlanOrganizationalName {get; set;}
    [XmlElement(Order=3)]
    public string D_NM104_NameFirst {get; set;}
    [XmlElement(Order=4)]
    public string D_NM105_NameMiddle {get; set;}
    [XmlElement(Order=5)]
    public string D_NM106_NamePrefix {get; set;}
    [XmlElement(Order=6)]
    public string D_NM107_NameSuffix {get; set;}
    [XmlElement(Order=7)]
    public string D_NM108_IdentificationCodeQualifier {get; set;}
    [XmlElement(Order=8)]
    public string D_NM109_Pay_toPlanPrimaryIdentifier {get; set;}
    [XmlElement(Order=9)]
    public string D_NM110_EntityRelationshipCode {get; set;}
    [XmlElement(Order=10)]
    public string D_NM111_EntityIdentifierCode {get; set;}
    [XmlElement(Order=11)]
    public string D_NM112_NameLastorOrganizationName {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_98_6 {
        PE,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_N3_Pay_ToPlanAddress {
    [XmlElement(Order=0)]
    public string D_N301_Pay_toPlanAddressLine {get; set;}
    [XmlElement(Order=1)]
    public string D_N302_Pay_toPlanAddressLine {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_N4_Pay_ToPlanCity_State_ZIPCode {
    [XmlElement(Order=0)]
    public string D_N401_Pay_toPlanCityName {get; set;}
    [XmlElement(Order=1)]
    public string D_N402_Pay_toPlanStateorProvinceCode {get; set;}
    [XmlElement(Order=2)]
    public string D_N403_Pay_toPlanPostalZoneorZIPCode {get; set;}
    [XmlElement(Order=3)]
    public string D_N404_CountryCode {get; set;}
    [XmlElement(Order=4)]
    public string D_N405_LocationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_N406_LocationIdentifier {get; set;}
    [XmlElement(Order=6)]
    public string D_N407_CountrySubdivisionCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class A_REF_2 {
    [XmlElementAttribute(Order=0)]
    public S_REF_Pay_ToPlanSecondaryIdentification S_REF_Pay_ToPlanSecondaryIdentification {get; set;}
    [XmlElementAttribute(Order=1)]
    public S_REF_Pay_ToPlanTaxIdentificationNumber S_REF_Pay_ToPlanTaxIdentificationNumber {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_Pay_ToPlanSecondaryIdentification {
    [XmlElement(Order=0)]
    public X12_ID_128_5 D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_Pay_toPlanSecondaryIdentifier {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03_Description {get; set;}
    [XmlElement(Order=3)]
    public C_C040_ReferenceIdentifier_3 C_C040_ReferenceIdentifier_3 {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_128_5 {
        [XmlEnum("2U")]
        Item2U,
        FY,
        NF,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C040_ReferenceIdentifier_3 {
    [XmlElement(Order=0)]
    public string D_C04001_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C04002_ReferenceIdentification {get; set;}
    [XmlElement(Order=2)]
    public string D_C04003_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C04004_ReferenceIdentification {get; set;}
    [XmlElement(Order=4)]
    public string D_C04005_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_C04006_ReferenceIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_Pay_ToPlanTaxIdentificationNumber {
    [XmlElement(Order=0)]
    public X12_ID_128_6 D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_Pay_ToPlanTaxIdentificationNumber {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03_Description {get; set;}
    [XmlElement(Order=3)]
    public C_C040_ReferenceIdentifier_4 C_C040_ReferenceIdentifier_4 {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_128_6 {
        EI,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C040_ReferenceIdentifier_4 {
    [XmlElement(Order=0)]
    public string D_C04001_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C04002_ReferenceIdentification {get; set;}
    [XmlElement(Order=2)]
    public string D_C04003_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C04004_ReferenceIdentification {get; set;}
    [XmlElement(Order=4)]
    public string D_C04005_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_C04006_ReferenceIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_TS837_2000B {
    [XmlElement(Order=0)]
    public S_HL_SubscriberHierarchicalLevel S_HL_SubscriberHierarchicalLevel {get; set;}
    [XmlElement(Order=1)]
    public S_SBR_SubscriberInformation S_SBR_SubscriberInformation {get; set;}
    [XmlElement(Order=2)]
    public S_PAT_PatientInformation S_PAT_PatientInformation {get; set;}
    [XmlElement(Order=3)]
    public A_NM1_3 A_NM1_3 {get; set;}
    [XmlElement("G_TS837_2300",Order=4)]
    public List<G_TS837_2300> G_TS837_2300 {get; set;}
    [XmlElement("G_TS837_2000C",Order=5)]
    public List<G_TS837_2000C> G_TS837_2000C {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_HL_SubscriberHierarchicalLevel {
    [XmlElement(Order=0)]
    public string D_HL01_HierarchicalIDNumber {get; set;}
    [XmlElement(Order=1)]
    public string D_HL02_HierarchicalParentIDNumber {get; set;}
    [XmlElement(Order=2)]
    public string D_HL03_HierarchicalLevelCode {get; set;}
    [XmlElement(Order=3)]
    public string D_HL04_HierarchicalChildCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_SBR_SubscriberInformation {
    [XmlElement(Order=0)]
    public X12_ID_1138 D_SBR01_PayerResponsibilitySequenceNumberCode {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1069 D_SBR02_IndividualRelationshipCode {get; set;}
    [XmlElement(Order=2)]
    public string D_SBR03_SubscriberGrouporPolicyNumber {get; set;}
    [XmlElement(Order=3)]
    public string D_SBR04_SubscriberGroupName {get; set;}
    [XmlElement(Order=4)]
    public string D_SBR05_InsuranceTypeCode {get; set;}
    [XmlElement(Order=5)]
    public string D_SBR06_CoordinationofBenefitsCode {get; set;}
    [XmlElement(Order=6)]
    public string D_SBR07_Yes_NoConditionorResponseCode {get; set;}
    [XmlElement(Order=7)]
    public string D_SBR08_EmploymentStatusCode {get; set;}
    [XmlElement(Order=8)]
    public string D_SBR09_ClaimFilingIndicatorCode {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_1138 {
        A,
        B,
        C,
        D,
        E,
        F,
        G,
        H,
        P,
        S,
        T,
        U,
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_1069 {
        [XmlEnum("18")]
        Item18,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_PAT_PatientInformation {
    [XmlElement(Order=0)]
    public X12_ID_1069_2 D_PAT01_IndividualRelationshipCode {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1384 D_PAT02_PatientLocationCode {get; set;}
    [XmlElement(Order=2)]
    public string D_PAT03_EmploymentStatusCode {get; set;}
    [XmlElement(Order=3)]
    public string D_PAT04_StudentStatusCode {get; set;}
    [XmlElement(Order=4)]
    public string D_PAT05_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_PAT06_PatientDeathDate {get; set;}
    [XmlElement(Order=6)]
    public string D_PAT07_UnitorBasisforMeasurementCode {get; set;}
    [XmlElement(Order=7)]
    public string D_PAT08_PatientWeight {get; set;}
    [XmlElement(Order=8)]
    public string D_PAT09_PregnancyIndicator {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_1069_2 {
        [XmlEnum("01")]
        Item01,
        [XmlEnum("02")]
        Item02,
        [XmlEnum("03")]
        Item03,
        [XmlEnum("04")]
        Item04,
        [XmlEnum("05")]
        Item05,
        [XmlEnum("06")]
        Item06,
        [XmlEnum("07")]
        Item07,
        [XmlEnum("08")]
        Item08,
        [XmlEnum("09")]
        Item09,
        [XmlEnum("10")]
        Item10,
        [XmlEnum("11")]
        Item11,
        [XmlEnum("12")]
        Item12,
        [XmlEnum("13")]
        Item13,
        [XmlEnum("14")]
        Item14,
        [XmlEnum("15")]
        Item15,
        [XmlEnum("16")]
        Item16,
        [XmlEnum("17")]
        Item17,
        [XmlEnum("18")]
        Item18,
        [XmlEnum("19")]
        Item19,
        [XmlEnum("20")]
        Item20,
        [XmlEnum("21")]
        Item21,
        [XmlEnum("22")]
        Item22,
        [XmlEnum("23")]
        Item23,
        [XmlEnum("24")]
        Item24,
        [XmlEnum("25")]
        Item25,
        [XmlEnum("26")]
        Item26,
        [XmlEnum("27")]
        Item27,
        [XmlEnum("28")]
        Item28,
        [XmlEnum("29")]
        Item29,
        [XmlEnum("30")]
        Item30,
        [XmlEnum("31")]
        Item31,
        [XmlEnum("32")]
        Item32,
        [XmlEnum("33")]
        Item33,
        [XmlEnum("34")]
        Item34,
        [XmlEnum("36")]
        Item36,
        [XmlEnum("37")]
        Item37,
        [XmlEnum("38")]
        Item38,
        [XmlEnum("39")]
        Item39,
        [XmlEnum("40")]
        Item40,
        [XmlEnum("41")]
        Item41,
        [XmlEnum("43")]
        Item43,
        [XmlEnum("45")]
        Item45,
        [XmlEnum("46")]
        Item46,
        [XmlEnum("47")]
        Item47,
        [XmlEnum("48")]
        Item48,
        [XmlEnum("49")]
        Item49,
        [XmlEnum("50")]
        Item50,
        [XmlEnum("51")]
        Item51,
        [XmlEnum("52")]
        Item52,
        [XmlEnum("53")]
        Item53,
        [XmlEnum("55")]
        Item55,
        [XmlEnum("56")]
        Item56,
        [XmlEnum("57")]
        Item57,
        [XmlEnum("58")]
        Item58,
        [XmlEnum("59")]
        Item59,
        [XmlEnum("60")]
        Item60,
        [XmlEnum("61")]
        Item61,
        [XmlEnum("62")]
        Item62,
        [XmlEnum("63")]
        Item63,
        [XmlEnum("64")]
        Item64,
        [XmlEnum("65")]
        Item65,
        [XmlEnum("66")]
        Item66,
        [XmlEnum("67")]
        Item67,
        [XmlEnum("68")]
        Item68,
        [XmlEnum("70")]
        Item70,
        [XmlEnum("71")]
        Item71,
        [XmlEnum("72")]
        Item72,
        [XmlEnum("73")]
        Item73,
        [XmlEnum("74")]
        Item74,
        [XmlEnum("75")]
        Item75,
        [XmlEnum("76")]
        Item76,
        [XmlEnum("78")]
        Item78,
        [XmlEnum("79")]
        Item79,
        [XmlEnum("80")]
        Item80,
        [XmlEnum("81")]
        Item81,
        [XmlEnum("82")]
        Item82,
        [XmlEnum("83")]
        Item83,
        [XmlEnum("84")]
        Item84,
        [XmlEnum("86")]
        Item86,
        [XmlEnum("87")]
        Item87,
        [XmlEnum("88")]
        Item88,
        [XmlEnum("90")]
        Item90,
        [XmlEnum("91")]
        Item91,
        [XmlEnum("92")]
        Item92,
        [XmlEnum("93")]
        Item93,
        [XmlEnum("94")]
        Item94,
        [XmlEnum("95")]
        Item95,
        [XmlEnum("96")]
        Item96,
        [XmlEnum("97")]
        Item97,
        [XmlEnum("98")]
        Item98,
        [XmlEnum("99")]
        Item99,
        A1,
        A2,
        A3,
        A4,
        A5,
        A6,
        A7,
        A8,
        A9,
        B1,
        B2,
        B3,
        B4,
        B5,
        B6,
        B7,
        B8,
        B9,
        C1,
        C2,
        C3,
        C4,
        C5,
        C8,
        C9,
        D1,
        D2,
        D3,
        D4,
        D5,
        D6,
        D7,
        D8,
        D9,
        E1,
        E2,
        E3,
        E4,
        E5,
        E6,
        E7,
        E8,
        E9,
        F1,
        F2,
        F3,
        F6,
        F7,
        F8,
        F9,
        G2,
        G3,
        G4,
        G5,
        G6,
        G7,
        G8,
        G9,
        H1,
        H4,
        N1,
        OT,
        ZZ,
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_1384 {
        A,
        B,
        C,
        D,
        E,
        F,
        G,
        H,
        L,
        M,
        O,
        P,
        R,
        S,
        T,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class A_NM1_3 {
    [XmlElementAttribute(Order=0)]
    public G_TS837_2010BA G_TS837_2010BA {get; set;}
    [XmlElementAttribute(Order=1)]
    public G_TS837_2010BB G_TS837_2010BB {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_TS837_2010BA {
    [XmlElement(Order=0)]
    public S_NM1_SubscriberName S_NM1_SubscriberName {get; set;}
    [XmlElement(Order=1)]
    public S_N3_SubscriberAddress S_N3_SubscriberAddress {get; set;}
    [XmlElement(Order=2)]
    public S_N4_SubscriberCity_State_ZIPCode S_N4_SubscriberCity_State_ZIPCode {get; set;}
    [XmlElement(Order=3)]
    public S_DMG_SubscriberDemographicInformation S_DMG_SubscriberDemographicInformation {get; set;}
    [XmlElement(Order=4)]
    public A_REF_3 A_REF_3 {get; set;}
    [XmlElement(Order=5)]
    public S_PER_PropertyandCasualtySubscriberContactInformation S_PER_PropertyandCasualtySubscriberContactInformation {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_NM1_SubscriberName {
    [XmlElement(Order=0)]
    public X12_ID_98_7 D_NM101_EntityIdentifierCode {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1065 D_NM102_EntityTypeQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_NM103_SubscriberLastName {get; set;}
    [XmlElement(Order=3)]
    public string D_NM104_SubscriberFirstName {get; set;}
    [XmlElement(Order=4)]
    public string D_NM105_SubscriberMiddleNameorInitial {get; set;}
    [XmlElement(Order=5)]
    public string D_NM106_NamePrefix {get; set;}
    [XmlElement(Order=6)]
    public string D_NM107_SubscriberNameSuffix {get; set;}
    [XmlElement(Order=7)]
    public string D_NM108_IdentificationCodeQualifier {get; set;}
    [XmlElement(Order=8)]
    public string D_NM109_SubscriberPrimaryIdentifier {get; set;}
    [XmlElement(Order=9)]
    public string D_NM110_EntityRelationshipCode {get; set;}
    [XmlElement(Order=10)]
    public string D_NM111_EntityIdentifierCode {get; set;}
    [XmlElement(Order=11)]
    public string D_NM112_NameLastorOrganizationName {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_98_7 {
        IL,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_N3_SubscriberAddress {
    [XmlElement(Order=0)]
    public string D_N301_SubscriberAddressLine {get; set;}
    [XmlElement(Order=1)]
    public string D_N302_SubscriberAddressLine {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_N4_SubscriberCity_State_ZIPCode {
    [XmlElement(Order=0)]
    public string D_N401_SubscriberCityName {get; set;}
    [XmlElement(Order=1)]
    public string D_N402_SubscriberStateCode {get; set;}
    [XmlElement(Order=2)]
    public string D_N403_SubscriberPostalZoneorZIPCode {get; set;}
    [XmlElement(Order=3)]
    public string D_N404_CountryCode {get; set;}
    [XmlElement(Order=4)]
    public string D_N405_LocationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_N406_LocationIdentifier {get; set;}
    [XmlElement(Order=6)]
    public string D_N407_CountrySubdivisionCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_DMG_SubscriberDemographicInformation {
    [XmlElement(Order=0)]
    public X12_ID_1250 D_DMG01_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_DMG02_SubscriberBirthDate {get; set;}
    [XmlElement(Order=2)]
    public string D_DMG03_SubscriberGenderCode {get; set;}
    [XmlElement(Order=3)]
    public string D_DMG04_MaritalStatusCode {get; set;}
    [XmlElement("C_C056_CompositeRaceorEthnicityInformation",Order=4)]
    public List<C_C056_CompositeRaceorEthnicityInformation> C_C056_CompositeRaceorEthnicityInformation {get; set;}
    [XmlElement(Order=5)]
    public string D_DMG06_CitizenshipStatusCode {get; set;}
    [XmlElement(Order=6)]
    public string D_DMG07_CountryCode {get; set;}
    [XmlElement(Order=7)]
    public string D_DMG08_BasisofVerificationCode {get; set;}
    [XmlElement(Order=8)]
    public string D_DMG09_Quantity {get; set;}
    [XmlElement(Order=9)]
    public string D_DMG10_CodeListQualifierCode {get; set;}
    [XmlElement(Order=10)]
    public string D_DMG11_IndustryCode {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_1250 {
        D8,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C056_CompositeRaceorEthnicityInformation {
    [XmlElement(Order=0)]
    public string D_C05601_RaceorEthnicityCode {get; set;}
    [XmlElement(Order=1)]
    public string D_C05602_CodeListQualifierCode {get; set;}
    [XmlElement(Order=2)]
    public string D_C05603_IndustryCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class A_REF_3 {
    [XmlElementAttribute(Order=0)]
    public S_REF_SubscriberSecondaryIdentification S_REF_SubscriberSecondaryIdentification {get; set;}
    [XmlElementAttribute(Order=1)]
    public S_REF_PropertyandCasualtyClaimNumber S_REF_PropertyandCasualtyClaimNumber {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_SubscriberSecondaryIdentification {
    [XmlElement(Order=0)]
    public X12_ID_128_7 D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_SubscriberSupplementalIdentifier {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03_Description {get; set;}
    [XmlElement(Order=3)]
    public C_C040_ReferenceIdentifier_5 C_C040_ReferenceIdentifier_5 {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_128_7 {
        SY,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C040_ReferenceIdentifier_5 {
    [XmlElement(Order=0)]
    public string D_C04001_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C04002_ReferenceIdentification {get; set;}
    [XmlElement(Order=2)]
    public string D_C04003_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C04004_ReferenceIdentification {get; set;}
    [XmlElement(Order=4)]
    public string D_C04005_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_C04006_ReferenceIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_PropertyandCasualtyClaimNumber {
    [XmlElement(Order=0)]
    public X12_ID_128_8 D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_PropertyCasualtyClaimNumber {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03_Description {get; set;}
    [XmlElement(Order=3)]
    public C_C040_ReferenceIdentifier_6 C_C040_ReferenceIdentifier_6 {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_128_8 {
        Y4,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C040_ReferenceIdentifier_6 {
    [XmlElement(Order=0)]
    public string D_C04001_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C04002_ReferenceIdentification {get; set;}
    [XmlElement(Order=2)]
    public string D_C04003_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C04004_ReferenceIdentification {get; set;}
    [XmlElement(Order=4)]
    public string D_C04005_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_C04006_ReferenceIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_PER_PropertyandCasualtySubscriberContactInformation {
    [XmlElement(Order=0)]
    public X12_ID_366 D_PER01_ContactFunctionCode {get; set;}
    [XmlElement(Order=1)]
    public string D_PER02_Name {get; set;}
    [XmlElement(Order=2)]
    public string D_PER03_CommunicationNumberQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_PER04_CommunicationNumber {get; set;}
    [XmlElement(Order=4)]
    public string D_PER05_CommunicationNumberQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_PER06_CommunicationNumber {get; set;}
    [XmlElement(Order=6)]
    public string D_PER07_CommunicationNumberQualifier {get; set;}
    [XmlElement(Order=7)]
    public string D_PER08_CommunicationNumber {get; set;}
    [XmlElement(Order=8)]
    public string D_PER09_ContactInquiryReference {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_TS837_2010BB {
    [XmlElement(Order=0)]
    public S_NM1_PayerName S_NM1_PayerName {get; set;}
    [XmlElement(Order=1)]
    public S_N3_PayerAddress S_N3_PayerAddress {get; set;}
    [XmlElement(Order=2)]
    public S_N4_PayerCity_State_ZIPCode S_N4_PayerCity_State_ZIPCode {get; set;}
    [XmlElement(Order=3)]
    public A_REF_4 A_REF_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_NM1_PayerName {
    [XmlElement(Order=0)]
    public X12_ID_98_8 D_NM101_EntityIdentifierCode {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1065_2 D_NM102_EntityTypeQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_NM103_PayerName {get; set;}
    [XmlElement(Order=3)]
    public string D_NM104_NameFirst {get; set;}
    [XmlElement(Order=4)]
    public string D_NM105_NameMiddle {get; set;}
    [XmlElement(Order=5)]
    public string D_NM106_NamePrefix {get; set;}
    [XmlElement(Order=6)]
    public string D_NM107_NameSuffix {get; set;}
    [XmlElement(Order=7)]
    public string D_NM108_IdentificationCodeQualifier {get; set;}
    [XmlElement(Order=8)]
    public string D_NM109_PayerIdentifier {get; set;}
    [XmlElement(Order=9)]
    public string D_NM110_EntityRelationshipCode {get; set;}
    [XmlElement(Order=10)]
    public string D_NM111_EntityIdentifierCode {get; set;}
    [XmlElement(Order=11)]
    public string D_NM112_NameLastorOrganizationName {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_98_8 {
        PR,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_N3_PayerAddress {
    [XmlElement(Order=0)]
    public string D_N301_PayerAddressLine {get; set;}
    [XmlElement(Order=1)]
    public string D_N302_PayerAddressLine {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_N4_PayerCity_State_ZIPCode {
    [XmlElement(Order=0)]
    public string D_N401_PayerCityName {get; set;}
    [XmlElement(Order=1)]
    public string D_N402_PayerStateorProvinceCode {get; set;}
    [XmlElement(Order=2)]
    public string D_N403_PayerPostalZoneorZIPCode {get; set;}
    [XmlElement(Order=3)]
    public string D_N404_CountryCode {get; set;}
    [XmlElement(Order=4)]
    public string D_N405_LocationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_N406_LocationIdentifier {get; set;}
    [XmlElement(Order=6)]
    public string D_N407_CountrySubdivisionCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class A_REF_4 {
    [XmlElement(Order=0)]
    public U_REF_PayerSecondaryIdentification U_REF_PayerSecondaryIdentification {get; set;}
    [XmlElement(Order=1)]
    public U_REF_BillingProviderSecondaryIdentification U_REF_BillingProviderSecondaryIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_PayerSecondaryIdentification {
    [XmlElement(Order=0)]
    public X12_ID_128_9 D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_PayerSecondaryIdentifier {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03_Description {get; set;}
    [XmlElement(Order=3)]
    public C_C040_ReferenceIdentifier_7 C_C040_ReferenceIdentifier_7 {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_128_9 {
        [XmlEnum("2U")]
        Item2U,
        EI,
        FY,
        NF,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C040_ReferenceIdentifier_7 {
    [XmlElement(Order=0)]
    public string D_C04001_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C04002_ReferenceIdentification {get; set;}
    [XmlElement(Order=2)]
    public string D_C04003_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C04004_ReferenceIdentification {get; set;}
    [XmlElement(Order=4)]
    public string D_C04005_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_C04006_ReferenceIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_BillingProviderSecondaryIdentification {
    [XmlElement(Order=0)]
    public X12_ID_128_10 D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_BillingProviderSecondaryIdentifier {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03_Description {get; set;}
    [XmlElement(Order=3)]
    public C_C040_ReferenceIdentifier_8 C_C040_ReferenceIdentifier_8 {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_128_10 {
        G2,
        LU,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C040_ReferenceIdentifier_8 {
    [XmlElement(Order=0)]
    public string D_C04001_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C04002_ReferenceIdentification {get; set;}
    [XmlElement(Order=2)]
    public string D_C04003_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C04004_ReferenceIdentification {get; set;}
    [XmlElement(Order=4)]
    public string D_C04005_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_C04006_ReferenceIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_TS837_2300 {
    [XmlElement(Order=0)]
    public S_CLM_ClaimInformation S_CLM_ClaimInformation {get; set;}
    [XmlElement(Order=1)]
    public A_DTP A_DTP {get; set;}
    [XmlElement("S_PWK_ClaimSupplementalInformation",Order=2)]
    public List<S_PWK_ClaimSupplementalInformation> S_PWK_ClaimSupplementalInformation {get; set;}
    [XmlElement(Order=3)]
    public S_CN1_ContractInformation S_CN1_ContractInformation {get; set;}
    [XmlElement(Order=4)]
    public S_AMT_PatientAmountPaid S_AMT_PatientAmountPaid {get; set;}
    [XmlElement(Order=5)]
    public A_REF_5 A_REF_5 {get; set;}
    [XmlElement("S_K3_FileInformation",Order=6)]
    public List<S_K3_FileInformation> S_K3_FileInformation {get; set;}
    [XmlElement(Order=7)]
    public S_NTE_ClaimNote S_NTE_ClaimNote {get; set;}
    [XmlElement(Order=8)]
    public S_CR1_AmbulanceTransportInformation S_CR1_AmbulanceTransportInformation {get; set;}
    [XmlElement(Order=9)]
    public S_CR2_SpinalManipulationServiceInformation S_CR2_SpinalManipulationServiceInformation {get; set;}
    [XmlElement(Order=10)]
    public A_CRC A_CRC {get; set;}
    [XmlElement(Order=11)]
    public A_HI A_HI {get; set;}
    [XmlElement(Order=12)]
    public S_HCP_ClaimPricing_RepricingInformation S_HCP_ClaimPricing_RepricingInformation {get; set;}
    [XmlElement(Order=13)]
    public A_NM1_4 A_NM1_4 {get; set;}
    [XmlElement("G_TS837_2320",Order=14)]
    public List<G_TS837_2320> G_TS837_2320 {get; set;}
    [XmlElement("G_TS837_2400",Order=15)]
    public List<G_TS837_2400> G_TS837_2400 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_CLM_ClaimInformation {
    [XmlElement(Order=0)]
    public string D_CLM01_PatientControlNumber {get; set;}
    [XmlElement(Order=1)]
    public string D_CLM02_TotalClaimChargeAmount {get; set;}
    [XmlElement(Order=2)]
    public string D_CLM03_ClaimFilingIndicatorCode {get; set;}
    [XmlElement(Order=3)]
    public string D_CLM04_Non_InstitutionalClaimTypeCode {get; set;}
    [XmlElement(Order=4)]
    public C_C023_HealthCareServiceLocationInformation C_C023_HealthCareServiceLocationInformation {get; set;}
    [XmlElement(Order=5)]
    public string D_CLM06_ProviderorSupplierSignatureIndicator {get; set;}
    [XmlElement(Order=6)]
    public string D_CLM07_AssignmentorPlanParticipationCode {get; set;}
    [XmlElement(Order=7)]
    public string D_CLM08_BenefitsAssignmentCertificationIndicator {get; set;}
    [XmlElement(Order=8)]
    public string D_CLM09_ReleaseofInformationCode {get; set;}
    [XmlElement(Order=9)]
    public string D_CLM10_PatientSignatureSourceCode {get; set;}
    [XmlElement(Order=10)]
    public C_C024_RelatedCausesInformation C_C024_RelatedCausesInformation {get; set;}
    [XmlElement(Order=11)]
    public string D_CLM12_SpecialProgramIndicator {get; set;}
    [XmlElement(Order=12)]
    public string D_CLM13_Yes_NoConditionorResponseCode {get; set;}
    [XmlElement(Order=13)]
    public string D_CLM14_LevelofServiceCode {get; set;}
    [XmlElement(Order=14)]
    public string D_CLM15_Yes_NoConditionorResponseCode {get; set;}
    [XmlElement(Order=15)]
    public string D_CLM16_ProviderAgreementCode {get; set;}
    [XmlElement(Order=16)]
    public string D_CLM17_ClaimStatusCode {get; set;}
    [XmlElement(Order=17)]
    public string D_CLM18_Yes_NoConditionorResponseCode {get; set;}
    [XmlElement(Order=18)]
    public string D_CLM19_ClaimSubmissionReasonCode {get; set;}
    [XmlElement(Order=19)]
    public string D_CLM20_DelayReasonCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C023_HealthCareServiceLocationInformation {
    [XmlElement(Order=0)]
    public string D_C02301_PlaceofServiceCode {get; set;}
    [XmlElement(Order=1)]
    public string D_C02302_FacilityCodeQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_C02303_ClaimFrequencyCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C024_RelatedCausesInformation {
    [XmlElement(Order=0)]
    public string D_C02401_RelatedCausesCode {get; set;}
    [XmlElement(Order=1)]
    public string D_C02402_RelatedCausesCode {get; set;}
    [XmlElement(Order=2)]
    public string D_C02403_Related_CausesCode {get; set;}
    [XmlElement(Order=3)]
    public string D_C02404_AutoAccidentStateorProvinceCode {get; set;}
    [XmlElement(Order=4)]
    public string D_C02405_CountryCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class A_DTP {
    [XmlElementAttribute(Order=0)]
    public S_DTP_Date_OnsetofCurrentIllnessorSymptom S_DTP_Date_OnsetofCurrentIllnessorSymptom {get; set;}
    [XmlElementAttribute(Order=1)]
    public S_DTP_Date_InitialTreatmentDate S_DTP_Date_InitialTreatmentDate {get; set;}
    [XmlElementAttribute(Order=2)]
    public S_DTP_Date_LastSeenDate S_DTP_Date_LastSeenDate {get; set;}
    [XmlElementAttribute(Order=3)]
    public S_DTP_Date_AcuteManifestation S_DTP_Date_AcuteManifestation {get; set;}
    [XmlElementAttribute(Order=4)]
    public S_DTP_Date_Accident S_DTP_Date_Accident {get; set;}
    [XmlElementAttribute(Order=5)]
    public S_DTP_Date_LastMenstrualPeriod S_DTP_Date_LastMenstrualPeriod {get; set;}
    [XmlElementAttribute(Order=6)]
    public S_DTP_Date_LastX_rayDate S_DTP_Date_LastX_rayDate {get; set;}
    [XmlElementAttribute(Order=7)]
    public S_DTP_Date_HearingandVisionPrescriptionDate S_DTP_Date_HearingandVisionPrescriptionDate {get; set;}
    [XmlElementAttribute(Order=8)]
    public S_DTP_Date_DisabilityDates S_DTP_Date_DisabilityDates {get; set;}
    [XmlElementAttribute(Order=9)]
    public S_DTP_Date_LastWorked S_DTP_Date_LastWorked {get; set;}
    [XmlElementAttribute(Order=10)]
    public S_DTP_Date_AuthorizedReturntoWork S_DTP_Date_AuthorizedReturntoWork {get; set;}
    [XmlElementAttribute(Order=11)]
    public S_DTP_Date_Admission S_DTP_Date_Admission {get; set;}
    [XmlElementAttribute(Order=12)]
    public S_DTP_Date_Discharge S_DTP_Date_Discharge {get; set;}
    [XmlElement(Order=13)]
    public U_DTP_Date_AssumedandRelinquishedCareDates U_DTP_Date_AssumedandRelinquishedCareDates {get; set;}
    [XmlElementAttribute(Order=14)]
    public S_DTP_PropertyandCasualtyDateofFirstContact S_DTP_PropertyandCasualtyDateofFirstContact {get; set;}
    [XmlElementAttribute(Order=15)]
    public S_DTP_Date_RepricerReceivedDate S_DTP_Date_RepricerReceivedDate {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_DTP_Date_OnsetofCurrentIllnessorSymptom {
    [XmlElement(Order=0)]
    public X12_ID_374_2 D_DTP01_DateTimeQualifier {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1250 D_DTP02_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_DTP03_OnsetofCurrentIllnessorInjuryDate {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_374_2 {
        [XmlEnum("431")]
        Item431,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_DTP_Date_InitialTreatmentDate {
    [XmlElement(Order=0)]
    public X12_ID_374_3 D_DTP01_DateTimeQualifier {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1250 D_DTP02_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_DTP03_InitialTreatmentDate {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_374_3 {
        [XmlEnum("454")]
        Item454,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_DTP_Date_LastSeenDate {
    [XmlElement(Order=0)]
    public X12_ID_374_4 D_DTP01_DateTimeQualifier {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1250 D_DTP02_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_DTP03_LastSeenDate {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_374_4 {
        [XmlEnum("304")]
        Item304,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_DTP_Date_AcuteManifestation {
    [XmlElement(Order=0)]
    public X12_ID_374_5 D_DTP01_DateTimeQualifier {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1250 D_DTP02_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_DTP03_AcuteManifestationDate {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_374_5 {
        [XmlEnum("453")]
        Item453,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_DTP_Date_Accident {
    [XmlElement(Order=0)]
    public X12_ID_374_6 D_DTP01_DateTimeQualifier {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1250 D_DTP02_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_DTP03_AccidentDate {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_374_6 {
        [XmlEnum("439")]
        Item439,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_DTP_Date_LastMenstrualPeriod {
    [XmlElement(Order=0)]
    public X12_ID_374_7 D_DTP01_DateTimeQualifier {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1250 D_DTP02_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_DTP03_LastMenstrualPeriodDate {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_374_7 {
        [XmlEnum("484")]
        Item484,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_DTP_Date_LastX_rayDate {
    [XmlElement(Order=0)]
    public X12_ID_374_8 D_DTP01_DateTimeQualifier {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1250 D_DTP02_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_DTP03_LastX_RayDate {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_374_8 {
        [XmlEnum("455")]
        Item455,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_DTP_Date_HearingandVisionPrescriptionDate {
    [XmlElement(Order=0)]
    public X12_ID_374_9 D_DTP01_DateTimeQualifier {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1250 D_DTP02_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_DTP03_PrescriptionDate {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_374_9 {
        [XmlEnum("471")]
        Item471,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_DTP_Date_DisabilityDates {
    [XmlElement(Order=0)]
    public X12_ID_374_10 D_DTP01_DateTimeQualifier {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1250_2 D_DTP02_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_DTP03_DisabilityFromDate {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_374_10 {
        [XmlEnum("314")]
        Item314,
        [XmlEnum("360")]
        Item360,
        [XmlEnum("361")]
        Item361,
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_1250_2 {
        D8,
        RD8,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_DTP_Date_LastWorked {
    [XmlElement(Order=0)]
    public X12_ID_374_11 D_DTP01_DateTimeQualifier {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1250 D_DTP02_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_DTP03_LastWorkedDate {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_374_11 {
        [XmlEnum("297")]
        Item297,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_DTP_Date_AuthorizedReturntoWork {
    [XmlElement(Order=0)]
    public X12_ID_374_12 D_DTP01_DateTimeQualifier {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1250 D_DTP02_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_DTP03_WorkReturnDate {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_374_12 {
        [XmlEnum("296")]
        Item296,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_DTP_Date_Admission {
    [XmlElement(Order=0)]
    public X12_ID_374_13 D_DTP01_DateTimeQualifier {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1250 D_DTP02_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_DTP03_RelatedHospitalizationAdmissionDate {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_374_13 {
        [XmlEnum("435")]
        Item435,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_DTP_Date_Discharge {
    [XmlElement(Order=0)]
    public X12_ID_374_14 D_DTP01_DateTimeQualifier {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1250 D_DTP02_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_DTP03_RelatedHospitalizationDischargeDate {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_374_14 {
        [XmlEnum("096")]
        Item096,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_DTP_Date_AssumedandRelinquishedCareDates {
    [XmlElement(Order=0)]
    public X12_ID_374_15 D_DTP01_DateTimeQualifier {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1250 D_DTP02_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_DTP03_AssumedorRelinquishedCareDate {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_374_15 {
        [XmlEnum("090")]
        Item090,
        [XmlEnum("091")]
        Item091,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_DTP_PropertyandCasualtyDateofFirstContact {
    [XmlElement(Order=0)]
    public X12_ID_374_16 D_DTP01_DateTimeQualifier {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1250 D_DTP02_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_DTP03_DateTimePeriod {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_374_16 {
        [XmlEnum("444")]
        Item444,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_DTP_Date_RepricerReceivedDate {
    [XmlElement(Order=0)]
    public X12_ID_374_17 D_DTP01_DateTimeQualifier {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1250 D_DTP02_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_DTP03_RepricerReceivedDate {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_374_17 {
        [XmlEnum("050")]
        Item050,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_PWK_ClaimSupplementalInformation {
    [XmlElement(Order=0)]
    public X12_ID_755 D_PWK01_AttachmentReportTypeCode {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_756 D_PWK02_AttachmentTransmissionCode {get; set;}
    [XmlElement(Order=2)]
    public string D_PWK03_ReportCopiesNeeded {get; set;}
    [XmlElement(Order=3)]
    public string D_PWK04_EntityIdentifierCode {get; set;}
    [XmlElement(Order=4)]
    public string D_PWK05_IdentificationCodeQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_PWK06_AttachmentControlNumber {get; set;}
    [XmlElement(Order=6)]
    public string D_PWK07_Description {get; set;}
    [XmlElement(Order=7)]
    public C_C002_ActionsIndicated C_C002_ActionsIndicated {get; set;}
    [XmlElement(Order=8)]
    public string D_PWK09_RequestCategoryCode {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_755 {
        [XmlEnum("03")]
        Item03,
        [XmlEnum("04")]
        Item04,
        [XmlEnum("05")]
        Item05,
        [XmlEnum("06")]
        Item06,
        [XmlEnum("07")]
        Item07,
        [XmlEnum("08")]
        Item08,
        [XmlEnum("09")]
        Item09,
        [XmlEnum("10")]
        Item10,
        [XmlEnum("11")]
        Item11,
        [XmlEnum("13")]
        Item13,
        [XmlEnum("15")]
        Item15,
        [XmlEnum("21")]
        Item21,
        [XmlEnum("77")]
        Item77,
        A3,
        A4,
        AM,
        AS,
        B2,
        B3,
        B4,
        BR,
        BS,
        BT,
        CB,
        CK,
        CT,
        D2,
        DA,
        DB,
        DG,
        DJ,
        DS,
        EB,
        HC,
        HR,
        I5,
        IR,
        LA,
        M1,
        MT,
        NN,
        OB,
        OC,
        OD,
        OE,
        OX,
        OZ,
        P4,
        P5,
        PE,
        PN,
        PO,
        PQ,
        PY,
        PZ,
        RB,
        RR,
        RT,
        RX,
        SG,
        V5,
        XP,
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_756 {
        AA,
        BM,
        EL,
        EM,
        FT,
        FX,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C002_ActionsIndicated {
    [XmlElement(Order=0)]
    public string D_C00201_Paperwork_ReportActionCode {get; set;}
    [XmlElement(Order=1)]
    public string D_C00202_Paperwork_ReportActionCode {get; set;}
    [XmlElement(Order=2)]
    public string D_C00203_Paperwork_ReportActionCode {get; set;}
    [XmlElement(Order=3)]
    public string D_C00204_Paperwork_ReportActionCode {get; set;}
    [XmlElement(Order=4)]
    public string D_C00205_Paperwork_ReportActionCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_CN1_ContractInformation {
    [XmlElement(Order=0)]
    public X12_ID_1166 D_CN101_ContractTypeCode {get; set;}
    [XmlElement(Order=1)]
    public string D_CN102_ContractAmount {get; set;}
    [XmlElement(Order=2)]
    public string D_CN103_ContractPercentage {get; set;}
    [XmlElement(Order=3)]
    public string D_CN104_ContractCode {get; set;}
    [XmlElement(Order=4)]
    public string D_CN105_TermsDiscountPercentage {get; set;}
    [XmlElement(Order=5)]
    public string D_CN106_ContractVersionIdentifier {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_1166 {
        [XmlEnum("01")]
        Item01,
        [XmlEnum("02")]
        Item02,
        [XmlEnum("03")]
        Item03,
        [XmlEnum("04")]
        Item04,
        [XmlEnum("05")]
        Item05,
        [XmlEnum("06")]
        Item06,
        [XmlEnum("09")]
        Item09,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_AMT_PatientAmountPaid {
    [XmlElement(Order=0)]
    public X12_ID_522 D_AMT01_AmountQualifierCode {get; set;}
    [XmlElement(Order=1)]
    public string D_AMT02_PatientAmountPaid {get; set;}
    [XmlElement(Order=2)]
    public string D_AMT03_Credit_DebitFlagCode {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_522 {
        F5,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class A_REF_5 {
    [XmlElementAttribute(Order=0)]
    public S_REF_ServiceAuthorizationExceptionCode S_REF_ServiceAuthorizationExceptionCode {get; set;}
    [XmlElementAttribute(Order=1)]
    public S_REF_MandatoryMedicare_Section4081_CrossoverIndicator S_REF_MandatoryMedicare_Section4081_CrossoverIndicator {get; set;}
    [XmlElementAttribute(Order=2)]
    public S_REF_MammographyCertificationNumber S_REF_MammographyCertificationNumber {get; set;}
    [XmlElementAttribute(Order=3)]
    public S_REF_ReferralNumber S_REF_ReferralNumber {get; set;}
    [XmlElementAttribute(Order=4)]
    public S_REF_PriorAuthorization S_REF_PriorAuthorization {get; set;}
    [XmlElementAttribute(Order=5)]
    public S_REF_PayerClaimControlNumber S_REF_PayerClaimControlNumber {get; set;}
    [XmlElementAttribute(Order=6)]
    public S_REF_ClinicalLaboratoryImprovementAmendment_CLIA_Number S_REF_ClinicalLaboratoryImprovementAmendment_CLIA_Number {get; set;}
    [XmlElementAttribute(Order=7)]
    public S_REF_RepricedClaimNumber S_REF_RepricedClaimNumber {get; set;}
    [XmlElementAttribute(Order=8)]
    public S_REF_AdjustedRepricedClaimNumber S_REF_AdjustedRepricedClaimNumber {get; set;}
    [XmlElementAttribute(Order=9)]
    public S_REF_InvestigationalDeviceExemptionNumber S_REF_InvestigationalDeviceExemptionNumber {get; set;}
    [XmlElementAttribute(Order=10)]
    public S_REF_ClaimIdentifierForTransmissionIntermediaries S_REF_ClaimIdentifierForTransmissionIntermediaries {get; set;}
    [XmlElementAttribute(Order=11)]
    public S_REF_MedicalRecordNumber S_REF_MedicalRecordNumber {get; set;}
    [XmlElementAttribute(Order=12)]
    public S_REF_DemonstrationProjectIdentifier S_REF_DemonstrationProjectIdentifier {get; set;}
    [XmlElementAttribute(Order=13)]
    public S_REF_CarePlanOversight S_REF_CarePlanOversight {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_ServiceAuthorizationExceptionCode {
    [XmlElement(Order=0)]
    public X12_ID_128_11 D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_127_1 D_REF02_ServiceAuthorizationExceptionCode {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03_Description {get; set;}
    [XmlElement(Order=3)]
    public C_C040_ReferenceIdentifier_9 C_C040_ReferenceIdentifier_9 {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_128_11 {
        [XmlEnum("4N")]
        Item4N,
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_127_1 {
        [XmlEnum("1")]
        Item1,
        [XmlEnum("2")]
        Item2,
        [XmlEnum("3")]
        Item3,
        [XmlEnum("4")]
        Item4,
        [XmlEnum("5")]
        Item5,
        [XmlEnum("6")]
        Item6,
        [XmlEnum("7")]
        Item7,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C040_ReferenceIdentifier_9 {
    [XmlElement(Order=0)]
    public string D_C04001_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C04002_ReferenceIdentification {get; set;}
    [XmlElement(Order=2)]
    public string D_C04003_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C04004_ReferenceIdentification {get; set;}
    [XmlElement(Order=4)]
    public string D_C04005_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_C04006_ReferenceIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_MandatoryMedicare_Section4081_CrossoverIndicator {
    [XmlElement(Order=0)]
    public X12_ID_128_12 D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_127_2 D_REF02_MedicareSection4081Indicator {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03_Description {get; set;}
    [XmlElement(Order=3)]
    public C_C040_ReferenceIdentifier_10 C_C040_ReferenceIdentifier_10 {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_128_12 {
        F5,
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_127_2 {
        N,
        Y,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C040_ReferenceIdentifier_10 {
    [XmlElement(Order=0)]
    public string D_C04001_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C04002_ReferenceIdentification {get; set;}
    [XmlElement(Order=2)]
    public string D_C04003_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C04004_ReferenceIdentification {get; set;}
    [XmlElement(Order=4)]
    public string D_C04005_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_C04006_ReferenceIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_MammographyCertificationNumber {
    [XmlElement(Order=0)]
    public X12_ID_128_13 D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_MammographyCertificationNumber {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03_Description {get; set;}
    [XmlElement(Order=3)]
    public C_C040_ReferenceIdentifier_11 C_C040_ReferenceIdentifier_11 {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_128_13 {
        EW,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C040_ReferenceIdentifier_11 {
    [XmlElement(Order=0)]
    public string D_C04001_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C04002_ReferenceIdentification {get; set;}
    [XmlElement(Order=2)]
    public string D_C04003_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C04004_ReferenceIdentification {get; set;}
    [XmlElement(Order=4)]
    public string D_C04005_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_C04006_ReferenceIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_ReferralNumber {
    [XmlElement(Order=0)]
    public X12_ID_128_14 D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_ReferralNumber {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03_Description {get; set;}
    [XmlElement(Order=3)]
    public C_C040_ReferenceIdentifier_12 C_C040_ReferenceIdentifier_12 {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_128_14 {
        [XmlEnum("9F")]
        Item9F,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C040_ReferenceIdentifier_12 {
    [XmlElement(Order=0)]
    public string D_C04001_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C04002_ReferenceIdentification {get; set;}
    [XmlElement(Order=2)]
    public string D_C04003_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C04004_ReferenceIdentification {get; set;}
    [XmlElement(Order=4)]
    public string D_C04005_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_C04006_ReferenceIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_PriorAuthorization {
    [XmlElement(Order=0)]
    public X12_ID_128_15 D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_PriorAuthorizationNumber {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03_Description {get; set;}
    [XmlElement(Order=3)]
    public C_C040_ReferenceIdentifier_13 C_C040_ReferenceIdentifier_13 {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_128_15 {
        G1,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C040_ReferenceIdentifier_13 {
    [XmlElement(Order=0)]
    public string D_C04001_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C04002_ReferenceIdentification {get; set;}
    [XmlElement(Order=2)]
    public string D_C04003_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C04004_ReferenceIdentification {get; set;}
    [XmlElement(Order=4)]
    public string D_C04005_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_C04006_ReferenceIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_PayerClaimControlNumber {
    [XmlElement(Order=0)]
    public X12_ID_128_16 D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_PayerClaimControlNumber {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03_Description {get; set;}
    [XmlElement(Order=3)]
    public C_C040_ReferenceIdentifier_14 C_C040_ReferenceIdentifier_14 {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_128_16 {
        F8,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C040_ReferenceIdentifier_14 {
    [XmlElement(Order=0)]
    public string D_C04001_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C04002_ReferenceIdentification {get; set;}
    [XmlElement(Order=2)]
    public string D_C04003_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C04004_ReferenceIdentification {get; set;}
    [XmlElement(Order=4)]
    public string D_C04005_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_C04006_ReferenceIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_ClinicalLaboratoryImprovementAmendment_CLIA_Number {
    [XmlElement(Order=0)]
    public X12_ID_128_17 D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_ClinicalLaboratoryImprovementAmendmentNumber {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03_Description {get; set;}
    [XmlElement(Order=3)]
    public C_C040_ReferenceIdentifier_15 C_C040_ReferenceIdentifier_15 {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_128_17 {
        X4,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C040_ReferenceIdentifier_15 {
    [XmlElement(Order=0)]
    public string D_C04001_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C04002_ReferenceIdentification {get; set;}
    [XmlElement(Order=2)]
    public string D_C04003_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C04004_ReferenceIdentification {get; set;}
    [XmlElement(Order=4)]
    public string D_C04005_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_C04006_ReferenceIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_RepricedClaimNumber {
    [XmlElement(Order=0)]
    public X12_ID_128_18 D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_RepricedClaimReferenceNumber {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03_Description {get; set;}
    [XmlElement(Order=3)]
    public C_C040_ReferenceIdentifier_16 C_C040_ReferenceIdentifier_16 {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_128_18 {
        [XmlEnum("9A")]
        Item9A,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C040_ReferenceIdentifier_16 {
    [XmlElement(Order=0)]
    public string D_C04001_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C04002_ReferenceIdentification {get; set;}
    [XmlElement(Order=2)]
    public string D_C04003_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C04004_ReferenceIdentification {get; set;}
    [XmlElement(Order=4)]
    public string D_C04005_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_C04006_ReferenceIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_AdjustedRepricedClaimNumber {
    [XmlElement(Order=0)]
    public X12_ID_128_19 D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_AdjustedRepricedClaimReferenceNumber {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03_Description {get; set;}
    [XmlElement(Order=3)]
    public C_C040_ReferenceIdentifier_17 C_C040_ReferenceIdentifier_17 {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_128_19 {
        [XmlEnum("9C")]
        Item9C,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C040_ReferenceIdentifier_17 {
    [XmlElement(Order=0)]
    public string D_C04001_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C04002_ReferenceIdentification {get; set;}
    [XmlElement(Order=2)]
    public string D_C04003_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C04004_ReferenceIdentification {get; set;}
    [XmlElement(Order=4)]
    public string D_C04005_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_C04006_ReferenceIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_InvestigationalDeviceExemptionNumber {
    [XmlElement(Order=0)]
    public X12_ID_128_20 D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_InvestigationalDeviceExemptionIdentifier {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03_Description {get; set;}
    [XmlElement(Order=3)]
    public C_C040_ReferenceIdentifier_18 C_C040_ReferenceIdentifier_18 {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_128_20 {
        LX,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C040_ReferenceIdentifier_18 {
    [XmlElement(Order=0)]
    public string D_C04001_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C04002_ReferenceIdentification {get; set;}
    [XmlElement(Order=2)]
    public string D_C04003_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C04004_ReferenceIdentification {get; set;}
    [XmlElement(Order=4)]
    public string D_C04005_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_C04006_ReferenceIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_ClaimIdentifierForTransmissionIntermediaries {
    [XmlElement(Order=0)]
    public X12_ID_128_21 D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_ValueAddedNetworkTraceNumber {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03_Description {get; set;}
    [XmlElement(Order=3)]
    public C_C040_ReferenceIdentifier_19 C_C040_ReferenceIdentifier_19 {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_128_21 {
        D9,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C040_ReferenceIdentifier_19 {
    [XmlElement(Order=0)]
    public string D_C04001_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C04002_ReferenceIdentification {get; set;}
    [XmlElement(Order=2)]
    public string D_C04003_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C04004_ReferenceIdentification {get; set;}
    [XmlElement(Order=4)]
    public string D_C04005_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_C04006_ReferenceIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_MedicalRecordNumber {
    [XmlElement(Order=0)]
    public X12_ID_128_22 D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_MedicalRecordNumber {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03_Description {get; set;}
    [XmlElement(Order=3)]
    public C_C040_ReferenceIdentifier_20 C_C040_ReferenceIdentifier_20 {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_128_22 {
        EA,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C040_ReferenceIdentifier_20 {
    [XmlElement(Order=0)]
    public string D_C04001_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C04002_ReferenceIdentification {get; set;}
    [XmlElement(Order=2)]
    public string D_C04003_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C04004_ReferenceIdentification {get; set;}
    [XmlElement(Order=4)]
    public string D_C04005_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_C04006_ReferenceIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_DemonstrationProjectIdentifier {
    [XmlElement(Order=0)]
    public X12_ID_128_23 D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_DemonstrationProjectIdentifier {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03_Description {get; set;}
    [XmlElement(Order=3)]
    public C_C040_ReferenceIdentifier_21 C_C040_ReferenceIdentifier_21 {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_128_23 {
        P4,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C040_ReferenceIdentifier_21 {
    [XmlElement(Order=0)]
    public string D_C04001_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C04002_ReferenceIdentification {get; set;}
    [XmlElement(Order=2)]
    public string D_C04003_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C04004_ReferenceIdentification {get; set;}
    [XmlElement(Order=4)]
    public string D_C04005_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_C04006_ReferenceIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_CarePlanOversight {
    [XmlElement(Order=0)]
    public X12_ID_128_24 D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_CarePlanOversightNumber {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03_Description {get; set;}
    [XmlElement(Order=3)]
    public C_C040_ReferenceIdentifier_22 C_C040_ReferenceIdentifier_22 {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_128_24 {
        [XmlEnum("1J")]
        Item1J,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C040_ReferenceIdentifier_22 {
    [XmlElement(Order=0)]
    public string D_C04001_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C04002_ReferenceIdentification {get; set;}
    [XmlElement(Order=2)]
    public string D_C04003_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C04004_ReferenceIdentification {get; set;}
    [XmlElement(Order=4)]
    public string D_C04005_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_C04006_ReferenceIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_K3_FileInformation {
    [XmlElement(Order=0)]
    public string D_K301_FixedFormatInformation {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1333 D_K302_RecordFormatCode {get; set;}
    [XmlElement(Order=2)]
    public C_C001_CompositeUnitofMeasure C_C001_CompositeUnitofMeasure {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_1333 {
        C,
        D,
        E,
        F,
        P,
        S,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C001_CompositeUnitofMeasure {
    [XmlElement(Order=0)]
    public string D_C00101_UnitorBasisforMeasurementCode {get; set;}
    [XmlElement(Order=1)]
    public string D_C00102_Exponent {get; set;}
    [XmlElement(Order=2)]
    public string D_C00103_Multiplier {get; set;}
    [XmlElement(Order=3)]
    public string D_C00104_UnitorBasisforMeasurementCode {get; set;}
    [XmlElement(Order=4)]
    public string D_C00105_Exponent {get; set;}
    [XmlElement(Order=5)]
    public string D_C00106_Multiplier {get; set;}
    [XmlElement(Order=6)]
    public string D_C00107_UnitorBasisforMeasurementCode {get; set;}
    [XmlElement(Order=7)]
    public string D_C00108_Exponent {get; set;}
    [XmlElement(Order=8)]
    public string D_C00109_Multiplier {get; set;}
    [XmlElement(Order=9)]
    public string D_C00110_UnitorBasisforMeasurementCode {get; set;}
    [XmlElement(Order=10)]
    public string D_C00111_Exponent {get; set;}
    [XmlElement(Order=11)]
    public string D_C00112_Multiplier {get; set;}
    [XmlElement(Order=12)]
    public string D_C00113_UnitorBasisforMeasurementCode {get; set;}
    [XmlElement(Order=13)]
    public string D_C00114_Exponent {get; set;}
    [XmlElement(Order=14)]
    public string D_C00115_Multiplier {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_NTE_ClaimNote {
    [XmlElement(Order=0)]
    public X12_ID_363 D_NTE01_NoteReferenceCode {get; set;}
    [XmlElement(Order=1)]
    public string D_NTE02_ClaimNoteText {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_363 {
        ADD,
        CER,
        DCP,
        DGN,
        TPO,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_CR1_AmbulanceTransportInformation {
    [XmlElement(Order=0)]
    public X12_ID_355_3 D_CR101_UnitorBasisforMeasurementCode {get; set;}
    [XmlElement(Order=1)]
    public string D_CR102_PatientWeight {get; set;}
    [XmlElement(Order=2)]
    public string D_CR103_AmbulanceTransportCode {get; set;}
    [XmlElement(Order=3)]
    public string D_CR104_AmbulanceTransportReasonCode {get; set;}
    [XmlElement(Order=4)]
    public string D_CR105_UnitorBasisforMeasurementCode {get; set;}
    [XmlElement(Order=5)]
    public string D_CR106_TransportDistance {get; set;}
    [XmlElement(Order=6)]
    public string D_CR107_AddressInformation {get; set;}
    [XmlElement(Order=7)]
    public string D_CR108_AddressInformation {get; set;}
    [XmlElement(Order=8)]
    public string D_CR109_RoundTripPurposeDescription {get; set;}
    [XmlElement(Order=9)]
    public string D_CR110_StretcherPurposeDescription {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_355_3 {
        LB,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_CR2_SpinalManipulationServiceInformation {
    [XmlElement(Order=0)]
    public string D_CR201_Count {get; set;}
    [XmlElement(Order=1)]
    public string D_CR202_Quantity {get; set;}
    [XmlElement(Order=2)]
    public string D_CR203_SubluxationLevelCode {get; set;}
    [XmlElement(Order=3)]
    public string D_CR204_SubluxationLevelCode {get; set;}
    [XmlElement(Order=4)]
    public string D_CR205_UnitorBasisforMeasurementCode {get; set;}
    [XmlElement(Order=5)]
    public string D_CR206_Quantity {get; set;}
    [XmlElement(Order=6)]
    public string D_CR207_Quantity {get; set;}
    [XmlElement(Order=7)]
    public string D_CR208_PatientConditionCode {get; set;}
    [XmlElement(Order=8)]
    public string D_CR209_Yes_NoConditionorResponseCode {get; set;}
    [XmlElement(Order=9)]
    public string D_CR210_PatientConditionDescription {get; set;}
    [XmlElement(Order=10)]
    public string D_CR211_PatientConditionDescription {get; set;}
    [XmlElement(Order=11)]
    public string D_CR212_Yes_NoConditionorResponseCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class A_CRC {
    [XmlElement(Order=0)]
    public U_CRC_AmbulanceCertification U_CRC_AmbulanceCertification {get; set;}
    [XmlElement(Order=1)]
    public U_CRC_PatientConditionInformation_Vision U_CRC_PatientConditionInformation_Vision {get; set;}
    [XmlElementAttribute(Order=2)]
    public S_CRC_HomeboundIndicator S_CRC_HomeboundIndicator {get; set;}
    [XmlElementAttribute(Order=3)]
    public S_CRC_EPSDTReferral S_CRC_EPSDTReferral {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_CRC_AmbulanceCertification {
    [XmlElement(Order=0)]
    public X12_ID_1136 D_CRC01_CodeCategory {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1073_3 D_CRC02_CertificationConditionIndicator {get; set;}
    [XmlElement(Order=2)]
    public string D_CRC03_ConditionCode {get; set;}
    [XmlElement(Order=3)]
    public string D_CRC04_ConditionCode {get; set;}
    [XmlElement(Order=4)]
    public string D_CRC05_ConditionCode {get; set;}
    [XmlElement(Order=5)]
    public string D_CRC06_ConditionCode {get; set;}
    [XmlElement(Order=6)]
    public string D_CRC07_ConditionCode {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_1136 {
        [XmlEnum("07")]
        Item07,
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_1073_3 {
        N,
        Y,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_CRC_PatientConditionInformation_Vision {
    [XmlElement(Order=0)]
    public X12_ID_1136_2 D_CRC01_CodeCategory {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1073_3 D_CRC02_CertificationConditionIndicator {get; set;}
    [XmlElement(Order=2)]
    public string D_CRC03_ConditionCode {get; set;}
    [XmlElement(Order=3)]
    public string D_CRC04_ConditionCode {get; set;}
    [XmlElement(Order=4)]
    public string D_CRC05_ConditionCode {get; set;}
    [XmlElement(Order=5)]
    public string D_CRC06_ConditionCode {get; set;}
    [XmlElement(Order=6)]
    public string D_CRC07_ConditionCode {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_1136_2 {
        E1,
        E2,
        E3,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_CRC_HomeboundIndicator {
    [XmlElement(Order=0)]
    public X12_ID_1136_3 D_CRC01_CodeCategory {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1073_2 D_CRC02_CertificationConditionIndicator {get; set;}
    [XmlElement(Order=2)]
    public string D_CRC03_HomeboundIndicator {get; set;}
    [XmlElement(Order=3)]
    public string D_CRC04_ConditionIndicator {get; set;}
    [XmlElement(Order=4)]
    public string D_CRC05_ConditionIndicator {get; set;}
    [XmlElement(Order=5)]
    public string D_CRC06_ConditionIndicator {get; set;}
    [XmlElement(Order=6)]
    public string D_CRC07_ConditionIndicator {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_1136_3 {
        [XmlEnum("75")]
        Item75,
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_1073_2 {
        Y,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_CRC_EPSDTReferral {
    [XmlElement(Order=0)]
    public X12_ID_1136_4 D_CRC01_CodeQualifier {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1073_3 D_CRC02_CertificationConditionCodeAppliesIndicator {get; set;}
    [XmlElement(Order=2)]
    public string D_CRC03_ConditionIndicator {get; set;}
    [XmlElement(Order=3)]
    public string D_CRC04_ConditionIndicator {get; set;}
    [XmlElement(Order=4)]
    public string D_CRC05_ConditionIndicator {get; set;}
    [XmlElement(Order=5)]
    public string D_CRC06_ConditionIndicator {get; set;}
    [XmlElement(Order=6)]
    public string D_CRC07_ConditionIndicator {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_1136_4 {
        ZZ,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class A_HI {
    [XmlElementAttribute(Order=0)]
    public S_HI_HealthCareDiagnosisCode S_HI_HealthCareDiagnosisCode {get; set;}
    [XmlElementAttribute(Order=1)]
    public S_HI_AnesthesiaRelatedProcedure S_HI_AnesthesiaRelatedProcedure {get; set;}
    [XmlElement(Order=2)]
    public U_HI_ConditionInformation U_HI_ConditionInformation {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_HI_HealthCareDiagnosisCode {
    [XmlElement(Order=0)]
    public C_C022_HealthCareCodeInformation C_C022_HealthCareCodeInformation {get; set;}
    [XmlElement(Order=1)]
    public C_C022_HealthCareCodeInformation_2 C_C022_HealthCareCodeInformation_2 {get; set;}
    [XmlElement(Order=2)]
    public C_C022_HealthCareCodeInformation_3 C_C022_HealthCareCodeInformation_3 {get; set;}
    [XmlElement(Order=3)]
    public C_C022_HealthCareCodeInformation_4 C_C022_HealthCareCodeInformation_4 {get; set;}
    [XmlElement(Order=4)]
    public C_C022_HealthCareCodeInformation_5 C_C022_HealthCareCodeInformation_5 {get; set;}
    [XmlElement(Order=5)]
    public C_C022_HealthCareCodeInformation_6 C_C022_HealthCareCodeInformation_6 {get; set;}
    [XmlElement(Order=6)]
    public C_C022_HealthCareCodeInformation_7 C_C022_HealthCareCodeInformation_7 {get; set;}
    [XmlElement(Order=7)]
    public C_C022_HealthCareCodeInformation_8 C_C022_HealthCareCodeInformation_8 {get; set;}
    [XmlElement(Order=8)]
    public C_C022_HealthCareCodeInformation_9 C_C022_HealthCareCodeInformation_9 {get; set;}
    [XmlElement(Order=9)]
    public C_C022_HealthCareCodeInformation_10 C_C022_HealthCareCodeInformation_10 {get; set;}
    [XmlElement(Order=10)]
    public C_C022_HealthCareCodeInformation_11 C_C022_HealthCareCodeInformation_11 {get; set;}
    [XmlElement(Order=11)]
    public C_C022_HealthCareCodeInformation_12 C_C022_HealthCareCodeInformation_12 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C022_HealthCareCodeInformation {
    [XmlElement(Order=0)]
    public X12_ID_1270_2 D_C02201_DiagnosisTypeCode {get; set;}
    [XmlElement(Order=1)]
    public string D_C02202_DiagnosisCode {get; set;}
    [XmlElement(Order=2)]
    public string D_C02203_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C02204_DateTimePeriod {get; set;}
    [XmlElement(Order=4)]
    public string D_C02205_MonetaryAmount {get; set;}
    [XmlElement(Order=5)]
    public string D_C02206_Quantity {get; set;}
    [XmlElement(Order=6)]
    public string D_C02207_VersionIdentifier {get; set;}
    [XmlElement(Order=7)]
    public string D_C02208_IndustryCode {get; set;}
    [XmlElement(Order=8)]
    public string D_C02209_Yes_NoConditionorResponseCode {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_1270_2 {
        ABK,
        BK,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C022_HealthCareCodeInformation_2 {
    [XmlElement(Order=0)]
    public X12_ID_1270_3 D_C02201_DiagnosisTypeCode {get; set;}
    [XmlElement(Order=1)]
    public string D_C02202_DiagnosisCode {get; set;}
    [XmlElement(Order=2)]
    public string D_C02203_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C02204_DateTimePeriod {get; set;}
    [XmlElement(Order=4)]
    public string D_C02205_MonetaryAmount {get; set;}
    [XmlElement(Order=5)]
    public string D_C02206_Quantity {get; set;}
    [XmlElement(Order=6)]
    public string D_C02207_VersionIdentifier {get; set;}
    [XmlElement(Order=7)]
    public string D_C02208_IndustryCode {get; set;}
    [XmlElement(Order=8)]
    public string D_C02209_Yes_NoConditionorResponseCode {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_1270_3 {
        ABF,
        BF,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C022_HealthCareCodeInformation_3 {
    [XmlElement(Order=0)]
    public string D_C02201_DiagnosisTypeCode {get; set;}
    [XmlElement(Order=1)]
    public string D_C02202_DiagnosisCode {get; set;}
    [XmlElement(Order=2)]
    public string D_C02203_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C02204_DateTimePeriod {get; set;}
    [XmlElement(Order=4)]
    public string D_C02205_MonetaryAmount {get; set;}
    [XmlElement(Order=5)]
    public string D_C02206_Quantity {get; set;}
    [XmlElement(Order=6)]
    public string D_C02207_VersionIdentifier {get; set;}
    [XmlElement(Order=7)]
    public string D_C02208_IndustryCode {get; set;}
    [XmlElement(Order=8)]
    public string D_C02209_Yes_NoConditionorResponseCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C022_HealthCareCodeInformation_4 {
    [XmlElement(Order=0)]
    public string D_C02201_DiagnosisTypeCode {get; set;}
    [XmlElement(Order=1)]
    public string D_C02202_DiagnosisCode {get; set;}
    [XmlElement(Order=2)]
    public string D_C02203_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C02204_DateTimePeriod {get; set;}
    [XmlElement(Order=4)]
    public string D_C02205_MonetaryAmount {get; set;}
    [XmlElement(Order=5)]
    public string D_C02206_Quantity {get; set;}
    [XmlElement(Order=6)]
    public string D_C02207_VersionIdentifier {get; set;}
    [XmlElement(Order=7)]
    public string D_C02208_IndustryCode {get; set;}
    [XmlElement(Order=8)]
    public string D_C02209_Yes_NoConditionorResponseCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C022_HealthCareCodeInformation_5 {
    [XmlElement(Order=0)]
    public string D_C02201_DiagnosisTypeCode {get; set;}
    [XmlElement(Order=1)]
    public string D_C02202_DiagnosisCode {get; set;}
    [XmlElement(Order=2)]
    public string D_C02203_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C02204_DateTimePeriod {get; set;}
    [XmlElement(Order=4)]
    public string D_C02205_MonetaryAmount {get; set;}
    [XmlElement(Order=5)]
    public string D_C02206_Quantity {get; set;}
    [XmlElement(Order=6)]
    public string D_C02207_VersionIdentifier {get; set;}
    [XmlElement(Order=7)]
    public string D_C02208_IndustryCode {get; set;}
    [XmlElement(Order=8)]
    public string D_C02209_Yes_NoConditionorResponseCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C022_HealthCareCodeInformation_6 {
    [XmlElement(Order=0)]
    public string D_C02201_DiagnosisTypeCode {get; set;}
    [XmlElement(Order=1)]
    public string D_C02202_DiagnosisCode {get; set;}
    [XmlElement(Order=2)]
    public string D_C02203_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C02204_DateTimePeriod {get; set;}
    [XmlElement(Order=4)]
    public string D_C02205_MonetaryAmount {get; set;}
    [XmlElement(Order=5)]
    public string D_C02206_Quantity {get; set;}
    [XmlElement(Order=6)]
    public string D_C02207_VersionIdentifier {get; set;}
    [XmlElement(Order=7)]
    public string D_C02208_IndustryCode {get; set;}
    [XmlElement(Order=8)]
    public string D_C02209_Yes_NoConditionorResponseCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C022_HealthCareCodeInformation_7 {
    [XmlElement(Order=0)]
    public string D_C02201_DiagnosisTypeCode {get; set;}
    [XmlElement(Order=1)]
    public string D_C02202_DiagnosisCode {get; set;}
    [XmlElement(Order=2)]
    public string D_C02203_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C02204_DateTimePeriod {get; set;}
    [XmlElement(Order=4)]
    public string D_C02205_MonetaryAmount {get; set;}
    [XmlElement(Order=5)]
    public string D_C02206_Quantity {get; set;}
    [XmlElement(Order=6)]
    public string D_C02207_VersionIdentifier {get; set;}
    [XmlElement(Order=7)]
    public string D_C02208_IndustryCode {get; set;}
    [XmlElement(Order=8)]
    public string D_C02209_Yes_NoConditionorResponseCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C022_HealthCareCodeInformation_8 {
    [XmlElement(Order=0)]
    public string D_C02201_DiagnosisTypeCode {get; set;}
    [XmlElement(Order=1)]
    public string D_C02202_DiagnosisCode {get; set;}
    [XmlElement(Order=2)]
    public string D_C02203_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C02204_DateTimePeriod {get; set;}
    [XmlElement(Order=4)]
    public string D_C02205_MonetaryAmount {get; set;}
    [XmlElement(Order=5)]
    public string D_C02206_Quantity {get; set;}
    [XmlElement(Order=6)]
    public string D_C02207_VersionIdentifier {get; set;}
    [XmlElement(Order=7)]
    public string D_C02208_IndustryCode {get; set;}
    [XmlElement(Order=8)]
    public string D_C02209_Yes_NoConditionorResponseCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C022_HealthCareCodeInformation_9 {
    [XmlElement(Order=0)]
    public string D_C02201_DiagnosisTypeCode {get; set;}
    [XmlElement(Order=1)]
    public string D_C02202_DiagnosisCode {get; set;}
    [XmlElement(Order=2)]
    public string D_C02203_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C02204_DateTimePeriod {get; set;}
    [XmlElement(Order=4)]
    public string D_C02205_MonetaryAmount {get; set;}
    [XmlElement(Order=5)]
    public string D_C02206_Quantity {get; set;}
    [XmlElement(Order=6)]
    public string D_C02207_VersionIdentifier {get; set;}
    [XmlElement(Order=7)]
    public string D_C02208_IndustryCode {get; set;}
    [XmlElement(Order=8)]
    public string D_C02209_Yes_NoConditionorResponseCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C022_HealthCareCodeInformation_10 {
    [XmlElement(Order=0)]
    public string D_C02201_DiagnosisTypeCode {get; set;}
    [XmlElement(Order=1)]
    public string D_C02202_DiagnosisCode {get; set;}
    [XmlElement(Order=2)]
    public string D_C02203_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C02204_DateTimePeriod {get; set;}
    [XmlElement(Order=4)]
    public string D_C02205_MonetaryAmount {get; set;}
    [XmlElement(Order=5)]
    public string D_C02206_Quantity {get; set;}
    [XmlElement(Order=6)]
    public string D_C02207_VersionIdentifier {get; set;}
    [XmlElement(Order=7)]
    public string D_C02208_IndustryCode {get; set;}
    [XmlElement(Order=8)]
    public string D_C02209_Yes_NoConditionorResponseCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C022_HealthCareCodeInformation_11 {
    [XmlElement(Order=0)]
    public string D_C02201_DiagnosisTypeCode {get; set;}
    [XmlElement(Order=1)]
    public string D_C02202_DiagnosisCode {get; set;}
    [XmlElement(Order=2)]
    public string D_C02203_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C02204_DateTimePeriod {get; set;}
    [XmlElement(Order=4)]
    public string D_C02205_MonetaryAmount {get; set;}
    [XmlElement(Order=5)]
    public string D_C02206_Quantity {get; set;}
    [XmlElement(Order=6)]
    public string D_C02207_VersionIdentifier {get; set;}
    [XmlElement(Order=7)]
    public string D_C02208_IndustryCode {get; set;}
    [XmlElement(Order=8)]
    public string D_C02209_Yes_NoConditionorResponseCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C022_HealthCareCodeInformation_12 {
    [XmlElement(Order=0)]
    public string D_C02201_DiagnosisTypeCode {get; set;}
    [XmlElement(Order=1)]
    public string D_C02202_DiagnosisCode {get; set;}
    [XmlElement(Order=2)]
    public string D_C02203_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C02204_DateTimePeriod {get; set;}
    [XmlElement(Order=4)]
    public string D_C02205_MonetaryAmount {get; set;}
    [XmlElement(Order=5)]
    public string D_C02206_Quantity {get; set;}
    [XmlElement(Order=6)]
    public string D_C02207_VersionIdentifier {get; set;}
    [XmlElement(Order=7)]
    public string D_C02208_IndustryCode {get; set;}
    [XmlElement(Order=8)]
    public string D_C02209_Yes_NoConditionorResponseCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_HI_AnesthesiaRelatedProcedure {
    [XmlElement(Order=0)]
    public C_C022_HealthCareCodeInformation_13 C_C022_HealthCareCodeInformation_13 {get; set;}
    [XmlElement(Order=1)]
    public C_C022_HealthCareCodeInformation_14 C_C022_HealthCareCodeInformation_14 {get; set;}
    [XmlElement(Order=2)]
    public C_C022_HealthCareCodeInformation_15 C_C022_HealthCareCodeInformation_15 {get; set;}
    [XmlElement(Order=3)]
    public C_C022_HealthCareCodeInformation_16 C_C022_HealthCareCodeInformation_16 {get; set;}
    [XmlElement(Order=4)]
    public C_C022_HealthCareCodeInformation_17 C_C022_HealthCareCodeInformation_17 {get; set;}
    [XmlElement(Order=5)]
    public C_C022_HealthCareCodeInformation_18 C_C022_HealthCareCodeInformation_18 {get; set;}
    [XmlElement(Order=6)]
    public C_C022_HealthCareCodeInformation_19 C_C022_HealthCareCodeInformation_19 {get; set;}
    [XmlElement(Order=7)]
    public C_C022_HealthCareCodeInformation_20 C_C022_HealthCareCodeInformation_20 {get; set;}
    [XmlElement(Order=8)]
    public C_C022_HealthCareCodeInformation_21 C_C022_HealthCareCodeInformation_21 {get; set;}
    [XmlElement(Order=9)]
    public C_C022_HealthCareCodeInformation_22 C_C022_HealthCareCodeInformation_22 {get; set;}
    [XmlElement(Order=10)]
    public C_C022_HealthCareCodeInformation_23 C_C022_HealthCareCodeInformation_23 {get; set;}
    [XmlElement(Order=11)]
    public C_C022_HealthCareCodeInformation_24 C_C022_HealthCareCodeInformation_24 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C022_HealthCareCodeInformation_13 {
    [XmlElement(Order=0)]
    public X12_ID_1270_4 D_C02201_CodeListQualifierCode {get; set;}
    [XmlElement(Order=1)]
    public string D_C02202_AnesthesiaRelatedSurgicalProcedure {get; set;}
    [XmlElement(Order=2)]
    public string D_C02203_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C02204_DateTimePeriod {get; set;}
    [XmlElement(Order=4)]
    public string D_C02205_MonetaryAmount {get; set;}
    [XmlElement(Order=5)]
    public string D_C02206_Quantity {get; set;}
    [XmlElement(Order=6)]
    public string D_C02207_VersionIdentifier {get; set;}
    [XmlElement(Order=7)]
    public string D_C02208_IndustryCode {get; set;}
    [XmlElement(Order=8)]
    public string D_C02209_Yes_NoConditionorResponseCode {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_1270_4 {
        BP,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C022_HealthCareCodeInformation_14 {
    [XmlElement(Order=0)]
    public X12_ID_1270_5 D_C02201_CodeListQualifierCode {get; set;}
    [XmlElement(Order=1)]
    public string D_C02202_IndustryCode {get; set;}
    [XmlElement(Order=2)]
    public string D_C02203_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C02204_DateTimePeriod {get; set;}
    [XmlElement(Order=4)]
    public string D_C02205_MonetaryAmount {get; set;}
    [XmlElement(Order=5)]
    public string D_C02206_Quantity {get; set;}
    [XmlElement(Order=6)]
    public string D_C02207_VersionIdentifier {get; set;}
    [XmlElement(Order=7)]
    public string D_C02208_IndustryCode {get; set;}
    [XmlElement(Order=8)]
    public string D_C02209_Yes_NoConditionorResponseCode {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_1270_5 {
        BO,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C022_HealthCareCodeInformation_15 {
    [XmlElement(Order=0)]
    public string D_C02201_CodeListQualifierCode {get; set;}
    [XmlElement(Order=1)]
    public string D_C02202_IndustryCode {get; set;}
    [XmlElement(Order=2)]
    public string D_C02203_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C02204_DateTimePeriod {get; set;}
    [XmlElement(Order=4)]
    public string D_C02205_MonetaryAmount {get; set;}
    [XmlElement(Order=5)]
    public string D_C02206_Quantity {get; set;}
    [XmlElement(Order=6)]
    public string D_C02207_VersionIdentifier {get; set;}
    [XmlElement(Order=7)]
    public string D_C02208_IndustryCode {get; set;}
    [XmlElement(Order=8)]
    public string D_C02209_Yes_NoConditionorResponseCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C022_HealthCareCodeInformation_16 {
    [XmlElement(Order=0)]
    public string D_C02201_CodeListQualifierCode {get; set;}
    [XmlElement(Order=1)]
    public string D_C02202_IndustryCode {get; set;}
    [XmlElement(Order=2)]
    public string D_C02203_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C02204_DateTimePeriod {get; set;}
    [XmlElement(Order=4)]
    public string D_C02205_MonetaryAmount {get; set;}
    [XmlElement(Order=5)]
    public string D_C02206_Quantity {get; set;}
    [XmlElement(Order=6)]
    public string D_C02207_VersionIdentifier {get; set;}
    [XmlElement(Order=7)]
    public string D_C02208_IndustryCode {get; set;}
    [XmlElement(Order=8)]
    public string D_C02209_Yes_NoConditionorResponseCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C022_HealthCareCodeInformation_17 {
    [XmlElement(Order=0)]
    public string D_C02201_CodeListQualifierCode {get; set;}
    [XmlElement(Order=1)]
    public string D_C02202_IndustryCode {get; set;}
    [XmlElement(Order=2)]
    public string D_C02203_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C02204_DateTimePeriod {get; set;}
    [XmlElement(Order=4)]
    public string D_C02205_MonetaryAmount {get; set;}
    [XmlElement(Order=5)]
    public string D_C02206_Quantity {get; set;}
    [XmlElement(Order=6)]
    public string D_C02207_VersionIdentifier {get; set;}
    [XmlElement(Order=7)]
    public string D_C02208_IndustryCode {get; set;}
    [XmlElement(Order=8)]
    public string D_C02209_Yes_NoConditionorResponseCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C022_HealthCareCodeInformation_18 {
    [XmlElement(Order=0)]
    public string D_C02201_CodeListQualifierCode {get; set;}
    [XmlElement(Order=1)]
    public string D_C02202_IndustryCode {get; set;}
    [XmlElement(Order=2)]
    public string D_C02203_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C02204_DateTimePeriod {get; set;}
    [XmlElement(Order=4)]
    public string D_C02205_MonetaryAmount {get; set;}
    [XmlElement(Order=5)]
    public string D_C02206_Quantity {get; set;}
    [XmlElement(Order=6)]
    public string D_C02207_VersionIdentifier {get; set;}
    [XmlElement(Order=7)]
    public string D_C02208_IndustryCode {get; set;}
    [XmlElement(Order=8)]
    public string D_C02209_Yes_NoConditionorResponseCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C022_HealthCareCodeInformation_19 {
    [XmlElement(Order=0)]
    public string D_C02201_CodeListQualifierCode {get; set;}
    [XmlElement(Order=1)]
    public string D_C02202_IndustryCode {get; set;}
    [XmlElement(Order=2)]
    public string D_C02203_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C02204_DateTimePeriod {get; set;}
    [XmlElement(Order=4)]
    public string D_C02205_MonetaryAmount {get; set;}
    [XmlElement(Order=5)]
    public string D_C02206_Quantity {get; set;}
    [XmlElement(Order=6)]
    public string D_C02207_VersionIdentifier {get; set;}
    [XmlElement(Order=7)]
    public string D_C02208_IndustryCode {get; set;}
    [XmlElement(Order=8)]
    public string D_C02209_Yes_NoConditionorResponseCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C022_HealthCareCodeInformation_20 {
    [XmlElement(Order=0)]
    public string D_C02201_CodeListQualifierCode {get; set;}
    [XmlElement(Order=1)]
    public string D_C02202_IndustryCode {get; set;}
    [XmlElement(Order=2)]
    public string D_C02203_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C02204_DateTimePeriod {get; set;}
    [XmlElement(Order=4)]
    public string D_C02205_MonetaryAmount {get; set;}
    [XmlElement(Order=5)]
    public string D_C02206_Quantity {get; set;}
    [XmlElement(Order=6)]
    public string D_C02207_VersionIdentifier {get; set;}
    [XmlElement(Order=7)]
    public string D_C02208_IndustryCode {get; set;}
    [XmlElement(Order=8)]
    public string D_C02209_Yes_NoConditionorResponseCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C022_HealthCareCodeInformation_21 {
    [XmlElement(Order=0)]
    public string D_C02201_CodeListQualifierCode {get; set;}
    [XmlElement(Order=1)]
    public string D_C02202_IndustryCode {get; set;}
    [XmlElement(Order=2)]
    public string D_C02203_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C02204_DateTimePeriod {get; set;}
    [XmlElement(Order=4)]
    public string D_C02205_MonetaryAmount {get; set;}
    [XmlElement(Order=5)]
    public string D_C02206_Quantity {get; set;}
    [XmlElement(Order=6)]
    public string D_C02207_VersionIdentifier {get; set;}
    [XmlElement(Order=7)]
    public string D_C02208_IndustryCode {get; set;}
    [XmlElement(Order=8)]
    public string D_C02209_Yes_NoConditionorResponseCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C022_HealthCareCodeInformation_22 {
    [XmlElement(Order=0)]
    public string D_C02201_CodeListQualifierCode {get; set;}
    [XmlElement(Order=1)]
    public string D_C02202_IndustryCode {get; set;}
    [XmlElement(Order=2)]
    public string D_C02203_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C02204_DateTimePeriod {get; set;}
    [XmlElement(Order=4)]
    public string D_C02205_MonetaryAmount {get; set;}
    [XmlElement(Order=5)]
    public string D_C02206_Quantity {get; set;}
    [XmlElement(Order=6)]
    public string D_C02207_VersionIdentifier {get; set;}
    [XmlElement(Order=7)]
    public string D_C02208_IndustryCode {get; set;}
    [XmlElement(Order=8)]
    public string D_C02209_Yes_NoConditionorResponseCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C022_HealthCareCodeInformation_23 {
    [XmlElement(Order=0)]
    public string D_C02201_CodeListQualifierCode {get; set;}
    [XmlElement(Order=1)]
    public string D_C02202_IndustryCode {get; set;}
    [XmlElement(Order=2)]
    public string D_C02203_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C02204_DateTimePeriod {get; set;}
    [XmlElement(Order=4)]
    public string D_C02205_MonetaryAmount {get; set;}
    [XmlElement(Order=5)]
    public string D_C02206_Quantity {get; set;}
    [XmlElement(Order=6)]
    public string D_C02207_VersionIdentifier {get; set;}
    [XmlElement(Order=7)]
    public string D_C02208_IndustryCode {get; set;}
    [XmlElement(Order=8)]
    public string D_C02209_Yes_NoConditionorResponseCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C022_HealthCareCodeInformation_24 {
    [XmlElement(Order=0)]
    public string D_C02201_CodeListQualifierCode {get; set;}
    [XmlElement(Order=1)]
    public string D_C02202_IndustryCode {get; set;}
    [XmlElement(Order=2)]
    public string D_C02203_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C02204_DateTimePeriod {get; set;}
    [XmlElement(Order=4)]
    public string D_C02205_MonetaryAmount {get; set;}
    [XmlElement(Order=5)]
    public string D_C02206_Quantity {get; set;}
    [XmlElement(Order=6)]
    public string D_C02207_VersionIdentifier {get; set;}
    [XmlElement(Order=7)]
    public string D_C02208_IndustryCode {get; set;}
    [XmlElement(Order=8)]
    public string D_C02209_Yes_NoConditionorResponseCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_HI_ConditionInformation {
    [XmlElement(Order=0)]
    public C_C022_HealthCareCodeInformation_25 C_C022_HealthCareCodeInformation_25 {get; set;}
    [XmlElement(Order=1)]
    public C_C022_HealthCareCodeInformation_26 C_C022_HealthCareCodeInformation_26 {get; set;}
    [XmlElement(Order=2)]
    public C_C022_HealthCareCodeInformation_27 C_C022_HealthCareCodeInformation_27 {get; set;}
    [XmlElement(Order=3)]
    public C_C022_HealthCareCodeInformation_28 C_C022_HealthCareCodeInformation_28 {get; set;}
    [XmlElement(Order=4)]
    public C_C022_HealthCareCodeInformation_29 C_C022_HealthCareCodeInformation_29 {get; set;}
    [XmlElement(Order=5)]
    public C_C022_HealthCareCodeInformation_30 C_C022_HealthCareCodeInformation_30 {get; set;}
    [XmlElement(Order=6)]
    public C_C022_HealthCareCodeInformation_31 C_C022_HealthCareCodeInformation_31 {get; set;}
    [XmlElement(Order=7)]
    public C_C022_HealthCareCodeInformation_32 C_C022_HealthCareCodeInformation_32 {get; set;}
    [XmlElement(Order=8)]
    public C_C022_HealthCareCodeInformation_33 C_C022_HealthCareCodeInformation_33 {get; set;}
    [XmlElement(Order=9)]
    public C_C022_HealthCareCodeInformation_34 C_C022_HealthCareCodeInformation_34 {get; set;}
    [XmlElement(Order=10)]
    public C_C022_HealthCareCodeInformation_35 C_C022_HealthCareCodeInformation_35 {get; set;}
    [XmlElement(Order=11)]
    public C_C022_HealthCareCodeInformation_36 C_C022_HealthCareCodeInformation_36 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C022_HealthCareCodeInformation_25 {
    [XmlElement(Order=0)]
    public X12_ID_1270_6 D_C02201_CodeListQualifierCode {get; set;}
    [XmlElement(Order=1)]
    public string D_C02202_ConditionCode {get; set;}
    [XmlElement(Order=2)]
    public string D_C02203_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C02204_DateTimePeriod {get; set;}
    [XmlElement(Order=4)]
    public string D_C02205_MonetaryAmount {get; set;}
    [XmlElement(Order=5)]
    public string D_C02206_Quantity {get; set;}
    [XmlElement(Order=6)]
    public string D_C02207_VersionIdentifier {get; set;}
    [XmlElement(Order=7)]
    public string D_C02208_IndustryCode {get; set;}
    [XmlElement(Order=8)]
    public string D_C02209_Yes_NoConditionorResponseCode {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_1270_6 {
        BG,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C022_HealthCareCodeInformation_26 {
    [XmlElement(Order=0)]
    public X12_ID_1270_6 D_C02201_CodeListQualifierCode {get; set;}
    [XmlElement(Order=1)]
    public string D_C02202_ConditionCode {get; set;}
    [XmlElement(Order=2)]
    public string D_C02203_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C02204_DateTimePeriod {get; set;}
    [XmlElement(Order=4)]
    public string D_C02205_MonetaryAmount {get; set;}
    [XmlElement(Order=5)]
    public string D_C02206_Quantity {get; set;}
    [XmlElement(Order=6)]
    public string D_C02207_VersionIdentifier {get; set;}
    [XmlElement(Order=7)]
    public string D_C02208_IndustryCode {get; set;}
    [XmlElement(Order=8)]
    public string D_C02209_Yes_NoConditionorResponseCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C022_HealthCareCodeInformation_27 {
    [XmlElement(Order=0)]
    public string D_C02201_CodeListQualifierCode {get; set;}
    [XmlElement(Order=1)]
    public string D_C02202_ConditionCode {get; set;}
    [XmlElement(Order=2)]
    public string D_C02203_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C02204_DateTimePeriod {get; set;}
    [XmlElement(Order=4)]
    public string D_C02205_MonetaryAmount {get; set;}
    [XmlElement(Order=5)]
    public string D_C02206_Quantity {get; set;}
    [XmlElement(Order=6)]
    public string D_C02207_VersionIdentifier {get; set;}
    [XmlElement(Order=7)]
    public string D_C02208_IndustryCode {get; set;}
    [XmlElement(Order=8)]
    public string D_C02209_Yes_NoConditionorResponseCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C022_HealthCareCodeInformation_28 {
    [XmlElement(Order=0)]
    public string D_C02201_CodeListQualifierCode {get; set;}
    [XmlElement(Order=1)]
    public string D_C02202_ConditionCode {get; set;}
    [XmlElement(Order=2)]
    public string D_C02203_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C02204_DateTimePeriod {get; set;}
    [XmlElement(Order=4)]
    public string D_C02205_MonetaryAmount {get; set;}
    [XmlElement(Order=5)]
    public string D_C02206_Quantity {get; set;}
    [XmlElement(Order=6)]
    public string D_C02207_VersionIdentifier {get; set;}
    [XmlElement(Order=7)]
    public string D_C02208_IndustryCode {get; set;}
    [XmlElement(Order=8)]
    public string D_C02209_Yes_NoConditionorResponseCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C022_HealthCareCodeInformation_29 {
    [XmlElement(Order=0)]
    public string D_C02201_CodeListQualifierCode {get; set;}
    [XmlElement(Order=1)]
    public string D_C02202_ConditionCode {get; set;}
    [XmlElement(Order=2)]
    public string D_C02203_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C02204_DateTimePeriod {get; set;}
    [XmlElement(Order=4)]
    public string D_C02205_MonetaryAmount {get; set;}
    [XmlElement(Order=5)]
    public string D_C02206_Quantity {get; set;}
    [XmlElement(Order=6)]
    public string D_C02207_VersionIdentifier {get; set;}
    [XmlElement(Order=7)]
    public string D_C02208_IndustryCode {get; set;}
    [XmlElement(Order=8)]
    public string D_C02209_Yes_NoConditionorResponseCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C022_HealthCareCodeInformation_30 {
    [XmlElement(Order=0)]
    public string D_C02201_CodeListQualifierCode {get; set;}
    [XmlElement(Order=1)]
    public string D_C02202_ConditionCode {get; set;}
    [XmlElement(Order=2)]
    public string D_C02203_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C02204_DateTimePeriod {get; set;}
    [XmlElement(Order=4)]
    public string D_C02205_MonetaryAmount {get; set;}
    [XmlElement(Order=5)]
    public string D_C02206_Quantity {get; set;}
    [XmlElement(Order=6)]
    public string D_C02207_VersionIdentifier {get; set;}
    [XmlElement(Order=7)]
    public string D_C02208_IndustryCode {get; set;}
    [XmlElement(Order=8)]
    public string D_C02209_Yes_NoConditionorResponseCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C022_HealthCareCodeInformation_31 {
    [XmlElement(Order=0)]
    public string D_C02201_CodeListQualifierCode {get; set;}
    [XmlElement(Order=1)]
    public string D_C02202_ConditionCode {get; set;}
    [XmlElement(Order=2)]
    public string D_C02203_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C02204_DateTimePeriod {get; set;}
    [XmlElement(Order=4)]
    public string D_C02205_MonetaryAmount {get; set;}
    [XmlElement(Order=5)]
    public string D_C02206_Quantity {get; set;}
    [XmlElement(Order=6)]
    public string D_C02207_VersionIdentifier {get; set;}
    [XmlElement(Order=7)]
    public string D_C02208_IndustryCode {get; set;}
    [XmlElement(Order=8)]
    public string D_C02209_Yes_NoConditionorResponseCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C022_HealthCareCodeInformation_32 {
    [XmlElement(Order=0)]
    public string D_C02201_CodeListQualifierCode {get; set;}
    [XmlElement(Order=1)]
    public string D_C02202_ConditionCode {get; set;}
    [XmlElement(Order=2)]
    public string D_C02203_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C02204_DateTimePeriod {get; set;}
    [XmlElement(Order=4)]
    public string D_C02205_MonetaryAmount {get; set;}
    [XmlElement(Order=5)]
    public string D_C02206_Quantity {get; set;}
    [XmlElement(Order=6)]
    public string D_C02207_VersionIdentifier {get; set;}
    [XmlElement(Order=7)]
    public string D_C02208_IndustryCode {get; set;}
    [XmlElement(Order=8)]
    public string D_C02209_Yes_NoConditionorResponseCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C022_HealthCareCodeInformation_33 {
    [XmlElement(Order=0)]
    public string D_C02201_CodeListQualifierCode {get; set;}
    [XmlElement(Order=1)]
    public string D_C02202_ConditionCode {get; set;}
    [XmlElement(Order=2)]
    public string D_C02203_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C02204_DateTimePeriod {get; set;}
    [XmlElement(Order=4)]
    public string D_C02205_MonetaryAmount {get; set;}
    [XmlElement(Order=5)]
    public string D_C02206_Quantity {get; set;}
    [XmlElement(Order=6)]
    public string D_C02207_VersionIdentifier {get; set;}
    [XmlElement(Order=7)]
    public string D_C02208_IndustryCode {get; set;}
    [XmlElement(Order=8)]
    public string D_C02209_Yes_NoConditionorResponseCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C022_HealthCareCodeInformation_34 {
    [XmlElement(Order=0)]
    public string D_C02201_CodeListQualifierCode {get; set;}
    [XmlElement(Order=1)]
    public string D_C02202_ConditionCode {get; set;}
    [XmlElement(Order=2)]
    public string D_C02203_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C02204_DateTimePeriod {get; set;}
    [XmlElement(Order=4)]
    public string D_C02205_MonetaryAmount {get; set;}
    [XmlElement(Order=5)]
    public string D_C02206_Quantity {get; set;}
    [XmlElement(Order=6)]
    public string D_C02207_VersionIdentifier {get; set;}
    [XmlElement(Order=7)]
    public string D_C02208_IndustryCode {get; set;}
    [XmlElement(Order=8)]
    public string D_C02209_Yes_NoConditionorResponseCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C022_HealthCareCodeInformation_35 {
    [XmlElement(Order=0)]
    public string D_C02201_CodeListQualifierCode {get; set;}
    [XmlElement(Order=1)]
    public string D_C02202_ConditionCode {get; set;}
    [XmlElement(Order=2)]
    public string D_C02203_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C02204_DateTimePeriod {get; set;}
    [XmlElement(Order=4)]
    public string D_C02205_MonetaryAmount {get; set;}
    [XmlElement(Order=5)]
    public string D_C02206_Quantity {get; set;}
    [XmlElement(Order=6)]
    public string D_C02207_VersionIdentifier {get; set;}
    [XmlElement(Order=7)]
    public string D_C02208_IndustryCode {get; set;}
    [XmlElement(Order=8)]
    public string D_C02209_Yes_NoConditionorResponseCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C022_HealthCareCodeInformation_36 {
    [XmlElement(Order=0)]
    public string D_C02201_CodeListQualifierCode {get; set;}
    [XmlElement(Order=1)]
    public string D_C02202_ConditionCode {get; set;}
    [XmlElement(Order=2)]
    public string D_C02203_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C02204_DateTimePeriod {get; set;}
    [XmlElement(Order=4)]
    public string D_C02205_MonetaryAmount {get; set;}
    [XmlElement(Order=5)]
    public string D_C02206_Quantity {get; set;}
    [XmlElement(Order=6)]
    public string D_C02207_VersionIdentifier {get; set;}
    [XmlElement(Order=7)]
    public string D_C02208_IndustryCode {get; set;}
    [XmlElement(Order=8)]
    public string D_C02209_Yes_NoConditionorResponseCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_HCP_ClaimPricing_RepricingInformation {
    [XmlElement(Order=0)]
    public X12_ID_1473 D_HCP01_PricingMethodology {get; set;}
    [XmlElement(Order=1)]
    public string D_HCP02_RepricedAllowedAmount {get; set;}
    [XmlElement(Order=2)]
    public string D_HCP03_RepricedSavingAmount {get; set;}
    [XmlElement(Order=3)]
    public string D_HCP04_RepricingOrganizationIdentifier {get; set;}
    [XmlElement(Order=4)]
    public string D_HCP05_RepricingPerDiemorFlatRateAmount {get; set;}
    [XmlElement(Order=5)]
    public string D_HCP06_RepricedApprovedAmbulatoryPatientGroupCode {get; set;}
    [XmlElement(Order=6)]
    public string D_HCP07_RepricedApprovedAmbulatoryPatientGroupAmount {get; set;}
    [XmlElement(Order=7)]
    public string D_HCP08_Product_ServiceID {get; set;}
    [XmlElement(Order=8)]
    public string D_HCP09_Product_ServiceIDQualifier {get; set;}
    [XmlElement(Order=9)]
    public string D_HCP10_Product_ServiceID {get; set;}
    [XmlElement(Order=10)]
    public string D_HCP11_UnitorBasisforMeasurementCode {get; set;}
    [XmlElement(Order=11)]
    public string D_HCP12_Quantity {get; set;}
    [XmlElement(Order=12)]
    public string D_HCP13_RejectReasonCode {get; set;}
    [XmlElement(Order=13)]
    public string D_HCP14_PolicyComplianceCode {get; set;}
    [XmlElement(Order=14)]
    public string D_HCP15_ExceptionCode {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_1473 {
        [XmlEnum("00")]
        Item00,
        [XmlEnum("01")]
        Item01,
        [XmlEnum("02")]
        Item02,
        [XmlEnum("03")]
        Item03,
        [XmlEnum("04")]
        Item04,
        [XmlEnum("05")]
        Item05,
        [XmlEnum("07")]
        Item07,
        [XmlEnum("08")]
        Item08,
        [XmlEnum("09")]
        Item09,
        [XmlEnum("10")]
        Item10,
        [XmlEnum("11")]
        Item11,
        [XmlEnum("12")]
        Item12,
        [XmlEnum("13")]
        Item13,
        [XmlEnum("14")]
        Item14,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class A_NM1_4 {
    [XmlElement(Order=0)]
    public U_TS837_2310A U_TS837_2310A {get; set;}
    [XmlElementAttribute(Order=1)]
    public G_TS837_2310B G_TS837_2310B {get; set;}
    [XmlElementAttribute(Order=2)]
    public G_TS837_2310C G_TS837_2310C {get; set;}
    [XmlElementAttribute(Order=3)]
    public G_TS837_2310D G_TS837_2310D {get; set;}
    [XmlElementAttribute(Order=4)]
    public G_TS837_2310E G_TS837_2310E {get; set;}
    [XmlElementAttribute(Order=5)]
    public G_TS837_2310F G_TS837_2310F {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_TS837_2310A {
    [XmlElement(Order=0)]
    public S_NM1_ReferringProviderName S_NM1_ReferringProviderName {get; set;}
    [XmlElement("S_REF_ReferringProviderSecondaryIdentification",Order=1)]
    public List<S_REF_ReferringProviderSecondaryIdentification> S_REF_ReferringProviderSecondaryIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_NM1_ReferringProviderName {
    [XmlElement(Order=0)]
    public X12_ID_98_9 D_NM101_EntityIdentifierCode {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1065_3 D_NM102_EntityTypeQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_NM103_ReferringProviderLastName {get; set;}
    [XmlElement(Order=3)]
    public string D_NM104_ReferringProviderFirstName {get; set;}
    [XmlElement(Order=4)]
    public string D_NM105_ReferringProviderMiddleNameorInitial {get; set;}
    [XmlElement(Order=5)]
    public string D_NM106_NamePrefix {get; set;}
    [XmlElement(Order=6)]
    public string D_NM107_ReferringProviderNameSuffix {get; set;}
    [XmlElement(Order=7)]
    public string D_NM108_IdentificationCodeQualifier {get; set;}
    [XmlElement(Order=8)]
    public string D_NM109_ReferringProviderIdentifier {get; set;}
    [XmlElement(Order=9)]
    public string D_NM110_EntityRelationshipCode {get; set;}
    [XmlElement(Order=10)]
    public string D_NM111_EntityIdentifierCode {get; set;}
    [XmlElement(Order=11)]
    public string D_NM112_NameLastorOrganizationName {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_98_9 {
        DN,
        P3,
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_1065_3 {
        [XmlEnum("1")]
        Item1,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_ReferringProviderSecondaryIdentification {
    [XmlElement(Order=0)]
    public X12_ID_128_25 D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_ReferringProviderSecondaryIdentifier {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03_Description {get; set;}
    [XmlElement(Order=3)]
    public C_C040_ReferenceIdentifier_23 C_C040_ReferenceIdentifier_23 {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_128_25 {
        [XmlEnum("0B")]
        Item0B,
        [XmlEnum("1G")]
        Item1G,
        G2,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C040_ReferenceIdentifier_23 {
    [XmlElement(Order=0)]
    public string D_C04001_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C04002_ReferenceIdentification {get; set;}
    [XmlElement(Order=2)]
    public string D_C04003_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C04004_ReferenceIdentification {get; set;}
    [XmlElement(Order=4)]
    public string D_C04005_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_C04006_ReferenceIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_TS837_2310B {
    [XmlElement(Order=0)]
    public S_NM1_RenderingProviderName S_NM1_RenderingProviderName {get; set;}
    [XmlElement(Order=1)]
    public S_PRV_RenderingProviderSpecialtyInformation S_PRV_RenderingProviderSpecialtyInformation {get; set;}
    [XmlElement("S_REF_RenderingProviderSecondaryIdentification",Order=2)]
    public List<S_REF_RenderingProviderSecondaryIdentification> S_REF_RenderingProviderSecondaryIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_NM1_RenderingProviderName {
    [XmlElement(Order=0)]
    public X12_ID_98_10 D_NM101_EntityIdentifierCode {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1065 D_NM102_EntityTypeQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_NM103_RenderingProviderLastorOrganizationName {get; set;}
    [XmlElement(Order=3)]
    public string D_NM104_RenderingProviderFirstName {get; set;}
    [XmlElement(Order=4)]
    public string D_NM105_RenderingProviderMiddleNameorInitial {get; set;}
    [XmlElement(Order=5)]
    public string D_NM106_NamePrefix {get; set;}
    [XmlElement(Order=6)]
    public string D_NM107_RenderingProviderNameSuffix {get; set;}
    [XmlElement(Order=7)]
    public string D_NM108_IdentificationCodeQualifier {get; set;}
    [XmlElement(Order=8)]
    public string D_NM109_RenderingProviderIdentifier {get; set;}
    [XmlElement(Order=9)]
    public string D_NM110_EntityRelationshipCode {get; set;}
    [XmlElement(Order=10)]
    public string D_NM111_EntityIdentifierCode {get; set;}
    [XmlElement(Order=11)]
    public string D_NM112_NameLastorOrganizationName {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_98_10 {
        [XmlEnum("82")]
        Item82,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_PRV_RenderingProviderSpecialtyInformation {
    [XmlElement(Order=0)]
    public X12_ID_1221_2 D_PRV01_ProviderCode {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_128 D_PRV02_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_PRV03_ProviderTaxonomyCode {get; set;}
    [XmlElement(Order=3)]
    public string D_PRV04_StateorProvinceCode {get; set;}
    [XmlElement(Order=4)]
    public C_C035_ProviderSpecialtyInformation_2 C_C035_ProviderSpecialtyInformation_2 {get; set;}
    [XmlElement(Order=5)]
    public string D_PRV06_ProviderOrganizationCode {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_1221_2 {
        PE,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C035_ProviderSpecialtyInformation_2 {
    [XmlElement(Order=0)]
    public string D_C03501_ProviderSpecialtyCode {get; set;}
    [XmlElement(Order=1)]
    public string D_C03502_AgencyQualifierCode {get; set;}
    [XmlElement(Order=2)]
    public string D_C03503_Yes_NoConditionorResponseCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_RenderingProviderSecondaryIdentification {
    [XmlElement(Order=0)]
    public X12_ID_128_26 D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_RenderingProviderSecondaryIdentifier {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03_Description {get; set;}
    [XmlElement(Order=3)]
    public C_C040_ReferenceIdentifier_24 C_C040_ReferenceIdentifier_24 {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_128_26 {
        [XmlEnum("0B")]
        Item0B,
        [XmlEnum("1G")]
        Item1G,
        G2,
        LU,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C040_ReferenceIdentifier_24 {
    [XmlElement(Order=0)]
    public string D_C04001_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C04002_ReferenceIdentification {get; set;}
    [XmlElement(Order=2)]
    public string D_C04003_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C04004_ReferenceIdentification {get; set;}
    [XmlElement(Order=4)]
    public string D_C04005_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_C04006_ReferenceIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_TS837_2310C {
    [XmlElement(Order=0)]
    public S_NM1_ServiceFacilityLocationName S_NM1_ServiceFacilityLocationName {get; set;}
    [XmlElement(Order=1)]
    public S_N3_ServiceFacilityLocationAddress S_N3_ServiceFacilityLocationAddress {get; set;}
    [XmlElement(Order=2)]
    public S_N4_ServiceFacilityLocationCity_State_ZIPCode S_N4_ServiceFacilityLocationCity_State_ZIPCode {get; set;}
    [XmlElement("S_REF_ServiceFacilityLocationSecondaryIdentification",Order=3)]
    public List<S_REF_ServiceFacilityLocationSecondaryIdentification> S_REF_ServiceFacilityLocationSecondaryIdentification {get; set;}
    [XmlElement(Order=4)]
    public S_PER_ServiceFacilityContactInformation S_PER_ServiceFacilityContactInformation {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_NM1_ServiceFacilityLocationName {
    [XmlElement(Order=0)]
    public X12_ID_98_11 D_NM101_EntityIdentifierCode {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1065_2 D_NM102_EntityTypeQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_NM103_LaboratoryorFacilityName {get; set;}
    [XmlElement(Order=3)]
    public string D_NM104_NameFirst {get; set;}
    [XmlElement(Order=4)]
    public string D_NM105_NameMiddle {get; set;}
    [XmlElement(Order=5)]
    public string D_NM106_NamePrefix {get; set;}
    [XmlElement(Order=6)]
    public string D_NM107_NameSuffix {get; set;}
    [XmlElement(Order=7)]
    public string D_NM108_IdentificationCodeQualifier {get; set;}
    [XmlElement(Order=8)]
    public string D_NM109_LaboratoryorFacilityPrimaryIdentifier {get; set;}
    [XmlElement(Order=9)]
    public string D_NM110_EntityRelationshipCode {get; set;}
    [XmlElement(Order=10)]
    public string D_NM111_EntityIdentifierCode {get; set;}
    [XmlElement(Order=11)]
    public string D_NM112_NameLastorOrganizationName {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_98_11 {
        [XmlEnum("77")]
        Item77,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_N3_ServiceFacilityLocationAddress {
    [XmlElement(Order=0)]
    public string D_N301_LaboratoryorFacilityAddressLine {get; set;}
    [XmlElement(Order=1)]
    public string D_N302_LaboratoryorFacilityAddressLine {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_N4_ServiceFacilityLocationCity_State_ZIPCode {
    [XmlElement(Order=0)]
    public string D_N401_LaboratoryorFacilityCityName {get; set;}
    [XmlElement(Order=1)]
    public string D_N402_LaboratoryorFacilityStateorProvinceCode {get; set;}
    [XmlElement(Order=2)]
    public string D_N403_LaboratoryorFacilityPostalZoneorZIPCode {get; set;}
    [XmlElement(Order=3)]
    public string D_N404_CountryCode {get; set;}
    [XmlElement(Order=4)]
    public string D_N405_LocationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_N406_LocationIdentifier {get; set;}
    [XmlElement(Order=6)]
    public string D_N407_CountrySubdivisionCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_ServiceFacilityLocationSecondaryIdentification {
    [XmlElement(Order=0)]
    public X12_ID_128_27 D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_LaboratoryorFacilitySecondaryIdentifier {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03_Description {get; set;}
    [XmlElement(Order=3)]
    public C_C040_ReferenceIdentifier_25 C_C040_ReferenceIdentifier_25 {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_128_27 {
        [XmlEnum("0B")]
        Item0B,
        G2,
        LU,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C040_ReferenceIdentifier_25 {
    [XmlElement(Order=0)]
    public string D_C04001_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C04002_ReferenceIdentification {get; set;}
    [XmlElement(Order=2)]
    public string D_C04003_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C04004_ReferenceIdentification {get; set;}
    [XmlElement(Order=4)]
    public string D_C04005_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_C04006_ReferenceIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_PER_ServiceFacilityContactInformation {
    [XmlElement(Order=0)]
    public X12_ID_366 D_PER01_ContactFunctionCode {get; set;}
    [XmlElement(Order=1)]
    public string D_PER02_Name {get; set;}
    [XmlElement(Order=2)]
    public string D_PER03_CommunicationNumberQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_PER04_CommunicationNumber {get; set;}
    [XmlElement(Order=4)]
    public string D_PER05_CommunicationNumberQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_PER06_CommunicationNumber {get; set;}
    [XmlElement(Order=6)]
    public string D_PER07_CommunicationNumberQualifier {get; set;}
    [XmlElement(Order=7)]
    public string D_PER08_CommunicationNumber {get; set;}
    [XmlElement(Order=8)]
    public string D_PER09_ContactInquiryReference {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_TS837_2310D {
    [XmlElement(Order=0)]
    public S_NM1_SupervisingProviderName S_NM1_SupervisingProviderName {get; set;}
    [XmlElement("S_REF_SupervisingProviderSecondaryIdentification",Order=1)]
    public List<S_REF_SupervisingProviderSecondaryIdentification> S_REF_SupervisingProviderSecondaryIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_NM1_SupervisingProviderName {
    [XmlElement(Order=0)]
    public X12_ID_98_12 D_NM101_EntityIdentifierCode {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1065_3 D_NM102_EntityTypeQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_NM103_SupervisingProviderLastName {get; set;}
    [XmlElement(Order=3)]
    public string D_NM104_SupervisingProviderFirstName {get; set;}
    [XmlElement(Order=4)]
    public string D_NM105_SupervisingProviderMiddleNameorInitial {get; set;}
    [XmlElement(Order=5)]
    public string D_NM106_NamePrefix {get; set;}
    [XmlElement(Order=6)]
    public string D_NM107_SupervisingProviderNameSuffix {get; set;}
    [XmlElement(Order=7)]
    public string D_NM108_IdentificationCodeQualifier {get; set;}
    [XmlElement(Order=8)]
    public string D_NM109_SupervisingProviderIdentifier {get; set;}
    [XmlElement(Order=9)]
    public string D_NM110_EntityRelationshipCode {get; set;}
    [XmlElement(Order=10)]
    public string D_NM111_EntityIdentifierCode {get; set;}
    [XmlElement(Order=11)]
    public string D_NM112_NameLastorOrganizationName {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_98_12 {
        DQ,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_SupervisingProviderSecondaryIdentification {
    [XmlElement(Order=0)]
    public X12_ID_128_26 D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_SupervisingProviderSecondaryIdentifier {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03_Description {get; set;}
    [XmlElement(Order=3)]
    public C_C040_ReferenceIdentifier_26 C_C040_ReferenceIdentifier_26 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C040_ReferenceIdentifier_26 {
    [XmlElement(Order=0)]
    public string D_C04001_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C04002_ReferenceIdentification {get; set;}
    [XmlElement(Order=2)]
    public string D_C04003_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C04004_ReferenceIdentification {get; set;}
    [XmlElement(Order=4)]
    public string D_C04005_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_C04006_ReferenceIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_TS837_2310E {
    [XmlElement(Order=0)]
    public S_NM1_AmbulancePick_upLocation S_NM1_AmbulancePick_upLocation {get; set;}
    [XmlElement(Order=1)]
    public S_N3_AmbulancePick_upLocationAddress S_N3_AmbulancePick_upLocationAddress {get; set;}
    [XmlElement(Order=2)]
    public S_N4_AmbulancePick_upLocationCity_State_ZipCode S_N4_AmbulancePick_upLocationCity_State_ZipCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_NM1_AmbulancePick_upLocation {
    [XmlElement(Order=0)]
    public X12_ID_98_13 D_NM101_EntityIdentifierCode {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1065_2 D_NM102_EntityTypeQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_NM103_NameLastorOrganizationName {get; set;}
    [XmlElement(Order=3)]
    public string D_NM104_NameFirst {get; set;}
    [XmlElement(Order=4)]
    public string D_NM105_NameMiddle {get; set;}
    [XmlElement(Order=5)]
    public string D_NM106_NamePrefix {get; set;}
    [XmlElement(Order=6)]
    public string D_NM107_NameSuffix {get; set;}
    [XmlElement(Order=7)]
    public string D_NM108_IdentificationCodeQualifier {get; set;}
    [XmlElement(Order=8)]
    public string D_NM109_IdentificationCode {get; set;}
    [XmlElement(Order=9)]
    public string D_NM110_EntityRelationshipCode {get; set;}
    [XmlElement(Order=10)]
    public string D_NM111_EntityIdentifierCode {get; set;}
    [XmlElement(Order=11)]
    public string D_NM112_NameLastorOrganizationName {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_98_13 {
        PW,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_N3_AmbulancePick_upLocationAddress {
    [XmlElement(Order=0)]
    public string D_N301_AmbulancePick_upAddressLine {get; set;}
    [XmlElement(Order=1)]
    public string D_N302_AmbulancePick_upAddressLine {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_N4_AmbulancePick_upLocationCity_State_ZipCode {
    [XmlElement(Order=0)]
    public string D_N401_AmbulancePick_upCityName {get; set;}
    [XmlElement(Order=1)]
    public string D_N402_AmbulancePick_upStateorProvinceCode {get; set;}
    [XmlElement(Order=2)]
    public string D_N403_AmbulancePick_upPostalZoneorZIPCode {get; set;}
    [XmlElement(Order=3)]
    public string D_N404_CountryCode {get; set;}
    [XmlElement(Order=4)]
    public string D_N405_LocationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_N406_LocationIdentifier {get; set;}
    [XmlElement(Order=6)]
    public string D_N407_CountrySubdivisionCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_TS837_2310F {
    [XmlElement(Order=0)]
    public S_NM1_AmbulanceDrop_offLocation S_NM1_AmbulanceDrop_offLocation {get; set;}
    [XmlElement(Order=1)]
    public S_N3_AmbulanceDrop_offLocationAddress S_N3_AmbulanceDrop_offLocationAddress {get; set;}
    [XmlElement(Order=2)]
    public S_N4_AmbulanceDrop_offLocationCity_State_ZipCode S_N4_AmbulanceDrop_offLocationCity_State_ZipCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_NM1_AmbulanceDrop_offLocation {
    [XmlElement(Order=0)]
    public X12_ID_98_14 D_NM101_EntityIdentifierCode {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1065_2 D_NM102_EntityTypeQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_NM103_AmbulanceDrop_offLocation {get; set;}
    [XmlElement(Order=3)]
    public string D_NM104_NameFirst {get; set;}
    [XmlElement(Order=4)]
    public string D_NM105_NameMiddle {get; set;}
    [XmlElement(Order=5)]
    public string D_NM106_NamePrefix {get; set;}
    [XmlElement(Order=6)]
    public string D_NM107_NameSuffix {get; set;}
    [XmlElement(Order=7)]
    public string D_NM108_IdentificationCodeQualifier {get; set;}
    [XmlElement(Order=8)]
    public string D_NM109_IdentificationCode {get; set;}
    [XmlElement(Order=9)]
    public string D_NM110_EntityRelationshipCode {get; set;}
    [XmlElement(Order=10)]
    public string D_NM111_EntityIdentifierCode {get; set;}
    [XmlElement(Order=11)]
    public string D_NM112_NameLastorOrganizationName {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_98_14 {
        [XmlEnum("45")]
        Item45,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_N3_AmbulanceDrop_offLocationAddress {
    [XmlElement(Order=0)]
    public string D_N301_AmbulanceDrop_offAddressLine {get; set;}
    [XmlElement(Order=1)]
    public string D_N302_AmbulanceDrop_offAddressLine {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_N4_AmbulanceDrop_offLocationCity_State_ZipCode {
    [XmlElement(Order=0)]
    public string D_N401_AmbulanceDrop_offCityName {get; set;}
    [XmlElement(Order=1)]
    public string D_N402_AmbulanceDrop_offStateorProvinceCode {get; set;}
    [XmlElement(Order=2)]
    public string D_N403_AmbulanceDrop_offPostalZoneorZIPCode {get; set;}
    [XmlElement(Order=3)]
    public string D_N404_CountryCode {get; set;}
    [XmlElement(Order=4)]
    public string D_N405_LocationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_N406_LocationIdentifier {get; set;}
    [XmlElement(Order=6)]
    public string D_N407_CountrySubdivisionCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_TS837_2320 {
    [XmlElement(Order=0)]
    public S_SBR_OtherSubscriberInformation S_SBR_OtherSubscriberInformation {get; set;}
    [XmlElement("S_CAS_ClaimLevelAdjustments",Order=1)]
    public List<S_CAS_ClaimLevelAdjustments> S_CAS_ClaimLevelAdjustments {get; set;}
    [XmlElement(Order=2)]
    public A_AMT A_AMT {get; set;}
    [XmlElement(Order=3)]
    public S_OI_OtherInsuranceCoverageInformation S_OI_OtherInsuranceCoverageInformation {get; set;}
    [XmlElement(Order=4)]
    public S_MOA_OutpatientAdjudicationInformation S_MOA_OutpatientAdjudicationInformation {get; set;}
    [XmlElement(Order=5)]
    public A_NM1_5 A_NM1_5 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_SBR_OtherSubscriberInformation {
    [XmlElement(Order=0)]
    public X12_ID_1138 D_SBR01_PayerResponsibilitySequenceNumberCode {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1069_3 D_SBR02_IndividualRelationshipCode {get; set;}
    [XmlElement(Order=2)]
    public string D_SBR03_InsuredGrouporPolicyNumber {get; set;}
    [XmlElement(Order=3)]
    public string D_SBR04_OtherInsuredGroupName {get; set;}
    [XmlElement(Order=4)]
    public string D_SBR05_InsuranceTypeCode {get; set;}
    [XmlElement(Order=5)]
    public string D_SBR06_CoordinationofBenefitsCode {get; set;}
    [XmlElement(Order=6)]
    public string D_SBR07_Yes_NoConditionorResponseCode {get; set;}
    [XmlElement(Order=7)]
    public string D_SBR08_EmploymentStatusCode {get; set;}
    [XmlElement(Order=8)]
    public string D_SBR09_ClaimFilingIndicatorCode {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_1069_3 {
        [XmlEnum("01")]
        Item01,
        [XmlEnum("18")]
        Item18,
        [XmlEnum("19")]
        Item19,
        [XmlEnum("20")]
        Item20,
        [XmlEnum("21")]
        Item21,
        [XmlEnum("39")]
        Item39,
        [XmlEnum("40")]
        Item40,
        [XmlEnum("53")]
        Item53,
        G8,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_CAS_ClaimLevelAdjustments {
    [XmlElement(Order=0)]
    public X12_ID_1033 D_CAS01_ClaimAdjustmentGroupCode {get; set;}
    [XmlElement(Order=1)]
    public string D_CAS02_AdjustmentReasonCode {get; set;}
    [XmlElement(Order=2)]
    public string D_CAS03_AdjustmentAmount {get; set;}
    [XmlElement(Order=3)]
    public string D_CAS04_AdjustmentQuantity {get; set;}
    [XmlElement(Order=4)]
    public string D_CAS05_AdjustmentReasonCode {get; set;}
    [XmlElement(Order=5)]
    public string D_CAS06_AdjustmentAmount {get; set;}
    [XmlElement(Order=6)]
    public string D_CAS07_AdjustmentQuantity {get; set;}
    [XmlElement(Order=7)]
    public string D_CAS08_AdjustmentReasonCode {get; set;}
    [XmlElement(Order=8)]
    public string D_CAS09_AdjustmentAmount {get; set;}
    [XmlElement(Order=9)]
    public string D_CAS10_AdjustmentQuantity {get; set;}
    [XmlElement(Order=10)]
    public string D_CAS11_AdjustmentReasonCode {get; set;}
    [XmlElement(Order=11)]
    public string D_CAS12_AdjustmentAmount {get; set;}
    [XmlElement(Order=12)]
    public string D_CAS13_AdjustmentQuantity {get; set;}
    [XmlElement(Order=13)]
    public string D_CAS14_AdjustmentReasonCode {get; set;}
    [XmlElement(Order=14)]
    public string D_CAS15_AdjustmentAmount {get; set;}
    [XmlElement(Order=15)]
    public string D_CAS16_AdjustmentQuantity {get; set;}
    [XmlElement(Order=16)]
    public string D_CAS17_AdjustmentReasonCode {get; set;}
    [XmlElement(Order=17)]
    public string D_CAS18_AdjustmentAmount {get; set;}
    [XmlElement(Order=18)]
    public string D_CAS19_AdjustmentQuantity {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_1033 {
        CO,
        CR,
        OA,
        PI,
        PR,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class A_AMT {
    [XmlElementAttribute(Order=0)]
    public S_AMT_CoordinationofBenefits_COB_PayerPaidAmount S_AMT_CoordinationofBenefits_COB_PayerPaidAmount {get; set;}
    [XmlElementAttribute(Order=1)]
    public S_AMT_CoordinationofBenefits_COB_TotalNon_coveredAmount S_AMT_CoordinationofBenefits_COB_TotalNon_coveredAmount {get; set;}
    [XmlElementAttribute(Order=2)]
    public S_AMT_RemainingPatientLiability S_AMT_RemainingPatientLiability {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_AMT_CoordinationofBenefits_COB_PayerPaidAmount {
    [XmlElement(Order=0)]
    public X12_ID_522_2 D_AMT01_AmountQualifierCode {get; set;}
    [XmlElement(Order=1)]
    public string D_AMT02_PayerPaidAmount {get; set;}
    [XmlElement(Order=2)]
    public string D_AMT03_Credit_DebitFlagCode {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_522_2 {
        D,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_AMT_CoordinationofBenefits_COB_TotalNon_coveredAmount {
    [XmlElement(Order=0)]
    public X12_ID_522_3 D_AMT01_AmountQualifierCode {get; set;}
    [XmlElement(Order=1)]
    public string D_AMT02_Non_CoveredChargeAmount {get; set;}
    [XmlElement(Order=2)]
    public string D_AMT03_Credit_DebitFlagCode {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_522_3 {
        A8,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_AMT_RemainingPatientLiability {
    [XmlElement(Order=0)]
    public X12_ID_522_4 D_AMT01_AmountQualifierCode {get; set;}
    [XmlElement(Order=1)]
    public string D_AMT02_RemainingPatientLiability {get; set;}
    [XmlElement(Order=2)]
    public string D_AMT03_Credit_DebitFlagCode {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_522_4 {
        EAF,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_OI_OtherInsuranceCoverageInformation {
    [XmlElement(Order=0)]
    public X12_ID_1032_2 D_OI01_ClaimFilingIndicatorCode {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1383 D_OI02_ClaimSubmissionReasonCode {get; set;}
    [XmlElement(Order=2)]
    public string D_OI03_BenefitsAssignmentCertificationIndicator {get; set;}
    [XmlElement(Order=3)]
    public string D_OI04_PatientSignatureSourceCode {get; set;}
    [XmlElement(Order=4)]
    public string D_OI05_ProviderAgreementCode {get; set;}
    [XmlElement(Order=5)]
    public string D_OI06_ReleaseofInformationCode {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_1032_2 {
        [XmlEnum("01")]
        Item01,
        [XmlEnum("02")]
        Item02,
        [XmlEnum("03")]
        Item03,
        [XmlEnum("04")]
        Item04,
        [XmlEnum("05")]
        Item05,
        [XmlEnum("06")]
        Item06,
        [XmlEnum("07")]
        Item07,
        [XmlEnum("08")]
        Item08,
        [XmlEnum("09")]
        Item09,
        [XmlEnum("10")]
        Item10,
        [XmlEnum("11")]
        Item11,
        [XmlEnum("12")]
        Item12,
        [XmlEnum("13")]
        Item13,
        [XmlEnum("14")]
        Item14,
        [XmlEnum("15")]
        Item15,
        [XmlEnum("16")]
        Item16,
        [XmlEnum("17")]
        Item17,
        [XmlEnum("18")]
        Item18,
        [XmlEnum("19")]
        Item19,
        [XmlEnum("20")]
        Item20,
        [XmlEnum("21")]
        Item21,
        [XmlEnum("22")]
        Item22,
        [XmlEnum("31")]
        Item31,
        [XmlEnum("32")]
        Item32,
        [XmlEnum("33")]
        Item33,
        AM,
        BL,
        CH,
        CI,
        CN,
        DS,
        FI,
        HM,
        LI,
        LM,
        MA,
        MB,
        MC,
        MH,
        OF,
        SA,
        TV,
        VA,
        WB,
        WC,
        WD,
        WE,
        ZZ,
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_1383 {
        [XmlEnum("00")]
        Item00,
        [XmlEnum("01")]
        Item01,
        [XmlEnum("02")]
        Item02,
        [XmlEnum("03")]
        Item03,
        [XmlEnum("05")]
        Item05,
        [XmlEnum("07")]
        Item07,
        [XmlEnum("08")]
        Item08,
        [XmlEnum("09")]
        Item09,
        [XmlEnum("15")]
        Item15,
        [XmlEnum("16")]
        Item16,
        [XmlEnum("17")]
        Item17,
        [XmlEnum("18")]
        Item18,
        [XmlEnum("20")]
        Item20,
        [XmlEnum("22")]
        Item22,
        [XmlEnum("27")]
        Item27,
        [XmlEnum("28")]
        Item28,
        [XmlEnum("29")]
        Item29,
        PB,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_MOA_OutpatientAdjudicationInformation {
    [XmlElement(Order=0)]
    public string D_MOA01_ReimbursementRate {get; set;}
    [XmlElement(Order=1)]
    public string D_MOA02_HCPCSPayableAmount {get; set;}
    [XmlElement(Order=2)]
    public string D_MOA03_ClaimPaymentRemarkCode {get; set;}
    [XmlElement(Order=3)]
    public string D_MOA04_ClaimPaymentRemarkCode {get; set;}
    [XmlElement(Order=4)]
    public string D_MOA05_ClaimPaymentRemarkCode {get; set;}
    [XmlElement(Order=5)]
    public string D_MOA06_ClaimPaymentRemarkCode {get; set;}
    [XmlElement(Order=6)]
    public string D_MOA07_ClaimPaymentRemarkCode {get; set;}
    [XmlElement(Order=7)]
    public string D_MOA08_EndStageRenalDiseasePaymentAmount {get; set;}
    [XmlElement(Order=8)]
    public string D_MOA09_Non_PayableProfessionalComponentBilledAmount {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class A_NM1_5 {
    [XmlElementAttribute(Order=0)]
    public G_TS837_2330A G_TS837_2330A {get; set;}
    [XmlElementAttribute(Order=1)]
    public G_TS837_2330B G_TS837_2330B {get; set;}
    [XmlElement(Order=2)]
    public U_TS837_2330C U_TS837_2330C {get; set;}
    [XmlElementAttribute(Order=3)]
    public G_TS837_2330D G_TS837_2330D {get; set;}
    [XmlElementAttribute(Order=4)]
    public G_TS837_2330E G_TS837_2330E {get; set;}
    [XmlElementAttribute(Order=5)]
    public G_TS837_2330F G_TS837_2330F {get; set;}
    [XmlElementAttribute(Order=6)]
    public G_TS837_2330G G_TS837_2330G {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_TS837_2330A {
    [XmlElement(Order=0)]
    public S_NM1_OtherSubscriberName S_NM1_OtherSubscriberName {get; set;}
    [XmlElement(Order=1)]
    public S_N3_OtherSubscriberAddress S_N3_OtherSubscriberAddress {get; set;}
    [XmlElement(Order=2)]
    public S_N4_OtherSubscriberCity_State_ZIPCode S_N4_OtherSubscriberCity_State_ZIPCode {get; set;}
    [XmlElement(Order=3)]
    public S_REF_OtherSubscriberSecondaryIdentification S_REF_OtherSubscriberSecondaryIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_NM1_OtherSubscriberName {
    [XmlElement(Order=0)]
    public X12_ID_98_7 D_NM101_EntityIdentifierCode {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1065 D_NM102_EntityTypeQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_NM103_OtherInsuredLastName {get; set;}
    [XmlElement(Order=3)]
    public string D_NM104_OtherInsuredFirstName {get; set;}
    [XmlElement(Order=4)]
    public string D_NM105_OtherInsuredMiddleName {get; set;}
    [XmlElement(Order=5)]
    public string D_NM106_NamePrefix {get; set;}
    [XmlElement(Order=6)]
    public string D_NM107_OtherInsuredNameSuffix {get; set;}
    [XmlElement(Order=7)]
    public string D_NM108_IdentificationCodeQualifier {get; set;}
    [XmlElement(Order=8)]
    public string D_NM109_OtherInsuredIdentifier {get; set;}
    [XmlElement(Order=9)]
    public string D_NM110_EntityRelationshipCode {get; set;}
    [XmlElement(Order=10)]
    public string D_NM111_EntityIdentifierCode {get; set;}
    [XmlElement(Order=11)]
    public string D_NM112_NameLastorOrganizationName {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_N3_OtherSubscriberAddress {
    [XmlElement(Order=0)]
    public string D_N301_OtherInsuredAddressLine {get; set;}
    [XmlElement(Order=1)]
    public string D_N302_OtherInsuredAddressLine {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_N4_OtherSubscriberCity_State_ZIPCode {
    [XmlElement(Order=0)]
    public string D_N401_OtherSubscriberCityName {get; set;}
    [XmlElement(Order=1)]
    public string D_N402_OtherSubscriberStateorProvinceCode {get; set;}
    [XmlElement(Order=2)]
    public string D_N403_OtherSubscriberPostalZoneorZIPCode {get; set;}
    [XmlElement(Order=3)]
    public string D_N404_CountryCode {get; set;}
    [XmlElement(Order=4)]
    public string D_N405_LocationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_N406_LocationIdentifier {get; set;}
    [XmlElement(Order=6)]
    public string D_N407_CountrySubdivisionCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_OtherSubscriberSecondaryIdentification {
    [XmlElement(Order=0)]
    public X12_ID_128_7 D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_OtherInsuredAdditionalIdentifier {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03_Description {get; set;}
    [XmlElement(Order=3)]
    public C_C040_ReferenceIdentifier_27 C_C040_ReferenceIdentifier_27 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C040_ReferenceIdentifier_27 {
    [XmlElement(Order=0)]
    public string D_C04001_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C04002_ReferenceIdentification {get; set;}
    [XmlElement(Order=2)]
    public string D_C04003_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C04004_ReferenceIdentification {get; set;}
    [XmlElement(Order=4)]
    public string D_C04005_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_C04006_ReferenceIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_TS837_2330B {
    [XmlElement(Order=0)]
    public S_NM1_OtherPayerName S_NM1_OtherPayerName {get; set;}
    [XmlElement(Order=1)]
    public S_N3_OtherPayerAddress S_N3_OtherPayerAddress {get; set;}
    [XmlElement(Order=2)]
    public S_N4_OtherPayerCity_State_ZIPCode S_N4_OtherPayerCity_State_ZIPCode {get; set;}
    [XmlElement(Order=3)]
    public S_DTP_ClaimCheckorRemittanceDate S_DTP_ClaimCheckorRemittanceDate {get; set;}
    [XmlElement(Order=4)]
    public A_REF_6 A_REF_6 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_NM1_OtherPayerName {
    [XmlElement(Order=0)]
    public X12_ID_98_8 D_NM101_EntityIdentifierCode {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1065_2 D_NM102_EntityTypeQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_NM103_OtherPayerOrganizationName {get; set;}
    [XmlElement(Order=3)]
    public string D_NM104_NameFirst {get; set;}
    [XmlElement(Order=4)]
    public string D_NM105_NameMiddle {get; set;}
    [XmlElement(Order=5)]
    public string D_NM106_NamePrefix {get; set;}
    [XmlElement(Order=6)]
    public string D_NM107_NameSuffix {get; set;}
    [XmlElement(Order=7)]
    public string D_NM108_IdentificationCodeQualifier {get; set;}
    [XmlElement(Order=8)]
    public string D_NM109_OtherPayerPrimaryIdentifier {get; set;}
    [XmlElement(Order=9)]
    public string D_NM110_EntityRelationshipCode {get; set;}
    [XmlElement(Order=10)]
    public string D_NM111_EntityIdentifierCode {get; set;}
    [XmlElement(Order=11)]
    public string D_NM112_NameLastorOrganizationName {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_N3_OtherPayerAddress {
    [XmlElement(Order=0)]
    public string D_N301_OtherPayerAddressLine {get; set;}
    [XmlElement(Order=1)]
    public string D_N302_OtherPayerAddressLine {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_N4_OtherPayerCity_State_ZIPCode {
    [XmlElement(Order=0)]
    public string D_N401_OtherPayerCityName {get; set;}
    [XmlElement(Order=1)]
    public string D_N402_OtherPayerStateorProvinceCode {get; set;}
    [XmlElement(Order=2)]
    public string D_N403_OtherPayerPostalZoneorZIPCode {get; set;}
    [XmlElement(Order=3)]
    public string D_N404_CountryCode {get; set;}
    [XmlElement(Order=4)]
    public string D_N405_LocationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_N406_LocationIdentifier {get; set;}
    [XmlElement(Order=6)]
    public string D_N407_CountrySubdivisionCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_DTP_ClaimCheckorRemittanceDate {
    [XmlElement(Order=0)]
    public X12_ID_374_18 D_DTP01_DateTimeQualifier {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1250 D_DTP02_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_DTP03_AdjudicationorPaymentDate {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_374_18 {
        [XmlEnum("573")]
        Item573,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class A_REF_6 {
    [XmlElement(Order=0)]
    public U_REF_OtherPayerSecondaryIdentifier U_REF_OtherPayerSecondaryIdentifier {get; set;}
    [XmlElementAttribute(Order=1)]
    public S_REF_OtherPayerPriorAuthorizationNumber S_REF_OtherPayerPriorAuthorizationNumber {get; set;}
    [XmlElementAttribute(Order=2)]
    public S_REF_OtherPayerReferralNumber S_REF_OtherPayerReferralNumber {get; set;}
    [XmlElementAttribute(Order=3)]
    public S_REF_OtherPayerClaimAdjustmentIndicator S_REF_OtherPayerClaimAdjustmentIndicator {get; set;}
    [XmlElementAttribute(Order=4)]
    public S_REF_OtherPayerClaimControlNumber S_REF_OtherPayerClaimControlNumber {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_OtherPayerSecondaryIdentifier {
    [XmlElement(Order=0)]
    public X12_ID_128_9 D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_OtherPayerSecondaryIdentifier {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03_Description {get; set;}
    [XmlElement(Order=3)]
    public C_C040_ReferenceIdentifier_28 C_C040_ReferenceIdentifier_28 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C040_ReferenceIdentifier_28 {
    [XmlElement(Order=0)]
    public string D_C04001_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C04002_ReferenceIdentification {get; set;}
    [XmlElement(Order=2)]
    public string D_C04003_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C04004_ReferenceIdentification {get; set;}
    [XmlElement(Order=4)]
    public string D_C04005_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_C04006_ReferenceIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_OtherPayerPriorAuthorizationNumber {
    [XmlElement(Order=0)]
    public X12_ID_128_15 D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_OtherPayerPriorAuthorizationNumber {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03_Description {get; set;}
    [XmlElement(Order=3)]
    public C_C040_ReferenceIdentifier_29 C_C040_ReferenceIdentifier_29 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C040_ReferenceIdentifier_29 {
    [XmlElement(Order=0)]
    public string D_C04001_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C04002_ReferenceIdentification {get; set;}
    [XmlElement(Order=2)]
    public string D_C04003_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C04004_ReferenceIdentification {get; set;}
    [XmlElement(Order=4)]
    public string D_C04005_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_C04006_ReferenceIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_OtherPayerReferralNumber {
    [XmlElement(Order=0)]
    public X12_ID_128_14 D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_OtherPayerPriorAuthorizationorReferralNumber {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03_Description {get; set;}
    [XmlElement(Order=3)]
    public C_C040_ReferenceIdentifier_30 C_C040_ReferenceIdentifier_30 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C040_ReferenceIdentifier_30 {
    [XmlElement(Order=0)]
    public string D_C04001_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C04002_ReferenceIdentification {get; set;}
    [XmlElement(Order=2)]
    public string D_C04003_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C04004_ReferenceIdentification {get; set;}
    [XmlElement(Order=4)]
    public string D_C04005_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_C04006_ReferenceIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_OtherPayerClaimAdjustmentIndicator {
    [XmlElement(Order=0)]
    public X12_ID_128_28 D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_OtherPayerClaimAdjustmentIndicator {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03_Description {get; set;}
    [XmlElement(Order=3)]
    public C_C040_ReferenceIdentifier_31 C_C040_ReferenceIdentifier_31 {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_128_28 {
        T4,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C040_ReferenceIdentifier_31 {
    [XmlElement(Order=0)]
    public string D_C04001_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C04002_ReferenceIdentification {get; set;}
    [XmlElement(Order=2)]
    public string D_C04003_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C04004_ReferenceIdentification {get; set;}
    [XmlElement(Order=4)]
    public string D_C04005_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_C04006_ReferenceIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_OtherPayerClaimControlNumber {
    [XmlElement(Order=0)]
    public X12_ID_128_16 D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_OtherPayer_sClaimControlNumber {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03_Description {get; set;}
    [XmlElement(Order=3)]
    public C_C040_ReferenceIdentifier_32 C_C040_ReferenceIdentifier_32 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C040_ReferenceIdentifier_32 {
    [XmlElement(Order=0)]
    public string D_C04001_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C04002_ReferenceIdentification {get; set;}
    [XmlElement(Order=2)]
    public string D_C04003_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C04004_ReferenceIdentification {get; set;}
    [XmlElement(Order=4)]
    public string D_C04005_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_C04006_ReferenceIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_TS837_2330C {
    [XmlElement(Order=0)]
    public S_NM1_OtherPayerReferringProvider S_NM1_OtherPayerReferringProvider {get; set;}
    [XmlElement("S_REF_OtherPayerReferringProviderSecondaryIdentification",Order=1)]
    public List<S_REF_OtherPayerReferringProviderSecondaryIdentification> S_REF_OtherPayerReferringProviderSecondaryIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_NM1_OtherPayerReferringProvider {
    [XmlElement(Order=0)]
    public X12_ID_98_9 D_NM101_EntityIdentifierCode {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1065_3 D_NM102_EntityTypeQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_NM103_NameLastorOrganizationName {get; set;}
    [XmlElement(Order=3)]
    public string D_NM104_NameFirst {get; set;}
    [XmlElement(Order=4)]
    public string D_NM105_NameMiddle {get; set;}
    [XmlElement(Order=5)]
    public string D_NM106_NamePrefix {get; set;}
    [XmlElement(Order=6)]
    public string D_NM107_NameSuffix {get; set;}
    [XmlElement(Order=7)]
    public string D_NM108_IdentificationCodeQualifier {get; set;}
    [XmlElement(Order=8)]
    public string D_NM109_IdentificationCode {get; set;}
    [XmlElement(Order=9)]
    public string D_NM110_EntityRelationshipCode {get; set;}
    [XmlElement(Order=10)]
    public string D_NM111_EntityIdentifierCode {get; set;}
    [XmlElement(Order=11)]
    public string D_NM112_NameLastorOrganizationName {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_OtherPayerReferringProviderSecondaryIdentification {
    [XmlElement(Order=0)]
    public X12_ID_128_25 D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_OtherPayerReferringProviderIdentifier {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03_Description {get; set;}
    [XmlElement(Order=3)]
    public C_C040_ReferenceIdentifier_33 C_C040_ReferenceIdentifier_33 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C040_ReferenceIdentifier_33 {
    [XmlElement(Order=0)]
    public string D_C04001_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C04002_ReferenceIdentification {get; set;}
    [XmlElement(Order=2)]
    public string D_C04003_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C04004_ReferenceIdentification {get; set;}
    [XmlElement(Order=4)]
    public string D_C04005_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_C04006_ReferenceIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_TS837_2330D {
    [XmlElement(Order=0)]
    public S_NM1_OtherPayerRenderingProvider S_NM1_OtherPayerRenderingProvider {get; set;}
    [XmlElement("S_REF_OtherPayerRenderingProviderSecondaryIdentification",Order=1)]
    public List<S_REF_OtherPayerRenderingProviderSecondaryIdentification> S_REF_OtherPayerRenderingProviderSecondaryIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_NM1_OtherPayerRenderingProvider {
    [XmlElement(Order=0)]
    public X12_ID_98_10 D_NM101_EntityIdentifierCode {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1065 D_NM102_EntityTypeQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_NM103_NameLastorOrganizationName {get; set;}
    [XmlElement(Order=3)]
    public string D_NM104_NameFirst {get; set;}
    [XmlElement(Order=4)]
    public string D_NM105_NameMiddle {get; set;}
    [XmlElement(Order=5)]
    public string D_NM106_NamePrefix {get; set;}
    [XmlElement(Order=6)]
    public string D_NM107_NameSuffix {get; set;}
    [XmlElement(Order=7)]
    public string D_NM108_IdentificationCodeQualifier {get; set;}
    [XmlElement(Order=8)]
    public string D_NM109_IdentificationCode {get; set;}
    [XmlElement(Order=9)]
    public string D_NM110_EntityRelationshipCode {get; set;}
    [XmlElement(Order=10)]
    public string D_NM111_EntityIdentifierCode {get; set;}
    [XmlElement(Order=11)]
    public string D_NM112_NameLastorOrganizationName {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_OtherPayerRenderingProviderSecondaryIdentification {
    [XmlElement(Order=0)]
    public X12_ID_128_26 D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_OtherPayerRenderingProviderSecondaryIdentifier {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03_Description {get; set;}
    [XmlElement(Order=3)]
    public C_C040_ReferenceIdentifier_34 C_C040_ReferenceIdentifier_34 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C040_ReferenceIdentifier_34 {
    [XmlElement(Order=0)]
    public string D_C04001_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C04002_ReferenceIdentification {get; set;}
    [XmlElement(Order=2)]
    public string D_C04003_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C04004_ReferenceIdentification {get; set;}
    [XmlElement(Order=4)]
    public string D_C04005_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_C04006_ReferenceIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_TS837_2330E {
    [XmlElement(Order=0)]
    public S_NM1_OtherPayerServiceFacilityLocation S_NM1_OtherPayerServiceFacilityLocation {get; set;}
    [XmlElement("S_REF_OtherPayerServiceFacilityLocationSecondaryIdentification",Order=1)]
    public List<S_REF_OtherPayerServiceFacilityLocationSecondaryIdentification> S_REF_OtherPayerServiceFacilityLocationSecondaryIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_NM1_OtherPayerServiceFacilityLocation {
    [XmlElement(Order=0)]
    public X12_ID_98_11 D_NM101_EntityIdentifierCode {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1065_2 D_NM102_EntityTypeQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_NM103_NameLastorOrganizationName {get; set;}
    [XmlElement(Order=3)]
    public string D_NM104_NameFirst {get; set;}
    [XmlElement(Order=4)]
    public string D_NM105_NameMiddle {get; set;}
    [XmlElement(Order=5)]
    public string D_NM106_NamePrefix {get; set;}
    [XmlElement(Order=6)]
    public string D_NM107_NameSuffix {get; set;}
    [XmlElement(Order=7)]
    public string D_NM108_IdentificationCodeQualifier {get; set;}
    [XmlElement(Order=8)]
    public string D_NM109_IdentificationCode {get; set;}
    [XmlElement(Order=9)]
    public string D_NM110_EntityRelationshipCode {get; set;}
    [XmlElement(Order=10)]
    public string D_NM111_EntityIdentifierCode {get; set;}
    [XmlElement(Order=11)]
    public string D_NM112_NameLastorOrganizationName {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_OtherPayerServiceFacilityLocationSecondaryIdentification {
    [XmlElement(Order=0)]
    public X12_ID_128_27 D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_OtherPayerServiceFacilityLocationSecondary_Identifier {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03_Description {get; set;}
    [XmlElement(Order=3)]
    public C_C040_ReferenceIdentifier_35 C_C040_ReferenceIdentifier_35 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C040_ReferenceIdentifier_35 {
    [XmlElement(Order=0)]
    public string D_C04001_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C04002_ReferenceIdentification {get; set;}
    [XmlElement(Order=2)]
    public string D_C04003_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C04004_ReferenceIdentification {get; set;}
    [XmlElement(Order=4)]
    public string D_C04005_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_C04006_ReferenceIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_TS837_2330F {
    [XmlElement(Order=0)]
    public S_NM1_OtherPayerSupervisingProvider S_NM1_OtherPayerSupervisingProvider {get; set;}
    [XmlElement("S_REF_OtherPayerSupervisingProviderSecondaryIdentification",Order=1)]
    public List<S_REF_OtherPayerSupervisingProviderSecondaryIdentification> S_REF_OtherPayerSupervisingProviderSecondaryIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_NM1_OtherPayerSupervisingProvider {
    [XmlElement(Order=0)]
    public X12_ID_98_12 D_NM101_EntityIdentifierCode {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1065_3 D_NM102_EntityTypeQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_NM103_NameLastorOrganizationName {get; set;}
    [XmlElement(Order=3)]
    public string D_NM104_NameFirst {get; set;}
    [XmlElement(Order=4)]
    public string D_NM105_NameMiddle {get; set;}
    [XmlElement(Order=5)]
    public string D_NM106_NamePrefix {get; set;}
    [XmlElement(Order=6)]
    public string D_NM107_NameSuffix {get; set;}
    [XmlElement(Order=7)]
    public string D_NM108_IdentificationCodeQualifier {get; set;}
    [XmlElement(Order=8)]
    public string D_NM109_IdentificationCode {get; set;}
    [XmlElement(Order=9)]
    public string D_NM110_EntityRelationshipCode {get; set;}
    [XmlElement(Order=10)]
    public string D_NM111_EntityIdentifierCode {get; set;}
    [XmlElement(Order=11)]
    public string D_NM112_NameLastorOrganizationName {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_OtherPayerSupervisingProviderSecondaryIdentification {
    [XmlElement(Order=0)]
    public X12_ID_128_26 D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_OtherPayerSupervisingProviderIdentifier {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03_Description {get; set;}
    [XmlElement(Order=3)]
    public C_C040_ReferenceIdentifier_36 C_C040_ReferenceIdentifier_36 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C040_ReferenceIdentifier_36 {
    [XmlElement(Order=0)]
    public string D_C04001_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C04002_ReferenceIdentification {get; set;}
    [XmlElement(Order=2)]
    public string D_C04003_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C04004_ReferenceIdentification {get; set;}
    [XmlElement(Order=4)]
    public string D_C04005_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_C04006_ReferenceIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_TS837_2330G {
    [XmlElement(Order=0)]
    public S_NM1_OtherPayerBillingProvider S_NM1_OtherPayerBillingProvider {get; set;}
    [XmlElement("S_REF_OtherPayerBillingProviderSecondaryIdentification",Order=1)]
    public List<S_REF_OtherPayerBillingProviderSecondaryIdentification> S_REF_OtherPayerBillingProviderSecondaryIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_NM1_OtherPayerBillingProvider {
    [XmlElement(Order=0)]
    public X12_ID_98_4 D_NM101_EntityIdentifierCode {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1065 D_NM102_EntityTypeQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_NM103_NameLastorOrganizationName {get; set;}
    [XmlElement(Order=3)]
    public string D_NM104_NameFirst {get; set;}
    [XmlElement(Order=4)]
    public string D_NM105_NameMiddle {get; set;}
    [XmlElement(Order=5)]
    public string D_NM106_NamePrefix {get; set;}
    [XmlElement(Order=6)]
    public string D_NM107_NameSuffix {get; set;}
    [XmlElement(Order=7)]
    public string D_NM108_IdentificationCodeQualifier {get; set;}
    [XmlElement(Order=8)]
    public string D_NM109_IdentificationCode {get; set;}
    [XmlElement(Order=9)]
    public string D_NM110_EntityRelationshipCode {get; set;}
    [XmlElement(Order=10)]
    public string D_NM111_EntityIdentifierCode {get; set;}
    [XmlElement(Order=11)]
    public string D_NM112_NameLastorOrganizationName {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_OtherPayerBillingProviderSecondaryIdentification {
    [XmlElement(Order=0)]
    public X12_ID_128_10 D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_OtherPayerBillingProviderIdentifier {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03_Description {get; set;}
    [XmlElement(Order=3)]
    public C_C040_ReferenceIdentifier_37 C_C040_ReferenceIdentifier_37 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C040_ReferenceIdentifier_37 {
    [XmlElement(Order=0)]
    public string D_C04001_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C04002_ReferenceIdentification {get; set;}
    [XmlElement(Order=2)]
    public string D_C04003_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C04004_ReferenceIdentification {get; set;}
    [XmlElement(Order=4)]
    public string D_C04005_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_C04006_ReferenceIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_TS837_2400 {
    [XmlElement(Order=0)]
    public S_LX_ServiceLineNumber S_LX_ServiceLineNumber {get; set;}
    [XmlElement(Order=1)]
    public S_SV1_ProfessionalService S_SV1_ProfessionalService {get; set;}
    [XmlElement(Order=2)]
    public S_SV5_DurableMedicalEquipmentService S_SV5_DurableMedicalEquipmentService {get; set;}
    [XmlElement(Order=3)]
    public A_PWK A_PWK {get; set;}
    [XmlElement(Order=4)]
    public S_CR1_AmbulanceTransportInformation_2 S_CR1_AmbulanceTransportInformation_2 {get; set;}
    [XmlElement(Order=5)]
    public S_CR3_DurableMedicalEquipmentCertification S_CR3_DurableMedicalEquipmentCertification {get; set;}
    [XmlElement(Order=6)]
    public A_CRC_2 A_CRC_2 {get; set;}
    [XmlElement(Order=7)]
    public A_DTP_2 A_DTP_2 {get; set;}
    [XmlElement(Order=8)]
    public A_QTY A_QTY {get; set;}
    [XmlElement("S_MEA_TestResult",Order=9)]
    public List<S_MEA_TestResult> S_MEA_TestResult {get; set;}
    [XmlElement(Order=10)]
    public S_CN1_ContractInformation_2 S_CN1_ContractInformation_2 {get; set;}
    [XmlElement(Order=11)]
    public A_REF_7 A_REF_7 {get; set;}
    [XmlElement(Order=12)]
    public A_AMT_2 A_AMT_2 {get; set;}
    [XmlElement("S_K3_FileInformation_2",Order=13)]
    public List<S_K3_FileInformation_2> S_K3_FileInformation_2 {get; set;}
    [XmlElement(Order=14)]
    public A_NTE A_NTE {get; set;}
    [XmlElement(Order=15)]
    public S_PS1_PurchasedServiceInformation S_PS1_PurchasedServiceInformation {get; set;}
    [XmlElement(Order=16)]
    public S_HCP_LinePricing_RepricingInformation S_HCP_LinePricing_RepricingInformation {get; set;}
    [XmlElement(Order=17)]
    public G_TS837_2410 G_TS837_2410 {get; set;}
    [XmlElement(Order=18)]
    public A_NM1_6 A_NM1_6 {get; set;}
    [XmlElement("G_TS837_2430",Order=19)]
    public List<G_TS837_2430> G_TS837_2430 {get; set;}
    [XmlElement("G_TS837_2440",Order=20)]
    public List<G_TS837_2440> G_TS837_2440 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_LX_ServiceLineNumber {
    [XmlElement(Order=0)]
    public string D_LX01_AssignedNumber {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_SV1_ProfessionalService {
    [XmlElement(Order=0)]
    public C_C003_CompositeMedicalProcedureIdentifier C_C003_CompositeMedicalProcedureIdentifier {get; set;}
    [XmlElement(Order=1)]
    public string D_SV102_LineItemChargeAmount {get; set;}
    [XmlElement(Order=2)]
    public string D_SV103_UnitorBasisforMeasurementCode {get; set;}
    [XmlElement(Order=3)]
    public string D_SV104_ServiceUnitCount {get; set;}
    [XmlElement(Order=4)]
    public string D_SV105_PlaceofServiceCode {get; set;}
    [XmlElement(Order=5)]
    public string D_SV106_ServiceTypeCode {get; set;}
    [XmlElement(Order=6)]
    public C_C004_CompositeDiagnosisCodePointer C_C004_CompositeDiagnosisCodePointer {get; set;}
    [XmlElement(Order=7)]
    public string D_SV108_MonetaryAmount {get; set;}
    [XmlElement(Order=8)]
    public string D_SV109_EmergencyIndicator {get; set;}
    [XmlElement(Order=9)]
    public string D_SV110_MultipleProcedureCode {get; set;}
    [XmlElement(Order=10)]
    public string D_SV111_EPSDTIndicator {get; set;}
    [XmlElement(Order=11)]
    public string D_SV112_FamilyPlanningIndicator {get; set;}
    [XmlElement(Order=12)]
    public string D_SV113_ReviewCode {get; set;}
    [XmlElement(Order=13)]
    public string D_SV114_NationalorLocalAssignedReviewValue {get; set;}
    [XmlElement(Order=14)]
    public string D_SV115_Co_PayStatusCode {get; set;}
    [XmlElement(Order=15)]
    public string D_SV116_HealthCareProfessionalShortageAreaCode {get; set;}
    [XmlElement(Order=16)]
    public string D_SV117_ReferenceIdentification {get; set;}
    [XmlElement(Order=17)]
    public string D_SV118_PostalCode {get; set;}
    [XmlElement(Order=18)]
    public string D_SV119_MonetaryAmount {get; set;}
    [XmlElement(Order=19)]
    public string D_SV120_LevelofCareCode {get; set;}
    [XmlElement(Order=20)]
    public string D_SV121_ProviderAgreementCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C003_CompositeMedicalProcedureIdentifier {
    [XmlElement(Order=0)]
    public X12_ID_235_2 D_C00301_ProductorServiceIDQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C00302_ProcedureCode {get; set;}
    [XmlElement(Order=2)]
    public string D_C00303_ProcedureModifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C00304_ProcedureModifier {get; set;}
    [XmlElement(Order=4)]
    public string D_C00305_ProcedureModifier {get; set;}
    [XmlElement(Order=5)]
    public string D_C00306_ProcedureModifier {get; set;}
    [XmlElement(Order=6)]
    public string D_C00307_Description {get; set;}
    [XmlElement(Order=7)]
    public string D_C00308_Product_ServiceID {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_235_2 {
        ER,
        HC,
        IV,
        WK,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C004_CompositeDiagnosisCodePointer {
    [XmlElement(Order=0)]
    public string D_C00401_DiagnosisCodePointer {get; set;}
    [XmlElement(Order=1)]
    public string D_C00402_DiagnosisCodePointer {get; set;}
    [XmlElement(Order=2)]
    public string D_C00403_DiagnosisCodePointer {get; set;}
    [XmlElement(Order=3)]
    public string D_C00404_DiagnosisCodePointer {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_SV5_DurableMedicalEquipmentService {
    [XmlElement(Order=0)]
    public C_C003_CompositeMedicalProcedureIdentifier_2 C_C003_CompositeMedicalProcedureIdentifier_2 {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_355_6 D_SV502_UnitorBasisforMeasurementCode {get; set;}
    [XmlElement(Order=2)]
    public string D_SV503_LengthofMedicalNecessity {get; set;}
    [XmlElement(Order=3)]
    public string D_SV504_DMERentalPrice {get; set;}
    [XmlElement(Order=4)]
    public string D_SV505_DMEPurchasePrice {get; set;}
    [XmlElement(Order=5)]
    public string D_SV506_RentalUnitPriceIndicator {get; set;}
    [XmlElement(Order=6)]
    public string D_SV507_PrognosisCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C003_CompositeMedicalProcedureIdentifier_2 {
    [XmlElement(Order=0)]
    public X12_ID_235_3 D_C00301_ProcedureIdentifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C00302_ProcedureCode {get; set;}
    [XmlElement(Order=2)]
    public string D_C00303_ProcedureModifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C00304_ProcedureModifier {get; set;}
    [XmlElement(Order=4)]
    public string D_C00305_ProcedureModifier {get; set;}
    [XmlElement(Order=5)]
    public string D_C00306_ProcedureModifier {get; set;}
    [XmlElement(Order=6)]
    public string D_C00307_Description {get; set;}
    [XmlElement(Order=7)]
    public string D_C00308_Product_ServiceID {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_235_3 {
        HC,
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_355_6 {
        DA,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class A_PWK {
    [XmlElement(Order=0)]
    public U_PWK_LineSupplementalInformation U_PWK_LineSupplementalInformation {get; set;}
    [XmlElementAttribute(Order=1)]
    public S_PWK_DurableMedicalEquipmentCertificateofMedicalNecessityIndicator S_PWK_DurableMedicalEquipmentCertificateofMedicalNecessityIndicator {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_PWK_LineSupplementalInformation {
    [XmlElement(Order=0)]
    public X12_ID_755_2 D_PWK01_AttachmentReportTypeCode {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_756 D_PWK02_AttachmentTransmissionCode {get; set;}
    [XmlElement(Order=2)]
    public string D_PWK03_ReportCopiesNeeded {get; set;}
    [XmlElement(Order=3)]
    public string D_PWK04_EntityIdentifierCode {get; set;}
    [XmlElement(Order=4)]
    public string D_PWK05_IdentificationCodeQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_PWK06_AttachmentControlNumber {get; set;}
    [XmlElement(Order=6)]
    public string D_PWK07_Description {get; set;}
    [XmlElement(Order=7)]
    public C_C002_ActionsIndicated_2 C_C002_ActionsIndicated_2 {get; set;}
    [XmlElement(Order=8)]
    public string D_PWK09_RequestCategoryCode {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_755_2 {
        [XmlEnum("03")]
        Item03,
        [XmlEnum("04")]
        Item04,
        [XmlEnum("05")]
        Item05,
        [XmlEnum("06")]
        Item06,
        [XmlEnum("07")]
        Item07,
        [XmlEnum("08")]
        Item08,
        [XmlEnum("09")]
        Item09,
        [XmlEnum("10")]
        Item10,
        [XmlEnum("11")]
        Item11,
        [XmlEnum("13")]
        Item13,
        [XmlEnum("15")]
        Item15,
        [XmlEnum("21")]
        Item21,
        A3,
        A4,
        AM,
        AS,
        B2,
        B3,
        B4,
        BR,
        BS,
        BT,
        CB,
        CK,
        CT,
        D2,
        DA,
        DB,
        DG,
        DJ,
        DS,
        EB,
        HC,
        HR,
        I5,
        IR,
        LA,
        M1,
        MT,
        NN,
        OB,
        OC,
        OD,
        OE,
        OX,
        OZ,
        P4,
        P5,
        PE,
        PN,
        PO,
        PQ,
        PY,
        PZ,
        RB,
        RR,
        RT,
        RX,
        SG,
        V5,
        XP,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C002_ActionsIndicated_2 {
    [XmlElement(Order=0)]
    public string D_C00201_Paperwork_ReportActionCode {get; set;}
    [XmlElement(Order=1)]
    public string D_C00202_Paperwork_ReportActionCode {get; set;}
    [XmlElement(Order=2)]
    public string D_C00203_Paperwork_ReportActionCode {get; set;}
    [XmlElement(Order=3)]
    public string D_C00204_Paperwork_ReportActionCode {get; set;}
    [XmlElement(Order=4)]
    public string D_C00205_Paperwork_ReportActionCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_PWK_DurableMedicalEquipmentCertificateofMedicalNecessityIndicator {
    [XmlElement(Order=0)]
    public X12_ID_755_3 D_PWK01_AttachmentReportTypeCode {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_756_2 D_PWK02_AttachmentTransmissionCode {get; set;}
    [XmlElement(Order=2)]
    public string D_PWK03_ReportCopiesNeeded {get; set;}
    [XmlElement(Order=3)]
    public string D_PWK04_EntityIdentifierCode {get; set;}
    [XmlElement(Order=4)]
    public string D_PWK05_IdentificationCodeQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_PWK06_IdentificationCode {get; set;}
    [XmlElement(Order=6)]
    public string D_PWK07_Description {get; set;}
    [XmlElement(Order=7)]
    public C_C002_ActionsIndicated_3 C_C002_ActionsIndicated_3 {get; set;}
    [XmlElement(Order=8)]
    public string D_PWK09_RequestCategoryCode {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_755_3 {
        CT,
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_756_2 {
        AB,
        AD,
        AF,
        AG,
        NS,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C002_ActionsIndicated_3 {
    [XmlElement(Order=0)]
    public string D_C00201_Paperwork_ReportActionCode {get; set;}
    [XmlElement(Order=1)]
    public string D_C00202_Paperwork_ReportActionCode {get; set;}
    [XmlElement(Order=2)]
    public string D_C00203_Paperwork_ReportActionCode {get; set;}
    [XmlElement(Order=3)]
    public string D_C00204_Paperwork_ReportActionCode {get; set;}
    [XmlElement(Order=4)]
    public string D_C00205_Paperwork_ReportActionCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_CR1_AmbulanceTransportInformation_2 {
    [XmlElement(Order=0)]
    public X12_ID_355_3 D_CR101_UnitorBasisforMeasurementCode {get; set;}
    [XmlElement(Order=1)]
    public string D_CR102_PatientWeight {get; set;}
    [XmlElement(Order=2)]
    public string D_CR103_AmbulanceTransportCode {get; set;}
    [XmlElement(Order=3)]
    public string D_CR104_AmbulanceTransportReasonCode {get; set;}
    [XmlElement(Order=4)]
    public string D_CR105_UnitorBasisforMeasurementCode {get; set;}
    [XmlElement(Order=5)]
    public string D_CR106_TransportDistance {get; set;}
    [XmlElement(Order=6)]
    public string D_CR107_AddressInformation {get; set;}
    [XmlElement(Order=7)]
    public string D_CR108_AddressInformation {get; set;}
    [XmlElement(Order=8)]
    public string D_CR109_RoundTripPurposeDescription {get; set;}
    [XmlElement(Order=9)]
    public string D_CR110_StretcherPurposeDescription {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_CR3_DurableMedicalEquipmentCertification {
    [XmlElement(Order=0)]
    public X12_ID_1322 D_CR301_CertificationTypeCode {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_355_7 D_CR302_UnitorBasisforMeasurementCode {get; set;}
    [XmlElement(Order=2)]
    public string D_CR303_DurableMedicalEquipmentDuration {get; set;}
    [XmlElement(Order=3)]
    public string D_CR304_InsulinDependentCode {get; set;}
    [XmlElement(Order=4)]
    public string D_CR305_Description {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_1322 {
        I,
        R,
        S,
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_355_7 {
        MO,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class A_CRC_2 {
    [XmlElement(Order=0)]
    public U_CRC_AmbulanceCertification_2 U_CRC_AmbulanceCertification_2 {get; set;}
    [XmlElementAttribute(Order=1)]
    public S_CRC_HospiceEmployeeIndicator S_CRC_HospiceEmployeeIndicator {get; set;}
    [XmlElementAttribute(Order=2)]
    public S_CRC_ConditionIndicator_DurableMedicalEquipment S_CRC_ConditionIndicator_DurableMedicalEquipment {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_CRC_AmbulanceCertification_2 {
    [XmlElement(Order=0)]
    public X12_ID_1136 D_CRC01_CodeCategory {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1073_3 D_CRC02_CertificationConditionIndicator {get; set;}
    [XmlElement(Order=2)]
    public string D_CRC03_ConditionCode {get; set;}
    [XmlElement(Order=3)]
    public string D_CRC04_ConditionCode {get; set;}
    [XmlElement(Order=4)]
    public string D_CRC05_ConditionCode {get; set;}
    [XmlElement(Order=5)]
    public string D_CRC06_ConditionCode {get; set;}
    [XmlElement(Order=6)]
    public string D_CRC07_ConditionCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_CRC_HospiceEmployeeIndicator {
    [XmlElement(Order=0)]
    public X12_ID_1136_5 D_CRC01_CodeCategory {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1073_3 D_CRC02_HospiceEmployedProviderIndicator {get; set;}
    [XmlElement(Order=2)]
    public string D_CRC03_ConditionIndicator {get; set;}
    [XmlElement(Order=3)]
    public string D_CRC04_ConditionIndicator {get; set;}
    [XmlElement(Order=4)]
    public string D_CRC05_ConditionIndicator {get; set;}
    [XmlElement(Order=5)]
    public string D_CRC06_ConditionIndicator {get; set;}
    [XmlElement(Order=6)]
    public string D_CRC07_ConditionIndicator {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_1136_5 {
        [XmlEnum("70")]
        Item70,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_CRC_ConditionIndicator_DurableMedicalEquipment {
    [XmlElement(Order=0)]
    public X12_ID_1136_6 D_CRC01_CodeCategory {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1073_3 D_CRC02_CertificationConditionIndicator {get; set;}
    [XmlElement(Order=2)]
    public string D_CRC03_ConditionIndicator {get; set;}
    [XmlElement(Order=3)]
    public string D_CRC04_ConditionIndicator {get; set;}
    [XmlElement(Order=4)]
    public string D_CRC05_ConditionIndicator {get; set;}
    [XmlElement(Order=5)]
    public string D_CRC06_ConditionIndicator {get; set;}
    [XmlElement(Order=6)]
    public string D_CRC07_ConditionIndicator {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_1136_6 {
        [XmlEnum("09")]
        Item09,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class A_DTP_2 {
    [XmlElementAttribute(Order=0)]
    public S_DTP_Date_ServiceDate S_DTP_Date_ServiceDate {get; set;}
    [XmlElementAttribute(Order=1)]
    public S_DTP_Date_PrescriptionDate S_DTP_Date_PrescriptionDate {get; set;}
    [XmlElementAttribute(Order=2)]
    public S_DTP_DATE_CertificationRevision_RecertificationDate S_DTP_DATE_CertificationRevision_RecertificationDate {get; set;}
    [XmlElementAttribute(Order=3)]
    public S_DTP_Date_BeginTherapyDate S_DTP_Date_BeginTherapyDate {get; set;}
    [XmlElementAttribute(Order=4)]
    public S_DTP_Date_LastCertificationDate S_DTP_Date_LastCertificationDate {get; set;}
    [XmlElementAttribute(Order=5)]
    public S_DTP_Date_LastSeenDate_2 S_DTP_Date_LastSeenDate_2 {get; set;}
    [XmlElement(Order=6)]
    public U_DTP_Date_TestDate U_DTP_Date_TestDate {get; set;}
    [XmlElementAttribute(Order=7)]
    public S_DTP_Date_ShippedDate S_DTP_Date_ShippedDate {get; set;}
    [XmlElementAttribute(Order=8)]
    public S_DTP_Date_LastX_rayDate_2 S_DTP_Date_LastX_rayDate_2 {get; set;}
    [XmlElementAttribute(Order=9)]
    public S_DTP_Date_InitialTreatmentDate_2 S_DTP_Date_InitialTreatmentDate_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_DTP_Date_ServiceDate {
    [XmlElement(Order=0)]
    public X12_ID_374_19 D_DTP01_DateTimeQualifier {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1250_2 D_DTP02_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_DTP03_ServiceDate {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_374_19 {
        [XmlEnum("472")]
        Item472,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_DTP_Date_PrescriptionDate {
    [XmlElement(Order=0)]
    public X12_ID_374_9 D_DTP01_DateTimeQualifier {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1250 D_DTP02_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_DTP03_PrescriptionDate {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_DTP_DATE_CertificationRevision_RecertificationDate {
    [XmlElement(Order=0)]
    public X12_ID_374_20 D_DTP01_DateTimeQualifier {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1250 D_DTP02_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_DTP03_CertificationRevisionorRecertificationDate {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_374_20 {
        [XmlEnum("607")]
        Item607,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_DTP_Date_BeginTherapyDate {
    [XmlElement(Order=0)]
    public X12_ID_374_21 D_DTP01_DateTimeQualifier {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1250 D_DTP02_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_DTP03_BeginTherapyDate {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_374_21 {
        [XmlEnum("463")]
        Item463,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_DTP_Date_LastCertificationDate {
    [XmlElement(Order=0)]
    public X12_ID_374_22 D_DTP01_DateTimeQualifier {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1250 D_DTP02_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_DTP03_LastCertificationDate {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_374_22 {
        [XmlEnum("461")]
        Item461,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_DTP_Date_LastSeenDate_2 {
    [XmlElement(Order=0)]
    public X12_ID_374_4 D_DTP01_DateTimeQualifier {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1250 D_DTP02_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_DTP03_TreatmentorTherapyDate {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_DTP_Date_TestDate {
    [XmlElement(Order=0)]
    public X12_ID_374_23 D_DTP01_DateTimeQualifier {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1250 D_DTP02_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_DTP03_TestPerformedDate {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_374_23 {
        [XmlEnum("738")]
        Item738,
        [XmlEnum("739")]
        Item739,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_DTP_Date_ShippedDate {
    [XmlElement(Order=0)]
    public X12_ID_374_24 D_DTP01_DateTimeQualifier {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1250 D_DTP02_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_DTP03_ShippedDate {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_374_24 {
        [XmlEnum("011")]
        Item011,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_DTP_Date_LastX_rayDate_2 {
    [XmlElement(Order=0)]
    public X12_ID_374_8 D_DTP01_DateTimeQualifier {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1250 D_DTP02_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_DTP03_LastX_RayDate {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_DTP_Date_InitialTreatmentDate_2 {
    [XmlElement(Order=0)]
    public X12_ID_374_3 D_DTP01_DateTimeQualifier {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1250 D_DTP02_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_DTP03_InitialTreatmentDate {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class A_QTY {
    [XmlElementAttribute(Order=0)]
    public S_QTY_AmbulancePatientCount S_QTY_AmbulancePatientCount {get; set;}
    [XmlElementAttribute(Order=1)]
    public S_QTY_ObstetricAnesthesiaAdditionalUnits S_QTY_ObstetricAnesthesiaAdditionalUnits {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_QTY_AmbulancePatientCount {
    [XmlElement(Order=0)]
    public X12_ID_673 D_QTY01_QuantityQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_QTY02_AmbulancePatientCount {get; set;}
    [XmlElement(Order=2)]
    public C_C001_CompositeUnitofMeasure_2 C_C001_CompositeUnitofMeasure_2 {get; set;}
    [XmlElement(Order=3)]
    public string D_QTY04_Free_formInformation {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_673 {
        PT,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C001_CompositeUnitofMeasure_2 {
    [XmlElement(Order=0)]
    public string D_C00101_UnitorBasisforMeasurementCode {get; set;}
    [XmlElement(Order=1)]
    public string D_C00102_Exponent {get; set;}
    [XmlElement(Order=2)]
    public string D_C00103_Multiplier {get; set;}
    [XmlElement(Order=3)]
    public string D_C00104_UnitorBasisforMeasurementCode {get; set;}
    [XmlElement(Order=4)]
    public string D_C00105_Exponent {get; set;}
    [XmlElement(Order=5)]
    public string D_C00106_Multiplier {get; set;}
    [XmlElement(Order=6)]
    public string D_C00107_UnitorBasisforMeasurementCode {get; set;}
    [XmlElement(Order=7)]
    public string D_C00108_Exponent {get; set;}
    [XmlElement(Order=8)]
    public string D_C00109_Multiplier {get; set;}
    [XmlElement(Order=9)]
    public string D_C00110_UnitorBasisforMeasurementCode {get; set;}
    [XmlElement(Order=10)]
    public string D_C00111_Exponent {get; set;}
    [XmlElement(Order=11)]
    public string D_C00112_Multiplier {get; set;}
    [XmlElement(Order=12)]
    public string D_C00113_UnitorBasisforMeasurementCode {get; set;}
    [XmlElement(Order=13)]
    public string D_C00114_Exponent {get; set;}
    [XmlElement(Order=14)]
    public string D_C00115_Multiplier {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_QTY_ObstetricAnesthesiaAdditionalUnits {
    [XmlElement(Order=0)]
    public X12_ID_673_2 D_QTY01_QuantityQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_QTY02_ObstetricAdditionalUnits {get; set;}
    [XmlElement(Order=2)]
    public C_C001_CompositeUnitofMeasure_3 C_C001_CompositeUnitofMeasure_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_QTY04_Free_formInformation {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_673_2 {
        FL,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C001_CompositeUnitofMeasure_3 {
    [XmlElement(Order=0)]
    public string D_C00101_UnitorBasisforMeasurementCode {get; set;}
    [XmlElement(Order=1)]
    public string D_C00102_Exponent {get; set;}
    [XmlElement(Order=2)]
    public string D_C00103_Multiplier {get; set;}
    [XmlElement(Order=3)]
    public string D_C00104_UnitorBasisforMeasurementCode {get; set;}
    [XmlElement(Order=4)]
    public string D_C00105_Exponent {get; set;}
    [XmlElement(Order=5)]
    public string D_C00106_Multiplier {get; set;}
    [XmlElement(Order=6)]
    public string D_C00107_UnitorBasisforMeasurementCode {get; set;}
    [XmlElement(Order=7)]
    public string D_C00108_Exponent {get; set;}
    [XmlElement(Order=8)]
    public string D_C00109_Multiplier {get; set;}
    [XmlElement(Order=9)]
    public string D_C00110_UnitorBasisforMeasurementCode {get; set;}
    [XmlElement(Order=10)]
    public string D_C00111_Exponent {get; set;}
    [XmlElement(Order=11)]
    public string D_C00112_Multiplier {get; set;}
    [XmlElement(Order=12)]
    public string D_C00113_UnitorBasisforMeasurementCode {get; set;}
    [XmlElement(Order=13)]
    public string D_C00114_Exponent {get; set;}
    [XmlElement(Order=14)]
    public string D_C00115_Multiplier {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_MEA_TestResult {
    [XmlElement(Order=0)]
    public X12_ID_737 D_MEA01_MeasurementReferenceIdentificationCode {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_738 D_MEA02_MeasurementQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_MEA03_TestResults {get; set;}
    [XmlElement(Order=3)]
    public C_C001_CompositeUnitofMeasure_4 C_C001_CompositeUnitofMeasure_4 {get; set;}
    [XmlElement(Order=4)]
    public string D_MEA05_RangeMinimum {get; set;}
    [XmlElement(Order=5)]
    public string D_MEA06_RangeMaximum {get; set;}
    [XmlElement(Order=6)]
    public string D_MEA07_MeasurementSignificanceCode {get; set;}
    [XmlElement(Order=7)]
    public string D_MEA08_MeasurementAttributeCode {get; set;}
    [XmlElement(Order=8)]
    public string D_MEA09_Surface_Layer_PositionCode {get; set;}
    [XmlElement(Order=9)]
    public string D_MEA10_MeasurementMethodorDevice {get; set;}
    [XmlElement(Order=10)]
    public string D_MEA11_CodeListQualifierCode {get; set;}
    [XmlElement(Order=11)]
    public string D_MEA12_IndustryCode {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_737 {
        OG,
        TR,
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_738 {
        HT,
        R1,
        R2,
        R3,
        R4,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C001_CompositeUnitofMeasure_4 {
    [XmlElement(Order=0)]
    public string D_C00101_UnitorBasisforMeasurementCode {get; set;}
    [XmlElement(Order=1)]
    public string D_C00102_Exponent {get; set;}
    [XmlElement(Order=2)]
    public string D_C00103_Multiplier {get; set;}
    [XmlElement(Order=3)]
    public string D_C00104_UnitorBasisforMeasurementCode {get; set;}
    [XmlElement(Order=4)]
    public string D_C00105_Exponent {get; set;}
    [XmlElement(Order=5)]
    public string D_C00106_Multiplier {get; set;}
    [XmlElement(Order=6)]
    public string D_C00107_UnitorBasisforMeasurementCode {get; set;}
    [XmlElement(Order=7)]
    public string D_C00108_Exponent {get; set;}
    [XmlElement(Order=8)]
    public string D_C00109_Multiplier {get; set;}
    [XmlElement(Order=9)]
    public string D_C00110_UnitorBasisforMeasurementCode {get; set;}
    [XmlElement(Order=10)]
    public string D_C00111_Exponent {get; set;}
    [XmlElement(Order=11)]
    public string D_C00112_Multiplier {get; set;}
    [XmlElement(Order=12)]
    public string D_C00113_UnitorBasisforMeasurementCode {get; set;}
    [XmlElement(Order=13)]
    public string D_C00114_Exponent {get; set;}
    [XmlElement(Order=14)]
    public string D_C00115_Multiplier {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_CN1_ContractInformation_2 {
    [XmlElement(Order=0)]
    public X12_ID_1166 D_CN101_ContractTypeCode {get; set;}
    [XmlElement(Order=1)]
    public string D_CN102_ContractAmount {get; set;}
    [XmlElement(Order=2)]
    public string D_CN103_ContractPercentage {get; set;}
    [XmlElement(Order=3)]
    public string D_CN104_ContractCode {get; set;}
    [XmlElement(Order=4)]
    public string D_CN105_TermsDiscountPercentage {get; set;}
    [XmlElement(Order=5)]
    public string D_CN106_ContractVersionIdentifier {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class A_REF_7 {
    [XmlElementAttribute(Order=0)]
    public S_REF_RepricedLineItemReferenceNumber S_REF_RepricedLineItemReferenceNumber {get; set;}
    [XmlElementAttribute(Order=1)]
    public S_REF_AdjustedRepricedLineItemReferenceNumber S_REF_AdjustedRepricedLineItemReferenceNumber {get; set;}
    [XmlElement(Order=2)]
    public U_REF_PriorAuthorization_2 U_REF_PriorAuthorization_2 {get; set;}
    [XmlElementAttribute(Order=3)]
    public S_REF_LineItemControlNumber S_REF_LineItemControlNumber {get; set;}
    [XmlElementAttribute(Order=4)]
    public S_REF_MammographyCertificationNumber_2 S_REF_MammographyCertificationNumber_2 {get; set;}
    [XmlElementAttribute(Order=5)]
    public S_REF_ClinicalLaboratoryImprovementAmendment_CLIA_Number_2 S_REF_ClinicalLaboratoryImprovementAmendment_CLIA_Number_2 {get; set;}
    [XmlElementAttribute(Order=6)]
    public S_REF_ReferringClinicalLaboratoryImprovementAmendment_CLIA_FacilityIdentification S_REF_ReferringClinicalLaboratoryImprovementAmendment_CLIA_FacilityIdentification {get; set;}
    [XmlElementAttribute(Order=7)]
    public S_REF_ImmunizationBatchNumber S_REF_ImmunizationBatchNumber {get; set;}
    [XmlElement(Order=8)]
    public U_REF_ReferralNumber_2 U_REF_ReferralNumber_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_RepricedLineItemReferenceNumber {
    [XmlElement(Order=0)]
    public X12_ID_128_29 D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_RepricedLineItemReferenceNumber {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03_Description {get; set;}
    [XmlElement(Order=3)]
    public C_C040_ReferenceIdentifier_38 C_C040_ReferenceIdentifier_38 {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_128_29 {
        [XmlEnum("9B")]
        Item9B,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C040_ReferenceIdentifier_38 {
    [XmlElement(Order=0)]
    public string D_C04001_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C04002_ReferenceIdentification {get; set;}
    [XmlElement(Order=2)]
    public string D_C04003_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C04004_ReferenceIdentification {get; set;}
    [XmlElement(Order=4)]
    public string D_C04005_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_C04006_ReferenceIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_AdjustedRepricedLineItemReferenceNumber {
    [XmlElement(Order=0)]
    public X12_ID_128_30 D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_AdjustedRepricedLineItemReferenceNumber {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03_Description {get; set;}
    [XmlElement(Order=3)]
    public C_C040_ReferenceIdentifier_39 C_C040_ReferenceIdentifier_39 {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_128_30 {
        [XmlEnum("9D")]
        Item9D,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C040_ReferenceIdentifier_39 {
    [XmlElement(Order=0)]
    public string D_C04001_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C04002_ReferenceIdentification {get; set;}
    [XmlElement(Order=2)]
    public string D_C04003_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C04004_ReferenceIdentification {get; set;}
    [XmlElement(Order=4)]
    public string D_C04005_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_C04006_ReferenceIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_PriorAuthorization_2 {
    [XmlElement(Order=0)]
    public X12_ID_128_15 D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_PriorAuthorizationorReferralNumber {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03_Description {get; set;}
    [XmlElement(Order=3)]
    public C_C040_ReferenceIdentifier_40 C_C040_ReferenceIdentifier_40 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C040_ReferenceIdentifier_40 {
    [XmlElement(Order=0)]
    public string D_C04001_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C04002_OtherPayerPrimaryIdentifier {get; set;}
    [XmlElement(Order=2)]
    public string D_C04003_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C04004_ReferenceIdentification {get; set;}
    [XmlElement(Order=4)]
    public string D_C04005_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_C04006_ReferenceIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_LineItemControlNumber {
    [XmlElement(Order=0)]
    public X12_ID_128_32 D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_LineItemControlNumber {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03_Description {get; set;}
    [XmlElement(Order=3)]
    public C_C040_ReferenceIdentifier_41 C_C040_ReferenceIdentifier_41 {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_128_32 {
        [XmlEnum("6R")]
        Item6R,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C040_ReferenceIdentifier_41 {
    [XmlElement(Order=0)]
    public string D_C04001_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C04002_ReferenceIdentification {get; set;}
    [XmlElement(Order=2)]
    public string D_C04003_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C04004_ReferenceIdentification {get; set;}
    [XmlElement(Order=4)]
    public string D_C04005_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_C04006_ReferenceIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_MammographyCertificationNumber_2 {
    [XmlElement(Order=0)]
    public X12_ID_128_13 D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_MammographyCertificationNumber {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03_Description {get; set;}
    [XmlElement(Order=3)]
    public C_C040_ReferenceIdentifier_42 C_C040_ReferenceIdentifier_42 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C040_ReferenceIdentifier_42 {
    [XmlElement(Order=0)]
    public string D_C04001_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C04002_ReferenceIdentification {get; set;}
    [XmlElement(Order=2)]
    public string D_C04003_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C04004_ReferenceIdentification {get; set;}
    [XmlElement(Order=4)]
    public string D_C04005_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_C04006_ReferenceIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_ClinicalLaboratoryImprovementAmendment_CLIA_Number_2 {
    [XmlElement(Order=0)]
    public X12_ID_128_17 D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_ClinicalLaboratoryImprovementAmendmentNumber {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03_Description {get; set;}
    [XmlElement(Order=3)]
    public C_C040_ReferenceIdentifier_43 C_C040_ReferenceIdentifier_43 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C040_ReferenceIdentifier_43 {
    [XmlElement(Order=0)]
    public string D_C04001_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C04002_ReferenceIdentification {get; set;}
    [XmlElement(Order=2)]
    public string D_C04003_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C04004_ReferenceIdentification {get; set;}
    [XmlElement(Order=4)]
    public string D_C04005_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_C04006_ReferenceIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_ReferringClinicalLaboratoryImprovementAmendment_CLIA_FacilityIdentification {
    [XmlElement(Order=0)]
    public X12_ID_128_33 D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_ReferringCLIANumber {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03_Description {get; set;}
    [XmlElement(Order=3)]
    public C_C040_ReferenceIdentifier_44 C_C040_ReferenceIdentifier_44 {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_128_33 {
        F4,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C040_ReferenceIdentifier_44 {
    [XmlElement(Order=0)]
    public string D_C04001_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C04002_ReferenceIdentification {get; set;}
    [XmlElement(Order=2)]
    public string D_C04003_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C04004_ReferenceIdentification {get; set;}
    [XmlElement(Order=4)]
    public string D_C04005_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_C04006_ReferenceIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_ImmunizationBatchNumber {
    [XmlElement(Order=0)]
    public X12_ID_128_34 D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_ImmunizationBatchNumber {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03_Description {get; set;}
    [XmlElement(Order=3)]
    public C_C040_ReferenceIdentifier_45 C_C040_ReferenceIdentifier_45 {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_128_34 {
        BT,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C040_ReferenceIdentifier_45 {
    [XmlElement(Order=0)]
    public string D_C04001_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C04002_ReferenceIdentification {get; set;}
    [XmlElement(Order=2)]
    public string D_C04003_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C04004_ReferenceIdentification {get; set;}
    [XmlElement(Order=4)]
    public string D_C04005_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_C04006_ReferenceIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_ReferralNumber_2 {
    [XmlElement(Order=0)]
    public X12_ID_128_14 D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_ReferralNumber {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03_Description {get; set;}
    [XmlElement(Order=3)]
    public C_C040_ReferenceIdentifier_46 C_C040_ReferenceIdentifier_46 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C040_ReferenceIdentifier_46 {
    [XmlElement(Order=0)]
    public string D_C04001_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C04002_OtherPayerPrimaryIdentifier {get; set;}
    [XmlElement(Order=2)]
    public string D_C04003_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C04004_ReferenceIdentification {get; set;}
    [XmlElement(Order=4)]
    public string D_C04005_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_C04006_ReferenceIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class A_AMT_2 {
    [XmlElementAttribute(Order=0)]
    public S_AMT_SalesTaxAmount S_AMT_SalesTaxAmount {get; set;}
    [XmlElementAttribute(Order=1)]
    public S_AMT_PostageClaimedAmount S_AMT_PostageClaimedAmount {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_AMT_SalesTaxAmount {
    [XmlElement(Order=0)]
    public X12_ID_522_5 D_AMT01_AmountQualifierCode {get; set;}
    [XmlElement(Order=1)]
    public string D_AMT02_SalesTaxAmount {get; set;}
    [XmlElement(Order=2)]
    public string D_AMT03_Credit_DebitFlagCode {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_522_5 {
        T,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_AMT_PostageClaimedAmount {
    [XmlElement(Order=0)]
    public X12_ID_522_6 D_AMT01_AmountQualifierCode {get; set;}
    [XmlElement(Order=1)]
    public string D_AMT02_PostageClaimedAmount {get; set;}
    [XmlElement(Order=2)]
    public string D_AMT03_Credit_DebitFlagCode {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_522_6 {
        F4,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_K3_FileInformation_2 {
    [XmlElement(Order=0)]
    public string D_K301_FixedFormatInformation {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1333 D_K302_RecordFormatCode {get; set;}
    [XmlElement(Order=2)]
    public C_C001_CompositeUnitofMeasure_5 C_C001_CompositeUnitofMeasure_5 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C001_CompositeUnitofMeasure_5 {
    [XmlElement(Order=0)]
    public string D_C00101_UnitorBasisforMeasurementCode {get; set;}
    [XmlElement(Order=1)]
    public string D_C00102_Exponent {get; set;}
    [XmlElement(Order=2)]
    public string D_C00103_Multiplier {get; set;}
    [XmlElement(Order=3)]
    public string D_C00104_UnitorBasisforMeasurementCode {get; set;}
    [XmlElement(Order=4)]
    public string D_C00105_Exponent {get; set;}
    [XmlElement(Order=5)]
    public string D_C00106_Multiplier {get; set;}
    [XmlElement(Order=6)]
    public string D_C00107_UnitorBasisforMeasurementCode {get; set;}
    [XmlElement(Order=7)]
    public string D_C00108_Exponent {get; set;}
    [XmlElement(Order=8)]
    public string D_C00109_Multiplier {get; set;}
    [XmlElement(Order=9)]
    public string D_C00110_UnitorBasisforMeasurementCode {get; set;}
    [XmlElement(Order=10)]
    public string D_C00111_Exponent {get; set;}
    [XmlElement(Order=11)]
    public string D_C00112_Multiplier {get; set;}
    [XmlElement(Order=12)]
    public string D_C00113_UnitorBasisforMeasurementCode {get; set;}
    [XmlElement(Order=13)]
    public string D_C00114_Exponent {get; set;}
    [XmlElement(Order=14)]
    public string D_C00115_Multiplier {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class A_NTE {
    [XmlElementAttribute(Order=0)]
    public S_NTE_LineNote S_NTE_LineNote {get; set;}
    [XmlElementAttribute(Order=1)]
    public S_NTE_ThirdPartyOrganizationNotes S_NTE_ThirdPartyOrganizationNotes {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_NTE_LineNote {
    [XmlElement(Order=0)]
    public X12_ID_363_2 D_NTE01_NoteReferenceCode {get; set;}
    [XmlElement(Order=1)]
    public string D_NTE02_LineNoteText {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_363_2 {
        ADD,
        DCP,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_NTE_ThirdPartyOrganizationNotes {
    [XmlElement(Order=0)]
    public X12_ID_363_3 D_NTE01_NoteReferenceCode {get; set;}
    [XmlElement(Order=1)]
    public string D_NTE02_LineNoteText {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_363_3 {
        TPO,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_PS1_PurchasedServiceInformation {
    [XmlElement(Order=0)]
    public string D_PS101_PurchasedServiceProviderIdentifier {get; set;}
    [XmlElement(Order=1)]
    public string D_PS102_PurchasedServiceChargeAmount {get; set;}
    [XmlElement(Order=2)]
    public string D_PS103_StateorProvinceCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_HCP_LinePricing_RepricingInformation {
    [XmlElement(Order=0)]
    public X12_ID_1473_2 D_HCP01_PricingMethodology {get; set;}
    [XmlElement(Order=1)]
    public string D_HCP02_RepricedAllowedAmount {get; set;}
    [XmlElement(Order=2)]
    public string D_HCP03_RepricedSavingAmount {get; set;}
    [XmlElement(Order=3)]
    public string D_HCP04_RepricingOrganizationIdentifier {get; set;}
    [XmlElement(Order=4)]
    public string D_HCP05_RepricingPerDiemorFlatRateAmount {get; set;}
    [XmlElement(Order=5)]
    public string D_HCP06_RepricedApprovedAmbulatoryPatientGroupCode {get; set;}
    [XmlElement(Order=6)]
    public string D_HCP07_RepricedApprovedAmbulatoryPatientGroupAmount {get; set;}
    [XmlElement(Order=7)]
    public string D_HCP08_Product_ServiceID {get; set;}
    [XmlElement(Order=8)]
    public string D_HCP09_ProductorServiceIDQualifier {get; set;}
    [XmlElement(Order=9)]
    public string D_HCP10_RepricedApprovedHCPCSCode {get; set;}
    [XmlElement(Order=10)]
    public string D_HCP11_UnitorBasisforMeasurementCode {get; set;}
    [XmlElement(Order=11)]
    public string D_HCP12_RepricedApprovedServiceUnitCount {get; set;}
    [XmlElement(Order=12)]
    public string D_HCP13_RejectReasonCode {get; set;}
    [XmlElement(Order=13)]
    public string D_HCP14_PolicyComplianceCode {get; set;}
    [XmlElement(Order=14)]
    public string D_HCP15_ExceptionCode {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_1473_2 {
        [XmlEnum("00")]
        Item00,
        [XmlEnum("01")]
        Item01,
        [XmlEnum("02")]
        Item02,
        [XmlEnum("03")]
        Item03,
        [XmlEnum("04")]
        Item04,
        [XmlEnum("05")]
        Item05,
        [XmlEnum("06")]
        Item06,
        [XmlEnum("07")]
        Item07,
        [XmlEnum("08")]
        Item08,
        [XmlEnum("09")]
        Item09,
        [XmlEnum("10")]
        Item10,
        [XmlEnum("11")]
        Item11,
        [XmlEnum("12")]
        Item12,
        [XmlEnum("13")]
        Item13,
        [XmlEnum("14")]
        Item14,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_TS837_2410 {
    [XmlElement(Order=0)]
    public S_LIN_DrugIdentification S_LIN_DrugIdentification {get; set;}
    [XmlElement(Order=1)]
    public S_CTP_DrugQuantity S_CTP_DrugQuantity {get; set;}
    [XmlElement(Order=2)]
    public S_REF_PrescriptionorCompoundDrugAssociationNumber S_REF_PrescriptionorCompoundDrugAssociationNumber {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_LIN_DrugIdentification {
    [XmlElement(Order=0)]
    public string D_LIN01_AssignedIdentification {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_235_4 D_LIN02_ProductorServiceIDQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_LIN03_NationalDrugCodeorUniversalProductNumber {get; set;}
    [XmlElement(Order=3)]
    public string D_LIN04_Product_ServiceIDQualifier {get; set;}
    [XmlElement(Order=4)]
    public string D_LIN05_Product_ServiceID {get; set;}
    [XmlElement(Order=5)]
    public string D_LIN06_Product_ServiceIDQualifier {get; set;}
    [XmlElement(Order=6)]
    public string D_LIN07_Product_ServiceID {get; set;}
    [XmlElement(Order=7)]
    public string D_LIN08_Product_ServiceIDQualifier {get; set;}
    [XmlElement(Order=8)]
    public string D_LIN09_Product_ServiceID {get; set;}
    [XmlElement(Order=9)]
    public string D_LIN10_Product_ServiceIDQualifier {get; set;}
    [XmlElement(Order=10)]
    public string D_LIN11_Product_ServiceID {get; set;}
    [XmlElement(Order=11)]
    public string D_LIN12_Product_ServiceIDQualifier {get; set;}
    [XmlElement(Order=12)]
    public string D_LIN13_Product_ServiceID {get; set;}
    [XmlElement(Order=13)]
    public string D_LIN14_Product_ServiceIDQualifier {get; set;}
    [XmlElement(Order=14)]
    public string D_LIN15_Product_ServiceID {get; set;}
    [XmlElement(Order=15)]
    public string D_LIN16_Product_ServiceIDQualifier {get; set;}
    [XmlElement(Order=16)]
    public string D_LIN17_Product_ServiceID {get; set;}
    [XmlElement(Order=17)]
    public string D_LIN18_Product_ServiceIDQualifier {get; set;}
    [XmlElement(Order=18)]
    public string D_LIN19_Product_ServiceID {get; set;}
    [XmlElement(Order=19)]
    public string D_LIN20_Product_ServiceIDQualifier {get; set;}
    [XmlElement(Order=20)]
    public string D_LIN21_Product_ServiceID {get; set;}
    [XmlElement(Order=21)]
    public string D_LIN22_Product_ServiceIDQualifier {get; set;}
    [XmlElement(Order=22)]
    public string D_LIN23_Product_ServiceID {get; set;}
    [XmlElement(Order=23)]
    public string D_LIN24_Product_ServiceIDQualifier {get; set;}
    [XmlElement(Order=24)]
    public string D_LIN25_Product_ServiceID {get; set;}
    [XmlElement(Order=25)]
    public string D_LIN26_Product_ServiceIDQualifier {get; set;}
    [XmlElement(Order=26)]
    public string D_LIN27_Product_ServiceID {get; set;}
    [XmlElement(Order=27)]
    public string D_LIN28_Product_ServiceIDQualifier {get; set;}
    [XmlElement(Order=28)]
    public string D_LIN29_Product_ServiceID {get; set;}
    [XmlElement(Order=29)]
    public string D_LIN30_Product_ServiceIDQualifier {get; set;}
    [XmlElement(Order=30)]
    public string D_LIN31_Product_ServiceID {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_235_4 {
        EN,
        EO,
        HI,
        N4,
        ON,
        UK,
        UP,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_CTP_DrugQuantity {
    [XmlElement(Order=0)]
    public X12_ID_687 D_CTP01_ClassofTradeCode {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_236 D_CTP02_PriceIdentifierCode {get; set;}
    [XmlElement(Order=2)]
    public string D_CTP03_UnitPrice {get; set;}
    [XmlElement(Order=3)]
    public string D_CTP04_NationalDrugUnitCount {get; set;}
    [XmlElement(Order=4)]
    public C_C001_CompositeUnitofMeasure_6 C_C001_CompositeUnitofMeasure_6 {get; set;}
    [XmlElement(Order=5)]
    public string D_CTP06_PriceMultiplierQualifier {get; set;}
    [XmlElement(Order=6)]
    public string D_CTP07_Multiplier {get; set;}
    [XmlElement(Order=7)]
    public string D_CTP08_MonetaryAmount {get; set;}
    [XmlElement(Order=8)]
    public string D_CTP09_BasisofUnitPriceCode {get; set;}
    [XmlElement(Order=9)]
    public string D_CTP10_ConditionValue {get; set;}
    [XmlElement(Order=10)]
    public string D_CTP11_MultiplePriceQuantity {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_687 {
        AA,
        AB,
        AC,
        AD,
        AE,
        AF,
        AG,
        AH,
        AI,
        AJ,
        AL,
        AM,
        AN,
        AO,
        AP,
        AQ,
        AR,
        AS,
        BG,
        BR,
        CB,
        CN,
        CO,
        CR,
        CX,
        CY,
        DE,
        DF,
        DI,
        DR,
        EX,
        FS,
        GA,
        GM,
        GR,
        GV,
        HS,
        ID,
        IN,
        IR,
        JB,
        LC,
        MC,
        MF,
        ML,
        OE,
        OF,
        ON,
        PF,
        PH,
        PT,
        PY,
        RS,
        SA,
        SB,
        SE,
        ST,
        TR,
        WA,
        WC,
        WH,
        WS,
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_236 {
        ACT,
        AGC,
        ALT,
        AWP,
        BBP,
        BCH,
        BID,
        C01,
        C02,
        C03,
        C04,
        C05,
        C06,
        C07,
        C08,
        C09,
        C10,
        C11,
        C12,
        C13,
        C14,
        C15,
        C16,
        C17,
        C18,
        C19,
        C20,
        C21,
        C22,
        C23,
        C24,
        C25,
        C26,
        C27,
        C28,
        C29,
        C30,
        CAN,
        CAT,
        CDF,
        CDV,
        CHG,
        CON,
        CUP,
        CUS,
        D01,
        D02,
        D03,
        DAP,
        DIS,
        DPR,
        DSC,
        DSD,
        DSP,
        EDM,
        EDP,
        EDS,
        EDW,
        ELC,
        EST,
        EUP,
        FCH,
        FCP,
        FDS,
        FET,
        FGP,
        FOR,
        FSP,
        FUL,
        FUP,
        GAP,
        GDP,
        GOV,
        GSP,
        GTP,
        ICL,
        IND,
        INS,
        INV,
        LAR,
        LCP,
        LPP,
        LPR,
        MAP,
        MAS,
        MAX,
        MIN,
        MNC,
        MNR,
        MOD,
        MPR,
        MSR,
        MXR,
        N01,
        N02,
        N03,
        N04,
        N05,
        N06,
        N07,
        N08,
        N09,
        N10,
        N11,
        N12,
        N13,
        N14,
        N15,
        N16,
        N17,
        N18,
        N19,
        N20,
        N21,
        N22,
        N23,
        N24,
        N25,
        N26,
        N27,
        N28,
        N29,
        N30,
        N31,
        NET,
        OAP,
        OPP,
        PAP,
        PAQ,
        PBQ,
        PBR,
        PHS,
        PIE,
        PLT,
        PPA,
        PPD,
        PRF,
        PRO,
        PRP,
        PUR,
        QTE,
        REG,
        RES,
        RPA,
        RPM,
        RPP,
        RSH,
        RTL,
        SAC,
        SDP,
        SFP,
        SHD,
        SLP,
        SPC,
        SPE,
        SSP,
        STA,
        SUM,
        SWP,
        THP,
        TOT,
        TRF,
        UCP,
        ULC,
        WAR,
        WHL,
        WSP,
        ZNP,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C001_CompositeUnitofMeasure_6 {
    [XmlElement(Order=0)]
    public string D_C00101_CodeQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C00102_Exponent {get; set;}
    [XmlElement(Order=2)]
    public string D_C00103_Multiplier {get; set;}
    [XmlElement(Order=3)]
    public string D_C00104_UnitorBasisforMeasurementCode {get; set;}
    [XmlElement(Order=4)]
    public string D_C00105_Exponent {get; set;}
    [XmlElement(Order=5)]
    public string D_C00106_Multiplier {get; set;}
    [XmlElement(Order=6)]
    public string D_C00107_UnitorBasisforMeasurementCode {get; set;}
    [XmlElement(Order=7)]
    public string D_C00108_Exponent {get; set;}
    [XmlElement(Order=8)]
    public string D_C00109_Multiplier {get; set;}
    [XmlElement(Order=9)]
    public string D_C00110_UnitorBasisforMeasurementCode {get; set;}
    [XmlElement(Order=10)]
    public string D_C00111_Exponent {get; set;}
    [XmlElement(Order=11)]
    public string D_C00112_Multiplier {get; set;}
    [XmlElement(Order=12)]
    public string D_C00113_UnitorBasisforMeasurementCode {get; set;}
    [XmlElement(Order=13)]
    public string D_C00114_Exponent {get; set;}
    [XmlElement(Order=14)]
    public string D_C00115_Multiplier {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_PrescriptionorCompoundDrugAssociationNumber {
    [XmlElement(Order=0)]
    public X12_ID_128_35 D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_PrescriptionNumber {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03_Description {get; set;}
    [XmlElement(Order=3)]
    public C_C040_ReferenceIdentifier_47 C_C040_ReferenceIdentifier_47 {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_128_35 {
        VY,
        XZ,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C040_ReferenceIdentifier_47 {
    [XmlElement(Order=0)]
    public string D_C04001_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C04002_ReferenceIdentification {get; set;}
    [XmlElement(Order=2)]
    public string D_C04003_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C04004_ReferenceIdentification {get; set;}
    [XmlElement(Order=4)]
    public string D_C04005_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_C04006_ReferenceIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class A_NM1_6 {
    [XmlElementAttribute(Order=0)]
    public G_TS837_2420A G_TS837_2420A {get; set;}
    [XmlElementAttribute(Order=1)]
    public G_TS837_2420B G_TS837_2420B {get; set;}
    [XmlElementAttribute(Order=2)]
    public G_TS837_2420C G_TS837_2420C {get; set;}
    [XmlElementAttribute(Order=3)]
    public G_TS837_2420D G_TS837_2420D {get; set;}
    [XmlElementAttribute(Order=4)]
    public G_TS837_2420E G_TS837_2420E {get; set;}
    [XmlElement(Order=5)]
    public U_TS837_2420F U_TS837_2420F {get; set;}
    [XmlElementAttribute(Order=6)]
    public G_TS837_2420G G_TS837_2420G {get; set;}
    [XmlElementAttribute(Order=7)]
    public G_TS837_2420H G_TS837_2420H {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_TS837_2420A {
    [XmlElement(Order=0)]
    public S_NM1_RenderingProviderName_2 S_NM1_RenderingProviderName_2 {get; set;}
    [XmlElement(Order=1)]
    public S_PRV_RenderingProviderSpecialtyInformation_2 S_PRV_RenderingProviderSpecialtyInformation_2 {get; set;}
    [XmlElement("S_REF_RenderingProviderSecondaryIdentification_2",Order=2)]
    public List<S_REF_RenderingProviderSecondaryIdentification_2> S_REF_RenderingProviderSecondaryIdentification_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_NM1_RenderingProviderName_2 {
    [XmlElement(Order=0)]
    public X12_ID_98_10 D_NM101_EntityIdentifierCode {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1065 D_NM102_EntityTypeQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_NM103_RenderingProviderLastorOrganizationName {get; set;}
    [XmlElement(Order=3)]
    public string D_NM104_RenderingProviderFirstName {get; set;}
    [XmlElement(Order=4)]
    public string D_NM105_RenderingProviderMiddleName {get; set;}
    [XmlElement(Order=5)]
    public string D_NM106_NamePrefix {get; set;}
    [XmlElement(Order=6)]
    public string D_NM107_RenderingProviderNameSuffix {get; set;}
    [XmlElement(Order=7)]
    public string D_NM108_IdentificationCodeQualifier {get; set;}
    [XmlElement(Order=8)]
    public string D_NM109_RenderingProviderIdentifier {get; set;}
    [XmlElement(Order=9)]
    public string D_NM110_EntityRelationshipCode {get; set;}
    [XmlElement(Order=10)]
    public string D_NM111_EntityIdentifierCode {get; set;}
    [XmlElement(Order=11)]
    public string D_NM112_NameLastorOrganizationName {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_PRV_RenderingProviderSpecialtyInformation_2 {
    [XmlElement(Order=0)]
    public X12_ID_1221_2 D_PRV01_ProviderCode {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_128 D_PRV02_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_PRV03_ProviderTaxonomyCode {get; set;}
    [XmlElement(Order=3)]
    public string D_PRV04_StateorProvinceCode {get; set;}
    [XmlElement(Order=4)]
    public C_C035_ProviderSpecialtyInformation_3 C_C035_ProviderSpecialtyInformation_3 {get; set;}
    [XmlElement(Order=5)]
    public string D_PRV06_ProviderOrganizationCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C035_ProviderSpecialtyInformation_3 {
    [XmlElement(Order=0)]
    public string D_C03501_ProviderSpecialtyCode {get; set;}
    [XmlElement(Order=1)]
    public string D_C03502_AgencyQualifierCode {get; set;}
    [XmlElement(Order=2)]
    public string D_C03503_Yes_NoConditionorResponseCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_RenderingProviderSecondaryIdentification_2 {
    [XmlElement(Order=0)]
    public X12_ID_128_26 D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_RenderingProviderSecondaryIdentifier {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03_Description {get; set;}
    [XmlElement(Order=3)]
    public C_C040_ReferenceIdentifier_48 C_C040_ReferenceIdentifier_48 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C040_ReferenceIdentifier_48 {
    [XmlElement(Order=0)]
    public string D_C04001_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C04002_OtherPayerPrimaryIdentifier {get; set;}
    [XmlElement(Order=2)]
    public string D_C04003_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C04004_ReferenceIdentification {get; set;}
    [XmlElement(Order=4)]
    public string D_C04005_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_C04006_ReferenceIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_TS837_2420B {
    [XmlElement(Order=0)]
    public S_NM1_PurchasedServiceProviderName S_NM1_PurchasedServiceProviderName {get; set;}
    [XmlElement("S_REF_PurchasedServiceProviderSecondaryIdentification",Order=1)]
    public List<S_REF_PurchasedServiceProviderSecondaryIdentification> S_REF_PurchasedServiceProviderSecondaryIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_NM1_PurchasedServiceProviderName {
    [XmlElement(Order=0)]
    public X12_ID_98_15 D_NM101_EntityIdentifierCode {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1065 D_NM102_EntityTypeQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_NM103_NameLastorOrganizationName {get; set;}
    [XmlElement(Order=3)]
    public string D_NM104_NameFirst {get; set;}
    [XmlElement(Order=4)]
    public string D_NM105_NameMiddle {get; set;}
    [XmlElement(Order=5)]
    public string D_NM106_NamePrefix {get; set;}
    [XmlElement(Order=6)]
    public string D_NM107_NameSuffix {get; set;}
    [XmlElement(Order=7)]
    public string D_NM108_IdentificationCodeQualifier {get; set;}
    [XmlElement(Order=8)]
    public string D_NM109_PurchasedServiceProviderIdentifier {get; set;}
    [XmlElement(Order=9)]
    public string D_NM110_EntityRelationshipCode {get; set;}
    [XmlElement(Order=10)]
    public string D_NM111_EntityIdentifierCode {get; set;}
    [XmlElement(Order=11)]
    public string D_NM112_NameLastorOrganizationName {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_98_15 {
        QB,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_PurchasedServiceProviderSecondaryIdentification {
    [XmlElement(Order=0)]
    public X12_ID_128_25 D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_PurchasedServiceProviderSecondaryIdentifier {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03_Description {get; set;}
    [XmlElement(Order=3)]
    public C_C040_ReferenceIdentifier_49 C_C040_ReferenceIdentifier_49 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C040_ReferenceIdentifier_49 {
    [XmlElement(Order=0)]
    public string D_C04001_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C04002_OtherPayerPrimaryIdentifier {get; set;}
    [XmlElement(Order=2)]
    public string D_C04003_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C04004_ReferenceIdentification {get; set;}
    [XmlElement(Order=4)]
    public string D_C04005_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_C04006_ReferenceIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_TS837_2420C {
    [XmlElement(Order=0)]
    public S_NM1_ServiceFacilityLocation S_NM1_ServiceFacilityLocation {get; set;}
    [XmlElement(Order=1)]
    public S_N3_ServiceFacilityLocationAddress_2 S_N3_ServiceFacilityLocationAddress_2 {get; set;}
    [XmlElement(Order=2)]
    public S_N4_ServiceFacilityLocationCity_State_ZIPCode_2 S_N4_ServiceFacilityLocationCity_State_ZIPCode_2 {get; set;}
    [XmlElement("S_REF_ServiceFacilityLocationSecondaryIdentification_2",Order=3)]
    public List<S_REF_ServiceFacilityLocationSecondaryIdentification_2> S_REF_ServiceFacilityLocationSecondaryIdentification_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_NM1_ServiceFacilityLocation {
    [XmlElement(Order=0)]
    public X12_ID_98_11 D_NM101_EntityIdentifierCode {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1065_2 D_NM102_EntityTypeQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_NM103_LaboratoryorFacilityName {get; set;}
    [XmlElement(Order=3)]
    public string D_NM104_NameFirst {get; set;}
    [XmlElement(Order=4)]
    public string D_NM105_NameMiddle {get; set;}
    [XmlElement(Order=5)]
    public string D_NM106_NamePrefix {get; set;}
    [XmlElement(Order=6)]
    public string D_NM107_NameSuffix {get; set;}
    [XmlElement(Order=7)]
    public string D_NM108_IdentificationCodeQualifier {get; set;}
    [XmlElement(Order=8)]
    public string D_NM109_LaboratoryorFacilityPrimaryIdentifier {get; set;}
    [XmlElement(Order=9)]
    public string D_NM110_EntityRelationshipCode {get; set;}
    [XmlElement(Order=10)]
    public string D_NM111_EntityIdentifierCode {get; set;}
    [XmlElement(Order=11)]
    public string D_NM112_NameLastorOrganizationName {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_N3_ServiceFacilityLocationAddress_2 {
    [XmlElement(Order=0)]
    public string D_N301_LaboratoryorFacilityAddressLine {get; set;}
    [XmlElement(Order=1)]
    public string D_N302_LaboratoryorFacilityAddressLine {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_N4_ServiceFacilityLocationCity_State_ZIPCode_2 {
    [XmlElement(Order=0)]
    public string D_N401_LaboratoryorFacilityCityName {get; set;}
    [XmlElement(Order=1)]
    public string D_N402_LaboratoryorFacilityStateorProvinceCode {get; set;}
    [XmlElement(Order=2)]
    public string D_N403_LaboratoryorFacilityPostalZoneorZIPCode {get; set;}
    [XmlElement(Order=3)]
    public string D_N404_CountryCode {get; set;}
    [XmlElement(Order=4)]
    public string D_N405_LocationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_N406_LocationIdentifier {get; set;}
    [XmlElement(Order=6)]
    public string D_N407_CountrySubdivisionCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_ServiceFacilityLocationSecondaryIdentification_2 {
    [XmlElement(Order=0)]
    public X12_ID_128_10 D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_ServiceFacilityLocationSecondaryIdentifier {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03_Description {get; set;}
    [XmlElement(Order=3)]
    public C_C040_ReferenceIdentifier_50 C_C040_ReferenceIdentifier_50 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C040_ReferenceIdentifier_50 {
    [XmlElement(Order=0)]
    public string D_C04001_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C04002_OtherPayerPrimaryIdentifier {get; set;}
    [XmlElement(Order=2)]
    public string D_C04003_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C04004_ReferenceIdentification {get; set;}
    [XmlElement(Order=4)]
    public string D_C04005_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_C04006_ReferenceIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_TS837_2420D {
    [XmlElement(Order=0)]
    public S_NM1_SupervisingProviderName_2 S_NM1_SupervisingProviderName_2 {get; set;}
    [XmlElement("S_REF_SupervisingProviderSecondaryIdentification_2",Order=1)]
    public List<S_REF_SupervisingProviderSecondaryIdentification_2> S_REF_SupervisingProviderSecondaryIdentification_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_NM1_SupervisingProviderName_2 {
    [XmlElement(Order=0)]
    public X12_ID_98_12 D_NM101_EntityIdentifierCode {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1065_3 D_NM102_EntityTypeQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_NM103_SupervisingProviderLastName {get; set;}
    [XmlElement(Order=3)]
    public string D_NM104_SupervisingProviderFirstName {get; set;}
    [XmlElement(Order=4)]
    public string D_NM105_SupervisingProviderMiddleNameorInitial {get; set;}
    [XmlElement(Order=5)]
    public string D_NM106_NamePrefix {get; set;}
    [XmlElement(Order=6)]
    public string D_NM107_SupervisingProviderNameSuffix {get; set;}
    [XmlElement(Order=7)]
    public string D_NM108_IdentificationCodeQualifier {get; set;}
    [XmlElement(Order=8)]
    public string D_NM109_SupervisingProviderIdentifier {get; set;}
    [XmlElement(Order=9)]
    public string D_NM110_EntityRelationshipCode {get; set;}
    [XmlElement(Order=10)]
    public string D_NM111_EntityIdentifierCode {get; set;}
    [XmlElement(Order=11)]
    public string D_NM112_NameLastorOrganizationName {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_SupervisingProviderSecondaryIdentification_2 {
    [XmlElement(Order=0)]
    public X12_ID_128_26 D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_SupervisingProviderSecondaryIdentifier {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03_Description {get; set;}
    [XmlElement(Order=3)]
    public C_C040_ReferenceIdentifier_51 C_C040_ReferenceIdentifier_51 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C040_ReferenceIdentifier_51 {
    [XmlElement(Order=0)]
    public string D_C04001_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C04002_OtherPayerPrimaryIdentifier {get; set;}
    [XmlElement(Order=2)]
    public string D_C04003_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C04004_ReferenceIdentification {get; set;}
    [XmlElement(Order=4)]
    public string D_C04005_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_C04006_ReferenceIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_TS837_2420E {
    [XmlElement(Order=0)]
    public S_NM1_OrderingProviderName S_NM1_OrderingProviderName {get; set;}
    [XmlElement(Order=1)]
    public S_N3_OrderingProviderAddress S_N3_OrderingProviderAddress {get; set;}
    [XmlElement(Order=2)]
    public S_N4_OrderingProviderCity_State_ZIPCode S_N4_OrderingProviderCity_State_ZIPCode {get; set;}
    [XmlElement("S_REF_OrderingProviderSecondaryIdentification",Order=3)]
    public List<S_REF_OrderingProviderSecondaryIdentification> S_REF_OrderingProviderSecondaryIdentification {get; set;}
    [XmlElement(Order=4)]
    public S_PER_OrderingProviderContactInformation S_PER_OrderingProviderContactInformation {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_NM1_OrderingProviderName {
    [XmlElement(Order=0)]
    public X12_ID_98_16 D_NM101_EntityIdentifierCode {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1065_3 D_NM102_EntityTypeQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_NM103_OrderingProviderLastName {get; set;}
    [XmlElement(Order=3)]
    public string D_NM104_OrderingProviderFirstName {get; set;}
    [XmlElement(Order=4)]
    public string D_NM105_OrderingProviderMiddleNameorInitial {get; set;}
    [XmlElement(Order=5)]
    public string D_NM106_NamePrefix {get; set;}
    [XmlElement(Order=6)]
    public string D_NM107_OrderingProviderNameSuffix {get; set;}
    [XmlElement(Order=7)]
    public string D_NM108_IdentificationCodeQualifier {get; set;}
    [XmlElement(Order=8)]
    public string D_NM109_OrderingProviderIdentifier {get; set;}
    [XmlElement(Order=9)]
    public string D_NM110_EntityRelationshipCode {get; set;}
    [XmlElement(Order=10)]
    public string D_NM111_EntityIdentifierCode {get; set;}
    [XmlElement(Order=11)]
    public string D_NM112_NameLastorOrganizationName {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_98_16 {
        DK,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_N3_OrderingProviderAddress {
    [XmlElement(Order=0)]
    public string D_N301_OrderingProviderAddressLine {get; set;}
    [XmlElement(Order=1)]
    public string D_N302_OrderingProviderAddressLine {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_N4_OrderingProviderCity_State_ZIPCode {
    [XmlElement(Order=0)]
    public string D_N401_OrderingProviderCityName {get; set;}
    [XmlElement(Order=1)]
    public string D_N402_OrderingProviderStateorProvinceCode {get; set;}
    [XmlElement(Order=2)]
    public string D_N403_OrderingProviderPostalZoneorZIPCode {get; set;}
    [XmlElement(Order=3)]
    public string D_N404_CountryCode {get; set;}
    [XmlElement(Order=4)]
    public string D_N405_LocationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_N406_LocationIdentifier {get; set;}
    [XmlElement(Order=6)]
    public string D_N407_CountrySubdivisionCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_OrderingProviderSecondaryIdentification {
    [XmlElement(Order=0)]
    public X12_ID_128_25 D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_OrderingProviderSecondaryIdentifier {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03_Description {get; set;}
    [XmlElement(Order=3)]
    public C_C040_ReferenceIdentifier_52 C_C040_ReferenceIdentifier_52 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C040_ReferenceIdentifier_52 {
    [XmlElement(Order=0)]
    public string D_C04001_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C04002_OtherPayerPrimaryIdentifier {get; set;}
    [XmlElement(Order=2)]
    public string D_C04003_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C04004_ReferenceIdentification {get; set;}
    [XmlElement(Order=4)]
    public string D_C04005_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_C04006_ReferenceIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_PER_OrderingProviderContactInformation {
    [XmlElement(Order=0)]
    public X12_ID_366 D_PER01_ContactFunctionCode {get; set;}
    [XmlElement(Order=1)]
    public string D_PER02_OrderingProviderContactName {get; set;}
    [XmlElement(Order=2)]
    public string D_PER03_CommunicationNumberQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_PER04_CommunicationNumber {get; set;}
    [XmlElement(Order=4)]
    public string D_PER05_CommunicationNumberQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_PER06_CommunicationNumber {get; set;}
    [XmlElement(Order=6)]
    public string D_PER07_CommunicationNumberQualifier {get; set;}
    [XmlElement(Order=7)]
    public string D_PER08_CommunicationNumber {get; set;}
    [XmlElement(Order=8)]
    public string D_PER09_ContactInquiryReference {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_TS837_2420F {
    [XmlElement(Order=0)]
    public S_NM1_ReferringProviderName_2 S_NM1_ReferringProviderName_2 {get; set;}
    [XmlElement("S_REF_ReferringProviderSecondaryIdentification_2",Order=1)]
    public List<S_REF_ReferringProviderSecondaryIdentification_2> S_REF_ReferringProviderSecondaryIdentification_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_NM1_ReferringProviderName_2 {
    [XmlElement(Order=0)]
    public X12_ID_98_9 D_NM101_EntityIdentifierCode {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1065_3 D_NM102_EntityTypeQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_NM103_ReferringProviderLastName {get; set;}
    [XmlElement(Order=3)]
    public string D_NM104_ReferringProviderFirstName {get; set;}
    [XmlElement(Order=4)]
    public string D_NM105_ReferringProviderMiddleNameorInitial {get; set;}
    [XmlElement(Order=5)]
    public string D_NM106_NamePrefix {get; set;}
    [XmlElement(Order=6)]
    public string D_NM107_ReferringProviderNameSuffix {get; set;}
    [XmlElement(Order=7)]
    public string D_NM108_IdentificationCodeQualifier {get; set;}
    [XmlElement(Order=8)]
    public string D_NM109_ReferringProviderIdentifier {get; set;}
    [XmlElement(Order=9)]
    public string D_NM110_EntityRelationshipCode {get; set;}
    [XmlElement(Order=10)]
    public string D_NM111_EntityIdentifierCode {get; set;}
    [XmlElement(Order=11)]
    public string D_NM112_NameLastorOrganizationName {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_ReferringProviderSecondaryIdentification_2 {
    [XmlElement(Order=0)]
    public X12_ID_128_25 D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_ReferringProviderSecondaryIdentifier {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03_Description {get; set;}
    [XmlElement(Order=3)]
    public C_C040_ReferenceIdentifier_53 C_C040_ReferenceIdentifier_53 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C040_ReferenceIdentifier_53 {
    [XmlElement(Order=0)]
    public string D_C04001_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C04002_OtherPayerPrimaryIdentifier {get; set;}
    [XmlElement(Order=2)]
    public string D_C04003_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C04004_ReferenceIdentification {get; set;}
    [XmlElement(Order=4)]
    public string D_C04005_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_C04006_ReferenceIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_TS837_2420G {
    [XmlElement(Order=0)]
    public S_NM1_AmbulancePick_upLocation_2 S_NM1_AmbulancePick_upLocation_2 {get; set;}
    [XmlElement(Order=1)]
    public S_N3_AmbulancePick_upLocationAddress_2 S_N3_AmbulancePick_upLocationAddress_2 {get; set;}
    [XmlElement(Order=2)]
    public S_N4_AmbulancePick_upLocationCity_State_ZipCode_2 S_N4_AmbulancePick_upLocationCity_State_ZipCode_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_NM1_AmbulancePick_upLocation_2 {
    [XmlElement(Order=0)]
    public X12_ID_98_13 D_NM101_EntityIdentifierCode {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1065_2 D_NM102_EntityTypeQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_NM103_NameLastorOrganizationName {get; set;}
    [XmlElement(Order=3)]
    public string D_NM104_NameFirst {get; set;}
    [XmlElement(Order=4)]
    public string D_NM105_NameMiddle {get; set;}
    [XmlElement(Order=5)]
    public string D_NM106_NamePrefix {get; set;}
    [XmlElement(Order=6)]
    public string D_NM107_NameSuffix {get; set;}
    [XmlElement(Order=7)]
    public string D_NM108_IdentificationCodeQualifier {get; set;}
    [XmlElement(Order=8)]
    public string D_NM109_IdentificationCode {get; set;}
    [XmlElement(Order=9)]
    public string D_NM110_EntityRelationshipCode {get; set;}
    [XmlElement(Order=10)]
    public string D_NM111_EntityIdentifierCode {get; set;}
    [XmlElement(Order=11)]
    public string D_NM112_NameLastorOrganizationName {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_N3_AmbulancePick_upLocationAddress_2 {
    [XmlElement(Order=0)]
    public string D_N301_AmbulancePick_upAddressLine {get; set;}
    [XmlElement(Order=1)]
    public string D_N302_AmbulancePick_upAddressLine {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_N4_AmbulancePick_upLocationCity_State_ZipCode_2 {
    [XmlElement(Order=0)]
    public string D_N401_AmbulancePick_upCityName {get; set;}
    [XmlElement(Order=1)]
    public string D_N402_AmbulancePick_upStateorProvinceCode {get; set;}
    [XmlElement(Order=2)]
    public string D_N403_AmbulancePick_upPostalZoneorZIPCode {get; set;}
    [XmlElement(Order=3)]
    public string D_N404_CountryCode {get; set;}
    [XmlElement(Order=4)]
    public string D_N405_LocationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_N406_LocationIdentifier {get; set;}
    [XmlElement(Order=6)]
    public string D_N407_CountrySubdivisionCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_TS837_2420H {
    [XmlElement(Order=0)]
    public S_NM1_AmbulanceDrop_offLocation_2 S_NM1_AmbulanceDrop_offLocation_2 {get; set;}
    [XmlElement(Order=1)]
    public S_N3_AmbulanceDrop_offLocationAddress_2 S_N3_AmbulanceDrop_offLocationAddress_2 {get; set;}
    [XmlElement(Order=2)]
    public S_N4_AmbulanceDrop_offLocationCity_State_ZipCode_2 S_N4_AmbulanceDrop_offLocationCity_State_ZipCode_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_NM1_AmbulanceDrop_offLocation_2 {
    [XmlElement(Order=0)]
    public X12_ID_98_14 D_NM101_EntityIdentifierCode {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1065_2 D_NM102_EntityTypeQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_NM103_AmbulanceDrop_offLocation {get; set;}
    [XmlElement(Order=3)]
    public string D_NM104_NameFirst {get; set;}
    [XmlElement(Order=4)]
    public string D_NM105_NameMiddle {get; set;}
    [XmlElement(Order=5)]
    public string D_NM106_NamePrefix {get; set;}
    [XmlElement(Order=6)]
    public string D_NM107_NameSuffix {get; set;}
    [XmlElement(Order=7)]
    public string D_NM108_IdentificationCodeQualifier {get; set;}
    [XmlElement(Order=8)]
    public string D_NM109_IdentificationCode {get; set;}
    [XmlElement(Order=9)]
    public string D_NM110_EntityRelationshipCode {get; set;}
    [XmlElement(Order=10)]
    public string D_NM111_EntityIdentifierCode {get; set;}
    [XmlElement(Order=11)]
    public string D_NM112_NameLastorOrganizationName {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_N3_AmbulanceDrop_offLocationAddress_2 {
    [XmlElement(Order=0)]
    public string D_N301_AmbulanceDrop_offAddressLine {get; set;}
    [XmlElement(Order=1)]
    public string D_N302_AmbulanceDrop_offAddressLine {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_N4_AmbulanceDrop_offLocationCity_State_ZipCode_2 {
    [XmlElement(Order=0)]
    public string D_N401_AmbulanceDrop_offCityName {get; set;}
    [XmlElement(Order=1)]
    public string D_N402_AmbulanceDrop_offStateorProvinceCode {get; set;}
    [XmlElement(Order=2)]
    public string D_N403_AmbulanceDrop_offPostalZoneorZIPCode {get; set;}
    [XmlElement(Order=3)]
    public string D_N404_CountryCode {get; set;}
    [XmlElement(Order=4)]
    public string D_N405_LocationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_N406_LocationIdentifier {get; set;}
    [XmlElement(Order=6)]
    public string D_N407_CountrySubdivisionCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_TS837_2430 {
    [XmlElement(Order=0)]
    public S_SVD_LineAdjudicationInformation S_SVD_LineAdjudicationInformation {get; set;}
    [XmlElement("S_CAS_LineAdjustment",Order=1)]
    public List<S_CAS_LineAdjustment> S_CAS_LineAdjustment {get; set;}
    [XmlElement(Order=2)]
    public S_DTP_LineCheckorRemittanceDate S_DTP_LineCheckorRemittanceDate {get; set;}
    [XmlElement(Order=3)]
    public S_AMT_RemainingPatientLiability_2 S_AMT_RemainingPatientLiability_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_SVD_LineAdjudicationInformation {
    [XmlElement(Order=0)]
    public string D_SVD01_OtherPayerPrimaryIdentifier {get; set;}
    [XmlElement(Order=1)]
    public string D_SVD02_ServiceLinePaidAmount {get; set;}
    [XmlElement(Order=2)]
    public C_C003_CompositeMedicalProcedureIdentifier_3 C_C003_CompositeMedicalProcedureIdentifier_3 {get; set;}
    [XmlElement(Order=3)]
    public string D_SVD04_Product_ServiceID {get; set;}
    [XmlElement(Order=4)]
    public string D_SVD05_PaidServiceUnitCount {get; set;}
    [XmlElement(Order=5)]
    public string D_SVD06_BundledorUnbundledLineNumber {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C003_CompositeMedicalProcedureIdentifier_3 {
    [XmlElement(Order=0)]
    public string D_C00301_ProductorServiceIDQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C00302_ProcedureCode {get; set;}
    [XmlElement(Order=2)]
    public string D_C00303_ProcedureModifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C00304_ProcedureModifier {get; set;}
    [XmlElement(Order=4)]
    public string D_C00305_ProcedureModifier {get; set;}
    [XmlElement(Order=5)]
    public string D_C00306_ProcedureModifier {get; set;}
    [XmlElement(Order=6)]
    public string D_C00307_ProcedureCodeDescription {get; set;}
    [XmlElement(Order=7)]
    public string D_C00308_Product_ServiceID {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_CAS_LineAdjustment {
    [XmlElement(Order=0)]
    public X12_ID_1033 D_CAS01_ClaimAdjustmentGroupCode {get; set;}
    [XmlElement(Order=1)]
    public string D_CAS02_AdjustmentReasonCode {get; set;}
    [XmlElement(Order=2)]
    public string D_CAS03_AdjustmentAmount {get; set;}
    [XmlElement(Order=3)]
    public string D_CAS04_AdjustmentQuantity {get; set;}
    [XmlElement(Order=4)]
    public string D_CAS05_AdjustmentReasonCode {get; set;}
    [XmlElement(Order=5)]
    public string D_CAS06_AdjustmentAmount {get; set;}
    [XmlElement(Order=6)]
    public string D_CAS07_AdjustmentQuantity {get; set;}
    [XmlElement(Order=7)]
    public string D_CAS08_AdjustmentReasonCode {get; set;}
    [XmlElement(Order=8)]
    public string D_CAS09_AdjustmentAmount {get; set;}
    [XmlElement(Order=9)]
    public string D_CAS10_AdjustmentQuantity {get; set;}
    [XmlElement(Order=10)]
    public string D_CAS11_AdjustmentReasonCode {get; set;}
    [XmlElement(Order=11)]
    public string D_CAS12_AdjustmentAmount {get; set;}
    [XmlElement(Order=12)]
    public string D_CAS13_AdjustmentQuantity {get; set;}
    [XmlElement(Order=13)]
    public string D_CAS14_AdjustmentReasonCode {get; set;}
    [XmlElement(Order=14)]
    public string D_CAS15_AdjustmentAmount {get; set;}
    [XmlElement(Order=15)]
    public string D_CAS16_AdjustmentQuantity {get; set;}
    [XmlElement(Order=16)]
    public string D_CAS17_AdjustmentReasonCode {get; set;}
    [XmlElement(Order=17)]
    public string D_CAS18_AdjustmentAmount {get; set;}
    [XmlElement(Order=18)]
    public string D_CAS19_AdjustmentQuantity {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_DTP_LineCheckorRemittanceDate {
    [XmlElement(Order=0)]
    public X12_ID_374_18 D_DTP01_DateTimeQualifier {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1250 D_DTP02_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_DTP03_AdjudicationorPaymentDate {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_AMT_RemainingPatientLiability_2 {
    [XmlElement(Order=0)]
    public X12_ID_522_4 D_AMT01_AmountQualifierCode {get; set;}
    [XmlElement(Order=1)]
    public string D_AMT02_RemainingPatientLiability {get; set;}
    [XmlElement(Order=2)]
    public string D_AMT03_Credit_DebitFlagCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_TS837_2440 {
    [XmlElement(Order=0)]
    public S_LQ_FormIdentificationCode S_LQ_FormIdentificationCode {get; set;}
    [XmlElement("S_FRM_SupportingDocumentation",Order=1)]
    public List<S_FRM_SupportingDocumentation> S_FRM_SupportingDocumentation {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_LQ_FormIdentificationCode {
    [XmlElement(Order=0)]
    public X12_ID_1270_7 D_LQ01_CodeListQualifierCode {get; set;}
    [XmlElement(Order=1)]
    public string D_LQ02_FormIdentifier {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_1270_7 {
        AS,
        UT,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_FRM_SupportingDocumentation {
    [XmlElement(Order=0)]
    public string D_FRM01_QuestionNumber_Letter {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1073_4 D_FRM02_QuestionResponse {get; set;}
    [XmlElement(Order=2)]
    public string D_FRM03_QuestionResponse {get; set;}
    [XmlElement(Order=3)]
    public string D_FRM04_QuestionResponse {get; set;}
    [XmlElement(Order=4)]
    public string D_FRM05_QuestionResponse {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_1073_4 {
        N,
        W,
        Y,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_TS837_2000C {
    [XmlElement(Order=0)]
    public S_HL_PatientHierarchicalLevel S_HL_PatientHierarchicalLevel {get; set;}
    [XmlElement(Order=1)]
    public S_PAT_PatientInformation_2 S_PAT_PatientInformation_2 {get; set;}
    [XmlElement(Order=2)]
    public G_TS837_2010CA G_TS837_2010CA {get; set;}
    [XmlElement("G_TS837_2300_1",Order=3)]
    public List<G_TS837_2300_1> G_TS837_2300_1 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_HL_PatientHierarchicalLevel {
    [XmlElement(Order=0)]
    public string D_HL01_HierarchicalIDNumber {get; set;}
    [XmlElement(Order=1)]
    public string D_HL02_HierarchicalParentIDNumber {get; set;}
    [XmlElement(Order=2)]
    public string D_HL03_HierarchicalLevelCode {get; set;}
    [XmlElement(Order=3)]
    public string D_HL04_HierarchicalChildCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_PAT_PatientInformation_2 {
    [XmlElement(Order=0)]
    public X12_ID_1069_4 D_PAT01_IndividualRelationshipCode {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1384 D_PAT02_PatientLocationCode {get; set;}
    [XmlElement(Order=2)]
    public string D_PAT03_EmploymentStatusCode {get; set;}
    [XmlElement(Order=3)]
    public string D_PAT04_StudentStatusCode {get; set;}
    [XmlElement(Order=4)]
    public string D_PAT05_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_PAT06_PatientDeathDate {get; set;}
    [XmlElement(Order=6)]
    public string D_PAT07_UnitorBasisforMeasurementCode {get; set;}
    [XmlElement(Order=7)]
    public string D_PAT08_PatientWeight {get; set;}
    [XmlElement(Order=8)]
    public string D_PAT09_PregnancyIndicator {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_1069_4 {
        [XmlEnum("01")]
        Item01,
        [XmlEnum("19")]
        Item19,
        [XmlEnum("20")]
        Item20,
        [XmlEnum("21")]
        Item21,
        [XmlEnum("39")]
        Item39,
        [XmlEnum("40")]
        Item40,
        [XmlEnum("53")]
        Item53,
        G8,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_TS837_2010CA {
    [XmlElement(Order=0)]
    public S_NM1_PatientName S_NM1_PatientName {get; set;}
    [XmlElement(Order=1)]
    public S_N3_PatientAddress S_N3_PatientAddress {get; set;}
    [XmlElement(Order=2)]
    public S_N4_PatientCity_State_ZIPCode S_N4_PatientCity_State_ZIPCode {get; set;}
    [XmlElement(Order=3)]
    public S_DMG_PatientDemographicInformation S_DMG_PatientDemographicInformation {get; set;}
    [XmlElement(Order=4)]
    public A_REF_8 A_REF_8 {get; set;}
    [XmlElement(Order=5)]
    public S_PER_PropertyandCasualtyPatientContactInformation S_PER_PropertyandCasualtyPatientContactInformation {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_NM1_PatientName {
    [XmlElement(Order=0)]
    public X12_ID_98_17 D_NM101_EntityIdentifierCode {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1065_3 D_NM102_EntityTypeQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_NM103_PatientLastName {get; set;}
    [XmlElement(Order=3)]
    public string D_NM104_PatientFirstName {get; set;}
    [XmlElement(Order=4)]
    public string D_NM105_PatientMiddleNameorInitial {get; set;}
    [XmlElement(Order=5)]
    public string D_NM106_NamePrefix {get; set;}
    [XmlElement(Order=6)]
    public string D_NM107_PatientNameSuffix {get; set;}
    [XmlElement(Order=7)]
    public string D_NM108_IdentificationCodeQualifier {get; set;}
    [XmlElement(Order=8)]
    public string D_NM109_IdentificationCode {get; set;}
    [XmlElement(Order=9)]
    public string D_NM110_EntityRelationshipCode {get; set;}
    [XmlElement(Order=10)]
    public string D_NM111_EntityIdentifierCode {get; set;}
    [XmlElement(Order=11)]
    public string D_NM112_NameLastorOrganizationName {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_98_17 {
        QC,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_N3_PatientAddress {
    [XmlElement(Order=0)]
    public string D_N301_PatientAddressLine {get; set;}
    [XmlElement(Order=1)]
    public string D_N302_PatientAddressLine {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_N4_PatientCity_State_ZIPCode {
    [XmlElement(Order=0)]
    public string D_N401_PatientCityName {get; set;}
    [XmlElement(Order=1)]
    public string D_N402_PatientStateCode {get; set;}
    [XmlElement(Order=2)]
    public string D_N403_PatientPostalZoneorZIPCode {get; set;}
    [XmlElement(Order=3)]
    public string D_N404_CountryCode {get; set;}
    [XmlElement(Order=4)]
    public string D_N405_LocationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_N406_LocationIdentifier {get; set;}
    [XmlElement(Order=6)]
    public string D_N407_CountrySubdivisionCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_DMG_PatientDemographicInformation {
    [XmlElement(Order=0)]
    public X12_ID_1250 D_DMG01_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_DMG02_PatientBirthDate {get; set;}
    [XmlElement(Order=2)]
    public string D_DMG03_PatientGenderCode {get; set;}
    [XmlElement(Order=3)]
    public string D_DMG04_MaritalStatusCode {get; set;}
    [XmlElement("C_C056_CompositeRaceorEthnicityInformation_2",Order=4)]
    public List<C_C056_CompositeRaceorEthnicityInformation_2> C_C056_CompositeRaceorEthnicityInformation_2 {get; set;}
    [XmlElement(Order=5)]
    public string D_DMG06_CitizenshipStatusCode {get; set;}
    [XmlElement(Order=6)]
    public string D_DMG07_CountryCode {get; set;}
    [XmlElement(Order=7)]
    public string D_DMG08_BasisofVerificationCode {get; set;}
    [XmlElement(Order=8)]
    public string D_DMG09_Quantity {get; set;}
    [XmlElement(Order=9)]
    public string D_DMG10_CodeListQualifierCode {get; set;}
    [XmlElement(Order=10)]
    public string D_DMG11_IndustryCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C056_CompositeRaceorEthnicityInformation_2 {
    [XmlElement(Order=0)]
    public string D_C05601_RaceorEthnicityCode {get; set;}
    [XmlElement(Order=1)]
    public string D_C05602_CodeListQualifierCode {get; set;}
    [XmlElement(Order=2)]
    public string D_C05603_IndustryCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class A_REF_8 {
    [XmlElementAttribute(Order=0)]
    public S_REF_PropertyandCasualtyClaimNumber_2 S_REF_PropertyandCasualtyClaimNumber_2 {get; set;}
    [XmlElementAttribute(Order=1)]
    public S_REF_PropertyandCasualtyPatientIdentifier S_REF_PropertyandCasualtyPatientIdentifier {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_PropertyandCasualtyClaimNumber_2 {
    [XmlElement(Order=0)]
    public X12_ID_128_8 D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_PropertyCasualtyClaimNumber {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03_Description {get; set;}
    [XmlElement(Order=3)]
    public C_C040_ReferenceIdentifier_54 C_C040_ReferenceIdentifier_54 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C040_ReferenceIdentifier_54 {
    [XmlElement(Order=0)]
    public string D_C04001_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C04002_ReferenceIdentification {get; set;}
    [XmlElement(Order=2)]
    public string D_C04003_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C04004_ReferenceIdentification {get; set;}
    [XmlElement(Order=4)]
    public string D_C04005_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_C04006_ReferenceIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_PropertyandCasualtyPatientIdentifier {
    [XmlElement(Order=0)]
    public X12_ID_128_36 D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_PropertyandCasualtyPatientIdentifier {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03_Description {get; set;}
    [XmlElement(Order=3)]
    public C_C040_ReferenceIdentifier_55 C_C040_ReferenceIdentifier_55 {get; set;}
    }
    [Serializable]
    [XmlType(Namespace="www.edifabric.com/x12", AnonymousType=true)]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public enum X12_ID_128_36 {
        [XmlEnum("1W")]
        Item1W,
        SY,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C040_ReferenceIdentifier_55 {
    [XmlElement(Order=0)]
    public string D_C04001_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C04002_ReferenceIdentification {get; set;}
    [XmlElement(Order=2)]
    public string D_C04003_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C04004_ReferenceIdentification {get; set;}
    [XmlElement(Order=4)]
    public string D_C04005_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_C04006_ReferenceIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_PER_PropertyandCasualtyPatientContactInformation {
    [XmlElement(Order=0)]
    public X12_ID_366 D_PER01_ContactFunctionCode {get; set;}
    [XmlElement(Order=1)]
    public string D_PER02_Name {get; set;}
    [XmlElement(Order=2)]
    public string D_PER03_CommunicationNumberQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_PER04_CommunicationNumber {get; set;}
    [XmlElement(Order=4)]
    public string D_PER05_CommunicationNumberQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_PER06_CommunicationNumber {get; set;}
    [XmlElement(Order=6)]
    public string D_PER07_CommunicationNumberQualifier {get; set;}
    [XmlElement(Order=7)]
    public string D_PER08_CommunicationNumber {get; set;}
    [XmlElement(Order=8)]
    public string D_PER09_ContactInquiryReference {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_TS837_2300_1 {
    [XmlElement(Order=0)]
    public S_CLM_ClaimInformation_2 S_CLM_ClaimInformation_2 {get; set;}
    [XmlElement(Order=1)]
    public A_DTP_3 A_DTP_3 {get; set;}
    [XmlElement("S_PWK_ClaimSupplementalInformation_2",Order=2)]
    public List<S_PWK_ClaimSupplementalInformation_2> S_PWK_ClaimSupplementalInformation_2 {get; set;}
    [XmlElement(Order=3)]
    public S_CN1_ContractInformation_3 S_CN1_ContractInformation_3 {get; set;}
    [XmlElement(Order=4)]
    public S_AMT_PatientAmountPaid_2 S_AMT_PatientAmountPaid_2 {get; set;}
    [XmlElement(Order=5)]
    public A_REF_9 A_REF_9 {get; set;}
    [XmlElement("S_K3_FileInformation_3",Order=6)]
    public List<S_K3_FileInformation_3> S_K3_FileInformation_3 {get; set;}
    [XmlElement(Order=7)]
    public S_NTE_ClaimNote_2 S_NTE_ClaimNote_2 {get; set;}
    [XmlElement(Order=8)]
    public S_CR1_AmbulanceTransportInformation_3 S_CR1_AmbulanceTransportInformation_3 {get; set;}
    [XmlElement(Order=9)]
    public S_CR2_SpinalManipulationServiceInformation_2 S_CR2_SpinalManipulationServiceInformation_2 {get; set;}
    [XmlElement(Order=10)]
    public A_CRC_3 A_CRC_3 {get; set;}
    [XmlElement(Order=11)]
    public A_HI_2 A_HI_2 {get; set;}
    [XmlElement(Order=12)]
    public S_HCP_ClaimPricing_RepricingInformation_2 S_HCP_ClaimPricing_RepricingInformation_2 {get; set;}
    [XmlElement(Order=13)]
    public A_NM1_7 A_NM1_7 {get; set;}
    [XmlElement("G_TS837_2320_1",Order=14)]
    public List<G_TS837_2320_1> G_TS837_2320_1 {get; set;}
    [XmlElement("G_TS837_2400_1",Order=15)]
    public List<G_TS837_2400_1> G_TS837_2400_1 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_CLM_ClaimInformation_2 {
    [XmlElement(Order=0)]
    public string D_CLM01_PatientControlNumber {get; set;}
    [XmlElement(Order=1)]
    public string D_CLM02_TotalClaimChargeAmount {get; set;}
    [XmlElement(Order=2)]
    public string D_CLM03_ClaimFilingIndicatorCode {get; set;}
    [XmlElement(Order=3)]
    public string D_CLM04_Non_InstitutionalClaimTypeCode {get; set;}
    [XmlElement(Order=4)]
    public C_C023_HealthCareServiceLocationInformation_2 C_C023_HealthCareServiceLocationInformation_2 {get; set;}
    [XmlElement(Order=5)]
    public string D_CLM06_ProviderorSupplierSignatureIndicator {get; set;}
    [XmlElement(Order=6)]
    public string D_CLM07_AssignmentorPlanParticipationCode {get; set;}
    [XmlElement(Order=7)]
    public string D_CLM08_BenefitsAssignmentCertificationIndicator {get; set;}
    [XmlElement(Order=8)]
    public string D_CLM09_ReleaseofInformationCode {get; set;}
    [XmlElement(Order=9)]
    public string D_CLM10_PatientSignatureSourceCode {get; set;}
    [XmlElement(Order=10)]
    public C_C024_RelatedCausesInformation_2 C_C024_RelatedCausesInformation_2 {get; set;}
    [XmlElement(Order=11)]
    public string D_CLM12_SpecialProgramIndicator {get; set;}
    [XmlElement(Order=12)]
    public string D_CLM13_Yes_NoConditionorResponseCode {get; set;}
    [XmlElement(Order=13)]
    public string D_CLM14_LevelofServiceCode {get; set;}
    [XmlElement(Order=14)]
    public string D_CLM15_Yes_NoConditionorResponseCode {get; set;}
    [XmlElement(Order=15)]
    public string D_CLM16_ProviderAgreementCode {get; set;}
    [XmlElement(Order=16)]
    public string D_CLM17_ClaimStatusCode {get; set;}
    [XmlElement(Order=17)]
    public string D_CLM18_Yes_NoConditionorResponseCode {get; set;}
    [XmlElement(Order=18)]
    public string D_CLM19_ClaimSubmissionReasonCode {get; set;}
    [XmlElement(Order=19)]
    public string D_CLM20_DelayReasonCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C023_HealthCareServiceLocationInformation_2 {
    [XmlElement(Order=0)]
    public string D_C02301_PlaceofServiceCode {get; set;}
    [XmlElement(Order=1)]
    public string D_C02302_FacilityCodeQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_C02303_ClaimFrequencyCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C024_RelatedCausesInformation_2 {
    [XmlElement(Order=0)]
    public string D_C02401_RelatedCausesCode {get; set;}
    [XmlElement(Order=1)]
    public string D_C02402_RelatedCausesCode {get; set;}
    [XmlElement(Order=2)]
    public string D_C02403_Related_CausesCode {get; set;}
    [XmlElement(Order=3)]
    public string D_C02404_AutoAccidentStateorProvinceCode {get; set;}
    [XmlElement(Order=4)]
    public string D_C02405_CountryCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class A_DTP_3 {
    [XmlElementAttribute(Order=0)]
    public S_DTP_Date_OnsetofCurrentIllnessorSymptom_2 S_DTP_Date_OnsetofCurrentIllnessorSymptom_2 {get; set;}
    [XmlElementAttribute(Order=1)]
    public S_DTP_Date_InitialTreatmentDate_3 S_DTP_Date_InitialTreatmentDate_3 {get; set;}
    [XmlElementAttribute(Order=2)]
    public S_DTP_Date_LastSeenDate_3 S_DTP_Date_LastSeenDate_3 {get; set;}
    [XmlElementAttribute(Order=3)]
    public S_DTP_Date_AcuteManifestation_2 S_DTP_Date_AcuteManifestation_2 {get; set;}
    [XmlElementAttribute(Order=4)]
    public S_DTP_Date_Accident_2 S_DTP_Date_Accident_2 {get; set;}
    [XmlElementAttribute(Order=5)]
    public S_DTP_Date_LastMenstrualPeriod_2 S_DTP_Date_LastMenstrualPeriod_2 {get; set;}
    [XmlElementAttribute(Order=6)]
    public S_DTP_Date_LastX_rayDate_3 S_DTP_Date_LastX_rayDate_3 {get; set;}
    [XmlElementAttribute(Order=7)]
    public S_DTP_Date_HearingandVisionPrescriptionDate_2 S_DTP_Date_HearingandVisionPrescriptionDate_2 {get; set;}
    [XmlElementAttribute(Order=8)]
    public S_DTP_Date_DisabilityDates_2 S_DTP_Date_DisabilityDates_2 {get; set;}
    [XmlElementAttribute(Order=9)]
    public S_DTP_Date_LastWorked_2 S_DTP_Date_LastWorked_2 {get; set;}
    [XmlElementAttribute(Order=10)]
    public S_DTP_Date_AuthorizedReturntoWork_2 S_DTP_Date_AuthorizedReturntoWork_2 {get; set;}
    [XmlElementAttribute(Order=11)]
    public S_DTP_Date_Admission_2 S_DTP_Date_Admission_2 {get; set;}
    [XmlElementAttribute(Order=12)]
    public S_DTP_Date_Discharge_2 S_DTP_Date_Discharge_2 {get; set;}
    [XmlElement(Order=13)]
    public U_DTP_Date_AssumedandRelinquishedCareDates_2 U_DTP_Date_AssumedandRelinquishedCareDates_2 {get; set;}
    [XmlElementAttribute(Order=14)]
    public S_DTP_PropertyandCasualtyDateofFirstContact_2 S_DTP_PropertyandCasualtyDateofFirstContact_2 {get; set;}
    [XmlElementAttribute(Order=15)]
    public S_DTP_Date_RepricerReceivedDate_2 S_DTP_Date_RepricerReceivedDate_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_DTP_Date_OnsetofCurrentIllnessorSymptom_2 {
    [XmlElement(Order=0)]
    public X12_ID_374_2 D_DTP01_DateTimeQualifier {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1250 D_DTP02_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_DTP03_OnsetofCurrentIllnessorInjuryDate {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_DTP_Date_InitialTreatmentDate_3 {
    [XmlElement(Order=0)]
    public X12_ID_374_3 D_DTP01_DateTimeQualifier {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1250 D_DTP02_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_DTP03_InitialTreatmentDate {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_DTP_Date_LastSeenDate_3 {
    [XmlElement(Order=0)]
    public X12_ID_374_4 D_DTP01_DateTimeQualifier {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1250 D_DTP02_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_DTP03_LastSeenDate {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_DTP_Date_AcuteManifestation_2 {
    [XmlElement(Order=0)]
    public X12_ID_374_5 D_DTP01_DateTimeQualifier {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1250 D_DTP02_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_DTP03_AcuteManifestationDate {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_DTP_Date_Accident_2 {
    [XmlElement(Order=0)]
    public X12_ID_374_6 D_DTP01_DateTimeQualifier {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1250 D_DTP02_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_DTP03_AccidentDate {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_DTP_Date_LastMenstrualPeriod_2 {
    [XmlElement(Order=0)]
    public X12_ID_374_7 D_DTP01_DateTimeQualifier {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1250 D_DTP02_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_DTP03_LastMenstrualPeriodDate {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_DTP_Date_LastX_rayDate_3 {
    [XmlElement(Order=0)]
    public X12_ID_374_8 D_DTP01_DateTimeQualifier {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1250 D_DTP02_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_DTP03_LastX_RayDate {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_DTP_Date_HearingandVisionPrescriptionDate_2 {
    [XmlElement(Order=0)]
    public X12_ID_374_9 D_DTP01_DateTimeQualifier {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1250 D_DTP02_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_DTP03_PrescriptionDate {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_DTP_Date_DisabilityDates_2 {
    [XmlElement(Order=0)]
    public X12_ID_374_10 D_DTP01_DateTimeQualifier {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1250_2 D_DTP02_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_DTP03_DisabilityFromDate {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_DTP_Date_LastWorked_2 {
    [XmlElement(Order=0)]
    public X12_ID_374_11 D_DTP01_DateTimeQualifier {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1250 D_DTP02_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_DTP03_LastWorkedDate {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_DTP_Date_AuthorizedReturntoWork_2 {
    [XmlElement(Order=0)]
    public X12_ID_374_12 D_DTP01_DateTimeQualifier {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1250 D_DTP02_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_DTP03_WorkReturnDate {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_DTP_Date_Admission_2 {
    [XmlElement(Order=0)]
    public X12_ID_374_13 D_DTP01_DateTimeQualifier {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1250 D_DTP02_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_DTP03_RelatedHospitalizationAdmissionDate {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_DTP_Date_Discharge_2 {
    [XmlElement(Order=0)]
    public X12_ID_374_14 D_DTP01_DateTimeQualifier {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1250 D_DTP02_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_DTP03_RelatedHospitalizationDischargeDate {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_DTP_Date_AssumedandRelinquishedCareDates_2 {
    [XmlElement(Order=0)]
    public X12_ID_374_15 D_DTP01_DateTimeQualifier {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1250 D_DTP02_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_DTP03_AssumedorRelinquishedCareDate {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_DTP_PropertyandCasualtyDateofFirstContact_2 {
    [XmlElement(Order=0)]
    public X12_ID_374_16 D_DTP01_DateTimeQualifier {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1250 D_DTP02_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_DTP03_DateTimePeriod {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_DTP_Date_RepricerReceivedDate_2 {
    [XmlElement(Order=0)]
    public X12_ID_374_17 D_DTP01_DateTimeQualifier {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1250 D_DTP02_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_DTP03_RepricerReceivedDate {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_PWK_ClaimSupplementalInformation_2 {
    [XmlElement(Order=0)]
    public X12_ID_755 D_PWK01_AttachmentReportTypeCode {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_756 D_PWK02_AttachmentTransmissionCode {get; set;}
    [XmlElement(Order=2)]
    public string D_PWK03_ReportCopiesNeeded {get; set;}
    [XmlElement(Order=3)]
    public string D_PWK04_EntityIdentifierCode {get; set;}
    [XmlElement(Order=4)]
    public string D_PWK05_IdentificationCodeQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_PWK06_AttachmentControlNumber {get; set;}
    [XmlElement(Order=6)]
    public string D_PWK07_Description {get; set;}
    [XmlElement(Order=7)]
    public C_C002_ActionsIndicated_4 C_C002_ActionsIndicated_4 {get; set;}
    [XmlElement(Order=8)]
    public string D_PWK09_RequestCategoryCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C002_ActionsIndicated_4 {
    [XmlElement(Order=0)]
    public string D_C00201_Paperwork_ReportActionCode {get; set;}
    [XmlElement(Order=1)]
    public string D_C00202_Paperwork_ReportActionCode {get; set;}
    [XmlElement(Order=2)]
    public string D_C00203_Paperwork_ReportActionCode {get; set;}
    [XmlElement(Order=3)]
    public string D_C00204_Paperwork_ReportActionCode {get; set;}
    [XmlElement(Order=4)]
    public string D_C00205_Paperwork_ReportActionCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_CN1_ContractInformation_3 {
    [XmlElement(Order=0)]
    public X12_ID_1166 D_CN101_ContractTypeCode {get; set;}
    [XmlElement(Order=1)]
    public string D_CN102_ContractAmount {get; set;}
    [XmlElement(Order=2)]
    public string D_CN103_ContractPercentage {get; set;}
    [XmlElement(Order=3)]
    public string D_CN104_ContractCode {get; set;}
    [XmlElement(Order=4)]
    public string D_CN105_TermsDiscountPercentage {get; set;}
    [XmlElement(Order=5)]
    public string D_CN106_ContractVersionIdentifier {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_AMT_PatientAmountPaid_2 {
    [XmlElement(Order=0)]
    public X12_ID_522 D_AMT01_AmountQualifierCode {get; set;}
    [XmlElement(Order=1)]
    public string D_AMT02_PatientAmountPaid {get; set;}
    [XmlElement(Order=2)]
    public string D_AMT03_Credit_DebitFlagCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class A_REF_9 {
    [XmlElementAttribute(Order=0)]
    public S_REF_ServiceAuthorizationExceptionCode_2 S_REF_ServiceAuthorizationExceptionCode_2 {get; set;}
    [XmlElementAttribute(Order=1)]
    public S_REF_MandatoryMedicare_Section4081_CrossoverIndicator_2 S_REF_MandatoryMedicare_Section4081_CrossoverIndicator_2 {get; set;}
    [XmlElementAttribute(Order=2)]
    public S_REF_MammographyCertificationNumber_3 S_REF_MammographyCertificationNumber_3 {get; set;}
    [XmlElementAttribute(Order=3)]
    public S_REF_ReferralNumber_3 S_REF_ReferralNumber_3 {get; set;}
    [XmlElementAttribute(Order=4)]
    public S_REF_PriorAuthorization_3 S_REF_PriorAuthorization_3 {get; set;}
    [XmlElementAttribute(Order=5)]
    public S_REF_PayerClaimControlNumber_2 S_REF_PayerClaimControlNumber_2 {get; set;}
    [XmlElementAttribute(Order=6)]
    public S_REF_ClinicalLaboratoryImprovementAmendment_CLIA_Number_3 S_REF_ClinicalLaboratoryImprovementAmendment_CLIA_Number_3 {get; set;}
    [XmlElementAttribute(Order=7)]
    public S_REF_RepricedClaimNumber_2 S_REF_RepricedClaimNumber_2 {get; set;}
    [XmlElementAttribute(Order=8)]
    public S_REF_AdjustedRepricedClaimNumber_2 S_REF_AdjustedRepricedClaimNumber_2 {get; set;}
    [XmlElementAttribute(Order=9)]
    public S_REF_InvestigationalDeviceExemptionNumber_2 S_REF_InvestigationalDeviceExemptionNumber_2 {get; set;}
    [XmlElementAttribute(Order=10)]
    public S_REF_ClaimIdentifierForTransmissionIntermediaries_2 S_REF_ClaimIdentifierForTransmissionIntermediaries_2 {get; set;}
    [XmlElementAttribute(Order=11)]
    public S_REF_MedicalRecordNumber_2 S_REF_MedicalRecordNumber_2 {get; set;}
    [XmlElementAttribute(Order=12)]
    public S_REF_DemonstrationProjectIdentifier_2 S_REF_DemonstrationProjectIdentifier_2 {get; set;}
    [XmlElementAttribute(Order=13)]
    public S_REF_CarePlanOversight_2 S_REF_CarePlanOversight_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_ServiceAuthorizationExceptionCode_2 {
    [XmlElement(Order=0)]
    public X12_ID_128_11 D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_127_1 D_REF02_ServiceAuthorizationExceptionCode {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03_Description {get; set;}
    [XmlElement(Order=3)]
    public C_C040_ReferenceIdentifier_56 C_C040_ReferenceIdentifier_56 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C040_ReferenceIdentifier_56 {
    [XmlElement(Order=0)]
    public string D_C04001_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C04002_ReferenceIdentification {get; set;}
    [XmlElement(Order=2)]
    public string D_C04003_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C04004_ReferenceIdentification {get; set;}
    [XmlElement(Order=4)]
    public string D_C04005_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_C04006_ReferenceIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_MandatoryMedicare_Section4081_CrossoverIndicator_2 {
    [XmlElement(Order=0)]
    public X12_ID_128_12 D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_127_2 D_REF02_MedicareSection4081Indicator {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03_Description {get; set;}
    [XmlElement(Order=3)]
    public C_C040_ReferenceIdentifier_57 C_C040_ReferenceIdentifier_57 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C040_ReferenceIdentifier_57 {
    [XmlElement(Order=0)]
    public string D_C04001_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C04002_ReferenceIdentification {get; set;}
    [XmlElement(Order=2)]
    public string D_C04003_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C04004_ReferenceIdentification {get; set;}
    [XmlElement(Order=4)]
    public string D_C04005_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_C04006_ReferenceIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_MammographyCertificationNumber_3 {
    [XmlElement(Order=0)]
    public X12_ID_128_13 D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_MammographyCertificationNumber {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03_Description {get; set;}
    [XmlElement(Order=3)]
    public C_C040_ReferenceIdentifier_58 C_C040_ReferenceIdentifier_58 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C040_ReferenceIdentifier_58 {
    [XmlElement(Order=0)]
    public string D_C04001_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C04002_ReferenceIdentification {get; set;}
    [XmlElement(Order=2)]
    public string D_C04003_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C04004_ReferenceIdentification {get; set;}
    [XmlElement(Order=4)]
    public string D_C04005_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_C04006_ReferenceIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_ReferralNumber_3 {
    [XmlElement(Order=0)]
    public X12_ID_128_14 D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_ReferralNumber {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03_Description {get; set;}
    [XmlElement(Order=3)]
    public C_C040_ReferenceIdentifier_59 C_C040_ReferenceIdentifier_59 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C040_ReferenceIdentifier_59 {
    [XmlElement(Order=0)]
    public string D_C04001_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C04002_ReferenceIdentification {get; set;}
    [XmlElement(Order=2)]
    public string D_C04003_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C04004_ReferenceIdentification {get; set;}
    [XmlElement(Order=4)]
    public string D_C04005_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_C04006_ReferenceIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_PriorAuthorization_3 {
    [XmlElement(Order=0)]
    public X12_ID_128_15 D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_PriorAuthorizationNumber {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03_Description {get; set;}
    [XmlElement(Order=3)]
    public C_C040_ReferenceIdentifier_60 C_C040_ReferenceIdentifier_60 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C040_ReferenceIdentifier_60 {
    [XmlElement(Order=0)]
    public string D_C04001_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C04002_ReferenceIdentification {get; set;}
    [XmlElement(Order=2)]
    public string D_C04003_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C04004_ReferenceIdentification {get; set;}
    [XmlElement(Order=4)]
    public string D_C04005_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_C04006_ReferenceIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_PayerClaimControlNumber_2 {
    [XmlElement(Order=0)]
    public X12_ID_128_16 D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_PayerClaimControlNumber {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03_Description {get; set;}
    [XmlElement(Order=3)]
    public C_C040_ReferenceIdentifier_61 C_C040_ReferenceIdentifier_61 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C040_ReferenceIdentifier_61 {
    [XmlElement(Order=0)]
    public string D_C04001_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C04002_ReferenceIdentification {get; set;}
    [XmlElement(Order=2)]
    public string D_C04003_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C04004_ReferenceIdentification {get; set;}
    [XmlElement(Order=4)]
    public string D_C04005_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_C04006_ReferenceIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_ClinicalLaboratoryImprovementAmendment_CLIA_Number_3 {
    [XmlElement(Order=0)]
    public X12_ID_128_17 D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_ClinicalLaboratoryImprovementAmendmentNumber {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03_Description {get; set;}
    [XmlElement(Order=3)]
    public C_C040_ReferenceIdentifier_62 C_C040_ReferenceIdentifier_62 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C040_ReferenceIdentifier_62 {
    [XmlElement(Order=0)]
    public string D_C04001_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C04002_ReferenceIdentification {get; set;}
    [XmlElement(Order=2)]
    public string D_C04003_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C04004_ReferenceIdentification {get; set;}
    [XmlElement(Order=4)]
    public string D_C04005_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_C04006_ReferenceIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_RepricedClaimNumber_2 {
    [XmlElement(Order=0)]
    public X12_ID_128_18 D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_RepricedClaimReferenceNumber {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03_Description {get; set;}
    [XmlElement(Order=3)]
    public C_C040_ReferenceIdentifier_63 C_C040_ReferenceIdentifier_63 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C040_ReferenceIdentifier_63 {
    [XmlElement(Order=0)]
    public string D_C04001_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C04002_ReferenceIdentification {get; set;}
    [XmlElement(Order=2)]
    public string D_C04003_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C04004_ReferenceIdentification {get; set;}
    [XmlElement(Order=4)]
    public string D_C04005_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_C04006_ReferenceIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_AdjustedRepricedClaimNumber_2 {
    [XmlElement(Order=0)]
    public X12_ID_128_19 D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_AdjustedRepricedClaimReferenceNumber {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03_Description {get; set;}
    [XmlElement(Order=3)]
    public C_C040_ReferenceIdentifier_64 C_C040_ReferenceIdentifier_64 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C040_ReferenceIdentifier_64 {
    [XmlElement(Order=0)]
    public string D_C04001_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C04002_ReferenceIdentification {get; set;}
    [XmlElement(Order=2)]
    public string D_C04003_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C04004_ReferenceIdentification {get; set;}
    [XmlElement(Order=4)]
    public string D_C04005_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_C04006_ReferenceIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_InvestigationalDeviceExemptionNumber_2 {
    [XmlElement(Order=0)]
    public X12_ID_128_20 D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_InvestigationalDeviceExemptionIdentifier {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03_Description {get; set;}
    [XmlElement(Order=3)]
    public C_C040_ReferenceIdentifier_65 C_C040_ReferenceIdentifier_65 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C040_ReferenceIdentifier_65 {
    [XmlElement(Order=0)]
    public string D_C04001_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C04002_ReferenceIdentification {get; set;}
    [XmlElement(Order=2)]
    public string D_C04003_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C04004_ReferenceIdentification {get; set;}
    [XmlElement(Order=4)]
    public string D_C04005_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_C04006_ReferenceIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_ClaimIdentifierForTransmissionIntermediaries_2 {
    [XmlElement(Order=0)]
    public X12_ID_128_21 D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_ValueAddedNetworkTraceNumber {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03_Description {get; set;}
    [XmlElement(Order=3)]
    public C_C040_ReferenceIdentifier_66 C_C040_ReferenceIdentifier_66 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C040_ReferenceIdentifier_66 {
    [XmlElement(Order=0)]
    public string D_C04001_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C04002_ReferenceIdentification {get; set;}
    [XmlElement(Order=2)]
    public string D_C04003_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C04004_ReferenceIdentification {get; set;}
    [XmlElement(Order=4)]
    public string D_C04005_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_C04006_ReferenceIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_MedicalRecordNumber_2 {
    [XmlElement(Order=0)]
    public X12_ID_128_22 D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_MedicalRecordNumber {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03_Description {get; set;}
    [XmlElement(Order=3)]
    public C_C040_ReferenceIdentifier_67 C_C040_ReferenceIdentifier_67 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C040_ReferenceIdentifier_67 {
    [XmlElement(Order=0)]
    public string D_C04001_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C04002_ReferenceIdentification {get; set;}
    [XmlElement(Order=2)]
    public string D_C04003_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C04004_ReferenceIdentification {get; set;}
    [XmlElement(Order=4)]
    public string D_C04005_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_C04006_ReferenceIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_DemonstrationProjectIdentifier_2 {
    [XmlElement(Order=0)]
    public X12_ID_128_23 D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_DemonstrationProjectIdentifier {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03_Description {get; set;}
    [XmlElement(Order=3)]
    public C_C040_ReferenceIdentifier_68 C_C040_ReferenceIdentifier_68 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C040_ReferenceIdentifier_68 {
    [XmlElement(Order=0)]
    public string D_C04001_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C04002_ReferenceIdentification {get; set;}
    [XmlElement(Order=2)]
    public string D_C04003_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C04004_ReferenceIdentification {get; set;}
    [XmlElement(Order=4)]
    public string D_C04005_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_C04006_ReferenceIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_CarePlanOversight_2 {
    [XmlElement(Order=0)]
    public X12_ID_128_24 D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_CarePlanOversightNumber {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03_Description {get; set;}
    [XmlElement(Order=3)]
    public C_C040_ReferenceIdentifier_69 C_C040_ReferenceIdentifier_69 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C040_ReferenceIdentifier_69 {
    [XmlElement(Order=0)]
    public string D_C04001_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C04002_ReferenceIdentification {get; set;}
    [XmlElement(Order=2)]
    public string D_C04003_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C04004_ReferenceIdentification {get; set;}
    [XmlElement(Order=4)]
    public string D_C04005_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_C04006_ReferenceIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_K3_FileInformation_3 {
    [XmlElement(Order=0)]
    public string D_K301_FixedFormatInformation {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1333 D_K302_RecordFormatCode {get; set;}
    [XmlElement(Order=2)]
    public C_C001_CompositeUnitofMeasure_7 C_C001_CompositeUnitofMeasure_7 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C001_CompositeUnitofMeasure_7 {
    [XmlElement(Order=0)]
    public string D_C00101_UnitorBasisforMeasurementCode {get; set;}
    [XmlElement(Order=1)]
    public string D_C00102_Exponent {get; set;}
    [XmlElement(Order=2)]
    public string D_C00103_Multiplier {get; set;}
    [XmlElement(Order=3)]
    public string D_C00104_UnitorBasisforMeasurementCode {get; set;}
    [XmlElement(Order=4)]
    public string D_C00105_Exponent {get; set;}
    [XmlElement(Order=5)]
    public string D_C00106_Multiplier {get; set;}
    [XmlElement(Order=6)]
    public string D_C00107_UnitorBasisforMeasurementCode {get; set;}
    [XmlElement(Order=7)]
    public string D_C00108_Exponent {get; set;}
    [XmlElement(Order=8)]
    public string D_C00109_Multiplier {get; set;}
    [XmlElement(Order=9)]
    public string D_C00110_UnitorBasisforMeasurementCode {get; set;}
    [XmlElement(Order=10)]
    public string D_C00111_Exponent {get; set;}
    [XmlElement(Order=11)]
    public string D_C00112_Multiplier {get; set;}
    [XmlElement(Order=12)]
    public string D_C00113_UnitorBasisforMeasurementCode {get; set;}
    [XmlElement(Order=13)]
    public string D_C00114_Exponent {get; set;}
    [XmlElement(Order=14)]
    public string D_C00115_Multiplier {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_NTE_ClaimNote_2 {
    [XmlElement(Order=0)]
    public X12_ID_363 D_NTE01_NoteReferenceCode {get; set;}
    [XmlElement(Order=1)]
    public string D_NTE02_ClaimNoteText {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_CR1_AmbulanceTransportInformation_3 {
    [XmlElement(Order=0)]
    public X12_ID_355_3 D_CR101_UnitorBasisforMeasurementCode {get; set;}
    [XmlElement(Order=1)]
    public string D_CR102_PatientWeight {get; set;}
    [XmlElement(Order=2)]
    public string D_CR103_AmbulanceTransportCode {get; set;}
    [XmlElement(Order=3)]
    public string D_CR104_AmbulanceTransportReasonCode {get; set;}
    [XmlElement(Order=4)]
    public string D_CR105_UnitorBasisforMeasurementCode {get; set;}
    [XmlElement(Order=5)]
    public string D_CR106_TransportDistance {get; set;}
    [XmlElement(Order=6)]
    public string D_CR107_AddressInformation {get; set;}
    [XmlElement(Order=7)]
    public string D_CR108_AddressInformation {get; set;}
    [XmlElement(Order=8)]
    public string D_CR109_RoundTripPurposeDescription {get; set;}
    [XmlElement(Order=9)]
    public string D_CR110_StretcherPurposeDescription {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_CR2_SpinalManipulationServiceInformation_2 {
    [XmlElement(Order=0)]
    public string D_CR201_Count {get; set;}
    [XmlElement(Order=1)]
    public string D_CR202_Quantity {get; set;}
    [XmlElement(Order=2)]
    public string D_CR203_SubluxationLevelCode {get; set;}
    [XmlElement(Order=3)]
    public string D_CR204_SubluxationLevelCode {get; set;}
    [XmlElement(Order=4)]
    public string D_CR205_UnitorBasisforMeasurementCode {get; set;}
    [XmlElement(Order=5)]
    public string D_CR206_Quantity {get; set;}
    [XmlElement(Order=6)]
    public string D_CR207_Quantity {get; set;}
    [XmlElement(Order=7)]
    public string D_CR208_PatientConditionCode {get; set;}
    [XmlElement(Order=8)]
    public string D_CR209_Yes_NoConditionorResponseCode {get; set;}
    [XmlElement(Order=9)]
    public string D_CR210_PatientConditionDescription {get; set;}
    [XmlElement(Order=10)]
    public string D_CR211_PatientConditionDescription {get; set;}
    [XmlElement(Order=11)]
    public string D_CR212_Yes_NoConditionorResponseCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class A_CRC_3 {
    [XmlElement(Order=0)]
    public U_CRC_AmbulanceCertification_3 U_CRC_AmbulanceCertification_3 {get; set;}
    [XmlElement(Order=1)]
    public U_CRC_PatientConditionInformation_Vision_2 U_CRC_PatientConditionInformation_Vision_2 {get; set;}
    [XmlElementAttribute(Order=2)]
    public S_CRC_HomeboundIndicator_2 S_CRC_HomeboundIndicator_2 {get; set;}
    [XmlElementAttribute(Order=3)]
    public S_CRC_EPSDTReferral_2 S_CRC_EPSDTReferral_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_CRC_AmbulanceCertification_3 {
    [XmlElement(Order=0)]
    public X12_ID_1136 D_CRC01_CodeCategory {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1073_3 D_CRC02_CertificationConditionIndicator {get; set;}
    [XmlElement(Order=2)]
    public string D_CRC03_ConditionCode {get; set;}
    [XmlElement(Order=3)]
    public string D_CRC04_ConditionCode {get; set;}
    [XmlElement(Order=4)]
    public string D_CRC05_ConditionCode {get; set;}
    [XmlElement(Order=5)]
    public string D_CRC06_ConditionCode {get; set;}
    [XmlElement(Order=6)]
    public string D_CRC07_ConditionCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_CRC_PatientConditionInformation_Vision_2 {
    [XmlElement(Order=0)]
    public X12_ID_1136_2 D_CRC01_CodeCategory {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1073_3 D_CRC02_CertificationConditionIndicator {get; set;}
    [XmlElement(Order=2)]
    public string D_CRC03_ConditionCode {get; set;}
    [XmlElement(Order=3)]
    public string D_CRC04_ConditionCode {get; set;}
    [XmlElement(Order=4)]
    public string D_CRC05_ConditionCode {get; set;}
    [XmlElement(Order=5)]
    public string D_CRC06_ConditionCode {get; set;}
    [XmlElement(Order=6)]
    public string D_CRC07_ConditionCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_CRC_HomeboundIndicator_2 {
    [XmlElement(Order=0)]
    public X12_ID_1136_3 D_CRC01_CodeCategory {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1073_2 D_CRC02_CertificationConditionIndicator {get; set;}
    [XmlElement(Order=2)]
    public string D_CRC03_HomeboundIndicator {get; set;}
    [XmlElement(Order=3)]
    public string D_CRC04_ConditionIndicator {get; set;}
    [XmlElement(Order=4)]
    public string D_CRC05_ConditionIndicator {get; set;}
    [XmlElement(Order=5)]
    public string D_CRC06_ConditionIndicator {get; set;}
    [XmlElement(Order=6)]
    public string D_CRC07_ConditionIndicator {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_CRC_EPSDTReferral_2 {
    [XmlElement(Order=0)]
    public X12_ID_1136_4 D_CRC01_CodeQualifier {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1073_3 D_CRC02_CertificationConditionCodeAppliesIndicator {get; set;}
    [XmlElement(Order=2)]
    public string D_CRC03_ConditionIndicator {get; set;}
    [XmlElement(Order=3)]
    public string D_CRC04_ConditionIndicator {get; set;}
    [XmlElement(Order=4)]
    public string D_CRC05_ConditionIndicator {get; set;}
    [XmlElement(Order=5)]
    public string D_CRC06_ConditionIndicator {get; set;}
    [XmlElement(Order=6)]
    public string D_CRC07_ConditionIndicator {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class A_HI_2 {
    [XmlElementAttribute(Order=0)]
    public S_HI_HealthCareDiagnosisCode_2 S_HI_HealthCareDiagnosisCode_2 {get; set;}
    [XmlElementAttribute(Order=1)]
    public S_HI_AnesthesiaRelatedProcedure_2 S_HI_AnesthesiaRelatedProcedure_2 {get; set;}
    [XmlElement(Order=2)]
    public U_HI_ConditionInformation_2 U_HI_ConditionInformation_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_HI_HealthCareDiagnosisCode_2 {
    [XmlElement(Order=0)]
    public C_C022_HealthCareCodeInformation_37 C_C022_HealthCareCodeInformation_37 {get; set;}
    [XmlElement(Order=1)]
    public C_C022_HealthCareCodeInformation_38 C_C022_HealthCareCodeInformation_38 {get; set;}
    [XmlElement(Order=2)]
    public C_C022_HealthCareCodeInformation_39 C_C022_HealthCareCodeInformation_39 {get; set;}
    [XmlElement(Order=3)]
    public C_C022_HealthCareCodeInformation_40 C_C022_HealthCareCodeInformation_40 {get; set;}
    [XmlElement(Order=4)]
    public C_C022_HealthCareCodeInformation_41 C_C022_HealthCareCodeInformation_41 {get; set;}
    [XmlElement(Order=5)]
    public C_C022_HealthCareCodeInformation_42 C_C022_HealthCareCodeInformation_42 {get; set;}
    [XmlElement(Order=6)]
    public C_C022_HealthCareCodeInformation_43 C_C022_HealthCareCodeInformation_43 {get; set;}
    [XmlElement(Order=7)]
    public C_C022_HealthCareCodeInformation_44 C_C022_HealthCareCodeInformation_44 {get; set;}
    [XmlElement(Order=8)]
    public C_C022_HealthCareCodeInformation_45 C_C022_HealthCareCodeInformation_45 {get; set;}
    [XmlElement(Order=9)]
    public C_C022_HealthCareCodeInformation_46 C_C022_HealthCareCodeInformation_46 {get; set;}
    [XmlElement(Order=10)]
    public C_C022_HealthCareCodeInformation_47 C_C022_HealthCareCodeInformation_47 {get; set;}
    [XmlElement(Order=11)]
    public C_C022_HealthCareCodeInformation_48 C_C022_HealthCareCodeInformation_48 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C022_HealthCareCodeInformation_37 {
    [XmlElement(Order=0)]
    public X12_ID_1270_2 D_C02201_DiagnosisTypeCode {get; set;}
    [XmlElement(Order=1)]
    public string D_C02202_DiagnosisCode {get; set;}
    [XmlElement(Order=2)]
    public string D_C02203_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C02204_DateTimePeriod {get; set;}
    [XmlElement(Order=4)]
    public string D_C02205_MonetaryAmount {get; set;}
    [XmlElement(Order=5)]
    public string D_C02206_Quantity {get; set;}
    [XmlElement(Order=6)]
    public string D_C02207_VersionIdentifier {get; set;}
    [XmlElement(Order=7)]
    public string D_C02208_IndustryCode {get; set;}
    [XmlElement(Order=8)]
    public string D_C02209_Yes_NoConditionorResponseCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C022_HealthCareCodeInformation_38 {
    [XmlElement(Order=0)]
    public X12_ID_1270_3 D_C02201_DiagnosisTypeCode {get; set;}
    [XmlElement(Order=1)]
    public string D_C02202_DiagnosisCode {get; set;}
    [XmlElement(Order=2)]
    public string D_C02203_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C02204_DateTimePeriod {get; set;}
    [XmlElement(Order=4)]
    public string D_C02205_MonetaryAmount {get; set;}
    [XmlElement(Order=5)]
    public string D_C02206_Quantity {get; set;}
    [XmlElement(Order=6)]
    public string D_C02207_VersionIdentifier {get; set;}
    [XmlElement(Order=7)]
    public string D_C02208_IndustryCode {get; set;}
    [XmlElement(Order=8)]
    public string D_C02209_Yes_NoConditionorResponseCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C022_HealthCareCodeInformation_39 {
    [XmlElement(Order=0)]
    public string D_C02201_DiagnosisTypeCode {get; set;}
    [XmlElement(Order=1)]
    public string D_C02202_DiagnosisCode {get; set;}
    [XmlElement(Order=2)]
    public string D_C02203_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C02204_DateTimePeriod {get; set;}
    [XmlElement(Order=4)]
    public string D_C02205_MonetaryAmount {get; set;}
    [XmlElement(Order=5)]
    public string D_C02206_Quantity {get; set;}
    [XmlElement(Order=6)]
    public string D_C02207_VersionIdentifier {get; set;}
    [XmlElement(Order=7)]
    public string D_C02208_IndustryCode {get; set;}
    [XmlElement(Order=8)]
    public string D_C02209_Yes_NoConditionorResponseCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C022_HealthCareCodeInformation_40 {
    [XmlElement(Order=0)]
    public string D_C02201_DiagnosisTypeCode {get; set;}
    [XmlElement(Order=1)]
    public string D_C02202_DiagnosisCode {get; set;}
    [XmlElement(Order=2)]
    public string D_C02203_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C02204_DateTimePeriod {get; set;}
    [XmlElement(Order=4)]
    public string D_C02205_MonetaryAmount {get; set;}
    [XmlElement(Order=5)]
    public string D_C02206_Quantity {get; set;}
    [XmlElement(Order=6)]
    public string D_C02207_VersionIdentifier {get; set;}
    [XmlElement(Order=7)]
    public string D_C02208_IndustryCode {get; set;}
    [XmlElement(Order=8)]
    public string D_C02209_Yes_NoConditionorResponseCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C022_HealthCareCodeInformation_41 {
    [XmlElement(Order=0)]
    public string D_C02201_DiagnosisTypeCode {get; set;}
    [XmlElement(Order=1)]
    public string D_C02202_DiagnosisCode {get; set;}
    [XmlElement(Order=2)]
    public string D_C02203_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C02204_DateTimePeriod {get; set;}
    [XmlElement(Order=4)]
    public string D_C02205_MonetaryAmount {get; set;}
    [XmlElement(Order=5)]
    public string D_C02206_Quantity {get; set;}
    [XmlElement(Order=6)]
    public string D_C02207_VersionIdentifier {get; set;}
    [XmlElement(Order=7)]
    public string D_C02208_IndustryCode {get; set;}
    [XmlElement(Order=8)]
    public string D_C02209_Yes_NoConditionorResponseCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C022_HealthCareCodeInformation_42 {
    [XmlElement(Order=0)]
    public string D_C02201_DiagnosisTypeCode {get; set;}
    [XmlElement(Order=1)]
    public string D_C02202_DiagnosisCode {get; set;}
    [XmlElement(Order=2)]
    public string D_C02203_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C02204_DateTimePeriod {get; set;}
    [XmlElement(Order=4)]
    public string D_C02205_MonetaryAmount {get; set;}
    [XmlElement(Order=5)]
    public string D_C02206_Quantity {get; set;}
    [XmlElement(Order=6)]
    public string D_C02207_VersionIdentifier {get; set;}
    [XmlElement(Order=7)]
    public string D_C02208_IndustryCode {get; set;}
    [XmlElement(Order=8)]
    public string D_C02209_Yes_NoConditionorResponseCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C022_HealthCareCodeInformation_43 {
    [XmlElement(Order=0)]
    public string D_C02201_DiagnosisTypeCode {get; set;}
    [XmlElement(Order=1)]
    public string D_C02202_DiagnosisCode {get; set;}
    [XmlElement(Order=2)]
    public string D_C02203_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C02204_DateTimePeriod {get; set;}
    [XmlElement(Order=4)]
    public string D_C02205_MonetaryAmount {get; set;}
    [XmlElement(Order=5)]
    public string D_C02206_Quantity {get; set;}
    [XmlElement(Order=6)]
    public string D_C02207_VersionIdentifier {get; set;}
    [XmlElement(Order=7)]
    public string D_C02208_IndustryCode {get; set;}
    [XmlElement(Order=8)]
    public string D_C02209_Yes_NoConditionorResponseCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C022_HealthCareCodeInformation_44 {
    [XmlElement(Order=0)]
    public string D_C02201_DiagnosisTypeCode {get; set;}
    [XmlElement(Order=1)]
    public string D_C02202_DiagnosisCode {get; set;}
    [XmlElement(Order=2)]
    public string D_C02203_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C02204_DateTimePeriod {get; set;}
    [XmlElement(Order=4)]
    public string D_C02205_MonetaryAmount {get; set;}
    [XmlElement(Order=5)]
    public string D_C02206_Quantity {get; set;}
    [XmlElement(Order=6)]
    public string D_C02207_VersionIdentifier {get; set;}
    [XmlElement(Order=7)]
    public string D_C02208_IndustryCode {get; set;}
    [XmlElement(Order=8)]
    public string D_C02209_Yes_NoConditionorResponseCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C022_HealthCareCodeInformation_45 {
    [XmlElement(Order=0)]
    public string D_C02201_DiagnosisTypeCode {get; set;}
    [XmlElement(Order=1)]
    public string D_C02202_DiagnosisCode {get; set;}
    [XmlElement(Order=2)]
    public string D_C02203_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C02204_DateTimePeriod {get; set;}
    [XmlElement(Order=4)]
    public string D_C02205_MonetaryAmount {get; set;}
    [XmlElement(Order=5)]
    public string D_C02206_Quantity {get; set;}
    [XmlElement(Order=6)]
    public string D_C02207_VersionIdentifier {get; set;}
    [XmlElement(Order=7)]
    public string D_C02208_IndustryCode {get; set;}
    [XmlElement(Order=8)]
    public string D_C02209_Yes_NoConditionorResponseCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C022_HealthCareCodeInformation_46 {
    [XmlElement(Order=0)]
    public string D_C02201_DiagnosisTypeCode {get; set;}
    [XmlElement(Order=1)]
    public string D_C02202_DiagnosisCode {get; set;}
    [XmlElement(Order=2)]
    public string D_C02203_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C02204_DateTimePeriod {get; set;}
    [XmlElement(Order=4)]
    public string D_C02205_MonetaryAmount {get; set;}
    [XmlElement(Order=5)]
    public string D_C02206_Quantity {get; set;}
    [XmlElement(Order=6)]
    public string D_C02207_VersionIdentifier {get; set;}
    [XmlElement(Order=7)]
    public string D_C02208_IndustryCode {get; set;}
    [XmlElement(Order=8)]
    public string D_C02209_Yes_NoConditionorResponseCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C022_HealthCareCodeInformation_47 {
    [XmlElement(Order=0)]
    public string D_C02201_DiagnosisTypeCode {get; set;}
    [XmlElement(Order=1)]
    public string D_C02202_DiagnosisCode {get; set;}
    [XmlElement(Order=2)]
    public string D_C02203_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C02204_DateTimePeriod {get; set;}
    [XmlElement(Order=4)]
    public string D_C02205_MonetaryAmount {get; set;}
    [XmlElement(Order=5)]
    public string D_C02206_Quantity {get; set;}
    [XmlElement(Order=6)]
    public string D_C02207_VersionIdentifier {get; set;}
    [XmlElement(Order=7)]
    public string D_C02208_IndustryCode {get; set;}
    [XmlElement(Order=8)]
    public string D_C02209_Yes_NoConditionorResponseCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C022_HealthCareCodeInformation_48 {
    [XmlElement(Order=0)]
    public string D_C02201_DiagnosisTypeCode {get; set;}
    [XmlElement(Order=1)]
    public string D_C02202_DiagnosisCode {get; set;}
    [XmlElement(Order=2)]
    public string D_C02203_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C02204_DateTimePeriod {get; set;}
    [XmlElement(Order=4)]
    public string D_C02205_MonetaryAmount {get; set;}
    [XmlElement(Order=5)]
    public string D_C02206_Quantity {get; set;}
    [XmlElement(Order=6)]
    public string D_C02207_VersionIdentifier {get; set;}
    [XmlElement(Order=7)]
    public string D_C02208_IndustryCode {get; set;}
    [XmlElement(Order=8)]
    public string D_C02209_Yes_NoConditionorResponseCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_HI_AnesthesiaRelatedProcedure_2 {
    [XmlElement(Order=0)]
    public C_C022_HealthCareCodeInformation_49 C_C022_HealthCareCodeInformation_49 {get; set;}
    [XmlElement(Order=1)]
    public C_C022_HealthCareCodeInformation_50 C_C022_HealthCareCodeInformation_50 {get; set;}
    [XmlElement(Order=2)]
    public C_C022_HealthCareCodeInformation_51 C_C022_HealthCareCodeInformation_51 {get; set;}
    [XmlElement(Order=3)]
    public C_C022_HealthCareCodeInformation_52 C_C022_HealthCareCodeInformation_52 {get; set;}
    [XmlElement(Order=4)]
    public C_C022_HealthCareCodeInformation_53 C_C022_HealthCareCodeInformation_53 {get; set;}
    [XmlElement(Order=5)]
    public C_C022_HealthCareCodeInformation_54 C_C022_HealthCareCodeInformation_54 {get; set;}
    [XmlElement(Order=6)]
    public C_C022_HealthCareCodeInformation_55 C_C022_HealthCareCodeInformation_55 {get; set;}
    [XmlElement(Order=7)]
    public C_C022_HealthCareCodeInformation_56 C_C022_HealthCareCodeInformation_56 {get; set;}
    [XmlElement(Order=8)]
    public C_C022_HealthCareCodeInformation_57 C_C022_HealthCareCodeInformation_57 {get; set;}
    [XmlElement(Order=9)]
    public C_C022_HealthCareCodeInformation_58 C_C022_HealthCareCodeInformation_58 {get; set;}
    [XmlElement(Order=10)]
    public C_C022_HealthCareCodeInformation_59 C_C022_HealthCareCodeInformation_59 {get; set;}
    [XmlElement(Order=11)]
    public C_C022_HealthCareCodeInformation_60 C_C022_HealthCareCodeInformation_60 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C022_HealthCareCodeInformation_49 {
    [XmlElement(Order=0)]
    public X12_ID_1270_4 D_C02201_CodeListQualifierCode {get; set;}
    [XmlElement(Order=1)]
    public string D_C02202_AnesthesiaRelatedSurgicalProcedure {get; set;}
    [XmlElement(Order=2)]
    public string D_C02203_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C02204_DateTimePeriod {get; set;}
    [XmlElement(Order=4)]
    public string D_C02205_MonetaryAmount {get; set;}
    [XmlElement(Order=5)]
    public string D_C02206_Quantity {get; set;}
    [XmlElement(Order=6)]
    public string D_C02207_VersionIdentifier {get; set;}
    [XmlElement(Order=7)]
    public string D_C02208_IndustryCode {get; set;}
    [XmlElement(Order=8)]
    public string D_C02209_Yes_NoConditionorResponseCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C022_HealthCareCodeInformation_50 {
    [XmlElement(Order=0)]
    public X12_ID_1270_5 D_C02201_CodeListQualifierCode {get; set;}
    [XmlElement(Order=1)]
    public string D_C02202_IndustryCode {get; set;}
    [XmlElement(Order=2)]
    public string D_C02203_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C02204_DateTimePeriod {get; set;}
    [XmlElement(Order=4)]
    public string D_C02205_MonetaryAmount {get; set;}
    [XmlElement(Order=5)]
    public string D_C02206_Quantity {get; set;}
    [XmlElement(Order=6)]
    public string D_C02207_VersionIdentifier {get; set;}
    [XmlElement(Order=7)]
    public string D_C02208_IndustryCode {get; set;}
    [XmlElement(Order=8)]
    public string D_C02209_Yes_NoConditionorResponseCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C022_HealthCareCodeInformation_51 {
    [XmlElement(Order=0)]
    public string D_C02201_CodeListQualifierCode {get; set;}
    [XmlElement(Order=1)]
    public string D_C02202_IndustryCode {get; set;}
    [XmlElement(Order=2)]
    public string D_C02203_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C02204_DateTimePeriod {get; set;}
    [XmlElement(Order=4)]
    public string D_C02205_MonetaryAmount {get; set;}
    [XmlElement(Order=5)]
    public string D_C02206_Quantity {get; set;}
    [XmlElement(Order=6)]
    public string D_C02207_VersionIdentifier {get; set;}
    [XmlElement(Order=7)]
    public string D_C02208_IndustryCode {get; set;}
    [XmlElement(Order=8)]
    public string D_C02209_Yes_NoConditionorResponseCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C022_HealthCareCodeInformation_52 {
    [XmlElement(Order=0)]
    public string D_C02201_CodeListQualifierCode {get; set;}
    [XmlElement(Order=1)]
    public string D_C02202_IndustryCode {get; set;}
    [XmlElement(Order=2)]
    public string D_C02203_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C02204_DateTimePeriod {get; set;}
    [XmlElement(Order=4)]
    public string D_C02205_MonetaryAmount {get; set;}
    [XmlElement(Order=5)]
    public string D_C02206_Quantity {get; set;}
    [XmlElement(Order=6)]
    public string D_C02207_VersionIdentifier {get; set;}
    [XmlElement(Order=7)]
    public string D_C02208_IndustryCode {get; set;}
    [XmlElement(Order=8)]
    public string D_C02209_Yes_NoConditionorResponseCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C022_HealthCareCodeInformation_53 {
    [XmlElement(Order=0)]
    public string D_C02201_CodeListQualifierCode {get; set;}
    [XmlElement(Order=1)]
    public string D_C02202_IndustryCode {get; set;}
    [XmlElement(Order=2)]
    public string D_C02203_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C02204_DateTimePeriod {get; set;}
    [XmlElement(Order=4)]
    public string D_C02205_MonetaryAmount {get; set;}
    [XmlElement(Order=5)]
    public string D_C02206_Quantity {get; set;}
    [XmlElement(Order=6)]
    public string D_C02207_VersionIdentifier {get; set;}
    [XmlElement(Order=7)]
    public string D_C02208_IndustryCode {get; set;}
    [XmlElement(Order=8)]
    public string D_C02209_Yes_NoConditionorResponseCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C022_HealthCareCodeInformation_54 {
    [XmlElement(Order=0)]
    public string D_C02201_CodeListQualifierCode {get; set;}
    [XmlElement(Order=1)]
    public string D_C02202_IndustryCode {get; set;}
    [XmlElement(Order=2)]
    public string D_C02203_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C02204_DateTimePeriod {get; set;}
    [XmlElement(Order=4)]
    public string D_C02205_MonetaryAmount {get; set;}
    [XmlElement(Order=5)]
    public string D_C02206_Quantity {get; set;}
    [XmlElement(Order=6)]
    public string D_C02207_VersionIdentifier {get; set;}
    [XmlElement(Order=7)]
    public string D_C02208_IndustryCode {get; set;}
    [XmlElement(Order=8)]
    public string D_C02209_Yes_NoConditionorResponseCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C022_HealthCareCodeInformation_55 {
    [XmlElement(Order=0)]
    public string D_C02201_CodeListQualifierCode {get; set;}
    [XmlElement(Order=1)]
    public string D_C02202_IndustryCode {get; set;}
    [XmlElement(Order=2)]
    public string D_C02203_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C02204_DateTimePeriod {get; set;}
    [XmlElement(Order=4)]
    public string D_C02205_MonetaryAmount {get; set;}
    [XmlElement(Order=5)]
    public string D_C02206_Quantity {get; set;}
    [XmlElement(Order=6)]
    public string D_C02207_VersionIdentifier {get; set;}
    [XmlElement(Order=7)]
    public string D_C02208_IndustryCode {get; set;}
    [XmlElement(Order=8)]
    public string D_C02209_Yes_NoConditionorResponseCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C022_HealthCareCodeInformation_56 {
    [XmlElement(Order=0)]
    public string D_C02201_CodeListQualifierCode {get; set;}
    [XmlElement(Order=1)]
    public string D_C02202_IndustryCode {get; set;}
    [XmlElement(Order=2)]
    public string D_C02203_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C02204_DateTimePeriod {get; set;}
    [XmlElement(Order=4)]
    public string D_C02205_MonetaryAmount {get; set;}
    [XmlElement(Order=5)]
    public string D_C02206_Quantity {get; set;}
    [XmlElement(Order=6)]
    public string D_C02207_VersionIdentifier {get; set;}
    [XmlElement(Order=7)]
    public string D_C02208_IndustryCode {get; set;}
    [XmlElement(Order=8)]
    public string D_C02209_Yes_NoConditionorResponseCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C022_HealthCareCodeInformation_57 {
    [XmlElement(Order=0)]
    public string D_C02201_CodeListQualifierCode {get; set;}
    [XmlElement(Order=1)]
    public string D_C02202_IndustryCode {get; set;}
    [XmlElement(Order=2)]
    public string D_C02203_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C02204_DateTimePeriod {get; set;}
    [XmlElement(Order=4)]
    public string D_C02205_MonetaryAmount {get; set;}
    [XmlElement(Order=5)]
    public string D_C02206_Quantity {get; set;}
    [XmlElement(Order=6)]
    public string D_C02207_VersionIdentifier {get; set;}
    [XmlElement(Order=7)]
    public string D_C02208_IndustryCode {get; set;}
    [XmlElement(Order=8)]
    public string D_C02209_Yes_NoConditionorResponseCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C022_HealthCareCodeInformation_58 {
    [XmlElement(Order=0)]
    public string D_C02201_CodeListQualifierCode {get; set;}
    [XmlElement(Order=1)]
    public string D_C02202_IndustryCode {get; set;}
    [XmlElement(Order=2)]
    public string D_C02203_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C02204_DateTimePeriod {get; set;}
    [XmlElement(Order=4)]
    public string D_C02205_MonetaryAmount {get; set;}
    [XmlElement(Order=5)]
    public string D_C02206_Quantity {get; set;}
    [XmlElement(Order=6)]
    public string D_C02207_VersionIdentifier {get; set;}
    [XmlElement(Order=7)]
    public string D_C02208_IndustryCode {get; set;}
    [XmlElement(Order=8)]
    public string D_C02209_Yes_NoConditionorResponseCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C022_HealthCareCodeInformation_59 {
    [XmlElement(Order=0)]
    public string D_C02201_CodeListQualifierCode {get; set;}
    [XmlElement(Order=1)]
    public string D_C02202_IndustryCode {get; set;}
    [XmlElement(Order=2)]
    public string D_C02203_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C02204_DateTimePeriod {get; set;}
    [XmlElement(Order=4)]
    public string D_C02205_MonetaryAmount {get; set;}
    [XmlElement(Order=5)]
    public string D_C02206_Quantity {get; set;}
    [XmlElement(Order=6)]
    public string D_C02207_VersionIdentifier {get; set;}
    [XmlElement(Order=7)]
    public string D_C02208_IndustryCode {get; set;}
    [XmlElement(Order=8)]
    public string D_C02209_Yes_NoConditionorResponseCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C022_HealthCareCodeInformation_60 {
    [XmlElement(Order=0)]
    public string D_C02201_CodeListQualifierCode {get; set;}
    [XmlElement(Order=1)]
    public string D_C02202_IndustryCode {get; set;}
    [XmlElement(Order=2)]
    public string D_C02203_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C02204_DateTimePeriod {get; set;}
    [XmlElement(Order=4)]
    public string D_C02205_MonetaryAmount {get; set;}
    [XmlElement(Order=5)]
    public string D_C02206_Quantity {get; set;}
    [XmlElement(Order=6)]
    public string D_C02207_VersionIdentifier {get; set;}
    [XmlElement(Order=7)]
    public string D_C02208_IndustryCode {get; set;}
    [XmlElement(Order=8)]
    public string D_C02209_Yes_NoConditionorResponseCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_HI_ConditionInformation_2 {
    [XmlElement(Order=0)]
    public C_C022_HealthCareCodeInformation_61 C_C022_HealthCareCodeInformation_61 {get; set;}
    [XmlElement(Order=1)]
    public C_C022_HealthCareCodeInformation_62 C_C022_HealthCareCodeInformation_62 {get; set;}
    [XmlElement(Order=2)]
    public C_C022_HealthCareCodeInformation_63 C_C022_HealthCareCodeInformation_63 {get; set;}
    [XmlElement(Order=3)]
    public C_C022_HealthCareCodeInformation_64 C_C022_HealthCareCodeInformation_64 {get; set;}
    [XmlElement(Order=4)]
    public C_C022_HealthCareCodeInformation_65 C_C022_HealthCareCodeInformation_65 {get; set;}
    [XmlElement(Order=5)]
    public C_C022_HealthCareCodeInformation_66 C_C022_HealthCareCodeInformation_66 {get; set;}
    [XmlElement(Order=6)]
    public C_C022_HealthCareCodeInformation_67 C_C022_HealthCareCodeInformation_67 {get; set;}
    [XmlElement(Order=7)]
    public C_C022_HealthCareCodeInformation_68 C_C022_HealthCareCodeInformation_68 {get; set;}
    [XmlElement(Order=8)]
    public C_C022_HealthCareCodeInformation_69 C_C022_HealthCareCodeInformation_69 {get; set;}
    [XmlElement(Order=9)]
    public C_C022_HealthCareCodeInformation_70 C_C022_HealthCareCodeInformation_70 {get; set;}
    [XmlElement(Order=10)]
    public C_C022_HealthCareCodeInformation_71 C_C022_HealthCareCodeInformation_71 {get; set;}
    [XmlElement(Order=11)]
    public C_C022_HealthCareCodeInformation_72 C_C022_HealthCareCodeInformation_72 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C022_HealthCareCodeInformation_61 {
    [XmlElement(Order=0)]
    public X12_ID_1270_6 D_C02201_CodeListQualifierCode {get; set;}
    [XmlElement(Order=1)]
    public string D_C02202_ConditionCode {get; set;}
    [XmlElement(Order=2)]
    public string D_C02203_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C02204_DateTimePeriod {get; set;}
    [XmlElement(Order=4)]
    public string D_C02205_MonetaryAmount {get; set;}
    [XmlElement(Order=5)]
    public string D_C02206_Quantity {get; set;}
    [XmlElement(Order=6)]
    public string D_C02207_VersionIdentifier {get; set;}
    [XmlElement(Order=7)]
    public string D_C02208_IndustryCode {get; set;}
    [XmlElement(Order=8)]
    public string D_C02209_Yes_NoConditionorResponseCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C022_HealthCareCodeInformation_62 {
    [XmlElement(Order=0)]
    public X12_ID_1270_6 D_C02201_CodeListQualifierCode {get; set;}
    [XmlElement(Order=1)]
    public string D_C02202_ConditionCode {get; set;}
    [XmlElement(Order=2)]
    public string D_C02203_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C02204_DateTimePeriod {get; set;}
    [XmlElement(Order=4)]
    public string D_C02205_MonetaryAmount {get; set;}
    [XmlElement(Order=5)]
    public string D_C02206_Quantity {get; set;}
    [XmlElement(Order=6)]
    public string D_C02207_VersionIdentifier {get; set;}
    [XmlElement(Order=7)]
    public string D_C02208_IndustryCode {get; set;}
    [XmlElement(Order=8)]
    public string D_C02209_Yes_NoConditionorResponseCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C022_HealthCareCodeInformation_63 {
    [XmlElement(Order=0)]
    public string D_C02201_CodeListQualifierCode {get; set;}
    [XmlElement(Order=1)]
    public string D_C02202_ConditionCode {get; set;}
    [XmlElement(Order=2)]
    public string D_C02203_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C02204_DateTimePeriod {get; set;}
    [XmlElement(Order=4)]
    public string D_C02205_MonetaryAmount {get; set;}
    [XmlElement(Order=5)]
    public string D_C02206_Quantity {get; set;}
    [XmlElement(Order=6)]
    public string D_C02207_VersionIdentifier {get; set;}
    [XmlElement(Order=7)]
    public string D_C02208_IndustryCode {get; set;}
    [XmlElement(Order=8)]
    public string D_C02209_Yes_NoConditionorResponseCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C022_HealthCareCodeInformation_64 {
    [XmlElement(Order=0)]
    public string D_C02201_CodeListQualifierCode {get; set;}
    [XmlElement(Order=1)]
    public string D_C02202_ConditionCode {get; set;}
    [XmlElement(Order=2)]
    public string D_C02203_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C02204_DateTimePeriod {get; set;}
    [XmlElement(Order=4)]
    public string D_C02205_MonetaryAmount {get; set;}
    [XmlElement(Order=5)]
    public string D_C02206_Quantity {get; set;}
    [XmlElement(Order=6)]
    public string D_C02207_VersionIdentifier {get; set;}
    [XmlElement(Order=7)]
    public string D_C02208_IndustryCode {get; set;}
    [XmlElement(Order=8)]
    public string D_C02209_Yes_NoConditionorResponseCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C022_HealthCareCodeInformation_65 {
    [XmlElement(Order=0)]
    public string D_C02201_CodeListQualifierCode {get; set;}
    [XmlElement(Order=1)]
    public string D_C02202_ConditionCode {get; set;}
    [XmlElement(Order=2)]
    public string D_C02203_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C02204_DateTimePeriod {get; set;}
    [XmlElement(Order=4)]
    public string D_C02205_MonetaryAmount {get; set;}
    [XmlElement(Order=5)]
    public string D_C02206_Quantity {get; set;}
    [XmlElement(Order=6)]
    public string D_C02207_VersionIdentifier {get; set;}
    [XmlElement(Order=7)]
    public string D_C02208_IndustryCode {get; set;}
    [XmlElement(Order=8)]
    public string D_C02209_Yes_NoConditionorResponseCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C022_HealthCareCodeInformation_66 {
    [XmlElement(Order=0)]
    public string D_C02201_CodeListQualifierCode {get; set;}
    [XmlElement(Order=1)]
    public string D_C02202_ConditionCode {get; set;}
    [XmlElement(Order=2)]
    public string D_C02203_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C02204_DateTimePeriod {get; set;}
    [XmlElement(Order=4)]
    public string D_C02205_MonetaryAmount {get; set;}
    [XmlElement(Order=5)]
    public string D_C02206_Quantity {get; set;}
    [XmlElement(Order=6)]
    public string D_C02207_VersionIdentifier {get; set;}
    [XmlElement(Order=7)]
    public string D_C02208_IndustryCode {get; set;}
    [XmlElement(Order=8)]
    public string D_C02209_Yes_NoConditionorResponseCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C022_HealthCareCodeInformation_67 {
    [XmlElement(Order=0)]
    public string D_C02201_CodeListQualifierCode {get; set;}
    [XmlElement(Order=1)]
    public string D_C02202_ConditionCode {get; set;}
    [XmlElement(Order=2)]
    public string D_C02203_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C02204_DateTimePeriod {get; set;}
    [XmlElement(Order=4)]
    public string D_C02205_MonetaryAmount {get; set;}
    [XmlElement(Order=5)]
    public string D_C02206_Quantity {get; set;}
    [XmlElement(Order=6)]
    public string D_C02207_VersionIdentifier {get; set;}
    [XmlElement(Order=7)]
    public string D_C02208_IndustryCode {get; set;}
    [XmlElement(Order=8)]
    public string D_C02209_Yes_NoConditionorResponseCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C022_HealthCareCodeInformation_68 {
    [XmlElement(Order=0)]
    public string D_C02201_CodeListQualifierCode {get; set;}
    [XmlElement(Order=1)]
    public string D_C02202_ConditionCode {get; set;}
    [XmlElement(Order=2)]
    public string D_C02203_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C02204_DateTimePeriod {get; set;}
    [XmlElement(Order=4)]
    public string D_C02205_MonetaryAmount {get; set;}
    [XmlElement(Order=5)]
    public string D_C02206_Quantity {get; set;}
    [XmlElement(Order=6)]
    public string D_C02207_VersionIdentifier {get; set;}
    [XmlElement(Order=7)]
    public string D_C02208_IndustryCode {get; set;}
    [XmlElement(Order=8)]
    public string D_C02209_Yes_NoConditionorResponseCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C022_HealthCareCodeInformation_69 {
    [XmlElement(Order=0)]
    public string D_C02201_CodeListQualifierCode {get; set;}
    [XmlElement(Order=1)]
    public string D_C02202_ConditionCode {get; set;}
    [XmlElement(Order=2)]
    public string D_C02203_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C02204_DateTimePeriod {get; set;}
    [XmlElement(Order=4)]
    public string D_C02205_MonetaryAmount {get; set;}
    [XmlElement(Order=5)]
    public string D_C02206_Quantity {get; set;}
    [XmlElement(Order=6)]
    public string D_C02207_VersionIdentifier {get; set;}
    [XmlElement(Order=7)]
    public string D_C02208_IndustryCode {get; set;}
    [XmlElement(Order=8)]
    public string D_C02209_Yes_NoConditionorResponseCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C022_HealthCareCodeInformation_70 {
    [XmlElement(Order=0)]
    public string D_C02201_CodeListQualifierCode {get; set;}
    [XmlElement(Order=1)]
    public string D_C02202_ConditionCode {get; set;}
    [XmlElement(Order=2)]
    public string D_C02203_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C02204_DateTimePeriod {get; set;}
    [XmlElement(Order=4)]
    public string D_C02205_MonetaryAmount {get; set;}
    [XmlElement(Order=5)]
    public string D_C02206_Quantity {get; set;}
    [XmlElement(Order=6)]
    public string D_C02207_VersionIdentifier {get; set;}
    [XmlElement(Order=7)]
    public string D_C02208_IndustryCode {get; set;}
    [XmlElement(Order=8)]
    public string D_C02209_Yes_NoConditionorResponseCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C022_HealthCareCodeInformation_71 {
    [XmlElement(Order=0)]
    public string D_C02201_CodeListQualifierCode {get; set;}
    [XmlElement(Order=1)]
    public string D_C02202_ConditionCode {get; set;}
    [XmlElement(Order=2)]
    public string D_C02203_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C02204_DateTimePeriod {get; set;}
    [XmlElement(Order=4)]
    public string D_C02205_MonetaryAmount {get; set;}
    [XmlElement(Order=5)]
    public string D_C02206_Quantity {get; set;}
    [XmlElement(Order=6)]
    public string D_C02207_VersionIdentifier {get; set;}
    [XmlElement(Order=7)]
    public string D_C02208_IndustryCode {get; set;}
    [XmlElement(Order=8)]
    public string D_C02209_Yes_NoConditionorResponseCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C022_HealthCareCodeInformation_72 {
    [XmlElement(Order=0)]
    public string D_C02201_CodeListQualifierCode {get; set;}
    [XmlElement(Order=1)]
    public string D_C02202_ConditionCode {get; set;}
    [XmlElement(Order=2)]
    public string D_C02203_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C02204_DateTimePeriod {get; set;}
    [XmlElement(Order=4)]
    public string D_C02205_MonetaryAmount {get; set;}
    [XmlElement(Order=5)]
    public string D_C02206_Quantity {get; set;}
    [XmlElement(Order=6)]
    public string D_C02207_VersionIdentifier {get; set;}
    [XmlElement(Order=7)]
    public string D_C02208_IndustryCode {get; set;}
    [XmlElement(Order=8)]
    public string D_C02209_Yes_NoConditionorResponseCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_HCP_ClaimPricing_RepricingInformation_2 {
    [XmlElement(Order=0)]
    public X12_ID_1473 D_HCP01_PricingMethodology {get; set;}
    [XmlElement(Order=1)]
    public string D_HCP02_RepricedAllowedAmount {get; set;}
    [XmlElement(Order=2)]
    public string D_HCP03_RepricedSavingAmount {get; set;}
    [XmlElement(Order=3)]
    public string D_HCP04_RepricingOrganizationIdentifier {get; set;}
    [XmlElement(Order=4)]
    public string D_HCP05_RepricingPerDiemorFlatRateAmount {get; set;}
    [XmlElement(Order=5)]
    public string D_HCP06_RepricedApprovedAmbulatoryPatientGroupCode {get; set;}
    [XmlElement(Order=6)]
    public string D_HCP07_RepricedApprovedAmbulatoryPatientGroupAmount {get; set;}
    [XmlElement(Order=7)]
    public string D_HCP08_Product_ServiceID {get; set;}
    [XmlElement(Order=8)]
    public string D_HCP09_Product_ServiceIDQualifier {get; set;}
    [XmlElement(Order=9)]
    public string D_HCP10_Product_ServiceID {get; set;}
    [XmlElement(Order=10)]
    public string D_HCP11_UnitorBasisforMeasurementCode {get; set;}
    [XmlElement(Order=11)]
    public string D_HCP12_Quantity {get; set;}
    [XmlElement(Order=12)]
    public string D_HCP13_RejectReasonCode {get; set;}
    [XmlElement(Order=13)]
    public string D_HCP14_PolicyComplianceCode {get; set;}
    [XmlElement(Order=14)]
    public string D_HCP15_ExceptionCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class A_NM1_7 {
    [XmlElement(Order=0)]
    public U_TS837_2310A_1 U_TS837_2310A_1 {get; set;}
    [XmlElementAttribute(Order=1)]
    public G_TS837_2310B_1 G_TS837_2310B_1 {get; set;}
    [XmlElementAttribute(Order=2)]
    public G_TS837_2310C_1 G_TS837_2310C_1 {get; set;}
    [XmlElementAttribute(Order=3)]
    public G_TS837_2310D_1 G_TS837_2310D_1 {get; set;}
    [XmlElementAttribute(Order=4)]
    public G_TS837_2310E_1 G_TS837_2310E_1 {get; set;}
    [XmlElementAttribute(Order=5)]
    public G_TS837_2310F_1 G_TS837_2310F_1 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_TS837_2310A_1 {
    [XmlElement(Order=0)]
    public S_NM1_ReferringProviderName_3 S_NM1_ReferringProviderName_3 {get; set;}
    [XmlElement("S_REF_ReferringProviderSecondaryIdentification_3",Order=1)]
    public List<S_REF_ReferringProviderSecondaryIdentification_3> S_REF_ReferringProviderSecondaryIdentification_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_NM1_ReferringProviderName_3 {
    [XmlElement(Order=0)]
    public X12_ID_98_9 D_NM101_EntityIdentifierCode {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1065_3 D_NM102_EntityTypeQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_NM103_ReferringProviderLastName {get; set;}
    [XmlElement(Order=3)]
    public string D_NM104_ReferringProviderFirstName {get; set;}
    [XmlElement(Order=4)]
    public string D_NM105_ReferringProviderMiddleNameorInitial {get; set;}
    [XmlElement(Order=5)]
    public string D_NM106_NamePrefix {get; set;}
    [XmlElement(Order=6)]
    public string D_NM107_ReferringProviderNameSuffix {get; set;}
    [XmlElement(Order=7)]
    public string D_NM108_IdentificationCodeQualifier {get; set;}
    [XmlElement(Order=8)]
    public string D_NM109_ReferringProviderIdentifier {get; set;}
    [XmlElement(Order=9)]
    public string D_NM110_EntityRelationshipCode {get; set;}
    [XmlElement(Order=10)]
    public string D_NM111_EntityIdentifierCode {get; set;}
    [XmlElement(Order=11)]
    public string D_NM112_NameLastorOrganizationName {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_ReferringProviderSecondaryIdentification_3 {
    [XmlElement(Order=0)]
    public X12_ID_128_25 D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_ReferringProviderSecondaryIdentifier {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03_Description {get; set;}
    [XmlElement(Order=3)]
    public C_C040_ReferenceIdentifier_70 C_C040_ReferenceIdentifier_70 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C040_ReferenceIdentifier_70 {
    [XmlElement(Order=0)]
    public string D_C04001_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C04002_ReferenceIdentification {get; set;}
    [XmlElement(Order=2)]
    public string D_C04003_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C04004_ReferenceIdentification {get; set;}
    [XmlElement(Order=4)]
    public string D_C04005_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_C04006_ReferenceIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_TS837_2310B_1 {
    [XmlElement(Order=0)]
    public S_NM1_RenderingProviderName_3 S_NM1_RenderingProviderName_3 {get; set;}
    [XmlElement(Order=1)]
    public S_PRV_RenderingProviderSpecialtyInformation_3 S_PRV_RenderingProviderSpecialtyInformation_3 {get; set;}
    [XmlElement("S_REF_RenderingProviderSecondaryIdentification_3",Order=2)]
    public List<S_REF_RenderingProviderSecondaryIdentification_3> S_REF_RenderingProviderSecondaryIdentification_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_NM1_RenderingProviderName_3 {
    [XmlElement(Order=0)]
    public X12_ID_98_10 D_NM101_EntityIdentifierCode {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1065 D_NM102_EntityTypeQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_NM103_RenderingProviderLastorOrganizationName {get; set;}
    [XmlElement(Order=3)]
    public string D_NM104_RenderingProviderFirstName {get; set;}
    [XmlElement(Order=4)]
    public string D_NM105_RenderingProviderMiddleNameorInitial {get; set;}
    [XmlElement(Order=5)]
    public string D_NM106_NamePrefix {get; set;}
    [XmlElement(Order=6)]
    public string D_NM107_RenderingProviderNameSuffix {get; set;}
    [XmlElement(Order=7)]
    public string D_NM108_IdentificationCodeQualifier {get; set;}
    [XmlElement(Order=8)]
    public string D_NM109_RenderingProviderIdentifier {get; set;}
    [XmlElement(Order=9)]
    public string D_NM110_EntityRelationshipCode {get; set;}
    [XmlElement(Order=10)]
    public string D_NM111_EntityIdentifierCode {get; set;}
    [XmlElement(Order=11)]
    public string D_NM112_NameLastorOrganizationName {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_PRV_RenderingProviderSpecialtyInformation_3 {
    [XmlElement(Order=0)]
    public X12_ID_1221_2 D_PRV01_ProviderCode {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_128 D_PRV02_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_PRV03_ProviderTaxonomyCode {get; set;}
    [XmlElement(Order=3)]
    public string D_PRV04_StateorProvinceCode {get; set;}
    [XmlElement(Order=4)]
    public C_C035_ProviderSpecialtyInformation_4 C_C035_ProviderSpecialtyInformation_4 {get; set;}
    [XmlElement(Order=5)]
    public string D_PRV06_ProviderOrganizationCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C035_ProviderSpecialtyInformation_4 {
    [XmlElement(Order=0)]
    public string D_C03501_ProviderSpecialtyCode {get; set;}
    [XmlElement(Order=1)]
    public string D_C03502_AgencyQualifierCode {get; set;}
    [XmlElement(Order=2)]
    public string D_C03503_Yes_NoConditionorResponseCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_RenderingProviderSecondaryIdentification_3 {
    [XmlElement(Order=0)]
    public X12_ID_128_26 D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_RenderingProviderSecondaryIdentifier {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03_Description {get; set;}
    [XmlElement(Order=3)]
    public C_C040_ReferenceIdentifier_71 C_C040_ReferenceIdentifier_71 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C040_ReferenceIdentifier_71 {
    [XmlElement(Order=0)]
    public string D_C04001_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C04002_ReferenceIdentification {get; set;}
    [XmlElement(Order=2)]
    public string D_C04003_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C04004_ReferenceIdentification {get; set;}
    [XmlElement(Order=4)]
    public string D_C04005_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_C04006_ReferenceIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_TS837_2310C_1 {
    [XmlElement(Order=0)]
    public S_NM1_ServiceFacilityLocationName_2 S_NM1_ServiceFacilityLocationName_2 {get; set;}
    [XmlElement(Order=1)]
    public S_N3_ServiceFacilityLocationAddress_3 S_N3_ServiceFacilityLocationAddress_3 {get; set;}
    [XmlElement(Order=2)]
    public S_N4_ServiceFacilityLocationCity_State_ZIPCode_3 S_N4_ServiceFacilityLocationCity_State_ZIPCode_3 {get; set;}
    [XmlElement("S_REF_ServiceFacilityLocationSecondaryIdentification_3",Order=3)]
    public List<S_REF_ServiceFacilityLocationSecondaryIdentification_3> S_REF_ServiceFacilityLocationSecondaryIdentification_3 {get; set;}
    [XmlElement(Order=4)]
    public S_PER_ServiceFacilityContactInformation_2 S_PER_ServiceFacilityContactInformation_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_NM1_ServiceFacilityLocationName_2 {
    [XmlElement(Order=0)]
    public X12_ID_98_11 D_NM101_EntityIdentifierCode {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1065_2 D_NM102_EntityTypeQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_NM103_LaboratoryorFacilityName {get; set;}
    [XmlElement(Order=3)]
    public string D_NM104_NameFirst {get; set;}
    [XmlElement(Order=4)]
    public string D_NM105_NameMiddle {get; set;}
    [XmlElement(Order=5)]
    public string D_NM106_NamePrefix {get; set;}
    [XmlElement(Order=6)]
    public string D_NM107_NameSuffix {get; set;}
    [XmlElement(Order=7)]
    public string D_NM108_IdentificationCodeQualifier {get; set;}
    [XmlElement(Order=8)]
    public string D_NM109_LaboratoryorFacilityPrimaryIdentifier {get; set;}
    [XmlElement(Order=9)]
    public string D_NM110_EntityRelationshipCode {get; set;}
    [XmlElement(Order=10)]
    public string D_NM111_EntityIdentifierCode {get; set;}
    [XmlElement(Order=11)]
    public string D_NM112_NameLastorOrganizationName {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_N3_ServiceFacilityLocationAddress_3 {
    [XmlElement(Order=0)]
    public string D_N301_LaboratoryorFacilityAddressLine {get; set;}
    [XmlElement(Order=1)]
    public string D_N302_LaboratoryorFacilityAddressLine {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_N4_ServiceFacilityLocationCity_State_ZIPCode_3 {
    [XmlElement(Order=0)]
    public string D_N401_LaboratoryorFacilityCityName {get; set;}
    [XmlElement(Order=1)]
    public string D_N402_LaboratoryorFacilityStateorProvinceCode {get; set;}
    [XmlElement(Order=2)]
    public string D_N403_LaboratoryorFacilityPostalZoneorZIPCode {get; set;}
    [XmlElement(Order=3)]
    public string D_N404_CountryCode {get; set;}
    [XmlElement(Order=4)]
    public string D_N405_LocationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_N406_LocationIdentifier {get; set;}
    [XmlElement(Order=6)]
    public string D_N407_CountrySubdivisionCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_ServiceFacilityLocationSecondaryIdentification_3 {
    [XmlElement(Order=0)]
    public X12_ID_128_27 D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_LaboratoryorFacilitySecondaryIdentifier {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03_Description {get; set;}
    [XmlElement(Order=3)]
    public C_C040_ReferenceIdentifier_72 C_C040_ReferenceIdentifier_72 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C040_ReferenceIdentifier_72 {
    [XmlElement(Order=0)]
    public string D_C04001_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C04002_ReferenceIdentification {get; set;}
    [XmlElement(Order=2)]
    public string D_C04003_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C04004_ReferenceIdentification {get; set;}
    [XmlElement(Order=4)]
    public string D_C04005_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_C04006_ReferenceIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_PER_ServiceFacilityContactInformation_2 {
    [XmlElement(Order=0)]
    public X12_ID_366 D_PER01_ContactFunctionCode {get; set;}
    [XmlElement(Order=1)]
    public string D_PER02_Name {get; set;}
    [XmlElement(Order=2)]
    public string D_PER03_CommunicationNumberQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_PER04_CommunicationNumber {get; set;}
    [XmlElement(Order=4)]
    public string D_PER05_CommunicationNumberQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_PER06_CommunicationNumber {get; set;}
    [XmlElement(Order=6)]
    public string D_PER07_CommunicationNumberQualifier {get; set;}
    [XmlElement(Order=7)]
    public string D_PER08_CommunicationNumber {get; set;}
    [XmlElement(Order=8)]
    public string D_PER09_ContactInquiryReference {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_TS837_2310D_1 {
    [XmlElement(Order=0)]
    public S_NM1_SupervisingProviderName_3 S_NM1_SupervisingProviderName_3 {get; set;}
    [XmlElement("S_REF_SupervisingProviderSecondaryIdentification_3",Order=1)]
    public List<S_REF_SupervisingProviderSecondaryIdentification_3> S_REF_SupervisingProviderSecondaryIdentification_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_NM1_SupervisingProviderName_3 {
    [XmlElement(Order=0)]
    public X12_ID_98_12 D_NM101_EntityIdentifierCode {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1065_3 D_NM102_EntityTypeQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_NM103_SupervisingProviderLastName {get; set;}
    [XmlElement(Order=3)]
    public string D_NM104_SupervisingProviderFirstName {get; set;}
    [XmlElement(Order=4)]
    public string D_NM105_SupervisingProviderMiddleNameorInitial {get; set;}
    [XmlElement(Order=5)]
    public string D_NM106_NamePrefix {get; set;}
    [XmlElement(Order=6)]
    public string D_NM107_SupervisingProviderNameSuffix {get; set;}
    [XmlElement(Order=7)]
    public string D_NM108_IdentificationCodeQualifier {get; set;}
    [XmlElement(Order=8)]
    public string D_NM109_SupervisingProviderIdentifier {get; set;}
    [XmlElement(Order=9)]
    public string D_NM110_EntityRelationshipCode {get; set;}
    [XmlElement(Order=10)]
    public string D_NM111_EntityIdentifierCode {get; set;}
    [XmlElement(Order=11)]
    public string D_NM112_NameLastorOrganizationName {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_SupervisingProviderSecondaryIdentification_3 {
    [XmlElement(Order=0)]
    public X12_ID_128_26 D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_SupervisingProviderSecondaryIdentifier {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03_Description {get; set;}
    [XmlElement(Order=3)]
    public C_C040_ReferenceIdentifier_73 C_C040_ReferenceIdentifier_73 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C040_ReferenceIdentifier_73 {
    [XmlElement(Order=0)]
    public string D_C04001_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C04002_ReferenceIdentification {get; set;}
    [XmlElement(Order=2)]
    public string D_C04003_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C04004_ReferenceIdentification {get; set;}
    [XmlElement(Order=4)]
    public string D_C04005_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_C04006_ReferenceIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_TS837_2310E_1 {
    [XmlElement(Order=0)]
    public S_NM1_AmbulancePick_upLocation_3 S_NM1_AmbulancePick_upLocation_3 {get; set;}
    [XmlElement(Order=1)]
    public S_N3_AmbulancePick_upLocationAddress_3 S_N3_AmbulancePick_upLocationAddress_3 {get; set;}
    [XmlElement(Order=2)]
    public S_N4_AmbulancePick_upLocationCity_State_ZipCode_3 S_N4_AmbulancePick_upLocationCity_State_ZipCode_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_NM1_AmbulancePick_upLocation_3 {
    [XmlElement(Order=0)]
    public X12_ID_98_13 D_NM101_EntityIdentifierCode {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1065_2 D_NM102_EntityTypeQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_NM103_NameLastorOrganizationName {get; set;}
    [XmlElement(Order=3)]
    public string D_NM104_NameFirst {get; set;}
    [XmlElement(Order=4)]
    public string D_NM105_NameMiddle {get; set;}
    [XmlElement(Order=5)]
    public string D_NM106_NamePrefix {get; set;}
    [XmlElement(Order=6)]
    public string D_NM107_NameSuffix {get; set;}
    [XmlElement(Order=7)]
    public string D_NM108_IdentificationCodeQualifier {get; set;}
    [XmlElement(Order=8)]
    public string D_NM109_IdentificationCode {get; set;}
    [XmlElement(Order=9)]
    public string D_NM110_EntityRelationshipCode {get; set;}
    [XmlElement(Order=10)]
    public string D_NM111_EntityIdentifierCode {get; set;}
    [XmlElement(Order=11)]
    public string D_NM112_NameLastorOrganizationName {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_N3_AmbulancePick_upLocationAddress_3 {
    [XmlElement(Order=0)]
    public string D_N301_AmbulancePick_upAddressLine {get; set;}
    [XmlElement(Order=1)]
    public string D_N302_AmbulancePick_upAddressLine {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_N4_AmbulancePick_upLocationCity_State_ZipCode_3 {
    [XmlElement(Order=0)]
    public string D_N401_AmbulancePick_upCityName {get; set;}
    [XmlElement(Order=1)]
    public string D_N402_AmbulancePick_upStateorProvinceCode {get; set;}
    [XmlElement(Order=2)]
    public string D_N403_AmbulancePick_upPostalZoneorZIPCode {get; set;}
    [XmlElement(Order=3)]
    public string D_N404_CountryCode {get; set;}
    [XmlElement(Order=4)]
    public string D_N405_LocationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_N406_LocationIdentifier {get; set;}
    [XmlElement(Order=6)]
    public string D_N407_CountrySubdivisionCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_TS837_2310F_1 {
    [XmlElement(Order=0)]
    public S_NM1_AmbulanceDrop_offLocation_3 S_NM1_AmbulanceDrop_offLocation_3 {get; set;}
    [XmlElement(Order=1)]
    public S_N3_AmbulanceDrop_offLocationAddress_3 S_N3_AmbulanceDrop_offLocationAddress_3 {get; set;}
    [XmlElement(Order=2)]
    public S_N4_AmbulanceDrop_offLocationCity_State_ZipCode_3 S_N4_AmbulanceDrop_offLocationCity_State_ZipCode_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_NM1_AmbulanceDrop_offLocation_3 {
    [XmlElement(Order=0)]
    public X12_ID_98_14 D_NM101_EntityIdentifierCode {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1065_2 D_NM102_EntityTypeQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_NM103_AmbulanceDrop_offLocation {get; set;}
    [XmlElement(Order=3)]
    public string D_NM104_NameFirst {get; set;}
    [XmlElement(Order=4)]
    public string D_NM105_NameMiddle {get; set;}
    [XmlElement(Order=5)]
    public string D_NM106_NamePrefix {get; set;}
    [XmlElement(Order=6)]
    public string D_NM107_NameSuffix {get; set;}
    [XmlElement(Order=7)]
    public string D_NM108_IdentificationCodeQualifier {get; set;}
    [XmlElement(Order=8)]
    public string D_NM109_IdentificationCode {get; set;}
    [XmlElement(Order=9)]
    public string D_NM110_EntityRelationshipCode {get; set;}
    [XmlElement(Order=10)]
    public string D_NM111_EntityIdentifierCode {get; set;}
    [XmlElement(Order=11)]
    public string D_NM112_NameLastorOrganizationName {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_N3_AmbulanceDrop_offLocationAddress_3 {
    [XmlElement(Order=0)]
    public string D_N301_AmbulanceDrop_offAddressLine {get; set;}
    [XmlElement(Order=1)]
    public string D_N302_AmbulanceDrop_offAddressLine {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_N4_AmbulanceDrop_offLocationCity_State_ZipCode_3 {
    [XmlElement(Order=0)]
    public string D_N401_AmbulanceDrop_offCityName {get; set;}
    [XmlElement(Order=1)]
    public string D_N402_AmbulanceDrop_offStateorProvinceCode {get; set;}
    [XmlElement(Order=2)]
    public string D_N403_AmbulanceDrop_offPostalZoneorZIPCode {get; set;}
    [XmlElement(Order=3)]
    public string D_N404_CountryCode {get; set;}
    [XmlElement(Order=4)]
    public string D_N405_LocationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_N406_LocationIdentifier {get; set;}
    [XmlElement(Order=6)]
    public string D_N407_CountrySubdivisionCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_TS837_2320_1 {
    [XmlElement(Order=0)]
    public S_SBR_OtherSubscriberInformation_2 S_SBR_OtherSubscriberInformation_2 {get; set;}
    [XmlElement("S_CAS_ClaimLevelAdjustments_2",Order=1)]
    public List<S_CAS_ClaimLevelAdjustments_2> S_CAS_ClaimLevelAdjustments_2 {get; set;}
    [XmlElement(Order=2)]
    public A_AMT_3 A_AMT_3 {get; set;}
    [XmlElement(Order=3)]
    public S_OI_OtherInsuranceCoverageInformation_2 S_OI_OtherInsuranceCoverageInformation_2 {get; set;}
    [XmlElement(Order=4)]
    public S_MOA_OutpatientAdjudicationInformation_2 S_MOA_OutpatientAdjudicationInformation_2 {get; set;}
    [XmlElement(Order=5)]
    public A_NM1_8 A_NM1_8 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_SBR_OtherSubscriberInformation_2 {
    [XmlElement(Order=0)]
    public X12_ID_1138 D_SBR01_PayerResponsibilitySequenceNumberCode {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1069_3 D_SBR02_IndividualRelationshipCode {get; set;}
    [XmlElement(Order=2)]
    public string D_SBR03_InsuredGrouporPolicyNumber {get; set;}
    [XmlElement(Order=3)]
    public string D_SBR04_OtherInsuredGroupName {get; set;}
    [XmlElement(Order=4)]
    public string D_SBR05_InsuranceTypeCode {get; set;}
    [XmlElement(Order=5)]
    public string D_SBR06_CoordinationofBenefitsCode {get; set;}
    [XmlElement(Order=6)]
    public string D_SBR07_Yes_NoConditionorResponseCode {get; set;}
    [XmlElement(Order=7)]
    public string D_SBR08_EmploymentStatusCode {get; set;}
    [XmlElement(Order=8)]
    public string D_SBR09_ClaimFilingIndicatorCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_CAS_ClaimLevelAdjustments_2 {
    [XmlElement(Order=0)]
    public X12_ID_1033 D_CAS01_ClaimAdjustmentGroupCode {get; set;}
    [XmlElement(Order=1)]
    public string D_CAS02_AdjustmentReasonCode {get; set;}
    [XmlElement(Order=2)]
    public string D_CAS03_AdjustmentAmount {get; set;}
    [XmlElement(Order=3)]
    public string D_CAS04_AdjustmentQuantity {get; set;}
    [XmlElement(Order=4)]
    public string D_CAS05_AdjustmentReasonCode {get; set;}
    [XmlElement(Order=5)]
    public string D_CAS06_AdjustmentAmount {get; set;}
    [XmlElement(Order=6)]
    public string D_CAS07_AdjustmentQuantity {get; set;}
    [XmlElement(Order=7)]
    public string D_CAS08_AdjustmentReasonCode {get; set;}
    [XmlElement(Order=8)]
    public string D_CAS09_AdjustmentAmount {get; set;}
    [XmlElement(Order=9)]
    public string D_CAS10_AdjustmentQuantity {get; set;}
    [XmlElement(Order=10)]
    public string D_CAS11_AdjustmentReasonCode {get; set;}
    [XmlElement(Order=11)]
    public string D_CAS12_AdjustmentAmount {get; set;}
    [XmlElement(Order=12)]
    public string D_CAS13_AdjustmentQuantity {get; set;}
    [XmlElement(Order=13)]
    public string D_CAS14_AdjustmentReasonCode {get; set;}
    [XmlElement(Order=14)]
    public string D_CAS15_AdjustmentAmount {get; set;}
    [XmlElement(Order=15)]
    public string D_CAS16_AdjustmentQuantity {get; set;}
    [XmlElement(Order=16)]
    public string D_CAS17_AdjustmentReasonCode {get; set;}
    [XmlElement(Order=17)]
    public string D_CAS18_AdjustmentAmount {get; set;}
    [XmlElement(Order=18)]
    public string D_CAS19_AdjustmentQuantity {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class A_AMT_3 {
    [XmlElementAttribute(Order=0)]
    public S_AMT_CoordinationofBenefits_COB_PayerPaidAmount_2 S_AMT_CoordinationofBenefits_COB_PayerPaidAmount_2 {get; set;}
    [XmlElementAttribute(Order=1)]
    public S_AMT_CoordinationofBenefits_COB_TotalNon_coveredAmount_2 S_AMT_CoordinationofBenefits_COB_TotalNon_coveredAmount_2 {get; set;}
    [XmlElementAttribute(Order=2)]
    public S_AMT_RemainingPatientLiability_3 S_AMT_RemainingPatientLiability_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_AMT_CoordinationofBenefits_COB_PayerPaidAmount_2 {
    [XmlElement(Order=0)]
    public X12_ID_522_2 D_AMT01_AmountQualifierCode {get; set;}
    [XmlElement(Order=1)]
    public string D_AMT02_PayerPaidAmount {get; set;}
    [XmlElement(Order=2)]
    public string D_AMT03_Credit_DebitFlagCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_AMT_CoordinationofBenefits_COB_TotalNon_coveredAmount_2 {
    [XmlElement(Order=0)]
    public X12_ID_522_3 D_AMT01_AmountQualifierCode {get; set;}
    [XmlElement(Order=1)]
    public string D_AMT02_Non_CoveredChargeAmount {get; set;}
    [XmlElement(Order=2)]
    public string D_AMT03_Credit_DebitFlagCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_AMT_RemainingPatientLiability_3 {
    [XmlElement(Order=0)]
    public X12_ID_522_4 D_AMT01_AmountQualifierCode {get; set;}
    [XmlElement(Order=1)]
    public string D_AMT02_RemainingPatientLiability {get; set;}
    [XmlElement(Order=2)]
    public string D_AMT03_Credit_DebitFlagCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_OI_OtherInsuranceCoverageInformation_2 {
    [XmlElement(Order=0)]
    public X12_ID_1032_2 D_OI01_ClaimFilingIndicatorCode {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1383 D_OI02_ClaimSubmissionReasonCode {get; set;}
    [XmlElement(Order=2)]
    public string D_OI03_BenefitsAssignmentCertificationIndicator {get; set;}
    [XmlElement(Order=3)]
    public string D_OI04_PatientSignatureSourceCode {get; set;}
    [XmlElement(Order=4)]
    public string D_OI05_ProviderAgreementCode {get; set;}
    [XmlElement(Order=5)]
    public string D_OI06_ReleaseofInformationCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_MOA_OutpatientAdjudicationInformation_2 {
    [XmlElement(Order=0)]
    public string D_MOA01_ReimbursementRate {get; set;}
    [XmlElement(Order=1)]
    public string D_MOA02_HCPCSPayableAmount {get; set;}
    [XmlElement(Order=2)]
    public string D_MOA03_ClaimPaymentRemarkCode {get; set;}
    [XmlElement(Order=3)]
    public string D_MOA04_ClaimPaymentRemarkCode {get; set;}
    [XmlElement(Order=4)]
    public string D_MOA05_ClaimPaymentRemarkCode {get; set;}
    [XmlElement(Order=5)]
    public string D_MOA06_ClaimPaymentRemarkCode {get; set;}
    [XmlElement(Order=6)]
    public string D_MOA07_ClaimPaymentRemarkCode {get; set;}
    [XmlElement(Order=7)]
    public string D_MOA08_EndStageRenalDiseasePaymentAmount {get; set;}
    [XmlElement(Order=8)]
    public string D_MOA09_Non_PayableProfessionalComponentBilledAmount {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class A_NM1_8 {
    [XmlElementAttribute(Order=0)]
    public G_TS837_2330A_1 G_TS837_2330A_1 {get; set;}
    [XmlElementAttribute(Order=1)]
    public G_TS837_2330B_1 G_TS837_2330B_1 {get; set;}
    [XmlElement(Order=2)]
    public U_TS837_2330C_1 U_TS837_2330C_1 {get; set;}
    [XmlElementAttribute(Order=3)]
    public G_TS837_2330D_1 G_TS837_2330D_1 {get; set;}
    [XmlElementAttribute(Order=4)]
    public G_TS837_2330E_1 G_TS837_2330E_1 {get; set;}
    [XmlElementAttribute(Order=5)]
    public G_TS837_2330F_1 G_TS837_2330F_1 {get; set;}
    [XmlElementAttribute(Order=6)]
    public G_TS837_2330G_1 G_TS837_2330G_1 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_TS837_2330A_1 {
    [XmlElement(Order=0)]
    public S_NM1_OtherSubscriberName_2 S_NM1_OtherSubscriberName_2 {get; set;}
    [XmlElement(Order=1)]
    public S_N3_OtherSubscriberAddress_2 S_N3_OtherSubscriberAddress_2 {get; set;}
    [XmlElement(Order=2)]
    public S_N4_OtherSubscriberCity_State_ZIPCode_2 S_N4_OtherSubscriberCity_State_ZIPCode_2 {get; set;}
    [XmlElement(Order=3)]
    public S_REF_OtherSubscriberSecondaryIdentification_2 S_REF_OtherSubscriberSecondaryIdentification_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_NM1_OtherSubscriberName_2 {
    [XmlElement(Order=0)]
    public X12_ID_98_7 D_NM101_EntityIdentifierCode {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1065 D_NM102_EntityTypeQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_NM103_OtherInsuredLastName {get; set;}
    [XmlElement(Order=3)]
    public string D_NM104_OtherInsuredFirstName {get; set;}
    [XmlElement(Order=4)]
    public string D_NM105_OtherInsuredMiddleName {get; set;}
    [XmlElement(Order=5)]
    public string D_NM106_NamePrefix {get; set;}
    [XmlElement(Order=6)]
    public string D_NM107_OtherInsuredNameSuffix {get; set;}
    [XmlElement(Order=7)]
    public string D_NM108_IdentificationCodeQualifier {get; set;}
    [XmlElement(Order=8)]
    public string D_NM109_OtherInsuredIdentifier {get; set;}
    [XmlElement(Order=9)]
    public string D_NM110_EntityRelationshipCode {get; set;}
    [XmlElement(Order=10)]
    public string D_NM111_EntityIdentifierCode {get; set;}
    [XmlElement(Order=11)]
    public string D_NM112_NameLastorOrganizationName {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_N3_OtherSubscriberAddress_2 {
    [XmlElement(Order=0)]
    public string D_N301_OtherInsuredAddressLine {get; set;}
    [XmlElement(Order=1)]
    public string D_N302_OtherInsuredAddressLine {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_N4_OtherSubscriberCity_State_ZIPCode_2 {
    [XmlElement(Order=0)]
    public string D_N401_OtherSubscriberCityName {get; set;}
    [XmlElement(Order=1)]
    public string D_N402_OtherSubscriberStateorProvinceCode {get; set;}
    [XmlElement(Order=2)]
    public string D_N403_OtherSubscriberPostalZoneorZIPCode {get; set;}
    [XmlElement(Order=3)]
    public string D_N404_CountryCode {get; set;}
    [XmlElement(Order=4)]
    public string D_N405_LocationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_N406_LocationIdentifier {get; set;}
    [XmlElement(Order=6)]
    public string D_N407_CountrySubdivisionCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_OtherSubscriberSecondaryIdentification_2 {
    [XmlElement(Order=0)]
    public X12_ID_128_7 D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_OtherInsuredAdditionalIdentifier {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03_Description {get; set;}
    [XmlElement(Order=3)]
    public C_C040_ReferenceIdentifier_74 C_C040_ReferenceIdentifier_74 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C040_ReferenceIdentifier_74 {
    [XmlElement(Order=0)]
    public string D_C04001_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C04002_ReferenceIdentification {get; set;}
    [XmlElement(Order=2)]
    public string D_C04003_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C04004_ReferenceIdentification {get; set;}
    [XmlElement(Order=4)]
    public string D_C04005_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_C04006_ReferenceIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_TS837_2330B_1 {
    [XmlElement(Order=0)]
    public S_NM1_OtherPayerName_2 S_NM1_OtherPayerName_2 {get; set;}
    [XmlElement(Order=1)]
    public S_N3_OtherPayerAddress_2 S_N3_OtherPayerAddress_2 {get; set;}
    [XmlElement(Order=2)]
    public S_N4_OtherPayerCity_State_ZIPCode_2 S_N4_OtherPayerCity_State_ZIPCode_2 {get; set;}
    [XmlElement(Order=3)]
    public S_DTP_ClaimCheckorRemittanceDate_2 S_DTP_ClaimCheckorRemittanceDate_2 {get; set;}
    [XmlElement(Order=4)]
    public A_REF_10 A_REF_10 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_NM1_OtherPayerName_2 {
    [XmlElement(Order=0)]
    public X12_ID_98_8 D_NM101_EntityIdentifierCode {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1065_2 D_NM102_EntityTypeQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_NM103_OtherPayerOrganizationName {get; set;}
    [XmlElement(Order=3)]
    public string D_NM104_NameFirst {get; set;}
    [XmlElement(Order=4)]
    public string D_NM105_NameMiddle {get; set;}
    [XmlElement(Order=5)]
    public string D_NM106_NamePrefix {get; set;}
    [XmlElement(Order=6)]
    public string D_NM107_NameSuffix {get; set;}
    [XmlElement(Order=7)]
    public string D_NM108_IdentificationCodeQualifier {get; set;}
    [XmlElement(Order=8)]
    public string D_NM109_OtherPayerPrimaryIdentifier {get; set;}
    [XmlElement(Order=9)]
    public string D_NM110_EntityRelationshipCode {get; set;}
    [XmlElement(Order=10)]
    public string D_NM111_EntityIdentifierCode {get; set;}
    [XmlElement(Order=11)]
    public string D_NM112_NameLastorOrganizationName {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_N3_OtherPayerAddress_2 {
    [XmlElement(Order=0)]
    public string D_N301_OtherPayerAddressLine {get; set;}
    [XmlElement(Order=1)]
    public string D_N302_OtherPayerAddressLine {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_N4_OtherPayerCity_State_ZIPCode_2 {
    [XmlElement(Order=0)]
    public string D_N401_OtherPayerCityName {get; set;}
    [XmlElement(Order=1)]
    public string D_N402_OtherPayerStateorProvinceCode {get; set;}
    [XmlElement(Order=2)]
    public string D_N403_OtherPayerPostalZoneorZIPCode {get; set;}
    [XmlElement(Order=3)]
    public string D_N404_CountryCode {get; set;}
    [XmlElement(Order=4)]
    public string D_N405_LocationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_N406_LocationIdentifier {get; set;}
    [XmlElement(Order=6)]
    public string D_N407_CountrySubdivisionCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_DTP_ClaimCheckorRemittanceDate_2 {
    [XmlElement(Order=0)]
    public X12_ID_374_18 D_DTP01_DateTimeQualifier {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1250 D_DTP02_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_DTP03_AdjudicationorPaymentDate {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class A_REF_10 {
    [XmlElement(Order=0)]
    public U_REF_OtherPayerSecondaryIdentifier_2 U_REF_OtherPayerSecondaryIdentifier_2 {get; set;}
    [XmlElementAttribute(Order=1)]
    public S_REF_OtherPayerPriorAuthorizationNumber_2 S_REF_OtherPayerPriorAuthorizationNumber_2 {get; set;}
    [XmlElementAttribute(Order=2)]
    public S_REF_OtherPayerReferralNumber_2 S_REF_OtherPayerReferralNumber_2 {get; set;}
    [XmlElementAttribute(Order=3)]
    public S_REF_OtherPayerClaimAdjustmentIndicator_2 S_REF_OtherPayerClaimAdjustmentIndicator_2 {get; set;}
    [XmlElementAttribute(Order=4)]
    public S_REF_OtherPayerClaimControlNumber_2 S_REF_OtherPayerClaimControlNumber_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_OtherPayerSecondaryIdentifier_2 {
    [XmlElement(Order=0)]
    public X12_ID_128_9 D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_OtherPayerSecondaryIdentifier {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03_Description {get; set;}
    [XmlElement(Order=3)]
    public C_C040_ReferenceIdentifier_75 C_C040_ReferenceIdentifier_75 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C040_ReferenceIdentifier_75 {
    [XmlElement(Order=0)]
    public string D_C04001_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C04002_ReferenceIdentification {get; set;}
    [XmlElement(Order=2)]
    public string D_C04003_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C04004_ReferenceIdentification {get; set;}
    [XmlElement(Order=4)]
    public string D_C04005_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_C04006_ReferenceIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_OtherPayerPriorAuthorizationNumber_2 {
    [XmlElement(Order=0)]
    public X12_ID_128_15 D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_OtherPayerPriorAuthorizationNumber {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03_Description {get; set;}
    [XmlElement(Order=3)]
    public C_C040_ReferenceIdentifier_76 C_C040_ReferenceIdentifier_76 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C040_ReferenceIdentifier_76 {
    [XmlElement(Order=0)]
    public string D_C04001_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C04002_ReferenceIdentification {get; set;}
    [XmlElement(Order=2)]
    public string D_C04003_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C04004_ReferenceIdentification {get; set;}
    [XmlElement(Order=4)]
    public string D_C04005_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_C04006_ReferenceIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_OtherPayerReferralNumber_2 {
    [XmlElement(Order=0)]
    public X12_ID_128_14 D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_OtherPayerPriorAuthorizationorReferralNumber {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03_Description {get; set;}
    [XmlElement(Order=3)]
    public C_C040_ReferenceIdentifier_77 C_C040_ReferenceIdentifier_77 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C040_ReferenceIdentifier_77 {
    [XmlElement(Order=0)]
    public string D_C04001_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C04002_ReferenceIdentification {get; set;}
    [XmlElement(Order=2)]
    public string D_C04003_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C04004_ReferenceIdentification {get; set;}
    [XmlElement(Order=4)]
    public string D_C04005_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_C04006_ReferenceIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_OtherPayerClaimAdjustmentIndicator_2 {
    [XmlElement(Order=0)]
    public X12_ID_128_28 D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_OtherPayerClaimAdjustmentIndicator {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03_Description {get; set;}
    [XmlElement(Order=3)]
    public C_C040_ReferenceIdentifier_78 C_C040_ReferenceIdentifier_78 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C040_ReferenceIdentifier_78 {
    [XmlElement(Order=0)]
    public string D_C04001_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C04002_ReferenceIdentification {get; set;}
    [XmlElement(Order=2)]
    public string D_C04003_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C04004_ReferenceIdentification {get; set;}
    [XmlElement(Order=4)]
    public string D_C04005_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_C04006_ReferenceIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_OtherPayerClaimControlNumber_2 {
    [XmlElement(Order=0)]
    public X12_ID_128_16 D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_OtherPayer_sClaimControlNumber {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03_Description {get; set;}
    [XmlElement(Order=3)]
    public C_C040_ReferenceIdentifier_79 C_C040_ReferenceIdentifier_79 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C040_ReferenceIdentifier_79 {
    [XmlElement(Order=0)]
    public string D_C04001_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C04002_ReferenceIdentification {get; set;}
    [XmlElement(Order=2)]
    public string D_C04003_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C04004_ReferenceIdentification {get; set;}
    [XmlElement(Order=4)]
    public string D_C04005_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_C04006_ReferenceIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_TS837_2330C_1 {
    [XmlElement(Order=0)]
    public S_NM1_OtherPayerReferringProvider_2 S_NM1_OtherPayerReferringProvider_2 {get; set;}
    [XmlElement("S_REF_OtherPayerReferringProviderSecondaryIdentification_2",Order=1)]
    public List<S_REF_OtherPayerReferringProviderSecondaryIdentification_2> S_REF_OtherPayerReferringProviderSecondaryIdentification_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_NM1_OtherPayerReferringProvider_2 {
    [XmlElement(Order=0)]
    public X12_ID_98_9 D_NM101_EntityIdentifierCode {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1065_3 D_NM102_EntityTypeQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_NM103_NameLastorOrganizationName {get; set;}
    [XmlElement(Order=3)]
    public string D_NM104_NameFirst {get; set;}
    [XmlElement(Order=4)]
    public string D_NM105_NameMiddle {get; set;}
    [XmlElement(Order=5)]
    public string D_NM106_NamePrefix {get; set;}
    [XmlElement(Order=6)]
    public string D_NM107_NameSuffix {get; set;}
    [XmlElement(Order=7)]
    public string D_NM108_IdentificationCodeQualifier {get; set;}
    [XmlElement(Order=8)]
    public string D_NM109_IdentificationCode {get; set;}
    [XmlElement(Order=9)]
    public string D_NM110_EntityRelationshipCode {get; set;}
    [XmlElement(Order=10)]
    public string D_NM111_EntityIdentifierCode {get; set;}
    [XmlElement(Order=11)]
    public string D_NM112_NameLastorOrganizationName {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_OtherPayerReferringProviderSecondaryIdentification_2 {
    [XmlElement(Order=0)]
    public X12_ID_128_25 D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_OtherPayerReferringProviderIdentifier {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03_Description {get; set;}
    [XmlElement(Order=3)]
    public C_C040_ReferenceIdentifier_80 C_C040_ReferenceIdentifier_80 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C040_ReferenceIdentifier_80 {
    [XmlElement(Order=0)]
    public string D_C04001_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C04002_ReferenceIdentification {get; set;}
    [XmlElement(Order=2)]
    public string D_C04003_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C04004_ReferenceIdentification {get; set;}
    [XmlElement(Order=4)]
    public string D_C04005_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_C04006_ReferenceIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_TS837_2330D_1 {
    [XmlElement(Order=0)]
    public S_NM1_OtherPayerRenderingProvider_2 S_NM1_OtherPayerRenderingProvider_2 {get; set;}
    [XmlElement("S_REF_OtherPayerRenderingProviderSecondaryIdentification_2",Order=1)]
    public List<S_REF_OtherPayerRenderingProviderSecondaryIdentification_2> S_REF_OtherPayerRenderingProviderSecondaryIdentification_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_NM1_OtherPayerRenderingProvider_2 {
    [XmlElement(Order=0)]
    public X12_ID_98_10 D_NM101_EntityIdentifierCode {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1065 D_NM102_EntityTypeQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_NM103_NameLastorOrganizationName {get; set;}
    [XmlElement(Order=3)]
    public string D_NM104_NameFirst {get; set;}
    [XmlElement(Order=4)]
    public string D_NM105_NameMiddle {get; set;}
    [XmlElement(Order=5)]
    public string D_NM106_NamePrefix {get; set;}
    [XmlElement(Order=6)]
    public string D_NM107_NameSuffix {get; set;}
    [XmlElement(Order=7)]
    public string D_NM108_IdentificationCodeQualifier {get; set;}
    [XmlElement(Order=8)]
    public string D_NM109_IdentificationCode {get; set;}
    [XmlElement(Order=9)]
    public string D_NM110_EntityRelationshipCode {get; set;}
    [XmlElement(Order=10)]
    public string D_NM111_EntityIdentifierCode {get; set;}
    [XmlElement(Order=11)]
    public string D_NM112_NameLastorOrganizationName {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_OtherPayerRenderingProviderSecondaryIdentification_2 {
    [XmlElement(Order=0)]
    public X12_ID_128_26 D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_OtherPayerRenderingProviderSecondaryIdentifier {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03_Description {get; set;}
    [XmlElement(Order=3)]
    public C_C040_ReferenceIdentifier_81 C_C040_ReferenceIdentifier_81 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C040_ReferenceIdentifier_81 {
    [XmlElement(Order=0)]
    public string D_C04001_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C04002_ReferenceIdentification {get; set;}
    [XmlElement(Order=2)]
    public string D_C04003_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C04004_ReferenceIdentification {get; set;}
    [XmlElement(Order=4)]
    public string D_C04005_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_C04006_ReferenceIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_TS837_2330E_1 {
    [XmlElement(Order=0)]
    public S_NM1_OtherPayerServiceFacilityLocation_2 S_NM1_OtherPayerServiceFacilityLocation_2 {get; set;}
    [XmlElement("S_REF_OtherPayerServiceFacilityLocationSecondaryIdentification_2",Order=1)]
    public List<S_REF_OtherPayerServiceFacilityLocationSecondaryIdentification_2> S_REF_OtherPayerServiceFacilityLocationSecondaryIdentification_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_NM1_OtherPayerServiceFacilityLocation_2 {
    [XmlElement(Order=0)]
    public X12_ID_98_11 D_NM101_EntityIdentifierCode {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1065_2 D_NM102_EntityTypeQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_NM103_NameLastorOrganizationName {get; set;}
    [XmlElement(Order=3)]
    public string D_NM104_NameFirst {get; set;}
    [XmlElement(Order=4)]
    public string D_NM105_NameMiddle {get; set;}
    [XmlElement(Order=5)]
    public string D_NM106_NamePrefix {get; set;}
    [XmlElement(Order=6)]
    public string D_NM107_NameSuffix {get; set;}
    [XmlElement(Order=7)]
    public string D_NM108_IdentificationCodeQualifier {get; set;}
    [XmlElement(Order=8)]
    public string D_NM109_IdentificationCode {get; set;}
    [XmlElement(Order=9)]
    public string D_NM110_EntityRelationshipCode {get; set;}
    [XmlElement(Order=10)]
    public string D_NM111_EntityIdentifierCode {get; set;}
    [XmlElement(Order=11)]
    public string D_NM112_NameLastorOrganizationName {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_OtherPayerServiceFacilityLocationSecondaryIdentification_2 {
    [XmlElement(Order=0)]
    public X12_ID_128_27 D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_OtherPayerServiceFacilityLocationSecondary_Identifier {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03_Description {get; set;}
    [XmlElement(Order=3)]
    public C_C040_ReferenceIdentifier_82 C_C040_ReferenceIdentifier_82 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C040_ReferenceIdentifier_82 {
    [XmlElement(Order=0)]
    public string D_C04001_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C04002_ReferenceIdentification {get; set;}
    [XmlElement(Order=2)]
    public string D_C04003_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C04004_ReferenceIdentification {get; set;}
    [XmlElement(Order=4)]
    public string D_C04005_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_C04006_ReferenceIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_TS837_2330F_1 {
    [XmlElement(Order=0)]
    public S_NM1_OtherPayerSupervisingProvider_2 S_NM1_OtherPayerSupervisingProvider_2 {get; set;}
    [XmlElement("S_REF_OtherPayerSupervisingProviderSecondaryIdentification_2",Order=1)]
    public List<S_REF_OtherPayerSupervisingProviderSecondaryIdentification_2> S_REF_OtherPayerSupervisingProviderSecondaryIdentification_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_NM1_OtherPayerSupervisingProvider_2 {
    [XmlElement(Order=0)]
    public X12_ID_98_12 D_NM101_EntityIdentifierCode {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1065_3 D_NM102_EntityTypeQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_NM103_NameLastorOrganizationName {get; set;}
    [XmlElement(Order=3)]
    public string D_NM104_NameFirst {get; set;}
    [XmlElement(Order=4)]
    public string D_NM105_NameMiddle {get; set;}
    [XmlElement(Order=5)]
    public string D_NM106_NamePrefix {get; set;}
    [XmlElement(Order=6)]
    public string D_NM107_NameSuffix {get; set;}
    [XmlElement(Order=7)]
    public string D_NM108_IdentificationCodeQualifier {get; set;}
    [XmlElement(Order=8)]
    public string D_NM109_IdentificationCode {get; set;}
    [XmlElement(Order=9)]
    public string D_NM110_EntityRelationshipCode {get; set;}
    [XmlElement(Order=10)]
    public string D_NM111_EntityIdentifierCode {get; set;}
    [XmlElement(Order=11)]
    public string D_NM112_NameLastorOrganizationName {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_OtherPayerSupervisingProviderSecondaryIdentification_2 {
    [XmlElement(Order=0)]
    public X12_ID_128_26 D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_OtherPayerSupervisingProviderIdentifier {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03_Description {get; set;}
    [XmlElement(Order=3)]
    public C_C040_ReferenceIdentifier_83 C_C040_ReferenceIdentifier_83 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C040_ReferenceIdentifier_83 {
    [XmlElement(Order=0)]
    public string D_C04001_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C04002_ReferenceIdentification {get; set;}
    [XmlElement(Order=2)]
    public string D_C04003_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C04004_ReferenceIdentification {get; set;}
    [XmlElement(Order=4)]
    public string D_C04005_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_C04006_ReferenceIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_TS837_2330G_1 {
    [XmlElement(Order=0)]
    public S_NM1_OtherPayerBillingProvider_2 S_NM1_OtherPayerBillingProvider_2 {get; set;}
    [XmlElement("S_REF_OtherPayerBillingProviderSecondaryIdentification_2",Order=1)]
    public List<S_REF_OtherPayerBillingProviderSecondaryIdentification_2> S_REF_OtherPayerBillingProviderSecondaryIdentification_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_NM1_OtherPayerBillingProvider_2 {
    [XmlElement(Order=0)]
    public X12_ID_98_4 D_NM101_EntityIdentifierCode {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1065 D_NM102_EntityTypeQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_NM103_NameLastorOrganizationName {get; set;}
    [XmlElement(Order=3)]
    public string D_NM104_NameFirst {get; set;}
    [XmlElement(Order=4)]
    public string D_NM105_NameMiddle {get; set;}
    [XmlElement(Order=5)]
    public string D_NM106_NamePrefix {get; set;}
    [XmlElement(Order=6)]
    public string D_NM107_NameSuffix {get; set;}
    [XmlElement(Order=7)]
    public string D_NM108_IdentificationCodeQualifier {get; set;}
    [XmlElement(Order=8)]
    public string D_NM109_IdentificationCode {get; set;}
    [XmlElement(Order=9)]
    public string D_NM110_EntityRelationshipCode {get; set;}
    [XmlElement(Order=10)]
    public string D_NM111_EntityIdentifierCode {get; set;}
    [XmlElement(Order=11)]
    public string D_NM112_NameLastorOrganizationName {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_OtherPayerBillingProviderSecondaryIdentification_2 {
    [XmlElement(Order=0)]
    public X12_ID_128_10 D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_OtherPayerBillingProviderIdentifier {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03_Description {get; set;}
    [XmlElement(Order=3)]
    public C_C040_ReferenceIdentifier_84 C_C040_ReferenceIdentifier_84 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C040_ReferenceIdentifier_84 {
    [XmlElement(Order=0)]
    public string D_C04001_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C04002_ReferenceIdentification {get; set;}
    [XmlElement(Order=2)]
    public string D_C04003_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C04004_ReferenceIdentification {get; set;}
    [XmlElement(Order=4)]
    public string D_C04005_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_C04006_ReferenceIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_TS837_2400_1 {
    [XmlElement(Order=0)]
    public S_LX_ServiceLineNumber_2 S_LX_ServiceLineNumber_2 {get; set;}
    [XmlElement(Order=1)]
    public S_SV1_ProfessionalService_2 S_SV1_ProfessionalService_2 {get; set;}
    [XmlElement(Order=2)]
    public S_SV5_DurableMedicalEquipmentService_2 S_SV5_DurableMedicalEquipmentService_2 {get; set;}
    [XmlElement(Order=3)]
    public A_PWK_2 A_PWK_2 {get; set;}
    [XmlElement(Order=4)]
    public S_CR1_AmbulanceTransportInformation_4 S_CR1_AmbulanceTransportInformation_4 {get; set;}
    [XmlElement(Order=5)]
    public S_CR3_DurableMedicalEquipmentCertification_2 S_CR3_DurableMedicalEquipmentCertification_2 {get; set;}
    [XmlElement(Order=6)]
    public A_CRC_4 A_CRC_4 {get; set;}
    [XmlElement(Order=7)]
    public A_DTP_4 A_DTP_4 {get; set;}
    [XmlElement(Order=8)]
    public A_QTY_2 A_QTY_2 {get; set;}
    [XmlElement("S_MEA_TestResult_2",Order=9)]
    public List<S_MEA_TestResult_2> S_MEA_TestResult_2 {get; set;}
    [XmlElement(Order=10)]
    public S_CN1_ContractInformation_4 S_CN1_ContractInformation_4 {get; set;}
    [XmlElement(Order=11)]
    public A_REF_11 A_REF_11 {get; set;}
    [XmlElement(Order=12)]
    public A_AMT_4 A_AMT_4 {get; set;}
    [XmlElement("S_K3_FileInformation_4",Order=13)]
    public List<S_K3_FileInformation_4> S_K3_FileInformation_4 {get; set;}
    [XmlElement(Order=14)]
    public A_NTE_2 A_NTE_2 {get; set;}
    [XmlElement(Order=15)]
    public S_PS1_PurchasedServiceInformation_2 S_PS1_PurchasedServiceInformation_2 {get; set;}
    [XmlElement(Order=16)]
    public S_HCP_LinePricing_RepricingInformation_2 S_HCP_LinePricing_RepricingInformation_2 {get; set;}
    [XmlElement(Order=17)]
    public G_TS837_2410_1 G_TS837_2410_1 {get; set;}
    [XmlElement(Order=18)]
    public A_NM1_9 A_NM1_9 {get; set;}
    [XmlElement("G_TS837_2430_1",Order=19)]
    public List<G_TS837_2430_1> G_TS837_2430_1 {get; set;}
    [XmlElement("G_TS837_2440_1",Order=20)]
    public List<G_TS837_2440_1> G_TS837_2440_1 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_LX_ServiceLineNumber_2 {
    [XmlElement(Order=0)]
    public string D_LX01_AssignedNumber {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_SV1_ProfessionalService_2 {
    [XmlElement(Order=0)]
    public C_C003_CompositeMedicalProcedureIdentifier_4 C_C003_CompositeMedicalProcedureIdentifier_4 {get; set;}
    [XmlElement(Order=1)]
    public string D_SV102_LineItemChargeAmount {get; set;}
    [XmlElement(Order=2)]
    public string D_SV103_UnitorBasisforMeasurementCode {get; set;}
    [XmlElement(Order=3)]
    public string D_SV104_ServiceUnitCount {get; set;}
    [XmlElement(Order=4)]
    public string D_SV105_PlaceofServiceCode {get; set;}
    [XmlElement(Order=5)]
    public string D_SV106_ServiceTypeCode {get; set;}
    [XmlElement(Order=6)]
    public C_C004_CompositeDiagnosisCodePointer_2 C_C004_CompositeDiagnosisCodePointer_2 {get; set;}
    [XmlElement(Order=7)]
    public string D_SV108_MonetaryAmount {get; set;}
    [XmlElement(Order=8)]
    public string D_SV109_EmergencyIndicator {get; set;}
    [XmlElement(Order=9)]
    public string D_SV110_MultipleProcedureCode {get; set;}
    [XmlElement(Order=10)]
    public string D_SV111_EPSDTIndicator {get; set;}
    [XmlElement(Order=11)]
    public string D_SV112_FamilyPlanningIndicator {get; set;}
    [XmlElement(Order=12)]
    public string D_SV113_ReviewCode {get; set;}
    [XmlElement(Order=13)]
    public string D_SV114_NationalorLocalAssignedReviewValue {get; set;}
    [XmlElement(Order=14)]
    public string D_SV115_Co_PayStatusCode {get; set;}
    [XmlElement(Order=15)]
    public string D_SV116_HealthCareProfessionalShortageAreaCode {get; set;}
    [XmlElement(Order=16)]
    public string D_SV117_ReferenceIdentification {get; set;}
    [XmlElement(Order=17)]
    public string D_SV118_PostalCode {get; set;}
    [XmlElement(Order=18)]
    public string D_SV119_MonetaryAmount {get; set;}
    [XmlElement(Order=19)]
    public string D_SV120_LevelofCareCode {get; set;}
    [XmlElement(Order=20)]
    public string D_SV121_ProviderAgreementCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C003_CompositeMedicalProcedureIdentifier_4 {
    [XmlElement(Order=0)]
    public X12_ID_235_2 D_C00301_ProductorServiceIDQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C00302_ProcedureCode {get; set;}
    [XmlElement(Order=2)]
    public string D_C00303_ProcedureModifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C00304_ProcedureModifier {get; set;}
    [XmlElement(Order=4)]
    public string D_C00305_ProcedureModifier {get; set;}
    [XmlElement(Order=5)]
    public string D_C00306_ProcedureModifier {get; set;}
    [XmlElement(Order=6)]
    public string D_C00307_Description {get; set;}
    [XmlElement(Order=7)]
    public string D_C00308_Product_ServiceID {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C004_CompositeDiagnosisCodePointer_2 {
    [XmlElement(Order=0)]
    public string D_C00401_DiagnosisCodePointer {get; set;}
    [XmlElement(Order=1)]
    public string D_C00402_DiagnosisCodePointer {get; set;}
    [XmlElement(Order=2)]
    public string D_C00403_DiagnosisCodePointer {get; set;}
    [XmlElement(Order=3)]
    public string D_C00404_DiagnosisCodePointer {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_SV5_DurableMedicalEquipmentService_2 {
    [XmlElement(Order=0)]
    public C_C003_CompositeMedicalProcedureIdentifier_5 C_C003_CompositeMedicalProcedureIdentifier_5 {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_355_6 D_SV502_UnitorBasisforMeasurementCode {get; set;}
    [XmlElement(Order=2)]
    public string D_SV503_LengthofMedicalNecessity {get; set;}
    [XmlElement(Order=3)]
    public string D_SV504_DMERentalPrice {get; set;}
    [XmlElement(Order=4)]
    public string D_SV505_DMEPurchasePrice {get; set;}
    [XmlElement(Order=5)]
    public string D_SV506_RentalUnitPriceIndicator {get; set;}
    [XmlElement(Order=6)]
    public string D_SV507_PrognosisCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C003_CompositeMedicalProcedureIdentifier_5 {
    [XmlElement(Order=0)]
    public X12_ID_235_3 D_C00301_ProcedureIdentifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C00302_ProcedureCode {get; set;}
    [XmlElement(Order=2)]
    public string D_C00303_ProcedureModifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C00304_ProcedureModifier {get; set;}
    [XmlElement(Order=4)]
    public string D_C00305_ProcedureModifier {get; set;}
    [XmlElement(Order=5)]
    public string D_C00306_ProcedureModifier {get; set;}
    [XmlElement(Order=6)]
    public string D_C00307_Description {get; set;}
    [XmlElement(Order=7)]
    public string D_C00308_Product_ServiceID {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class A_PWK_2 {
    [XmlElement(Order=0)]
    public U_PWK_LineSupplementalInformation_2 U_PWK_LineSupplementalInformation_2 {get; set;}
    [XmlElementAttribute(Order=1)]
    public S_PWK_DurableMedicalEquipmentCertificateofMedicalNecessityIndicator_2 S_PWK_DurableMedicalEquipmentCertificateofMedicalNecessityIndicator_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_PWK_LineSupplementalInformation_2 {
    [XmlElement(Order=0)]
    public X12_ID_755_2 D_PWK01_AttachmentReportTypeCode {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_756 D_PWK02_AttachmentTransmissionCode {get; set;}
    [XmlElement(Order=2)]
    public string D_PWK03_ReportCopiesNeeded {get; set;}
    [XmlElement(Order=3)]
    public string D_PWK04_EntityIdentifierCode {get; set;}
    [XmlElement(Order=4)]
    public string D_PWK05_IdentificationCodeQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_PWK06_AttachmentControlNumber {get; set;}
    [XmlElement(Order=6)]
    public string D_PWK07_Description {get; set;}
    [XmlElement(Order=7)]
    public C_C002_ActionsIndicated_5 C_C002_ActionsIndicated_5 {get; set;}
    [XmlElement(Order=8)]
    public string D_PWK09_RequestCategoryCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C002_ActionsIndicated_5 {
    [XmlElement(Order=0)]
    public string D_C00201_Paperwork_ReportActionCode {get; set;}
    [XmlElement(Order=1)]
    public string D_C00202_Paperwork_ReportActionCode {get; set;}
    [XmlElement(Order=2)]
    public string D_C00203_Paperwork_ReportActionCode {get; set;}
    [XmlElement(Order=3)]
    public string D_C00204_Paperwork_ReportActionCode {get; set;}
    [XmlElement(Order=4)]
    public string D_C00205_Paperwork_ReportActionCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_PWK_DurableMedicalEquipmentCertificateofMedicalNecessityIndicator_2 {
    [XmlElement(Order=0)]
    public X12_ID_755_3 D_PWK01_AttachmentReportTypeCode {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_756_2 D_PWK02_AttachmentTransmissionCode {get; set;}
    [XmlElement(Order=2)]
    public string D_PWK03_ReportCopiesNeeded {get; set;}
    [XmlElement(Order=3)]
    public string D_PWK04_EntityIdentifierCode {get; set;}
    [XmlElement(Order=4)]
    public string D_PWK05_IdentificationCodeQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_PWK06_IdentificationCode {get; set;}
    [XmlElement(Order=6)]
    public string D_PWK07_Description {get; set;}
    [XmlElement(Order=7)]
    public C_C002_ActionsIndicated_6 C_C002_ActionsIndicated_6 {get; set;}
    [XmlElement(Order=8)]
    public string D_PWK09_RequestCategoryCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C002_ActionsIndicated_6 {
    [XmlElement(Order=0)]
    public string D_C00201_Paperwork_ReportActionCode {get; set;}
    [XmlElement(Order=1)]
    public string D_C00202_Paperwork_ReportActionCode {get; set;}
    [XmlElement(Order=2)]
    public string D_C00203_Paperwork_ReportActionCode {get; set;}
    [XmlElement(Order=3)]
    public string D_C00204_Paperwork_ReportActionCode {get; set;}
    [XmlElement(Order=4)]
    public string D_C00205_Paperwork_ReportActionCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_CR1_AmbulanceTransportInformation_4 {
    [XmlElement(Order=0)]
    public X12_ID_355_3 D_CR101_UnitorBasisforMeasurementCode {get; set;}
    [XmlElement(Order=1)]
    public string D_CR102_PatientWeight {get; set;}
    [XmlElement(Order=2)]
    public string D_CR103_AmbulanceTransportCode {get; set;}
    [XmlElement(Order=3)]
    public string D_CR104_AmbulanceTransportReasonCode {get; set;}
    [XmlElement(Order=4)]
    public string D_CR105_UnitorBasisforMeasurementCode {get; set;}
    [XmlElement(Order=5)]
    public string D_CR106_TransportDistance {get; set;}
    [XmlElement(Order=6)]
    public string D_CR107_AddressInformation {get; set;}
    [XmlElement(Order=7)]
    public string D_CR108_AddressInformation {get; set;}
    [XmlElement(Order=8)]
    public string D_CR109_RoundTripPurposeDescription {get; set;}
    [XmlElement(Order=9)]
    public string D_CR110_StretcherPurposeDescription {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_CR3_DurableMedicalEquipmentCertification_2 {
    [XmlElement(Order=0)]
    public X12_ID_1322 D_CR301_CertificationTypeCode {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_355_7 D_CR302_UnitorBasisforMeasurementCode {get; set;}
    [XmlElement(Order=2)]
    public string D_CR303_DurableMedicalEquipmentDuration {get; set;}
    [XmlElement(Order=3)]
    public string D_CR304_InsulinDependentCode {get; set;}
    [XmlElement(Order=4)]
    public string D_CR305_Description {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class A_CRC_4 {
    [XmlElement(Order=0)]
    public U_CRC_AmbulanceCertification_4 U_CRC_AmbulanceCertification_4 {get; set;}
    [XmlElementAttribute(Order=1)]
    public S_CRC_HospiceEmployeeIndicator_2 S_CRC_HospiceEmployeeIndicator_2 {get; set;}
    [XmlElementAttribute(Order=2)]
    public S_CRC_ConditionIndicator_DurableMedicalEquipment_2 S_CRC_ConditionIndicator_DurableMedicalEquipment_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_CRC_AmbulanceCertification_4 {
    [XmlElement(Order=0)]
    public X12_ID_1136 D_CRC01_CodeCategory {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1073_3 D_CRC02_CertificationConditionIndicator {get; set;}
    [XmlElement(Order=2)]
    public string D_CRC03_ConditionCode {get; set;}
    [XmlElement(Order=3)]
    public string D_CRC04_ConditionCode {get; set;}
    [XmlElement(Order=4)]
    public string D_CRC05_ConditionCode {get; set;}
    [XmlElement(Order=5)]
    public string D_CRC06_ConditionCode {get; set;}
    [XmlElement(Order=6)]
    public string D_CRC07_ConditionCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_CRC_HospiceEmployeeIndicator_2 {
    [XmlElement(Order=0)]
    public X12_ID_1136_5 D_CRC01_CodeCategory {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1073_3 D_CRC02_HospiceEmployedProviderIndicator {get; set;}
    [XmlElement(Order=2)]
    public string D_CRC03_ConditionIndicator {get; set;}
    [XmlElement(Order=3)]
    public string D_CRC04_ConditionIndicator {get; set;}
    [XmlElement(Order=4)]
    public string D_CRC05_ConditionIndicator {get; set;}
    [XmlElement(Order=5)]
    public string D_CRC06_ConditionIndicator {get; set;}
    [XmlElement(Order=6)]
    public string D_CRC07_ConditionIndicator {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_CRC_ConditionIndicator_DurableMedicalEquipment_2 {
    [XmlElement(Order=0)]
    public X12_ID_1136_6 D_CRC01_CodeCategory {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1073_3 D_CRC02_CertificationConditionIndicator {get; set;}
    [XmlElement(Order=2)]
    public string D_CRC03_ConditionIndicator {get; set;}
    [XmlElement(Order=3)]
    public string D_CRC04_ConditionIndicator {get; set;}
    [XmlElement(Order=4)]
    public string D_CRC05_ConditionIndicator {get; set;}
    [XmlElement(Order=5)]
    public string D_CRC06_ConditionIndicator {get; set;}
    [XmlElement(Order=6)]
    public string D_CRC07_ConditionIndicator {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class A_DTP_4 {
    [XmlElementAttribute(Order=0)]
    public S_DTP_Date_ServiceDate_2 S_DTP_Date_ServiceDate_2 {get; set;}
    [XmlElementAttribute(Order=1)]
    public S_DTP_Date_PrescriptionDate_2 S_DTP_Date_PrescriptionDate_2 {get; set;}
    [XmlElementAttribute(Order=2)]
    public S_DTP_DATE_CertificationRevision_RecertificationDate_2 S_DTP_DATE_CertificationRevision_RecertificationDate_2 {get; set;}
    [XmlElementAttribute(Order=3)]
    public S_DTP_Date_BeginTherapyDate_2 S_DTP_Date_BeginTherapyDate_2 {get; set;}
    [XmlElementAttribute(Order=4)]
    public S_DTP_Date_LastCertificationDate_2 S_DTP_Date_LastCertificationDate_2 {get; set;}
    [XmlElementAttribute(Order=5)]
    public S_DTP_Date_LastSeenDate_4 S_DTP_Date_LastSeenDate_4 {get; set;}
    [XmlElement(Order=6)]
    public U_DTP_Date_TestDate_2 U_DTP_Date_TestDate_2 {get; set;}
    [XmlElementAttribute(Order=7)]
    public S_DTP_Date_ShippedDate_2 S_DTP_Date_ShippedDate_2 {get; set;}
    [XmlElementAttribute(Order=8)]
    public S_DTP_Date_LastX_rayDate_4 S_DTP_Date_LastX_rayDate_4 {get; set;}
    [XmlElementAttribute(Order=9)]
    public S_DTP_Date_InitialTreatmentDate_4 S_DTP_Date_InitialTreatmentDate_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_DTP_Date_ServiceDate_2 {
    [XmlElement(Order=0)]
    public X12_ID_374_19 D_DTP01_DateTimeQualifier {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1250_2 D_DTP02_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_DTP03_ServiceDate {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_DTP_Date_PrescriptionDate_2 {
    [XmlElement(Order=0)]
    public X12_ID_374_9 D_DTP01_DateTimeQualifier {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1250 D_DTP02_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_DTP03_PrescriptionDate {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_DTP_DATE_CertificationRevision_RecertificationDate_2 {
    [XmlElement(Order=0)]
    public X12_ID_374_20 D_DTP01_DateTimeQualifier {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1250 D_DTP02_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_DTP03_CertificationRevisionorRecertificationDate {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_DTP_Date_BeginTherapyDate_2 {
    [XmlElement(Order=0)]
    public X12_ID_374_21 D_DTP01_DateTimeQualifier {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1250 D_DTP02_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_DTP03_BeginTherapyDate {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_DTP_Date_LastCertificationDate_2 {
    [XmlElement(Order=0)]
    public X12_ID_374_22 D_DTP01_DateTimeQualifier {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1250 D_DTP02_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_DTP03_LastCertificationDate {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_DTP_Date_LastSeenDate_4 {
    [XmlElement(Order=0)]
    public X12_ID_374_4 D_DTP01_DateTimeQualifier {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1250 D_DTP02_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_DTP03_TreatmentorTherapyDate {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_DTP_Date_TestDate_2 {
    [XmlElement(Order=0)]
    public X12_ID_374_23 D_DTP01_DateTimeQualifier {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1250 D_DTP02_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_DTP03_TestPerformedDate {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_DTP_Date_ShippedDate_2 {
    [XmlElement(Order=0)]
    public X12_ID_374_24 D_DTP01_DateTimeQualifier {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1250 D_DTP02_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_DTP03_ShippedDate {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_DTP_Date_LastX_rayDate_4 {
    [XmlElement(Order=0)]
    public X12_ID_374_8 D_DTP01_DateTimeQualifier {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1250 D_DTP02_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_DTP03_LastX_RayDate {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_DTP_Date_InitialTreatmentDate_4 {
    [XmlElement(Order=0)]
    public X12_ID_374_3 D_DTP01_DateTimeQualifier {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1250 D_DTP02_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_DTP03_InitialTreatmentDate {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class A_QTY_2 {
    [XmlElementAttribute(Order=0)]
    public S_QTY_AmbulancePatientCount_2 S_QTY_AmbulancePatientCount_2 {get; set;}
    [XmlElementAttribute(Order=1)]
    public S_QTY_ObstetricAnesthesiaAdditionalUnits_2 S_QTY_ObstetricAnesthesiaAdditionalUnits_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_QTY_AmbulancePatientCount_2 {
    [XmlElement(Order=0)]
    public X12_ID_673 D_QTY01_QuantityQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_QTY02_AmbulancePatientCount {get; set;}
    [XmlElement(Order=2)]
    public C_C001_CompositeUnitofMeasure_8 C_C001_CompositeUnitofMeasure_8 {get; set;}
    [XmlElement(Order=3)]
    public string D_QTY04_Free_formInformation {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C001_CompositeUnitofMeasure_8 {
    [XmlElement(Order=0)]
    public string D_C00101_UnitorBasisforMeasurementCode {get; set;}
    [XmlElement(Order=1)]
    public string D_C00102_Exponent {get; set;}
    [XmlElement(Order=2)]
    public string D_C00103_Multiplier {get; set;}
    [XmlElement(Order=3)]
    public string D_C00104_UnitorBasisforMeasurementCode {get; set;}
    [XmlElement(Order=4)]
    public string D_C00105_Exponent {get; set;}
    [XmlElement(Order=5)]
    public string D_C00106_Multiplier {get; set;}
    [XmlElement(Order=6)]
    public string D_C00107_UnitorBasisforMeasurementCode {get; set;}
    [XmlElement(Order=7)]
    public string D_C00108_Exponent {get; set;}
    [XmlElement(Order=8)]
    public string D_C00109_Multiplier {get; set;}
    [XmlElement(Order=9)]
    public string D_C00110_UnitorBasisforMeasurementCode {get; set;}
    [XmlElement(Order=10)]
    public string D_C00111_Exponent {get; set;}
    [XmlElement(Order=11)]
    public string D_C00112_Multiplier {get; set;}
    [XmlElement(Order=12)]
    public string D_C00113_UnitorBasisforMeasurementCode {get; set;}
    [XmlElement(Order=13)]
    public string D_C00114_Exponent {get; set;}
    [XmlElement(Order=14)]
    public string D_C00115_Multiplier {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_QTY_ObstetricAnesthesiaAdditionalUnits_2 {
    [XmlElement(Order=0)]
    public X12_ID_673_2 D_QTY01_QuantityQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_QTY02_ObstetricAdditionalUnits {get; set;}
    [XmlElement(Order=2)]
    public C_C001_CompositeUnitofMeasure_9 C_C001_CompositeUnitofMeasure_9 {get; set;}
    [XmlElement(Order=3)]
    public string D_QTY04_Free_formInformation {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C001_CompositeUnitofMeasure_9 {
    [XmlElement(Order=0)]
    public string D_C00101_UnitorBasisforMeasurementCode {get; set;}
    [XmlElement(Order=1)]
    public string D_C00102_Exponent {get; set;}
    [XmlElement(Order=2)]
    public string D_C00103_Multiplier {get; set;}
    [XmlElement(Order=3)]
    public string D_C00104_UnitorBasisforMeasurementCode {get; set;}
    [XmlElement(Order=4)]
    public string D_C00105_Exponent {get; set;}
    [XmlElement(Order=5)]
    public string D_C00106_Multiplier {get; set;}
    [XmlElement(Order=6)]
    public string D_C00107_UnitorBasisforMeasurementCode {get; set;}
    [XmlElement(Order=7)]
    public string D_C00108_Exponent {get; set;}
    [XmlElement(Order=8)]
    public string D_C00109_Multiplier {get; set;}
    [XmlElement(Order=9)]
    public string D_C00110_UnitorBasisforMeasurementCode {get; set;}
    [XmlElement(Order=10)]
    public string D_C00111_Exponent {get; set;}
    [XmlElement(Order=11)]
    public string D_C00112_Multiplier {get; set;}
    [XmlElement(Order=12)]
    public string D_C00113_UnitorBasisforMeasurementCode {get; set;}
    [XmlElement(Order=13)]
    public string D_C00114_Exponent {get; set;}
    [XmlElement(Order=14)]
    public string D_C00115_Multiplier {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_MEA_TestResult_2 {
    [XmlElement(Order=0)]
    public X12_ID_737 D_MEA01_MeasurementReferenceIdentificationCode {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_738 D_MEA02_MeasurementQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_MEA03_TestResults {get; set;}
    [XmlElement(Order=3)]
    public C_C001_CompositeUnitofMeasure_10 C_C001_CompositeUnitofMeasure_10 {get; set;}
    [XmlElement(Order=4)]
    public string D_MEA05_RangeMinimum {get; set;}
    [XmlElement(Order=5)]
    public string D_MEA06_RangeMaximum {get; set;}
    [XmlElement(Order=6)]
    public string D_MEA07_MeasurementSignificanceCode {get; set;}
    [XmlElement(Order=7)]
    public string D_MEA08_MeasurementAttributeCode {get; set;}
    [XmlElement(Order=8)]
    public string D_MEA09_Surface_Layer_PositionCode {get; set;}
    [XmlElement(Order=9)]
    public string D_MEA10_MeasurementMethodorDevice {get; set;}
    [XmlElement(Order=10)]
    public string D_MEA11_CodeListQualifierCode {get; set;}
    [XmlElement(Order=11)]
    public string D_MEA12_IndustryCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C001_CompositeUnitofMeasure_10 {
    [XmlElement(Order=0)]
    public string D_C00101_UnitorBasisforMeasurementCode {get; set;}
    [XmlElement(Order=1)]
    public string D_C00102_Exponent {get; set;}
    [XmlElement(Order=2)]
    public string D_C00103_Multiplier {get; set;}
    [XmlElement(Order=3)]
    public string D_C00104_UnitorBasisforMeasurementCode {get; set;}
    [XmlElement(Order=4)]
    public string D_C00105_Exponent {get; set;}
    [XmlElement(Order=5)]
    public string D_C00106_Multiplier {get; set;}
    [XmlElement(Order=6)]
    public string D_C00107_UnitorBasisforMeasurementCode {get; set;}
    [XmlElement(Order=7)]
    public string D_C00108_Exponent {get; set;}
    [XmlElement(Order=8)]
    public string D_C00109_Multiplier {get; set;}
    [XmlElement(Order=9)]
    public string D_C00110_UnitorBasisforMeasurementCode {get; set;}
    [XmlElement(Order=10)]
    public string D_C00111_Exponent {get; set;}
    [XmlElement(Order=11)]
    public string D_C00112_Multiplier {get; set;}
    [XmlElement(Order=12)]
    public string D_C00113_UnitorBasisforMeasurementCode {get; set;}
    [XmlElement(Order=13)]
    public string D_C00114_Exponent {get; set;}
    [XmlElement(Order=14)]
    public string D_C00115_Multiplier {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_CN1_ContractInformation_4 {
    [XmlElement(Order=0)]
    public X12_ID_1166 D_CN101_ContractTypeCode {get; set;}
    [XmlElement(Order=1)]
    public string D_CN102_ContractAmount {get; set;}
    [XmlElement(Order=2)]
    public string D_CN103_ContractPercentage {get; set;}
    [XmlElement(Order=3)]
    public string D_CN104_ContractCode {get; set;}
    [XmlElement(Order=4)]
    public string D_CN105_TermsDiscountPercentage {get; set;}
    [XmlElement(Order=5)]
    public string D_CN106_ContractVersionIdentifier {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class A_REF_11 {
    [XmlElementAttribute(Order=0)]
    public S_REF_RepricedLineItemReferenceNumber_2 S_REF_RepricedLineItemReferenceNumber_2 {get; set;}
    [XmlElementAttribute(Order=1)]
    public S_REF_AdjustedRepricedLineItemReferenceNumber_2 S_REF_AdjustedRepricedLineItemReferenceNumber_2 {get; set;}
    [XmlElement(Order=2)]
    public U_REF_PriorAuthorization_4 U_REF_PriorAuthorization_4 {get; set;}
    [XmlElementAttribute(Order=3)]
    public S_REF_LineItemControlNumber_2 S_REF_LineItemControlNumber_2 {get; set;}
    [XmlElementAttribute(Order=4)]
    public S_REF_MammographyCertificationNumber_4 S_REF_MammographyCertificationNumber_4 {get; set;}
    [XmlElementAttribute(Order=5)]
    public S_REF_ClinicalLaboratoryImprovementAmendment_CLIA_Number_4 S_REF_ClinicalLaboratoryImprovementAmendment_CLIA_Number_4 {get; set;}
    [XmlElementAttribute(Order=6)]
    public S_REF_ReferringClinicalLaboratoryImprovementAmendment_CLIA_FacilityIdentification_2 S_REF_ReferringClinicalLaboratoryImprovementAmendment_CLIA_FacilityIdentification_2 {get; set;}
    [XmlElementAttribute(Order=7)]
    public S_REF_ImmunizationBatchNumber_2 S_REF_ImmunizationBatchNumber_2 {get; set;}
    [XmlElement(Order=8)]
    public U_REF_ReferralNumber_4 U_REF_ReferralNumber_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_RepricedLineItemReferenceNumber_2 {
    [XmlElement(Order=0)]
    public X12_ID_128_29 D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_RepricedLineItemReferenceNumber {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03_Description {get; set;}
    [XmlElement(Order=3)]
    public C_C040_ReferenceIdentifier_85 C_C040_ReferenceIdentifier_85 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C040_ReferenceIdentifier_85 {
    [XmlElement(Order=0)]
    public string D_C04001_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C04002_ReferenceIdentification {get; set;}
    [XmlElement(Order=2)]
    public string D_C04003_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C04004_ReferenceIdentification {get; set;}
    [XmlElement(Order=4)]
    public string D_C04005_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_C04006_ReferenceIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_AdjustedRepricedLineItemReferenceNumber_2 {
    [XmlElement(Order=0)]
    public X12_ID_128_30 D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_AdjustedRepricedLineItemReferenceNumber {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03_Description {get; set;}
    [XmlElement(Order=3)]
    public C_C040_ReferenceIdentifier_86 C_C040_ReferenceIdentifier_86 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C040_ReferenceIdentifier_86 {
    [XmlElement(Order=0)]
    public string D_C04001_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C04002_ReferenceIdentification {get; set;}
    [XmlElement(Order=2)]
    public string D_C04003_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C04004_ReferenceIdentification {get; set;}
    [XmlElement(Order=4)]
    public string D_C04005_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_C04006_ReferenceIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_PriorAuthorization_4 {
    [XmlElement(Order=0)]
    public X12_ID_128_15 D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_PriorAuthorizationorReferralNumber {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03_Description {get; set;}
    [XmlElement(Order=3)]
    public C_C040_ReferenceIdentifier_87 C_C040_ReferenceIdentifier_87 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C040_ReferenceIdentifier_87 {
    [XmlElement(Order=0)]
    public string D_C04001_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C04002_OtherPayerPrimaryIdentifier {get; set;}
    [XmlElement(Order=2)]
    public string D_C04003_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C04004_ReferenceIdentification {get; set;}
    [XmlElement(Order=4)]
    public string D_C04005_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_C04006_ReferenceIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_LineItemControlNumber_2 {
    [XmlElement(Order=0)]
    public X12_ID_128_32 D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_LineItemControlNumber {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03_Description {get; set;}
    [XmlElement(Order=3)]
    public C_C040_ReferenceIdentifier_88 C_C040_ReferenceIdentifier_88 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C040_ReferenceIdentifier_88 {
    [XmlElement(Order=0)]
    public string D_C04001_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C04002_ReferenceIdentification {get; set;}
    [XmlElement(Order=2)]
    public string D_C04003_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C04004_ReferenceIdentification {get; set;}
    [XmlElement(Order=4)]
    public string D_C04005_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_C04006_ReferenceIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_MammographyCertificationNumber_4 {
    [XmlElement(Order=0)]
    public X12_ID_128_13 D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_MammographyCertificationNumber {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03_Description {get; set;}
    [XmlElement(Order=3)]
    public C_C040_ReferenceIdentifier_89 C_C040_ReferenceIdentifier_89 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C040_ReferenceIdentifier_89 {
    [XmlElement(Order=0)]
    public string D_C04001_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C04002_ReferenceIdentification {get; set;}
    [XmlElement(Order=2)]
    public string D_C04003_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C04004_ReferenceIdentification {get; set;}
    [XmlElement(Order=4)]
    public string D_C04005_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_C04006_ReferenceIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_ClinicalLaboratoryImprovementAmendment_CLIA_Number_4 {
    [XmlElement(Order=0)]
    public X12_ID_128_17 D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_ClinicalLaboratoryImprovementAmendmentNumber {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03_Description {get; set;}
    [XmlElement(Order=3)]
    public C_C040_ReferenceIdentifier_90 C_C040_ReferenceIdentifier_90 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C040_ReferenceIdentifier_90 {
    [XmlElement(Order=0)]
    public string D_C04001_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C04002_ReferenceIdentification {get; set;}
    [XmlElement(Order=2)]
    public string D_C04003_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C04004_ReferenceIdentification {get; set;}
    [XmlElement(Order=4)]
    public string D_C04005_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_C04006_ReferenceIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_ReferringClinicalLaboratoryImprovementAmendment_CLIA_FacilityIdentification_2 {
    [XmlElement(Order=0)]
    public X12_ID_128_33 D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_ReferringCLIANumber {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03_Description {get; set;}
    [XmlElement(Order=3)]
    public C_C040_ReferenceIdentifier_91 C_C040_ReferenceIdentifier_91 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C040_ReferenceIdentifier_91 {
    [XmlElement(Order=0)]
    public string D_C04001_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C04002_ReferenceIdentification {get; set;}
    [XmlElement(Order=2)]
    public string D_C04003_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C04004_ReferenceIdentification {get; set;}
    [XmlElement(Order=4)]
    public string D_C04005_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_C04006_ReferenceIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_ImmunizationBatchNumber_2 {
    [XmlElement(Order=0)]
    public X12_ID_128_34 D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_ImmunizationBatchNumber {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03_Description {get; set;}
    [XmlElement(Order=3)]
    public C_C040_ReferenceIdentifier_92 C_C040_ReferenceIdentifier_92 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C040_ReferenceIdentifier_92 {
    [XmlElement(Order=0)]
    public string D_C04001_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C04002_ReferenceIdentification {get; set;}
    [XmlElement(Order=2)]
    public string D_C04003_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C04004_ReferenceIdentification {get; set;}
    [XmlElement(Order=4)]
    public string D_C04005_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_C04006_ReferenceIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_ReferralNumber_4 {
    [XmlElement(Order=0)]
    public X12_ID_128_14 D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_ReferralNumber {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03_Description {get; set;}
    [XmlElement(Order=3)]
    public C_C040_ReferenceIdentifier_93 C_C040_ReferenceIdentifier_93 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C040_ReferenceIdentifier_93 {
    [XmlElement(Order=0)]
    public string D_C04001_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C04002_OtherPayerPrimaryIdentifier {get; set;}
    [XmlElement(Order=2)]
    public string D_C04003_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C04004_ReferenceIdentification {get; set;}
    [XmlElement(Order=4)]
    public string D_C04005_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_C04006_ReferenceIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class A_AMT_4 {
    [XmlElementAttribute(Order=0)]
    public S_AMT_SalesTaxAmount_2 S_AMT_SalesTaxAmount_2 {get; set;}
    [XmlElementAttribute(Order=1)]
    public S_AMT_PostageClaimedAmount_2 S_AMT_PostageClaimedAmount_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_AMT_SalesTaxAmount_2 {
    [XmlElement(Order=0)]
    public X12_ID_522_5 D_AMT01_AmountQualifierCode {get; set;}
    [XmlElement(Order=1)]
    public string D_AMT02_SalesTaxAmount {get; set;}
    [XmlElement(Order=2)]
    public string D_AMT03_Credit_DebitFlagCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_AMT_PostageClaimedAmount_2 {
    [XmlElement(Order=0)]
    public X12_ID_522_6 D_AMT01_AmountQualifierCode {get; set;}
    [XmlElement(Order=1)]
    public string D_AMT02_PostageClaimedAmount {get; set;}
    [XmlElement(Order=2)]
    public string D_AMT03_Credit_DebitFlagCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_K3_FileInformation_4 {
    [XmlElement(Order=0)]
    public string D_K301_FixedFormatInformation {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1333 D_K302_RecordFormatCode {get; set;}
    [XmlElement(Order=2)]
    public C_C001_CompositeUnitofMeasure_11 C_C001_CompositeUnitofMeasure_11 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C001_CompositeUnitofMeasure_11 {
    [XmlElement(Order=0)]
    public string D_C00101_UnitorBasisforMeasurementCode {get; set;}
    [XmlElement(Order=1)]
    public string D_C00102_Exponent {get; set;}
    [XmlElement(Order=2)]
    public string D_C00103_Multiplier {get; set;}
    [XmlElement(Order=3)]
    public string D_C00104_UnitorBasisforMeasurementCode {get; set;}
    [XmlElement(Order=4)]
    public string D_C00105_Exponent {get; set;}
    [XmlElement(Order=5)]
    public string D_C00106_Multiplier {get; set;}
    [XmlElement(Order=6)]
    public string D_C00107_UnitorBasisforMeasurementCode {get; set;}
    [XmlElement(Order=7)]
    public string D_C00108_Exponent {get; set;}
    [XmlElement(Order=8)]
    public string D_C00109_Multiplier {get; set;}
    [XmlElement(Order=9)]
    public string D_C00110_UnitorBasisforMeasurementCode {get; set;}
    [XmlElement(Order=10)]
    public string D_C00111_Exponent {get; set;}
    [XmlElement(Order=11)]
    public string D_C00112_Multiplier {get; set;}
    [XmlElement(Order=12)]
    public string D_C00113_UnitorBasisforMeasurementCode {get; set;}
    [XmlElement(Order=13)]
    public string D_C00114_Exponent {get; set;}
    [XmlElement(Order=14)]
    public string D_C00115_Multiplier {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class A_NTE_2 {
    [XmlElementAttribute(Order=0)]
    public S_NTE_LineNote_2 S_NTE_LineNote_2 {get; set;}
    [XmlElementAttribute(Order=1)]
    public S_NTE_ThirdPartyOrganizationNotes_2 S_NTE_ThirdPartyOrganizationNotes_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_NTE_LineNote_2 {
    [XmlElement(Order=0)]
    public X12_ID_363_2 D_NTE01_NoteReferenceCode {get; set;}
    [XmlElement(Order=1)]
    public string D_NTE02_LineNoteText {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_NTE_ThirdPartyOrganizationNotes_2 {
    [XmlElement(Order=0)]
    public X12_ID_363_3 D_NTE01_NoteReferenceCode {get; set;}
    [XmlElement(Order=1)]
    public string D_NTE02_LineNoteText {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_PS1_PurchasedServiceInformation_2 {
    [XmlElement(Order=0)]
    public string D_PS101_PurchasedServiceProviderIdentifier {get; set;}
    [XmlElement(Order=1)]
    public string D_PS102_PurchasedServiceChargeAmount {get; set;}
    [XmlElement(Order=2)]
    public string D_PS103_StateorProvinceCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_HCP_LinePricing_RepricingInformation_2 {
    [XmlElement(Order=0)]
    public X12_ID_1473_2 D_HCP01_PricingMethodology {get; set;}
    [XmlElement(Order=1)]
    public string D_HCP02_RepricedAllowedAmount {get; set;}
    [XmlElement(Order=2)]
    public string D_HCP03_RepricedSavingAmount {get; set;}
    [XmlElement(Order=3)]
    public string D_HCP04_RepricingOrganizationIdentifier {get; set;}
    [XmlElement(Order=4)]
    public string D_HCP05_RepricingPerDiemorFlatRateAmount {get; set;}
    [XmlElement(Order=5)]
    public string D_HCP06_RepricedApprovedAmbulatoryPatientGroupCode {get; set;}
    [XmlElement(Order=6)]
    public string D_HCP07_RepricedApprovedAmbulatoryPatientGroupAmount {get; set;}
    [XmlElement(Order=7)]
    public string D_HCP08_Product_ServiceID {get; set;}
    [XmlElement(Order=8)]
    public string D_HCP09_ProductorServiceIDQualifier {get; set;}
    [XmlElement(Order=9)]
    public string D_HCP10_RepricedApprovedHCPCSCode {get; set;}
    [XmlElement(Order=10)]
    public string D_HCP11_UnitorBasisforMeasurementCode {get; set;}
    [XmlElement(Order=11)]
    public string D_HCP12_RepricedApprovedServiceUnitCount {get; set;}
    [XmlElement(Order=12)]
    public string D_HCP13_RejectReasonCode {get; set;}
    [XmlElement(Order=13)]
    public string D_HCP14_PolicyComplianceCode {get; set;}
    [XmlElement(Order=14)]
    public string D_HCP15_ExceptionCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_TS837_2410_1 {
    [XmlElement(Order=0)]
    public S_LIN_DrugIdentification_2 S_LIN_DrugIdentification_2 {get; set;}
    [XmlElement(Order=1)]
    public S_CTP_DrugQuantity_2 S_CTP_DrugQuantity_2 {get; set;}
    [XmlElement(Order=2)]
    public S_REF_PrescriptionorCompoundDrugAssociationNumber_2 S_REF_PrescriptionorCompoundDrugAssociationNumber_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_LIN_DrugIdentification_2 {
    [XmlElement(Order=0)]
    public string D_LIN01_AssignedIdentification {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_235_4 D_LIN02_ProductorServiceIDQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_LIN03_NationalDrugCodeorUniversalProductNumber {get; set;}
    [XmlElement(Order=3)]
    public string D_LIN04_Product_ServiceIDQualifier {get; set;}
    [XmlElement(Order=4)]
    public string D_LIN05_Product_ServiceID {get; set;}
    [XmlElement(Order=5)]
    public string D_LIN06_Product_ServiceIDQualifier {get; set;}
    [XmlElement(Order=6)]
    public string D_LIN07_Product_ServiceID {get; set;}
    [XmlElement(Order=7)]
    public string D_LIN08_Product_ServiceIDQualifier {get; set;}
    [XmlElement(Order=8)]
    public string D_LIN09_Product_ServiceID {get; set;}
    [XmlElement(Order=9)]
    public string D_LIN10_Product_ServiceIDQualifier {get; set;}
    [XmlElement(Order=10)]
    public string D_LIN11_Product_ServiceID {get; set;}
    [XmlElement(Order=11)]
    public string D_LIN12_Product_ServiceIDQualifier {get; set;}
    [XmlElement(Order=12)]
    public string D_LIN13_Product_ServiceID {get; set;}
    [XmlElement(Order=13)]
    public string D_LIN14_Product_ServiceIDQualifier {get; set;}
    [XmlElement(Order=14)]
    public string D_LIN15_Product_ServiceID {get; set;}
    [XmlElement(Order=15)]
    public string D_LIN16_Product_ServiceIDQualifier {get; set;}
    [XmlElement(Order=16)]
    public string D_LIN17_Product_ServiceID {get; set;}
    [XmlElement(Order=17)]
    public string D_LIN18_Product_ServiceIDQualifier {get; set;}
    [XmlElement(Order=18)]
    public string D_LIN19_Product_ServiceID {get; set;}
    [XmlElement(Order=19)]
    public string D_LIN20_Product_ServiceIDQualifier {get; set;}
    [XmlElement(Order=20)]
    public string D_LIN21_Product_ServiceID {get; set;}
    [XmlElement(Order=21)]
    public string D_LIN22_Product_ServiceIDQualifier {get; set;}
    [XmlElement(Order=22)]
    public string D_LIN23_Product_ServiceID {get; set;}
    [XmlElement(Order=23)]
    public string D_LIN24_Product_ServiceIDQualifier {get; set;}
    [XmlElement(Order=24)]
    public string D_LIN25_Product_ServiceID {get; set;}
    [XmlElement(Order=25)]
    public string D_LIN26_Product_ServiceIDQualifier {get; set;}
    [XmlElement(Order=26)]
    public string D_LIN27_Product_ServiceID {get; set;}
    [XmlElement(Order=27)]
    public string D_LIN28_Product_ServiceIDQualifier {get; set;}
    [XmlElement(Order=28)]
    public string D_LIN29_Product_ServiceID {get; set;}
    [XmlElement(Order=29)]
    public string D_LIN30_Product_ServiceIDQualifier {get; set;}
    [XmlElement(Order=30)]
    public string D_LIN31_Product_ServiceID {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_CTP_DrugQuantity_2 {
    [XmlElement(Order=0)]
    public X12_ID_687 D_CTP01_ClassofTradeCode {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_236 D_CTP02_PriceIdentifierCode {get; set;}
    [XmlElement(Order=2)]
    public string D_CTP03_UnitPrice {get; set;}
    [XmlElement(Order=3)]
    public string D_CTP04_NationalDrugUnitCount {get; set;}
    [XmlElement(Order=4)]
    public C_C001_CompositeUnitofMeasure_12 C_C001_CompositeUnitofMeasure_12 {get; set;}
    [XmlElement(Order=5)]
    public string D_CTP06_PriceMultiplierQualifier {get; set;}
    [XmlElement(Order=6)]
    public string D_CTP07_Multiplier {get; set;}
    [XmlElement(Order=7)]
    public string D_CTP08_MonetaryAmount {get; set;}
    [XmlElement(Order=8)]
    public string D_CTP09_BasisofUnitPriceCode {get; set;}
    [XmlElement(Order=9)]
    public string D_CTP10_ConditionValue {get; set;}
    [XmlElement(Order=10)]
    public string D_CTP11_MultiplePriceQuantity {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C001_CompositeUnitofMeasure_12 {
    [XmlElement(Order=0)]
    public string D_C00101_CodeQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C00102_Exponent {get; set;}
    [XmlElement(Order=2)]
    public string D_C00103_Multiplier {get; set;}
    [XmlElement(Order=3)]
    public string D_C00104_UnitorBasisforMeasurementCode {get; set;}
    [XmlElement(Order=4)]
    public string D_C00105_Exponent {get; set;}
    [XmlElement(Order=5)]
    public string D_C00106_Multiplier {get; set;}
    [XmlElement(Order=6)]
    public string D_C00107_UnitorBasisforMeasurementCode {get; set;}
    [XmlElement(Order=7)]
    public string D_C00108_Exponent {get; set;}
    [XmlElement(Order=8)]
    public string D_C00109_Multiplier {get; set;}
    [XmlElement(Order=9)]
    public string D_C00110_UnitorBasisforMeasurementCode {get; set;}
    [XmlElement(Order=10)]
    public string D_C00111_Exponent {get; set;}
    [XmlElement(Order=11)]
    public string D_C00112_Multiplier {get; set;}
    [XmlElement(Order=12)]
    public string D_C00113_UnitorBasisforMeasurementCode {get; set;}
    [XmlElement(Order=13)]
    public string D_C00114_Exponent {get; set;}
    [XmlElement(Order=14)]
    public string D_C00115_Multiplier {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_PrescriptionorCompoundDrugAssociationNumber_2 {
    [XmlElement(Order=0)]
    public X12_ID_128_35 D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_PrescriptionNumber {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03_Description {get; set;}
    [XmlElement(Order=3)]
    public C_C040_ReferenceIdentifier_94 C_C040_ReferenceIdentifier_94 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C040_ReferenceIdentifier_94 {
    [XmlElement(Order=0)]
    public string D_C04001_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C04002_ReferenceIdentification {get; set;}
    [XmlElement(Order=2)]
    public string D_C04003_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C04004_ReferenceIdentification {get; set;}
    [XmlElement(Order=4)]
    public string D_C04005_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_C04006_ReferenceIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class A_NM1_9 {
    [XmlElementAttribute(Order=0)]
    public G_TS837_2420A_1 G_TS837_2420A_1 {get; set;}
    [XmlElementAttribute(Order=1)]
    public G_TS837_2420B_1 G_TS837_2420B_1 {get; set;}
    [XmlElementAttribute(Order=2)]
    public G_TS837_2420C_1 G_TS837_2420C_1 {get; set;}
    [XmlElementAttribute(Order=3)]
    public G_TS837_2420D_1 G_TS837_2420D_1 {get; set;}
    [XmlElementAttribute(Order=4)]
    public G_TS837_2420E_1 G_TS837_2420E_1 {get; set;}
    [XmlElement(Order=5)]
    public U_TS837_2420F_1 U_TS837_2420F_1 {get; set;}
    [XmlElementAttribute(Order=6)]
    public G_TS837_2420G_1 G_TS837_2420G_1 {get; set;}
    [XmlElementAttribute(Order=7)]
    public G_TS837_2420H_1 G_TS837_2420H_1 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_TS837_2420A_1 {
    [XmlElement(Order=0)]
    public S_NM1_RenderingProviderName_4 S_NM1_RenderingProviderName_4 {get; set;}
    [XmlElement(Order=1)]
    public S_PRV_RenderingProviderSpecialtyInformation_4 S_PRV_RenderingProviderSpecialtyInformation_4 {get; set;}
    [XmlElement("S_REF_RenderingProviderSecondaryIdentification_4",Order=2)]
    public List<S_REF_RenderingProviderSecondaryIdentification_4> S_REF_RenderingProviderSecondaryIdentification_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_NM1_RenderingProviderName_4 {
    [XmlElement(Order=0)]
    public X12_ID_98_10 D_NM101_EntityIdentifierCode {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1065 D_NM102_EntityTypeQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_NM103_RenderingProviderLastorOrganizationName {get; set;}
    [XmlElement(Order=3)]
    public string D_NM104_RenderingProviderFirstName {get; set;}
    [XmlElement(Order=4)]
    public string D_NM105_RenderingProviderMiddleName {get; set;}
    [XmlElement(Order=5)]
    public string D_NM106_NamePrefix {get; set;}
    [XmlElement(Order=6)]
    public string D_NM107_RenderingProviderNameSuffix {get; set;}
    [XmlElement(Order=7)]
    public string D_NM108_IdentificationCodeQualifier {get; set;}
    [XmlElement(Order=8)]
    public string D_NM109_RenderingProviderIdentifier {get; set;}
    [XmlElement(Order=9)]
    public string D_NM110_EntityRelationshipCode {get; set;}
    [XmlElement(Order=10)]
    public string D_NM111_EntityIdentifierCode {get; set;}
    [XmlElement(Order=11)]
    public string D_NM112_NameLastorOrganizationName {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_PRV_RenderingProviderSpecialtyInformation_4 {
    [XmlElement(Order=0)]
    public X12_ID_1221_2 D_PRV01_ProviderCode {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_128 D_PRV02_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_PRV03_ProviderTaxonomyCode {get; set;}
    [XmlElement(Order=3)]
    public string D_PRV04_StateorProvinceCode {get; set;}
    [XmlElement(Order=4)]
    public C_C035_ProviderSpecialtyInformation_5 C_C035_ProviderSpecialtyInformation_5 {get; set;}
    [XmlElement(Order=5)]
    public string D_PRV06_ProviderOrganizationCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C035_ProviderSpecialtyInformation_5 {
    [XmlElement(Order=0)]
    public string D_C03501_ProviderSpecialtyCode {get; set;}
    [XmlElement(Order=1)]
    public string D_C03502_AgencyQualifierCode {get; set;}
    [XmlElement(Order=2)]
    public string D_C03503_Yes_NoConditionorResponseCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_RenderingProviderSecondaryIdentification_4 {
    [XmlElement(Order=0)]
    public X12_ID_128_26 D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_RenderingProviderSecondaryIdentifier {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03_Description {get; set;}
    [XmlElement(Order=3)]
    public C_C040_ReferenceIdentifier_95 C_C040_ReferenceIdentifier_95 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C040_ReferenceIdentifier_95 {
    [XmlElement(Order=0)]
    public string D_C04001_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C04002_OtherPayerPrimaryIdentifier {get; set;}
    [XmlElement(Order=2)]
    public string D_C04003_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C04004_ReferenceIdentification {get; set;}
    [XmlElement(Order=4)]
    public string D_C04005_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_C04006_ReferenceIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_TS837_2420B_1 {
    [XmlElement(Order=0)]
    public S_NM1_PurchasedServiceProviderName_2 S_NM1_PurchasedServiceProviderName_2 {get; set;}
    [XmlElement("S_REF_PurchasedServiceProviderSecondaryIdentification_2",Order=1)]
    public List<S_REF_PurchasedServiceProviderSecondaryIdentification_2> S_REF_PurchasedServiceProviderSecondaryIdentification_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_NM1_PurchasedServiceProviderName_2 {
    [XmlElement(Order=0)]
    public X12_ID_98_15 D_NM101_EntityIdentifierCode {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1065 D_NM102_EntityTypeQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_NM103_NameLastorOrganizationName {get; set;}
    [XmlElement(Order=3)]
    public string D_NM104_NameFirst {get; set;}
    [XmlElement(Order=4)]
    public string D_NM105_NameMiddle {get; set;}
    [XmlElement(Order=5)]
    public string D_NM106_NamePrefix {get; set;}
    [XmlElement(Order=6)]
    public string D_NM107_NameSuffix {get; set;}
    [XmlElement(Order=7)]
    public string D_NM108_IdentificationCodeQualifier {get; set;}
    [XmlElement(Order=8)]
    public string D_NM109_PurchasedServiceProviderIdentifier {get; set;}
    [XmlElement(Order=9)]
    public string D_NM110_EntityRelationshipCode {get; set;}
    [XmlElement(Order=10)]
    public string D_NM111_EntityIdentifierCode {get; set;}
    [XmlElement(Order=11)]
    public string D_NM112_NameLastorOrganizationName {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_PurchasedServiceProviderSecondaryIdentification_2 {
    [XmlElement(Order=0)]
    public X12_ID_128_25 D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_PurchasedServiceProviderSecondaryIdentifier {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03_Description {get; set;}
    [XmlElement(Order=3)]
    public C_C040_ReferenceIdentifier_96 C_C040_ReferenceIdentifier_96 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C040_ReferenceIdentifier_96 {
    [XmlElement(Order=0)]
    public string D_C04001_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C04002_OtherPayerPrimaryIdentifier {get; set;}
    [XmlElement(Order=2)]
    public string D_C04003_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C04004_ReferenceIdentification {get; set;}
    [XmlElement(Order=4)]
    public string D_C04005_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_C04006_ReferenceIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_TS837_2420C_1 {
    [XmlElement(Order=0)]
    public S_NM1_ServiceFacilityLocation_2 S_NM1_ServiceFacilityLocation_2 {get; set;}
    [XmlElement(Order=1)]
    public S_N3_ServiceFacilityLocationAddress_4 S_N3_ServiceFacilityLocationAddress_4 {get; set;}
    [XmlElement(Order=2)]
    public S_N4_ServiceFacilityLocationCity_State_ZIPCode_4 S_N4_ServiceFacilityLocationCity_State_ZIPCode_4 {get; set;}
    [XmlElement("S_REF_ServiceFacilityLocationSecondaryIdentification_4",Order=3)]
    public List<S_REF_ServiceFacilityLocationSecondaryIdentification_4> S_REF_ServiceFacilityLocationSecondaryIdentification_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_NM1_ServiceFacilityLocation_2 {
    [XmlElement(Order=0)]
    public X12_ID_98_11 D_NM101_EntityIdentifierCode {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1065_2 D_NM102_EntityTypeQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_NM103_LaboratoryorFacilityName {get; set;}
    [XmlElement(Order=3)]
    public string D_NM104_NameFirst {get; set;}
    [XmlElement(Order=4)]
    public string D_NM105_NameMiddle {get; set;}
    [XmlElement(Order=5)]
    public string D_NM106_NamePrefix {get; set;}
    [XmlElement(Order=6)]
    public string D_NM107_NameSuffix {get; set;}
    [XmlElement(Order=7)]
    public string D_NM108_IdentificationCodeQualifier {get; set;}
    [XmlElement(Order=8)]
    public string D_NM109_LaboratoryorFacilityPrimaryIdentifier {get; set;}
    [XmlElement(Order=9)]
    public string D_NM110_EntityRelationshipCode {get; set;}
    [XmlElement(Order=10)]
    public string D_NM111_EntityIdentifierCode {get; set;}
    [XmlElement(Order=11)]
    public string D_NM112_NameLastorOrganizationName {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_N3_ServiceFacilityLocationAddress_4 {
    [XmlElement(Order=0)]
    public string D_N301_LaboratoryorFacilityAddressLine {get; set;}
    [XmlElement(Order=1)]
    public string D_N302_LaboratoryorFacilityAddressLine {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_N4_ServiceFacilityLocationCity_State_ZIPCode_4 {
    [XmlElement(Order=0)]
    public string D_N401_LaboratoryorFacilityCityName {get; set;}
    [XmlElement(Order=1)]
    public string D_N402_LaboratoryorFacilityStateorProvinceCode {get; set;}
    [XmlElement(Order=2)]
    public string D_N403_LaboratoryorFacilityPostalZoneorZIPCode {get; set;}
    [XmlElement(Order=3)]
    public string D_N404_CountryCode {get; set;}
    [XmlElement(Order=4)]
    public string D_N405_LocationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_N406_LocationIdentifier {get; set;}
    [XmlElement(Order=6)]
    public string D_N407_CountrySubdivisionCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_ServiceFacilityLocationSecondaryIdentification_4 {
    [XmlElement(Order=0)]
    public X12_ID_128_10 D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_ServiceFacilityLocationSecondaryIdentifier {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03_Description {get; set;}
    [XmlElement(Order=3)]
    public C_C040_ReferenceIdentifier_97 C_C040_ReferenceIdentifier_97 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C040_ReferenceIdentifier_97 {
    [XmlElement(Order=0)]
    public string D_C04001_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C04002_OtherPayerPrimaryIdentifier {get; set;}
    [XmlElement(Order=2)]
    public string D_C04003_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C04004_ReferenceIdentification {get; set;}
    [XmlElement(Order=4)]
    public string D_C04005_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_C04006_ReferenceIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_TS837_2420D_1 {
    [XmlElement(Order=0)]
    public S_NM1_SupervisingProviderName_4 S_NM1_SupervisingProviderName_4 {get; set;}
    [XmlElement("S_REF_SupervisingProviderSecondaryIdentification_4",Order=1)]
    public List<S_REF_SupervisingProviderSecondaryIdentification_4> S_REF_SupervisingProviderSecondaryIdentification_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_NM1_SupervisingProviderName_4 {
    [XmlElement(Order=0)]
    public X12_ID_98_12 D_NM101_EntityIdentifierCode {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1065_3 D_NM102_EntityTypeQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_NM103_SupervisingProviderLastName {get; set;}
    [XmlElement(Order=3)]
    public string D_NM104_SupervisingProviderFirstName {get; set;}
    [XmlElement(Order=4)]
    public string D_NM105_SupervisingProviderMiddleNameorInitial {get; set;}
    [XmlElement(Order=5)]
    public string D_NM106_NamePrefix {get; set;}
    [XmlElement(Order=6)]
    public string D_NM107_SupervisingProviderNameSuffix {get; set;}
    [XmlElement(Order=7)]
    public string D_NM108_IdentificationCodeQualifier {get; set;}
    [XmlElement(Order=8)]
    public string D_NM109_SupervisingProviderIdentifier {get; set;}
    [XmlElement(Order=9)]
    public string D_NM110_EntityRelationshipCode {get; set;}
    [XmlElement(Order=10)]
    public string D_NM111_EntityIdentifierCode {get; set;}
    [XmlElement(Order=11)]
    public string D_NM112_NameLastorOrganizationName {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_SupervisingProviderSecondaryIdentification_4 {
    [XmlElement(Order=0)]
    public X12_ID_128_26 D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_SupervisingProviderSecondaryIdentifier {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03_Description {get; set;}
    [XmlElement(Order=3)]
    public C_C040_ReferenceIdentifier_98 C_C040_ReferenceIdentifier_98 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C040_ReferenceIdentifier_98 {
    [XmlElement(Order=0)]
    public string D_C04001_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C04002_OtherPayerPrimaryIdentifier {get; set;}
    [XmlElement(Order=2)]
    public string D_C04003_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C04004_ReferenceIdentification {get; set;}
    [XmlElement(Order=4)]
    public string D_C04005_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_C04006_ReferenceIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_TS837_2420E_1 {
    [XmlElement(Order=0)]
    public S_NM1_OrderingProviderName_2 S_NM1_OrderingProviderName_2 {get; set;}
    [XmlElement(Order=1)]
    public S_N3_OrderingProviderAddress_2 S_N3_OrderingProviderAddress_2 {get; set;}
    [XmlElement(Order=2)]
    public S_N4_OrderingProviderCity_State_ZIPCode_2 S_N4_OrderingProviderCity_State_ZIPCode_2 {get; set;}
    [XmlElement("S_REF_OrderingProviderSecondaryIdentification_2",Order=3)]
    public List<S_REF_OrderingProviderSecondaryIdentification_2> S_REF_OrderingProviderSecondaryIdentification_2 {get; set;}
    [XmlElement(Order=4)]
    public S_PER_OrderingProviderContactInformation_2 S_PER_OrderingProviderContactInformation_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_NM1_OrderingProviderName_2 {
    [XmlElement(Order=0)]
    public X12_ID_98_16 D_NM101_EntityIdentifierCode {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1065_3 D_NM102_EntityTypeQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_NM103_OrderingProviderLastName {get; set;}
    [XmlElement(Order=3)]
    public string D_NM104_OrderingProviderFirstName {get; set;}
    [XmlElement(Order=4)]
    public string D_NM105_OrderingProviderMiddleNameorInitial {get; set;}
    [XmlElement(Order=5)]
    public string D_NM106_NamePrefix {get; set;}
    [XmlElement(Order=6)]
    public string D_NM107_OrderingProviderNameSuffix {get; set;}
    [XmlElement(Order=7)]
    public string D_NM108_IdentificationCodeQualifier {get; set;}
    [XmlElement(Order=8)]
    public string D_NM109_OrderingProviderIdentifier {get; set;}
    [XmlElement(Order=9)]
    public string D_NM110_EntityRelationshipCode {get; set;}
    [XmlElement(Order=10)]
    public string D_NM111_EntityIdentifierCode {get; set;}
    [XmlElement(Order=11)]
    public string D_NM112_NameLastorOrganizationName {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_N3_OrderingProviderAddress_2 {
    [XmlElement(Order=0)]
    public string D_N301_OrderingProviderAddressLine {get; set;}
    [XmlElement(Order=1)]
    public string D_N302_OrderingProviderAddressLine {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_N4_OrderingProviderCity_State_ZIPCode_2 {
    [XmlElement(Order=0)]
    public string D_N401_OrderingProviderCityName {get; set;}
    [XmlElement(Order=1)]
    public string D_N402_OrderingProviderStateorProvinceCode {get; set;}
    [XmlElement(Order=2)]
    public string D_N403_OrderingProviderPostalZoneorZIPCode {get; set;}
    [XmlElement(Order=3)]
    public string D_N404_CountryCode {get; set;}
    [XmlElement(Order=4)]
    public string D_N405_LocationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_N406_LocationIdentifier {get; set;}
    [XmlElement(Order=6)]
    public string D_N407_CountrySubdivisionCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_OrderingProviderSecondaryIdentification_2 {
    [XmlElement(Order=0)]
    public X12_ID_128_25 D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_OrderingProviderSecondaryIdentifier {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03_Description {get; set;}
    [XmlElement(Order=3)]
    public C_C040_ReferenceIdentifier_99 C_C040_ReferenceIdentifier_99 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C040_ReferenceIdentifier_99 {
    [XmlElement(Order=0)]
    public string D_C04001_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C04002_OtherPayerPrimaryIdentifier {get; set;}
    [XmlElement(Order=2)]
    public string D_C04003_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C04004_ReferenceIdentification {get; set;}
    [XmlElement(Order=4)]
    public string D_C04005_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_C04006_ReferenceIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_PER_OrderingProviderContactInformation_2 {
    [XmlElement(Order=0)]
    public X12_ID_366 D_PER01_ContactFunctionCode {get; set;}
    [XmlElement(Order=1)]
    public string D_PER02_OrderingProviderContactName {get; set;}
    [XmlElement(Order=2)]
    public string D_PER03_CommunicationNumberQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_PER04_CommunicationNumber {get; set;}
    [XmlElement(Order=4)]
    public string D_PER05_CommunicationNumberQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_PER06_CommunicationNumber {get; set;}
    [XmlElement(Order=6)]
    public string D_PER07_CommunicationNumberQualifier {get; set;}
    [XmlElement(Order=7)]
    public string D_PER08_CommunicationNumber {get; set;}
    [XmlElement(Order=8)]
    public string D_PER09_ContactInquiryReference {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_TS837_2420F_1 {
    [XmlElement(Order=0)]
    public S_NM1_ReferringProviderName_4 S_NM1_ReferringProviderName_4 {get; set;}
    [XmlElement("S_REF_ReferringProviderSecondaryIdentification_4",Order=1)]
    public List<S_REF_ReferringProviderSecondaryIdentification_4> S_REF_ReferringProviderSecondaryIdentification_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_NM1_ReferringProviderName_4 {
    [XmlElement(Order=0)]
    public X12_ID_98_9 D_NM101_EntityIdentifierCode {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1065_3 D_NM102_EntityTypeQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_NM103_ReferringProviderLastName {get; set;}
    [XmlElement(Order=3)]
    public string D_NM104_ReferringProviderFirstName {get; set;}
    [XmlElement(Order=4)]
    public string D_NM105_ReferringProviderMiddleNameorInitial {get; set;}
    [XmlElement(Order=5)]
    public string D_NM106_NamePrefix {get; set;}
    [XmlElement(Order=6)]
    public string D_NM107_ReferringProviderNameSuffix {get; set;}
    [XmlElement(Order=7)]
    public string D_NM108_IdentificationCodeQualifier {get; set;}
    [XmlElement(Order=8)]
    public string D_NM109_ReferringProviderIdentifier {get; set;}
    [XmlElement(Order=9)]
    public string D_NM110_EntityRelationshipCode {get; set;}
    [XmlElement(Order=10)]
    public string D_NM111_EntityIdentifierCode {get; set;}
    [XmlElement(Order=11)]
    public string D_NM112_NameLastorOrganizationName {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_ReferringProviderSecondaryIdentification_4 {
    [XmlElement(Order=0)]
    public X12_ID_128_25 D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_ReferringProviderSecondaryIdentifier {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03_Description {get; set;}
    [XmlElement(Order=3)]
    public C_C040_ReferenceIdentifier_100 C_C040_ReferenceIdentifier_100 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C040_ReferenceIdentifier_100 {
    [XmlElement(Order=0)]
    public string D_C04001_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C04002_OtherPayerPrimaryIdentifier {get; set;}
    [XmlElement(Order=2)]
    public string D_C04003_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C04004_ReferenceIdentification {get; set;}
    [XmlElement(Order=4)]
    public string D_C04005_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_C04006_ReferenceIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_TS837_2420G_1 {
    [XmlElement(Order=0)]
    public S_NM1_AmbulancePick_upLocation_4 S_NM1_AmbulancePick_upLocation_4 {get; set;}
    [XmlElement(Order=1)]
    public S_N3_AmbulancePick_upLocationAddress_4 S_N3_AmbulancePick_upLocationAddress_4 {get; set;}
    [XmlElement(Order=2)]
    public S_N4_AmbulancePick_upLocationCity_State_ZipCode_4 S_N4_AmbulancePick_upLocationCity_State_ZipCode_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_NM1_AmbulancePick_upLocation_4 {
    [XmlElement(Order=0)]
    public X12_ID_98_13 D_NM101_EntityIdentifierCode {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1065_2 D_NM102_EntityTypeQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_NM103_NameLastorOrganizationName {get; set;}
    [XmlElement(Order=3)]
    public string D_NM104_NameFirst {get; set;}
    [XmlElement(Order=4)]
    public string D_NM105_NameMiddle {get; set;}
    [XmlElement(Order=5)]
    public string D_NM106_NamePrefix {get; set;}
    [XmlElement(Order=6)]
    public string D_NM107_NameSuffix {get; set;}
    [XmlElement(Order=7)]
    public string D_NM108_IdentificationCodeQualifier {get; set;}
    [XmlElement(Order=8)]
    public string D_NM109_IdentificationCode {get; set;}
    [XmlElement(Order=9)]
    public string D_NM110_EntityRelationshipCode {get; set;}
    [XmlElement(Order=10)]
    public string D_NM111_EntityIdentifierCode {get; set;}
    [XmlElement(Order=11)]
    public string D_NM112_NameLastorOrganizationName {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_N3_AmbulancePick_upLocationAddress_4 {
    [XmlElement(Order=0)]
    public string D_N301_AmbulancePick_upAddressLine {get; set;}
    [XmlElement(Order=1)]
    public string D_N302_AmbulancePick_upAddressLine {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_N4_AmbulancePick_upLocationCity_State_ZipCode_4 {
    [XmlElement(Order=0)]
    public string D_N401_AmbulancePick_upCityName {get; set;}
    [XmlElement(Order=1)]
    public string D_N402_AmbulancePick_upStateorProvinceCode {get; set;}
    [XmlElement(Order=2)]
    public string D_N403_AmbulancePick_upPostalZoneorZIPCode {get; set;}
    [XmlElement(Order=3)]
    public string D_N404_CountryCode {get; set;}
    [XmlElement(Order=4)]
    public string D_N405_LocationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_N406_LocationIdentifier {get; set;}
    [XmlElement(Order=6)]
    public string D_N407_CountrySubdivisionCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_TS837_2420H_1 {
    [XmlElement(Order=0)]
    public S_NM1_AmbulanceDrop_offLocation_4 S_NM1_AmbulanceDrop_offLocation_4 {get; set;}
    [XmlElement(Order=1)]
    public S_N3_AmbulanceDrop_offLocationAddress_4 S_N3_AmbulanceDrop_offLocationAddress_4 {get; set;}
    [XmlElement(Order=2)]
    public S_N4_AmbulanceDrop_offLocationCity_State_ZipCode_4 S_N4_AmbulanceDrop_offLocationCity_State_ZipCode_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_NM1_AmbulanceDrop_offLocation_4 {
    [XmlElement(Order=0)]
    public X12_ID_98_14 D_NM101_EntityIdentifierCode {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1065_2 D_NM102_EntityTypeQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_NM103_AmbulanceDrop_offLocation {get; set;}
    [XmlElement(Order=3)]
    public string D_NM104_NameFirst {get; set;}
    [XmlElement(Order=4)]
    public string D_NM105_NameMiddle {get; set;}
    [XmlElement(Order=5)]
    public string D_NM106_NamePrefix {get; set;}
    [XmlElement(Order=6)]
    public string D_NM107_NameSuffix {get; set;}
    [XmlElement(Order=7)]
    public string D_NM108_IdentificationCodeQualifier {get; set;}
    [XmlElement(Order=8)]
    public string D_NM109_IdentificationCode {get; set;}
    [XmlElement(Order=9)]
    public string D_NM110_EntityRelationshipCode {get; set;}
    [XmlElement(Order=10)]
    public string D_NM111_EntityIdentifierCode {get; set;}
    [XmlElement(Order=11)]
    public string D_NM112_NameLastorOrganizationName {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_N3_AmbulanceDrop_offLocationAddress_4 {
    [XmlElement(Order=0)]
    public string D_N301_AmbulanceDrop_offAddressLine {get; set;}
    [XmlElement(Order=1)]
    public string D_N302_AmbulanceDrop_offAddressLine {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_N4_AmbulanceDrop_offLocationCity_State_ZipCode_4 {
    [XmlElement(Order=0)]
    public string D_N401_AmbulanceDrop_offCityName {get; set;}
    [XmlElement(Order=1)]
    public string D_N402_AmbulanceDrop_offStateorProvinceCode {get; set;}
    [XmlElement(Order=2)]
    public string D_N403_AmbulanceDrop_offPostalZoneorZIPCode {get; set;}
    [XmlElement(Order=3)]
    public string D_N404_CountryCode {get; set;}
    [XmlElement(Order=4)]
    public string D_N405_LocationQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_N406_LocationIdentifier {get; set;}
    [XmlElement(Order=6)]
    public string D_N407_CountrySubdivisionCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_TS837_2430_1 {
    [XmlElement(Order=0)]
    public S_SVD_LineAdjudicationInformation_2 S_SVD_LineAdjudicationInformation_2 {get; set;}
    [XmlElement("S_CAS_LineAdjustment_2",Order=1)]
    public List<S_CAS_LineAdjustment_2> S_CAS_LineAdjustment_2 {get; set;}
    [XmlElement(Order=2)]
    public S_DTP_LineCheckorRemittanceDate_2 S_DTP_LineCheckorRemittanceDate_2 {get; set;}
    [XmlElement(Order=3)]
    public S_AMT_RemainingPatientLiability_4 S_AMT_RemainingPatientLiability_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_SVD_LineAdjudicationInformation_2 {
    [XmlElement(Order=0)]
    public string D_SVD01_OtherPayerPrimaryIdentifier {get; set;}
    [XmlElement(Order=1)]
    public string D_SVD02_ServiceLinePaidAmount {get; set;}
    [XmlElement(Order=2)]
    public C_C003_CompositeMedicalProcedureIdentifier_6 C_C003_CompositeMedicalProcedureIdentifier_6 {get; set;}
    [XmlElement(Order=3)]
    public string D_SVD04_Product_ServiceID {get; set;}
    [XmlElement(Order=4)]
    public string D_SVD05_PaidServiceUnitCount {get; set;}
    [XmlElement(Order=5)]
    public string D_SVD06_BundledorUnbundledLineNumber {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_C003_CompositeMedicalProcedureIdentifier_6 {
    [XmlElement(Order=0)]
    public string D_C00301_ProductorServiceIDQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_C00302_ProcedureCode {get; set;}
    [XmlElement(Order=2)]
    public string D_C00303_ProcedureModifier {get; set;}
    [XmlElement(Order=3)]
    public string D_C00304_ProcedureModifier {get; set;}
    [XmlElement(Order=4)]
    public string D_C00305_ProcedureModifier {get; set;}
    [XmlElement(Order=5)]
    public string D_C00306_ProcedureModifier {get; set;}
    [XmlElement(Order=6)]
    public string D_C00307_ProcedureCodeDescription {get; set;}
    [XmlElement(Order=7)]
    public string D_C00308_Product_ServiceID {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_CAS_LineAdjustment_2 {
    [XmlElement(Order=0)]
    public X12_ID_1033 D_CAS01_ClaimAdjustmentGroupCode {get; set;}
    [XmlElement(Order=1)]
    public string D_CAS02_AdjustmentReasonCode {get; set;}
    [XmlElement(Order=2)]
    public string D_CAS03_AdjustmentAmount {get; set;}
    [XmlElement(Order=3)]
    public string D_CAS04_AdjustmentQuantity {get; set;}
    [XmlElement(Order=4)]
    public string D_CAS05_AdjustmentReasonCode {get; set;}
    [XmlElement(Order=5)]
    public string D_CAS06_AdjustmentAmount {get; set;}
    [XmlElement(Order=6)]
    public string D_CAS07_AdjustmentQuantity {get; set;}
    [XmlElement(Order=7)]
    public string D_CAS08_AdjustmentReasonCode {get; set;}
    [XmlElement(Order=8)]
    public string D_CAS09_AdjustmentAmount {get; set;}
    [XmlElement(Order=9)]
    public string D_CAS10_AdjustmentQuantity {get; set;}
    [XmlElement(Order=10)]
    public string D_CAS11_AdjustmentReasonCode {get; set;}
    [XmlElement(Order=11)]
    public string D_CAS12_AdjustmentAmount {get; set;}
    [XmlElement(Order=12)]
    public string D_CAS13_AdjustmentQuantity {get; set;}
    [XmlElement(Order=13)]
    public string D_CAS14_AdjustmentReasonCode {get; set;}
    [XmlElement(Order=14)]
    public string D_CAS15_AdjustmentAmount {get; set;}
    [XmlElement(Order=15)]
    public string D_CAS16_AdjustmentQuantity {get; set;}
    [XmlElement(Order=16)]
    public string D_CAS17_AdjustmentReasonCode {get; set;}
    [XmlElement(Order=17)]
    public string D_CAS18_AdjustmentAmount {get; set;}
    [XmlElement(Order=18)]
    public string D_CAS19_AdjustmentQuantity {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_DTP_LineCheckorRemittanceDate_2 {
    [XmlElement(Order=0)]
    public X12_ID_374_18 D_DTP01_DateTimeQualifier {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1250 D_DTP02_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_DTP03_AdjudicationorPaymentDate {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_AMT_RemainingPatientLiability_4 {
    [XmlElement(Order=0)]
    public X12_ID_522_4 D_AMT01_AmountQualifierCode {get; set;}
    [XmlElement(Order=1)]
    public string D_AMT02_RemainingPatientLiability {get; set;}
    [XmlElement(Order=2)]
    public string D_AMT03_Credit_DebitFlagCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_TS837_2440_1 {
    [XmlElement(Order=0)]
    public S_LQ_FormIdentificationCode_2 S_LQ_FormIdentificationCode_2 {get; set;}
    [XmlElement("S_FRM_SupportingDocumentation_2",Order=1)]
    public List<S_FRM_SupportingDocumentation_2> S_FRM_SupportingDocumentation_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_LQ_FormIdentificationCode_2 {
    [XmlElement(Order=0)]
    public X12_ID_1270_7 D_LQ01_CodeListQualifierCode {get; set;}
    [XmlElement(Order=1)]
    public string D_LQ02_FormIdentifier {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_FRM_SupportingDocumentation_2 {
    [XmlElement(Order=0)]
    public string D_FRM01_QuestionNumber_Letter {get; set;}
    [XmlElement(Order=1)]
    public X12_ID_1073_4 D_FRM02_QuestionResponse {get; set;}
    [XmlElement(Order=2)]
    public string D_FRM03_QuestionResponse {get; set;}
    [XmlElement(Order=3)]
    public string D_FRM04_QuestionResponse {get; set;}
    [XmlElement(Order=4)]
    public string D_FRM05_QuestionResponse {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_SE {
    [XmlElement(Order=0)]
    public string D_SE01_TransactionSegmentCount {get; set;}
    [XmlElement(Order=1)]
    public string D_SE02_TransactionSetControlNumber {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class U_REF_BillingProviderUPIN_LicenseInformation {
    [XmlElement("S_REF_BillingProviderUPIN_LicenseInformation",Order=0)]
    public List<S_REF_BillingProviderUPIN_LicenseInformation> S_REF_BillingProviderUPIN_LicenseInformation {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class U_REF_PayerSecondaryIdentification {
    [XmlElement("S_REF_PayerSecondaryIdentification",Order=0)]
    public List<S_REF_PayerSecondaryIdentification> S_REF_PayerSecondaryIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class U_REF_BillingProviderSecondaryIdentification {
    [XmlElement("S_REF_BillingProviderSecondaryIdentification",Order=0)]
    public List<S_REF_BillingProviderSecondaryIdentification> S_REF_BillingProviderSecondaryIdentification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class U_DTP_Date_AssumedandRelinquishedCareDates {
    [XmlElement("S_DTP_Date_AssumedandRelinquishedCareDates",Order=0)]
    public List<S_DTP_Date_AssumedandRelinquishedCareDates> S_DTP_Date_AssumedandRelinquishedCareDates {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class U_CRC_AmbulanceCertification {
    [XmlElement("S_CRC_AmbulanceCertification",Order=0)]
    public List<S_CRC_AmbulanceCertification> S_CRC_AmbulanceCertification {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class U_CRC_PatientConditionInformation_Vision {
    [XmlElement("S_CRC_PatientConditionInformation_Vision",Order=0)]
    public List<S_CRC_PatientConditionInformation_Vision> S_CRC_PatientConditionInformation_Vision {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class U_HI_ConditionInformation {
    [XmlElement("S_HI_ConditionInformation",Order=0)]
    public List<S_HI_ConditionInformation> S_HI_ConditionInformation {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class U_TS837_2310A {
    [XmlElement("G_TS837_2310A",Order=0)]
    public List<G_TS837_2310A> G_TS837_2310A {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class U_REF_OtherPayerSecondaryIdentifier {
    [XmlElement("S_REF_OtherPayerSecondaryIdentifier",Order=0)]
    public List<S_REF_OtherPayerSecondaryIdentifier> S_REF_OtherPayerSecondaryIdentifier {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class U_TS837_2330C {
    [XmlElement("G_TS837_2330C",Order=0)]
    public List<G_TS837_2330C> G_TS837_2330C {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class U_PWK_LineSupplementalInformation {
    [XmlElement("S_PWK_LineSupplementalInformation",Order=0)]
    public List<S_PWK_LineSupplementalInformation> S_PWK_LineSupplementalInformation {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class U_CRC_AmbulanceCertification_2 {
    [XmlElement("S_CRC_AmbulanceCertification_2",Order=0)]
    public List<S_CRC_AmbulanceCertification_2> S_CRC_AmbulanceCertification_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class U_DTP_Date_TestDate {
    [XmlElement("S_DTP_Date_TestDate",Order=0)]
    public List<S_DTP_Date_TestDate> S_DTP_Date_TestDate {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class U_REF_PriorAuthorization_2 {
    [XmlElement("S_REF_PriorAuthorization_2",Order=0)]
    public List<S_REF_PriorAuthorization_2> S_REF_PriorAuthorization_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class U_REF_ReferralNumber_2 {
    [XmlElement("S_REF_ReferralNumber_2",Order=0)]
    public List<S_REF_ReferralNumber_2> S_REF_ReferralNumber_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class U_TS837_2420F {
    [XmlElement("G_TS837_2420F",Order=0)]
    public List<G_TS837_2420F> G_TS837_2420F {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class U_DTP_Date_AssumedandRelinquishedCareDates_2 {
    [XmlElement("S_DTP_Date_AssumedandRelinquishedCareDates_2",Order=0)]
    public List<S_DTP_Date_AssumedandRelinquishedCareDates_2> S_DTP_Date_AssumedandRelinquishedCareDates_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class U_CRC_AmbulanceCertification_3 {
    [XmlElement("S_CRC_AmbulanceCertification_3",Order=0)]
    public List<S_CRC_AmbulanceCertification_3> S_CRC_AmbulanceCertification_3 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class U_CRC_PatientConditionInformation_Vision_2 {
    [XmlElement("S_CRC_PatientConditionInformation_Vision_2",Order=0)]
    public List<S_CRC_PatientConditionInformation_Vision_2> S_CRC_PatientConditionInformation_Vision_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class U_HI_ConditionInformation_2 {
    [XmlElement("S_HI_ConditionInformation_2",Order=0)]
    public List<S_HI_ConditionInformation_2> S_HI_ConditionInformation_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class U_TS837_2310A_1 {
    [XmlElement("G_TS837_2310A_1",Order=0)]
    public List<G_TS837_2310A_1> G_TS837_2310A_1 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class U_REF_OtherPayerSecondaryIdentifier_2 {
    [XmlElement("S_REF_OtherPayerSecondaryIdentifier_2",Order=0)]
    public List<S_REF_OtherPayerSecondaryIdentifier_2> S_REF_OtherPayerSecondaryIdentifier_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class U_TS837_2330C_1 {
    [XmlElement("G_TS837_2330C_1",Order=0)]
    public List<G_TS837_2330C_1> G_TS837_2330C_1 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class U_PWK_LineSupplementalInformation_2 {
    [XmlElement("S_PWK_LineSupplementalInformation_2",Order=0)]
    public List<S_PWK_LineSupplementalInformation_2> S_PWK_LineSupplementalInformation_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class U_CRC_AmbulanceCertification_4 {
    [XmlElement("S_CRC_AmbulanceCertification_4",Order=0)]
    public List<S_CRC_AmbulanceCertification_4> S_CRC_AmbulanceCertification_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class U_DTP_Date_TestDate_2 {
    [XmlElement("S_DTP_Date_TestDate_2",Order=0)]
    public List<S_DTP_Date_TestDate_2> S_DTP_Date_TestDate_2 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class U_REF_PriorAuthorization_4 {
    [XmlElement("S_REF_PriorAuthorization_4",Order=0)]
    public List<S_REF_PriorAuthorization_4> S_REF_PriorAuthorization_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class U_REF_ReferralNumber_4 {
    [XmlElement("S_REF_ReferralNumber_4",Order=0)]
    public List<S_REF_ReferralNumber_4> S_REF_ReferralNumber_4 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class U_TS837_2420F_1 {
    [XmlElement("G_TS837_2420F_1",Order=0)]
    public List<G_TS837_2420F_1> G_TS837_2420F_1 {get; set;}
    }
}
