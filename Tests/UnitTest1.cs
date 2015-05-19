using System;
using System.Reflection;
using EdiFabric.Framework.Envelopes;
using EdiFabric.Framework.Envelopes.Edifact;
using EdiFabric.Framework.Messages;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EdiFabric.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //const string sample = "EdiFabric.Tests.Edi.Edifact_INVOIC_D00A.txt";
            //EdifactStream es = new EdifactStream(Assembly.GetExecutingAssembly().GetManifestResourceStream(sample));

            const string sample = "EdiFabric.Tests.Edi.X12_810_00204_MultipleMessages.txt";
            EdiStream es = new EdiStream(Assembly.GetExecutingAssembly().GetManifestResourceStream(sample));
            //Message msg = null;
            //while((var msg = es.GetNextMessage()) != null)
            var b = es.GetNextMessage();
            var b1 = es.GetNextMessage();
        }
    }
}
