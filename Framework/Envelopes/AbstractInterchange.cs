using System.Collections.Generic;
using System.Xml.Linq;

namespace EdiFabric.Framework.Envelopes
{
    /// <summary>
    /// This is the abstract class for all EDI interchanges.
    /// </summary>
    public abstract class AbstractInterchange
    {
        /// <summary>
        /// Converts the interchange to EDI message.
        /// </summary>
        /// <param name="context">
        /// The interchange context.
        /// This sets the non format default separators.
        /// </param>
        /// <returns>
        /// The EDI message.
        /// </returns>
        public abstract List<string> ToEdi(InterchangeContext context = null);

        /// <summary>
        /// Serialize the interchange into XML.
        /// </summary>
        /// <returns>
        /// The serialized XML.
        /// </returns>
        public XElement Serialize()
        {
            return EdiHelper.Serialize(this);
        }
    }
}
