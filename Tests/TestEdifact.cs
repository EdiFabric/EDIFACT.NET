using System;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using EdiFabric.Framework;
using EdiFabric.Framework.Headers;
using EdiFabric.Framework.Items;
using EdiFabric.Rules.EdifactD00AINVOIC;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EdiFabric.Tests
{
    [TestClass]
    public class TestEdifact
    {
        public const string TargetNamespace = "www.edifabric.com/edifact";
        
        [TestMethod]
        public void TestParse()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A.txt";
            const string expectedResult = "EdiFabric.Tests.Xml.Edifact_INVOIC_D00A.xml";
            var expectedXml = XElement.Load(TestHelper.Load(expectedResult));

            // ACT
            var ediItems = TestHelper.Parse(sample).ToList();

            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsNotNull(ediItems.OfType<EdiControl<S_UNB>>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<EdiControl<S_UNG>>().SingleOrDefault());
            var parsedXml = TestHelper.Serialize(ediItems.OfType<EdiMessage>().Single().Value, TargetNamespace);
            Assert.AreEqual(parsedXml.ToString(), expectedXml.ToString());
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
        public void TestParseWithValidationFailure()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A.txt";
            const string validationXsd = "EF_EDIFACT_D00A_INVOIC.xsd";

            // ACT
            var message = (M_INVOIC)TestHelper.Parse(sample).OfType<EdiMessage>().Single().Value;
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
            var message = (M_INVOIC)TestHelper.Parse(sample).OfType<EdiMessage>().Single().Value;
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
            var ediItems = TestHelper.Parse(sample).ToList();

            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsNotNull(ediItems.OfType<EdiControl<S_UNB>>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<EdiControl<S_UNG>>().SingleOrDefault());
            var parsedXml = TestHelper.Serialize(ediItems.OfType<EdiMessage>().Single().Value, TargetNamespace);
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
            var ediItems = TestHelper.Parse(sample).ToList();

            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsNotNull(ediItems.OfType<EdiControl<S_UNB>>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<EdiControl<S_UNG>>().SingleOrDefault());
            var parsedXml = TestHelper.Serialize(ediItems.OfType<EdiMessage>().Single().Value, TargetNamespace);
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
            var ediItems = TestHelper.Parse(sample, Encoding.UTF8).ToList();

            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsNotNull(ediItems.OfType<EdiControl<S_UNB>>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<EdiControl<S_UNG>>().SingleOrDefault());
            var parsedXml = TestHelper.Serialize(ediItems.OfType<EdiMessage>().Single().Value, TargetNamespace);
            Assert.AreEqual(parsedXml.ToString(), expectedXml.ToString());
        }

        [TestMethod]
        public void TestGenerateWithNonDefaultSeparators()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A.txt";
            const string expectedResult = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_NonDefaultSeparators.txt";
            var interchange = TestHelper.GenerateEdifact<M_INVOIC>(sample);
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
        public void TestParseWithError()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_BadSegment.txt";

            // ACT
            var ediItems = TestHelper.Parse(sample);

            // ASSERT
            Assert.IsNotNull(ediItems.OfType<EdiError>().SingleOrDefault());
        }

        [TestMethod]
        public void TestParseWithGroup()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_Group.txt";
            const string expectedResult = "EdiFabric.Tests.Xml.Edifact_INVOIC_D00A.xml";
            var expectedXml = XElement.Load(TestHelper.Load(expectedResult));

            // ACT
            var ediItems = TestHelper.Parse(sample).ToList();

            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsNotNull(ediItems.OfType<EdiControl<S_UNB>>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<EdiControl<S_UNG>>().SingleOrDefault());
            var parsedXml = TestHelper.Serialize(ediItems.OfType<EdiMessage>().Single().Value, TargetNamespace);
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
            var ediItems = TestHelper.ParseMultiple(sample).ToList();

            // ASSERT
            Assert.IsTrue(ediItems.OfType<EdiMessage>().Count() == 2);
            Assert.IsTrue(ediItems.OfType<EdiControl<S_UNB>>().Count() == 1);
            Assert.IsTrue(ediItems.OfType<EdiControl<S_UNG>>().Count() == 1);
            Assert.IsTrue(ediItems.OfType<EdiControl<S_UNE>>().Count() == 1);
            Assert.IsTrue(ediItems.OfType<EdiControl<S_UNZ>>().Count() == 1);
            foreach (var item in ediItems)
            {
                var message = item as EdiMessage;
                if (message == null) continue;
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
            var ediItems = TestHelper.ParseMultiple(sample).ToList();

            // ASSERT
            Assert.IsTrue(ediItems.OfType<EdiMessage>().Count() == 2);
            Assert.IsTrue(ediItems.OfType<EdiControl<S_UNB>>().Count() == 1);
            Assert.IsTrue(ediItems.OfType<EdiControl<S_UNG>>().Count() == 2);
            Assert.IsTrue(ediItems.OfType<EdiControl<S_UNE>>().Count() == 2);
            Assert.IsTrue(ediItems.OfType<EdiControl<S_UNZ>>().Count() == 1);
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
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_MultipleMessages.txt";
            const string expectedResult = "EdiFabric.Tests.Xml.Edifact_INVOIC_D00A.xml";
            var expectedXml = XElement.Load(TestHelper.Load(expectedResult));

            // ACT
            var ediItems = TestHelper.ParseMultiple(sample).ToList();

            // ASSERT
            Assert.IsTrue(ediItems.OfType<EdiMessage>().Count() == 2);
            Assert.IsTrue(ediItems.OfType<EdiControl<S_UNB>>().Count() == 1);
            Assert.IsTrue(ediItems.OfType<EdiControl<S_UNZ>>().Count() == 1);
            Assert.IsTrue(!ediItems.OfType<EdiControl<S_UNG>>().Any());
            Assert.IsTrue(!ediItems.OfType<EdiControl<S_UNE>>().Any());
            foreach (var item in ediItems)
            {
                var message = item as EdiMessage;
                if (message == null) continue;
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
            var ediItems = TestHelper.Parse(sample).ToList();

            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsNotNull(ediItems.OfType<EdiControl<S_UNB>>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<EdiControl<S_UNG>>().SingleOrDefault());
            var parsedXml = TestHelper.Serialize(ediItems.OfType<EdiMessage>().Single().Value, TargetNamespace);
            Assert.AreEqual(parsedXml.ToString(), expectedXml.ToString());
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
        public void TestParseWithEscapedEscape()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_EscapedEscape.txt";
            const string expectedResult = "EdiFabric.Tests.Xml.Edifact_INVOIC_D00A_EscapedEscape.xml";
            var expectedXml = XElement.Load(TestHelper.Load(expectedResult));

            // ACT
            var ediItems = TestHelper.Parse(sample).ToList();

            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsNotNull(ediItems.OfType<EdiControl<S_UNB>>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<EdiControl<S_UNG>>().SingleOrDefault());
            var parsedXml = TestHelper.Serialize(ediItems.OfType<EdiMessage>().Single().Value, TargetNamespace);
            Assert.AreEqual(parsedXml.ToString(), expectedXml.ToString());
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
        public void TestParseWithRepeatingDataElement()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_RepeatingDataElement.txt";
            const string expectedResult = "EdiFabric.Tests.Xml.Edifact_INVOIC_D00A_RepeatingDataElement.xml";
            var expectedXml = XElement.Load(TestHelper.Load(expectedResult));

            // ACT
            var ediItems = TestHelper.Parse(sample).ToList();

            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsNotNull(ediItems.OfType<EdiControl<S_UNB>>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<EdiControl<S_UNG>>().SingleOrDefault());
            var parsedXml = TestHelper.Serialize(ediItems.OfType<EdiMessage>().Single().Value, TargetNamespace);
            Assert.AreEqual(parsedXml.ToString(), expectedXml.ToString());
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
        public void TestParseWithEscapedRepetiton()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_EscapedRepetition.txt";
            const string expectedResult = "EdiFabric.Tests.Xml.Edifact_INVOIC_D00A_EscapedRepetition.xml";
            var expectedXml = XElement.Load(TestHelper.Load(expectedResult));

            // ACT
            var ediItems = TestHelper.Parse(sample).ToList();

            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsNotNull(ediItems.OfType<EdiControl<S_UNB>>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<EdiControl<S_UNG>>().SingleOrDefault());
            var parsedXml = TestHelper.Serialize(ediItems.OfType<EdiMessage>().Single().Value, TargetNamespace);
            Assert.AreEqual(parsedXml.ToString(), expectedXml.ToString());
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
        public void TestParseWithHeaders()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_Group.txt";
            const string expectedGroup = "EdiFabric.Tests.Xml.Edifact_Group.xml";
            var expectedXmlGroup = XElement.Load(TestHelper.Load(expectedGroup));
            const string expectedInterchange = "EdiFabric.Tests.Xml.Edifact_Interchange.xml";
            var expectedXmlInterchange = XElement.Load(TestHelper.Load(expectedInterchange));

            // ACT
            var ediItems = TestHelper.Parse(sample).ToList();

            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsNotNull(ediItems.OfType<EdiControl<S_UNB>>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<EdiControl<S_UNG>>().SingleOrDefault());
            var parsedXmlInterchange =
                TestHelper.Serialize(ediItems.OfType<EdiControl<S_UNB>>().First().Parse(),
                    TargetNamespace);
            Assert.AreEqual(parsedXmlInterchange.ToString(), expectedXmlInterchange.ToString());
            var parsedXmlGroup =
                TestHelper.Serialize(ediItems.OfType<EdiControl<S_UNG>>().First().Parse(),
                    TargetNamespace);
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
            var ediItems = TestHelper.Parse(sample).ToList();

            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsNotNull(ediItems.OfType<EdiControl<S_UNB>>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<EdiControl<S_UNG>>().SingleOrDefault());
            var parsedXml = TestHelper.Serialize(ediItems.OfType<EdiMessage>().Single().Value, TargetNamespace);
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
            var items = TestHelper.ParseMultiple(sample).ToList();

            // ASSERT
            Assert.IsTrue(items.Count == 6);
            var parsedXmlInterchange =
                TestHelper.Serialize(items.OfType<EdiControl<S_UNB>>().First().Parse(),
                    TargetNamespace);
            Assert.AreEqual(parsedXmlInterchange.ToString(), expectedXmlInterchange.ToString());
            var parsedXmlInterchange2 =
                TestHelper.Serialize(items.OfType<EdiControl<S_UNB>>().Last().Parse(),
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
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_InvalidTrailers.txt";

            // ACT
            var ediItems = TestHelper.ParseMultiple(sample);

            // ASSERT
            Assert.IsNotNull(ediItems.OfType<EdiError>().SingleOrDefault());
        }

        [TestMethod]
        public void TestParseWithInvalidHeader()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_InvalidHeader.txt";

            // ACT
            var ediItems = TestHelper.Parse(sample).ToList();

            // ASSERT
            Assert.IsTrue(ediItems.Count() == 1);
            Assert.IsNotNull(ediItems.OfType<EdiError>().SingleOrDefault());
        }

        [TestMethod]
        public void TestParseWithInvalidSegment()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_InvalidSegment.txt";

            // ACT
            var ediItems = TestHelper.ParseMultiple(sample);

            // ASSERT
            Assert.IsNotNull(ediItems.OfType<EdiError>().SingleOrDefault());
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
        public void TestParseWithRulesAssemblyName()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A.txt";
            const string expectedResult = "EdiFabric.Tests.Xml.Edifact_INVOIC_D00A.xml";
            var expectedXml = XElement.Load(TestHelper.Load(expectedResult));

            // ACT
            var ediItems = TestHelper.Parse(sample).ToList();

            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsNotNull(ediItems.OfType<EdiControl<S_UNB>>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<EdiControl<S_UNG>>().SingleOrDefault());
            var parsedXml = TestHelper.Serialize(ediItems.OfType<EdiMessage>().Single().Value, TargetNamespace);
            Assert.AreEqual(parsedXml.ToString(), expectedXml.ToString());
        }
    }
}
