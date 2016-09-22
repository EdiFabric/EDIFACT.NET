using System;
using System.Collections.Generic;
using System.Diagnostics;
using System;
using System.Linq;
using System.Xml.Linq;
using EdiFabric.Framework;
using EdiFabric.Framework.Headers;
using EdiFabric.Rules.X12004010X098A1837;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EdiFabric.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class TestHipaa
    {
        public const string TargetNamespace = "www.edifabric.com/x12";

        [TestMethod]
        public void TestParse4010()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Hipaa_837P_00401.txt";
            const string expectedResult = "EdiFabric.Tests.Xml.Hipaa_837P_00401.xml";
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
        public void TestGenerate5001Hl()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Hipaa_837P_00501_HL.txt";
            var interchange = TestHelper.GenerateX12<Rules.X12005010X222A1837.M_837>(sample);

            // ACT
            var ediSegments = interchange.GenerateEdi();

            // ASSERT
            var f = TestHelper.AsString(ediSegments, Environment.NewLine);
            Assert.AreEqual(TestHelper.AsString(sample), TestHelper.AsString(ediSegments, Environment.NewLine));
        }  
    }
}
