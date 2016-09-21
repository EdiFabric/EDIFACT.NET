using System;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using EdiFabric.Framework;
using EdiFabric.Rules.X12002040810;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EdiFabric.Tests
{
    [TestClass]
    public class TestX12
    {
        public const string TargetNamespace = "www.edifabric.com/x12";
        
        [TestMethod]
        public void TestParse()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.X12_810_00204.txt";
            const string expectedResult = "EdiFabric.Tests.Xml.X12_810_00204.xml";
            var expectedXml = XElement.Load(TestHelper.Load(expectedResult));

            // ACT
            var message = TestHelper.ParseX12(sample);

            // ASSERT
            Assert.IsNotNull(message);
            Assert.IsNotNull(message.InterchangeHeader);
            Assert.IsNotNull(message.Value);
            Assert.IsNotNull(message.GroupHeader);
            var parsedXml = TestHelper.Serialize(message.Value, TargetNamespace);
            Assert.AreEqual(parsedXml.ToString(), expectedXml.ToString());
        }

        [TestMethod]
        public void TestGenerate()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.X12_810_00204.txt";
            var interchange = TestHelper.GenerateX12(sample);

            // ACT
            var ediSegments = interchange.GenerateEdi();

            // ASSERT
            Assert.AreEqual(TestHelper.AsString(sample), TestHelper.AsString(ediSegments, Environment.NewLine));
        }

        [TestMethod]
        public void TestParseWithValidationFailure()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A.txt";
            const string validationXsd = "EF_EDIFACT_D00A_INVOIC.xsd";

            // ACT
            var message = (M_810)TestHelper.ParseEdifact(sample).Value;
            var brokenRules = message.ValidateEdifact(TestHelper.LoadXsd(validationXsd));

            // ASSERT
            Assert.IsTrue(brokenRules.Any());
        }

        [TestMethod]
        public void TestParseWithValidation()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_Valid.txt";
            const string validationXsd = "EF_EDIFACT_D00A_INVOIC.xsd";

            // ACT
            var message = (M_810)TestHelper.ParseEdifact(sample).Value;
            var brokenRules = message.ValidateEdifact(TestHelper.LoadXsd(validationXsd));

            // ASSERT
            Assert.IsFalse(brokenRules.Any());
        }

        [TestMethod]
        public void TestParseWithDefaultUna()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_DefaultUNA.txt";
            const string expectedResult = "EdiFabric.Tests.Xml.Edifact_INVOIC_D00A.xml";
            var expectedXml = XElement.Load(TestHelper.Load(expectedResult));

            // ACT
            var message = TestHelper.ParseEdifact(sample);

            // ASSERT
            Assert.IsNotNull(message);
            Assert.IsNotNull(message.InterchangeHeader);
            Assert.IsNotNull(message.Value);
            Assert.IsNull(message.GroupHeader);
            var parsedXml = TestHelper.Serialize(message.Value, TargetNamespace);
            Assert.AreEqual(parsedXml.ToString(), expectedXml.ToString());
        }

        [TestMethod]
        public void TestParseWithNonDefaultUna()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_NonDefaultSeparators.txt";
            const string expectedResult = "EdiFabric.Tests.Xml.Edifact_INVOIC_D00A.xml";
            var expectedXml = XElement.Load(TestHelper.Load(expectedResult));

            // ACT
            var message = TestHelper.ParseEdifact(sample);

            // ASSERT
            Assert.IsNotNull(message);
            Assert.IsNotNull(message.InterchangeHeader);
            Assert.IsNotNull(message.Value);
            Assert.IsNull(message.GroupHeader);
            var parsedXml = TestHelper.Serialize(message.Value, TargetNamespace);
            Assert.AreEqual(parsedXml.ToString(), expectedXml.ToString());
        }

        [TestMethod]
        public void TestParseWithLf()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_LF.txt";
            const string expectedResult = "EdiFabric.Tests.Xml.Edifact_INVOIC_D00A.xml";
            var expectedXml = XElement.Load(TestHelper.Load(expectedResult));

            // ACT
            var message = TestHelper.ParseEdifact(sample, Encoding.UTF8);

            // ASSERT
            Assert.IsNotNull(message);
            Assert.IsNotNull(message.InterchangeHeader);
            Assert.IsNotNull(message.Value);
            Assert.IsNull(message.GroupHeader);
            var parsedXml = TestHelper.Serialize(message.Value, TargetNamespace);
            Assert.AreEqual(parsedXml.ToString(), expectedXml.ToString());
        }

        [TestMethod]
        public void TestGenerateWithNonDefaultSeparators()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A.txt";
            const string expectedResult = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_NonDefaultSeparators.txt";
            var interchange = TestHelper.GenerateEdifact(sample);
            var defaultSeparators = Separators.DefaultSeparatorsEdifact();
            var newSeparators = Separators.SeparatorsEdifact(defaultSeparators.Segment,
                defaultSeparators.ComponentDataElement, '|', defaultSeparators.RepetitionDataElement,
                defaultSeparators.Escape);

            // ACT
            var ediSegments = interchange.GenerateEdi(newSeparators);

            // ASSERT
            Assert.AreEqual(TestHelper.AsString(expectedResult), TestHelper.AsString(ediSegments, Environment.NewLine));
        }

        [TestMethod]
        [ExpectedException(typeof(ParserException))]
        public void TestParseWithError()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_BadSegment.txt";

            // ACT
            TestHelper.ParseEdifact(sample);
        }

        [TestMethod]
        public void TestParseWithGroup()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_Group.txt";
            const string expectedResult = "EdiFabric.Tests.Xml.Edifact_INVOIC_D00A.xml";
            var expectedXml = XElement.Load(TestHelper.Load(expectedResult));

            // ACT
            var message = TestHelper.ParseEdifact(sample);

            // ASSERT
            Assert.IsNotNull(message);
            Assert.IsNotNull(message.InterchangeHeader);
            Assert.IsNotNull(message.Value);
            Assert.IsNotNull(message.GroupHeader);
            var parsedXml = TestHelper.Serialize(message.Value, TargetNamespace);
            Assert.AreEqual(parsedXml.ToString(), expectedXml.ToString());
        }

        [TestMethod]
        public void TestParseWithGroupAndMultipleMessages()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_GroupMultipleMessages.txt";
            const string expectedResult = "EdiFabric.Tests.Xml.Edifact_INVOIC_D00A.xml";
            var expectedXml = XElement.Load(TestHelper.Load(expectedResult));

            // ACT
            var messages = TestHelper.ParseEdifactMultiple(sample);

            // ASSERT
            Assert.IsTrue(messages.Count == 2);
            Assert.IsTrue(TestHelper.Serialize(messages[0].InterchangeHeader, TargetNamespace).ToString() ==
                          TestHelper.Serialize(messages[1].InterchangeHeader, TargetNamespace).ToString());
            Assert.IsTrue(TestHelper.Serialize(messages[0].GroupHeader, TargetNamespace).ToString() ==
                          TestHelper.Serialize(messages[1].GroupHeader, TargetNamespace).ToString());
            foreach (var message in messages)
            {
                Assert.IsNotNull(message);
                Assert.IsNotNull(message.InterchangeHeader);
                Assert.IsNotNull(message.Value);
                Assert.IsNotNull(message.GroupHeader);
                var parsedXml = TestHelper.Serialize(message.Value, TargetNamespace);
                Assert.AreEqual(parsedXml.ToString(), expectedXml.ToString());
            }
        }

        [TestMethod]
        public void TestParseWithMultipleGroups()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_MultipleGroups.txt";
            const string expectedResult = "EdiFabric.Tests.Xml.Edifact_INVOIC_D00A.xml";
            var expectedXml = XElement.Load(TestHelper.Load(expectedResult));

            // ACT
            var messages = TestHelper.ParseEdifactMultiple(sample);

            // ASSERT
            Assert.IsTrue(messages.Count == 2);
            Assert.IsTrue(TestHelper.Serialize(messages[0].InterchangeHeader, TargetNamespace).ToString() ==
                         TestHelper.Serialize(messages[1].InterchangeHeader, TargetNamespace).ToString());
            Assert.IsTrue(TestHelper.Serialize(messages[0].GroupHeader, TargetNamespace).ToString() !=
                          TestHelper.Serialize(messages[1].GroupHeader, TargetNamespace).ToString());
            foreach (var message in messages)
            {
                Assert.IsNotNull(message);
                Assert.IsNotNull(message.InterchangeHeader);
                Assert.IsNotNull(message.Value);
                Assert.IsNotNull(message.GroupHeader);
                var parsedXml = TestHelper.Serialize(message.Value, TargetNamespace);
                Assert.AreEqual(parsedXml.ToString(), expectedXml.ToString());
            }
        }

        [TestMethod]
        public void TestParseWithMultipleMessages()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_MultipleMessages.txt";
            const string expectedResult = "EdiFabric.Tests.Xml.Edifact_INVOIC_D00A.xml";
            var expectedXml = XElement.Load(TestHelper.Load(expectedResult));

            // ACT
            var messages = TestHelper.ParseEdifactMultiple(sample);

            // ASSERT
            Assert.IsTrue(messages.Count == 2);
            Assert.IsTrue(TestHelper.Serialize(messages[0].InterchangeHeader, TargetNamespace).ToString() ==
                         TestHelper.Serialize(messages[1].InterchangeHeader, TargetNamespace).ToString());
            foreach (var message in messages)
            {
                Assert.IsNotNull(message);
                Assert.IsNotNull(message.InterchangeHeader);
                Assert.IsNotNull(message.Value);
                Assert.IsNull(message.GroupHeader);
                var parsedXml = TestHelper.Serialize(message.Value, TargetNamespace);
                Assert.AreEqual(parsedXml.ToString(), expectedXml.ToString());
            }
        }

        [TestMethod]
        public void TestParseWithEscapedSegmentTerminator()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_EscapedSegmentTerminator.txt";
            const string expectedResult = "EdiFabric.Tests.Xml.Edifact_INVOIC_D00A_EscapedSegmentTerminator.xml";
            var expectedXml = XElement.Load(TestHelper.Load(expectedResult));

            // ACT
            var message = TestHelper.ParseEdifact(sample);

            // ASSERT
            Assert.IsNotNull(message);
            Assert.IsNotNull(message.InterchangeHeader);
            Assert.IsNotNull(message.Value);
            Assert.IsNull(message.GroupHeader);
            var parsedXml = TestHelper.Serialize(message.Value, TargetNamespace);
            Assert.AreEqual(parsedXml.ToString(), expectedXml.ToString());
        }

        [TestMethod]
        public void TestGenerateWithEscapedSegmentTerminator()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_EscapedSegmentTerminator.txt";
            var interchange = TestHelper.GenerateEdifact(sample);

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
            var interchange = TestHelper.GenerateEdifact(sample);

            // ACT
            var ediSegments = interchange.GenerateEdi();

            // ASSERT
            Assert.AreEqual(TestHelper.AsString(sample), TestHelper.AsString(ediSegments, Environment.NewLine));
        }

        [TestMethod]
        public void TestParseWithEscapedEscape()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_EscapedEscape.txt";
            const string expectedResult = "EdiFabric.Tests.Xml.Edifact_INVOIC_D00A_EscapedEscape.xml";
            var expectedXml = XElement.Load(TestHelper.Load(expectedResult));

            // ACT
            var message = TestHelper.ParseEdifact(sample);

            // ASSERT
            Assert.IsNotNull(message);
            Assert.IsNotNull(message.InterchangeHeader);
            Assert.IsNotNull(message.Value);
            Assert.IsNull(message.GroupHeader);
            var parsedXml = TestHelper.Serialize(message.Value, TargetNamespace);
            Assert.AreEqual(parsedXml.ToString(), expectedXml.ToString());
        }

        [TestMethod]
        public void TestGenerateWithEscapedEscape()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_EscapedEscape.txt";
            var interchange = TestHelper.GenerateEdifact(sample);

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
            var interchange = TestHelper.GenerateEdifact(sample);

            // ACT
            var ediSegments = interchange.GenerateEdi();

            // ASSERT
            Assert.AreEqual(TestHelper.AsString(sample), TestHelper.AsString(ediSegments, Environment.NewLine));
        }

        [TestMethod]
        public void TestParseWithRepeatingDataElement()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_RepeatingDataElement.txt";
            const string expectedResult = "EdiFabric.Tests.Xml.Edifact_INVOIC_D00A_RepeatingDataElement.xml";
            var expectedXml = XElement.Load(TestHelper.Load(expectedResult));

            // ACT
            var message = TestHelper.ParseEdifact(sample);

            // ASSERT
            Assert.IsNotNull(message);
            Assert.IsNotNull(message.InterchangeHeader);
            Assert.IsNotNull(message.Value);
            Assert.IsNull(message.GroupHeader);
            var parsedXml = TestHelper.Serialize(message.Value, TargetNamespace);
            Assert.AreEqual(parsedXml.ToString(), expectedXml.ToString());
        }

        [TestMethod]
        public void TestGenerateWithRepeatingDataElement()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_RepeatingDataElement.txt";
            var interchange = TestHelper.GenerateEdifact(sample);

            // ACT
            var ediSegments = interchange.GenerateEdi();

            // ASSERT
            Assert.AreEqual(TestHelper.AsString(sample), TestHelper.AsString(ediSegments, Environment.NewLine));
        }

        [TestMethod]
        public void TestParseWithEscapedRepetiton()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_EscapedRepetition.txt";
            const string expectedResult = "EdiFabric.Tests.Xml.Edifact_INVOIC_D00A_EscapedRepetition.xml";
            var expectedXml = XElement.Load(TestHelper.Load(expectedResult));

            // ACT
            var message = TestHelper.ParseEdifact(sample);

            // ASSERT
            Assert.IsNotNull(message);
            Assert.IsNotNull(message.InterchangeHeader);
            Assert.IsNotNull(message.Value);
            Assert.IsNull(message.GroupHeader);
            var parsedXml = TestHelper.Serialize(message.Value, TargetNamespace);
            Assert.AreEqual(parsedXml.ToString(), expectedXml.ToString());
        }

        [TestMethod]
        public void TestGenerateWithEscapedRepetiton()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_EscapedRepetition.txt";
            var interchange = TestHelper.GenerateEdifact(sample);

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
            var interchange = TestHelper.GenerateEdifact(sample);

            // ACT
            var ediSegments = interchange.GenerateEdi();

            // ASSERT
            Assert.AreEqual(TestHelper.AsString(sample), TestHelper.AsString(ediSegments, Environment.NewLine));
        }

        [TestMethod]
        public void TestParseWithHeaders()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_Group.txt";
            const string expectedGroup = "EdiFabric.Tests.Xml.Edifact_Group.xml";
            var expectedXmlGroup = XElement.Load(TestHelper.Load(expectedGroup));
            const string expectedInterchange = "EdiFabric.Tests.Xml.Edifact_Interchange.xml";
            var expectedXmlInterchange = XElement.Load(TestHelper.Load(expectedInterchange));

            // ACT
            var message = TestHelper.ParseEdifact(sample);

            // ASSERT
            Assert.IsNotNull(message.InterchangeHeader);
            Assert.IsNotNull(message.GroupHeader);
            var parsedXmlInterchange = TestHelper.Serialize(message.InterchangeHeader, TargetNamespace);
            Assert.AreEqual(parsedXmlInterchange.ToString(), expectedXmlInterchange.ToString());
            var parsedXmlGroup = TestHelper.Serialize(message.GroupHeader, TargetNamespace);
            Assert.AreEqual(parsedXmlGroup.ToString(), expectedXmlGroup.ToString());
        }

        [TestMethod]
        public void TestParseWithTrailingBlanks()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_TrailingBlanks.txt";
            const string expectedResult = "EdiFabric.Tests.Xml.Edifact_INVOIC_D00A.xml";
            var expectedXml = XElement.Load(TestHelper.Load(expectedResult));

            // ACT
            var message = TestHelper.ParseEdifact(sample);

            // ASSERT
            Assert.IsNotNull(message);
            Assert.IsNotNull(message.InterchangeHeader);
            Assert.IsNotNull(message.Value);
            Assert.IsNull(message.GroupHeader);
            var parsedXml = TestHelper.Serialize(message.Value, TargetNamespace);
            Assert.AreEqual(parsedXml.ToString(), expectedXml.ToString());
        }

        [TestMethod]
        public void TestParseWithMultipleInterchange()
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
            var messages = TestHelper.ParseEdifactMultiple(sample);

            // ASSERT
            Assert.IsTrue(messages.Count == 2);
            var parsedXmlInterchange = TestHelper.Serialize(messages[0].InterchangeHeader, TargetNamespace);
            Assert.AreEqual(parsedXmlInterchange.ToString(), expectedXmlInterchange.ToString());
            var parsedXmlInterchange2 = TestHelper.Serialize(messages[1].InterchangeHeader, TargetNamespace);
            Assert.AreEqual(parsedXmlInterchange2.ToString(), expectedXmlInterchange2.ToString());
            foreach (var message in messages)
            {
                Assert.IsNotNull(message);
                Assert.IsNotNull(message.Value);
                var parsedXml = TestHelper.Serialize(message.Value, TargetNamespace);
                Assert.AreEqual(parsedXml.ToString(), expectedXml.ToString());
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ParserException))]
        public void TestParseWithInvalidTrailers()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_InvalidTrailers.txt";

            // ACT
            TestHelper.ParseEdifactMultiple(sample);
        }

        [TestMethod]
        [ExpectedException(typeof(ParserException))]
        public void TestParseWithInvalidHeader()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_InvalidHeader.txt";

            // ACT
            TestHelper.ParseEdifactMultiple(sample);
        }

        [TestMethod]
        [ExpectedException(typeof(ParserException))]
        public void TestParseWithInvalidSegment()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_InvalidSegment.txt";

            // ACT
            TestHelper.ParseEdifactMultiple(sample);
        }

        [TestMethod]
        public void TestGenerateGroup()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_Group.txt";
            var interchange = TestHelper.GenerateEdifact(sample);

            // ACT
            var ediSegments = interchange.GenerateEdi();

            // ASSERT
            Assert.AreEqual(TestHelper.AsString(sample), TestHelper.AsString(ediSegments, Environment.NewLine));
        }
        


       
    }
}
