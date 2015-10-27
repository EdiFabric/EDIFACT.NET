using System.Reflection;
using EdiFabric.Framework;
using EdiFabric.Framework.Envelopes.Edifact;
using EdiFabric.Framework.Envelopes.X12;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EdiFabric.Tests
{
    [TestClass]
    public class TestStream
    {
        [TestMethod]
        public void TestX12Stream()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.X12_810_00204_MultipleGroups.txt";
            var i = 0;

            // ACT
            EdiStream es = new EdiStream(Assembly.GetExecutingAssembly().GetManifestResourceStream(sample));
            while (es.GetNextMessage())
            {
                var message = es.Message;
                var header = es.InterchangeHeader;
                var group = es.InterchangeGroup;
                i++;

                // ASSERT
                Assert.IsNotNull(message);
                Assert.IsNotNull(header);
                Assert.IsInstanceOfType(header, typeof(S_ISA));
                Assert.IsNotNull(group);
                Assert.IsInstanceOfType(group, typeof(S_GS));
            }

            Assert.AreEqual(2, i);
        }

        [TestMethod]
        public void TestEdifactStream()
        {
            // ARRANGE
            const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_MultipleGroups.txt";
            var i = 0;

            // ACT
            EdiStream es = new EdiStream(Assembly.GetExecutingAssembly().GetManifestResourceStream(sample));
            while (es.GetNextMessage())
            {
                var message = es.Message;
                var header = es.InterchangeHeader;
                var group = es.InterchangeGroup;
                i++;

                // ASSERT
                Assert.IsNotNull(message);
                Assert.IsNotNull(header);
                Assert.IsInstanceOfType(header, typeof(S_UNB));
                Assert.IsNotNull(group);
                Assert.IsInstanceOfType(group, typeof(S_UNG));
            }

            Assert.AreEqual(2, i);
        }
    }
}
