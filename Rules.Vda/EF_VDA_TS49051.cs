using System;
using System.Collections.Generic;
using EdiFabric.Core.Annotations.Edi;
using EdiFabric.Core.Annotations.Validation;
using EdiFabric.Core.Model.Edi;

namespace EdiFabric.Rules.Vda
{
    [Serializable()]
    [Message("VDA", "1", "4905")]
    public class TS4905 : EdiMessage
    {
        [Required]
        [Pos(1)]
        public S511 S511 { get; set; }

        [Required]
        [Pos(2)]
        public List<TS4905_S512Loop> S512Loop { get; set; }

        [Required]
        [Pos(3)]
        public S519 S519 { get; set; }        
    }
    
    [Serializable()]
    [Group("512")]
    public class TS4905_S512Loop
    {
        
        [Required]
        [Pos(1)]
        public S512 S512 { get; set; }

        [Required]
        [Pos(2)]
        public S513 S513 { get; set; }

        [Pos(3)]
        public List<S514> S514 { get; set; }

        [Pos(4)]
        public S515 S515 { get; set; }

        [Pos(5)]
        public List<S517> S517 { get; set; }
        
        [ListCount(5)]
        [Pos(6)]
        public List<S518> S518 { get; set; }
        
    }

    [Serializable()]
    [Segment("511", typeof(VDA_ID_V2))]
    public class S511
    {
        [Required]
        [StringLength(3, 3)]
        [DataElement("511_01", typeof(VDA_ID_511_01))]
        [Pos(1)]
        public string RecordType_01 { get; set; }

        [Required]
        [StringLength(2, 2)]
        [DataElement("511_02", typeof(VDA_ID_V2))]
        [Pos(2)]
        public string Version_02 { get; set; }

        [Required]
        [StringLength(9, 9)]
        [DataElement("511_03", typeof(VDA_AN))]
        [Pos(3)]
        public string CustomerCode_03 { get; set; }

        [Required]
        [StringLength(9, 9)]
        [DataElement("511_04", typeof(VDA_AN))]
        [Pos(4)]
        public string SupplierCode_04 { get; set; }

        [Required]
        [StringLength(5, 5)]
        [DataElement("511_05", typeof(VDA_N0))]
        [Pos(5)]
        public string TransmissionNumberOld_05 { get; set; }

        [Required]
        [StringLength(5, 5)]
        [DataElement("511_06", typeof(VDA_N0))]
        [Pos(6)]
        public string TransmissionNumberNew_06 { get; set; }

        [Required]
        [StringLength(6, 6)]
        [DataElement("511_07", typeof(VDA_DT))]
        [Pos(7)]
        public string TransmissionDate_07 { get; set; }

        [StringLength(6, 6)]
        [DataElement("511_08", typeof(VDA_DT))]
        [Pos(8)]
        public string StartingDate_08 { get; set; }

        [Required]
        [StringLength(83, 83)]
        [DataElement("511_09", typeof(VDA_AN))]
        [Pos(9)]
        public string Blanks_09 { get; set; }
    }

    [Serializable()]
    [Segment("512", typeof(VDA_ID_V1))]
    public class S512
    {
        [Required]
        [StringLength(3, 3)]
        [DataElement("512_01", typeof(VDA_ID_512_01))]
        [Pos(1)]
        public string RecordType_01 { get; set; }

        [Required]
        [StringLength(2, 2)]
        [DataElement("512_02", typeof(VDA_ID_V1))]
        [Pos(2)]
        public string Version_02 { get; set; }

        [Required]
        [StringLength(3, 3)]
        [DataElement("512_03", typeof(VDA_AN))]
        [Pos(3)]
        public string CustomerPlantCode_03 { get; set; }

        [Required]
        [StringLength(9, 9)]
        [DataElement("512_04", typeof(VDA_N0))]
        [Pos(4)]
        public string DeliveryCallOffNumberNew_04 { get; set; }

        [Required]
        [StringLength(6, 6)]
        [DataElement("512_05", typeof(VDA_DT))]
        [Pos(5)]
        public string DeliveryCallOffDateNew_05 { get; set; }

        [Required]
        [StringLength(9, 9)]
        [DataElement("512_06", typeof(VDA_N0))]
        [Pos(6)]
        public string DeliveryCallOffNumberOld_06 { get; set; }

        [Required]
        [StringLength(6, 6)]
        [DataElement("512_07", typeof(VDA_DT))]
        [Pos(7)]
        public string DeliveryCallOffDateOld_07 { get; set; }

        [Required]
        [StringLength(22, 22)]
        [DataElement("512_08", typeof(VDA_AN))]
        [Pos(8)]
        public string ArticleCodeCustomer_08 { get; set; }

        [StringLength(22, 22)]
        [DataElement("512_09", typeof(VDA_AN))]
        [Pos(9)]
        public string ArticleCodeSupplier_09 { get; set; }

        [StringLength(12, 12)]
        [DataElement("512_10", typeof(VDA_N0))]
        [Pos(10)]
        public string OrderNumber_10 { get; set; }

        [Required]
        [StringLength(5, 5)]
        [DataElement("512_11", typeof(VDA_AN))]
        [Pos(11)]
        public string DockGate_11 { get; set; }

        [Required]
        [StringLength(4, 4)]
        [DataElement("512_12", typeof(VDA_AN))]
        [Pos(12)]
        public string CustomerClerkIdentifier_12 { get; set; }

        [Required]
        [StringLength(2, 2)]
        [DataElement("512_13", typeof(VDA_AN))]
        [Pos(13)]
        public string QuantityUnitOfMeasure_13 { get; set; }

        [Required]
        [StringLength(1, 1)]
        [DataElement("512_14", typeof(VDA_AN))]
        [Pos(14)]
        public string DeliveryFrequency_14 { get; set; }

        [StringLength(1, 1)]
        [DataElement("512_15", typeof(VDA_N0))]
        [Pos(15)]
        public string ManufacturingRelease_15 { get; set; }

        [StringLength(1, 1)]
        [DataElement("512_16", typeof(VDA_N0))]
        [Pos(16)]
        public string MaterialRelease_16 { get; set; }

        [Required]
        [StringLength(1, 1)]
        [DataElement("512_17", typeof(VDA_AN))]
        [Pos(17)]
        public string RequirementCode_17 { get; set; }

        [StringLength(7, 7)]
        [DataElement("512_18", typeof(VDA_AN))]
        [Pos(18)]
        public string AccountKey_18 { get; set; }

        [StringLength(7, 7)]
        [DataElement("512_19", typeof(VDA_AN))]
        [Pos(19)]
        public string StockLocation_19 { get; set; }

        [Required]
        [StringLength(5, 5)]
        [DataElement("512_20", typeof(VDA_AN))]
        [Pos(20)]
        public string Blanks_20 { get; set; }
    }

    [Serializable()]
    [Segment("513", typeof(VDA_ID_V1))]
    public class S513
    {
        [Required]
        [StringLength(3, 3)]
        [DataElement("513_01", typeof(VDA_ID_513_01))]
        [Pos(1)]
        public string RecordType_01 { get; set; }

        [Required]
        [StringLength(2, 2)]
        [DataElement("513_02", typeof(VDA_ID_V1))]
        [Pos(2)]
        public string Version_02 { get; set; }

        [Required]
        [StringLength(6, 6)]
        [DataElement("513_03", typeof(VDA_DT))]
        [Pos(3)]
        public string DateOfLastRecordedReceipt_03 { get; set; }

        [Required]
        [StringLength(8, 8)]
        [DataElement("513_04", typeof(VDA_N0))]
        [Pos(4)]
        public string LastRecordedDeliveryNoteNumber_04 { get; set; }

        [Required]
        [StringLength(6, 6)]
        [DataElement("513_05", typeof(VDA_DT))]
        [Pos(5)]
        public string DateOfLastRecordedReceipt_05 { get; set; }

        [Required]
        [StringLength(12, 12)]
        [DataElement("513_06", typeof(VDA_N0))]
        [Pos(6)]
        public string QuantityLastRecordedReceipt_06 { get; set; }

        [Required]
        [StringLength(10, 10)]
        [DataElement("513_07", typeof(VDA_N0))]
        [Pos(7)]
        public string CommulativeFigureReceipt_07 { get; set; }

        [Required]
        [StringLength(6, 6)]
        [DataElement("513_08", typeof(VDA_DT))]
        [Pos(8)]
        public string CallOffDate1_08 { get; set; }

        [StringLength(9, 9)]
        [DataElement("513_09", typeof(VDA_N0))]
        [Pos(9)]
        public string CallOffQuantity1_09 { get; set; }

        [Required]
        [StringLength(6, 6)]
        [DataElement("513_10", typeof(VDA_DT))]
        [Pos(10)]
        public string CallOffDate2_10 { get; set; }

        [StringLength(9, 9)]
        [DataElement("513_11", typeof(VDA_N0))]
        [Pos(11)]
        public string CallOffQuantity2_11 { get; set; }

        [Required]
        [StringLength(6, 6)]
        [DataElement("513_12", typeof(VDA_DT))]
        [Pos(12)]
        public string CallOffDate3_12 { get; set; }

        [StringLength(9, 9)]
        [DataElement("513_13", typeof(VDA_N0))]
        [Pos(13)]
        public string CallOffQuantity3_13 { get; set; }

        [Required]
        [StringLength(6, 6)]
        [DataElement("513_14", typeof(VDA_DT))]
        [Pos(14)]
        public string CallOffDate4_14 { get; set; }

        [StringLength(9, 9)]
        [DataElement("513_15", typeof(VDA_N0))]
        [Pos(15)]
        public string CallOffQuantity4_15 { get; set; }

        [Required]
        [StringLength(6, 6)]
        [DataElement("513_16", typeof(VDA_DT))]
        [Pos(16)]
        public string CallOffDate5_16 { get; set; }

        [StringLength(9, 9)]
        [DataElement("513_17", typeof(VDA_N0))]
        [Pos(17)]
        public string CallOffQuantity5_17 { get; set; }

        [Required]
        [StringLength(6, 6)]
        [DataElement("513_18", typeof(VDA_AN))]
        [Pos(18)]
        public string Blanks_18 { get; set; }
    }

    [Serializable()]
    [Segment("514", typeof(VDA_ID_V1))]
    public class S514
    {
        [Required]
        [StringLength(3, 3)]
        [DataElement("514_01", typeof(VDA_ID_514_01))]
        [Pos(1)]
        public string RecordType_01 { get; set; }

        [Required]
        [StringLength(2, 2)]
        [DataElement("514_02", typeof(VDA_ID_V1))]
        [Pos(2)]
        public string Version_02 { get; set; }

        [Required]
        [StringLength(6, 6)]
        [DataElement("514_03", typeof(VDA_DT))]
        [Pos(3)]
        public string CallOffDate6_03 { get; set; }

        [Required]
        [StringLength(9, 9)]
        [DataElement("514_04", typeof(VDA_N0))]
        [Pos(4)]
        public string CallOffQuantity6_04 { get; set; }

        [StringLength(6, 6)]
        [DataElement("514_05", typeof(VDA_DT))]
        [Pos(5)]
        public string CallOffDate7_05 { get; set; }

        [StringLength(9, 9)]
        [DataElement("514_06", typeof(VDA_N0))]
        [Pos(6)]
        public string CallOffQuantity7_06 { get; set; }

        [StringLength(6, 6)]
        [DataElement("514_07", typeof(VDA_DT))]
        [Pos(7)]
        public string CallOffDate8_07 { get; set; }

        [StringLength(9, 9)]
        [DataElement("514_08", typeof(VDA_N0))]
        [Pos(8)]
        public string CallOffQuantity8_08 { get; set; }

        [StringLength(6, 6)]
        [DataElement("514_09", typeof(VDA_DT))]
        [Pos(9)]
        public string CallOffDate9_09 { get; set; }

        [StringLength(9, 9)]
        [DataElement("514_10", typeof(VDA_N0))]
        [Pos(10)]
        public string CallOffQuantity9_10 { get; set; }

        [StringLength(6, 6)]
        [DataElement("514_11", typeof(VDA_DT))]
        [Pos(11)]
        public string CallOffDate10_11 { get; set; }

        [StringLength(9, 9)]
        [DataElement("514_12", typeof(VDA_N0))]
        [Pos(12)]
        public string CallOffQuantity10_12 { get; set; }

        [StringLength(6, 6)]
        [DataElement("514_13", typeof(VDA_DT))]
        [Pos(13)]
        public string CallOffDate11_13 { get; set; }

        [StringLength(9, 9)]
        [DataElement("514_14", typeof(VDA_N0))]
        [Pos(14)]
        public string CallOffQuantity11_14 { get; set; }

        [StringLength(6, 6)]
        [DataElement("514_15", typeof(VDA_DT))]
        [Pos(15)]
        public string CallOffDate12_15 { get; set; }

        [StringLength(9, 9)]
        [DataElement("514_16", typeof(VDA_N0))]
        [Pos(16)]
        public string CallOffQuantity12_16 { get; set; }

        [StringLength(6, 6)]
        [DataElement("514_17", typeof(VDA_DT))]
        [Pos(17)]
        public string CallOffDate13_17 { get; set; }

        [StringLength(9, 9)]
        [DataElement("514_18", typeof(VDA_N0))]
        [Pos(18)]
        public string CallOffQuantity13_18 { get; set; }

        [Required]
        [StringLength(3, 3)]
        [DataElement("514_19", typeof(VDA_AN))]
        [Pos(19)]
        public string Blanks_19 { get; set; }
    }

    [Serializable()]
    [Segment("515", typeof(VDA_ID_V1))]
    public class S515
    {
        [Required]
        [StringLength(3, 3)]
        [DataElement("515_01", typeof(VDA_ID_515_01))]
        [Pos(1)]
        public string RecordType_01 { get; set; }

        [Required]
        [StringLength(2, 2)]
        [DataElement("515_02", typeof(VDA_ID_V1))]
        [Pos(2)]
        public string Version_02 { get; set; }

        [StringLength(6, 6)]
        [DataElement("515_03", typeof(VDA_DT))]
        [Pos(3)]
        public string ManufacturingReleaseStartDate_03 { get; set; }

        [StringLength(6, 6)]
        [DataElement("515_04", typeof(VDA_DT))]
        [Pos(4)]
        public string ManufacturingReleaseFinalDate_04 { get; set; }

        [StringLength(10, 10)]
        [DataElement("515_05", typeof(VDA_N0))]
        [Pos(5)]
        public string ManufacturingReleaseCumulatedRequirements_05 { get; set; }

        [StringLength(6, 6)]
        [DataElement("515_06", typeof(VDA_DT))]
        [Pos(6)]
        public string MaterialReleaseStartDate_06 { get; set; }

        [StringLength(6, 6)]
        [DataElement("515_07", typeof(VDA_DT))]
        [Pos(7)]
        public string MaterialReleaseFinalDate_07 { get; set; }

        [StringLength(10, 10)]
        [DataElement("515_08", typeof(VDA_N0))]
        [Pos(8)]
        public string MaterialReleaseCumulatedRequirements_08 { get; set; }

        [StringLength(22, 22)]
        [DataElement("515_09", typeof(VDA_AN))]
        [Pos(9)]
        public string CompletingArticleCode_09 { get; set; }

        [StringLength(9, 9)]
        [DataElement("515_10", typeof(VDA_AN))]
        [Pos(10)]
        public string ImmediateSupplier_10 { get; set; }

        [StringLength(6, 6)]
        [DataElement("515_11", typeof(VDA_DT))]
        [Pos(11)]
        public string DatePlanningHorizon_11 { get; set; }

        [StringLength(14, 14)]
        [DataElement("515_12", typeof(VDA_AN))]
        [Pos(12)]
        public string PointOfConsumption_12 { get; set; }

        [StringLength(10, 10)]
        [DataElement("515_13", typeof(VDA_N0))]
        [Pos(13)]
        public string CumulativeFigure_13 { get; set; }

        [StringLength(18, 18)]
        [DataElement("515_14", typeof(VDA_AN))]
        [Pos(14)]
        public string Blanks_14 { get; set; }
    }

    [Serializable()]
    [Segment("517", typeof(VDA_ID_V1))]
    public class S517
    {
        [Required]
        [StringLength(3, 3)]
        [DataElement("517_01", typeof(VDA_ID_517_01))]
        [Pos(1)]
        public string RecordType_01 { get; set; }

        [Required]
        [StringLength(2, 2)]
        [DataElement("517_02", typeof(VDA_ID_V1))]
        [Pos(2)]
        public string Version_02 { get; set; }

        [Required]
        [StringLength(22, 22)]
        [DataElement("517_03", typeof(VDA_AN))]
        [Pos(3)]
        public string PackagingCodeCustomer_03 { get; set; }

        [StringLength(22, 22)]
        [DataElement("517_04", typeof(VDA_AN))]
        [Pos(4)]
        public string PackagingCodeSupplier_04 { get; set; }

        [Required]
        [StringLength(7, 7)]
        [DataElement("517_05", typeof(VDA_N0))]
        [Pos(5)]
        public string CapacityPerPackagingType_05 { get; set; }

        [StringLength(72, 72)]
        [DataElement("517_06", typeof(VDA_AN))]
        [Pos(6)]
        public string Blanks_06 { get; set; }
    }

    [Serializable()]
    [Segment("518", typeof(VDA_ID_V1))]
    public class S518
    {
        [Required]
        [StringLength(3, 3)]
        [DataElement("518_01", typeof(VDA_ID_518_01))]
        [Pos(1)]
        public string RecordType_01 { get; set; }

        [Required]
        [StringLength(2, 2)]
        [DataElement("518_02", typeof(VDA_ID_V1))]
        [Pos(2)]
        public string Version_02 { get; set; }

        [Required]
        [StringLength(40, 40)]
        [DataElement("518_03", typeof(VDA_AN))]
        [Pos(3)]
        public string DeliveryInstructionText1_03 { get; set; }

        [StringLength(40, 40)]
        [DataElement("518_04", typeof(VDA_AN))]
        [Pos(4)]
        public string DeliveryInstructionText2_04 { get; set; }

        [StringLength(40, 40)]
        [DataElement("518_05", typeof(VDA_AN))]
        [Pos(5)]
        public string DeliveryInstructionText3_05 { get; set; }

        [StringLength(3, 3)]
        [DataElement("518_06", typeof(VDA_AN))]
        [Pos(6)]
        public string Blanks_06 { get; set; }
    }

    [Serializable()]
    [Segment("519", typeof(VDA_ID_V1))]
    public class S519
    {
        [Required]
        [StringLength(3, 3)]
        [DataElement("519_01", typeof(VDA_ID_519_01))]
        [Pos(1)]
        public string RecordType_01 { get; set; }

        [Required]
        [StringLength(2, 2)]
        [DataElement("519_02", typeof(VDA_ID_V1))]
        [Pos(2)]
        public string Version_02 { get; set; }

        [Required]
        [StringLength(7, 7)]
        [DataElement("519_03", typeof(VDA_N0))]
        [Pos(3)]
        public string CounterRecordType511_03 { get; set; }

        [Required]
        [StringLength(7, 7)]
        [DataElement("519_04", typeof(VDA_N0))]
        [Pos(4)]
        public string CounterRecordType512_04 { get; set; }

        [Required]
        [StringLength(7, 7)]
        [DataElement("519_05", typeof(VDA_N0))]
        [Pos(5)]
        public string CounterRecordType513_05 { get; set; }

        [Required]
        [StringLength(7, 7)]
        [DataElement("519_06", typeof(VDA_N0))]
        [Pos(6)]
        public string CounterRecordType514_06 { get; set; }

        [Required]
        [StringLength(7, 7)]
        [DataElement("519_07", typeof(VDA_N0))]
        [Pos(7)]
        public string CounterRecordType517_07 { get; set; }

        [Required]
        [StringLength(7, 7)]
        [DataElement("519_08", typeof(VDA_N0))]
        [Pos(8)]
        public string CounterRecordType518_08 { get; set; }

        [Required]
        [StringLength(7, 7)]
        [DataElement("519_09", typeof(VDA_N0))]
        [Pos(9)]
        public string CounterRecordType519_09 { get; set; }

        [Required]
        [StringLength(7, 7)]
        [DataElement("519_10", typeof(VDA_N0))]
        [Pos(10)]
        public string CounterRecordType515_10 { get; set; }

        [Required]
        [StringLength(67, 67)]
        [DataElement("519_11", typeof(VDA_AN))]
        [Pos(11)]
        public string Blanks_11 { get; set; }
    }
}
