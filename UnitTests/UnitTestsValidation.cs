using System.Collections.Generic;
using System.Linq;
using EdiFabric.Annotations.Validation;
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
            var ediStream = Helper.LoadStream(sample, false);
            List<object> ediItems;

            // ACT
            using (var ediReader = new EdifactReader(ediStream, "EdiFabric.Rules.EdifactD00A.Rep"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }
            var msg = ediItems.OfType<TSINVOIC>().Single();

            List<SegmentErrorContext> results;
            var validationResult = msg.IsValid(out results);

            // ASSERT
            Assert.IsFalse(validationResult);
            Assert.IsTrue(results.Any());
            Assert.IsTrue(results.Count == 4);

            var sErr1 = results.SingleOrDefault(r => r.Name == "UNH" && r.Position == 1);
            Assert.IsNotNull(sErr1);
            Assert.IsTrue(sErr1.Codes.Count == 0);
            Assert.IsTrue(sErr1.Errors.Count == 1);
            var dErr1 = sErr1.Errors.First();
            Assert.IsTrue(dErr1.Name == "0051");
            Assert.IsTrue(dErr1.Position == 2);
            Assert.IsTrue(dErr1.ComponentPosition == 4);
            Assert.IsTrue(dErr1.RepetitionPosition == 0);
            Assert.IsTrue(dErr1.Value == null);
            Assert.IsTrue(dErr1.Code == ValidationResult.RequiredMissingDataElement);

            var sErr2 = results.SingleOrDefault(r => r.Name == "PCD" && r.Position == 15);
            Assert.IsNotNull(sErr2);
            Assert.IsTrue(sErr2.Codes.Count == 0);
            Assert.IsTrue(sErr2.Errors.Count == 1);
            var dErr2 = sErr2.Errors.First();
            Assert.IsTrue(dErr2.Name == "C501");
            Assert.IsTrue(dErr2.Position == 1);
            Assert.IsTrue(dErr2.ComponentPosition == 0);
            Assert.IsTrue(dErr2.RepetitionPosition == 0);
            Assert.IsTrue(dErr2.Value == null);
            Assert.IsTrue(dErr2.Code == ValidationResult.RequiredMissingComposite);

            var sErr3 = results.SingleOrDefault(r => r.Name == "UNS" && r.Position == 33);
            Assert.IsNotNull(sErr3);
            Assert.IsTrue(sErr3.Codes.Count == 1);
            Assert.IsTrue(sErr3.Errors.Count == 0);
            Assert.IsTrue(sErr3.Codes.Contains(ValidationResult.RequiredMissingSegment));

            var sErr4 = results.SingleOrDefault(r => r.Name == "MOA" && r.Position == 33);
            Assert.IsNotNull(sErr4);
            Assert.IsTrue(sErr4.Codes.Count == 1);
            Assert.IsTrue(sErr4.Errors.Count == 0);
            Assert.IsTrue(sErr4.Codes.Contains(ValidationResult.RequiredMissingGroup));
        }

        [TestMethod]
        public void TestValidationListCount()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.Edi.Edifact_INVOIC_D00A_Val_ListCount.txt";
            var ediStream = Helper.LoadStream(sample, false);
            List<object> ediItems;

            // ACT
            using (var ediReader = new EdifactReader(ediStream, "EdiFabric.Rules.EdifactD00A.Rep"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }
            var msg = ediItems.OfType<TSINVOIC>().Single();

            List<SegmentErrorContext> results;
            var validationResult = msg.IsValid(out results);

            // ASSERT
            Assert.IsFalse(validationResult);
            Assert.IsTrue(results.Any());
            Assert.IsTrue(results.Count == 4);

            var sErr1 = results.SingleOrDefault(r => r.Name == "BGM" && r.Position == 2);
            Assert.IsNotNull(sErr1);
            Assert.IsTrue(sErr1.Codes.Count == 0);
            Assert.IsTrue(sErr1.Errors.Count == 1);
            var dErr1 = sErr1.Errors.First();
            Assert.IsTrue(dErr1.Name == "1225");
            Assert.IsTrue(dErr1.Position == 3);
            Assert.IsTrue(dErr1.ComponentPosition == 0);
            Assert.IsTrue(dErr1.RepetitionPosition == 2);
            Assert.IsTrue(dErr1.Value == null);
            Assert.IsTrue(dErr1.Code == ValidationResult.CountExceededDataElement);

            var sErr2 = results.SingleOrDefault(r => r.Name == "COM" && r.Position == 15);
            Assert.IsNotNull(sErr2);
            Assert.IsTrue(sErr2.Codes.Count == 0);
            Assert.IsTrue(sErr2.Errors.Count == 1);
            var dErr2 = sErr2.Errors.First();
            Assert.IsTrue(dErr2.Name == "C076");
            Assert.IsTrue(dErr2.Position == 1);
            Assert.IsTrue(dErr2.ComponentPosition == 0);
            Assert.IsTrue(dErr2.RepetitionPosition == 4);
            Assert.IsTrue(dErr2.Value == null);
            Assert.IsTrue(dErr2.Code == ValidationResult.CountExceededComposite);

            var sErr3 = results.SingleOrDefault(r => r.Name == "ALI" && r.Position == 4);
            Assert.IsNotNull(sErr3);
            Assert.IsTrue(sErr3.Codes.Count == 1);
            Assert.IsTrue(sErr3.Errors.Count == 0);
            Assert.IsTrue(sErr3.Codes.Contains(ValidationResult.CountExceededSegment));

            var sErr4 = results.SingleOrDefault(r => r.Name == "TAX" && r.Position == 19);
            Assert.IsNotNull(sErr4);
            Assert.IsTrue(sErr4.Codes.Count == 1);
            Assert.IsTrue(sErr4.Errors.Count == 0);
            Assert.IsTrue(sErr4.Codes.Contains(ValidationResult.CountExceededGroup));
        }
    }
}
