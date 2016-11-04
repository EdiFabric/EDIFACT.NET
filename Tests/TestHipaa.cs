using System;
using System.Linq;
using System.Xml.Linq;
using EdiFabric.Framework;
using EdiFabric.Framework.Controls;
using EdiFabric.Rules.X12004010X098A1837;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EdiFabric.Tests
{
    [TestClass]
    public class TestHipaa
    {
        [TestMethod]
        public void TestParse4010()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Hipaa_837P_00401.txt";
            const string expectedResult = "EdiFabric.Tests.Xml.Hipaa_837P_00401.xml";
            var expectedXml = XElement.Load(TestHelper.Load(expectedResult));

            // ACT
            var ediItems = TestHelper.Parse(sample).ToList();

            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsNotNull(ediItems.OfType<S_ISA>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<S_GS>().SingleOrDefault());
            var parsedXml = ediItems.OfType<M_837>().Single().Serialize();
            Assert.IsNotNull(parsedXml.Root);
            Assert.AreEqual(parsedXml.Root.ToString(), expectedXml.ToString());
        }

        [TestMethod]
        public void TestGenerate4010()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Hipaa_837P_00401.txt";
            var interchange = TestHelper.GenerateX12<M_837>(sample);

            // ACT
            var ediSegments = interchange.GenerateEdi();

            // ASSERT
            Assert.AreEqual(TestHelper.AsString(sample), TestHelper.AsString(ediSegments, Environment.NewLine));
        }

        [TestMethod]
        public void TestParse5010()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Hipaa_837P_00501.txt";
            const string expectedResult = "EdiFabric.Tests.Xml.Hipaa_837P_00501.xml";
            var expectedXml = XElement.Load(TestHelper.Load(expectedResult));

            // ACT
            var ediItems = TestHelper.Parse(sample).ToList();

            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsNotNull(ediItems.OfType<S_ISA>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<S_GS>().SingleOrDefault());
            var parsedXml = ediItems.OfType<Rules.X12005010X222A1837.M_837>().Single().Serialize();
            Assert.IsNotNull(parsedXml.Root);
            Assert.AreEqual(parsedXml.Root.ToString(), expectedXml.ToString());
        }

        [TestMethod]
        public void TestGenerate5010()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Hipaa_837P_00501.txt";
            var interchange = TestHelper.GenerateX12<Rules.X12005010X222A1837.M_837>(sample);

            // ACT
            var ediSegments = interchange.GenerateEdi();

            // ASSERT
            Assert.AreEqual(TestHelper.AsString(sample), TestHelper.AsString(ediSegments, Environment.NewLine));
        }

        [TestMethod]
        public void TestParse5010Hl()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Hipaa_837P_00501_HL.txt";
            const string expectedResult = "EdiFabric.Tests.Xml.Hipaa_837P_00501_HL.xml";
            var expectedXml = XElement.Load(TestHelper.Load(expectedResult));

            // ACT
            var ediItems = TestHelper.Parse(sample).ToList();

            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsNotNull(ediItems.OfType<S_ISA>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<S_GS>().SingleOrDefault());
            var parsedXml = ediItems.OfType<Rules.X12005010X222A1837.M_837>().Single().Serialize();
            Assert.IsNotNull(parsedXml.Root);
            Assert.AreEqual(parsedXml.Root.ToString(), expectedXml.ToString());
        }

        [TestMethod]
        public void TestGenerate5010Hl()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Hipaa_837P_00501_HL.txt";
            var interchange = TestHelper.GenerateX12<Rules.X12005010X222A1837.M_837>(sample);

            // ACT
            var ediSegments = interchange.GenerateEdi();

            // ASSERT
            Assert.AreEqual(TestHelper.AsString(sample), TestHelper.AsString(ediSegments, Environment.NewLine));
        }

        [TestMethod]
        public void TestParse5010NoEnum()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Hipaa_837P_00501_NoEnum.txt";
            const string expectedResult = "EdiFabric.Tests.Xml.Hipaa_837P_00501_NoEnum.xml";
            var expectedXml = XElement.Load(TestHelper.Load(expectedResult));

            // ACT
            var ediItems = TestHelper.Parse(sample).ToList();

            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsNotNull(ediItems.OfType<S_ISA>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<S_GS>().SingleOrDefault());
            var parsedXml = ediItems.OfType<Rules.X12005010X222A1837.M_837>().Single().Serialize();
            Assert.IsNotNull(parsedXml.Root);
            Assert.AreEqual(parsedXml.Root.ToString(), expectedXml.ToString());
        }

        [TestMethod]
        public void TestGenerate5010NoEnum()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Hipaa_837P_00501_NoEnum.txt";
            var interchange = TestHelper.GenerateX12<Rules.X12005010X222A1837.M_837>(sample);

            // ACT
            var ediSegments = interchange.GenerateEdi();

            // ASSERT
            Assert.AreEqual(TestHelper.AsString(sample), TestHelper.AsString(ediSegments, Environment.NewLine));
        }  
    }
}
