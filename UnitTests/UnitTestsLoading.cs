using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using EdiFabric.Core.ErrorCodes;
using EdiFabric.Core.Model.Edi;
using EdiFabric.Core.Model.Edi.ErrorContexts;
using EdiFabric.Framework.Readers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EdiFabric.UnitTests
{
    [TestClass]
    public class UnitTestsLoading
    {
        [TestMethod]
        public void TestDuplicateTs()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.Edi.X12_820_00204.txt";
            var ediStream = CommonHelper.LoadStream(sample, false);
           
            List<EdiItem> ediItems;

            // ACT
            using (var ediReader = new X12Reader(ediStream, "EdiFabric.Rules.X12002040.Rep"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }            

            // ASSERT
            var error = ediItems.OfType<ReaderErrorContext>().SingleOrDefault();
            Assert.IsNotNull(error);
            Assert.IsNotNull(error.MessageErrorContext);
            Assert.IsTrue(error.MessageErrorContext.Codes.Contains(MessageErrorCode.TransactionSetNotSupported));
        }

        [TestMethod]
        public void TestMissingTs()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.Edi.Edifact_INVOIC_D00B.txt";
            var ediStream = CommonHelper.LoadStream(sample, false);

            List<EdiItem> ediItems;

            // ACT
            using (var ediReader = new EdifactReader(ediStream, "EdiFabric.UnitTests"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }

            // ASSERT
            var error = ediItems.OfType<ReaderErrorContext>().SingleOrDefault();
            Assert.IsNotNull(error);
            Assert.IsNotNull(error.MessageErrorContext);
            Assert.IsTrue(error.MessageErrorContext.Codes.Contains(MessageErrorCode.TransactionSetNotSupported));
        }

        [TestMethod]
        public void TestMissingAssembly()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.Edi.Edifact_INVOIC_D00A.txt";
            var ediStream = CommonHelper.LoadStream(sample, false);

            List<EdiItem> ediItems;

            // ACT
            using (var ediReader = new EdifactReader(ediStream, a => Assembly.Load(new AssemblyName("nosuchassembly"))))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }

            // ASSERT
            var error = ediItems.OfType<ReaderErrorContext>().SingleOrDefault();
            Assert.IsNotNull(error);
            Assert.IsNotNull(error.MessageErrorContext);
            Assert.IsTrue(error.MessageErrorContext.Codes.Contains(MessageErrorCode.TransactionSetNotSupported));
        }
    }
}
