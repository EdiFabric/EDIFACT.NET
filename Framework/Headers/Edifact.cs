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
using System.Xml.Serialization;

namespace EdiFabric.Framework.Headers
{
    /// <summary>
    /// This class represents the EDIFACT interchange header.
    /// </summary>
    [XmlRoot(Namespace = "www.edifabric.com/edifact")]
    public class S_UNB
    {
        [XmlElement(Order = 0)]
        public C_S001 C_S001 { get; set; }

        [XmlElement(Order = 1)]
        public C_S002 C_S002 { get; set; }

        [XmlElement(Order = 2)]
        public C_S003 C_S003 { get; set; }

        [XmlElement(Order = 3)]
        public C_S004 C_S004 { get; set; }

        [XmlElement(Order = 4)]
        public string D_0020_5 { get; set; }

        [XmlElement(Order = 5)]
        public C_S005 C_S005 { get; set; }

        [XmlElement(Order = 6)]
        public string D_0026_7 { get; set; }

        [XmlElement(Order = 7)]
        public string D_0029_8 { get; set; }

        [XmlElement(Order = 8)]
        public string D_0031_9 { get; set; }

        [XmlElement(Order = 9)]
        public string D_0032_10 { get; set; }

        [XmlElement(Order = 10)]
        public string D_0035_11 { get; set; }
    }

    /// <summary>
    /// This class represents a composite data element referenced in the EDIFACT interchange header.
    /// </summary>
    public class C_S001
    {
        [XmlElement(Order = 0)]
        public string D_0001_1 { get; set; }

        [XmlElement(Order = 1)]
        public string D_0002_2 { get; set; }

        [XmlElement(Order = 2)]
        public string D_0080_3 { get; set; }

        [XmlElement(Order = 3)]
        public string D_0133_4 { get; set; }
    }

    /// <summary>
    /// This class represents a composite data element referenced in the EDIFACT interchange header.
    /// </summary>
    public class C_S002
    {
        [XmlElement(Order = 0)]
        public string D_0004_1 { get; set; }

        [XmlElement(Order = 1)]
        public string D_0007_2 { get; set; }

        [XmlElement(Order = 2)]
        public string D_0008_3 { get; set; }

        [XmlElement(Order = 3)]
        public string D_0042_4 { get; set; }
    }

    /// <summary>
    /// This class represents a composite data element referenced in the EDIFACT interchange header.
    /// </summary>
    public class C_S003
    {
        [XmlElement(Order = 0)]
        public string D_0010_1 { get; set; }

        [XmlElement(Order = 1)]
        public string D_0007_2 { get; set; }

        [XmlElement(Order = 2)]
        public string D_0014_3 { get; set; }

        [XmlElement(Order = 3)]
        public string D_0046_4 { get; set; }
    }

    /// <summary>
    /// This class represents a composite data element referenced in the EDIFACT interchange header.
    /// </summary>
    public class C_S004
    {
        [XmlElement(Order = 0)]
        public string D_0017_1 { get; set; }

        [XmlElement(Order = 1)]
        public string D_0019_2 { get; set; }
    }

    /// <summary>
    /// This class represents a composite data element referenced in the EDIFACT interchange header.
    /// </summary>
    public class C_S005
    {
        [XmlElement(Order = 0)]
        public string D_0022_1 { get; set; }

        [XmlElement(Order = 1)]
        public string D_0025_2 { get; set; }
    }

    /// <summary>
    /// This class represents the EDIFACT group header.
    /// </summary>
    [XmlRoot(Namespace = "www.edifabric.com/edifact")]
    public class S_UNG
    {
        [XmlElement(Order = 0)]
        public string D_0038_1 { get; set; }

        [XmlElement(Order = 1)]
        public C_S006 C_S006 { get; set; }

        [XmlElement(Order = 2)]
        public C_S007 C_S007 { get; set; }

        [XmlElement(Order = 3)]
        public C_S004_2 C_S004_2 { get; set; }

        [XmlElement(Order = 4)]
        public string D_0048_5 { get; set; }

        [XmlElement(Order = 5)]
        public string D_0051_6 { get; set; }

        [XmlElement(Order = 6)]
        public C_S008 C_S008 { get; set; }

        [XmlElement(Order = 7)]
        public string D_0058_8 { get; set; }
    }

    /// <summary>
    /// This class represents a composite data element referenced in the EDIFACT group header.
    /// </summary>
    public class C_S006
    {
        [XmlElement(Order = 0)]
        public string D_0040_1 { get; set; }

        [XmlElement(Order = 1)]
        public string D_0007_2 { get; set; }
    }

    /// <summary>
    /// This class represents a composite data element referenced in the EDIFACT group header.
    /// </summary>
    public class C_S007
    {
        [XmlElement(Order = 0)]
        public string D_0044_1 { get; set; }

        [XmlElement(Order = 1)]
        public string D_0007_2 { get; set; }
    }

    /// <summary>
    /// This class represents a composite data element referenced in the EDIFACT group header.
    /// </summary>
    public class C_S004_2
    {
        [XmlElement(Order = 0)]
        public string D_0017_1 { get; set; }

        [XmlElement(Order = 1)]
        public string D_0019_2 { get; set; }
    }

    /// <summary>
    /// This class represents a composite data element referenced in the EDIFACT group header.
    /// </summary>
    public class C_S008
    {
        [XmlElement(Order = 0)]
        public string D_0052_1 { get; set; }

        [XmlElement(Order = 1)]
        public string D_0054_2 { get; set; }

        [XmlElement(Order = 2)]
        public string D_0057_3 { get; set; }
    }

    /// <summary>
    /// This class represents the EDIFACT group trailer.
    /// </summary>
    [XmlRoot(Namespace = "www.edifabric.com/edifact")]
    public class S_UNE
    {
        [XmlElement(Order = 0)]
        public string D_0060_1 { get; set; }

        [XmlElement(Order = 1)]
        public string D_0048_2 { get; set; }
    }

    /// <summary>
    /// This class represents the EDIFACT interchange trailer.
    /// </summary>
    [XmlRoot(Namespace = "www.edifabric.com/edifact")]
    public class S_UNZ
    {
        [XmlElement(Order = 0)]
        public string D_0036_1 { get; set; }

        [XmlElement(Order = 1)]
        public string D_0020_2 { get; set; }
    }

    /// <summary>
    /// This class represents an EDI EDIFACT group.
    /// </summary>
    /// <typeparam name="T">The type of the messages that this group can contain.</typeparam>
    public class EdifactGroup<T> : EdiContainer<S_UNG, T, S_UNE>, IEdiGroup
    {
        /// <summary>
        ///  Initializes a new instance of the <see cref="EdifactGroup{T}"/> class.
        /// </summary>
        /// <param name="header">The group header.</param>
        public EdifactGroup(S_UNG header)
            : base(header, (ung, i) => new S_UNE
            {
                D_0060_1 = i.ToString(),
                D_0048_2 = ung.D_0048_5
            }, Separators.DefaultSeparatorsEdifact())
        {
        }
    }

    /// <summary>
    /// This class represents an EDI EDIFACT interchange.
    /// </summary>
    public class EdifactInterchange : EdiContainer<S_UNB, IEdiGroup, S_UNZ>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdifactInterchange"/> class.
        /// </summary>
        /// <param name="header">The interchange header.</param>
        public EdifactInterchange(S_UNB header)
            : base(header, (unb, i) => new S_UNZ
            {
                D_0036_1 = i.ToString(),
                D_0020_2 = unb.D_0020_5
            }, Separators.DefaultSeparatorsEdifact())
        {
            if (header == null) throw new ParserException("UNB header is null.");
        }

        /// <summary>
        /// Generates a collection of EDI segments.
        /// </summary>
        /// <param name="separators">The EDI separators.</param>
        /// <returns>The collection of EDI segments.</returns>
        public override IEnumerable<string> GenerateEdi(Separators separators = null)
        {
            var result = new List<string>();
            var currentSeparators = separators ?? Separators.DefaultSeparatorsEdifact();
            if (separators != null)
            {
               result.Add(separators.ToUna()); 
            }

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
