using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using EdiFabric.Framework;
using EdiFabric.Framework.Controls;
using EdiFabric.Framework.Exceptions;
using EdiFabric.Framework.Readers;
using EdiFabric.Rules.X12002040810;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EdiFabric.Tests
{
    [TestClass]
    public class TestX12
    {
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
            Assert.IsNotNull(ediItems.OfType<S_ISA>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<S_GS>().SingleOrDefault());
            var parsedXml = ediItems.OfType<M_810>().Single().Serialize();
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
        public void TestParseWithValidationFailure()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.X12_810_00204.txt";
           
            // ACT
            var message = TestHelper.Parse(sample).OfType<M_810>().Single();
            var brokenRules = message.Validate();

            // ASSERT
            Assert.IsTrue(brokenRules.Any());
        }

        [TestMethod]
        public void TestParseWithValidation()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.X12_810_00204_Valid.txt";
            
            // ACT
            var message = TestHelper.Parse(sample).OfType<M_810>().Single();
            var brokenRules = message.Validate();

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
            Assert.IsNotNull(ediItems.OfType<S_ISA>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<S_GS>().SingleOrDefault());
            var parsedXml = ediItems.OfType<Rules.Rep.X12002040810.M_810>().Single().Serialize();
            Assert.AreEqual(parsedXml.Root.ToString(), expectedXml.ToString());
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
            Assert.IsNotNull(ediItems.OfType<S_ISA>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<S_GS>().SingleOrDefault());
            var parsedXml = ediItems.OfType<M_810>().Single().Serialize();
            Assert.AreEqual(parsedXml.Root.ToString(), expectedXml.ToString());
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
            Assert.IsNotNull(ediItems.OfType<S_ISA>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<S_GS>().SingleOrDefault());
            var parsedXml = ediItems.OfType<M_810>().Single().Serialize();
            Assert.AreEqual(parsedXml.Root.ToString(), expectedXml.ToString());
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
            Assert.IsNotNull(ediItems.OfType<ParsingException>().SingleOrDefault());
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
            var interchange = new X12Interchange(items.OfType<S_ISA>().Single());
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
            var ediItems = TestHelper.Parse(sample).ToList();

            // ASSERT
            Assert.IsTrue(ediItems.OfType<M_810>().Count() == 2);
            Assert.IsTrue(ediItems.OfType<S_ISA>().Count() == 1);
            Assert.IsTrue(ediItems.OfType<S_GS>().Count() == 2);
            Assert.IsTrue(ediItems.OfType<S_GE>().Count() == 2);
            Assert.IsTrue(ediItems.OfType<S_IEA>().Count() == 1);
            foreach (var item in ediItems)
            {
                var message = item as M_810;
                if (message == null) continue;
                var parsedXml = message.Serialize();
                Assert.AreEqual(parsedXml.Root.ToString(), expectedXml.ToString());
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
            var ediItems = TestHelper.Parse(sample).ToList();

            // ASSERT
            Assert.IsTrue(ediItems.OfType<M_810>().Count() == 2);
            Assert.IsTrue(ediItems.OfType<S_ISA>().Count() == 1);
            Assert.IsTrue(ediItems.OfType<S_GS>().Count() == 1);
            Assert.IsTrue(ediItems.OfType<S_GE>().Count() == 1);
            Assert.IsTrue(ediItems.OfType<S_IEA>().Count() == 1);
            foreach (var item in ediItems)
            {
                var message = item as M_810;
                if (message == null) continue;
                var parsedXml = message.Serialize();
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
            Assert.IsNotNull(ediItems.OfType<S_ISA>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<S_GS>().SingleOrDefault());
            var parsedXmlInterchange = ediItems.OfType<S_ISA>().First().Serialize();
            Assert.AreEqual(parsedXmlInterchange.Root.ToString(), expectedXmlInterchange.ToString());
            var parsedXmlGroup = ediItems.OfType<S_GS>().First().Serialize();
            Assert.AreEqual(parsedXmlGroup.Root.ToString(), expectedXmlGroup.ToString());
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
            Assert.IsNotNull(ediItems.OfType<S_ISA>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<S_GS>().SingleOrDefault());
            var parsedXml = ediItems.OfType<M_810>().Single().Serialize();
            Assert.AreEqual(parsedXml.Root.ToString(), expectedXml.ToString());
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
            var items = TestHelper.Parse(sample).ToList();

            // ASSERT
            Assert.IsTrue(items.Count == 10);
            Assert.IsTrue(items.OfType<M_810>().Count() == 2);
            Assert.IsTrue(items.OfType<S_ISA>().Count() == 2);
            Assert.IsTrue(items.OfType<S_GS>().Count() == 2);
            Assert.IsTrue(items.OfType<S_GE>().Count() == 2);
            Assert.IsTrue(items.OfType<S_IEA>().Count() == 2);
            var parsedXmlInterchange = items.OfType<S_ISA>().First().Serialize();
            Assert.AreEqual(parsedXmlInterchange.Root.ToString(), expectedXmlInterchange.ToString());
            var parsedXmlInterchange2 = items.OfType<S_ISA>().Last().Serialize();
            Assert.AreEqual(parsedXmlInterchange2.Root.ToString(), expectedXmlInterchange2.ToString());
            foreach (var item in items.OfType<M_810>())
            {
                Assert.IsNotNull(item);
                Assert.IsNotNull(item);
                var parsedXml = item.Serialize();
                Assert.AreEqual(parsedXml.Root.ToString(), expectedXml.ToString());
            }
        }

        [TestMethod]
        public void TestParseWithInvalidTrailers()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.X12_810_00204_InvalidTrailers.txt";

            // ACT
            var ediItems = TestHelper.Parse(sample);

            // ASSERT
            Assert.IsNotNull(ediItems.OfType<ParsingException>().SingleOrDefault());
        }

        [TestMethod]
        public void TestParseWithInvalidHeader()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.X12_810_00204_InvalidHeader.txt";

            // ACT
            var ediItems = TestHelper.Parse(sample);

            // ASSERT
            Assert.IsNotNull(ediItems.OfType<ParsingException>().SingleOrDefault());
        }

        [TestMethod]
        public void TestParseWithInvalidSegment()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.X12_810_00204_InvalidSegment.txt";

            // ACT
            var ediItems = TestHelper.Parse(sample);

            // ASSERT
            Assert.IsNotNull(ediItems.OfType<ParsingException>().SingleOrDefault());
        }

        [TestMethod]
        public void TestParseWithRulesAssemblyName()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.X12_810_00204.txt";
            const string expectedResult = "EdiFabric.Tests.Xml.X12_810_00204.xml";
            var expectedXml = XElement.Load(TestHelper.Load(expectedResult));

            // ACT
            var ediItems = TestHelper.Parse(sample, null, "EdiFabric.Rules").ToList();

            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsNotNull(ediItems.OfType<S_ISA>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<S_GS>().SingleOrDefault());
            var parsedXml = ediItems.OfType<M_810>().Single().Serialize();
            Assert.AreEqual(parsedXml.Root.ToString(), expectedXml.ToString());
        }

        [TestMethod]
        public void TestParseWithGroupRead()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.X12_810_00204_MultipleGroups.txt";
            var ediItems = new List<object>();

            // ACT
            using (var ediReader = EdiReader.Create(TestHelper.Load(sample)))
            {
                while (ediReader.Read())
                {
                    ediItems.Add(ediReader.Item);
                    if (!(ediReader.Item is S_GE)) continue;

                    // ASSERT
                    Assert.IsNotNull(ediItems.OfType<S_GS>().SingleOrDefault());
                    Assert.IsNotNull(ediItems.OfType<S_GE>().SingleOrDefault());
                    ediItems.Clear();
                }
            }
        }

        [TestMethod]
        public void TestParseWithInterchangeRead()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.X12_810_00204_MultipleInterchanges.txt";
            var ediItems = new List<object>();

            // ACT
            using (var ediReader = EdiReader.Create(TestHelper.Load(sample)))
            {
                while (ediReader.Read())
                {
                    ediItems.Add(ediReader.Item);
                    if (!(ediReader.Item is S_IEA)) continue;

                    // ASSERT
                    Assert.IsNotNull(ediItems.OfType<S_ISA>().SingleOrDefault());
                    Assert.IsNotNull(ediItems.OfType<S_IEA>().SingleOrDefault());
                    ediItems.Clear();
                }
            }
        }

        [TestMethod]
        public void TestParseWithMissingGroupTrailer()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.X12_810_00204_MissingGroupTrailer.txt";
            var ediItems = new List<object>();

            // ACT
            using (var ediReader = EdiReader.Create(TestHelper.Load(sample)))
            {
                while (ediReader.Read())
                {
                    ediItems.Add(ediReader.Item);
                }
            }

            // ASSERT
            Assert.IsNotNull(ediItems.OfType<S_ISA>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<S_GS>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<S_GE>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<ParsingException>().SingleOrDefault());
        }

        [TestMethod]
        public void TestParseWithMissingInterchangeTrailer()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.X12_810_00204_MissingInterchangeTrailer.txt";
            var ediItems = new List<object>();

            // ACT
            using (var ediReader = EdiReader.Create(TestHelper.Load(sample)))
            {
                while (ediReader.Read())
                {
                    ediItems.Add(ediReader.Item);
                }
            }

            // ASSERT
            Assert.IsNotNull(ediItems.OfType<S_ISA>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<S_GS>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<S_GE>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<S_IEA>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<M_810>().SingleOrDefault());
        }

        [TestMethod]
        public void TestParseWithValidAndInvalidMessageRead()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.X12_810_00204_ValidAndInvalidMessage.txt";

            // ACT
            using (var ediReader = EdiReader.Create(TestHelper.Load(sample)))
            {
                var ediItems = ediReader.ReadToEnd().ToList();

                // ASSERT
                Assert.IsNotNull(ediItems.OfType<S_ISA>().SingleOrDefault());
                Assert.IsNotNull(ediItems.OfType<S_GS>().SingleOrDefault());
                Assert.IsNotNull(ediItems.OfType<S_GE>().SingleOrDefault());
                Assert.IsNotNull(ediItems.OfType<S_IEA>().SingleOrDefault());
                Assert.IsNotNull(ediItems.OfType<ParsingException>().SingleOrDefault());
                Assert.IsNotNull(ediItems.OfType<M_810>().SingleOrDefault());

            }
        }

        [TestMethod]
        public void TestParseWithVersionFromSt()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.X12_810_00204_VersionFromSt.txt";

            // ACT
            using (var ediReader = EdiReader.Create(TestHelper.Load(sample)))
            {
                var ediItems = ediReader.ReadToEnd().ToList();

                // ASSERT
                Assert.IsNotNull(ediItems.OfType<S_ISA>().SingleOrDefault());
                Assert.IsNotNull(ediItems.OfType<S_GS>().SingleOrDefault());
                Assert.IsNotNull(ediItems.OfType<S_GE>().SingleOrDefault());
                Assert.IsNotNull(ediItems.OfType<S_IEA>().SingleOrDefault());
                Assert.IsNotNull(ediItems.OfType<M_810>().SingleOrDefault());

            }
        }
    }
}
