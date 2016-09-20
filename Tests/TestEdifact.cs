using System;
using System.Text;
using System.Xml.Linq;
using EdiFabric.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EdiFabric.Tests
{
    [TestClass]
    public class TestEdifact
    {
        public const string TargetNamespaceEdifact = "www.edifabric.com/edifact";
        public const string RulesAssemblyName = "EdiFabric.Rules";

        //[TestMethod]
        //public void TestToInterchangeWithEnvelopeSchemaValidation()
        //{
        //    // ARRANGE
        //    const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A.txt";
        //    const string envelopeXsd = "EdiFabric.Tests.Xsd.EdifactEnvelope.xsd";

        //    // ACT
        //    var interchange = Interchange.LoadFrom(Assembly.GetExecutingAssembly().GetManifestResourceStream(sample));
        //    var xml = TestHelper.Serialize(interchange, TargetNamespaceEdifact); 
            
        //    var schemas = new XmlSchemaSet();
        //    var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(envelopeXsd);
        //    if (stream != null)
        //    {
        //        var schema = XmlSchema.Read(stream, null);
        //        schemas.Add(schema);
        //    }
        //    var doc = new XDocument(xml);
        //    var errors = false;
        //    doc.Validate(schemas, (o, e) => { errors = true; });
            
        //    // ASSERT
        //    Assert.IsFalse(errors);
        //}

        [TestMethod]
        public void TestParse()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A.txt";
            const string expectedResult = "EdiFabric.Tests.Xml.Edifact_INVOIC_D00A.xml";
            var expectedXml = XElement.Load(TestHelper.Load(expectedResult));

            // ACT
            var message = TestHelper.ParseEdifact(sample);

            // ASSERT
            Assert.IsNotNull(message);
            Assert.IsNotNull(message.InterchangeHeader);
            Assert.IsNotNull(message.Value);
            Assert.IsNull(message.GroupHeader);
            var parsedXml = TestHelper.Serialize(message.Value, TargetNamespaceEdifact);
            Assert.AreEqual(parsedXml.ToString(), expectedXml.ToString());
        }

        [TestMethod]
        public void TestGenerate()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A.txt";
            var interchange = TestHelper.GenerateEdifact(sample);

            // ACT
            var ediSegments = interchange.GenerateEdi();

            // ASSERT
            Assert.AreEqual(TestHelper.AsString(sample), TestHelper.AsString(ediSegments, Environment.NewLine));
        }

        [TestMethod]
        public void TestParseWithDefaultUna()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_DefaultUNA.txt";
            const string expectedResult = "EdiFabric.Tests.Xml.Edifact_INVOIC_D00A.xml";
            var expectedXml = XElement.Load(TestHelper.Load(expectedResult));
            
            // ACT
            var message = TestHelper.ParseEdifact(sample);

            // ASSERT
            Assert.IsNotNull(message);
            Assert.IsNotNull(message.InterchangeHeader);
            Assert.IsNotNull(message.Value);
            Assert.IsNull(message.GroupHeader);
            var parsedXml = TestHelper.Serialize(message.Value, TargetNamespaceEdifact);
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
            var message = TestHelper.ParseEdifact(sample);

            // ASSERT
            Assert.IsNotNull(message);
            Assert.IsNotNull(message.InterchangeHeader);
            Assert.IsNotNull(message.Value);
            Assert.IsNull(message.GroupHeader);
            var parsedXml = TestHelper.Serialize(message.Value, TargetNamespaceEdifact);
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
            var message = TestHelper.ParseEdifact(sample, Encoding.UTF8);

            // ASSERT
            Assert.IsNotNull(message);
            Assert.IsNotNull(message.InterchangeHeader);
            Assert.IsNotNull(message.Value);
            Assert.IsNull(message.GroupHeader);
            var parsedXml = TestHelper.Serialize(message.Value, TargetNamespaceEdifact);
            Assert.AreEqual(parsedXml.ToString(), expectedXml.ToString());
        }

        [TestMethod]
        public void TestGenerateWithNonDefaultSeparators()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A.txt";
            const string expectedResult = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_NonDefaultSeparators.txt";
            var interchange = TestHelper.GenerateEdifact(sample);
            var newSeparators = Separators.SeparatorsEdifact(null, null, "|", null, null);
            
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
            try
            {
                TestHelper.ParseEdifact(sample);
            }
            catch (Exception ex)
            {
                // ASSERT
                Assert.IsInstanceOfType(ex, typeof(ParserException));
            }
        }

        [TestMethod]
        public void TestParseWithGroup()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_Group.txt";
            const string expectedResult = "EdiFabric.Tests.Xml.Edifact_INVOIC_D00A.xml";
            var expectedXml = XElement.Load(TestHelper.Load(expectedResult));

            // ACT
            var message = TestHelper.ParseEdifact(sample);

            // ASSERT
            Assert.IsNotNull(message);
            Assert.IsNotNull(message.InterchangeHeader);
            Assert.IsNotNull(message.Value);
            Assert.IsNotNull(message.GroupHeader);
            var parsedXml = TestHelper.Serialize(message.Value, TargetNamespaceEdifact);
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
            var messages = TestHelper.ParseEdifactMultiple(sample);

            // ASSERT
            Assert.IsTrue(messages.Count == 2);
            Assert.IsTrue(TestHelper.Serialize(messages[0].InterchangeHeader, TargetNamespaceEdifact).ToString() ==
                          TestHelper.Serialize(messages[1].InterchangeHeader, TargetNamespaceEdifact).ToString());
            Assert.IsTrue(TestHelper.Serialize(messages[0].GroupHeader, TargetNamespaceEdifact).ToString() ==
                          TestHelper.Serialize(messages[1].GroupHeader, TargetNamespaceEdifact).ToString());
            foreach (var message in messages)
            {
                Assert.IsNotNull(message);
                Assert.IsNotNull(message.InterchangeHeader);
                Assert.IsNotNull(message.Value);
                Assert.IsNotNull(message.GroupHeader);
                var parsedXml = TestHelper.Serialize(message.Value, TargetNamespaceEdifact);
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
            var messages = TestHelper.ParseEdifactMultiple(sample);

            // ASSERT
            Assert.IsTrue(messages.Count == 2);
            Assert.IsTrue(TestHelper.Serialize(messages[0].InterchangeHeader, TargetNamespaceEdifact).ToString() ==
                         TestHelper.Serialize(messages[1].InterchangeHeader, TargetNamespaceEdifact).ToString());
            Assert.IsTrue(TestHelper.Serialize(messages[0].GroupHeader, TargetNamespaceEdifact).ToString() !=
                          TestHelper.Serialize(messages[1].GroupHeader, TargetNamespaceEdifact).ToString());
            foreach (var message in messages)
            {
                Assert.IsNotNull(message);
                Assert.IsNotNull(message.InterchangeHeader);
                Assert.IsNotNull(message.Value);
                Assert.IsNotNull(message.GroupHeader);
                var parsedXml = TestHelper.Serialize(message.Value, TargetNamespaceEdifact);
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
            var messages = TestHelper.ParseEdifactMultiple(sample);

            // ASSERT
            Assert.IsTrue(messages.Count == 2);
            Assert.IsTrue(TestHelper.Serialize(messages[0].InterchangeHeader, TargetNamespaceEdifact).ToString() ==
                         TestHelper.Serialize(messages[1].InterchangeHeader, TargetNamespaceEdifact).ToString());
           foreach (var message in messages)
            {
                Assert.IsNotNull(message);
                Assert.IsNotNull(message.InterchangeHeader);
                Assert.IsNotNull(message.Value);
                Assert.IsNull(message.GroupHeader);
                var parsedXml = TestHelper.Serialize(message.Value, TargetNamespaceEdifact);
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
            var message = TestHelper.ParseEdifact(sample);

            // ASSERT
            Assert.IsNotNull(message);
            Assert.IsNotNull(message.InterchangeHeader);
            Assert.IsNotNull(message.Value);
            Assert.IsNull(message.GroupHeader);
            var parsedXml = TestHelper.Serialize(message.Value, TargetNamespaceEdifact);
            Assert.AreEqual(parsedXml.ToString(), expectedXml.ToString());
        }

        [TestMethod]
        public void TestGenerateWithEscapedSegmentTerminator()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_EscapedSegmentTerminator.txt";
            var interchange = TestHelper.GenerateEdifact(sample);

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
            var interchange = TestHelper.GenerateEdifact(sample);

            // ACT
            var ediSegments = interchange.GenerateEdi();

            // ASSERT
            Assert.AreEqual(TestHelper.AsString(sample), TestHelper.AsString(ediSegments, Environment.NewLine));
        }
        
        //[TestMethod]
        //public void TestToInterchangeWithValidation()
        //{
        //    // ARRANGE
        //    const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A.txt";
            
        //    // ACT
        //    var interchange = Interchange.LoadFrom(Assembly.GetExecutingAssembly().GetManifestResourceStream(sample));

        //    var brokenRules = new List<string>();
        //    foreach (var group in interchange.Groups)
        //    {
        //        foreach (var message in group.Messages)
        //        {
        //            brokenRules.AddRange(message.Validate());
        //        }
        //    }

        //    // ASSERT
        //    Assert.IsTrue(brokenRules.Any());
        //}

        [TestMethod]
        public void TestParseWithEscapedEscape()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_EscapedEscape.txt";
            const string expectedResult = "EdiFabric.Tests.Xml.Edifact_INVOIC_D00A_EscapedEscape.xml";
            var expectedXml = XElement.Load(TestHelper.Load(expectedResult));

            // ACT
            var message = TestHelper.ParseEdifact(sample);

            // ASSERT
            Assert.IsNotNull(message);
            Assert.IsNotNull(message.InterchangeHeader);
            Assert.IsNotNull(message.Value);
            Assert.IsNull(message.GroupHeader);
            var parsedXml = TestHelper.Serialize(message.Value, TargetNamespaceEdifact);
            Assert.AreEqual(parsedXml.ToString(), expectedXml.ToString());
        }

        [TestMethod]
        public void TestGenerateWithEscapedEscape()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_EscapedEscape.txt";
            var interchange = TestHelper.GenerateEdifact(sample);

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
            var interchange = TestHelper.GenerateEdifact(sample);

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
            var message = TestHelper.ParseEdifact(sample);

            // ASSERT
            Assert.IsNotNull(message);
            Assert.IsNotNull(message.InterchangeHeader);
            Assert.IsNotNull(message.Value);
            Assert.IsNull(message.GroupHeader);
            var parsedXml = TestHelper.Serialize(message.Value, TargetNamespaceEdifact);
            Assert.AreEqual(parsedXml.ToString(), expectedXml.ToString());
        }

        [TestMethod]
        public void TestGenerateWithRepeatingDataElement()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_RepeatingDataElement.txt";
            var interchange = TestHelper.GenerateEdifact(sample);

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
            var message = TestHelper.ParseEdifact(sample);

            // ASSERT
            Assert.IsNotNull(message);
            Assert.IsNotNull(message.InterchangeHeader);
            Assert.IsNotNull(message.Value);
            Assert.IsNull(message.GroupHeader);
            var parsedXml = TestHelper.Serialize(message.Value, TargetNamespaceEdifact);
            Assert.AreEqual(parsedXml.ToString(), expectedXml.ToString());
        }

        [TestMethod]
        public void TestGenerateWithEscapedRepetiton()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_EscapedRepetition.txt";
            var interchange = TestHelper.GenerateEdifact(sample);

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
            var interchange = TestHelper.GenerateEdifact(sample);

            // ACT
            var ediSegments = interchange.GenerateEdi();

            // ASSERT
            Assert.AreEqual(TestHelper.AsString(sample), TestHelper.AsString(ediSegments, Environment.NewLine));
        }
    }
}
