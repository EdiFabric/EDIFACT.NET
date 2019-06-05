namespace EdiFabric.Templates.EdifactD96A
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Annotations.Validation;
    using EdiFabric.Core.Model.Edi;
    using EdiFabric.Core.Model.Edi.Edifact;
    using System.Xml.Serialization;

    /// <summary>
    /// Message function, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",LL,PP,")]
    public class EDIFACT_ID_1225_PartnerA
    {
    }

}
