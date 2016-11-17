namespace EdiFabric.Framework.Exceptions
{
    static class ErrorCodeDescriptions
    {
        public static string ToDescription(this ErrorCodes errorCode)
        {
            switch (errorCode)
            {
                case ErrorCodes.ComponentDataElementsTooMany:
                    return "Too many component data elements.";
                case ErrorCodes.DataElementLengthWrong:
                    return "Data element has incorrect length.";
                case ErrorCodes.DataElementTooLong:
                    return "Data element is too long.";
                case ErrorCodes.DataElementTooShort:
                    return "Data element is too short.";
                case ErrorCodes.DataElementValueWrong:
                    return "Invalid code value.";
                case ErrorCodes.DataElementsTooMany:
                    return "Too many data elements.";
                case ErrorCodes.ImproperEndOfFile:
                    return "Unprocessed segments found before the end of the file.";
                case ErrorCodes.InvalidControlStructure:
                    return "Interchange control structure is invalid.";
                case ErrorCodes.RequiredMissing:
                    return "Mandatory item is missing.";
                case ErrorCodes.RulesAssemblyNameNotSet:
                    return "The rules assembly is not set.";
                case ErrorCodes.Unexpected:
                    return "Item exceeds maximum use.";
                case ErrorCodes.UnexpectedMessage:
                    return "Transaction set is not supported.";
                case ErrorCodes.UnexpectedSegment:
                    return "Segment is not expected at this position.";
                case ErrorCodes.UnrecognizedSegment:
                    return "Segment is not in defined transaction set.";
                case ErrorCodes.ValidationFailed:
                    return "Message validation failed.";
                case ErrorCodes.MessageTrailerMissing:
                    return "Transaction set trailer missing.";
                case ErrorCodes.InvalidTransactionSetIdentifier:
                    return "Missing or invalid transaction set identifier.";
                case ErrorCodes.ControlNumberNotMatching:
                    return "Transaction set control number in header and trailer do not match.";
                case ErrorCodes.SegmentsCountNotMatching:
                    return "Number of included segments does not match actual count.";
                case ErrorCodes.InvalidInterchangeContent:
                    return "Invalid interchange content acknowledgment.";
                case ErrorCodes.DuplicateMessageControlNumber:
                    return "Invalid transaction set control number.";
                case ErrorCodes.SegmentWithErrors:
                    return "Segment has data element errors.";
                case ErrorCodes.MessageWithErrors:
                    return "One or more segments in error.";
            }

            return errorCode.ToString();
        }
    }
}
