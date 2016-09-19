using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml.Linq;
using System.Xml.Schema;
using EdiFabric.Rules;
using EdiFabric.Framework;
using EdiFabric.Framework.Headers;
using EdiFabric.Framework.Readers;
using EdiFabric.Rules.EdifactD00AINVOIC;
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
            using (var ediReader = EdifactReader.Create(TestHelper.Load(sample), RulesAssemblyName))
            {
                if (ediReader.ReadMessage())
                {
                    // ASSERT
                    Assert.IsNotNull(ediReader.Message);
                    Assert.IsNotNull(ediReader.Message.InterchangeHeader);
                    Assert.IsNotNull(ediReader.Message.Value);
                    Assert.IsNull(ediReader.Message.GroupHeader);
                    var parsedXml = TestHelper.Serialize(ediReader.Message.Value, TargetNamespaceEdifact);                    
                    Assert.AreEqual(parsedXml.ToString(), expectedXml.ToString());
                }
                else
                {
                    Assert.Fail();
                }
            }
        }

        [TestMethod]
        public void TestGenerate()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A.txt";
            
            EdiMessage<S_UNB, S_UNZ> message;
            using (var ediReader = EdifactReader.Create(TestHelper.Load(sample), RulesAssemblyName))
            {
                ediReader.ReadMessage();
                message = ediReader.Message;
            }
            var group = new EdifactGroup<M_INVOIC>(null);
            group.AddItem(message.Value as M_INVOIC);
            var interchange = new EdifactInterchange(message.InterchangeHeader);
            interchange.AddItem(group);

            // ACT
            var ediSegments = interchange.GenerateEdi();

            // ASSERT
            Assert.AreEqual(TestHelper.AsString(sample), TestHelper.AsString(ediSegments, Environment.NewLine));
        }

        //[TestMethod]
        //public void TestToInterchangeWithDefaultUna()
        //{
        //    // ARRANGE
        //    const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_DefaultUNA.txt";
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

        //[TestMethod]
        //public void TestToInterchangeWithNonDefaultSeparators()
        //{
        //    // ARRANGE
        //    const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_NonDefaultSeparators.txt";
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

        //[TestMethod]
        //public void TestToInterchangeWithLf()
        //{
        //    // ARRANGE
        //    const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_LF.txt";
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

        //[TestMethod]
        //public void TestToEdiWithSegmentsComparison()
        //{
        //    // ARRANGE
        //    const string sample = "EdiFabric.Tests.Xml.Edifact_INVOIC_D00A.xml";
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
        //    var parsedEdi = Interchange.LoadFrom(XElement.Load(Assembly.GetExecutingAssembly().GetManifestResourceStream(sample))).ToEdi();

        //    // ASSERT
        //    Assert.AreEqual(expectedEdi.Count, parsedEdi.Count);
        //    for (int i = 0; i < parsedEdi.Count; i++)
        //    {
        //        Assert.IsTrue(parsedEdi[i] == expectedEdi[i]);
        //    }
        //}

        //[TestMethod]
        //public void TestToEdiWithSegmentsComparisonAndNonDefaultSeparators()
        //{
        //    // ARRANGE
        //    const string sample = "EdiFabric.Tests.Xml.Edifact_INVOIC_D00A.xml";
        //    const string expectedResult = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_NonDefaultSeparators.txt";

        //    var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(expectedResult);
        //    Debug.Assert(stream != null, "stream != null");

        //    var reader = new StreamReader(stream);
        //    var expectedEdi = new List<string>();
        //    while (reader.Peek() >= 0)
        //    {
        //        expectedEdi.Add(reader.ReadLine());
        //    }

        //    // ACT
        //    var interchangeContext = new Separators { DataElement = "|", Segment = "'"};
        //    var parsedEdi = Interchange.LoadFrom(XElement.Load(Assembly.GetExecutingAssembly().GetManifestResourceStream(sample))).ToEdi(interchangeContext);

        //    // ASSERT
        //    Assert.AreEqual(expectedEdi.Count, parsedEdi.Count);
        //    for (int i = 0; i < parsedEdi.Count; i++)
        //    {
        //        Assert.IsTrue(parsedEdi[i] == expectedEdi[i]);
        //    }
        //}

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
