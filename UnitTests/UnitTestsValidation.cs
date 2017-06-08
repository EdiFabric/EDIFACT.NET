using System;
using System.Collections.Generic;
using System.Linq;
using EdiFabric.Core.ErrorCodes;
using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.ErrorContexts;
using EdiFabric.Core.Model.Edi.X12;
using EdiFabric.Framework.Readers;
using EdiFabric.Rules.EDIFACT_D00A.Rep;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EdiFabric.UnitTests
{
    /// <summary>
    /// Summary description for UnitTestsValidation
    /// </summary>
    [TestClass]
    public class UnitTestsValidation
    {

        [TestMethod]
        public void TestValidationRequiredMissing()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.Edi.Edifact_INVOIC_D00A_Val_RequiredMissing.txt";
            var ediStream = CommonHelper.LoadStream(sample, false);
            List<EdiItem> ediItems;

            // ACT
            using (var ediReader = new EdifactReader(ediStream, "EdiFabric.Rules.EdifactD00A.Rep"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }
            var msg = ediItems.OfType<TSINVOICAll>().Single();

            MessageErrorContext result;
            var validationResult = msg.IsValid(out result);

            // ASSERT
            Assert.IsFalse(validationResult);
            Assert.IsTrue(result.Errors.Any());
            Assert.IsTrue(result.Errors.Count == 6);

            var sErr1 = result.Errors.SingleOrDefault(r => r.Name == "UNH" && r.Position == 1);
            Assert.IsNotNull(sErr1);
            Assert.IsTrue(sErr1.Codes.Count == 0);
            Assert.IsTrue(sErr1.Errors.Count == 1);
            var dErr1 = sErr1.Errors.First();
            Assert.IsTrue(dErr1.Name == "0051");
            Assert.IsTrue(dErr1.Position == 2);
            Assert.IsTrue(dErr1.ComponentPosition == 4);
            Assert.IsTrue(dErr1.RepetitionPosition == 0);
            Assert.IsTrue(dErr1.Value == null);
            Assert.IsTrue(dErr1.Code == DataElementErrorCode.RequiredDataElementMissing);

            var sErr2 = result.Errors.SingleOrDefault(r => r.Name == "PCD" && r.Position == 14);
            Assert.IsNotNull(sErr2);
            Assert.IsTrue(sErr2.Codes.Count == 0);
            Assert.IsTrue(sErr2.Errors.Count == 1);
            var dErr2 = sErr2.Errors.First();
            Assert.IsTrue(dErr2.Name == "C501");
            Assert.IsTrue(dErr2.Position == 1);
            Assert.IsTrue(dErr2.ComponentPosition == 0);
            Assert.IsTrue(dErr2.RepetitionPosition == 0);
            Assert.IsTrue(dErr2.Value == null);
            Assert.IsTrue(dErr2.Code == DataElementErrorCode.RequiredDataElementMissing);

            var sErr3 = result.Errors.SingleOrDefault(r => r.Name == "UNS" && r.Position == 32);
            Assert.IsNotNull(sErr3);
            Assert.IsTrue(sErr3.Codes.Count == 1);
            Assert.IsTrue(sErr3.Errors.Count == 0);
            Assert.IsTrue(sErr3.Codes.Contains(SegmentErrorCode.RequiredSegmentMissing));

            var sErr4 = result.Errors.SingleOrDefault(r => r.Name == "MOA" && r.Position == 32);
            Assert.IsNotNull(sErr4);
            Assert.IsTrue(sErr4.Codes.Count == 1);
            Assert.IsTrue(sErr4.Errors.Count == 0);
            Assert.IsTrue(sErr4.Codes.Contains(SegmentErrorCode.RequiredSegmentMissing));

            var sErr5 = result.Errors.SingleOrDefault(r => r.Name == "PAI" && r.Position == 4);
            Assert.IsNotNull(sErr5);
            Assert.IsTrue(sErr5.Codes.Count == 1);
            Assert.IsTrue(sErr5.Errors.Count == 0);
            Assert.IsTrue(sErr5.Codes.Contains(SegmentErrorCode.RequiredSegmentMissing));

            var sErr6 = result.Errors.SingleOrDefault(r => r.Name == "UNT" && r.Position == 4);
            Assert.IsNotNull(sErr6);
            Assert.IsTrue(sErr6.Codes.Count == 1);
            Assert.IsTrue(sErr6.Errors.Count == 0);
            Assert.IsTrue(sErr6.Codes.Contains(SegmentErrorCode.RequiredSegmentMissing));
        }

        [TestMethod]
        public void TestValidationListCountMax()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.Edi.Edifact_INVOIC_D00A_Val_ListCountMax.txt";
            var ediStream = CommonHelper.LoadStream(sample, false);
            List<EdiItem> ediItems;

            // ACT
            using (var ediReader = new EdifactReader(ediStream, "EdiFabric.Rules.EdifactD00A.Rep"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }
            var msg = ediItems.OfType<TSINVOIC>().Single();

            MessageErrorContext result;
            var validationResult = msg.IsValid(out result);

            // ASSERT
            Assert.IsFalse(validationResult);
            Assert.IsTrue(result.Errors.Any());
            Assert.IsTrue(result.Errors.Count == 4);

            var sErr1 = result.Errors.SingleOrDefault(r => r.Name == "BGM" && r.Position == 2);
            Assert.IsNotNull(sErr1);
            Assert.IsTrue(sErr1.Codes.Count == 0);
            Assert.IsTrue(sErr1.Errors.Count == 1);
            var dErr1 = sErr1.Errors.First();
            Assert.IsTrue(dErr1.Name == "1225");
            Assert.IsTrue(dErr1.Position == 3);
            Assert.IsTrue(dErr1.ComponentPosition == 0);
            Assert.IsTrue(dErr1.RepetitionPosition == 4);
            Assert.IsTrue(dErr1.Value == "AC");
            Assert.IsTrue(dErr1.Code == DataElementErrorCode.TooManyRepetitions);

            var sErr2 = result.Errors.SingleOrDefault(r => r.Name == "COM" && r.Position == 15);
            Assert.IsNotNull(sErr2);
            Assert.IsTrue(sErr2.Codes.Count == 0);
            Assert.IsTrue(sErr2.Errors.Count == 1);
            var dErr2 = sErr2.Errors.First();
            Assert.IsTrue(dErr2.Name == "C076");
            Assert.IsTrue(dErr2.Position == 1);
            Assert.IsTrue(dErr2.ComponentPosition == 0);
            Assert.IsTrue(dErr2.RepetitionPosition == 4);
            Assert.IsTrue(dErr2.Value == null);
            Assert.IsTrue(dErr2.Code == DataElementErrorCode.TooManyRepetitions);

            var sErr3 = result.Errors.SingleOrDefault(r => r.Name == "ALI" && r.Position == 10);
            Assert.IsNotNull(sErr3);
            Assert.IsTrue(sErr3.Codes.Count == 1);
            Assert.IsTrue(sErr3.Errors.Count == 0);
            Assert.IsTrue(sErr3.Codes.Contains(SegmentErrorCode.SegmentExceedsMaximumUse));

            var sErr4 = result.Errors.SingleOrDefault(r => r.Name == "TAX" && r.Position == 25);
            Assert.IsNotNull(sErr4);
            Assert.IsTrue(sErr4.Codes.Count == 1);
            Assert.IsTrue(sErr4.Errors.Count == 0);
            Assert.IsTrue(sErr4.Codes.Contains(SegmentErrorCode.LoopExceedsMaximumUse));
        }

        [TestMethod]
        public void TestValidationListCountMin()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.Edi.Edifact_INVOIC_D00A_Val_ListCountMin.txt";
            var ediStream = CommonHelper.LoadStream(sample, false);
            List<EdiItem> ediItems;

            // ACT
            using (var ediReader = new EdifactReader(ediStream, "EdiFabric.Rules.EdifactD00A.Rep"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }
            var msg = ediItems.OfType<TSINVOIC>().Single();

            MessageErrorContext result;
            var validationResult = msg.IsValid(out result);

            // ASSERT
            Assert.IsFalse(validationResult);
            Assert.IsTrue(result.Errors.Any());
            Assert.IsTrue(result.Errors.Count == 4);

            var sErr1 = result.Errors.SingleOrDefault(r => r.Name == "BGM" && r.Position == 2);
            Assert.IsNotNull(sErr1);
            Assert.IsTrue(sErr1.Codes.Count == 0);
            Assert.IsTrue(sErr1.Errors.Count == 1);
            var dErr1 = sErr1.Errors.First();
            Assert.IsTrue(dErr1.Name == "1225");
            Assert.IsTrue(dErr1.Position == 3);
            Assert.IsTrue(dErr1.ComponentPosition == 0);
            Assert.IsTrue(dErr1.RepetitionPosition == 2);
            Assert.IsTrue(dErr1.Value == null);
            Assert.IsTrue(dErr1.Code == DataElementErrorCode.TooFewRepetitions);

            var sErr2 = result.Errors.SingleOrDefault(r => r.Name == "COM" && r.Position == 10);
            Assert.IsNotNull(sErr2);
            Assert.IsTrue(sErr2.Codes.Count == 0);
            Assert.IsTrue(sErr2.Errors.Count == 1);
            var dErr2 = sErr2.Errors.First();
            Assert.IsTrue(dErr2.Name == "C076");
            Assert.IsTrue(dErr2.Position == 1);
            Assert.IsTrue(dErr2.ComponentPosition == 0);
            Assert.IsTrue(dErr2.RepetitionPosition == 2);
            Assert.IsTrue(dErr2.Value == null);
            Assert.IsTrue(dErr2.Code == DataElementErrorCode.TooFewRepetitions);

            var sErr3 = result.Errors.SingleOrDefault(r => r.Name == "ALI" && r.Position == 6);
            Assert.IsNotNull(sErr3);
            Assert.IsTrue(sErr3.Codes.Count == 1);
            Assert.IsTrue(sErr3.Errors.Count == 0);
            Assert.IsTrue(sErr3.Codes.Contains(SegmentErrorCode.SegmentBelowMinimumUse));

            var sErr4 = result.Errors.SingleOrDefault(r => r.Name == "TAX" && r.Position == 16);
            Assert.IsNotNull(sErr4);
            Assert.IsTrue(sErr4.Codes.Count == 1);
            Assert.IsTrue(sErr4.Errors.Count == 0);
            Assert.IsTrue(sErr4.Codes.Contains(SegmentErrorCode.LoopBelowMinimumUse));
        }

        [TestMethod]
        public void TestValidationInvalidAttributes()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.Edi.Edifact_INVOIC_D00A_Val_InvalidAttributes.txt";
            var ediStream = CommonHelper.LoadStream(sample, false);
            List<EdiItem> ediItems;

            // ACT
            using (var ediReader = new EdifactReader(ediStream, "EdiFabric.Rules.EdifactD00A.Rep"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }
            var msg = ediItems.OfType<TSINVOICInvalidAttributes>().Single();

            MessageErrorContext result;
            msg.IsValid(out result, true);
            
            // ASSERT
            Assert.IsFalse(result.HasErrors);
        }

        [TestMethod]
        public void TestValidationStringLen()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.Edi.Edifact_INVOIC_D00A_Val_StringLen.txt";
            var ediStream = CommonHelper.LoadStream(sample, false);
            List<EdiItem> ediItems;

            // ACT
            using (var ediReader = new EdifactReader(ediStream, "EdiFabric.Rules.EdifactD00A.Rep"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }
            var msg = ediItems.OfType<TSINVOIC>().Single();

            MessageErrorContext result;
            var validationResult = msg.IsValid(out result);

            // ASSERT
            Assert.IsFalse(validationResult);
            Assert.IsTrue(result.Errors.Any());
            Assert.IsTrue(result.Errors.Count == 3);

            var sErr1 = result.Errors.SingleOrDefault(r => r.Name == "UNH" && r.Position == 1);
            Assert.IsNotNull(sErr1);
            Assert.IsTrue(sErr1.Codes.Count == 0);
            Assert.IsTrue(sErr1.Errors.Count == 1);
            var dErr1 = sErr1.Errors.First();
            Assert.IsTrue(dErr1.Name == "0062");
            Assert.IsTrue(dErr1.Position == 1);
            Assert.IsTrue(dErr1.ComponentPosition == 0);
            Assert.IsTrue(dErr1.RepetitionPosition == 0);
            Assert.IsTrue(dErr1.Value == "5");
            Assert.IsTrue(dErr1.Code == DataElementErrorCode.DataElementTooShort);

            var sErr2 = result.Errors.SingleOrDefault(r => r.Name == "BGM" && r.Position == 2);
            Assert.IsNotNull(sErr2);
            Assert.IsTrue(sErr2.Codes.Count == 0);
            Assert.IsTrue(sErr2.Errors.Count == 2);
            var dErr2 = sErr2.Errors.First();
            Assert.IsTrue(dErr2.Name == "1225");
            Assert.IsTrue(dErr2.Position == 3);
            Assert.IsTrue(dErr2.ComponentPosition == 0);
            Assert.IsTrue(dErr2.RepetitionPosition == 1);
            Assert.IsTrue(dErr2.Value == "B");
            Assert.IsTrue(dErr2.Code == DataElementErrorCode.DataElementTooShort);
            var dErr3 = sErr2.Errors.Last();
            Assert.IsTrue(dErr3.Name == "1225");
            Assert.IsTrue(dErr3.Position == 3);
            Assert.IsTrue(dErr3.ComponentPosition == 0);
            Assert.IsTrue(dErr3.RepetitionPosition == 2);
            Assert.IsTrue(dErr3.Value == "CDEF");
            Assert.IsTrue(dErr3.Code == DataElementErrorCode.DataElementTooLong);

            var sErr4 = result.Errors.SingleOrDefault(r => r.Name == "MOA" && r.Position == 16);
            Assert.IsNotNull(sErr4);
            Assert.IsTrue(sErr4.Codes.Count == 0);
            Assert.IsTrue(sErr4.Errors.Count == 1);
            var dErr4 = sErr4.Errors.First();
            Assert.IsTrue(dErr4.Name == "6345");
            Assert.IsTrue(dErr4.Position == 1);
            Assert.IsTrue(dErr4.ComponentPosition == 3);
            Assert.IsTrue(dErr4.RepetitionPosition == 0);
            Assert.IsTrue(dErr4.Value == "BCDE");
            Assert.IsTrue(dErr4.Code == DataElementErrorCode.DataElementTooLong);
        }

        [TestMethod]
        public void TestValidationNoAttributes()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.Edi.Edifact_INVOIC_D00A_Val_NoAttributes.txt";
            var ediStream = CommonHelper.LoadStream(sample, false);
            List<EdiItem> ediItems;

            // ACT
            using (var ediReader = new EdifactReader(ediStream, "EdiFabric.Rules.EdifactD00A.Rep"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }
            var msg = ediItems.OfType<TSINVOICNoAttributes>().Single();

            MessageErrorContext result;
            msg.IsValid(out result, true);

            // ASSERT
            Assert.IsFalse(result.HasErrors);
        }

        [TestMethod]
        public void TestValidationInvalidCode()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.Edi.Edifact_INVOIC_D00A_Val_InvalidCode.txt";
            var ediStream = CommonHelper.LoadStream(sample, false);
            List<EdiItem> ediItems;

            // ACT
            using (var ediReader = new EdifactReader(ediStream, "EdiFabric.Rules.EdifactD00A.Rep"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }
            var msg = ediItems.OfType<TSINVOIC>().Single();

            MessageErrorContext result;
            var validationResult = msg.IsValid(out result);

            // ASSERT
            Assert.IsFalse(validationResult);
            Assert.IsTrue(result.Errors.Any());
            Assert.IsTrue(result.Errors.Count == 1);

            var sErr1 = result.Errors.SingleOrDefault(r => r.Name == "CTA" && r.Position == 8);
            Assert.IsNotNull(sErr1);
            Assert.IsTrue(sErr1.Codes.Count == 0);
            Assert.IsTrue(sErr1.Errors.Count == 1);
            var dErr1 = sErr1.Errors.First();
            Assert.IsTrue(dErr1.Name == "3139");
            Assert.IsTrue(dErr1.Position == 1);
            Assert.IsTrue(dErr1.ComponentPosition == 0);
            Assert.IsTrue(dErr1.RepetitionPosition == 0);
            Assert.IsTrue(dErr1.Value == "123");
            Assert.IsTrue(dErr1.Code == DataElementErrorCode.InvalidCodeValue);
        }

        [TestMethod]
        public void TestValidateWithNoTrailer()
        {
            // ARRANGE
            var msg = EdifactHelper.CreateInvoice();

            // ACT           
            MessageErrorContext errorContext;
            var result = msg.IsValid(out errorContext, true);

            // ASSERT
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestValidateWithTrailer()
        {
            // ARRANGE
            var msg = EdifactHelper.CreateInvoice();

            // ACT           
            MessageErrorContext errorContext;
            var result = msg.IsValid(out errorContext);

            // ASSERT
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestValidationNoControlNumber()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.Edi.Edifact_INVOIC_D00A_Val_NoControlNumber.txt";
            var ediStream = CommonHelper.LoadStream(sample, false);
            List<EdiItem> ediItems;

            // ACT
            using (var ediReader = new EdifactReader(ediStream, "EdiFabric.Rules.EdifactD00A"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }
            var msg = ediItems.OfType<Rules.EDIFACT_D00A.TSINVOIC>().Single();

            MessageErrorContext result;
            var validationResult = msg.IsValid(out result);

            // ASSERT
            Assert.IsFalse(validationResult);
            Assert.IsTrue(result.Errors.Count == 1);
            Assert.IsTrue(result.Codes.Count == 1);
            Assert.IsTrue(result.Codes.Contains(MessageErrorCode.MissingOrInvalidControlNumber));
        }

        [TestMethod]
        public void TestValidationNoTrailerControlNumber()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.Edi.Edifact_INVOIC_D00A_Val_NoTrailerControlNumber.txt";
            var ediStream = CommonHelper.LoadStream(sample, false);
            List<EdiItem> ediItems;

            // ACT
            using (var ediReader = new EdifactReader(ediStream, "EdiFabric.Rules.EdifactD00A"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }
            var msg = ediItems.OfType<Rules.EDIFACT_D00A.TSINVOIC>().Single();

            MessageErrorContext result;
            var validationResult = msg.IsValid(out result);

            // ASSERT
            Assert.IsFalse(validationResult);
            Assert.IsTrue(result.Errors.Count == 1);
            Assert.IsTrue(result.Codes.Count == 1);
            Assert.IsTrue(result.Codes.Contains(MessageErrorCode.ControlNumberNotMatching));
        }

        [TestMethod]
        public void TestValidationNoTrailerSegmentCount()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.Edi.Edifact_INVOIC_D00A_Val_NoTrailerSegmentCount.txt";
            var ediStream = CommonHelper.LoadStream(sample, false);
            List<EdiItem> ediItems;

            // ACT
            using (var ediReader = new EdifactReader(ediStream, "EdiFabric.Rules.EdifactD00A"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }
            var msg = ediItems.OfType<Rules.EDIFACT_D00A.TSINVOIC>().Single();

            MessageErrorContext result;
            var validationResult = msg.IsValid(out result);

            // ASSERT
            Assert.IsFalse(validationResult);
            Assert.IsTrue(result.Errors.Count == 1);
            Assert.IsTrue(result.Codes.Count == 1);
            Assert.IsTrue(result.Codes.Contains(MessageErrorCode.SegmentsCountNotMatching));
        }

        [TestMethod]
        public void TestValidationWrongControlNumber()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.Edi.Edifact_INVOIC_D00A_Val_WrongControlNumber.txt";
            var ediStream = CommonHelper.LoadStream(sample, false);
            List<EdiItem> ediItems;

            // ACT
            using (var ediReader = new EdifactReader(ediStream, "EdiFabric.Rules.EdifactD00A"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }
            var msg = ediItems.OfType<Rules.EDIFACT_D00A.TSINVOIC>().Single();

            MessageErrorContext result;
            var validationResult = msg.IsValid(out result);

            // ASSERT
            Assert.IsFalse(validationResult);
            Assert.IsTrue(result.Errors.Count == 0);
            Assert.IsTrue(result.Codes.Count == 1);
            Assert.IsTrue(result.Codes.Contains(MessageErrorCode.ControlNumberNotMatching));
        }

        [TestMethod]
        public void TestValidationWrongSegmentCount()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.Edi.Edifact_INVOIC_D00A_Val_WrongSegmentCount.txt";
            var ediStream = CommonHelper.LoadStream(sample, false);
            List<EdiItem> ediItems;

            // ACT
            using (var ediReader = new EdifactReader(ediStream, "EdiFabric.Rules.EdifactD00A"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }
            var msg = ediItems.OfType<Rules.EDIFACT_D00A.TSINVOIC>().Single();

            MessageErrorContext result;
            var validationResult = msg.IsValid(out result);

            // ASSERT
            Assert.IsFalse(validationResult);
            Assert.IsTrue(result.Errors.Count == 0);
            Assert.IsTrue(result.Codes.Count == 1);
            Assert.IsTrue(result.Codes.Contains(MessageErrorCode.SegmentsCountNotMatching));
        }

        [TestMethod]
        public void TestValidationOfReaderErrorContext()
        {
            // ARRANGE
            var readerErrorContext = new ReaderErrorContext(new Exception("test"),
                ReaderErrorCode.InvalidControlStructure);

            // ACT
            var result = readerErrorContext.Validate();

            // ASSERT
            Assert.IsTrue(result.Count == 0);
        }

        [TestMethod]
        public void TestValidationIsa()
        {
            //  ARRANGE
            const string sample = "EdiFabric.UnitTests.Edi.X12_820_00204.txt";
            var ediStream = CommonHelper.LoadStream(sample, false);
            ISA isa;
            using (var ediReader = new X12Reader(ediStream, "EdiFabric.Rules.X12002040.Rep"))
            {
                var ediItems = ediReader.ReadToEnd().ToList();
                isa = ediItems.OfType<ISA>().Single();
            } 

            //  ACT
            var result = isa.Validate();

            //  ASSERT

        }
    }
}
