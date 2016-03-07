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
using EdiFabric.Framework.Messages;

namespace EdiFabric.Framework.Envelopes.X12
{
    /// <summary>
    /// This class represents the X12 interchange header.
    /// </summary>
    [XmlRoot(Namespace = Namespaces.X12, IsNullable = false)]
    public class S_ISA
    {
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string D_744_1 { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string D_745_2 { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string D_746_3 { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string D_747_4 { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string D_704_5 { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string D_705_6 { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public string D_704_7 { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public string D_706_8 { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public string D_373_9 { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public string D_337_10 { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public string D_726_11 { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
        public string D_703_12 { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Order = 12)]
        public string D_709_13 { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Order = 13)]
        public string D_749_14 { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Order = 14)]
        public string D_748_15 { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Order = 15)]
        public string D_701_16 { get; set; }
    }

    /// <summary>
    /// This class represents a logical group.
    /// </summary>
    [XmlRoot("GROUP", Namespace = Namespaces.X12)]
    public class Group
    {
        public Group()
        {
            Ge = new S_GE();
            Messages = new List<Message>();
            Gs = new S_GS();
        }

        [XmlElement("S_GS", Order = 0)]
        public S_GS Gs { get; set; }

        [XmlArray("MESSAGES", Order = 1)]
        [XmlArrayItem("MESSAGE", IsNullable = false)]
        public List<Message> Messages { get; set; }

        [XmlElement("S_GE", Order = 2)]
        public S_GE Ge { get; set; }
    }

    /// <summary>
    /// This class represents the X12 group header.
    /// </summary>
    [System.Xml.Serialization.XmlRootAttribute(Namespace = Namespaces.X12, IsNullable = false)]
    public class S_GS
    {
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string D_479_1 { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string D_142_2 { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string D_124_3 { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string D_29_4 { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string D_30_5 { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string D_28_6 { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public string D_455_7 { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public string D_480_8 { get; set; }
    }

    /// <summary>
    /// This class represents the X12 group trailer.
    /// </summary>
    [System.Xml.Serialization.XmlRootAttribute(Namespace = Namespaces.X12, IsNullable = false)]
    public class S_GE
    {
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string D_97_1 { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string D_28_2 { get; set; }
    }

    /// <summary>
    /// This class represents the X12 interchange trailer.
    /// </summary>
    [System.Xml.Serialization.XmlRootAttribute(Namespace = Namespaces.X12, IsNullable = false)]
    public class S_IEA
    {
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string D_405_1 { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string D_709_2 { get; set; }
    }
}
