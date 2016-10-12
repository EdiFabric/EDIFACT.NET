namespace EdiFabric.Framework.Constants
{
    static class ErrorCodeDescriptions
    {
        public static string ToDescription(this ErrorCodes errorCode)
        {
            switch (errorCode)
            {
                case ErrorCodes.ImproperEndOfFile:
                    return "Missing headers or trailers.";
                case ErrorCodes.InvalidControlStructure:
                    return "Missing UNA, UNB or ISA.";
                case ErrorCodes.InvalidInterchangeContent:
                    return "Missing GS.";
                default:
                    return "Unknown error.";
            }
        }
    }
}
