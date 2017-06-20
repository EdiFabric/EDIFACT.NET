using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using EdiFabric.Core.ErrorCodes;
using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.Edifact;
using EdiFabric.Core.Model.Edi.ErrorContexts;
using EdiFabric.Framework;
using EdiFabric.Framework.Readers;
using EdiFabric.Framework.Writers;
using EdiFabric.Rules.EDIFACT_D00A;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EdiFabric.UnitTests.Edifact
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestSingleMessage()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.Edifact.Edi.Edifact_INVOIC_D00A.txt";
            var ediStream = CommonHelper.LoadStream(sample);
            var expected = CommonHelper.LoadString(sample);
            List<EdiItem> ediItems;
            
            // ACT
            using (var ediReader = new EdifactReader(ediStream, "EdiFabric.Rules.EdifactD00A"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }
            var actual = EdifactHelper.Generate(ediItems, null, Environment.NewLine);
            
            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsNotNull(ediItems.OfType<UNB>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<UNG>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<TSINVOIC>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<UNE>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<UNZ>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<ErrorContext>().SingleOrDefault());
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDefaultUna()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.Edifact.Edi.Edifact_INVOIC_D00A_DefaultUNA.txt";
            var ediStream = CommonHelper.LoadStream(sample);
            var expected = CommonHelper.LoadString(sample);
            List<EdiItem> ediItems;
            Separators separators;

            // ACT
            using (var ediReader = new EdifactReader(ediStream, "EdiFabric.Rules.EdifactD00A"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
                separators = ediReader.Separators;
            }
            var actual = EdifactHelper.Generate(ediItems, separators, Environment.NewLine, null, separators.ToUna());

            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsNotNull(ediItems.OfType<UNB>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<UNG>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<TSINVOIC>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<UNE>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<UNZ>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<ErrorContext>().SingleOrDefault());
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestNonDefaultUna()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.Edifact.Edi.Edifact_INVOIC_D00A_NonDefaultSeparators.txt";
            var ediStream = CommonHelper.LoadStream(sample);
            var expected = CommonHelper.LoadString(sample);
            List<EdiItem> ediItems;
            Separators separators;

            // ACT
            using (var ediReader = new EdifactReader(ediStream, "EdiFabric.Rules.EdifactD00A"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
                separators = ediReader.Separators;
            }
            var actual = EdifactHelper.Generate(ediItems, separators, Environment.NewLine);

            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsNotNull(ediItems.OfType<UNB>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<UNG>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<TSINVOIC>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<UNE>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<UNZ>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<ErrorContext>().SingleOrDefault());
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestPostfixLf()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.Edifact.Edi.Edifact_INVOIC_D00A_LF.txt";
            var ediStream = CommonHelper.LoadStream(sample);
            var expected = CommonHelper.LoadString(sample);
            List<EdiItem> ediItems;
            
            // ACT
            using (var ediReader = new EdifactReader(ediStream, "EdiFabric.Rules.EdifactD00A"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }
            var actual = EdifactHelper.Generate(ediItems, null, "\n", Encoding.UTF8);

            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsNotNull(ediItems.OfType<UNB>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<UNG>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<TSINVOIC>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<UNE>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<UNZ>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<ErrorContext>().SingleOrDefault());
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestNonDefaultSeparators()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.Edifact.Edi.Edifact_INVOIC_D00A_NonDefaultSeparators.txt";
            var ediStream = CommonHelper.LoadStream(sample);
            var expected = CommonHelper.LoadString(sample);
            List<EdiItem> ediItems;
            Separators separators;

            // ACT
            using (var ediReader = new EdifactReader(ediStream, "EdiFabric.Rules.EdifactD00A"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
                separators = ediReader.Separators;
            }
            var actual = EdifactHelper.Generate(ediItems, separators, Environment.NewLine);

            // ASSERT
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestError()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.Edifact.Edi.Edifact_INVOIC_D00A_BadSegment.txt";
            var ediStream = CommonHelper.LoadStream(sample);
            List<EdiItem> ediItems;

            // ACT
            using (var ediReader = new EdifactReader(ediStream, "EdiFabric.Rules.EdifactD00A"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }
            
            // ASSERT
            Assert.IsNotNull(ediItems.OfType<UNB>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<UNG>().SingleOrDefault());
            var error = ediItems.OfType<TSINVOIC>().SingleOrDefault();
            Assert.IsNotNull(error);
            Assert.IsTrue(error.HasErrors);
            Assert.IsNotNull(error.ErrorContext.Errors.Any(e => e.Codes.Contains(SegmentErrorCode.UnrecognizedSegment)));
            Assert.IsNull(ediItems.OfType<UNE>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<UNZ>().SingleOrDefault());
        }

        [TestMethod]
        public void TestGroup()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.Edifact.Edi.Edifact_INVOIC_D00A_Group.txt";
            var ediStream = CommonHelper.LoadStream(sample);
            var expected = CommonHelper.LoadString(sample);
            List<EdiItem> ediItems;

            // ACT
            using (var ediReader = new EdifactReader(ediStream, "EdiFabric.Rules.EdifactD00A"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }
            var actual = EdifactHelper.Generate(ediItems, null, Environment.NewLine);

            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsNotNull(ediItems.OfType<UNB>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<UNG>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<TSINVOIC>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<UNE>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<UNZ>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<ErrorContext>().SingleOrDefault());
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGroupAndMultipleMessages()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.Edifact.Edi.Edifact_INVOIC_D00A_GroupMultipleMessages.txt";
            var ediStream = CommonHelper.LoadStream(sample);
            var expected = CommonHelper.LoadString(sample);
            List<EdiItem> ediItems;

            // ACT
            using (var ediReader = new EdifactReader(ediStream, "EdiFabric.Rules.EdifactD00A"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }
            var actual = EdifactHelper.Generate(ediItems, null, Environment.NewLine);

            // ASSERT
            Assert.IsTrue(ediItems.OfType<UNB>().Count() == 1);
            Assert.IsTrue(ediItems.OfType<UNG>().Count() == 1);
            Assert.IsTrue(ediItems.OfType<TSINVOIC>().Count() == 2);
            Assert.IsTrue(ediItems.OfType<UNE>().Count() == 1);
            Assert.IsTrue(ediItems.OfType<UNZ>().Count() == 1);
            Assert.IsNull(ediItems.OfType<ErrorContext>().SingleOrDefault());
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMultipleGroups()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.Edifact.Edi.Edifact_INVOIC_D00A_MultipleGroups.txt";
            var ediStream = CommonHelper.LoadStream(sample);
            var expected = CommonHelper.LoadString(sample);
            List<EdiItem> ediItems;

            // ACT
            using (var ediReader = new EdifactReader(ediStream, "EdiFabric.Rules.EdifactD00A"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }
            var actual = EdifactHelper.Generate(ediItems, null, Environment.NewLine);

            // ASSERT
            Assert.IsTrue(ediItems.OfType<UNB>().Count() == 1);
            Assert.IsTrue(ediItems.OfType<UNG>().Count() == 2);
            Assert.IsTrue(ediItems.OfType<TSINVOIC>().Count() == 2);
            Assert.IsTrue(ediItems.OfType<UNE>().Count() == 2);
            Assert.IsTrue(ediItems.OfType<UNZ>().Count() == 1);
            Assert.IsNull(ediItems.OfType<ErrorContext>().SingleOrDefault());
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMultipleMessages()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.Edifact.Edi.Edifact_INVOIC_D00A_MultipleMessages.txt";
            var ediStream = CommonHelper.LoadStream(sample);
            var expected = CommonHelper.LoadString(sample);
            List<EdiItem> ediItems;

            // ACT
            using (var ediReader = new EdifactReader(ediStream, "EdiFabric.Rules.EdifactD00A"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }
            var actual = EdifactHelper.Generate(ediItems, null, Environment.NewLine);

            // ASSERT
            Assert.IsTrue(ediItems.OfType<TSINVOIC>().Count() == 2);
            Assert.IsTrue(ediItems.OfType<UNB>().Count() == 1);
            Assert.IsTrue(ediItems.OfType<UNZ>().Count() == 1);
            Assert.IsTrue(!ediItems.OfType<UNG>().Any());
            Assert.IsTrue(!ediItems.OfType<UNE>().Any());
            Assert.IsNull(ediItems.OfType<ErrorContext>().SingleOrDefault());
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestEscapedSegmentTerminator()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.Edifact.Edi.Edifact_INVOIC_D00A_EscapedSegmentTerminator.txt";
            var ediStream = CommonHelper.LoadStream(sample);
            var expected = CommonHelper.LoadString(sample);
            List<EdiItem> ediItems;

            // ACT
            using (var ediReader = new EdifactReader(ediStream, "EdiFabric.Rules.EdifactD00A"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }
            var actual = EdifactHelper.Generate(ediItems, null, Environment.NewLine);

            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsNotNull(ediItems.OfType<UNB>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<UNG>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<TSINVOIC>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<UNE>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<UNZ>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<ErrorContext>().SingleOrDefault());
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestRepeatingSegment()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.Edifact.Edi.Edifact_INVOIC_D00A_RepeatingSegment.txt";
            var ediStream = CommonHelper.LoadStream(sample);
            var expected = CommonHelper.LoadString(sample);
            List<EdiItem> ediItems;

            // ACT
            using (var ediReader = new EdifactReader(ediStream, "EdiFabric.Rules.EdifactD00A"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }
            var actual = EdifactHelper.Generate(ediItems, null, Environment.NewLine);

            // ASSERT
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestEscapedEscape()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.Edifact.Edi.Edifact_INVOIC_D00A_EscapedEscape.txt";
            var ediStream = CommonHelper.LoadStream(sample);
            var expected = CommonHelper.LoadString(sample);
            List<EdiItem> ediItems;

            // ACT
            using (var ediReader = new EdifactReader(ediStream, "EdiFabric.Rules.EdifactD00A"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }
            var actual = EdifactHelper.Generate(ediItems, null, Environment.NewLine);

            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsNotNull(ediItems.OfType<UNB>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<UNG>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<TSINVOIC>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<UNE>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<UNZ>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<ErrorContext>().SingleOrDefault());
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestTrailingSeparator()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.Edifact.Edi.Edifact_INVOIC_D00A_TrailingSeparator.txt";
            var ediStream = CommonHelper.LoadStream(sample);
            var expected = CommonHelper.LoadString(sample);
            List<EdiItem> ediItems;

            // ACT
            using (var ediReader = new EdifactReader(ediStream, "EdiFabric.Rules.EdifactD00A"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }
            var actual = EdifactHelper.Generate(ediItems, null, Environment.NewLine);

            // ASSERT
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestRepeatingDataElement()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.Edifact.Edi.Edifact_INVOIC_D00A_RepeatingDataElement.txt";
            var ediStream = CommonHelper.LoadStream(sample);
            var expected = CommonHelper.LoadString(sample);
            List<EdiItem> ediItems;

            // ACT
            using (var ediReader = new EdifactReader(ediStream, "EdiFabric.Rules.EdifactD00A"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }
            var actual = EdifactHelper.Generate(ediItems, null, Environment.NewLine);

            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsNotNull(ediItems.OfType<UNB>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<UNG>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<TSINVOIC>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<UNE>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<UNZ>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<ErrorContext>().SingleOrDefault());
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestEscapedRepetiton()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.Edifact.Edi.Edifact_INVOIC_D00A_EscapedRepetition.txt";
            var ediStream = CommonHelper.LoadStream(sample);
            var expected = CommonHelper.LoadString(sample);
            List<EdiItem> ediItems;

            // ACT
            using (var ediReader = new EdifactReader(ediStream, "EdiFabric.Rules.EdifactD00A"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }
            var actual = EdifactHelper.Generate(ediItems, null, Environment.NewLine);

            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsNotNull(ediItems.OfType<UNB>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<UNG>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<TSINVOIC>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<UNE>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<UNZ>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<ErrorContext>().SingleOrDefault());
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestBom()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.Edifact.Edi.Edifact_INVOIC_D00A_BOM.txt";
            var ediStream = CommonHelper.LoadStream(sample);
            var expected = CommonHelper.LoadString(sample);
            List<EdiItem> ediItems;

            // ACT
            using (var ediReader = new EdifactReader(ediStream, "EdiFabric.Rules.EdifactD00A"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }
            var actual = EdifactHelper.Generate(ediItems, null, Environment.NewLine, Encoding.UTF8);

            // ASSERT
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestTrailingBlanks()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.Edifact.Edi.Edifact_INVOIC_D00A_TrailingBlanks.txt";
            const string sampleClean = "EdiFabric.UnitTests.Edifact.Edi.Edifact_INVOIC_D00A.txt";
            var ediStream = CommonHelper.LoadStream(sample);
            var expected = CommonHelper.LoadString(sampleClean);
            List<EdiItem> ediItems;

            // ACT
            using (var ediReader = new EdifactReader(ediStream, "EdiFabric.Rules.EdifactD00A"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }
            var actual = EdifactHelper.Generate(ediItems, null, Environment.NewLine);

            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsNotNull(ediItems.OfType<UNB>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<UNG>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<UNE>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<UNZ>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<ErrorContext>().SingleOrDefault());
            Assert.IsTrue(ediItems.OfType<TSINVOIC>().Count() == 1);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMultipleInterchange()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.Edifact.Edi.Edifact_INVOIC_D00A_MultipleInterchange.txt";
            var ediStream = CommonHelper.LoadStream(sample);
            var expected = CommonHelper.LoadString(sample);
            var ediItems = new List<EdiItem>();

            // ACT
            var actual = "";
            using (var ediReader = new EdifactReader(ediStream, "EdiFabric.Rules.EdifactD00A"))
            {
                while (ediReader.Read())
                {
                    if (ediReader.Item is UNB && ediItems.Any())
                    {
                        actual = actual + EdifactHelper.Generate(ediItems, null, Environment.NewLine);
                        ediItems.Clear();
                    }

                    ediItems.Add(ediReader.Item);
                }

                actual = actual + EdifactHelper.Generate(ediItems, ediReader.Separators, Environment.NewLine);
            }
            
            // ASSERT
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestInvalidTrailers()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.Edifact.Edi.Edifact_INVOIC_D00A_InvalidTrailers.txt";
            var ediStream = CommonHelper.LoadStream(sample);
            List<EdiItem> ediItems;

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
            var error = ediItems.OfType<ReaderErrorContext>().SingleOrDefault();
            Assert.IsNotNull(error);
            Assert.IsNotNull(error.ReaderErrorCode == ReaderErrorCode.ImproperEndOfFile);
        }

        [TestMethod]
        public void TestInvalidHeader()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.Edifact.Edi.Edifact_INVOIC_D00A_InvalidHeader.txt";
            var ediStream = CommonHelper.LoadStream(sample);
            List<EdiItem> ediItems;

            // ACT
            using (var ediReader = new EdifactReader(ediStream, "EdiFabric.Rules.EdifactD00A"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }

            // ASSERT
            var error = ediItems.OfType<ReaderErrorContext>().SingleOrDefault();
            Assert.IsNotNull(error);
            Assert.IsNotNull(error.ReaderErrorCode == ReaderErrorCode.InvalidControlStructure);
        }

        [TestMethod]
        public void TestTooManyDataElements()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.Edifact.Edi.Edifact_INVOIC_D00A_InvalidSegment.txt";
            var ediStream = CommonHelper.LoadStream(sample);
            List<EdiItem> ediItems;

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
            var error = ediItems.OfType<TSINVOIC>().SingleOrDefault();
            Assert.IsNotNull(error);
            Assert.IsTrue(error.HasErrors);
            Assert.IsTrue(error.ErrorContext.Errors.Any(e => e.Errors.Any(d => d.Code == DataElementErrorCode.TooManyDataElements)));

            MessageErrorContext mec;
            Assert.IsFalse(error.IsValid(out mec));
            Assert.IsTrue(mec.Errors.Any(e => e.Errors.Any(d => d.Code == DataElementErrorCode.TooManyDataElements)));
            Assert.IsTrue(mec.Errors.Count > 1);
        }

        [TestMethod]
        public void TestTooManyComponentDataElements()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.Edifact.Edi.Edifact_INVOIC_D00A_InvalidSegment2.txt";
            var ediStream = CommonHelper.LoadStream(sample);
            List<EdiItem> ediItems;

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
            var error = ediItems.OfType<TSINVOIC>().SingleOrDefault();
            Assert.IsNotNull(error);
            Assert.IsTrue(error.HasErrors);
            Assert.IsTrue(error.ErrorContext.Errors.Any(e => e.Errors.Any(d => d.Code == DataElementErrorCode.TooManyComponents)));

            MessageErrorContext mec;
            Assert.IsFalse(error.IsValid(out mec));
            Assert.IsTrue(mec.Errors.Any(e => e.Errors.Any(d => d.Code == DataElementErrorCode.TooManyComponents)));
            Assert.IsTrue(mec.Errors.Count > 1);
        }

        [TestMethod]
        public void TestGroupRead()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.Edifact.Edi.Edifact_INVOIC_D00A_MultipleGroups.txt";
            var ediStream = CommonHelper.LoadStream(sample);
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
                    Assert.IsNull(ediItems.OfType<ErrorContext>().SingleOrDefault());
                    ediItems.Clear();
                }
            }
        }

        [TestMethod]
        public void TestInterchangeRead()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.Edifact.Edi.Edifact_INVOIC_D00A_MultipleInterchange.txt";
            var ediStream = CommonHelper.LoadStream(sample);
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
                    Assert.IsNull(ediItems.OfType<ErrorContext>().SingleOrDefault());
                    ediItems.Clear();
                }
            }
        }

        [TestMethod]
        public void TestMissingGroupTrailer()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.Edifact.Edi.Edifact_INVOIC_D00A_MissingGroupTrailer.txt";
            var ediStream = CommonHelper.LoadStream(sample);
            List<EdiItem> ediItems;

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
            Assert.IsNull(ediItems.OfType<ErrorContext>().SingleOrDefault());
        }

        [TestMethod]
        public void TestMissingInterchangeTrailer()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.Edifact.Edi.Edifact_INVOIC_D00A_MissingInterchangeTrailer.txt";
            var ediStream = CommonHelper.LoadStream(sample);
            List<EdiItem> ediItems;

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
            Assert.IsNull(ediItems.OfType<ErrorContext>().SingleOrDefault());
        }

        [TestMethod]
        public void TestValidAndInvalidMessageRead()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.Edifact.Edi.Edifact_INVOIC_D00A_ValidAndInvalidMessage.txt";
            var ediStream = CommonHelper.LoadStream(sample);
            List<EdiItem> ediItems;

            // ACT
            using (var ediReader = new EdifactReader(ediStream, "EdiFabric.Rules.EdifactD00A"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }

            // ASSERT
            Assert.IsNotNull(ediItems.OfType<UNB>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<UNG>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<TSINVOIC>().SingleOrDefault(m => m.HasErrors));
            Assert.IsNotNull(ediItems.OfType<TSINVOIC>().SingleOrDefault(m => !m.HasErrors));
            Assert.IsNull(ediItems.OfType<UNE>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<UNZ>().SingleOrDefault());
            var error = ediItems.OfType<TSINVOIC>().SingleOrDefault(m => m.HasErrors);
            Assert.IsNotNull(error);
            Assert.IsNotNull(error.ErrorContext.Errors.Any(e => e.Codes.Contains(SegmentErrorCode.UnrecognizedSegment)));
        }

        [TestMethod]
        public void TestBlankRepetition()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.Edifact.Edi.Edifact_INVOIC_D00A_BlankRepetition.txt";
            const string sampleClean = "EdiFabric.UnitTests.Edifact.Edi.Edifact_INVOIC_D00A.txt";
            var ediStream = CommonHelper.LoadStream(sample);
            var expected = CommonHelper.LoadString(sampleClean);
            List<EdiItem> ediItems;

            // ACT
            using (var ediReader = new EdifactReader(ediStream, "EdiFabric.Rules.EdifactD00A"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }
            var actual = EdifactHelper.Generate(ediItems, null, Environment.NewLine);

            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsNotNull(ediItems.OfType<UNB>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<UNG>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<TSINVOIC>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<UNE>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<UNZ>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<ErrorContext>().SingleOrDefault());
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMultipleInvalidInterchangesWithContinueOnError()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.Edifact.Edi.Edifact_INVOIC_D00A_MultipleInvalidInterchanges.txt";
            var ediStream = CommonHelper.LoadStream(sample);
            List<EdiItem> ediItems;

            // ACT
            using (var ediReader = new EdifactReader(ediStream, "EdiFabric.Rules.EdifactD00A", Encoding.Default, true))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }

            // ASSERT
            Assert.IsTrue(ediItems.OfType<UNB>().Count() == 2);
            Assert.IsNull(ediItems.OfType<UNG>().SingleOrDefault());
            Assert.IsTrue(ediItems.OfType<TSINVOIC>().Count() == 2);
            Assert.IsNull(ediItems.OfType<UNE>().SingleOrDefault());
            Assert.IsTrue(ediItems.OfType<UNZ>().Count() == 1);
            Assert.IsNotNull(ediItems.OfType<ReaderErrorContext>().SingleOrDefault());
            Assert.IsTrue(ediItems.Count == 6);
        }

        [TestMethod]
        public void TestMultipleInvalidInterchanges()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.Edifact.Edi.Edifact_INVOIC_D00A_MultipleInvalidInterchanges.txt";
            var ediStream = CommonHelper.LoadStream(sample);
            List<EdiItem> ediItems;

            // ACT
            using (var ediReader = new EdifactReader(ediStream, "EdiFabric.Rules.EdifactD00A"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }

            // ASSERT
            Assert.IsTrue(ediItems.OfType<UNB>().Count() == 1);
            Assert.IsNull(ediItems.OfType<UNG>().SingleOrDefault());
            Assert.IsTrue(ediItems.OfType<TSINVOIC>().Count() == 1);
            Assert.IsNull(ediItems.OfType<UNE>().SingleOrDefault());
            Assert.IsTrue(!ediItems.OfType<UNZ>().Any());
            Assert.IsNotNull(ediItems.OfType<ReaderErrorContext>().SingleOrDefault());
            Assert.IsTrue(ediItems.Count == 3);
        }

        [TestMethod]
        public void TestMultipleInvalidMessagesWithContinueOnError()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.Edifact.Edi.Edifact_INVOIC_D00A_MultipleInvalidMessages.txt";
            var ediStream = CommonHelper.LoadStream(sample);
            List<EdiItem> ediItems;

            // ACT
            using (var ediReader = new EdifactReader(ediStream, "EdiFabric.Rules.EdifactD00A", Encoding.Default, true))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }

            // ASSERT
            Assert.IsTrue(ediItems.OfType<UNB>().Count() == 1);
            Assert.IsNull(ediItems.OfType<UNG>().SingleOrDefault());
            Assert.IsTrue(ediItems.OfType<TSINVOIC>().Count(m => !m.HasErrors) == 3);
            Assert.IsNull(ediItems.OfType<UNE>().SingleOrDefault());
            Assert.IsTrue(ediItems.OfType<UNZ>().Count() == 1);
            Assert.IsTrue(ediItems.OfType<TSINVOIC>().Count(m => m.HasErrors) == 2);
        }

        [TestMethod]
        public void TestMultipleInvalidMessages()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.Edifact.Edi.Edifact_INVOIC_D00A_MultipleInvalidMessages.txt";
            var ediStream = CommonHelper.LoadStream(sample);
            List<EdiItem> ediItems;

            // ACT
            using (var ediReader = new EdifactReader(ediStream, "EdiFabric.Rules.EdifactD00A"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }

            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsTrue(ediItems.Count == 2);
            Assert.IsNotNull(ediItems.OfType<UNB>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<ReaderErrorContext>().SingleOrDefault());  
        }

        [TestMethod]
        public void TestValidation()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.Edifact.Edi.Edifact_INVOIC_D00A_Valid.txt";
            var ediStream = CommonHelper.LoadStream(sample);
            List<EdiItem> ediItems;

            // ACT
            using (var ediReader = new EdifactReader(ediStream, "EdiFabric.Rules.EdifactD00A"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }
            var msg = ediItems.OfType<TSINVOIC>().Single();

            MessageErrorContext result;
            var validationResult = msg.IsValid(out result);

            // ASSERT
            Assert.IsTrue(validationResult);
            Assert.IsFalse(result.Errors.Any());
        }

        [TestMethod]
        public void TestLoadingWithDelegate()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.Edifact.Edi.Edifact_INVOIC_D00A.txt";
            var ediStream = CommonHelper.LoadStream(sample);
            var expected = CommonHelper.LoadString(sample);
            List<EdiItem> ediItems;

            // ACT
            using (var ediReader = new EdifactReader(ediStream, AssemblyLoadFactory))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }
            var actual = EdifactHelper.Generate(ediItems, null, Environment.NewLine);

            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsNotNull(ediItems.OfType<UNB>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<UNG>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<TSINVOIC>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<UNE>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<UNZ>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<ErrorContext>().SingleOrDefault());           
            Assert.AreEqual(expected, actual);
        }

        private static Assembly AssemblyLoadFactory(MessageContext messageContext)
        {
            Assert.IsNotNull(messageContext.ControlNumber);
            Assert.IsNotNull(messageContext.Format);
            Assert.IsNotNull(messageContext.Name);
            Assert.IsNotNull(messageContext.ReceiverId);
            Assert.IsNotNull(messageContext.ReceiverQualifier);
            Assert.IsNotNull(messageContext.SenderId);
            Assert.IsNotNull(messageContext.SenderQualifier);
            Assert.IsNotNull(messageContext.Version);

            return Assembly.Load("EdiFabric.Rules.EdifactD00A");
        }

        [TestMethod]
        public void TestPreserveWhiteSpace()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.Edifact.Edi.Edifact_INVOIC_D00A_Write.txt";
            var expected = CommonHelper.LoadString(sample);
            string actual;
            
            // ACT
            using (var stream = new MemoryStream())
            {
                var writer = new EdifactWriter(stream, Encoding.Default, Environment.NewLine, true);

                writer.Write(EdifactHelper.CreateUnb());
                writer.Write(EdifactHelper.CreateInvoice());                
                writer.Flush();

                actual = CommonHelper.LoadString(stream);
            }

            // ASSERT
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestNoPreserveWhiteSpace()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.Edifact.Edi.Edifact_INVOIC_D00A_WriteNoPreserveWhitespace.txt";
            var expected = CommonHelper.LoadString(sample);
            string actual;

            // ACT
            using (var stream = new MemoryStream())
            {
                var writer = new EdifactWriter(stream, Encoding.Default, Environment.NewLine);

                writer.Write(EdifactHelper.CreateUnb());
                writer.Write(EdifactHelper.CreateInvoice());
                writer.Flush();

                actual = CommonHelper.LoadString(stream);
            }

            // ASSERT
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestEval()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.Edifact.Edi.Edifact_INVOIC_D00A.txt";
            const string sampleEval = "EdiFabric.UnitTests.Edifact.Edi.Edifact_INVOIC_D00A_Eval.txt";
            var ediStream = CommonHelper.LoadStream(sample);
            var expected = CommonHelper.LoadString(sampleEval);
            List<EdiItem> ediItems;

            // ACT
            using (var ediReader = new EdifactReader(ediStream, "EdiFabric.Rules.EdifactD00A.Eval"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }
            var actual = EdifactHelper.Generate(ediItems, null, Environment.NewLine);

            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsNotNull(ediItems.OfType<UNB>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<UNG>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<TSINVOICEval>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<UNE>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<UNZ>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<ErrorContext>().SingleOrDefault());
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestNoValidationAttributes()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.Edifact.Edi.Edifact_INVOIC_D00A.txt";
            var ediStream = CommonHelper.LoadStream(sample);
            var expected = CommonHelper.LoadString(sample);
            List<EdiItem> ediItems;

            // ACT
            using (var ediReader = new EdifactReader(ediStream, "EdiFabric.Rules.EdifactD00A.NoValidation"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }
            var actual = EdifactHelper.Generate(ediItems, null, Environment.NewLine);

            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsNotNull(ediItems.OfType<UNB>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<UNG>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<TSINVOICNoValidation>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<UNE>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<UNZ>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<ErrorContext>().SingleOrDefault());
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestPostfixCr()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.Edifact.Edi.Edifact_INVOIC_D00A_CR.txt";
            var ediStream = CommonHelper.LoadStream(sample);
            var expected = CommonHelper.LoadString(sample);
            List<EdiItem> ediItems;

            // ACT
            using (var ediReader = new EdifactReader(ediStream, "EdiFabric.Rules.EdifactD00A"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }
            var actual = EdifactHelper.Generate(ediItems, null, "\r");

            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsNotNull(ediItems.OfType<UNB>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<UNG>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<TSINVOIC>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<UNE>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<UNZ>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<ErrorContext>().SingleOrDefault());
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestSplitMessage()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.Edifact.Edi.Edifact_INVOIC_D00A_Split.txt";
            var ediStream = CommonHelper.LoadStream(sample);
            List<EdiItem> ediItems;

            // ACT
            using (var ediReader = new EdifactReader(ediStream, "EdiFabric.Rules.EdifactD00A.Rep"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }

            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsNotNull(ediItems.OfType<UNB>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<UNG>().SingleOrDefault());
            var messages = ediItems.OfType<Rules.EDIFACT_D00A.Rep.TSINVOICSplit>().ToList();
            Assert.IsTrue(messages.Count(m => !m.HasErrors) == 3);

            foreach (var msg in messages)
            {
                Assert.IsTrue(msg.MessagePart > 0);
                Assert.IsTrue(!string.IsNullOrEmpty(msg.ControlNumber));
                Assert.IsTrue(!string.IsNullOrEmpty(msg.Name));
                Assert.IsTrue(!string.IsNullOrEmpty(msg.Format));
                Assert.IsTrue(!string.IsNullOrEmpty(msg.Version));

                MessageErrorContext mec;
                if (!msg.IsValid(out mec))
                {
                    Assert.IsTrue(mec.MessagePart > 0);
                    Assert.IsTrue(!string.IsNullOrEmpty(mec.ControlNumber));
                    Assert.IsTrue(!string.IsNullOrEmpty(mec.Name));
                }
            }

            Assert.IsNull(ediItems.OfType<UNE>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<UNZ>().SingleOrDefault());
            var errors = ediItems.OfType<Rules.EDIFACT_D00A.Rep.TSINVOICSplit>().Where(m => m.HasErrors).ToList();
            Assert.IsTrue(errors.Count() == 1);

            foreach (var err in errors)
            {
                Assert.IsTrue(err.MessagePart > 0);
                Assert.IsTrue(!string.IsNullOrEmpty(err.ControlNumber));
                Assert.IsTrue(!string.IsNullOrEmpty(err.Name));
            }
        }

        [TestMethod]
        public void TestSplitWithValidation()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.Edifact.Edi.Edifact_INVOIC_D00A_Split.txt";
            var ediStream = CommonHelper.LoadStream(sample);
            List<EdiItem> ediItems;

            // ACT
            using (var ediReader = new EdifactReader(ediStream, "EdiFabric.Rules.EdifactD00A.Rep"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }

            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsNotNull(ediItems.OfType<UNB>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<UNG>().SingleOrDefault());
            var messages = ediItems.OfType<Rules.EDIFACT_D00A.Rep.TSINVOICSplit>().ToList();
            Assert.IsTrue(messages.Count(m => !m.HasErrors) == 3);
            Assert.IsTrue(messages.Count(m => m.HasErrors) == 1);
            Assert.IsNull(ediItems.OfType<UNE>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<UNZ>().SingleOrDefault());

            var linLoops = messages.Where(msg => msg.LINLoop1 != null).SelectMany(msg => msg.LINLoop1).ToList();
            Assert.IsTrue(linLoops.Count > 1);
            Assert.IsTrue(linLoops.First().Validate().ToList().Count == 1);

            foreach (var linLoop in linLoops.Skip(1))
                Assert.IsTrue(linLoop.Validate().ToList().Count == 0);
        }       
    }
}
