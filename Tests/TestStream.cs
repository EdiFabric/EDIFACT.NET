using System.Reflection;
using EdiFabric.Framework;
using EdiFabric.Framework.Headers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EdiFabric.Tests
{
    [TestClass]
    public class TestStream
    {
        //[TestMethod]
        //public void TestX12Stream()
        //{
        //    // ARRANGE
        //    const string sample = "EdiFabric.Tests.Edi.X12_810_00204_MultipleGroupsBrokenLine.txt";
        //    var i = 0;

        //    // ACT
        //    EdiReader es = EdiReader.Create(Assembly.GetExecutingAssembly().GetManifestResourceStream(sample), null);
        //    while (es.ReadMessage())
        //    {
        //        var message = es.Message.Value;
        //        var header = es.Message.InterchangeHeader;
        //        var group = es.Message.GroupHeader;
        //        i++;

        //        // ASSERT
        //        Assert.IsNotNull(message);
        //        Assert.IsNotNull(header);
        //        Assert.IsInstanceOfType(header, typeof(S_ISA));
        //        Assert.IsNotNull(group);
        //        Assert.IsInstanceOfType(group, typeof(S_GS));
        //    }

        //    Assert.AreEqual(2, i);
        //}

        //[TestMethod]
        //public void TestEdifactStream()
        //{
        //    // ARRANGE
        //    const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A_MultipleGroups.txt";
        //    var i = 0;

        //    // ACT
        //    EdiReader es = EdiReader.Create(Assembly.GetExecutingAssembly().GetManifestResourceStream(sample), null);
        //    while (es.ReadMessage())
        //    {
        //        var message = es.Message.Value;
        //        var header = es.Message.InterchangeHeader;
        //        var group = es.Message.GroupHeader;
        //        i++;

        //        // ASSERT
        //        Assert.IsNotNull(message);
        //        Assert.IsNotNull(header);
        //        Assert.IsInstanceOfType(header, typeof(S_UNB));
        //        Assert.IsNotNull(group);
        //        Assert.IsInstanceOfType(group, typeof(S_UNG));
        //    }

        //    Assert.AreEqual(2, i);
        //}
    }
}
