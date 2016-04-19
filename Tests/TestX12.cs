using System.Linq;
using EdiFabric.Definitions.X12_002040_810;
using EdiFabric.Framework;
using EdiFabric.Framework.Envelopes;
using EdiFabric.Framework.Envelopes.X12;
using EdiFabric.Framework.Messages;

namespace EdiFabric.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    using System.Reflection;
    using System.Xml.Schema;
    using System.Xml.Linq;

    [TestClass]
    public class TestX12
    {
        public const string TargetNamespaceX12 = "www.edifabric.com/x12";

        [TestMethod]
        public void TestMessageDeserialization()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.X12_810_00204Deserialize.txt";

            // ACT
            var interchange = Interchange.LoadFrom(Assembly.GetExecutingAssembly().GetManifestResourceStream(sample));
            var message = interchange.Groups[0].Messages[0];

            if (message.Context.Tag == "810")
            {
                var typedMessage = message.DeserializeItem<M_810>();

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
            const string sample = "EdiFabric.Tests.Edi.X12_810_00204.txt";
            
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
            const string sample = "EdiFabric.Tests.Edi.X12_810_00204.txt";
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
        public void TestToInterchangeWithNonDefaultSeparators()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.X12_810_00204_NonDefaultSeparators.txt";
            const string expectedResult = "EdiFabric.Tests.Xml.X12_810_00204.xml";

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
        public void TestToInterchangeWithLf()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.X12_810_00204_LF.txt";
            const string expectedResult = "EdiFabric.Tests.Xml.X12_810_00204.xml";

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
        public void TestToInterchangeWithSegmentSeparatorIsNewLine()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.X12_810_00204_SegmentSeparatorIsNewLine.txt";
            const string expectedResult = "EdiFabric.Tests.Xml.X12_810_00204.xml";

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
        public void TestToInterchangeWithXmlComparison()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.X12_810_00204.txt";
            const string expectedResult = "EdiFabric.Tests.Xml.X12_810_00204.xml";

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
            const string sample = "EdiFabric.Tests.Xml.X12_810_00204.xml";
            const string expectedResult = "EdiFabric.Tests.Edi.X12_810_00204.txt";

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
                Interchange.LoadFrom(XElement.Load(Assembly.GetExecutingAssembly().GetManifestResourceStream(sample))).ToEdi();

            // ASSERT
            Assert.AreEqual(expectedEdi.Count, parsedEdi.Count);
            for (int i = 0; i < parsedEdi.Count; i++)
            {
                Assert.IsTrue(parsedEdi[i] == expectedEdi[i]);
            }
        }

        [TestMethod]
        public void TestToEdiWithSegmentsComparisonAndNonDefaultSeparators()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Xml.X12_810_00204.xml";
            const string expectedResult = "EdiFabric.Tests.Edi.X12_810_00204_NonDefaultSeparators.txt";

            var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(expectedResult);
            Debug.Assert(stream != null, "stream != null");

            var reader = new StreamReader(stream);
            var expectedEdi = new List<string>();
            while (reader.Peek() >= 0)
            {
                expectedEdi.Add(reader.ReadLine());
            }

            // ACT
            var interchangeContext = new InterchangeContext { DataElementSeparator = "|", SegmentTerminator = "~" };
            var parsedEdi =
                Interchange.LoadFrom(XElement.Load(Assembly.GetExecutingAssembly().GetManifestResourceStream(sample))).ToEdi(interchangeContext);

            // ASSERT
            Assert.AreEqual(expectedEdi.Count, parsedEdi.Count);
            for (int i = 0; i < parsedEdi.Count; i++)
            {
                Assert.IsTrue(parsedEdi[i] == expectedEdi[i]);
            }
        }

        [TestMethod]
        public void TestToInterchangeWithFriendlyException()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.X12_810_00204_BadSegment.txt";
           
            // ACT
            try
            {
                Interchange.LoadFrom(Assembly.GetExecutingAssembly().GetManifestResourceStream(sample));
            }
            catch (Exception ex)
            {
                // ASSERT
                Assert.IsInstanceOfType(ex, typeof(ParserException));
            }
        }

        [TestMethod]
        public void TestToInterchangeWithMultipleMessages()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.X12_810_00204_MultipleMessages.txt";
            const string expectedResult = "EdiFabric.Tests.Xml.X12_810_00204_MultipleMessages.xml";

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
        public void TestToInterchangeWithMultipleGroups()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.X12_810_00204_MultipleGroups.txt";
            const string expectedResult = "EdiFabric.Tests.Xml.X12_810_00204_MultipleGroups.xml";

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
        public void TestToInterchangeWithPropertiesOrder()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.X12_810_00204_PropertiesOrder.txt";
            const string expectedResult = "EdiFabric.Tests.Xml.X12_810_00204_PropertiesOrder.xml";

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
        public void TestToEdiWithInvalidContext()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Xml.X12_810_00204.xml";
            var interchangeContext = new InterchangeContext
            {
                DataElementSeparator = "*",
                ComponentDataElementSeparator = "*"
            };

            // ACT
            try
            {
                Interchange.LoadFrom(
                        XElement.Load(Assembly.GetExecutingAssembly().GetManifestResourceStream(sample))).ToEdi(interchangeContext);
            }
            catch (Exception ex)
            {
                // ASSERT
                Assert.IsInstanceOfType(ex, typeof(ParserException));
                Assert.IsTrue(ex.Message.StartsWith("Invalid interchange context"));
            }
        }

        [TestMethod]
        public void TestToEdiWithEmptyNode()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Xml.X12_810_00204_EmptyNode.xml";
            const string expectedResult = "EdiFabric.Tests.Edi.X12_810_00204.txt";

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
                Interchange.LoadFrom(XElement.Load(Assembly.GetExecutingAssembly().GetManifestResourceStream(sample))).ToEdi();

            // ASSERT
            Assert.AreEqual(expectedEdi.Count, parsedEdi.Count);
            for (int i = 0; i < parsedEdi.Count; i++)
            {
                Assert.IsTrue(parsedEdi[i] == expectedEdi[i]);
            }
        }

        [TestMethod]
        public void TestToEdiWithRepetitionSeparator()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Xml.X12_810_00204_RepetitionSeparator.xml";
            const string expectedResult = "EdiFabric.Tests.Edi.X12_810_00204_RepetitionSeparator.txt";

            var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(expectedResult);
            Debug.Assert(stream != null, "stream != null");

            var reader = new StreamReader(stream);
            var expectedEdi = new List<string>();
            while (reader.Peek() >= 0)
            {
                expectedEdi.Add(reader.ReadLine());
            }
            var interchangeContext = new InterchangeContext
            {
                RepetitionSeparator = "|"
            };

            // ACT
            var parsedEdi =
                Interchange.LoadFrom(XElement.Load(Assembly.GetExecutingAssembly().GetManifestResourceStream(sample))).ToEdi(interchangeContext);

            // ASSERT
            Assert.AreEqual(expectedEdi.Count, parsedEdi.Count);
            for (int i = 0; i < parsedEdi.Count; i++)
            {
                Assert.IsTrue(parsedEdi[i] == expectedEdi[i]);
            }
        }

        [TestMethod]
        public void TestToEdiWithSegmentList()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Xml.X12_810_00204_SegmentList.xml";
            const string expectedResult = "EdiFabric.Tests.Edi.X12_810_00204.txt";

            var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(expectedResult);
            Debug.Assert(stream != null, "stream != null");

            var reader = new StreamReader(stream);
            var expectedEdi = new List<string>();
            while (reader.Peek() >= 0)
            {
                expectedEdi.Add(reader.ReadLine());
            }
            var interchangeContext = new InterchangeContext
            {
                RepetitionSeparator = "|"
            };

            // ACT
            var parsedEdi =
                Interchange.LoadFrom(XElement.Load(Assembly.GetExecutingAssembly().GetManifestResourceStream(sample))).ToEdi(interchangeContext);

            // ASSERT
            Assert.AreEqual(expectedEdi.Count, parsedEdi.Count);
            for (int i = 0; i < parsedEdi.Count; i++)
            {
                Assert.IsTrue(parsedEdi[i] == expectedEdi[i]);
            }
        }

        [TestMethod]
        public void TestToInterchangeWithValidation()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.X12_810_00204.txt";
            
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
    }
}
