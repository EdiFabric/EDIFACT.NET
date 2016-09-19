using System;
using System.Diagnostics;
using System.Reflection;
using System.Text;
using System.Xml.Linq;
using EdiFabric.Framework;
using EdiFabric.Framework.Constants;
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

        //[TestMethod]
        //public void TestToInterchangeWithFriendlyException()
        //{
        //    // ARRANGE
        //    const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_BadSegment.txt";
           
        //    // ACT
        //    try
        //    {
        //        Interchange.LoadFrom(Assembly.GetExecutingAssembly().GetManifestResourceStream(sample));
        //    }
        //    catch (Exception ex)
        //    {
        //        // ASSERT
        //        Assert.IsInstanceOfType(ex, typeof(ParserException));
        //    }
        //}

        //[TestMethod]
        //public void TestToInterchangeWithGroup()
        //{
        //    // ARRANGE
        //    const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_Group.txt";
        //    const string expectedResult = "EdiFabric.Tests.Xml.Edifact_INVOIC_D00A_Group.xml";

        //    var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(expectedResult);
        //    Debug.Assert(stream != null, "stream != null");
        //    var expectedXml = XElement.Load(stream);

        //    // ACT
        //    var interchange = Interchange.LoadFrom(Assembly.GetExecutingAssembly().GetManifestResourceStream(sample));
        //    var parsedXml = TestHelper.Serialize(interchange, TargetNamespaceEdifact); 

        //    // ASSERT
        //    Assert.AreEqual(parsedXml.ToString(), expectedXml.ToString());
        //}

        //[TestMethod]
        //public void TestToInterchangeWithGroupAndMultipleMessages()
        //{
        //    // ARRANGE
        //    const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_GroupMultipleMessages.txt";
        //    const string expectedResult = "EdiFabric.Tests.Xml.Edifact_INVOIC_D00A_GroupMultipleMessages.xml";

        //    var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(expectedResult);
        //    Debug.Assert(stream != null, "stream != null");
        //    var expectedXml = XElement.Load(stream);

        //    // ACT
        //    var interchange = Interchange.LoadFrom(Assembly.GetExecutingAssembly().GetManifestResourceStream(sample));
        //    var parsedXml = TestHelper.Serialize(interchange, TargetNamespaceEdifact); 

        //    // ASSERT
        //    Assert.AreEqual(parsedXml.ToString(), expectedXml.ToString());
        //}

        //[TestMethod]
        //public void TestToInterchangeWithMultipleGroups()
        //{
        //    // ARRANGE
        //    const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_MultipleGroups.txt";
        //    const string expectedResult = "EdiFabric.Tests.Xml.Edifact_INVOIC_D00A_MultipleGroups.xml";

        //    var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(expectedResult);
        //    Debug.Assert(stream != null, "stream != null");
        //    var expectedXml = XElement.Load(stream);

        //    // ACT
        //    var interchange = Interchange.LoadFrom(Assembly.GetExecutingAssembly().GetManifestResourceStream(sample));
        //    var parsedXml = TestHelper.Serialize(interchange, TargetNamespaceEdifact); 

        //    // ASSERT
        //    Assert.AreEqual(parsedXml.ToString(), expectedXml.ToString());
        //}      

        //[TestMethod]
        //public void TestToInterchangeWithMultipleMessages()
        //{
        //    // ARRANGE
        //    const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_MultipleMessages.txt";
        //    const string expectedResult = "EdiFabric.Tests.Xml.Edifact_INVOIC_D00A_MultipleMessages.xml";

        //    var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(expectedResult);
        //    Debug.Assert(stream != null, "stream != null");
        //    var expectedXml = XElement.Load(stream);

        //    // ACT
        //    var interchange = Interchange.LoadFrom(Assembly.GetExecutingAssembly().GetManifestResourceStream(sample));
        //    var parsedXml = TestHelper.Serialize(interchange, TargetNamespaceEdifact); 

        //    // ASSERT
        //    Assert.AreEqual(parsedXml.ToString(), expectedXml.ToString());
        //}

        //[TestMethod]
        //public void TestToInterchangeWithEscapedSegmentTerminator()
        //{
        //    // ARRANGE
        //    const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_EscapedSegmentTerminator.txt";
        //    const string expectedResult = "EdiFabric.Tests.Xml.Edifact_INVOIC_D00A_EscapedSegmentTerminator.xml";

        //    var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(expectedResult);
        //    Debug.Assert(stream != null, "stream != null");
        //    var expectedXml = XElement.Load(stream);

        //    // ACT
        //    var interchange = Interchange.LoadFrom(Assembly.GetExecutingAssembly().GetManifestResourceStream(sample));
        //    var parsedXml = TestHelper.Serialize(interchange, TargetNamespaceEdifact); 

        //    // ASSERT
        //    Assert.AreEqual(parsedXml.ToString(), expectedXml.ToString());
        //}

        //[TestMethod]
        //public void TestToEdiWithEscaped()
        //{
        //    // ARRANGE
        //    const string sample = "EdiFabric.Tests.Xml.Edifact_INVOIC_D00A_EscapedSegmentTerminator.xml";
        //    const string expectedResult = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_EscapedSegmentTerminator.txt";

        //    var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(expectedResult);
        //    Debug.Assert(stream != null, "stream != null");

        //    var reader = new StreamReader(stream);
        //    var expectedEdi = new List<string>();
        //    while (reader.Peek() >= 0)
        //    {
        //        expectedEdi.Add(reader.ReadLine());
        //    }

        //    // ACT
        //    var parsedEdi = Interchange.LoadFrom(XElement.Load(Assembly.GetExecutingAssembly().GetManifestResourceStream(sample)))
        //                   .ToEdi();

        //    // ASSERT
        //    Assert.AreEqual(expectedEdi.Count, parsedEdi.Count);
        //    for (int i = 0; i < parsedEdi.Count; i++)
        //    {
        //        Assert.IsTrue(parsedEdi[i] == expectedEdi[i]);
        //    }
        //}

        //[TestMethod]
        //public void TestToEdiWithInvalidContext()
        //{
        //    // ARRANGE
        //    const string sample = "EdiFabric.Tests.Xml.Edifact_INVOIC_D00A_EscapedSegmentTerminator.xml";
        //    var interchangeContext = new Separators
        //                                 {
        //                                     DataElement = "|",
        //                                     ComponentDataElement = "|"
        //                                 };

        //    // ACT
        //    try
        //    {
        //        Interchange.LoadFrom(
        //                XElement.Load(Assembly.GetExecutingAssembly().GetManifestResourceStream(sample))).ToEdi(interchangeContext);
        //    }
        //    catch (Exception ex)
        //    {
        //        // ASSERT
        //        Assert.IsInstanceOfType(ex, typeof(ParserException));
        //        Assert.IsTrue(ex.Message.StartsWith("Invalid interchange context"));
        //    }
        //}

        //[TestMethod]
        //public void TestToEdiWithEmptyNode()
        //{
        //    // ARRANGE
        //    const string sample = "EdiFabric.Tests.Xml.Edifact_INVOIC_D00A_EmptyNode.xml";
        //    const string expectedResult = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A.txt";

        //    var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(expectedResult);
        //    Debug.Assert(stream != null, "stream != null");

        //    var reader = new StreamReader(stream);
        //    var expectedEdi = new List<string>();
        //    while (reader.Peek() >= 0)
        //    {
        //        expectedEdi.Add(reader.ReadLine());
        //    }

        //    // ACT
        //    var parsedEdi = Interchange.LoadFrom(XElement.Load(Assembly.GetExecutingAssembly().GetManifestResourceStream(sample)))
        //                   .ToEdi();

        //    // ASSERT
        //    Assert.AreEqual(expectedEdi.Count, parsedEdi.Count);
        //    for (int i = 0; i < parsedEdi.Count; i++)
        //    {
        //        Assert.IsTrue(parsedEdi[i] == expectedEdi[i]);
        //    }
        //}

        //[TestMethod]
        //public void TestToEdiWithSegmentList()
        //{
        //    // ARRANGE
        //    const string sample = "EdiFabric.Tests.Xml.Edifact_INVOIC_D00A_SegmentList.xml";
        //    const string expectedResult = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A.txt";

        //    var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(expectedResult);
        //    Debug.Assert(stream != null, "stream != null");

        //    var reader = new StreamReader(stream);
        //    var expectedEdi = new List<string>();
        //    while (reader.Peek() >= 0)
        //    {
        //        expectedEdi.Add(reader.ReadLine());
        //    }

        //    // ACT
        //    var parsedEdi = Interchange.LoadFrom(XElement.Load(Assembly.GetExecutingAssembly().GetManifestResourceStream(sample)))
        //                   .ToEdi();

        //    // ASSERT
        //    Assert.AreEqual(expectedEdi.Count, parsedEdi.Count);
        //    for (int i = 0; i < parsedEdi.Count; i++)
        //    {
        //        Assert.IsTrue(parsedEdi[i] == expectedEdi[i]);
        //    }
        //}

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

        //[TestMethod]
        //public void TestToInterchangeWithEscapedEscape()
        //{
        //    // ARRANGE
        //    const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_EscapedEscape.txt";
        //    const string expectedResult = "EdiFabric.Tests.Xml.Edifact_INVOIC_D00A_EscapedEscape.xml";

        //    var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(expectedResult);
        //    Debug.Assert(stream != null, "stream != null");
        //    var expectedXml = XElement.Load(stream);

        //    // ACT
        //    var interchange = Interchange.LoadFrom(Assembly.GetExecutingAssembly().GetManifestResourceStream(sample));
        //    var parsedXml = TestHelper.Serialize(interchange, TargetNamespaceEdifact);

        //    // ASSERT
        //    Assert.AreEqual(parsedXml.ToString(), expectedXml.ToString());
        //}

        //[TestMethod]
        //public void TestToEdiWithEscapingTheEscapeGeneration()
        //{
        //    // ARRANGE
        //    const string sample = "EdiFabric.Tests.Xml.Edifact_INVOIC_D00A_EscapeGen.xml";
        //    const string expectedResult = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_EscapeGen.txt";

        //    var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(expectedResult);
        //    Debug.Assert(stream != null, "stream != null");

        //    var reader = new StreamReader(stream);
        //    var expectedEdi = new List<string>();
        //    while (reader.Peek() >= 0)
        //    {
        //        expectedEdi.Add(reader.ReadLine());
        //    }

        //    // ACT
        //    var parsedEdi = Interchange.LoadFrom(XElement.Load(Assembly.GetExecutingAssembly().GetManifestResourceStream(sample))).ToEdi();

        //    // ASSERT
        //    Assert.AreEqual(expectedEdi.Count, parsedEdi.Count);
        //    for (int i = 0; i < parsedEdi.Count; i++)
        //    {
        //        Assert.IsTrue(parsedEdi[i] == expectedEdi[i]);
        //    }
        //}

        //[TestMethod]
        //public void TestToEdiWithTrailingSeparator()
        //{
        //    // ARRANGE
        //    const string sample = "EdiFabric.Tests.Xml.Edifact_INVOIC_D00A_TrailingSeparator.xml";
        //    const string expectedResult = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_TrailingSeparator.txt";

        //    var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(expectedResult);
        //    Debug.Assert(stream != null, "stream != null");

        //    var reader = new StreamReader(stream);
        //    var expectedEdi = new List<string>();
        //    while (reader.Peek() >= 0)
        //    {
        //        expectedEdi.Add(reader.ReadLine());
        //    }

        //    // ACT
        //    var parsedEdi = Interchange.LoadFrom(XElement.Load(Assembly.GetExecutingAssembly().GetManifestResourceStream(sample))).ToEdi();

        //    // ASSERT
        //    Assert.AreEqual(expectedEdi.Count, parsedEdi.Count);
        //    for (int i = 0; i < parsedEdi.Count; i++)
        //    {
        //        Assert.IsTrue(parsedEdi[i] == expectedEdi[i]);
        //    }
        //}

        //[TestMethod]
        //public void TestToEdiWithEscapedRepetitonTerminator()
        //{
        //    // ARRANGE
        //    const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_EscapedRepetition.txt";
        //    const string expectedResult = "EdiFabric.Tests.Xml.Edifact_INVOIC_D00A_EscapedRepetition.xml";

        //    var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(expectedResult);
        //    Debug.Assert(stream != null, "stream != null");
        //    var expectedXml = XElement.Load(stream);

        //    // ACT
        //    var interchange = Interchange.LoadFrom(Assembly.GetExecutingAssembly().GetManifestResourceStream(sample));
        //    var parsedXml = TestHelper.Serialize(interchange, TargetNamespaceEdifact);

        //    // ASSERT
        //    Assert.AreEqual(parsedXml.ToString(), expectedXml.ToString());
        //}

        //[TestMethod]
        //public void TestToEdiWithBom()
        //{
        //    // ARRANGE
        //    const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_BOM.txt";
        //    const string expectedResult = "EdiFabric.Tests.Xml.Edifact_INVOIC_D00A.xml";

        //    var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(expectedResult);
        //    Debug.Assert(stream != null, "stream != null");
        //    var expectedXml = XElement.Load(stream);

        //    // ACT
        //    var interchange = Interchange.LoadFrom(Assembly.GetExecutingAssembly().GetManifestResourceStream(sample));
        //    var parsedXml = TestHelper.Serialize(interchange, TargetNamespaceEdifact);

        //    // ASSERT
        //    Assert.AreEqual(parsedXml.ToString(), expectedXml.ToString());
        //}
    }
}
