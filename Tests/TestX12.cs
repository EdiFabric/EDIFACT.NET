using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using EdiFabric.Framework;
using EdiFabric.Framework.Controls;
using EdiFabric.Framework.Exceptions;
using EdiFabric.Framework.Readers;
using EdiFabric.Framework.Validation;
using EdiFabric.Rules.X12002040810;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EdiFabric.Tests
{
    [TestClass]
    public class TestX12
    {
        [TestMethod]
        public void TestParseX12()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.X12_810_00204.txt";
            const string expectedResult = "EdiFabric.Tests.Xml.X12_810_00204.xml";
            var expectedXml = XElement.Load(TestHelper.Load(expectedResult));

            // ACT
            var ediItems = TestHelper.ParseX12(sample).ToList();

            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsNotNull(ediItems.OfType<S_ISA>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<S_GS>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<M_810>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<S_GE>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<S_IEA>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<ParsingException>().SingleOrDefault());
            var parsedXml = TestHelper.Serialize(ediItems.OfType<M_810>().Single());
            Assert.IsNotNull(parsedXml.Root);
            Assert.AreEqual(parsedXml.Root.ToString(), expectedXml.ToString());
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
        public void TestParseX12WithValidationFailure()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.X12_810_00204.txt";

            // ACT
            var message = TestHelper.ParseX12(sample).OfType<M_810>().Single();
            var validationResults = EdiValidator.Create(new ValidatorSettings("EdiFabric.Xsd")).Validate(message);

            // ASSERT
            Assert.IsNotNull(validationResults);
            Assert.IsNotNull(validationResults.ErrorContext);
            Assert.IsTrue(validationResults.ErrorContext.Errors.Any() || validationResults.ErrorContext.Codes.Any());
        }

        [TestMethod]
        public void TestParseX12WithValidation()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.X12_810_00204_Valid.txt";

            // ACT
            var message = TestHelper.ParseX12(sample).OfType<M_810>().Single();
            var validationResults = EdiValidator.Create(new ValidatorSettings("EdiFabric.Xsd")).Validate(message);

            // ASSERT
            Assert.IsNotNull(validationResults);
            Assert.IsNotNull(validationResults.ErrorContext);
            Assert.IsFalse(validationResults.ErrorContext.Errors.Any());
            Assert.IsFalse(validationResults.ErrorContext.Codes.Any());
        }

        [TestMethod]
        public void TestParseX12WithRepetitionSeparator()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.X12_810_00204_RepetitionSeparator.txt";
            const string expectedResult = "EdiFabric.Tests.Xml.X12_810_00204_RepetitionSeparator.xml";
            var expectedXml = XElement.Load(TestHelper.Load(expectedResult));

            // ACT
            var ediItems = TestHelper.ParseX12(sample, null, null, "EdiFabric.Rules.Rep").ToList();

            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsNotNull(ediItems.OfType<S_ISA>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<S_GS>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<Rules.Rep.X12002040810.M_810>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<S_GE>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<S_IEA>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<ParsingException>().SingleOrDefault());
            var parsedXml = TestHelper.Serialize(ediItems.OfType<Rules.Rep.X12002040810.M_810>().Single());
            Assert.IsNotNull(parsedXml.Root);
            Assert.AreEqual(parsedXml.Root.ToString(), expectedXml.ToString());
        }

        [TestMethod]
        public void TestGenerateWithRepetitionSeparator()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.X12_810_00204_RepetitionSeparator.txt";
            var interchange = TestHelper.GenerateX12<Rules.Rep.X12002040810.M_810>(sample, "EdiFabric.Rules.Rep");

            // ACT
            var defaultSeparators = Separators.DefaultX12();
            var newSeparators = new Separators(defaultSeparators.Segment,
                '>', defaultSeparators.DataElement, '!', null);
            var ediSegments = interchange.GenerateEdi(newSeparators);

            // ASSERT
            Assert.AreEqual(TestHelper.AsString(sample), TestHelper.AsString(ediSegments, Environment.NewLine));
        }

        [TestMethod]
        public void TestParseX12WithSegmentSeparatorLf()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.X12_810_00204_SegmentSeparatorLF.txt";
            const string expectedResult = "EdiFabric.Tests.Xml.X12_810_00204.xml";
            var expectedXml = XElement.Load(TestHelper.Load(expectedResult));

            // ACT
            var ediItems = TestHelper.ParseX12(sample).ToList();

            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsNotNull(ediItems.OfType<S_ISA>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<S_GS>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<M_810>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<S_GE>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<S_IEA>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<ParsingException>().SingleOrDefault());
            var parsedXml = TestHelper.Serialize(ediItems.OfType<M_810>().Single());
            Assert.IsNotNull(parsedXml.Root);
            Assert.AreEqual(parsedXml.Root.ToString(), expectedXml.ToString());
        }

        [TestMethod]
        public void TestParseX12WithLf()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.X12_810_00204_LF.txt";
            const string expectedResult = "EdiFabric.Tests.Xml.X12_810_00204.xml";
            var expectedXml = XElement.Load(TestHelper.Load(expectedResult));

            // ACT
            var ediItems = TestHelper.ParseX12(sample).ToList();

            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsNotNull(ediItems.OfType<S_ISA>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<S_GS>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<M_810>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<S_GE>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<S_IEA>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<ParsingException>().SingleOrDefault());
            var parsedXml = TestHelper.Serialize(ediItems.OfType<M_810>().Single());
            Assert.IsNotNull(parsedXml.Root);
            Assert.AreEqual(parsedXml.Root.ToString(), expectedXml.ToString());
        }

        [TestMethod]
        public void TestGenerateWithSegmentSeparatorLf()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.X12_810_00204_SegmentSeparatorLF.txt";
            var interchange = TestHelper.GenerateX12<M_810>(sample);

            // ACT
            var defaultSeparators = Separators.DefaultX12();
            var newSeparators = new Separators('\n',
                '>', defaultSeparators.DataElement, defaultSeparators.RepetitionDataElement, null);
            var ediSegments = interchange.GenerateEdi(newSeparators);

            // ASSERT
            Assert.AreEqual(TestHelper.AsString(sample, false), TestHelper.AsString(ediSegments, null));
        }

        [TestMethod]
        public void TestParseX12WithError()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.X12_810_00204_BadSegment.txt";

            // ACT
            var ediItems = TestHelper.ParseX12(sample).ToList();

            // ASSERT
            Assert.IsNotNull(ediItems.OfType<S_ISA>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<S_GS>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<ParsingException>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<S_GE>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<S_IEA>().SingleOrDefault());
        }

        [TestMethod]
        public void TestParseX12WithMultipleGroups()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.X12_810_00204_MultipleGroups.txt";
            const string expectedResult = "EdiFabric.Tests.Xml.X12_810_00204.xml";
            var expectedXml = XElement.Load(TestHelper.Load(expectedResult));

            // ACT
            var ediItems = TestHelper.ParseX12(sample).ToList();

            // ASSERT
            Assert.IsTrue(ediItems.OfType<M_810>().Count() == 2);
            Assert.IsTrue(ediItems.OfType<S_ISA>().Count() == 1);
            Assert.IsTrue(ediItems.OfType<S_GS>().Count() == 2);
            Assert.IsTrue(ediItems.OfType<S_GE>().Count() == 2);
            Assert.IsTrue(ediItems.OfType<S_IEA>().Count() == 1);
            Assert.IsNull(ediItems.OfType<ParsingException>().SingleOrDefault());
            foreach (var item in ediItems)
            {
                var message = item as M_810;
                if (message == null) continue;
                var parsedXml = TestHelper.Serialize(message);
                Assert.IsNotNull(parsedXml.Root);
                Assert.AreEqual(parsedXml.Root.ToString(), expectedXml.ToString());
            }
        }

        [TestMethod]
        public void TestParseX12WithMultipleMessages()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.X12_810_00204_MultipleMessages.txt";
            const string expectedResult = "EdiFabric.Tests.Xml.X12_810_00204.xml";
            var expectedXml = XElement.Load(TestHelper.Load(expectedResult));

            // ACT
            var ediItems = TestHelper.ParseX12(sample).ToList();

            // ASSERT
            Assert.IsTrue(ediItems.OfType<M_810>().Count() == 2);
            Assert.IsTrue(ediItems.OfType<S_ISA>().Count() == 1);
            Assert.IsTrue(ediItems.OfType<S_GS>().Count() == 1);
            Assert.IsTrue(ediItems.OfType<S_GE>().Count() == 1);
            Assert.IsTrue(ediItems.OfType<S_IEA>().Count() == 1);
            Assert.IsNull(ediItems.OfType<ParsingException>().SingleOrDefault());
            foreach (var item in ediItems)
            {
                var message = item as M_810;
                if (message == null) continue;
                var parsedXml = TestHelper.Serialize(message);
                Assert.IsNotNull(parsedXml.Root);
                Assert.AreEqual(parsedXml.Root.ToString(), expectedXml.ToString());
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
        public void TestParseX12WithHeaders()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.X12_810_00204.txt";
            const string expectedGroup = "EdiFabric.Tests.Xml.X12_Group.xml";
            var expectedXmlGroup = XElement.Load(TestHelper.Load(expectedGroup));
            const string expectedInterchange = "EdiFabric.Tests.Xml.X12_Interchange.xml";
            var expectedXmlInterchange = XElement.Load(TestHelper.Load(expectedInterchange),
                LoadOptions.PreserveWhitespace);

            // ACT
            var ediItems = TestHelper.ParseX12(sample).ToList();

            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsNotNull(ediItems.OfType<S_ISA>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<S_GS>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<M_810>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<S_GE>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<S_IEA>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<ParsingException>().SingleOrDefault());
            var parsedXmlInterchange = TestHelper.Serialize(ediItems.OfType<S_ISA>().First());
            Assert.IsNotNull(parsedXmlInterchange.Root);
            Assert.AreEqual(parsedXmlInterchange.Root.ToString(), expectedXmlInterchange.ToString());
            var parsedXmlGroup = TestHelper.Serialize(ediItems.OfType<S_GS>().First());
            Assert.IsNotNull(parsedXmlGroup.Root);
            Assert.AreEqual(parsedXmlGroup.Root.ToString(), expectedXmlGroup.ToString());
        }

        [TestMethod]
        public void TestParseX12WithTrailingBlanks()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.X12_810_00204_TrailingBlanks.txt";
            const string expectedResult = "EdiFabric.Tests.Xml.X12_810_00204.xml";
            var expectedXml = XElement.Load(TestHelper.Load(expectedResult));

            // ACT
            var ediItems = TestHelper.ParseX12(sample).ToList();

            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsNotNull(ediItems.OfType<S_ISA>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<S_GS>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<M_810>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<S_GE>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<S_IEA>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<ParsingException>().SingleOrDefault());
            var parsedXml = TestHelper.Serialize(ediItems.OfType<M_810>().Single());
            Assert.IsNotNull(parsedXml.Root);
            Assert.AreEqual(parsedXml.Root.ToString(), expectedXml.ToString());
        }

        [TestMethod]
        public void TestParseX12WithMultipleInterchange()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.X12_810_00204_MultipleInterchanges.txt";
            const string expectedResult = "EdiFabric.Tests.Xml.X12_810_00204.xml";
            var expectedXml = XElement.Load(TestHelper.Load(expectedResult));
            const string expectedInterchange = "EdiFabric.Tests.Xml.X12_Interchange.xml";
            var expectedXmlInterchange = XElement.Load(TestHelper.Load(expectedInterchange),
                LoadOptions.PreserveWhitespace);
            const string expectedInterchange2 = "EdiFabric.Tests.Xml.X12_Interchange2.xml";
            var expectedXmlInterchange2 = XElement.Load(TestHelper.Load(expectedInterchange2),
                LoadOptions.PreserveWhitespace);

            // ACT
            var items = TestHelper.ParseX12(sample).ToList();

            // ASSERT
            Assert.IsTrue(items.Count == 10);
            Assert.IsTrue(items.OfType<M_810>().Count() == 2);
            Assert.IsTrue(items.OfType<S_ISA>().Count() == 2);
            Assert.IsTrue(items.OfType<S_GS>().Count() == 2);
            Assert.IsTrue(items.OfType<S_GE>().Count() == 2);
            Assert.IsTrue(items.OfType<S_IEA>().Count() == 2);
            Assert.IsNull(items.OfType<ParsingException>().SingleOrDefault());
            var parsedXmlInterchange = TestHelper.Serialize(items.OfType<S_ISA>().First());
            Assert.IsNotNull(parsedXmlInterchange.Root);
            Assert.AreEqual(parsedXmlInterchange.Root.ToString(), expectedXmlInterchange.ToString());
            var parsedXmlInterchange2 = TestHelper.Serialize(items.OfType<S_ISA>().Last());
            Assert.IsNotNull(parsedXmlInterchange2.Root);
            Assert.AreEqual(parsedXmlInterchange2.Root.ToString(), expectedXmlInterchange2.ToString());
            foreach (var item in items.OfType<M_810>())
            {
                Assert.IsNotNull(item);
                Assert.IsNotNull(item);
                var parsedXml = TestHelper.Serialize(item);
                Assert.IsNotNull(parsedXml.Root);
                Assert.AreEqual(parsedXml.Root.ToString(), expectedXml.ToString());
            }
        }

        [TestMethod]
        public void TestParseX12WithInvalidTrailers()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.X12_810_00204_InvalidTrailers.txt";

            // ACT
            var ediItems = TestHelper.ParseX12(sample).ToList();

            // ASSERT
            Assert.IsNotNull(ediItems.OfType<S_ISA>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<S_GS>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<M_810>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<S_GE>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<S_IEA>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<ParsingException>().SingleOrDefault());
        }

        [TestMethod]
        public void TestParseX12WithInvalidHeader()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.X12_810_00204_InvalidHeader.txt";

            // ACT
            var ediItems = TestHelper.ParseX12(sample).ToList();

            // ASSERT
            Assert.IsNotNull(ediItems.OfType<ParsingException>().SingleOrDefault());
        }

        [TestMethod]
        public void TestParseX12WithInvalidSegment()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.X12_810_00204_InvalidSegment.txt";

            // ACT
            var ediItems = TestHelper.ParseX12(sample).ToList();

            // ASSERT
            Assert.IsNotNull(ediItems.OfType<S_ISA>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<S_GS>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<ParsingException>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<S_GE>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<S_IEA>().SingleOrDefault());
        }

        [TestMethod]
        public void TestParseX12WithRulesAssemblyName()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.X12_810_00204.txt";
            const string expectedResult = "EdiFabric.Tests.Xml.X12_810_00204.xml";
            var expectedXml = XElement.Load(TestHelper.Load(expectedResult));

            // ACT
            var ediItems = TestHelper.ParseX12(sample, null, "EdiFabric.Rules").ToList();

            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsNotNull(ediItems.OfType<S_ISA>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<S_GS>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<M_810>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<S_GE>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<S_IEA>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<ParsingException>().SingleOrDefault());
            var parsedXml = TestHelper.Serialize(ediItems.OfType<M_810>().Single());
            Assert.IsNotNull(parsedXml.Root);
            Assert.AreEqual(parsedXml.Root.ToString(), expectedXml.ToString());
        }

        [TestMethod]
        public void TestParseX12WithGroupRead()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.X12_810_00204_MultipleGroups.txt";
            var ediItems = new List<object>();

            // ACT
            using (var ediReader = X12Reader.Create(TestHelper.Load(sample), new ReaderSettings("EdiFabric.Rules")))
            {
                while (ediReader.Read())
                {
                    ediItems.Add(ediReader.Item);
                    if (!(ediReader.Item is S_GE)) continue;

                    // ASSERT
                    Assert.IsNotNull(ediItems.OfType<S_GS>().SingleOrDefault());
                    Assert.IsNotNull(ediItems.OfType<M_810>().SingleOrDefault());
                    Assert.IsNotNull(ediItems.OfType<S_GE>().SingleOrDefault());
                    Assert.IsNull(ediItems.OfType<ParsingException>().SingleOrDefault());
                    ediItems.Clear();
                }
            }
        }

        [TestMethod]
        public void TestParseX12WithInterchangeRead()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.X12_810_00204_MultipleInterchanges.txt";
            var ediItems = new List<object>();

            // ACT
            using (var ediReader = X12Reader.Create(TestHelper.Load(sample), new ReaderSettings("EdiFabric.Rules")))
            {
                while (ediReader.Read())
                {
                    ediItems.Add(ediReader.Item);
                    if (!(ediReader.Item is S_IEA)) continue;

                    // ASSERT
                    Assert.IsNotNull(ediItems.OfType<S_ISA>().SingleOrDefault());
                    Assert.IsNotNull(ediItems.OfType<S_GS>().SingleOrDefault());
                    Assert.IsNotNull(ediItems.OfType<M_810>().SingleOrDefault());
                    Assert.IsNotNull(ediItems.OfType<S_GE>().SingleOrDefault());
                    Assert.IsNotNull(ediItems.OfType<S_IEA>().SingleOrDefault());
                    Assert.IsNull(ediItems.OfType<ParsingException>().SingleOrDefault());
                    ediItems.Clear();
                }
            }
        }

        [TestMethod]
        public void TestParseX12WithMissingGroupTrailer()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.X12_810_00204_MissingGroupTrailer.txt";
            var ediItems = new List<object>();

            // ACT
            using (var ediReader = X12Reader.Create(TestHelper.Load(sample), new ReaderSettings("EdiFabric.Rules")))
            {
                while (ediReader.Read())
                {
                    ediItems.Add(ediReader.Item);
                }
            }

            // ASSERT
            Assert.IsNotNull(ediItems.OfType<S_ISA>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<S_GS>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<M_810>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<S_GE>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<S_IEA>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<ParsingException>().SingleOrDefault());
        }

        [TestMethod]
        public void TestParseX12WithMissingInterchangeTrailer()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.X12_810_00204_MissingInterchangeTrailer.txt";
            var ediItems = new List<object>();

            // ACT
            using (var ediReader = X12Reader.Create(TestHelper.Load(sample), new ReaderSettings("EdiFabric.Rules")))
            {
                while (ediReader.Read())
                {
                    ediItems.Add(ediReader.Item);
                }
            }

            // ASSERT
            Assert.IsNotNull(ediItems.OfType<S_ISA>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<S_GS>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<M_810>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<S_GE>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<S_IEA>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<ParsingException>().SingleOrDefault());
        }

        [TestMethod]
        public void TestParseX12WithValidAndInvalidMessageRead()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.X12_810_00204_ValidAndInvalidMessage.txt";

            // ACT
            using (var ediReader = X12Reader.Create(TestHelper.Load(sample), new ReaderSettings("EdiFabric.Rules")))
            {
                var ediItems = ediReader.ReadToEnd().ToList();

                // ASSERT
                Assert.IsNotNull(ediItems.OfType<S_ISA>().SingleOrDefault());
                Assert.IsNotNull(ediItems.OfType<S_GS>().SingleOrDefault());
                Assert.IsNotNull(ediItems.OfType<ParsingException>().SingleOrDefault());
                Assert.IsNotNull(ediItems.OfType<M_810>().SingleOrDefault());
                Assert.IsNotNull(ediItems.OfType<S_GE>().SingleOrDefault());
                Assert.IsNotNull(ediItems.OfType<S_IEA>().SingleOrDefault());
            }
        }

        [TestMethod]
        public void TestParseX12WithVersionFromSt()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.X12_810_00204_VersionFromSt.txt";

            // ACT
            using (var ediReader = X12Reader.Create(TestHelper.Load(sample), new ReaderSettings("EdiFabric.Rules")))
            {
                var ediItems = ediReader.ReadToEnd().ToList();

                // ASSERT
                Assert.IsNotNull(ediItems.OfType<S_ISA>().SingleOrDefault());
                Assert.IsNotNull(ediItems.OfType<S_GS>().SingleOrDefault());
                Assert.IsNotNull(ediItems.OfType<M_810>().SingleOrDefault());
                Assert.IsNotNull(ediItems.OfType<S_GE>().SingleOrDefault());
                Assert.IsNotNull(ediItems.OfType<S_IEA>().SingleOrDefault());
                Assert.IsNull(ediItems.OfType<ParsingException>().SingleOrDefault());
            }
        }

        [TestMethod]
        public void TestParseX12WithNoRepetition()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.X12_810_00204_NoRepetition.txt";
            const string expectedResult = "EdiFabric.Tests.Xml.X12_810_00204_NoRepetition.xml";
            var expectedXml = XElement.Load(TestHelper.Load(expectedResult));

            // ACT
            var ediItems = TestHelper.ParseX12(sample).ToList();

            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsNotNull(ediItems.OfType<S_ISA>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<S_GS>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<M_810>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<S_GE>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<S_IEA>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<ParsingException>().SingleOrDefault());
            var parsedXml = TestHelper.Serialize(ediItems.OfType<M_810>().Single());
            Assert.IsNotNull(parsedXml.Root);
            Assert.AreEqual(parsedXml.Root.ToString(), expectedXml.ToString());
        }

        [TestMethod]
        public void TestParseX12WithBlankRepetition()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.X12_810_00204_BlankRepetition.txt";
            const string expectedResult = "EdiFabric.Tests.Xml.X12_810_00204.xml";
            var expectedXml = XElement.Load(TestHelper.Load(expectedResult));

            // ACT
            var ediItems = TestHelper.ParseX12(sample).ToList();

            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsNotNull(ediItems.OfType<S_ISA>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<S_GS>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<M_810>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<S_GE>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<S_IEA>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<ParsingException>().SingleOrDefault());
            var parsedXml = TestHelper.Serialize(ediItems.OfType<M_810>().Single());
            Assert.IsNotNull(parsedXml.Root);
            Assert.AreEqual(parsedXml.Root.ToString(), expectedXml.ToString());
        }

        [TestMethod]
        public void TestParseX12WithMultipleInvalidInterchanges()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.X12_810_00204_MultipleInvalidInterchanges.txt";
            const string expectedResult = "EdiFabric.Tests.Xml.X12_810_00204.xml";
            var expectedXml = XElement.Load(TestHelper.Load(expectedResult));

            // ACT
            var items = TestHelper.ParseX12(sample).ToList();

            // ASSERT
            Assert.IsTrue(items.OfType<M_810>().Count() == 3);
            Assert.IsTrue(items.OfType<S_ISA>().Count() == 2);
            Assert.IsTrue(items.OfType<S_GS>().Count() == 3);
            Assert.IsTrue(items.OfType<S_GE>().Count() == 3);
            Assert.IsTrue(items.OfType<S_IEA>().Count() == 2);
            Assert.IsNotNull(items.OfType<ParsingException>().SingleOrDefault());

            foreach (var msg in items.OfType<M_810>())
            {
                var parsedXml = TestHelper.Serialize(msg);
                Assert.IsNotNull(parsedXml.Root);
                Assert.AreEqual(parsedXml.Root.ToString(), expectedXml.ToString());
            }
        }

        [TestMethod]
        public void TestParseX12WithMultipleInvalidIMessages()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.X12_810_00204_MultipleInvalidMessages.txt";
            const string expectedResult = "EdiFabric.Tests.Xml.X12_810_00204_Probe.xml";
            var expectedXml = XElement.Load(TestHelper.Load(expectedResult));

            // ACT
            var ediItems = TestHelper.ParseX12(sample).ToList();

            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsNotNull(ediItems.OfType<S_ISA>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<S_GS>().SingleOrDefault());
            Assert.IsTrue(ediItems.OfType<M_810>().Count() == 3);
            Assert.IsNotNull(ediItems.OfType<S_GE>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<S_IEA>().SingleOrDefault());
            Assert.IsTrue(ediItems.OfType<ParsingException>().Count() == 2);

            foreach (var msg in ediItems.OfType<M_810>().Skip(1))
            {
                var parsedXml = TestHelper.Serialize(msg);
                Assert.IsNotNull(parsedXml.Root);
                Assert.AreEqual(parsedXml.Root.ToString(), expectedXml.ToString());
            }
        }

        [TestMethod]
        public void TestValidationRules()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Xml.X12_810_00204_Validation.xml";
            var obj = TestHelper.Deserialize<Rules.Rep.X12002040810.M_810>(TestHelper.Load(sample));
            const string expectedResult = "EdiFabric.Tests.Xml.X12_810_00204_ValidationExpected.xml";
            var expectedXml = XElement.Load(TestHelper.Load(expectedResult));

            // ACT
            var error = EdiValidator.Create(new ValidatorSettings("EdiFabric.Xsd")).Validate(obj);

            // ASSERT
            Assert.IsNotNull(error);
            var root = TestHelper.Serialize(error.Flatten().ToList()).Root;
            Assert.IsNotNull(root);
            Assert.AreEqual(root.ToString(), expectedXml.ToString());
        }

        [TestMethod]
        public void TestParseX12WithTa1()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.X12_810_00204_TA1.txt";
            const string expectedResult = "EdiFabric.Tests.Xml.X12_810_00204.xml";
            var expectedXml = XElement.Load(TestHelper.Load(expectedResult));

            // ACT
            var ediItems = TestHelper.ParseX12(sample).ToList();

            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsNotNull(ediItems.OfType<S_ISA>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<S_TA1>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<S_GS>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<M_810>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<S_GE>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<S_IEA>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<ParsingException>().SingleOrDefault());
            var parsedXml = TestHelper.Serialize(ediItems.OfType<M_810>().Single());
            Assert.IsNotNull(parsedXml.Root);
            Assert.AreEqual(parsedXml.Root.ToString(), expectedXml.ToString());
        }
    }
}

