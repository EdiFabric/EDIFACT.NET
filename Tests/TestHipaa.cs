using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Xml.Linq;
using System.Xml.Schema;

using EdiFabric.Definitions.Hipaa_004010_837_X098;
using EdiFabric.Framework.Envelopes.X12;
using EdiFabric.Framework.Messages;

namespace EdiFabric.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class TestHipaa
    {
        public const string TargetNamespaceX12 = "www.edifabric.com/x12";

        [TestMethod]
        public void TestMessageDeserialization()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Hipaa_837P_00401.txt";

            // ACT
            var interchange = Interchange.LoadFrom(Assembly.GetExecutingAssembly().GetManifestResourceStream(sample));
            var message = interchange.Groups[0].Messages[0];

            if (message.Context.Tag == "837" && message.Context.Origin == "X098")
            {
                var typedMessage = message.DeserializeItem<M_837>();

                // ASSERT
                Assert.IsNotNull(typedMessage);
            }
            else
            {
                Assert.Fail();
            }
        }
        
        [TestMethod]
        public void TestMessageContextFromType()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Hipaa_837P_00401.txt";

            // ACT
            var interchange = Interchange.LoadFrom(Assembly.GetExecutingAssembly().GetManifestResourceStream(sample));
            var systemType = (new MessageContext(interchange.Groups[0].Messages[0].Context.SystemType)).SystemType;

            // ASSERT
            Assert.IsNotNull(systemType);
        }

        [TestMethod]
        public void TestToInterchangeWithEnvelopeSchemaValidation()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Hipaa_837P_00401.txt";
            const string envelopeXsd = "EdiFabric.Tests.Xsd.X12Envelope.xsd";

            // ACT
            var interchange = Interchange.LoadFrom(Assembly.GetExecutingAssembly().GetManifestResourceStream(sample));
            var xml = TestHelper.Serialize(interchange, TargetNamespaceX12); 

            var schemas = new XmlSchemaSet();
            var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(envelopeXsd);
            if (stream != null)
            {
                var schema = XmlSchema.Read(stream, null);
                schemas.Add(schema);
            }
            var doc = new XDocument(xml);
            var errors = false;
            doc.Validate(schemas, (o, e) => { errors = true; });

            // ASSERT
            Assert.IsFalse(errors);
        }

        [TestMethod]
        public void TestToInterchangeWithXmlComparison()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Hipaa_837P_00401.txt";
            const string expectedResult = "EdiFabric.Tests.Xml.Hipaa_837P_00401.xml";

            var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(expectedResult);
            Debug.Assert(stream != null, "stream != null");
            var expectedXml = XElement.Load(stream, LoadOptions.PreserveWhitespace);

            // ACT
            var interchange = Interchange.LoadFrom(Assembly.GetExecutingAssembly().GetManifestResourceStream(sample));
            var parsedXml = TestHelper.Serialize(interchange, TargetNamespaceX12);

            // ASSERT
            Assert.AreEqual(parsedXml.ToString(), expectedXml.ToString());
        }

        [TestMethod]
        public void TestToEdiWithSegmentsComparison()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Xml.Hipaa_837P_00401.xml";
            const string expectedResult = "EdiFabric.Tests.Edi.Hipaa_837P_00401.txt";

            var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(expectedResult);
            Debug.Assert(stream != null, "stream != null");

            var reader = new StreamReader(stream);
            var expectedEdi = new List<string>();
            while (reader.Peek() >= 0)
            {
                expectedEdi.Add(reader.ReadLine());
            }

            // ACT
            var parsedEdi =
                Interchange.LoadFrom(XElement.Load(Assembly.GetExecutingAssembly().GetManifestResourceStream(sample)))
                           .ToEdi();

            // ASSERT
            Assert.AreEqual(expectedEdi.Count, parsedEdi.Count);
            for (int i = 0; i < parsedEdi.Count; i++)
            {
                Assert.IsTrue(parsedEdi[i] == expectedEdi[i]);
            }
        }

        [TestMethod]
        public void TestToInterchangeWithInvalidEnum()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Hipaa_837P_00401_BadSegment.txt";
            const string expectedErrorMessage = "Instance validation error: 'CL' is not a valid value for S_BHT_BeginningOfHierarchicalTransaction_TS837Q1D_BHT06_ClaimOrEncounterIdentifier.";

            // ACT
            try
            {
                var interchange = Interchange.LoadFrom(Assembly.GetExecutingAssembly().GetManifestResourceStream(sample));
                var message = interchange.Groups[0].Messages[0];

                if (message.Context.Tag == "837" && message.Context.Origin == "X098")
                {
                    message.DeserializeItem<M_837>();

                    // ASSERT
                    Assert.Fail();
                }
                else
                {
                    Assert.Fail();
                }
            }
            catch (Exception ex)
            {
                // ASSERT
                Assert.IsTrue(ex.InnerException.Message == expectedErrorMessage);
            }
        }

        [TestMethod]
        public void TestToInterchangeWithValidation()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Hipaa_837P_00401.txt";

            // ACT
            var interchange = Interchange.LoadFrom(Assembly.GetExecutingAssembly().GetManifestResourceStream(sample));

            var brokenRules = new List<string>();
            foreach (var group in interchange.Groups)
            {
                foreach (var message in group.Messages)
                {
                    brokenRules.AddRange(message.Validate());
                }
            }

            // ASSERT
            Assert.IsTrue(brokenRules.Any());
        }

        [TestMethod]
        public void TestToInterchangeWithSecondaryValue()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Hipaa_837P_00401_SecondaryValue1.txt";
            const string expectedResult = "EdiFabric.Tests.Xml.Hipaa_837P_00401_Secondary1.xml";

            var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(expectedResult);
            Debug.Assert(stream != null, "stream != null");
            var expectedXml = XElement.Load(stream, LoadOptions.PreserveWhitespace);

            // ACT
            var interchange = Interchange.LoadFrom(Assembly.GetExecutingAssembly().GetManifestResourceStream(sample), "EdiFabric.Tests");
            var parsedXml = TestHelper.Serialize(interchange, TargetNamespaceX12);

            // ASSERT
            Assert.AreEqual(parsedXml.ToString(), expectedXml.ToString());
        }

        [TestMethod]
        public void TestToInterchangeWithSecondaryValueOnly()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Hipaa_837P_00401_SecondaryValue2.txt";
            const string expectedResult = "EdiFabric.Tests.Xml.Hipaa_837P_00401_Secondary2.xml";

            var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(expectedResult);
            Debug.Assert(stream != null, "stream != null");
            var expectedXml = XElement.Load(stream, LoadOptions.PreserveWhitespace);

            // ACT
            var interchange = Interchange.LoadFrom(Assembly.GetExecutingAssembly().GetManifestResourceStream(sample), "EdiFabric.Tests");
            var parsedXml = TestHelper.Serialize(interchange, TargetNamespaceX12);

            // ASSERT
            Assert.AreEqual(parsedXml.ToString(), expectedXml.ToString());
        }

        [TestMethod]
        public void TestToInterchangeWithNoSecondaryValue()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Hipaa_837P_00401_SecondaryValue3.txt";
            const string expectedResult = "EdiFabric.Tests.Xml.Hipaa_837P_00401_Secondary3.xml";

            var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(expectedResult);
            Debug.Assert(stream != null, "stream != null");
            var expectedXml = XElement.Load(stream, LoadOptions.PreserveWhitespace);

            // ACT
            var interchange = Interchange.LoadFrom(Assembly.GetExecutingAssembly().GetManifestResourceStream(sample), "EdiFabric.Tests");
            var parsedXml = TestHelper.Serialize(interchange, TargetNamespaceX12);

            // ASSERT
            Assert.AreEqual(parsedXml.ToString(), expectedXml.ToString());
        }

        [TestMethod]
        public void TestToInterchangeWithInvalidMessage()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Hipaa_837P_00401_Invalid.txt";
            const string expectedErrorMessage = "Failed at line: BHP*0019*00*1*20110406*085755*CH";
            const string expectedInnerErrorMessage = "Can't find a match for segment Name = BHP FirstValue = 0019 SecondValue = 00 ParentId = . Message is invalid.";

            // ACT
            try
            {
                Interchange.LoadFrom(Assembly.GetExecutingAssembly().GetManifestResourceStream(sample));
                Assert.Fail();               
            }
            catch (Exception ex)
            {
                // ASSERT
                Assert.IsTrue(ex.Message == expectedErrorMessage);
                Assert.IsTrue(ex.InnerException.Message == expectedInnerErrorMessage);
            }
        }

        [TestMethod]
        public void TestToEdiWithSegmentComparison5010()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Xml.Hipaa_837P_00501.xml";
            const string expectedResult = "EdiFabric.Tests.Edi.Hipaa_837P_00501.txt";

            var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(expectedResult);
            Debug.Assert(stream != null, "stream != null");

            var reader = new StreamReader(stream);
            var expectedEdi = new List<string>();
            while (reader.Peek() >= 0)
            {
                expectedEdi.Add(reader.ReadLine());
            }

            // ACT
            var parsedEdi =
                Interchange.LoadFrom(XElement.Load(Assembly.GetExecutingAssembly().GetManifestResourceStream(sample)))
                           .ToEdi();

            var b = "";
            foreach (var t in parsedEdi)
            {
                b = b + t + Environment.NewLine;
            }

            // ASSERT
            Assert.AreEqual(expectedEdi.Count, parsedEdi.Count);
            for (int i = 0; i < parsedEdi.Count; i++)
            {
                Assert.IsTrue(parsedEdi[i] == expectedEdi[i]);
            }
        }

        [TestMethod]
        public void TestToInterchangeWithXmlComparison5010()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Hipaa_837P_00501.txt";
            const string expectedResult = "EdiFabric.Tests.Xml.Hipaa_837P_00501.xml";

            var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(expectedResult);
            Debug.Assert(stream != null, "stream != null");
            var expectedXml = XElement.Load(stream, LoadOptions.PreserveWhitespace);

            // ACT
            var interchange = Interchange.LoadFrom(Assembly.GetExecutingAssembly().GetManifestResourceStream(sample));
            var parsedXml = TestHelper.Serialize(interchange, TargetNamespaceX12);

            // ASSERT
            Assert.AreEqual(parsedXml.ToString(), expectedXml.ToString());
        }
    }
}
