using System.Linq;
using System.Xml;
using System.Xml.XPath;
using EdiFabric.Definitions.Edifact_D00A_INVOIC;
using EdiFabric.Framework;
using EdiFabric.Framework.Envelopes;
using EdiFabric.Framework.Envelopes.Edifact;
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
    public class TestEdifact
    {
        public const string TargetNamespaceEdifact = "www.edifabric.com/edifact";

        [TestMethod]
        public void TestMessageDeserialization()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A.txt";

            // ACT
            var interchange = Interchange.LoadFrom(Assembly.GetExecutingAssembly().GetManifestResourceStream(sample));
            var message = interchange.Groups[0].Messages[0];

            if (message.Context.Tag == "INVOIC")
            {
                var typedMessage = message.DeserializeItem<M_INVOIC>();

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
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A.txt";
            
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
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A.txt";
            const string envelopeXsd = "EdiFabric.Tests.Xsd.EdifactEnvelope.xsd";

            // ACT
            var interchange = Interchange.LoadFrom(Assembly.GetExecutingAssembly().GetManifestResourceStream(sample));
            var xml = TestHelper.Serialize(interchange, TargetNamespaceEdifact); 
            
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
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A.txt";
            const string expectedResult = "EdiFabric.Tests.Xml.Edifact_INVOIC_D00A.xml";

            var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(expectedResult);
            Debug.Assert(stream != null, "stream != null");
            var expectedXml = XElement.Load(stream);
            
            // ACT
            var interchange = Interchange.LoadFrom(Assembly.GetExecutingAssembly().GetManifestResourceStream(sample));
            var parsedXml = TestHelper.Serialize(interchange, TargetNamespaceEdifact); 
            
            // ASSERT
            Assert.AreEqual(parsedXml.ToString(), expectedXml.ToString());
        }

        [TestMethod]
        public void TestToInterchangeWithDefaultUna()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_DefaultUNA.txt";
            const string expectedResult = "EdiFabric.Tests.Xml.Edifact_INVOIC_D00A.xml";

            var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(expectedResult);
            Debug.Assert(stream != null, "stream != null");
            var expectedXml = XElement.Load(stream);

            // ACT
            var interchange = Interchange.LoadFrom(Assembly.GetExecutingAssembly().GetManifestResourceStream(sample));
            var parsedXml = TestHelper.Serialize(interchange, TargetNamespaceEdifact); 

            // ASSERT
            Assert.AreEqual(parsedXml.ToString(), expectedXml.ToString());
        }

        [TestMethod]
        public void TestToInterchangeWithNonDefaultSeparators()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_NonDefaultSeparators.txt";
            const string expectedResult = "EdiFabric.Tests.Xml.Edifact_INVOIC_D00A.xml";

            var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(expectedResult);
            Debug.Assert(stream != null, "stream != null");
            var expectedXml = XElement.Load(stream);

            // ACT
            var interchange = Interchange.LoadFrom(Assembly.GetExecutingAssembly().GetManifestResourceStream(sample));
            var parsedXml = TestHelper.Serialize(interchange, TargetNamespaceEdifact); 

            // ASSERT
            Assert.AreEqual(parsedXml.ToString(), expectedXml.ToString());
        }

        [TestMethod]
        public void TestToEdiWithSegmentsComparison()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Xml.Edifact_INVOIC_D00A.xml";
            const string expectedResult = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A.txt";

            var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(expectedResult);
            Debug.Assert(stream != null, "stream != null");

            var reader = new StreamReader(stream);
            var expectedEdi = new List<string>();
            while (reader.Peek() >= 0)
            {
                expectedEdi.Add(reader.ReadLine());
            }

            // ACT
            var parsedEdi = Interchange.LoadFrom(XElement.Load(Assembly.GetExecutingAssembly().GetManifestResourceStream(sample))).ToEdi();

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
            const string sample = "EdiFabric.Tests.Xml.Edifact_INVOIC_D00A.xml";
            const string expectedResult = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_NonDefaultSeparators.txt";

            var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(expectedResult);
            Debug.Assert(stream != null, "stream != null");

            var reader = new StreamReader(stream);
            var expectedEdi = new List<string>();
            while (reader.Peek() >= 0)
            {
                expectedEdi.Add(reader.ReadLine());
            }

            // ACT
            var interchangeContext = new InterchangeContext { DataElementSeparator = "|", SegmentTerminator = "'"};
            var parsedEdi = Interchange.LoadFrom(XElement.Load(Assembly.GetExecutingAssembly().GetManifestResourceStream(sample))).ToEdi(interchangeContext);

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
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_BadSegment.txt";
           
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
        public void TestToInterchangeWithGroup()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_Group.txt";
            const string expectedResult = "EdiFabric.Tests.Xml.Edifact_INVOIC_D00A_Group.xml";

            var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(expectedResult);
            Debug.Assert(stream != null, "stream != null");
            var expectedXml = XElement.Load(stream);

            // ACT
            var interchange = Interchange.LoadFrom(Assembly.GetExecutingAssembly().GetManifestResourceStream(sample));
            var parsedXml = TestHelper.Serialize(interchange, TargetNamespaceEdifact); 

            // ASSERT
            Assert.AreEqual(parsedXml.ToString(), expectedXml.ToString());
        }

        [TestMethod]
        public void TestToInterchangeWithGroupAndMultipleMessages()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_GroupMultipleMessages.txt";
            const string expectedResult = "EdiFabric.Tests.Xml.Edifact_INVOIC_D00A_GroupMultipleMessages.xml";

            var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(expectedResult);
            Debug.Assert(stream != null, "stream != null");
            var expectedXml = XElement.Load(stream);

            // ACT
            var interchange = Interchange.LoadFrom(Assembly.GetExecutingAssembly().GetManifestResourceStream(sample));
            var parsedXml = TestHelper.Serialize(interchange, TargetNamespaceEdifact); 

            // ASSERT
            Assert.AreEqual(parsedXml.ToString(), expectedXml.ToString());
        }

        [TestMethod]
        public void TestToInterchangeWithMultipleGroups()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_MultipleGroups.txt";
            const string expectedResult = "EdiFabric.Tests.Xml.Edifact_INVOIC_D00A_MultipleGroups.xml";

            var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(expectedResult);
            Debug.Assert(stream != null, "stream != null");
            var expectedXml = XElement.Load(stream);

            // ACT
            var interchange = Interchange.LoadFrom(Assembly.GetExecutingAssembly().GetManifestResourceStream(sample));
            var parsedXml = TestHelper.Serialize(interchange, TargetNamespaceEdifact); 

            // ASSERT
            Assert.AreEqual(parsedXml.ToString(), expectedXml.ToString());
        }

       

        [TestMethod]
        public void TestToInterchangeWithMultipleMessages()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_MultipleMessages.txt";
            const string expectedResult = "EdiFabric.Tests.Xml.Edifact_INVOIC_D00A_MultipleMessages.xml";

            var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(expectedResult);
            Debug.Assert(stream != null, "stream != null");
            var expectedXml = XElement.Load(stream);

            // ACT
            var interchange = Interchange.LoadFrom(Assembly.GetExecutingAssembly().GetManifestResourceStream(sample));
            var parsedXml = TestHelper.Serialize(interchange, TargetNamespaceEdifact); 

            // ASSERT
            Assert.AreEqual(parsedXml.ToString(), expectedXml.ToString());
        }

        [TestMethod]
        public void TestToInterchangeWithEscapedSegmentTerminator()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_EscapedSegmentTerminator.txt";
            const string expectedResult = "EdiFabric.Tests.Xml.Edifact_INVOIC_D00A_EscapedSegmentTerminator.xml";

            var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(expectedResult);
            Debug.Assert(stream != null, "stream != null");
            var expectedXml = XElement.Load(stream);

            // ACT
            var interchange = Interchange.LoadFrom(Assembly.GetExecutingAssembly().GetManifestResourceStream(sample));
            var parsedXml = TestHelper.Serialize(interchange, TargetNamespaceEdifact); 

            // ASSERT
            Assert.AreEqual(parsedXml.ToString(), expectedXml.ToString());
        }

        [TestMethod]
        public void TestToEdiWithEscaped()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Xml.Edifact_INVOIC_D00A_EscapedSegmentTerminator.xml";
            const string expectedResult = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_EscapedSegmentTerminator.txt";

            var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(expectedResult);
            Debug.Assert(stream != null, "stream != null");

            var reader = new StreamReader(stream);
            var expectedEdi = new List<string>();
            while (reader.Peek() >= 0)
            {
                expectedEdi.Add(reader.ReadLine());
            }

            // ACT
            var parsedEdi = Interchange.LoadFrom(XElement.Load(Assembly.GetExecutingAssembly().GetManifestResourceStream(sample)))
                           .ToEdi();

            // ASSERT
            Assert.AreEqual(expectedEdi.Count, parsedEdi.Count);
            for (int i = 0; i < parsedEdi.Count; i++)
            {
                Assert.IsTrue(parsedEdi[i] == expectedEdi[i]);
            }
        }

        [TestMethod]
        public void TestToEdiWithInvalidContext()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Xml.Edifact_INVOIC_D00A_EscapedSegmentTerminator.xml";
            var interchangeContext = new InterchangeContext
                                         {
                                             DataElementSeparator = "|",
                                             ComponentDataElementSeparator = "|"
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
            const string sample = "EdiFabric.Tests.Xml.Edifact_INVOIC_D00A_EmptyNode.xml";
            const string expectedResult = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A.txt";

            var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(expectedResult);
            Debug.Assert(stream != null, "stream != null");

            var reader = new StreamReader(stream);
            var expectedEdi = new List<string>();
            while (reader.Peek() >= 0)
            {
                expectedEdi.Add(reader.ReadLine());
            }

            // ACT
            var parsedEdi = Interchange.LoadFrom(XElement.Load(Assembly.GetExecutingAssembly().GetManifestResourceStream(sample)))
                           .ToEdi();

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
            const string sample = "EdiFabric.Tests.Xml.Edifact_INVOIC_D00A_SegmentList.xml";
            const string expectedResult = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A.txt";

            var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(expectedResult);
            Debug.Assert(stream != null, "stream != null");

            var reader = new StreamReader(stream);
            var expectedEdi = new List<string>();
            while (reader.Peek() >= 0)
            {
                expectedEdi.Add(reader.ReadLine());
            }

            // ACT
            var parsedEdi = Interchange.LoadFrom(XElement.Load(Assembly.GetExecutingAssembly().GetManifestResourceStream(sample)))
                           .ToEdi();

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
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A.txt";
            
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
        public void TestToInterchangeWithEscapedEscape()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_EscapedEscape.txt";
            const string expectedResult = "EdiFabric.Tests.Xml.Edifact_INVOIC_D00A_EscapedEscape.xml";

            var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(expectedResult);
            Debug.Assert(stream != null, "stream != null");
            var expectedXml = XElement.Load(stream);

            // ACT
            var interchange = Interchange.LoadFrom(Assembly.GetExecutingAssembly().GetManifestResourceStream(sample));
            var parsedXml = TestHelper.Serialize(interchange, TargetNamespaceEdifact);

            // ASSERT
            Assert.AreEqual(parsedXml.ToString(), expectedXml.ToString());
        }

        [TestMethod]
        public void TestToEdiWithEscapingTheEscapeGeneration()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Xml.Edifact_INVOIC_D00A_EscapeGen.xml";
            const string expectedResult = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_EscapeGen.txt";

            var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(expectedResult);
            Debug.Assert(stream != null, "stream != null");

            var reader = new StreamReader(stream);
            var expectedEdi = new List<string>();
            while (reader.Peek() >= 0)
            {
                expectedEdi.Add(reader.ReadLine());
            }

            // ACT
            var parsedEdi = Interchange.LoadFrom(XElement.Load(Assembly.GetExecutingAssembly().GetManifestResourceStream(sample))).ToEdi();

            // ASSERT
            Assert.AreEqual(expectedEdi.Count, parsedEdi.Count);
            for (int i = 0; i < parsedEdi.Count; i++)
            {
                Assert.IsTrue(parsedEdi[i] == expectedEdi[i]);
            }
        }

        [TestMethod]
        public void TestToEdiWithTrailingSeparator()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Xml.Edifact_INVOIC_D00A_TrailingSeparator.xml";
            const string expectedResult = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_TrailingSeparator.txt";

            var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(expectedResult);
            Debug.Assert(stream != null, "stream != null");

            var reader = new StreamReader(stream);
            var expectedEdi = new List<string>();
            while (reader.Peek() >= 0)
            {
                expectedEdi.Add(reader.ReadLine());
            }

            // ACT
            var parsedEdi = Interchange.LoadFrom(XElement.Load(Assembly.GetExecutingAssembly().GetManifestResourceStream(sample))).ToEdi();

            // ASSERT
            Assert.AreEqual(expectedEdi.Count, parsedEdi.Count);
            for (int i = 0; i < parsedEdi.Count; i++)
            {
                Assert.IsTrue(parsedEdi[i] == expectedEdi[i]);
            }
        }
    }
}
