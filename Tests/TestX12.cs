using System;
using System.Linq;
using System.Xml.Linq;
using EdiFabric.Framework;
using EdiFabric.Framework.Headers;
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
            var interchange = TestHelper.GenerateX12<M_810>(sample);

            // ACT
            var ediSegments = interchange.GenerateEdi();

            // ASSERT
            Assert.AreEqual(TestHelper.AsString(sample), TestHelper.AsString(ediSegments, Environment.NewLine));
        }

        [TestMethod]
        public void TestParseWithValidationFailure()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.X12_810_00204.txt";
            const string validationXsd = "EF_X12_002040_810.xsd";

            // ACT
            var message = (M_810)TestHelper.ParseX12(sample).Value;
            var brokenRules = message.ValidateX12(TestHelper.LoadXsd(validationXsd));

            // ASSERT
            Assert.IsTrue(brokenRules.Any());
        }

        [TestMethod]
        public void TestParseWithValidation()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.X12_810_00204_Valid.txt";
            const string validationXsd = "EF_X12_002040_810.xsd";

            // ACT
            var message = (M_810)TestHelper.ParseX12(sample).Value;
            var brokenRules = message.ValidateX12(TestHelper.LoadXsd(validationXsd));

            // ASSERT
            Assert.IsFalse(brokenRules.Any());
        }

        [TestMethod]
        public void TestParseWithRepetitionSeparator()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.X12_810_00204_RepetitionSeparator.txt";
            const string expectedResult = "EdiFabric.Tests.Xml.X12_810_00204_RepetitionSeparator.xml";
            var expectedXml = XElement.Load(TestHelper.Load(expectedResult));

            // ACT
            var message = TestHelper.ParseX12(sample, null, null, "EdiFabric.Rules.Rep");

            // ASSERT
            Assert.IsNotNull(message);
            Assert.IsNotNull(message.InterchangeHeader);
            Assert.IsNotNull(message.Value);
            Assert.IsNotNull(message.GroupHeader);
            Assert.IsTrue(message.Separators.RepetitionDataElement == '!');
            var parsedXml = TestHelper.Serialize(message.Value, TargetNamespace);
            Assert.AreEqual(parsedXml.ToString(), expectedXml.ToString());
        }

        [TestMethod]
        public void TestGenerateWithRepetitionSeparator()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.X12_810_00204_RepetitionSeparator.txt";
            var interchange = TestHelper.GenerateX12<Rules.Rep.X12002040810.M_810>(sample, "EdiFabric.Rules.Rep");

            // ACT
            var defaultSeparators = Separators.DefaultSeparatorsX12();
            var newSeparators = Separators.SeparatorsX12(defaultSeparators.Segment,
                '>', defaultSeparators.DataElement, '!');
            var ediSegments = interchange.GenerateEdi(newSeparators);

            // ASSERT
            Assert.AreEqual(TestHelper.AsString(sample), TestHelper.AsString(ediSegments, Environment.NewLine));
        }

        [TestMethod]
        public void TestParseWithSegmentSeparatorLf()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.X12_810_00204_SegmentSeparatorLF.txt";
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
        public void TestParseWithLf()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.X12_810_00204_LF.txt";
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
        public void TestGenerateWithSegmentSeparatorLf()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.X12_810_00204_SegmentSeparatorLF.txt";
            var interchange = TestHelper.GenerateX12<M_810>(sample);

            // ACT
            var defaultSeparators = Separators.DefaultSeparatorsX12();
            var newSeparators = Separators.SeparatorsX12('\n',
                '>', defaultSeparators.DataElement, defaultSeparators.RepetitionDataElement);
            var ediSegments = interchange.GenerateEdi(newSeparators);

            // ASSERT
            Assert.AreEqual(TestHelper.AsString(sample), TestHelper.AsString(ediSegments, null));
        }

        [TestMethod]
        [ExpectedException(typeof(ParserException))]
        public void TestParseWithError()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.X12_810_00204_BadSegment.txt";

            // ACT
            TestHelper.ParseX12(sample);
        }

        [TestMethod]
        [ExpectedException(typeof(ParserException))]
        public void TestGenerateWithNoGroup()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.X12_810_00204.txt";
            var message = TestHelper.ParseX12(sample);
            var group = new X12Group<M_810>(null);
            group.AddItem((M_810) message.Value);
            var interchange = new X12Interchange(message.InterchangeHeader);
            interchange.AddItem(group);

            // ACT
            interchange.GenerateEdi();
        }

        [TestMethod]
        public void TestParseWithMultipleGroups()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.X12_810_00204_MultipleGroups.txt";
            const string expectedResult = "EdiFabric.Tests.Xml.X12_810_00204.xml";
            var expectedXml = XElement.Load(TestHelper.Load(expectedResult));

            // ACT
            var messages = TestHelper.ParseX12Multiple(sample);

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
        public void TestParseWithMultipleMessages()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.X12_810_00204_MultipleMessages.txt";
            const string expectedResult = "EdiFabric.Tests.Xml.X12_810_00204.xml";
            var expectedXml = XElement.Load(TestHelper.Load(expectedResult));

            // ACT
            var messages = TestHelper.ParseX12Multiple(sample);

            // ASSERT
            Assert.IsTrue(messages.Count == 2);
            Assert.IsTrue(TestHelper.Serialize(messages[0].InterchangeHeader, TargetNamespace).ToString() ==
                         TestHelper.Serialize(messages[1].InterchangeHeader, TargetNamespace).ToString());
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
        public void TestGenerateWithBom()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.X12_810_00204_BOM.txt";
            var interchange = TestHelper.GenerateX12<M_810>(sample);

            // ACT
            var ediSegments = interchange.GenerateEdi();

            // ASSERT
            Assert.AreEqual(TestHelper.AsString(sample), TestHelper.AsString(ediSegments, Environment.NewLine));
        }

        [TestMethod]
        public void TestParseWithHeaders()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.X12_810_00204.txt";
            const string expectedGroup = "EdiFabric.Tests.Xml.X12_Group.xml";
            var expectedXmlGroup = XElement.Load(TestHelper.Load(expectedGroup));
            const string expectedInterchange = "EdiFabric.Tests.Xml.X12_Interchange.xml";
            var expectedXmlInterchange = XElement.Load(TestHelper.Load(expectedInterchange), LoadOptions.PreserveWhitespace);

            // ACT
            var message = TestHelper.ParseX12(sample);

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
            const string sample = "EdiFabric.Tests.Edi.X12_810_00204_TrailingBlanks.txt";
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
        public void TestParseWithMultipleInterchange()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.X12_810_00204_MultipleInterchanges.txt";
            const string expectedResult = "EdiFabric.Tests.Xml.X12_810_00204.xml";
            var expectedXml = XElement.Load(TestHelper.Load(expectedResult));
            const string expectedInterchange = "EdiFabric.Tests.Xml.X12_Interchange.xml";
            var expectedXmlInterchange = XElement.Load(TestHelper.Load(expectedInterchange), LoadOptions.PreserveWhitespace);
            const string expectedInterchange2 = "EdiFabric.Tests.Xml.X12_Interchange2.xml";
            var expectedXmlInterchange2 = XElement.Load(TestHelper.Load(expectedInterchange2), LoadOptions.PreserveWhitespace);

            // ACT
            var messages = TestHelper.ParseX12Multiple(sample);

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
            const string sample = "EdiFabric.Tests.Edi.X12_810_00204_InvalidTrailers.txt";

            // ACT
            TestHelper.ParseX12Multiple(sample);
        }

        [TestMethod]
        [ExpectedException(typeof(ParserException))]
        public void TestParseWithInvalidHeader()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.X12_810_00204_InvalidHeader.txt";

            // ACT
            TestHelper.ParseX12Multiple(sample);
        }

        [TestMethod]
        [ExpectedException(typeof(ParserException))]
        public void TestParseWithInvalidSegment()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.X12_810_00204_InvalidSegment.txt";

            // ACT
            TestHelper.ParseX12Multiple(sample);
        }
    }
}
