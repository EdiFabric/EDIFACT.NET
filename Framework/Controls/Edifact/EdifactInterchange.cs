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

using System;
using System.Collections.Generic;

namespace EdiFabric.Framework.Controls.Edifact
{
    /// <summary>
    /// This class represents EDIFACT interchange.
    /// </summary>
    public class EdifactInterchange : EdiContainer<UNB, IEdiGroup, UNZ>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdifactInterchange"/> class.
        /// </summary>
        /// <param name="header">The interchange header.</param>
        public EdifactInterchange(UNB header)
            : base(header, (unb, i) => new UNZ
            {
                InterchangeControlCount_1 = i.ToString(),
                InterchangeControlReference_2 = unb.InterchangeControlReference_5
            }, Separators.DefaultEdifact)
        {
            if (header == null) throw new Exception("UNB header is null.");
        }

        /// <summary>
        /// Generates a collection of EDI segments from the header, the items and the trailer.
        /// Automatically generates an UNA segment if the separators are not the default.
        /// </summary>
        /// <param name="separators">The EDI separators.</param>
        /// <returns>The collection of EDI segments.</returns>
        public override IEnumerable<string> GenerateEdi(Separators separators = null)
        {
            var result = new List<string>();
            var currentSeparators = separators ?? Separators.DefaultEdifact;
            if (separators != null)
            {
                result.Add(separators.ToUna());
            }

            result.Add(ToSegmentEdi(Header, currentSeparators));
            foreach (var item in Items)
            {
                result.AddRange(item.GenerateEdi(currentSeparators));
            }
            result.Add(ToSegmentEdi(Trailer, currentSeparators));

            return result;
        }
    }
}
