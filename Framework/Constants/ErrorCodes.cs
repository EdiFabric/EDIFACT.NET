namespace EdiFabric.Framework.Constants
{
    public enum ErrorCodes
    {
        /// <summary>
        /// N/A
        /// </summary>
        Unknown,

        /// <summary>
        /// Invalid Control Structure
        /// Missing ISA
        /// </summary>
        InvalidControlStructure,

        /// <summary>
        /// Invalid Interchange Content
        /// Missing GS
        /// </summary>
        InvalidInterchangeContent,

        /// <summary>
        /// Improper End of File
        /// Missing GE or ISA
        /// </summary>
        ImproperEndOfFile,
    }
}
