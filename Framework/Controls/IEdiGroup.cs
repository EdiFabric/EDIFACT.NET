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

using System.Collections.Generic;

namespace EdiFabric.Framework.Controls
{
    /// <summary>
    /// EDI container interface.
    /// </summary>
    public interface IEdiGroup
    {
        /// <summary>
        /// Generates a collection of EDI strings.
        /// </summary>
        /// <param name="separators">The EDI separators.</param>
        /// <returns>The collection of EDI strings.</returns>
        IEnumerable<string> GenerateEdi(Separators separators);
    }
}
