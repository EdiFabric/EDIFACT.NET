using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.ErrorContexts;
using EdiFabric.Framework;
using EdiFabric.Framework.Readers;
using EdiFabric.Rules.Vda;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EdiFabric.UnitTests.Vda
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestSingleMessage()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.Vda.Edi.Vda_4905_02.txt";
            var ediStream = CommonHelper.LoadStream(sample);
            var expected = CommonHelper.LoadString(sample);
            List<EdiItem> ediItems;

            // ACT
            using (var ediReader = new VdaReader(ediStream, MessageContextFactory, Encoding.UTF8, Environment.NewLine))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }
            var actual = VdaHelper.Generate(ediItems, Environment.NewLine);

            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsNotNull(ediItems.OfType<TS4905>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<ErrorContext>().SingleOrDefault());
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMultipleMessages()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.Vda.Edi.Vda_4905_02_MultipleMessages.txt";
            var ediStream = CommonHelper.LoadStream(sample);
            var expected = CommonHelper.LoadString(sample);
            List<EdiItem> ediItems;

            // ACT
            using (var ediReader = new VdaReader(ediStream, MessageContextFactory, Encoding.UTF8, Environment.NewLine))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }
            var actual = VdaHelper.Generate(ediItems, Environment.NewLine);

            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsTrue(ediItems.OfType<TS4905>().Count() == 2);
            Assert.IsNull(ediItems.OfType<ErrorContext>().SingleOrDefault());
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMultipleInvalidMessages()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.Vda.Edi.Vda_4905_02_MultipleInvalidMessages.txt";
            var ediStream = CommonHelper.LoadStream(sample);
            List<EdiItem> ediItems;

            // ACT
            using (var ediReader = new VdaReader(ediStream, MessageContextFactory, Encoding.UTF8, Environment.NewLine))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }
            
            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsTrue(ediItems.OfType<TS4905>().Count() == 2);
            Assert.IsNotNull(ediItems.OfType<TS4905>().FirstOrDefault());
            Assert.IsTrue(ediItems.OfType<TS4905>().First().HasErrors);
            Assert.IsNull(ediItems.OfType<ErrorContext>().SingleOrDefault());
        }

        [TestMethod]
        public void TestShortSegment()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.Vda.Edi.Vda_4905_02_ShortSegment.txt";
            var ediStream = CommonHelper.LoadStream(sample);
            List<EdiItem> ediItems;

            // ACT
            using (var ediReader = new VdaReader(ediStream, MessageContextFactory, Encoding.UTF8, Environment.NewLine))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }
            
            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsTrue(!ediItems.OfType<TS4905>().Any());
            Assert.IsNotNull(ediItems.OfType<ReaderErrorContext>().SingleOrDefault());
         }

        [TestMethod]
        public void TestMultipleInvalidMessagesWithShortSegment()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.Vda.Edi.Vda_4905_02_MultipleInvalidMessagesWithShortSegment.txt";
            var ediStream = CommonHelper.LoadStream(sample);
            List<EdiItem> ediItems;

            // ACT
            using (var ediReader = new VdaReader(ediStream, MessageContextFactory, Encoding.UTF8, Environment.NewLine))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }

            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsTrue(ediItems.OfType<TS4905>().Count() == 1);
            Assert.IsNotNull(ediItems.OfType<TS4905>().FirstOrDefault());
            Assert.IsFalse(ediItems.OfType<TS4905>().First().HasErrors);
            Assert.IsNotNull(ediItems.OfType<ReaderErrorContext>().SingleOrDefault());
        }

        [TestMethod]
        public void TestWithBom()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.Vda.Edi.Vda_4905_02_BOM.txt";
            var ediStream = CommonHelper.LoadStream(sample);
            var expected = CommonHelper.LoadString(sample);
            List<EdiItem> ediItems;

            // ACT
            using (var ediReader = new VdaReader(ediStream, MessageContextFactory, Encoding.UTF8, Environment.NewLine))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }
            var actual = VdaHelper.Generate(ediItems, Environment.NewLine);

            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsTrue(ediItems.OfType<TS4905>().Count() == 1);
            Assert.IsNull(ediItems.OfType<ErrorContext>().SingleOrDefault());
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestNoPostfix()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.Vda.Edi.Vda_4905_02_NoPostfix.txt";
            var ediStream = CommonHelper.LoadStream(sample);
            var expected = CommonHelper.LoadString(sample);
            List<EdiItem> ediItems;

            // ACT
            using (var ediReader = new VdaReader(ediStream, MessageContextFactory))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }
            var actual = VdaHelper.Generate(ediItems);

            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsTrue(ediItems.OfType<TS4905>().Count() == 1);
            Assert.IsNull(ediItems.OfType<ErrorContext>().SingleOrDefault());
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestTrailing()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.Vda.Edi.Vda_4905_02_Trailing.txt";
            var ediStream = CommonHelper.LoadStream(sample);
            var expected = CommonHelper.LoadString(sample);
            List<EdiItem> ediItems;

            // ACT
            using (var ediReader = new VdaReader(ediStream, MessageContextFactory, Encoding.UTF8, Environment.NewLine))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }
            var actual = VdaHelper.Generate(ediItems, Environment.NewLine) + "trailer";

            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsTrue(ediItems.OfType<TS4905>().Count() == 1);
            Assert.IsNull(ediItems.OfType<ErrorContext>().SingleOrDefault());
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestWithUnexpectedPostfix()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.Vda.Edi.Vda_4905_02.txt";
            var ediStream = CommonHelper.LoadStream(sample);
            List<EdiItem> ediItems;

            // ACT
            using (var ediReader = new VdaReader(ediStream, MessageContextFactory))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }
            
            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsNotNull(ediItems.OfType<TS4905>().SingleOrDefault());
            Assert.IsTrue(ediItems.OfType<TS4905>().Single().HasErrors);
            Assert.IsNull(ediItems.OfType<ErrorContext>().SingleOrDefault());
        }

        private MessageContext MessageContextFactory(string segment)
        {
            var id = segment.Substring(0, 5);
            switch (id)
            {
                case "51102":
                    return From4905(segment);
            }

            return null;
        }

        private MessageContext From4905(string segment)
        {
            var newControlNumber = segment.Substring(29, 5);
            var sender = segment.Substring(15, 9);
            var receiver = segment.Substring(6, 9);

            return new MessageContext("4905", newControlNumber, "1", "VDA", sender, "", receiver, "",
                mc => Assembly.Load(new AssemblyName("EdiFabric.Rules.Vda")));
        }
    }
}
