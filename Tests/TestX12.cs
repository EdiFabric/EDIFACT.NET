using System;
using System.Linq;
using System.Xml.Linq;
using EdiFabric.Framework;
using EdiFabric.Framework.Controls;
using EdiFabric.Framework.Items;
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
            var ediItems = TestHelper.Parse(sample).ToList();

            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsNotNull(ediItems.OfType<EdiControl<S_ISA>>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<EdiControl<S_GS>>().SingleOrDefault());
            var parsedXml = TestHelper.Serialize(ediItems.OfType<EdiMessage>().Single().Value, TargetNamespace);
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
            var message = (M_810)TestHelper.Parse(sample).OfType<EdiMessage>().Single().Value;
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
            var message = (M_810)TestHelper.Parse(sample).OfType<EdiMessage>().Single().Value;
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
            var ediItems = TestHelper.Parse(sample, null, null, "EdiFabric.Rules.Rep").ToList();

            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsNotNull(ediItems.OfType<EdiControl<S_ISA>>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<EdiControl<S_GS>>().SingleOrDefault());
            Assert.IsTrue(ediItems.OfType<EdiMessage>().Single().Separators.RepetitionDataElement == '!');
            var parsedXml = TestHelper.Serialize(ediItems.OfType<EdiMessage>().Single().Value, TargetNamespace);
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
            var ediItems = TestHelper.Parse(sample).ToList();

            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsNotNull(ediItems.OfType<EdiControl<S_ISA>>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<EdiControl<S_GS>>().SingleOrDefault());
            var parsedXml = TestHelper.Serialize(ediItems.OfType<EdiMessage>().Single().Value, TargetNamespace);
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
            var ediItems = TestHelper.Parse(sample).ToList();

            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsNotNull(ediItems.OfType<EdiControl<S_ISA>>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<EdiControl<S_GS>>().SingleOrDefault());
            var parsedXml = TestHelper.Serialize(ediItems.OfType<EdiMessage>().Single().Value, TargetNamespace);
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
            Assert.AreEqual(TestHelper.AsString(sample, false), TestHelper.AsString(ediSegments, null));
        }

        [TestMethod]
        public void TestParseWithError()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.X12_810_00204_BadSegment.txt";

            // ACT
            var ediItems = TestHelper.Parse(sample);

            // ASSERT
            Assert.IsNotNull(ediItems.OfType<EdiError>().SingleOrDefault());
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestGenerateWithNoGroup()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.X12_810_00204.txt";
            var items = TestHelper.Parse(sample).ToList();

            var group = new X12Group<M_810>(null);
            group.AddItem(items.OfType<M_810>().Single());
            var interchange = new X12Interchange(items.OfType<EdiControl<S_ISA>>().Single().Parse());
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
            var ediItems = TestHelper.ParseMultiple(sample).ToList();

            // ASSERT
            Assert.IsTrue(ediItems.OfType<EdiMessage>().Count() == 2);
            Assert.IsTrue(ediItems.OfType<EdiControl<S_ISA>>().Count() == 1);
            Assert.IsTrue(ediItems.OfType<EdiControl<S_GS>>().Count() == 2);
            Assert.IsTrue(ediItems.OfType<EdiControl<S_GE>>().Count() == 2);
            Assert.IsTrue(ediItems.OfType<EdiControl<S_IEA>>().Count() == 1);
            foreach (var item in ediItems)
            {
                var message = item as EdiMessage;
                if (message == null) continue;
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
            var ediItems = TestHelper.ParseMultiple(sample).ToList();

            // ASSERT
            Assert.IsTrue(ediItems.OfType<EdiMessage>().Count() == 2);
            Assert.IsTrue(ediItems.OfType<EdiControl<S_ISA>>().Count() == 1);
            Assert.IsTrue(ediItems.OfType<EdiControl<S_GS>>().Count() == 1);
            Assert.IsTrue(ediItems.OfType<EdiControl<S_GE>>().Count() == 1);
            Assert.IsTrue(ediItems.OfType<EdiControl<S_IEA>>().Count() == 1);
            foreach (var item in ediItems)
            {
                var message = item as EdiMessage;
                if (message == null) continue;
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
            var ediItems = TestHelper.Parse(sample).ToList();

            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsNotNull(ediItems.OfType<EdiControl<S_ISA>>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<EdiControl<S_GS>>().SingleOrDefault());
            var parsedXmlInterchange =
                TestHelper.Serialize(ediItems.OfType<EdiControl<S_ISA>>().First().Parse(),
                    TargetNamespace);
            Assert.AreEqual(parsedXmlInterchange.ToString(), expectedXmlInterchange.ToString());
            var parsedXmlGroup =
                TestHelper.Serialize(ediItems.OfType<EdiControl<S_GS>>().First().Parse(),
                    TargetNamespace);
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
            var ediItems = TestHelper.Parse(sample).ToList();

            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsNotNull(ediItems.OfType<EdiControl<S_ISA>>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<EdiControl<S_GS>>().SingleOrDefault());
            var parsedXml = TestHelper.Serialize(ediItems.OfType<EdiMessage>().Single().Value, TargetNamespace);
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
            var items = TestHelper.ParseMultiple(sample).ToList();

            // ASSERT
            Assert.IsTrue(items.Count == 10);
            Assert.IsTrue(items.OfType<EdiMessage>().Count() == 2);
            Assert.IsTrue(items.OfType<EdiControl<S_ISA>>().Count() == 2);
            Assert.IsTrue(items.OfType<EdiControl<S_GS>>().Count() == 2);
            Assert.IsTrue(items.OfType<EdiControl<S_GE>>().Count() == 2);
            Assert.IsTrue(items.OfType<EdiControl<S_IEA>>().Count() == 2);
            var parsedXmlInterchange =
                TestHelper.Serialize(items.OfType<EdiControl<S_ISA>>().First().Parse(),
                    TargetNamespace);
            Assert.AreEqual(parsedXmlInterchange.ToString(), expectedXmlInterchange.ToString());
            var parsedXmlInterchange2 =
                TestHelper.Serialize(items.OfType<EdiControl<S_ISA>>().Last().Parse(),
                    TargetNamespace);
            Assert.AreEqual(parsedXmlInterchange2.ToString(), expectedXmlInterchange2.ToString());
            foreach (var item in items.OfType<EdiMessage>())
            {
                Assert.IsNotNull(item);
                Assert.IsNotNull(item.Value);
                var parsedXml = TestHelper.Serialize(item.Value, TargetNamespace);
                Assert.AreEqual(parsedXml.ToString(), expectedXml.ToString());
            }
        }

        [TestMethod]
        public void TestParseWithInvalidTrailers()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.X12_810_00204_InvalidTrailers.txt";

            // ACT
            var ediItems = TestHelper.ParseMultiple(sample);

            // ASSERT
            Assert.IsNotNull(ediItems.OfType<EdiError>().SingleOrDefault());
        }

        [TestMethod]
        public void TestParseWithInvalidHeader()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.X12_810_00204_InvalidHeader.txt";

            // ACT
            var ediItems = TestHelper.Parse(sample);

            // ASSERT
            Assert.IsNotNull(ediItems.OfType<EdiError>().SingleOrDefault());
        }

        [TestMethod]
        public void TestParseWithInvalidSegment()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.X12_810_00204_InvalidSegment.txt";

            // ACT
            var ediItems = TestHelper.ParseMultiple(sample);

            // ASSERT
            Assert.IsNotNull(ediItems.OfType<EdiError>().SingleOrDefault());
        }
    }
}
