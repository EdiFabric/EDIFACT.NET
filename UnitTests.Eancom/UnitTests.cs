using System;
using System.Collections.Generic;
using System.Linq;
using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.Edifact;
using EdiFabric.Core.Model.Edi.ErrorContexts;
using EdiFabric.Framework.Readers;
using EdiFabric.Rules.EANCOM_D01BEAN3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EdiFabric.UnitTests.Eancom
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestSingleMessage()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.Eancom.Edi.Eancom_INVOIC_D01BEAN3.txt";
            var ediStream = CommonHelper.LoadStream(sample);
            var expected = CommonHelper.LoadString(sample);
            List<EdiItem> ediItems;

            // ACT
            using (var ediReader = new EdifactReader(ediStream, "EdiFabric.Rules.EancomD01BEAN3"))
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
    }
}
