using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using EdiFabric.Framework;
using EdiFabric.Framework.Exceptions;
using EdiFabric.Framework.Readers;
using EdiFabric.Framework.Segments.X12;
using EdiFabric.Framework.Validators;
using EdiFabric.Rules.X12_002040;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EdiFabric.UnitTests.X12
{
    [TestClass]
    public class UnitTests
    {        
        [TestMethod]
        public void TestSingleMessage()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.X12.Edi.X12_810_00204.txt";
            var ediStream = Helper.LoadStream(sample);
            var expected = Helper.LoadString(sample);
            List<object> ediItems;

            // ACT
            using (var ediReader = new X12Reader(ediStream, "EdiFabric.Rules.X12002040"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }
            var actual = Helper.GenerateX12(ediItems, null, Environment.NewLine);

            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsNotNull(ediItems.OfType<ISA>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<GS>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<TS810>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<GE>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<IEA>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<ParsingException>().SingleOrDefault());
            File.WriteAllText(@"C:\Test\Expected.txt", expected);
            File.WriteAllText(@"C:\Test\Actual.txt", actual);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestParseX12WithValidationFailure()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.X12.Edi.X12_810_00204.txt";
            var ediStream = Helper.LoadStream(sample);
            var expected = Helper.LoadString(sample);
            List<object> ediItems;

            // ACT
            using (var ediReader = new X12Reader(ediStream, "EdiFabric.Rules.X12002040"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }
            var msg = ediItems.OfType<TS810>().SingleOrDefault();
            msg.Validate();

            // ASSERT
            
        }

    //    [TestMethod]
    //    public void TestParseX12WithValidation()
    //    {
    //        // ARRANGE
    //        const string sample = "EdiFabric.UnitTests.X12.Edi.X12_810_00204_Valid.txt";

    //        // ACT
    //        var message = TestHelper.ParseX12(sample).OfType<M_810>().Single();
    //        var validationResults = EdiValidator.Create("EdiFabric.Xsd").Validate(message);

    //        // ASSERT
    //        Assert.IsNotNull(validationResults);
    //        Assert.IsNotNull(validationResults.ErrorContext);
    //        Assert.IsFalse(validationResults.ErrorContext.Errors.Any());
    //        Assert.IsFalse(validationResults.ErrorContext.Codes.Any());
    //    }

        [TestMethod]
        public void TestRepetitionSeparator()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.X12.Edi.X12_810_00204_RepetitionSeparator.txt";
            var ediStream = Helper.LoadStream(sample);
            var expected = Helper.LoadString(sample);
            List<object> ediItems;
            Separators separators;

            // ACT
            using (var ediReader = new X12Reader(ediStream, "EdiFabric.Rules.X12002040.Rep"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
                separators = ediReader.Separators;
            }
            var actual = Helper.GenerateX12(ediItems, separators, Environment.NewLine);

            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsNotNull(ediItems.OfType<ISA>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<GS>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<Rules.X12_002040.Rep.TS810>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<GE>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<IEA>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<ParsingException>().SingleOrDefault());
            File.WriteAllText(@"C:\Test\Expected.txt", expected);
            File.WriteAllText(@"C:\Test\Actual.txt", actual);
            Assert.AreEqual(expected, actual);
            
        }

        [TestMethod]
        public void TestDuplicateSeparator()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.X12.Edi.X12_810_00204_RepetitionSeparator.txt";
            var ediStream = Helper.LoadStream(sample);
            var expected = Helper.LoadString(sample);
            List<object> ediItems;
            Separators separators;

            // ACT
            using (var ediReader = new X12Reader(ediStream, "EdiFabric.Rules.X12002040.Rep"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
                separators = ediReader.Separators;
            }
            var actual = Helper.GenerateX12(ediItems, separators, Environment.NewLine);

            // ASSERT
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestSegmentSeparatorLf()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.X12.Edi.X12_810_00204_SegmentSeparatorLF.txt";
            var ediStream = Helper.LoadStream(sample);
            var expected = Helper.LoadString(sample);
            List<object> ediItems;
            Separators separators;

            // ACT
            using (var ediReader = new X12Reader(ediStream, "EdiFabric.Rules.X12002040"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
                separators = ediReader.Separators;
            }
            var actual = Helper.GenerateX12(ediItems, separators, "");

            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsNotNull(ediItems.OfType<ISA>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<GS>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<TS810>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<GE>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<IEA>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<ParsingException>().SingleOrDefault());
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestPostfixLf()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.X12.Edi.X12_810_00204_LF.txt";
            var ediStream = Helper.LoadStream(sample);
            var expected = Helper.LoadString(sample);
            List<object> ediItems;
            Separators separators;

            // ACT
            using (var ediReader = new X12Reader(ediStream, "EdiFabric.Rules.X12002040"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
                separators = ediReader.Separators;
            }
            var actual = Helper.GenerateX12(ediItems, separators, "\n");

            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsNotNull(ediItems.OfType<ISA>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<GS>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<TS810>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<GE>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<IEA>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<ParsingException>().SingleOrDefault());
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestError()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.X12.Edi.X12_810_00204_BadSegment.txt";
            var ediStream = Helper.LoadStream(sample);
            List<object> ediItems;

            // ACT
            using (var ediReader = new X12Reader(ediStream, "EdiFabric.Rules.X12002040"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }
            
            // ASSERT
            Assert.IsNotNull(ediItems.OfType<ISA>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<GS>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<ParsingException>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<GE>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<IEA>().SingleOrDefault());
        }

        [TestMethod]
        public void TestMultipleGroups()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.X12.Edi.X12_810_00204_MultipleGroups.txt";
            var ediStream = Helper.LoadStream(sample);
            var expected = Helper.LoadString(sample);
            List<object> ediItems;

            // ACT
            using (var ediReader = new X12Reader(ediStream, "EdiFabric.Rules.X12002040"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }
            var actual = Helper.GenerateX12(ediItems, null, Environment.NewLine);

            // ASSERT
            Assert.IsTrue(ediItems.OfType<TS810>().Count() == 2);
            Assert.IsTrue(ediItems.OfType<ISA>().Count() == 1);
            Assert.IsTrue(ediItems.OfType<GS>().Count() == 2);
            Assert.IsTrue(ediItems.OfType<GE>().Count() == 2);
            Assert.IsTrue(ediItems.OfType<IEA>().Count() == 1);
            Assert.IsNull(ediItems.OfType<ParsingException>().SingleOrDefault());
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMultipleMessages()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.X12.Edi.X12_810_00204_MultipleMessages.txt";
            var ediStream = Helper.LoadStream(sample);
            var expected = Helper.LoadString(sample);
            List<object> ediItems;

            // ACT
            using (var ediReader = new X12Reader(ediStream, "EdiFabric.Rules.X12002040"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }
            var actual = Helper.GenerateX12(ediItems, null, Environment.NewLine);

            // ASSERT
            Assert.IsTrue(ediItems.OfType<TS810>().Count() == 2);
            Assert.IsTrue(ediItems.OfType<ISA>().Count() == 1);
            Assert.IsTrue(ediItems.OfType<GS>().Count() == 1);
            Assert.IsTrue(ediItems.OfType<GE>().Count() == 1);
            Assert.IsTrue(ediItems.OfType<IEA>().Count() == 1);
            Assert.IsNull(ediItems.OfType<ParsingException>().SingleOrDefault());
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestBom()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.X12.Edi.X12_810_00204_BOM.txt";
            var ediStream = Helper.LoadStream(sample);
            var expected = Helper.LoadString(sample);
            List<object> ediItems;

            // ACT
            using (var ediReader = new X12Reader(ediStream, "EdiFabric.Rules.X12002040"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }
            var actual = Helper.GenerateX12(ediItems, null, Environment.NewLine);

            // ASSERT
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestTrailingBlanks()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.X12.Edi.X12_810_00204_TrailingBlanks.txt";
            const string cleanSample = "EdiFabric.UnitTests.X12.Edi.X12_810_00204.txt";
            var ediStream = Helper.LoadStream(sample);
            var expected = Helper.LoadString(cleanSample);
            List<object> ediItems;

            // ACT
            using (var ediReader = new X12Reader(ediStream, "EdiFabric.Rules.X12002040"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }
            var actual = Helper.GenerateX12(ediItems, null, Environment.NewLine);

            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsNotNull(ediItems.OfType<ISA>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<GS>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<TS810>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<GE>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<IEA>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<ParsingException>().SingleOrDefault());
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMultipleInterchange()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.X12.Edi.X12_810_00204_MultipleInterchanges.txt";
            var ediStream = Helper.LoadStream(sample);
            var expected = Helper.LoadString(sample);
            var ediItems = new List<object>();

            // ACT
            var actual = "";
            using (var ediReader = new X12Reader(ediStream, "EdiFabric.Rules.X12002040"))
            {
                while (ediReader.Read())
                {
                    if (ediReader.Item is ISA && ediItems.Any())
                    {
                        actual = actual + Helper.GenerateX12(ediItems, null, Environment.NewLine);
                        ediItems.Clear();
                    }

                    ediItems.Add(ediReader.Item);
                }

                actual = actual + Helper.GenerateX12(ediItems, ediReader.Separators, Environment.NewLine);
            }

            // ASSERT
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestInvalidTrailers()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.X12.Edi.X12_810_00204_InvalidTrailers.txt";
            var ediStream = Helper.LoadStream(sample);
            List<object> ediItems;

            // ACT
            using (var ediReader = new X12Reader(ediStream, "EdiFabric.Rules.X12002040"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }
            
            // ASSERT
            Assert.IsNotNull(ediItems.OfType<ISA>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<GS>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<TS810>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<GE>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<IEA>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<ParsingException>().SingleOrDefault());
        }

        [TestMethod]
        public void TestInvalidHeader()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.X12.Edi.X12_810_00204_InvalidHeader.txt";
            var ediStream = Helper.LoadStream(sample);
            List<object> ediItems;

            // ACT
            using (var ediReader = new X12Reader(ediStream, "EdiFabric.Rules.X12002040"))
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
            const string sample = "EdiFabric.UnitTests.X12.Edi.X12_810_00204_InvalidSegment.txt";
            var ediStream = Helper.LoadStream(sample);
            List<object> ediItems;

            // ACT
            using (var ediReader = new X12Reader(ediStream, "EdiFabric.Rules.X12002040"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }

            // ASSERT
            Assert.IsNotNull(ediItems.OfType<ISA>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<GS>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<ParsingException>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<GE>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<IEA>().SingleOrDefault());
        }

        [TestMethod]
        public void TestGroupRead()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.X12.Edi.X12_810_00204_MultipleGroups.txt";
            var ediStream = Helper.LoadStream(sample);
            var ediItems = new List<object>();

            // ACT
            using (var ediReader = new X12Reader(ediStream, "EdiFabric.Rules.X12002040"))
            {
                while (ediReader.Read())
                {
                    ediItems.Add(ediReader.Item);
                    if (!(ediReader.Item is GE)) continue;

                    // ASSERT
                    Assert.IsNotNull(ediItems.OfType<GS>().SingleOrDefault());
                    Assert.IsNotNull(ediItems.OfType<TS810>().SingleOrDefault());
                    Assert.IsNotNull(ediItems.OfType<GE>().SingleOrDefault());
                    Assert.IsNull(ediItems.OfType<ParsingException>().SingleOrDefault());
                    ediItems.Clear();
                }
            }
        }

        [TestMethod]
        public void TestInterchangeRead()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.X12.Edi.X12_810_00204_MultipleInterchanges.txt";
            var ediStream = Helper.LoadStream(sample);
            var ediItems = new List<object>();

            // ACT
            using (var ediReader = new X12Reader(ediStream, "EdiFabric.Rules.X12002040"))
            {
                while (ediReader.Read())
                {
                    ediItems.Add(ediReader.Item);
                    if (!(ediReader.Item is IEA)) continue;

                    // ASSERT
                    Assert.IsNotNull(ediItems.OfType<ISA>().SingleOrDefault());
                    Assert.IsNotNull(ediItems.OfType<GS>().SingleOrDefault());
                    Assert.IsNotNull(ediItems.OfType<TS810>().SingleOrDefault());
                    Assert.IsNotNull(ediItems.OfType<GE>().SingleOrDefault());
                    Assert.IsNotNull(ediItems.OfType<IEA>().SingleOrDefault());
                    Assert.IsNull(ediItems.OfType<ParsingException>().SingleOrDefault());
                    ediItems.Clear();
                }
            }
        }

        [TestMethod]
        public void TestMissingGroupTrailer()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.X12.Edi.X12_810_00204_MissingGroupTrailer.txt";
            var ediStream = Helper.LoadStream(sample);
            List<object> ediItems;

            // ACT
            using (var ediReader = new X12Reader(ediStream, "EdiFabric.Rules.X12002040"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }

            // ASSERT
            Assert.IsNotNull(ediItems.OfType<ISA>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<GS>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<TS810>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<GE>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<IEA>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<ParsingException>().SingleOrDefault());
        }

        [TestMethod]
        public void TestMissingInterchangeTrailer()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.X12.Edi.X12_810_00204_MissingInterchangeTrailer.txt";
            var ediStream = Helper.LoadStream(sample);
            List<object> ediItems;

            // ACT
            using (var ediReader = new X12Reader(ediStream, "EdiFabric.Rules.X12002040"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }

            // ASSERT
            Assert.IsNotNull(ediItems.OfType<ISA>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<GS>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<TS810>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<GE>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<IEA>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<ParsingException>().SingleOrDefault());
        }

        [TestMethod]
        public void TestValidAndInvalidMessageRead()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.X12.Edi.X12_810_00204_ValidAndInvalidMessage.txt";
            var ediStream = Helper.LoadStream(sample);
            List<object> ediItems;

            // ACT
            using (var ediReader = new X12Reader(ediStream, "EdiFabric.Rules.X12002040"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }

            // ASSERT
            Assert.IsNotNull(ediItems.OfType<ISA>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<GS>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<ParsingException>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<TS810>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<GE>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<IEA>().SingleOrDefault());
        }

        [TestMethod]
        public void TestVersionFromSt()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.X12.Edi.X12_810_00204_VersionFromSt.txt";
            var ediStream = Helper.LoadStream(sample);
            List<object> ediItems;

            // ACT
            using (var ediReader = new X12Reader(ediStream, "EdiFabric.Rules.X12002040"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }

            // ASSERT
            Assert.IsNotNull(ediItems.OfType<ISA>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<GS>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<TS810>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<GE>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<IEA>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<ParsingException>().SingleOrDefault());
        }

        [TestMethod]
        public void TestNoRepetition()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.X12.Edi.X12_810_00204_NoRepetition.txt";
            var ediStream = Helper.LoadStream(sample);
            var expected = Helper.LoadString(sample);
            List<object> ediItems;

            // ACT
            using (var ediReader = new X12Reader(ediStream, "EdiFabric.Rules.X12002040"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }
            var actual = Helper.GenerateX12(ediItems, null, Environment.NewLine);

            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsNotNull(ediItems.OfType<ISA>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<GS>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<TS810>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<GE>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<IEA>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<ParsingException>().SingleOrDefault());
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestBlankRepetition()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.X12.Edi.X12_810_00204_BlankRepetition.txt";
            const string cleanSample = "EdiFabric.UnitTests.X12.Edi.X12_810_00204_BlankRepetitionClean.txt";
            var ediStream = Helper.LoadStream(sample);
            var expected = Helper.LoadString(cleanSample);
            List<object> ediItems;
            Separators separators;

            // ACT
            using (var ediReader = new X12Reader(ediStream, "EdiFabric.Rules.X12002040"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
                separators = ediReader.Separators;
            }
            var actual = Helper.GenerateX12(ediItems, separators, Environment.NewLine);


            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsNotNull(ediItems.OfType<ISA>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<GS>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<TS810>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<GE>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<IEA>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<ParsingException>().SingleOrDefault());
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMultipleInvalidInterchanges()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.X12.Edi.X12_810_00204_MultipleInvalidInterchanges.txt";
            var ediStream = Helper.LoadStream(sample);
            List<object> ediItems;

            // ACT
            using (var ediReader = new X12Reader(ediStream, "EdiFabric.Rules.X12002040"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }
            
            // ASSERT
            Assert.IsTrue(ediItems.OfType<TS810>().Count() == 3);
            Assert.IsTrue(ediItems.OfType<ISA>().Count() == 2);
            Assert.IsTrue(ediItems.OfType<GS>().Count() == 3);
            Assert.IsTrue(ediItems.OfType<GE>().Count() == 3);
            Assert.IsTrue(ediItems.OfType<IEA>().Count() == 2);
            Assert.IsNotNull(ediItems.OfType<ParsingException>().SingleOrDefault());
        }

        [TestMethod]
        public void TestMultipleInvalidIMessages()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.X12.Edi.X12_810_00204_MultipleInvalidMessages.txt";
            var ediStream = Helper.LoadStream(sample);
            List<object> ediItems;

            // ACT
            using (var ediReader = new X12Reader(ediStream, "EdiFabric.Rules.X12002040"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }

            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsNotNull(ediItems.OfType<ISA>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<GS>().SingleOrDefault());
            Assert.IsTrue(ediItems.OfType<TS810>().Count() == 3);
            Assert.IsNotNull(ediItems.OfType<GE>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<IEA>().SingleOrDefault());
            Assert.IsTrue(ediItems.OfType<ParsingException>().Count() == 2);
        }

        //    [TestMethod]
    //    public void TestValidationRules()
    //    {
    //        // ARRANGE
    //        const string sample = "EdiFabric.Tests.Xml.X12_810_00204_Validation.xml";
    //        var obj = TestHelper.Deserialize<Rules.Rep.X12002040810.M_810>(TestHelper.LoadStream(sample));
    //        const string expectedResult = "EdiFabric.Tests.Xml.X12_810_00204_ValidationExpected.xml";
    //        var expectedXml = XElement.Load(TestHelper.LoadStream(expectedResult));

    //        // ACT
    //        var error = EdiValidator.Create("EdiFabric.Xsd").Validate(obj);

    //        // ASSERT
    //        Assert.IsNotNull(error);
    //        var root = TestHelper.Serialize(error.Flatten().ToList()).Root;
    //        Assert.IsNotNull(root);
    //        Assert.AreEqual(root.ToString(), expectedXml.ToString());
    //    }

        [TestMethod]
        public void TestTa1()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.X12.Edi.X12_810_00204_TA1.txt";
            var ediStream = Helper.LoadStream(sample);
            var expected = Helper.LoadString(sample);
            List<object> ediItems;
            Separators separators;

            // ACT
            using (var ediReader = new X12Reader(ediStream, "EdiFabric.Rules.X12002040"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
                separators = ediReader.Separators;
            }
            var actual = Helper.GenerateX12(ediItems, separators, Environment.NewLine);

            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsNotNull(ediItems.OfType<ISA>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<TA1>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<GS>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<TS810>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<GE>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<IEA>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<ParsingException>().SingleOrDefault());
            Assert.AreEqual(expected, actual);
        }
    }
}

