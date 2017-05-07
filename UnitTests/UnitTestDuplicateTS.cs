using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Reflection;
using EdiFabric.Framework;
using EdiFabric.Framework.Readers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EdiFabric.UnitTests
{
    [TestClass]
    public class UnitTestDuplicateTs
    {
        [TestMethod]
        public void TestDuplicateTs()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.Edi.X12_810_00204.txt";
            var ediStream = Helper.LoadStream(sample, false);
           
            List<object> ediItems;

            // ACT
            using (var ediReader = new X12Reader(ediStream, "EdiFabric.Rules.DuplicateTS"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }            

            // ASSERT
            var error = ediItems.OfType<ParsingException>().SingleOrDefault();
            Assert.IsNotNull(error);
            Assert.IsTrue(error.ErrorCode == ErrorCode.DuplicateTypeFound);  
        }

        [TestMethod]
        public void TestMissingTs()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.Edi.Edifact_INVOIC_D00B.txt";
            var ediStream = Helper.LoadStream(sample, false);

            List<object> ediItems;

            // ACT
            using (var ediReader = new EdifactReader(ediStream, "EdiFabric.Rules.DuplicateTS"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }

            // ASSERT
            var error = ediItems.OfType<ParsingException>().SingleOrDefault();
            Assert.IsNotNull(error);
            Assert.IsTrue(error.ErrorCode == ErrorCode.UnexpectedMessage);  
        }

        [TestMethod]
        public void TestMissingAssembly()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.Edi.Edifact_INVOIC_D00A.txt";
            var ediStream = Helper.LoadStream(sample, false);

            List<object> ediItems;

            // ACT
            using (var ediReader = new EdifactReader(ediStream, a => Assembly.Load("nosuchassembly")))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }

            // ASSERT
            var error = ediItems.OfType<ParsingException>().SingleOrDefault();
            Assert.IsNotNull(error);
            Assert.IsTrue(error.ErrorCode == ErrorCode.RulesAssemblyNotFound);  
        }

        [TestMethod]
        public void TestLog()
        {
            // ARRANGE
            const string sample = "EdiFabric.UnitTests.Edi.Edifact_INVOIC_D00A.txt";
            var ediStream = Helper.LoadStream(sample, false);
            var logFile = ConfigurationManager.AppSettings["EdiFabric.LogFile"];

            List<object> ediItems;

            // ACT
            using (var ediReader = new EdifactReader(ediStream, "EdiFabric.Rules.DuplicateTS"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }
            
            // ASSERT
            Assert.IsNull(ediItems.OfType<ParsingException>().SingleOrDefault());
            Assert.IsNotNull(logFile);
            Assert.IsTrue(File.Exists(logFile)); 
        }
    }
}
