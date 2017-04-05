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
using System.Xml.Serialization;
using EdiFabric.Attributes;

namespace EdiFabric.Framework.Controls
{
    /// <summary>
    /// This class represents X12 interchange header.
    /// </summary>
    public class ISA : IEdiControl
    {
        [D(1)]
        public string AuthorizationInformationQualifier_1 { get; set; }

        [D(2)]
        public string AuthorizationInformation_2 { get; set; }

        [D(3)]
        public string D_746_3 { get; set; }

        [D(4)]
        public string D_747_4 { get; set; }

        [D(5)]
        public string D_704_5 { get; set; }

        [D(6)]
        public string D_705_6 { get; set; }

        [D(7)]
        public string D_704_7 { get; set; }

        [D(8)]
        public string D_706_8 { get; set; }

        [D(9)]
        public string D_373_9 { get; set; }

        [D(10)]
        public string D_337_10 { get; set; }

        [D(11)]
        public string D_726_11 { get; set; }

        [D(12)]
        public string D_703_12 { get; set; }

        [D(13)]
        public string D_709_13 { get; set; }

        [D(14)]
        public string D_749_14 { get; set; }

        [D(15)]
        public string D_748_15 { get; set; }

        [D(16)]
        public string D_701_16 { get; set; }
    }

    /// <summary>
    /// This class represents X12 group header.
    /// </summary>
    [XmlRoot(Namespace = "www.edifabric.com/x12")]
    public class GS : IEdiControl
    {
        [D(1)]
        public string D_479_1 { get; set; }

        [D(2)]
        public string D_142_2 { get; set; }

        [D(3)]
        public string D_124_3 { get; set; }

        [D(4)]
        public string D_29_4 { get; set; }

        [D(5)]
        public string D_30_5 { get; set; }

        [D(6)]
        public string D_28_6 { get; set; }

        [D(7)]
        public string D_455_7 { get; set; }

        [D(8)]
        public string D_480_8 { get; set; }
    }

    /// <summary>
    /// This class represents X12 group trailer.
    /// </summary>
    [XmlRoot(Namespace = "www.edifabric.com/x12")]
    public class GE : IEdiControl
    {
        [D(1)]
        public string D_97_1 { get; set; }

        [D(2)]
        public string D_28_2 { get; set; }
    }

    /// <summary>
    /// This class represents X12 interchange trailer.
    /// </summary>
    [XmlRoot(Namespace = "www.edifabric.com/x12")]
    public class IEA : IEdiControl 
    {
        [D(1)]
        public string D_405_1 { get; set; }

        [D(2)]
        public string D_709_2 { get; set; }
    }

    /// <summary>
    /// This class represents X12 technical acknowledgment.
    /// </summary>
    [XmlRoot(Namespace = "www.edifabric.com/x12")]
    public class TA1 : IEdiControl
    {
        [D(1)]
        public string D_TA101_1 { get; set; }

        [D(2)]
        public string D_TA102_2 { get; set; }

        [D(3)]
        public string D_TA103_3 { get; set; }

        [D(4)]
        public string D_TA104_4 { get; set; }

        [D(5)]
        public string D_TA105_5 { get; set; }
    }  

    /// <summary>
    /// This class represents X12 group.
    /// Each group can only contain messages of the same type.
    /// </summary>
    /// <typeparam name="T">The type of the messages that this group can contain.</typeparam>
    public class X12Group<T> : EdiContainer<GS, T, GE>, IEdiGroup
    {
        /// <summary>
        ///  Initializes a new instance of the <see cref="X12Group{T}"/> class.
        /// </summary>
        /// <param name="header">The group header.</param>
        public X12Group(GS header)
            : base(header, (gs, i) => new GE
            {
                D_97_1 = i.ToString(),
                D_28_2 = gs.D_28_6
            }, Separators.DefaultX12())
        {
        }
    }

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
                D_405_1 = i.ToString(),
                D_709_2 = header.D_709_13
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

            Header.D_701_16 = currentSeparators.ComponentDataElement.ToString();
            if (Header.D_726_11 != "U")
                Header.D_726_11 = currentSeparators.RepetitionDataElement.ToString();

            result.AddRange(ToEdi(Header, currentSeparators));
            foreach (var item in Items)
            {
                result.AddRange(item.GenerateEdi(currentSeparators));
            }
            result.AddRange(ToEdi(Trailer, currentSeparators));

            return result;
        }
    }
}
