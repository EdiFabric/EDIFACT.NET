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
            //var actual = X12Helper.Generate(ediItems, null, Environment.NewLine);

            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsNotNull(ediItems.OfType<TS4905>().SingleOrDefault());
            Assert.IsNull(ediItems.OfType<ErrorContext>().SingleOrDefault());
            //Assert.AreEqual(expected, actual);
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
