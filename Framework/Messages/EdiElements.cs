//---------------------------------------------------------------------
// This file is part of ediFabric
//
// Copyright (c) ediFabric. All rights reserved.
//
// THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY
// KIND, WHETHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
// IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR
// PURPOSE.
//---------------------------------------------------------------------

namespace EdiFabric.Framework.Messages
{
    /// <summary>
    /// This class represents the names EDI data elements important for the parsing process.
    /// </summary>
    class EdiElements
    {
        /// <summary>
        /// UNH context.
        /// </summary>
        public const string UnhContext = "C_S009";

        /// <summary>
        /// UNH tag.
        /// </summary>
        public const string UnhTag = "D_0065_1";

        /// <summary>
        /// UNH edition.
        /// </summary>
        public const string UnhEdition = "D_0052_2";

        /// <summary>
        /// UNH release.
        /// </summary>
        public const string UnhRelease = "D_0054_3";

        /// <summary>
        /// ST tag.
        /// </summary>
        public const string StTag = "D_143_1";

        /// <summary>
        /// ST tag for HIPAA.
        /// </summary>
        public const string StTagHipaa = "D_ST01";

        /// <summary>
        /// GS version.
        /// </summary>
        public const string GsVersion = "D_480_8";
    }
}
