using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EdiFabric.Framework;
using EdiFabric.Framework.Controls.Edifact;
using EdiFabric.Framework.Exceptions;
using EdiFabric.Framework.Readers;
using EdiFabric.Rules.EDIFACT_D00A;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EdiFabric.Tests
{
    [TestClass]
    public class TestEdifact
    {
        [TestMethod]
        public void TestSingleMessage()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A.txt";
            var ediStream = TestHelper.LoadStream(sample);
            var expected = TestHelper.LoadString(sample);
            List<object> ediItems;
            
            // ACT
            using (var ediReader = new EdifactReader(ediStream, "EdiFabric.Rules.EdifactD00A"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }
            var actual = TestHelper.GenerateEdifact<TSINVOIC>(ediItems, null, Environment.NewLine);
            
            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsNotNull(ediItems.OfType<UNB>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<UNG>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<TSINVOIC>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<UNE>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<UNZ>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<ParsingException>().SingleOrDefault());
            Assert.AreEqual(expected, actual);
        }

        //[TestMethod]
        //public void TestValidationFailure()
        //{
        //    // ARRANGE
        //    const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A.txt";
        //    var ediStream = TestHelper.LoadStream(sample);
        //    List<object> ediItems;

        //    // ACT
        //    using (var ediReader = new EdifactReader(ediStream, "EdiFabric.Rules.EdifactD00A"))
        //    {
        //        ediItems = ediReader.ReadToEnd().ToList();
        //    }

        //    var message = ediItems.OfType<TSINVOIC>().Single();
        //    var validationResults = EdiValidator.Create("EdiFabric.Xsd").Validate(message);

        //    // ASSERT
        //    Assert.IsNotNull(validationResults);
        //    Assert.IsNotNull(validationResults.ErrorContext);
        //    Assert.IsTrue(validationResults.ErrorContext.Errors.Any() || validationResults.ErrorContext.Codes.Any());
        //}

        //[TestMethod]
        //public void TestParseEdifactWithValidation()
        //{
        //    // ARRANGE
        //    const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_Valid.txt";

        //    // ACT
        //    var message = TestHelper.ParseEdifact(sample).OfType<M_INVOIC>().Single();
        //    var validationResults = EdiValidator.Create("EdiFabric.Xsd").Validate(message);

        //    // ASSERT
        //    Assert.IsNotNull(validationResults);
        //    Assert.IsNotNull(validationResults.ErrorContext);
        //    Assert.IsFalse(validationResults.ErrorContext.Errors.Any());
        //    Assert.IsFalse(validationResults.ErrorContext.Codes.Any());
        //}

        [TestMethod]
        public void TestDefaultUna()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_DefaultUNA.txt";
            var ediStream = TestHelper.LoadStream(sample);
            var expected = TestHelper.LoadString(sample);
            List<object> ediItems;
            Separators separators;

            // ACT
            using (var ediReader = new EdifactReader(ediStream, "EdiFabric.Rules.EdifactD00A"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
                separators = ediReader.Separators;
            }
            var actual = TestHelper.GenerateEdifact<TSINVOIC>(ediItems, separators, Environment.NewLine);

            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsNotNull(ediItems.OfType<UNB>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<UNG>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<TSINVOIC>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<UNE>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<UNZ>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<ParsingException>().SingleOrDefault());
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestNonDefaultUna()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_NonDefaultSeparators.txt";
            var ediStream = TestHelper.LoadStream(sample);
            var expected = TestHelper.LoadString(sample);
            List<object> ediItems;
            Separators separators;

            // ACT
            using (var ediReader = new EdifactReader(ediStream, "EdiFabric.Rules.EdifactD00A"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
                separators = ediReader.Separators;
            }
            var actual = TestHelper.GenerateEdifact<TSINVOIC>(ediItems, separators, Environment.NewLine);

            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsNotNull(ediItems.OfType<UNB>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<UNG>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<TSINVOIC>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<UNE>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<UNZ>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<ParsingException>().SingleOrDefault());
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestPostfixLf()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_LF.txt";
            var ediStream = TestHelper.LoadStream(sample);
            var expected = TestHelper.LoadString(sample, Encoding.UTF8);
            List<object> ediItems;
            
            // ACT
            using (var ediReader = new EdifactReader(ediStream, "EdiFabric.Rules.EdifactD00A", Encoding.UTF8))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }
            var actual = TestHelper.GenerateEdifact<TSINVOIC>(ediItems, null, "\n");

            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsNotNull(ediItems.OfType<UNB>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<UNG>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<TSINVOIC>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<UNE>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<UNZ>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<ParsingException>().SingleOrDefault());
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestNonDefaultSeparators()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_NonDefaultSeparators.txt";
            var ediStream = TestHelper.LoadStream(sample);
            var expected = TestHelper.LoadString(sample);
            List<object> ediItems;
            Separators separators;

            // ACT
            using (var ediReader = new EdifactReader(ediStream, "EdiFabric.Rules.EdifactD00A"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
                separators = ediReader.Separators;
            }
            var actual = TestHelper.GenerateEdifact<TSINVOIC>(ediItems, separators, Environment.NewLine);

            // ASSERT
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestError()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_BadSegment.txt";
            var ediStream = TestHelper.LoadStream(sample);
            List<object> ediItems;

            // ACT
            using (var ediReader = new EdifactReader(ediStream, "EdiFabric.Rules.EdifactD00A"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }
            
            // ASSERT
            Assert.IsNotNull(ediItems.OfType<UNB>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<UNG>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<ParsingException>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<UNE>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<UNZ>().SingleOrDefault());
        }

        [TestMethod]
        public void TestGroup()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_Group.txt";
            var ediStream = TestHelper.LoadStream(sample);
            var expected = TestHelper.LoadString(sample);
            List<object> ediItems;

            // ACT
            using (var ediReader = new EdifactReader(ediStream, "EdiFabric.Rules.EdifactD00A"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }
            var actual = TestHelper.GenerateEdifact<TSINVOIC>(ediItems, null, Environment.NewLine);

            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsNotNull(ediItems.OfType<UNB>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<UNG>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<TSINVOIC>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<UNE>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<UNZ>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<ParsingException>().SingleOrDefault());
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGroupAndMultipleMessages()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_GroupMultipleMessages.txt";
            var ediStream = TestHelper.LoadStream(sample);
            var expected = TestHelper.LoadString(sample);
            List<object> ediItems;

            // ACT
            using (var ediReader = new EdifactReader(ediStream, "EdiFabric.Rules.EdifactD00A"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }
            var actual = TestHelper.GenerateEdifact<TSINVOIC>(ediItems, null, Environment.NewLine);

            // ASSERT
            Assert.IsTrue(ediItems.OfType<UNB>().Count() == 1);
            Assert.IsTrue(ediItems.OfType<UNG>().Count() == 1);
            Assert.IsTrue(ediItems.OfType<TSINVOIC>().Count() == 2);
            Assert.IsTrue(ediItems.OfType<UNE>().Count() == 1);
            Assert.IsTrue(ediItems.OfType<UNZ>().Count() == 1);
            Assert.IsNull(ediItems.OfType<ParsingException>().SingleOrDefault());
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMultipleGroups()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_MultipleGroups.txt";
            var ediStream = TestHelper.LoadStream(sample);
            var expected = TestHelper.LoadString(sample);
            List<object> ediItems;

            // ACT
            using (var ediReader = new EdifactReader(ediStream, "EdiFabric.Rules.EdifactD00A"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }
            var actual = TestHelper.GenerateEdifact<TSINVOIC>(ediItems, null, Environment.NewLine);

            // ASSERT
            Assert.IsTrue(ediItems.OfType<UNB>().Count() == 1);
            Assert.IsTrue(ediItems.OfType<UNG>().Count() == 2);
            Assert.IsTrue(ediItems.OfType<TSINVOIC>().Count() == 2);
            Assert.IsTrue(ediItems.OfType<UNE>().Count() == 2);
            Assert.IsTrue(ediItems.OfType<UNZ>().Count() == 1);
            Assert.IsNull(ediItems.OfType<ParsingException>().SingleOrDefault());
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMultipleMessages()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_MultipleMessages.txt";
            var ediStream = TestHelper.LoadStream(sample);
            var expected = TestHelper.LoadString(sample);
            List<object> ediItems;

            // ACT
            using (var ediReader = new EdifactReader(ediStream, "EdiFabric.Rules.EdifactD00A"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }
            var actual = TestHelper.GenerateEdifact<TSINVOIC>(ediItems, null, Environment.NewLine);

            // ASSERT
            Assert.IsTrue(ediItems.OfType<TSINVOIC>().Count() == 2);
            Assert.IsTrue(ediItems.OfType<UNB>().Count() == 1);
            Assert.IsTrue(ediItems.OfType<UNZ>().Count() == 1);
            Assert.IsTrue(!ediItems.OfType<UNG>().Any());
            Assert.IsTrue(!ediItems.OfType<UNE>().Any());
            Assert.IsNull(ediItems.OfType<ParsingException>().SingleOrDefault());
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestEscapedSegmentTerminator()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_EscapedSegmentTerminator.txt";
            var ediStream = TestHelper.LoadStream(sample);
            var expected = TestHelper.LoadString(sample);
            List<object> ediItems;

            // ACT
            using (var ediReader = new EdifactReader(ediStream, "EdiFabric.Rules.EdifactD00A"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }
            var actual = TestHelper.GenerateEdifact<TSINVOIC>(ediItems, null, Environment.NewLine);

            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsNotNull(ediItems.OfType<UNB>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<UNG>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<TSINVOIC>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<UNE>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<UNZ>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<ParsingException>().SingleOrDefault());
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestRepeatingSegment()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_RepeatingSegment.txt";
            var ediStream = TestHelper.LoadStream(sample);
            var expected = TestHelper.LoadString(sample);
            List<object> ediItems;

            // ACT
            using (var ediReader = new EdifactReader(ediStream, "EdiFabric.Rules.EdifactD00A"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }
            var actual = TestHelper.GenerateEdifact<TSINVOIC>(ediItems, null, Environment.NewLine);

            // ASSERT
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestEscapedEscape()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_EscapedEscape.txt";
            var ediStream = TestHelper.LoadStream(sample);
            var expected = TestHelper.LoadString(sample);
            List<object> ediItems;

            // ACT
            using (var ediReader = new EdifactReader(ediStream, "EdiFabric.Rules.EdifactD00A"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }
            var actual = TestHelper.GenerateEdifact<TSINVOIC>(ediItems, null, Environment.NewLine);

            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsNotNull(ediItems.OfType<UNB>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<UNG>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<TSINVOIC>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<UNE>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<UNZ>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<ParsingException>().SingleOrDefault());
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestTrailingSeparator()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_TrailingSeparator.txt";
            var ediStream = TestHelper.LoadStream(sample);
            var expected = TestHelper.LoadString(sample);
            List<object> ediItems;

            // ACT
            using (var ediReader = new EdifactReader(ediStream, "EdiFabric.Rules.EdifactD00A"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }
            var actual = TestHelper.GenerateEdifact<TSINVOIC>(ediItems, null, Environment.NewLine);

            // ASSERT
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestRepeatingDataElement()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_RepeatingDataElement.txt";
            var ediStream = TestHelper.LoadStream(sample);
            var expected = TestHelper.LoadString(sample);
            List<object> ediItems;

            // ACT
            using (var ediReader = new EdifactReader(ediStream, "EdiFabric.Rules.EdifactD00A"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }
            var actual = TestHelper.GenerateEdifact<TSINVOIC>(ediItems, null, Environment.NewLine);

            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsNotNull(ediItems.OfType<UNB>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<UNG>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<TSINVOIC>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<UNE>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<UNZ>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<ParsingException>().SingleOrDefault());
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestEscapedRepetiton()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_EscapedRepetition.txt";
            var ediStream = TestHelper.LoadStream(sample);
            var expected = TestHelper.LoadString(sample);
            List<object> ediItems;

            // ACT
            using (var ediReader = new EdifactReader(ediStream, "EdiFabric.Rules.EdifactD00A"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }
            var actual = TestHelper.GenerateEdifact<TSINVOIC>(ediItems, null, Environment.NewLine);

            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsNotNull(ediItems.OfType<UNB>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<UNG>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<TSINVOIC>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<UNE>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<UNZ>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<ParsingException>().SingleOrDefault());
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestBom()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_BOM.txt";
            var ediStream = TestHelper.LoadStream(sample);
            var expected = TestHelper.LoadString(sample);
            List<object> ediItems;

            // ACT
            using (var ediReader = new EdifactReader(ediStream, "EdiFabric.Rules.EdifactD00A"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }
            var actual = TestHelper.GenerateEdifact<TSINVOIC>(ediItems, null, Environment.NewLine);

            // ASSERT
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestTrailingBlanks()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_TrailingBlanks.txt";
            const string sampleClean = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A.txt";
            var ediStream = TestHelper.LoadStream(sample);
            var expected = TestHelper.LoadString(sampleClean);
            List<object> ediItems;

            // ACT
            using (var ediReader = new EdifactReader(ediStream, "EdiFabric.Rules.EdifactD00A"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }
            var actual = TestHelper.GenerateEdifact<TSINVOIC>(ediItems, null, Environment.NewLine);

            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsNotNull(ediItems.OfType<UNB>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<UNG>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<UNE>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<UNZ>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<ParsingException>().SingleOrDefault());
            Assert.IsTrue(ediItems.OfType<TSINVOIC>().Count() == 1);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMultipleInterchange()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_MultipleInterchange.txt";
            var ediStream = TestHelper.LoadStream(sample);
            var expected = TestHelper.LoadString(sample);
            var ediItems = new List<object>();

            // ACT
            var actual = "";
            using (var ediReader = new EdifactReader(ediStream, "EdiFabric.Rules.EdifactD00A"))
            {
                while (ediReader.Read())
                {
                    if (ediReader.Item is UNB && ediItems.Any())
                    {
                        actual = actual + TestHelper.GenerateEdifact<TSINVOIC>(ediItems, null, Environment.NewLine);
                        ediItems.Clear();
                    }

                    ediItems.Add(ediReader.Item);
                }

                actual = actual + TestHelper.GenerateEdifact<TSINVOIC>(ediItems, ediReader.Separators, Environment.NewLine);
            }
            
            // ASSERT
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestInvalidTrailers()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_InvalidTrailers.txt";
            var ediStream = TestHelper.LoadStream(sample);
            List<object> ediItems;

            // ACT
            using (var ediReader = new EdifactReader(ediStream, "EdiFabric.Rules.EdifactD00A"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }
            
            // ASSERT
            Assert.IsNotNull(ediItems.OfType<UNB>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<UNG>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<TSINVOIC>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<UNE>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<UNZ>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<ParsingException>().SingleOrDefault());
        }

        [TestMethod]
        public void TestInvalidHeader()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_InvalidHeader.txt";
            var ediStream = TestHelper.LoadStream(sample);
            List<object> ediItems;

            // ACT
            using (var ediReader = new EdifactReader(ediStream, "EdiFabric.Rules.EdifactD00A"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }

            // ASSERT
            Assert.IsNotNull(ediItems.OfType<ParsingException>().SingleOrDefault());
        }

        [TestMethod]
        public void TestInvalidSegment()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_InvalidSegment.txt";
            var ediStream = TestHelper.LoadStream(sample);
            List<object> ediItems;

            // ACT
            using (var ediReader = new EdifactReader(ediStream, "EdiFabric.Rules.EdifactD00A"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }

            // ASSERT
            Assert.IsNotNull(ediItems.OfType<UNB>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<UNG>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<TSINVOIC>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<UNE>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<UNZ>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<ParsingException>().SingleOrDefault());
        }

        [TestMethod]
        public void TestGroupRead()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_MultipleGroups.txt";
            var ediStream = TestHelper.LoadStream(sample);
            var ediItems = new List<object>();

            // ACT
            using (var ediReader = new EdifactReader(ediStream, "EdiFabric.Rules.EdifactD00A"))
            {
                while (ediReader.Read())
                {
                    ediItems.Add(ediReader.Item);
                    if (!(ediReader.Item is UNE)) continue;

                    // ASSERT
                    Assert.IsNotNull(ediItems.OfType<UNG>().SingleOrDefault());
                    Assert.IsNotNull(ediItems.OfType<TSINVOIC>().SingleOrDefault());
                    Assert.IsNotNull(ediItems.OfType<UNE>().SingleOrDefault());
                    Assert.IsNull(ediItems.OfType<ParsingException>().SingleOrDefault());
                    ediItems.Clear();
                }
            }
        }

        [TestMethod]
        public void TestInterchangeRead()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_MultipleInterchange.txt";
            var ediStream = TestHelper.LoadStream(sample);
            var ediItems = new List<object>();

            // ACT
            using (var ediReader = new EdifactReader(ediStream, "EdiFabric.Rules.EdifactD00A"))
            {
                while (ediReader.Read())
                {
                    ediItems.Add(ediReader.Item);
                    if (!(ediReader.Item is UNZ)) continue;

                    // ASSERT
                    Assert.IsNotNull(ediItems.OfType<UNB>().SingleOrDefault());
                    Assert.IsNull(ediItems.OfType<UNG>().SingleOrDefault());
                    Assert.IsNotNull(ediItems.OfType<TSINVOIC>().SingleOrDefault());
                    Assert.IsNull(ediItems.OfType<UNE>().SingleOrDefault());
                    Assert.IsNotNull(ediItems.OfType<UNZ>().SingleOrDefault());
                    Assert.IsNull(ediItems.OfType<ParsingException>().SingleOrDefault());
                    ediItems.Clear();
                }
            }
        }

        [TestMethod]
        public void TestMissingGroupTrailer()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_MissingGroupTrailer.txt";
            var ediStream = TestHelper.LoadStream(sample);
            List<object> ediItems;

            // ACT
            using (var ediReader = new EdifactReader(ediStream, "EdiFabric.Rules.EdifactD00A"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }

            // ASSERT
            Assert.IsNotNull(ediItems.OfType<UNB>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<UNG>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<TSINVOIC>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<UNE>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<UNZ>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<ParsingException>().SingleOrDefault());
        }

        [TestMethod]
        public void TestMissingInterchangeTrailer()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_MissingInterchangeTrailer.txt";
            var ediStream = TestHelper.LoadStream(sample);
            List<object> ediItems;

            // ACT
            using (var ediReader = new EdifactReader(ediStream, "EdiFabric.Rules.EdifactD00A"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }

            // ASSERT
            Assert.IsTrue(ediItems.OfType<UNB>().Count() == 2);
            Assert.IsNull(ediItems.OfType<UNG>().SingleOrDefault());
            Assert.IsTrue(ediItems.OfType<TSINVOIC>().Count() == 2);
            Assert.IsNull(ediItems.OfType<UNE>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<UNZ>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<ParsingException>().SingleOrDefault());
        }

        [TestMethod]
        public void TestValidAndInvalidMessageRead()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_ValidAndInvalidMessage.txt";
            var ediStream = TestHelper.LoadStream(sample);
            List<object> ediItems;

            // ACT
            using (var ediReader = new EdifactReader(ediStream, "EdiFabric.Rules.EdifactD00A"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }

            // ASSERT
            Assert.IsNotNull(ediItems.OfType<UNB>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<UNG>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<TSINVOIC>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<UNE>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<UNZ>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<ParsingException>().SingleOrDefault());
        }

        [TestMethod]
        public void TestBlankRepetition()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_BlankRepetition.txt";
            const string sampleClean = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A.txt";
            var ediStream = TestHelper.LoadStream(sample);
            var expected = TestHelper.LoadString(sampleClean);
            List<object> ediItems;

            // ACT
            using (var ediReader = new EdifactReader(ediStream, "EdiFabric.Rules.EdifactD00A"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }
            var actual = TestHelper.GenerateEdifact<TSINVOIC>(ediItems, null, Environment.NewLine);

            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsNotNull(ediItems.OfType<UNB>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<UNG>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<TSINVOIC>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<UNE>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<UNZ>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<ParsingException>().SingleOrDefault());
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMultipleInvalidInterchanges()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_MultipleInvalidInterchanges.txt";
            var ediStream = TestHelper.LoadStream(sample);
            List<object> ediItems;

            // ACT
            using (var ediReader = new EdifactReader(ediStream, "EdiFabric.Rules.EdifactD00A"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }

            // ASSERT
            Assert.IsTrue(ediItems.OfType<UNB>().Count() == 2);
            Assert.IsNull(ediItems.OfType<UNG>().SingleOrDefault());
            Assert.IsTrue(ediItems.OfType<TSINVOIC>().Count() == 3);
            Assert.IsNull(ediItems.OfType<UNE>().SingleOrDefault());
            Assert.IsTrue(ediItems.OfType<UNZ>().Count() == 2);
            Assert.IsNotNull(ediItems.OfType<ParsingException>().SingleOrDefault());
            Assert.IsTrue(ediItems.Count == 8);
        }

        [TestMethod]
        public void TestMultipleInvalidMessages()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_MultipleInvalidMessages.txt";
            var ediStream = TestHelper.LoadStream(sample);
            List<object> ediItems;

            // ACT
            using (var ediReader = new EdifactReader(ediStream, "EdiFabric.Rules.EdifactD00A"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }

            // ASSERT
            Assert.IsTrue(ediItems.OfType<UNB>().Count() == 1);
            Assert.IsNull(ediItems.OfType<UNG>().SingleOrDefault());
            Assert.IsTrue(ediItems.OfType<TSINVOIC>().Count() == 3);
            Assert.IsNull(ediItems.OfType<UNE>().SingleOrDefault());
            Assert.IsTrue(ediItems.OfType<UNZ>().Count() == 1);
            Assert.IsTrue(ediItems.OfType<ParsingException>().Count() == 2);
        }

        //[TestMethod]
        //public void TestValidationRules()
        //{
        //    // ARRANGE
        //    const string sample = "EdiFabric.Tests.Xml.Edifact_INVOIC_D00A_Validation.xml";
        //    var obj = TestHelper.Deserialize<M_INVOIC>(TestHelper.LoadStream(sample));
        //    const string expectedResult = "EdiFabric.Tests.Xml.Edifact_INVOIC_D00A_ValidationExpected.xml";
        //    var expectedXml = XElement.Load(TestHelper.LoadStream(expectedResult));

        //    // ACT
        //    var error = EdiValidator.Create("EdiFabric.Xsd").Validate(obj);

        //    // ASSERT
        //    Assert.IsNotNull(error);
        //    var root = TestHelper.Serialize(error.Flatten().ToList()).Root;
        //    Assert.IsNotNull(root);
        //    Assert.AreEqual(root.ToString(), expectedXml.ToString());
        //}
    }
}
