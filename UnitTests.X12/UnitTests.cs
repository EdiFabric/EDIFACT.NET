using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using EdiFabric.Core.Model;
using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.Exceptions;
using EdiFabric.Core.Model.Edi.X12;
using EdiFabric.Framework;
using EdiFabric.Framework.Exceptions;
using EdiFabric.Framework.Readers;
using EdiFabric.Framework.Writers;
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
            var ediStream = CommonHelper.LoadStream(sample);
            var expected = CommonHelper.LoadString(sample);
            List<object> ediItems;

            // ACT
            using (var ediReader = new X12Reader(ediStream, "EdiFabric.Rules.X12002040"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }
            var actual = X12Helper.Generate(ediItems, null, Environment.NewLine);

            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsNotNull(ediItems.OfType<ISA>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<GS>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<TS810>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<GE>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<IEA>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<ReaderException>().SingleOrDefault());
            File.WriteAllText(@"C:\Test\Expected.txt", expected);
            File.WriteAllText(@"C:\Test\Actual.txt", actual);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestRepetitionSeparator()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.X12.Edi.X12_810_00204_RepetitionSeparator.txt";
            var ediStream = CommonHelper.LoadStream(sample);
            var expected = CommonHelper.LoadString(sample);
            List<object> ediItems;
            Separators separators;

            // ACT
            using (var ediReader = new X12Reader(ediStream, "EdiFabric.Rules.X12002040.Rep"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
                separators = ediReader.Separators;
            }
            var actual = X12Helper.Generate(ediItems, separators, Environment.NewLine);

            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsNotNull(ediItems.OfType<ISA>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<GS>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<Rules.X12_002040.Rep.TS810>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<GE>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<IEA>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<ReaderException>().SingleOrDefault());
            File.WriteAllText(@"C:\Test\Expected.txt", expected);
            File.WriteAllText(@"C:\Test\Actual.txt", actual);
            Assert.AreEqual(expected, actual);
            
        }

        [TestMethod]
        public void TestDuplicateSeparator()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.X12.Edi.X12_810_00204_RepetitionSeparator.txt";
            var ediStream = CommonHelper.LoadStream(sample);
            var expected = CommonHelper.LoadString(sample);
            List<object> ediItems;
            Separators separators;

            // ACT
            using (var ediReader = new X12Reader(ediStream, "EdiFabric.Rules.X12002040.Rep"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
                separators = ediReader.Separators;
            }
            var actual = X12Helper.Generate(ediItems, separators, Environment.NewLine);

            // ASSERT
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestSegmentSeparatorLf()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.X12.Edi.X12_810_00204_SegmentSeparatorLF.txt";
            var ediStream = CommonHelper.LoadStream(sample);
            var expected = CommonHelper.LoadString(sample);
            List<object> ediItems;
            Separators separators;

            // ACT
            using (var ediReader = new X12Reader(ediStream, "EdiFabric.Rules.X12002040"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
                separators = ediReader.Separators;
            }
            var actual = X12Helper.Generate(ediItems, separators, "");

            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsNotNull(ediItems.OfType<ISA>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<GS>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<TS810>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<GE>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<IEA>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<ReaderException>().SingleOrDefault());
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestPostfixLf()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.X12.Edi.X12_810_00204_LF.txt";
            var ediStream = CommonHelper.LoadStream(sample);
            var expected = CommonHelper.LoadString(sample);
            List<object> ediItems;
            Separators separators;

            // ACT
            using (var ediReader = new X12Reader(ediStream, "EdiFabric.Rules.X12002040"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
                separators = ediReader.Separators;
            }
            var actual = X12Helper.Generate(ediItems, separators, "\n");

            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsNotNull(ediItems.OfType<ISA>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<GS>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<TS810>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<GE>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<IEA>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<ReaderException>().SingleOrDefault());
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestError()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.X12.Edi.X12_810_00204_BadSegment.txt";
            var ediStream = CommonHelper.LoadStream(sample);
            List<object> ediItems;

            // ACT
            using (var ediReader = new X12Reader(ediStream, "EdiFabric.Rules.X12002040"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }
            
            // ASSERT
            Assert.IsNotNull(ediItems.OfType<ISA>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<GS>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<ReaderException>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<GE>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<IEA>().SingleOrDefault());
        }

        [TestMethod]
        public void TestMultipleGroups()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.X12.Edi.X12_810_00204_MultipleGroups.txt";
            var ediStream = CommonHelper.LoadStream(sample);
            var expected = CommonHelper.LoadString(sample);
            List<object> ediItems;

            // ACT
            using (var ediReader = new X12Reader(ediStream, "EdiFabric.Rules.X12002040"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }
            var actual = X12Helper.Generate(ediItems, null, Environment.NewLine);

            // ASSERT
            Assert.IsTrue(ediItems.OfType<TS810>().Count() == 2);
            Assert.IsTrue(ediItems.OfType<ISA>().Count() == 1);
            Assert.IsTrue(ediItems.OfType<GS>().Count() == 2);
            Assert.IsTrue(ediItems.OfType<GE>().Count() == 2);
            Assert.IsTrue(ediItems.OfType<IEA>().Count() == 1);
            Assert.IsNull(ediItems.OfType<ReaderException>().SingleOrDefault());
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMultipleMessages()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.X12.Edi.X12_810_00204_MultipleMessages.txt";
            var ediStream = CommonHelper.LoadStream(sample);
            var expected = CommonHelper.LoadString(sample);
            List<object> ediItems;

            // ACT
            using (var ediReader = new X12Reader(ediStream, "EdiFabric.Rules.X12002040"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }
            var actual = X12Helper.Generate(ediItems, null, Environment.NewLine);

            // ASSERT
            Assert.IsTrue(ediItems.OfType<TS810>().Count() == 2);
            Assert.IsTrue(ediItems.OfType<ISA>().Count() == 1);
            Assert.IsTrue(ediItems.OfType<GS>().Count() == 1);
            Assert.IsTrue(ediItems.OfType<GE>().Count() == 1);
            Assert.IsTrue(ediItems.OfType<IEA>().Count() == 1);
            Assert.IsNull(ediItems.OfType<ReaderException>().SingleOrDefault());
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestBom()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.X12.Edi.X12_810_00204_BOM.txt";
            var ediStream = CommonHelper.LoadStream(sample);
            var expected = CommonHelper.LoadString(sample);
            List<object> ediItems;

            // ACT
            using (var ediReader = new X12Reader(ediStream, "EdiFabric.Rules.X12002040"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }
            var actual = X12Helper.Generate(ediItems, null, Environment.NewLine);

            // ASSERT
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestTrailingBlanks()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.X12.Edi.X12_810_00204_TrailingBlanks.txt";
            const string cleanSample = "EdiFabric.UnitTests.X12.Edi.X12_810_00204.txt";
            var ediStream = CommonHelper.LoadStream(sample);
            var expected = CommonHelper.LoadString(cleanSample);
            List<object> ediItems;

            // ACT
            using (var ediReader = new X12Reader(ediStream, "EdiFabric.Rules.X12002040"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }
            var actual = X12Helper.Generate(ediItems, null, Environment.NewLine);

            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsNotNull(ediItems.OfType<ISA>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<GS>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<TS810>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<GE>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<IEA>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<ReaderException>().SingleOrDefault());
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMultipleInterchange()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.X12.Edi.X12_810_00204_MultipleInterchanges.txt";
            var ediStream = CommonHelper.LoadStream(sample);
            var expected = CommonHelper.LoadString(sample);
            var ediItems = new List<object>();

            // ACT
            var actual = "";
            using (var ediReader = new X12Reader(ediStream, "EdiFabric.Rules.X12002040"))
            {
                while (ediReader.Read())
                {
                    if (ediReader.Item is ISA && ediItems.Any())
                    {
                        actual = actual + X12Helper.Generate(ediItems, null, Environment.NewLine);
                        ediItems.Clear();
                    }

                    ediItems.Add(ediReader.Item);
                }

                actual = actual + X12Helper.Generate(ediItems, ediReader.Separators, Environment.NewLine);
            }

            // ASSERT
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestInvalidTrailers()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.X12.Edi.X12_810_00204_InvalidTrailers.txt";
            var ediStream = CommonHelper.LoadStream(sample);
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
            var error = ediItems.OfType<ReaderException>().SingleOrDefault();
            Assert.IsNotNull(error);
            Assert.IsNotNull(error.ErrorCode == ReaderErrorCode.ImproperEndOfFile);
        }

        [TestMethod]
        public void TestInvalidHeader()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.X12.Edi.X12_810_00204_InvalidHeader.txt";
            var ediStream = CommonHelper.LoadStream(sample);
            List<object> ediItems;

            // ACT
            using (var ediReader = new X12Reader(ediStream, "EdiFabric.Rules.X12002040"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }
            
            // ASSERT
            var error = ediItems.OfType<ReaderException>().SingleOrDefault();
            Assert.IsNotNull(error);
            Assert.IsNotNull(error.ErrorCode == ReaderErrorCode.InvalidControlStructure);
        }

        [TestMethod]
        public void TestTooManyDataElements()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.X12.Edi.X12_810_00204_InvalidSegment.txt";
            var ediStream = CommonHelper.LoadStream(sample);
            List<object> ediItems;

            // ACT
            using (var ediReader = new X12Reader(ediStream, "EdiFabric.Rules.X12002040"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }

            // ASSERT
            Assert.IsNotNull(ediItems.OfType<ISA>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<GS>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<TS810>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<GE>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<IEA>().SingleOrDefault());
            var error = ediItems.OfType<ReaderException>().SingleOrDefault();
            Assert.IsNotNull(error);
            //Assert.IsNotNull(error.ErrorCode == ErrorCode.DataElementsTooMany);
        }

        [TestMethod]
        public void TestTooManyComponentDataElements()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.X12.Edi.X12_810_00204_InvalidSegment2.txt";
            var ediStream = CommonHelper.LoadStream(sample);
            List<object> ediItems;

            // ACT
            using (var ediReader = new X12Reader(ediStream, "EdiFabric.Rules.X12002040.Rep"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }

            // ASSERT
            Assert.IsNotNull(ediItems.OfType<ISA>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<GS>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<TS810>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<GE>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<IEA>().SingleOrDefault());
            var error = ediItems.OfType<ReaderException>().SingleOrDefault();
            Assert.IsNotNull(error);
            //Assert.IsNotNull(error.ErrorCode == ErrorCode.ComponentDataElementsTooMany);
        }

        [TestMethod]
        public void TestGroupRead()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.X12.Edi.X12_810_00204_MultipleGroups.txt";
            var ediStream = CommonHelper.LoadStream(sample);
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
                    Assert.IsNull(ediItems.OfType<ReaderException>().SingleOrDefault());
                    ediItems.Clear();
                }
            }
        }

        [TestMethod]
        public void TestInterchangeRead()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.X12.Edi.X12_810_00204_MultipleInterchanges.txt";
            var ediStream = CommonHelper.LoadStream(sample);
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
                    Assert.IsNull(ediItems.OfType<ReaderException>().SingleOrDefault());
                    ediItems.Clear();
                }
            }
        }

        [TestMethod]
        public void TestMissingGroupTrailer()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.X12.Edi.X12_810_00204_MissingGroupTrailer.txt";
            var ediStream = CommonHelper.LoadStream(sample);
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
            Assert.IsNull(ediItems.OfType<ReaderException>().SingleOrDefault());
        }

        [TestMethod]
        public void TestMissingInterchangeTrailer()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.X12.Edi.X12_810_00204_MissingInterchangeTrailer.txt";
            var ediStream = CommonHelper.LoadStream(sample);
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
            Assert.IsNull(ediItems.OfType<ReaderException>().SingleOrDefault());
        }

        [TestMethod]
        public void TestValidAndInvalidMessageRead()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.X12.Edi.X12_810_00204_ValidAndInvalidMessage.txt";
            var ediStream = CommonHelper.LoadStream(sample);
            List<object> ediItems;

            // ACT
            using (var ediReader = new X12Reader(ediStream, "EdiFabric.Rules.X12002040"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }

            // ASSERT
            Assert.IsNotNull(ediItems.OfType<ISA>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<GS>().SingleOrDefault());
            var error = ediItems.OfType<ErrorContextMessage>().SingleOrDefault();
            Assert.IsNotNull(error);
            //Assert.IsNotNull(error. == ErrorCode.UnrecognizedSegment);
            Assert.IsNotNull(ediItems.OfType<TS810>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<GE>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<IEA>().SingleOrDefault());
        }

        [TestMethod]
        public void TestVersionFromSt()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.X12.Edi.X12_810_00204_VersionFromSt.txt";
            var ediStream = CommonHelper.LoadStream(sample);
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
            Assert.IsNull(ediItems.OfType<ReaderException>().SingleOrDefault());
        }

        [TestMethod]
        public void TestNoRepetition()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.X12.Edi.X12_810_00204_NoRepetition.txt";
            var ediStream = CommonHelper.LoadStream(sample);
            var expected = CommonHelper.LoadString(sample);
            List<object> ediItems;

            // ACT
            using (var ediReader = new X12Reader(ediStream, "EdiFabric.Rules.X12002040"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }
            var actual = X12Helper.Generate(ediItems, null, Environment.NewLine);

            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsNotNull(ediItems.OfType<ISA>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<GS>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<TS810>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<GE>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<IEA>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<ReaderException>().SingleOrDefault());
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestBlankRepetition()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.X12.Edi.X12_810_00204_BlankRepetition.txt";
            const string cleanSample = "EdiFabric.UnitTests.X12.Edi.X12_810_00204_BlankRepetitionClean.txt";
            var ediStream = CommonHelper.LoadStream(sample);
            var expected = CommonHelper.LoadString(cleanSample);
            List<object> ediItems;
            Separators separators;

            // ACT
            using (var ediReader = new X12Reader(ediStream, "EdiFabric.Rules.X12002040"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
                separators = ediReader.Separators;
            }
            var actual = X12Helper.Generate(ediItems, separators, Environment.NewLine);


            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsNotNull(ediItems.OfType<ISA>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<GS>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<TS810>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<GE>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<IEA>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<ReaderException>().SingleOrDefault());
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMultipleInvalidInterchanges()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.X12.Edi.X12_810_00204_MultipleInvalidInterchanges.txt";
            var ediStream = CommonHelper.LoadStream(sample);
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
            Assert.IsNotNull(ediItems.OfType<ReaderException>().SingleOrDefault());
        }

        [TestMethod]
        public void TestMultipleInvalidIMessages()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.X12.Edi.X12_810_00204_MultipleInvalidMessages.txt";
            var ediStream = CommonHelper.LoadStream(sample);
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
            Assert.IsTrue(ediItems.OfType<ReaderException>().Count() == 2);
        }

        [TestMethod]
        public void TestTa1()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.X12.Edi.X12_810_00204_TA1.txt";
            var ediStream = CommonHelper.LoadStream(sample);
            var expected = CommonHelper.LoadString(sample);
            List<object> ediItems;
            Separators separators;

            // ACT
            using (var ediReader = new X12Reader(ediStream, "EdiFabric.Rules.X12002040"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
                separators = ediReader.Separators;
            }
            var actual = X12Helper.Generate(ediItems, separators, Environment.NewLine);

            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsNotNull(ediItems.OfType<ISA>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<TA1>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<GS>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<TS810>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<GE>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<IEA>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<ReaderException>().SingleOrDefault());
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestLoadingWithDelegate()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.X12.Edi.X12_810_00204.txt";
            var ediStream = CommonHelper.LoadStream(sample);
            var expected = CommonHelper.LoadString(sample);
            List<object> ediItems;

            // ACT
            using (var ediReader = new X12Reader(ediStream, AssemblyLoadFactory))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }
            var actual = X12Helper.Generate(ediItems, null, Environment.NewLine);

            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsNotNull(ediItems.OfType<ISA>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<GS>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<TS810>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<GE>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<IEA>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<ReaderException>().SingleOrDefault());
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

            return Assembly.Load("EdiFabric.Rules.X12002040");
        }

        [TestMethod]
        public void TestPreserveWhiteSpace()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.X12.Edi.X12_810_00204_Write.txt";
            var expected = CommonHelper.LoadString(sample);
            string actual;

            // ACT
            using (var stream = new MemoryStream())
            {
                var writer = new X12Writer(stream, Encoding.Default, Environment.NewLine, true);

                writer.WriteInterchange(X12Helper.CreateIsa());
                writer.WriteGroup(X12Helper.CreateGs());
                writer.WriteMessage(X12Helper.CreateInvoice());
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
            const string sample = "EdiFabric.UnitTests.X12.Edi.X12_810_00204_WriteNoPreserveWhitespace.txt";
            var expected = CommonHelper.LoadString(sample);
            string actual;

            // ACT
            using (var stream = new MemoryStream())
            {
                var writer = new X12Writer(stream, Encoding.Default, Environment.NewLine);

                writer.WriteInterchange(X12Helper.CreateIsa());
                writer.WriteGroup(X12Helper.CreateGs());
                writer.WriteMessage(X12Helper.CreateInvoice());
                writer.Flush();

                actual = CommonHelper.LoadString(stream);
            }

            // ASSERT
            Assert.AreEqual(expected, actual);
        }
    }
}

