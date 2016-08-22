namespace EdiFabric.Definitions.Hipaa_004010_837_X098 {
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
    public S_BHT_BeginningOfHierarchicalTransaction_TS837Q1 S_BHT_BeginningOfHierarchicalTransaction_TS837Q1 {get; set;}
    [XmlElement(Order=2)]
    public S_REF_TransmissionTypeIdentification_TS837Q1 S_REF_TransmissionTypeIdentification_TS837Q1 {get; set;}
    [XmlElement(Order=3)]
    public G_TS837Q1_1000A G_TS837Q1_1000A {get; set;}
    [XmlElement(Order=4)]
    public G_TS837Q1_1000B G_TS837Q1_1000B {get; set;}
    [XmlElement("G_TS837Q1_2000A",Order=5)]
    public List<G_TS837Q1_2000A> G_TS837Q1_2000A {get; set;}
    [XmlElement(Order=6)]
    public S_SE S_SE {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_ST {
    [XmlElement(Order=0)]
    public string D_ST01 {get; set;}
    [XmlElement(Order=1)]
    public string D_ST02 {get; set;}
    [XmlElement(Order=2)]
    public string D_ST03 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_BHT_BeginningOfHierarchicalTransaction_TS837Q1 {
    [XmlElement(Order=0)]
    public S_BHT_BeginningOfHierarchicalTransaction_TS837Q1D_BHT01_HierarchicalStructureCode D_BHT01_HierarchicalStructureCode {get; set;}
    [XmlElement(Order=1)]
    public S_BHT_BeginningOfHierarchicalTransaction_TS837Q1D_BHT02_TransactionSetPurposeCode D_BHT02_TransactionSetPurposeCode {get; set;}
    [XmlElement(Order=2)]
    public string D_BHT03_OriginatorApplicationTransactionIdentifier {get; set;}
    [XmlElement(Order=3)]
    public string D_BHT04_TransactionSetCreationDate {get; set;}
    [XmlElement(Order=4)]
    public string D_BHT05_TransactionSetCreationTime {get; set;}
    [XmlElement(Order=5)]
    public string D_BHT06_ClaimOrEncounterIdentifier {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_BHT_BeginningOfHierarchicalTransaction_TS837Q1D_BHT01_HierarchicalStructureCode {
        [XmlEnum("0019")]
        Item0019,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_BHT_BeginningOfHierarchicalTransaction_TS837Q1D_BHT02_TransactionSetPurposeCode {
        [XmlEnum("00")]
        Item00,
        [XmlEnum("18")]
        Item18,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_TransmissionTypeIdentification_TS837Q1 {
    [XmlElement(Order=0)]
    public S_REF_TransmissionTypeIdentification_TS837Q1D_REF01_ReferenceIdentificationQualifier D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_TransmissionTypeCode {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03 {get; set;}
    [XmlElement(Order=3)]
    public string D_REF04_C040U826 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_REF_TransmissionTypeIdentification_TS837Q1D_REF01_ReferenceIdentificationQualifier {
        [XmlEnum("87")]
        Item87,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_TS837Q1_1000A {
    [XmlElement(Order=0)]
    public S_NM1_SubmitterName_TS837Q1_1000A S_NM1_SubmitterName_TS837Q1_1000A {get; set;}
    [XmlElement("S_PER_SubmitterEDIContactInformation_TS837Q1_1000A",Order=1)]
    public List<S_PER_SubmitterEDIContactInformation_TS837Q1_1000A> S_PER_SubmitterEDIContactInformation_TS837Q1_1000A {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_NM1_SubmitterName_TS837Q1_1000A {
    [XmlElement(Order=0)]
    public S_NM1_SubmitterName_TS837Q1_1000AD_NM101_EntityIdentifierCode D_NM101_EntityIdentifierCode {get; set;}
    [XmlElement(Order=1)]
    public S_NM1_SubmitterName_TS837Q1_1000AD_NM102_EntityTypeQualifier D_NM102_EntityTypeQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_NM103_SubmitterLastOrOrganizationName {get; set;}
    [XmlElement(Order=3)]
    public string D_NM104_SubmitterFirstName {get; set;}
    [XmlElement(Order=4)]
    public string D_NM105_SubmitterMiddleName {get; set;}
    [XmlElement(Order=5)]
    public string D_NM106 {get; set;}
    [XmlElement(Order=6)]
    public string D_NM107 {get; set;}
    [XmlElement(Order=7)]
    public string D_NM108_IdentificationCodeQualifier {get; set;}
    [XmlElement(Order=8)]
    public string D_NM109_SubmitterIdentifier {get; set;}
    [XmlElement(Order=9)]
    public string D_NM110 {get; set;}
    [XmlElement(Order=10)]
    public string D_NM111 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_NM1_SubmitterName_TS837Q1_1000AD_NM101_EntityIdentifierCode {
        [XmlEnum("41")]
        Item41,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_NM1_SubmitterName_TS837Q1_1000AD_NM102_EntityTypeQualifier {
        [XmlEnum("1")]
        Item1,
        [XmlEnum("2")]
        Item2,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_PER_SubmitterEDIContactInformation_TS837Q1_1000A {
    [XmlElement(Order=0)]
    public S_PER_SubmitterEDIContactInformation_TS837Q1_1000AD_PER01_ContactFunctionCode D_PER01_ContactFunctionCode {get; set;}
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
    public string D_PER09 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_PER_SubmitterEDIContactInformation_TS837Q1_1000AD_PER01_ContactFunctionCode {
        IC,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_TS837Q1_1000B {
    [XmlElement(Order=0)]
    public S_NM1_ReceiverName_TS837Q1_1000B S_NM1_ReceiverName_TS837Q1_1000B {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_NM1_ReceiverName_TS837Q1_1000B {
    [XmlElement(Order=0)]
    public S_NM1_ReceiverName_TS837Q1_1000BD_NM101_EntityIdentifierCode D_NM101_EntityIdentifierCode {get; set;}
    [XmlElement(Order=1)]
    public S_NM1_ReceiverName_TS837Q1_1000BD_NM102_EntityTypeQualifier D_NM102_EntityTypeQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_NM103_ReceiverName {get; set;}
    [XmlElement(Order=3)]
    public string D_NM104 {get; set;}
    [XmlElement(Order=4)]
    public string D_NM105 {get; set;}
    [XmlElement(Order=5)]
    public string D_NM106 {get; set;}
    [XmlElement(Order=6)]
    public string D_NM107 {get; set;}
    [XmlElement(Order=7)]
    public string D_NM108_IdentificationCodeQualifier {get; set;}
    [XmlElement(Order=8)]
    public string D_NM109_ReceiverPrimaryIdentifier {get; set;}
    [XmlElement(Order=9)]
    public string D_NM110 {get; set;}
    [XmlElement(Order=10)]
    public string D_NM111 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_NM1_ReceiverName_TS837Q1_1000BD_NM101_EntityIdentifierCode {
        [XmlEnum("40")]
        Item40,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_NM1_ReceiverName_TS837Q1_1000BD_NM102_EntityTypeQualifier {
        [XmlEnum("2")]
        Item2,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_TS837Q1_2000A {
    [XmlElement(Order=0)]
    public S_HL_BillingPaytoProviderHierarchicalLevel_TS837Q1_2000A S_HL_BillingPaytoProviderHierarchicalLevel_TS837Q1_2000A {get; set;}
    [XmlElement(Order=1)]
    public S_PRV_BillingPaytoProviderSpecialtyInformation_TS837Q1_2000A S_PRV_BillingPaytoProviderSpecialtyInformation_TS837Q1_2000A {get; set;}
    [XmlElement(Order=2)]
    public S_CUR_ForeignCurrencyInformation_TS837Q1_2000A S_CUR_ForeignCurrencyInformation_TS837Q1_2000A {get; set;}
    [XmlElement(Order=3)]
    public A_TS837Q1_2010A A_TS837Q1_2010A {get; set;}
    [XmlElement("G_TS837Q1_2000B",Order=4)]
    public List<G_TS837Q1_2000B> G_TS837Q1_2000B {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_HL_BillingPaytoProviderHierarchicalLevel_TS837Q1_2000A {
    [XmlElement(Order=0)]
    public string D_HL01_HierarchicalIDNumber {get; set;}
    [XmlElement(Order=1)]
    public string D_HL02 {get; set;}
    [XmlElement(Order=2)]
    public string D_HL03_HierarchicalLevelCode {get; set;}
    [XmlElement(Order=3)]
    public string D_HL04_HierarchicalChildCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_PRV_BillingPaytoProviderSpecialtyInformation_TS837Q1_2000A {
    [XmlElement(Order=0)]
    public S_PRV_BillingPaytoProviderSpecialtyInformation_TS837Q1_2000AD_PRV01_ProviderCode D_PRV01_ProviderCode {get; set;}
    [XmlElement(Order=1)]
    public S_PRV_BillingPaytoProviderSpecialtyInformation_TS837Q1_2000AD_PRV02_ReferenceIdentificationQualifier D_PRV02_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_PRV03_ProviderTaxonomyCode {get; set;}
    [XmlElement(Order=3)]
    public string D_PRV04 {get; set;}
    [XmlElement(Order=4)]
    public string D_PRV05_C035U827 {get; set;}
    [XmlElement(Order=5)]
    public string D_PRV06 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_PRV_BillingPaytoProviderSpecialtyInformation_TS837Q1_2000AD_PRV01_ProviderCode {
        BI,
        PT,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_PRV_BillingPaytoProviderSpecialtyInformation_TS837Q1_2000AD_PRV02_ReferenceIdentificationQualifier {
        ZZ,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_CUR_ForeignCurrencyInformation_TS837Q1_2000A {
    [XmlElement(Order=0)]
    public S_CUR_ForeignCurrencyInformation_TS837Q1_2000AD_CUR01_EntityIdentifierCode D_CUR01_EntityIdentifierCode {get; set;}
    [XmlElement(Order=1)]
    public string D_CUR02_CurrencyCode {get; set;}
    [XmlElement(Order=2)]
    public string D_CUR03 {get; set;}
    [XmlElement(Order=3)]
    public string D_CUR04 {get; set;}
    [XmlElement(Order=4)]
    public string D_CUR05 {get; set;}
    [XmlElement(Order=5)]
    public string D_CUR06 {get; set;}
    [XmlElement(Order=6)]
    public string D_CUR07 {get; set;}
    [XmlElement(Order=7)]
    public string D_CUR08 {get; set;}
    [XmlElement(Order=8)]
    public string D_CUR09 {get; set;}
    [XmlElement(Order=9)]
    public string D_CUR10 {get; set;}
    [XmlElement(Order=10)]
    public string D_CUR11 {get; set;}
    [XmlElement(Order=11)]
    public string D_CUR12 {get; set;}
    [XmlElement(Order=12)]
    public string D_CUR13 {get; set;}
    [XmlElement(Order=13)]
    public string D_CUR14 {get; set;}
    [XmlElement(Order=14)]
    public string D_CUR15 {get; set;}
    [XmlElement(Order=15)]
    public string D_CUR16 {get; set;}
    [XmlElement(Order=16)]
    public string D_CUR17 {get; set;}
    [XmlElement(Order=17)]
    public string D_CUR18 {get; set;}
    [XmlElement(Order=18)]
    public string D_CUR19 {get; set;}
    [XmlElement(Order=19)]
    public string D_CUR20 {get; set;}
    [XmlElement(Order=20)]
    public string D_CUR21 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_CUR_ForeignCurrencyInformation_TS837Q1_2000AD_CUR01_EntityIdentifierCode {
        [XmlEnum("85")]
        Item85,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class A_TS837Q1_2010A {
    [XmlElementAttribute(Order=0)]
    public G_TS837Q1_2010AA G_TS837Q1_2010AA {get; set;}
    [XmlElementAttribute(Order=1)]
    public G_TS837Q1_2010AB G_TS837Q1_2010AB {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_TS837Q1_2010AA {
    [XmlElement(Order=0)]
    public S_NM1_BillingProviderName_TS837Q1_2010AA S_NM1_BillingProviderName_TS837Q1_2010AA {get; set;}
    [XmlElement(Order=1)]
    public S_N3_BillingProviderAddress_TS837Q1_2010AA S_N3_BillingProviderAddress_TS837Q1_2010AA {get; set;}
    [XmlElement(Order=2)]
    public S_N4_BillingProviderCityStateZIPCode_TS837Q1_2010AA S_N4_BillingProviderCityStateZIPCode_TS837Q1_2010AA {get; set;}
    [XmlElement(Order=3)]
    public A_REF_TS837Q1_2010AA A_REF_TS837Q1_2010AA {get; set;}
    [XmlElement("S_PER_BillingProviderContactInformation_TS837Q1_2010AA",Order=4)]
    public List<S_PER_BillingProviderContactInformation_TS837Q1_2010AA> S_PER_BillingProviderContactInformation_TS837Q1_2010AA {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_NM1_BillingProviderName_TS837Q1_2010AA {
    [XmlElement(Order=0)]
    public S_NM1_BillingProviderName_TS837Q1_2010AAD_NM101_EntityIdentifierCode D_NM101_EntityIdentifierCode {get; set;}
    [XmlElement(Order=1)]
    public S_NM1_BillingProviderName_TS837Q1_2010AAD_NM102_EntityTypeQualifier D_NM102_EntityTypeQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_NM103_BillingProviderLastOrOrganizationalName {get; set;}
    [XmlElement(Order=3)]
    public string D_NM104_BillingProviderFirstName {get; set;}
    [XmlElement(Order=4)]
    public string D_NM105_BillingProviderMiddleName {get; set;}
    [XmlElement(Order=5)]
    public string D_NM106 {get; set;}
    [XmlElement(Order=6)]
    public string D_NM107_BillingProviderNameSuffix {get; set;}
    [XmlElement(Order=7)]
    public string D_NM108_IdentificationCodeQualifier {get; set;}
    [XmlElement(Order=8)]
    public string D_NM109_BillingProviderIdentifier {get; set;}
    [XmlElement(Order=9)]
    public string D_NM110 {get; set;}
    [XmlElement(Order=10)]
    public string D_NM111 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_NM1_BillingProviderName_TS837Q1_2010AAD_NM101_EntityIdentifierCode {
        [XmlEnum("85")]
        Item85,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_NM1_BillingProviderName_TS837Q1_2010AAD_NM102_EntityTypeQualifier {
        [XmlEnum("1")]
        Item1,
        [XmlEnum("2")]
        Item2,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_N3_BillingProviderAddress_TS837Q1_2010AA {
    [XmlElement(Order=0)]
    public string D_N301_BillingProviderAddressLine {get; set;}
    [XmlElement(Order=1)]
    public string D_N302_BillingProviderAddressLine {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_N4_BillingProviderCityStateZIPCode_TS837Q1_2010AA {
    [XmlElement(Order=0)]
    public string D_N401_BillingProviderCityName {get; set;}
    [XmlElement(Order=1)]
    public string D_N402_BillingProviderStateOrProvinceCode {get; set;}
    [XmlElement(Order=2)]
    public string D_N403_BillingProviderPostalZoneOrZIPCode {get; set;}
    [XmlElement(Order=3)]
    public string D_N404_CountryCode {get; set;}
    [XmlElement(Order=4)]
    public string D_N405 {get; set;}
    [XmlElement(Order=5)]
    public string D_N406 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class A_REF_TS837Q1_2010AA {
    [XmlElement(Order=0)]
    public U_REF_BillingProviderSecondaryIdentification_TS837Q1_2010AA U_REF_BillingProviderSecondaryIdentification_TS837Q1_2010AA {get; set;}
    [XmlElement(Order=1)]
    public U_REF_CreditDebitCardBillingInformation_TS837Q1_2010AA U_REF_CreditDebitCardBillingInformation_TS837Q1_2010AA {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_BillingProviderSecondaryIdentification_TS837Q1_2010AA {
    [XmlElement(Order=0)]
    public S_REF_BillingProviderSecondaryIdentification_TS837Q1_2010AAD_REF01_ReferenceIdentificationQualifier D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_BillingProviderAdditionalIdentifier {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03 {get; set;}
    [XmlElement(Order=3)]
    public string D_REF04_C040U828 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_REF_BillingProviderSecondaryIdentification_TS837Q1_2010AAD_REF01_ReferenceIdentificationQualifier {
        [XmlEnum("0B")]
        Item0B,
        [XmlEnum("1A")]
        Item1A,
        [XmlEnum("1B")]
        Item1B,
        [XmlEnum("1C")]
        Item1C,
        [XmlEnum("1D")]
        Item1D,
        [XmlEnum("1G")]
        Item1G,
        [XmlEnum("1H")]
        Item1H,
        [XmlEnum("1J")]
        Item1J,
        B3,
        BQ,
        EI,
        FH,
        G2,
        G5,
        LU,
        SY,
        U3,
        X5,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_CreditDebitCardBillingInformation_TS837Q1_2010AA {
    [XmlElement(Order=0)]
    public S_REF_CreditDebitCardBillingInformation_TS837Q1_2010AAD_REF01_ReferenceIdentificationQualifier D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_BillingProviderCreditCardIdentifier {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03 {get; set;}
    [XmlElement(Order=3)]
    public string D_REF04_C040U829 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_REF_CreditDebitCardBillingInformation_TS837Q1_2010AAD_REF01_ReferenceIdentificationQualifier {
        [XmlEnum("06")]
        Item06,
        [XmlEnum("8U")]
        Item8U,
        EM,
        IJ,
        RB,
        ST,
        TT,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_PER_BillingProviderContactInformation_TS837Q1_2010AA {
    [XmlElement(Order=0)]
    public S_PER_BillingProviderContactInformation_TS837Q1_2010AAD_PER01_ContactFunctionCode D_PER01_ContactFunctionCode {get; set;}
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
    public string D_PER09 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_PER_BillingProviderContactInformation_TS837Q1_2010AAD_PER01_ContactFunctionCode {
        IC,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_TS837Q1_2010AB {
    [XmlElement(Order=0)]
    public S_NM1_PaytoProviderName_TS837Q1_2010AB S_NM1_PaytoProviderName_TS837Q1_2010AB {get; set;}
    [XmlElement(Order=1)]
    public S_N3_PaytoProviderAddress_TS837Q1_2010AB S_N3_PaytoProviderAddress_TS837Q1_2010AB {get; set;}
    [XmlElement(Order=2)]
    public S_N4_PaytoProviderCityStateZIPCode_TS837Q1_2010AB S_N4_PaytoProviderCityStateZIPCode_TS837Q1_2010AB {get; set;}
    [XmlElement("S_REF_PaytoProviderSecondaryIdentification_TS837Q1_2010AB",Order=3)]
    public List<S_REF_PaytoProviderSecondaryIdentification_TS837Q1_2010AB> S_REF_PaytoProviderSecondaryIdentification_TS837Q1_2010AB {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_NM1_PaytoProviderName_TS837Q1_2010AB {
    [XmlElement(Order=0)]
    public S_NM1_PaytoProviderName_TS837Q1_2010ABD_NM101_EntityIdentifierCode D_NM101_EntityIdentifierCode {get; set;}
    [XmlElement(Order=1)]
    public S_NM1_PaytoProviderName_TS837Q1_2010ABD_NM102_EntityTypeQualifier D_NM102_EntityTypeQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_NM103_PaytoProviderLastOrOrganizationalName {get; set;}
    [XmlElement(Order=3)]
    public string D_NM104_PaytoProviderFirstName {get; set;}
    [XmlElement(Order=4)]
    public string D_NM105_PaytoProviderMiddleName {get; set;}
    [XmlElement(Order=5)]
    public string D_NM106 {get; set;}
    [XmlElement(Order=6)]
    public string D_NM107_PaytoProviderNameSuffix {get; set;}
    [XmlElement(Order=7)]
    public string D_NM108_IdentificationCodeQualifier {get; set;}
    [XmlElement(Order=8)]
    public string D_NM109_PaytoProviderIdentifier {get; set;}
    [XmlElement(Order=9)]
    public string D_NM110 {get; set;}
    [XmlElement(Order=10)]
    public string D_NM111 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_NM1_PaytoProviderName_TS837Q1_2010ABD_NM101_EntityIdentifierCode {
        [XmlEnum("87")]
        Item87,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_NM1_PaytoProviderName_TS837Q1_2010ABD_NM102_EntityTypeQualifier {
        [XmlEnum("1")]
        Item1,
        [XmlEnum("2")]
        Item2,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_N3_PaytoProviderAddress_TS837Q1_2010AB {
    [XmlElement(Order=0)]
    public string D_N301_PaytoProviderAddressLine {get; set;}
    [XmlElement(Order=1)]
    public string D_N302_PaytoProviderAddressLine {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_N4_PaytoProviderCityStateZIPCode_TS837Q1_2010AB {
    [XmlElement(Order=0)]
    public string D_N401_PaytoProviderCityName {get; set;}
    [XmlElement(Order=1)]
    public string D_N402_PaytoProviderStateCode {get; set;}
    [XmlElement(Order=2)]
    public string D_N403_PaytoProviderPostalZoneOrZIPCode {get; set;}
    [XmlElement(Order=3)]
    public string D_N404_CountryCode {get; set;}
    [XmlElement(Order=4)]
    public string D_N405 {get; set;}
    [XmlElement(Order=5)]
    public string D_N406 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_PaytoProviderSecondaryIdentification_TS837Q1_2010AB {
    [XmlElement(Order=0)]
    public S_REF_PaytoProviderSecondaryIdentification_TS837Q1_2010ABD_REF01_ReferenceIdentificationQualifier D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_PaytoProviderIdentifier {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03 {get; set;}
    [XmlElement(Order=3)]
    public string D_REF04_C040U830 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_REF_PaytoProviderSecondaryIdentification_TS837Q1_2010ABD_REF01_ReferenceIdentificationQualifier {
        [XmlEnum("0B")]
        Item0B,
        [XmlEnum("1A")]
        Item1A,
        [XmlEnum("1B")]
        Item1B,
        [XmlEnum("1C")]
        Item1C,
        [XmlEnum("1D")]
        Item1D,
        [XmlEnum("1G")]
        Item1G,
        [XmlEnum("1H")]
        Item1H,
        [XmlEnum("1J")]
        Item1J,
        B3,
        BQ,
        EI,
        FH,
        G2,
        G5,
        LU,
        SY,
        U3,
        X5,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_TS837Q1_2000B {
    [XmlElement(Order=0)]
    public S_HL_SubscriberHierarchicalLevel_TS837Q1_2000B S_HL_SubscriberHierarchicalLevel_TS837Q1_2000B {get; set;}
    [XmlElement(Order=1)]
    public S_SBR_SubscriberInformation_TS837Q1_2000B S_SBR_SubscriberInformation_TS837Q1_2000B {get; set;}
    [XmlElement(Order=2)]
    public S_PAT_PatientInformation_TS837Q1_2000B S_PAT_PatientInformation_TS837Q1_2000B {get; set;}
    [XmlElement(Order=3)]
    public A_TS837Q1_2010B A_TS837Q1_2010B {get; set;}
    [XmlElement("G_TS837Q1_2300",Order=4)]
    public List<G_TS837Q1_2300> G_TS837Q1_2300 {get; set;}
    [XmlElement("G_TS837Q1_2000C",Order=5)]
    public List<G_TS837Q1_2000C> G_TS837Q1_2000C {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_HL_SubscriberHierarchicalLevel_TS837Q1_2000B {
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
    public class S_SBR_SubscriberInformation_TS837Q1_2000B {
    [XmlElement(Order=0)]
    public S_SBR_SubscriberInformation_TS837Q1_2000BD_SBR01_PayerResponsibilitySequenceNumberCode D_SBR01_PayerResponsibilitySequenceNumberCode {get; set;}
    [XmlElement(Order=1)]
    public S_SBR_SubscriberInformation_TS837Q1_2000BD_SBR02_IndividualRelationshipCode D_SBR02_IndividualRelationshipCode {get; set;}
    [XmlIgnore]
    [XmlElementAttribute(Order=2)]
    public bool D_SBR02_IndividualRelationshipCodeSpecified {get; set;}
    [XmlElement(Order=2)]
    public string D_SBR03_InsuredGroupOrPolicyNumber {get; set;}
    [XmlElement(Order=3)]
    public string D_SBR04_InsuredGroupName {get; set;}
    [XmlElement(Order=4)]
    public string D_SBR05_InsuranceTypeCode {get; set;}
    [XmlElement(Order=5)]
    public string D_SBR06 {get; set;}
    [XmlElement(Order=6)]
    public string D_SBR07 {get; set;}
    [XmlElement(Order=7)]
    public string D_SBR08 {get; set;}
    [XmlElement(Order=8)]
    public string D_SBR09_ClaimFilingIndicatorCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_SBR_SubscriberInformation_TS837Q1_2000BD_SBR01_PayerResponsibilitySequenceNumberCode {
        P,
        S,
        T,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_SBR_SubscriberInformation_TS837Q1_2000BD_SBR02_IndividualRelationshipCode {
        [XmlEnum("18")]
        Item18,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_PAT_PatientInformation_TS837Q1_2000B {
    [XmlElement(Order=0)]
    public string D_PAT01 {get; set;}
    [XmlElement(Order=1)]
    public string D_PAT02 {get; set;}
    [XmlElement(Order=2)]
    public string D_PAT03 {get; set;}
    [XmlElement(Order=3)]
    public string D_PAT04 {get; set;}
    [XmlElement(Order=4)]
    public string D_PAT05_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_PAT06_InsuredIndividualDeathDate {get; set;}
    [XmlElement(Order=6)]
    public string D_PAT07_UnitOrBasisForMeasurementCode {get; set;}
    [XmlElement(Order=7)]
    public string D_PAT08_PatientWeight {get; set;}
    [XmlElement(Order=8)]
    public string D_PAT09_PregnancyIndicator {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class A_TS837Q1_2010B {
    [XmlElementAttribute(Order=0)]
    public G_TS837Q1_2010BA G_TS837Q1_2010BA {get; set;}
    [XmlElementAttribute(Order=1)]
    public G_TS837Q1_2010BB G_TS837Q1_2010BB {get; set;}
    [XmlElementAttribute(Order=2)]
    public G_TS837Q1_2010BC G_TS837Q1_2010BC {get; set;}
    [XmlElementAttribute(Order=3)]
    public G_TS837Q1_2010BD G_TS837Q1_2010BD {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_TS837Q1_2010BA {
    [XmlElement(Order=0)]
    public S_NM1_SubscriberName_TS837Q1_2010BA S_NM1_SubscriberName_TS837Q1_2010BA {get; set;}
    [XmlElement(Order=1)]
    public S_N3_SubscriberAddress_TS837Q1_2010BA S_N3_SubscriberAddress_TS837Q1_2010BA {get; set;}
    [XmlElement(Order=2)]
    public S_N4_SubscriberCityStateZIPCode_TS837Q1_2010BA S_N4_SubscriberCityStateZIPCode_TS837Q1_2010BA {get; set;}
    [XmlElement(Order=3)]
    public S_DMG_SubscriberDemographicInformation_TS837Q1_2010BA S_DMG_SubscriberDemographicInformation_TS837Q1_2010BA {get; set;}
    [XmlElement(Order=4)]
    public A_REF_TS837Q1_2010BA A_REF_TS837Q1_2010BA {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_NM1_SubscriberName_TS837Q1_2010BA {
    [XmlElement(Order=0)]
    public S_NM1_SubscriberName_TS837Q1_2010BAD_NM101_EntityIdentifierCode D_NM101_EntityIdentifierCode {get; set;}
    [XmlElement(Order=1)]
    public S_NM1_SubscriberName_TS837Q1_2010BAD_NM102_EntityTypeQualifier D_NM102_EntityTypeQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_NM103_SubscriberLastName {get; set;}
    [XmlElement(Order=3)]
    public string D_NM104_SubscriberFirstName {get; set;}
    [XmlElement(Order=4)]
    public string D_NM105_SubscriberMiddleName {get; set;}
    [XmlElement(Order=5)]
    public string D_NM106 {get; set;}
    [XmlElement(Order=6)]
    public string D_NM107_SubscriberNameSuffix {get; set;}
    [XmlElement(Order=7)]
    public string D_NM108_IdentificationCodeQualifier {get; set;}
    [XmlElement(Order=8)]
    public string D_NM109_SubscriberPrimaryIdentifier {get; set;}
    [XmlElement(Order=9)]
    public string D_NM110 {get; set;}
    [XmlElement(Order=10)]
    public string D_NM111 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_NM1_SubscriberName_TS837Q1_2010BAD_NM101_EntityIdentifierCode {
        IL,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_NM1_SubscriberName_TS837Q1_2010BAD_NM102_EntityTypeQualifier {
        [XmlEnum("1")]
        Item1,
        [XmlEnum("2")]
        Item2,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_N3_SubscriberAddress_TS837Q1_2010BA {
    [XmlElement(Order=0)]
    public string D_N301_SubscriberAddressLine {get; set;}
    [XmlElement(Order=1)]
    public string D_N302_SubscriberAddressLine {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_N4_SubscriberCityStateZIPCode_TS837Q1_2010BA {
    [XmlElement(Order=0)]
    public string D_N401_SubscriberCityName {get; set;}
    [XmlElement(Order=1)]
    public string D_N402_SubscriberStateCode {get; set;}
    [XmlElement(Order=2)]
    public string D_N403_SubscriberPostalZoneOrZIPCode {get; set;}
    [XmlElement(Order=3)]
    public string D_N404_CountryCode {get; set;}
    [XmlElement(Order=4)]
    public string D_N405 {get; set;}
    [XmlElement(Order=5)]
    public string D_N406 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_DMG_SubscriberDemographicInformation_TS837Q1_2010BA {
    [XmlElement(Order=0)]
    public S_DMG_SubscriberDemographicInformation_TS837Q1_2010BAD_DMG01_DateTimePeriodFormatQualifier D_DMG01_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_DMG02_SubscriberBirthDate {get; set;}
    [XmlElement(Order=2)]
    public string D_DMG03_SubscriberGenderCode {get; set;}
    [XmlElement(Order=3)]
    public string D_DMG04 {get; set;}
    [XmlElement(Order=4)]
    public string D_DMG05 {get; set;}
    [XmlElement(Order=5)]
    public string D_DMG06 {get; set;}
    [XmlElement(Order=6)]
    public string D_DMG07 {get; set;}
    [XmlElement(Order=7)]
    public string D_DMG08 {get; set;}
    [XmlElement(Order=8)]
    public string D_DMG09 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_DMG_SubscriberDemographicInformation_TS837Q1_2010BAD_DMG01_DateTimePeriodFormatQualifier {
        D8,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class A_REF_TS837Q1_2010BA {
    [XmlElement(Order=0)]
    public U_REF_SubscriberSecondaryIdentification_TS837Q1_2010BA U_REF_SubscriberSecondaryIdentification_TS837Q1_2010BA {get; set;}
    [XmlElementAttribute(Order=1)]
    public S_REF_PropertyAndCasualtyClaimNumber_TS837Q1_2010BA S_REF_PropertyAndCasualtyClaimNumber_TS837Q1_2010BA {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_SubscriberSecondaryIdentification_TS837Q1_2010BA {
    [XmlElement(Order=0)]
    public S_REF_SubscriberSecondaryIdentification_TS837Q1_2010BAD_REF01_ReferenceIdentificationQualifier D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_SubscriberSupplementalIdentifier {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03 {get; set;}
    [XmlElement(Order=3)]
    public string D_REF04_C040U831 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_REF_SubscriberSecondaryIdentification_TS837Q1_2010BAD_REF01_ReferenceIdentificationQualifier {
        [XmlEnum("1W")]
        Item1W,
        [XmlEnum("23")]
        Item23,
        IG,
        SY,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_PropertyAndCasualtyClaimNumber_TS837Q1_2010BA {
    [XmlElement(Order=0)]
    public S_REF_PropertyAndCasualtyClaimNumber_TS837Q1_2010BAD_REF01_ReferenceIdentificationQualifier D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_PropertyCasualtyClaimNumber {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03 {get; set;}
    [XmlElement(Order=3)]
    public string D_REF04_C040U832 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_REF_PropertyAndCasualtyClaimNumber_TS837Q1_2010BAD_REF01_ReferenceIdentificationQualifier {
        Y4,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_TS837Q1_2010BB {
    [XmlElement(Order=0)]
    public S_NM1_PayerName_TS837Q1_2010BB S_NM1_PayerName_TS837Q1_2010BB {get; set;}
    [XmlElement(Order=1)]
    public S_N3_PayerAddress_TS837Q1_2010BB S_N3_PayerAddress_TS837Q1_2010BB {get; set;}
    [XmlElement(Order=2)]
    public S_N4_PayerCityStateZIPCode_TS837Q1_2010BB S_N4_PayerCityStateZIPCode_TS837Q1_2010BB {get; set;}
    [XmlElement("S_REF_PayerSecondaryIdentification_TS837Q1_2010BB",Order=3)]
    public List<S_REF_PayerSecondaryIdentification_TS837Q1_2010BB> S_REF_PayerSecondaryIdentification_TS837Q1_2010BB {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_NM1_PayerName_TS837Q1_2010BB {
    [XmlElement(Order=0)]
    public S_NM1_PayerName_TS837Q1_2010BBD_NM101_EntityIdentifierCode D_NM101_EntityIdentifierCode {get; set;}
    [XmlElement(Order=1)]
    public S_NM1_PayerName_TS837Q1_2010BBD_NM102_EntityTypeQualifier D_NM102_EntityTypeQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_NM103_PayerName {get; set;}
    [XmlElement(Order=3)]
    public string D_NM104 {get; set;}
    [XmlElement(Order=4)]
    public string D_NM105 {get; set;}
    [XmlElement(Order=5)]
    public string D_NM106 {get; set;}
    [XmlElement(Order=6)]
    public string D_NM107 {get; set;}
    [XmlElement(Order=7)]
    public string D_NM108_IdentificationCodeQualifier {get; set;}
    [XmlElement(Order=8)]
    public string D_NM109_PayerIdentifier {get; set;}
    [XmlElement(Order=9)]
    public string D_NM110 {get; set;}
    [XmlElement(Order=10)]
    public string D_NM111 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_NM1_PayerName_TS837Q1_2010BBD_NM101_EntityIdentifierCode {
        PR,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_NM1_PayerName_TS837Q1_2010BBD_NM102_EntityTypeQualifier {
        [XmlEnum("2")]
        Item2,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_N3_PayerAddress_TS837Q1_2010BB {
    [XmlElement(Order=0)]
    public string D_N301_PayerAddressLine {get; set;}
    [XmlElement(Order=1)]
    public string D_N302_PayerAddressLine {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_N4_PayerCityStateZIPCode_TS837Q1_2010BB {
    [XmlElement(Order=0)]
    public string D_N401_PayerCityName {get; set;}
    [XmlElement(Order=1)]
    public string D_N402_PayerStateCode {get; set;}
    [XmlElement(Order=2)]
    public string D_N403_PayerPostalZoneOrZIPCode {get; set;}
    [XmlElement(Order=3)]
    public string D_N404_CountryCode {get; set;}
    [XmlElement(Order=4)]
    public string D_N405 {get; set;}
    [XmlElement(Order=5)]
    public string D_N406 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_PayerSecondaryIdentification_TS837Q1_2010BB {
    [XmlElement(Order=0)]
    public S_REF_PayerSecondaryIdentification_TS837Q1_2010BBD_REF01_ReferenceIdentificationQualifier D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_PayerAdditionalIdentifier {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03 {get; set;}
    [XmlElement(Order=3)]
    public string D_REF04_C040U833 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_REF_PayerSecondaryIdentification_TS837Q1_2010BBD_REF01_ReferenceIdentificationQualifier {
        [XmlEnum("2U")]
        Item2U,
        FY,
        NF,
        TJ,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_TS837Q1_2010BC {
    [XmlElement(Order=0)]
    public S_NM1_ResponsiblePartyName_TS837Q1_2010BC S_NM1_ResponsiblePartyName_TS837Q1_2010BC {get; set;}
    [XmlElement(Order=1)]
    public S_N3_ResponsiblePartyAddress_TS837Q1_2010BC S_N3_ResponsiblePartyAddress_TS837Q1_2010BC {get; set;}
    [XmlElement(Order=2)]
    public S_N4_ResponsiblePartyCityStateZIPCode_TS837Q1_2010BC S_N4_ResponsiblePartyCityStateZIPCode_TS837Q1_2010BC {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_NM1_ResponsiblePartyName_TS837Q1_2010BC {
    [XmlElement(Order=0)]
    public S_NM1_ResponsiblePartyName_TS837Q1_2010BCD_NM101_EntityIdentifierCode D_NM101_EntityIdentifierCode {get; set;}
    [XmlElement(Order=1)]
    public S_NM1_ResponsiblePartyName_TS837Q1_2010BCD_NM102_EntityTypeQualifier D_NM102_EntityTypeQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_NM103_ResponsiblePartyLastOrOrganizationName {get; set;}
    [XmlElement(Order=3)]
    public string D_NM104_ResponsiblePartyFirstName {get; set;}
    [XmlElement(Order=4)]
    public string D_NM105_ResponsiblePartyMiddleName {get; set;}
    [XmlElement(Order=5)]
    public string D_NM106 {get; set;}
    [XmlElement(Order=6)]
    public string D_NM107_ResponsiblePartySuffixName {get; set;}
    [XmlElement(Order=7)]
    public string D_NM108 {get; set;}
    [XmlElement(Order=8)]
    public string D_NM109 {get; set;}
    [XmlElement(Order=9)]
    public string D_NM110 {get; set;}
    [XmlElement(Order=10)]
    public string D_NM111 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_NM1_ResponsiblePartyName_TS837Q1_2010BCD_NM101_EntityIdentifierCode {
        QD,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_NM1_ResponsiblePartyName_TS837Q1_2010BCD_NM102_EntityTypeQualifier {
        [XmlEnum("1")]
        Item1,
        [XmlEnum("2")]
        Item2,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_N3_ResponsiblePartyAddress_TS837Q1_2010BC {
    [XmlElement(Order=0)]
    public string D_N301_ResponsiblePartyAddressLine {get; set;}
    [XmlElement(Order=1)]
    public string D_N302_ResponsiblePartyAddressLine {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_N4_ResponsiblePartyCityStateZIPCode_TS837Q1_2010BC {
    [XmlElement(Order=0)]
    public string D_N401_ResponsiblePartyCityName {get; set;}
    [XmlElement(Order=1)]
    public string D_N402_ResponsiblePartyStateCode {get; set;}
    [XmlElement(Order=2)]
    public string D_N403_ResponsiblePartyPostalZoneOrZIPCode {get; set;}
    [XmlElement(Order=3)]
    public string D_N404_CountryCode {get; set;}
    [XmlElement(Order=4)]
    public string D_N405 {get; set;}
    [XmlElement(Order=5)]
    public string D_N406 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_TS837Q1_2010BD {
    [XmlElement(Order=0)]
    public S_NM1_CreditDebitCardHolderName_TS837Q1_2010BD S_NM1_CreditDebitCardHolderName_TS837Q1_2010BD {get; set;}
    [XmlElement("S_REF_CreditDebitCardInformation_TS837Q1_2010BD",Order=1)]
    public List<S_REF_CreditDebitCardInformation_TS837Q1_2010BD> S_REF_CreditDebitCardInformation_TS837Q1_2010BD {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_NM1_CreditDebitCardHolderName_TS837Q1_2010BD {
    [XmlElement(Order=0)]
    public S_NM1_CreditDebitCardHolderName_TS837Q1_2010BDD_NM101_EntityIdentifierCode D_NM101_EntityIdentifierCode {get; set;}
    [XmlElement(Order=1)]
    public S_NM1_CreditDebitCardHolderName_TS837Q1_2010BDD_NM102_EntityTypeQualifier D_NM102_EntityTypeQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_NM103_CreditOrDebitCardHolderLastOrOrganizationalName {get; set;}
    [XmlElement(Order=3)]
    public string D_NM104_CreditOrDebitCardHolderFirstName {get; set;}
    [XmlElement(Order=4)]
    public string D_NM105_CreditOrDebitCardHolderMiddleName {get; set;}
    [XmlElement(Order=5)]
    public string D_NM106 {get; set;}
    [XmlElement(Order=6)]
    public string D_NM107_CreditOrDebitCardHolderNameSuffix {get; set;}
    [XmlElement(Order=7)]
    public string D_NM108_IdentificationCodeQualifier {get; set;}
    [XmlElement(Order=8)]
    public string D_NM109_CreditOrDebitCardNumber {get; set;}
    [XmlElement(Order=9)]
    public string D_NM110 {get; set;}
    [XmlElement(Order=10)]
    public string D_NM111 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_NM1_CreditDebitCardHolderName_TS837Q1_2010BDD_NM101_EntityIdentifierCode {
        AO,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_NM1_CreditDebitCardHolderName_TS837Q1_2010BDD_NM102_EntityTypeQualifier {
        [XmlEnum("1")]
        Item1,
        [XmlEnum("2")]
        Item2,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_CreditDebitCardInformation_TS837Q1_2010BD {
    [XmlElement(Order=0)]
    public S_REF_CreditDebitCardInformation_TS837Q1_2010BDD_REF01_ReferenceIdentificationQualifier D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_CreditOrDebitCardAuthorizationNumber {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03 {get; set;}
    [XmlElement(Order=3)]
    public string D_REF04_C040U834 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_REF_CreditDebitCardInformation_TS837Q1_2010BDD_REF01_ReferenceIdentificationQualifier {
        AB,
        BB,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_TS837Q1_2300 {
    [XmlElement(Order=0)]
    public S_CLM_ClaimInformation_TS837Q1_2300 S_CLM_ClaimInformation_TS837Q1_2300 {get; set;}
    [XmlElement(Order=1)]
    public A_DTP_TS837Q1_2300 A_DTP_TS837Q1_2300 {get; set;}
    [XmlElement("S_PWK_ClaimSupplementalInformation_TS837Q1_2300",Order=2)]
    public List<S_PWK_ClaimSupplementalInformation_TS837Q1_2300> S_PWK_ClaimSupplementalInformation_TS837Q1_2300 {get; set;}
    [XmlElement(Order=3)]
    public S_CN1_ContractInformation_TS837Q1_2300 S_CN1_ContractInformation_TS837Q1_2300 {get; set;}
    [XmlElement(Order=4)]
    public A_AMT_TS837Q1_2300 A_AMT_TS837Q1_2300 {get; set;}
    [XmlElement(Order=5)]
    public A_REF_TS837Q1_2300 A_REF_TS837Q1_2300 {get; set;}
    [XmlElement("S_K3_FileInformation_TS837Q1_2300",Order=6)]
    public List<S_K3_FileInformation_TS837Q1_2300> S_K3_FileInformation_TS837Q1_2300 {get; set;}
    [XmlElement(Order=7)]
    public S_NTE_ClaimNote_TS837Q1_2300 S_NTE_ClaimNote_TS837Q1_2300 {get; set;}
    [XmlElement(Order=8)]
    public S_CR1_AmbulanceTransportInformation_TS837Q1_2300 S_CR1_AmbulanceTransportInformation_TS837Q1_2300 {get; set;}
    [XmlElement(Order=9)]
    public S_CR2_SpinalManipulationServiceInformation_TS837Q1_2300 S_CR2_SpinalManipulationServiceInformation_TS837Q1_2300 {get; set;}
    [XmlElement(Order=10)]
    public A_CRC_TS837Q1_2300 A_CRC_TS837Q1_2300 {get; set;}
    [XmlElement(Order=11)]
    public S_HI_HealthCareDiagnosisCode_TS837Q1_2300 S_HI_HealthCareDiagnosisCode_TS837Q1_2300 {get; set;}
    [XmlElement(Order=12)]
    public S_HCP_ClaimPricingRepricingInformation_TS837Q1_2300 S_HCP_ClaimPricingRepricingInformation_TS837Q1_2300 {get; set;}
    [XmlElement("G_TS837Q1_2305",Order=13)]
    public List<G_TS837Q1_2305> G_TS837Q1_2305 {get; set;}
    [XmlElement(Order=14)]
    public A_TS837Q1_2310 A_TS837Q1_2310 {get; set;}
    [XmlElement("G_TS837Q1_2320",Order=15)]
    public List<G_TS837Q1_2320> G_TS837Q1_2320 {get; set;}
    [XmlElement("G_TS837Q1_2400",Order=16)]
    public List<G_TS837Q1_2400> G_TS837Q1_2400 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_CLM_ClaimInformation_TS837Q1_2300 {
    [XmlElement(Order=0)]
    public string D_CLM01_PatientAccountNumber {get; set;}
    [XmlElement(Order=1)]
    public string D_CLM02_TotalClaimChargeAmount {get; set;}
    [XmlElement(Order=2)]
    public string D_CLM03 {get; set;}
    [XmlElement(Order=3)]
    public string D_CLM04 {get; set;}
    [XmlElement(Order=4)]
    public C_CLM05_C023U837_TS837Q1_2300 C_CLM05_C023U837_TS837Q1_2300 {get; set;}
    [XmlElement(Order=5)]
    public string D_CLM06_ProviderOrSupplierSignatureIndicator {get; set;}
    [XmlElement(Order=6)]
    public string D_CLM07_MedicareAssignmentCode {get; set;}
    [XmlElement(Order=7)]
    public string D_CLM08_BenefitsAssignmentCertificationIndicator {get; set;}
    [XmlElement(Order=8)]
    public string D_CLM09_ReleaseOfInformationCode {get; set;}
    [XmlElement(Order=9)]
    public string D_CLM10_PatientSignatureSourceCode {get; set;}
    [XmlElement(Order=10)]
    public C_CLM11_C024U841_TS837Q1_2300 C_CLM11_C024U841_TS837Q1_2300 {get; set;}
    [XmlElement(Order=11)]
    public string D_CLM12_SpecialProgramIndicator {get; set;}
    [XmlElement(Order=12)]
    public string D_CLM13 {get; set;}
    [XmlElement(Order=13)]
    public string D_CLM14 {get; set;}
    [XmlElement(Order=14)]
    public string D_CLM15 {get; set;}
    [XmlElement(Order=15)]
    public string D_CLM16_ParticipationAgreement {get; set;}
    [XmlElement(Order=16)]
    public string D_CLM17 {get; set;}
    [XmlElement(Order=17)]
    public string D_CLM18 {get; set;}
    [XmlElement(Order=18)]
    public string D_CLM19 {get; set;}
    [XmlElement(Order=19)]
    public string D_CLM20_DelayReasonCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_CLM05_C023U837_TS837Q1_2300 {
    [XmlElement(Order=0)]
    public string D_CLM05_C02301U838_FacilityTypeCode {get; set;}
    [XmlElement(Order=1)]
    public string D_CLM05_C02302U5846 {get; set;}
    [XmlElement(Order=2)]
    public string D_CLM05_C02303U840_ClaimFrequencyCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_CLM11_C024U841_TS837Q1_2300 {
    [XmlElement(Order=0)]
    public string D_CLM11_C02401U842_RelatedCausesCode {get; set;}
    [XmlElement(Order=1)]
    public string D_CLM11_C02402U843_RelatedCausesCode {get; set;}
    [XmlElement(Order=2)]
    public string D_CLM11_C02403U844_RelatedCausesCode {get; set;}
    [XmlElement(Order=3)]
    public string D_CLM11_C02404U845_AutoAccidentStateOrProvinceCode {get; set;}
    [XmlElement(Order=4)]
    public string D_CLM11_C02405U846_CountryCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class A_DTP_TS837Q1_2300 {
    [XmlElementAttribute(Order=0)]
    public S_DTP_DateInitialTreatment_TS837Q1_2300 S_DTP_DateInitialTreatment_TS837Q1_2300 {get; set;}
    [XmlElementAttribute(Order=1)]
    public S_DTP_DateDateLastSeen_TS837Q1_2300 S_DTP_DateDateLastSeen_TS837Q1_2300 {get; set;}
    [XmlElementAttribute(Order=2)]
    public S_DTP_DateOnsetOfCurrentIllnessSymptom_TS837Q1_2300 S_DTP_DateOnsetOfCurrentIllnessSymptom_TS837Q1_2300 {get; set;}
    [XmlElement(Order=3)]
    public U_DTP_DateAcuteManifestation_TS837Q1_2300 U_DTP_DateAcuteManifestation_TS837Q1_2300 {get; set;}
    [XmlElement(Order=4)]
    public U_DTP_DateSimilarIllnessSymptomOnset_TS837Q1_2300 U_DTP_DateSimilarIllnessSymptomOnset_TS837Q1_2300 {get; set;}
    [XmlElement(Order=5)]
    public U_DTP_DateAccident_TS837Q1_2300 U_DTP_DateAccident_TS837Q1_2300 {get; set;}
    [XmlElementAttribute(Order=6)]
    public S_DTP_DateLastMenstrualPeriod_TS837Q1_2300 S_DTP_DateLastMenstrualPeriod_TS837Q1_2300 {get; set;}
    [XmlElementAttribute(Order=7)]
    public S_DTP_DateLastXray_TS837Q1_2300 S_DTP_DateLastXray_TS837Q1_2300 {get; set;}
    [XmlElementAttribute(Order=8)]
    public S_DTP_DateHearingAndVisionPrescriptionDate_TS837Q1_2300 S_DTP_DateHearingAndVisionPrescriptionDate_TS837Q1_2300 {get; set;}
    [XmlElement(Order=9)]
    public U_DTP_DateDisabilityBegin_TS837Q1_2300 U_DTP_DateDisabilityBegin_TS837Q1_2300 {get; set;}
    [XmlElement(Order=10)]
    public U_DTP_DateDisabilityEnd_TS837Q1_2300 U_DTP_DateDisabilityEnd_TS837Q1_2300 {get; set;}
    [XmlElementAttribute(Order=11)]
    public S_DTP_DateLastWorked_TS837Q1_2300 S_DTP_DateLastWorked_TS837Q1_2300 {get; set;}
    [XmlElementAttribute(Order=12)]
    public S_DTP_DateAuthorizedReturnToWork_TS837Q1_2300 S_DTP_DateAuthorizedReturnToWork_TS837Q1_2300 {get; set;}
    [XmlElementAttribute(Order=13)]
    public S_DTP_DateAdmission_TS837Q1_2300 S_DTP_DateAdmission_TS837Q1_2300 {get; set;}
    [XmlElementAttribute(Order=14)]
    public S_DTP_DateDischarge_TS837Q1_2300 S_DTP_DateDischarge_TS837Q1_2300 {get; set;}
    [XmlElement(Order=15)]
    public U_DTP_DateAssumedAndRelinquishedCareDates_TS837Q1_2300 U_DTP_DateAssumedAndRelinquishedCareDates_TS837Q1_2300 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_DTP_DateInitialTreatment_TS837Q1_2300 {
    [XmlElement(Order=0)]
    public S_DTP_DateInitialTreatment_TS837Q1_2300D_DTP01_DateTimeQualifier D_DTP01_DateTimeQualifier {get; set;}
    [XmlElement(Order=1)]
    public S_DTP_DateInitialTreatment_TS837Q1_2300D_DTP02_DateTimePeriodFormatQualifier D_DTP02_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_DTP03_InitialTreatmentDate {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_DTP_DateInitialTreatment_TS837Q1_2300D_DTP01_DateTimeQualifier {
        [XmlEnum("454")]
        Item454,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_DTP_DateInitialTreatment_TS837Q1_2300D_DTP02_DateTimePeriodFormatQualifier {
        D8,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_DTP_DateDateLastSeen_TS837Q1_2300 {
    [XmlElement(Order=0)]
    public S_DTP_DateDateLastSeen_TS837Q1_2300D_DTP01_DateTimeQualifier D_DTP01_DateTimeQualifier {get; set;}
    [XmlElement(Order=1)]
    public S_DTP_DateDateLastSeen_TS837Q1_2300D_DTP02_DateTimePeriodFormatQualifier D_DTP02_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_DTP03_LastSeenDate {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_DTP_DateDateLastSeen_TS837Q1_2300D_DTP01_DateTimeQualifier {
        [XmlEnum("304")]
        Item304,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_DTP_DateDateLastSeen_TS837Q1_2300D_DTP02_DateTimePeriodFormatQualifier {
        D8,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_DTP_DateOnsetOfCurrentIllnessSymptom_TS837Q1_2300 {
    [XmlElement(Order=0)]
    public S_DTP_DateOnsetOfCurrentIllnessSymptom_TS837Q1_2300D_DTP01_DateTimeQualifier D_DTP01_DateTimeQualifier {get; set;}
    [XmlElement(Order=1)]
    public S_DTP_DateOnsetOfCurrentIllnessSymptom_TS837Q1_2300D_DTP02_DateTimePeriodFormatQualifier D_DTP02_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_DTP03_OnsetOfCurrentIllnessOrInjuryDate {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_DTP_DateOnsetOfCurrentIllnessSymptom_TS837Q1_2300D_DTP01_DateTimeQualifier {
        [XmlEnum("431")]
        Item431,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_DTP_DateOnsetOfCurrentIllnessSymptom_TS837Q1_2300D_DTP02_DateTimePeriodFormatQualifier {
        D8,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_DTP_DateAcuteManifestation_TS837Q1_2300 {
    [XmlElement(Order=0)]
    public S_DTP_DateAcuteManifestation_TS837Q1_2300D_DTP01_DateTimeQualifier D_DTP01_DateTimeQualifier {get; set;}
    [XmlElement(Order=1)]
    public S_DTP_DateAcuteManifestation_TS837Q1_2300D_DTP02_DateTimePeriodFormatQualifier D_DTP02_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_DTP03_AcuteManifestationDate {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_DTP_DateAcuteManifestation_TS837Q1_2300D_DTP01_DateTimeQualifier {
        [XmlEnum("453")]
        Item453,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_DTP_DateAcuteManifestation_TS837Q1_2300D_DTP02_DateTimePeriodFormatQualifier {
        D8,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_DTP_DateSimilarIllnessSymptomOnset_TS837Q1_2300 {
    [XmlElement(Order=0)]
    public S_DTP_DateSimilarIllnessSymptomOnset_TS837Q1_2300D_DTP01_DateTimeQualifier D_DTP01_DateTimeQualifier {get; set;}
    [XmlElement(Order=1)]
    public S_DTP_DateSimilarIllnessSymptomOnset_TS837Q1_2300D_DTP02_DateTimePeriodFormatQualifier D_DTP02_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_DTP03_SimilarIllnessOrSymptomDate {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_DTP_DateSimilarIllnessSymptomOnset_TS837Q1_2300D_DTP01_DateTimeQualifier {
        [XmlEnum("438")]
        Item438,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_DTP_DateSimilarIllnessSymptomOnset_TS837Q1_2300D_DTP02_DateTimePeriodFormatQualifier {
        D8,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_DTP_DateAccident_TS837Q1_2300 {
    [XmlElement(Order=0)]
    public S_DTP_DateAccident_TS837Q1_2300D_DTP01_DateTimeQualifier D_DTP01_DateTimeQualifier {get; set;}
    [XmlElement(Order=1)]
    public S_DTP_DateAccident_TS837Q1_2300D_DTP02_DateTimePeriodFormatQualifier D_DTP02_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_DTP03_AccidentDate {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_DTP_DateAccident_TS837Q1_2300D_DTP01_DateTimeQualifier {
        [XmlEnum("439")]
        Item439,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_DTP_DateAccident_TS837Q1_2300D_DTP02_DateTimePeriodFormatQualifier {
        D8,
        DT,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_DTP_DateLastMenstrualPeriod_TS837Q1_2300 {
    [XmlElement(Order=0)]
    public S_DTP_DateLastMenstrualPeriod_TS837Q1_2300D_DTP01_DateTimeQualifier D_DTP01_DateTimeQualifier {get; set;}
    [XmlElement(Order=1)]
    public S_DTP_DateLastMenstrualPeriod_TS837Q1_2300D_DTP02_DateTimePeriodFormatQualifier D_DTP02_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_DTP03_LastMenstrualPeriodDate {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_DTP_DateLastMenstrualPeriod_TS837Q1_2300D_DTP01_DateTimeQualifier {
        [XmlEnum("484")]
        Item484,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_DTP_DateLastMenstrualPeriod_TS837Q1_2300D_DTP02_DateTimePeriodFormatQualifier {
        D8,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_DTP_DateLastXray_TS837Q1_2300 {
    [XmlElement(Order=0)]
    public S_DTP_DateLastXray_TS837Q1_2300D_DTP01_DateTimeQualifier D_DTP01_DateTimeQualifier {get; set;}
    [XmlElement(Order=1)]
    public S_DTP_DateLastXray_TS837Q1_2300D_DTP02_DateTimePeriodFormatQualifier D_DTP02_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_DTP03_LastXRayDate {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_DTP_DateLastXray_TS837Q1_2300D_DTP01_DateTimeQualifier {
        [XmlEnum("455")]
        Item455,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_DTP_DateLastXray_TS837Q1_2300D_DTP02_DateTimePeriodFormatQualifier {
        D8,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_DTP_DateHearingAndVisionPrescriptionDate_TS837Q1_2300 {
    [XmlElement(Order=0)]
    public S_DTP_DateHearingAndVisionPrescriptionDate_TS837Q1_2300D_DTP01_DateTimeQualifier D_DTP01_DateTimeQualifier {get; set;}
    [XmlElement(Order=1)]
    public S_DTP_DateHearingAndVisionPrescriptionDate_TS837Q1_2300D_DTP02_DateTimePeriodFormatQualifier D_DTP02_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_DTP03_PrescriptionDate {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_DTP_DateHearingAndVisionPrescriptionDate_TS837Q1_2300D_DTP01_DateTimeQualifier {
        [XmlEnum("471")]
        Item471,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_DTP_DateHearingAndVisionPrescriptionDate_TS837Q1_2300D_DTP02_DateTimePeriodFormatQualifier {
        D8,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_DTP_DateDisabilityBegin_TS837Q1_2300 {
    [XmlElement(Order=0)]
    public S_DTP_DateDisabilityBegin_TS837Q1_2300D_DTP01_DateTimeQualifier D_DTP01_DateTimeQualifier {get; set;}
    [XmlElement(Order=1)]
    public S_DTP_DateDisabilityBegin_TS837Q1_2300D_DTP02_DateTimePeriodFormatQualifier D_DTP02_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_DTP03_DisabilityFromDate {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_DTP_DateDisabilityBegin_TS837Q1_2300D_DTP01_DateTimeQualifier {
        [XmlEnum("360")]
        Item360,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_DTP_DateDisabilityBegin_TS837Q1_2300D_DTP02_DateTimePeriodFormatQualifier {
        D8,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_DTP_DateDisabilityEnd_TS837Q1_2300 {
    [XmlElement(Order=0)]
    public S_DTP_DateDisabilityEnd_TS837Q1_2300D_DTP01_DateTimeQualifier D_DTP01_DateTimeQualifier {get; set;}
    [XmlElement(Order=1)]
    public S_DTP_DateDisabilityEnd_TS837Q1_2300D_DTP02_DateTimePeriodFormatQualifier D_DTP02_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_DTP03_DisabilityToDate {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_DTP_DateDisabilityEnd_TS837Q1_2300D_DTP01_DateTimeQualifier {
        [XmlEnum("361")]
        Item361,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_DTP_DateDisabilityEnd_TS837Q1_2300D_DTP02_DateTimePeriodFormatQualifier {
        D8,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_DTP_DateLastWorked_TS837Q1_2300 {
    [XmlElement(Order=0)]
    public S_DTP_DateLastWorked_TS837Q1_2300D_DTP01_DateTimeQualifier D_DTP01_DateTimeQualifier {get; set;}
    [XmlElement(Order=1)]
    public S_DTP_DateLastWorked_TS837Q1_2300D_DTP02_DateTimePeriodFormatQualifier D_DTP02_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_DTP03_LastWorkedDate {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_DTP_DateLastWorked_TS837Q1_2300D_DTP01_DateTimeQualifier {
        [XmlEnum("297")]
        Item297,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_DTP_DateLastWorked_TS837Q1_2300D_DTP02_DateTimePeriodFormatQualifier {
        D8,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_DTP_DateAuthorizedReturnToWork_TS837Q1_2300 {
    [XmlElement(Order=0)]
    public S_DTP_DateAuthorizedReturnToWork_TS837Q1_2300D_DTP01_DateTimeQualifier D_DTP01_DateTimeQualifier {get; set;}
    [XmlElement(Order=1)]
    public S_DTP_DateAuthorizedReturnToWork_TS837Q1_2300D_DTP02_DateTimePeriodFormatQualifier D_DTP02_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_DTP03_WorkReturnDate {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_DTP_DateAuthorizedReturnToWork_TS837Q1_2300D_DTP01_DateTimeQualifier {
        [XmlEnum("296")]
        Item296,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_DTP_DateAuthorizedReturnToWork_TS837Q1_2300D_DTP02_DateTimePeriodFormatQualifier {
        D8,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_DTP_DateAdmission_TS837Q1_2300 {
    [XmlElement(Order=0)]
    public S_DTP_DateAdmission_TS837Q1_2300D_DTP01_DateTimeQualifier D_DTP01_DateTimeQualifier {get; set;}
    [XmlElement(Order=1)]
    public S_DTP_DateAdmission_TS837Q1_2300D_DTP02_DateTimePeriodFormatQualifier D_DTP02_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_DTP03_RelatedHospitalizationAdmissionDate {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_DTP_DateAdmission_TS837Q1_2300D_DTP01_DateTimeQualifier {
        [XmlEnum("435")]
        Item435,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_DTP_DateAdmission_TS837Q1_2300D_DTP02_DateTimePeriodFormatQualifier {
        D8,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_DTP_DateDischarge_TS837Q1_2300 {
    [XmlElement(Order=0)]
    public S_DTP_DateDischarge_TS837Q1_2300D_DTP01_DateTimeQualifier D_DTP01_DateTimeQualifier {get; set;}
    [XmlElement(Order=1)]
    public S_DTP_DateDischarge_TS837Q1_2300D_DTP02_DateTimePeriodFormatQualifier D_DTP02_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_DTP03_RelatedHospitalizationDischargeDate {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_DTP_DateDischarge_TS837Q1_2300D_DTP01_DateTimeQualifier {
        [XmlEnum("096")]
        Item096,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_DTP_DateDischarge_TS837Q1_2300D_DTP02_DateTimePeriodFormatQualifier {
        D8,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_DTP_DateAssumedAndRelinquishedCareDates_TS837Q1_2300 {
    [XmlElement(Order=0)]
    public S_DTP_DateAssumedAndRelinquishedCareDates_TS837Q1_2300D_DTP01_DateTimeQualifier D_DTP01_DateTimeQualifier {get; set;}
    [XmlElement(Order=1)]
    public S_DTP_DateAssumedAndRelinquishedCareDates_TS837Q1_2300D_DTP02_DateTimePeriodFormatQualifier D_DTP02_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_DTP03_AssumedOrRelinquishedCareDate {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_DTP_DateAssumedAndRelinquishedCareDates_TS837Q1_2300D_DTP01_DateTimeQualifier {
        [XmlEnum("090")]
        Item090,
        [XmlEnum("091")]
        Item091,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_DTP_DateAssumedAndRelinquishedCareDates_TS837Q1_2300D_DTP02_DateTimePeriodFormatQualifier {
        D8,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_PWK_ClaimSupplementalInformation_TS837Q1_2300 {
    [XmlElement(Order=0)]
    public S_PWK_ClaimSupplementalInformation_TS837Q1_2300D_PWK01_AttachmentReportTypeCode D_PWK01_AttachmentReportTypeCode {get; set;}
    [XmlElement(Order=1)]
    public S_PWK_ClaimSupplementalInformation_TS837Q1_2300D_PWK02_AttachmentTransmissionCode D_PWK02_AttachmentTransmissionCode {get; set;}
    [XmlElement(Order=2)]
    public string D_PWK03 {get; set;}
    [XmlElement(Order=3)]
    public string D_PWK04 {get; set;}
    [XmlElement(Order=4)]
    public string D_PWK05_IdentificationCodeQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_PWK06_AttachmentControlNumber {get; set;}
    [XmlElement(Order=6)]
    public string D_PWK07 {get; set;}
    [XmlElement(Order=7)]
    public string D_PWK08_C002U847 {get; set;}
    [XmlElement(Order=8)]
    public string D_PWK09 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_PWK_ClaimSupplementalInformation_TS837Q1_2300D_PWK01_AttachmentReportTypeCode {
        [XmlEnum("77")]
        Item77,
        AS,
        B2,
        B3,
        B4,
        CT,
        DA,
        DG,
        DS,
        EB,
        MT,
        NN,
        OB,
        OZ,
        PN,
        PO,
        PZ,
        RB,
        RR,
        RT,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_PWK_ClaimSupplementalInformation_TS837Q1_2300D_PWK02_AttachmentTransmissionCode {
        AA,
        BM,
        EL,
        EM,
        FX,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_CN1_ContractInformation_TS837Q1_2300 {
    [XmlElement(Order=0)]
    public S_CN1_ContractInformation_TS837Q1_2300D_CN101_ContractTypeCode D_CN101_ContractTypeCode {get; set;}
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
    public enum S_CN1_ContractInformation_TS837Q1_2300D_CN101_ContractTypeCode {
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
    public class A_AMT_TS837Q1_2300 {
    [XmlElementAttribute(Order=0)]
    public S_AMT_CreditDebitCardMaximumAmount_TS837Q1_2300 S_AMT_CreditDebitCardMaximumAmount_TS837Q1_2300 {get; set;}
    [XmlElementAttribute(Order=1)]
    public S_AMT_PatientAmountPaid_TS837Q1_2300 S_AMT_PatientAmountPaid_TS837Q1_2300 {get; set;}
    [XmlElementAttribute(Order=2)]
    public S_AMT_TotalPurchasedServiceAmount_TS837Q1_2300 S_AMT_TotalPurchasedServiceAmount_TS837Q1_2300 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_AMT_CreditDebitCardMaximumAmount_TS837Q1_2300 {
    [XmlElement(Order=0)]
    public S_AMT_CreditDebitCardMaximumAmount_TS837Q1_2300D_AMT01_AmountQualifierCode D_AMT01_AmountQualifierCode {get; set;}
    [XmlElement(Order=1)]
    public string D_AMT02_CreditOrDebitCardMaximumAmount {get; set;}
    [XmlElement(Order=2)]
    public string D_AMT03 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_AMT_CreditDebitCardMaximumAmount_TS837Q1_2300D_AMT01_AmountQualifierCode {
        MA,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_AMT_PatientAmountPaid_TS837Q1_2300 {
    [XmlElement(Order=0)]
    public S_AMT_PatientAmountPaid_TS837Q1_2300D_AMT01_AmountQualifierCode D_AMT01_AmountQualifierCode {get; set;}
    [XmlElement(Order=1)]
    public string D_AMT02_PatientAmountPaid {get; set;}
    [XmlElement(Order=2)]
    public string D_AMT03 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_AMT_PatientAmountPaid_TS837Q1_2300D_AMT01_AmountQualifierCode {
        F5,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_AMT_TotalPurchasedServiceAmount_TS837Q1_2300 {
    [XmlElement(Order=0)]
    public S_AMT_TotalPurchasedServiceAmount_TS837Q1_2300D_AMT01_AmountQualifierCode D_AMT01_AmountQualifierCode {get; set;}
    [XmlElement(Order=1)]
    public string D_AMT02_TotalPurchasedServiceAmount {get; set;}
    [XmlElement(Order=2)]
    public string D_AMT03 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_AMT_TotalPurchasedServiceAmount_TS837Q1_2300D_AMT01_AmountQualifierCode {
        NE,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class A_REF_TS837Q1_2300 {
    [XmlElementAttribute(Order=0)]
    public S_REF_ServiceAuthorizationExceptionCode_TS837Q1_2300 S_REF_ServiceAuthorizationExceptionCode_TS837Q1_2300 {get; set;}
    [XmlElementAttribute(Order=1)]
    public S_REF_MandatoryMedicareSection4081CrossoverIndicator_TS837Q1_2300 S_REF_MandatoryMedicareSection4081CrossoverIndicator_TS837Q1_2300 {get; set;}
    [XmlElementAttribute(Order=2)]
    public S_REF_MammographyCertificationNumber_TS837Q1_2300 S_REF_MammographyCertificationNumber_TS837Q1_2300 {get; set;}
    [XmlElement(Order=3)]
    public U_REF_PriorAuthorizationOrReferralNumber_TS837Q1_2300 U_REF_PriorAuthorizationOrReferralNumber_TS837Q1_2300 {get; set;}
    [XmlElementAttribute(Order=4)]
    public S_REF_OriginalReferenceNumberICNDCN_TS837Q1_2300 S_REF_OriginalReferenceNumberICNDCN_TS837Q1_2300 {get; set;}
    [XmlElement(Order=5)]
    public U_REF_ClinicalLaboratoryImprovementAmendmentCLIANumber_TS837Q1_2300 U_REF_ClinicalLaboratoryImprovementAmendmentCLIANumber_TS837Q1_2300 {get; set;}
    [XmlElementAttribute(Order=6)]
    public S_REF_RepricedClaimNumber_TS837Q1_2300 S_REF_RepricedClaimNumber_TS837Q1_2300 {get; set;}
    [XmlElementAttribute(Order=7)]
    public S_REF_AdjustedRepricedClaimNumber_TS837Q1_2300 S_REF_AdjustedRepricedClaimNumber_TS837Q1_2300 {get; set;}
    [XmlElementAttribute(Order=8)]
    public S_REF_InvestigationalDeviceExemptionNumber_TS837Q1_2300 S_REF_InvestigationalDeviceExemptionNumber_TS837Q1_2300 {get; set;}
    [XmlElementAttribute(Order=9)]
    public S_REF_ClaimIdentificationNumberForClearingHousesAndOtherTransmissionIntermediaries_TS837Q1_2300 S_REF_ClaimIdentificationNumberForClearingHousesAndOtherTransmissionIntermediaries_TS837Q1_2300 {get; set;}
    [XmlElement(Order=10)]
    public U_REF_AmbulatoryPatientGroupAPG_TS837Q1_2300 U_REF_AmbulatoryPatientGroupAPG_TS837Q1_2300 {get; set;}
    [XmlElementAttribute(Order=11)]
    public S_REF_MedicalRecordNumber_TS837Q1_2300 S_REF_MedicalRecordNumber_TS837Q1_2300 {get; set;}
    [XmlElementAttribute(Order=12)]
    public S_REF_DemonstrationProjectIdentifier_TS837Q1_2300 S_REF_DemonstrationProjectIdentifier_TS837Q1_2300 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_ServiceAuthorizationExceptionCode_TS837Q1_2300 {
    [XmlElement(Order=0)]
    public S_REF_ServiceAuthorizationExceptionCode_TS837Q1_2300D_REF01_ReferenceIdentificationQualifier D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_ServiceAuthorizationExceptionCode {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03 {get; set;}
    [XmlElement(Order=3)]
    public string D_REF04_C040U848 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_REF_ServiceAuthorizationExceptionCode_TS837Q1_2300D_REF01_ReferenceIdentificationQualifier {
        [XmlEnum("4N")]
        Item4N,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_MandatoryMedicareSection4081CrossoverIndicator_TS837Q1_2300 {
    [XmlElement(Order=0)]
    public S_REF_MandatoryMedicareSection4081CrossoverIndicator_TS837Q1_2300D_REF01_ReferenceIdentificationQualifier D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_MedicareSection4081Indicator {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03 {get; set;}
    [XmlElement(Order=3)]
    public string D_REF04_C040U849 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_REF_MandatoryMedicareSection4081CrossoverIndicator_TS837Q1_2300D_REF01_ReferenceIdentificationQualifier {
        F5,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_MammographyCertificationNumber_TS837Q1_2300 {
    [XmlElement(Order=0)]
    public S_REF_MammographyCertificationNumber_TS837Q1_2300D_REF01_ReferenceIdentificationQualifier D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_MammographyCertificationNumber {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03 {get; set;}
    [XmlElement(Order=3)]
    public string D_REF04_C040U850 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_REF_MammographyCertificationNumber_TS837Q1_2300D_REF01_ReferenceIdentificationQualifier {
        EW,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_PriorAuthorizationOrReferralNumber_TS837Q1_2300 {
    [XmlElement(Order=0)]
    public S_REF_PriorAuthorizationOrReferralNumber_TS837Q1_2300D_REF01_ReferenceIdentificationQualifier D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_PriorAuthorizationOrReferralNumber {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03 {get; set;}
    [XmlElement(Order=3)]
    public string D_REF04_C040U851 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_REF_PriorAuthorizationOrReferralNumber_TS837Q1_2300D_REF01_ReferenceIdentificationQualifier {
        [XmlEnum("9F")]
        Item9F,
        G1,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_OriginalReferenceNumberICNDCN_TS837Q1_2300 {
    [XmlElement(Order=0)]
    public S_REF_OriginalReferenceNumberICNDCN_TS837Q1_2300D_REF01_ReferenceIdentificationQualifier D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_ClaimOriginalReferenceNumber {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03 {get; set;}
    [XmlElement(Order=3)]
    public string D_REF04_C040U852 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_REF_OriginalReferenceNumberICNDCN_TS837Q1_2300D_REF01_ReferenceIdentificationQualifier {
        F8,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_ClinicalLaboratoryImprovementAmendmentCLIANumber_TS837Q1_2300 {
    [XmlElement(Order=0)]
    public S_REF_ClinicalLaboratoryImprovementAmendmentCLIANumber_TS837Q1_2300D_REF01_ReferenceIdentificationQualifier D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_ClinicalLaboratoryImprovementAmendmentNumber {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03 {get; set;}
    [XmlElement(Order=3)]
    public string D_REF04_C040U853 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_REF_ClinicalLaboratoryImprovementAmendmentCLIANumber_TS837Q1_2300D_REF01_ReferenceIdentificationQualifier {
        X4,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_RepricedClaimNumber_TS837Q1_2300 {
    [XmlElement(Order=0)]
    public S_REF_RepricedClaimNumber_TS837Q1_2300D_REF01_ReferenceIdentificationQualifier D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_RepricedClaimReferenceNumber {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03 {get; set;}
    [XmlElement(Order=3)]
    public string D_REF04_C040U854 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_REF_RepricedClaimNumber_TS837Q1_2300D_REF01_ReferenceIdentificationQualifier {
        [XmlEnum("9A")]
        Item9A,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_AdjustedRepricedClaimNumber_TS837Q1_2300 {
    [XmlElement(Order=0)]
    public S_REF_AdjustedRepricedClaimNumber_TS837Q1_2300D_REF01_ReferenceIdentificationQualifier D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_AdjustedRepricedClaimReferenceNumber {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03 {get; set;}
    [XmlElement(Order=3)]
    public string D_REF04_C040U855 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_REF_AdjustedRepricedClaimNumber_TS837Q1_2300D_REF01_ReferenceIdentificationQualifier {
        [XmlEnum("9C")]
        Item9C,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_InvestigationalDeviceExemptionNumber_TS837Q1_2300 {
    [XmlElement(Order=0)]
    public S_REF_InvestigationalDeviceExemptionNumber_TS837Q1_2300D_REF01_ReferenceIdentificationQualifier D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_InvestigationalDeviceExemptionIdentifier {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03 {get; set;}
    [XmlElement(Order=3)]
    public string D_REF04_C040U856 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_REF_InvestigationalDeviceExemptionNumber_TS837Q1_2300D_REF01_ReferenceIdentificationQualifier {
        LX,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_ClaimIdentificationNumberForClearingHousesAndOtherTransmissionIntermediaries_TS837Q1_2300 {
    [XmlElement(Order=0)]
    public S_REF_ClaimIdentificationNumberForClearingHousesAndOtherTransmissionIntermediaries_TS837Q1_2300D_REF01_ReferenceIdentificationQualifier D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_ClearinghouseTraceNumber {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03 {get; set;}
    [XmlElement(Order=3)]
    public string D_REF04_C040U857 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_REF_ClaimIdentificationNumberForClearingHousesAndOtherTransmissionIntermediaries_TS837Q1_2300D_REF01_ReferenceIdentificationQualifier {
        D9,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_AmbulatoryPatientGroupAPG_TS837Q1_2300 {
    [XmlElement(Order=0)]
    public S_REF_AmbulatoryPatientGroupAPG_TS837Q1_2300D_REF01_ReferenceIdentificationQualifier D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_AmbulatoryPatientGroupNumber {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03 {get; set;}
    [XmlElement(Order=3)]
    public string D_REF04_C040U858 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_REF_AmbulatoryPatientGroupAPG_TS837Q1_2300D_REF01_ReferenceIdentificationQualifier {
        [XmlEnum("1S")]
        Item1S,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_MedicalRecordNumber_TS837Q1_2300 {
    [XmlElement(Order=0)]
    public S_REF_MedicalRecordNumber_TS837Q1_2300D_REF01_ReferenceIdentificationQualifier D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_MedicalRecordNumber {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03 {get; set;}
    [XmlElement(Order=3)]
    public string D_REF04_C040U859 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_REF_MedicalRecordNumber_TS837Q1_2300D_REF01_ReferenceIdentificationQualifier {
        EA,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_DemonstrationProjectIdentifier_TS837Q1_2300 {
    [XmlElement(Order=0)]
    public S_REF_DemonstrationProjectIdentifier_TS837Q1_2300D_REF01_ReferenceIdentificationQualifier D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_DemonstrationProjectIdentifier {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03 {get; set;}
    [XmlElement(Order=3)]
    public string D_REF04_C040U860 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_REF_DemonstrationProjectIdentifier_TS837Q1_2300D_REF01_ReferenceIdentificationQualifier {
        P4,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_K3_FileInformation_TS837Q1_2300 {
    [XmlElement(Order=0)]
    public string D_K301_FixedFormatInformation {get; set;}
    [XmlElement(Order=1)]
    public string D_K302 {get; set;}
    [XmlElement(Order=2)]
    public string D_K303_C001U861 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_NTE_ClaimNote_TS837Q1_2300 {
    [XmlElement(Order=0)]
    public S_NTE_ClaimNote_TS837Q1_2300D_NTE01_NoteReferenceCode D_NTE01_NoteReferenceCode {get; set;}
    [XmlElement(Order=1)]
    public string D_NTE02_ClaimNoteText {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_NTE_ClaimNote_TS837Q1_2300D_NTE01_NoteReferenceCode {
        ADD,
        CER,
        DCP,
        DGN,
        PMT,
        TPO,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_CR1_AmbulanceTransportInformation_TS837Q1_2300 {
    [XmlElement(Order=0)]
    public S_CR1_AmbulanceTransportInformation_TS837Q1_2300D_CR101_UnitOrBasisForMeasurementCode D_CR101_UnitOrBasisForMeasurementCode {get; set;}
    [XmlIgnore]
    [XmlElementAttribute(Order=1)]
    public bool D_CR101_UnitOrBasisForMeasurementCodeSpecified {get; set;}
    [XmlElement(Order=1)]
    public string D_CR102_PatientWeight {get; set;}
    [XmlElement(Order=2)]
    public string D_CR103_AmbulanceTransportCode {get; set;}
    [XmlElement(Order=3)]
    public string D_CR104_AmbulanceTransportReasonCode {get; set;}
    [XmlElement(Order=4)]
    public string D_CR105_UnitOrBasisForMeasurementCode {get; set;}
    [XmlElement(Order=5)]
    public string D_CR106_TransportDistance {get; set;}
    [XmlElement(Order=6)]
    public string D_CR107 {get; set;}
    [XmlElement(Order=7)]
    public string D_CR108 {get; set;}
    [XmlElement(Order=8)]
    public string D_CR109_RoundTripPurposeDescription {get; set;}
    [XmlElement(Order=9)]
    public string D_CR110_StretcherPurposeDescription {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_CR1_AmbulanceTransportInformation_TS837Q1_2300D_CR101_UnitOrBasisForMeasurementCode {
        LB,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_CR2_SpinalManipulationServiceInformation_TS837Q1_2300 {
    [XmlElement(Order=0)]
    public string D_CR201 {get; set;}
    [XmlElement(Order=1)]
    public string D_CR202 {get; set;}
    [XmlElement(Order=2)]
    public string D_CR203 {get; set;}
    [XmlElement(Order=3)]
    public string D_CR204 {get; set;}
    [XmlElement(Order=4)]
    public string D_CR205 {get; set;}
    [XmlElement(Order=5)]
    public string D_CR206 {get; set;}
    [XmlElement(Order=6)]
    public string D_CR207 {get; set;}
    [XmlElement(Order=7)]
    public string D_CR208_PatientConditionCode {get; set;}
    [XmlElement(Order=8)]
    public string D_CR209 {get; set;}
    [XmlElement(Order=9)]
    public string D_CR210_PatientConditionDescription {get; set;}
    [XmlElement(Order=10)]
    public string D_CR211_PatientConditionDescription {get; set;}
    [XmlElement(Order=11)]
    public string D_CR212_XrayAvailabilityIndicator {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class A_CRC_TS837Q1_2300 {
    [XmlElement(Order=0)]
    public U_CRC_AmbulanceCertification_TS837Q1_2300 U_CRC_AmbulanceCertification_TS837Q1_2300 {get; set;}
    [XmlElement(Order=1)]
    public U_CRC_PatientConditionInformationVision_TS837Q1_2300 U_CRC_PatientConditionInformationVision_TS837Q1_2300 {get; set;}
    [XmlElementAttribute(Order=2)]
    public S_CRC_HomeboundIndicator_TS837Q1_2300 S_CRC_HomeboundIndicator_TS837Q1_2300 {get; set;}
    [XmlElementAttribute(Order=3)]
    public S_CRC_EPSDTReferral_TS837Q1_2300 S_CRC_EPSDTReferral_TS837Q1_2300 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_CRC_AmbulanceCertification_TS837Q1_2300 {
    [XmlElement(Order=0)]
    public S_CRC_AmbulanceCertification_TS837Q1_2300D_CRC01_CodeCategory D_CRC01_CodeCategory {get; set;}
    [XmlElement(Order=1)]
    public S_CRC_AmbulanceCertification_TS837Q1_2300D_CRC02_CertificationConditionIndicator D_CRC02_CertificationConditionIndicator {get; set;}
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
    public enum S_CRC_AmbulanceCertification_TS837Q1_2300D_CRC01_CodeCategory {
        [XmlEnum("07")]
        Item07,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_CRC_AmbulanceCertification_TS837Q1_2300D_CRC02_CertificationConditionIndicator {
        N,
        Y,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_CRC_PatientConditionInformationVision_TS837Q1_2300 {
    [XmlElement(Order=0)]
    public S_CRC_PatientConditionInformationVision_TS837Q1_2300D_CRC01_CodeCategory D_CRC01_CodeCategory {get; set;}
    [XmlElement(Order=1)]
    public S_CRC_PatientConditionInformationVision_TS837Q1_2300D_CRC02_CertificationConditionIndicator D_CRC02_CertificationConditionIndicator {get; set;}
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
    public enum S_CRC_PatientConditionInformationVision_TS837Q1_2300D_CRC01_CodeCategory {
        E1,
        E2,
        E3,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_CRC_PatientConditionInformationVision_TS837Q1_2300D_CRC02_CertificationConditionIndicator {
        N,
        Y,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_CRC_HomeboundIndicator_TS837Q1_2300 {
    [XmlElement(Order=0)]
    public S_CRC_HomeboundIndicator_TS837Q1_2300D_CRC01_CodeCategory D_CRC01_CodeCategory {get; set;}
    [XmlElement(Order=1)]
    public S_CRC_HomeboundIndicator_TS837Q1_2300D_CRC02_CertificationConditionIndicator D_CRC02_CertificationConditionIndicator {get; set;}
    [XmlElement(Order=2)]
    public string D_CRC03_HomeboundIndicator {get; set;}
    [XmlElement(Order=3)]
    public string D_CRC04 {get; set;}
    [XmlElement(Order=4)]
    public string D_CRC05 {get; set;}
    [XmlElement(Order=5)]
    public string D_CRC06 {get; set;}
    [XmlElement(Order=6)]
    public string D_CRC07 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_CRC_HomeboundIndicator_TS837Q1_2300D_CRC01_CodeCategory {
        [XmlEnum("75")]
        Item75,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_CRC_HomeboundIndicator_TS837Q1_2300D_CRC02_CertificationConditionIndicator {
        Y,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_CRC_EPSDTReferral_TS837Q1_2300 {
    [XmlElement(Order=0)]
    public S_CRC_EPSDTReferral_TS837Q1_2300D_CRC01_CodeCategory D_CRC01_CodeCategory {get; set;}
    [XmlElement(Order=1)]
    public S_CRC_EPSDTReferral_TS837Q1_2300D_CRC02_CertificationConditionIndicator D_CRC02_CertificationConditionIndicator {get; set;}
    [XmlElement(Order=2)]
    public string D_CRC03_ConditionCode {get; set;}
    [XmlElement(Order=3)]
    public string D_CRC04_ConditionCode {get; set;}
    [XmlElement(Order=4)]
    public string D_CRC05_ConditionCode {get; set;}
    [XmlElement(Order=5)]
    public string D_CRC06 {get; set;}
    [XmlElement(Order=6)]
    public string D_CRC07 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_CRC_EPSDTReferral_TS837Q1_2300D_CRC01_CodeCategory {
        ZZ,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_CRC_EPSDTReferral_TS837Q1_2300D_CRC02_CertificationConditionIndicator {
        N,
        Y,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_HI_HealthCareDiagnosisCode_TS837Q1_2300 {
    [XmlElement(Order=0)]
    public C_HI01_C022U862_TS837Q1_2300 C_HI01_C022U862_TS837Q1_2300 {get; set;}
    [XmlElement(Order=1)]
    public C_HI02_C022U870_TS837Q1_2300 C_HI02_C022U870_TS837Q1_2300 {get; set;}
    [XmlElement(Order=2)]
    public C_HI03_C022U878_TS837Q1_2300 C_HI03_C022U878_TS837Q1_2300 {get; set;}
    [XmlElement(Order=3)]
    public C_HI04_C022U886_TS837Q1_2300 C_HI04_C022U886_TS837Q1_2300 {get; set;}
    [XmlElement(Order=4)]
    public C_HI05_C022U894_TS837Q1_2300 C_HI05_C022U894_TS837Q1_2300 {get; set;}
    [XmlElement(Order=5)]
    public C_HI06_C022U902_TS837Q1_2300 C_HI06_C022U902_TS837Q1_2300 {get; set;}
    [XmlElement(Order=6)]
    public C_HI07_C022U910_TS837Q1_2300 C_HI07_C022U910_TS837Q1_2300 {get; set;}
    [XmlElement(Order=7)]
    public C_HI08_C022U918_TS837Q1_2300 C_HI08_C022U918_TS837Q1_2300 {get; set;}
    [XmlElement(Order=8)]
    public string D_HI09_C022U926 {get; set;}
    [XmlElement(Order=9)]
    public string D_HI10_C022U927 {get; set;}
    [XmlElement(Order=10)]
    public string D_HI11_C022U928 {get; set;}
    [XmlElement(Order=11)]
    public string D_HI12_C022U929 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_HI01_C022U862_TS837Q1_2300 {
    [XmlElement(Order=0)]
    public C_HI01_C022U862_TS837Q1_2300D_HI01_C02201U863_DiagnosisTypeCode D_HI01_C02201U863_DiagnosisTypeCode {get; set;}
    [XmlElement(Order=1)]
    public string D_HI01_C02202U864_DiagnosisCode {get; set;}
    [XmlElement(Order=2)]
    public string D_HI01_C02203U5872 {get; set;}
    [XmlElement(Order=3)]
    public string D_HI01_C02204U5873 {get; set;}
    [XmlElement(Order=4)]
    public string D_HI01_C02205U5874 {get; set;}
    [XmlElement(Order=5)]
    public string D_HI01_C02206U5875 {get; set;}
    [XmlElement(Order=6)]
    public string D_HI01_C02207U5876 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum C_HI01_C022U862_TS837Q1_2300D_HI01_C02201U863_DiagnosisTypeCode {
        BK,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_HI02_C022U870_TS837Q1_2300 {
    [XmlElement(Order=0)]
    public C_HI02_C022U870_TS837Q1_2300D_HI02_C02201U871_DiagnosisTypeCode D_HI02_C02201U871_DiagnosisTypeCode {get; set;}
    [XmlElement(Order=1)]
    public string D_HI02_C02202U872_DiagnosisCode {get; set;}
    [XmlElement(Order=2)]
    public string D_HI02_C02203U5880 {get; set;}
    [XmlElement(Order=3)]
    public string D_HI02_C02204U5881 {get; set;}
    [XmlElement(Order=4)]
    public string D_HI02_C02205U5882 {get; set;}
    [XmlElement(Order=5)]
    public string D_HI02_C02206U5883 {get; set;}
    [XmlElement(Order=6)]
    public string D_HI02_C02207U5884 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum C_HI02_C022U870_TS837Q1_2300D_HI02_C02201U871_DiagnosisTypeCode {
        BF,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_HI03_C022U878_TS837Q1_2300 {
    [XmlElement(Order=0)]
    public string D_HI03_C02201U879_DiagnosisTypeCode {get; set;}
    [XmlElement(Order=1)]
    public string D_HI03_C02202U880_DiagnosisCode {get; set;}
    [XmlElement(Order=2)]
    public string D_HI03_C02203U5888 {get; set;}
    [XmlElement(Order=3)]
    public string D_HI03_C02204U5889 {get; set;}
    [XmlElement(Order=4)]
    public string D_HI03_C02205U5890 {get; set;}
    [XmlElement(Order=5)]
    public string D_HI03_C02206U5891 {get; set;}
    [XmlElement(Order=6)]
    public string D_HI03_C02207U5892 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_HI04_C022U886_TS837Q1_2300 {
    [XmlElement(Order=0)]
    public string D_HI04_C02201U887_DiagnosisTypeCode {get; set;}
    [XmlElement(Order=1)]
    public string D_HI04_C02202U888_DiagnosisCode {get; set;}
    [XmlElement(Order=2)]
    public string D_HI04_C02203U5896 {get; set;}
    [XmlElement(Order=3)]
    public string D_HI04_C02204U5897 {get; set;}
    [XmlElement(Order=4)]
    public string D_HI04_C02205U5898 {get; set;}
    [XmlElement(Order=5)]
    public string D_HI04_C02206U5899 {get; set;}
    [XmlElement(Order=6)]
    public string D_HI04_C02207U5900 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_HI05_C022U894_TS837Q1_2300 {
    [XmlElement(Order=0)]
    public string D_HI05_C02201U895_DiagnosisTypeCode {get; set;}
    [XmlElement(Order=1)]
    public string D_HI05_C02202U896_DiagnosisCode {get; set;}
    [XmlElement(Order=2)]
    public string D_HI05_C02203U5904 {get; set;}
    [XmlElement(Order=3)]
    public string D_HI05_C02204U5905 {get; set;}
    [XmlElement(Order=4)]
    public string D_HI05_C02205U5906 {get; set;}
    [XmlElement(Order=5)]
    public string D_HI05_C02206U5907 {get; set;}
    [XmlElement(Order=6)]
    public string D_HI05_C02207U5908 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_HI06_C022U902_TS837Q1_2300 {
    [XmlElement(Order=0)]
    public string D_HI06_C02201U903_DiagnosisTypeCode {get; set;}
    [XmlElement(Order=1)]
    public string D_HI06_C02202U904_DiagnosisCode {get; set;}
    [XmlElement(Order=2)]
    public string D_HI06_C02203U5912 {get; set;}
    [XmlElement(Order=3)]
    public string D_HI06_C02204U5913 {get; set;}
    [XmlElement(Order=4)]
    public string D_HI06_C02205U5914 {get; set;}
    [XmlElement(Order=5)]
    public string D_HI06_C02206U5915 {get; set;}
    [XmlElement(Order=6)]
    public string D_HI06_C02207U5916 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_HI07_C022U910_TS837Q1_2300 {
    [XmlElement(Order=0)]
    public string D_HI07_C02201U911_DiagnosisTypeCode {get; set;}
    [XmlElement(Order=1)]
    public string D_HI07_C02202U912_DiagnosisCode {get; set;}
    [XmlElement(Order=2)]
    public string D_HI07_C02203U5920 {get; set;}
    [XmlElement(Order=3)]
    public string D_HI07_C02204U5921 {get; set;}
    [XmlElement(Order=4)]
    public string D_HI07_C02205U5922 {get; set;}
    [XmlElement(Order=5)]
    public string D_HI07_C02206U5923 {get; set;}
    [XmlElement(Order=6)]
    public string D_HI07_C02207U5924 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_HI08_C022U918_TS837Q1_2300 {
    [XmlElement(Order=0)]
    public string D_HI08_C02201U919_DiagnosisTypeCode {get; set;}
    [XmlElement(Order=1)]
    public string D_HI08_C02202U920_DiagnosisCode {get; set;}
    [XmlElement(Order=2)]
    public string D_HI08_C02203U5928 {get; set;}
    [XmlElement(Order=3)]
    public string D_HI08_C02204U5929 {get; set;}
    [XmlElement(Order=4)]
    public string D_HI08_C02205U5930 {get; set;}
    [XmlElement(Order=5)]
    public string D_HI08_C02206U5931 {get; set;}
    [XmlElement(Order=6)]
    public string D_HI08_C02207U5932 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_HCP_ClaimPricingRepricingInformation_TS837Q1_2300 {
    [XmlElement(Order=0)]
    public S_HCP_ClaimPricingRepricingInformation_TS837Q1_2300D_HCP01_PricingMethodology D_HCP01_PricingMethodology {get; set;}
    [XmlElement(Order=1)]
    public string D_HCP02_RepricedAllowedAmount {get; set;}
    [XmlElement(Order=2)]
    public string D_HCP03_RepricedSavingAmount {get; set;}
    [XmlElement(Order=3)]
    public string D_HCP04_RepricingOrganizationIdentifier {get; set;}
    [XmlElement(Order=4)]
    public string D_HCP05_RepricingPerDiemOrFlatRateAmount {get; set;}
    [XmlElement(Order=5)]
    public string D_HCP06_RepricedApprovedAmbulatoryPatientGroupCode {get; set;}
    [XmlElement(Order=6)]
    public string D_HCP07_RepricedApprovedAmbulatoryPatientGroupAmount {get; set;}
    [XmlElement(Order=7)]
    public string D_HCP08 {get; set;}
    [XmlElement(Order=8)]
    public string D_HCP09 {get; set;}
    [XmlElement(Order=9)]
    public string D_HCP10 {get; set;}
    [XmlElement(Order=10)]
    public string D_HCP11 {get; set;}
    [XmlElement(Order=11)]
    public string D_HCP12 {get; set;}
    [XmlElement(Order=12)]
    public string D_HCP13_RejectReasonCode {get; set;}
    [XmlElement(Order=13)]
    public string D_HCP14_PolicyComplianceCode {get; set;}
    [XmlElement(Order=14)]
    public string D_HCP15_ExceptionCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_HCP_ClaimPricingRepricingInformation_TS837Q1_2300D_HCP01_PricingMethodology {
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
    public class G_TS837Q1_2305 {
    [XmlElement(Order=0)]
    public S_CR7_HomeHealthCarePlanInformation_TS837Q1_2305 S_CR7_HomeHealthCarePlanInformation_TS837Q1_2305 {get; set;}
    [XmlElement("S_HSD_HealthCareServicesDelivery_TS837Q1_2305",Order=1)]
    public List<S_HSD_HealthCareServicesDelivery_TS837Q1_2305> S_HSD_HealthCareServicesDelivery_TS837Q1_2305 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_CR7_HomeHealthCarePlanInformation_TS837Q1_2305 {
    [XmlElement(Order=0)]
    public S_CR7_HomeHealthCarePlanInformation_TS837Q1_2305D_CR701_DisciplineTypeCode D_CR701_DisciplineTypeCode {get; set;}
    [XmlElement(Order=1)]
    public string D_CR702_TotalVisitsRenderedCount {get; set;}
    [XmlElement(Order=2)]
    public string D_CR703_CertificationPeriodProjectedVisitCount {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_CR7_HomeHealthCarePlanInformation_TS837Q1_2305D_CR701_DisciplineTypeCode {
        AI,
        MS,
        OT,
        PT,
        SN,
        ST,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_HSD_HealthCareServicesDelivery_TS837Q1_2305 {
    [XmlElement(Order=0)]
    public S_HSD_HealthCareServicesDelivery_TS837Q1_2305D_HSD01_Visits D_HSD01_Visits {get; set;}
    [XmlIgnore]
    [XmlElementAttribute(Order=1)]
    public bool D_HSD01_VisitsSpecified {get; set;}
    [XmlElement(Order=1)]
    public string D_HSD02_NumberOfVisits {get; set;}
    [XmlElement(Order=2)]
    public string D_HSD03_FrequencyPeriod {get; set;}
    [XmlElement(Order=3)]
    public string D_HSD04_FrequencyCount {get; set;}
    [XmlElement(Order=4)]
    public string D_HSD05_DurationOfVisitsUnits {get; set;}
    [XmlElement(Order=5)]
    public string D_HSD06_DurationOfVisitsNumberOfUnits {get; set;}
    [XmlElement(Order=6)]
    public string D_HSD07_ShipDeliveryOrCalendarPatternCode {get; set;}
    [XmlElement(Order=7)]
    public string D_HSD08_DeliveryPatternTimeCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_HSD_HealthCareServicesDelivery_TS837Q1_2305D_HSD01_Visits {
        VS,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class A_TS837Q1_2310 {
    [XmlElement(Order=0)]
    public U_TS837Q1_2310A U_TS837Q1_2310A {get; set;}
    [XmlElementAttribute(Order=1)]
    public G_TS837Q1_2310B G_TS837Q1_2310B {get; set;}
    [XmlElementAttribute(Order=2)]
    public G_TS837Q1_2310C G_TS837Q1_2310C {get; set;}
    [XmlElementAttribute(Order=3)]
    public G_TS837Q1_2310D G_TS837Q1_2310D {get; set;}
    [XmlElementAttribute(Order=4)]
    public G_TS837Q1_2310E G_TS837Q1_2310E {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_TS837Q1_2310A {
    [XmlElement(Order=0)]
    public S_NM1_ReferringProviderName_TS837Q1_2310A S_NM1_ReferringProviderName_TS837Q1_2310A {get; set;}
    [XmlElement(Order=1)]
    public S_PRV_ReferringProviderSpecialtyInformation_TS837Q1_2310A S_PRV_ReferringProviderSpecialtyInformation_TS837Q1_2310A {get; set;}
    [XmlElement("S_REF_ReferringProviderSecondaryIdentification_TS837Q1_2310A",Order=2)]
    public List<S_REF_ReferringProviderSecondaryIdentification_TS837Q1_2310A> S_REF_ReferringProviderSecondaryIdentification_TS837Q1_2310A {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_NM1_ReferringProviderName_TS837Q1_2310A {
    [XmlElement(Order=0)]
    public S_NM1_ReferringProviderName_TS837Q1_2310AD_NM101_EntityIdentifierCode D_NM101_EntityIdentifierCode {get; set;}
    [XmlElement(Order=1)]
    public S_NM1_ReferringProviderName_TS837Q1_2310AD_NM102_EntityTypeQualifier D_NM102_EntityTypeQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_NM103_ReferringProviderLastName {get; set;}
    [XmlElement(Order=3)]
    public string D_NM104_ReferringProviderFirstName {get; set;}
    [XmlElement(Order=4)]
    public string D_NM105_ReferringProviderMiddleName {get; set;}
    [XmlElement(Order=5)]
    public string D_NM106 {get; set;}
    [XmlElement(Order=6)]
    public string D_NM107_ReferringProviderNameSuffix {get; set;}
    [XmlElement(Order=7)]
    public string D_NM108_IdentificationCodeQualifier {get; set;}
    [XmlElement(Order=8)]
    public string D_NM109_ReferringProviderIdentifier {get; set;}
    [XmlElement(Order=9)]
    public string D_NM110 {get; set;}
    [XmlElement(Order=10)]
    public string D_NM111 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_NM1_ReferringProviderName_TS837Q1_2310AD_NM101_EntityIdentifierCode {
        DN,
        P3,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_NM1_ReferringProviderName_TS837Q1_2310AD_NM102_EntityTypeQualifier {
        [XmlEnum("1")]
        Item1,
        [XmlEnum("2")]
        Item2,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_PRV_ReferringProviderSpecialtyInformation_TS837Q1_2310A {
    [XmlElement(Order=0)]
    public S_PRV_ReferringProviderSpecialtyInformation_TS837Q1_2310AD_PRV01_ProviderCode D_PRV01_ProviderCode {get; set;}
    [XmlElement(Order=1)]
    public S_PRV_ReferringProviderSpecialtyInformation_TS837Q1_2310AD_PRV02_ReferenceIdentificationQualifier D_PRV02_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_PRV03_ProviderTaxonomyCode {get; set;}
    [XmlElement(Order=3)]
    public string D_PRV04 {get; set;}
    [XmlElement(Order=4)]
    public string D_PRV05_C035U930 {get; set;}
    [XmlElement(Order=5)]
    public string D_PRV06 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_PRV_ReferringProviderSpecialtyInformation_TS837Q1_2310AD_PRV01_ProviderCode {
        RF,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_PRV_ReferringProviderSpecialtyInformation_TS837Q1_2310AD_PRV02_ReferenceIdentificationQualifier {
        ZZ,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_ReferringProviderSecondaryIdentification_TS837Q1_2310A {
    [XmlElement(Order=0)]
    public S_REF_ReferringProviderSecondaryIdentification_TS837Q1_2310AD_REF01_ReferenceIdentificationQualifier D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_ReferringProviderSecondaryIdentifier {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03 {get; set;}
    [XmlElement(Order=3)]
    public string D_REF04_C040U931 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_REF_ReferringProviderSecondaryIdentification_TS837Q1_2310AD_REF01_ReferenceIdentificationQualifier {
        [XmlEnum("0B")]
        Item0B,
        [XmlEnum("1B")]
        Item1B,
        [XmlEnum("1C")]
        Item1C,
        [XmlEnum("1D")]
        Item1D,
        [XmlEnum("1G")]
        Item1G,
        [XmlEnum("1H")]
        Item1H,
        EI,
        G2,
        LU,
        N5,
        SY,
        X5,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_TS837Q1_2310B {
    [XmlElement(Order=0)]
    public S_NM1_RenderingProviderName_TS837Q1_2310B S_NM1_RenderingProviderName_TS837Q1_2310B {get; set;}
    [XmlElement(Order=1)]
    public S_PRV_RenderingProviderSpecialtyInformation_TS837Q1_2310B S_PRV_RenderingProviderSpecialtyInformation_TS837Q1_2310B {get; set;}
    [XmlElement("S_REF_RenderingProviderSecondaryIdentification_TS837Q1_2310B",Order=2)]
    public List<S_REF_RenderingProviderSecondaryIdentification_TS837Q1_2310B> S_REF_RenderingProviderSecondaryIdentification_TS837Q1_2310B {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_NM1_RenderingProviderName_TS837Q1_2310B {
    [XmlElement(Order=0)]
    public S_NM1_RenderingProviderName_TS837Q1_2310BD_NM101_EntityIdentifierCode D_NM101_EntityIdentifierCode {get; set;}
    [XmlElement(Order=1)]
    public S_NM1_RenderingProviderName_TS837Q1_2310BD_NM102_EntityTypeQualifier D_NM102_EntityTypeQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_NM103_RenderingProviderLastOrOrganizationName {get; set;}
    [XmlElement(Order=3)]
    public string D_NM104_RenderingProviderFirstName {get; set;}
    [XmlElement(Order=4)]
    public string D_NM105_RenderingProviderMiddleName {get; set;}
    [XmlElement(Order=5)]
    public string D_NM106 {get; set;}
    [XmlElement(Order=6)]
    public string D_NM107_RenderingProviderNameSuffix {get; set;}
    [XmlElement(Order=7)]
    public string D_NM108_IdentificationCodeQualifier {get; set;}
    [XmlElement(Order=8)]
    public string D_NM109_RenderingProviderIdentifier {get; set;}
    [XmlElement(Order=9)]
    public string D_NM110 {get; set;}
    [XmlElement(Order=10)]
    public string D_NM111 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_NM1_RenderingProviderName_TS837Q1_2310BD_NM101_EntityIdentifierCode {
        [XmlEnum("82")]
        Item82,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_NM1_RenderingProviderName_TS837Q1_2310BD_NM102_EntityTypeQualifier {
        [XmlEnum("1")]
        Item1,
        [XmlEnum("2")]
        Item2,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_PRV_RenderingProviderSpecialtyInformation_TS837Q1_2310B {
    [XmlElement(Order=0)]
    public S_PRV_RenderingProviderSpecialtyInformation_TS837Q1_2310BD_PRV01_ProviderCode D_PRV01_ProviderCode {get; set;}
    [XmlElement(Order=1)]
    public S_PRV_RenderingProviderSpecialtyInformation_TS837Q1_2310BD_PRV02_ReferenceIdentificationQualifier D_PRV02_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_PRV03_ProviderTaxonomyCode {get; set;}
    [XmlElement(Order=3)]
    public string D_PRV04 {get; set;}
    [XmlElement(Order=4)]
    public string D_PRV05_C035U932 {get; set;}
    [XmlElement(Order=5)]
    public string D_PRV06 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_PRV_RenderingProviderSpecialtyInformation_TS837Q1_2310BD_PRV01_ProviderCode {
        PE,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_PRV_RenderingProviderSpecialtyInformation_TS837Q1_2310BD_PRV02_ReferenceIdentificationQualifier {
        ZZ,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_RenderingProviderSecondaryIdentification_TS837Q1_2310B {
    [XmlElement(Order=0)]
    public S_REF_RenderingProviderSecondaryIdentification_TS837Q1_2310BD_REF01_ReferenceIdentificationQualifier D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_RenderingProviderSecondaryIdentifier {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03 {get; set;}
    [XmlElement(Order=3)]
    public string D_REF04_C040U933 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_REF_RenderingProviderSecondaryIdentification_TS837Q1_2310BD_REF01_ReferenceIdentificationQualifier {
        [XmlEnum("0B")]
        Item0B,
        [XmlEnum("1B")]
        Item1B,
        [XmlEnum("1C")]
        Item1C,
        [XmlEnum("1D")]
        Item1D,
        [XmlEnum("1G")]
        Item1G,
        [XmlEnum("1H")]
        Item1H,
        EI,
        G2,
        LU,
        N5,
        SY,
        X5,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_TS837Q1_2310C {
    [XmlElement(Order=0)]
    public S_NM1_PurchasedServiceProviderName_TS837Q1_2310C S_NM1_PurchasedServiceProviderName_TS837Q1_2310C {get; set;}
    [XmlElement("S_REF_PurchasedServiceProviderSecondaryIdentification_TS837Q1_2310C",Order=1)]
    public List<S_REF_PurchasedServiceProviderSecondaryIdentification_TS837Q1_2310C> S_REF_PurchasedServiceProviderSecondaryIdentification_TS837Q1_2310C {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_NM1_PurchasedServiceProviderName_TS837Q1_2310C {
    [XmlElement(Order=0)]
    public S_NM1_PurchasedServiceProviderName_TS837Q1_2310CD_NM101_EntityIdentifierCode D_NM101_EntityIdentifierCode {get; set;}
    [XmlElement(Order=1)]
    public S_NM1_PurchasedServiceProviderName_TS837Q1_2310CD_NM102_EntityTypeQualifier D_NM102_EntityTypeQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_NM103_PurchasedServiceProviderLastOrOrganizationName {get; set;}
    [XmlElement(Order=3)]
    public string D_NM104_PurchasedServiceProviderFirstName {get; set;}
    [XmlElement(Order=4)]
    public string D_NM105_PurchasedServiceProviderMiddleName {get; set;}
    [XmlElement(Order=5)]
    public string D_NM106 {get; set;}
    [XmlElement(Order=6)]
    public string D_NM107 {get; set;}
    [XmlElement(Order=7)]
    public string D_NM108_IdentificationCodeQualifier {get; set;}
    [XmlElement(Order=8)]
    public string D_NM109_PurchasedServiceProviderIdentifier {get; set;}
    [XmlElement(Order=9)]
    public string D_NM110 {get; set;}
    [XmlElement(Order=10)]
    public string D_NM111 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_NM1_PurchasedServiceProviderName_TS837Q1_2310CD_NM101_EntityIdentifierCode {
        QB,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_NM1_PurchasedServiceProviderName_TS837Q1_2310CD_NM102_EntityTypeQualifier {
        [XmlEnum("1")]
        Item1,
        [XmlEnum("2")]
        Item2,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_PurchasedServiceProviderSecondaryIdentification_TS837Q1_2310C {
    [XmlElement(Order=0)]
    public S_REF_PurchasedServiceProviderSecondaryIdentification_TS837Q1_2310CD_REF01_ReferenceIdentificationQualifier D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_PurchasedServiceProviderSecondaryIdentifier {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03 {get; set;}
    [XmlElement(Order=3)]
    public string D_REF04_C040U934 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_REF_PurchasedServiceProviderSecondaryIdentification_TS837Q1_2310CD_REF01_ReferenceIdentificationQualifier {
        [XmlEnum("0B")]
        Item0B,
        [XmlEnum("1A")]
        Item1A,
        [XmlEnum("1B")]
        Item1B,
        [XmlEnum("1C")]
        Item1C,
        [XmlEnum("1D")]
        Item1D,
        [XmlEnum("1G")]
        Item1G,
        [XmlEnum("1H")]
        Item1H,
        EI,
        G2,
        LU,
        N5,
        SY,
        U3,
        X5,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_TS837Q1_2310D {
    [XmlElement(Order=0)]
    public S_NM1_ServiceFacilityLocation_TS837Q1_2310D S_NM1_ServiceFacilityLocation_TS837Q1_2310D {get; set;}
    [XmlElement(Order=1)]
    public S_N3_ServiceFacilityLocationAddress_TS837Q1_2310D S_N3_ServiceFacilityLocationAddress_TS837Q1_2310D {get; set;}
    [XmlElement(Order=2)]
    public S_N4_ServiceFacilityLocationCityStateZIP_TS837Q1_2310D S_N4_ServiceFacilityLocationCityStateZIP_TS837Q1_2310D {get; set;}
    [XmlElement("S_REF_ServiceFacilityLocationSecondaryIdentification_TS837Q1_2310D",Order=3)]
    public List<S_REF_ServiceFacilityLocationSecondaryIdentification_TS837Q1_2310D> S_REF_ServiceFacilityLocationSecondaryIdentification_TS837Q1_2310D {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_NM1_ServiceFacilityLocation_TS837Q1_2310D {
    [XmlElement(Order=0)]
    public S_NM1_ServiceFacilityLocation_TS837Q1_2310DD_NM101_EntityIdentifierCode D_NM101_EntityIdentifierCode {get; set;}
    [XmlElement(Order=1)]
    public S_NM1_ServiceFacilityLocation_TS837Q1_2310DD_NM102_EntityTypeQualifier D_NM102_EntityTypeQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_NM103_LaboratoryOrFacilityName {get; set;}
    [XmlElement(Order=3)]
    public string D_NM104 {get; set;}
    [XmlElement(Order=4)]
    public string D_NM105 {get; set;}
    [XmlElement(Order=5)]
    public string D_NM106 {get; set;}
    [XmlElement(Order=6)]
    public string D_NM107 {get; set;}
    [XmlElement(Order=7)]
    public string D_NM108_IdentificationCodeQualifier {get; set;}
    [XmlElement(Order=8)]
    public string D_NM109_LaboratoryOrFacilityPrimaryIdentifier {get; set;}
    [XmlElement(Order=9)]
    public string D_NM110 {get; set;}
    [XmlElement(Order=10)]
    public string D_NM111 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_NM1_ServiceFacilityLocation_TS837Q1_2310DD_NM101_EntityIdentifierCode {
        [XmlEnum("77")]
        Item77,
        FA,
        LI,
        TL,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_NM1_ServiceFacilityLocation_TS837Q1_2310DD_NM102_EntityTypeQualifier {
        [XmlEnum("2")]
        Item2,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_N3_ServiceFacilityLocationAddress_TS837Q1_2310D {
    [XmlElement(Order=0)]
    public string D_N301_LaboratoryOrFacilityAddressLine {get; set;}
    [XmlElement(Order=1)]
    public string D_N302_LaboratoryOrFacilityAddressLine {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_N4_ServiceFacilityLocationCityStateZIP_TS837Q1_2310D {
    [XmlElement(Order=0)]
    public string D_N401_LaboratoryOrFacilityCityName {get; set;}
    [XmlElement(Order=1)]
    public string D_N402_LaboratoryOrFacilityStateOrProvinceCode {get; set;}
    [XmlElement(Order=2)]
    public string D_N403_LaboratoryOrFacilityPostalZoneOrZIPCode {get; set;}
    [XmlElement(Order=3)]
    public string D_N404_CountryCode {get; set;}
    [XmlElement(Order=4)]
    public string D_N405 {get; set;}
    [XmlElement(Order=5)]
    public string D_N406 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_ServiceFacilityLocationSecondaryIdentification_TS837Q1_2310D {
    [XmlElement(Order=0)]
    public S_REF_ServiceFacilityLocationSecondaryIdentification_TS837Q1_2310DD_REF01_ReferenceIdentificationQualifier D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_LaboratoryOrFacilitySecondaryIdentifier {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03 {get; set;}
    [XmlElement(Order=3)]
    public string D_REF04_C040U935 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_REF_ServiceFacilityLocationSecondaryIdentification_TS837Q1_2310DD_REF01_ReferenceIdentificationQualifier {
        [XmlEnum("0B")]
        Item0B,
        [XmlEnum("1A")]
        Item1A,
        [XmlEnum("1B")]
        Item1B,
        [XmlEnum("1C")]
        Item1C,
        [XmlEnum("1D")]
        Item1D,
        [XmlEnum("1G")]
        Item1G,
        [XmlEnum("1H")]
        Item1H,
        G2,
        LU,
        N5,
        TJ,
        X4,
        X5,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_TS837Q1_2310E {
    [XmlElement(Order=0)]
    public S_NM1_SupervisingProviderName_TS837Q1_2310E S_NM1_SupervisingProviderName_TS837Q1_2310E {get; set;}
    [XmlElement("S_REF_SupervisingProviderSecondaryIdentification_TS837Q1_2310E",Order=1)]
    public List<S_REF_SupervisingProviderSecondaryIdentification_TS837Q1_2310E> S_REF_SupervisingProviderSecondaryIdentification_TS837Q1_2310E {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_NM1_SupervisingProviderName_TS837Q1_2310E {
    [XmlElement(Order=0)]
    public S_NM1_SupervisingProviderName_TS837Q1_2310ED_NM101_EntityIdentifierCode D_NM101_EntityIdentifierCode {get; set;}
    [XmlElement(Order=1)]
    public S_NM1_SupervisingProviderName_TS837Q1_2310ED_NM102_EntityTypeQualifier D_NM102_EntityTypeQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_NM103_SupervisingProviderLastName {get; set;}
    [XmlElement(Order=3)]
    public string D_NM104_SupervisingProviderFirstName {get; set;}
    [XmlElement(Order=4)]
    public string D_NM105_SupervisingProviderMiddleName {get; set;}
    [XmlElement(Order=5)]
    public string D_NM106 {get; set;}
    [XmlElement(Order=6)]
    public string D_NM107_SupervisingProviderNameSuffix {get; set;}
    [XmlElement(Order=7)]
    public string D_NM108_IdentificationCodeQualifier {get; set;}
    [XmlElement(Order=8)]
    public string D_NM109_SupervisingProviderIdentifier {get; set;}
    [XmlElement(Order=9)]
    public string D_NM110 {get; set;}
    [XmlElement(Order=10)]
    public string D_NM111 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_NM1_SupervisingProviderName_TS837Q1_2310ED_NM101_EntityIdentifierCode {
        DQ,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_NM1_SupervisingProviderName_TS837Q1_2310ED_NM102_EntityTypeQualifier {
        [XmlEnum("1")]
        Item1,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_SupervisingProviderSecondaryIdentification_TS837Q1_2310E {
    [XmlElement(Order=0)]
    public S_REF_SupervisingProviderSecondaryIdentification_TS837Q1_2310ED_REF01_ReferenceIdentificationQualifier D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_SupervisingProviderSecondaryIdentifier {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03 {get; set;}
    [XmlElement(Order=3)]
    public string D_REF04_C040U936 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_REF_SupervisingProviderSecondaryIdentification_TS837Q1_2310ED_REF01_ReferenceIdentificationQualifier {
        [XmlEnum("0B")]
        Item0B,
        [XmlEnum("1B")]
        Item1B,
        [XmlEnum("1C")]
        Item1C,
        [XmlEnum("1D")]
        Item1D,
        [XmlEnum("1G")]
        Item1G,
        [XmlEnum("1H")]
        Item1H,
        EI,
        G2,
        LU,
        N5,
        SY,
        X5,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_TS837Q1_2320 {
    [XmlElement(Order=0)]
    public S_SBR_OtherSubscriberInformation_TS837Q1_2320 S_SBR_OtherSubscriberInformation_TS837Q1_2320 {get; set;}
    [XmlElement("S_CAS_ClaimLevelAdjustments_TS837Q1_2320",Order=1)]
    public List<S_CAS_ClaimLevelAdjustments_TS837Q1_2320> S_CAS_ClaimLevelAdjustments_TS837Q1_2320 {get; set;}
    [XmlElement(Order=2)]
    public A_AMT_CoordinationOfBenefitsCOB_TS837Q1_2320 A_AMT_CoordinationOfBenefitsCOB_TS837Q1_2320 {get; set;}
    [XmlElement(Order=3)]
    public S_DMG_SubscriberDemographicInformation_TS837Q1_2320 S_DMG_SubscriberDemographicInformation_TS837Q1_2320 {get; set;}
    [XmlElement(Order=4)]
    public S_OI_OtherInsuranceCoverageInformation_TS837Q1_2320 S_OI_OtherInsuranceCoverageInformation_TS837Q1_2320 {get; set;}
    [XmlElement(Order=5)]
    public S_MOA_MedicareOutpatientAdjudicationInformation_TS837Q1_2320 S_MOA_MedicareOutpatientAdjudicationInformation_TS837Q1_2320 {get; set;}
    [XmlElement(Order=6)]
    public A_TS837Q1_2330 A_TS837Q1_2330 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_SBR_OtherSubscriberInformation_TS837Q1_2320 {
    [XmlElement(Order=0)]
    public S_SBR_OtherSubscriberInformation_TS837Q1_2320D_SBR01_PayerResponsibilitySequenceNumberCode D_SBR01_PayerResponsibilitySequenceNumberCode {get; set;}
    [XmlElement(Order=1)]
    public S_SBR_OtherSubscriberInformation_TS837Q1_2320D_SBR02_IndividualRelationshipCode D_SBR02_IndividualRelationshipCode {get; set;}
    [XmlElement(Order=2)]
    public string D_SBR03_InsuredGroupOrPolicyNumber {get; set;}
    [XmlElement(Order=3)]
    public string D_SBR04_OtherInsuredGroupName {get; set;}
    [XmlElement(Order=4)]
    public string D_SBR05_InsuranceTypeCode {get; set;}
    [XmlElement(Order=5)]
    public string D_SBR06 {get; set;}
    [XmlElement(Order=6)]
    public string D_SBR07 {get; set;}
    [XmlElement(Order=7)]
    public string D_SBR08 {get; set;}
    [XmlElement(Order=8)]
    public string D_SBR09_ClaimFilingIndicatorCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_SBR_OtherSubscriberInformation_TS837Q1_2320D_SBR01_PayerResponsibilitySequenceNumberCode {
        P,
        S,
        T,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_SBR_OtherSubscriberInformation_TS837Q1_2320D_SBR02_IndividualRelationshipCode {
        [XmlEnum("01")]
        Item01,
        [XmlEnum("04")]
        Item04,
        [XmlEnum("05")]
        Item05,
        [XmlEnum("07")]
        Item07,
        [XmlEnum("10")]
        Item10,
        [XmlEnum("15")]
        Item15,
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
        [XmlEnum("29")]
        Item29,
        [XmlEnum("32")]
        Item32,
        [XmlEnum("33")]
        Item33,
        [XmlEnum("36")]
        Item36,
        [XmlEnum("39")]
        Item39,
        [XmlEnum("40")]
        Item40,
        [XmlEnum("41")]
        Item41,
        [XmlEnum("43")]
        Item43,
        [XmlEnum("53")]
        Item53,
        G8,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_CAS_ClaimLevelAdjustments_TS837Q1_2320 {
    [XmlElement(Order=0)]
    public S_CAS_ClaimLevelAdjustments_TS837Q1_2320D_CAS01_ClaimAdjustmentGroupCode D_CAS01_ClaimAdjustmentGroupCode {get; set;}
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
    public enum S_CAS_ClaimLevelAdjustments_TS837Q1_2320D_CAS01_ClaimAdjustmentGroupCode {
        CO,
        CR,
        OA,
        PI,
        PR,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class A_AMT_CoordinationOfBenefitsCOB_TS837Q1_2320 {
    [XmlElementAttribute(Order=0)]
    public S_AMT_CoordinationOfBenefitsCOBPayerPaidAmount_TS837Q1_2320 S_AMT_CoordinationOfBenefitsCOBPayerPaidAmount_TS837Q1_2320 {get; set;}
    [XmlElementAttribute(Order=1)]
    public S_AMT_CoordinationOfBenefitsCOBApprovedAmount_TS837Q1_2320 S_AMT_CoordinationOfBenefitsCOBApprovedAmount_TS837Q1_2320 {get; set;}
    [XmlElementAttribute(Order=2)]
    public S_AMT_CoordinationOfBenefitsCOBAllowedAmount_TS837Q1_2320 S_AMT_CoordinationOfBenefitsCOBAllowedAmount_TS837Q1_2320 {get; set;}
    [XmlElementAttribute(Order=3)]
    public S_AMT_CoordinationOfBenefitsCOBPatientResponsibilityAmount_TS837Q1_2320 S_AMT_CoordinationOfBenefitsCOBPatientResponsibilityAmount_TS837Q1_2320 {get; set;}
    [XmlElementAttribute(Order=4)]
    public S_AMT_CoordinationOfBenefitsCOBCoveredAmount_TS837Q1_2320 S_AMT_CoordinationOfBenefitsCOBCoveredAmount_TS837Q1_2320 {get; set;}
    [XmlElementAttribute(Order=5)]
    public S_AMT_CoordinationOfBenefitsCOBDiscountAmount_TS837Q1_2320 S_AMT_CoordinationOfBenefitsCOBDiscountAmount_TS837Q1_2320 {get; set;}
    [XmlElementAttribute(Order=6)]
    public S_AMT_CoordinationOfBenefitsCOBPerDayLimitAmount_TS837Q1_2320 S_AMT_CoordinationOfBenefitsCOBPerDayLimitAmount_TS837Q1_2320 {get; set;}
    [XmlElementAttribute(Order=7)]
    public S_AMT_CoordinationOfBenefitsCOBPatientPaidAmount_TS837Q1_2320 S_AMT_CoordinationOfBenefitsCOBPatientPaidAmount_TS837Q1_2320 {get; set;}
    [XmlElementAttribute(Order=8)]
    public S_AMT_CoordinationOfBenefitsCOBTaxAmount_TS837Q1_2320 S_AMT_CoordinationOfBenefitsCOBTaxAmount_TS837Q1_2320 {get; set;}
    [XmlElementAttribute(Order=9)]
    public S_AMT_CoordinationOfBenefitsCOBTotalClaimBeforeTaxesAmount_TS837Q1_2320 S_AMT_CoordinationOfBenefitsCOBTotalClaimBeforeTaxesAmount_TS837Q1_2320 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_AMT_CoordinationOfBenefitsCOBPayerPaidAmount_TS837Q1_2320 {
    [XmlElement(Order=0)]
    public S_AMT_CoordinationOfBenefitsCOBPayerPaidAmount_TS837Q1_2320D_AMT01_AmountQualifierCode D_AMT01_AmountQualifierCode {get; set;}
    [XmlElement(Order=1)]
    public string D_AMT02_PayerPaidAmount {get; set;}
    [XmlElement(Order=2)]
    public string D_AMT03 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_AMT_CoordinationOfBenefitsCOBPayerPaidAmount_TS837Q1_2320D_AMT01_AmountQualifierCode {
        D,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_AMT_CoordinationOfBenefitsCOBApprovedAmount_TS837Q1_2320 {
    [XmlElement(Order=0)]
    public S_AMT_CoordinationOfBenefitsCOBApprovedAmount_TS837Q1_2320D_AMT01_AmountQualifierCode D_AMT01_AmountQualifierCode {get; set;}
    [XmlElement(Order=1)]
    public string D_AMT02_ApprovedAmount {get; set;}
    [XmlElement(Order=2)]
    public string D_AMT03 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_AMT_CoordinationOfBenefitsCOBApprovedAmount_TS837Q1_2320D_AMT01_AmountQualifierCode {
        AAE,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_AMT_CoordinationOfBenefitsCOBAllowedAmount_TS837Q1_2320 {
    [XmlElement(Order=0)]
    public S_AMT_CoordinationOfBenefitsCOBAllowedAmount_TS837Q1_2320D_AMT01_AmountQualifierCode D_AMT01_AmountQualifierCode {get; set;}
    [XmlElement(Order=1)]
    public string D_AMT02_AllowedAmount {get; set;}
    [XmlElement(Order=2)]
    public string D_AMT03 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_AMT_CoordinationOfBenefitsCOBAllowedAmount_TS837Q1_2320D_AMT01_AmountQualifierCode {
        B6,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_AMT_CoordinationOfBenefitsCOBPatientResponsibilityAmount_TS837Q1_2320 {
    [XmlElement(Order=0)]
    public S_AMT_CoordinationOfBenefitsCOBPatientResponsibilityAmount_TS837Q1_2320D_AMT01_AmountQualifierCode D_AMT01_AmountQualifierCode {get; set;}
    [XmlElement(Order=1)]
    public string D_AMT02_OtherPayerPatientResponsibilityAmount {get; set;}
    [XmlElement(Order=2)]
    public string D_AMT03 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_AMT_CoordinationOfBenefitsCOBPatientResponsibilityAmount_TS837Q1_2320D_AMT01_AmountQualifierCode {
        F2,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_AMT_CoordinationOfBenefitsCOBCoveredAmount_TS837Q1_2320 {
    [XmlElement(Order=0)]
    public S_AMT_CoordinationOfBenefitsCOBCoveredAmount_TS837Q1_2320D_AMT01_AmountQualifierCode D_AMT01_AmountQualifierCode {get; set;}
    [XmlElement(Order=1)]
    public string D_AMT02_OtherPayerCoveredAmount {get; set;}
    [XmlElement(Order=2)]
    public string D_AMT03 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_AMT_CoordinationOfBenefitsCOBCoveredAmount_TS837Q1_2320D_AMT01_AmountQualifierCode {
        AU,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_AMT_CoordinationOfBenefitsCOBDiscountAmount_TS837Q1_2320 {
    [XmlElement(Order=0)]
    public S_AMT_CoordinationOfBenefitsCOBDiscountAmount_TS837Q1_2320D_AMT01_AmountQualifierCode D_AMT01_AmountQualifierCode {get; set;}
    [XmlElement(Order=1)]
    public string D_AMT02_OtherPayerDiscountAmount {get; set;}
    [XmlElement(Order=2)]
    public string D_AMT03 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_AMT_CoordinationOfBenefitsCOBDiscountAmount_TS837Q1_2320D_AMT01_AmountQualifierCode {
        D8,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_AMT_CoordinationOfBenefitsCOBPerDayLimitAmount_TS837Q1_2320 {
    [XmlElement(Order=0)]
    public S_AMT_CoordinationOfBenefitsCOBPerDayLimitAmount_TS837Q1_2320D_AMT01_AmountQualifierCode D_AMT01_AmountQualifierCode {get; set;}
    [XmlElement(Order=1)]
    public string D_AMT02_OtherPayerPerDayLimitAmount {get; set;}
    [XmlElement(Order=2)]
    public string D_AMT03 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_AMT_CoordinationOfBenefitsCOBPerDayLimitAmount_TS837Q1_2320D_AMT01_AmountQualifierCode {
        DY,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_AMT_CoordinationOfBenefitsCOBPatientPaidAmount_TS837Q1_2320 {
    [XmlElement(Order=0)]
    public S_AMT_CoordinationOfBenefitsCOBPatientPaidAmount_TS837Q1_2320D_AMT01_AmountQualifierCode D_AMT01_AmountQualifierCode {get; set;}
    [XmlElement(Order=1)]
    public string D_AMT02_OtherPayerPatientPaidAmount {get; set;}
    [XmlElement(Order=2)]
    public string D_AMT03 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_AMT_CoordinationOfBenefitsCOBPatientPaidAmount_TS837Q1_2320D_AMT01_AmountQualifierCode {
        F5,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_AMT_CoordinationOfBenefitsCOBTaxAmount_TS837Q1_2320 {
    [XmlElement(Order=0)]
    public S_AMT_CoordinationOfBenefitsCOBTaxAmount_TS837Q1_2320D_AMT01_AmountQualifierCode D_AMT01_AmountQualifierCode {get; set;}
    [XmlElement(Order=1)]
    public string D_AMT02_OtherPayerTaxAmount {get; set;}
    [XmlElement(Order=2)]
    public string D_AMT03 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_AMT_CoordinationOfBenefitsCOBTaxAmount_TS837Q1_2320D_AMT01_AmountQualifierCode {
        T,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_AMT_CoordinationOfBenefitsCOBTotalClaimBeforeTaxesAmount_TS837Q1_2320 {
    [XmlElement(Order=0)]
    public S_AMT_CoordinationOfBenefitsCOBTotalClaimBeforeTaxesAmount_TS837Q1_2320D_AMT01_AmountQualifierCode D_AMT01_AmountQualifierCode {get; set;}
    [XmlElement(Order=1)]
    public string D_AMT02_OtherPayerPreTaxClaimTotalAmount {get; set;}
    [XmlElement(Order=2)]
    public string D_AMT03 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_AMT_CoordinationOfBenefitsCOBTotalClaimBeforeTaxesAmount_TS837Q1_2320D_AMT01_AmountQualifierCode {
        T2,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_DMG_SubscriberDemographicInformation_TS837Q1_2320 {
    [XmlElement(Order=0)]
    public S_DMG_SubscriberDemographicInformation_TS837Q1_2320D_DMG01_DateTimePeriodFormatQualifier D_DMG01_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_DMG02_OtherInsuredBirthDate {get; set;}
    [XmlElement(Order=2)]
    public string D_DMG03_OtherInsuredGenderCode {get; set;}
    [XmlElement(Order=3)]
    public string D_DMG04 {get; set;}
    [XmlElement(Order=4)]
    public string D_DMG05 {get; set;}
    [XmlElement(Order=5)]
    public string D_DMG06 {get; set;}
    [XmlElement(Order=6)]
    public string D_DMG07 {get; set;}
    [XmlElement(Order=7)]
    public string D_DMG08 {get; set;}
    [XmlElement(Order=8)]
    public string D_DMG09 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_DMG_SubscriberDemographicInformation_TS837Q1_2320D_DMG01_DateTimePeriodFormatQualifier {
        D8,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_OI_OtherInsuranceCoverageInformation_TS837Q1_2320 {
    [XmlElement(Order=0)]
    public string D_OI01 {get; set;}
    [XmlElement(Order=1)]
    public string D_OI02 {get; set;}
    [XmlElement(Order=2)]
    public string D_OI03_BenefitsAssignmentCertificationIndicator {get; set;}
    [XmlElement(Order=3)]
    public string D_OI04_PatientSignatureSourceCode {get; set;}
    [XmlElement(Order=4)]
    public string D_OI05 {get; set;}
    [XmlElement(Order=5)]
    public string D_OI06_ReleaseOfInformationCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_MOA_MedicareOutpatientAdjudicationInformation_TS837Q1_2320 {
    [XmlElement(Order=0)]
    public string D_MOA01_ReimbursementRate {get; set;}
    [XmlElement(Order=1)]
    public string D_MOA02_HCPCSPayableAmount {get; set;}
    [XmlElement(Order=2)]
    public string D_MOA03_RemarkCode {get; set;}
    [XmlElement(Order=3)]
    public string D_MOA04_RemarkCode {get; set;}
    [XmlElement(Order=4)]
    public string D_MOA05_RemarkCode {get; set;}
    [XmlElement(Order=5)]
    public string D_MOA06_RemarkCode {get; set;}
    [XmlElement(Order=6)]
    public string D_MOA07_RemarkCode {get; set;}
    [XmlElement(Order=7)]
    public string D_MOA08_EndStageRenalDiseasePaymentAmount {get; set;}
    [XmlElement(Order=8)]
    public string D_MOA09_NonPayableProfessionalComponentBilledAmount {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class A_TS837Q1_2330 {
    [XmlElementAttribute(Order=0)]
    public G_TS837Q1_2330A G_TS837Q1_2330A {get; set;}
    [XmlElementAttribute(Order=1)]
    public G_TS837Q1_2330B G_TS837Q1_2330B {get; set;}
    [XmlElementAttribute(Order=2)]
    public G_TS837Q1_2330C G_TS837Q1_2330C {get; set;}
    [XmlElement(Order=3)]
    public U_TS837Q1_2330D U_TS837Q1_2330D {get; set;}
    [XmlElementAttribute(Order=4)]
    public G_TS837Q1_2330E G_TS837Q1_2330E {get; set;}
    [XmlElementAttribute(Order=5)]
    public G_TS837Q1_2330F G_TS837Q1_2330F {get; set;}
    [XmlElementAttribute(Order=6)]
    public G_TS837Q1_2330G G_TS837Q1_2330G {get; set;}
    [XmlElementAttribute(Order=7)]
    public G_TS837Q1_2330H G_TS837Q1_2330H {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_TS837Q1_2330A {
    [XmlElement(Order=0)]
    public S_NM1_OtherSubscriberName_TS837Q1_2330A S_NM1_OtherSubscriberName_TS837Q1_2330A {get; set;}
    [XmlElement(Order=1)]
    public S_N3_OtherSubscriberAddress_TS837Q1_2330A S_N3_OtherSubscriberAddress_TS837Q1_2330A {get; set;}
    [XmlElement(Order=2)]
    public S_N4_OtherSubscriberCityStateZIPCode_TS837Q1_2330A S_N4_OtherSubscriberCityStateZIPCode_TS837Q1_2330A {get; set;}
    [XmlElement("S_REF_OtherSubscriberSecondaryIdentification_TS837Q1_2330A",Order=3)]
    public List<S_REF_OtherSubscriberSecondaryIdentification_TS837Q1_2330A> S_REF_OtherSubscriberSecondaryIdentification_TS837Q1_2330A {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_NM1_OtherSubscriberName_TS837Q1_2330A {
    [XmlElement(Order=0)]
    public S_NM1_OtherSubscriberName_TS837Q1_2330AD_NM101_EntityIdentifierCode D_NM101_EntityIdentifierCode {get; set;}
    [XmlElement(Order=1)]
    public S_NM1_OtherSubscriberName_TS837Q1_2330AD_NM102_EntityTypeQualifier D_NM102_EntityTypeQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_NM103_OtherInsuredLastName {get; set;}
    [XmlElement(Order=3)]
    public string D_NM104_OtherInsuredFirstName {get; set;}
    [XmlElement(Order=4)]
    public string D_NM105_OtherInsuredMiddleName {get; set;}
    [XmlElement(Order=5)]
    public string D_NM106 {get; set;}
    [XmlElement(Order=6)]
    public string D_NM107_OtherInsuredNameSuffix {get; set;}
    [XmlElement(Order=7)]
    public string D_NM108_IdentificationCodeQualifier {get; set;}
    [XmlElement(Order=8)]
    public string D_NM109_OtherInsuredIdentifier {get; set;}
    [XmlElement(Order=9)]
    public string D_NM110 {get; set;}
    [XmlElement(Order=10)]
    public string D_NM111 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_NM1_OtherSubscriberName_TS837Q1_2330AD_NM101_EntityIdentifierCode {
        IL,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_NM1_OtherSubscriberName_TS837Q1_2330AD_NM102_EntityTypeQualifier {
        [XmlEnum("1")]
        Item1,
        [XmlEnum("2")]
        Item2,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_N3_OtherSubscriberAddress_TS837Q1_2330A {
    [XmlElement(Order=0)]
    public string D_N301_OtherInsuredAddressLine {get; set;}
    [XmlElement(Order=1)]
    public string D_N302_OtherInsuredAddressLine {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_N4_OtherSubscriberCityStateZIPCode_TS837Q1_2330A {
    [XmlElement(Order=0)]
    public string D_N401_OtherInsuredCityName {get; set;}
    [XmlElement(Order=1)]
    public string D_N402_OtherInsuredStateCode {get; set;}
    [XmlElement(Order=2)]
    public string D_N403_OtherInsuredPostalZoneOrZIPCode {get; set;}
    [XmlElement(Order=3)]
    public string D_N404_CountryCode {get; set;}
    [XmlElement(Order=4)]
    public string D_N405 {get; set;}
    [XmlElement(Order=5)]
    public string D_N406 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_OtherSubscriberSecondaryIdentification_TS837Q1_2330A {
    [XmlElement(Order=0)]
    public S_REF_OtherSubscriberSecondaryIdentification_TS837Q1_2330AD_REF01_ReferenceIdentificationQualifier D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_OtherInsuredAdditionalIdentifier {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03 {get; set;}
    [XmlElement(Order=3)]
    public string D_REF04_C040U937 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_REF_OtherSubscriberSecondaryIdentification_TS837Q1_2330AD_REF01_ReferenceIdentificationQualifier {
        [XmlEnum("1W")]
        Item1W,
        [XmlEnum("23")]
        Item23,
        IG,
        SY,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_TS837Q1_2330B {
    [XmlElement(Order=0)]
    public S_NM1_OtherPayerName_TS837Q1_2330B S_NM1_OtherPayerName_TS837Q1_2330B {get; set;}
    [XmlElement("S_PER_OtherPayerContactInformation_TS837Q1_2330B",Order=1)]
    public List<S_PER_OtherPayerContactInformation_TS837Q1_2330B> S_PER_OtherPayerContactInformation_TS837Q1_2330B {get; set;}
    [XmlElement(Order=2)]
    public S_DTP_ClaimAdjudicationDate_TS837Q1_2330B S_DTP_ClaimAdjudicationDate_TS837Q1_2330B {get; set;}
    [XmlElement(Order=3)]
    public A_REF_OtherPayerr_TS837Q1_2330B A_REF_OtherPayerr_TS837Q1_2330B {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_NM1_OtherPayerName_TS837Q1_2330B {
    [XmlElement(Order=0)]
    public S_NM1_OtherPayerName_TS837Q1_2330BD_NM101_EntityIdentifierCode D_NM101_EntityIdentifierCode {get; set;}
    [XmlElement(Order=1)]
    public S_NM1_OtherPayerName_TS837Q1_2330BD_NM102_EntityTypeQualifier D_NM102_EntityTypeQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_NM103_OtherPayerLastOrOrganizationName {get; set;}
    [XmlElement(Order=3)]
    public string D_NM104 {get; set;}
    [XmlElement(Order=4)]
    public string D_NM105 {get; set;}
    [XmlElement(Order=5)]
    public string D_NM106 {get; set;}
    [XmlElement(Order=6)]
    public string D_NM107 {get; set;}
    [XmlElement(Order=7)]
    public string D_NM108_IdentificationCodeQualifier {get; set;}
    [XmlElement(Order=8)]
    public string D_NM109_OtherPayerPrimaryIdentifier {get; set;}
    [XmlElement(Order=9)]
    public string D_NM110 {get; set;}
    [XmlElement(Order=10)]
    public string D_NM111 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_NM1_OtherPayerName_TS837Q1_2330BD_NM101_EntityIdentifierCode {
        PR,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_NM1_OtherPayerName_TS837Q1_2330BD_NM102_EntityTypeQualifier {
        [XmlEnum("2")]
        Item2,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_PER_OtherPayerContactInformation_TS837Q1_2330B {
    [XmlElement(Order=0)]
    public S_PER_OtherPayerContactInformation_TS837Q1_2330BD_PER01_ContactFunctionCode D_PER01_ContactFunctionCode {get; set;}
    [XmlElement(Order=1)]
    public string D_PER02_OtherPayerContactName {get; set;}
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
    public string D_PER09 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_PER_OtherPayerContactInformation_TS837Q1_2330BD_PER01_ContactFunctionCode {
        IC,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_DTP_ClaimAdjudicationDate_TS837Q1_2330B {
    [XmlElement(Order=0)]
    public S_DTP_ClaimAdjudicationDate_TS837Q1_2330BD_DTP01_DateTimeQualifier D_DTP01_DateTimeQualifier {get; set;}
    [XmlElement(Order=1)]
    public S_DTP_ClaimAdjudicationDate_TS837Q1_2330BD_DTP02_DateTimePeriodFormatQualifier D_DTP02_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_DTP03_AdjudicationOrPaymentDate {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_DTP_ClaimAdjudicationDate_TS837Q1_2330BD_DTP01_DateTimeQualifier {
        [XmlEnum("573")]
        Item573,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_DTP_ClaimAdjudicationDate_TS837Q1_2330BD_DTP02_DateTimePeriodFormatQualifier {
        D8,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class A_REF_OtherPayerr_TS837Q1_2330B {
    [XmlElement(Order=0)]
    public U_REF_OtherPayerSecondaryIdentifier_TS837Q1_2330B U_REF_OtherPayerSecondaryIdentifier_TS837Q1_2330B {get; set;}
    [XmlElement(Order=1)]
    public U_REF_OtherPayerPriorAuthorizationOrReferralNumber_TS837Q1_2330B U_REF_OtherPayerPriorAuthorizationOrReferralNumber_TS837Q1_2330B {get; set;}
    [XmlElement(Order=2)]
    public U_REF_OtherPayerClaimAdjustmentIndicator_TS837Q1_2330B U_REF_OtherPayerClaimAdjustmentIndicator_TS837Q1_2330B {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_OtherPayerSecondaryIdentifier_TS837Q1_2330B {
    [XmlElement(Order=0)]
    public S_REF_OtherPayerSecondaryIdentifier_TS837Q1_2330BD_REF01_ReferenceIdentificationQualifier D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_OtherPayerSecondaryIdentifier {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03 {get; set;}
    [XmlElement(Order=3)]
    public string D_REF04_C040U938 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_REF_OtherPayerSecondaryIdentifier_TS837Q1_2330BD_REF01_ReferenceIdentificationQualifier {
        [XmlEnum("2U")]
        Item2U,
        F8,
        FY,
        NF,
        TJ,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_OtherPayerPriorAuthorizationOrReferralNumber_TS837Q1_2330B {
    [XmlElement(Order=0)]
    public S_REF_OtherPayerPriorAuthorizationOrReferralNumber_TS837Q1_2330BD_REF01_ReferenceIdentificationQualifier D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_OtherPayerPriorAuthorizationOrReferralNumber {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03 {get; set;}
    [XmlElement(Order=3)]
    public string D_REF04_C040U939 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_REF_OtherPayerPriorAuthorizationOrReferralNumber_TS837Q1_2330BD_REF01_ReferenceIdentificationQualifier {
        [XmlEnum("9F")]
        Item9F,
        G1,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_OtherPayerClaimAdjustmentIndicator_TS837Q1_2330B {
    [XmlElement(Order=0)]
    public S_REF_OtherPayerClaimAdjustmentIndicator_TS837Q1_2330BD_REF01_ReferenceIdentificationQualifier D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_OtherPayerClaimAdjustmentIndicator {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03 {get; set;}
    [XmlElement(Order=3)]
    public string D_REF04_C040U940 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_REF_OtherPayerClaimAdjustmentIndicator_TS837Q1_2330BD_REF01_ReferenceIdentificationQualifier {
        T4,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_TS837Q1_2330C {
    [XmlElement(Order=0)]
    public S_NM1_OtherPayerPatientInformation_TS837Q1_2330C S_NM1_OtherPayerPatientInformation_TS837Q1_2330C {get; set;}
    [XmlElement("S_REF_OtherPayerPatientIdentification_TS837Q1_2330C",Order=1)]
    public List<S_REF_OtherPayerPatientIdentification_TS837Q1_2330C> S_REF_OtherPayerPatientIdentification_TS837Q1_2330C {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_NM1_OtherPayerPatientInformation_TS837Q1_2330C {
    [XmlElement(Order=0)]
    public S_NM1_OtherPayerPatientInformation_TS837Q1_2330CD_NM101_EntityIdentifierCode D_NM101_EntityIdentifierCode {get; set;}
    [XmlElement(Order=1)]
    public S_NM1_OtherPayerPatientInformation_TS837Q1_2330CD_NM102_EntityTypeQualifier D_NM102_EntityTypeQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_NM103 {get; set;}
    [XmlElement(Order=3)]
    public string D_NM104 {get; set;}
    [XmlElement(Order=4)]
    public string D_NM105 {get; set;}
    [XmlElement(Order=5)]
    public string D_NM106 {get; set;}
    [XmlElement(Order=6)]
    public string D_NM107 {get; set;}
    [XmlElement(Order=7)]
    public string D_NM108_IdentificationCodeQualifier {get; set;}
    [XmlElement(Order=8)]
    public string D_NM109_OtherPayerPatientPrimaryIdentifier {get; set;}
    [XmlElement(Order=9)]
    public string D_NM110 {get; set;}
    [XmlElement(Order=10)]
    public string D_NM111 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_NM1_OtherPayerPatientInformation_TS837Q1_2330CD_NM101_EntityIdentifierCode {
        QC,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_NM1_OtherPayerPatientInformation_TS837Q1_2330CD_NM102_EntityTypeQualifier {
        [XmlEnum("1")]
        Item1,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_OtherPayerPatientIdentification_TS837Q1_2330C {
    [XmlElement(Order=0)]
    public S_REF_OtherPayerPatientIdentification_TS837Q1_2330CD_REF01_ReferenceIdentificationQualifier D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_OtherPayerPatientSecondaryIdentifier {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03 {get; set;}
    [XmlElement(Order=3)]
    public string D_REF04_C040U941 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_REF_OtherPayerPatientIdentification_TS837Q1_2330CD_REF01_ReferenceIdentificationQualifier {
        [XmlEnum("1W")]
        Item1W,
        [XmlEnum("23")]
        Item23,
        IG,
        SY,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_TS837Q1_2330D {
    [XmlElement(Order=0)]
    public S_NM1_OtherPayerReferringProvider_TS837Q1_2330D S_NM1_OtherPayerReferringProvider_TS837Q1_2330D {get; set;}
    [XmlElement("S_REF_OtherPayerReferringProviderIdentification_TS837Q1_2330D",Order=1)]
    public List<S_REF_OtherPayerReferringProviderIdentification_TS837Q1_2330D> S_REF_OtherPayerReferringProviderIdentification_TS837Q1_2330D {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_NM1_OtherPayerReferringProvider_TS837Q1_2330D {
    [XmlElement(Order=0)]
    public S_NM1_OtherPayerReferringProvider_TS837Q1_2330DD_NM101_EntityIdentifierCode D_NM101_EntityIdentifierCode {get; set;}
    [XmlElement(Order=1)]
    public S_NM1_OtherPayerReferringProvider_TS837Q1_2330DD_NM102_EntityTypeQualifier D_NM102_EntityTypeQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_NM103 {get; set;}
    [XmlElement(Order=3)]
    public string D_NM104 {get; set;}
    [XmlElement(Order=4)]
    public string D_NM105 {get; set;}
    [XmlElement(Order=5)]
    public string D_NM106 {get; set;}
    [XmlElement(Order=6)]
    public string D_NM107 {get; set;}
    [XmlElement(Order=7)]
    public string D_NM108 {get; set;}
    [XmlElement(Order=8)]
    public string D_NM109 {get; set;}
    [XmlElement(Order=9)]
    public string D_NM110 {get; set;}
    [XmlElement(Order=10)]
    public string D_NM111 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_NM1_OtherPayerReferringProvider_TS837Q1_2330DD_NM101_EntityIdentifierCode {
        DN,
        P3,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_NM1_OtherPayerReferringProvider_TS837Q1_2330DD_NM102_EntityTypeQualifier {
        [XmlEnum("1")]
        Item1,
        [XmlEnum("2")]
        Item2,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_OtherPayerReferringProviderIdentification_TS837Q1_2330D {
    [XmlElement(Order=0)]
    public S_REF_OtherPayerReferringProviderIdentification_TS837Q1_2330DD_REF01_ReferenceIdentificationQualifier D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_OtherPayerReferringProviderIdentifier {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03 {get; set;}
    [XmlElement(Order=3)]
    public string D_REF04_C040U942 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_REF_OtherPayerReferringProviderIdentification_TS837Q1_2330DD_REF01_ReferenceIdentificationQualifier {
        [XmlEnum("1B")]
        Item1B,
        [XmlEnum("1C")]
        Item1C,
        [XmlEnum("1D")]
        Item1D,
        EI,
        G2,
        LU,
        N5,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_TS837Q1_2330E {
    [XmlElement(Order=0)]
    public S_NM1_OtherPayerRenderingProvider_TS837Q1_2330E S_NM1_OtherPayerRenderingProvider_TS837Q1_2330E {get; set;}
    [XmlElement("S_REF_OtherPayerRenderingProviderSecondaryIdentification_TS837Q1_2330E",Order=1)]
    public List<S_REF_OtherPayerRenderingProviderSecondaryIdentification_TS837Q1_2330E> S_REF_OtherPayerRenderingProviderSecondaryIdentification_TS837Q1_2330E {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_NM1_OtherPayerRenderingProvider_TS837Q1_2330E {
    [XmlElement(Order=0)]
    public S_NM1_OtherPayerRenderingProvider_TS837Q1_2330ED_NM101_EntityIdentifierCode D_NM101_EntityIdentifierCode {get; set;}
    [XmlElement(Order=1)]
    public S_NM1_OtherPayerRenderingProvider_TS837Q1_2330ED_NM102_EntityTypeQualifier D_NM102_EntityTypeQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_NM103 {get; set;}
    [XmlElement(Order=3)]
    public string D_NM104 {get; set;}
    [XmlElement(Order=4)]
    public string D_NM105 {get; set;}
    [XmlElement(Order=5)]
    public string D_NM106 {get; set;}
    [XmlElement(Order=6)]
    public string D_NM107 {get; set;}
    [XmlElement(Order=7)]
    public string D_NM108 {get; set;}
    [XmlElement(Order=8)]
    public string D_NM109 {get; set;}
    [XmlElement(Order=9)]
    public string D_NM110 {get; set;}
    [XmlElement(Order=10)]
    public string D_NM111 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_NM1_OtherPayerRenderingProvider_TS837Q1_2330ED_NM101_EntityIdentifierCode {
        [XmlEnum("82")]
        Item82,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_NM1_OtherPayerRenderingProvider_TS837Q1_2330ED_NM102_EntityTypeQualifier {
        [XmlEnum("1")]
        Item1,
        [XmlEnum("2")]
        Item2,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_OtherPayerRenderingProviderSecondaryIdentification_TS837Q1_2330E {
    [XmlElement(Order=0)]
    public S_REF_OtherPayerRenderingProviderSecondaryIdentification_TS837Q1_2330ED_REF01_ReferenceIdentificationQualifier D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_OtherPayerRenderingProviderSecondaryIdentifier {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03 {get; set;}
    [XmlElement(Order=3)]
    public string D_REF04_C040U943 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_REF_OtherPayerRenderingProviderSecondaryIdentification_TS837Q1_2330ED_REF01_ReferenceIdentificationQualifier {
        [XmlEnum("1B")]
        Item1B,
        [XmlEnum("1C")]
        Item1C,
        [XmlEnum("1D")]
        Item1D,
        EI,
        G2,
        LU,
        N5,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_TS837Q1_2330F {
    [XmlElement(Order=0)]
    public S_NM1_OtherPayerPurchasedServiceProvider_TS837Q1_2330F S_NM1_OtherPayerPurchasedServiceProvider_TS837Q1_2330F {get; set;}
    [XmlElement("S_REF_OtherPayerPurchasedServiceProviderIdentification_TS837Q1_2330F",Order=1)]
    public List<S_REF_OtherPayerPurchasedServiceProviderIdentification_TS837Q1_2330F> S_REF_OtherPayerPurchasedServiceProviderIdentification_TS837Q1_2330F {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_NM1_OtherPayerPurchasedServiceProvider_TS837Q1_2330F {
    [XmlElement(Order=0)]
    public S_NM1_OtherPayerPurchasedServiceProvider_TS837Q1_2330FD_NM101_EntityIdentifierCode D_NM101_EntityIdentifierCode {get; set;}
    [XmlElement(Order=1)]
    public S_NM1_OtherPayerPurchasedServiceProvider_TS837Q1_2330FD_NM102_EntityTypeQualifier D_NM102_EntityTypeQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_NM103 {get; set;}
    [XmlElement(Order=3)]
    public string D_NM104 {get; set;}
    [XmlElement(Order=4)]
    public string D_NM105 {get; set;}
    [XmlElement(Order=5)]
    public string D_NM106 {get; set;}
    [XmlElement(Order=6)]
    public string D_NM107 {get; set;}
    [XmlElement(Order=7)]
    public string D_NM108 {get; set;}
    [XmlElement(Order=8)]
    public string D_NM109 {get; set;}
    [XmlElement(Order=9)]
    public string D_NM110 {get; set;}
    [XmlElement(Order=10)]
    public string D_NM111 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_NM1_OtherPayerPurchasedServiceProvider_TS837Q1_2330FD_NM101_EntityIdentifierCode {
        QB,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_NM1_OtherPayerPurchasedServiceProvider_TS837Q1_2330FD_NM102_EntityTypeQualifier {
        [XmlEnum("1")]
        Item1,
        [XmlEnum("2")]
        Item2,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_OtherPayerPurchasedServiceProviderIdentification_TS837Q1_2330F {
    [XmlElement(Order=0)]
    public S_REF_OtherPayerPurchasedServiceProviderIdentification_TS837Q1_2330FD_REF01_ReferenceIdentificationQualifier D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_OtherPayerPurchasedServiceProviderIdentifier {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03 {get; set;}
    [XmlElement(Order=3)]
    public string D_REF04_C040U944 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_REF_OtherPayerPurchasedServiceProviderIdentification_TS837Q1_2330FD_REF01_ReferenceIdentificationQualifier {
        [XmlEnum("1A")]
        Item1A,
        [XmlEnum("1B")]
        Item1B,
        [XmlEnum("1C")]
        Item1C,
        [XmlEnum("1D")]
        Item1D,
        EI,
        G2,
        LU,
        N5,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_TS837Q1_2330G {
    [XmlElement(Order=0)]
    public S_NM1_OtherPayerServiceFacilityLocation_TS837Q1_2330G S_NM1_OtherPayerServiceFacilityLocation_TS837Q1_2330G {get; set;}
    [XmlElement("S_REF_OtherPayerServiceFacilityLocationIdentification_TS837Q1_2330G",Order=1)]
    public List<S_REF_OtherPayerServiceFacilityLocationIdentification_TS837Q1_2330G> S_REF_OtherPayerServiceFacilityLocationIdentification_TS837Q1_2330G {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_NM1_OtherPayerServiceFacilityLocation_TS837Q1_2330G {
    [XmlElement(Order=0)]
    public S_NM1_OtherPayerServiceFacilityLocation_TS837Q1_2330GD_NM101_EntityIdentifierCode D_NM101_EntityIdentifierCode {get; set;}
    [XmlElement(Order=1)]
    public S_NM1_OtherPayerServiceFacilityLocation_TS837Q1_2330GD_NM102_EntityTypeQualifier D_NM102_EntityTypeQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_NM103 {get; set;}
    [XmlElement(Order=3)]
    public string D_NM104 {get; set;}
    [XmlElement(Order=4)]
    public string D_NM105 {get; set;}
    [XmlElement(Order=5)]
    public string D_NM106 {get; set;}
    [XmlElement(Order=6)]
    public string D_NM107 {get; set;}
    [XmlElement(Order=7)]
    public string D_NM108 {get; set;}
    [XmlElement(Order=8)]
    public string D_NM109 {get; set;}
    [XmlElement(Order=9)]
    public string D_NM110 {get; set;}
    [XmlElement(Order=10)]
    public string D_NM111 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_NM1_OtherPayerServiceFacilityLocation_TS837Q1_2330GD_NM101_EntityIdentifierCode {
        [XmlEnum("77")]
        Item77,
        FA,
        LI,
        TL,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_NM1_OtherPayerServiceFacilityLocation_TS837Q1_2330GD_NM102_EntityTypeQualifier {
        [XmlEnum("2")]
        Item2,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_OtherPayerServiceFacilityLocationIdentification_TS837Q1_2330G {
    [XmlElement(Order=0)]
    public S_REF_OtherPayerServiceFacilityLocationIdentification_TS837Q1_2330GD_REF01_ReferenceIdentificationQualifier D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_OtherPayerServiceFacilityLocationIdentifier {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03 {get; set;}
    [XmlElement(Order=3)]
    public string D_REF04_C040U945 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_REF_OtherPayerServiceFacilityLocationIdentification_TS837Q1_2330GD_REF01_ReferenceIdentificationQualifier {
        [XmlEnum("1A")]
        Item1A,
        [XmlEnum("1B")]
        Item1B,
        [XmlEnum("1C")]
        Item1C,
        [XmlEnum("1D")]
        Item1D,
        G2,
        LU,
        N5,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_TS837Q1_2330H {
    [XmlElement(Order=0)]
    public S_NM1_OtherPayerSupervisingProvider_TS837Q1_2330H S_NM1_OtherPayerSupervisingProvider_TS837Q1_2330H {get; set;}
    [XmlElement("S_REF_OtherPayerSupervisingProviderIdentification_TS837Q1_2330H",Order=1)]
    public List<S_REF_OtherPayerSupervisingProviderIdentification_TS837Q1_2330H> S_REF_OtherPayerSupervisingProviderIdentification_TS837Q1_2330H {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_NM1_OtherPayerSupervisingProvider_TS837Q1_2330H {
    [XmlElement(Order=0)]
    public S_NM1_OtherPayerSupervisingProvider_TS837Q1_2330HD_NM101_EntityIdentifierCode D_NM101_EntityIdentifierCode {get; set;}
    [XmlElement(Order=1)]
    public S_NM1_OtherPayerSupervisingProvider_TS837Q1_2330HD_NM102_EntityTypeQualifier D_NM102_EntityTypeQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_NM103 {get; set;}
    [XmlElement(Order=3)]
    public string D_NM104 {get; set;}
    [XmlElement(Order=4)]
    public string D_NM105 {get; set;}
    [XmlElement(Order=5)]
    public string D_NM106 {get; set;}
    [XmlElement(Order=6)]
    public string D_NM107 {get; set;}
    [XmlElement(Order=7)]
    public string D_NM108 {get; set;}
    [XmlElement(Order=8)]
    public string D_NM109 {get; set;}
    [XmlElement(Order=9)]
    public string D_NM110 {get; set;}
    [XmlElement(Order=10)]
    public string D_NM111 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_NM1_OtherPayerSupervisingProvider_TS837Q1_2330HD_NM101_EntityIdentifierCode {
        DQ,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_NM1_OtherPayerSupervisingProvider_TS837Q1_2330HD_NM102_EntityTypeQualifier {
        [XmlEnum("1")]
        Item1,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_OtherPayerSupervisingProviderIdentification_TS837Q1_2330H {
    [XmlElement(Order=0)]
    public S_REF_OtherPayerSupervisingProviderIdentification_TS837Q1_2330HD_REF01_ReferenceIdentificationQualifier D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_OtherPayerSupervisingProviderIdentifier {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03 {get; set;}
    [XmlElement(Order=3)]
    public string D_REF04_C040U946 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_REF_OtherPayerSupervisingProviderIdentification_TS837Q1_2330HD_REF01_ReferenceIdentificationQualifier {
        [XmlEnum("1B")]
        Item1B,
        [XmlEnum("1C")]
        Item1C,
        [XmlEnum("1D")]
        Item1D,
        EI,
        G2,
        N5,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_TS837Q1_2400 {
    [XmlElement(Order=0)]
    public S_LX_ServiceLine_TS837Q1_2400 S_LX_ServiceLine_TS837Q1_2400 {get; set;}
    [XmlElement(Order=1)]
    public S_SV1_ProfessionalService_TS837Q1_2400 S_SV1_ProfessionalService_TS837Q1_2400 {get; set;}
    [XmlElement(Order=2)]
    public S_SV5_DurableMedicalEquipmentService_TS837Q1_2400 S_SV5_DurableMedicalEquipmentService_TS837Q1_2400 {get; set;}
    [XmlElement(Order=3)]
    public S_PWK_DMERCCMNIndicator_TS837Q1_2400 S_PWK_DMERCCMNIndicator_TS837Q1_2400 {get; set;}
    [XmlElement(Order=4)]
    public S_CR1_AmbulanceTransportInformation_TS837Q1_2400 S_CR1_AmbulanceTransportInformation_TS837Q1_2400 {get; set;}
    [XmlElement("S_CR2_SpinalManipulationServiceInformation_TS837Q1_2400",Order=5)]
    public List<S_CR2_SpinalManipulationServiceInformation_TS837Q1_2400> S_CR2_SpinalManipulationServiceInformation_TS837Q1_2400 {get; set;}
    [XmlElement(Order=6)]
    public S_CR3_DurableMedicalEquipmentCertification_TS837Q1_2400 S_CR3_DurableMedicalEquipmentCertification_TS837Q1_2400 {get; set;}
    [XmlElement(Order=7)]
    public S_CR5_HomeOxygenTherapyInformation_TS837Q1_2400 S_CR5_HomeOxygenTherapyInformation_TS837Q1_2400 {get; set;}
    [XmlElement(Order=8)]
    public A_CRC_TS837Q1_2400 A_CRC_TS837Q1_2400 {get; set;}
    [XmlElement(Order=9)]
    public A_DTP_TS837Q1_2400 A_DTP_TS837Q1_2400 {get; set;}
    [XmlElement("S_MEA_TestResult_TS837Q1_2400",Order=10)]
    public List<S_MEA_TestResult_TS837Q1_2400> S_MEA_TestResult_TS837Q1_2400 {get; set;}
    [XmlElement(Order=11)]
    public S_CN1_ContractInformation_TS837Q1_2400 S_CN1_ContractInformation_TS837Q1_2400 {get; set;}
    [XmlElement(Order=12)]
    public A_REF_TS837Q1_2400 A_REF_TS837Q1_2400 {get; set;}
    [XmlElement(Order=13)]
    public A_AMT_TS837Q1_2400 A_AMT_TS837Q1_2400 {get; set;}
    [XmlElement("S_K3_FileInformation_TS837Q1_2400",Order=14)]
    public List<S_K3_FileInformation_TS837Q1_2400> S_K3_FileInformation_TS837Q1_2400 {get; set;}
    [XmlElement(Order=15)]
    public S_NTE_LineNote_TS837Q1_2400 S_NTE_LineNote_TS837Q1_2400 {get; set;}
    [XmlElement(Order=16)]
    public S_PS1_PurchasedServiceInformation_TS837Q1_2400 S_PS1_PurchasedServiceInformation_TS837Q1_2400 {get; set;}
    [XmlElement(Order=17)]
    public S_HSD_HealthCareServicesDelivery_TS837Q1_2400 S_HSD_HealthCareServicesDelivery_TS837Q1_2400 {get; set;}
    [XmlElement(Order=18)]
    public S_HCP_LinePricingRepricingInformation_TS837Q1_2400 S_HCP_LinePricingRepricingInformation_TS837Q1_2400 {get; set;}
    [XmlElement("G_TS837Q1_2410",Order=19)]
    public List<G_TS837Q1_2410> G_TS837Q1_2410 {get; set;}
    [XmlElement(Order=20)]
    public A_TS837Q1_2420 A_TS837Q1_2420 {get; set;}
    [XmlElement("G_TS837Q1_2430",Order=21)]
    public List<G_TS837Q1_2430> G_TS837Q1_2430 {get; set;}
    [XmlElement("G_TS837Q1_2440",Order=22)]
    public List<G_TS837Q1_2440> G_TS837Q1_2440 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_LX_ServiceLine_TS837Q1_2400 {
    [XmlElement(Order=0)]
    public string D_LX01_AssignedNumber {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_SV1_ProfessionalService_TS837Q1_2400 {
    [XmlElement(Order=0)]
    public C_SV101_C003U947_TS837Q1_2400 C_SV101_C003U947_TS837Q1_2400 {get; set;}
    [XmlElement(Order=1)]
    public string D_SV102_LineItemChargeAmount {get; set;}
    [XmlElement(Order=2)]
    public string D_SV103_UnitOrBasisForMeasurementCode {get; set;}
    [XmlElement(Order=3)]
    public string D_SV104_ServiceUnitCount {get; set;}
    [XmlElement(Order=4)]
    public string D_SV105_PlaceOfServiceCode {get; set;}
    [XmlElement(Order=5)]
    public string D_SV106 {get; set;}
    [XmlElement(Order=6)]
    public C_SV107_C004U955_TS837Q1_2400 C_SV107_C004U955_TS837Q1_2400 {get; set;}
    [XmlElement(Order=7)]
    public string D_SV108 {get; set;}
    [XmlElement(Order=8)]
    public string D_SV109_EmergencyIndicator {get; set;}
    [XmlElement(Order=9)]
    public string D_SV110 {get; set;}
    [XmlElement(Order=10)]
    public string D_SV111_EPSDTIndicator {get; set;}
    [XmlElement(Order=11)]
    public string D_SV112_FamilyPlanningIndicator {get; set;}
    [XmlElement(Order=12)]
    public string D_SV113 {get; set;}
    [XmlElement(Order=13)]
    public string D_SV114 {get; set;}
    [XmlElement(Order=14)]
    public string D_SV115_CoPayStatusCode {get; set;}
    [XmlElement(Order=15)]
    public string D_SV116 {get; set;}
    [XmlElement(Order=16)]
    public string D_SV117 {get; set;}
    [XmlElement(Order=17)]
    public string D_SV118 {get; set;}
    [XmlElement(Order=18)]
    public string D_SV119 {get; set;}
    [XmlElement(Order=19)]
    public string D_SV120 {get; set;}
    [XmlElement(Order=20)]
    public string D_SV121 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_SV101_C003U947_TS837Q1_2400 {
    [XmlElement(Order=0)]
    public C_SV101_C003U947_TS837Q1_2400D_SV101_C00301U948_ProductOrServiceIDQualifier D_SV101_C00301U948_ProductOrServiceIDQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_SV101_C00302U949_ProcedureCode {get; set;}
    [XmlElement(Order=2)]
    public string D_SV101_C00303U950_ProcedureModifier {get; set;}
    [XmlElement(Order=3)]
    public string D_SV101_C00304U951_ProcedureModifier {get; set;}
    [XmlElement(Order=4)]
    public string D_SV101_C00305U952_ProcedureModifier {get; set;}
    [XmlElement(Order=5)]
    public string D_SV101_C00306U953_ProcedureModifier {get; set;}
    [XmlElement(Order=6)]
    public string D_SV101_C00307U5961 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum C_SV101_C003U947_TS837Q1_2400D_SV101_C00301U948_ProductOrServiceIDQualifier {
        HC,
        IV,
        ZZ,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_SV107_C004U955_TS837Q1_2400 {
    [XmlElement(Order=0)]
    public string D_SV107_C00401U956_DiagnosisCodePointer {get; set;}
    [XmlElement(Order=1)]
    public string D_SV107_C00402U957_DiagnosisCodePointer {get; set;}
    [XmlElement(Order=2)]
    public string D_SV107_C00403U958_DiagnosisCodePointer {get; set;}
    [XmlElement(Order=3)]
    public string D_SV107_C00404U959_DiagnosisCodePointer {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_SV5_DurableMedicalEquipmentService_TS837Q1_2400 {
    [XmlElement(Order=0)]
    public C_SV501_C003U5967_TS837Q1_2400 C_SV501_C003U5967_TS837Q1_2400 {get; set;}
    [XmlElement(Order=1)]
    public S_SV5_DurableMedicalEquipmentService_TS837Q1_2400D_SV502_UnitOrBasisForMeasurementCode D_SV502_UnitOrBasisForMeasurementCode {get; set;}
    [XmlElement(Order=2)]
    public string D_SV503_LengthOfMedicalNecessity {get; set;}
    [XmlElement(Order=3)]
    public string D_SV504_DMERentalPrice {get; set;}
    [XmlElement(Order=4)]
    public string D_SV505_DMEPurchasePrice {get; set;}
    [XmlElement(Order=5)]
    public string D_SV506_RentalUnitPriceIndicator {get; set;}
    [XmlElement(Order=6)]
    public string D_SV507 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_SV501_C003U5967_TS837Q1_2400 {
    [XmlElement(Order=0)]
    public C_SV501_C003U5967_TS837Q1_2400D_SV501_C00301U5968_ProcedureIdentifier D_SV501_C00301U5968_ProcedureIdentifier {get; set;}
    [XmlElement(Order=1)]
    public string D_SV501_C00302U5969_ProcedureCode {get; set;}
    [XmlElement(Order=2)]
    public string D_SV501_C00303U5970 {get; set;}
    [XmlElement(Order=3)]
    public string D_SV501_C00304U5971 {get; set;}
    [XmlElement(Order=4)]
    public string D_SV501_C00305U5972 {get; set;}
    [XmlElement(Order=5)]
    public string D_SV501_C00306U5973 {get; set;}
    [XmlElement(Order=6)]
    public string D_SV501_C00307U5974 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum C_SV501_C003U5967_TS837Q1_2400D_SV501_C00301U5968_ProcedureIdentifier {
        HC,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_SV5_DurableMedicalEquipmentService_TS837Q1_2400D_SV502_UnitOrBasisForMeasurementCode {
        DA,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_PWK_DMERCCMNIndicator_TS837Q1_2400 {
    [XmlElement(Order=0)]
    public S_PWK_DMERCCMNIndicator_TS837Q1_2400D_PWK01_AttachmentReportTypeCode D_PWK01_AttachmentReportTypeCode {get; set;}
    [XmlElement(Order=1)]
    public S_PWK_DMERCCMNIndicator_TS837Q1_2400D_PWK02_AttachmentTransmissionCode D_PWK02_AttachmentTransmissionCode {get; set;}
    [XmlElement(Order=2)]
    public string D_PWK03 {get; set;}
    [XmlElement(Order=3)]
    public string D_PWK04 {get; set;}
    [XmlElement(Order=4)]
    public string D_PWK05 {get; set;}
    [XmlElement(Order=5)]
    public string D_PWK06 {get; set;}
    [XmlElement(Order=6)]
    public string D_PWK07 {get; set;}
    [XmlElement(Order=7)]
    public string D_PWK08_C002U961 {get; set;}
    [XmlElement(Order=8)]
    public string D_PWK09 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_PWK_DMERCCMNIndicator_TS837Q1_2400D_PWK01_AttachmentReportTypeCode {
        CT,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_PWK_DMERCCMNIndicator_TS837Q1_2400D_PWK02_AttachmentTransmissionCode {
        AB,
        AD,
        AF,
        AG,
        NS,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_CR1_AmbulanceTransportInformation_TS837Q1_2400 {
    [XmlElement(Order=0)]
    public S_CR1_AmbulanceTransportInformation_TS837Q1_2400D_CR101_UnitOrBasisForMeasurementCode D_CR101_UnitOrBasisForMeasurementCode {get; set;}
    [XmlIgnore]
    [XmlElementAttribute(Order=1)]
    public bool D_CR101_UnitOrBasisForMeasurementCodeSpecified {get; set;}
    [XmlElement(Order=1)]
    public string D_CR102_PatientWeight {get; set;}
    [XmlElement(Order=2)]
    public string D_CR103_AmbulanceTransportCode {get; set;}
    [XmlElement(Order=3)]
    public string D_CR104_AmbulanceTransportReasonCode {get; set;}
    [XmlElement(Order=4)]
    public string D_CR105_UnitOrBasisForMeasurementCode {get; set;}
    [XmlElement(Order=5)]
    public string D_CR106_TransportDistance {get; set;}
    [XmlElement(Order=6)]
    public string D_CR107 {get; set;}
    [XmlElement(Order=7)]
    public string D_CR108 {get; set;}
    [XmlElement(Order=8)]
    public string D_CR109_RoundTripPurposeDescription {get; set;}
    [XmlElement(Order=9)]
    public string D_CR110_StretcherPurposeDescription {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_CR1_AmbulanceTransportInformation_TS837Q1_2400D_CR101_UnitOrBasisForMeasurementCode {
        LB,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_CR2_SpinalManipulationServiceInformation_TS837Q1_2400 {
    [XmlElement(Order=0)]
    public string D_CR201 {get; set;}
    [XmlElement(Order=1)]
    public string D_CR202 {get; set;}
    [XmlElement(Order=2)]
    public string D_CR203 {get; set;}
    [XmlElement(Order=3)]
    public string D_CR204 {get; set;}
    [XmlElement(Order=4)]
    public string D_CR205 {get; set;}
    [XmlElement(Order=5)]
    public string D_CR206 {get; set;}
    [XmlElement(Order=6)]
    public string D_CR207 {get; set;}
    [XmlElement(Order=7)]
    public string D_CR208_PatientConditionCode {get; set;}
    [XmlElement(Order=8)]
    public string D_CR209 {get; set;}
    [XmlElement(Order=9)]
    public string D_CR210_PatientConditionDescription {get; set;}
    [XmlElement(Order=10)]
    public string D_CR211_PatientConditionDescription {get; set;}
    [XmlElement(Order=11)]
    public string D_CR212_XrayAvailabilityIndicator {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_CR3_DurableMedicalEquipmentCertification_TS837Q1_2400 {
    [XmlElement(Order=0)]
    public S_CR3_DurableMedicalEquipmentCertification_TS837Q1_2400D_CR301_CertificationTypeCode D_CR301_CertificationTypeCode {get; set;}
    [XmlElement(Order=1)]
    public S_CR3_DurableMedicalEquipmentCertification_TS837Q1_2400D_CR302_UnitOrBasisForMeasurementCode D_CR302_UnitOrBasisForMeasurementCode {get; set;}
    [XmlElement(Order=2)]
    public string D_CR303_DurableMedicalEquipmentDuration {get; set;}
    [XmlElement(Order=3)]
    public string D_CR304 {get; set;}
    [XmlElement(Order=4)]
    public string D_CR305 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_CR3_DurableMedicalEquipmentCertification_TS837Q1_2400D_CR301_CertificationTypeCode {
        I,
        R,
        S,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_CR3_DurableMedicalEquipmentCertification_TS837Q1_2400D_CR302_UnitOrBasisForMeasurementCode {
        MO,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_CR5_HomeOxygenTherapyInformation_TS837Q1_2400 {
    [XmlElement(Order=0)]
    public S_CR5_HomeOxygenTherapyInformation_TS837Q1_2400D_CR501_CertificationTypeCode D_CR501_CertificationTypeCode {get; set;}
    [XmlElement(Order=1)]
    public string D_CR502_TreatmentPeriodCount {get; set;}
    [XmlElement(Order=2)]
    public string D_CR503 {get; set;}
    [XmlElement(Order=3)]
    public string D_CR504 {get; set;}
    [XmlElement(Order=4)]
    public string D_CR505 {get; set;}
    [XmlElement(Order=5)]
    public string D_CR506 {get; set;}
    [XmlElement(Order=6)]
    public string D_CR507 {get; set;}
    [XmlElement(Order=7)]
    public string D_CR508 {get; set;}
    [XmlElement(Order=8)]
    public string D_CR509 {get; set;}
    [XmlElement(Order=9)]
    public string D_CR510_ArterialBloodGasQuantity {get; set;}
    [XmlElement(Order=10)]
    public string D_CR511_OxygenSaturationQuantity {get; set;}
    [XmlElement(Order=11)]
    public string D_CR512_OxygenTestConditionCode {get; set;}
    [XmlElement(Order=12)]
    public string D_CR513_OxygenTestFindingsCode {get; set;}
    [XmlElement(Order=13)]
    public string D_CR514_OxygenTestFindingsCode {get; set;}
    [XmlElement(Order=14)]
    public string D_CR515_OxygenTestFindingsCode {get; set;}
    [XmlElement(Order=15)]
    public string D_CR516 {get; set;}
    [XmlElement(Order=16)]
    public string D_CR517 {get; set;}
    [XmlElement(Order=17)]
    public string D_CR518 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_CR5_HomeOxygenTherapyInformation_TS837Q1_2400D_CR501_CertificationTypeCode {
        I,
        R,
        S,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class A_CRC_TS837Q1_2400 {
    [XmlElement(Order=0)]
    public U_CRC_AmbulanceCertification_TS837Q1_2400 U_CRC_AmbulanceCertification_TS837Q1_2400 {get; set;}
    [XmlElementAttribute(Order=1)]
    public S_CRC_HospiceEmployeeIndicator_TS837Q1_2400 S_CRC_HospiceEmployeeIndicator_TS837Q1_2400 {get; set;}
    [XmlElement(Order=2)]
    public U_CRC_DMERCConditionIndicator_TS837Q1_2400 U_CRC_DMERCConditionIndicator_TS837Q1_2400 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_CRC_AmbulanceCertification_TS837Q1_2400 {
    [XmlElement(Order=0)]
    public S_CRC_AmbulanceCertification_TS837Q1_2400D_CRC01_CodeCategory D_CRC01_CodeCategory {get; set;}
    [XmlElement(Order=1)]
    public S_CRC_AmbulanceCertification_TS837Q1_2400D_CRC02_CertificationConditionIndicator D_CRC02_CertificationConditionIndicator {get; set;}
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
    public enum S_CRC_AmbulanceCertification_TS837Q1_2400D_CRC01_CodeCategory {
        [XmlEnum("07")]
        Item07,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_CRC_AmbulanceCertification_TS837Q1_2400D_CRC02_CertificationConditionIndicator {
        N,
        Y,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_CRC_HospiceEmployeeIndicator_TS837Q1_2400 {
    [XmlElement(Order=0)]
    public S_CRC_HospiceEmployeeIndicator_TS837Q1_2400D_CRC01_CodeCategory D_CRC01_CodeCategory {get; set;}
    [XmlElement(Order=1)]
    public S_CRC_HospiceEmployeeIndicator_TS837Q1_2400D_CRC02_HospiceEmployedProviderIndicator D_CRC02_HospiceEmployedProviderIndicator {get; set;}
    [XmlElement(Order=2)]
    public string D_CRC03_ConditionIndicator {get; set;}
    [XmlElement(Order=3)]
    public string D_CRC04 {get; set;}
    [XmlElement(Order=4)]
    public string D_CRC05 {get; set;}
    [XmlElement(Order=5)]
    public string D_CRC06 {get; set;}
    [XmlElement(Order=6)]
    public string D_CRC07 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_CRC_HospiceEmployeeIndicator_TS837Q1_2400D_CRC01_CodeCategory {
        [XmlEnum("70")]
        Item70,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_CRC_HospiceEmployeeIndicator_TS837Q1_2400D_CRC02_HospiceEmployedProviderIndicator {
        N,
        Y,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_CRC_DMERCConditionIndicator_TS837Q1_2400 {
    [XmlElement(Order=0)]
    public S_CRC_DMERCConditionIndicator_TS837Q1_2400D_CRC01_CodeCategory D_CRC01_CodeCategory {get; set;}
    [XmlElement(Order=1)]
    public S_CRC_DMERCConditionIndicator_TS837Q1_2400D_CRC02_CertificationConditionIndicator D_CRC02_CertificationConditionIndicator {get; set;}
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
    public enum S_CRC_DMERCConditionIndicator_TS837Q1_2400D_CRC01_CodeCategory {
        [XmlEnum("09")]
        Item09,
        [XmlEnum("11")]
        Item11,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_CRC_DMERCConditionIndicator_TS837Q1_2400D_CRC02_CertificationConditionIndicator {
        N,
        Y,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class A_DTP_TS837Q1_2400 {
    [XmlElementAttribute(Order=0)]
    public S_DTP_DateServiceDate_TS837Q1_2400 S_DTP_DateServiceDate_TS837Q1_2400 {get; set;}
    [XmlElementAttribute(Order=1)]
    public S_DTP_DateCertificationRevisionDate_TS837Q1_2400 S_DTP_DateCertificationRevisionDate_TS837Q1_2400 {get; set;}
    [XmlElementAttribute(Order=2)]
    public S_DTP_DateBeginTherapyDate_TS837Q1_2400 S_DTP_DateBeginTherapyDate_TS837Q1_2400 {get; set;}
    [XmlElementAttribute(Order=3)]
    public S_DTP_DateLastCertificationDate_TS837Q1_2400 S_DTP_DateLastCertificationDate_TS837Q1_2400 {get; set;}
    [XmlElementAttribute(Order=4)]
    public S_DTP_DateDateLastSeen_TS837Q1_2400 S_DTP_DateDateLastSeen_TS837Q1_2400 {get; set;}
    [XmlElement(Order=5)]
    public U_DTP_DateTest_TS837Q1_2400 U_DTP_DateTest_TS837Q1_2400 {get; set;}
    [XmlElement(Order=6)]
    public U_DTP_DateOxygenSaturationArterialBloodGasTest_TS837Q1_2400 U_DTP_DateOxygenSaturationArterialBloodGasTest_TS837Q1_2400 {get; set;}
    [XmlElementAttribute(Order=7)]
    public S_DTP_DateShipped_TS837Q1_2400 S_DTP_DateShipped_TS837Q1_2400 {get; set;}
    [XmlElementAttribute(Order=8)]
    public S_DTP_DateOnsetOfCurrentSymptomIllness_TS837Q1_2400 S_DTP_DateOnsetOfCurrentSymptomIllness_TS837Q1_2400 {get; set;}
    [XmlElementAttribute(Order=9)]
    public S_DTP_DateLastXray_TS837Q1_2400 S_DTP_DateLastXray_TS837Q1_2400 {get; set;}
    [XmlElementAttribute(Order=10)]
    public S_DTP_DateAcuteManifestation_TS837Q1_2400 S_DTP_DateAcuteManifestation_TS837Q1_2400 {get; set;}
    [XmlElementAttribute(Order=11)]
    public S_DTP_DateInitialTreatment_TS837Q1_2400 S_DTP_DateInitialTreatment_TS837Q1_2400 {get; set;}
    [XmlElementAttribute(Order=12)]
    public S_DTP_DateSimilarIllnessSymptomOnset_TS837Q1_2400 S_DTP_DateSimilarIllnessSymptomOnset_TS837Q1_2400 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_DTP_DateServiceDate_TS837Q1_2400 {
    [XmlElement(Order=0)]
    public S_DTP_DateServiceDate_TS837Q1_2400D_DTP01_DateTimeQualifier D_DTP01_DateTimeQualifier {get; set;}
    [XmlElement(Order=1)]
    public S_DTP_DateServiceDate_TS837Q1_2400D_DTP02_DateTimePeriodFormatQualifier D_DTP02_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_DTP03_ServiceDate {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_DTP_DateServiceDate_TS837Q1_2400D_DTP01_DateTimeQualifier {
        [XmlEnum("472")]
        Item472,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_DTP_DateServiceDate_TS837Q1_2400D_DTP02_DateTimePeriodFormatQualifier {
        D8,
        RD8,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_DTP_DateCertificationRevisionDate_TS837Q1_2400 {
    [XmlElement(Order=0)]
    public S_DTP_DateCertificationRevisionDate_TS837Q1_2400D_DTP01_DateTimeQualifier D_DTP01_DateTimeQualifier {get; set;}
    [XmlElement(Order=1)]
    public S_DTP_DateCertificationRevisionDate_TS837Q1_2400D_DTP02_DateTimePeriodFormatQualifier D_DTP02_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_DTP03_CertificationRevisionDate {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_DTP_DateCertificationRevisionDate_TS837Q1_2400D_DTP01_DateTimeQualifier {
        [XmlEnum("607")]
        Item607,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_DTP_DateCertificationRevisionDate_TS837Q1_2400D_DTP02_DateTimePeriodFormatQualifier {
        D8,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_DTP_DateBeginTherapyDate_TS837Q1_2400 {
    [XmlElement(Order=0)]
    public S_DTP_DateBeginTherapyDate_TS837Q1_2400D_DTP01_DateTimeQualifier D_DTP01_DateTimeQualifier {get; set;}
    [XmlElement(Order=1)]
    public S_DTP_DateBeginTherapyDate_TS837Q1_2400D_DTP02_DateTimePeriodFormatQualifier D_DTP02_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_DTP03_BeginTherapyDate {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_DTP_DateBeginTherapyDate_TS837Q1_2400D_DTP01_DateTimeQualifier {
        [XmlEnum("463")]
        Item463,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_DTP_DateBeginTherapyDate_TS837Q1_2400D_DTP02_DateTimePeriodFormatQualifier {
        D8,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_DTP_DateLastCertificationDate_TS837Q1_2400 {
    [XmlElement(Order=0)]
    public S_DTP_DateLastCertificationDate_TS837Q1_2400D_DTP01_DateTimeQualifier D_DTP01_DateTimeQualifier {get; set;}
    [XmlElement(Order=1)]
    public S_DTP_DateLastCertificationDate_TS837Q1_2400D_DTP02_DateTimePeriodFormatQualifier D_DTP02_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_DTP03_LastCertificationDate {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_DTP_DateLastCertificationDate_TS837Q1_2400D_DTP01_DateTimeQualifier {
        [XmlEnum("461")]
        Item461,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_DTP_DateLastCertificationDate_TS837Q1_2400D_DTP02_DateTimePeriodFormatQualifier {
        D8,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_DTP_DateDateLastSeen_TS837Q1_2400 {
    [XmlElement(Order=0)]
    public S_DTP_DateDateLastSeen_TS837Q1_2400D_DTP01_DateTimeQualifier D_DTP01_DateTimeQualifier {get; set;}
    [XmlElement(Order=1)]
    public S_DTP_DateDateLastSeen_TS837Q1_2400D_DTP02_DateTimePeriodFormatQualifier D_DTP02_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_DTP03_LastSeenDate {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_DTP_DateDateLastSeen_TS837Q1_2400D_DTP01_DateTimeQualifier {
        [XmlEnum("304")]
        Item304,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_DTP_DateDateLastSeen_TS837Q1_2400D_DTP02_DateTimePeriodFormatQualifier {
        D8,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_DTP_DateTest_TS837Q1_2400 {
    [XmlElement(Order=0)]
    public S_DTP_DateTest_TS837Q1_2400D_DTP01_DateTimeQualifier D_DTP01_DateTimeQualifier {get; set;}
    [XmlElement(Order=1)]
    public S_DTP_DateTest_TS837Q1_2400D_DTP02_DateTimePeriodFormatQualifier D_DTP02_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_DTP03_TestPerformedDate {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_DTP_DateTest_TS837Q1_2400D_DTP01_DateTimeQualifier {
        [XmlEnum("738")]
        Item738,
        [XmlEnum("739")]
        Item739,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_DTP_DateTest_TS837Q1_2400D_DTP02_DateTimePeriodFormatQualifier {
        D8,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_DTP_DateOxygenSaturationArterialBloodGasTest_TS837Q1_2400 {
    [XmlElement(Order=0)]
    public S_DTP_DateOxygenSaturationArterialBloodGasTest_TS837Q1_2400D_DTP01_DateTimeQualifier D_DTP01_DateTimeQualifier {get; set;}
    [XmlElement(Order=1)]
    public S_DTP_DateOxygenSaturationArterialBloodGasTest_TS837Q1_2400D_DTP02_DateTimePeriodFormatQualifier D_DTP02_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_DTP03_OxygenSaturationTestDate {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_DTP_DateOxygenSaturationArterialBloodGasTest_TS837Q1_2400D_DTP01_DateTimeQualifier {
        [XmlEnum("119")]
        Item119,
        [XmlEnum("480")]
        Item480,
        [XmlEnum("481")]
        Item481,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_DTP_DateOxygenSaturationArterialBloodGasTest_TS837Q1_2400D_DTP02_DateTimePeriodFormatQualifier {
        D8,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_DTP_DateShipped_TS837Q1_2400 {
    [XmlElement(Order=0)]
    public S_DTP_DateShipped_TS837Q1_2400D_DTP01_DateTimeQualifier D_DTP01_DateTimeQualifier {get; set;}
    [XmlElement(Order=1)]
    public S_DTP_DateShipped_TS837Q1_2400D_DTP02_DateTimePeriodFormatQualifier D_DTP02_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_DTP03_ShippedDate {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_DTP_DateShipped_TS837Q1_2400D_DTP01_DateTimeQualifier {
        [XmlEnum("011")]
        Item011,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_DTP_DateShipped_TS837Q1_2400D_DTP02_DateTimePeriodFormatQualifier {
        D8,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_DTP_DateOnsetOfCurrentSymptomIllness_TS837Q1_2400 {
    [XmlElement(Order=0)]
    public S_DTP_DateOnsetOfCurrentSymptomIllness_TS837Q1_2400D_DTP01_DateTimeQualifier D_DTP01_DateTimeQualifier {get; set;}
    [XmlElement(Order=1)]
    public S_DTP_DateOnsetOfCurrentSymptomIllness_TS837Q1_2400D_DTP02_DateTimePeriodFormatQualifier D_DTP02_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_DTP03_OnsetDate {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_DTP_DateOnsetOfCurrentSymptomIllness_TS837Q1_2400D_DTP01_DateTimeQualifier {
        [XmlEnum("431")]
        Item431,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_DTP_DateOnsetOfCurrentSymptomIllness_TS837Q1_2400D_DTP02_DateTimePeriodFormatQualifier {
        D8,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_DTP_DateLastXray_TS837Q1_2400 {
    [XmlElement(Order=0)]
    public S_DTP_DateLastXray_TS837Q1_2400D_DTP01_DateTimeQualifier D_DTP01_DateTimeQualifier {get; set;}
    [XmlElement(Order=1)]
    public S_DTP_DateLastXray_TS837Q1_2400D_DTP02_DateTimePeriodFormatQualifier D_DTP02_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_DTP03_LastXRayDate {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_DTP_DateLastXray_TS837Q1_2400D_DTP01_DateTimeQualifier {
        [XmlEnum("455")]
        Item455,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_DTP_DateLastXray_TS837Q1_2400D_DTP02_DateTimePeriodFormatQualifier {
        D8,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_DTP_DateAcuteManifestation_TS837Q1_2400 {
    [XmlElement(Order=0)]
    public S_DTP_DateAcuteManifestation_TS837Q1_2400D_DTP01_DateTimeQualifier D_DTP01_DateTimeQualifier {get; set;}
    [XmlElement(Order=1)]
    public S_DTP_DateAcuteManifestation_TS837Q1_2400D_DTP02_DateTimePeriodFormatQualifier D_DTP02_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_DTP03_AcuteManifestationDate {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_DTP_DateAcuteManifestation_TS837Q1_2400D_DTP01_DateTimeQualifier {
        [XmlEnum("453")]
        Item453,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_DTP_DateAcuteManifestation_TS837Q1_2400D_DTP02_DateTimePeriodFormatQualifier {
        D8,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_DTP_DateInitialTreatment_TS837Q1_2400 {
    [XmlElement(Order=0)]
    public S_DTP_DateInitialTreatment_TS837Q1_2400D_DTP01_DateTimeQualifier D_DTP01_DateTimeQualifier {get; set;}
    [XmlElement(Order=1)]
    public S_DTP_DateInitialTreatment_TS837Q1_2400D_DTP02_DateTimePeriodFormatQualifier D_DTP02_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_DTP03_InitialTreatmentDate {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_DTP_DateInitialTreatment_TS837Q1_2400D_DTP01_DateTimeQualifier {
        [XmlEnum("454")]
        Item454,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_DTP_DateInitialTreatment_TS837Q1_2400D_DTP02_DateTimePeriodFormatQualifier {
        D8,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_DTP_DateSimilarIllnessSymptomOnset_TS837Q1_2400 {
    [XmlElement(Order=0)]
    public S_DTP_DateSimilarIllnessSymptomOnset_TS837Q1_2400D_DTP01_DateTimeQualifier D_DTP01_DateTimeQualifier {get; set;}
    [XmlElement(Order=1)]
    public S_DTP_DateSimilarIllnessSymptomOnset_TS837Q1_2400D_DTP02_DateTimePeriodFormatQualifier D_DTP02_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_DTP03_SimilarIllnessOrSymptomDate {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_DTP_DateSimilarIllnessSymptomOnset_TS837Q1_2400D_DTP01_DateTimeQualifier {
        [XmlEnum("438")]
        Item438,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_DTP_DateSimilarIllnessSymptomOnset_TS837Q1_2400D_DTP02_DateTimePeriodFormatQualifier {
        D8,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_MEA_TestResult_TS837Q1_2400 {
    [XmlElement(Order=0)]
    public S_MEA_TestResult_TS837Q1_2400D_MEA01_MeasurementReferenceIdentificationCode D_MEA01_MeasurementReferenceIdentificationCode {get; set;}
    [XmlElement(Order=1)]
    public S_MEA_TestResult_TS837Q1_2400D_MEA02_MeasurementQualifier D_MEA02_MeasurementQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_MEA03_TestResults {get; set;}
    [XmlElement(Order=3)]
    public string D_MEA04_C001U963 {get; set;}
    [XmlElement(Order=4)]
    public string D_MEA05 {get; set;}
    [XmlElement(Order=5)]
    public string D_MEA06 {get; set;}
    [XmlElement(Order=6)]
    public string D_MEA07 {get; set;}
    [XmlElement(Order=7)]
    public string D_MEA08 {get; set;}
    [XmlElement(Order=8)]
    public string D_MEA09 {get; set;}
    [XmlElement(Order=9)]
    public string D_MEA10 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_MEA_TestResult_TS837Q1_2400D_MEA01_MeasurementReferenceIdentificationCode {
        OG,
        TR,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_MEA_TestResult_TS837Q1_2400D_MEA02_MeasurementQualifier {
        GRA,
        HT,
        R1,
        R2,
        R3,
        R4,
        ZO,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_CN1_ContractInformation_TS837Q1_2400 {
    [XmlElement(Order=0)]
    public S_CN1_ContractInformation_TS837Q1_2400D_CN101_ContractTypeCode D_CN101_ContractTypeCode {get; set;}
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
    public enum S_CN1_ContractInformation_TS837Q1_2400D_CN101_ContractTypeCode {
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
    public class A_REF_TS837Q1_2400 {
    [XmlElementAttribute(Order=0)]
    public S_REF_RepricedLineItemReferenceNumber_TS837Q1_2400 S_REF_RepricedLineItemReferenceNumber_TS837Q1_2400 {get; set;}
    [XmlElementAttribute(Order=1)]
    public S_REF_AdjustedRepricedLineItemReferenceNumber_TS837Q1_2400 S_REF_AdjustedRepricedLineItemReferenceNumber_TS837Q1_2400 {get; set;}
    [XmlElement(Order=2)]
    public U_REF_PriorAuthorizationOrReferralNumber_TS837Q1_2400 U_REF_PriorAuthorizationOrReferralNumber_TS837Q1_2400 {get; set;}
    [XmlElementAttribute(Order=3)]
    public S_REF_LineItemControlNumber_TS837Q1_2400 S_REF_LineItemControlNumber_TS837Q1_2400 {get; set;}
    [XmlElementAttribute(Order=4)]
    public S_REF_MammographyCertificationNumber_TS837Q1_2400 S_REF_MammographyCertificationNumber_TS837Q1_2400 {get; set;}
    [XmlElementAttribute(Order=5)]
    public S_REF_ClinicalLaboratoryImprovementAmendmentCLIAIdentification_TS837Q1_2400 S_REF_ClinicalLaboratoryImprovementAmendmentCLIAIdentification_TS837Q1_2400 {get; set;}
    [XmlElementAttribute(Order=6)]
    public S_REF_ReferringClinicalLaboratoryImprovementAmendmentCLIAFacilityIdentification_TS837Q1_2400 S_REF_ReferringClinicalLaboratoryImprovementAmendmentCLIAFacilityIdentification_TS837Q1_2400 {get; set;}
    [XmlElementAttribute(Order=7)]
    public S_REF_ImmunizationBatchNumber_TS837Q1_2400 S_REF_ImmunizationBatchNumber_TS837Q1_2400 {get; set;}
    [XmlElement(Order=8)]
    public U_REF_AmbulatoryPatientGroupAPG_TS837Q1_2400 U_REF_AmbulatoryPatientGroupAPG_TS837Q1_2400 {get; set;}
    [XmlElementAttribute(Order=9)]
    public S_REF_OxygenFlowRate_TS837Q1_2400 S_REF_OxygenFlowRate_TS837Q1_2400 {get; set;}
    [XmlElementAttribute(Order=10)]
    public S_REF_UniversalProductNumberUPN_TS837Q1_2400 S_REF_UniversalProductNumberUPN_TS837Q1_2400 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_RepricedLineItemReferenceNumber_TS837Q1_2400 {
    [XmlElement(Order=0)]
    public S_REF_RepricedLineItemReferenceNumber_TS837Q1_2400D_REF01_ReferenceIdentificationQualifier D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_RepricedLineItemReferenceNumber {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03 {get; set;}
    [XmlElement(Order=3)]
    public string D_REF04_C040U964 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_REF_RepricedLineItemReferenceNumber_TS837Q1_2400D_REF01_ReferenceIdentificationQualifier {
        [XmlEnum("9B")]
        Item9B,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_AdjustedRepricedLineItemReferenceNumber_TS837Q1_2400 {
    [XmlElement(Order=0)]
    public S_REF_AdjustedRepricedLineItemReferenceNumber_TS837Q1_2400D_REF01_ReferenceIdentificationQualifier D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_AdjustedRepricedLineItemReferenceNumber {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03 {get; set;}
    [XmlElement(Order=3)]
    public string D_REF04_C040U965 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_REF_AdjustedRepricedLineItemReferenceNumber_TS837Q1_2400D_REF01_ReferenceIdentificationQualifier {
        [XmlEnum("9D")]
        Item9D,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_PriorAuthorizationOrReferralNumber_TS837Q1_2400 {
    [XmlElement(Order=0)]
    public S_REF_PriorAuthorizationOrReferralNumber_TS837Q1_2400D_REF01_ReferenceIdentificationQualifier D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_PriorAuthorizationOrReferralNumber {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03 {get; set;}
    [XmlElement(Order=3)]
    public string D_REF04_C040U966 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_REF_PriorAuthorizationOrReferralNumber_TS837Q1_2400D_REF01_ReferenceIdentificationQualifier {
        [XmlEnum("9F")]
        Item9F,
        G1,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_LineItemControlNumber_TS837Q1_2400 {
    [XmlElement(Order=0)]
    public S_REF_LineItemControlNumber_TS837Q1_2400D_REF01_ReferenceIdentificationQualifier D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_LineItemControlNumber {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03 {get; set;}
    [XmlElement(Order=3)]
    public string D_REF04_C040U967 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_REF_LineItemControlNumber_TS837Q1_2400D_REF01_ReferenceIdentificationQualifier {
        [XmlEnum("6R")]
        Item6R,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_MammographyCertificationNumber_TS837Q1_2400 {
    [XmlElement(Order=0)]
    public S_REF_MammographyCertificationNumber_TS837Q1_2400D_REF01_ReferenceIdentificationQualifier D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_MammographyCertificationNumber {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03 {get; set;}
    [XmlElement(Order=3)]
    public string D_REF04_C040U968 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_REF_MammographyCertificationNumber_TS837Q1_2400D_REF01_ReferenceIdentificationQualifier {
        EW,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_ClinicalLaboratoryImprovementAmendmentCLIAIdentification_TS837Q1_2400 {
    [XmlElement(Order=0)]
    public S_REF_ClinicalLaboratoryImprovementAmendmentCLIAIdentification_TS837Q1_2400D_REF01_ReferenceIdentificationQualifier D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_ClinicalLaboratoryImprovementAmendmentNumber {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03 {get; set;}
    [XmlElement(Order=3)]
    public string D_REF04_C040U969 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_REF_ClinicalLaboratoryImprovementAmendmentCLIAIdentification_TS837Q1_2400D_REF01_ReferenceIdentificationQualifier {
        X4,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_ReferringClinicalLaboratoryImprovementAmendmentCLIAFacilityIdentification_TS837Q1_2400 {
    [XmlElement(Order=0)]
    public S_REF_ReferringClinicalLaboratoryImprovementAmendmentCLIAFacilityIdentification_TS837Q1_2400D_REF01_ReferenceIdentificationQualifier D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_ReferringCLIANumber {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03 {get; set;}
    [XmlElement(Order=3)]
    public string D_REF04_C040U970 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_REF_ReferringClinicalLaboratoryImprovementAmendmentCLIAFacilityIdentification_TS837Q1_2400D_REF01_ReferenceIdentificationQualifier {
        F4,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_ImmunizationBatchNumber_TS837Q1_2400 {
    [XmlElement(Order=0)]
    public S_REF_ImmunizationBatchNumber_TS837Q1_2400D_REF01_ReferenceIdentificationQualifier D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_ImmunizationBatchNumber {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03 {get; set;}
    [XmlElement(Order=3)]
    public string D_REF04_C040U971 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_REF_ImmunizationBatchNumber_TS837Q1_2400D_REF01_ReferenceIdentificationQualifier {
        BT,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_AmbulatoryPatientGroupAPG_TS837Q1_2400 {
    [XmlElement(Order=0)]
    public S_REF_AmbulatoryPatientGroupAPG_TS837Q1_2400D_REF01_ReferenceIdentificationQualifier D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_AmbulatoryPatientGroupNumber {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03 {get; set;}
    [XmlElement(Order=3)]
    public string D_REF04_C040U972 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_REF_AmbulatoryPatientGroupAPG_TS837Q1_2400D_REF01_ReferenceIdentificationQualifier {
        [XmlEnum("1S")]
        Item1S,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_OxygenFlowRate_TS837Q1_2400 {
    [XmlElement(Order=0)]
    public S_REF_OxygenFlowRate_TS837Q1_2400D_REF01_ReferenceIdentificationQualifier D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_OxygenFlowRate {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03 {get; set;}
    [XmlElement(Order=3)]
    public string D_REF04_C040U973 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_REF_OxygenFlowRate_TS837Q1_2400D_REF01_ReferenceIdentificationQualifier {
        TP,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_UniversalProductNumberUPN_TS837Q1_2400 {
    [XmlElement(Order=0)]
    public S_REF_UniversalProductNumberUPN_TS837Q1_2400D_REF01_ReferenceIdentificationQualifier D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_UniversalProductNumber {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03 {get; set;}
    [XmlElement(Order=3)]
    public string D_REF04_C040U974 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_REF_UniversalProductNumberUPN_TS837Q1_2400D_REF01_ReferenceIdentificationQualifier {
        OZ,
        VP,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class A_AMT_TS837Q1_2400 {
    [XmlElementAttribute(Order=0)]
    public S_AMT_SalesTaxAmount_TS837Q1_2400 S_AMT_SalesTaxAmount_TS837Q1_2400 {get; set;}
    [XmlElementAttribute(Order=1)]
    public S_AMT_ApprovedAmount_TS837Q1_2400 S_AMT_ApprovedAmount_TS837Q1_2400 {get; set;}
    [XmlElementAttribute(Order=2)]
    public S_AMT_PostageClaimedAmount_TS837Q1_2400 S_AMT_PostageClaimedAmount_TS837Q1_2400 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_AMT_SalesTaxAmount_TS837Q1_2400 {
    [XmlElement(Order=0)]
    public S_AMT_SalesTaxAmount_TS837Q1_2400D_AMT01_AmountQualifierCode D_AMT01_AmountQualifierCode {get; set;}
    [XmlElement(Order=1)]
    public string D_AMT02_SalesTaxAmount {get; set;}
    [XmlElement(Order=2)]
    public string D_AMT03 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_AMT_SalesTaxAmount_TS837Q1_2400D_AMT01_AmountQualifierCode {
        T,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_AMT_ApprovedAmount_TS837Q1_2400 {
    [XmlElement(Order=0)]
    public S_AMT_ApprovedAmount_TS837Q1_2400D_AMT01_AmountQualifierCode D_AMT01_AmountQualifierCode {get; set;}
    [XmlElement(Order=1)]
    public string D_AMT02_ApprovedAmount {get; set;}
    [XmlElement(Order=2)]
    public string D_AMT03 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_AMT_ApprovedAmount_TS837Q1_2400D_AMT01_AmountQualifierCode {
        AAE,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_AMT_PostageClaimedAmount_TS837Q1_2400 {
    [XmlElement(Order=0)]
    public S_AMT_PostageClaimedAmount_TS837Q1_2400D_AMT01_AmountQualifierCode D_AMT01_AmountQualifierCode {get; set;}
    [XmlElement(Order=1)]
    public string D_AMT02_PostageClaimedAmount {get; set;}
    [XmlElement(Order=2)]
    public string D_AMT03 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_AMT_PostageClaimedAmount_TS837Q1_2400D_AMT01_AmountQualifierCode {
        F4,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_K3_FileInformation_TS837Q1_2400 {
    [XmlElement(Order=0)]
    public string D_K301_FixedFormatInformation {get; set;}
    [XmlElement(Order=1)]
    public string D_K302 {get; set;}
    [XmlElement(Order=2)]
    public string D_K303_C001U975 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_NTE_LineNote_TS837Q1_2400 {
    [XmlElement(Order=0)]
    public S_NTE_LineNote_TS837Q1_2400D_NTE01_NoteReferenceCode D_NTE01_NoteReferenceCode {get; set;}
    [XmlElement(Order=1)]
    public string D_NTE02_LineNoteText {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_NTE_LineNote_TS837Q1_2400D_NTE01_NoteReferenceCode {
        ADD,
        DCP,
        PMT,
        TPO,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_PS1_PurchasedServiceInformation_TS837Q1_2400 {
    [XmlElement(Order=0)]
    public string D_PS101_PurchasedServiceProviderIdentifier {get; set;}
    [XmlElement(Order=1)]
    public string D_PS102_PurchasedServiceChargeAmount {get; set;}
    [XmlElement(Order=2)]
    public string D_PS103 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_HSD_HealthCareServicesDelivery_TS837Q1_2400 {
    [XmlElement(Order=0)]
    public S_HSD_HealthCareServicesDelivery_TS837Q1_2400D_HSD01_Visits D_HSD01_Visits {get; set;}
    [XmlIgnore]
    [XmlElementAttribute(Order=1)]
    public bool D_HSD01_VisitsSpecified {get; set;}
    [XmlElement(Order=1)]
    public string D_HSD02_NumberOfVisits {get; set;}
    [XmlElement(Order=2)]
    public string D_HSD03_FrequencyPeriod {get; set;}
    [XmlElement(Order=3)]
    public string D_HSD04_FrequencyCount {get; set;}
    [XmlElement(Order=4)]
    public string D_HSD05_DurationOfVisitsUnits {get; set;}
    [XmlElement(Order=5)]
    public string D_HSD06_DurationOfVisitsNumberOfUnits {get; set;}
    [XmlElement(Order=6)]
    public string D_HSD07_ShipDeliveryOrCalendarPatternCode {get; set;}
    [XmlElement(Order=7)]
    public string D_HSD08_DeliveryPatternTimeCode {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_HSD_HealthCareServicesDelivery_TS837Q1_2400D_HSD01_Visits {
        VS,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_HCP_LinePricingRepricingInformation_TS837Q1_2400 {
    [XmlElement(Order=0)]
    public S_HCP_LinePricingRepricingInformation_TS837Q1_2400D_HCP01_PricingMethodology D_HCP01_PricingMethodology {get; set;}
    [XmlElement(Order=1)]
    public string D_HCP02_RepricedAllowedAmount {get; set;}
    [XmlElement(Order=2)]
    public string D_HCP03_RepricedSavingAmount {get; set;}
    [XmlElement(Order=3)]
    public string D_HCP04_RepricingOrganizationIdentifier {get; set;}
    [XmlElement(Order=4)]
    public string D_HCP05_RepricingPerDiemOrFlatRateAmount {get; set;}
    [XmlElement(Order=5)]
    public string D_HCP06_RepricedApprovedAmbulatoryPatientGroupCode {get; set;}
    [XmlElement(Order=6)]
    public string D_HCP07_RepricedApprovedAmbulatoryPatientGroupAmount {get; set;}
    [XmlElement(Order=7)]
    public string D_HCP08 {get; set;}
    [XmlElement(Order=8)]
    public string D_HCP09_ProductOrServiceIDQualifier {get; set;}
    [XmlElement(Order=9)]
    public string D_HCP10_ProcedureCode {get; set;}
    [XmlElement(Order=10)]
    public string D_HCP11_UnitOrBasisForMeasurementCode {get; set;}
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
    public enum S_HCP_LinePricingRepricingInformation_TS837Q1_2400D_HCP01_PricingMethodology {
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
    public class G_TS837Q1_2410 {
    [XmlElement(Order=0)]
    public S_LIN_DrugIdentification_TS837Q1_2410 S_LIN_DrugIdentification_TS837Q1_2410 {get; set;}
    [XmlElement(Order=1)]
    public S_CTP_DrugPricing_TS837Q1_2410 S_CTP_DrugPricing_TS837Q1_2410 {get; set;}
    [XmlElement(Order=2)]
    public S_REF_PrescriptionNumber_TS837Q1_2410 S_REF_PrescriptionNumber_TS837Q1_2410 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_LIN_DrugIdentification_TS837Q1_2410 {
    [XmlElement(Order=0)]
    public string D_LIN01 {get; set;}
    [XmlElement(Order=1)]
    public S_LIN_DrugIdentification_TS837Q1_2410D_LIN02_ProductOrServiceIDQualifier D_LIN02_ProductOrServiceIDQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_LIN03_NationalDrugCode {get; set;}
    [XmlElement(Order=3)]
    public string D_LIN04 {get; set;}
    [XmlElement(Order=4)]
    public string D_LIN05 {get; set;}
    [XmlElement(Order=5)]
    public string D_LIN06 {get; set;}
    [XmlElement(Order=6)]
    public string D_LIN07 {get; set;}
    [XmlElement(Order=7)]
    public string D_LIN08 {get; set;}
    [XmlElement(Order=8)]
    public string D_LIN09 {get; set;}
    [XmlElement(Order=9)]
    public string D_LIN10 {get; set;}
    [XmlElement(Order=10)]
    public string D_LIN11 {get; set;}
    [XmlElement(Order=11)]
    public string D_LIN12 {get; set;}
    [XmlElement(Order=12)]
    public string D_LIN13 {get; set;}
    [XmlElement(Order=13)]
    public string D_LIN14 {get; set;}
    [XmlElement(Order=14)]
    public string D_LIN15 {get; set;}
    [XmlElement(Order=15)]
    public string D_LIN16 {get; set;}
    [XmlElement(Order=16)]
    public string D_LIN17 {get; set;}
    [XmlElement(Order=17)]
    public string D_LIN18 {get; set;}
    [XmlElement(Order=18)]
    public string D_LIN19 {get; set;}
    [XmlElement(Order=19)]
    public string D_LIN20 {get; set;}
    [XmlElement(Order=20)]
    public string D_LIN21 {get; set;}
    [XmlElement(Order=21)]
    public string D_LIN22 {get; set;}
    [XmlElement(Order=22)]
    public string D_LIN23 {get; set;}
    [XmlElement(Order=23)]
    public string D_LIN24 {get; set;}
    [XmlElement(Order=24)]
    public string D_LIN25 {get; set;}
    [XmlElement(Order=25)]
    public string D_LIN26 {get; set;}
    [XmlElement(Order=26)]
    public string D_LIN27 {get; set;}
    [XmlElement(Order=27)]
    public string D_LIN28 {get; set;}
    [XmlElement(Order=28)]
    public string D_LIN29 {get; set;}
    [XmlElement(Order=29)]
    public string D_LIN30 {get; set;}
    [XmlElement(Order=30)]
    public string D_LIN31 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_LIN_DrugIdentification_TS837Q1_2410D_LIN02_ProductOrServiceIDQualifier {
        N4,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_CTP_DrugPricing_TS837Q1_2410 {
    [XmlElement(Order=0)]
    public string D_CTP01 {get; set;}
    [XmlElement(Order=1)]
    public string D_CTP02 {get; set;}
    [XmlElement(Order=2)]
    public string D_CTP03_DrugUnitPrice {get; set;}
    [XmlElement(Order=3)]
    public string D_CTP04_NationalDrugUnitCount {get; set;}
    [XmlElement(Order=4)]
    public C_CTP05_C001U5989_TS837Q1_2410 C_CTP05_C001U5989_TS837Q1_2410 {get; set;}
    [XmlElement(Order=5)]
    public string D_CTP06 {get; set;}
    [XmlElement(Order=6)]
    public string D_CTP07 {get; set;}
    [XmlElement(Order=7)]
    public string D_CTP08 {get; set;}
    [XmlElement(Order=8)]
    public string D_CTP09 {get; set;}
    [XmlElement(Order=9)]
    public string D_CTP10 {get; set;}
    [XmlElement(Order=10)]
    public string D_CTP11 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_CTP05_C001U5989_TS837Q1_2410 {
    [XmlElement(Order=0)]
    public string D_CTP05_C00101U5990_UnitOrBasisForMeasurementCode {get; set;}
    [XmlElement(Order=1)]
    public string D_CTP05_C00102U5991 {get; set;}
    [XmlElement(Order=2)]
    public string D_CTP05_C00103U5992 {get; set;}
    [XmlElement(Order=3)]
    public string D_CTP05_C00104U5993 {get; set;}
    [XmlElement(Order=4)]
    public string D_CTP05_C00105U5994 {get; set;}
    [XmlElement(Order=5)]
    public string D_CTP05_C00106U5995 {get; set;}
    [XmlElement(Order=6)]
    public string D_CTP05_C00107U5996 {get; set;}
    [XmlElement(Order=7)]
    public string D_CTP05_C00108U5997 {get; set;}
    [XmlElement(Order=8)]
    public string D_CTP05_C00109U5998 {get; set;}
    [XmlElement(Order=9)]
    public string D_CTP05_C00110U5999 {get; set;}
    [XmlElement(Order=10)]
    public string D_CTP05_C00111U6000 {get; set;}
    [XmlElement(Order=11)]
    public string D_CTP05_C00112U6001 {get; set;}
    [XmlElement(Order=12)]
    public string D_CTP05_C00113U6002 {get; set;}
    [XmlElement(Order=13)]
    public string D_CTP05_C00114U6003 {get; set;}
    [XmlElement(Order=14)]
    public string D_CTP05_C00115U6004 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_PrescriptionNumber_TS837Q1_2410 {
    [XmlElement(Order=0)]
    public S_REF_PrescriptionNumber_TS837Q1_2410D_REF01_ReferenceIdentificationQualifier D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_PrescriptionNumber {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03 {get; set;}
    [XmlElement(Order=3)]
    public string D_REF04_C040U6005 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_REF_PrescriptionNumber_TS837Q1_2410D_REF01_ReferenceIdentificationQualifier {
        XZ,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class A_TS837Q1_2420 {
    [XmlElementAttribute(Order=0)]
    public G_TS837Q1_2420A G_TS837Q1_2420A {get; set;}
    [XmlElementAttribute(Order=1)]
    public G_TS837Q1_2420B G_TS837Q1_2420B {get; set;}
    [XmlElementAttribute(Order=2)]
    public G_TS837Q1_2420C G_TS837Q1_2420C {get; set;}
    [XmlElementAttribute(Order=3)]
    public G_TS837Q1_2420D G_TS837Q1_2420D {get; set;}
    [XmlElementAttribute(Order=4)]
    public G_TS837Q1_2420E G_TS837Q1_2420E {get; set;}
    [XmlElement(Order=5)]
    public U_TS837Q1_2420F U_TS837Q1_2420F {get; set;}
    [XmlElement(Order=6)]
    public U_TS837Q1_2420G U_TS837Q1_2420G {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_TS837Q1_2420A {
    [XmlElement(Order=0)]
    public S_NM1_RenderingProviderName_TS837Q1_2420A S_NM1_RenderingProviderName_TS837Q1_2420A {get; set;}
    [XmlElement(Order=1)]
    public S_PRV_RenderingProviderSpecialtyInformation_TS837Q1_2420A S_PRV_RenderingProviderSpecialtyInformation_TS837Q1_2420A {get; set;}
    [XmlElement("S_REF_RenderingProviderSecondaryIdentification_TS837Q1_2420A",Order=2)]
    public List<S_REF_RenderingProviderSecondaryIdentification_TS837Q1_2420A> S_REF_RenderingProviderSecondaryIdentification_TS837Q1_2420A {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_NM1_RenderingProviderName_TS837Q1_2420A {
    [XmlElement(Order=0)]
    public S_NM1_RenderingProviderName_TS837Q1_2420AD_NM101_EntityIdentifierCode D_NM101_EntityIdentifierCode {get; set;}
    [XmlElement(Order=1)]
    public S_NM1_RenderingProviderName_TS837Q1_2420AD_NM102_EntityTypeQualifier D_NM102_EntityTypeQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_NM103_RenderingProviderLastOrOrganizationName {get; set;}
    [XmlElement(Order=3)]
    public string D_NM104_RenderingProviderFirstName {get; set;}
    [XmlElement(Order=4)]
    public string D_NM105_RenderingProviderMiddleName {get; set;}
    [XmlElement(Order=5)]
    public string D_NM106 {get; set;}
    [XmlElement(Order=6)]
    public string D_NM107_RenderingProviderNameSuffix {get; set;}
    [XmlElement(Order=7)]
    public string D_NM108_IdentificationCodeQualifier {get; set;}
    [XmlElement(Order=8)]
    public string D_NM109_RenderingProviderIdentifier {get; set;}
    [XmlElement(Order=9)]
    public string D_NM110 {get; set;}
    [XmlElement(Order=10)]
    public string D_NM111 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_NM1_RenderingProviderName_TS837Q1_2420AD_NM101_EntityIdentifierCode {
        [XmlEnum("82")]
        Item82,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_NM1_RenderingProviderName_TS837Q1_2420AD_NM102_EntityTypeQualifier {
        [XmlEnum("1")]
        Item1,
        [XmlEnum("2")]
        Item2,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_PRV_RenderingProviderSpecialtyInformation_TS837Q1_2420A {
    [XmlElement(Order=0)]
    public S_PRV_RenderingProviderSpecialtyInformation_TS837Q1_2420AD_PRV01_ProviderCode D_PRV01_ProviderCode {get; set;}
    [XmlElement(Order=1)]
    public S_PRV_RenderingProviderSpecialtyInformation_TS837Q1_2420AD_PRV02_ReferenceIdentificationQualifier D_PRV02_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_PRV03_ProviderTaxonomyCode {get; set;}
    [XmlElement(Order=3)]
    public string D_PRV04 {get; set;}
    [XmlElement(Order=4)]
    public string D_PRV05_C035U976 {get; set;}
    [XmlElement(Order=5)]
    public string D_PRV06 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_PRV_RenderingProviderSpecialtyInformation_TS837Q1_2420AD_PRV01_ProviderCode {
        PE,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_PRV_RenderingProviderSpecialtyInformation_TS837Q1_2420AD_PRV02_ReferenceIdentificationQualifier {
        ZZ,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_RenderingProviderSecondaryIdentification_TS837Q1_2420A {
    [XmlElement(Order=0)]
    public S_REF_RenderingProviderSecondaryIdentification_TS837Q1_2420AD_REF01_ReferenceIdentificationQualifier D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_RenderingProviderSecondaryIdentifier {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03 {get; set;}
    [XmlElement(Order=3)]
    public string D_REF04_C040U977 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_REF_RenderingProviderSecondaryIdentification_TS837Q1_2420AD_REF01_ReferenceIdentificationQualifier {
        [XmlEnum("0B")]
        Item0B,
        [XmlEnum("1B")]
        Item1B,
        [XmlEnum("1C")]
        Item1C,
        [XmlEnum("1D")]
        Item1D,
        [XmlEnum("1G")]
        Item1G,
        [XmlEnum("1H")]
        Item1H,
        EI,
        G2,
        LU,
        N5,
        SY,
        X5,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_TS837Q1_2420B {
    [XmlElement(Order=0)]
    public S_NM1_PurchasedServiceProviderName_TS837Q1_2420B S_NM1_PurchasedServiceProviderName_TS837Q1_2420B {get; set;}
    [XmlElement("S_REF_PurchasedServiceProviderSecondaryIdentification_TS837Q1_2420B",Order=1)]
    public List<S_REF_PurchasedServiceProviderSecondaryIdentification_TS837Q1_2420B> S_REF_PurchasedServiceProviderSecondaryIdentification_TS837Q1_2420B {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_NM1_PurchasedServiceProviderName_TS837Q1_2420B {
    [XmlElement(Order=0)]
    public S_NM1_PurchasedServiceProviderName_TS837Q1_2420BD_NM101_EntityIdentifierCode D_NM101_EntityIdentifierCode {get; set;}
    [XmlElement(Order=1)]
    public S_NM1_PurchasedServiceProviderName_TS837Q1_2420BD_NM102_EntityTypeQualifier D_NM102_EntityTypeQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_NM103 {get; set;}
    [XmlElement(Order=3)]
    public string D_NM104 {get; set;}
    [XmlElement(Order=4)]
    public string D_NM105 {get; set;}
    [XmlElement(Order=5)]
    public string D_NM106 {get; set;}
    [XmlElement(Order=6)]
    public string D_NM107 {get; set;}
    [XmlElement(Order=7)]
    public string D_NM108_IdentificationCodeQualifier {get; set;}
    [XmlElement(Order=8)]
    public string D_NM109_PurchasedServiceProviderIdentifier {get; set;}
    [XmlElement(Order=9)]
    public string D_NM110 {get; set;}
    [XmlElement(Order=10)]
    public string D_NM111 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_NM1_PurchasedServiceProviderName_TS837Q1_2420BD_NM101_EntityIdentifierCode {
        QB,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_NM1_PurchasedServiceProviderName_TS837Q1_2420BD_NM102_EntityTypeQualifier {
        [XmlEnum("1")]
        Item1,
        [XmlEnum("2")]
        Item2,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_PurchasedServiceProviderSecondaryIdentification_TS837Q1_2420B {
    [XmlElement(Order=0)]
    public S_REF_PurchasedServiceProviderSecondaryIdentification_TS837Q1_2420BD_REF01_ReferenceIdentificationQualifier D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_PurchasedServiceProviderSecondaryIdentifier {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03 {get; set;}
    [XmlElement(Order=3)]
    public string D_REF04_C040U978 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_REF_PurchasedServiceProviderSecondaryIdentification_TS837Q1_2420BD_REF01_ReferenceIdentificationQualifier {
        [XmlEnum("0B")]
        Item0B,
        [XmlEnum("1A")]
        Item1A,
        [XmlEnum("1B")]
        Item1B,
        [XmlEnum("1C")]
        Item1C,
        [XmlEnum("1D")]
        Item1D,
        [XmlEnum("1G")]
        Item1G,
        [XmlEnum("1H")]
        Item1H,
        EI,
        G2,
        LU,
        N5,
        SY,
        U3,
        X5,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_TS837Q1_2420C {
    [XmlElement(Order=0)]
    public S_NM1_ServiceFacilityLocation_TS837Q1_2420C S_NM1_ServiceFacilityLocation_TS837Q1_2420C {get; set;}
    [XmlElement(Order=1)]
    public S_N3_ServiceFacilityLocationAddress_TS837Q1_2420C S_N3_ServiceFacilityLocationAddress_TS837Q1_2420C {get; set;}
    [XmlElement(Order=2)]
    public S_N4_ServiceFacilityLocationCityStateZIP_TS837Q1_2420C S_N4_ServiceFacilityLocationCityStateZIP_TS837Q1_2420C {get; set;}
    [XmlElement("S_REF_ServiceFacilityLocationSecondaryIdentification_TS837Q1_2420C",Order=3)]
    public List<S_REF_ServiceFacilityLocationSecondaryIdentification_TS837Q1_2420C> S_REF_ServiceFacilityLocationSecondaryIdentification_TS837Q1_2420C {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_NM1_ServiceFacilityLocation_TS837Q1_2420C {
    [XmlElement(Order=0)]
    public S_NM1_ServiceFacilityLocation_TS837Q1_2420CD_NM101_EntityIdentifierCode D_NM101_EntityIdentifierCode {get; set;}
    [XmlElement(Order=1)]
    public S_NM1_ServiceFacilityLocation_TS837Q1_2420CD_NM102_EntityTypeQualifier D_NM102_EntityTypeQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_NM103_LaboratoryOrFacilityName {get; set;}
    [XmlElement(Order=3)]
    public string D_NM104 {get; set;}
    [XmlElement(Order=4)]
    public string D_NM105 {get; set;}
    [XmlElement(Order=5)]
    public string D_NM106 {get; set;}
    [XmlElement(Order=6)]
    public string D_NM107 {get; set;}
    [XmlElement(Order=7)]
    public string D_NM108_IdentificationCodeQualifier {get; set;}
    [XmlElement(Order=8)]
    public string D_NM109_LaboratoryOrFacilityPrimaryIdentifier {get; set;}
    [XmlElement(Order=9)]
    public string D_NM110 {get; set;}
    [XmlElement(Order=10)]
    public string D_NM111 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_NM1_ServiceFacilityLocation_TS837Q1_2420CD_NM101_EntityIdentifierCode {
        [XmlEnum("77")]
        Item77,
        FA,
        LI,
        TL,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_NM1_ServiceFacilityLocation_TS837Q1_2420CD_NM102_EntityTypeQualifier {
        [XmlEnum("2")]
        Item2,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_N3_ServiceFacilityLocationAddress_TS837Q1_2420C {
    [XmlElement(Order=0)]
    public string D_N301_LaboratoryOrFacilityAddressLine {get; set;}
    [XmlElement(Order=1)]
    public string D_N302_LaboratoryOrFacilityAddressLine {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_N4_ServiceFacilityLocationCityStateZIP_TS837Q1_2420C {
    [XmlElement(Order=0)]
    public string D_N401_LaboratoryOrFacilityCityName {get; set;}
    [XmlElement(Order=1)]
    public string D_N402_LaboratoryOrFacilityStateOrProvinceCode {get; set;}
    [XmlElement(Order=2)]
    public string D_N403_LaboratoryOrFacilityPostalZoneOrZIPCode {get; set;}
    [XmlElement(Order=3)]
    public string D_N404_CountryCode {get; set;}
    [XmlElement(Order=4)]
    public string D_N405 {get; set;}
    [XmlElement(Order=5)]
    public string D_N406 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_ServiceFacilityLocationSecondaryIdentification_TS837Q1_2420C {
    [XmlElement(Order=0)]
    public S_REF_ServiceFacilityLocationSecondaryIdentification_TS837Q1_2420CD_REF01_ReferenceIdentificationQualifier D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_ServiceFacilityLocationSecondaryIdentifier {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03 {get; set;}
    [XmlElement(Order=3)]
    public string D_REF04_C040U979 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_REF_ServiceFacilityLocationSecondaryIdentification_TS837Q1_2420CD_REF01_ReferenceIdentificationQualifier {
        [XmlEnum("0B")]
        Item0B,
        [XmlEnum("1A")]
        Item1A,
        [XmlEnum("1B")]
        Item1B,
        [XmlEnum("1C")]
        Item1C,
        [XmlEnum("1D")]
        Item1D,
        [XmlEnum("1G")]
        Item1G,
        [XmlEnum("1H")]
        Item1H,
        G2,
        LU,
        N5,
        TJ,
        X4,
        X5,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_TS837Q1_2420D {
    [XmlElement(Order=0)]
    public S_NM1_SupervisingProviderName_TS837Q1_2420D S_NM1_SupervisingProviderName_TS837Q1_2420D {get; set;}
    [XmlElement("S_REF_SupervisingProviderSecondaryIdentification_TS837Q1_2420D",Order=1)]
    public List<S_REF_SupervisingProviderSecondaryIdentification_TS837Q1_2420D> S_REF_SupervisingProviderSecondaryIdentification_TS837Q1_2420D {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_NM1_SupervisingProviderName_TS837Q1_2420D {
    [XmlElement(Order=0)]
    public S_NM1_SupervisingProviderName_TS837Q1_2420DD_NM101_EntityIdentifierCode D_NM101_EntityIdentifierCode {get; set;}
    [XmlElement(Order=1)]
    public S_NM1_SupervisingProviderName_TS837Q1_2420DD_NM102_EntityTypeQualifier D_NM102_EntityTypeQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_NM103_SupervisingProviderLastName {get; set;}
    [XmlElement(Order=3)]
    public string D_NM104_SupervisingProviderFirstName {get; set;}
    [XmlElement(Order=4)]
    public string D_NM105_SupervisingProviderMiddleName {get; set;}
    [XmlElement(Order=5)]
    public string D_NM106 {get; set;}
    [XmlElement(Order=6)]
    public string D_NM107_SupervisingProviderNameSuffix {get; set;}
    [XmlElement(Order=7)]
    public string D_NM108_IdentificationCodeQualifier {get; set;}
    [XmlElement(Order=8)]
    public string D_NM109_SupervisingProviderIdentifier {get; set;}
    [XmlElement(Order=9)]
    public string D_NM110 {get; set;}
    [XmlElement(Order=10)]
    public string D_NM111 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_NM1_SupervisingProviderName_TS837Q1_2420DD_NM101_EntityIdentifierCode {
        DQ,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_NM1_SupervisingProviderName_TS837Q1_2420DD_NM102_EntityTypeQualifier {
        [XmlEnum("1")]
        Item1,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_SupervisingProviderSecondaryIdentification_TS837Q1_2420D {
    [XmlElement(Order=0)]
    public S_REF_SupervisingProviderSecondaryIdentification_TS837Q1_2420DD_REF01_ReferenceIdentificationQualifier D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_SupervisingProviderSecondaryIdentifier {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03 {get; set;}
    [XmlElement(Order=3)]
    public string D_REF04_C040U980 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_REF_SupervisingProviderSecondaryIdentification_TS837Q1_2420DD_REF01_ReferenceIdentificationQualifier {
        [XmlEnum("0B")]
        Item0B,
        [XmlEnum("1B")]
        Item1B,
        [XmlEnum("1C")]
        Item1C,
        [XmlEnum("1D")]
        Item1D,
        [XmlEnum("1G")]
        Item1G,
        [XmlEnum("1H")]
        Item1H,
        EI,
        G2,
        LU,
        N5,
        SY,
        X5,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_TS837Q1_2420E {
    [XmlElement(Order=0)]
    public S_NM1_OrderingProviderName_TS837Q1_2420E S_NM1_OrderingProviderName_TS837Q1_2420E {get; set;}
    [XmlElement(Order=1)]
    public S_N3_OrderingProviderAddress_TS837Q1_2420E S_N3_OrderingProviderAddress_TS837Q1_2420E {get; set;}
    [XmlElement(Order=2)]
    public S_N4_OrderingProviderCityStateZIPCode_TS837Q1_2420E S_N4_OrderingProviderCityStateZIPCode_TS837Q1_2420E {get; set;}
    [XmlElement("S_REF_OrderingProviderSecondaryIdentification_TS837Q1_2420E",Order=3)]
    public List<S_REF_OrderingProviderSecondaryIdentification_TS837Q1_2420E> S_REF_OrderingProviderSecondaryIdentification_TS837Q1_2420E {get; set;}
    [XmlElement(Order=4)]
    public S_PER_OrderingProviderContactInformation_TS837Q1_2420E S_PER_OrderingProviderContactInformation_TS837Q1_2420E {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_NM1_OrderingProviderName_TS837Q1_2420E {
    [XmlElement(Order=0)]
    public S_NM1_OrderingProviderName_TS837Q1_2420ED_NM101_EntityIdentifierCode D_NM101_EntityIdentifierCode {get; set;}
    [XmlElement(Order=1)]
    public S_NM1_OrderingProviderName_TS837Q1_2420ED_NM102_EntityTypeQualifier D_NM102_EntityTypeQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_NM103_OrderingProviderLastName {get; set;}
    [XmlElement(Order=3)]
    public string D_NM104_OrderingProviderFirstName {get; set;}
    [XmlElement(Order=4)]
    public string D_NM105_OrderingProviderMiddleName {get; set;}
    [XmlElement(Order=5)]
    public string D_NM106 {get; set;}
    [XmlElement(Order=6)]
    public string D_NM107_OrderingProviderNameSuffix {get; set;}
    [XmlElement(Order=7)]
    public string D_NM108_IdentificationCodeQualifier {get; set;}
    [XmlElement(Order=8)]
    public string D_NM109_OrderingProviderIdentifier {get; set;}
    [XmlElement(Order=9)]
    public string D_NM110 {get; set;}
    [XmlElement(Order=10)]
    public string D_NM111 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_NM1_OrderingProviderName_TS837Q1_2420ED_NM101_EntityIdentifierCode {
        DK,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_NM1_OrderingProviderName_TS837Q1_2420ED_NM102_EntityTypeQualifier {
        [XmlEnum("1")]
        Item1,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_N3_OrderingProviderAddress_TS837Q1_2420E {
    [XmlElement(Order=0)]
    public string D_N301_OrderingProviderAddressLine {get; set;}
    [XmlElement(Order=1)]
    public string D_N302_OrderingProviderAddressLine {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_N4_OrderingProviderCityStateZIPCode_TS837Q1_2420E {
    [XmlElement(Order=0)]
    public string D_N401_OrderingProviderCityName {get; set;}
    [XmlElement(Order=1)]
    public string D_N402_OrderingProviderStateCode {get; set;}
    [XmlElement(Order=2)]
    public string D_N403_OrderingProviderPostalZoneOrZIPCode {get; set;}
    [XmlElement(Order=3)]
    public string D_N404_CountryCode {get; set;}
    [XmlElement(Order=4)]
    public string D_N405 {get; set;}
    [XmlElement(Order=5)]
    public string D_N406 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_OrderingProviderSecondaryIdentification_TS837Q1_2420E {
    [XmlElement(Order=0)]
    public S_REF_OrderingProviderSecondaryIdentification_TS837Q1_2420ED_REF01_ReferenceIdentificationQualifier D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_OrderingProviderSecondaryIdentifier {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03 {get; set;}
    [XmlElement(Order=3)]
    public string D_REF04_C040U981 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_REF_OrderingProviderSecondaryIdentification_TS837Q1_2420ED_REF01_ReferenceIdentificationQualifier {
        [XmlEnum("0B")]
        Item0B,
        [XmlEnum("1B")]
        Item1B,
        [XmlEnum("1C")]
        Item1C,
        [XmlEnum("1D")]
        Item1D,
        [XmlEnum("1G")]
        Item1G,
        [XmlEnum("1H")]
        Item1H,
        EI,
        G2,
        LU,
        N5,
        SY,
        X5,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_PER_OrderingProviderContactInformation_TS837Q1_2420E {
    [XmlElement(Order=0)]
    public S_PER_OrderingProviderContactInformation_TS837Q1_2420ED_PER01_ContactFunctionCode D_PER01_ContactFunctionCode {get; set;}
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
    public string D_PER09 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_PER_OrderingProviderContactInformation_TS837Q1_2420ED_PER01_ContactFunctionCode {
        IC,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_TS837Q1_2420F {
    [XmlElement(Order=0)]
    public S_NM1_ReferringProviderName_TS837Q1_2420F S_NM1_ReferringProviderName_TS837Q1_2420F {get; set;}
    [XmlElement(Order=1)]
    public S_PRV_ReferringProviderSpecialtyInformation_TS837Q1_2420F S_PRV_ReferringProviderSpecialtyInformation_TS837Q1_2420F {get; set;}
    [XmlElement("S_REF_ReferringProviderSecondaryIdentification_TS837Q1_2420F",Order=2)]
    public List<S_REF_ReferringProviderSecondaryIdentification_TS837Q1_2420F> S_REF_ReferringProviderSecondaryIdentification_TS837Q1_2420F {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_NM1_ReferringProviderName_TS837Q1_2420F {
    [XmlElement(Order=0)]
    public S_NM1_ReferringProviderName_TS837Q1_2420FD_NM101_EntityIdentifierCode D_NM101_EntityIdentifierCode {get; set;}
    [XmlElement(Order=1)]
    public S_NM1_ReferringProviderName_TS837Q1_2420FD_NM102_EntityTypeQualifier D_NM102_EntityTypeQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_NM103_ReferringProviderLastName {get; set;}
    [XmlElement(Order=3)]
    public string D_NM104_ReferringProviderFirstName {get; set;}
    [XmlElement(Order=4)]
    public string D_NM105_ReferringProviderMiddleName {get; set;}
    [XmlElement(Order=5)]
    public string D_NM106 {get; set;}
    [XmlElement(Order=6)]
    public string D_NM107_ReferringProviderNameSuffix {get; set;}
    [XmlElement(Order=7)]
    public string D_NM108_IdentificationCodeQualifier {get; set;}
    [XmlElement(Order=8)]
    public string D_NM109_ReferringProviderIdentifier {get; set;}
    [XmlElement(Order=9)]
    public string D_NM110 {get; set;}
    [XmlElement(Order=10)]
    public string D_NM111 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_NM1_ReferringProviderName_TS837Q1_2420FD_NM101_EntityIdentifierCode {
        DN,
        P3,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_NM1_ReferringProviderName_TS837Q1_2420FD_NM102_EntityTypeQualifier {
        [XmlEnum("1")]
        Item1,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_PRV_ReferringProviderSpecialtyInformation_TS837Q1_2420F {
    [XmlElement(Order=0)]
    public S_PRV_ReferringProviderSpecialtyInformation_TS837Q1_2420FD_PRV01_ProviderCode D_PRV01_ProviderCode {get; set;}
    [XmlElement(Order=1)]
    public S_PRV_ReferringProviderSpecialtyInformation_TS837Q1_2420FD_PRV02_ReferenceIdentificationQualifier D_PRV02_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_PRV03_ProviderTaxonomyCode {get; set;}
    [XmlElement(Order=3)]
    public string D_PRV04 {get; set;}
    [XmlElement(Order=4)]
    public string D_PRV05_C035U982 {get; set;}
    [XmlElement(Order=5)]
    public string D_PRV06 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_PRV_ReferringProviderSpecialtyInformation_TS837Q1_2420FD_PRV01_ProviderCode {
        RF,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_PRV_ReferringProviderSpecialtyInformation_TS837Q1_2420FD_PRV02_ReferenceIdentificationQualifier {
        ZZ,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_ReferringProviderSecondaryIdentification_TS837Q1_2420F {
    [XmlElement(Order=0)]
    public S_REF_ReferringProviderSecondaryIdentification_TS837Q1_2420FD_REF01_ReferenceIdentificationQualifier D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_ReferringProviderSecondaryIdentifier {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03 {get; set;}
    [XmlElement(Order=3)]
    public string D_REF04_C040U983 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_REF_ReferringProviderSecondaryIdentification_TS837Q1_2420FD_REF01_ReferenceIdentificationQualifier {
        [XmlEnum("0B")]
        Item0B,
        [XmlEnum("1B")]
        Item1B,
        [XmlEnum("1C")]
        Item1C,
        [XmlEnum("1D")]
        Item1D,
        [XmlEnum("1G")]
        Item1G,
        [XmlEnum("1H")]
        Item1H,
        EI,
        G2,
        LU,
        N5,
        SY,
        X5,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_TS837Q1_2420G {
    [XmlElement(Order=0)]
    public S_NM1_OtherPayerPriorAuthorizationOrReferralNumber_TS837Q1_2420G S_NM1_OtherPayerPriorAuthorizationOrReferralNumber_TS837Q1_2420G {get; set;}
    [XmlElement("S_REF_OtherPayerPriorAuthorizationOrReferralNumber_TS837Q1_2420G",Order=1)]
    public List<S_REF_OtherPayerPriorAuthorizationOrReferralNumber_TS837Q1_2420G> S_REF_OtherPayerPriorAuthorizationOrReferralNumber_TS837Q1_2420G {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_NM1_OtherPayerPriorAuthorizationOrReferralNumber_TS837Q1_2420G {
    [XmlElement(Order=0)]
    public S_NM1_OtherPayerPriorAuthorizationOrReferralNumber_TS837Q1_2420GD_NM101_EntityIdentifierCode D_NM101_EntityIdentifierCode {get; set;}
    [XmlElement(Order=1)]
    public S_NM1_OtherPayerPriorAuthorizationOrReferralNumber_TS837Q1_2420GD_NM102_EntityTypeQualifier D_NM102_EntityTypeQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_NM103_PayerName {get; set;}
    [XmlElement(Order=3)]
    public string D_NM104 {get; set;}
    [XmlElement(Order=4)]
    public string D_NM105 {get; set;}
    [XmlElement(Order=5)]
    public string D_NM106 {get; set;}
    [XmlElement(Order=6)]
    public string D_NM107 {get; set;}
    [XmlElement(Order=7)]
    public string D_NM108_IdentificationCodeQualifier {get; set;}
    [XmlElement(Order=8)]
    public string D_NM109_OtherPayerIdentificationNumber {get; set;}
    [XmlElement(Order=9)]
    public string D_NM110 {get; set;}
    [XmlElement(Order=10)]
    public string D_NM111 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_NM1_OtherPayerPriorAuthorizationOrReferralNumber_TS837Q1_2420GD_NM101_EntityIdentifierCode {
        PR,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_NM1_OtherPayerPriorAuthorizationOrReferralNumber_TS837Q1_2420GD_NM102_EntityTypeQualifier {
        [XmlEnum("2")]
        Item2,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_OtherPayerPriorAuthorizationOrReferralNumber_TS837Q1_2420G {
    [XmlElement(Order=0)]
    public S_REF_OtherPayerPriorAuthorizationOrReferralNumber_TS837Q1_2420GD_REF01_ReferenceIdentificationQualifier D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_OtherPayerPriorAuthorizationOrReferralNumber {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03 {get; set;}
    [XmlElement(Order=3)]
    public string D_REF04_C040U984 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_REF_OtherPayerPriorAuthorizationOrReferralNumber_TS837Q1_2420GD_REF01_ReferenceIdentificationQualifier {
        [XmlEnum("9F")]
        Item9F,
        G1,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_TS837Q1_2430 {
    [XmlElement(Order=0)]
    public S_SVD_LineAdjudicationInformation_TS837Q1_2430 S_SVD_LineAdjudicationInformation_TS837Q1_2430 {get; set;}
    [XmlElement("S_CAS_LineAdjustment_TS837Q1_2430",Order=1)]
    public List<S_CAS_LineAdjustment_TS837Q1_2430> S_CAS_LineAdjustment_TS837Q1_2430 {get; set;}
    [XmlElement(Order=2)]
    public S_DTP_LineAdjudicationDate_TS837Q1_2430 S_DTP_LineAdjudicationDate_TS837Q1_2430 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_SVD_LineAdjudicationInformation_TS837Q1_2430 {
    [XmlElement(Order=0)]
    public string D_SVD01_OtherPayerPrimaryIdentifier {get; set;}
    [XmlElement(Order=1)]
    public string D_SVD02_ServiceLinePaidAmount {get; set;}
    [XmlElement(Order=2)]
    public C_SVD03_C003U985_TS837Q1_2430 C_SVD03_C003U985_TS837Q1_2430 {get; set;}
    [XmlElement(Order=3)]
    public string D_SVD04 {get; set;}
    [XmlElement(Order=4)]
    public string D_SVD05_PaidServiceUnitCount {get; set;}
    [XmlElement(Order=5)]
    public string D_SVD06_BundledOrUnbundledLineNumber {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class C_SVD03_C003U985_TS837Q1_2430 {
    [XmlElement(Order=0)]
    public string D_SVD03_C00301U986_ProductOrServiceIDQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_SVD03_C00302U987_ProcedureCode {get; set;}
    [XmlElement(Order=2)]
    public string D_SVD03_C00303U988_ProcedureModifier {get; set;}
    [XmlElement(Order=3)]
    public string D_SVD03_C00304U989_ProcedureModifier {get; set;}
    [XmlElement(Order=4)]
    public string D_SVD03_C00305U990_ProcedureModifier {get; set;}
    [XmlElement(Order=5)]
    public string D_SVD03_C00306U991_ProcedureModifier {get; set;}
    [XmlElement(Order=6)]
    public string D_SVD03_C00307U992_ProcedureCodeDescription {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_CAS_LineAdjustment_TS837Q1_2430 {
    [XmlElement(Order=0)]
    public S_CAS_LineAdjustment_TS837Q1_2430D_CAS01_ClaimAdjustmentGroupCode D_CAS01_ClaimAdjustmentGroupCode {get; set;}
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
    public enum S_CAS_LineAdjustment_TS837Q1_2430D_CAS01_ClaimAdjustmentGroupCode {
        CO,
        CR,
        OA,
        PI,
        PR,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_DTP_LineAdjudicationDate_TS837Q1_2430 {
    [XmlElement(Order=0)]
    public S_DTP_LineAdjudicationDate_TS837Q1_2430D_DTP01_DateTimeQualifier D_DTP01_DateTimeQualifier {get; set;}
    [XmlElement(Order=1)]
    public S_DTP_LineAdjudicationDate_TS837Q1_2430D_DTP02_DateTimePeriodFormatQualifier D_DTP02_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_DTP03_AdjudicationOrPaymentDate {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_DTP_LineAdjudicationDate_TS837Q1_2430D_DTP01_DateTimeQualifier {
        [XmlEnum("573")]
        Item573,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_DTP_LineAdjudicationDate_TS837Q1_2430D_DTP02_DateTimePeriodFormatQualifier {
        D8,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_TS837Q1_2440 {
    [XmlElement(Order=0)]
    public S_LQ_FormIdentificationCode_TS837Q1_2440 S_LQ_FormIdentificationCode_TS837Q1_2440 {get; set;}
    [XmlElement("S_FRM_SupportingDocumentation_TS837Q1_2440",Order=1)]
    public List<S_FRM_SupportingDocumentation_TS837Q1_2440> S_FRM_SupportingDocumentation_TS837Q1_2440 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_LQ_FormIdentificationCode_TS837Q1_2440 {
    [XmlElement(Order=0)]
    public S_LQ_FormIdentificationCode_TS837Q1_2440D_LQ01_CodeListQualifierCode D_LQ01_CodeListQualifierCode {get; set;}
    [XmlElement(Order=1)]
    public string D_LQ02_FormIdentifier {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_LQ_FormIdentificationCode_TS837Q1_2440D_LQ01_CodeListQualifierCode {
        AS,
        UT,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_FRM_SupportingDocumentation_TS837Q1_2440 {
    [XmlElement(Order=0)]
    public string D_FRM01_QuestionNumberLetter {get; set;}
    [XmlElement(Order=1)]
    public S_FRM_SupportingDocumentation_TS837Q1_2440D_FRM02_QuestionResponse D_FRM02_QuestionResponse {get; set;}
    [XmlIgnore]
    [XmlElementAttribute(Order=2)]
    public bool D_FRM02_QuestionResponseSpecified {get; set;}
    [XmlElement(Order=2)]
    public string D_FRM03_QuestionResponse {get; set;}
    [XmlElement(Order=3)]
    public string D_FRM04_QuestionResponse {get; set;}
    [XmlElement(Order=4)]
    public string D_FRM05_QuestionResponse {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_FRM_SupportingDocumentation_TS837Q1_2440D_FRM02_QuestionResponse {
        N,
        W,
        Y,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_TS837Q1_2000C {
    [XmlElement(Order=0)]
    public S_HL_PatientHierarchicalLevel_TS837Q1_2000C S_HL_PatientHierarchicalLevel_TS837Q1_2000C {get; set;}
    [XmlElement(Order=1)]
    public S_PAT_PatientInformation_TS837Q1_2000C S_PAT_PatientInformation_TS837Q1_2000C {get; set;}
    [XmlElement(Order=2)]
    public G_TS837Q1_2010CA G_TS837Q1_2010CA {get; set;}
    [XmlElement("G_TS837Q1_2300",Order=3)]
    public List<G_TS837Q1_2300> G_TS837Q1_2300 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_HL_PatientHierarchicalLevel_TS837Q1_2000C {
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
    public class S_PAT_PatientInformation_TS837Q1_2000C {
    [XmlElement(Order=0)]
    public S_PAT_PatientInformation_TS837Q1_2000CD_PAT01_IndividualRelationshipCode D_PAT01_IndividualRelationshipCode {get; set;}
    [XmlElement(Order=1)]
    public string D_PAT02 {get; set;}
    [XmlElement(Order=2)]
    public string D_PAT03 {get; set;}
    [XmlElement(Order=3)]
    public string D_PAT04 {get; set;}
    [XmlElement(Order=4)]
    public string D_PAT05_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=5)]
    public string D_PAT06_PatientDeathDate {get; set;}
    [XmlElement(Order=6)]
    public string D_PAT07_UnitOrBasisForMeasurementCode {get; set;}
    [XmlElement(Order=7)]
    public string D_PAT08_PatientWeight {get; set;}
    [XmlElement(Order=8)]
    public string D_PAT09_PregnancyIndicator {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_PAT_PatientInformation_TS837Q1_2000CD_PAT01_IndividualRelationshipCode {
        [XmlEnum("01")]
        Item01,
        [XmlEnum("04")]
        Item04,
        [XmlEnum("05")]
        Item05,
        [XmlEnum("07")]
        Item07,
        [XmlEnum("09")]
        Item09,
        [XmlEnum("10")]
        Item10,
        [XmlEnum("15")]
        Item15,
        [XmlEnum("17")]
        Item17,
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
        [XmlEnum("29")]
        Item29,
        [XmlEnum("32")]
        Item32,
        [XmlEnum("33")]
        Item33,
        [XmlEnum("34")]
        Item34,
        [XmlEnum("36")]
        Item36,
        [XmlEnum("39")]
        Item39,
        [XmlEnum("40")]
        Item40,
        [XmlEnum("41")]
        Item41,
        [XmlEnum("43")]
        Item43,
        [XmlEnum("53")]
        Item53,
        G8,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class G_TS837Q1_2010CA {
    [XmlElement(Order=0)]
    public S_NM1_PatientName_TS837Q1_2010CA S_NM1_PatientName_TS837Q1_2010CA {get; set;}
    [XmlElement(Order=1)]
    public S_N3_PatientAddress_TS837Q1_2010CA S_N3_PatientAddress_TS837Q1_2010CA {get; set;}
    [XmlElement(Order=2)]
    public S_N4_PatientCityStateZIPCode_TS837Q1_2010CA S_N4_PatientCityStateZIPCode_TS837Q1_2010CA {get; set;}
    [XmlElement(Order=3)]
    public S_DMG_PatientDemographicInformation_TS837Q1_2010CA S_DMG_PatientDemographicInformation_TS837Q1_2010CA {get; set;}
    [XmlElement(Order=4)]
    public A_REF_TS837Q1_2010CA A_REF_TS837Q1_2010CA {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_NM1_PatientName_TS837Q1_2010CA {
    [XmlElement(Order=0)]
    public S_NM1_PatientName_TS837Q1_2010CAD_NM101_EntityIdentifierCode D_NM101_EntityIdentifierCode {get; set;}
    [XmlElement(Order=1)]
    public S_NM1_PatientName_TS837Q1_2010CAD_NM102_EntityTypeQualifier D_NM102_EntityTypeQualifier {get; set;}
    [XmlElement(Order=2)]
    public string D_NM103_PatientLastName {get; set;}
    [XmlElement(Order=3)]
    public string D_NM104_PatientFirstName {get; set;}
    [XmlElement(Order=4)]
    public string D_NM105_PatientMiddleName {get; set;}
    [XmlElement(Order=5)]
    public string D_NM106 {get; set;}
    [XmlElement(Order=6)]
    public string D_NM107_PatientNameSuffix {get; set;}
    [XmlElement(Order=7)]
    public string D_NM108_IdentificationCodeQualifier {get; set;}
    [XmlElement(Order=8)]
    public string D_NM109_PatientPrimaryIdentifier {get; set;}
    [XmlElement(Order=9)]
    public string D_NM110 {get; set;}
    [XmlElement(Order=10)]
    public string D_NM111 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_NM1_PatientName_TS837Q1_2010CAD_NM101_EntityIdentifierCode {
        QC,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_NM1_PatientName_TS837Q1_2010CAD_NM102_EntityTypeQualifier {
        [XmlEnum("1")]
        Item1,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_N3_PatientAddress_TS837Q1_2010CA {
    [XmlElement(Order=0)]
    public string D_N301_PatientAddressLine {get; set;}
    [XmlElement(Order=1)]
    public string D_N302_PatientAddressLine {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_N4_PatientCityStateZIPCode_TS837Q1_2010CA {
    [XmlElement(Order=0)]
    public string D_N401_PatientCityName {get; set;}
    [XmlElement(Order=1)]
    public string D_N402_PatientStateCode {get; set;}
    [XmlElement(Order=2)]
    public string D_N403_PatientPostalZoneOrZIPCode {get; set;}
    [XmlElement(Order=3)]
    public string D_N404_CountryCode {get; set;}
    [XmlElement(Order=4)]
    public string D_N405 {get; set;}
    [XmlElement(Order=5)]
    public string D_N406 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_DMG_PatientDemographicInformation_TS837Q1_2010CA {
    [XmlElement(Order=0)]
    public S_DMG_PatientDemographicInformation_TS837Q1_2010CAD_DMG01_DateTimePeriodFormatQualifier D_DMG01_DateTimePeriodFormatQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_DMG02_PatientBirthDate {get; set;}
    [XmlElement(Order=2)]
    public string D_DMG03_PatientGenderCode {get; set;}
    [XmlElement(Order=3)]
    public string D_DMG04 {get; set;}
    [XmlElement(Order=4)]
    public string D_DMG05 {get; set;}
    [XmlElement(Order=5)]
    public string D_DMG06 {get; set;}
    [XmlElement(Order=6)]
    public string D_DMG07 {get; set;}
    [XmlElement(Order=7)]
    public string D_DMG08 {get; set;}
    [XmlElement(Order=8)]
    public string D_DMG09 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_DMG_PatientDemographicInformation_TS837Q1_2010CAD_DMG01_DateTimePeriodFormatQualifier {
        D8,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class A_REF_TS837Q1_2010CA {
    [XmlElement(Order=0)]
    public U_REF_PatientSecondaryIdentification_TS837Q1_2010CA U_REF_PatientSecondaryIdentification_TS837Q1_2010CA {get; set;}
    [XmlElementAttribute(Order=1)]
    public S_REF_PropertyAndCasualtyClaimNumber_TS837Q1_2010CA S_REF_PropertyAndCasualtyClaimNumber_TS837Q1_2010CA {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_PatientSecondaryIdentification_TS837Q1_2010CA {
    [XmlElement(Order=0)]
    public S_REF_PatientSecondaryIdentification_TS837Q1_2010CAD_REF01_ReferenceIdentificationQualifier D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_PatientSecondaryIdentifier {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03 {get; set;}
    [XmlElement(Order=3)]
    public string D_REF04_C040U835 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_REF_PatientSecondaryIdentification_TS837Q1_2010CAD_REF01_ReferenceIdentificationQualifier {
        [XmlEnum("1W")]
        Item1W,
        [XmlEnum("23")]
        Item23,
        IG,
        SY,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_REF_PropertyAndCasualtyClaimNumber_TS837Q1_2010CA {
    [XmlElement(Order=0)]
    public S_REF_PropertyAndCasualtyClaimNumber_TS837Q1_2010CAD_REF01_ReferenceIdentificationQualifier D_REF01_ReferenceIdentificationQualifier {get; set;}
    [XmlElement(Order=1)]
    public string D_REF02_PropertyCasualtyClaimNumber {get; set;}
    [XmlElement(Order=2)]
    public string D_REF03 {get; set;}
    [XmlElement(Order=3)]
    public string D_REF04_C040U836 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    public enum S_REF_PropertyAndCasualtyClaimNumber_TS837Q1_2010CAD_REF01_ReferenceIdentificationQualifier {
        Y4,
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class S_SE {
    [XmlElement(Order=0)]
    public string D_SE01 {get; set;}
    [XmlElement(Order=1)]
    public string D_SE02 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class U_REF_BillingProviderSecondaryIdentification_TS837Q1_2010AA {
    [XmlElement("S_REF_BillingProviderSecondaryIdentification_TS837Q1_2010AA",Order=0)]
    public List<S_REF_BillingProviderSecondaryIdentification_TS837Q1_2010AA> S_REF_BillingProviderSecondaryIdentification_TS837Q1_2010AA {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class U_REF_CreditDebitCardBillingInformation_TS837Q1_2010AA {
    [XmlElement("S_REF_CreditDebitCardBillingInformation_TS837Q1_2010AA",Order=0)]
    public List<S_REF_CreditDebitCardBillingInformation_TS837Q1_2010AA> S_REF_CreditDebitCardBillingInformation_TS837Q1_2010AA {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class U_REF_SubscriberSecondaryIdentification_TS837Q1_2010BA {
    [XmlElement("S_REF_SubscriberSecondaryIdentification_TS837Q1_2010BA",Order=0)]
    public List<S_REF_SubscriberSecondaryIdentification_TS837Q1_2010BA> S_REF_SubscriberSecondaryIdentification_TS837Q1_2010BA {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class U_DTP_DateAcuteManifestation_TS837Q1_2300 {
    [XmlElement("S_DTP_DateAcuteManifestation_TS837Q1_2300",Order=0)]
    public List<S_DTP_DateAcuteManifestation_TS837Q1_2300> S_DTP_DateAcuteManifestation_TS837Q1_2300 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class U_DTP_DateSimilarIllnessSymptomOnset_TS837Q1_2300 {
    [XmlElement("S_DTP_DateSimilarIllnessSymptomOnset_TS837Q1_2300",Order=0)]
    public List<S_DTP_DateSimilarIllnessSymptomOnset_TS837Q1_2300> S_DTP_DateSimilarIllnessSymptomOnset_TS837Q1_2300 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class U_DTP_DateAccident_TS837Q1_2300 {
    [XmlElement("S_DTP_DateAccident_TS837Q1_2300",Order=0)]
    public List<S_DTP_DateAccident_TS837Q1_2300> S_DTP_DateAccident_TS837Q1_2300 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class U_DTP_DateDisabilityBegin_TS837Q1_2300 {
    [XmlElement("S_DTP_DateDisabilityBegin_TS837Q1_2300",Order=0)]
    public List<S_DTP_DateDisabilityBegin_TS837Q1_2300> S_DTP_DateDisabilityBegin_TS837Q1_2300 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class U_DTP_DateDisabilityEnd_TS837Q1_2300 {
    [XmlElement("S_DTP_DateDisabilityEnd_TS837Q1_2300",Order=0)]
    public List<S_DTP_DateDisabilityEnd_TS837Q1_2300> S_DTP_DateDisabilityEnd_TS837Q1_2300 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class U_DTP_DateAssumedAndRelinquishedCareDates_TS837Q1_2300 {
    [XmlElement("S_DTP_DateAssumedAndRelinquishedCareDates_TS837Q1_2300",Order=0)]
    public List<S_DTP_DateAssumedAndRelinquishedCareDates_TS837Q1_2300> S_DTP_DateAssumedAndRelinquishedCareDates_TS837Q1_2300 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class U_REF_PriorAuthorizationOrReferralNumber_TS837Q1_2300 {
    [XmlElement("S_REF_PriorAuthorizationOrReferralNumber_TS837Q1_2300",Order=0)]
    public List<S_REF_PriorAuthorizationOrReferralNumber_TS837Q1_2300> S_REF_PriorAuthorizationOrReferralNumber_TS837Q1_2300 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class U_REF_ClinicalLaboratoryImprovementAmendmentCLIANumber_TS837Q1_2300 {
    [XmlElement("S_REF_ClinicalLaboratoryImprovementAmendmentCLIANumber_TS837Q1_2300",Order=0)]
    public List<S_REF_ClinicalLaboratoryImprovementAmendmentCLIANumber_TS837Q1_2300> S_REF_ClinicalLaboratoryImprovementAmendmentCLIANumber_TS837Q1_2300 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class U_REF_AmbulatoryPatientGroupAPG_TS837Q1_2300 {
    [XmlElement("S_REF_AmbulatoryPatientGroupAPG_TS837Q1_2300",Order=0)]
    public List<S_REF_AmbulatoryPatientGroupAPG_TS837Q1_2300> S_REF_AmbulatoryPatientGroupAPG_TS837Q1_2300 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class U_CRC_AmbulanceCertification_TS837Q1_2300 {
    [XmlElement("S_CRC_AmbulanceCertification_TS837Q1_2300",Order=0)]
    public List<S_CRC_AmbulanceCertification_TS837Q1_2300> S_CRC_AmbulanceCertification_TS837Q1_2300 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class U_CRC_PatientConditionInformationVision_TS837Q1_2300 {
    [XmlElement("S_CRC_PatientConditionInformationVision_TS837Q1_2300",Order=0)]
    public List<S_CRC_PatientConditionInformationVision_TS837Q1_2300> S_CRC_PatientConditionInformationVision_TS837Q1_2300 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class U_TS837Q1_2310A {
    [XmlElement("G_TS837Q1_2310A",Order=0)]
    public List<G_TS837Q1_2310A> G_TS837Q1_2310A {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class U_REF_OtherPayerSecondaryIdentifier_TS837Q1_2330B {
    [XmlElement("S_REF_OtherPayerSecondaryIdentifier_TS837Q1_2330B",Order=0)]
    public List<S_REF_OtherPayerSecondaryIdentifier_TS837Q1_2330B> S_REF_OtherPayerSecondaryIdentifier_TS837Q1_2330B {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class U_REF_OtherPayerPriorAuthorizationOrReferralNumber_TS837Q1_2330B {
    [XmlElement("S_REF_OtherPayerPriorAuthorizationOrReferralNumber_TS837Q1_2330B",Order=0)]
    public List<S_REF_OtherPayerPriorAuthorizationOrReferralNumber_TS837Q1_2330B> S_REF_OtherPayerPriorAuthorizationOrReferralNumber_TS837Q1_2330B {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class U_REF_OtherPayerClaimAdjustmentIndicator_TS837Q1_2330B {
    [XmlElement("S_REF_OtherPayerClaimAdjustmentIndicator_TS837Q1_2330B",Order=0)]
    public List<S_REF_OtherPayerClaimAdjustmentIndicator_TS837Q1_2330B> S_REF_OtherPayerClaimAdjustmentIndicator_TS837Q1_2330B {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class U_TS837Q1_2330D {
    [XmlElement("G_TS837Q1_2330D",Order=0)]
    public List<G_TS837Q1_2330D> G_TS837Q1_2330D {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class U_CRC_AmbulanceCertification_TS837Q1_2400 {
    [XmlElement("S_CRC_AmbulanceCertification_TS837Q1_2400",Order=0)]
    public List<S_CRC_AmbulanceCertification_TS837Q1_2400> S_CRC_AmbulanceCertification_TS837Q1_2400 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class U_CRC_DMERCConditionIndicator_TS837Q1_2400 {
    [XmlElement("S_CRC_DMERCConditionIndicator_TS837Q1_2400",Order=0)]
    public List<S_CRC_DMERCConditionIndicator_TS837Q1_2400> S_CRC_DMERCConditionIndicator_TS837Q1_2400 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class U_DTP_DateTest_TS837Q1_2400 {
    [XmlElement("S_DTP_DateTest_TS837Q1_2400",Order=0)]
    public List<S_DTP_DateTest_TS837Q1_2400> S_DTP_DateTest_TS837Q1_2400 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class U_DTP_DateOxygenSaturationArterialBloodGasTest_TS837Q1_2400 {
    [XmlElement("S_DTP_DateOxygenSaturationArterialBloodGasTest_TS837Q1_2400",Order=0)]
    public List<S_DTP_DateOxygenSaturationArterialBloodGasTest_TS837Q1_2400> S_DTP_DateOxygenSaturationArterialBloodGasTest_TS837Q1_2400 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class U_REF_PriorAuthorizationOrReferralNumber_TS837Q1_2400 {
    [XmlElement("S_REF_PriorAuthorizationOrReferralNumber_TS837Q1_2400",Order=0)]
    public List<S_REF_PriorAuthorizationOrReferralNumber_TS837Q1_2400> S_REF_PriorAuthorizationOrReferralNumber_TS837Q1_2400 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class U_REF_AmbulatoryPatientGroupAPG_TS837Q1_2400 {
    [XmlElement("S_REF_AmbulatoryPatientGroupAPG_TS837Q1_2400",Order=0)]
    public List<S_REF_AmbulatoryPatientGroupAPG_TS837Q1_2400> S_REF_AmbulatoryPatientGroupAPG_TS837Q1_2400 {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class U_TS837Q1_2420F {
    [XmlElement("G_TS837Q1_2420F",Order=0)]
    public List<G_TS837Q1_2420F> G_TS837Q1_2420F {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class U_TS837Q1_2420G {
    [XmlElement("G_TS837Q1_2420G",Order=0)]
    public List<G_TS837Q1_2420G> G_TS837Q1_2420G {get; set;}
    }
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="www.edifabric.com/x12")]
    [XmlRoot(Namespace="www.edifabric.com/x12", IsNullable=false)]
    public class U_REF_PatientSecondaryIdentification_TS837Q1_2010CA {
    [XmlElement("S_REF_PatientSecondaryIdentification_TS837Q1_2010CA",Order=0)]
    public List<S_REF_PatientSecondaryIdentification_TS837Q1_2010CA> S_REF_PatientSecondaryIdentification_TS837Q1_2010CA {get; set;}
    }
}
