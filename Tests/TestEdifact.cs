using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using EdiFabric.Framework;
using EdiFabric.Framework.Controls;
using EdiFabric.Framework.Exceptions;
using EdiFabric.Framework.Readers;
using EdiFabric.Framework.Validation;
using EdiFabric.Rules.EdifactD00AINVOIC;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EdiFabric.Tests
{
    [TestClass]
    public class TestEdifact
    {
        [TestMethod]
        public void TestParseEdifact()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A.txt";
            const string expectedResult = "EdiFabric.Tests.Xml.Edifact_INVOIC_D00A.xml";
            var expectedXml = XElement.Load(TestHelper.Load(expectedResult));

            // ACT
            var ediItems = TestHelper.ParseEdifact(sample).ToList();

            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsNotNull(ediItems.OfType<S_UNB>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<S_UNG>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<M_INVOIC>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<S_UNE>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<S_UNZ>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<ParsingException>().SingleOrDefault());
            var parsedXml = TestHelper.Serialize(ediItems.OfType<M_INVOIC>().Single());
            Assert.IsNotNull(parsedXml.Root);
            Assert.AreEqual(parsedXml.Root.ToString(), expectedXml.ToString());
        }

        [TestMethod]
        public void TestGenerate()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A.txt";
            var interchange = TestHelper.GenerateEdifact<M_INVOIC>(sample);

            // ACT
            var ediSegments = interchange.GenerateEdi();

            // ASSERT
            Assert.AreEqual(TestHelper.AsString(sample), TestHelper.AsString(ediSegments, Environment.NewLine));
        }

        [TestMethod]
        public void TestParseEdifactWithValidationFailure()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A.txt";

            // ACT
            var message = TestHelper.ParseEdifact(sample).OfType<M_INVOIC>().Single();
            var validationResults = EdiValidator.Create(new ValidatorSettings("EdiFabric.Xsd")).Validate(message);

            // ASSERT
            Assert.IsNotNull(validationResults);
            Assert.IsNotNull(validationResults.ErrorContext);
            Assert.IsTrue(validationResults.ErrorContext.Errors.Any() || validationResults.ErrorContext.Codes.Any());
        }

        [TestMethod]
        public void TestParseEdifactWithValidation()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_Valid.txt";

            // ACT
            var message = TestHelper.ParseEdifact(sample).OfType<M_INVOIC>().Single();
            var validationResults = EdiValidator.Create(new ValidatorSettings("EdiFabric.Xsd")).Validate(message);

            // ASSERT
            Assert.IsNotNull(validationResults);
            Assert.IsNotNull(validationResults.ErrorContext);
            Assert.IsFalse(validationResults.ErrorContext.Errors.Any());
            Assert.IsFalse(validationResults.ErrorContext.Codes.Any());
        }

        [TestMethod]
        public void TestParseEdifactWithDefaultUna()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_DefaultUNA.txt";
            const string expectedResult = "EdiFabric.Tests.Xml.Edifact_INVOIC_D00A.xml";
            var expectedXml = XElement.Load(TestHelper.Load(expectedResult));

            // ACT
            var ediItems = TestHelper.ParseEdifact(sample).ToList();

            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsNotNull(ediItems.OfType<S_UNB>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<S_UNG>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<M_INVOIC>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<S_UNE>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<S_UNZ>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<ParsingException>().SingleOrDefault());
            var parsedXml = TestHelper.Serialize(ediItems.OfType<M_INVOIC>().Single());
            Assert.IsNotNull(parsedXml.Root);
            Assert.AreEqual(parsedXml.Root.ToString(), expectedXml.ToString());
        }

        [TestMethod]
        public void TestParseEdifactWithNonDefaultUna()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_NonDefaultSeparators.txt";
            const string expectedResult = "EdiFabric.Tests.Xml.Edifact_INVOIC_D00A.xml";
            var expectedXml = XElement.Load(TestHelper.Load(expectedResult));

            // ACT
            var ediItems = TestHelper.ParseEdifact(sample).ToList();

            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsNotNull(ediItems.OfType<S_UNB>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<S_UNG>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<M_INVOIC>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<S_UNE>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<S_UNZ>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<ParsingException>().SingleOrDefault());
            var parsedXml = TestHelper.Serialize(ediItems.OfType<M_INVOIC>().Single());
            Assert.IsNotNull(parsedXml.Root);
            Assert.AreEqual(parsedXml.Root.ToString(), expectedXml.ToString());
        }

        [TestMethod]
        public void TestParseEdifactWithLf()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_LF.txt";
            const string expectedResult = "EdiFabric.Tests.Xml.Edifact_INVOIC_D00A.xml";
            var expectedXml = XElement.Load(TestHelper.Load(expectedResult));

            // ACT
            var ediItems = TestHelper.ParseEdifact(sample, Encoding.UTF8).ToList();

            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsNotNull(ediItems.OfType<S_UNB>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<S_UNG>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<M_INVOIC>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<S_UNE>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<S_UNZ>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<ParsingException>().SingleOrDefault());
            var parsedXml = TestHelper.Serialize(ediItems.OfType<M_INVOIC>().Single());
            Assert.IsNotNull(parsedXml.Root);
            Assert.AreEqual(parsedXml.Root.ToString(), expectedXml.ToString());
        }

        [TestMethod]
        public void TestGenerateWithNonDefaultSeparators()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A.txt";
            const string expectedResult = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_NonDefaultSeparators.txt";
            var interchange = TestHelper.GenerateEdifact<M_INVOIC>(sample);
            var defaultSeparators = Separators.DefaultEdifact();
            var newSeparators = new Separators(defaultSeparators.Segment,
                defaultSeparators.ComponentDataElement, '|', defaultSeparators.RepetitionDataElement,
                defaultSeparators.Escape);

            // ACT
            var ediSegments = interchange.GenerateEdi(newSeparators);

            // ASSERT
            Assert.AreEqual(TestHelper.AsString(expectedResult), TestHelper.AsString(ediSegments, Environment.NewLine));
        }

        [TestMethod]
        public void TestParseEdifactWithError()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_BadSegment.txt";

            // ACT
            var ediItems = TestHelper.ParseEdifact(sample).ToList();

            // ASSERT
            Assert.IsNotNull(ediItems.OfType<S_UNB>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<S_UNG>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<ParsingException>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<S_UNE>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<S_UNZ>().SingleOrDefault());
        }

        [TestMethod]
        public void TestParseEdifactWithGroup()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_Group.txt";
            const string expectedResult = "EdiFabric.Tests.Xml.Edifact_INVOIC_D00A.xml";
            var expectedXml = XElement.Load(TestHelper.Load(expectedResult));

            // ACT
            var ediItems = TestHelper.ParseEdifact(sample).ToList();

            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsNotNull(ediItems.OfType<S_UNB>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<S_UNG>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<M_INVOIC>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<S_UNE>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<S_UNZ>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<ParsingException>().SingleOrDefault());
            var parsedXml = TestHelper.Serialize(ediItems.OfType<M_INVOIC>().Single());
            Assert.IsNotNull(parsedXml.Root);
            Assert.AreEqual(parsedXml.Root.ToString(), expectedXml.ToString());
        }

        [TestMethod]
        public void TestParseEdifactWithGroupAndMultipleMessages()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_GroupMultipleMessages.txt";
            const string expectedResult = "EdiFabric.Tests.Xml.Edifact_INVOIC_D00A.xml";
            var expectedXml = XElement.Load(TestHelper.Load(expectedResult));

            // ACT
            var ediItems = TestHelper.ParseEdifact(sample).ToList();

            // ASSERT
            Assert.IsTrue(ediItems.OfType<S_UNB>().Count() == 1);
            Assert.IsTrue(ediItems.OfType<S_UNG>().Count() == 1);
            Assert.IsTrue(ediItems.OfType<M_INVOIC>().Count() == 2);
            Assert.IsTrue(ediItems.OfType<S_UNE>().Count() == 1);
            Assert.IsTrue(ediItems.OfType<S_UNZ>().Count() == 1);
            Assert.IsNull(ediItems.OfType<ParsingException>().SingleOrDefault());
            foreach (var item in ediItems)
            {
                var message = item as M_INVOIC;
                if (message == null) continue;
                var parsedXml = TestHelper.Serialize(message);
                Assert.IsNotNull(parsedXml.Root);
                Assert.AreEqual(parsedXml.Root.ToString(), expectedXml.ToString());
            }
        }

        [TestMethod]
        public void TestParseEdifactWithMultipleGroups()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_MultipleGroups.txt";
            const string expectedResult = "EdiFabric.Tests.Xml.Edifact_INVOIC_D00A.xml";
            var expectedXml = XElement.Load(TestHelper.Load(expectedResult));

            // ACT
            var ediItems = TestHelper.ParseEdifact(sample).ToList();

            // ASSERT
            Assert.IsTrue(ediItems.OfType<S_UNB>().Count() == 1);
            Assert.IsTrue(ediItems.OfType<S_UNG>().Count() == 2);
            Assert.IsTrue(ediItems.OfType<M_INVOIC>().Count() == 2);
            Assert.IsTrue(ediItems.OfType<S_UNE>().Count() == 2);
            Assert.IsTrue(ediItems.OfType<S_UNZ>().Count() == 1);
            Assert.IsNull(ediItems.OfType<ParsingException>().SingleOrDefault());
            foreach (var item in ediItems)
            {
                var message = item as M_INVOIC;
                if (message == null) continue;
                var parsedXml = TestHelper.Serialize(message);
                Assert.IsNotNull(parsedXml.Root);
                Assert.AreEqual(parsedXml.Root.ToString(), expectedXml.ToString());
            }
        }

        [TestMethod]
        public void TestParseEdifactWithMultipleMessages()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_MultipleMessages.txt";
            const string expectedResult = "EdiFabric.Tests.Xml.Edifact_INVOIC_D00A.xml";
            var expectedXml = XElement.Load(TestHelper.Load(expectedResult));

            // ACT
            var ediItems = TestHelper.ParseEdifact(sample).ToList();

            // ASSERT
            Assert.IsTrue(ediItems.OfType<M_INVOIC>().Count() == 2);
            Assert.IsTrue(ediItems.OfType<S_UNB>().Count() == 1);
            Assert.IsTrue(ediItems.OfType<S_UNZ>().Count() == 1);
            Assert.IsTrue(!ediItems.OfType<S_UNG>().Any());
            Assert.IsTrue(!ediItems.OfType<S_UNE>().Any());
            Assert.IsNull(ediItems.OfType<ParsingException>().SingleOrDefault());
            foreach (var item in ediItems)
            {
                var message = item as M_INVOIC;
                if (message == null) continue;
                var parsedXml = TestHelper.Serialize(message);
                Assert.IsNotNull(parsedXml.Root);
                Assert.AreEqual(parsedXml.Root.ToString(), expectedXml.ToString());
            }
        }

        [TestMethod]
        public void TestParseEdifactWithEscapedSegmentTerminator()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_EscapedSegmentTerminator.txt";
            const string expectedResult = "EdiFabric.Tests.Xml.Edifact_INVOIC_D00A_EscapedSegmentTerminator.xml";
            var expectedXml = XElement.Load(TestHelper.Load(expectedResult));

            // ACT
            var ediItems = TestHelper.ParseEdifact(sample).ToList();

            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsNotNull(ediItems.OfType<S_UNB>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<S_UNG>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<M_INVOIC>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<S_UNE>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<S_UNZ>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<ParsingException>().SingleOrDefault());
            var parsedXml = TestHelper.Serialize(ediItems.OfType<M_INVOIC>().Single());
            Assert.IsNotNull(parsedXml.Root);
            Assert.AreEqual(parsedXml.Root.ToString(), expectedXml.ToString());
        }

        [TestMethod]
        public void TestGenerateWithEscapedSegmentTerminator()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_EscapedSegmentTerminator.txt";
            var interchange = TestHelper.GenerateEdifact<M_INVOIC>(sample);

            // ACT
            var ediSegments = interchange.GenerateEdi();

            // ASSERT
            Assert.AreEqual(TestHelper.AsString(sample), TestHelper.AsString(ediSegments, Environment.NewLine));
        }

        [TestMethod]
        public void TestGenerateWithRepeatingSegment()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_RepeatingSegment.txt";
            var interchange = TestHelper.GenerateEdifact<M_INVOIC>(sample);

            // ACT
            var ediSegments = interchange.GenerateEdi();

            // ASSERT
            Assert.AreEqual(TestHelper.AsString(sample), TestHelper.AsString(ediSegments, Environment.NewLine));
        }

        [TestMethod]
        public void TestParseEdifactWithEscapedEscape()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_EscapedEscape.txt";
            const string expectedResult = "EdiFabric.Tests.Xml.Edifact_INVOIC_D00A_EscapedEscape.xml";
            var expectedXml = XElement.Load(TestHelper.Load(expectedResult));

            // ACT
            var ediItems = TestHelper.ParseEdifact(sample).ToList();

            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsNotNull(ediItems.OfType<S_UNB>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<S_UNG>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<M_INVOIC>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<S_UNE>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<S_UNZ>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<ParsingException>().SingleOrDefault());
            var parsedXml = TestHelper.Serialize(ediItems.OfType<M_INVOIC>().Single());
            Assert.IsNotNull(parsedXml.Root);
            Assert.AreEqual(parsedXml.Root.ToString(), expectedXml.ToString());
        }

        [TestMethod]
        public void TestGenerateWithEscapedEscape()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_EscapedEscape.txt";
            var interchange = TestHelper.GenerateEdifact<M_INVOIC>(sample);

            // ACT
            var ediSegments = interchange.GenerateEdi();

            // ASSERT
            Assert.AreEqual(TestHelper.AsString(sample), TestHelper.AsString(ediSegments, Environment.NewLine));
        }

        [TestMethod]
        public void TestGenerateWithTrailingSeparator()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_TrailingSeparator.txt";
            var interchange = TestHelper.GenerateEdifact<M_INVOIC>(sample);

            // ACT
            var ediSegments = interchange.GenerateEdi();

            // ASSERT
            Assert.AreEqual(TestHelper.AsString(sample), TestHelper.AsString(ediSegments, Environment.NewLine));
        }

        [TestMethod]
        public void TestParseEdifactWithRepeatingDataElement()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_RepeatingDataElement.txt";
            const string expectedResult = "EdiFabric.Tests.Xml.Edifact_INVOIC_D00A_RepeatingDataElement.xml";
            var expectedXml = XElement.Load(TestHelper.Load(expectedResult));

            // ACT
            var ediItems = TestHelper.ParseEdifact(sample).ToList();

            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsNotNull(ediItems.OfType<S_UNB>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<S_UNG>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<M_INVOIC>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<S_UNE>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<S_UNZ>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<ParsingException>().SingleOrDefault());
            var parsedXml = TestHelper.Serialize(ediItems.OfType<M_INVOIC>().Single());
            Assert.IsNotNull(parsedXml.Root);
            Assert.AreEqual(parsedXml.Root.ToString(), expectedXml.ToString());
        }

        [TestMethod]
        public void TestGenerateWithRepeatingDataElement()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_RepeatingDataElement.txt";
            var interchange = TestHelper.GenerateEdifact<M_INVOIC>(sample);

            // ACT
            var ediSegments = interchange.GenerateEdi();

            // ASSERT
            Assert.AreEqual(TestHelper.AsString(sample), TestHelper.AsString(ediSegments, Environment.NewLine));
        }

        [TestMethod]
        public void TestParseEdifactWithEscapedRepetiton()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_EscapedRepetition.txt";
            const string expectedResult = "EdiFabric.Tests.Xml.Edifact_INVOIC_D00A_EscapedRepetition.xml";
            var expectedXml = XElement.Load(TestHelper.Load(expectedResult));

            // ACT
            var ediItems = TestHelper.ParseEdifact(sample).ToList();

            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsNotNull(ediItems.OfType<S_UNB>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<S_UNG>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<M_INVOIC>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<S_UNE>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<S_UNZ>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<ParsingException>().SingleOrDefault());
            var parsedXml = TestHelper.Serialize(ediItems.OfType<M_INVOIC>().Single());
            Assert.IsNotNull(parsedXml.Root);
            Assert.AreEqual(parsedXml.Root.ToString(), expectedXml.ToString());
        }

        [TestMethod]
        public void TestGenerateWithEscapedRepetiton()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_EscapedRepetition.txt";
            var interchange = TestHelper.GenerateEdifact<M_INVOIC>(sample);

            // ACT
            var ediSegments = interchange.GenerateEdi();

            // ASSERT
            Assert.AreEqual(TestHelper.AsString(sample), TestHelper.AsString(ediSegments, Environment.NewLine));
        }

        [TestMethod]
        public void TestGenerateWithBom()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_BOM.txt";
            var interchange = TestHelper.GenerateEdifact<M_INVOIC>(sample);

            // ACT
            var ediSegments = interchange.GenerateEdi();

            // ASSERT
            Assert.AreEqual(TestHelper.AsString(sample), TestHelper.AsString(ediSegments, Environment.NewLine));
        }

        [TestMethod]
        public void TestParseEdifactWithHeaders()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_Group.txt";
            const string expectedGroup = "EdiFabric.Tests.Xml.Edifact_Group.xml";
            var expectedXmlGroup = XElement.Load(TestHelper.Load(expectedGroup));
            const string expectedInterchange = "EdiFabric.Tests.Xml.Edifact_Interchange.xml";
            var expectedXmlInterchange = XElement.Load(TestHelper.Load(expectedInterchange));

            // ACT
            var ediItems = TestHelper.ParseEdifact(sample).ToList();

            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsNotNull(ediItems.OfType<S_UNB>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<S_UNG>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<M_INVOIC>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<S_UNE>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<S_UNZ>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<ParsingException>().SingleOrDefault());
            var parsedXmlInterchange = TestHelper.Serialize(ediItems.OfType<S_UNB>().First());
            Assert.IsNotNull(parsedXmlInterchange.Root);
            Assert.AreEqual(parsedXmlInterchange.Root.ToString(), expectedXmlInterchange.ToString());
            var parsedXmlGroup = TestHelper.Serialize(ediItems.OfType<S_UNG>().First());
            Assert.IsNotNull(parsedXmlGroup.Root);
            Assert.AreEqual(parsedXmlGroup.Root.ToString(), expectedXmlGroup.ToString());
        }

        [TestMethod]
        public void TestParseEdifactWithTrailingBlanks()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_TrailingBlanks.txt";
            const string expectedResult = "EdiFabric.Tests.Xml.Edifact_INVOIC_D00A.xml";
            var expectedXml = XElement.Load(TestHelper.Load(expectedResult));

            // ACT
            var ediItems = TestHelper.ParseEdifact(sample).ToList();

            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsNotNull(ediItems.OfType<S_UNB>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<S_UNG>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<S_UNE>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<S_UNZ>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<ParsingException>().SingleOrDefault());
            Assert.IsTrue(ediItems.OfType<M_INVOIC>().Count() == 2);
            var parsedXml = TestHelper.Serialize(ediItems.OfType<M_INVOIC>().First());
            Assert.IsNotNull(parsedXml.Root);
            Assert.AreEqual(parsedXml.Root.ToString(), expectedXml.ToString());
        }

        [TestMethod]
        public void TestParseEdifactWithMultipleInterchange()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_MultipleInterchange.txt";
            const string expectedResult = "EdiFabric.Tests.Xml.Edifact_INVOIC_D00A.xml";
            var expectedXml = XElement.Load(TestHelper.Load(expectedResult));
            const string expectedInterchange = "EdiFabric.Tests.Xml.Edifact_Interchange.xml";
            var expectedXmlInterchange = XElement.Load(TestHelper.Load(expectedInterchange));
            const string expectedInterchange2 = "EdiFabric.Tests.Xml.Edifact_Interchange2.xml";
            var expectedXmlInterchange2 = XElement.Load(TestHelper.Load(expectedInterchange2));

            // ACT
            var items = TestHelper.ParseEdifact(sample).ToList();

            // ASSERT
            Assert.IsTrue(items.OfType<S_UNB>().Count() == 2);
            Assert.IsNull(items.OfType<S_UNG>().SingleOrDefault());
            Assert.IsTrue(items.OfType<M_INVOIC>().Count() == 2);
            Assert.IsNull(items.OfType<S_UNE>().SingleOrDefault());
            Assert.IsTrue(items.OfType<S_UNZ>().Count() == 2);
            Assert.IsNull(items.OfType<ParsingException>().SingleOrDefault());
            Assert.IsTrue(items.Count == 6);
            var parsedXmlInterchange = TestHelper.Serialize(items.OfType<S_UNB>().First());
            Assert.IsNotNull(parsedXmlInterchange.Root);
            Assert.AreEqual(parsedXmlInterchange.Root.ToString(), expectedXmlInterchange.ToString());
            var parsedXmlInterchange2 = TestHelper.Serialize(items.OfType<S_UNB>().Last());
            Assert.IsNotNull(parsedXmlInterchange2.Root);
            Assert.AreEqual(parsedXmlInterchange2.Root.ToString(), expectedXmlInterchange2.ToString());
            foreach (var item in items.OfType<M_INVOIC>())
            {
                Assert.IsNotNull(item);
                var parsedXml = TestHelper.Serialize(item);
                Assert.IsNotNull(parsedXml.Root);
                Assert.AreEqual(parsedXml.Root.ToString(), expectedXml.ToString());
            }
        }

        [TestMethod]
        public void TestParseEdifactWithInvalidTrailers()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_InvalidTrailers.txt";

            // ACT
            var ediItems = TestHelper.ParseEdifact(sample).ToList();

            // ASSERT
            Assert.IsNotNull(ediItems.OfType<S_UNB>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<S_UNG>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<M_INVOIC>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<S_UNE>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<S_UNZ>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<ParsingException>().SingleOrDefault());
        }

        [TestMethod]
        public void TestParseEdifactWithInvalidHeader()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_InvalidHeader.txt";

            // ACT
            var ediItems = TestHelper.ParseEdifact(sample).ToList();

            // ASSERT
            Assert.IsNotNull(ediItems.OfType<ParsingException>().SingleOrDefault());
        }

        [TestMethod]
        public void TestParseEdifactWithInvalidSegment()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_InvalidSegment.txt";

            // ACT
            var ediItems = TestHelper.ParseEdifact(sample).ToList();

            // ASSERT
            Assert.IsNotNull(ediItems.OfType<S_UNB>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<S_UNG>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<M_INVOIC>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<S_UNE>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<S_UNZ>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<ParsingException>().SingleOrDefault());
        }

        [TestMethod]
        public void TestGenerateGroup()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_Group.txt";
            var interchange = TestHelper.GenerateEdifact<M_INVOIC>(sample);

            // ACT
            var ediSegments = interchange.GenerateEdi();

            // ASSERT
            Assert.AreEqual(TestHelper.AsString(sample), TestHelper.AsString(ediSegments, Environment.NewLine));
        }

        [TestMethod]
        public void TestParseEdifactWithRulesAssemblyName()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A.txt";
            const string expectedResult = "EdiFabric.Tests.Xml.Edifact_INVOIC_D00A.xml";
            var expectedXml = XElement.Load(TestHelper.Load(expectedResult));

            // ACT
            var ediItems = TestHelper.ParseEdifact(sample, null, "EdiFabric.Rules").ToList();

            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsNotNull(ediItems.OfType<S_UNB>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<S_UNG>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<M_INVOIC>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<S_UNE>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<S_UNZ>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<ParsingException>().SingleOrDefault());
            var parsedXml = TestHelper.Serialize(ediItems.OfType<M_INVOIC>().Single());
            Assert.IsNotNull(parsedXml.Root);
            Assert.AreEqual(parsedXml.Root.ToString(), expectedXml.ToString());
        }


        [TestMethod]
        public void TestParseEdifactWithGroupRead()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_MultipleGroups.txt";
            var ediItems = new List<object>();

            // ACT
            using (var ediReader = EdifactReader.Create(TestHelper.Load(sample), new ReaderSettings("EdiFabric.Rules")))
            {
                while (ediReader.Read())
                {
                    ediItems.Add(ediReader.Item);
                    if (!(ediReader.Item is S_UNE)) continue;

                    // ASSERT
                    Assert.IsNotNull(ediItems.OfType<S_UNG>().SingleOrDefault());
                    Assert.IsNotNull(ediItems.OfType<M_INVOIC>().SingleOrDefault());
                    Assert.IsNotNull(ediItems.OfType<S_UNE>().SingleOrDefault());
                    Assert.IsNull(ediItems.OfType<ParsingException>().SingleOrDefault());
                    ediItems.Clear();
                }
            }
        }

        [TestMethod]
        public void TestParseEdifactWithInterchangeRead()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_MultipleInterchange.txt";
            var ediItems = new List<object>();

            // ACT
            using (var ediReader = EdifactReader.Create(TestHelper.Load(sample), new ReaderSettings("EdiFabric.Rules")))
            {
                while (ediReader.Read())
                {
                    ediItems.Add(ediReader.Item);
                    if (!(ediReader.Item is S_UNZ)) continue;

                    // ASSERT
                    Assert.IsNotNull(ediItems.OfType<S_UNB>().SingleOrDefault());
                    Assert.IsNull(ediItems.OfType<S_UNG>().SingleOrDefault());
                    Assert.IsNotNull(ediItems.OfType<M_INVOIC>().SingleOrDefault());
                    Assert.IsNull(ediItems.OfType<S_UNE>().SingleOrDefault());
                    Assert.IsNotNull(ediItems.OfType<S_UNZ>().SingleOrDefault());
                    Assert.IsNull(ediItems.OfType<ParsingException>().SingleOrDefault());
                    ediItems.Clear();
                }
            }
        }

        [TestMethod]
        public void TestParseEdifactWithMissingGroupTrailer()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_MissingGroupTrailer.txt";
            var ediItems = new List<object>();

            // ACT
            using (var ediReader = EdifactReader.Create(TestHelper.Load(sample), new ReaderSettings("EdiFabric.Rules")))
            {
                while (ediReader.Read())
                {
                    ediItems.Add(ediReader.Item);
                }
            }

            // ASSERT
            Assert.IsNotNull(ediItems.OfType<S_UNB>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<S_UNG>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<M_INVOIC>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<S_UNE>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<S_UNZ>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<ParsingException>().SingleOrDefault());
        }

        [TestMethod]
        public void TestParseEdifactWithMissingInterchangeTrailer()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_MissingInterchangeTrailer.txt";
            var ediItems = new List<object>();

            // ACT
            using (var ediReader = EdifactReader.Create(TestHelper.Load(sample), new ReaderSettings("EdiFabric.Rules")))
            {
                while (ediReader.Read())
                {
                    ediItems.Add(ediReader.Item);
                }
            }

            // ASSERT
            Assert.IsTrue(ediItems.OfType<S_UNB>().Count() == 2);
            Assert.IsNull(ediItems.OfType<S_UNG>().SingleOrDefault());
            Assert.IsTrue(ediItems.OfType<M_INVOIC>().Count() == 2);
            Assert.IsNull(ediItems.OfType<S_UNE>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<S_UNZ>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<ParsingException>().SingleOrDefault());
        }

        [TestMethod]
        public void TestParseEdifactWithValidAndInvalidMessageRead()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_ValidAndInvalidMessage.txt";

            // ACT
            using (var ediReader = EdifactReader.Create(TestHelper.Load(sample), new ReaderSettings("EdiFabric.Rules")))
            {
                var ediItems = ediReader.ReadToEnd().ToList();

                // ASSERT
                Assert.IsNotNull(ediItems.OfType<S_UNB>().SingleOrDefault());
                Assert.IsNull(ediItems.OfType<S_UNG>().SingleOrDefault());
                Assert.IsNotNull(ediItems.OfType<M_INVOIC>().SingleOrDefault());
                Assert.IsNull(ediItems.OfType<S_UNE>().SingleOrDefault());
                Assert.IsNotNull(ediItems.OfType<S_UNZ>().SingleOrDefault());
                Assert.IsNotNull(ediItems.OfType<ParsingException>().SingleOrDefault());

            }
        }

        [TestMethod]
        public void TestParseEdifactWithBlankRepetition()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_BlankRepetition.txt";
            const string expectedResult = "EdiFabric.Tests.Xml.Edifact_INVOIC_D00A.xml";
            var expectedXml = XElement.Load(TestHelper.Load(expectedResult));

            // ACT
            var ediItems = TestHelper.ParseEdifact(sample).ToList();

            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsNotNull(ediItems.OfType<S_UNB>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<S_UNG>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<M_INVOIC>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<S_UNE>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<S_UNZ>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<ParsingException>().SingleOrDefault());
            var parsedXml = TestHelper.Serialize(ediItems.OfType<M_INVOIC>().Single());
            Assert.IsNotNull(parsedXml.Root);
            Assert.AreEqual(parsedXml.Root.ToString(), expectedXml.ToString());
        }

        [TestMethod]
        public void TestParseEdifactWithMultipleInvalidInterchanges()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_MultipleInvalidInterchanges.txt";
            const string expectedResult = "EdiFabric.Tests.Xml.Edifact_INVOIC_D00A.xml";
            var expectedXml = XElement.Load(TestHelper.Load(expectedResult));

            // ACT
            var items = TestHelper.ParseEdifact(sample).ToList();

            // ASSERT
            Assert.IsTrue(items.OfType<S_UNB>().Count() == 2);
            Assert.IsNull(items.OfType<S_UNG>().SingleOrDefault());
            Assert.IsTrue(items.OfType<M_INVOIC>().Count() == 3);
            Assert.IsNull(items.OfType<S_UNE>().SingleOrDefault());
            Assert.IsTrue(items.OfType<S_UNZ>().Count() == 2);
            Assert.IsNotNull(items.OfType<ParsingException>().SingleOrDefault());
            Assert.IsTrue(items.Count == 8);
            foreach (var item in items.OfType<M_INVOIC>())
            {
                Assert.IsNotNull(item);
                var parsedXml = TestHelper.Serialize(item);
                Assert.IsNotNull(parsedXml.Root);
                Assert.AreEqual(parsedXml.Root.ToString(), expectedXml.ToString());
            }
        }

        [TestMethod]
        public void TestParseEdifactWithMultipleInvalidMessages()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_MultipleInvalidMessages.txt";
            const string expectedResult = "EdiFabric.Tests.Xml.Edifact_INVOIC_D00A_Probe.xml";
            var expectedXml = XElement.Load(TestHelper.Load(expectedResult));

            // ACT
            var items = TestHelper.ParseEdifact(sample).ToList();

            // ASSERT
            Assert.IsTrue(items.OfType<S_UNB>().Count() == 1);
            Assert.IsNull(items.OfType<S_UNG>().SingleOrDefault());
            Assert.IsTrue(items.OfType<M_INVOIC>().Count() == 3);
            Assert.IsNull(items.OfType<S_UNE>().SingleOrDefault());
            Assert.IsTrue(items.OfType<S_UNZ>().Count() == 1);
            Assert.IsTrue(items.OfType<ParsingException>().Count() == 2);
            foreach (var item in items.OfType<M_INVOIC>().Skip(1))
            {
                Assert.IsNotNull(item);
                var parsedXml = TestHelper.Serialize(item);
                Assert.IsNotNull(parsedXml.Root);
                Assert.AreEqual(parsedXml.Root.ToString(), expectedXml.ToString());
            }
        }

        [TestMethod]
        public void TestValidationRules()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Xml.Edifact_INVOIC_D00A_Validation.xml";
            var obj = TestHelper.Deserialize<M_INVOIC>(TestHelper.Load(sample));
            const string expectedResult = "EdiFabric.Tests.Xml.Edifact_INVOIC_D00A_ValidationExpected.xml";
            var expectedXml = XElement.Load(TestHelper.Load(expectedResult));

            // ACT
            var error = EdiValidator.Create(new ValidatorSettings("EdiFabric.Xsd")).Validate(obj);

            // ASSERT
            Assert.IsNotNull(error);
            var root = TestHelper.Serialize(error.Flatten().ToList()).Root;
            Assert.IsNotNull(root);
            Assert.AreEqual(root.ToString(), expectedXml.ToString());
        }
    }
}
