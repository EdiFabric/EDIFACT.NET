using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using EdiFabric.Framework;
using EdiFabric.Framework.Readers;
using EdiFabric.Framework.Segments.X12;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EdiFabric.UnitTests.Hipaa
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void Test4010()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.Hipaa.Edi.Hipaa_837P_00401.txt";
            var ediStream = Helper.LoadStream(sample);
            var expected = Helper.LoadString(sample);
            List<object> ediItems;

            // ACT
            using (var ediReader = new X12Reader(ediStream, HipaaFactory))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }
            var actual = Helper.GenerateX12(ediItems, null, Environment.NewLine);

            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsNotNull(ediItems.OfType<ISA>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<GS>().SingleOrDefault());
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test5010()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.Hipaa.Edi.Hipaa_837P_00501.txt";
            var ediStream = Helper.LoadStream(sample);
            var expected = Helper.LoadString(sample);
            List<object> ediItems;

            // ACT
            using (var ediReader = new X12Reader(ediStream, HipaaFactory))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }
            var actual = Helper.GenerateX12(ediItems, null, Environment.NewLine);

            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsNotNull(ediItems.OfType<ISA>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<GS>().SingleOrDefault());
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test5010Hl()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.Hipaa.Edi.Hipaa_837P_00501_HL.txt";
            var ediStream = Helper.LoadStream(sample);
            var expected = Helper.LoadString(sample);
            List<object> ediItems;

            // ACT
            using (var ediReader = new X12Reader(ediStream, HipaaFactory))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }
            var actual = Helper.GenerateX12(ediItems, null, Environment.NewLine);

            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsNotNull(ediItems.OfType<ISA>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<GS>().SingleOrDefault());
            Assert.AreEqual(expected, actual);
        }

    //    [TestMethod]
    //    public void TestValidationRules()
    //    {
    //        // ARRANGE
    //        const string sample = "EdiFabric.Tests.Xml.Hipaa_837P_00501_Validation.xml";
    //        var obj = TestHelper.Deserialize<Rules.X12005010X222A1837.M_837>(TestHelper.LoadStream(sample));
    //        const string expectedResult = "EdiFabric.Tests.Xml.Hipaa_837P_00501_ValidationExpected.xml";
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
        public void Test5010Lfnm1Lisa()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.Hipaa.Edi.Hipaa_837P_00501_LF.txt";
            var ediStream = Helper.LoadStream(sample);
            var expected = Helper.LoadString(sample);
            List<object> ediItems;
            Separators separators;

            // ACT
            using (var ediReader = new X12Reader(ediStream, HipaaFactory))
            {
                ediItems = ediReader.ReadToEnd().ToList();
                separators = ediReader.Separators;
            }
            var actual = Helper.GenerateX12(ediItems, separators, "");

            // ASSERT
            Assert.IsNotNull(ediItems);
            Assert.IsNotNull(ediItems.OfType<ISA>().SingleOrDefault());
            Assert.IsNotNull(ediItems.OfType<GS>().SingleOrDefault());
            Assert.AreEqual(expected, actual);
        }


        private Assembly HipaaFactory(MessageContext mc)
        {
            if (mc.Version == "005010X222A1")
                return Assembly.Load("EdiFabric.Rules.Hipaa005010");
            if (mc.Version == "004010X098A1")
                return Assembly.Load("EdiFabric.Rules.Hipaa004010");

            throw new Exception("Not supported!");
        }
    }
}
