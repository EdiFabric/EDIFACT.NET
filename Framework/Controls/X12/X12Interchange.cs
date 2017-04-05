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

namespace EdiFabric.Framework.Controls.X12
{
    /// <summary>
    /// This class represents X12 interchange.
    /// </summary>
    public class X12Interchange : EdiContainer<ISA, IEdiGroup, IEA>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="X12Interchange"/> class.
        /// </summary>
        /// <param name="header">The interchange header.</param>
        public X12Interchange(ISA header)
            : base(header, (gs, i) => new IEA
            {
                NumberOfIncludedGroups_1 = i.ToString(),
                InterchangeControlNumber_2 = header.InterchangeControlNumber_13
            }, Separators.DefaultX12())
        {
            if (header == null) throw new Exception("ISA header is null.");
        }

        /// <summary>
        /// Generates a collection of EDI segments from the header, the items and the trailer.
        /// ComponentDataElement separator (ISA 16) and RepetitionDataElement separator (ISA 11)
        /// are discarded if set in the ISA header. Their values are retrieved from the EDI separators.
        /// </summary>
        /// <param name="separators">The EDI separators.</param>
        /// <returns>The collection of EDI segments.</returns>
        public override IEnumerable<string> GenerateEdi(Separators separators = null)
        {
            var result = new List<string>();
            var currentSeparators = separators ?? Separators.DefaultX12();

            Header.ComponentElementSeparator_16 = currentSeparators.ComponentDataElement.ToString();
            if (Header.InterchangeControlStandardsIdentifier_11 != "U")
                Header.InterchangeControlStandardsIdentifier_11 = currentSeparators.RepetitionDataElement.ToString();

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
