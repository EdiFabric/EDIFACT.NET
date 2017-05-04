using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using EdiFabric.Framework.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EdiFabric.UnitTests
{
    //[TestClass]
    //public class UnitTestsExceptionSerialization
    //{
    //    [TestMethod]
    //    public void TestSerializationOfDataElementErrorContext()
    //    {
    //        var context = new DataElementErrorContext("Name", 66, ErrorCodes.ComponentDataElementsTooMany, 32, 96, "876");

    //        BinaryFormatter formatter = new BinaryFormatter();
    //        MemoryStream stream = new MemoryStream();
    //        formatter.Serialize(stream, context);
    //        stream.Seek(0, SeekOrigin.Begin);
    //        var copy = (DataElementErrorContext)formatter.Deserialize(stream);

    //        AssertTwoDataElementErrorsAreEqual(context, copy);
    //    }
        
    //    [TestMethod]
    //    public void TestSerializationOfSegmentErrorContext()
    //    {
    //        var context = new SegmentErrorContext("Name", 66, ErrorCodes.ComponentDataElementsTooMany);
    //        context.Add(ErrorCodes.DataElementsTooMany);
    //        context.Add("Name1", 66, ErrorCodes.ComponentDataElementsTooMany, 32, 96, "876");
    //        context.Add("Name2", 88, ErrorCodes.ControlNumberNotMatching, 16, 48, "438");


    //        BinaryFormatter formatter = new BinaryFormatter();
    //        MemoryStream stream = new MemoryStream();
    //        formatter.Serialize(stream, context);
    //        stream.Seek(0, SeekOrigin.Begin);
    //        var copy = (SegmentErrorContext)formatter.Deserialize(stream);

    //        AssertTwoSegmentErrorsAreEqual(context, copy);
    //    }
        
    //    [TestMethod]
    //    public void TestSerializationOfMessageErrorContext()
    //    {
    //        var segContext1 = new SegmentErrorContext("Name", 66, ErrorCodes.ComponentDataElementsTooMany);
    //        segContext1.Add(ErrorCodes.DataElementsTooMany);
    //        segContext1.Add("Name1", 66, ErrorCodes.ComponentDataElementsTooMany, 32, 96, "876");
    //        segContext1.Add("Name2", 88, ErrorCodes.ControlNumberNotMatching, 16, 48, "438");

    //        var segContext2 = new SegmentErrorContext("Name2", 32, ErrorCodes.ComponentDataElementsTooMany);
    //        segContext2.Add(ErrorCodes.DataElementsTooMany);
    //        segContext2.Add("Name1", 66, ErrorCodes.ComponentDataElementsTooMany, 16, 48, "476");
    //        segContext2.Add("Name2", 88, ErrorCodes.ControlNumberNotMatching, 5, 5, "200");

    //        var msgContext = new MessageErrorContext("MsgError", "111111");
    //        msgContext.Add(ErrorCodes.DataElementsTooMany);
    //        msgContext.Add(segContext1);
    //        msgContext.Add(segContext2);


    //        BinaryFormatter formatter = new BinaryFormatter();
    //        MemoryStream stream = new MemoryStream();
    //        formatter.Serialize(stream, msgContext);
    //        stream.Seek(0, SeekOrigin.Begin);
    //        var copy = (MessageErrorContext)formatter.Deserialize(stream);

    //        AssertTwoMessageErrorsAreEqual(msgContext, copy);
    //    }

    //    [TestMethod]
    //    public void TestSerializationOfParsingException()
    //    {
    //        var segContext1 = new SegmentErrorContext("Name", 66, ErrorCodes.ComponentDataElementsTooMany);
    //        segContext1.Add(ErrorCodes.DataElementsTooMany);
    //        segContext1.Add("Name1", 66, ErrorCodes.ComponentDataElementsTooMany, 32, 96, "876");
    //        segContext1.Add("Name2", 88, ErrorCodes.ControlNumberNotMatching, 16, 48, "438");

    //        var segContext2 = new SegmentErrorContext("Name2", 32, ErrorCodes.ComponentDataElementsTooMany);
    //        segContext2.Add(ErrorCodes.DataElementsTooMany);
    //        segContext2.Add("Name1", 66, ErrorCodes.ComponentDataElementsTooMany, 16, 48, "476");
    //        segContext2.Add("Name2", 88, ErrorCodes.ControlNumberNotMatching, 5, 5, "200");

    //        var msgContext = new MessageErrorContext("MsgError", "111111");
    //        msgContext.Add(ErrorCodes.DataElementsTooMany);
    //        msgContext.Add(segContext1);
    //        msgContext.Add(segContext2);

    //        ParsingException ex;

    //        try
    //        {
    //            throw new ParsingException(ErrorCodes.SegmentWithErrors, "message", "HL*1*0*20*1~", msgContext);
    //        }
    //        catch (ParsingException thrown)
    //        {
    //            ex = thrown;
                
    //        }

    //        BinaryFormatter formatter = new BinaryFormatter();
    //        MemoryStream stream = new MemoryStream();
    //        formatter.Serialize(stream, ex);
    //        stream.Seek(0, SeekOrigin.Begin);
    //        var copy = (ParsingException)formatter.Deserialize(stream);
    //        //var copy = new ParsingException(ErrorCodes.ControlNumberNotMatching, "message2");
            
    //        AssertTwoParsingExceptionsAreEqual(ex, copy);
    //    }
        
    //    void AssertTwoDataElementErrorsAreEqual(DataElementErrorContext context, DataElementErrorContext other)
    //    {
    //        Assert.AreEqual(context.Code, other.Code);
    //        Assert.AreEqual(context.ComponentPosition, other.ComponentPosition);
    //        Assert.AreEqual(context.Name, other.Name);
    //        Assert.AreEqual(context.Position, other.Position);
    //        Assert.AreEqual(context.RepetitionPosition, other.RepetitionPosition);
    //        Assert.AreEqual(context.Value, other.Value);
    //    }

    //    void AssertTwoSegmentErrorsAreEqual(SegmentErrorContext context, SegmentErrorContext other)
    //    {
    //        Assert.AreEqual(context.Name, other.Name, "Name");
    //        Assert.AreEqual(context.Position, other.Position, "Position");
    //        Assert.AreEqual(context.Codes.Count, other.Codes.Count, "Error Code Count");

    //        var contextCodesArray = other.Codes.ToArray();
    //        var copyCodesArray = context.Codes.ToArray();
    //        for (int i = 0; i < context.Codes.Count; i++)
    //        {
    //            Assert.AreEqual(copyCodesArray[i], contextCodesArray[i]);
    //        }

    //        Assert.AreEqual(context.Errors.Count, other.Errors.Count);
    //        var copyErrorsArray = context.Errors.ToArray();
    //        var contextErrorsArray = other.Errors.ToArray();

    //        for (int i = 0; i < context.Errors.Count; i++)
    //        {
    //            AssertTwoDataElementErrorsAreEqual(contextErrorsArray[i], copyErrorsArray[i]);
    //        }
    //    }

    //    void AssertTwoMessageErrorsAreEqual(MessageErrorContext context, MessageErrorContext other)
    //    {
    //        Assert.AreEqual(context.Name, other.Name, "Name");
    //        Assert.AreEqual(context.ControlNumber, other.ControlNumber, "Position");

    //        Assert.AreEqual(context.Codes.Count, other.Codes.Count);
    //        var contextCodesArray = other.Codes.ToArray();
    //        var copyCodesArray = context.Codes.ToArray();
    //        for (int i = 0; i < context.Codes.Count; i++)
    //        {
    //            Assert.AreEqual(copyCodesArray[i], contextCodesArray[i]);
    //        }

    //        Assert.AreEqual(context.Errors.Count, other.Errors.Count);
    //        var copyErrorsArray = context.Errors.ToArray();
    //        var contextErrorsArray = other.Errors.ToArray();

    //        for (int i = 0; i < context.Errors.Count; i++)
    //        {
    //            AssertTwoSegmentErrorsAreEqual(contextErrorsArray[i], copyErrorsArray[i]);
    //        }
    //    }
        
    //    void AssertTwoParsingExceptionsAreEqual(ParsingException ex, ParsingException other)
    //    {
    //        Assert.AreEqual(ex.ErrorCode, other.ErrorCode);
    //        Assert.AreEqual(ex.FailedLine, other.FailedLine);
    //        Assert.AreEqual(ex.ErrorContext, other.ErrorContext);
    //        Assert.AreEqual(ex.Message, other.Message);
    //        Assert.AreEqual(ex.StackTrace, other.StackTrace);
    //    }
    //}
}
